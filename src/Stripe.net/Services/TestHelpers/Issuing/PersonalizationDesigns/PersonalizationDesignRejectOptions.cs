// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;

    public class PersonalizationDesignRejectOptions : BaseOptions
    {
        /// <summary>
        /// The reason(s) the personalization design was rejected.
        /// </summary>
        [JsonProperty("rejection_reasons")]
        public PersonalizationDesignRejectionReasonsOptions RejectionReasons { get; set; }
    }
}
