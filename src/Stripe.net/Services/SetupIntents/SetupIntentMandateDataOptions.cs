namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentMandateDataOptions : INestedOptions
    {
        [JsonProperty("customer_acceptance")]
        public SetupIntentMandateDataCustomerAcceptanceOptions CustomerAcceptance { get; set; }
    }
}
