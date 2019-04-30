namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ExternalAccountCreateOptions : BaseOptions
    {
        /// <summary>
        /// REQUIRED. Either a token, like the ones returned by
        /// <a href="https://stripe.com/docs/stripe.js">Stripe.js</a>, or a
        /// <see cref="AccountBankAccountOptions"/> instance containing a user’s bank account
        /// details.
        /// </summary>
        [JsonProperty("external_account")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<string, AccountBankAccountOptions> ExternalAccount { get; set; }

        /// <summary>
        /// When set to <c>true</c>, or if this is the first external account added in this
        /// currency, this account becomes the default external account for its currency.
        /// </summary>
        [JsonProperty("default_for_currency")]
        public bool? DefaultForCurrency { get; set; }

        /// <summary>
        /// A set of key-value pairs that you can attach to an external account object. It can be
        /// useful for storing additional information about the external account in a structured
        /// format.
        /// </summary>
         [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
   }
}
