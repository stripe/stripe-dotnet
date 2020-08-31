namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class BankAccountUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The name of the person or business that owns the bank account.
        /// </summary>
        [JsonProperty("account_holder_name")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The type of entity that holds the account. This can be either <c>individual</c> or
        /// <c>company</c>.
        /// </summary>
        [JsonProperty("account_holder_type")]
        public string AccountHolderType { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
