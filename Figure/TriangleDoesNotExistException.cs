using System.Runtime.Serialization;

namespace Figure
{
    [Serializable]
    internal class TriangleDoesNotExistException : Exception
    {
        public TriangleDoesNotExistException()
        {
        }

        public TriangleDoesNotExistException(string? message) : base(message)
        {
        }

        public TriangleDoesNotExistException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected TriangleDoesNotExistException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}