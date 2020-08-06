namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionScheduleDefaultSettingsBillingThresholdsOptions : INestedOptions
    {
        [JsonProperty("amount_gte")]
        public long? AmountGte { get; set; }

        [JsonProperty("reset_billing_cycle_anchor")]
        public bool? ResetBillingCycleAnchor { get; set; }
    }
}
