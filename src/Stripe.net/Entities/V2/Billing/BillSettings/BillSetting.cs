// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// BillSetting is responsible for settings which dictate generating bills, which include
    /// settings for calculating totals on bills, tax on bill items, as well as how to generate
    /// and present invoices.
    /// </summary>
    public class BillSetting : StripeEntity<BillSetting>, IHasId, IHasObject
    {
        /// <summary>
        /// The ID of the BillSetting object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// Settings related to calculating a bill.
        /// </summary>
        [JsonProperty("calculation")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("calculation")]
#endif
        public BillSettingCalculation Calculation { get; set; }

        /// <summary>
        /// Timestamp of when the object was created.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// An optional field for adding a display name for the BillSetting object.
        /// </summary>
        [JsonProperty("display_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_name")]
#endif
        public string DisplayName { get; set; }

        /// <summary>
        /// Settings related to invoice behavior.
        /// </summary>
        [JsonProperty("invoice")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice")]
#endif
        public BillSettingInvoice Invoice { get; set; }

        /// <summary>
        /// The ID of the invoice rendering template to be used when generating invoices.
        /// </summary>
        [JsonProperty("invoice_rendering_template")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_rendering_template")]
#endif
        public string InvoiceRenderingTemplate { get; set; }

        /// <summary>
        /// The latest version of the current settings object. This will be Updated every time an
        /// attribute of the settings is updated.
        /// </summary>
        [JsonProperty("latest_version")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("latest_version")]
#endif
        public string LatestVersion { get; set; }

        /// <summary>
        /// The current live version of the settings object. This can be different from
        /// latest_version if settings are updated without setting live_version='latest'.
        /// </summary>
        [JsonProperty("live_version")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("live_version")]
#endif
        public string LiveVersion { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// A lookup key used to retrieve settings dynamically from a static string. This may be up
        /// to 200 characters.
        /// </summary>
        [JsonProperty("lookup_key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lookup_key")]
#endif
        public string LookupKey { get; set; }
    }
}
