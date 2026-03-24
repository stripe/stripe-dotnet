// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InstitutionFeatures : StripeEntity<InstitutionFeatures>
    {
        [JsonProperty("balances")]
        [STJS.JsonPropertyName("balances")]
        public InstitutionFeaturesBalances Balances { get; set; }

        [JsonProperty("ownership")]
        [STJS.JsonPropertyName("ownership")]
        public InstitutionFeaturesOwnership Ownership { get; set; }

        [JsonProperty("payment_method")]
        [STJS.JsonPropertyName("payment_method")]
        public InstitutionFeaturesPaymentMethod PaymentMethod { get; set; }

        [JsonProperty("transactions")]
        [STJS.JsonPropertyName("transactions")]
        public InstitutionFeaturesTransactions Transactions { get; set; }
    }
}
