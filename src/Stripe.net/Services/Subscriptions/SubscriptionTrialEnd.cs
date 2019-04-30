namespace Stripe
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionTrialEnd
    {
        /// <summary>Special value used to end a customer's trial immediately.</summary>
        [EnumMember(Value = "now")]
        Now,
    }
}
