namespace Stripe
{
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Interface that identifies entities returned by Stripe that have an `object` attribute.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeObjectConverter))]
    public interface IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        string Object { get; set; }
    }
}
