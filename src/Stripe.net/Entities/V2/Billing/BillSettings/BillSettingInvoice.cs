// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class BillSettingInvoice : StripeEntity<BillSettingInvoice>
    {
        /// <summary>
        /// The amount of time until the invoice will be overdue for payment.
        /// </summary>
        [JsonProperty("time_until_due")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("time_until_due")]
#endif
        public BillSettingInvoiceTimeUntilDue TimeUntilDue { get; set; }
    }
}
