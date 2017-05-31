using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    /// <summary>
    /// Source objects allow you to accept a variety of payment methods. They represent a customer's payment instrument and can be used with the Stripe API just like a card object: once chargeable, they can be charged, or attached to customers.
    /// </summary>
    public class StripeSource : StripeEntityWithId
    {
        [JsonProperty("object")]
        public string Object => "source";

        /// <summary>
        /// Amount associated with the source. This is the amount for which the source will be chargeable once ready. Required for single-use sources.
        /// </summary>
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        /// <summary>
        /// The client secret of the source. Used for client-side polling using a publishable key.
        /// </summary>
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Information related to the code verification flow. Present if the source is authenticated by a verification code (flow is code_verification).
        /// </summary>
        [JsonProperty("code_verification")]
        public StripeCodeVerification CodeVerification { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime Created { get; set; }

        /// <summary>
        /// The currency associated with the source. This is the currency for which the source will be chargeable once ready. Required for single-use sources.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The authentication flow of the source. Flow is one of redirect, receiver, code_verification, none.
        /// </summary>
        [JsonProperty("flow")]
        public string Flow { get; set; }

        [JsonProperty("ideal")]
        public StripeIdeal Ideal { get; set; }

        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to a source object. It can be useful for storing additional information about the source in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Information about the owner of the payment instrument that may be used or required by particular source types.
        /// </summary>
        [JsonProperty("owner")]
        public StripeOwner Owner { get; set; }

        /// <summary>
        /// Information related to the receiver flow. Present if the source is a receiver (flow is receiver).
        /// </summary>
        [JsonProperty("receiver")]
        public StripeReceiver Receiver { get; set; }

        /// <summary>
        /// Information related to the redirect flow. Present if the source is authenticated by a redirect (flow is redirect).
        /// </summary>
        [JsonProperty("redirect")]
        public StripeRedirect Redirect { get; set; }

        [JsonProperty("bitcoin")]
        public StripeBitcoin Bitcoin { get; set; }

        [JsonProperty("bancontact")]
        public StripeBancontact Bancontact { get; set; }

        [JsonProperty("sepa_debit")]
        public StripeSepaDebit SepaDebit { get; set; }

        [JsonProperty("sofort")]
        public StripeSofort Sofort { get; set; }

        [JsonProperty("card")]
        public StripeSourceCard Card { get; set; }

        [JsonProperty("three_d_secure")]
        public StripeThreeDSecure ThreeDSecure { get; set; }

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
    }
}
