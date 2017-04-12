using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeLegalEntity : StripeEntity
    {
        [JsonProperty("additional_owners")]
        public List<StripeAdditionalOwners> AdditionalOwners { get; set; }

        [JsonProperty("address")]
        public StripeAddress Address { get; set; }

        [JsonProperty("business_name")]
        public string BusinessName { get; set; }

        /// <summary>
        /// Whether the business ID number of the legal entity has been provided.
        /// </summary>
        [JsonProperty("business_tax_id_provided")]
        public bool BusinessTaxIdProvided { get; set; }

        /// <summary>
        /// Whether the business VAT number of the legal entity has been provided.
        /// </summary>
        [JsonProperty("business_vat_id_provided")]
        public bool BusinessVatIdProvided { get; set; }

        [JsonProperty("dob")]
        public StripeBirthDay BirthDay { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("personal_address")]
        public StripeAddress PersonalAddress { get; set; }

        [JsonProperty("personal_id_number_provided")]
        public bool PersonalIdNumberProvided { get; set; }

        [JsonProperty("ssn_last_4_provided")]
        public bool SocialSecurityNumberLastFourProvided { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("verification")]
        public StripeLegalEntityVerification LegalEntityVerification { get; set; }
    }
}
