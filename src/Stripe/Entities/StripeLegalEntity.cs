using Newtonsoft.Json;

namespace Stripe
{
    public class StripeLegalEntity
    {
        [JsonProperty("business_name")]
        public string BusinessName { get; set; }

        [JsonProperty("business_tax_id")]
        public string BusinessTaxId { get; set; }

        [JsonProperty("business_vat_id")]
        public string BusinessVatId { get; set; }

        //hash
        [JsonProperty("address")]
        public StripeAddress Address { get; set; }

        [JsonProperty("personal_id_number")]
        public string PersonalIdNumber { get; set; }

        //Read Only Property
        [JsonProperty("personal_id_number_provided")]
        public bool PersonalIdNumberProvided { get; set; }

        [JsonProperty("ssn_last_4")]
        public string RepSSNLast4 { get; set; }

        //Read Only Property
        [JsonProperty("ssn_last_4_provided")]
        public bool RepSSNLast4Provided { get; set; }

        [JsonProperty("first_name")]
        public string RepFirstName { get; set; }

        [JsonProperty("last_name")]
        public string RepLastName { get; set; }

        //hash
        [JsonProperty("dob")]
        public StripeDob RepDob { get; set; }

        //hash
        [JsonProperty("personal_address")]
        public StripeAddress PersonalAddress { get; set; }
                
        [JsonProperty("type")]
        public string Type { get; set; }

        //hash
        [JsonProperty("verification")]
        public StripeLegalEntityVerification Verification { get; set; }

        //list
        //Additional Owners are only required for EU countries as of November 2015.
        [JsonProperty("additional_owners")]
        public StripeList<StripeAdditionalOwner> StripAdditionalOwnerList { get; set; }
    }
}
