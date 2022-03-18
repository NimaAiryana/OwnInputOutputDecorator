namespace OwnInputOutputDecorator.Abstractions
{
    public abstract class FilterInputStream : InputStream
    {
        private readonly InputStream _inputStream;

        public FilterInputStream(InputStream inputStream) : base(inputStream.Read()) => _inputStream = inputStream;
    }
}
