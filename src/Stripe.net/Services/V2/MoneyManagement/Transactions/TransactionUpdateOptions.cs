// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class TransactionUpdateOptions : BaseOptions, IHasMetadata
    {
        private Dictionary<string, string> metadata;

        /// <summary>
        /// A description of the Transaction, up to 100 characters. Pass <c>null</c> to clear the
        /// description, or omit this parameter to leave it unchanged.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to the Transaction. Individual keys can be
        /// unset by posting null to them.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("metadata")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        [STJS.JsonConverter(typeof(STJNullPreservingDictionaryConverter))]
        public Dictionary<string, string> Metadata
        {
            get => this.metadata;
            set
            {
                this.metadata = value;
                this.SetTracker.Track();
            }
        }
    }
}
