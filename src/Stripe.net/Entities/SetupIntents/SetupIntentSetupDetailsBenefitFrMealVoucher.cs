// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SetupIntentSetupDetailsBenefitFrMealVoucher : StripeEntity<SetupIntentSetupDetailsBenefitFrMealVoucher>
    {
        /// <summary>
        /// The 14-digit SIRET of the meal voucher acceptor.
        /// </summary>
        [JsonProperty("siret")]
        [STJS.JsonPropertyName("siret")]
        public string Siret { get; set; }
    }
}
