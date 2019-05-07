namespace Stripe.Terminal
{
    using System;
    using Newtonsoft.Json;

    public class LocationListOptions : ListOptions
    {
        [Obsolete("This feature has been deprecated and should not be used moving forward.")]
        [JsonProperty("operator_account")]
        public string OperatorAccount { get; set; }
    }
}
