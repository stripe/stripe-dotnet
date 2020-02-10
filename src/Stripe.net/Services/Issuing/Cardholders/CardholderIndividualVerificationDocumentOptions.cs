namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CardholderIndividualVerificationDocumentOptions : INestedOptions
    {
        [JsonProperty("back")]
        public string Back { get; set; }

        [JsonProperty("front")]
        public string Front { get; set; }
    }
}
