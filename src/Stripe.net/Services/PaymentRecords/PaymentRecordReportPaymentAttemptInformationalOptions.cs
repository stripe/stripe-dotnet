// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentRecordReportPaymentAttemptInformationalOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Customer information for this payment.
        /// </summary>
        [JsonProperty("customer_details")]
        [STJS.JsonPropertyName("customer_details")]
        public PaymentRecordCustomerDetailsOptions CustomerDetails { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Shipping information for this payment.
        /// </summary>
        [JsonProperty("shipping_details")]
        [STJS.JsonPropertyName("shipping_details")]
        public PaymentRecordShippingDetailsOptions ShippingDetails { get; set; }
    }
}
