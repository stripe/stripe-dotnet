namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SessionShippingAddressCollection : StripeEntity<SessionShippingAddressCollection>
    {
        [JsonProperty("allowed_countries")]
        public List<string> AllowedCountries { get; set; }
    }
}
