// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FxQuoteUsagePayment : StripeEntity<FxQuoteUsagePayment>
    {
        /// <summary>
        /// The Stripe account ID that the funds will be transferred to.
        ///
        /// This field should match the account ID that would be used in the PaymentIntent’s
        /// transfer_data[destination] field.
        /// </summary>
        [JsonProperty("destination")]
        [STJS.JsonPropertyName("destination")]
        public string Destination { get; set; }

        /// <summary>
        /// The Stripe account ID that these funds are intended for.
        ///
        /// This field must match the account ID that would be used in the PaymentIntent’s
        /// on_behalf_of field.
        /// </summary>
        [JsonProperty("on_behalf_of")]
        [STJS.JsonPropertyName("on_behalf_of")]
        public string OnBehalfOf { get; set; }
    }
}
