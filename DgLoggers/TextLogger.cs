using System.Diagnostics;

namespace DgLoggers
{
    public class TextLogger : ITextLogger
    {
        public void Log(string text)
        {
            Debug.WriteLine(text);
        }
    }
}
