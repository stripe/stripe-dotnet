namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodIdealCreateOptions : INestedOptions
    {
        /// <summary>
        /// The customer's bank.
        /// </summary>
        [JsonProperty("bank")]
        public string Bank { get; set; }
    }
}
