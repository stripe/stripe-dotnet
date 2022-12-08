// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class AuthorizationNetworkData : StripeEntity<AuthorizationNetworkData>
    {
        /// <summary>
        /// Identifier assigned to the acquirer by the card network. Sometimes this value is not
        /// provided by the network; in this case, the value will be <c>null</c>.
        /// </summary>
        [JsonProperty("acquiring_institution_id")]
        public string AcquiringInstitutionId { get; set; }
    }
}
