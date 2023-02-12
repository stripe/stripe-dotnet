// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuotePreviewInvoiceLinesOptions : ListOptions
    {
        [JsonProperty("applies_to")]
        public QuoteAppliesToOptions AppliesTo { get; set; }
    }
}
