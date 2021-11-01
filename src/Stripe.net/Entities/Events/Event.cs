// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    [JsonConverter(typeof(EventConverter))]
    /// <summary>
    /// Events are our way of letting you know when something interesting happens in your
    /// account. When an interesting event occurs, we create a new <c>Event</c> object. For
    /// example, when a charge succeeds, we create a <c>charge.succeeded</c> event; and when an
    /// invoice payment attempt fails, we create an <c>invoice.payment_failed</c> event. Note
    /// that many API requests may cause multiple events to be created. For example, if you
    /// create a new subscription for a customer, you will receive both a
    /// <c>customer.subscription.created</c> event and a <c>charge.succeeded</c> event.
    ///
    /// Events occur when the state of another API resource changes. The state of that resource
    /// at the time of the change is embedded in the event's data field. For example, a
    /// <c>charge.succeeded</c> event will contain a charge, and an
    /// <c>invoice.payment_failed</c> event will contain an invoice.
    ///
    /// As with other API resources, you can use endpoints to retrieve an <a
    /// href="https://stripe.com/docs/api#retrieve_event">individual event</a> or a <a
    /// href="https://stripe.com/docs/api#list_events">list of events</a> from the API. We also
    /// have a separate <a href="http://en.wikipedia.org/wiki/Webhook">webhooks</a> system for
    /// sending the <c>Event</c> objects directly to an endpoint on your server. Webhooks are
    /// managed in your <a href="https://dashboard.stripe.com/account/webhooks">account
    /// settings</a>, and our <a href="https://stripe.com/docs/webhooks">Using Webhooks</a>
    /// guide will help you get set up.
    ///
    /// When using <a href="https://stripe.com/docs/connect">Connect</a>, you can also receive
    /// notifications of events that occur in connected accounts. For these events, there will
    /// be an additional <c>account</c> attribute in the received <c>Event</c> object.
    ///
    /// <strong>NOTE:</strong> Right now, access to events through the <a
    /// href="https://stripe.com/docs/api#retrieve_event">Retrieve Event API</a> is guaranteed
    /// only for 30 days.
    /// </summary>
    public class Event : StripeEntity<Event>, IHasId, IHasObject
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
        /// The connected account that originated the event.
        /// </summary>
        [JsonProperty("account")]
        public string Account { get; set; }

        /// <summary>
        /// The Stripe API version used to render <c>data</c>. <em>Note: This property is populated
        /// only for events on or after October 31, 2014</em>.
        /// </summary>
        [JsonProperty("api_version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        [JsonProperty("data")]
        public EventData Data { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Number of webhooks that have yet to be successfully delivered (i.e., to return a 20x
        /// response) to the URLs you've specified.
        /// </summary>
        [JsonProperty("pending_webhooks")]
        public long PendingWebhooks { get; set; }

        /// <summary>
        /// Information on the API request that instigated the event.
        /// </summary>
        [JsonProperty("request")]
        public EventRequest Request { get; set; }

        /// <summary>
        /// Description of the event (e.g., <c>invoice.created</c> or <c>charge.refunded</c>).
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
