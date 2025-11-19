namespace Stripe
{
    using System;

    /// <summary>
    /// EventArgs for Stripe webhook event notifications.
    /// Contains the strongly-typed EventNotification and the StripeClient instance.
    /// </summary>
    /// <typeparam name="TEventNotification">The type of EventNotification.</typeparam>
    public class StripeEventNotificationEventArgs<TEventNotification> : EventArgs
        where TEventNotification : V2.Core.EventNotification
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StripeEventNotificationEventArgs{TEventNotification}"/> class.
        /// </summary>
        /// <param name="eventNotification">The event notification instance.</param>
        /// <param name="client">The StripeClient instance.</param>
        public StripeEventNotificationEventArgs(TEventNotification eventNotification, StripeClient client)
        {
            this.EventNotification = eventNotification ?? throw new ArgumentNullException(nameof(eventNotification));
            this.Client = client ?? throw new ArgumentNullException(nameof(client));
        }

        /// <summary>
        /// Gets the event notification instance.
        /// </summary>
        public TEventNotification EventNotification { get; }

        /// <summary>
        /// Gets the StripeClient instance that can be used to make API requests.
        /// </summary>
        public StripeClient Client { get; }
    }
}