namespace Stripe
{
    using System;

    /// <summary>
    /// A variant of StripeEventNotificationHandler that parses events without
    /// verifying webhook signatures. Intended for pre-authenticated channels
    /// like AWS EventBridge or Azure Event Grid.
    ///
    /// Because this is a sibling of <see cref="StripeEventNotificationHandler"/> rather than a
    /// subclass, it does not expose that class's two-argument Handle at all — passing a signature
    /// header here is a compile error rather than a runtime one.
    ///
    /// Do not instantiate directly. Use
    /// <see cref="StripeEventNotificationHandler.WithoutVerification"/> or
    /// <see cref="StripeClient.NotificationHandlerWithoutVerification"/> instead.
    /// </summary>
    public class StripeEventNotificationHandlerWithoutVerification : StripeEventNotificationHandlerBase
    {
        internal StripeEventNotificationHandlerWithoutVerification(StripeClient client, Action<object, StripeUnhandledEventNotificationEventArgs> fallbackCallback)
            : base(client, fallbackCallback)
        {
        }

        /// <summary>
        /// Handles an incoming webhook by parsing the payload without signature verification
        /// and dispatching to the registered handler.
        /// </summary>
        /// <param name="json">The JSON payload from the webhook request body.</param>
        public void Handle(string json)
        {
            if (json == null)
            {
                throw new ArgumentNullException(nameof(json));
            }

            // set after argument validation, so a bad call doesn't lock out registration
            this.HasHandledEvent = true;

            var eventNotification = this.client.ParseEventNotificationWithoutVerification(json);

            this.DispatchEventWithContext(eventNotification);
        }
    }
}
