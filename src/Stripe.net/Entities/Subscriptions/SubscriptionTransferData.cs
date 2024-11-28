// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class SubscriptionTransferData : StripeEntity<SubscriptionTransferData>
    {
        /// <summary>
        /// A non-negative decimal between 0 and 100, with at most two decimal places. This
        /// represents the percentage of the subscription invoice total that will be transferred to
        /// the destination account. By default, the entire amount is transferred to the
        /// destination.
        /// </summary>
        [JsonProperty("amount_percent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_percent")]
#endif
        public decimal? AmountPercent { get; set; }

        #region Expandable Destination

        /// <summary>
        /// (ID of the Account)
        /// The account where funds from the payment will be transferred to upon payment success.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string DestinationId
        {
            get => this.InternalDestination?.Id;
            set => this.InternalDestination = SetExpandableFieldId(value, this.InternalDestination);
        }

        /// <summary>
        /// (Expanded)
        /// The account where funds from the payment will be transferred to upon payment success.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Account Destination
        {
            get => this.InternalDestination?.ExpandedObject;
            set => this.InternalDestination = SetExpandableFieldObject(value, this.InternalDestination);
        }

        [JsonProperty("destination")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("destination")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Account>))]
#endif
        internal ExpandableField<Account> InternalDestination { get; set; }
        #endregion
    }
}
