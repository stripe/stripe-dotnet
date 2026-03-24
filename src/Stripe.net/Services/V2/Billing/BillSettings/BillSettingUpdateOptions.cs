// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class BillSettingUpdateOptions : BaseOptions
    {
        /// <summary>
        /// Settings related to calculating a bill.
        /// </summary>
        [JsonProperty("calculation")]
        [STJS.JsonPropertyName("calculation")]
        public BillSettingUpdateCalculationOptions Calculation { get; set; }

        /// <summary>
        /// An optional customer-facing display name for the BillSetting object. To remove the
        /// display name, set it to an empty string in the request. Maximum length of 250
        /// characters.
        /// </summary>
        [JsonProperty("display_name")]
        [STJS.JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Settings related to invoice behavior.
        /// </summary>
        [JsonProperty("invoice")]
        [STJS.JsonPropertyName("invoice")]
        public BillSettingUpdateInvoiceOptions Invoice { get; set; }

        /// <summary>
        /// The ID of the invoice rendering template to be used when generating invoices.
        /// </summary>
        [JsonProperty("invoice_rendering_template")]
        [STJS.JsonPropertyName("invoice_rendering_template")]
        public string InvoiceRenderingTemplate { get; set; }

        /// <summary>
        /// Optionally change the live version of the BillSetting. Providing <c>live_version =
        /// "latest"</c> will set the BillSetting' <c>live_version</c> to its latest version.
        /// </summary>
        [JsonProperty("live_version")]
        [STJS.JsonPropertyName("live_version")]
        public string LiveVersion { get; set; }

        /// <summary>
        /// A lookup key used to retrieve settings dynamically from a static string. This may be up
        /// to 200 characters.
        /// </summary>
        [JsonProperty("lookup_key")]
        [STJS.JsonPropertyName("lookup_key")]
        public string LookupKey { get; set; }
    }
}
