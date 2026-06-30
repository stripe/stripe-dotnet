// File copied from our code generator; changes here will be overwritten.
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Stripe.Events;

    /// <summary>
    /// A handler for Stripe webhook events that uses the .NET event handler pattern.
    /// Allows registration of strongly-typed event handlers for specific EventNotification types.
    /// </summary>
    public class StripeEventNotificationHandler
    {
        private readonly StripeClient client;
        private readonly string webhookSecret;
        private readonly HashSet<string> handledEventTypes = new HashSet<string>();
        private readonly StripeClientOptions clientOptions;

        // A private EventHandler for each EventNotification. We'll route notifications to the correct handler.
        // private-event-handlers: The beginning of the section generated from our OpenAPI spec
        // private-event-handlers: The end of the section generated from our OpenAPI spec

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeEventNotificationHandler"/> class.
        /// </summary>
        /// <param name="client">The StripeClient instance to use for parsing and API requests.</param>
        /// <param name="webhookSecret">The webhook secret used for signature verification.</param>
        /// <param name="fallbackCallback">The function to call when handing an event for whom there's no callback registered.</param>
        public StripeEventNotificationHandler(StripeClient client, string webhookSecret, Action<object, StripeUnhandledEventNotificationEventArgs> fallbackCallback)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            this.client = client;

            if (string.IsNullOrEmpty(webhookSecret))
            {
                throw new ArgumentNullException(nameof(webhookSecret));
            }

            this.webhookSecret = webhookSecret;

            this.FallbackCallback += new EventHandler<StripeUnhandledEventNotificationEventArgs>(fallbackCallback);

            // Capture the client options to reuse configuration when creating new clients
            var requestor = client.Requestor as LiveApiRequestor;
            if (requestor == null)
            {
                throw new InvalidOperationException("StripeEventNotificationHandler requires a StripeClient with a LiveApiRequestor.");
            }

            this.clientOptions = new StripeClientOptions
            {
                ApiKey = requestor.ApiKey,
                ClientId = requestor.ClientId,
                HttpClient = requestor.HttpClient,
                ApiBase = requestor.ApiBase,
                ConnectBase = requestor.ConnectBase,
                FilesBase = requestor.FilesBase,
                MeterEventsBase = requestor.MeterEventsBase,
                StripeAccount = null, // Don't copy StripeAccount or StripeContext
                StripeContext = null,
            };
        }

        private event EventHandler<StripeUnhandledEventNotificationEventArgs> FallbackCallback;

        // public facing EventHandler
        // public-event-handlers: The beginning of the section generated from our OpenAPI spec
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

            // Dispatch to the registered handler with the event's context
            this.DispatchEventWithContext(eventNotification);
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

        /// <summary>
        /// Dispatches the event with the event's StripeContext by creating a new client instance.
        /// </summary>
        /// <param name="eventNotification">The event notification to dispatch.</param>
        private void DispatchEventWithContext(V2.Core.EventNotification eventNotification)
        {
            if (eventNotification == null)
            {
                throw new ArgumentNullException(nameof(eventNotification));
            }

            // If client options somehow didn't get created, bail.
            if (this.clientOptions == null)
            {
                throw new InvalidOperationException("Unable to create client with event context: client options not available.");
            }

            // Create a new client with the event's context
            var eventClientOptions = this.clientOptions.Clone();
            eventClientOptions.StripeContext = eventNotification.Context;
            var eventClient = new StripeClient(eventClientOptions);

            this.DispatchEvent(eventNotification, eventClient);
        }

        private void DispatchEvent(V2.Core.EventNotification eventNotification, StripeClient client)
        {
            if (eventNotification == null)
            {
                throw new ArgumentNullException(nameof(eventNotification));
            }

            if (this.handledEventTypes.Contains(eventNotification.Type))
            {
                // Known event type; dispatch to the appropriate handler
                if (false)
                {
                    // so all of our generated handlers can be `else if`s
                }

                // event-handler-dispatch: The beginning of the section generated from our OpenAPI spec
                else if (eventNotification is Stripe.Events.V1AccountApplicationAuthorizedEventNotification)
                {
                    this.v1AccountApplicationAuthorized.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1AccountApplicationAuthorizedEventNotification>((Stripe.Events.V1AccountApplicationAuthorizedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1AccountApplicationDeauthorizedEventNotification)
                {
                    this.v1AccountApplicationDeauthorized.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1AccountApplicationDeauthorizedEventNotification>((Stripe.Events.V1AccountApplicationDeauthorizedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1AccountExternalAccountCreatedEventNotification)
                {
                    this.v1AccountExternalAccountCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1AccountExternalAccountCreatedEventNotification>((Stripe.Events.V1AccountExternalAccountCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1AccountExternalAccountDeletedEventNotification)
                {
                    this.v1AccountExternalAccountDeleted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1AccountExternalAccountDeletedEventNotification>((Stripe.Events.V1AccountExternalAccountDeletedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1AccountExternalAccountUpdatedEventNotification)
                {
                    this.v1AccountExternalAccountUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1AccountExternalAccountUpdatedEventNotification>((Stripe.Events.V1AccountExternalAccountUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1AccountUpdatedEventNotification)
                {
                    this.v1AccountUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1AccountUpdatedEventNotification>((Stripe.Events.V1AccountUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1AccountSignalsIncludingDelinquencyCreatedEventNotification)
                {
                    this.v1AccountSignalsIncludingDelinquencyCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1AccountSignalsIncludingDelinquencyCreatedEventNotification>((Stripe.Events.V1AccountSignalsIncludingDelinquencyCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ApplicationFeeCreatedEventNotification)
                {
                    this.v1ApplicationFeeCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ApplicationFeeCreatedEventNotification>((Stripe.Events.V1ApplicationFeeCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ApplicationFeeRefundUpdatedEventNotification)
                {
                    this.v1ApplicationFeeRefundUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ApplicationFeeRefundUpdatedEventNotification>((Stripe.Events.V1ApplicationFeeRefundUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ApplicationFeeRefundedEventNotification)
                {
                    this.v1ApplicationFeeRefunded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ApplicationFeeRefundedEventNotification>((Stripe.Events.V1ApplicationFeeRefundedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1BalanceAvailableEventNotification)
                {
                    this.v1BalanceAvailable.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1BalanceAvailableEventNotification>((Stripe.Events.V1BalanceAvailableEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1BillingAlertTriggeredEventNotification)
                {
                    this.v1BillingAlertTriggered.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1BillingAlertTriggeredEventNotification>((Stripe.Events.V1BillingAlertTriggeredEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1BillingMeterErrorReportTriggeredEventNotification)
                {
                    this.v1BillingMeterErrorReportTriggered.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterErrorReportTriggeredEventNotification>((Stripe.Events.V1BillingMeterErrorReportTriggeredEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1BillingMeterNoMeterFoundEventNotification)
                {
                    this.v1BillingMeterNoMeterFound.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterNoMeterFoundEventNotification>((Stripe.Events.V1BillingMeterNoMeterFoundEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1BillingPortalConfigurationCreatedEventNotification)
                {
                    this.v1BillingPortalConfigurationCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1BillingPortalConfigurationCreatedEventNotification>((Stripe.Events.V1BillingPortalConfigurationCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1BillingPortalConfigurationUpdatedEventNotification)
                {
                    this.v1BillingPortalConfigurationUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1BillingPortalConfigurationUpdatedEventNotification>((Stripe.Events.V1BillingPortalConfigurationUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1BillingPortalSessionCreatedEventNotification)
                {
                    this.v1BillingPortalSessionCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1BillingPortalSessionCreatedEventNotification>((Stripe.Events.V1BillingPortalSessionCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CapabilityUpdatedEventNotification)
                {
                    this.v1CapabilityUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CapabilityUpdatedEventNotification>((Stripe.Events.V1CapabilityUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CashBalanceFundsAvailableEventNotification)
                {
                    this.v1CashBalanceFundsAvailable.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CashBalanceFundsAvailableEventNotification>((Stripe.Events.V1CashBalanceFundsAvailableEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ChargeCapturedEventNotification)
                {
                    this.v1ChargeCaptured.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ChargeCapturedEventNotification>((Stripe.Events.V1ChargeCapturedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ChargeDisputeClosedEventNotification)
                {
                    this.v1ChargeDisputeClosed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ChargeDisputeClosedEventNotification>((Stripe.Events.V1ChargeDisputeClosedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ChargeDisputeCreatedEventNotification)
                {
                    this.v1ChargeDisputeCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ChargeDisputeCreatedEventNotification>((Stripe.Events.V1ChargeDisputeCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ChargeDisputeFundsReinstatedEventNotification)
                {
                    this.v1ChargeDisputeFundsReinstated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ChargeDisputeFundsReinstatedEventNotification>((Stripe.Events.V1ChargeDisputeFundsReinstatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ChargeDisputeFundsWithdrawnEventNotification)
                {
                    this.v1ChargeDisputeFundsWithdrawn.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ChargeDisputeFundsWithdrawnEventNotification>((Stripe.Events.V1ChargeDisputeFundsWithdrawnEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ChargeDisputeUpdatedEventNotification)
                {
                    this.v1ChargeDisputeUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ChargeDisputeUpdatedEventNotification>((Stripe.Events.V1ChargeDisputeUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ChargeExpiredEventNotification)
                {
                    this.v1ChargeExpired.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ChargeExpiredEventNotification>((Stripe.Events.V1ChargeExpiredEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ChargeFailedEventNotification)
                {
                    this.v1ChargeFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ChargeFailedEventNotification>((Stripe.Events.V1ChargeFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ChargePendingEventNotification)
                {
                    this.v1ChargePending.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ChargePendingEventNotification>((Stripe.Events.V1ChargePendingEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ChargeRefundUpdatedEventNotification)
                {
                    this.v1ChargeRefundUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ChargeRefundUpdatedEventNotification>((Stripe.Events.V1ChargeRefundUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ChargeRefundedEventNotification)
                {
                    this.v1ChargeRefunded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ChargeRefundedEventNotification>((Stripe.Events.V1ChargeRefundedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ChargeSucceededEventNotification)
                {
                    this.v1ChargeSucceeded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ChargeSucceededEventNotification>((Stripe.Events.V1ChargeSucceededEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ChargeUpdatedEventNotification)
                {
                    this.v1ChargeUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ChargeUpdatedEventNotification>((Stripe.Events.V1ChargeUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CheckoutSessionAsyncPaymentFailedEventNotification)
                {
                    this.v1CheckoutSessionAsyncPaymentFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CheckoutSessionAsyncPaymentFailedEventNotification>((Stripe.Events.V1CheckoutSessionAsyncPaymentFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CheckoutSessionAsyncPaymentSucceededEventNotification)
                {
                    this.v1CheckoutSessionAsyncPaymentSucceeded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CheckoutSessionAsyncPaymentSucceededEventNotification>((Stripe.Events.V1CheckoutSessionAsyncPaymentSucceededEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CheckoutSessionCompletedEventNotification)
                {
                    this.v1CheckoutSessionCompleted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CheckoutSessionCompletedEventNotification>((Stripe.Events.V1CheckoutSessionCompletedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CheckoutSessionExpiredEventNotification)
                {
                    this.v1CheckoutSessionExpired.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CheckoutSessionExpiredEventNotification>((Stripe.Events.V1CheckoutSessionExpiredEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ClimateOrderCanceledEventNotification)
                {
                    this.v1ClimateOrderCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ClimateOrderCanceledEventNotification>((Stripe.Events.V1ClimateOrderCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ClimateOrderCreatedEventNotification)
                {
                    this.v1ClimateOrderCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ClimateOrderCreatedEventNotification>((Stripe.Events.V1ClimateOrderCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ClimateOrderDelayedEventNotification)
                {
                    this.v1ClimateOrderDelayed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ClimateOrderDelayedEventNotification>((Stripe.Events.V1ClimateOrderDelayedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ClimateOrderDeliveredEventNotification)
                {
                    this.v1ClimateOrderDelivered.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ClimateOrderDeliveredEventNotification>((Stripe.Events.V1ClimateOrderDeliveredEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ClimateOrderProductSubstitutedEventNotification)
                {
                    this.v1ClimateOrderProductSubstituted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ClimateOrderProductSubstitutedEventNotification>((Stripe.Events.V1ClimateOrderProductSubstitutedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ClimateProductCreatedEventNotification)
                {
                    this.v1ClimateProductCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ClimateProductCreatedEventNotification>((Stripe.Events.V1ClimateProductCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ClimateProductPricingUpdatedEventNotification)
                {
                    this.v1ClimateProductPricingUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ClimateProductPricingUpdatedEventNotification>((Stripe.Events.V1ClimateProductPricingUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CouponCreatedEventNotification)
                {
                    this.v1CouponCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CouponCreatedEventNotification>((Stripe.Events.V1CouponCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CouponDeletedEventNotification)
                {
                    this.v1CouponDeleted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CouponDeletedEventNotification>((Stripe.Events.V1CouponDeletedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CouponUpdatedEventNotification)
                {
                    this.v1CouponUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CouponUpdatedEventNotification>((Stripe.Events.V1CouponUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CreditNoteCreatedEventNotification)
                {
                    this.v1CreditNoteCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CreditNoteCreatedEventNotification>((Stripe.Events.V1CreditNoteCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CreditNoteUpdatedEventNotification)
                {
                    this.v1CreditNoteUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CreditNoteUpdatedEventNotification>((Stripe.Events.V1CreditNoteUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CreditNoteVoidedEventNotification)
                {
                    this.v1CreditNoteVoided.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CreditNoteVoidedEventNotification>((Stripe.Events.V1CreditNoteVoidedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CustomerCreatedEventNotification)
                {
                    this.v1CustomerCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CustomerCreatedEventNotification>((Stripe.Events.V1CustomerCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CustomerDeletedEventNotification)
                {
                    this.v1CustomerDeleted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CustomerDeletedEventNotification>((Stripe.Events.V1CustomerDeletedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CustomerSubscriptionCreatedEventNotification)
                {
                    this.v1CustomerSubscriptionCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CustomerSubscriptionCreatedEventNotification>((Stripe.Events.V1CustomerSubscriptionCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CustomerSubscriptionDeletedEventNotification)
                {
                    this.v1CustomerSubscriptionDeleted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CustomerSubscriptionDeletedEventNotification>((Stripe.Events.V1CustomerSubscriptionDeletedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CustomerSubscriptionPausedEventNotification)
                {
                    this.v1CustomerSubscriptionPaused.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CustomerSubscriptionPausedEventNotification>((Stripe.Events.V1CustomerSubscriptionPausedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CustomerSubscriptionPendingUpdateAppliedEventNotification)
                {
                    this.v1CustomerSubscriptionPendingUpdateApplied.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CustomerSubscriptionPendingUpdateAppliedEventNotification>((Stripe.Events.V1CustomerSubscriptionPendingUpdateAppliedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CustomerSubscriptionPendingUpdateExpiredEventNotification)
                {
                    this.v1CustomerSubscriptionPendingUpdateExpired.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CustomerSubscriptionPendingUpdateExpiredEventNotification>((Stripe.Events.V1CustomerSubscriptionPendingUpdateExpiredEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CustomerSubscriptionResumedEventNotification)
                {
                    this.v1CustomerSubscriptionResumed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CustomerSubscriptionResumedEventNotification>((Stripe.Events.V1CustomerSubscriptionResumedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CustomerSubscriptionTrialWillEndEventNotification)
                {
                    this.v1CustomerSubscriptionTrialWillEnd.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CustomerSubscriptionTrialWillEndEventNotification>((Stripe.Events.V1CustomerSubscriptionTrialWillEndEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CustomerSubscriptionUpdatedEventNotification)
                {
                    this.v1CustomerSubscriptionUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CustomerSubscriptionUpdatedEventNotification>((Stripe.Events.V1CustomerSubscriptionUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CustomerTaxIdCreatedEventNotification)
                {
                    this.v1CustomerTaxIdCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CustomerTaxIdCreatedEventNotification>((Stripe.Events.V1CustomerTaxIdCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CustomerTaxIdDeletedEventNotification)
                {
                    this.v1CustomerTaxIdDeleted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CustomerTaxIdDeletedEventNotification>((Stripe.Events.V1CustomerTaxIdDeletedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CustomerTaxIdUpdatedEventNotification)
                {
                    this.v1CustomerTaxIdUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CustomerTaxIdUpdatedEventNotification>((Stripe.Events.V1CustomerTaxIdUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CustomerUpdatedEventNotification)
                {
                    this.v1CustomerUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CustomerUpdatedEventNotification>((Stripe.Events.V1CustomerUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1CustomerCashBalanceTransactionCreatedEventNotification)
                {
                    this.v1CustomerCashBalanceTransactionCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1CustomerCashBalanceTransactionCreatedEventNotification>((Stripe.Events.V1CustomerCashBalanceTransactionCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1EntitlementsActiveEntitlementSummaryUpdatedEventNotification)
                {
                    this.v1EntitlementsActiveEntitlementSummaryUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1EntitlementsActiveEntitlementSummaryUpdatedEventNotification>((Stripe.Events.V1EntitlementsActiveEntitlementSummaryUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1FileCreatedEventNotification)
                {
                    this.v1FileCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1FileCreatedEventNotification>((Stripe.Events.V1FileCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1FinancialConnectionsAccountCreatedEventNotification)
                {
                    this.v1FinancialConnectionsAccountCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountCreatedEventNotification>((Stripe.Events.V1FinancialConnectionsAccountCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1FinancialConnectionsAccountDeactivatedEventNotification)
                {
                    this.v1FinancialConnectionsAccountDeactivated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountDeactivatedEventNotification>((Stripe.Events.V1FinancialConnectionsAccountDeactivatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1FinancialConnectionsAccountDisconnectedEventNotification)
                {
                    this.v1FinancialConnectionsAccountDisconnected.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountDisconnectedEventNotification>((Stripe.Events.V1FinancialConnectionsAccountDisconnectedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1FinancialConnectionsAccountReactivatedEventNotification)
                {
                    this.v1FinancialConnectionsAccountReactivated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountReactivatedEventNotification>((Stripe.Events.V1FinancialConnectionsAccountReactivatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1FinancialConnectionsAccountRefreshedBalanceEventNotification)
                {
                    this.v1FinancialConnectionsAccountRefreshedBalance.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountRefreshedBalanceEventNotification>((Stripe.Events.V1FinancialConnectionsAccountRefreshedBalanceEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1FinancialConnectionsAccountRefreshedOwnershipEventNotification)
                {
                    this.v1FinancialConnectionsAccountRefreshedOwnership.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountRefreshedOwnershipEventNotification>((Stripe.Events.V1FinancialConnectionsAccountRefreshedOwnershipEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1FinancialConnectionsAccountRefreshedTransactionsEventNotification)
                {
                    this.v1FinancialConnectionsAccountRefreshedTransactions.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1FinancialConnectionsAccountRefreshedTransactionsEventNotification>((Stripe.Events.V1FinancialConnectionsAccountRefreshedTransactionsEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IdentityVerificationSessionCanceledEventNotification)
                {
                    this.v1IdentityVerificationSessionCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IdentityVerificationSessionCanceledEventNotification>((Stripe.Events.V1IdentityVerificationSessionCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IdentityVerificationSessionCreatedEventNotification)
                {
                    this.v1IdentityVerificationSessionCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IdentityVerificationSessionCreatedEventNotification>((Stripe.Events.V1IdentityVerificationSessionCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IdentityVerificationSessionProcessingEventNotification)
                {
                    this.v1IdentityVerificationSessionProcessing.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IdentityVerificationSessionProcessingEventNotification>((Stripe.Events.V1IdentityVerificationSessionProcessingEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IdentityVerificationSessionRedactedEventNotification)
                {
                    this.v1IdentityVerificationSessionRedacted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IdentityVerificationSessionRedactedEventNotification>((Stripe.Events.V1IdentityVerificationSessionRedactedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IdentityVerificationSessionRequiresInputEventNotification)
                {
                    this.v1IdentityVerificationSessionRequiresInput.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IdentityVerificationSessionRequiresInputEventNotification>((Stripe.Events.V1IdentityVerificationSessionRequiresInputEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IdentityVerificationSessionVerifiedEventNotification)
                {
                    this.v1IdentityVerificationSessionVerified.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IdentityVerificationSessionVerifiedEventNotification>((Stripe.Events.V1IdentityVerificationSessionVerifiedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoiceCreatedEventNotification)
                {
                    this.v1InvoiceCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceCreatedEventNotification>((Stripe.Events.V1InvoiceCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoiceDeletedEventNotification)
                {
                    this.v1InvoiceDeleted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceDeletedEventNotification>((Stripe.Events.V1InvoiceDeletedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoiceFinalizationFailedEventNotification)
                {
                    this.v1InvoiceFinalizationFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceFinalizationFailedEventNotification>((Stripe.Events.V1InvoiceFinalizationFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoiceFinalizedEventNotification)
                {
                    this.v1InvoiceFinalized.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceFinalizedEventNotification>((Stripe.Events.V1InvoiceFinalizedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoiceMarkedUncollectibleEventNotification)
                {
                    this.v1InvoiceMarkedUncollectible.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceMarkedUncollectibleEventNotification>((Stripe.Events.V1InvoiceMarkedUncollectibleEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoiceOverdueEventNotification)
                {
                    this.v1InvoiceOverdue.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceOverdueEventNotification>((Stripe.Events.V1InvoiceOverdueEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoiceOverpaidEventNotification)
                {
                    this.v1InvoiceOverpaid.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceOverpaidEventNotification>((Stripe.Events.V1InvoiceOverpaidEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoicePaidEventNotification)
                {
                    this.v1InvoicePaid.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoicePaidEventNotification>((Stripe.Events.V1InvoicePaidEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoicePaymentActionRequiredEventNotification)
                {
                    this.v1InvoicePaymentActionRequired.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoicePaymentActionRequiredEventNotification>((Stripe.Events.V1InvoicePaymentActionRequiredEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoicePaymentFailedEventNotification)
                {
                    this.v1InvoicePaymentFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoicePaymentFailedEventNotification>((Stripe.Events.V1InvoicePaymentFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoicePaymentSucceededEventNotification)
                {
                    this.v1InvoicePaymentSucceeded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoicePaymentSucceededEventNotification>((Stripe.Events.V1InvoicePaymentSucceededEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoiceSentEventNotification)
                {
                    this.v1InvoiceSent.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceSentEventNotification>((Stripe.Events.V1InvoiceSentEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoiceUpcomingEventNotification)
                {
                    this.v1InvoiceUpcoming.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceUpcomingEventNotification>((Stripe.Events.V1InvoiceUpcomingEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoiceUpdatedEventNotification)
                {
                    this.v1InvoiceUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceUpdatedEventNotification>((Stripe.Events.V1InvoiceUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoiceVoidedEventNotification)
                {
                    this.v1InvoiceVoided.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceVoidedEventNotification>((Stripe.Events.V1InvoiceVoidedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoiceWillBeDueEventNotification)
                {
                    this.v1InvoiceWillBeDue.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceWillBeDueEventNotification>((Stripe.Events.V1InvoiceWillBeDueEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoicePaymentPaidEventNotification)
                {
                    this.v1InvoicePaymentPaid.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoicePaymentPaidEventNotification>((Stripe.Events.V1InvoicePaymentPaidEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoiceitemCreatedEventNotification)
                {
                    this.v1InvoiceitemCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceitemCreatedEventNotification>((Stripe.Events.V1InvoiceitemCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1InvoiceitemDeletedEventNotification)
                {
                    this.v1InvoiceitemDeleted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1InvoiceitemDeletedEventNotification>((Stripe.Events.V1InvoiceitemDeletedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingAuthorizationCreatedEventNotification)
                {
                    this.v1IssuingAuthorizationCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingAuthorizationCreatedEventNotification>((Stripe.Events.V1IssuingAuthorizationCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingAuthorizationRequestEventNotification)
                {
                    this.v1IssuingAuthorizationRequest.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingAuthorizationRequestEventNotification>((Stripe.Events.V1IssuingAuthorizationRequestEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingAuthorizationUpdatedEventNotification)
                {
                    this.v1IssuingAuthorizationUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingAuthorizationUpdatedEventNotification>((Stripe.Events.V1IssuingAuthorizationUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingCardCreatedEventNotification)
                {
                    this.v1IssuingCardCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingCardCreatedEventNotification>((Stripe.Events.V1IssuingCardCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingCardUpdatedEventNotification)
                {
                    this.v1IssuingCardUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingCardUpdatedEventNotification>((Stripe.Events.V1IssuingCardUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingCardholderCreatedEventNotification)
                {
                    this.v1IssuingCardholderCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingCardholderCreatedEventNotification>((Stripe.Events.V1IssuingCardholderCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingCardholderUpdatedEventNotification)
                {
                    this.v1IssuingCardholderUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingCardholderUpdatedEventNotification>((Stripe.Events.V1IssuingCardholderUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingDisputeClosedEventNotification)
                {
                    this.v1IssuingDisputeClosed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingDisputeClosedEventNotification>((Stripe.Events.V1IssuingDisputeClosedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingDisputeCreatedEventNotification)
                {
                    this.v1IssuingDisputeCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingDisputeCreatedEventNotification>((Stripe.Events.V1IssuingDisputeCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingDisputeFundsReinstatedEventNotification)
                {
                    this.v1IssuingDisputeFundsReinstated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingDisputeFundsReinstatedEventNotification>((Stripe.Events.V1IssuingDisputeFundsReinstatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingDisputeFundsRescindedEventNotification)
                {
                    this.v1IssuingDisputeFundsRescinded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingDisputeFundsRescindedEventNotification>((Stripe.Events.V1IssuingDisputeFundsRescindedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingDisputeSubmittedEventNotification)
                {
                    this.v1IssuingDisputeSubmitted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingDisputeSubmittedEventNotification>((Stripe.Events.V1IssuingDisputeSubmittedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingDisputeUpdatedEventNotification)
                {
                    this.v1IssuingDisputeUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingDisputeUpdatedEventNotification>((Stripe.Events.V1IssuingDisputeUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingPersonalizationDesignActivatedEventNotification)
                {
                    this.v1IssuingPersonalizationDesignActivated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingPersonalizationDesignActivatedEventNotification>((Stripe.Events.V1IssuingPersonalizationDesignActivatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingPersonalizationDesignDeactivatedEventNotification)
                {
                    this.v1IssuingPersonalizationDesignDeactivated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingPersonalizationDesignDeactivatedEventNotification>((Stripe.Events.V1IssuingPersonalizationDesignDeactivatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingPersonalizationDesignRejectedEventNotification)
                {
                    this.v1IssuingPersonalizationDesignRejected.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingPersonalizationDesignRejectedEventNotification>((Stripe.Events.V1IssuingPersonalizationDesignRejectedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingPersonalizationDesignUpdatedEventNotification)
                {
                    this.v1IssuingPersonalizationDesignUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingPersonalizationDesignUpdatedEventNotification>((Stripe.Events.V1IssuingPersonalizationDesignUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingTokenCreatedEventNotification)
                {
                    this.v1IssuingTokenCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingTokenCreatedEventNotification>((Stripe.Events.V1IssuingTokenCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingTokenUpdatedEventNotification)
                {
                    this.v1IssuingTokenUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingTokenUpdatedEventNotification>((Stripe.Events.V1IssuingTokenUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingTransactionCreatedEventNotification)
                {
                    this.v1IssuingTransactionCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingTransactionCreatedEventNotification>((Stripe.Events.V1IssuingTransactionCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingTransactionPurchaseDetailsReceiptUpdatedEventNotification)
                {
                    this.v1IssuingTransactionPurchaseDetailsReceiptUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingTransactionPurchaseDetailsReceiptUpdatedEventNotification>((Stripe.Events.V1IssuingTransactionPurchaseDetailsReceiptUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1IssuingTransactionUpdatedEventNotification)
                {
                    this.v1IssuingTransactionUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1IssuingTransactionUpdatedEventNotification>((Stripe.Events.V1IssuingTransactionUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1MandateUpdatedEventNotification)
                {
                    this.v1MandateUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1MandateUpdatedEventNotification>((Stripe.Events.V1MandateUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PaymentIntentAmountCapturableUpdatedEventNotification)
                {
                    this.v1PaymentIntentAmountCapturableUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PaymentIntentAmountCapturableUpdatedEventNotification>((Stripe.Events.V1PaymentIntentAmountCapturableUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PaymentIntentCanceledEventNotification)
                {
                    this.v1PaymentIntentCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PaymentIntentCanceledEventNotification>((Stripe.Events.V1PaymentIntentCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PaymentIntentCreatedEventNotification)
                {
                    this.v1PaymentIntentCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PaymentIntentCreatedEventNotification>((Stripe.Events.V1PaymentIntentCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PaymentIntentPartiallyFundedEventNotification)
                {
                    this.v1PaymentIntentPartiallyFunded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PaymentIntentPartiallyFundedEventNotification>((Stripe.Events.V1PaymentIntentPartiallyFundedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PaymentIntentPaymentFailedEventNotification)
                {
                    this.v1PaymentIntentPaymentFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PaymentIntentPaymentFailedEventNotification>((Stripe.Events.V1PaymentIntentPaymentFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PaymentIntentProcessingEventNotification)
                {
                    this.v1PaymentIntentProcessing.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PaymentIntentProcessingEventNotification>((Stripe.Events.V1PaymentIntentProcessingEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PaymentIntentRequiresActionEventNotification)
                {
                    this.v1PaymentIntentRequiresAction.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PaymentIntentRequiresActionEventNotification>((Stripe.Events.V1PaymentIntentRequiresActionEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PaymentIntentSucceededEventNotification)
                {
                    this.v1PaymentIntentSucceeded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PaymentIntentSucceededEventNotification>((Stripe.Events.V1PaymentIntentSucceededEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PaymentLinkCreatedEventNotification)
                {
                    this.v1PaymentLinkCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PaymentLinkCreatedEventNotification>((Stripe.Events.V1PaymentLinkCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PaymentLinkUpdatedEventNotification)
                {
                    this.v1PaymentLinkUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PaymentLinkUpdatedEventNotification>((Stripe.Events.V1PaymentLinkUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PaymentMethodAttachedEventNotification)
                {
                    this.v1PaymentMethodAttached.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PaymentMethodAttachedEventNotification>((Stripe.Events.V1PaymentMethodAttachedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PaymentMethodAutomaticallyUpdatedEventNotification)
                {
                    this.v1PaymentMethodAutomaticallyUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PaymentMethodAutomaticallyUpdatedEventNotification>((Stripe.Events.V1PaymentMethodAutomaticallyUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PaymentMethodDetachedEventNotification)
                {
                    this.v1PaymentMethodDetached.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PaymentMethodDetachedEventNotification>((Stripe.Events.V1PaymentMethodDetachedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PaymentMethodUpdatedEventNotification)
                {
                    this.v1PaymentMethodUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PaymentMethodUpdatedEventNotification>((Stripe.Events.V1PaymentMethodUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PayoutCanceledEventNotification)
                {
                    this.v1PayoutCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PayoutCanceledEventNotification>((Stripe.Events.V1PayoutCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PayoutCreatedEventNotification)
                {
                    this.v1PayoutCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PayoutCreatedEventNotification>((Stripe.Events.V1PayoutCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PayoutFailedEventNotification)
                {
                    this.v1PayoutFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PayoutFailedEventNotification>((Stripe.Events.V1PayoutFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PayoutPaidEventNotification)
                {
                    this.v1PayoutPaid.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PayoutPaidEventNotification>((Stripe.Events.V1PayoutPaidEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PayoutReconciliationCompletedEventNotification)
                {
                    this.v1PayoutReconciliationCompleted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PayoutReconciliationCompletedEventNotification>((Stripe.Events.V1PayoutReconciliationCompletedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PayoutUpdatedEventNotification)
                {
                    this.v1PayoutUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PayoutUpdatedEventNotification>((Stripe.Events.V1PayoutUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PersonCreatedEventNotification)
                {
                    this.v1PersonCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PersonCreatedEventNotification>((Stripe.Events.V1PersonCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PersonDeletedEventNotification)
                {
                    this.v1PersonDeleted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PersonDeletedEventNotification>((Stripe.Events.V1PersonDeletedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PersonUpdatedEventNotification)
                {
                    this.v1PersonUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PersonUpdatedEventNotification>((Stripe.Events.V1PersonUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PlanCreatedEventNotification)
                {
                    this.v1PlanCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PlanCreatedEventNotification>((Stripe.Events.V1PlanCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PlanDeletedEventNotification)
                {
                    this.v1PlanDeleted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PlanDeletedEventNotification>((Stripe.Events.V1PlanDeletedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PlanUpdatedEventNotification)
                {
                    this.v1PlanUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PlanUpdatedEventNotification>((Stripe.Events.V1PlanUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PriceCreatedEventNotification)
                {
                    this.v1PriceCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PriceCreatedEventNotification>((Stripe.Events.V1PriceCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PriceDeletedEventNotification)
                {
                    this.v1PriceDeleted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PriceDeletedEventNotification>((Stripe.Events.V1PriceDeletedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PriceUpdatedEventNotification)
                {
                    this.v1PriceUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PriceUpdatedEventNotification>((Stripe.Events.V1PriceUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ProductCreatedEventNotification)
                {
                    this.v1ProductCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ProductCreatedEventNotification>((Stripe.Events.V1ProductCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ProductDeletedEventNotification)
                {
                    this.v1ProductDeleted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ProductDeletedEventNotification>((Stripe.Events.V1ProductDeletedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ProductUpdatedEventNotification)
                {
                    this.v1ProductUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ProductUpdatedEventNotification>((Stripe.Events.V1ProductUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PromotionCodeCreatedEventNotification)
                {
                    this.v1PromotionCodeCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PromotionCodeCreatedEventNotification>((Stripe.Events.V1PromotionCodeCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1PromotionCodeUpdatedEventNotification)
                {
                    this.v1PromotionCodeUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1PromotionCodeUpdatedEventNotification>((Stripe.Events.V1PromotionCodeUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1QuoteAcceptedEventNotification)
                {
                    this.v1QuoteAccepted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1QuoteAcceptedEventNotification>((Stripe.Events.V1QuoteAcceptedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1QuoteCanceledEventNotification)
                {
                    this.v1QuoteCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1QuoteCanceledEventNotification>((Stripe.Events.V1QuoteCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1QuoteCreatedEventNotification)
                {
                    this.v1QuoteCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1QuoteCreatedEventNotification>((Stripe.Events.V1QuoteCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1QuoteFinalizedEventNotification)
                {
                    this.v1QuoteFinalized.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1QuoteFinalizedEventNotification>((Stripe.Events.V1QuoteFinalizedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1RadarEarlyFraudWarningCreatedEventNotification)
                {
                    this.v1RadarEarlyFraudWarningCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1RadarEarlyFraudWarningCreatedEventNotification>((Stripe.Events.V1RadarEarlyFraudWarningCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1RadarEarlyFraudWarningUpdatedEventNotification)
                {
                    this.v1RadarEarlyFraudWarningUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1RadarEarlyFraudWarningUpdatedEventNotification>((Stripe.Events.V1RadarEarlyFraudWarningUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1RefundCreatedEventNotification)
                {
                    this.v1RefundCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1RefundCreatedEventNotification>((Stripe.Events.V1RefundCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1RefundFailedEventNotification)
                {
                    this.v1RefundFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1RefundFailedEventNotification>((Stripe.Events.V1RefundFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1RefundUpdatedEventNotification)
                {
                    this.v1RefundUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1RefundUpdatedEventNotification>((Stripe.Events.V1RefundUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ReviewClosedEventNotification)
                {
                    this.v1ReviewClosed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ReviewClosedEventNotification>((Stripe.Events.V1ReviewClosedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1ReviewOpenedEventNotification)
                {
                    this.v1ReviewOpened.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1ReviewOpenedEventNotification>((Stripe.Events.V1ReviewOpenedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1SetupIntentCanceledEventNotification)
                {
                    this.v1SetupIntentCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1SetupIntentCanceledEventNotification>((Stripe.Events.V1SetupIntentCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1SetupIntentCreatedEventNotification)
                {
                    this.v1SetupIntentCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1SetupIntentCreatedEventNotification>((Stripe.Events.V1SetupIntentCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1SetupIntentRequiresActionEventNotification)
                {
                    this.v1SetupIntentRequiresAction.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1SetupIntentRequiresActionEventNotification>((Stripe.Events.V1SetupIntentRequiresActionEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1SetupIntentSetupFailedEventNotification)
                {
                    this.v1SetupIntentSetupFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1SetupIntentSetupFailedEventNotification>((Stripe.Events.V1SetupIntentSetupFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1SetupIntentSucceededEventNotification)
                {
                    this.v1SetupIntentSucceeded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1SetupIntentSucceededEventNotification>((Stripe.Events.V1SetupIntentSucceededEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1SigmaScheduledQueryRunCreatedEventNotification)
                {
                    this.v1SigmaScheduledQueryRunCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1SigmaScheduledQueryRunCreatedEventNotification>((Stripe.Events.V1SigmaScheduledQueryRunCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1SourceCanceledEventNotification)
                {
                    this.v1SourceCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1SourceCanceledEventNotification>((Stripe.Events.V1SourceCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1SourceChargeableEventNotification)
                {
                    this.v1SourceChargeable.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1SourceChargeableEventNotification>((Stripe.Events.V1SourceChargeableEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1SourceFailedEventNotification)
                {
                    this.v1SourceFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1SourceFailedEventNotification>((Stripe.Events.V1SourceFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1SourceRefundAttributesRequiredEventNotification)
                {
                    this.v1SourceRefundAttributesRequired.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1SourceRefundAttributesRequiredEventNotification>((Stripe.Events.V1SourceRefundAttributesRequiredEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1SubscriptionScheduleAbortedEventNotification)
                {
                    this.v1SubscriptionScheduleAborted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1SubscriptionScheduleAbortedEventNotification>((Stripe.Events.V1SubscriptionScheduleAbortedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1SubscriptionScheduleCanceledEventNotification)
                {
                    this.v1SubscriptionScheduleCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1SubscriptionScheduleCanceledEventNotification>((Stripe.Events.V1SubscriptionScheduleCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1SubscriptionScheduleCompletedEventNotification)
                {
                    this.v1SubscriptionScheduleCompleted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1SubscriptionScheduleCompletedEventNotification>((Stripe.Events.V1SubscriptionScheduleCompletedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1SubscriptionScheduleCreatedEventNotification)
                {
                    this.v1SubscriptionScheduleCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1SubscriptionScheduleCreatedEventNotification>((Stripe.Events.V1SubscriptionScheduleCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1SubscriptionScheduleExpiringEventNotification)
                {
                    this.v1SubscriptionScheduleExpiring.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1SubscriptionScheduleExpiringEventNotification>((Stripe.Events.V1SubscriptionScheduleExpiringEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1SubscriptionScheduleReleasedEventNotification)
                {
                    this.v1SubscriptionScheduleReleased.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1SubscriptionScheduleReleasedEventNotification>((Stripe.Events.V1SubscriptionScheduleReleasedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1SubscriptionScheduleUpdatedEventNotification)
                {
                    this.v1SubscriptionScheduleUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1SubscriptionScheduleUpdatedEventNotification>((Stripe.Events.V1SubscriptionScheduleUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TaxSettingsUpdatedEventNotification)
                {
                    this.v1TaxSettingsUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TaxSettingsUpdatedEventNotification>((Stripe.Events.V1TaxSettingsUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TaxRateCreatedEventNotification)
                {
                    this.v1TaxRateCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TaxRateCreatedEventNotification>((Stripe.Events.V1TaxRateCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TaxRateUpdatedEventNotification)
                {
                    this.v1TaxRateUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TaxRateUpdatedEventNotification>((Stripe.Events.V1TaxRateUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TerminalReaderActionFailedEventNotification)
                {
                    this.v1TerminalReaderActionFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TerminalReaderActionFailedEventNotification>((Stripe.Events.V1TerminalReaderActionFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TerminalReaderActionSucceededEventNotification)
                {
                    this.v1TerminalReaderActionSucceeded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TerminalReaderActionSucceededEventNotification>((Stripe.Events.V1TerminalReaderActionSucceededEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TerminalReaderActionUpdatedEventNotification)
                {
                    this.v1TerminalReaderActionUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TerminalReaderActionUpdatedEventNotification>((Stripe.Events.V1TerminalReaderActionUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TestHelpersTestClockAdvancingEventNotification)
                {
                    this.v1TestHelpersTestClockAdvancing.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TestHelpersTestClockAdvancingEventNotification>((Stripe.Events.V1TestHelpersTestClockAdvancingEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TestHelpersTestClockCreatedEventNotification)
                {
                    this.v1TestHelpersTestClockCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TestHelpersTestClockCreatedEventNotification>((Stripe.Events.V1TestHelpersTestClockCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TestHelpersTestClockDeletedEventNotification)
                {
                    this.v1TestHelpersTestClockDeleted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TestHelpersTestClockDeletedEventNotification>((Stripe.Events.V1TestHelpersTestClockDeletedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TestHelpersTestClockInternalFailureEventNotification)
                {
                    this.v1TestHelpersTestClockInternalFailure.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TestHelpersTestClockInternalFailureEventNotification>((Stripe.Events.V1TestHelpersTestClockInternalFailureEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TestHelpersTestClockReadyEventNotification)
                {
                    this.v1TestHelpersTestClockReady.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TestHelpersTestClockReadyEventNotification>((Stripe.Events.V1TestHelpersTestClockReadyEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TopupCanceledEventNotification)
                {
                    this.v1TopupCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TopupCanceledEventNotification>((Stripe.Events.V1TopupCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TopupCreatedEventNotification)
                {
                    this.v1TopupCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TopupCreatedEventNotification>((Stripe.Events.V1TopupCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TopupFailedEventNotification)
                {
                    this.v1TopupFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TopupFailedEventNotification>((Stripe.Events.V1TopupFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TopupReversedEventNotification)
                {
                    this.v1TopupReversed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TopupReversedEventNotification>((Stripe.Events.V1TopupReversedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TopupSucceededEventNotification)
                {
                    this.v1TopupSucceeded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TopupSucceededEventNotification>((Stripe.Events.V1TopupSucceededEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TransferCreatedEventNotification)
                {
                    this.v1TransferCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TransferCreatedEventNotification>((Stripe.Events.V1TransferCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TransferReversedEventNotification)
                {
                    this.v1TransferReversed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TransferReversedEventNotification>((Stripe.Events.V1TransferReversedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1TransferUpdatedEventNotification)
                {
                    this.v1TransferUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1TransferUpdatedEventNotification>((Stripe.Events.V1TransferUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingCadenceBilledEventNotification)
                {
                    this.v2BillingCadenceBilled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingCadenceBilledEventNotification>((Stripe.Events.V2BillingCadenceBilledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingCadenceCanceledEventNotification)
                {
                    this.v2BillingCadenceCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingCadenceCanceledEventNotification>((Stripe.Events.V2BillingCadenceCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingCadenceCreatedEventNotification)
                {
                    this.v2BillingCadenceCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingCadenceCreatedEventNotification>((Stripe.Events.V2BillingCadenceCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingLicenseFeeCreatedEventNotification)
                {
                    this.v2BillingLicenseFeeCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingLicenseFeeCreatedEventNotification>((Stripe.Events.V2BillingLicenseFeeCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingLicenseFeeUpdatedEventNotification)
                {
                    this.v2BillingLicenseFeeUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingLicenseFeeUpdatedEventNotification>((Stripe.Events.V2BillingLicenseFeeUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingLicenseFeeVersionCreatedEventNotification)
                {
                    this.v2BillingLicenseFeeVersionCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingLicenseFeeVersionCreatedEventNotification>((Stripe.Events.V2BillingLicenseFeeVersionCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingLicensedItemCreatedEventNotification)
                {
                    this.v2BillingLicensedItemCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingLicensedItemCreatedEventNotification>((Stripe.Events.V2BillingLicensedItemCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingLicensedItemUpdatedEventNotification)
                {
                    this.v2BillingLicensedItemUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingLicensedItemUpdatedEventNotification>((Stripe.Events.V2BillingLicensedItemUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingMeteredItemCreatedEventNotification)
                {
                    this.v2BillingMeteredItemCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingMeteredItemCreatedEventNotification>((Stripe.Events.V2BillingMeteredItemCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingMeteredItemUpdatedEventNotification)
                {
                    this.v2BillingMeteredItemUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingMeteredItemUpdatedEventNotification>((Stripe.Events.V2BillingMeteredItemUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingPricingPlanCreatedEventNotification)
                {
                    this.v2BillingPricingPlanCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanCreatedEventNotification>((Stripe.Events.V2BillingPricingPlanCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingPricingPlanUpdatedEventNotification)
                {
                    this.v2BillingPricingPlanUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanUpdatedEventNotification>((Stripe.Events.V2BillingPricingPlanUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingPricingPlanComponentCreatedEventNotification)
                {
                    this.v2BillingPricingPlanComponentCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanComponentCreatedEventNotification>((Stripe.Events.V2BillingPricingPlanComponentCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingPricingPlanComponentUpdatedEventNotification)
                {
                    this.v2BillingPricingPlanComponentUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanComponentUpdatedEventNotification>((Stripe.Events.V2BillingPricingPlanComponentUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingPricingPlanSubscriptionCollectionAwaitingCustomerActionEventNotification)
                {
                    this.v2BillingPricingPlanSubscriptionCollectionAwaitingCustomerAction.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanSubscriptionCollectionAwaitingCustomerActionEventNotification>((Stripe.Events.V2BillingPricingPlanSubscriptionCollectionAwaitingCustomerActionEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingPricingPlanSubscriptionCollectionCurrentEventNotification)
                {
                    this.v2BillingPricingPlanSubscriptionCollectionCurrent.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanSubscriptionCollectionCurrentEventNotification>((Stripe.Events.V2BillingPricingPlanSubscriptionCollectionCurrentEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingPricingPlanSubscriptionCollectionPastDueEventNotification)
                {
                    this.v2BillingPricingPlanSubscriptionCollectionPastDue.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanSubscriptionCollectionPastDueEventNotification>((Stripe.Events.V2BillingPricingPlanSubscriptionCollectionPastDueEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingPricingPlanSubscriptionCollectionPausedEventNotification)
                {
                    this.v2BillingPricingPlanSubscriptionCollectionPaused.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanSubscriptionCollectionPausedEventNotification>((Stripe.Events.V2BillingPricingPlanSubscriptionCollectionPausedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingPricingPlanSubscriptionCollectionUnpaidEventNotification)
                {
                    this.v2BillingPricingPlanSubscriptionCollectionUnpaid.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanSubscriptionCollectionUnpaidEventNotification>((Stripe.Events.V2BillingPricingPlanSubscriptionCollectionUnpaidEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingPricingPlanSubscriptionServicingActivatedEventNotification)
                {
                    this.v2BillingPricingPlanSubscriptionServicingActivated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanSubscriptionServicingActivatedEventNotification>((Stripe.Events.V2BillingPricingPlanSubscriptionServicingActivatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingPricingPlanSubscriptionServicingCanceledEventNotification)
                {
                    this.v2BillingPricingPlanSubscriptionServicingCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanSubscriptionServicingCanceledEventNotification>((Stripe.Events.V2BillingPricingPlanSubscriptionServicingCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingPricingPlanSubscriptionServicingPausedEventNotification)
                {
                    this.v2BillingPricingPlanSubscriptionServicingPaused.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanSubscriptionServicingPausedEventNotification>((Stripe.Events.V2BillingPricingPlanSubscriptionServicingPausedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingPricingPlanVersionCreatedEventNotification)
                {
                    this.v2BillingPricingPlanVersionCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingPricingPlanVersionCreatedEventNotification>((Stripe.Events.V2BillingPricingPlanVersionCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingRateCardCreatedEventNotification)
                {
                    this.v2BillingRateCardCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardCreatedEventNotification>((Stripe.Events.V2BillingRateCardCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingRateCardUpdatedEventNotification)
                {
                    this.v2BillingRateCardUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardUpdatedEventNotification>((Stripe.Events.V2BillingRateCardUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingRateCardCustomPricingUnitOverageRateCreatedEventNotification)
                {
                    this.v2BillingRateCardCustomPricingUnitOverageRateCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardCustomPricingUnitOverageRateCreatedEventNotification>((Stripe.Events.V2BillingRateCardCustomPricingUnitOverageRateCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingRateCardRateCreatedEventNotification)
                {
                    this.v2BillingRateCardRateCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardRateCreatedEventNotification>((Stripe.Events.V2BillingRateCardRateCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingRateCardSubscriptionActivatedEventNotification)
                {
                    this.v2BillingRateCardSubscriptionActivated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionActivatedEventNotification>((Stripe.Events.V2BillingRateCardSubscriptionActivatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingRateCardSubscriptionCanceledEventNotification)
                {
                    this.v2BillingRateCardSubscriptionCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionCanceledEventNotification>((Stripe.Events.V2BillingRateCardSubscriptionCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingRateCardSubscriptionCollectionAwaitingCustomerActionEventNotification)
                {
                    this.v2BillingRateCardSubscriptionCollectionAwaitingCustomerAction.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionCollectionAwaitingCustomerActionEventNotification>((Stripe.Events.V2BillingRateCardSubscriptionCollectionAwaitingCustomerActionEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingRateCardSubscriptionCollectionCurrentEventNotification)
                {
                    this.v2BillingRateCardSubscriptionCollectionCurrent.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionCollectionCurrentEventNotification>((Stripe.Events.V2BillingRateCardSubscriptionCollectionCurrentEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingRateCardSubscriptionCollectionPastDueEventNotification)
                {
                    this.v2BillingRateCardSubscriptionCollectionPastDue.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionCollectionPastDueEventNotification>((Stripe.Events.V2BillingRateCardSubscriptionCollectionPastDueEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingRateCardSubscriptionCollectionPausedEventNotification)
                {
                    this.v2BillingRateCardSubscriptionCollectionPaused.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionCollectionPausedEventNotification>((Stripe.Events.V2BillingRateCardSubscriptionCollectionPausedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingRateCardSubscriptionCollectionUnpaidEventNotification)
                {
                    this.v2BillingRateCardSubscriptionCollectionUnpaid.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionCollectionUnpaidEventNotification>((Stripe.Events.V2BillingRateCardSubscriptionCollectionUnpaidEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingRateCardSubscriptionServicingActivatedEventNotification)
                {
                    this.v2BillingRateCardSubscriptionServicingActivated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionServicingActivatedEventNotification>((Stripe.Events.V2BillingRateCardSubscriptionServicingActivatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingRateCardSubscriptionServicingCanceledEventNotification)
                {
                    this.v2BillingRateCardSubscriptionServicingCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionServicingCanceledEventNotification>((Stripe.Events.V2BillingRateCardSubscriptionServicingCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingRateCardSubscriptionServicingPausedEventNotification)
                {
                    this.v2BillingRateCardSubscriptionServicingPaused.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardSubscriptionServicingPausedEventNotification>((Stripe.Events.V2BillingRateCardSubscriptionServicingPausedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2BillingRateCardVersionCreatedEventNotification)
                {
                    this.v2BillingRateCardVersionCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2BillingRateCardVersionCreatedEventNotification>((Stripe.Events.V2BillingRateCardVersionCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CommerceProductCatalogImportsFailedEventNotification)
                {
                    this.v2CommerceProductCatalogImportsFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CommerceProductCatalogImportsFailedEventNotification>((Stripe.Events.V2CommerceProductCatalogImportsFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CommerceProductCatalogImportsProcessingEventNotification)
                {
                    this.v2CommerceProductCatalogImportsProcessing.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CommerceProductCatalogImportsProcessingEventNotification>((Stripe.Events.V2CommerceProductCatalogImportsProcessingEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CommerceProductCatalogImportsSucceededEventNotification)
                {
                    this.v2CommerceProductCatalogImportsSucceeded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CommerceProductCatalogImportsSucceededEventNotification>((Stripe.Events.V2CommerceProductCatalogImportsSucceededEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CommerceProductCatalogImportsSucceededWithErrorsEventNotification)
                {
                    this.v2CommerceProductCatalogImportsSucceededWithErrors.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CommerceProductCatalogImportsSucceededWithErrorsEventNotification>((Stripe.Events.V2CommerceProductCatalogImportsSucceededWithErrorsEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountClosedEventNotification)
                {
                    this.v2CoreAccountClosed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountClosedEventNotification>((Stripe.Events.V2CoreAccountClosedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountCreatedEventNotification)
                {
                    this.v2CoreAccountCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountCreatedEventNotification>((Stripe.Events.V2CoreAccountCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountUpdatedEventNotification)
                {
                    this.v2CoreAccountUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountUpdatedEventNotification>((Stripe.Events.V2CoreAccountUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingConfigurationCardCreatorCapabilityStatusUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingConfigurationCardCreatorCapabilityStatusUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationCardCreatorCapabilityStatusUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingConfigurationCardCreatorCapabilityStatusUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingConfigurationCardCreatorUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingConfigurationCardCreatorUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationCardCreatorUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingConfigurationCardCreatorUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingConfigurationCustomerCapabilityStatusUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingConfigurationCustomerCapabilityStatusUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationCustomerCapabilityStatusUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingConfigurationCustomerCapabilityStatusUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingConfigurationCustomerUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingConfigurationCustomerUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationCustomerUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingConfigurationCustomerUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingConfigurationMerchantCapabilityStatusUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingConfigurationMerchantCapabilityStatusUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationMerchantCapabilityStatusUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingConfigurationMerchantCapabilityStatusUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingConfigurationMerchantUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingConfigurationMerchantUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationMerchantUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingConfigurationMerchantUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingConfigurationMoneyManagerCapabilityStatusUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingConfigurationMoneyManagerCapabilityStatusUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationMoneyManagerCapabilityStatusUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingConfigurationMoneyManagerCapabilityStatusUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingConfigurationMoneyManagerUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingConfigurationMoneyManagerUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationMoneyManagerUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingConfigurationMoneyManagerUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingConfigurationRecipientUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingConfigurationRecipientUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationRecipientUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingConfigurationRecipientUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingDefaultsUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingDefaultsUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingDefaultsUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingDefaultsUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingFutureRequirementsUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingFutureRequirementsUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingFutureRequirementsUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingFutureRequirementsUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingIdentityUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingIdentityUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingIdentityUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingIdentityUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingRequirementsUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingRequirementsUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingRequirementsUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingRequirementsUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountLinkReturnedEventNotification)
                {
                    this.v2CoreAccountLinkReturned.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountLinkReturnedEventNotification>((Stripe.Events.V2CoreAccountLinkReturnedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountPersonCreatedEventNotification)
                {
                    this.v2CoreAccountPersonCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountPersonCreatedEventNotification>((Stripe.Events.V2CoreAccountPersonCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountPersonDeletedEventNotification)
                {
                    this.v2CoreAccountPersonDeleted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountPersonDeletedEventNotification>((Stripe.Events.V2CoreAccountPersonDeletedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountPersonUpdatedEventNotification)
                {
                    this.v2CoreAccountPersonUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountPersonUpdatedEventNotification>((Stripe.Events.V2CoreAccountPersonUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountSignalsFraudulentWebsiteReadyEventNotification)
                {
                    this.v2CoreAccountSignalsFraudulentWebsiteReady.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountSignalsFraudulentWebsiteReadyEventNotification>((Stripe.Events.V2CoreAccountSignalsFraudulentWebsiteReadyEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreApprovalRequestApprovedEventNotification)
                {
                    this.v2CoreApprovalRequestApproved.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreApprovalRequestApprovedEventNotification>((Stripe.Events.V2CoreApprovalRequestApprovedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreApprovalRequestCanceledEventNotification)
                {
                    this.v2CoreApprovalRequestCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreApprovalRequestCanceledEventNotification>((Stripe.Events.V2CoreApprovalRequestCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreApprovalRequestCreatedEventNotification)
                {
                    this.v2CoreApprovalRequestCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreApprovalRequestCreatedEventNotification>((Stripe.Events.V2CoreApprovalRequestCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreApprovalRequestExpiredEventNotification)
                {
                    this.v2CoreApprovalRequestExpired.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreApprovalRequestExpiredEventNotification>((Stripe.Events.V2CoreApprovalRequestExpiredEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreApprovalRequestFailedEventNotification)
                {
                    this.v2CoreApprovalRequestFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreApprovalRequestFailedEventNotification>((Stripe.Events.V2CoreApprovalRequestFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreApprovalRequestRejectedEventNotification)
                {
                    this.v2CoreApprovalRequestRejected.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreApprovalRequestRejectedEventNotification>((Stripe.Events.V2CoreApprovalRequestRejectedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreApprovalRequestSucceededEventNotification)
                {
                    this.v2CoreApprovalRequestSucceeded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreApprovalRequestSucceededEventNotification>((Stripe.Events.V2CoreApprovalRequestSucceededEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreBatchJobBatchFailedEventNotification)
                {
                    this.v2CoreBatchJobBatchFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobBatchFailedEventNotification>((Stripe.Events.V2CoreBatchJobBatchFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreBatchJobCanceledEventNotification)
                {
                    this.v2CoreBatchJobCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobCanceledEventNotification>((Stripe.Events.V2CoreBatchJobCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreBatchJobCompletedEventNotification)
                {
                    this.v2CoreBatchJobCompleted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobCompletedEventNotification>((Stripe.Events.V2CoreBatchJobCompletedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreBatchJobCreatedEventNotification)
                {
                    this.v2CoreBatchJobCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobCreatedEventNotification>((Stripe.Events.V2CoreBatchJobCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreBatchJobReadyForUploadEventNotification)
                {
                    this.v2CoreBatchJobReadyForUpload.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobReadyForUploadEventNotification>((Stripe.Events.V2CoreBatchJobReadyForUploadEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreBatchJobTimeoutEventNotification)
                {
                    this.v2CoreBatchJobTimeout.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobTimeoutEventNotification>((Stripe.Events.V2CoreBatchJobTimeoutEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreBatchJobUpdatedEventNotification)
                {
                    this.v2CoreBatchJobUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobUpdatedEventNotification>((Stripe.Events.V2CoreBatchJobUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreBatchJobUploadTimeoutEventNotification)
                {
                    this.v2CoreBatchJobUploadTimeout.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobUploadTimeoutEventNotification>((Stripe.Events.V2CoreBatchJobUploadTimeoutEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreBatchJobValidatingEventNotification)
                {
                    this.v2CoreBatchJobValidating.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobValidatingEventNotification>((Stripe.Events.V2CoreBatchJobValidatingEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreBatchJobValidationFailedEventNotification)
                {
                    this.v2CoreBatchJobValidationFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobValidationFailedEventNotification>((Stripe.Events.V2CoreBatchJobValidationFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreClaimableSandboxClaimedEventNotification)
                {
                    this.v2CoreClaimableSandboxClaimed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreClaimableSandboxClaimedEventNotification>((Stripe.Events.V2CoreClaimableSandboxClaimedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreClaimableSandboxCreatedEventNotification)
                {
                    this.v2CoreClaimableSandboxCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreClaimableSandboxCreatedEventNotification>((Stripe.Events.V2CoreClaimableSandboxCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreClaimableSandboxExpiredEventNotification)
                {
                    this.v2CoreClaimableSandboxExpired.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreClaimableSandboxExpiredEventNotification>((Stripe.Events.V2CoreClaimableSandboxExpiredEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreClaimableSandboxExpiringEventNotification)
                {
                    this.v2CoreClaimableSandboxExpiring.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreClaimableSandboxExpiringEventNotification>((Stripe.Events.V2CoreClaimableSandboxExpiringEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreClaimableSandboxUpdatedEventNotification)
                {
                    this.v2CoreClaimableSandboxUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreClaimableSandboxUpdatedEventNotification>((Stripe.Events.V2CoreClaimableSandboxUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreEventDestinationPingEventNotification)
                {
                    this.v2CoreEventDestinationPing.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreEventDestinationPingEventNotification>((Stripe.Events.V2CoreEventDestinationPingEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthApiErrorFiringEventNotification)
                {
                    this.v2CoreHealthApiErrorFiring.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthApiErrorFiringEventNotification>((Stripe.Events.V2CoreHealthApiErrorFiringEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthApiErrorResolvedEventNotification)
                {
                    this.v2CoreHealthApiErrorResolved.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthApiErrorResolvedEventNotification>((Stripe.Events.V2CoreHealthApiErrorResolvedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthApiLatencyFiringEventNotification)
                {
                    this.v2CoreHealthApiLatencyFiring.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthApiLatencyFiringEventNotification>((Stripe.Events.V2CoreHealthApiLatencyFiringEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthApiLatencyResolvedEventNotification)
                {
                    this.v2CoreHealthApiLatencyResolved.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthApiLatencyResolvedEventNotification>((Stripe.Events.V2CoreHealthApiLatencyResolvedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthAuthorizationRateDropFiringEventNotification)
                {
                    this.v2CoreHealthAuthorizationRateDropFiring.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthAuthorizationRateDropFiringEventNotification>((Stripe.Events.V2CoreHealthAuthorizationRateDropFiringEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthAuthorizationRateDropResolvedEventNotification)
                {
                    this.v2CoreHealthAuthorizationRateDropResolved.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthAuthorizationRateDropResolvedEventNotification>((Stripe.Events.V2CoreHealthAuthorizationRateDropResolvedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthElementsErrorFiringEventNotification)
                {
                    this.v2CoreHealthElementsErrorFiring.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthElementsErrorFiringEventNotification>((Stripe.Events.V2CoreHealthElementsErrorFiringEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthElementsErrorResolvedEventNotification)
                {
                    this.v2CoreHealthElementsErrorResolved.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthElementsErrorResolvedEventNotification>((Stripe.Events.V2CoreHealthElementsErrorResolvedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthEventGenerationFailureResolvedEventNotification)
                {
                    this.v2CoreHealthEventGenerationFailureResolved.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthEventGenerationFailureResolvedEventNotification>((Stripe.Events.V2CoreHealthEventGenerationFailureResolvedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthFraudRateIncreasedEventNotification)
                {
                    this.v2CoreHealthFraudRateIncreased.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthFraudRateIncreasedEventNotification>((Stripe.Events.V2CoreHealthFraudRateIncreasedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthInvoiceCountDroppedFiringEventNotification)
                {
                    this.v2CoreHealthInvoiceCountDroppedFiring.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthInvoiceCountDroppedFiringEventNotification>((Stripe.Events.V2CoreHealthInvoiceCountDroppedFiringEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthInvoiceCountDroppedResolvedEventNotification)
                {
                    this.v2CoreHealthInvoiceCountDroppedResolved.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthInvoiceCountDroppedResolvedEventNotification>((Stripe.Events.V2CoreHealthInvoiceCountDroppedResolvedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthIssuingAuthorizationRequestErrorsFiringEventNotification)
                {
                    this.v2CoreHealthIssuingAuthorizationRequestErrorsFiring.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthIssuingAuthorizationRequestErrorsFiringEventNotification>((Stripe.Events.V2CoreHealthIssuingAuthorizationRequestErrorsFiringEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthIssuingAuthorizationRequestErrorsResolvedEventNotification)
                {
                    this.v2CoreHealthIssuingAuthorizationRequestErrorsResolved.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthIssuingAuthorizationRequestErrorsResolvedEventNotification>((Stripe.Events.V2CoreHealthIssuingAuthorizationRequestErrorsResolvedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthIssuingAuthorizationRequestTimeoutFiringEventNotification)
                {
                    this.v2CoreHealthIssuingAuthorizationRequestTimeoutFiring.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthIssuingAuthorizationRequestTimeoutFiringEventNotification>((Stripe.Events.V2CoreHealthIssuingAuthorizationRequestTimeoutFiringEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthIssuingAuthorizationRequestTimeoutResolvedEventNotification)
                {
                    this.v2CoreHealthIssuingAuthorizationRequestTimeoutResolved.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthIssuingAuthorizationRequestTimeoutResolvedEventNotification>((Stripe.Events.V2CoreHealthIssuingAuthorizationRequestTimeoutResolvedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthMeterEventSummariesDelayedFiringEventNotification)
                {
                    this.v2CoreHealthMeterEventSummariesDelayedFiring.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthMeterEventSummariesDelayedFiringEventNotification>((Stripe.Events.V2CoreHealthMeterEventSummariesDelayedFiringEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthMeterEventSummariesDelayedResolvedEventNotification)
                {
                    this.v2CoreHealthMeterEventSummariesDelayedResolved.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthMeterEventSummariesDelayedResolvedEventNotification>((Stripe.Events.V2CoreHealthMeterEventSummariesDelayedResolvedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthPaymentMethodErrorFiringEventNotification)
                {
                    this.v2CoreHealthPaymentMethodErrorFiring.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthPaymentMethodErrorFiringEventNotification>((Stripe.Events.V2CoreHealthPaymentMethodErrorFiringEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthPaymentMethodErrorResolvedEventNotification)
                {
                    this.v2CoreHealthPaymentMethodErrorResolved.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthPaymentMethodErrorResolvedEventNotification>((Stripe.Events.V2CoreHealthPaymentMethodErrorResolvedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthSepaDebitDelayedFiringEventNotification)
                {
                    this.v2CoreHealthSepaDebitDelayedFiring.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthSepaDebitDelayedFiringEventNotification>((Stripe.Events.V2CoreHealthSepaDebitDelayedFiringEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthSepaDebitDelayedResolvedEventNotification)
                {
                    this.v2CoreHealthSepaDebitDelayedResolved.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthSepaDebitDelayedResolvedEventNotification>((Stripe.Events.V2CoreHealthSepaDebitDelayedResolvedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthTrafficVolumeDropFiringEventNotification)
                {
                    this.v2CoreHealthTrafficVolumeDropFiring.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthTrafficVolumeDropFiringEventNotification>((Stripe.Events.V2CoreHealthTrafficVolumeDropFiringEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthTrafficVolumeDropResolvedEventNotification)
                {
                    this.v2CoreHealthTrafficVolumeDropResolved.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthTrafficVolumeDropResolvedEventNotification>((Stripe.Events.V2CoreHealthTrafficVolumeDropResolvedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthWebhookLatencyFiringEventNotification)
                {
                    this.v2CoreHealthWebhookLatencyFiring.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthWebhookLatencyFiringEventNotification>((Stripe.Events.V2CoreHealthWebhookLatencyFiringEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthWebhookLatencyResolvedEventNotification)
                {
                    this.v2CoreHealthWebhookLatencyResolved.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthWebhookLatencyResolvedEventNotification>((Stripe.Events.V2CoreHealthWebhookLatencyResolvedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2DataReportingQueryRunCreatedEventNotification)
                {
                    this.v2DataReportingQueryRunCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2DataReportingQueryRunCreatedEventNotification>((Stripe.Events.V2DataReportingQueryRunCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2DataReportingQueryRunFailedEventNotification)
                {
                    this.v2DataReportingQueryRunFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2DataReportingQueryRunFailedEventNotification>((Stripe.Events.V2DataReportingQueryRunFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2DataReportingQueryRunSucceededEventNotification)
                {
                    this.v2DataReportingQueryRunSucceeded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2DataReportingQueryRunSucceededEventNotification>((Stripe.Events.V2DataReportingQueryRunSucceededEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2DataReportingQueryRunUpdatedEventNotification)
                {
                    this.v2DataReportingQueryRunUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2DataReportingQueryRunUpdatedEventNotification>((Stripe.Events.V2DataReportingQueryRunUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2ExtendExtensionRunFailedEventNotification)
                {
                    this.v2ExtendExtensionRunFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2ExtendExtensionRunFailedEventNotification>((Stripe.Events.V2ExtendExtensionRunFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2ExtendWorkflowRunFailedEventNotification)
                {
                    this.v2ExtendWorkflowRunFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2ExtendWorkflowRunFailedEventNotification>((Stripe.Events.V2ExtendWorkflowRunFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2ExtendWorkflowRunStartedEventNotification)
                {
                    this.v2ExtendWorkflowRunStarted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2ExtendWorkflowRunStartedEventNotification>((Stripe.Events.V2ExtendWorkflowRunStartedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2ExtendWorkflowRunSucceededEventNotification)
                {
                    this.v2ExtendWorkflowRunSucceeded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2ExtendWorkflowRunSucceededEventNotification>((Stripe.Events.V2ExtendWorkflowRunSucceededEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2IamApiKeyCreatedEventNotification)
                {
                    this.v2IamApiKeyCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2IamApiKeyCreatedEventNotification>((Stripe.Events.V2IamApiKeyCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2IamApiKeyDefaultSecretRevealedEventNotification)
                {
                    this.v2IamApiKeyDefaultSecretRevealed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2IamApiKeyDefaultSecretRevealedEventNotification>((Stripe.Events.V2IamApiKeyDefaultSecretRevealedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2IamApiKeyExpiredEventNotification)
                {
                    this.v2IamApiKeyExpired.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2IamApiKeyExpiredEventNotification>((Stripe.Events.V2IamApiKeyExpiredEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2IamApiKeyPermissionsUpdatedEventNotification)
                {
                    this.v2IamApiKeyPermissionsUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2IamApiKeyPermissionsUpdatedEventNotification>((Stripe.Events.V2IamApiKeyPermissionsUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2IamApiKeyRotatedEventNotification)
                {
                    this.v2IamApiKeyRotated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2IamApiKeyRotatedEventNotification>((Stripe.Events.V2IamApiKeyRotatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2IamApiKeyUpdatedEventNotification)
                {
                    this.v2IamApiKeyUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2IamApiKeyUpdatedEventNotification>((Stripe.Events.V2IamApiKeyUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2IamStripeAccessGrantApprovedEventNotification)
                {
                    this.v2IamStripeAccessGrantApproved.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2IamStripeAccessGrantApprovedEventNotification>((Stripe.Events.V2IamStripeAccessGrantApprovedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2IamStripeAccessGrantCanceledEventNotification)
                {
                    this.v2IamStripeAccessGrantCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2IamStripeAccessGrantCanceledEventNotification>((Stripe.Events.V2IamStripeAccessGrantCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2IamStripeAccessGrantDeniedEventNotification)
                {
                    this.v2IamStripeAccessGrantDenied.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2IamStripeAccessGrantDeniedEventNotification>((Stripe.Events.V2IamStripeAccessGrantDeniedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2IamStripeAccessGrantRemovedEventNotification)
                {
                    this.v2IamStripeAccessGrantRemoved.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2IamStripeAccessGrantRemovedEventNotification>((Stripe.Events.V2IamStripeAccessGrantRemovedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2IamStripeAccessGrantRequestedEventNotification)
                {
                    this.v2IamStripeAccessGrantRequested.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2IamStripeAccessGrantRequestedEventNotification>((Stripe.Events.V2IamStripeAccessGrantRequestedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2IamStripeAccessGrantUpdatedEventNotification)
                {
                    this.v2IamStripeAccessGrantUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2IamStripeAccessGrantUpdatedEventNotification>((Stripe.Events.V2IamStripeAccessGrantUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementAdjustmentCreatedEventNotification)
                {
                    this.v2MoneyManagementAdjustmentCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementAdjustmentCreatedEventNotification>((Stripe.Events.V2MoneyManagementAdjustmentCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementDebitDisputeFailedEventNotification)
                {
                    this.v2MoneyManagementDebitDisputeFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementDebitDisputeFailedEventNotification>((Stripe.Events.V2MoneyManagementDebitDisputeFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementDebitDisputeSubmittedEventNotification)
                {
                    this.v2MoneyManagementDebitDisputeSubmitted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementDebitDisputeSubmittedEventNotification>((Stripe.Events.V2MoneyManagementDebitDisputeSubmittedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementDebitDisputeSucceededEventNotification)
                {
                    this.v2MoneyManagementDebitDisputeSucceeded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementDebitDisputeSucceededEventNotification>((Stripe.Events.V2MoneyManagementDebitDisputeSucceededEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementFinancialAccountCreatedEventNotification)
                {
                    this.v2MoneyManagementFinancialAccountCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAccountCreatedEventNotification>((Stripe.Events.V2MoneyManagementFinancialAccountCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementFinancialAccountUpdatedEventNotification)
                {
                    this.v2MoneyManagementFinancialAccountUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAccountUpdatedEventNotification>((Stripe.Events.V2MoneyManagementFinancialAccountUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementFinancialAccountStatementCreatedEventNotification)
                {
                    this.v2MoneyManagementFinancialAccountStatementCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAccountStatementCreatedEventNotification>((Stripe.Events.V2MoneyManagementFinancialAccountStatementCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementFinancialAccountStatementRestatedEventNotification)
                {
                    this.v2MoneyManagementFinancialAccountStatementRestated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAccountStatementRestatedEventNotification>((Stripe.Events.V2MoneyManagementFinancialAccountStatementRestatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementFinancialAddressActivatedEventNotification)
                {
                    this.v2MoneyManagementFinancialAddressActivated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAddressActivatedEventNotification>((Stripe.Events.V2MoneyManagementFinancialAddressActivatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementFinancialAddressFailedEventNotification)
                {
                    this.v2MoneyManagementFinancialAddressFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAddressFailedEventNotification>((Stripe.Events.V2MoneyManagementFinancialAddressFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementInboundTransferAvailableEventNotification)
                {
                    this.v2MoneyManagementInboundTransferAvailable.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferAvailableEventNotification>((Stripe.Events.V2MoneyManagementInboundTransferAvailableEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementInboundTransferBankDebitFailedEventNotification)
                {
                    this.v2MoneyManagementInboundTransferBankDebitFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitFailedEventNotification>((Stripe.Events.V2MoneyManagementInboundTransferBankDebitFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementInboundTransferBankDebitProcessingEventNotification)
                {
                    this.v2MoneyManagementInboundTransferBankDebitProcessing.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitProcessingEventNotification>((Stripe.Events.V2MoneyManagementInboundTransferBankDebitProcessingEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementInboundTransferBankDebitQueuedEventNotification)
                {
                    this.v2MoneyManagementInboundTransferBankDebitQueued.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitQueuedEventNotification>((Stripe.Events.V2MoneyManagementInboundTransferBankDebitQueuedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementInboundTransferBankDebitReturnedEventNotification)
                {
                    this.v2MoneyManagementInboundTransferBankDebitReturned.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitReturnedEventNotification>((Stripe.Events.V2MoneyManagementInboundTransferBankDebitReturnedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementInboundTransferBankDebitSucceededEventNotification)
                {
                    this.v2MoneyManagementInboundTransferBankDebitSucceeded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitSucceededEventNotification>((Stripe.Events.V2MoneyManagementInboundTransferBankDebitSucceededEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundPaymentCanceledEventNotification)
                {
                    this.v2MoneyManagementOutboundPaymentCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentCanceledEventNotification>((Stripe.Events.V2MoneyManagementOutboundPaymentCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundPaymentCreatedEventNotification)
                {
                    this.v2MoneyManagementOutboundPaymentCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentCreatedEventNotification>((Stripe.Events.V2MoneyManagementOutboundPaymentCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundPaymentFailedEventNotification)
                {
                    this.v2MoneyManagementOutboundPaymentFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentFailedEventNotification>((Stripe.Events.V2MoneyManagementOutboundPaymentFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundPaymentPostedEventNotification)
                {
                    this.v2MoneyManagementOutboundPaymentPosted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentPostedEventNotification>((Stripe.Events.V2MoneyManagementOutboundPaymentPostedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundPaymentReturnedEventNotification)
                {
                    this.v2MoneyManagementOutboundPaymentReturned.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentReturnedEventNotification>((Stripe.Events.V2MoneyManagementOutboundPaymentReturnedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundPaymentUnderReviewEventNotification)
                {
                    this.v2MoneyManagementOutboundPaymentUnderReview.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentUnderReviewEventNotification>((Stripe.Events.V2MoneyManagementOutboundPaymentUnderReviewEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundPaymentUpdatedEventNotification)
                {
                    this.v2MoneyManagementOutboundPaymentUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentUpdatedEventNotification>((Stripe.Events.V2MoneyManagementOutboundPaymentUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundTransferCanceledEventNotification)
                {
                    this.v2MoneyManagementOutboundTransferCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferCanceledEventNotification>((Stripe.Events.V2MoneyManagementOutboundTransferCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundTransferCreatedEventNotification)
                {
                    this.v2MoneyManagementOutboundTransferCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferCreatedEventNotification>((Stripe.Events.V2MoneyManagementOutboundTransferCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundTransferFailedEventNotification)
                {
                    this.v2MoneyManagementOutboundTransferFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferFailedEventNotification>((Stripe.Events.V2MoneyManagementOutboundTransferFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundTransferPostedEventNotification)
                {
                    this.v2MoneyManagementOutboundTransferPosted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferPostedEventNotification>((Stripe.Events.V2MoneyManagementOutboundTransferPostedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundTransferReturnedEventNotification)
                {
                    this.v2MoneyManagementOutboundTransferReturned.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferReturnedEventNotification>((Stripe.Events.V2MoneyManagementOutboundTransferReturnedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundTransferUnderReviewEventNotification)
                {
                    this.v2MoneyManagementOutboundTransferUnderReview.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferUnderReviewEventNotification>((Stripe.Events.V2MoneyManagementOutboundTransferUnderReviewEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundTransferUpdatedEventNotification)
                {
                    this.v2MoneyManagementOutboundTransferUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferUpdatedEventNotification>((Stripe.Events.V2MoneyManagementOutboundTransferUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementPayoutMethodCreatedEventNotification)
                {
                    this.v2MoneyManagementPayoutMethodCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementPayoutMethodCreatedEventNotification>((Stripe.Events.V2MoneyManagementPayoutMethodCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementPayoutMethodUpdatedEventNotification)
                {
                    this.v2MoneyManagementPayoutMethodUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementPayoutMethodUpdatedEventNotification>((Stripe.Events.V2MoneyManagementPayoutMethodUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementReceivedCreditAvailableEventNotification)
                {
                    this.v2MoneyManagementReceivedCreditAvailable.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedCreditAvailableEventNotification>((Stripe.Events.V2MoneyManagementReceivedCreditAvailableEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementReceivedCreditFailedEventNotification)
                {
                    this.v2MoneyManagementReceivedCreditFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedCreditFailedEventNotification>((Stripe.Events.V2MoneyManagementReceivedCreditFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementReceivedCreditReturnedEventNotification)
                {
                    this.v2MoneyManagementReceivedCreditReturned.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedCreditReturnedEventNotification>((Stripe.Events.V2MoneyManagementReceivedCreditReturnedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementReceivedCreditSucceededEventNotification)
                {
                    this.v2MoneyManagementReceivedCreditSucceeded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedCreditSucceededEventNotification>((Stripe.Events.V2MoneyManagementReceivedCreditSucceededEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementReceivedDebitCanceledEventNotification)
                {
                    this.v2MoneyManagementReceivedDebitCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitCanceledEventNotification>((Stripe.Events.V2MoneyManagementReceivedDebitCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementReceivedDebitFailedEventNotification)
                {
                    this.v2MoneyManagementReceivedDebitFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitFailedEventNotification>((Stripe.Events.V2MoneyManagementReceivedDebitFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementReceivedDebitPendingEventNotification)
                {
                    this.v2MoneyManagementReceivedDebitPending.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitPendingEventNotification>((Stripe.Events.V2MoneyManagementReceivedDebitPendingEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementReceivedDebitSucceededEventNotification)
                {
                    this.v2MoneyManagementReceivedDebitSucceeded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitSucceededEventNotification>((Stripe.Events.V2MoneyManagementReceivedDebitSucceededEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementReceivedDebitUpdatedEventNotification)
                {
                    this.v2MoneyManagementReceivedDebitUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitUpdatedEventNotification>((Stripe.Events.V2MoneyManagementReceivedDebitUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementRecipientVerificationCreatedEventNotification)
                {
                    this.v2MoneyManagementRecipientVerificationCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementRecipientVerificationCreatedEventNotification>((Stripe.Events.V2MoneyManagementRecipientVerificationCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementRecipientVerificationUpdatedEventNotification)
                {
                    this.v2MoneyManagementRecipientVerificationUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementRecipientVerificationUpdatedEventNotification>((Stripe.Events.V2MoneyManagementRecipientVerificationUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementTransactionCreatedEventNotification)
                {
                    this.v2MoneyManagementTransactionCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementTransactionCreatedEventNotification>((Stripe.Events.V2MoneyManagementTransactionCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementTransactionUpdatedEventNotification)
                {
                    this.v2MoneyManagementTransactionUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementTransactionUpdatedEventNotification>((Stripe.Events.V2MoneyManagementTransactionUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2OrchestratedCommerceAgreementConfirmedEventNotification)
                {
                    this.v2OrchestratedCommerceAgreementConfirmed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2OrchestratedCommerceAgreementConfirmedEventNotification>((Stripe.Events.V2OrchestratedCommerceAgreementConfirmedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2OrchestratedCommerceAgreementCreatedEventNotification)
                {
                    this.v2OrchestratedCommerceAgreementCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2OrchestratedCommerceAgreementCreatedEventNotification>((Stripe.Events.V2OrchestratedCommerceAgreementCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2OrchestratedCommerceAgreementPartiallyConfirmedEventNotification)
                {
                    this.v2OrchestratedCommerceAgreementPartiallyConfirmed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2OrchestratedCommerceAgreementPartiallyConfirmedEventNotification>((Stripe.Events.V2OrchestratedCommerceAgreementPartiallyConfirmedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2OrchestratedCommerceAgreementTerminatedEventNotification)
                {
                    this.v2OrchestratedCommerceAgreementTerminated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2OrchestratedCommerceAgreementTerminatedEventNotification>((Stripe.Events.V2OrchestratedCommerceAgreementTerminatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsOffSessionPaymentAttemptFailedEventNotification)
                {
                    this.v2PaymentsOffSessionPaymentAttemptFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentAttemptFailedEventNotification>((Stripe.Events.V2PaymentsOffSessionPaymentAttemptFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsOffSessionPaymentAttemptStartedEventNotification)
                {
                    this.v2PaymentsOffSessionPaymentAttemptStarted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentAttemptStartedEventNotification>((Stripe.Events.V2PaymentsOffSessionPaymentAttemptStartedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsOffSessionPaymentAuthorizationAttemptFailedEventNotification)
                {
                    this.v2PaymentsOffSessionPaymentAuthorizationAttemptFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentAuthorizationAttemptFailedEventNotification>((Stripe.Events.V2PaymentsOffSessionPaymentAuthorizationAttemptFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsOffSessionPaymentAuthorizationAttemptStartedEventNotification)
                {
                    this.v2PaymentsOffSessionPaymentAuthorizationAttemptStarted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentAuthorizationAttemptStartedEventNotification>((Stripe.Events.V2PaymentsOffSessionPaymentAuthorizationAttemptStartedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsOffSessionPaymentCanceledEventNotification)
                {
                    this.v2PaymentsOffSessionPaymentCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentCanceledEventNotification>((Stripe.Events.V2PaymentsOffSessionPaymentCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsOffSessionPaymentCreatedEventNotification)
                {
                    this.v2PaymentsOffSessionPaymentCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentCreatedEventNotification>((Stripe.Events.V2PaymentsOffSessionPaymentCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsOffSessionPaymentFailedEventNotification)
                {
                    this.v2PaymentsOffSessionPaymentFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentFailedEventNotification>((Stripe.Events.V2PaymentsOffSessionPaymentFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsOffSessionPaymentPausedEventNotification)
                {
                    this.v2PaymentsOffSessionPaymentPaused.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentPausedEventNotification>((Stripe.Events.V2PaymentsOffSessionPaymentPausedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsOffSessionPaymentRequiresCaptureEventNotification)
                {
                    this.v2PaymentsOffSessionPaymentRequiresCapture.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentRequiresCaptureEventNotification>((Stripe.Events.V2PaymentsOffSessionPaymentRequiresCaptureEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsOffSessionPaymentResumedEventNotification)
                {
                    this.v2PaymentsOffSessionPaymentResumed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentResumedEventNotification>((Stripe.Events.V2PaymentsOffSessionPaymentResumedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsOffSessionPaymentSucceededEventNotification)
                {
                    this.v2PaymentsOffSessionPaymentSucceeded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsOffSessionPaymentSucceededEventNotification>((Stripe.Events.V2PaymentsOffSessionPaymentSucceededEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsSettlementAllocationIntentCanceledEventNotification)
                {
                    this.v2PaymentsSettlementAllocationIntentCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentCanceledEventNotification>((Stripe.Events.V2PaymentsSettlementAllocationIntentCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsSettlementAllocationIntentCreatedEventNotification)
                {
                    this.v2PaymentsSettlementAllocationIntentCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentCreatedEventNotification>((Stripe.Events.V2PaymentsSettlementAllocationIntentCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsSettlementAllocationIntentErroredEventNotification)
                {
                    this.v2PaymentsSettlementAllocationIntentErrored.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentErroredEventNotification>((Stripe.Events.V2PaymentsSettlementAllocationIntentErroredEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsSettlementAllocationIntentFundsNotReceivedEventNotification)
                {
                    this.v2PaymentsSettlementAllocationIntentFundsNotReceived.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentFundsNotReceivedEventNotification>((Stripe.Events.V2PaymentsSettlementAllocationIntentFundsNotReceivedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsSettlementAllocationIntentMatchedEventNotification)
                {
                    this.v2PaymentsSettlementAllocationIntentMatched.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentMatchedEventNotification>((Stripe.Events.V2PaymentsSettlementAllocationIntentMatchedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsSettlementAllocationIntentNotFoundEventNotification)
                {
                    this.v2PaymentsSettlementAllocationIntentNotFound.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentNotFoundEventNotification>((Stripe.Events.V2PaymentsSettlementAllocationIntentNotFoundEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsSettlementAllocationIntentSettledEventNotification)
                {
                    this.v2PaymentsSettlementAllocationIntentSettled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentSettledEventNotification>((Stripe.Events.V2PaymentsSettlementAllocationIntentSettledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsSettlementAllocationIntentSubmittedEventNotification)
                {
                    this.v2PaymentsSettlementAllocationIntentSubmitted.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentSubmittedEventNotification>((Stripe.Events.V2PaymentsSettlementAllocationIntentSubmittedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsSettlementAllocationIntentSplitCanceledEventNotification)
                {
                    this.v2PaymentsSettlementAllocationIntentSplitCanceled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentSplitCanceledEventNotification>((Stripe.Events.V2PaymentsSettlementAllocationIntentSplitCanceledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsSettlementAllocationIntentSplitCreatedEventNotification)
                {
                    this.v2PaymentsSettlementAllocationIntentSplitCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentSplitCreatedEventNotification>((Stripe.Events.V2PaymentsSettlementAllocationIntentSplitCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2PaymentsSettlementAllocationIntentSplitSettledEventNotification)
                {
                    this.v2PaymentsSettlementAllocationIntentSplitSettled.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2PaymentsSettlementAllocationIntentSplitSettledEventNotification>((Stripe.Events.V2PaymentsSettlementAllocationIntentSplitSettledEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2ReportingReportRunCreatedEventNotification)
                {
                    this.v2ReportingReportRunCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2ReportingReportRunCreatedEventNotification>((Stripe.Events.V2ReportingReportRunCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2ReportingReportRunFailedEventNotification)
                {
                    this.v2ReportingReportRunFailed.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2ReportingReportRunFailedEventNotification>((Stripe.Events.V2ReportingReportRunFailedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2ReportingReportRunSucceededEventNotification)
                {
                    this.v2ReportingReportRunSucceeded.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2ReportingReportRunSucceededEventNotification>((Stripe.Events.V2ReportingReportRunSucceededEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2ReportingReportRunUpdatedEventNotification)
                {
                    this.v2ReportingReportRunUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2ReportingReportRunUpdatedEventNotification>((Stripe.Events.V2ReportingReportRunUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2SignalsAccountSignalFraudulentMerchantReadyEventNotification)
                {
                    this.v2SignalsAccountSignalFraudulentMerchantReady.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2SignalsAccountSignalFraudulentMerchantReadyEventNotification>((Stripe.Events.V2SignalsAccountSignalFraudulentMerchantReadyEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2SignalsAccountSignalMerchantDelinquencyReadyEventNotification)
                {
                    this.v2SignalsAccountSignalMerchantDelinquencyReady.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2SignalsAccountSignalMerchantDelinquencyReadyEventNotification>((Stripe.Events.V2SignalsAccountSignalMerchantDelinquencyReadyEventNotification)eventNotification, client));
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
                this.FallbackCallback.Invoke(
                    this,
                    new StripeUnhandledEventNotificationEventArgs(eventNotification, client, new UnhandledNotificationDetails(!(eventNotification is UnknownEventNotification))));
            }
        }
    }
}
