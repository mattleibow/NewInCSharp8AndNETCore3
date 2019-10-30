namespace NewFeaturesDemo
{
    public class InterpolatedVerbatimStrings
    {
        public void Create()
        {
            // since 6.0
            var oldSchool = $@"old way: {true}";

            // since 8.0
            var newSchool = @$"new way: {true}";
        }
    }
}
