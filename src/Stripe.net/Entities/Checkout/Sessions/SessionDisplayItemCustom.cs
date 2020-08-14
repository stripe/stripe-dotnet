namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SessionDisplayItemCustom : StripeEntity<SessionDisplayItemCustom>
    {
        /// <summary>
        /// The description of the line item.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The images of the line item.
        /// </summary>
        [JsonProperty("images")]
        public List<string> Images { get; set; }

        /// <summary>
        /// The name of the line item.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
