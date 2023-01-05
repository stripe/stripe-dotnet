// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardholderIndividualCardIssuing : StripeEntity<CardholderIndividualCardIssuing>
    {
        /// <summary>
        /// Information about cardholder acceptance of <a
        /// href="https://stripe.com/docs/issuing/cards">Authorized User Terms</a>.
        /// </summary>
        [JsonProperty("user_terms_acceptance")]
        public CardholderIndividualCardIssuingUserTermsAcceptance UserTermsAcceptance { get; set; }
    }
}
