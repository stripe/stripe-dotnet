namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class OrderPayOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// A fee in %s that will be applied to the order and transferred to the application owner's
        /// Stripe account. The request must be made with an OAuth key or the <c>Stripe-Account</c>
        /// header in order to take an application fee. For more information, see the application
        /// fees <a
        /// href="https://stripe.com/docs/connect/direct-charges#collecting-fees">documentation</a>.
        /// </summary>
        [JsonProperty("application_fee")]
        public long? ApplicationFee { get; set; }

        /// <summary>
        /// The ID of an existing customer that will be charged for this order. If no customer was
        /// attached to the order at creation, either <c>source</c> or <c>customer</c> is required.
        /// Otherwise, the specified customer will be charged instead of the one attached to the
        /// order.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The email address of the customer placing the order. Required if not previously
        /// specified for the order.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// A <a href="https://stripe.com/docs/api#tokens">Token</a>'s or a <a
        /// href="https://stripe.com/docs/api#sources">Source</a>'s ID, as returned by <a
        /// href="https://stripe.com/docs/elements">Elements</a>. If no customer was attached to the
        /// order at creation, either <c>source</c> or <c>customer</c> is required. Otherwise, the
        /// specified source will be charged intead of the customer attached to the order.
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }
    }
}
