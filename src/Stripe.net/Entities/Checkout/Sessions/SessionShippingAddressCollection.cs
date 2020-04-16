namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SessionShippingAddressCollection : StripeEntity<SessionShippingAddressCollection>
    {
        /// <summary>
        /// A list of two-letter ISO country codes representing which countries Checkout should
        /// provide as options for shipping locations.
        /// </summary>
        [JsonProperty("allowed_countries")]
        public List<string> AllowedCountries { get; set; }
    }
}
