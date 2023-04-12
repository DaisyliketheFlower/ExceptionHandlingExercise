using System;
using System.Runtime.Serialization;

namespace ExceptionHandlingExercise
{
    [Serializable]
    internal class FormatE : Exception
    {
        public FormatE()
        {
        }

        public FormatE(string message) : base(message)
        {
        }

        public FormatE(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FormatE(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}