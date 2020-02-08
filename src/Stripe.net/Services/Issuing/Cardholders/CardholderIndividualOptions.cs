namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CardholderIndividualOptions : INestedOptions
    {
        [JsonProperty("dob")]
        public CardholderIndividualDobOptions Dob { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("verification")]
        public CardholderIndividualVerificationOptions Verification { get; set; }
    }
}
