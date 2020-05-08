namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Account : StripeEntity<Account>, IHasId, IHasMetadata, IHasObject, IPaymentSource
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("business_profile")]
        public AccountBusinessProfile BusinessProfile { get; set; }

        [JsonProperty("business_type")]
        public string BusinessType { get; set; }

        [JsonProperty("capabilities")]
        public AccountCapabilities Capabilities { get; set; }

        [JsonProperty("charges_enabled")]
        public bool ChargesEnabled { get; set; }

        [JsonProperty("company")]
        public AccountCompany Company { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("default_currency")]
        public string DefaultCurrency { get; set; }

        [JsonProperty("deleted", NullValueHandling=NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        [JsonProperty("details_submitted")]
        public bool DetailsSubmitted { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("external_accounts")]
        public StripeList<IExternalAccount> ExternalAccounts { get; set; }

        [JsonProperty("individual")]
        public Person Individual { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("payouts_enabled")]
        public bool PayoutsEnabled { get; set; }

        [JsonProperty("requirements")]
        public AccountRequirements Requirements { get; set; }

        [JsonProperty("settings")]
        public AccountSettings Settings { get; set; }

        [JsonProperty("tos_acceptance")]
        public AccountTosAcceptance TosAcceptance { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
