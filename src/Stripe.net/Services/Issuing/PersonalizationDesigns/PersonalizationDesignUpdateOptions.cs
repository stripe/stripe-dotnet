// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PersonalizationDesignUpdateOptions : BaseOptions, IHasMetadata
    {
        private string cardLogo;
        private PersonalizationDesignCarrierTextOptions carrierText;
        private string lookupKey;
        private string name;

        /// <summary>
        /// The file for the card logo, for use with physical bundles that support card logos. Must
        /// have a <c>purpose</c> value of <c>issuing_logo</c>.
        /// </summary>
        [JsonProperty("card_logo")]
        [STJS.JsonPropertyName("card_logo")]
        public string CardLogo
        {
            get => this.cardLogo;
            set
            {
                this.cardLogo = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Hash containing carrier text, for use with physical bundles that support carrier text.
        /// </summary>
        [JsonProperty("carrier_text")]
        [STJS.JsonPropertyName("carrier_text")]
        public PersonalizationDesignCarrierTextOptions CarrierText
        {
            get => this.carrierText;
            set
            {
                this.carrierText = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// A lookup key used to retrieve personalization designs dynamically from a static string.
        /// This may be up to 200 characters.
        /// </summary>
        [JsonProperty("lookup_key")]
        [STJS.JsonPropertyName("lookup_key")]
        public string LookupKey
        {
            get => this.lookupKey;
            set
            {
                this.lookupKey = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Friendly display name. Providing an empty string will set the field to null.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name
        {
            get => this.name;
            set
            {
                this.name = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The physical bundle object belonging to this personalization design.
        /// </summary>
        [JsonProperty("physical_bundle")]
        [STJS.JsonPropertyName("physical_bundle")]
        public string PhysicalBundle { get; set; }

        /// <summary>
        /// Information on whether this personalization design is used to create cards when one is
        /// not specified.
        /// </summary>
        [JsonProperty("preferences")]
        [STJS.JsonPropertyName("preferences")]
        public PersonalizationDesignPreferencesOptions Preferences { get; set; }

        /// <summary>
        /// If set to true, will atomically remove the lookup key from the existing personalization
        /// design, and assign it to this personalization design.
        /// </summary>
        [JsonProperty("transfer_lookup_key")]
        [STJS.JsonPropertyName("transfer_lookup_key")]
        public bool? TransferLookupKey { get; set; }
    }
}
