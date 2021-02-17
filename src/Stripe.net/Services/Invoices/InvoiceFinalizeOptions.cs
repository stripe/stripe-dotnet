// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceFinalizeOptions : BaseOptions
    {
        /// <summary>
        /// Controls whether Stripe will perform <a
        /// href="https://stripe.com/docs/billing/invoices/overview#auto-advance">automatic
        /// collection</a> of the invoice. When <c>false</c>, the invoice's state will not
        /// automatically advance without an explicit action.
        /// </summary>
        [JsonProperty("auto_advance")]
        public bool? AutoAdvance { get; set; }
    }
}
