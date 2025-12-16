// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountUpdateConfigurationCustomerAutomaticIndirectTaxOptions : INestedOptions
    {
        /// <summary>
        /// The customer account's tax exemption status: <c>none</c>, <c>exempt</c>, or
        /// <c>reverse</c>. When <c>reverse</c>, invoice and receipt PDFs include "Reverse charge".
        /// One of: <c>exempt</c>, <c>none</c>, or <c>reverse</c>.
        /// </summary>
        [JsonProperty("exempt")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("exempt")]
#endif
        public string Exempt { get; set; }

        /// <summary>
        /// A recent IP address of the customer used for tax reporting and tax location inference.
        /// </summary>
        [JsonProperty("ip_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ip_address")]
#endif
        public string IpAddress { get; set; }

        /// <summary>
        /// Data source used to identify the customer account's tax location. Defaults to
        /// <c>identity_address</c>. Used for automatic indirect tax calculation.
        /// One of: <c>identity_address</c>, <c>ip_address</c>, <c>payment_method</c>, or
        /// <c>shipping_address</c>.
        /// </summary>
        [JsonProperty("location_source")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("location_source")]
#endif
        public string LocationSource { get; set; }

        /// <summary>
        /// A per-request flag that indicates when Stripe should validate the customer tax location
        /// - defaults to <c>auto</c>.
        /// One of: <c>auto</c>, <c>deferred</c>, or <c>immediately</c>.
        /// </summary>
        [JsonProperty("validate_location")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("validate_location")]
#endif
        public string ValidateLocation { get; set; }
    }
}
