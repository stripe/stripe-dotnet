// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// A portal configuration describes the functionality and behavior of a portal session.
    /// </summary>
    public class Configuration : StripeEntity<Configuration>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Whether the configuration is active and can be used to create portal sessions.
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }

        #region Expandable Application

        /// <summary>
        /// (ID of the Application)
        /// ID of the Connect Application that created the configuration.
        /// </summary>
        [JsonIgnore]
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
        public Application Application
        {
            get => this.InternalApplication?.ExpandedObject;
            set => this.InternalApplication = SetExpandableFieldObject(value, this.InternalApplication);
        }

        [JsonProperty("application")]
        [JsonConverter(typeof(ExpandableFieldConverter<Application>))]
        internal ExpandableField<Application> InternalApplication { get; set; }
        #endregion

        [JsonProperty("business_profile")]
        public ConfigurationBusinessProfile BusinessProfile { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The default URL to redirect customers to when they click on the portal's link to return
        /// to your website. This can be <a
        /// href="https://stripe.com/docs/api/customer_portal/sessions/create#create_portal_session-return_url">overriden</a>
        /// when creating the session.
        /// </summary>
        [JsonProperty("default_return_url")]
        public string DefaultReturnUrl { get; set; }

        [JsonProperty("features")]
        public ConfigurationFeatures Features { get; set; }

        /// <summary>
        /// Whether the configuration is the default. If <c>true</c>, this configuration can be
        /// managed in the Dashboard and portal sessions will use this configuration unless it is
        /// overriden when creating the session.
        /// </summary>
        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("login_page")]
        public ConfigurationLoginPage LoginPage { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Time at which the object was last updated. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("updated")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Updated { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
