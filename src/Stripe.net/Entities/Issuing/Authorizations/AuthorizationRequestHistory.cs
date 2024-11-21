// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AuthorizationRequestHistory : StripeEntity<AuthorizationRequestHistory>
    {
        /// <summary>
        /// The <c>pending_request.amount</c> at the time of the request, presented in your card's
        /// currency and in the <a href="https://stripe.com/docs/currencies#zero-decimal">smallest
        /// currency unit</a>. Stripe held this amount from your account to fund the authorization
        /// if the request was approved.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif

        public long Amount { get; set; }

        /// <summary>
        /// Detailed breakdown of amount components. These amounts are denominated in
        /// <c>currency</c> and in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("amount_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_details")]
#endif

        public AuthorizationRequestHistoryAmountDetails AmountDetails { get; set; }

        /// <summary>
        /// Whether this request was approved.
        /// </summary>
        [JsonProperty("approved")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("approved")]
#endif

        public bool Approved { get; set; }

        /// <summary>
        /// A code created by Stripe which is shared with the merchant to validate the
        /// authorization. This field will be populated if the authorization message was approved.
        /// The code typically starts with the letter "S", followed by a six-digit number. For
        /// example, "S498162". Please note that the code is not guaranteed to be unique across
        /// authorizations.
        /// </summary>
        [JsonProperty("authorization_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("authorization_code")]
#endif

        public string AuthorizationCode { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

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
        /// The <c>pending_request.merchant_amount</c> at the time of the request, presented in the
        /// <c>merchant_currency</c> and in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("merchant_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("merchant_amount")]
#endif

        public long MerchantAmount { get; set; }

        /// <summary>
        /// The currency that was collected by the merchant and presented to the cardholder for the
        /// authorization. Three-letter <a
        /// href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency code</a>, in
        /// lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("merchant_currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("merchant_currency")]
#endif

        public string MerchantCurrency { get; set; }

        /// <summary>
        /// The card network's estimate of the likelihood that an authorization is fraudulent. Takes
        /// on values between 1 and 99.
        /// </summary>
        [JsonProperty("network_risk_score")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network_risk_score")]
#endif

        public long? NetworkRiskScore { get; set; }

        /// <summary>
        /// When an authorization is approved or declined by you or by Stripe, this field provides
        /// additional detail on the reason for the outcome.
        /// One of: <c>account_disabled</c>, <c>card_active</c>, <c>card_canceled</c>,
        /// <c>card_expired</c>, <c>card_inactive</c>, <c>cardholder_blocked</c>,
        /// <c>cardholder_inactive</c>, <c>cardholder_verification_required</c>,
        /// <c>insecure_authorization_method</c>, <c>insufficient_funds</c>, <c>not_allowed</c>,
        /// <c>pin_blocked</c>, <c>spending_controls</c>, <c>suspected_fraud</c>,
        /// <c>verification_failed</c>, <c>webhook_approved</c>, <c>webhook_declined</c>,
        /// <c>webhook_error</c>, or <c>webhook_timeout</c>.
        /// </summary>
        [JsonProperty("reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reason")]
#endif

        public string Reason { get; set; }

        /// <summary>
        /// If the <c>request_history.reason</c> is <c>webhook_error</c> because the direct webhook
        /// response is invalid (for example, parsing errors or missing parameters), we surface a
        /// more detailed error message via this field.
        /// </summary>
        [JsonProperty("reason_message")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reason_message")]
#endif

        public string ReasonMessage { get; set; }

        /// <summary>
        /// Time when the card network received an authorization request from the acquirer in UTC.
        /// Referred to by networks as transmission time.
        /// </summary>
        [JsonProperty("requested_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("requested_at")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime? RequestedAt { get; set; }
    }
}
