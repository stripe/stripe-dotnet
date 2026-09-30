// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class DisputeEvidenceAppealCardOptions : INestedOptions, IHasSetTracking
    {
        private string reasonForFiling;
        private List<string> supportingFiles;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// An explanation of the reason for filing the appeal.
        /// </summary>
        [JsonProperty("reason_for_filing", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("reason_for_filing")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string ReasonForFiling
        {
            get => this.reasonForFiling;
            set
            {
                this.reasonForFiling = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// One or more document IDs returned by a <a
        /// href="https://docs.stripe.com/api#create_file">file upload</a> with a <c>purpose</c>
        /// value of <c>dispute_evidence</c> to support the appeal.
        /// </summary>
        [JsonProperty("supporting_files", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("supporting_files")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<string> SupportingFiles
        {
            get => this.supportingFiles;
            set
            {
                this.supportingFiles = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
