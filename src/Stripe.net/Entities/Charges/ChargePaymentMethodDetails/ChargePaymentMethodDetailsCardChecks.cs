namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ChargePaymentMethodDetailsCardChecks : StripeEntity<ChargePaymentMethodDetailsCardChecks>
    {
        [JsonProperty("address_line1_check")]
        public string AddressLine1Check { get; set; }

        [JsonProperty("address_postal_code_check")]
        public string AddressPostalCodeCheck { get; set; }

        [JsonProperty("cvc_check")]
        public string CvcCheck { get; set; }
    }
}
