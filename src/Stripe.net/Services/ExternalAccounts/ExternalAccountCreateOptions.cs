// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ExternalAccountCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// When set to true, or if this is the first external account added in this currency, this
        /// account becomes the default external account for its currency.
        /// </summary>
        [JsonProperty("default_for_currency")]
        [STJS.JsonPropertyName("default_for_currency")]
        public bool? DefaultForCurrency { get; set; }

        /// <summary>
        /// Either a token, like the ones returned by <a
        /// href="https://docs.stripe.com/js">Stripe.js</a>, or a dictionary containing a user’s
        /// external account details (with the options shown below).
        /// </summary>
        [JsonProperty("external_account")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("external_account")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<string, ExternalAccountCardOptions, AccountBankAccountOptions, ExternalAccountCardTokenOptions> ExternalAccount { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
