// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoicePaymentListOptions : ListOptions
    {
        /// <summary>
        /// Only return invoice payments that were created during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// The identifier of the invoice whose payments to return.
        /// </summary>
        [JsonProperty("invoice")]
        [STJS.JsonPropertyName("invoice")]
        public string Invoice { get; set; }

        /// <summary>
        /// The payment details of the invoice payments to return.
        /// </summary>
        [JsonProperty("payment")]
        [STJS.JsonPropertyName("payment")]
        public InvoicePaymentPaymentOptions Payment { get; set; }

        /// <summary>
        /// The status of the invoice payments to return.
        /// One of: <c>canceled</c>, <c>open</c>, or <c>paid</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
