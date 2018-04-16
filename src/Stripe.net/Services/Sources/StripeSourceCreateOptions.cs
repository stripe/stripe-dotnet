using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeSourceCreateOptions : StripeBaseOptions, ISupportMetadata
    {
        /// <summary>
        /// REQUIRED: The type of the source to create. One of type <see cref="StripeSourceType"/>
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("alipay")]
        public string Alipay { get; set; }

        /// <summary>
        /// Amount associated with the source. This is the amount for which the source will be chargeable once ready. Required for single-use sources.
        /// </summary>
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        /// <summary>
        /// The currency associated with the source. This is the currency for which the source will be chargeable once ready.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The authentication flow of the source to create. Flow is one of <see cref="StripeSourceFlow" />. It is generally inferred unless a type supports multiple flows.
        /// </summary>
        [JsonProperty("flow")]
        public string Flow { get; set; }

        [JsonProperty("bancontact[preferred_language]")]
        public string BancontactPreferredLanguage { get; set; }

        [JsonProperty("card")]
        public StripeCreditCardOptions Card { get; set; }

        [JsonProperty("ideal[bank]")]
        public string IdealBank { get; set; }

        [JsonProperty("sepa_debit[iban]")]
        public string SepaDebitIban { get; set; }

        [JsonProperty("sepa_debit[ideal]")]
        public string SepaDebitIdealSourceId { get; set; }

        [JsonProperty("sofort[country]")]
        public string SofortCountry { get; set; }

        [JsonProperty("[three_d_secure][customer]")]
        public string ThreeDSecureCustomer { get; set; }

        [JsonProperty("[three_d_secure][card]")]
        public string ThreeDSecureCardOrSourceId { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to a source object. It can be useful for storing additional information about the source in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Information about the owner of the payment instrument that may be used or required by particular source types.
        /// </summary>
        [JsonProperty("owner")]
        public StripeSourceOwner Owner { get; set; }

        /// <summary>
        /// <para>Parameters required for the redirect flow. Required if the source is authenticated by a redirect (flow is redirect).</para>
        /// <para>The URL you provide to redirect the customer back to you after they authenticated their payment. It can use your application URI scheme in the context of a mobile application.</para>
        /// </summary>
        [JsonProperty("[redirect][return_url]")]
        public string RedirectReturnUrl { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// An optional token used to create the source. When passed, token properties will override source parameters.
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// One of <see cref="StripeSourceUsage" />. Whether this source should be reusable or not. Some source types may or may not be reusable by construction, while other may leave the option at creation. If an incompatible value is passed, an error will be returned.
        /// </summary>
        [JsonProperty("usage")]
        public string Usage { get; set; }
    }
}
