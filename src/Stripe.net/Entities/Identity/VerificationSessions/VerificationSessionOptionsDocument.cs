// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class VerificationSessionOptionsDocument : StripeEntity<VerificationSessionOptionsDocument>
    {
        /// <summary>
        /// Restrict the list of allowed document type to these types.
        /// </summary>
        [JsonProperty("allowed_types")]
        public List<string> AllowedTypes { get; set; }

        /// <summary>
        /// Require that the user provide an id number which will be verified.
        /// </summary>
        [JsonProperty("require_id_number")]
        public bool RequireIdNumber { get; set; }

        /// <summary>
        /// Require that the user capture documents live with their webcam or phone camera.
        /// </summary>
        [JsonProperty("require_live_capture")]
        public bool RequireLiveCapture { get; set; }

        /// <summary>
        /// Require that the user provide a selfie to compare against the document photo.
        /// </summary>
        [JsonProperty("require_matching_selfie")]
        public bool RequireMatchingSelfie { get; set; }
    }
}
