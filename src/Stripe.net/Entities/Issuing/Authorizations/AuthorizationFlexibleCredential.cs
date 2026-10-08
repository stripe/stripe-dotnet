// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthorizationFlexibleCredential : StripeEntity<AuthorizationFlexibleCredential>
    {
        /// <summary>
        /// The authorization identifier of a prior product eligibility inquiry that selected the
        /// credential for this authorization, if exists.
        /// </summary>
        [JsonProperty("product_eligibility_inquiry")]
        [STJS.JsonPropertyName("product_eligibility_inquiry")]
        public string ProductEligibilityInquiry { get; set; }

        /// <summary>
        /// Details about the eligible secondary credentials for this authorization.
        /// </summary>
        [JsonProperty("secondary_credentials")]
        [STJS.JsonPropertyName("secondary_credentials")]
        public List<AuthorizationFlexibleCredentialSecondaryCredential> SecondaryCredentials { get; set; }

        /// <summary>
        /// The <c>key</c> of the selected secondary credential for this authorization. Null if the
        /// card's primary credential was selected.
        /// </summary>
        [JsonProperty("selected_secondary")]
        [STJS.JsonPropertyName("selected_secondary")]
        public string SelectedSecondary { get; set; }
    }
}
