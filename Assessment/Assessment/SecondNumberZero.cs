using System.Runtime.Serialization;

namespace Program
{
    [Serializable]
    internal class SecondNumberZero : Exception
    {
        public SecondNumberZero()
        {
        }

        public SecondNumberZero(string? message) : base(message)
        {
        }

        public SecondNumberZero(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected SecondNumberZero(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}