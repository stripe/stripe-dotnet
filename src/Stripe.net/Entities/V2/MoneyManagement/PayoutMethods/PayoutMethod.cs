// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Use the PayoutMethods API to list and interact with PayoutMethod objects.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PayoutMethod : StripeEntity<PayoutMethod>, IHasId, IHasObject
    {
        /// <summary>
        /// ID of the PayoutMethod object.
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
        /// The alternative reference for this payout method, if it's a projected payout method.
        /// </summary>
        [JsonProperty("alternative_reference")]
        [STJS.JsonPropertyName("alternative_reference")]
        public PayoutMethodAlternativeReference AlternativeReference { get; set; }

        /// <summary>
        /// A set of available payout speeds for this payout method.
        /// One of: <c>instant</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("available_payout_speeds")]
        [STJS.JsonPropertyName("available_payout_speeds")]
        public List<string> AvailablePayoutSpeeds { get; set; }

        /// <summary>
        /// The PayoutMethodBankAccount object details.
        /// </summary>
        [JsonProperty("bank_account")]
        [STJS.JsonPropertyName("bank_account")]
        public PayoutMethodBankAccount BankAccount { get; set; }

        /// <summary>
        /// The PayoutMethodCard object details.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public PayoutMethodCard Card { get; set; }

        /// <summary>
        /// Created timestamp.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// ID of the underlying active OutboundSetupIntent object, if any.
        /// </summary>
        [JsonProperty("latest_outbound_setup_intent")]
        [STJS.JsonPropertyName("latest_outbound_setup_intent")]
        public string LatestOutboundSetupIntent { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Whether the Payout Method is currently unusable for money movement, despite potentially
        /// being correctly set up. Please reach out to Stripe Support for more information.
        /// </summary>
        [JsonProperty("restricted")]
        [STJS.JsonPropertyName("restricted")]
        public bool Restricted { get; set; }

        /// <summary>
        /// Closed Enum. The type of payout method.
        /// One of: <c>bank_account</c>, <c>card</c>, or <c>crypto_wallet</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Indicates whether the payout method has met the necessary requirements for outbound
        /// money movement.
        /// </summary>
        [JsonProperty("usage_status")]
        [STJS.JsonPropertyName("usage_status")]
        public PayoutMethodUsageStatus UsageStatus { get; set; }
    }
}
