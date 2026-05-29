// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractCreateOneTimeFeeBillScheduleOptions : INestedOptions
    {
        /// <summary>
        /// When this entry should be billed.
        /// </summary>
        [JsonProperty("bill_at")]
        [STJS.JsonPropertyName("bill_at")]
        public ContractCreateOneTimeFeeBillScheduleBillAtOptions BillAt { get; set; }

        /// <summary>
        /// The amount to bill for this entry, in the smallest currency unit.
        /// </summary>
        [JsonProperty("value")]
        [JsonConverter(typeof(Int64StringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("value")]
        public long? Value { get; set; }
    }
}
