using System;

namespace Ex03.GarageLogic
{
    public class ValueOutOfRangeException : Exception
    {
        private readonly float r_MinimumValue;
        private readonly float r_MaximumValue;

        public ValueOutOfRangeException(float i_MinimumValue, float i_MaximumValue, string i_Message = null) 
            : base(i_Message ?? string.Format($"An error occured, the number should be between {i_MinimumValue} to {i_MaximumValue}"))
        {
            r_MinimumValue = i_MinimumValue;
            r_MaximumValue = i_MaximumValue;
        }
    }
}
