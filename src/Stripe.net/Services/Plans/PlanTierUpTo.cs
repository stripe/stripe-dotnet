namespace Stripe
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PlanTierUpTo
    {
        /// <summary>Use this value to define a fallback tier.</summary>
        [EnumMember(Value = "inf")]
        Inf,
    }
}
