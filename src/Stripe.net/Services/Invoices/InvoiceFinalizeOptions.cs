// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceFinalizeOptions : BaseOptions
    {
        /// <summary>
        /// Controls whether Stripe performs <a
        /// href="https://stripe.com/docs/invoicing/integration/automatic-advancement-collection">automatic
        /// collection</a> of the invoice. If <c>false</c>, the invoice's state doesn't
        /// automatically advance without an explicit action.
        /// </summary>
        [JsonProperty("auto_advance")]
        public bool? AutoAdvance { get; set; }
    }
}
