// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class CadenceUpdateSettingsCollectionOptions : INestedOptions, IHasId
    {
        /// <summary>
        /// The ID of the referenced Settings object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        [JsonProperty("version")]
        [JsonConverter(typeof(EmptyableConverter<string>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("version")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<string>))]
#endif
        internal Emptyable<string> InternalVersion { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyVersion
        {
            get => this.InternalVersion?.Empty ?? false;
            set
            {
                this.InternalVersion ??= new Emptyable<string>();
                this.InternalVersion.Empty = value;
            }
        }

        /// <summary>
        /// An optional field to specify the version of Settings to use. If not provided, this will
        /// always default to the <c>live_version</c> specified on the setting, any time the
        /// settings are used. Using a specific version here will prevent the settings from
        /// updating, and is discouraged for cadences. To clear a pinned version, set the version to
        /// null.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string Version
        {
            get => this.InternalVersion?.Value;
            set
            {
                this.InternalVersion ??= new Emptyable<string>();
                this.InternalVersion.Value = value;
            }
        }
    }
}
