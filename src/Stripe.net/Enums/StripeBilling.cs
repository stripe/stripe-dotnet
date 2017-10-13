using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

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
