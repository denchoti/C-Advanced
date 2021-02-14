using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExercises
{
    class Box<T>
    {
        public Box(T value)
        {
            this.Value = value;
        }

        public T Value { get; private set; }

        public override string ToString()
        {
            Type valueType = Value.GetType();
            string valueTypeFullName = valueType.FullName;
           

            return $"{valueTypeFullName}: {Value}";
        }
    }
}
