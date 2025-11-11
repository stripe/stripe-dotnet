namespace Stripe
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// A handler for Stripe webhook events that uses the .NET event handler pattern.
    /// Allows registration of strongly-typed event handlers for specific EventNotification types.
    /// </summary>
    public class StripeEventHandler
    {
        private readonly StripeClient client;
        private readonly string webhookSecret;
        private readonly Dictionary<Type, Delegate> eventHandlers = new Dictionary<Type, Delegate>();
        private bool hasHandledEvent = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeEventHandler"/> class.
        /// </summary>
        /// <param name="client">The StripeClient instance to use for parsing and API requests.</param>
        /// <param name="webhookSecret">The webhook secret used for signature verification.</param>
        public StripeEventHandler(StripeClient client, string webhookSecret)
        {
            this.client = client ?? throw new ArgumentNullException(nameof(client));
            this.webhookSecret = webhookSecret ?? throw new ArgumentNullException(nameof(webhookSecret));
        }

        /// <summary>
        /// Registers an event handler for a specific EventNotification type.
        /// </summary>
        /// <typeparam name="TEventNotification">The type of EventNotification to handle.</typeparam>
        /// <param name="handler">The event handler to invoke when this event type is received.</param>
        /// <exception cref="ArgumentNullException">Thrown if handler is null.</exception>
        /// <exception cref="InvalidOperationException">Thrown if a handler is already registered for this type.</exception>
        public void Register<TEventNotification>(EventHandler<StripeEventNotificationEventArgs<TEventNotification>> handler)
            where TEventNotification : V2.Core.EventNotification
        {
            if (handler == null)
            {
                throw new ArgumentNullException(nameof(handler));
            }

            if (this.hasHandledEvent)
            {
                throw new InvalidOperationException("Cannot register handlers after an event has been handled.");
            }

            var eventType = typeof(TEventNotification);
            if (this.eventHandlers.ContainsKey(eventType))
            {
                throw new InvalidOperationException($"A handler for {eventType.Name} is already registered.");
            }

            this.eventHandlers[eventType] = handler;
        }

        /// <summary>
        /// Handles an incoming webhook by parsing the payload, validating the signature,
        /// and dispatching to the registered handler if one exists.
        /// </summary>
        /// <param name="json">The JSON payload from the webhook request body.</param>
        /// <param name="stripeSignatureHeader">The Stripe-Signature header value.</param>
        /// <exception cref="ArgumentNullException">Thrown if any required parameter is null.</exception>
        /// <exception cref="StripeException">Thrown if signature validation fails or parsing fails.</exception>
        public void Handle(
            string json,
            string stripeSignatureHeader)
        {
            this.hasHandledEvent = true;

            if (json == null)
            {
                throw new ArgumentNullException(nameof(json));
            }

            if (stripeSignatureHeader == null)
            {
                throw new ArgumentNullException(nameof(stripeSignatureHeader));
            }

            // Parse and validate the event notification
            var eventNotification = this.client.ParseEventNotification(json, stripeSignatureHeader, this.webhookSecret);

            // Dispatch to the registered handler
            this.DispatchEvent(eventNotification);
        }

        private void DispatchEvent(V2.Core.EventNotification eventNotification)
        {
            var eventType = eventNotification.GetType();

            if (this.eventHandlers.TryGetValue(eventType, out var handler))
            {
                // Use reflection to create the EventArgs and invoke the handler
                var eventArgsType = typeof(StripeEventNotificationEventArgs<>).MakeGenericType(eventType);

                // TODO: bind stripe-context to client
                var eventArgs = Activator.CreateInstance(eventArgsType, eventNotification, this.client);

                handler.DynamicInvoke(this, eventArgs);
            }
        }
    }
}
