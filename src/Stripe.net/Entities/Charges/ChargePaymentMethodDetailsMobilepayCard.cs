// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsMobilepayCard : StripeEntity<ChargePaymentMethodDetailsMobilepayCard>
    {
        /// <summary>
        /// Brand of the card used in the transaction.
        /// </summary>
        [JsonProperty("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// Two-letter ISO code representing the country of the card.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Two digit number representing the card's expiration month.
        /// </summary>
        [JsonProperty("exp_month")]
        public long? ExpMonth { get; set; }

        /// <summary>
        /// Two digit number representing the card's expiration year.
        /// </summary>
        [JsonProperty("exp_year")]
        public long? ExpYear { get; set; }

        /// <summary>
        /// The last 4 digits of the card.
        /// </summary>
        [JsonProperty("last4")]
        public string Last4 { get; set; }
    }
}
