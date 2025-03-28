// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ChargeListOptions : ListOptions
    {
        /// <summary>
        /// Only return charges that were created during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Only return charges for the customer specified by this customer ID.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// Only return charges that were created by the PaymentIntent specified by this
        /// PaymentIntent ID.
        /// </summary>
        [JsonProperty("payment_intent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_intent")]
#endif
        public string PaymentIntent { get; set; }

        /// <summary>
        /// Only return charges for this transfer group, limited to 100.
        /// </summary>
        [JsonProperty("transfer_group")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transfer_group")]
#endif
        public string TransferGroup { get; set; }
    }
}
