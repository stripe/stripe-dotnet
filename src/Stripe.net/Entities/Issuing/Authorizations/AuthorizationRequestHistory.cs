// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AuthorizationRequestHistory : StripeEntity<AuthorizationRequestHistory>
    {
        /// <summary>
        /// The <c>pending_request.amount</c> at the time of the request, presented in your card's
        /// currency and in the <a href="https://stripe.com/docs/currencies#zero-decimal">smallest
        /// currency unit</a>. Stripe held this amount from your account to fund the authorization
        /// if the request was approved.
        /// </summary>
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
        /// The <c>pending_request.merchant_amount</c> at the time of the request, presented in the
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
        /// <c>webhook_declined</c>, <c>webhook_error</c>, or <c>webhook_timeout</c>.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// If approve/decline decision is directly responsed to the webhook with json payload and
        /// if the response is invalid (e.g., parsing errors), we surface the detailed message via
        /// this field.
        /// </summary>
        [JsonProperty("reason_message")]
        public string ReasonMessage { get; set; }
    }
}
