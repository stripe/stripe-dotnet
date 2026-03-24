// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PersonalizationDesignRejectOptions : BaseOptions
    {
        /// <summary>
        /// The reason(s) the personalization design was rejected.
        /// </summary>
        [JsonProperty("rejection_reasons")]
        [STJS.JsonPropertyName("rejection_reasons")]
        public PersonalizationDesignRejectionReasonsOptions RejectionReasons { get; set; }
    }
}
