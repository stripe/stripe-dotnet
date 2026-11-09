// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PayoutIntentNextActionConfirm : StripeEntity<PayoutIntentNextActionConfirm>
    {
        /// <summary>
        /// The PayoutIntent fields that must be reviewed before confirmation.
        /// One of: <c>estimated_fees</c>, <c>fx_quote</c>, or <c>recipient_verification</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("fields_to_review")]
        [STJS.JsonPropertyName("fields_to_review")]
        public List<string> FieldsToReview { get; set; }

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
