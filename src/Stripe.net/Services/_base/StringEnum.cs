namespace Stripe
{
    /// <summary>
    /// Abstract base class for string enum parameters.
    /// </summary>
    /// <remarks>
    /// This class is used to define request parameters that can only take certain string values.
    /// We use it instead of defining a regular <c>enum</c> with
    /// <see cref="System.Runtime.Serialization.EnumMemberAttribute"/> annotations for
    /// serialization because <c>enum</c> is really an integer under the hood. This can be
    /// problematic in some cases, like when a parameter can be an integer OR a string enum (e.g.
    /// <see cref="PlanTierOptions.UpTo"/>).
    /// </remarks>
    /// <example>
    /// This sample shows how to define a new string enum type.
    /// <code>
    /// public class FooBar : StringEnum
    /// {
    ///     public static readonly FooBar Foo = new FooBar("foo");
    ///     public static readonly FooBar Bar = new FooBar("bar");
    ///
    ///     private FooBar(string value) : base(value) {}
    /// }
    /// </code>
    /// </example>
    public abstract class StringEnum
    {
        /// <summary>Initializes a new instance of the <see cref="StringEnum"/> class.</summary>
        /// <param name="value">The serialized value for the instance.</param>
        protected StringEnum(string value)
        {
            this.Value = value;
        }

        /// <summary>Gets or sets the serialized value.</summary>
        /// <returns>The serialized value.</returns>
        public string Value { get; protected set; }

        /// <summary>Returns the serialized value.</summary>
        /// <returns>The serialized value.</returns>
        public override string ToString()
        {
            return this.Value;
        }
    }
}
