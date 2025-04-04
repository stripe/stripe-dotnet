// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountExternalAccountUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The name of the person or business that owns the bank account.
        /// </summary>
        [JsonProperty("account_holder_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_holder_name")]
#endif
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The type of entity that holds the account. This can be either <c>individual</c> or
        /// <c>company</c>.
        /// One of: <c>company</c>, or <c>individual</c>.
        /// </summary>
        [JsonProperty("account_holder_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_holder_type")]
#endif
        public string AccountHolderType { get; set; }

        /// <summary>
        /// The bank account type. This can only be <c>checking</c> or <c>savings</c> in most
        /// countries. In Japan, this can only be <c>futsu</c> or <c>toza</c>.
        /// One of: <c>checking</c>, <c>futsu</c>, <c>savings</c>, or <c>toza</c>.
        /// </summary>
        [JsonProperty("account_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_type")]
#endif
        public string AccountType { get; set; }

        /// <summary>
        /// City/District/Suburb/Town/Village.
        /// </summary>
        [JsonProperty("address_city")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_city")]
#endif
        public string AddressCity { get; set; }

        /// <summary>
        /// Billing address country, if provided when creating card.
        /// </summary>
        [JsonProperty("address_country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_country")]
#endif
        public string AddressCountry { get; set; }

        /// <summary>
        /// Address line 1 (Street address/PO Box/Company name).
        /// </summary>
        [JsonProperty("address_line1")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_line1")]
#endif
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Address line 2 (Apartment/Suite/Unit/Building).
        /// </summary>
        [JsonProperty("address_line2")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_line2")]
#endif
        public string AddressLine2 { get; set; }

        /// <summary>
        /// State/County/Province/Region.
        /// </summary>
        [JsonProperty("address_state")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_state")]
#endif
        public string AddressState { get; set; }

        /// <summary>
        /// ZIP or postal code.
        /// </summary>
        [JsonProperty("address_zip")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_zip")]
#endif
        public string AddressZip { get; set; }

        /// <summary>
        /// When set to true, this becomes the default external account for its currency.
        /// </summary>
        [JsonProperty("default_for_currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_for_currency")]
#endif
        public bool? DefaultForCurrency { get; set; }

        /// <summary>
        /// Documents that may be submitted to satisfy various informational requests.
        /// </summary>
        [JsonProperty("documents")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("documents")]
#endif
        public AccountExternalAccountDocumentsOptions Documents { get; set; }

        /// <summary>
        /// Two digit number representing the card’s expiration month.
        /// </summary>
        [JsonProperty("exp_month")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("exp_month")]
#endif
        public string ExpMonth { get; set; }

        /// <summary>
        /// Four digit number representing the card’s expiration year.
        /// </summary>
        [JsonProperty("exp_year")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("exp_year")]
#endif
        public string ExpYear { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Cardholder name.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }
    }
}
