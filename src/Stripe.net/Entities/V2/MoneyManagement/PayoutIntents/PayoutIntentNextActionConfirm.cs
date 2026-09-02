// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PayoutIntentNextActionConfirm : StripeEntity<PayoutIntentNextActionConfirm>
    {
        /// <summary>
        /// Open Enum. The reason the PayoutIntent requires confirmation.
        /// One of: <c>automatically_required</c>, or <c>manually_requested</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
