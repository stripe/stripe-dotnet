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

        // TODO: override `add` and check this
        // private bool hasHandledEvent = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeEventRouter"/> class.
        /// </summary>
        /// <param name="client">The StripeClient instance to use for parsing and API requests.</param>
        /// <param name="webhookSecret">The webhook secret used for signature verification.</param>
        public StripeEventRouter(StripeClient client, string webhookSecret)
        {
            this.client = client ?? throw new ArgumentNullException(nameof(client));
            this.webhookSecret = webhookSecret ?? throw new ArgumentNullException(nameof(webhookSecret));
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.UnknownEventNotification>> UnknownEventNotification;

        // event-handler-declarations: The beginning of the section generated from our OpenAPI spec
        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterErrorReportTriggeredEventNotification>> V1BillingMeterErrorReportTriggeredEvent;

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterNoMeterFoundEventNotification>> V1BillingMeterNoMeterFoundEvent;

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreEventDestinationPingEventNotification>> V2CoreEventDestinationPingEvent;

        // event-handler-declarations: The end of the section generated from our OpenAPI spec

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

        private void DispatchEvent(V2.Core.EventNotification eventNotification)
        {
            if (eventNotification is Stripe.Events.UnknownEventNotification e)
            {
                if (this.UnknownEventNotification == null)
                {
                    throw new Exception("No handler registered for \"UknownEventNotification\"");
                }

                this.UnknownEventNotification.Invoke(
                    this,
                    new StripeEventNotificationEventArgs<Stripe.Events.UnknownEventNotification>(
                        (Stripe.Events.UnknownEventNotification)eventNotification, this.client));
            }

            // event-handler-dispatch: The beginning of the section generated from our OpenAPI spec
            else if (eventNotification is Stripe.Events.V1BillingMeterErrorReportTriggeredEventNotification)
            {
                if (this.V1BillingMeterErrorReportTriggeredEvent == null)
                {
                    throw new Exception("No handler registered for \"V1BillingMeterErrorReportTriggeredEvent\"");
                }

                this.V1BillingMeterErrorReportTriggeredEvent.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterErrorReportTriggeredEventNotification>((Stripe.Events.V1BillingMeterErrorReportTriggeredEventNotification)eventNotification, this.client));
            }
            else if (eventNotification is Stripe.Events.V1BillingMeterNoMeterFoundEventNotification)
            {
                if (this.V1BillingMeterNoMeterFoundEvent == null)
                {
                    throw new Exception("No handler registered for \"V1BillingMeterNoMeterFoundEvent\"");
                }

                this.V1BillingMeterNoMeterFoundEvent.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterNoMeterFoundEventNotification>((Stripe.Events.V1BillingMeterNoMeterFoundEventNotification)eventNotification, this.client));
            }
            else if (eventNotification is Stripe.Events.V2CoreEventDestinationPingEventNotification)
            {
                if (this.V2CoreEventDestinationPingEvent == null)
                {
                    throw new Exception("No handler registered for \"V2CoreEventDestinationPingEvent\"");
                }

                this.V2CoreEventDestinationPingEvent.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreEventDestinationPingEventNotification>((Stripe.Events.V2CoreEventDestinationPingEventNotification)eventNotification, this.client));
            }

            // event-handler-dispatch: The end of the section generated from our OpenAPI spec
            else
            {
                throw new Exception("No handler registered!");
            }
        }
    }
}
