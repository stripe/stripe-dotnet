// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountTokenCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialCelticApplePayOptions : INestedOptions
    {
        /// <summary>
        /// The boolean value indicating if the terms of service have been accepted.
        /// </summary>
        [JsonProperty("shown_and_accepted")]
        [STJS.JsonPropertyName("shown_and_accepted")]
        public bool? ShownAndAccepted { get; set; }
    }
}
