using Bonsai;
using System;
using System.ComponentModel;

namespace UclOpen.Core
{
    [Combinator]
    [Description("Selects the substring preceding the first occurrence of the specified separator.")]
    [WorkflowElementCategory(ElementCategory.Transform)]
    public class StripSubstring
    {
        public string Separator { get; set; }
        
        public IObservable<string> Process(IObservable<string> source);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public Type GetType();
        public override string ToString();
    }
}