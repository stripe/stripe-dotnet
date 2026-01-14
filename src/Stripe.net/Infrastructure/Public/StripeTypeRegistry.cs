namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Reflection;

    public static class StripeTypeRegistry
    {
        /// <summary>
        /// Dictionary mapping the values contained in the `object` key of JSON payloads returned
        /// by Stripe's API to concrete types of model classes.
        /// </summary>
        public static readonly IReadOnlyDictionary<string, Type> ObjectsToTypes = new ReadOnlyDictionary<string, Type>(
            new Dictionary<string, Type>
            {
                // ObjectsToTypes: The beginning of the section generated from our OpenAPI spec
                { "account", typeof(Account) },
                { "account_link", typeof(AccountLink) },
                { "account_session", typeof(AccountSession) },
                { "apple_pay_domain", typeof(ApplePayDomain) },
                { "application", typeof(Application) },
                { "application_fee", typeof(ApplicationFee) },
                { "apps.secret", typeof(Apps.Secret) },
                { "balance", typeof(Balance) },
                { "balance_settings", typeof(BalanceSettings) },
                { "balance_transaction", typeof(BalanceTransaction) },
                { "bank_account", typeof(BankAccount) },
                { "billing.alert", typeof(Billing.Alert) },
                { "billing.alert_triggered", typeof(Billing.AlertTriggered) },
                { "billing.credit_balance_summary", typeof(Billing.CreditBalanceSummary) },
                {
                    "billing.credit_balance_transaction", typeof(
                    Billing.CreditBalanceTransaction)
                },
                { "billing.credit_grant", typeof(Billing.CreditGrant) },
                { "billing.meter", typeof(Billing.Meter) },
                { "billing.meter_event", typeof(Billing.MeterEvent) },
                { "billing.meter_event_adjustment", typeof(Billing.MeterEventAdjustment) },
                { "billing.meter_event_summary", typeof(Billing.MeterEventSummary) },
                { "billing_portal.configuration", typeof(BillingPortal.Configuration) },
                { "billing_portal.session", typeof(BillingPortal.Session) },
                { "capability", typeof(Capability) },
                { "card", typeof(Card) },
                { "cash_balance", typeof(CashBalance) },
                { "charge", typeof(Charge) },
                { "checkout.session", typeof(Checkout.Session) },
                { "climate.order", typeof(Climate.Order) },
                { "climate.product", typeof(Climate.Product) },
                { "climate.supplier", typeof(Climate.Supplier) },
                { "confirmation_token", typeof(ConfirmationToken) },
                { "connect_collection_transfer", typeof(ConnectCollectionTransfer) },
                { "country_spec", typeof(CountrySpec) },
                { "coupon", typeof(Coupon) },
                { "credit_note", typeof(CreditNote) },
                { "credit_note_line_item", typeof(CreditNoteLineItem) },
                { "customer", typeof(Customer) },
                { "customer_balance_transaction", typeof(CustomerBalanceTransaction) },
                { "customer_cash_balance_transaction", typeof(CustomerCashBalanceTransaction) },
                { "customer_session", typeof(CustomerSession) },
                { "discount", typeof(Discount) },
                { "dispute", typeof(Dispute) },
                { "entitlements.active_entitlement", typeof(Entitlements.ActiveEntitlement) },
                {
                    "entitlements.active_entitlement_summary", typeof(
                    Entitlements.ActiveEntitlementSummary)
                },
                { "entitlements.feature", typeof(Entitlements.Feature) },
                { "ephemeral_key", typeof(EphemeralKey) },
                { "event", typeof(Event) },
                { "fee_refund", typeof(ApplicationFeeRefund) },
                { "file", typeof(File) },
                { "file_link", typeof(FileLink) },
                { "financial_connections.account", typeof(FinancialConnections.Account) },
                {
                    "financial_connections.account_owner", typeof(
                    FinancialConnections.AccountOwner)
                },
                {
                    "financial_connections.account_ownership", typeof(
                    FinancialConnections.AccountOwnership)
                },
                { "financial_connections.session", typeof(FinancialConnections.Session) },
                {
                    "financial_connections.transaction", typeof(
                    FinancialConnections.Transaction)
                },
                { "forwarding.request", typeof(Forwarding.Request) },
                { "funding_instructions", typeof(FundingInstructions) },
                { "identity.verification_report", typeof(Identity.VerificationReport) },
                { "identity.verification_session", typeof(Identity.VerificationSession) },
                { "invoice", typeof(Invoice) },
                { "invoice_payment", typeof(InvoicePayment) },
                { "invoice_rendering_template", typeof(InvoiceRenderingTemplate) },
                { "invoiceitem", typeof(InvoiceItem) },
                { "issuing.authorization", typeof(Issuing.Authorization) },
                { "issuing.card", typeof(Issuing.Card) },
                { "issuing.cardholder", typeof(Issuing.Cardholder) },
                { "issuing.dispute", typeof(Issuing.Dispute) },
                { "issuing.personalization_design", typeof(Issuing.PersonalizationDesign) },
                { "issuing.physical_bundle", typeof(Issuing.PhysicalBundle) },
                { "issuing.token", typeof(Issuing.Token) },
                { "issuing.transaction", typeof(Issuing.Transaction) },
                { "item", typeof(LineItem) },
                { "line_item", typeof(InvoiceLineItem) },
                { "login_link", typeof(LoginLink) },
                { "mandate", typeof(Mandate) },
                { "payment_attempt_record", typeof(PaymentAttemptRecord) },
                { "payment_intent", typeof(PaymentIntent) },
                {
                    "payment_intent_amount_details_line_item", typeof(
                    PaymentIntentAmountDetailsLineItem)
                },
                { "payment_link", typeof(PaymentLink) },
                { "payment_method", typeof(PaymentMethod) },
                { "payment_method_configuration", typeof(PaymentMethodConfiguration) },
                { "payment_method_domain", typeof(PaymentMethodDomain) },
                { "payment_record", typeof(PaymentRecord) },
                { "payout", typeof(Payout) },
                { "person", typeof(Person) },
                { "plan", typeof(Plan) },
                { "price", typeof(Price) },
                { "product", typeof(Product) },
                { "product_feature", typeof(ProductFeature) },
                { "promotion_code", typeof(PromotionCode) },
                { "quote", typeof(Quote) },
                { "radar.early_fraud_warning", typeof(Radar.EarlyFraudWarning) },
                { "radar.value_list", typeof(Radar.ValueList) },
                { "radar.value_list_item", typeof(Radar.ValueListItem) },
                { "refund", typeof(Refund) },
                { "reporting.report_run", typeof(Reporting.ReportRun) },
                { "reporting.report_type", typeof(Reporting.ReportType) },
                { "reserve_transaction", typeof(ReserveTransaction) },
                { "review", typeof(Review) },
                { "scheduled_query_run", typeof(Sigma.ScheduledQueryRun) },
                { "setup_attempt", typeof(SetupAttempt) },
                { "setup_intent", typeof(SetupIntent) },
                { "shipping_rate", typeof(ShippingRate) },
                { "source", typeof(Source) },
                { "source_mandate_notification", typeof(SourceMandateNotification) },
                { "source_transaction", typeof(SourceTransaction) },
                { "subscription", typeof(Subscription) },
                { "subscription_item", typeof(SubscriptionItem) },
                { "subscription_schedule", typeof(SubscriptionSchedule) },
                { "tax.association", typeof(Tax.Association) },
                { "tax.calculation", typeof(Tax.Calculation) },
                { "tax.calculation_line_item", typeof(Tax.CalculationLineItem) },
                { "tax.registration", typeof(Tax.Registration) },
                { "tax.settings", typeof(Tax.Settings) },
                { "tax.transaction", typeof(Tax.Transaction) },
                { "tax.transaction_line_item", typeof(Tax.TransactionLineItem) },
                { "tax_code", typeof(TaxCode) },
                { "tax_deducted_at_source", typeof(TaxDeductedAtSource) },
                { "tax_id", typeof(TaxId) },
                { "tax_rate", typeof(TaxRate) },
                { "terminal.configuration", typeof(Terminal.Configuration) },
                { "terminal.connection_token", typeof(Terminal.ConnectionToken) },
                { "terminal.location", typeof(Terminal.Location) },
                { "terminal.onboarding_link", typeof(Terminal.OnboardingLink) },
                { "terminal.reader", typeof(Terminal.Reader) },
                { "test_helpers.test_clock", typeof(TestHelpers.TestClock) },
                { "token", typeof(Token) },
                { "topup", typeof(Topup) },
                { "transfer", typeof(Transfer) },
                { "transfer_reversal", typeof(TransferReversal) },
                { "treasury.credit_reversal", typeof(Treasury.CreditReversal) },
                { "treasury.debit_reversal", typeof(Treasury.DebitReversal) },
                { "treasury.financial_account", typeof(Treasury.FinancialAccount) },
                {
                    "treasury.financial_account_features", typeof(
                    Treasury.FinancialAccountFeatures)
                },
                { "treasury.inbound_transfer", typeof(Treasury.InboundTransfer) },
                { "treasury.outbound_payment", typeof(Treasury.OutboundPayment) },
                { "treasury.outbound_transfer", typeof(Treasury.OutboundTransfer) },
                { "treasury.received_credit", typeof(Treasury.ReceivedCredit) },
                { "treasury.received_debit", typeof(Treasury.ReceivedDebit) },
                { "treasury.transaction", typeof(Treasury.Transaction) },
                { "treasury.transaction_entry", typeof(Treasury.TransactionEntry) },
                { "webhook_endpoint", typeof(WebhookEndpoint) },

                // ObjectsToTypes: The end of the section generated from our OpenAPI spec
            });

        internal static readonly IReadOnlyDictionary<string, Type> V2ObjectsToTypes = new ReadOnlyDictionary<string, Type>(
            new Dictionary<string, Type>
            {
                // V2ObjectsToTypes: The beginning of the section generated from our OpenAPI spec
                { "v2.billing.meter_event", typeof(V2.Billing.MeterEvent) },
                { "v2.billing.meter_event_adjustment", typeof(V2.Billing.MeterEventAdjustment) },
                { "v2.billing.meter_event_session", typeof(V2.Billing.MeterEventSession) },
                { "v2.core.account", typeof(V2.Core.Account) },
                { "v2.core.account_link", typeof(V2.Core.AccountLink) },
                { "v2.core.account_person", typeof(V2.Core.AccountPerson) },
                { "v2.core.account_person_token", typeof(V2.Core.AccountPersonToken) },
                { "v2.core.account_token", typeof(V2.Core.AccountToken) },
                { "v2.core.event", typeof(V2.Core.Event) },
                { "v2.core.event_destination", typeof(V2.Core.EventDestination) },

                // V2ObjectsToTypes: The end of the section generated from our OpenAPI spec
            });

        internal static readonly IReadOnlyDictionary<string, Type> V2EventsToTypes = new ReadOnlyDictionary<string, Type>(
            new Dictionary<string, Type>
            {
                // V2EventsToTypes: The beginning of the section generated from our OpenAPI spec
                {
                    "v1.billing.meter.error_report_triggered", typeof(
                    Events.V1BillingMeterErrorReportTriggeredEvent)
                },
                {
                    "v1.billing.meter.no_meter_found", typeof(
                    Events.V1BillingMeterNoMeterFoundEvent)
                },
                { "v2.core.account.closed", typeof(Events.V2CoreAccountClosedEvent) },
                { "v2.core.account.created", typeof(Events.V2CoreAccountCreatedEvent) },
                { "v2.core.account.updated", typeof(Events.V2CoreAccountUpdatedEvent) },
                {
                    "v2.core.account[configuration.customer].capability_status_updated", typeof(
                    Events.V2CoreAccountIncludingConfigurationCustomerCapabilityStatusUpdatedEvent)
                },
                {
                    "v2.core.account[configuration.customer].updated", typeof(
                    Events.V2CoreAccountIncludingConfigurationCustomerUpdatedEvent)
                },
                {
                    "v2.core.account[configuration.merchant].capability_status_updated", typeof(
                    Events.V2CoreAccountIncludingConfigurationMerchantCapabilityStatusUpdatedEvent)
                },
                {
                    "v2.core.account[configuration.merchant].updated", typeof(
                    Events.V2CoreAccountIncludingConfigurationMerchantUpdatedEvent)
                },
                {
                    "v2.core.account[configuration.recipient].capability_status_updated", typeof(
                    Events.V2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdatedEvent)
                },
                {
                    "v2.core.account[configuration.recipient].updated", typeof(
                    Events.V2CoreAccountIncludingConfigurationRecipientUpdatedEvent)
                },
                {
                    "v2.core.account[defaults].updated", typeof(
                    Events.V2CoreAccountIncludingDefaultsUpdatedEvent)
                },
                {
                    "v2.core.account[future_requirements].updated", typeof(
                    Events.V2CoreAccountIncludingFutureRequirementsUpdatedEvent)
                },
                {
                    "v2.core.account[identity].updated", typeof(
                    Events.V2CoreAccountIncludingIdentityUpdatedEvent)
                },
                {
                    "v2.core.account[requirements].updated", typeof(
                    Events.V2CoreAccountIncludingRequirementsUpdatedEvent)
                },
                {
                    "v2.core.account_link.returned", typeof(
                    Events.V2CoreAccountLinkReturnedEvent)
                },
                {
                    "v2.core.account_person.created", typeof(
                    Events.V2CoreAccountPersonCreatedEvent)
                },
                {
                    "v2.core.account_person.deleted", typeof(
                    Events.V2CoreAccountPersonDeletedEvent)
                },
                {
                    "v2.core.account_person.updated", typeof(
                    Events.V2CoreAccountPersonUpdatedEvent)
                },
                {
                    "v2.core.event_destination.ping", typeof(
                    Events.V2CoreEventDestinationPingEvent)
                },

                // V2EventsToTypes: The end of the section generated from our OpenAPI spec
            });

        internal static readonly IReadOnlyDictionary<string, Type> V2EventNotificationsToTypes = new ReadOnlyDictionary<string, Type>(
            new Dictionary<string, Type>
            {
                // V2EventNotificationsToTypes: The beginning of the section generated from our OpenAPI spec
                {
                    "v1.billing.meter.error_report_triggered", typeof(
                    Events.V1BillingMeterErrorReportTriggeredEventNotification)
                },
                {
                    "v1.billing.meter.no_meter_found", typeof(
                    Events.V1BillingMeterNoMeterFoundEventNotification)
                },
                {
                    "v2.core.account.closed", typeof(
                    Events.V2CoreAccountClosedEventNotification)
                },
                {
                    "v2.core.account.created", typeof(
                    Events.V2CoreAccountCreatedEventNotification)
                },
                {
                    "v2.core.account.updated", typeof(
                    Events.V2CoreAccountUpdatedEventNotification)
                },
                {
                    "v2.core.account[configuration.customer].capability_status_updated", typeof(
                    Events.V2CoreAccountIncludingConfigurationCustomerCapabilityStatusUpdatedEventNotification)
                },
                {
                    "v2.core.account[configuration.customer].updated", typeof(
                    Events.V2CoreAccountIncludingConfigurationCustomerUpdatedEventNotification)
                },
                {
                    "v2.core.account[configuration.merchant].capability_status_updated", typeof(
                    Events.V2CoreAccountIncludingConfigurationMerchantCapabilityStatusUpdatedEventNotification)
                },
                {
                    "v2.core.account[configuration.merchant].updated", typeof(
                    Events.V2CoreAccountIncludingConfigurationMerchantUpdatedEventNotification)
                },
                {
                    "v2.core.account[configuration.recipient].capability_status_updated", typeof(
                    Events.V2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdatedEventNotification)
                },
                {
                    "v2.core.account[configuration.recipient].updated", typeof(
                    Events.V2CoreAccountIncludingConfigurationRecipientUpdatedEventNotification)
                },
                {
                    "v2.core.account[defaults].updated", typeof(
                    Events.V2CoreAccountIncludingDefaultsUpdatedEventNotification)
                },
                {
                    "v2.core.account[future_requirements].updated", typeof(
                    Events.V2CoreAccountIncludingFutureRequirementsUpdatedEventNotification)
                },
                {
                    "v2.core.account[identity].updated", typeof(
                    Events.V2CoreAccountIncludingIdentityUpdatedEventNotification)
                },
                {
                    "v2.core.account[requirements].updated", typeof(
                    Events.V2CoreAccountIncludingRequirementsUpdatedEventNotification)
                },
                {
                    "v2.core.account_link.returned", typeof(
                    Events.V2CoreAccountLinkReturnedEventNotification)
                },
                {
                    "v2.core.account_person.created", typeof(
                    Events.V2CoreAccountPersonCreatedEventNotification)
                },
                {
                    "v2.core.account_person.deleted", typeof(
                    Events.V2CoreAccountPersonDeletedEventNotification)
                },
                {
                    "v2.core.account_person.updated", typeof(
                    Events.V2CoreAccountPersonUpdatedEventNotification)
                },
                {
                    "v2.core.event_destination.ping", typeof(
                    Events.V2CoreEventDestinationPingEventNotification)
                },

                // V2EventNotificationsToTypes: The end of the section generated from our OpenAPI spec
            });

        /// <summary>
        /// Returns the concrete type to use, given a potential type and the value of the `object`
        /// key in a JSON payload.
        /// </summary>
        /// <param name="potentialType">Potential type. Can be a concrete type or an interface.</param>
        /// <param name="objectValue">Value of the `object` key in the JSON payload.</param>
        /// <returns>The concrete type to use, or `null`.</returns>
        public static Type GetConcreteType(Type potentialType, string objectValue)
        {
            if (potentialType != null && !potentialType.GetTypeInfo().IsInterface)
            {
                // Potential type is already a concrete type, return it.
                return potentialType;
            }

            Type concreteType = null;

            if (!string.IsNullOrEmpty(objectValue) &&
                ObjectsToTypes.TryGetValue(objectValue, out concreteType))
            {
                // Found a concrete type matching the value of the `object` key, check if it's
                // compatible with the interface.
                if (potentialType.GetTypeInfo().IsAssignableFrom(concreteType.GetTypeInfo()))
                {
                    return concreteType;
                }
            }

            return null;
        }

        public static Type GetConcreteV2EventType(string typeValue)
        {
            Type concreteType = null;
            if (!string.IsNullOrEmpty(typeValue))
            {
                V2EventsToTypes.TryGetValue(typeValue, out concreteType);
            }

            return concreteType;
        }

        public static Type GetConcreteV2EventNotificationType(string typeValue)
        {
            Type concreteType = null;
            if (!string.IsNullOrEmpty(typeValue))
            {
                V2EventNotificationsToTypes.TryGetValue(typeValue, out concreteType);
            }

            return concreteType;
        }
    }
}
