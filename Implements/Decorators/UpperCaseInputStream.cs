using OwnInputOutputDecorator.Abstractions;

namespace OwnInputOutputDecorator.Implements.Decorators
{
    public class UpperCaseInputStream : FilterInputStream
    {
        public UpperCaseInputStream(InputStream inputStream) : base(inputStream)
        {
            _input = _input.ToUpper();
        }
    }
}
