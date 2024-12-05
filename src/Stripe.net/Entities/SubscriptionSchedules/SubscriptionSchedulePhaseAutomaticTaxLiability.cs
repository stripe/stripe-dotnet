// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionSchedulePhaseAutomaticTaxLiability : StripeEntity<SubscriptionSchedulePhaseAutomaticTaxLiability>
    {
        #region Expandable Account

        /// <summary>
        /// (ID of the Account)
        /// The connected account being referenced when <c>type</c> is <c>account</c>.
        /// </summary>
        [JsonIgnore]
        public string AccountId
        {
            get => this.InternalAccount?.Id;
            set => this.InternalAccount = SetExpandableFieldId(value, this.InternalAccount);
        }

        /// <summary>
        /// (Expanded)
        /// The connected account being referenced when <c>type</c> is <c>account</c>.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Account Account
        {
            get => this.InternalAccount?.ExpandedObject;
            set => this.InternalAccount = SetExpandableFieldObject(value, this.InternalAccount);
        }

        [JsonProperty("account")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
        internal ExpandableField<Account> InternalAccount { get; set; }
        #endregion

        /// <summary>
        /// Type of the account referenced.
        /// One of: <c>account</c>, or <c>self</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
