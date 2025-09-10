using Bonsai;
using System;
using System.ComponentModel;
using System.Reactive.Linq;
using System.Collections.Generic;
using Bonsai.Sleap;
using Bonsai.Reactive;          
using OpenCV.Net; // bc ElementIndex ouputs an OpenCV.Net.IplImage when indexing video frames           

public class BodyPart
{
    public int Frame { get; set; }
    public string PartName { get; set; }
    public float X { get; set; }
    public float Y { get; set; }
    public float Confidence { get; set; }

    public override string ToString() // override default ToString() behavior to display BodyPart information in the Bonsai TextVisualiser
    {
        return "Frame=" + Frame +
            " PartName=" + PartName +
            " X=" + X.ToString("F2") +
            " Y=" + Y.ToString("F2") +
            " Conf=" + Confidence.ToString("F2");
    }
}

[Combinator]
[Description("Takes as input a zipped Pose and ElementIndex and outputs (Frame, PartName, X, Y, Confidence) for each bodyPart in the Pose.")]
[WorkflowElementCategory(ElementCategory.Transform)]
public class ExtractBodyPartPositions
{
    public IObservable<BodyPart> Process(
        IObservable<Tuple<ElementIndex<IplImage>, Pose>> source)
    {
        return source.SelectMany(items =>
        {
            int frame = items.Item1.Index;  
            Pose pose = items.Item2;

            var bodyPartPositions = new List<BodyPart>(pose.Count);
            foreach (var bodyPart in pose)
            {
                bodyPartPositions.Add(new BodyPart
                {
                    Frame = frame,
                    PartName = bodyPart.Name,
                    X = bodyPart.Position.X,
                    Y = bodyPart.Position.Y,
                    Confidence = bodyPart.Confidence
                });
            }
            return bodyPartPositions;
        });
    }
}