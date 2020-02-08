namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceMandateNotificationSepaDebit : StripeEntity<SourceMandateNotificationSepaDebit>
    {
        [JsonProperty("creditor_identifier")]
        public string CreditorIdentifier { get; set; }

        [JsonProperty("last4")]
        public string Last4 { get; set; }

        [JsonProperty("mandate_reference")]
        public string MandateReference { get; set; }
    }
}
