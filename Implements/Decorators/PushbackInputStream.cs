using OwnInputOutputDecorator.Abstractions;

namespace OwnInputOutputDecorator.Implements.Decorators
{
    public class PushbackInputStream : FilterInputStream
    {
        public PushbackInputStream(InputStream inputStream) : base(inputStream)
        {
        }
    }
}
