// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Session : StripeEntity<Session>, IHasId, IHasObject
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

        #region Expandable Configuration

        /// <summary>
        /// (ID of the Configuration)
        /// The configuration used by this session, describing the features available.
        /// </summary>
        [JsonIgnore]
        public string ConfigurationId
        {
            get => this.InternalConfiguration?.Id;
            set => this.InternalConfiguration = SetExpandableFieldId(value, this.InternalConfiguration);
        }

        /// <summary>
        /// (Expanded)
        /// The configuration used by this session, describing the features available.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Configuration Configuration
        {
            get => this.InternalConfiguration?.ExpandedObject;
            set => this.InternalConfiguration = SetExpandableFieldObject(value, this.InternalConfiguration);
        }

        [JsonProperty("configuration")]
        [JsonConverter(typeof(ExpandableFieldConverter<Configuration>))]
        internal ExpandableField<Configuration> InternalConfiguration { get; set; }
        #endregion

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The ID of the customer for this session.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The account for which the session was created on behalf of. When specified, only
        /// subscriptions and invoices with this <c>on_behalf_of</c> account appear in the portal.
        /// For more information, see the <a
        /// href="https://stripe.com/docs/connect/charges-transfers#on-behalf-of">docs</a>. Use the
        /// <a
        /// href="https://stripe.com/docs/api/accounts/object#account_object-settings-branding">Accounts
        /// API</a> to modify the <c>on_behalf_of</c> account's branding settings, which the portal
        /// displays.
        /// </summary>
        [JsonProperty("on_behalf_of")]
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// The URL to redirect customers to when they click on the portal's link to return to your
        /// website.
        /// </summary>
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// The short-lived URL of the session that gives customers access to the customer portal.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
