namespace Stripe
{
    using Newtonsoft.Json;

    public class PromotionCodeRestrictions : StripeEntity<PromotionCodeRestrictions>
    {
        [JsonProperty("first_time_transaction")]
        public bool FirstTimeTransaction { get; set; }

        [JsonProperty("minimum_amount")]
        public long? MinimumAmount { get; set; }

        [JsonProperty("minimum_amount_currency")]
        public string MinimumAmountCurrency { get; set; }
    }
}
