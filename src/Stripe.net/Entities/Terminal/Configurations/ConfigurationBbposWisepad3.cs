// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ConfigurationBbposWisepad3 : StripeEntity<ConfigurationBbposWisepad3>
    {
        #region Expandable Splashscreen

        /// <summary>
        /// (ID of the File)
        /// A File ID representing an image to display on the reader.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
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
        [STJS.JsonIgnore]
        public File Splashscreen
        {
            get => this.InternalSplashscreen?.ExpandedObject;
            set => this.InternalSplashscreen = SetExpandableFieldObject(value, this.InternalSplashscreen);
        }

        [JsonProperty("splashscreen")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        [STJS.JsonPropertyName("splashscreen")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalSplashscreen { get; set; }
        #endregion
    }
}
