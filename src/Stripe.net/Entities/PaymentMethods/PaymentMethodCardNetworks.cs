namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentMethodCardNetworks : StripeEntity<PaymentMethodCardNetworks>
    {
        [JsonProperty("available")]
        public List<string> Available { get; set; }

        [JsonProperty("preferred")]
        public string Preferred { get; set; }
    }
}
