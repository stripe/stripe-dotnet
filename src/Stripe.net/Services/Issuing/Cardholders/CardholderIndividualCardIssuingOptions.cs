// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardholderIndividualCardIssuingOptions : INestedOptions
    {
        /// <summary>
        /// Information about cardholder acceptance of Celtic <a
        /// href="https://stripe.com/docs/issuing/cards#accept-authorized-user-terms">Authorized
        /// User Terms</a>. Required for cards backed by a Celtic program.
        /// </summary>
        [JsonProperty("user_terms_acceptance")]
        public CardholderIndividualCardIssuingUserTermsAcceptanceOptions UserTermsAcceptance { get; set; }
    }
}
