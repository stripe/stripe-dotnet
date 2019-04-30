namespace Stripe
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionBillingCycleAnchor
    {
        /// <summary>Resets the subscription's billing cycle anchor to the current time.</summary>
        [EnumMember(Value = "now")]
        Now,

        /// <summary>Leaves the subscription's billing cycle anchor unchanged.</summary>
        [EnumMember(Value = "unchanged")]
        Unchanged,
    }
}
