// File generated from our OpenAPI spec
namespace Stripe.ThreeDSecure
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AuthenticationSubmitOptions : BaseOptions, IHasMetadata
    {
        private Dictionary<string, string> metadata;

        /// <summary>
        /// The fingerprinting result of the issuer fingerprinting step.
        ///
        /// Refer to the <a
        /// href="https://stripe.com/payments/3d-secure/standalone-3d-secure#issuer-fingerprinting">Issuer
        /// fingerprinting section of the Standalone 3DS guide</a> for more information.
        /// </summary>
        [JsonProperty("fingerprinting_result")]
        [STJS.JsonPropertyName("fingerprinting_result")]
        public string FingerprintingResult { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("metadata")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
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
