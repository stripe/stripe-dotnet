namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Token : StripeEntityWithId
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("bank_account")]
        public BankAccount BankAccount { get; set; }

        [JsonProperty("card")]
        public Card Card { get; set; }

        [JsonProperty("client_ip")]
        public string ClientIp { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? Created { get; set; }

        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("used")]
        public bool? Used { get; set; }

        // TODO: remove
        [Obsolete("This property is not valid on tokens and will be removed in a later version.")]
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}