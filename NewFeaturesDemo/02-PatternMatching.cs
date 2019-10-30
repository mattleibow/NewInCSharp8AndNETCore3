using System;

namespace NewFeaturesDemo
{
    // since 7.0
    public class PatternMatching
    {
        #region switch expressions

        // since 1.0
        public string SwitchStatements(Value value)
        {
            switch (value)
            {
                case Value.First:
                    return "first";
                case Value.Second:
                    return "second";
                case Value.Third:
                    return "third";
                default:
                    throw new ArgumentOutOfRangeException(nameof(value));
            }
        }

        // since 8.0
        public string SwitchExpressions(Value value) =>
            value switch
            {
                Value.First => "first",
                Value.Second => "second",
                Value.Third => "third",
                _ => throw new ArgumentOutOfRangeException(nameof(value))
            };

        #endregion

        #region property patterns

        // since 8.0
        public string PropertyPatterns(UsefulObject instance) =>
            instance switch
            {
                { Name: "Matthew" } => "very cool guy",
                { Name: "Mrs. Matthew" } => "a beautiful, but elusive creature",
                { Age: 18 } => "probably working in IT",
                { Age: 2 } => "old enough to walk, old enough to code",
                { Name: "Katie", Age: 100 } => "probably not alive",
                _ => "the average joe"
            };

        #endregion

        #region tuple patterns

        // since 8.0
        public string TuplePatterns(string name, int age) =>
            (name, age) switch
            {
                ("Matthew", _) => "very cool guy",
                ("Mrs. Matthew", _) => "a beautiful, but elusive creature",
                (_, 18) => "probably working in IT",
                (_, 2) => "old enough to walk, old enough to code",
                ("Katie", 100) => "here she is again, must still be going strong",
                _ => "still an average joe"
            };

        #endregion

        #region positional patterns

        // since 8.0
        public string PositionalPatterns(UsefulObject instance) =>
            instance switch
            {
                var (name, _) when name == "Matthew" => "very cool guy",
                var (name, _) when name == "Mrs. Matthew" => "a beautiful, but elusive creature",
                var (_, age) when age > 18 => "probably working in IT",
                var (_, age) when age > 2 => "old enough to walk, old enough to code",
                var (name, age) when name == "Katie" && age > 100 => "definitely still alive, wow",
                _ => "yup, still average"
            };

        #endregion

        public class UsefulObject
        {
            public string Name { get; set; }

            public int Age { get; set; }

            public void Deconstruct(out string name, out int age) =>
                (name, age) = (Name, Age);
        }

        public enum Value
        {
            First,
            Second,
            Third
        }
    }
}
