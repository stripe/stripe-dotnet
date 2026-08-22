namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Stripe.Events;

    /// <summary>
    /// Shared registration and dispatch machinery for <see cref="StripeEventNotificationHandler"/>
    /// and <see cref="StripeEventNotificationHandlerWithoutVerification"/>.
    ///
    /// Deliberately declares no Handle method. C# resolves overloads by signature rather than
    /// replacing them, so if either handler derived from the other it would inherit — and publicly
    /// expose — the other's Handle. As siblings, each declares only its own.
    ///
    /// This type has to be public (CS0060 forbids a less-accessible base for a public class), but
    /// its constructor is internal, so it cannot be derived from outside this assembly.
    /// </summary>
    public abstract class StripeEventNotificationHandlerBase
    {
#pragma warning disable SA1401 // Fields should be private
        protected readonly StripeClient client;
#pragma warning restore SA1401 // Fields should be private
        private readonly HashSet<string> handledEventTypes = new HashSet<string>();
#pragma warning disable SA1401 // Fields should be private
        protected readonly StripeClientOptions clientOptions;
#pragma warning restore SA1401 // Fields should be private

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
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingDefaultsUpdatedEventNotification>> v2CoreAccountIncludingDefaultsUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingFutureRequirementsUpdatedEventNotification>> v2CoreAccountIncludingFutureRequirementsUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingIdentityUpdatedEventNotification>> v2CoreAccountIncludingIdentityUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountIncludingRequirementsUpdatedEventNotification>> v2CoreAccountIncludingRequirementsUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountLinkReturnedEventNotification>> v2CoreAccountLinkReturned;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountPersonCreatedEventNotification>> v2CoreAccountPersonCreated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountPersonDeletedEventNotification>> v2CoreAccountPersonDeleted;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreAccountPersonUpdatedEventNotification>> v2CoreAccountPersonUpdated;
        private EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreEventDestinationPingEventNotification>> v2CoreEventDestinationPing;

        // private-event-handlers: The end of the section generated from our OpenAPI spec
        private Func<V2.Core.EventNotification, StripeClient, bool> preHandleCallback;

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeEventNotificationHandlerBase"/> class.
        /// </summary>
        /// <param name="client">The StripeClient instance to use for parsing and API requests.</param>
        /// <param name="fallbackCallback">The function to call when handing an event for whom there's no callback registered.</param>
        internal StripeEventNotificationHandlerBase(StripeClient client, Action<object, StripeUnhandledEventNotificationEventArgs> fallbackCallback)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            this.client = client;

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

        public event EventHandler<StripeEventNotificationEventArgs<Stripe.Events.V2CoreEventDestinationPingEventNotification>> V2CoreEventDestinationPing
        {
            add { this.AddEventHandler(ref this.v2CoreEventDestinationPing, value, "v2.core.event_destination.ping"); }
            remove { this.RemoveEventHandler(); }
        }

        // public-event-handlers: The end of the section generated from our OpenAPI spec

        /// <summary>
        /// Gets or sets a value indicating whether this handler has already handled an event.
        /// Registering a callback afterwards is refused, since callbacks are expected to be
        /// registered once at startup; doing so later indicates a bug.
        ///
        /// Set naiively rather than with a lock: we expect registration to happen synchronously
        /// at startup and handling to happen afterwards, so a race here is not a real concern.
        /// </summary>
        protected bool HasHandledEvent { get; set; }

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
        /// Registers a hook that runs after <c>Handle</c> parses the payload but before any callback fires. Returning <c>false</c> stops handling: no callback runs at all.
        /// </summary>
        /// <param name="hook">
        /// A function that receives the parsed event notification and the context-scoped
        /// client, and returns whether handling should continue.
        /// </param>
        /// <exception cref="ArgumentNullException">Thrown if <paramref name="hook"/> is null.</exception>
        /// <exception cref="InvalidOperationException">
        /// Thrown if called after <c>Handle</c> has already been called, or if a hook is
        /// already registered.
        /// </exception>
        public void PreHandle(Func<V2.Core.EventNotification, StripeClient, bool> hook)
        {
            if (hook == null)
            {
                throw new ArgumentNullException(nameof(hook));
            }

            this.AssertCanRegister();

            if (this.preHandleCallback != null)
            {
                throw new InvalidOperationException("A PreHandle hook is already registered. Only one PreHandle hook is allowed.");
            }

            this.preHandleCallback = hook;
        }

        /// <summary>
        /// Throws if callbacks can no longer be registered. Callbacks are expected to be
        /// registered once at startup, so registering anything after handling has begun
        /// indicates a bug.
        /// </summary>
        /// <exception cref="InvalidOperationException">
        /// Thrown if <c>Handle</c> has already been called.
        /// </exception>
        private void AssertCanRegister()
        {
            if (this.HasHandledEvent)
            {
                throw new InvalidOperationException("Cannot register new event handlers after Handle has been called. This is indicative of a bug.");
            }
        }

        /// <summary>
        /// Dispatches the event with the event's StripeContext by creating a new client instance.
        /// </summary>
        /// <param name="eventNotification">The event notification to dispatch.</param>
        protected void DispatchEventWithContext(V2.Core.EventNotification eventNotification)
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

        /// <summary>
        /// Centralizes the logic for adding event handlers.
        /// </summary>
        private void AddEventHandler<T>(ref EventHandler<T> handler, EventHandler<T> value, string eventType)
        where T : EventArgs
        {
            this.AssertCanRegister();

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

        private void DispatchEvent(V2.Core.EventNotification eventNotification, StripeClient client)
        {
            if (eventNotification == null)
            {
                throw new ArgumentNullException(nameof(eventNotification));
            }

            if (this.preHandleCallback != null && !this.preHandleCallback(eventNotification, client))
            {
                return;
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
                else if (eventNotification is Stripe.Events.V2CoreEventDestinationPingEventNotification)
                {
                    this.v2CoreEventDestinationPing.Invoke(this, new StripeEventNotificationEventArgs<Stripe.Events.V2CoreEventDestinationPingEventNotification>((Stripe.Events.V2CoreEventDestinationPingEventNotification)eventNotification, client));
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
