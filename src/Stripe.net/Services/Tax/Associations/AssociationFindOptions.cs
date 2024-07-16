// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class AssociationFindOptions : BaseOptions
    {
        /// <summary>
        /// Valid <a href="https://stripe.com/docs/api/payment_intents/object">PaymentIntent</a> id.
        /// </summary>
        [JsonProperty("payment_intent")]
        public string PaymentIntent { get; set; }
    }
}
