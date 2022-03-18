using OwnInputOutputDecorator.Abstractions;

namespace OwnInputOutputDecorator.Implements.Inputs
{
    public class ButtonInputStream : InputStream
    {
        public ButtonInputStream(string input) : base(input)
        {
            _input = $"You did click on me: {input}";
        }
    }
}
