using OwnInputOutputDecorator.Abstractions;

namespace OwnInputOutputDecorator.Implements.Decorators
{
    public class BufferInputStream : FilterInputStream
    {
        public BufferInputStream(InputStream inputStream) : base(inputStream)
        {
        }
    }
}
