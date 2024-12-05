// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PersonalizationDesignRejectOptions : BaseOptions
    {
        /// <summary>
        /// The reason(s) the personalization design was rejected.
        /// </summary>
        [JsonProperty("rejection_reasons")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rejection_reasons")]
#endif
        public PersonalizationDesignRejectionReasonsOptions RejectionReasons { get; set; }
    }
}
