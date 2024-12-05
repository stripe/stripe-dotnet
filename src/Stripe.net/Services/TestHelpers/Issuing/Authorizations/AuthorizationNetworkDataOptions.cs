// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;

    public class AuthorizationNetworkDataOptions : INestedOptions
    {
        /// <summary>
        /// Identifier assigned to the acquirer by the card network.
        /// </summary>
        [JsonProperty("acquiring_institution_id")]
        public string AcquiringInstitutionId { get; set; }
    }
}
