using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeLegalEntity
    {
        [JsonProperty("additional_owners")]
        public StripeList<StripeAdditionalOwners> StripAdditionalOwners { get; set; }

        [JsonProperty("address")]
        public StripeAddress Address { get; set; }

        [JsonProperty("business_name")]
        public string BusinessName { get; set; }

        [JsonProperty("dob")]
        public StripeBirthDay StripeBirthDay { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

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
        public StripeLegalEntityVerification StripeLegalEntityVerification { get; set; }
    }
}
