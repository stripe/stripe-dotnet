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
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterErrorReportTriggeredEventNotification>> v1BillingMeterErrorReportTriggered;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterNoMeterFoundEventNotification>> v1BillingMeterNoMeterFound;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CommerceProductCatalogImportsFailedEventNotification>> v2CommerceProductCatalogImportsFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CommerceProductCatalogImportsProcessingEventNotification>> v2CommerceProductCatalogImportsProcessing;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CommerceProductCatalogImportsSucceededEventNotification>> v2CommerceProductCatalogImportsSucceeded;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CommerceProductCatalogImportsSucceededWithErrorsEventNotification>> v2CommerceProductCatalogImportsSucceededWithErrors;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountClosedEventNotification>> v2CoreAccountClosed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountCreatedEventNotification>> v2CoreAccountCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountUpdatedEventNotification>> v2CoreAccountUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationCustomerCapabilityStatusUpdatedEventNotification>> v2CoreAccountIncludingConfigurationCustomerCapabilityStatusUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationCustomerUpdatedEventNotification>> v2CoreAccountIncludingConfigurationCustomerUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationMerchantCapabilityStatusUpdatedEventNotification>> v2CoreAccountIncludingConfigurationMerchantCapabilityStatusUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationMerchantUpdatedEventNotification>> v2CoreAccountIncludingConfigurationMerchantUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdatedEventNotification>> v2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationRecipientUpdatedEventNotification>> v2CoreAccountIncludingConfigurationRecipientUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationStorerCapabilityStatusUpdatedEventNotification>> v2CoreAccountIncludingConfigurationStorerCapabilityStatusUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationStorerUpdatedEventNotification>> v2CoreAccountIncludingConfigurationStorerUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingDefaultsUpdatedEventNotification>> v2CoreAccountIncludingDefaultsUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingFutureRequirementsUpdatedEventNotification>> v2CoreAccountIncludingFutureRequirementsUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingIdentityUpdatedEventNotification>> v2CoreAccountIncludingIdentityUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingRequirementsUpdatedEventNotification>> v2CoreAccountIncludingRequirementsUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountLinkReturnedEventNotification>> v2CoreAccountLinkReturned;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountPersonCreatedEventNotification>> v2CoreAccountPersonCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountPersonDeletedEventNotification>> v2CoreAccountPersonDeleted;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountPersonUpdatedEventNotification>> v2CoreAccountPersonUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobBatchFailedEventNotification>> v2CoreBatchJobBatchFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobCanceledEventNotification>> v2CoreBatchJobCanceled;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobCompletedEventNotification>> v2CoreBatchJobCompleted;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobCreatedEventNotification>> v2CoreBatchJobCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobReadyForUploadEventNotification>> v2CoreBatchJobReadyForUpload;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobTimeoutEventNotification>> v2CoreBatchJobTimeout;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobUpdatedEventNotification>> v2CoreBatchJobUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobUploadTimeoutEventNotification>> v2CoreBatchJobUploadTimeout;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobValidatingEventNotification>> v2CoreBatchJobValidating;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobValidationFailedEventNotification>> v2CoreBatchJobValidationFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreEventDestinationPingEventNotification>> v2CoreEventDestinationPing;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthEventGenerationFailureResolvedEventNotification>> v2CoreHealthEventGenerationFailureResolved;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2DataReportingQueryRunCreatedEventNotification>> v2DataReportingQueryRunCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2DataReportingQueryRunFailedEventNotification>> v2DataReportingQueryRunFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2DataReportingQueryRunSucceededEventNotification>> v2DataReportingQueryRunSucceeded;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2DataReportingQueryRunUpdatedEventNotification>> v2DataReportingQueryRunUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2ExtendWorkflowRunFailedEventNotification>> v2ExtendWorkflowRunFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2ExtendWorkflowRunStartedEventNotification>> v2ExtendWorkflowRunStarted;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2ExtendWorkflowRunSucceededEventNotification>> v2ExtendWorkflowRunSucceeded;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementAdjustmentCreatedEventNotification>> v2MoneyManagementAdjustmentCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAccountCreatedEventNotification>> v2MoneyManagementFinancialAccountCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAccountUpdatedEventNotification>> v2MoneyManagementFinancialAccountUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAddressActivatedEventNotification>> v2MoneyManagementFinancialAddressActivated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAddressFailedEventNotification>> v2MoneyManagementFinancialAddressFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferAvailableEventNotification>> v2MoneyManagementInboundTransferAvailable;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitFailedEventNotification>> v2MoneyManagementInboundTransferBankDebitFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitProcessingEventNotification>> v2MoneyManagementInboundTransferBankDebitProcessing;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitQueuedEventNotification>> v2MoneyManagementInboundTransferBankDebitQueued;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitReturnedEventNotification>> v2MoneyManagementInboundTransferBankDebitReturned;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitSucceededEventNotification>> v2MoneyManagementInboundTransferBankDebitSucceeded;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentCanceledEventNotification>> v2MoneyManagementOutboundPaymentCanceled;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentCreatedEventNotification>> v2MoneyManagementOutboundPaymentCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentFailedEventNotification>> v2MoneyManagementOutboundPaymentFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentPostedEventNotification>> v2MoneyManagementOutboundPaymentPosted;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentReturnedEventNotification>> v2MoneyManagementOutboundPaymentReturned;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentUpdatedEventNotification>> v2MoneyManagementOutboundPaymentUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferCanceledEventNotification>> v2MoneyManagementOutboundTransferCanceled;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferCreatedEventNotification>> v2MoneyManagementOutboundTransferCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferFailedEventNotification>> v2MoneyManagementOutboundTransferFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferPostedEventNotification>> v2MoneyManagementOutboundTransferPosted;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferReturnedEventNotification>> v2MoneyManagementOutboundTransferReturned;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferUpdatedEventNotification>> v2MoneyManagementOutboundTransferUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementPayoutMethodCreatedEventNotification>> v2MoneyManagementPayoutMethodCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementPayoutMethodUpdatedEventNotification>> v2MoneyManagementPayoutMethodUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedCreditAvailableEventNotification>> v2MoneyManagementReceivedCreditAvailable;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedCreditFailedEventNotification>> v2MoneyManagementReceivedCreditFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedCreditReturnedEventNotification>> v2MoneyManagementReceivedCreditReturned;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedCreditSucceededEventNotification>> v2MoneyManagementReceivedCreditSucceeded;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitCanceledEventNotification>> v2MoneyManagementReceivedDebitCanceled;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitFailedEventNotification>> v2MoneyManagementReceivedDebitFailed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitPendingEventNotification>> v2MoneyManagementReceivedDebitPending;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitSucceededEventNotification>> v2MoneyManagementReceivedDebitSucceeded;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitUpdatedEventNotification>> v2MoneyManagementReceivedDebitUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementTransactionCreatedEventNotification>> v2MoneyManagementTransactionCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementTransactionUpdatedEventNotification>> v2MoneyManagementTransactionUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2OrchestratedCommerceAgreementConfirmedEventNotification>> v2OrchestratedCommerceAgreementConfirmed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2OrchestratedCommerceAgreementCreatedEventNotification>> v2OrchestratedCommerceAgreementCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2OrchestratedCommerceAgreementPartiallyConfirmedEventNotification>> v2OrchestratedCommerceAgreementPartiallyConfirmed;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2OrchestratedCommerceAgreementTerminatedEventNotification>> v2OrchestratedCommerceAgreementTerminated;

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
        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterErrorReportTriggeredEventNotification>> V1BillingMeterErrorReportTriggered
        {
            add { this.AddEventHandler(ref this.v1BillingMeterErrorReportTriggered, value, "v1.billing.meter.error_report_triggered"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterNoMeterFoundEventNotification>> V1BillingMeterNoMeterFound
        {
            add { this.AddEventHandler(ref this.v1BillingMeterNoMeterFound, value, "v1.billing.meter.no_meter_found"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CommerceProductCatalogImportsFailedEventNotification>> V2CommerceProductCatalogImportsFailed
        {
            add { this.AddEventHandler(ref this.v2CommerceProductCatalogImportsFailed, value, "v2.commerce.product_catalog.imports.failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CommerceProductCatalogImportsProcessingEventNotification>> V2CommerceProductCatalogImportsProcessing
        {
            add { this.AddEventHandler(ref this.v2CommerceProductCatalogImportsProcessing, value, "v2.commerce.product_catalog.imports.processing"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CommerceProductCatalogImportsSucceededEventNotification>> V2CommerceProductCatalogImportsSucceeded
        {
            add { this.AddEventHandler(ref this.v2CommerceProductCatalogImportsSucceeded, value, "v2.commerce.product_catalog.imports.succeeded"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CommerceProductCatalogImportsSucceededWithErrorsEventNotification>> V2CommerceProductCatalogImportsSucceededWithErrors
        {
            add { this.AddEventHandler(ref this.v2CommerceProductCatalogImportsSucceededWithErrors, value, "v2.commerce.product_catalog.imports.succeeded_with_errors"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountClosedEventNotification>> V2CoreAccountClosed
        {
            add { this.AddEventHandler(ref this.v2CoreAccountClosed, value, "v2.core.account.closed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountCreatedEventNotification>> V2CoreAccountCreated
        {
            add { this.AddEventHandler(ref this.v2CoreAccountCreated, value, "v2.core.account.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountUpdatedEventNotification>> V2CoreAccountUpdated
        {
            add { this.AddEventHandler(ref this.v2CoreAccountUpdated, value, "v2.core.account.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationCustomerCapabilityStatusUpdatedEventNotification>> V2CoreAccountIncludingConfigurationCustomerCapabilityStatusUpdated
        {
            add { this.AddEventHandler(ref this.v2CoreAccountIncludingConfigurationCustomerCapabilityStatusUpdated, value, "v2.core.account[configuration.customer].capability_status_updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationCustomerUpdatedEventNotification>> V2CoreAccountIncludingConfigurationCustomerUpdated
        {
            add { this.AddEventHandler(ref this.v2CoreAccountIncludingConfigurationCustomerUpdated, value, "v2.core.account[configuration.customer].updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationMerchantCapabilityStatusUpdatedEventNotification>> V2CoreAccountIncludingConfigurationMerchantCapabilityStatusUpdated
        {
            add { this.AddEventHandler(ref this.v2CoreAccountIncludingConfigurationMerchantCapabilityStatusUpdated, value, "v2.core.account[configuration.merchant].capability_status_updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationMerchantUpdatedEventNotification>> V2CoreAccountIncludingConfigurationMerchantUpdated
        {
            add { this.AddEventHandler(ref this.v2CoreAccountIncludingConfigurationMerchantUpdated, value, "v2.core.account[configuration.merchant].updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdatedEventNotification>> V2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdated
        {
            add { this.AddEventHandler(ref this.v2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdated, value, "v2.core.account[configuration.recipient].capability_status_updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationRecipientUpdatedEventNotification>> V2CoreAccountIncludingConfigurationRecipientUpdated
        {
            add { this.AddEventHandler(ref this.v2CoreAccountIncludingConfigurationRecipientUpdated, value, "v2.core.account[configuration.recipient].updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationStorerCapabilityStatusUpdatedEventNotification>> V2CoreAccountIncludingConfigurationStorerCapabilityStatusUpdated
        {
            add { this.AddEventHandler(ref this.v2CoreAccountIncludingConfigurationStorerCapabilityStatusUpdated, value, "v2.core.account[configuration.storer].capability_status_updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationStorerUpdatedEventNotification>> V2CoreAccountIncludingConfigurationStorerUpdated
        {
            add { this.AddEventHandler(ref this.v2CoreAccountIncludingConfigurationStorerUpdated, value, "v2.core.account[configuration.storer].updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingDefaultsUpdatedEventNotification>> V2CoreAccountIncludingDefaultsUpdated
        {
            add { this.AddEventHandler(ref this.v2CoreAccountIncludingDefaultsUpdated, value, "v2.core.account[defaults].updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingFutureRequirementsUpdatedEventNotification>> V2CoreAccountIncludingFutureRequirementsUpdated
        {
            add { this.AddEventHandler(ref this.v2CoreAccountIncludingFutureRequirementsUpdated, value, "v2.core.account[future_requirements].updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingIdentityUpdatedEventNotification>> V2CoreAccountIncludingIdentityUpdated
        {
            add { this.AddEventHandler(ref this.v2CoreAccountIncludingIdentityUpdated, value, "v2.core.account[identity].updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingRequirementsUpdatedEventNotification>> V2CoreAccountIncludingRequirementsUpdated
        {
            add { this.AddEventHandler(ref this.v2CoreAccountIncludingRequirementsUpdated, value, "v2.core.account[requirements].updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountLinkReturnedEventNotification>> V2CoreAccountLinkReturned
        {
            add { this.AddEventHandler(ref this.v2CoreAccountLinkReturned, value, "v2.core.account_link.returned"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountPersonCreatedEventNotification>> V2CoreAccountPersonCreated
        {
            add { this.AddEventHandler(ref this.v2CoreAccountPersonCreated, value, "v2.core.account_person.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountPersonDeletedEventNotification>> V2CoreAccountPersonDeleted
        {
            add { this.AddEventHandler(ref this.v2CoreAccountPersonDeleted, value, "v2.core.account_person.deleted"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountPersonUpdatedEventNotification>> V2CoreAccountPersonUpdated
        {
            add { this.AddEventHandler(ref this.v2CoreAccountPersonUpdated, value, "v2.core.account_person.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobBatchFailedEventNotification>> V2CoreBatchJobBatchFailed
        {
            add { this.AddEventHandler(ref this.v2CoreBatchJobBatchFailed, value, "v2.core.batch_job.batch_failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobCanceledEventNotification>> V2CoreBatchJobCanceled
        {
            add { this.AddEventHandler(ref this.v2CoreBatchJobCanceled, value, "v2.core.batch_job.canceled"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobCompletedEventNotification>> V2CoreBatchJobCompleted
        {
            add { this.AddEventHandler(ref this.v2CoreBatchJobCompleted, value, "v2.core.batch_job.completed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobCreatedEventNotification>> V2CoreBatchJobCreated
        {
            add { this.AddEventHandler(ref this.v2CoreBatchJobCreated, value, "v2.core.batch_job.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobReadyForUploadEventNotification>> V2CoreBatchJobReadyForUpload
        {
            add { this.AddEventHandler(ref this.v2CoreBatchJobReadyForUpload, value, "v2.core.batch_job.ready_for_upload"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobTimeoutEventNotification>> V2CoreBatchJobTimeout
        {
            add { this.AddEventHandler(ref this.v2CoreBatchJobTimeout, value, "v2.core.batch_job.timeout"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobUpdatedEventNotification>> V2CoreBatchJobUpdated
        {
            add { this.AddEventHandler(ref this.v2CoreBatchJobUpdated, value, "v2.core.batch_job.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobUploadTimeoutEventNotification>> V2CoreBatchJobUploadTimeout
        {
            add { this.AddEventHandler(ref this.v2CoreBatchJobUploadTimeout, value, "v2.core.batch_job.upload_timeout"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobValidatingEventNotification>> V2CoreBatchJobValidating
        {
            add { this.AddEventHandler(ref this.v2CoreBatchJobValidating, value, "v2.core.batch_job.validating"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreBatchJobValidationFailedEventNotification>> V2CoreBatchJobValidationFailed
        {
            add { this.AddEventHandler(ref this.v2CoreBatchJobValidationFailed, value, "v2.core.batch_job.validation_failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreEventDestinationPingEventNotification>> V2CoreEventDestinationPing
        {
            add { this.AddEventHandler(ref this.v2CoreEventDestinationPing, value, "v2.core.event_destination.ping"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthEventGenerationFailureResolvedEventNotification>> V2CoreHealthEventGenerationFailureResolved
        {
            add { this.AddEventHandler(ref this.v2CoreHealthEventGenerationFailureResolved, value, "v2.core.health.event_generation_failure.resolved"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2DataReportingQueryRunCreatedEventNotification>> V2DataReportingQueryRunCreated
        {
            add { this.AddEventHandler(ref this.v2DataReportingQueryRunCreated, value, "v2.data.reporting.query_run.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2DataReportingQueryRunFailedEventNotification>> V2DataReportingQueryRunFailed
        {
            add { this.AddEventHandler(ref this.v2DataReportingQueryRunFailed, value, "v2.data.reporting.query_run.failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2DataReportingQueryRunSucceededEventNotification>> V2DataReportingQueryRunSucceeded
        {
            add { this.AddEventHandler(ref this.v2DataReportingQueryRunSucceeded, value, "v2.data.reporting.query_run.succeeded"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2DataReportingQueryRunUpdatedEventNotification>> V2DataReportingQueryRunUpdated
        {
            add { this.AddEventHandler(ref this.v2DataReportingQueryRunUpdated, value, "v2.data.reporting.query_run.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2ExtendWorkflowRunFailedEventNotification>> V2ExtendWorkflowRunFailed
        {
            add { this.AddEventHandler(ref this.v2ExtendWorkflowRunFailed, value, "v2.extend.workflow_run.failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2ExtendWorkflowRunStartedEventNotification>> V2ExtendWorkflowRunStarted
        {
            add { this.AddEventHandler(ref this.v2ExtendWorkflowRunStarted, value, "v2.extend.workflow_run.started"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2ExtendWorkflowRunSucceededEventNotification>> V2ExtendWorkflowRunSucceeded
        {
            add { this.AddEventHandler(ref this.v2ExtendWorkflowRunSucceeded, value, "v2.extend.workflow_run.succeeded"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementAdjustmentCreatedEventNotification>> V2MoneyManagementAdjustmentCreated
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementAdjustmentCreated, value, "v2.money_management.adjustment.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAccountCreatedEventNotification>> V2MoneyManagementFinancialAccountCreated
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementFinancialAccountCreated, value, "v2.money_management.financial_account.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAccountUpdatedEventNotification>> V2MoneyManagementFinancialAccountUpdated
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementFinancialAccountUpdated, value, "v2.money_management.financial_account.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAddressActivatedEventNotification>> V2MoneyManagementFinancialAddressActivated
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementFinancialAddressActivated, value, "v2.money_management.financial_address.activated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAddressFailedEventNotification>> V2MoneyManagementFinancialAddressFailed
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementFinancialAddressFailed, value, "v2.money_management.financial_address.failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferAvailableEventNotification>> V2MoneyManagementInboundTransferAvailable
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementInboundTransferAvailable, value, "v2.money_management.inbound_transfer.available"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitFailedEventNotification>> V2MoneyManagementInboundTransferBankDebitFailed
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementInboundTransferBankDebitFailed, value, "v2.money_management.inbound_transfer.bank_debit_failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitProcessingEventNotification>> V2MoneyManagementInboundTransferBankDebitProcessing
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementInboundTransferBankDebitProcessing, value, "v2.money_management.inbound_transfer.bank_debit_processing"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitQueuedEventNotification>> V2MoneyManagementInboundTransferBankDebitQueued
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementInboundTransferBankDebitQueued, value, "v2.money_management.inbound_transfer.bank_debit_queued"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitReturnedEventNotification>> V2MoneyManagementInboundTransferBankDebitReturned
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementInboundTransferBankDebitReturned, value, "v2.money_management.inbound_transfer.bank_debit_returned"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementInboundTransferBankDebitSucceededEventNotification>> V2MoneyManagementInboundTransferBankDebitSucceeded
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementInboundTransferBankDebitSucceeded, value, "v2.money_management.inbound_transfer.bank_debit_succeeded"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentCanceledEventNotification>> V2MoneyManagementOutboundPaymentCanceled
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementOutboundPaymentCanceled, value, "v2.money_management.outbound_payment.canceled"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentCreatedEventNotification>> V2MoneyManagementOutboundPaymentCreated
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementOutboundPaymentCreated, value, "v2.money_management.outbound_payment.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentFailedEventNotification>> V2MoneyManagementOutboundPaymentFailed
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementOutboundPaymentFailed, value, "v2.money_management.outbound_payment.failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentPostedEventNotification>> V2MoneyManagementOutboundPaymentPosted
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementOutboundPaymentPosted, value, "v2.money_management.outbound_payment.posted"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentReturnedEventNotification>> V2MoneyManagementOutboundPaymentReturned
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementOutboundPaymentReturned, value, "v2.money_management.outbound_payment.returned"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundPaymentUpdatedEventNotification>> V2MoneyManagementOutboundPaymentUpdated
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementOutboundPaymentUpdated, value, "v2.money_management.outbound_payment.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferCanceledEventNotification>> V2MoneyManagementOutboundTransferCanceled
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementOutboundTransferCanceled, value, "v2.money_management.outbound_transfer.canceled"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferCreatedEventNotification>> V2MoneyManagementOutboundTransferCreated
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementOutboundTransferCreated, value, "v2.money_management.outbound_transfer.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferFailedEventNotification>> V2MoneyManagementOutboundTransferFailed
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementOutboundTransferFailed, value, "v2.money_management.outbound_transfer.failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferPostedEventNotification>> V2MoneyManagementOutboundTransferPosted
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementOutboundTransferPosted, value, "v2.money_management.outbound_transfer.posted"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferReturnedEventNotification>> V2MoneyManagementOutboundTransferReturned
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementOutboundTransferReturned, value, "v2.money_management.outbound_transfer.returned"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementOutboundTransferUpdatedEventNotification>> V2MoneyManagementOutboundTransferUpdated
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementOutboundTransferUpdated, value, "v2.money_management.outbound_transfer.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementPayoutMethodCreatedEventNotification>> V2MoneyManagementPayoutMethodCreated
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementPayoutMethodCreated, value, "v2.money_management.payout_method.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementPayoutMethodUpdatedEventNotification>> V2MoneyManagementPayoutMethodUpdated
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementPayoutMethodUpdated, value, "v2.money_management.payout_method.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedCreditAvailableEventNotification>> V2MoneyManagementReceivedCreditAvailable
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementReceivedCreditAvailable, value, "v2.money_management.received_credit.available"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedCreditFailedEventNotification>> V2MoneyManagementReceivedCreditFailed
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementReceivedCreditFailed, value, "v2.money_management.received_credit.failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedCreditReturnedEventNotification>> V2MoneyManagementReceivedCreditReturned
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementReceivedCreditReturned, value, "v2.money_management.received_credit.returned"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedCreditSucceededEventNotification>> V2MoneyManagementReceivedCreditSucceeded
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementReceivedCreditSucceeded, value, "v2.money_management.received_credit.succeeded"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitCanceledEventNotification>> V2MoneyManagementReceivedDebitCanceled
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementReceivedDebitCanceled, value, "v2.money_management.received_debit.canceled"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitFailedEventNotification>> V2MoneyManagementReceivedDebitFailed
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementReceivedDebitFailed, value, "v2.money_management.received_debit.failed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitPendingEventNotification>> V2MoneyManagementReceivedDebitPending
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementReceivedDebitPending, value, "v2.money_management.received_debit.pending"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitSucceededEventNotification>> V2MoneyManagementReceivedDebitSucceeded
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementReceivedDebitSucceeded, value, "v2.money_management.received_debit.succeeded"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementReceivedDebitUpdatedEventNotification>> V2MoneyManagementReceivedDebitUpdated
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementReceivedDebitUpdated, value, "v2.money_management.received_debit.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementTransactionCreatedEventNotification>> V2MoneyManagementTransactionCreated
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementTransactionCreated, value, "v2.money_management.transaction.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementTransactionUpdatedEventNotification>> V2MoneyManagementTransactionUpdated
        {
            add { this.AddEventHandler(ref this.v2MoneyManagementTransactionUpdated, value, "v2.money_management.transaction.updated"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2OrchestratedCommerceAgreementConfirmedEventNotification>> V2OrchestratedCommerceAgreementConfirmed
        {
            add { this.AddEventHandler(ref this.v2OrchestratedCommerceAgreementConfirmed, value, "v2.orchestrated_commerce.agreement.confirmed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2OrchestratedCommerceAgreementCreatedEventNotification>> V2OrchestratedCommerceAgreementCreated
        {
            add { this.AddEventHandler(ref this.v2OrchestratedCommerceAgreementCreated, value, "v2.orchestrated_commerce.agreement.created"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2OrchestratedCommerceAgreementPartiallyConfirmedEventNotification>> V2OrchestratedCommerceAgreementPartiallyConfirmed
        {
            add { this.AddEventHandler(ref this.v2OrchestratedCommerceAgreementPartiallyConfirmed, value, "v2.orchestrated_commerce.agreement.partially_confirmed"); }
            remove { this.RemoveEventHandler(); }
        }

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2OrchestratedCommerceAgreementTerminatedEventNotification>> V2OrchestratedCommerceAgreementTerminated
        {
            add { this.AddEventHandler(ref this.v2OrchestratedCommerceAgreementTerminated, value, "v2.orchestrated_commerce.agreement.terminated"); }
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
                else if (eventNotification is Stripe.Events.V1BillingMeterErrorReportTriggeredEventNotification)
                {
                    this.v1BillingMeterErrorReportTriggered.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterErrorReportTriggeredEventNotification>((Stripe.Events.V1BillingMeterErrorReportTriggeredEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V1BillingMeterNoMeterFoundEventNotification)
                {
                    this.v1BillingMeterNoMeterFound.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V1BillingMeterNoMeterFoundEventNotification>((Stripe.Events.V1BillingMeterNoMeterFoundEventNotification)eventNotification, client));
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
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingConfigurationRecipientUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingConfigurationRecipientUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationRecipientUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingConfigurationRecipientUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingConfigurationStorerCapabilityStatusUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingConfigurationStorerCapabilityStatusUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationStorerCapabilityStatusUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingConfigurationStorerCapabilityStatusUpdatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreAccountIncludingConfigurationStorerUpdatedEventNotification)
                {
                    this.v2CoreAccountIncludingConfigurationStorerUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingConfigurationStorerUpdatedEventNotification>((Stripe.Events.V2CoreAccountIncludingConfigurationStorerUpdatedEventNotification)eventNotification, client));
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
                else if (eventNotification is Stripe.Events.V2CoreEventDestinationPingEventNotification)
                {
                    this.v2CoreEventDestinationPing.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreEventDestinationPingEventNotification>((Stripe.Events.V2CoreEventDestinationPingEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2CoreHealthEventGenerationFailureResolvedEventNotification)
                {
                    this.v2CoreHealthEventGenerationFailureResolved.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreHealthEventGenerationFailureResolvedEventNotification>((Stripe.Events.V2CoreHealthEventGenerationFailureResolvedEventNotification)eventNotification, client));
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
                else if (eventNotification is Stripe.Events.V2MoneyManagementAdjustmentCreatedEventNotification)
                {
                    this.v2MoneyManagementAdjustmentCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementAdjustmentCreatedEventNotification>((Stripe.Events.V2MoneyManagementAdjustmentCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementFinancialAccountCreatedEventNotification)
                {
                    this.v2MoneyManagementFinancialAccountCreated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAccountCreatedEventNotification>((Stripe.Events.V2MoneyManagementFinancialAccountCreatedEventNotification)eventNotification, client));
                }
                else if (eventNotification is Stripe.Events.V2MoneyManagementFinancialAccountUpdatedEventNotification)
                {
                    this.v2MoneyManagementFinancialAccountUpdated.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2MoneyManagementFinancialAccountUpdatedEventNotification>((Stripe.Events.V2MoneyManagementFinancialAccountUpdatedEventNotification)eventNotification, client));
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
