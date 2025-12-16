// File generated from our OpenAPI spec
namespace Stripe.SharedPayment
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class GrantedTokenUsageLimits : StripeEntity<GrantedTokenUsageLimits>
    {
        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// Time at which this SharedPaymentToken expires and can no longer be used to confirm a
        /// PaymentIntent.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expires_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Max amount that can be captured using this SharedPaymentToken.
        /// </summary>
        [JsonProperty("max_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("max_amount")]
#endif
        public long MaxAmount { get; set; }
    }
}
