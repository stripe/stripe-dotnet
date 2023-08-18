// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class DisputePaymentMethodDetails : StripeEntity<DisputePaymentMethodDetails>
    {
        /// <summary>
        /// Card specific dispute details.
        /// </summary>
        [JsonProperty("card")]
        public DisputePaymentMethodDetailsCard Card { get; set; }

        /// <summary>
        /// Payment method type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
