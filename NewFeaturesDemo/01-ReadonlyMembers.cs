namespace NewFeaturesDemo
{
    public class ReadonlyMembers
    {
        // since 7.2
        public readonly struct ReadonlyStruct
        {
            // only readoly members are allowed
            public int Value { get; }

            // ERROR: member is not readonly
            //public int Value { get; set; }
        }

        // since 8.0
        public struct ReadonlyStructMembers
        {
            // read and write allowed
            public int Value { get; set; }

            public readonly string ChangeReadonly()
            {
                // ERROR: no changes allowed
                //Value = 42;

                // can access members
                return $"{Value + 1}";
            }

            public string Change()
            {
                // can change values
                Value = 42;

                // can access members
                return $"{Value + 1}";
            }
        }
    }
}
