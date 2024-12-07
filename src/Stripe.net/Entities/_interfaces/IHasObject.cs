namespace Stripe
{
#if NET6_0_OR_GREATER
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Interface that identifies entities returned by Stripe that have an `object` attribute.
    /// </summary>
#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJStripeObjectConverter))]
#endif
    public interface IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        string Object { get; set; }
    }
}
