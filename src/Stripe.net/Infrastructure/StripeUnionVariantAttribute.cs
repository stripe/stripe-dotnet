namespace Stripe
{
    using System;

    /// <summary>
    /// Maps a discriminator value to a concrete variant type for a discriminated union interface.
    /// Applied to the interface multiple times, once per variant.
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = true)]
    public class StripeUnionVariantAttribute : Attribute
    {
        public StripeUnionVariantAttribute(Type variantType, string discriminatorValue)
        {
            this.VariantType = variantType;
            this.DiscriminatorValue = discriminatorValue;
        }

        /// <summary>
        /// Gets the concrete type to deserialize into when the discriminator matches.
        /// </summary>
        public Type VariantType { get; }

        /// <summary>
        /// Gets the discriminator value that maps to this variant type.
        /// </summary>
        public string DiscriminatorValue { get; }
    }
}
