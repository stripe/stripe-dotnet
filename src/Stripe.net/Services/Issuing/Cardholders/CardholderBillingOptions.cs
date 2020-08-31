namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardholderBillingOptions : INestedOptions
    {
        /// <summary>
        /// The cardholder’s billing address.
        /// </summary>
        [JsonProperty("address")]
        public AddressOptions Address { get; set; }
    }
}
