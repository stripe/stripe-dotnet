namespace Stripe
{
    using System;

    /// <summary>
    /// Marks an interface as a discriminated union. The interface property
    /// will be deserialized by inspecting the JSON discriminator field and
    /// dispatching to the appropriate variant type.
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface)]
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
