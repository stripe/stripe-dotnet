namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AuthorizationRequestHistory : StripeEntity<AuthorizationRequestHistory>
    {
        /// <summary>
        /// The authorization amount in your card's currency and in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>.
        /// Stripe held this amount from your account to fund the authorization if the request was
        /// approved.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Whether this request was approved.
        /// </summary>
        [JsonProperty("approved")]
        public bool Approved { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The amount that was authorized at the time of this request. This amount is in the
        /// <c>merchant_currency</c> and in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("merchant_amount")]
        public long MerchantAmount { get; set; }

        /// <summary>
        /// The currency that was collected by the merchant and presented to the cardholder for the
        /// authorization. Three-letter <a
        /// href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency code</a>, in
        /// lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("merchant_currency")]
        public string MerchantCurrency { get; set; }

        /// <summary>
        /// The reason for the approval or decline.
        /// One of: <c>account_disabled</c>, <c>card_active</c>, <c>card_inactive</c>,
        /// <c>cardholder_inactive</c>, <c>cardholder_verification_required</c>,
        /// <c>insufficient_funds</c>, <c>not_allowed</c>, <c>spending_controls</c>,
        /// <c>suspected_fraud</c>, <c>verification_failed</c>, <c>webhook_approved</c>,
        /// <c>webhook_declined</c>, or <c>webhook_timeout</c>.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
