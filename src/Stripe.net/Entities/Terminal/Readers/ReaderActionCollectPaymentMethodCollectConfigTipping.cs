// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReaderActionCollectPaymentMethodCollectConfigTipping : StripeEntity<ReaderActionCollectPaymentMethodCollectConfigTipping>
    {
        /// <summary>
        /// Amount used to calculate tip suggestions on tipping selection screen for this
        /// transaction. Must be a positive integer in the smallest currency unit (e.g., 100 cents
        /// to represent $1.00 or 100 to represent ¥100, a zero-decimal currency).
        /// </summary>
        [JsonProperty("amount_eligible")]
        [STJS.JsonPropertyName("amount_eligible")]
        public long AmountEligible { get; set; }
    }
}
