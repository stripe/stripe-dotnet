// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCreateConfigurationMerchantScriptStatementDescriptorKanjiOptions : INestedOptions
    {
        /// <summary>
        /// The default text that appears on statements for non-card charges outside of Japan. For
        /// card charges, if you don’t set a statement_descriptor_prefix, this text is also used as
        /// the statement descriptor prefix. In that case, if concatenating the statement descriptor
        /// suffix causes the combined statement descriptor to exceed 22 characters, we truncate the
        /// statement_descriptor text to limit the full descriptor to 22 characters. For more
        /// information about statement descriptors and their requirements, see the Merchant
        /// Configuration settings documentation.
        /// </summary>
        [JsonProperty("descriptor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("descriptor")]
#endif
        public string Descriptor { get; set; }

        /// <summary>
        /// Default text that appears on statements for card charges outside of Japan, prefixing any
        /// dynamic statement_descriptor_suffix specified on the charge. To maximize space for the
        /// dynamic part of the descriptor, keep this text short. If you don’t specify this value,
        /// statement_descriptor is used as the prefix. For more information about statement
        /// descriptors and their requirements, see the Merchant Configuration settings
        /// documentation.
        /// </summary>
        [JsonProperty("prefix")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("prefix")]
#endif
        public string Prefix { get; set; }
    }
}
