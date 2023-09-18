// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CardUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The bank account type. This can only be <c>checking</c> or <c>savings</c> in most
        /// countries. In Japan, this can only be <c>futsu</c> or <c>toza</c>.
        /// One of: <c>checking</c>, <c>futsu</c>, <c>savings</c>, or <c>toza</c>.
        /// </summary>
        [JsonProperty("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// City/District/Suburb/Town/Village.
        /// </summary>
        [JsonProperty("address_city")]
        public string AddressCity { get; set; }

        /// <summary>
        /// Billing address country, if provided when creating card.
        /// </summary>
        [JsonProperty("address_country")]
        public string AddressCountry { get; set; }

        /// <summary>
        /// Address line 1 (Street address/PO Box/Company name).
        /// </summary>
        [JsonProperty("address_line1")]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Address line 2 (Apartment/Suite/Unit/Building).
        /// </summary>
        [JsonProperty("address_line2")]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// State/County/Province/Region.
        /// </summary>
        [JsonProperty("address_state")]
        public string AddressState { get; set; }

        /// <summary>
        /// ZIP or postal code.
        /// </summary>
        [JsonProperty("address_zip")]
        public string AddressZip { get; set; }

        /// <summary>
        /// Documents that may be submitted to satisfy various informational requests.
        /// </summary>
        [JsonProperty("documents")]
        public CardDocumentsOptions Documents { get; set; }

        /// <summary>
        /// Two digit number representing the card’s expiration month.
        /// </summary>
        [JsonProperty("exp_month")]
        public long? ExpMonth { get; set; }

        /// <summary>
        /// Four digit number representing the card’s expiration year.
        /// </summary>
        [JsonProperty("exp_year")]
        public long? ExpYear { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Cardholder name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("validate")]
        public bool? Validate { get; set; }
    }
}
