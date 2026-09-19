// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Whether a project is eligible to provision resources with a provider, and any
    /// outstanding KYC requirements that must be satisfied first.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Eligibility : StripeEntity<Eligibility>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Whether the project is eligible to provision resources with the provider.
        /// </summary>
        [JsonProperty("is_eligible")]
        [STJS.JsonPropertyName("is_eligible")]
        public bool IsEligible { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Outstanding requirements that must be satisfied before the project is eligible, if any.
        /// </summary>
        [JsonProperty("requirements")]
        [STJS.JsonPropertyName("requirements")]
        public List<string> Requirements { get; set; }
    }
}
