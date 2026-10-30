// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractTermAdHocProduct : StripeEntity<ContractTermAdHocProduct>
    {
        /// <summary>
        /// Explicit bill dates and amounts, including billed history.
        /// </summary>
        [JsonProperty("bill_schedule")]
        [STJS.JsonPropertyName("bill_schedule")]
        public ContractTermAdHocProductBillSchedule BillSchedule { get; set; }

        /// <summary>
        /// The V1 Product being billed.
        /// </summary>
        [JsonProperty("product")]
        [STJS.JsonPropertyName("product")]
        public string Product { get; set; }

        /// <summary>
        /// Informational invoice and revenue-recognition period with timestamp objects; does not
        /// affect billing or proration.
        /// </summary>
        [JsonProperty("service_period")]
        [STJS.JsonPropertyName("service_period")]
        public ContractTermAdHocProductServicePeriod ServicePeriod { get; set; }
    }
}
