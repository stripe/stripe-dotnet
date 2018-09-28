namespace Stripe
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class SourceCreateOptions : BaseOptions, ISupportMetadata
    {
        /// <summary>
        /// REQUIRED: The type of the source to create. One of type <see cref="SourceType"/>
        /// </summary>
        [FormProperty("type")]
        public string Type { get; set; }

        [FormProperty("alipay")]
        public string Alipay { get; set; }

        /// <summary>
        /// Amount associated with the source. This is the amount for which the source will be chargeable once ready. Required for single-use sources.
        /// </summary>
        [FormProperty("amount")]
        public int? Amount { get; set; }

        /// <summary>
        /// The currency associated with the source. This is the currency for which the source will be chargeable once ready.
        /// </summary>
        [FormProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The customer associated with the Source that you are trying to share with a Connected account.
        /// This only works with Stripe Connect as documented here: https://stripe.com/docs/sources/connect#shared-card-sources
        /// </summary>
        [FormProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The authentication flow of the source to create. Flow is one of <see cref="SourceFlow" />. It is generally inferred unless a type supports multiple flows.
        /// </summary>
        [FormProperty("flow")]
        public string Flow { get; set; }

        [FormProperty("bancontact[preferred_language]")]
        public string BancontactPreferredLanguage { get; set; }

        [FormProperty("card")]
        public CreditCardOptions Card { get; set; }

        [FormProperty("card")]
        public string CardId { get; set; }

        /// <summary>
        /// This parameter is used to create a Source from an issuing card mostly in Test mode.
        /// </summary>
        [FormProperty("card[issuing_card]")]
        public string IssuingCardId { get; set; }

        [FormProperty("ideal[bank]")]
        public string IdealBank { get; set; }

        [FormProperty("sepa_debit[iban]")]
        public string SepaDebitIban { get; set; }

        [FormProperty("sepa_debit[ideal]")]
        public string SepaDebitIdealSourceId { get; set; }

        [FormProperty("sofort[country]")]
        public string SofortCountry { get; set; }

        [FormProperty("[three_d_secure][customer]")]
        public string ThreeDSecureCustomer { get; set; }

        [FormProperty("[three_d_secure][card]")]
        public string ThreeDSecureCardOrSourceId { get; set; }

        /// <summary>
        /// Information about a mandate possiblity attached to a source object (generally for bank debits) as well as its acceptance status.
        /// </summary>
        [FormProperty("mandate")]
        public SourceMandateOptions Mandate { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to a source object. It can be useful for storing additional information about the source in a structured format.
        /// </summary>
        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The id of the Source that you are trying to share with a Connected account.
        /// This only works with Stripe Connect as documented here: https://stripe.com/docs/sources/connect#shared-card-sources
        /// </summary>
        [FormProperty("original_source")]
        public string OriginalSource { get; set; }

        /// <summary>
        /// Information about the owner of the payment instrument that may be used or required by particular source types.
        /// </summary>
        [FormProperty("owner")]
        public SourceOwnerOptions Owner { get; set; }

        /// <summary>
        /// <para>Parameters required for the redirect flow. Required if the source is authenticated by a redirect (flow is redirect).</para>
        /// <para>The URL you provide to redirect the customer back to you after they authenticated their payment. It can use your application URI scheme in the context of a mobile application.</para>
        /// </summary>
        [FormProperty("[redirect][return_url]")]
        public string RedirectReturnUrl { get; set; }

        /// <summary>
        /// Optional parameters for the receiver flow. Can be set only if the source is a receiver.
        /// </summary>
        [FormProperty("receiver")]
        public SourceReceiverOptions Receiver { get; set; }

        [FormProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// An optional token used to create the source. When passed, token properties will override source parameters.
        /// </summary>
        [FormProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// One of <see cref="SourceUsage" />. Whether this source should be reusable or not. Some source types may or may not be reusable by construction, while other may leave the option at creation. If an incompatible value is passed, an error will be returned.
        /// </summary>
        [FormProperty("usage")]
        public string Usage { get; set; }
    }
}
