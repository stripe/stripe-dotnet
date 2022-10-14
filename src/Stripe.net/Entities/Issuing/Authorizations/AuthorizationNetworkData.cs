// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class AuthorizationNetworkData : StripeEntity<AuthorizationNetworkData>
    {
        /// <summary>
        /// ID from the network that identifies the acquiring financial institution. For Visa and
        /// Mastercard credit transactions this is as 6 digit code. For Maestro debit transactions
        /// this is a 9 digit code. Uncommonly, acquiring institution ID is not provided. When this
        /// occurs, the value will be null.
        /// </summary>
        [JsonProperty("acquiring_institution_id")]
        public string AcquiringInstitutionId { get; set; }
    }
}
