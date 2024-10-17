// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class FormPayee : StripeEntity<FormPayee>
    {
        #region Expandable Account

        /// <summary>
        /// (ID of the Account)
        /// The ID of the payee's Stripe account.
        /// </summary>
        [JsonIgnore]
        public string AccountId
        {
            get => this.InternalAccount?.Id;
            set => this.InternalAccount = SetExpandableFieldId(value, this.InternalAccount);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the payee's Stripe account.
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
        /// The external reference to this payee.
        /// </summary>
        [JsonProperty("external_reference")]
        public string ExternalReference { get; set; }

        /// <summary>
        /// Either <c>account</c> or <c>external_reference</c>.
        /// One of: <c>account</c>, or <c>external_reference</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
