namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class BankAccountCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// A set of key/value pairs that you can attach to an object. It can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// REQUIRED. Either a token, like the ones returned by
        /// <a href="https://stripe.com/docs/stripe.js">Stripe.js</a>, or a
        /// <see cref="SourceBankAccount"/> instance containing a user’s bank account
        /// details.
        /// </summary>
        [JsonProperty("source")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<string, SourceBankAccount> Source { get; set; }
    }
}
