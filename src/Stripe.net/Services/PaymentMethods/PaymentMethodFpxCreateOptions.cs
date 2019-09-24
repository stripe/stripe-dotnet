namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodFpxCreateOptions : INestedOptions
    {
        /// <summary>
        /// FPX bank name
        /// </summary>
        [JsonProperty("bank")]
        public string Bank { get; set; }
    }
}
