namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class TokenAccountOptions : INestedOptions
    {
        [JsonProperty("business_type")]
        public string BusinessType { get; set; }

        [JsonProperty("company")]
        public TokenAccountCompanyOptions Company { get; set; }

        [JsonProperty("individual")]
        public TokenPersonOptions Individual { get; set; }

        [JsonProperty("tos_shown_and_accepted")]
        public bool? TosShownAndAccepted { get; set; }
    }
}
