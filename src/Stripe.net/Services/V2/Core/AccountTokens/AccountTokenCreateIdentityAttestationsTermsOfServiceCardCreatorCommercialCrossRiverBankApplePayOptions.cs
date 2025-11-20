// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountTokenCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialCrossRiverBankApplePayOptions : INestedOptions
    {
        /// <summary>
        /// The boolean value indicating if the terms of service have been accepted.
        /// </summary>
        [JsonProperty("shown_and_accepted")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shown_and_accepted")]
#endif
        public bool? ShownAndAccepted { get; set; }
    }
}
