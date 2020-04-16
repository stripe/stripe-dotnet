namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardholderBilling : StripeEntity<CardholderBilling>
    {
        /// <summary>
        /// The Billing address of the cardholder.
        /// </summary>
        [JsonProperty("address")]
        public Address Address { get; set; }
    }
}
