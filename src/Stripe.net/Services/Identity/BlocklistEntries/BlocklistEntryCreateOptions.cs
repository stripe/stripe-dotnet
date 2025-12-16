// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class BlocklistEntryCreateOptions : BaseOptions
    {
        /// <summary>
        /// When true, the created BlocklistEntry will be used to retroactively unverify matching
        /// verifications.
        /// </summary>
        [JsonProperty("check_existing_verifications")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("check_existing_verifications")]
#endif
        public bool? CheckExistingVerifications { get; set; }

        /// <summary>
        /// The type of blocklist entry to be created.
        /// One of: <c>document</c>, or <c>selfie</c>.
        /// </summary>
        [JsonProperty("entry_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("entry_type")]
#endif
        public string EntryType { get; set; }

        /// <summary>
        /// The identifier of the VerificationReport to create the BlocklistEntry from.
        /// </summary>
        [JsonProperty("verification_report")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("verification_report")]
#endif
        public string VerificationReport { get; set; }
    }
}
