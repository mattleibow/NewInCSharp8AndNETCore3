namespace NewFeaturesDemo
{
    public class InterfaceMemberVisibility
    {
        public interface ISpecialInterface
        {
            public string GetName();

            protected int GetAge();

            internal int GetFavouriteNumber();

            private string GetPetName() => "unknown";

            public abstract string GetCarBrand();

            public virtual int GetCarCount() => 0;
        }

        public interface IMoreSpecialInterface : ISpecialInterface
        {
            public object InterfaceMethod() => GetAge();
        }

        public class SpecialConcrete : ISpecialInterface
        {
            public string GetName() => "Matthew";

            int ISpecialInterface.GetAge() => 26;

            int ISpecialInterface.GetFavouriteNumber() => 42;

            public string GetCarBrand() => "bmw";

            public int GetCarCount() => 1;
        }

        public void SpecialMethod(ISpecialInterface feature)
        {
        }
    }
}
