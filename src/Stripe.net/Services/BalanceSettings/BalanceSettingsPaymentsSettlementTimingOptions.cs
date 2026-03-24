// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class BalanceSettingsPaymentsSettlementTimingOptions : INestedOptions, IHasSetTracking
    {
        private long? delayDaysOverride;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Change <c>delay_days</c> for this account, which determines the number of days charge
        /// funds are held before becoming available. The maximum value is 31. Passing an empty
        /// string to <c>delay_days_override</c> will return <c>delay_days</c> to the default, which
        /// is the lowest available value for the account. <a
        /// href="https://stripe.com/connect/manage-payout-schedule">Learn more about controlling
        /// delay days</a>.
        /// </summary>
        [JsonProperty("delay_days_override")]
        [STJS.JsonPropertyName("delay_days_override")]
        public long? DelayDaysOverride
        {
            get => this.delayDaysOverride;
            set
            {
                this.delayDaysOverride = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
