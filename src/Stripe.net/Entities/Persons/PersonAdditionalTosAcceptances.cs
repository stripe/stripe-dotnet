// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PersonAdditionalTosAcceptances : StripeEntity<PersonAdditionalTosAcceptances>
    {
        /// <summary>
        /// Details on the legal guardian's acceptance of the main Stripe service agreement.
        /// </summary>
        [JsonProperty("account")]
        public PersonAdditionalTosAcceptancesAccount Account { get; set; }
    }
}
