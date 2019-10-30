using System;
using System.Threading.Tasks;

namespace NewFeaturesDemo
{
    public class AsynchronousDisposal
    {
        public async Task StartDisposal()
        {
            await using var instance = new UsefulObject();

            instance.EmptyMethod();
        }

        public class UsefulObject : IAsyncDisposable
        {
            public void EmptyMethod()
            {
                throw new NotImplementedException();
            }

            public async ValueTask DisposeAsync()
            {
                await Task.Delay(100);
            }
        }
    }
}
