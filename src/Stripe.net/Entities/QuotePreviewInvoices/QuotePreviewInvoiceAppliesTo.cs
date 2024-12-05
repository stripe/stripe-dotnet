// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuotePreviewInvoiceAppliesTo : StripeEntity<QuotePreviewInvoiceAppliesTo>
    {
        /// <summary>
        /// A custom string that identifies a new subscription schedule being created upon quote
        /// acceptance. All quote lines with the same <c>new_reference</c> field will be applied to
        /// the creation of a new subscription schedule.
        /// </summary>
        [JsonProperty("new_reference")]
        public string NewReference { get; set; }

        /// <summary>
        /// The ID of the schedule the line applies to.
        /// </summary>
        [JsonProperty("subscription_schedule")]
        public string SubscriptionSchedule { get; set; }

        /// <summary>
        /// Describes whether the quote line is affecting a new schedule or an existing schedule.
        /// One of: <c>new_reference</c>, or <c>subscription_schedule</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
