// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class BillSettingVersion : StripeEntity<BillSettingVersion>, IHasId, IHasObject
    {
        /// <summary>
        /// The ID of the BillSettingVersion object.
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
        public BillSettingVersionCalculation Calculation { get; set; }

        /// <summary>
        /// Timestamp of when the object was created.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Settings related to invoice behavior.
        /// </summary>
        [JsonProperty("invoice")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice")]
#endif
        public BillSettingVersionInvoice Invoice { get; set; }

        /// <summary>
        /// The ID of the invoice rendering template to be used when generating invoices.
        /// </summary>
        [JsonProperty("invoice_rendering_template")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_rendering_template")]
#endif
        public string InvoiceRenderingTemplate { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }
    }
}
