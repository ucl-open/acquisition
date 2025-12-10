using Bonsai;
using System;
using System.ComponentModel;

namespace UclOpen.Core
{
    [Combinator]
    [Description("Formats a date time into a string with no illegal path characters.")]
    [WorkflowElementCategory(ElementCategory.Transform)]
    public class FormatDate
    {
        public IObservable<string> Process(IObservable<DateTime> source);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public Type GetType();
        public override string ToString();
    }
}