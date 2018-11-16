namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Account : StripeEntity, IHasId, IHasMetadata, IHasObject, IPaymentSource
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        #region Expandable BusinessLogo
        public string BusinessLogoFileId { get; set; }

        [JsonIgnore]
        public File BusinessLogo { get; set; }

        [JsonProperty("business_logo")]
        internal object InternalBusinessLogo
        {
            set
            {
                StringOrObject<File>.Map(value, s => this.BusinessLogoFileId = s, o => this.BusinessLogo = o);
            }
        }
        #endregion

        [JsonProperty("business_name")]
        public string BusinessName { get; set; }

        [JsonProperty("business_primary_color")]
        public string BusinessPrimaryColor { get; set; }

        [JsonProperty("business_url")]
        public string BusinessUrl { get; set; }

        [JsonProperty("charges_enabled")]
        public bool ChargesEnabled { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("debit_negative_balances")]
        public bool DebitNegativeBalances { get; set; }

        [JsonProperty("decline_charge_on")]
        public DeclineChargeOn DeclineChargeOn { get; set; }

        [JsonProperty("default_currency")]
        public string DefaultCurrency { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("details_submitted")]
        public bool DetailsSubmitted { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("external_accounts")]
        public StripeList<IExternalAccount> ExternalAccounts { get; set; }

        [JsonProperty("keys")]
        public CustomAccountKeys Keys { get; set; }

        [JsonProperty("legal_entity")]
        public LegalEntity LegalEntity { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("payout_schedule")]
        public PayoutSchedule PayoutSchedule { get; set; }

        [JsonProperty("payout_statement_descriptor")]
        public string PayoutStatementDescriptor { get; set; }

        [JsonProperty("payouts_enabled")]
        public bool PayoutsEnabled { get; set; }

        [JsonProperty("product_description")]
        public string ProductDescription { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("support_address")]
        public Address SupportAddress { get; set; }

        [JsonProperty("support_email")]
        public string SupportEmail { get; set; }

        [JsonProperty("support_phone")]
        public string SupportPhone { get; set; }

        [JsonProperty("support_url")]
        public string SupportUrl { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("tos_acceptance")]
        public TermsOfServiceAcceptance TosAcceptance { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("verification")]
        public AccountVerification Verification { get; set; }
     }
}
