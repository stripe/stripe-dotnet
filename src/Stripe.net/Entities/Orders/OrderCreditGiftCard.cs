// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class OrderCreditGiftCard : StripeEntity<OrderCreditGiftCard>
    {
        /// <summary>
        /// The token of the gift card applied to the order.
        /// </summary>
        [JsonProperty("card")]
        public string Card { get; set; }
    }
}
