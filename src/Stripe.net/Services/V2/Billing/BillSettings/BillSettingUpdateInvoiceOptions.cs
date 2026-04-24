// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class BillSettingUpdateInvoiceOptions : INestedOptions
    {
        /// <summary>
        /// The amount of time until the invoice is overdue for payment.
        /// </summary>
        [JsonProperty("time_until_due")]
        [STJS.JsonPropertyName("time_until_due")]
        public BillSettingUpdateInvoiceTimeUntilDueOptions TimeUntilDue { get; set; }
    }
}
