namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public enum PaymentSourceType
    {
        Account,
        BankAccount,
        Card,
        Source,
    }

    [JsonConverter(typeof(PaymentSourceConverter))]
    public class PaymentSource : StripeEntity, IHasId
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        public PaymentSourceType Type { get; set; }

        public Account Account { get; set; }

        public BankAccount BankAccount { get; set; }

        public Card Card { get; set; }

        public Source SourceObject { get; set; }
    }
}
