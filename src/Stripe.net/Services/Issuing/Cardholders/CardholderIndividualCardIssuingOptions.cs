// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardholderIndividualCardIssuingOptions : INestedOptions
    {
        /// <summary>
        /// Information about cardholder acceptance of <a
        /// href="https://stripe.com/docs/issuing/cards">Authorized User Terms</a>.
        /// </summary>
        [JsonProperty("user_terms_acceptance")]
        public CardholderIndividualCardIssuingUserTermsAcceptanceOptions UserTermsAcceptance { get; set; }
    }
}
