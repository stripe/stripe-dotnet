namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    [Obsolete("Use Customer.TaxIds instead.")]
    public class CustomerTaxInfoVerification : StripeEntity
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("verified_name")]
        public string VerifiedName { get; set; }
    }
}
