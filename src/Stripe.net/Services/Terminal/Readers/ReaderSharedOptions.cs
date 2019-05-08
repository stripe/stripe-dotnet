namespace Stripe.Terminal
{
    using System;
    using Newtonsoft.Json;

    public class ReaderSharedOptions : BaseOptions
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [Obsolete("This feature has been deprecated and should not be used moving forward.")]
        [JsonProperty("operator_account")]
        public string OperatorAccount { get; set; }
    }
}
