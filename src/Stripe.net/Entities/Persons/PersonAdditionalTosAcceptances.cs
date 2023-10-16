// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PersonAdditionalTosAcceptances : StripeEntity<PersonAdditionalTosAcceptances>
    {
        [JsonProperty("account")]
        public PersonAdditionalTosAcceptancesAccount Account { get; set; }
    }
}
