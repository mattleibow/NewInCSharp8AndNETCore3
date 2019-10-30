#nullable enable

namespace NewFeaturesDemo
{
    public class NullCoalescingAssignment
    {
        public void Demonstrate()
        {
            string? name = null;
            int? age = null;

            // since 1.0
            name = name ?? "Matthew";
            if (age == null)
                age = 26;

            // since 8.0
            name ??= "Matthew";
            age ??= 26;
        }
    }
}
