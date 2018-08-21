namespace Stripe
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Billing
    {
        [EnumMember(Value = "charge_automatically")]
        ChargeAutomatically,

        [EnumMember(Value = "send_invoice")]
        SendInvoice,
    }
}
