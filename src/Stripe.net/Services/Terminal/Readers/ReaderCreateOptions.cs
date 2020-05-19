namespace Stripe.Terminal
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ReaderCreateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("registration_code")]
        public string RegistrationCode { get; set; }
    }
}
