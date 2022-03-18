using OwnInputOutputDecorator.Abstractions;

namespace OwnInputOutputDecorator.Implements.Decorators
{
    public class InflatorInputStream : FilterInputStream
    {
        public InflatorInputStream(InputStream inputStream) : base(inputStream)
        {
        }
    }
}
