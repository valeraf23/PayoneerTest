using System;

namespace PayoneerTest.Helpers.GenerationAttributes
{
    public class GenerationAttribute : Attribute
    {
        public int Length;

        public GenerationAttribute()
        {
            Length = 7;
        }

        public GenerationAttribute(int length)
        {
            Length = length;
        }
    }
}