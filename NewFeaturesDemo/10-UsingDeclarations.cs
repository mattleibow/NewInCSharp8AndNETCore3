using System.IO;

namespace NewFeaturesDemo
{
    public class UsingDeclarations
    {
        public void OldMethod()
        {
            using (var stream = File.OpenRead("filename.txt"))
            {
                var length = stream.Length;
            }
        }

        public void NewMethod()
        {
            using var stream = File.OpenRead("filename.txt");

            var length = stream.Length;

            // dispose stream
        }
    }
}
