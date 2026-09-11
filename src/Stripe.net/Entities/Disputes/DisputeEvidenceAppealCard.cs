// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class DisputeEvidenceAppealCard : StripeEntity<DisputeEvidenceAppealCard>
    {
        /// <summary>
        /// The reason for filing the appeal.
        /// </summary>
        [JsonProperty("reason_for_filing")]
        [STJS.JsonPropertyName("reason_for_filing")]
        public string ReasonForFiling { get; set; }

        /// <summary>
        /// One or more document IDs returned by a <a href="https://api.stripe.com#create_file">file
        /// upload</a> with a <c>purpose</c> value of <c>dispute_evidence</c> to support the appeal.
        /// </summary>
        [JsonProperty("supporting_files")]
        [STJS.JsonPropertyName("supporting_files")]
        public List<string> SupportingFiles { get; set; }
    }
}
