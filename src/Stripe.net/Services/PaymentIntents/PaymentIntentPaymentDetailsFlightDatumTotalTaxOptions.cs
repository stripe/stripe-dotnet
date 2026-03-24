// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentDetailsFlightDatumTotalTaxOptions : INestedOptions
    {
        /// <summary>
        /// Array of tax details.
        /// </summary>
        [JsonProperty("taxes")]
        [STJS.JsonPropertyName("taxes")]
        public List<PaymentIntentPaymentDetailsFlightDatumTotalTaxTaxOptions> Taxes { get; set; }
    }
}
