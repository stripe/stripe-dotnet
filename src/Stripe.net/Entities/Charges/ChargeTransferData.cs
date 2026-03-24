// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ChargeTransferData : StripeEntity<ChargeTransferData>
    {
        /// <summary>
        /// The amount transferred to the destination account, if specified. By default, the entire
        /// charge amount is transferred to the destination account.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        #region Expandable Destination

        /// <summary>
        /// (ID of the Account)
        /// ID of an existing, connected Stripe account to transfer funds to if <c>transfer_data</c>
        /// was specified in the charge request.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string DestinationId
        {
            get => this.InternalDestination?.Id;
            set => this.InternalDestination = SetExpandableFieldId(value, this.InternalDestination);
        }

        /// <summary>
        /// (Expanded)
        /// ID of an existing, connected Stripe account to transfer funds to if <c>transfer_data</c>
        /// was specified in the charge request.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Account Destination
        {
            get => this.InternalDestination?.ExpandedObject;
            set => this.InternalDestination = SetExpandableFieldObject(value, this.InternalDestination);
        }

        [JsonProperty("destination")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
        [STJS.JsonPropertyName("destination")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Account>))]
        internal ExpandableField<Account> InternalDestination { get; set; }
        #endregion
    }
}
