using System.Collections.Generic;
using System.IO;

namespace Algs
{
    public class In
    {
        public static IEnumerable<int> ReadInts(string filePath) {
            using (TextReader reader = File.OpenText(filePath))
            {
                string lastLine;
                while ((lastLine = reader.ReadLine()) != null)
                {
                    // ленивая загрузка данных
                    yield return int.Parse(lastLine);
                }
            }
        }
    }
}
