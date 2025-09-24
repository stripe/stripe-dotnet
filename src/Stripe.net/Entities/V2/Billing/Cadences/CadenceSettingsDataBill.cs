// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CadenceSettingsDataBill : StripeEntity<CadenceSettingsDataBill>
    {
        /// <summary>
        /// Settings related to calculating a bill.
        /// </summary>
        [JsonProperty("calculation")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("calculation")]
#endif
        public CadenceSettingsDataBillCalculation Calculation { get; set; }

        /// <summary>
        /// Settings related to invoice behavior.
        /// </summary>
        [JsonProperty("invoice")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice")]
#endif
        public CadenceSettingsDataBillInvoice Invoice { get; set; }

        /// <summary>
        /// The ID of the invoice rendering template to be used when generating invoices.
        /// </summary>
        [JsonProperty("invoice_rendering_template")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_rendering_template")]
#endif
        public string InvoiceRenderingTemplate { get; set; }
    }
}
