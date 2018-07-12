using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Stripe
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StripeBilling
    {
        [EnumMember(Value = "charge_automatically")]
        ChargeAutomatically,

        [EnumMember(Value = "send_invoice")]
        SendInvoice,
    }
}
