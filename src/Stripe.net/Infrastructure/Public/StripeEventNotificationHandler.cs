namespace Stripe
{
    using System;

    /// <summary>
    /// A handler for Stripe webhook events that uses the .NET event handler pattern.
    /// Allows registration of strongly-typed event handlers for specific EventNotification types.
    ///
    /// Verifies incoming webhook signatures before dispatching. For events arriving through a
    /// channel that has already authenticated them, see
    /// <see cref="WithoutVerification(StripeClient, Action{object, StripeUnhandledEventNotificationEventArgs})"/>.
    /// </summary>
    public class StripeEventNotificationHandler : StripeEventNotificationHandlerBase
    {
        private readonly string webhookSecret;

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeEventNotificationHandler"/> class.
        /// </summary>
        /// <param name="client">The StripeClient instance to use for parsing and API requests.</param>
        /// <param name="webhookSecret">The webhook secret used for signature verification.</param>
        /// <param name="fallbackCallback">The function to call when handing an event for whom there's no callback registered.</param>
        public StripeEventNotificationHandler(StripeClient client, string webhookSecret, Action<object, StripeUnhandledEventNotificationEventArgs> fallbackCallback)
            : base(client, fallbackCallback)
        {
            if (string.IsNullOrEmpty(webhookSecret))
            {
                throw new ArgumentNullException(nameof(webhookSecret));
            }

            this.webhookSecret = webhookSecret;
        }

        /// <summary>
        /// Creates a handler that processes events without webhook signature verification.
        /// Intended for pre-authenticated channels like AWS EventBridge or Azure Event Grid.
        /// </summary>
        public static StripeEventNotificationHandlerWithoutVerification WithoutVerification(StripeClient client, Action<object, StripeUnhandledEventNotificationEventArgs> fallbackCallback)
        {
            return new StripeEventNotificationHandlerWithoutVerification(client, fallbackCallback);
        }

        /// <summary>
        /// Handles an incoming webhook by parsing the payload, validating the signature,
        /// and dispatching to the registered handler if one exists.
        /// </summary>
        /// <param name="json">The JSON payload from the webhook request body.</param>
        /// <param name="stripeSignatureHeader">The Stripe-Signature header value.</param>
        /// <exception cref="ArgumentNullException">Thrown if any required parameter is null.</exception>
        /// <exception cref="StripeException">Thrown if signature validation fails or parsing fails.</exception>
        /// TODO: allow async?
        public void Handle(
            string json,
            string stripeSignatureHeader)
        {
            if (json == null)
            {
                throw new ArgumentNullException(nameof(json));
            }

            if (stripeSignatureHeader == null)
            {
                throw new ArgumentNullException(nameof(stripeSignatureHeader));
            }

            // set after argument validation, so a bad call doesn't lock out registration
            this.HasHandledEvent = true;

            // Parse and validate the event notification
            var eventNotification = this.client.ParseEventNotification(json, stripeSignatureHeader, this.webhookSecret);

            // Dispatch to the registered handler with the event's context
            this.DispatchEventWithContext(eventNotification);
        }
    }
}
