// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentRecordFundedOptions : INestedOptions
    {
        /// <summary>
        /// The amount that has been lost to the customer due to disputes on this payment.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public PaymentRecordFundedAmountOptions Amount { get; set; }

        /// <summary>
        /// When the dispute funding event occurred. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("funded_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("funded_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? FundedAt { get; set; }

        /// <summary>
        /// The type of dispute funding event.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
