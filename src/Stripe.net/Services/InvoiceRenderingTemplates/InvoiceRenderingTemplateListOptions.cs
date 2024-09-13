// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceRenderingTemplateListOptions : ListOptions
    {
        /// <summary>
        /// One of: <c>active</c>, or <c>archived</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
