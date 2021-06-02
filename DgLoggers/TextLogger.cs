using System.Diagnostics;

namespace DgLoggers
{
    public class TextLogger
    {
        public void Log(string text)
        {
            Debug.WriteLine(text);
        }
    }
}
