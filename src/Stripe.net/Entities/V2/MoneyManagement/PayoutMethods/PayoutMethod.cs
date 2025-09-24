// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Use the PayoutMethods API to list and interact with PayoutMethod objects.
    /// </summary>
    public class PayoutMethod : StripeEntity<PayoutMethod>, IHasId, IHasObject
    {
        /// <summary>
        /// ID of the PayoutMethod object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// A set of available payout speeds for this payout method.
        /// One of: <c>instant</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("available_payout_speeds")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("available_payout_speeds")]
#endif
        public List<string> AvailablePayoutSpeeds { get; set; }

        /// <summary>
        /// The PayoutMethodBankAccount object details.
        /// </summary>
        [JsonProperty("bank_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_account")]
#endif
        public PayoutMethodBankAccount BankAccount { get; set; }

        /// <summary>
        /// The PayoutMethodCard object details.
        /// </summary>
        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif
        public PayoutMethodCard Card { get; set; }

        /// <summary>
        /// Created timestamp.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The PayoutMethodCryptoWallet object details.
        /// </summary>
        [JsonProperty("crypto_wallet")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("crypto_wallet")]
#endif
        public PayoutMethodCryptoWallet CryptoWallet { get; set; }

        /// <summary>
        /// ID of the underlying active OutboundSetupIntent object, if any.
        /// </summary>
        [JsonProperty("latest_outbound_setup_intent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("latest_outbound_setup_intent")]
#endif
        public string LatestOutboundSetupIntent { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// Closed Enum. The type of payout method.
        /// One of: <c>bank_account</c>, <c>card</c>, or <c>crypto_wallet</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// Indicates whether the payout method has met the necessary requirements for outbound
        /// money movement.
        /// </summary>
        [JsonProperty("usage_status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("usage_status")]
#endif
        public PayoutMethodUsageStatus UsageStatus { get; set; }
    }
}
