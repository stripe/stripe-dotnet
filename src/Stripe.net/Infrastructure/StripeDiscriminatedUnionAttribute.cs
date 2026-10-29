namespace Stripe
{
    using System;

    /// <summary>
    /// Marks an interface or class as a discriminated union. The property
    /// will be deserialized by inspecting the JSON discriminator field and
    /// dispatching to the appropriate variant type. Unknown string discriminator values
    /// are deserialized as the annotated type when it is concrete and has a public
    /// parameterless constructor. Interfaces and abstract classes require a known variant.
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface | AttributeTargets.Class, Inherited = false)]
    public class StripeDiscriminatedUnionAttribute : Attribute
    {
        public StripeDiscriminatedUnionAttribute(string discriminatorPropertyName)
        {
            this.DiscriminatorPropertyName = discriminatorPropertyName;
        }

        /// <summary>
        /// Gets the JSON property name used as the discriminator (e.g. "model", "type").
        /// </summary>
        public string DiscriminatorPropertyName { get; }
    }
}
