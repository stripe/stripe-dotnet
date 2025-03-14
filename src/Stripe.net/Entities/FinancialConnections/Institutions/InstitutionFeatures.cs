// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InstitutionFeatures : StripeEntity<InstitutionFeatures>
    {
        [JsonProperty("balances")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("balances")]
#endif
        public InstitutionFeaturesBalances Balances { get; set; }

        [JsonProperty("ownership")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ownership")]
#endif
        public InstitutionFeaturesOwnership Ownership { get; set; }

        [JsonProperty("payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method")]
#endif
        public InstitutionFeaturesPaymentMethod PaymentMethod { get; set; }

        [JsonProperty("transactions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transactions")]
#endif
        public InstitutionFeaturesTransactions Transactions { get; set; }
    }
}
