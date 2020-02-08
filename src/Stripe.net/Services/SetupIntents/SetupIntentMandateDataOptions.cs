namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SetupIntentMandateDataOptions : INestedOptions
    {
        [JsonProperty("customer_acceptance")]
        public SetupIntentMandateDataCustomerAcceptanceOptions CustomerAcceptance { get; set; }
    }
}
