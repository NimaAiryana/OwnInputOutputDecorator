using OwnInputOutputDecorator.Abstractions;

namespace OwnInputOutputDecorator.Implements.Decorators
{
    public class DoubleQoutesInputStream : FilterInputStream
    {
        public DoubleQoutesInputStream(InputStream inputStream) : base(inputStream)
        {
            _input = $"\"{_input}\"";
        }
    }
}
