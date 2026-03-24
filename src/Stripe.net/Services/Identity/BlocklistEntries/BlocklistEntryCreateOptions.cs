// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class BlocklistEntryCreateOptions : BaseOptions
    {
        /// <summary>
        /// When true, the created BlocklistEntry will be used to retroactively unverify matching
        /// verifications.
        /// </summary>
        [JsonProperty("check_existing_verifications")]
        [STJS.JsonPropertyName("check_existing_verifications")]
        public bool? CheckExistingVerifications { get; set; }

        /// <summary>
        /// The type of blocklist entry to be created.
        /// One of: <c>document</c>, or <c>selfie</c>.
        /// </summary>
        [JsonProperty("entry_type")]
        [STJS.JsonPropertyName("entry_type")]
        public string EntryType { get; set; }

        /// <summary>
        /// The identifier of the VerificationReport to create the BlocklistEntry from.
        /// </summary>
        [JsonProperty("verification_report")]
        [STJS.JsonPropertyName("verification_report")]
        public string VerificationReport { get; set; }
    }
}
