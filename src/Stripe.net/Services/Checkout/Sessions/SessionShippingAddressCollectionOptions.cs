namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SessionShippingAddressCollectionOptions : INestedOptions
    {
        [JsonProperty("allowed_countries")]
        public List<string> AllowedCountries { get; set; }
    }
}
