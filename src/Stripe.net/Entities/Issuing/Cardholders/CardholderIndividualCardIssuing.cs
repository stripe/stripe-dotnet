// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CardholderIndividualCardIssuing : StripeEntity<CardholderIndividualCardIssuing>
    {
        /// <summary>
        /// Information about cardholder acceptance of Celtic <a
        /// href="https://docs.stripe.com/issuing/compliance-us#issuing-terms">Authorized User
        /// Terms</a>. Required for cards backed by a Celtic program.
        /// </summary>
        [JsonProperty("user_terms_acceptance")]
        [STJS.JsonPropertyName("user_terms_acceptance")]
        public CardholderIndividualCardIssuingUserTermsAcceptance UserTermsAcceptance { get; set; }
    }
}
