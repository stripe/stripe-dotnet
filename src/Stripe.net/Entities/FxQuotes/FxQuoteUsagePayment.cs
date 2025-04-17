// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FxQuoteUsagePayment : StripeEntity<FxQuoteUsagePayment>
    {
        /// <summary>
        /// The Stripe account ID that the funds will be transferred to.
        ///
        /// This field should match the account ID that would be used in the PaymentIntent’s
        /// transfer_data[destination] field.
        /// </summary>
        [JsonProperty("destination")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("destination")]
#endif
        public string Destination { get; set; }

        /// <summary>
        /// The Stripe account ID that these funds are intended for.
        ///
        /// This field must match the account ID that would be used in the PaymentIntent’s
        /// on_behalf_of field.
        /// </summary>
        [JsonProperty("on_behalf_of")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("on_behalf_of")]
#endif
        public string OnBehalfOf { get; set; }
    }
}
