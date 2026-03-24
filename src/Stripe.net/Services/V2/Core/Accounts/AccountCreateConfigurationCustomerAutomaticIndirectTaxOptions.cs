// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationCustomerAutomaticIndirectTaxOptions : INestedOptions
    {
        /// <summary>
        /// Describes the customer's tax exemption status, which is <c>none</c>, <c>exempt</c>, or
        /// <c>reverse</c>. When set to reverse, invoice and receipt PDFs include the following
        /// text: “Reverse charge”.
        /// One of: <c>exempt</c>, <c>none</c>, or <c>reverse</c>.
        /// </summary>
        [JsonProperty("exempt")]
        [STJS.JsonPropertyName("exempt")]
        public string Exempt { get; set; }

        /// <summary>
        /// A recent IP address of the customer used for tax reporting and tax location inference.
        /// </summary>
        [JsonProperty("ip_address")]
        [STJS.JsonPropertyName("ip_address")]
        public string IpAddress { get; set; }

        /// <summary>
        /// The data source used to identify the customer's tax location - defaults to
        /// <c>identity_address</c>. Will only be used for automatic tax calculation on the
        /// customer's Invoices and Subscriptions. This behavior is now deprecated for new users.
        /// One of: <c>identity_address</c>, <c>ip_address</c>, <c>payment_method</c>, or
        /// <c>shipping_address</c>.
        /// </summary>
        [JsonProperty("location_source")]
        [STJS.JsonPropertyName("location_source")]
        public string LocationSource { get; set; }
    }
}
