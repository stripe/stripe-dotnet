namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CardCreateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("default_for_currency")]
        public bool? DefaultForCurrency { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can
        /// be useful for storing additional information about the object in a
        /// structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// REQUIRED. Either a token, like the ones returned by
        /// <a href="https://stripe.com/docs/stripe.js">Stripe.js</a>, or a
        /// <see cref="CardCreateNestedOptions"/> instance containing a user's card
        /// details.
        /// </summary>
        [JsonProperty("source")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<string, CardCreateNestedOptions> Source { get; set; }

        [JsonProperty("validate")]
        public bool? Validate { get; set; }
    }
}
