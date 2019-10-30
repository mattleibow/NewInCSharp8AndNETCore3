namespace NewFeaturesDemo
{
    public class StaticLocalFunctions
    {
        // since 7.0
        public void LocalFunctions()
        {
            var instance = new UsefulObject();
            instance.Name = "Matthew";
            instance.Age = 26;

            var result = Calculate();

            int Calculate()
            {
                // Oh dear, we captured obj
                if (instance.Name == "Matthew")
                    return instance.Age;

                return -1;
            }
        }

        // since 8.0
        public void StaticFunctions()
        {
            var instance = new UsefulObject();
            instance.Name = "Matthew";
            instance.Age = 26;

            var result = Calculate(instance);

            static int Calculate(UsefulObject inst)
            {
                if (inst.Name == "Matthew")
                    return inst.Age;

                return -1;
            }
        }

        public class UsefulObject
        {
            public string Name { get; set; }

            public int Age { get; set; }
        }
    }
}
