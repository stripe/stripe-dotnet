namespace Stripe
{
    using System;

    /// <summary>
    /// EventArgs for Stripe webhook event notifications.
    /// Contains the strongly-typed EventNotification and the StripeClient instance.
    /// </summary>
    public class StripeUnhandledEventNotificationEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StripeUnhandledEventNotificationEventArgs"/> class.
        /// </summary>
        /// <param name="eventNotification">The event notification instance.</param>
        /// <param name="client">The StripeClient instance.</param>
        /// <param name="details">Details about the unhandled notification.</param>
        public StripeUnhandledEventNotificationEventArgs(V2.Core.EventNotification eventNotification, StripeClient client, UnhandledNotificationDetails details)
        {
            this.EventNotification = eventNotification ?? throw new ArgumentNullException(nameof(eventNotification));
            this.Client = client ?? throw new ArgumentNullException(nameof(client));
            this.Details = details ?? throw new ArgumentNullException(nameof(details));
        }

        /// <summary>
        /// Gets the event notification instance.
        /// </summary>
        public V2.Core.EventNotification EventNotification { get; }

        /// <summary>
        /// Gets the StripeClient instance that can be used to make API requests.
        /// </summary>
        public StripeClient Client { get; }

        /// <summary>
        /// Gets details about the unhandled notification.
        /// </summary>
        public UnhandledNotificationDetails Details { get; }
    }
}
