// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class ConfigurationBbposWiseposE : StripeEntity<ConfigurationBbposWiseposE>
    {
        #region Expandable Splashscreen

        /// <summary>
        /// (ID of the File)
        /// A File ID representing an image to display on the reader.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string SplashscreenId
        {
            get => this.InternalSplashscreen?.Id;
            set => this.InternalSplashscreen = SetExpandableFieldId(value, this.InternalSplashscreen);
        }

        /// <summary>
        /// (Expanded)
        /// A File ID representing an image to display on the reader.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public File Splashscreen
        {
            get => this.InternalSplashscreen?.ExpandedObject;
            set => this.InternalSplashscreen = SetExpandableFieldObject(value, this.InternalSplashscreen);
        }

        [JsonProperty("splashscreen")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("splashscreen")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<File>))]
#endif
        internal ExpandableField<File> InternalSplashscreen { get; set; }
        #endregion
    }
}
