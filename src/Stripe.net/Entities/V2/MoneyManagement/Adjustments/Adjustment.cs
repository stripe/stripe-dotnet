// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// An Adjustment records a credit or debit that Stripe makes to your Financial Account
    /// balance, for example to correct technical or operational errors.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Adjustment : StripeEntity<Adjustment>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
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
        /// Details about the original flow object linked to this Adjustment, if applicable.
        /// <c>adjusted_flow.type</c> identifies the kind of object. The corresponding field
        /// contains its ID: for an InboundTransfer, <c>adjusted_flow.inbound_transfer</c> contains
        /// the InboundTransfer's ID. Pass that ID to the <c>adjusted_flow</c> parameter on List
        /// Adjustments.
        /// </summary>
        [JsonProperty("adjusted_flow")]
        [STJS.JsonPropertyName("adjusted_flow")]
        public AdjustmentAdjustedFlow AdjustedFlow { get; set; }

        /// <summary>
        /// The amount of the Adjustment.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// Time at which the object was created. Represented as an RFC 3339 timestamp in UTC with
        /// millisecond precision, for example <c>2022-09-18T13:22:18.123Z</c>.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// A description of the Adjustment and its purpose.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the FinancialAccount whose balance this Adjustment affects.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }
    }
}
