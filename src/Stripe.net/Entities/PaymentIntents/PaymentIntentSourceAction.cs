namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public enum PaymentIntentSourceActionType
    {
        Unknown,
        AuthorizeWithUrl,
        None,
    }

    [JsonConverter(typeof(PaymentIntentSourceActionConverter))]
    public class PaymentIntentSourceAction : StripeEntity
    {
        public PaymentIntentSourceActionType Type { get; set; }

        public PaymentIntentSourceActionAuthorizeWithUrl AuthorizeWithUrl { get; set; }
    }
}
