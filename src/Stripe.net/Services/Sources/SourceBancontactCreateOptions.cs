namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceBancontactCreateOptions : INestedOptions
    {
        [JsonProperty("preferred_language")]
        public string PreferredLanguage { get; set; }
    }
}
