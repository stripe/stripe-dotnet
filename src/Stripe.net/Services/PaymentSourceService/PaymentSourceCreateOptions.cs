namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentSourceCreateOptions : BaseOptions
    {
        /// <summary>
        /// Either a token, like the ones returned by
        /// <a href="https://stripe.com/docs/stripe.js">Stripe.js</a>, or a
        /// <see cref="SourceBankAccount"/> instance containing a user's bank account details.
        /// </summary>
        [JsonProperty("bank_account")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<string, SourceBankAccount> BankAccount { get; set; }

        /// <summary>
        /// A token, like the ones returned by
        /// <a href="https://stripe.com/docs/stripe.js">Stripe.js</a>.
        /// </summary>
        [JsonProperty("card")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<string, CardCreateNestedOptions> Card { get; set; }

        /// <summary>
        /// A set of key-value pairs that you can attach to a card object. It can be useful for
        /// storing additional information about the card in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Please refer to full <a href="https://stripe.com/docs/api">documentation</a> instead.
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }
   }
}
