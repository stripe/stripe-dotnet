// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using Newtonsoft.Json;

    public class ConfirmationTokenPaymentMethodDataNaverPayOptions : INestedOptions
    {
        /// <summary>
        /// Whether to use Naver Pay points or a card to fund this transaction. If not provided,
        /// this defaults to <c>card</c>.
        /// One of: <c>card</c>, or <c>points</c>.
        /// </summary>
        [JsonProperty("funding")]
        public string Funding { get; set; }
    }
}
