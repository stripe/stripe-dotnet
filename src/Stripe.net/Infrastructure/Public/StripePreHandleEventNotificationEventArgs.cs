namespace Stripe
{
    /// <summary>
    /// EventArgs for the PreHandle callback, which runs before any event-specific callback.
    /// Carries the parsed event notification, the context-scoped StripeClient, and a
    /// <see cref="Cancel"/> flag that stops handling for this delivery.
    /// </summary>
    public class StripePreHandleEventNotificationEventArgs : StripeEventNotificationEventArgs<V2.Core.EventNotification>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StripePreHandleEventNotificationEventArgs"/> class.
        /// </summary>
        /// <param name="eventNotification">The event notification instance.</param>
        /// <param name="client">The StripeClient instance.</param>
        public StripePreHandleEventNotificationEventArgs(V2.Core.EventNotification eventNotification, StripeClient client)
            : base(eventNotification, client)
        {
        }

        /// <summary>
        /// Gets or sets a value indicating whether to stop handling this event notification.
        /// Setting it to <c>true</c> returns from <c>Handle</c> as soon as the PreHandle
        /// callback finishes, so neither the registered callback nor the fallback callback are
        /// called. Defaults to <c>false</c>, which lets handling continue as normal.
        /// </summary>
        public bool Cancel { get; set; }
    }
}
