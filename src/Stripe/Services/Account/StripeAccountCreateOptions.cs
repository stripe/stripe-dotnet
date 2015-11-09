using System;
using System.Collections.Generic;
using Newtonsoft.Json;

using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeAccountCreateOptions
    {
        //Country is required
        [JsonProperty("country")]
        public string Country { get; set; }

        //Managed is false for regular, non-managed accounts
        [JsonProperty("managed")]
        public bool Managed { get; set; } = false;

        //Email is required if managed is false
        [JsonProperty("email")]
        public string Email { get; set; }
        
        #region General Account Properties

        [JsonProperty("business_name")]
        public string BusinessName { get; set; }
        
        //business_logo is mentioned but cannot find information on its use/implementation
        //[JsonProperty("business_logo")]
        //public string BusinessLogo { get; set; }

        [JsonProperty("business_primary_color")]
        public string BusinessPrimaryColor { get; set; }

        [JsonProperty("business_url")]
        public string BusinessUrl { get; set; }
        
        [JsonProperty("currencies_supported")]
        public string[] CurrenciesSupported { get; set; }

        [JsonProperty("default_currency")]
        public string DefaultCurrency { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("support_email")]
        public string SupportEmail { get; set; }

        [JsonProperty("support_phone")]
        public string SupportPhone { get; set; }

        [JsonProperty("support_url")]
        public string SupportUrl { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }
                
        #endregion
        
    }
}
