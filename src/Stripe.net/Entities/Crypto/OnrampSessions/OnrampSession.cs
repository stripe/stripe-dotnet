// File generated from our OpenAPI spec
namespace Stripe.Crypto
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A Crypto Onramp Session represents your customer's session as they purchase
    /// cryptocurrency through Stripe. Once payment is successful, Stripe will fulfill the
    /// delivery of cryptocurrency to your user's wallet and contain a reference to the crypto
    /// transaction ID.
    ///
    /// You can create an onramp session on your server and embed the widget on your frontend.
    /// Alternatively, you can redirect your users to the standalone hosted onramp.
    ///
    /// Related guide: <a href="https://docs.stripe.com/crypto/integrate-the-onramp">Integrate
    /// the onramp</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OnrampSession : StripeEntity<OnrampSession>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// A client secret that can be used to drive a single session using our embedded widget.
        ///
        /// Related guide: <a href="https://docs.stripe.com/crypto/integrate-the-onramp">Set up an
        /// onramp integration</a>.
        /// </summary>
        [JsonProperty("client_secret")]
        [STJS.JsonPropertyName("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if any user kyc details were provided during the creation of
        /// the onramp session. Otherwise, has the value <c>false</c>.
        /// </summary>
        [JsonProperty("kyc_details_provided")]
        [STJS.JsonPropertyName("kyc_details_provided")]
        public bool KycDetailsProvided { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Redirect your users to the URL for a prebuilt frontend integration of the crypto onramp
        /// on the standalone hosted onramp.
        ///
        /// Related guide: <a
        /// href="https://docs.stripe.com/crypto/standalone-hosted-onramp#mint-a-session-with-a-redirect-url">Mint
        /// a session with a redirect url</a>.
        /// </summary>
        [JsonProperty("redirect_url")]
        [STJS.JsonPropertyName("redirect_url")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// The status of the Onramp Session. One of = <c>{initialized, rejected, requires_payment,
        /// fulfillment_processing, fulfillment_complete}</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonProperty("transaction_details")]
        [STJS.JsonPropertyName("transaction_details")]
        public OnrampSessionTransactionDetails TransactionDetails { get; set; }
    }
}
