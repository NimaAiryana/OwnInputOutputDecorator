using OwnInputOutputDecorator.Abstractions;

namespace OwnInputOutputDecorator.Implements.Inputs
{
    public class StringBufferInputStream : InputStream
    {
        public StringBufferInputStream(string input) : base(input)
        {
        }
    }
}
