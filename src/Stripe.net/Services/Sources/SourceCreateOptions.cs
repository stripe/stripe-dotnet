namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceCreateOptions : BaseOptions
    {
        /// <summary>
        /// REQUIRED: The type of the source to create. One of type <see cref="SourceType"/>
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("alipay")]
        public string Alipay { get; set; }

        /// <summary>
        /// Amount associated with the source. This is the amount for which the source will be chargeable once ready. Required for single-use sources.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// The currency associated with the source. This is the currency for which the source will be chargeable once ready.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The customer associated with the Source that you are trying to share with a Connected account.
        /// This only works with Stripe Connect as documented here: https://stripe.com/docs/sources/connect#shared-card-sources
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The authentication flow of the source to create. Flow is one of <see cref="SourceFlow" />. It is generally inferred unless a type supports multiple flows.
        /// </summary>
        [JsonProperty("flow")]
        public string Flow { get; set; }

        /// <summary>
        /// Information about a mandate possiblity attached to a source object (generally for bank debits) as well as its acceptance status.
        /// </summary>
        [JsonProperty("mandate")]
        public SourceMandateOptions Mandate { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to a source object. It can be useful for storing additional information about the source in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The id of the Source that you are trying to share with a Connected account.
        /// This only works with Stripe Connect as documented here: https://stripe.com/docs/sources/connect#shared-card-sources
        /// </summary>
        [JsonProperty("original_source")]
        public string OriginalSource { get; set; }

        /// <summary>
        /// Information about the owner of the payment instrument that may be used or required by particular source types.
        /// </summary>
        [JsonProperty("owner")]
        public SourceOwnerOptions Owner { get; set; }

        /// <summary>
        /// <para>Parameters required for the redirect flow. Required if the source is authenticated by a redirect (flow is redirect).</para>
        /// </summary>
        [JsonProperty("redirect")]
        public SourceRedirectOptions Redirect { get; set; }

        /// <summary>
        /// Optional parameters for the receiver flow. Can be set only if the source is a receiver.
        /// </summary>
        [JsonProperty("receiver")]
        public SourceReceiverOptions Receiver { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// An optional token used to create the source. When passed, token properties will override source parameters.
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// One of <see cref="SourceUsage" />. Whether this source should be reusable or not. Some source types may or may not be reusable by construction, while other may leave the option at creation. If an incompatible value is passed, an error will be returned.
        /// </summary>
        [JsonProperty("usage")]
        public string Usage { get; set; }

        /*
           Below we group all Source type specific paramters
        */

        [JsonProperty("au_becs_debit")]
        public SourceAuBecsDebitCreateOptions AuBecsDebit { get; set; }

        [JsonProperty("bancontact")]
        public SourceBancontactCreateOptions Bancontact { get; set; }

        [JsonProperty("card")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<string, CreditCardOptions> Card { get; set; }

        [JsonProperty("ideal")]
        public SourceIdealCreateOptions Ideal { get; set; }

        [JsonProperty("sepa_debit")]
        public SourceSepaDebitCreateOptions SepaDebit { get; set; }

        [JsonProperty("sofort")]
        public SourceSofortCreateOptions Sofort { get; set; }

        [JsonProperty("three_d_secure")]
        public SourceThreeDSecureCreateOptions ThreeDSecure { get; set; }
    }
}
