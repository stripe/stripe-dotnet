namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class TokenCreateOptions : BaseOptions
    {
        [JsonProperty("account")]
        public TokenAccountOptions Account { get; set; }

        [JsonProperty("bank_account")]
        public TokenBankAccountOptions BankAccount { get; set; }

        [JsonProperty("card")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<string, TokenCardOptions> Card { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("person")]
        public TokenPersonOptions Person { get; set; }

        [JsonProperty("pii")]
        public TokenPiiOptions Pii { get; set; }
    }
}
