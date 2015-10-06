using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Entities;

namespace Stripe
{
    public class StripeLegalEntity
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("business_name")]
        public string BusinessName { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("address")]
        public StripeAddress Address { get; set; }

        [JsonProperty("personal_address")]
        public StripeAddress PersonalAddress { get; set; }

        [JsonProperty("business_tax_id")]
        public string BusinessTaxId { get; set; }

        [JsonProperty("business_vat_id")]
        public string BusinessVatId { get; set; }

        [JsonProperty("dob")]
        public StripeBirthDay BirthDay { get; set; }

        [JsonProperty("ssn_last_4_provided")]
        public bool SSN4Provided { get; set; }

        [JsonProperty("personal_id_number_provided")]
        public bool PersonalIdNumberProvided { get; set; }

        [JsonProperty("verification")]
        public StripeLegalEntityVerification Verification { get; set; }

        [JsonProperty("additional_owners")]
        public IList<AdditionalOwner> AdditionalOwners { get; set; }
    }

    public class AdditionalOwner
    {
        [JsonProperty("dob")]
        public StripeBirthDay Dob { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("address")]
        public StripeAddress Address { get; set; }
    }
}
