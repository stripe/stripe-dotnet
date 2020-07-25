namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodFpxOptions : INestedOptions
    {
        /// <summary>
        /// Account holder type for FPX transaction. Can be one of "individual" or "company".
        /// </summary>
        [JsonProperty("account_holder_type")]
        public string AccountHolderType { get; set; }

        /// <summary>
        /// FPX bank name.
        /// </summary>
        [JsonProperty("bank")]
        public string Bank { get; set; }
    }
}
