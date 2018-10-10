namespace Stripe
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Stripe.Infrastructure;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentIntentSourceActionType
    {
        Unknown,

        [EnumMember(Value = "authorize_with_url")]
        AuthorizeWithUrl,
    }

    [JsonConverter(typeof(PaymentIntentSourceActionConverter))]
    public class PaymentIntentSourceAction : StripeEntity
    {
        public PaymentIntentSourceActionType Type { get; set; }

        public IPaymentIntentSourceActionValue Value { get; set; }
    }
}
