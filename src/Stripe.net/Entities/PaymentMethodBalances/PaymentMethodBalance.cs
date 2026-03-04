// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// PaymentMethodBalance objects represent balances available on a payment method. You can
    /// use v1/payment_methods/:id/check_balance to check the balance of a payment method.
    /// </summary>
    public class PaymentMethodBalance : StripeEntity<PaymentMethodBalance>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// The time at which the balance was calculated. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("as_of")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("as_of")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime AsOf { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// BalanceEntry contain information about every individual balance type of a card.
        /// </summary>
        [JsonProperty("balance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("balance")]
#endif
        public PaymentMethodBalanceBalance Balance { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }
    }
}
