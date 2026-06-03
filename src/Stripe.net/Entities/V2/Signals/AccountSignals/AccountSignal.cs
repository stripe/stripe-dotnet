// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// An automatically evaluated signal on a v2 account.
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
        /// The type of signal.
        /// One of: <c>fraudulent_merchant</c>, or <c>merchant_delinquency</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
