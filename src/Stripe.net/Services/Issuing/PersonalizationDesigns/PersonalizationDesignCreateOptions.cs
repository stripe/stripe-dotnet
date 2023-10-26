// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PersonalizationDesignCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The file for the card logo, for use with physical bundles that support card logos. Must
        /// have a <c>purpose</c> value of <c>issuing_logo</c>.
        /// </summary>
        [JsonProperty("card_logo")]
        public string CardLogo { get; set; }

        /// <summary>
        /// Hash containing carrier text, for use with physical bundles that support carrier text.
        /// </summary>
        [JsonProperty("carrier_text")]
        public PersonalizationDesignCarrierTextOptions CarrierText { get; set; }

        /// <summary>
        /// A lookup key used to retrieve personalization designs dynamically from a static string.
        /// This may be up to 200 characters.
        /// </summary>
        [JsonProperty("lookup_key")]
        public string LookupKey { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Friendly display name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The physical bundle object belonging to this personalization design.
        /// </summary>
        [JsonProperty("physical_bundle")]
        public string PhysicalBundle { get; set; }

        /// <summary>
        /// Information on whether this personalization design is used to create cards when one is
        /// not specified.
        /// </summary>
        [JsonProperty("preferences")]
        public PersonalizationDesignPreferencesOptions Preferences { get; set; }

        /// <summary>
        /// If set to true, will atomically remove the lookup key from the existing personalization
        /// design, and assign it to this personalization design.
        /// </summary>
        [JsonProperty("transfer_lookup_key")]
        public bool? TransferLookupKey { get; set; }
    }
}
