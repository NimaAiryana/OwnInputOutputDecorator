using OwnInputOutputDecorator.Abstractions;

namespace OwnInputOutputDecorator.Implements.Inputs
{
    public class ByteArrayInputStream : InputStream
    {
        public ByteArrayInputStream(string input) : base(input)
        {
        }
    }
}
