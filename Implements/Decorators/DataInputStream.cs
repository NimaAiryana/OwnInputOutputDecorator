using OwnInputOutputDecorator.Abstractions;

namespace OwnInputOutputDecorator.Implements.Decorators
{
    public class DataInputStream : FilterInputStream
    {
        public DataInputStream(InputStream inputStream) : base(inputStream)
        {
        }
    }
}
