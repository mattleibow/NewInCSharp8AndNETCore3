using System.IO;

namespace NewFeaturesDemo
{
    // since 8.0
    public class DisposableRefStructs
    {
        // ERROR: ref structs only live in the stack
        //private DisposableStruct inClass;

        public void TryDisposing()
        {
            // we can create and dispose structs
            using (var instance = new DisposableStruct())
            {
                DoSomethingSmart(instance);
            }
        }

        private void DoSomethingSmart(DisposableStruct instance)
        {
            var size = instance.FileSize;
        }

        public ref struct DisposableStruct
        {
            private FileStream filestream;

            public DisposableStruct(string file)
            {
                filestream = File.OpenRead(file);
            }

            public long FileSize => filestream.Length;

            // no need for the IDisposable interface
            public void Dispose()
            {
                filestream.Dispose();
            }
        }
    }
}
