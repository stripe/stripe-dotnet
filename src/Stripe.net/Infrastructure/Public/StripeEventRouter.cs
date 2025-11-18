namespace Stripe
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// A handler for Stripe webhook events that uses the .NET event handler pattern.
    /// Allows registration of strongly-typed event handlers for specific EventNotification types.
    /// </summary>
    public class StripeEventRouter
    {
        private readonly StripeClient client;
        private readonly string webhookSecret;
        private readonly HashSet<string> handledEventTypes = new HashSet<string>();
        private readonly Dictionary<string, EventHandler> eventHandlers = new Dictionary<string, EventHandler>();

        // A private EventHandler for each EventNotification. We'll route notifications to the correct handler.
        // private-event-handlers: The beginning of the section generated from our OpenAPI spec
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterErrorReportTriggeredEventNotification>> v1BillingMeterErrorReportTriggeredEvent;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterNoMeterFoundEventNotification>> v1BillingMeterNoMeterFoundEvent;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreEventDestinationPingEventNotification>> v2CoreEventDestinationPingEvent;

        // private-event-handlers: The beginning of the section generated from our OpenAPI spec

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeEventRouter"/> class.
        /// </summary>
        /// <param name="client">The StripeClient instance to use for parsing and API requests.</param>
        /// <param name="webhookSecret">The webhook secret used for signature verification.</param>
        /// <param name="unhandledEventHandler">TODO: ADD UNHANDLED DETAILS</param>
        public StripeEventRouter(StripeClient client, string webhookSecret, EventHandler<StripeEventNotificationEventArgs<V2.Core.EventNotification>> unhandledEventHandler)
        {
            this.client = client ?? throw new ArgumentNullException(nameof(client));
            this.webhookSecret = webhookSecret ?? throw new ArgumentNullException(nameof(webhookSecret));
            this.UnhandledEventHandler += unhandledEventHandler;
        }

        private event EventHandler<StripeEventNotificationEventArgs<V2.Core.EventNotification>> UnhandledEventHandler;

        // public facing EventHandler
        // public-event-handlers: The beginning of the section generated from our OpenAPI spec
        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterErrorReportTriggeredEventNotification>> V1BillingMeterErrorReportTriggeredEvent
        {
            add { this.AddEventHandler(ref this.v1BillingMeterErrorReportTriggeredEvent, value, "v1.billing.meter.error_report_triggered"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterNoMeterFoundEventNotification>> V1BillingMeterNoMeterFoundEvent
        {
            add { this.AddEventHandler(ref this.v1BillingMeterNoMeterFoundEvent, value, "v1.billing.meter.no_meter_found"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreEventDestinationPingEventNotification>> V2CoreEventDestinationPingEvent
        {
            add { this.AddEventHandler(ref this.v2CoreEventDestinationPingEvent, value, "v2.core.event_destination.ping"); }
            remove { this.RemoveEventHandler(); }
        }

        // public-event-handlers: The end of the section generated from our OpenAPI spec

        /// <summary>
        /// Centralizes the logic for adding event handlers.
        /// </summary>
        private void AddEventHandler<T>(ref EventHandler<T> handler, EventHandler<T> value, string eventType)
        where T : EventArgs
        {
            if (this.handledEventTypes.Add(eventType))
            {
                handler = value;
            }
            else
            {
                throw new InvalidOperationException($"A handler for event type '{eventType}' is already registered. Only one handler per event type is allowed.");
            }
        }

        /// <summary>
        /// Centralizes the logic for removing event handlers.
        /// </summary>
        private void RemoveEventHandler()
        {
            throw new InvalidOperationException("Removing handlers is not supported.");
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
            // this.hasHandledEvent = true;
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

        /// <summary>
        /// Returns a sorted list of event types that have registered handlers.
        /// </summary>
        /// <returns></returns>
        public List<string> HandledEventTypes()
        {
            var events = new List<string>(this.handledEventTypes);
            events.Sort();
            return events;
        }

        private void DispatchEvent(V2.Core.EventNotification eventNotification)
        {
            if (eventNotification == null)
            {
                throw new ArgumentNullException(nameof(eventNotification));
            }

            if (this.handledEventTypes.Contains(eventNotification.Type))
            {
                // Known event type; dispatch to the appropriate handler
                if (false) // so all of our handlers can be else ifs
                {
                }

                // event-handler-dispatch: The beginning of the section generated from our OpenAPI spec
                else if (eventNotification is Stripe.Events.V1BillingMeterErrorReportTriggeredEventNotification)
                {
                    this.v1BillingMeterErrorReportTriggeredEvent.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterErrorReportTriggeredEventNotification>((Stripe.Events.V1BillingMeterErrorReportTriggeredEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V1BillingMeterNoMeterFoundEventNotification)
                {
                    this.v1BillingMeterNoMeterFoundEvent.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterNoMeterFoundEventNotification>((Stripe.Events.V1BillingMeterNoMeterFoundEventNotification)eventNotification, this.client));
                }

                // event-handler-dispatch: The end of the section generated from our OpenAPI spec
                else
                {
                    throw new Exception("unexpected state, please file a bug");
                }
            }
            else
            {
                // Unknown event type; invoke the unhandled event handler
                this.UnhandledEventHandler.Invoke(
                    this,
                    new StripeEventNotificationEventArgs<V2.Core.EventNotification>(
                        eventNotification, this.client));
            }
        }
    }
}
