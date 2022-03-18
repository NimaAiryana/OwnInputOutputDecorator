using OwnInputOutputDecorator.Abstractions;

namespace OwnInputOutputDecorator.Implements.Decorators
{
    public class ZipInputStream : InflatorInputStream
    {
        public ZipInputStream(InputStream inputStream) : base(inputStream)
        {
        }
    }
}
