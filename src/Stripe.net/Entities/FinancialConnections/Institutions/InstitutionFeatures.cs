// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;

    public class InstitutionFeatures : StripeEntity<InstitutionFeatures>
    {
        [JsonProperty("balances")]
        public InstitutionFeaturesBalances Balances { get; set; }

        [JsonProperty("ownership")]
        public InstitutionFeaturesOwnership Ownership { get; set; }

        [JsonProperty("payment_method")]
        public InstitutionFeaturesPaymentMethod PaymentMethod { get; set; }

        [JsonProperty("transactions")]
        public InstitutionFeaturesTransactions Transactions { get; set; }
    }
}
