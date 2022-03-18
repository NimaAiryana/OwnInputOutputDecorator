using OwnInputOutputDecorator.Abstractions;

namespace OwnInputOutputDecorator.Implements.Inputs
{
    public class ButtonInputStream : InputStream
    {
        public ButtonInputStream(string input) : base(input)
        {
        }
    }
}
