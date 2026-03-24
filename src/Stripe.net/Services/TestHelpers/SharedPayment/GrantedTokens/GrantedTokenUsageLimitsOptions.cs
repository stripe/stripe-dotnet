// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.SharedPayment
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class GrantedTokenUsageLimitsOptions : INestedOptions
    {
        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Time at which this SharedPaymentToken expires and can no longer be used to confirm a
        /// PaymentIntent.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("expires_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Max amount that can be captured using this SharedPaymentToken.
        /// </summary>
        [JsonProperty("max_amount")]
        [STJS.JsonPropertyName("max_amount")]
        public long? MaxAmount { get; set; }

        /// <summary>
        /// The recurring interval at which the shared payment token's amount usage restrictions
        /// reset.
        /// One of: <c>month</c>, <c>week</c>, or <c>year</c>.
        /// </summary>
        [JsonProperty("recurring_interval")]
        [STJS.JsonPropertyName("recurring_interval")]
        public string RecurringInterval { get; set; }
    }
}
