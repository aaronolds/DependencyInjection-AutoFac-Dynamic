using System;

namespace DependencyInjection.Transitions
{
    public class ATransition : ITransition
    {
        public ATransition(int intProperty, string stringProperty, DateTime dateTimeProperty)
        {
            this.IntProperty = intProperty;
            this.StringProperty = stringProperty;
            this.DateTimeProperty = dateTimeProperty;

        }
        public int IntProperty { get; }
        public string StringProperty { get; }
        public DateTime DateTimeProperty { get; }

        public override string ToString()
        {
            return $"IntProperty: {IntProperty}\tStringProperty: {StringProperty}\tDateTimeProperty:{DateTimeProperty:mm/dd/yyyy}";
        }
    }
}