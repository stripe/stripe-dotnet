using Newtonsoft.Json;

namespace Stripe
{
    public class StripeAccount : StripeObject
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("charges_enabled")]
        public bool ChargesEnabled { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("currencies_supported")]
        public string[] CurrenciesSupported { get; set; }

        [JsonProperty("default_currency")]
        public string DefaultCurrency { get; set; }

        [JsonProperty("details_submitted")]
        public bool DetailsSubmitted { get; set; }

        [JsonProperty("transfers_enabled")]
        public bool TransfersEnabled { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }
}
