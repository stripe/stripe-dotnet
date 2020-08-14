namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AuthorizationRequestHistory : StripeEntity<AuthorizationRequestHistory>
    {
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Detailed breakdown of amount components. These amounts are denominated in
        /// <c>currency</c> and in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("amount_details")]
        public AuthorizationRequestHistoryAmountDetails AmountDetails { get; set; }

        /// <summary>
        /// Whether this request was approved.
        /// </summary>
        [JsonProperty("approved")]
        public bool Approved { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("merchant_amount")]
        public long MerchantAmount { get; set; }

        [JsonProperty("merchant_currency")]
        public string MerchantCurrency { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
