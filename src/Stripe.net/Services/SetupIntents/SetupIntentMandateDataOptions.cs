namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class SetupIntentMandateDataOptions : INestedOptions
    {
        [JsonProperty("customer_acceptance")]
        public SetupIntentMandateDataCustomerAcceptanceOptions CustomerAcceptance { get; set; }
    }
}
