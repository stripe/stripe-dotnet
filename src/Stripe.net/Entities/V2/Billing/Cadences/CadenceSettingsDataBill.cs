// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CadenceSettingsDataBill : StripeEntity<CadenceSettingsDataBill>
    {
        /// <summary>
        /// Settings related to calculating a bill.
        /// </summary>
        [JsonProperty("calculation")]
        [STJS.JsonPropertyName("calculation")]
        public CadenceSettingsDataBillCalculation Calculation { get; set; }

        /// <summary>
        /// Settings related to invoice behavior.
        /// </summary>
        [JsonProperty("invoice")]
        [STJS.JsonPropertyName("invoice")]
        public CadenceSettingsDataBillInvoice Invoice { get; set; }

        /// <summary>
        /// The ID of the invoice rendering template to be used when generating invoices.
        /// </summary>
        [JsonProperty("invoice_rendering_template")]
        [STJS.JsonPropertyName("invoice_rendering_template")]
        public string InvoiceRenderingTemplate { get; set; }
    }
}
