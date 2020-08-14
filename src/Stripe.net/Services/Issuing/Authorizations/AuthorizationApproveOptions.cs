namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class AuthorizationApproveOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
