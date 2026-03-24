// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class BillSettingVersionInvoice : StripeEntity<BillSettingVersionInvoice>
    {
        /// <summary>
        /// The amount of time until the invoice will be overdue for payment.
        /// </summary>
        [JsonProperty("time_until_due")]
        [STJS.JsonPropertyName("time_until_due")]
        public BillSettingVersionInvoiceTimeUntilDue TimeUntilDue { get; set; }
    }
}
