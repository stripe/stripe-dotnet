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

        // A private EventHandler for each EventNotification. We'll route notifications to the correct handler.
        // private-event-handlers: The beginning of the section generated from our OpenAPI spec
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterErrorReportTriggeredEventNotification>> v1BillingMeterErrorReportTriggeredEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterNoMeterFoundEventNotification>> v1BillingMeterNoMeterFoundEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountClosedEventNotification>> v2CoreAccountClosedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountCreatedEventNotification>> v2CoreAccountCreatedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountUpdatedEventNotification>> v2CoreAccountUpdatedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationCustomerCapabilityStatusUpdatedEventNotification>> v2CoreAccountIncludingConfigurationCustomerCapabilityStatusUpdatedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationCustomerUpdatedEventNotification>> v2CoreAccountIncludingConfigurationCustomerUpdatedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationMerchantCapabilityStatusUpdatedEventNotification>> v2CoreAccountIncludingConfigurationMerchantCapabilityStatusUpdatedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationMerchantUpdatedEventNotification>> v2CoreAccountIncludingConfigurationMerchantUpdatedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdatedEventNotification>> v2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdatedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationRecipientUpdatedEventNotification>> v2CoreAccountIncludingConfigurationRecipientUpdatedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationStorerCapabilityStatusUpdatedEventNotification>> v2CoreAccountIncludingConfigurationStorerCapabilityStatusUpdatedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationStorerUpdatedEventNotification>> v2CoreAccountIncludingConfigurationStorerUpdatedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingDefaultsUpdatedEventNotification>> v2CoreAccountIncludingDefaultsUpdatedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingIdentityUpdatedEventNotification>> v2CoreAccountIncludingIdentityUpdatedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingRequirementsUpdatedEventNotification>> v2CoreAccountIncludingRequirementsUpdatedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountLinkReturnedEventNotification>> v2CoreAccountLinkReturnedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountPersonCreatedEventNotification>> v2CoreAccountPersonCreatedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountPersonDeletedEventNotification>> v2CoreAccountPersonDeletedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountPersonUpdatedEventNotification>> v2CoreAccountPersonUpdatedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreEventDestinationPingEventNotification>> v2CoreEventDestinationPingEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementAdjustmentCreatedEventNotification>> v2MoneyManagementAdjustmentCreatedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAccountCreatedEventNotification>> v2MoneyManagementFinancialAccountCreatedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAccountUpdatedEventNotification>> v2MoneyManagementFinancialAccountUpdatedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAddressActivatedEventNotification>> v2MoneyManagementFinancialAddressActivatedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAddressFailedEventNotification>> v2MoneyManagementFinancialAddressFailedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferAvailableEventNotification>> v2MoneyManagementInboundTransferAvailableEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitFailedEventNotification>> v2MoneyManagementInboundTransferBankDebitFailedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitProcessingEventNotification>> v2MoneyManagementInboundTransferBankDebitProcessingEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitQueuedEventNotification>> v2MoneyManagementInboundTransferBankDebitQueuedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitReturnedEventNotification>> v2MoneyManagementInboundTransferBankDebitReturnedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitSucceededEventNotification>> v2MoneyManagementInboundTransferBankDebitSucceededEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentCanceledEventNotification>> v2MoneyManagementOutboundPaymentCanceledEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentCreatedEventNotification>> v2MoneyManagementOutboundPaymentCreatedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentFailedEventNotification>> v2MoneyManagementOutboundPaymentFailedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentPostedEventNotification>> v2MoneyManagementOutboundPaymentPostedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentReturnedEventNotification>> v2MoneyManagementOutboundPaymentReturnedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentUpdatedEventNotification>> v2MoneyManagementOutboundPaymentUpdatedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferCanceledEventNotification>> v2MoneyManagementOutboundTransferCanceledEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferCreatedEventNotification>> v2MoneyManagementOutboundTransferCreatedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferFailedEventNotification>> v2MoneyManagementOutboundTransferFailedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferPostedEventNotification>> v2MoneyManagementOutboundTransferPostedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferReturnedEventNotification>> v2MoneyManagementOutboundTransferReturnedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferUpdatedEventNotification>> v2MoneyManagementOutboundTransferUpdatedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementPayoutMethodUpdatedEventNotification>> v2MoneyManagementPayoutMethodUpdatedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedCreditAvailableEventNotification>> v2MoneyManagementReceivedCreditAvailableEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedCreditFailedEventNotification>> v2MoneyManagementReceivedCreditFailedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedCreditReturnedEventNotification>> v2MoneyManagementReceivedCreditReturnedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedCreditSucceededEventNotification>> v2MoneyManagementReceivedCreditSucceededEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitCanceledEventNotification>> v2MoneyManagementReceivedDebitCanceledEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitFailedEventNotification>> v2MoneyManagementReceivedDebitFailedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitPendingEventNotification>> v2MoneyManagementReceivedDebitPendingEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitSucceededEventNotification>> v2MoneyManagementReceivedDebitSucceededEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitUpdatedEventNotification>> v2MoneyManagementReceivedDebitUpdatedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementTransactionCreatedEventNotification>> v2MoneyManagementTransactionCreatedEventNotification;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementTransactionUpdatedEventNotification>> v2MoneyManagementTransactionUpdatedEventNotification;

        // private-event-handlers: The end of the section generated from our OpenAPI spec

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeEventRouter"/> class.
        /// </summary>
        /// <param name="client">The StripeClient instance to use for parsing and API requests.</param>
        /// <param name="webhookSecret">The webhook secret used for signature verification.</param>
        /// <param name="unhandledEventHandler">TODO: ADD UNHANDLED DETAILS.</param>
        public StripeEventRouter(StripeClient client, string webhookSecret, EventHandler<StripeUnhandledEventNotificationEventArgs> unhandledEventHandler)
        {
            this.client = client ?? throw new ArgumentNullException(nameof(client));
            this.webhookSecret = webhookSecret ?? throw new ArgumentNullException(nameof(webhookSecret));
            this.UnhandledEventHandler += unhandledEventHandler;
        }

        private event EventHandler<StripeUnhandledEventNotificationEventArgs> UnhandledEventHandler;

        // public facing EventHandler
        // public-event-handlers: The beginning of the section generated from our OpenAPI spec
        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterErrorReportTriggeredEventNotification>> V1BillingMeterErrorReportTriggeredEventNotification
        {
            add { this.AddEventHandler(ref this.v1BillingMeterErrorReportTriggeredEventNotification, value, "V1BillingMeterErrorReportTriggeredEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterNoMeterFoundEventNotification>> V1BillingMeterNoMeterFoundEventNotification
        {
            add { this.AddEventHandler(ref this.v1BillingMeterNoMeterFoundEventNotification, value, "V1BillingMeterNoMeterFoundEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountClosedEventNotification>> V2CoreAccountClosedEventNotification
        {
            add { this.AddEventHandler(ref this.v2CoreAccountClosedEventNotification, value, "V2CoreAccountClosedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountCreatedEventNotification>> V2CoreAccountCreatedEventNotification
        {
            add { this.AddEventHandler(ref this.v2CoreAccountCreatedEventNotification, value, "V2CoreAccountCreatedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountUpdatedEventNotification>> V2CoreAccountUpdatedEventNotification
        {
            add { this.AddEventHandler(ref this.v2CoreAccountUpdatedEventNotification, value, "V2CoreAccountUpdatedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationCustomerCapabilityStatusUpdatedEventNotification>> V2CoreAccountIncludingConfigurationCustomerCapabilityStatusUpdatedEventNotification
        {
            add { this.AddEventHandler(ref this.v2CoreAccountIncludingConfigurationCustomerCapabilityStatusUpdatedEventNotification, value, "V2CoreAccountIncludingConfigurationCustomerCapabilityStatusUpdatedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationCustomerUpdatedEventNotification>> V2CoreAccountIncludingConfigurationCustomerUpdatedEventNotification
        {
            add { this.AddEventHandler(ref this.v2CoreAccountIncludingConfigurationCustomerUpdatedEventNotification, value, "V2CoreAccountIncludingConfigurationCustomerUpdatedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationMerchantCapabilityStatusUpdatedEventNotification>> V2CoreAccountIncludingConfigurationMerchantCapabilityStatusUpdatedEventNotification
        {
            add { this.AddEventHandler(ref this.v2CoreAccountIncludingConfigurationMerchantCapabilityStatusUpdatedEventNotification, value, "V2CoreAccountIncludingConfigurationMerchantCapabilityStatusUpdatedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationMerchantUpdatedEventNotification>> V2CoreAccountIncludingConfigurationMerchantUpdatedEventNotification
        {
            add { this.AddEventHandler(ref this.v2CoreAccountIncludingConfigurationMerchantUpdatedEventNotification, value, "V2CoreAccountIncludingConfigurationMerchantUpdatedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdatedEventNotification>> V2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdatedEventNotification
        {
            add { this.AddEventHandler(ref this.v2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdatedEventNotification, value, "V2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdatedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationRecipientUpdatedEventNotification>> V2CoreAccountIncludingConfigurationRecipientUpdatedEventNotification
        {
            add { this.AddEventHandler(ref this.v2CoreAccountIncludingConfigurationRecipientUpdatedEventNotification, value, "V2CoreAccountIncludingConfigurationRecipientUpdatedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationStorerCapabilityStatusUpdatedEventNotification>> V2CoreAccountIncludingConfigurationStorerCapabilityStatusUpdatedEventNotification
        {
            add { this.AddEventHandler(ref this.v2CoreAccountIncludingConfigurationStorerCapabilityStatusUpdatedEventNotification, value, "V2CoreAccountIncludingConfigurationStorerCapabilityStatusUpdatedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationStorerUpdatedEventNotification>> V2CoreAccountIncludingConfigurationStorerUpdatedEventNotification
        {
            add { this.AddEventHandler(ref this.v2CoreAccountIncludingConfigurationStorerUpdatedEventNotification, value, "V2CoreAccountIncludingConfigurationStorerUpdatedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingDefaultsUpdatedEventNotification>> V2CoreAccountIncludingDefaultsUpdatedEventNotification
        {
            add { this.AddEventHandler(ref this.v2CoreAccountIncludingDefaultsUpdatedEventNotification, value, "V2CoreAccountIncludingDefaultsUpdatedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingIdentityUpdatedEventNotification>> V2CoreAccountIncludingIdentityUpdatedEventNotification
        {
            add { this.AddEventHandler(ref this.v2CoreAccountIncludingIdentityUpdatedEventNotification, value, "V2CoreAccountIncludingIdentityUpdatedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingRequirementsUpdatedEventNotification>> V2CoreAccountIncludingRequirementsUpdatedEventNotification
        {
            add { this.AddEventHandler(ref this.v2CoreAccountIncludingRequirementsUpdatedEventNotification, value, "V2CoreAccountIncludingRequirementsUpdatedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountLinkReturnedEventNotification>> V2CoreAccountLinkReturnedEventNotification
        {
            add { this.AddEventHandler(ref this.v2CoreAccountLinkReturnedEventNotification, value, "V2CoreAccountLinkReturnedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountPersonCreatedEventNotification>> V2CoreAccountPersonCreatedEventNotification
        {
            add { this.AddEventHandler(ref this.v2CoreAccountPersonCreatedEventNotification, value, "V2CoreAccountPersonCreatedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountPersonDeletedEventNotification>> V2CoreAccountPersonDeletedEventNotification
        {
            add { this.AddEventHandler(ref this.v2CoreAccountPersonDeletedEventNotification, value, "V2CoreAccountPersonDeletedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountPersonUpdatedEventNotification>> V2CoreAccountPersonUpdatedEventNotification
        {
            add { this.AddEventHandler(ref this.v2CoreAccountPersonUpdatedEventNotification, value, "V2CoreAccountPersonUpdatedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreEventDestinationPingEventNotification>> V2CoreEventDestinationPingEventNotification
        {
            add { this.AddEventHandler(ref this.v2CoreEventDestinationPingEventNotification, value, "V2CoreEventDestinationPingEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementAdjustmentCreatedEventNotification>> V2MoneyManagementAdjustmentCreatedEventNotification
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementAdjustmentCreatedEventNotification, value, "V2MoneyManagementAdjustmentCreatedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAccountCreatedEventNotification>> V2MoneyManagementFinancialAccountCreatedEventNotification
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementFinancialAccountCreatedEventNotification, value, "V2MoneyManagementFinancialAccountCreatedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAccountUpdatedEventNotification>> V2MoneyManagementFinancialAccountUpdatedEventNotification
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementFinancialAccountUpdatedEventNotification, value, "V2MoneyManagementFinancialAccountUpdatedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAddressActivatedEventNotification>> V2MoneyManagementFinancialAddressActivatedEventNotification
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementFinancialAddressActivatedEventNotification, value, "V2MoneyManagementFinancialAddressActivatedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAddressFailedEventNotification>> V2MoneyManagementFinancialAddressFailedEventNotification
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementFinancialAddressFailedEventNotification, value, "V2MoneyManagementFinancialAddressFailedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferAvailableEventNotification>> V2MoneyManagementInboundTransferAvailableEventNotification
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementInboundTransferAvailableEventNotification, value, "V2MoneyManagementInboundTransferAvailableEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitFailedEventNotification>> V2MoneyManagementInboundTransferBankDebitFailedEventNotification
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementInboundTransferBankDebitFailedEventNotification, value, "V2MoneyManagementInboundTransferBankDebitFailedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitProcessingEventNotification>> V2MoneyManagementInboundTransferBankDebitProcessingEventNotification
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementInboundTransferBankDebitProcessingEventNotification, value, "V2MoneyManagementInboundTransferBankDebitProcessingEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitQueuedEventNotification>> V2MoneyManagementInboundTransferBankDebitQueuedEventNotification
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementInboundTransferBankDebitQueuedEventNotification, value, "V2MoneyManagementInboundTransferBankDebitQueuedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitReturnedEventNotification>> V2MoneyManagementInboundTransferBankDebitReturnedEventNotification
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementInboundTransferBankDebitReturnedEventNotification, value, "V2MoneyManagementInboundTransferBankDebitReturnedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitSucceededEventNotification>> V2MoneyManagementInboundTransferBankDebitSucceededEventNotification
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementInboundTransferBankDebitSucceededEventNotification, value, "V2MoneyManagementInboundTransferBankDebitSucceededEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentCanceledEventNotification>> V2MoneyManagementOutboundPaymentCanceledEventNotification
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementOutboundPaymentCanceledEventNotification, value, "V2MoneyManagementOutboundPaymentCanceledEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentCreatedEventNotification>> V2MoneyManagementOutboundPaymentCreatedEventNotification
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementOutboundPaymentCreatedEventNotification, value, "V2MoneyManagementOutboundPaymentCreatedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentFailedEventNotification>> V2MoneyManagementOutboundPaymentFailedEventNotification
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementOutboundPaymentFailedEventNotification, value, "V2MoneyManagementOutboundPaymentFailedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentPostedEventNotification>> V2MoneyManagementOutboundPaymentPostedEventNotification
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementOutboundPaymentPostedEventNotification, value, "V2MoneyManagementOutboundPaymentPostedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentReturnedEventNotification>> V2MoneyManagementOutboundPaymentReturnedEventNotification
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementOutboundPaymentReturnedEventNotification, value, "V2MoneyManagementOutboundPaymentReturnedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentUpdatedEventNotification>> V2MoneyManagementOutboundPaymentUpdatedEventNotification
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementOutboundPaymentUpdatedEventNotification, value, "V2MoneyManagementOutboundPaymentUpdatedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferCanceledEventNotification>> V2MoneyManagementOutboundTransferCanceledEventNotification
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementOutboundTransferCanceledEventNotification, value, "V2MoneyManagementOutboundTransferCanceledEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferCreatedEventNotification>> V2MoneyManagementOutboundTransferCreatedEventNotification
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementOutboundTransferCreatedEventNotification, value, "V2MoneyManagementOutboundTransferCreatedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferFailedEventNotification>> V2MoneyManagementOutboundTransferFailedEventNotification
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementOutboundTransferFailedEventNotification, value, "V2MoneyManagementOutboundTransferFailedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferPostedEventNotification>> V2MoneyManagementOutboundTransferPostedEventNotification
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementOutboundTransferPostedEventNotification, value, "V2MoneyManagementOutboundTransferPostedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferReturnedEventNotification>> V2MoneyManagementOutboundTransferReturnedEventNotification
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementOutboundTransferReturnedEventNotification, value, "V2MoneyManagementOutboundTransferReturnedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferUpdatedEventNotification>> V2MoneyManagementOutboundTransferUpdatedEventNotification
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementOutboundTransferUpdatedEventNotification, value, "V2MoneyManagementOutboundTransferUpdatedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementPayoutMethodUpdatedEventNotification>> V2MoneyManagementPayoutMethodUpdatedEventNotification
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementPayoutMethodUpdatedEventNotification, value, "V2MoneyManagementPayoutMethodUpdatedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedCreditAvailableEventNotification>> V2MoneyManagementReceivedCreditAvailableEventNotification
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementReceivedCreditAvailableEventNotification, value, "V2MoneyManagementReceivedCreditAvailableEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedCreditFailedEventNotification>> V2MoneyManagementReceivedCreditFailedEventNotification
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementReceivedCreditFailedEventNotification, value, "V2MoneyManagementReceivedCreditFailedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedCreditReturnedEventNotification>> V2MoneyManagementReceivedCreditReturnedEventNotification
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementReceivedCreditReturnedEventNotification, value, "V2MoneyManagementReceivedCreditReturnedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedCreditSucceededEventNotification>> V2MoneyManagementReceivedCreditSucceededEventNotification
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementReceivedCreditSucceededEventNotification, value, "V2MoneyManagementReceivedCreditSucceededEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitCanceledEventNotification>> V2MoneyManagementReceivedDebitCanceledEventNotification
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementReceivedDebitCanceledEventNotification, value, "V2MoneyManagementReceivedDebitCanceledEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitFailedEventNotification>> V2MoneyManagementReceivedDebitFailedEventNotification
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementReceivedDebitFailedEventNotification, value, "V2MoneyManagementReceivedDebitFailedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitPendingEventNotification>> V2MoneyManagementReceivedDebitPendingEventNotification
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementReceivedDebitPendingEventNotification, value, "V2MoneyManagementReceivedDebitPendingEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitSucceededEventNotification>> V2MoneyManagementReceivedDebitSucceededEventNotification
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementReceivedDebitSucceededEventNotification, value, "V2MoneyManagementReceivedDebitSucceededEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitUpdatedEventNotification>> V2MoneyManagementReceivedDebitUpdatedEventNotification
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementReceivedDebitUpdatedEventNotification, value, "V2MoneyManagementReceivedDebitUpdatedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementTransactionCreatedEventNotification>> V2MoneyManagementTransactionCreatedEventNotification
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementTransactionCreatedEventNotification, value, "V2MoneyManagementTransactionCreatedEvent"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementTransactionUpdatedEventNotification>> V2MoneyManagementTransactionUpdatedEventNotification
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementTransactionUpdatedEventNotification, value, "V2MoneyManagementTransactionUpdatedEvent"); }
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
                if (false)
                {
                    // so all of our handlers can be `else if`s
                }

                // event-handler-dispatch: The beginning of the section generated from our OpenAPI spec
                else if (eventNotification is Stripe.Events.V1BillingMeterErrorReportTriggeredEventNotification)
                {
                    this.v1BillingMeterErrorReportTriggeredEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterErrorReportTriggeredEventNotification>((Stripe.Events.V1BillingMeterErrorReportTriggeredEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V1BillingMeterNoMeterFoundEventNotification)
                {
                    this.v1BillingMeterNoMeterFoundEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterNoMeterFoundEventNotification>((Stripe.Events.V1BillingMeterNoMeterFoundEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountClosedEventNotification)
                {
                    this.v2CoreAccountClosedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountClosedEventNotification>((Stripe.Events.V2CoreAccountClosedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountCreatedEventNotification)
                {
                    this.v2CoreAccountCreatedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountCreatedEventNotification>((Stripe.Events.V2CoreAccountCreatedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountUpdatedEventNotification)
                {
                    this.v2CoreAccountUpdatedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountUpdatedEventNotification>((Stripe.Events.V2CoreAccountUpdatedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingConfigurationCustomerCapabilityStatusUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingConfigurationCustomerCapabilityStatusUpdatedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationCustomerCapabilityStatusUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingConfigurationCustomerCapabilityStatusUpdatedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingConfigurationCustomerUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingConfigurationCustomerUpdatedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationCustomerUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingConfigurationCustomerUpdatedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingConfigurationMerchantCapabilityStatusUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingConfigurationMerchantCapabilityStatusUpdatedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationMerchantCapabilityStatusUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingConfigurationMerchantCapabilityStatusUpdatedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingConfigurationMerchantUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingConfigurationMerchantUpdatedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationMerchantUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingConfigurationMerchantUpdatedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdatedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdatedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingConfigurationRecipientUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingConfigurationRecipientUpdatedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationRecipientUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingConfigurationRecipientUpdatedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingConfigurationStorerCapabilityStatusUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingConfigurationStorerCapabilityStatusUpdatedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationStorerCapabilityStatusUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingConfigurationStorerCapabilityStatusUpdatedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingConfigurationStorerUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingConfigurationStorerUpdatedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationStorerUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingConfigurationStorerUpdatedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingDefaultsUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingDefaultsUpdatedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingDefaultsUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingDefaultsUpdatedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingIdentityUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingIdentityUpdatedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingIdentityUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingIdentityUpdatedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingRequirementsUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingRequirementsUpdatedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingRequirementsUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingRequirementsUpdatedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountLinkReturnedEventNotification)
                {
                    this.v2CoreAccountLinkReturnedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountLinkReturnedEventNotification>((Stripe.Events.V2CoreAccountLinkReturnedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountPersonCreatedEventNotification)
                {
                    this.v2CoreAccountPersonCreatedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountPersonCreatedEventNotification>((Stripe.Events.V2CoreAccountPersonCreatedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountPersonDeletedEventNotification)
                {
                    this.v2CoreAccountPersonDeletedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountPersonDeletedEventNotification>((Stripe.Events.V2CoreAccountPersonDeletedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountPersonUpdatedEventNotification)
                {
                    this.v2CoreAccountPersonUpdatedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountPersonUpdatedEventNotification>((Stripe.Events.V2CoreAccountPersonUpdatedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2CoreEventDestinationPingEventNotification)
                {
                    this.v2CoreEventDestinationPingEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreEventDestinationPingEventNotification>((Stripe.Events.V2CoreEventDestinationPingEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementAdjustmentCreatedEventNotification)
                {
                    this.v2MoneyManagementAdjustmentCreatedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementAdjustmentCreatedEventNotification>((Stripe.Events.V2MoneyManagementAdjustmentCreatedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementFinancialAccountCreatedEventNotification)
                {
                    this.v2MoneyManagementFinancialAccountCreatedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAccountCreatedEventNotification>((Stripe.Events.V2MoneyManagementFinancialAccountCreatedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementFinancialAccountUpdatedEventNotification)
                {
                    this.v2MoneyManagementFinancialAccountUpdatedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAccountUpdatedEventNotification>((Stripe.Events.V2MoneyManagementFinancialAccountUpdatedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementFinancialAddressActivatedEventNotification)
                {
                    this.v2MoneyManagementFinancialAddressActivatedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAddressActivatedEventNotification>((Stripe.Events.V2MoneyManagementFinancialAddressActivatedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementFinancialAddressFailedEventNotification)
                {
                    this.v2MoneyManagementFinancialAddressFailedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAddressFailedEventNotification>((Stripe.Events.V2MoneyManagementFinancialAddressFailedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementInboundTransferAvailableEventNotification)
                {
                    this.v2MoneyManagementInboundTransferAvailableEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferAvailableEventNotification>((Stripe.Events.V2MoneyManagementInboundTransferAvailableEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementInboundTransferBankDebitFailedEventNotification)
                {
                    this.v2MoneyManagementInboundTransferBankDebitFailedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitFailedEventNotification>((Stripe.Events.V2MoneyManagementInboundTransferBankDebitFailedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementInboundTransferBankDebitProcessingEventNotification)
                {
                    this.v2MoneyManagementInboundTransferBankDebitProcessingEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitProcessingEventNotification>((Stripe.Events.V2MoneyManagementInboundTransferBankDebitProcessingEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementInboundTransferBankDebitQueuedEventNotification)
                {
                    this.v2MoneyManagementInboundTransferBankDebitQueuedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitQueuedEventNotification>((Stripe.Events.V2MoneyManagementInboundTransferBankDebitQueuedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementInboundTransferBankDebitReturnedEventNotification)
                {
                    this.v2MoneyManagementInboundTransferBankDebitReturnedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitReturnedEventNotification>((Stripe.Events.V2MoneyManagementInboundTransferBankDebitReturnedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementInboundTransferBankDebitSucceededEventNotification)
                {
                    this.v2MoneyManagementInboundTransferBankDebitSucceededEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitSucceededEventNotification>((Stripe.Events.V2MoneyManagementInboundTransferBankDebitSucceededEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundPaymentCanceledEventNotification)
                {
                    this.v2MoneyManagementOutboundPaymentCanceledEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentCanceledEventNotification>((Stripe.Events.V2MoneyManagementOutboundPaymentCanceledEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundPaymentCreatedEventNotification)
                {
                    this.v2MoneyManagementOutboundPaymentCreatedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentCreatedEventNotification>((Stripe.Events.V2MoneyManagementOutboundPaymentCreatedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundPaymentFailedEventNotification)
                {
                    this.v2MoneyManagementOutboundPaymentFailedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentFailedEventNotification>((Stripe.Events.V2MoneyManagementOutboundPaymentFailedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundPaymentPostedEventNotification)
                {
                    this.v2MoneyManagementOutboundPaymentPostedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentPostedEventNotification>((Stripe.Events.V2MoneyManagementOutboundPaymentPostedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundPaymentReturnedEventNotification)
                {
                    this.v2MoneyManagementOutboundPaymentReturnedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentReturnedEventNotification>((Stripe.Events.V2MoneyManagementOutboundPaymentReturnedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundPaymentUpdatedEventNotification)
                {
                    this.v2MoneyManagementOutboundPaymentUpdatedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentUpdatedEventNotification>((Stripe.Events.V2MoneyManagementOutboundPaymentUpdatedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundTransferCanceledEventNotification)
                {
                    this.v2MoneyManagementOutboundTransferCanceledEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferCanceledEventNotification>((Stripe.Events.V2MoneyManagementOutboundTransferCanceledEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundTransferCreatedEventNotification)
                {
                    this.v2MoneyManagementOutboundTransferCreatedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferCreatedEventNotification>((Stripe.Events.V2MoneyManagementOutboundTransferCreatedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundTransferFailedEventNotification)
                {
                    this.v2MoneyManagementOutboundTransferFailedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferFailedEventNotification>((Stripe.Events.V2MoneyManagementOutboundTransferFailedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundTransferPostedEventNotification)
                {
                    this.v2MoneyManagementOutboundTransferPostedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferPostedEventNotification>((Stripe.Events.V2MoneyManagementOutboundTransferPostedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundTransferReturnedEventNotification)
                {
                    this.v2MoneyManagementOutboundTransferReturnedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferReturnedEventNotification>((Stripe.Events.V2MoneyManagementOutboundTransferReturnedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementOutboundTransferUpdatedEventNotification)
                {
                    this.v2MoneyManagementOutboundTransferUpdatedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferUpdatedEventNotification>((Stripe.Events.V2MoneyManagementOutboundTransferUpdatedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementPayoutMethodUpdatedEventNotification)
                {
                    this.v2MoneyManagementPayoutMethodUpdatedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementPayoutMethodUpdatedEventNotification>((Stripe.Events.V2MoneyManagementPayoutMethodUpdatedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementReceivedCreditAvailableEventNotification)
                {
                    this.v2MoneyManagementReceivedCreditAvailableEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedCreditAvailableEventNotification>((Stripe.Events.V2MoneyManagementReceivedCreditAvailableEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementReceivedCreditFailedEventNotification)
                {
                    this.v2MoneyManagementReceivedCreditFailedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedCreditFailedEventNotification>((Stripe.Events.V2MoneyManagementReceivedCreditFailedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementReceivedCreditReturnedEventNotification)
                {
                    this.v2MoneyManagementReceivedCreditReturnedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedCreditReturnedEventNotification>((Stripe.Events.V2MoneyManagementReceivedCreditReturnedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementReceivedCreditSucceededEventNotification)
                {
                    this.v2MoneyManagementReceivedCreditSucceededEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedCreditSucceededEventNotification>((Stripe.Events.V2MoneyManagementReceivedCreditSucceededEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementReceivedDebitCanceledEventNotification)
                {
                    this.v2MoneyManagementReceivedDebitCanceledEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitCanceledEventNotification>((Stripe.Events.V2MoneyManagementReceivedDebitCanceledEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementReceivedDebitFailedEventNotification)
                {
                    this.v2MoneyManagementReceivedDebitFailedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitFailedEventNotification>((Stripe.Events.V2MoneyManagementReceivedDebitFailedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementReceivedDebitPendingEventNotification)
                {
                    this.v2MoneyManagementReceivedDebitPendingEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitPendingEventNotification>((Stripe.Events.V2MoneyManagementReceivedDebitPendingEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementReceivedDebitSucceededEventNotification)
                {
                    this.v2MoneyManagementReceivedDebitSucceededEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitSucceededEventNotification>((Stripe.Events.V2MoneyManagementReceivedDebitSucceededEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementReceivedDebitUpdatedEventNotification)
                {
                    this.v2MoneyManagementReceivedDebitUpdatedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitUpdatedEventNotification>((Stripe.Events.V2MoneyManagementReceivedDebitUpdatedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementTransactionCreatedEventNotification)
                {
                    this.v2MoneyManagementTransactionCreatedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementTransactionCreatedEventNotification>((Stripe.Events.V2MoneyManagementTransactionCreatedEventNotification)eventNotification, this.client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementTransactionUpdatedEventNotification)
                {
                    this.v2MoneyManagementTransactionUpdatedEventNotification.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementTransactionUpdatedEventNotification>((Stripe.Events.V2MoneyManagementTransactionUpdatedEventNotification)eventNotification, this.client));
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
                    new StripeUnhandledEventNotificationEventArgs(eventNotification, this.client, new UnhandledNotificationDetails(true)));
            }
        }
    }
}
