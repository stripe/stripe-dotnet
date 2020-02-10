namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountCompanyVerificationDocumentOptions : INestedOptions
    {
        [JsonProperty("back")]
        public string Back { get; set; }

        [JsonProperty("front")]
        public string Front { get; set; }
    }
}
