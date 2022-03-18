namespace OwnInputOutputDecorator.Abstractions
{
    public abstract class InputStream
    {
        protected string _input;

        public InputStream(string input)
        {
            _input = input;
        }

        public string Read() => _input;

        public void Write() => Console.WriteLine(_input);
    }
}
