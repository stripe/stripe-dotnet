namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// Source objects allow you to accept a variety of payment methods. They represent a customer's payment instrument and can be used with the Source API just like a card object: once chargeable, they can be charged, or attached to customers.
    /// </summary>
    public class Source : StripeEntity, IHasId, IHasMetadata, IHasObject, IPaymentSource
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Amount associated with the source. This is the amount for which the source will be chargeable once ready. Required for single-use sources.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// The client secret of the source. Used for client-side polling using a publishable key.
        /// </summary>
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Information related to the code verification flow. Present if the source is authenticated by a verification code (flow is code_verification).
        /// </summary>
        [JsonProperty("code_verification")]
        public SourceCodeVerification CodeVerification { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        /// <summary>
        /// The currency associated with the source. This is the currency for which the source will be chargeable once ready. Required for single-use sources.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The customer to which the source is attached, if any.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The authentication flow of the source. Flow is one of redirect, receiver, code_verification, none.
        /// </summary>
        [JsonProperty("flow")]
        public string Flow { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to a source object. It can be useful for storing additional information about the source in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Information about the owner of the payment instrument that may be used or required by particular source types.
        /// </summary>
        [JsonProperty("owner")]
        public SourceOwner Owner { get; set; }

        /// <summary>
        /// Information related to the receiver flow. Present if the source is a receiver (flow is receiver).
        /// </summary>
        [JsonProperty("receiver")]
        public SourceReceiver Receiver { get; set; }

        /// <summary>
        /// Information related to the redirect flow. Present if the source is authenticated by a redirect (flow is redirect).
        /// </summary>
        [JsonProperty("redirect")]
        public SourceRedirect Redirect { get; set; }

        /// <summary>
        /// Extra information about a source. This will appear on your customer’s statement every time you charge the source.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// The status of the charge, one of canceled, chargeable, consumed, failed, or pending. Only chargeable source objects can be used to create a charge.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// The type of the source. The type is a payment method, one of card, three_d_secure, giropay, sepa_debit, ideal, sofort, or bancontact.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// One of reusable, single-use. Whether this source should be reusable or not. Some source types may or may not be reusable by construction, while other may leave the option at creation. If an incompatible value is passed, an error will be returned.
        /// </summary>
        [JsonProperty("usage")]
        public string Usage { get; set; }

        /*
         * Type-specific attributes
         */

        [JsonProperty("ach_credit_transfer")]
        public SourceAchCreditTransfer AchCreditTransfer { get; set; }

        [JsonProperty("ach_debit")]
        public SourceAchDebit AchDebit { get; set; }

        [JsonProperty("alipay")]
        public SourceAlipay Alipay { get; set; }

        [JsonProperty("bancontact")]
        public SourceBancontact Bancontact { get; set; }

        [JsonProperty("bitcoin")]
        public SourceBitcoin Bitcoin { get; set; }

        [JsonProperty("card")]
        public SourceCard Card { get; set; }

        [JsonProperty("eps")]
        public SourceEps Eps { get; set; }

        [JsonProperty("giropay")]
        public SourceGiropay Giropay { get; set; }

        [JsonProperty("ideal")]
        public SourceIdeal Ideal { get; set; }

        [JsonProperty("multibanco")]
        public SourceMultibanco Multibanco { get; set; }

        [JsonProperty("p24")]
        public SourceP24 P24 { get; set; }

        [JsonProperty("sepa_credit_transfer")]
        public SourceSepaCreditTransfer SepaCreditTransfer { get; set; }

        [JsonProperty("sepa_debit")]
        public SourceSepaDebit SepaDebit { get; set; }

        [JsonProperty("sofort")]
        public SourceSofort Sofort { get; set; }

        [JsonProperty("three_d_secure")]
        public SourceThreeDSecure ThreeDSecure { get; set; }
    }
}
