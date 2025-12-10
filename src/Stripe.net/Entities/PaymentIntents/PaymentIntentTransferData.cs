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
    public class PaymentIntentTransferData : StripeEntity<PaymentIntentTransferData>
    {
        /// <summary>
        /// The amount transferred to the destination account. This transfer will occur
        /// automatically after the payment succeeds. If no amount is specified, by default the
        /// entire payment amount is transferred to the destination account. The amount must be less
        /// than or equal to the <a
        /// href="https://docs.stripe.com/api/payment_intents/object#payment_intent_object-amount">amount</a>,
        /// and must be a positive integer representing how much to transfer in the smallest
        /// currency unit (e.g., 100 cents to charge $1.00).
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long Amount { get; set; }

        #region Expandable Destination

        /// <summary>
        /// (ID of the Account)
        /// The account (if any) that the payment is attributed to for tax reporting, and where
        /// funds from the payment are transferred to after payment success.
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
        /// The account (if any) that the payment is attributed to for tax reporting, and where
        /// funds from the payment are transferred to after payment success.
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
