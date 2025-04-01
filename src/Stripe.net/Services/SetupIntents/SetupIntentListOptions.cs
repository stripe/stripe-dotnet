// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SetupIntentListOptions : ListOptions
    {
        /// <summary>
        /// If present, the SetupIntent's payment method will be attached to the in-context Stripe
        /// Account.
        ///
        /// It can only be used for this Stripe Account’s own money movement flows like
        /// InboundTransfer and OutboundTransfers. It cannot be set to true when setting up a
        /// PaymentMethod for a Customer, and defaults to false when attaching a PaymentMethod to a
        /// Customer.
        /// </summary>
        [JsonProperty("attach_to_self")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("attach_to_self")]
#endif
        public bool? AttachToSelf { get; set; }

        /// <summary>
        /// A filter on the list, based on the object <c>created</c> field. The value can be a
        /// string with an integer Unix timestamp, or it can be a dictionary with a number of
        /// different query options.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Only return SetupIntents for the customer specified by this customer ID.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// Only return SetupIntents for the account specified by this customer ID.
        /// </summary>
        [JsonProperty("customer_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_account")]
#endif
        public string CustomerAccount { get; set; }

        /// <summary>
        /// Only return SetupIntents that associate with the specified payment method.
        /// </summary>
        [JsonProperty("payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method")]
#endif
        public string PaymentMethod { get; set; }
    }
}
