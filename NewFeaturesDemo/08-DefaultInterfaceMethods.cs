namespace NewFeaturesDemo
{
    public class DefaultInterfaceMethods
    {
        #region old way

        public interface IFeature
        {
            string GetName();
        }

        public interface IFeature2 : IFeature
        {
            int GetAge();
        }

        public void OldMethod(IFeature feature)
        {
        }

        public void NewMethod(IFeature2 feature)
        {
        }

        #endregion

        #region since 8.0

        public interface IModernFeature
        {
            string GetName();

            int GetAge()
            {
                if (GetName() == "Matthew")
                    return 26;

                return -1;
            }
        }

        public class HumanFeature : IModernFeature
        {
            public string GetName() => "Human";
        }

        public class MatthewFeature : IModernFeature
        {
            public string GetName() => "Matthew";

            public int GetAge() => 26;
        }

        public void ModernMethod(IModernFeature feature)
        {
        }

        #endregion
    }
}
