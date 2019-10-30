#nullable enable

namespace NewFeaturesDemo
{
    // since 8.0
    public class NullableReferenceTypes
    {
        public void Demonstrate(UsefulObject instance)
        {
            // get it or throw
            int justGetIt = instance.Name!.Length;

            // get it or null
            int? tryGetIt = instance.Name?.Length;

            // try get it or use 0
            int fixIt = instance.Name?.Length ?? 0;

            if (instance.Name == null)
                return;

            // at this point, Name can't be null
            int magic = instance.Name.Length;
        }

        public class UsefulObject
        {
            public string? Name { get; set; }
        }
    }
}
