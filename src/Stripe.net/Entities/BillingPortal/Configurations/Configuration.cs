// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// A portal configuration describes the functionality and behavior you embed in a portal
    /// session. Related guide: <a
    /// href="https://stripe.com/customer-management/configure-portal">Configure the customer
    /// portal</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Configuration : StripeEntity<Configuration>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Whether the configuration is active and can be used to create portal sessions.
        /// </summary>
        [JsonProperty("active")]
        [STJS.JsonPropertyName("active")]
        public bool Active { get; set; }

        #region Expandable Application

        /// <summary>
        /// (ID of the Application)
        /// ID of the Connect Application that created the configuration.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string ApplicationId
        {
            get => this.InternalApplication?.Id;
            set => this.InternalApplication = SetExpandableFieldId(value, this.InternalApplication);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the Connect Application that created the configuration.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Application Application
        {
            get => this.InternalApplication?.ExpandedObject;
            set => this.InternalApplication = SetExpandableFieldObject(value, this.InternalApplication);
        }

        [JsonProperty("application")]
        [JsonConverter(typeof(ExpandableFieldConverter<Application>))]
        [STJS.JsonPropertyName("application")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Application>))]
        internal ExpandableField<Application> InternalApplication { get; set; }
        #endregion

        [JsonProperty("business_profile")]
        [STJS.JsonPropertyName("business_profile")]
        public ConfigurationBusinessProfile BusinessProfile { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The default URL to redirect customers to when they click on the portal's link to return
        /// to your website. This can be <a
        /// href="https://docs.stripe.com/api/customer_portal/sessions/create#create_portal_session-return_url">overriden</a>
        /// when creating the session.
        /// </summary>
        [JsonProperty("default_return_url")]
        [STJS.JsonPropertyName("default_return_url")]
        public string DefaultReturnUrl { get; set; }

        [JsonProperty("features")]
        [STJS.JsonPropertyName("features")]
        public ConfigurationFeatures Features { get; set; }

        /// <summary>
        /// Whether the configuration is the default. If <c>true</c>, this configuration can be
        /// managed in the Dashboard and portal sessions will use this configuration unless it is
        /// overriden when creating the session.
        /// </summary>
        [JsonProperty("is_default")]
        [STJS.JsonPropertyName("is_default")]
        public bool IsDefault { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("login_page")]
        [STJS.JsonPropertyName("login_page")]
        public ConfigurationLoginPage LoginPage { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The name of the configuration.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Time at which the object was last updated. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("updated")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("updated")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Updated { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
