// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// Settings that configure and manage the behavior of collecting payments.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CollectionSetting : StripeEntity<CollectionSetting>, IHasId, IHasObject
    {
        /// <summary>
        /// The ID of the CollectionSetting.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Either automatic, or send_invoice. When charging automatically, Stripe will attempt to
        /// pay this bill at the end of the period using the payment method attached to the payer
        /// profile. When sending an invoice, Stripe will email your payer profile an invoice with
        /// payment instructions. Defaults to automatic.
        /// One of: <c>automatic</c>, or <c>send_invoice</c>.
        /// </summary>
        [JsonProperty("collection_method")]
        [STJS.JsonPropertyName("collection_method")]
        public string CollectionMethod { get; set; }

        /// <summary>
        /// Timestamp of when the object was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// An optional field for adding a display name for the CollectionSetting object.
        /// </summary>
        [JsonProperty("display_name")]
        [STJS.JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Email delivery settings.
        /// </summary>
        [JsonProperty("email_delivery")]
        [STJS.JsonPropertyName("email_delivery")]
        public CollectionSettingEmailDelivery EmailDelivery { get; set; }

        /// <summary>
        /// The latest version of the current settings object. This will be Updated every time an
        /// attribute of the settings is updated.
        /// </summary>
        [JsonProperty("latest_version")]
        [STJS.JsonPropertyName("latest_version")]
        public string LatestVersion { get; set; }

        /// <summary>
        /// The current live version of the settings object. This can be different from
        /// latest_version if settings are updated without setting live_version='latest'.
        /// </summary>
        [JsonProperty("live_version")]
        [STJS.JsonPropertyName("live_version")]
        public string LiveVersion { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// A lookup key used to retrieve settings dynamically from a static string. This may be up
        /// to 200 characters.
        /// </summary>
        [JsonProperty("lookup_key")]
        [STJS.JsonPropertyName("lookup_key")]
        public string LookupKey { get; set; }

        /// <summary>
        /// The ID of the PaymentMethodConfiguration object, which controls which payment methods
        /// are displayed to your customers.
        /// </summary>
        [JsonProperty("payment_method_configuration")]
        [STJS.JsonPropertyName("payment_method_configuration")]
        public string PaymentMethodConfiguration { get; set; }

        /// <summary>
        /// Payment Method specific configuration stored on the object.
        /// </summary>
        [JsonProperty("payment_method_options")]
        [STJS.JsonPropertyName("payment_method_options")]
        public CollectionSettingPaymentMethodOptions PaymentMethodOptions { get; set; }
    }
}
