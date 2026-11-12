// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OffSessionPaymentCreateItemOneTimePriceOptions : INestedOptions
    {
        /// <summary>
        /// The list of one-time prices and quantities the customer will purchase. Contains 1 to 10
        /// items.
        /// </summary>
        [JsonProperty("items")]
        [STJS.JsonPropertyName("items")]
        public List<OffSessionPaymentCreateItemOneTimePriceItemOptions> Items { get; set; }
    }
}
