namespace NewFeaturesDemo
{
    public class UnmanagedConstructedTypes
    {
        public void UseMethod()
        {
            MoreSkills(1);

            // since 8.0
            MoreSkills(new GenericStruct<int>());

            // ERROR: the generic parameter of GenericStruct is not unmanaged
            //MoreSkills(new GenericStruct<string>());
        }

        private void MoreSkills<T>(T instance)
            where T : unmanaged
        {
        }

        public struct GenericStruct<T>
        {
            public T Value { get; set; }
        }
    }
}
