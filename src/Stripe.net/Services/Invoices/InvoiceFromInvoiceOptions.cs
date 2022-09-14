// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceFromInvoiceOptions : INestedOptions
    {
        /// <summary>
        /// The relation between the new invoice and the original invoice. Currently, only
        /// 'revision' is permitted.
        /// </summary>
        [JsonProperty("action")]
        public string Action { get; set; }

        /// <summary>
        /// The <c>id</c> of the invoice that will be cloned.
        /// </summary>
        [JsonProperty("invoice")]
        public string Invoice { get; set; }
    }
}
