using OwnInputOutputDecorator.Abstractions;

namespace OwnInputOutputDecorator.Implements.Inputs
{
    public class FileInputStream : InputStream
    {
        public FileInputStream(string input) : base(input)
        {
        }
    }
}
