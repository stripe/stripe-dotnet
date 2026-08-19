// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentPlanCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The invoice(s) this payment plan collects on. Currently must contain exactly one invoice
        /// entry.
        /// </summary>
        [JsonProperty("collects_on")]
        [STJS.JsonPropertyName("collects_on")]
        public List<PaymentPlanCollectsOnOptions> CollectsOn { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The schedule defining how to split the invoice total into installments.
        /// </summary>
        [JsonProperty("schedule")]
        [STJS.JsonPropertyName("schedule")]
        public PaymentPlanScheduleOptions Schedule { get; set; }
    }
}
