namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsCard : StripeEntity<ChargePaymentMethodDetailsCard>
    {
        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("checks")]
        public ChargePaymentMethodDetailsCardChecks Checks { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("exp_month")]
        public long ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        public long ExpYear { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("funding")]
        public string Funding { get; set; }

        [JsonProperty("iin")]
        public string Iin { get; set; }

        [JsonProperty("installments")]
        public ChargePaymentMethodDetailsCardInstallments Installments { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("last4")]
        public string Last4 { get; set; }

        [JsonProperty("moto")]
        public bool? Moto { get; set; }

        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("three_d_secure")]
        public ChargePaymentMethodDetailsCardThreeDSecure ThreeDSecure { get; set; }

        [JsonProperty("wallet")]
        public ChargePaymentMethodDetailsCardWallet Wallet { get; set; }
    }
}
