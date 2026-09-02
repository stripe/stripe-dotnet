// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// An automatically evaluated signal on an account. Each Account Signal object corresponds
    /// to exactly one signal type, indicated by type. Only the type-specific field is
    /// populated; other type-specific payload fields are null. If an account has multiple
    /// signals, Stripe creates separate account signal objects.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSignal : StripeEntity<AccountSignal>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the account signal.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The account or customer this signal is associated with.
        /// </summary>
        [JsonProperty("account_details")]
        [STJS.JsonPropertyName("account_details")]
        public AccountSignalAccountDetails AccountDetails { get; set; }

        /// <summary>
        /// The account evaluation that produced this signal, if applicable.
        /// </summary>
        [JsonProperty("account_evaluation")]
        [STJS.JsonPropertyName("account_evaluation")]
        public string AccountEvaluation { get; set; }

        /// <summary>
        /// Timestamp at which the signal was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Data for the fraudulent merchant signal. Present only when type is fraudulent_merchant.
        /// </summary>
        [JsonProperty("fraudulent_merchant")]
        [STJS.JsonPropertyName("fraudulent_merchant")]
        public AccountSignalFraudulentMerchant FraudulentMerchant { get; set; }

        /// <summary>
        /// Data for the fraudulent website signal. Present only when type is fraudulent_website.
        /// </summary>
        [JsonProperty("fraudulent_website")]
        [STJS.JsonPropertyName("fraudulent_website")]
        public AccountSignalFraudulentWebsite FraudulentWebsite { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Data for the merchant delinquency signal. Present only when type is
        /// merchant_delinquency.
        /// </summary>
        [JsonProperty("merchant_delinquency")]
        [STJS.JsonPropertyName("merchant_delinquency")]
        public AccountSignalMerchantDelinquency MerchantDelinquency { get; set; }

        /// <summary>
        /// Data for the payment delinquency exposure signal. Present only when type is
        /// payment_delinquency_exposure.
        /// </summary>
        [JsonProperty("payment_delinquency_exposure")]
        [STJS.JsonPropertyName("payment_delinquency_exposure")]
        public AccountSignalPaymentDelinquencyExposure PaymentDelinquencyExposure { get; set; }

        /// <summary>
        /// The type of signal.
        /// One of: <c>fraudulent_merchant</c>, <c>fraudulent_website</c>,
        /// <c>merchant_delinquency</c>, <c>payment_delinquency_exposure</c>,
        /// <c>user_account_sharing</c>, or <c>user_multi_accounting</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Data for the user account-sharing signal. Present only when type is
        /// user_account_sharing.
        /// </summary>
        [JsonProperty("user_account_sharing")]
        [STJS.JsonPropertyName("user_account_sharing")]
        public AccountSignalUserAccountSharing UserAccountSharing { get; set; }

        /// <summary>
        /// Data for the user multi-accounting signal. Present only when type is
        /// user_multi_accounting.
        /// </summary>
        [JsonProperty("user_multi_accounting")]
        [STJS.JsonPropertyName("user_multi_accounting")]
        public AccountSignalUserMultiAccounting UserMultiAccounting { get; set; }
    }
}
