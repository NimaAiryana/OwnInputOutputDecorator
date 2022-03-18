using OwnInputOutputDecorator.Abstractions;

namespace OwnInputOutputDecorator.Implements.Decorators
{
    public class LowerCaseInputStream : FilterInputStream
    {
        public LowerCaseInputStream(InputStream inputStream) : base(inputStream)
        {
            _input = _input.ToLower();
        }
    }
}
