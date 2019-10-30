using System;

namespace NewFeaturesDemo
{
    public class StackallocInNestedExpressions
    {
        public void Allocate()
        {
            // since 7.2
            Span<int> separate = stackalloc[] { 1, 2, 3 };
            ShowOff(separate);

            // since 8.0
            ShowOff(stackalloc[] { 1, 2, 3 });
        }

        private void ShowOff(Span<int> values)
        {
        }
    }
}
