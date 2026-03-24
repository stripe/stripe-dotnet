// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceFromInvoiceOptions : INestedOptions
    {
        /// <summary>
        /// The relation between the new invoice and the original invoice. Currently, only
        /// 'revision' is permitted.
        /// </summary>
        [JsonProperty("action")]
        [STJS.JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// The <c>id</c> of the invoice that will be cloned.
        /// </summary>
        [JsonProperty("invoice")]
        [STJS.JsonPropertyName("invoice")]
        public string Invoice { get; set; }
    }
}
