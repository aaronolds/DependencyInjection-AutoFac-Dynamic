using System;

namespace DependencyInjection.Transitions
{
    public interface ITransition
    {
        public int IntProperty { get; }
        public string StringProperty { get; }
        public DateTime DateTimeProperty { get; }
    }
}