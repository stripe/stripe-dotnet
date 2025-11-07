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
                { "account_notice", typeof(AccountNotice) },
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
                { "billing.analytics.meter_usage", typeof(Billing.Analytics.MeterUsage) },
                { "billing.analytics.meter_usage_row", typeof(Billing.Analytics.MeterUsageRow) },
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
                { "capital.financing_offer", typeof(Capital.FinancingOffer) },
                { "capital.financing_summary", typeof(Capital.FinancingSummary) },
                { "capital.financing_transaction", typeof(Capital.FinancingTransaction) },
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
                    "financial_connections.account_inferred_balance", typeof(
                    FinancialConnections.AccountInferredBalance)
                },
                {
                    "financial_connections.account_owner", typeof(
                    FinancialConnections.AccountOwner)
                },
                {
                    "financial_connections.account_ownership", typeof(
                    FinancialConnections.AccountOwnership)
                },
                {
                    "financial_connections.institution", typeof(
                    FinancialConnections.Institution)
                },
                { "financial_connections.session", typeof(FinancialConnections.Session) },
                {
                    "financial_connections.transaction", typeof(
                    FinancialConnections.Transaction)
                },
                { "forwarding.request", typeof(Forwarding.Request) },
                { "funding_instructions", typeof(FundingInstructions) },
                { "fx_quote", typeof(FxQuote) },
                { "identity.verification_report", typeof(Identity.VerificationReport) },
                { "identity.verification_session", typeof(Identity.VerificationSession) },
                { "invoice", typeof(Invoice) },
                { "invoice_payment", typeof(InvoicePayment) },
                { "invoice_rendering_template", typeof(InvoiceRenderingTemplate) },
                { "invoiceitem", typeof(InvoiceItem) },
                { "issuing.authorization", typeof(Issuing.Authorization) },
                { "issuing.card", typeof(Issuing.Card) },
                { "issuing.cardholder", typeof(Issuing.Cardholder) },
                {
                    "issuing.credit_underwriting_record", typeof(
                    Issuing.CreditUnderwritingRecord)
                },
                { "issuing.dispute", typeof(Issuing.Dispute) },
                { "issuing.dispute_settlement_detail", typeof(Issuing.DisputeSettlementDetail) },
                { "issuing.fraud_liability_debit", typeof(Issuing.FraudLiabilityDebit) },
                { "issuing.personalization_design", typeof(Issuing.PersonalizationDesign) },
                { "issuing.physical_bundle", typeof(Issuing.PhysicalBundle) },
                { "issuing.settlement", typeof(Issuing.Settlement) },
                { "issuing.token", typeof(Issuing.Token) },
                { "issuing.transaction", typeof(Issuing.Transaction) },
                { "item", typeof(LineItem) },
                { "line_item", typeof(InvoiceLineItem) },
                { "login_link", typeof(LoginLink) },
                { "mandate", typeof(Mandate) },
                { "margin", typeof(Margin) },
                { "order", typeof(Order) },
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
                { "privacy.redaction_job", typeof(Privacy.RedactionJob) },
                {
                    "privacy.redaction_job_validation_error", typeof(
                    Privacy.RedactionJobValidationError)
                },
                { "product", typeof(Product) },
                { "product_feature", typeof(ProductFeature) },
                { "promotion_code", typeof(PromotionCode) },
                { "quote", typeof(Quote) },
                { "quote_line", typeof(QuoteLine) },
                { "quote_preview_invoice", typeof(QuotePreviewInvoice) },
                {
                    "quote_preview_subscription_schedule", typeof(
                    QuotePreviewSubscriptionSchedule)
                },
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
                { "tax.form", typeof(Tax.Form) },
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
                { "terminal.reader_collected_data", typeof(Terminal.ReaderCollectedData) },
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
                {
                    "financial_address_credit_simulation", typeof(
                    V2.FinancialAddressCreditSimulation)
                },
                {
                    "financial_address_generated_microdeposits", typeof(
                    V2.FinancialAddressGeneratedMicrodeposits)
                },
                { "v2.billing.bill_setting", typeof(V2.Billing.BillSetting) },
                { "v2.billing.bill_setting_version", typeof(V2.Billing.BillSettingVersion) },
                { "v2.billing.cadence", typeof(V2.Billing.Cadence) },
                { "v2.billing.collection_setting", typeof(V2.Billing.CollectionSetting) },
                {
                    "v2.billing.collection_setting_version", typeof(
                    V2.Billing.CollectionSettingVersion)
                },
                { "v2.billing.meter_event", typeof(V2.Billing.MeterEvent) },
                { "v2.billing.meter_event_adjustment", typeof(V2.Billing.MeterEventAdjustment) },
                { "v2.billing.meter_event_session", typeof(V2.Billing.MeterEventSession) },
                { "v2.billing.profile", typeof(V2.Billing.Profile) },
                { "v2.core.account", typeof(V2.Core.Account) },
                { "v2.core.account_link", typeof(V2.Core.AccountLink) },
                { "v2.core.account_person", typeof(V2.Core.AccountPerson) },
                { "v2.core.event", typeof(V2.Core.Event) },
                { "v2.core.event_destination", typeof(V2.Core.EventDestination) },
                { "v2.core.vault.gb_bank_account", typeof(V2.Core.Vault.GbBankAccount) },
                { "v2.core.vault.us_bank_account", typeof(V2.Core.Vault.UsBankAccount) },
                { "v2.money_management.adjustment", typeof(V2.MoneyManagement.Adjustment) },
                {
                    "v2.money_management.financial_account", typeof(
                    V2.MoneyManagement.FinancialAccount)
                },
                {
                    "v2.money_management.financial_address", typeof(
                    V2.MoneyManagement.FinancialAddress)
                },
                {
                    "v2.money_management.inbound_transfer", typeof(
                    V2.MoneyManagement.InboundTransfer)
                },
                {
                    "v2.money_management.outbound_payment", typeof(
                    V2.MoneyManagement.OutboundPayment)
                },
                {
                    "v2.money_management.outbound_payment_quote", typeof(
                    V2.MoneyManagement.OutboundPaymentQuote)
                },
                {
                    "v2.money_management.outbound_setup_intent", typeof(
                    V2.MoneyManagement.OutboundSetupIntent)
                },
                {
                    "v2.money_management.outbound_transfer", typeof(
                    V2.MoneyManagement.OutboundTransfer)
                },
                { "v2.money_management.payout_method", typeof(V2.MoneyManagement.PayoutMethod) },
                {
                    "v2.money_management.payout_methods_bank_account_spec", typeof(
                    V2.MoneyManagement.PayoutMethodsBankAccountSpec)
                },
                {
                    "v2.money_management.received_credit", typeof(
                    V2.MoneyManagement.ReceivedCredit)
                },
                {
                    "v2.money_management.received_debit", typeof(
                    V2.MoneyManagement.ReceivedDebit)
                },
                { "v2.money_management.transaction", typeof(V2.MoneyManagement.Transaction) },
                {
                    "v2.money_management.transaction_entry", typeof(
                    V2.MoneyManagement.TransactionEntry)
                },
                { "v2.payments.off_session_payment", typeof(V2.Payments.OffSessionPayment) },

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
                    "v2.core.account[configuration.storer].capability_status_updated", typeof(
                    Events.V2CoreAccountIncludingConfigurationStorerCapabilityStatusUpdatedEvent)
                },
                {
                    "v2.core.account[configuration.storer].updated", typeof(
                    Events.V2CoreAccountIncludingConfigurationStorerUpdatedEvent)
                },
                {
                    "v2.core.account[defaults].updated", typeof(
                    Events.V2CoreAccountIncludingDefaultsUpdatedEvent)
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
                {
                    "v2.money_management.adjustment.created", typeof(
                    Events.V2MoneyManagementAdjustmentCreatedEvent)
                },
                {
                    "v2.money_management.financial_account.created", typeof(
                    Events.V2MoneyManagementFinancialAccountCreatedEvent)
                },
                {
                    "v2.money_management.financial_account.updated", typeof(
                    Events.V2MoneyManagementFinancialAccountUpdatedEvent)
                },
                {
                    "v2.money_management.financial_address.activated", typeof(
                    Events.V2MoneyManagementFinancialAddressActivatedEvent)
                },
                {
                    "v2.money_management.financial_address.failed", typeof(
                    Events.V2MoneyManagementFinancialAddressFailedEvent)
                },
                {
                    "v2.money_management.inbound_transfer.available", typeof(
                    Events.V2MoneyManagementInboundTransferAvailableEvent)
                },
                {
                    "v2.money_management.inbound_transfer.bank_debit_failed", typeof(
                    Events.V2MoneyManagementInboundTransferBankDebitFailedEvent)
                },
                {
                    "v2.money_management.inbound_transfer.bank_debit_processing", typeof(
                    Events.V2MoneyManagementInboundTransferBankDebitProcessingEvent)
                },
                {
                    "v2.money_management.inbound_transfer.bank_debit_queued", typeof(
                    Events.V2MoneyManagementInboundTransferBankDebitQueuedEvent)
                },
                {
                    "v2.money_management.inbound_transfer.bank_debit_returned", typeof(
                    Events.V2MoneyManagementInboundTransferBankDebitReturnedEvent)
                },
                {
                    "v2.money_management.inbound_transfer.bank_debit_succeeded", typeof(
                    Events.V2MoneyManagementInboundTransferBankDebitSucceededEvent)
                },
                {
                    "v2.money_management.outbound_payment.canceled", typeof(
                    Events.V2MoneyManagementOutboundPaymentCanceledEvent)
                },
                {
                    "v2.money_management.outbound_payment.created", typeof(
                    Events.V2MoneyManagementOutboundPaymentCreatedEvent)
                },
                {
                    "v2.money_management.outbound_payment.failed", typeof(
                    Events.V2MoneyManagementOutboundPaymentFailedEvent)
                },
                {
                    "v2.money_management.outbound_payment.posted", typeof(
                    Events.V2MoneyManagementOutboundPaymentPostedEvent)
                },
                {
                    "v2.money_management.outbound_payment.returned", typeof(
                    Events.V2MoneyManagementOutboundPaymentReturnedEvent)
                },
                {
                    "v2.money_management.outbound_payment.updated", typeof(
                    Events.V2MoneyManagementOutboundPaymentUpdatedEvent)
                },
                {
                    "v2.money_management.outbound_transfer.canceled", typeof(
                    Events.V2MoneyManagementOutboundTransferCanceledEvent)
                },
                {
                    "v2.money_management.outbound_transfer.created", typeof(
                    Events.V2MoneyManagementOutboundTransferCreatedEvent)
                },
                {
                    "v2.money_management.outbound_transfer.failed", typeof(
                    Events.V2MoneyManagementOutboundTransferFailedEvent)
                },
                {
                    "v2.money_management.outbound_transfer.posted", typeof(
                    Events.V2MoneyManagementOutboundTransferPostedEvent)
                },
                {
                    "v2.money_management.outbound_transfer.returned", typeof(
                    Events.V2MoneyManagementOutboundTransferReturnedEvent)
                },
                {
                    "v2.money_management.outbound_transfer.updated", typeof(
                    Events.V2MoneyManagementOutboundTransferUpdatedEvent)
                },
                {
                    "v2.money_management.payout_method.updated", typeof(
                    Events.V2MoneyManagementPayoutMethodUpdatedEvent)
                },
                {
                    "v2.money_management.received_credit.available", typeof(
                    Events.V2MoneyManagementReceivedCreditAvailableEvent)
                },
                {
                    "v2.money_management.received_credit.failed", typeof(
                    Events.V2MoneyManagementReceivedCreditFailedEvent)
                },
                {
                    "v2.money_management.received_credit.returned", typeof(
                    Events.V2MoneyManagementReceivedCreditReturnedEvent)
                },
                {
                    "v2.money_management.received_credit.succeeded", typeof(
                    Events.V2MoneyManagementReceivedCreditSucceededEvent)
                },
                {
                    "v2.money_management.received_debit.canceled", typeof(
                    Events.V2MoneyManagementReceivedDebitCanceledEvent)
                },
                {
                    "v2.money_management.received_debit.failed", typeof(
                    Events.V2MoneyManagementReceivedDebitFailedEvent)
                },
                {
                    "v2.money_management.received_debit.pending", typeof(
                    Events.V2MoneyManagementReceivedDebitPendingEvent)
                },
                {
                    "v2.money_management.received_debit.succeeded", typeof(
                    Events.V2MoneyManagementReceivedDebitSucceededEvent)
                },
                {
                    "v2.money_management.received_debit.updated", typeof(
                    Events.V2MoneyManagementReceivedDebitUpdatedEvent)
                },
                {
                    "v2.money_management.transaction.created", typeof(
                    Events.V2MoneyManagementTransactionCreatedEvent)
                },
                {
                    "v2.money_management.transaction.updated", typeof(
                    Events.V2MoneyManagementTransactionUpdatedEvent)
                },
                {
                    "v2.payments.off_session_payment.attempt_failed", typeof(
                    Events.V2PaymentsOffSessionPaymentAttemptFailedEvent)
                },
                {
                    "v2.payments.off_session_payment.attempt_started", typeof(
                    Events.V2PaymentsOffSessionPaymentAttemptStartedEvent)
                },
                {
                    "v2.payments.off_session_payment.authorization_attempt_failed", typeof(
                    Events.V2PaymentsOffSessionPaymentAuthorizationAttemptFailedEvent)
                },
                {
                    "v2.payments.off_session_payment.authorization_attempt_started", typeof(
                    Events.V2PaymentsOffSessionPaymentAuthorizationAttemptStartedEvent)
                },
                {
                    "v2.payments.off_session_payment.canceled", typeof(
                    Events.V2PaymentsOffSessionPaymentCanceledEvent)
                },
                {
                    "v2.payments.off_session_payment.created", typeof(
                    Events.V2PaymentsOffSessionPaymentCreatedEvent)
                },
                {
                    "v2.payments.off_session_payment.failed", typeof(
                    Events.V2PaymentsOffSessionPaymentFailedEvent)
                },
                {
                    "v2.payments.off_session_payment.requires_capture", typeof(
                    Events.V2PaymentsOffSessionPaymentRequiresCaptureEvent)
                },
                {
                    "v2.payments.off_session_payment.succeeded", typeof(
                    Events.V2PaymentsOffSessionPaymentSucceededEvent)
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
                    "v2.core.account[configuration.storer].capability_status_updated", typeof(
                    Events.V2CoreAccountIncludingConfigurationStorerCapabilityStatusUpdatedEventNotification)
                },
                {
                    "v2.core.account[configuration.storer].updated", typeof(
                    Events.V2CoreAccountIncludingConfigurationStorerUpdatedEventNotification)
                },
                {
                    "v2.core.account[defaults].updated", typeof(
                    Events.V2CoreAccountIncludingDefaultsUpdatedEventNotification)
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
                {
                    "v2.money_management.adjustment.created", typeof(
                    Events.V2MoneyManagementAdjustmentCreatedEventNotification)
                },
                {
                    "v2.money_management.financial_account.created", typeof(
                    Events.V2MoneyManagementFinancialAccountCreatedEventNotification)
                },
                {
                    "v2.money_management.financial_account.updated", typeof(
                    Events.V2MoneyManagementFinancialAccountUpdatedEventNotification)
                },
                {
                    "v2.money_management.financial_address.activated", typeof(
                    Events.V2MoneyManagementFinancialAddressActivatedEventNotification)
                },
                {
                    "v2.money_management.financial_address.failed", typeof(
                    Events.V2MoneyManagementFinancialAddressFailedEventNotification)
                },
                {
                    "v2.money_management.inbound_transfer.available", typeof(
                    Events.V2MoneyManagementInboundTransferAvailableEventNotification)
                },
                {
                    "v2.money_management.inbound_transfer.bank_debit_failed", typeof(
                    Events.V2MoneyManagementInboundTransferBankDebitFailedEventNotification)
                },
                {
                    "v2.money_management.inbound_transfer.bank_debit_processing", typeof(
                    Events.V2MoneyManagementInboundTransferBankDebitProcessingEventNotification)
                },
                {
                    "v2.money_management.inbound_transfer.bank_debit_queued", typeof(
                    Events.V2MoneyManagementInboundTransferBankDebitQueuedEventNotification)
                },
                {
                    "v2.money_management.inbound_transfer.bank_debit_returned", typeof(
                    Events.V2MoneyManagementInboundTransferBankDebitReturnedEventNotification)
                },
                {
                    "v2.money_management.inbound_transfer.bank_debit_succeeded", typeof(
                    Events.V2MoneyManagementInboundTransferBankDebitSucceededEventNotification)
                },
                {
                    "v2.money_management.outbound_payment.canceled", typeof(
                    Events.V2MoneyManagementOutboundPaymentCanceledEventNotification)
                },
                {
                    "v2.money_management.outbound_payment.created", typeof(
                    Events.V2MoneyManagementOutboundPaymentCreatedEventNotification)
                },
                {
                    "v2.money_management.outbound_payment.failed", typeof(
                    Events.V2MoneyManagementOutboundPaymentFailedEventNotification)
                },
                {
                    "v2.money_management.outbound_payment.posted", typeof(
                    Events.V2MoneyManagementOutboundPaymentPostedEventNotification)
                },
                {
                    "v2.money_management.outbound_payment.returned", typeof(
                    Events.V2MoneyManagementOutboundPaymentReturnedEventNotification)
                },
                {
                    "v2.money_management.outbound_payment.updated", typeof(
                    Events.V2MoneyManagementOutboundPaymentUpdatedEventNotification)
                },
                {
                    "v2.money_management.outbound_transfer.canceled", typeof(
                    Events.V2MoneyManagementOutboundTransferCanceledEventNotification)
                },
                {
                    "v2.money_management.outbound_transfer.created", typeof(
                    Events.V2MoneyManagementOutboundTransferCreatedEventNotification)
                },
                {
                    "v2.money_management.outbound_transfer.failed", typeof(
                    Events.V2MoneyManagementOutboundTransferFailedEventNotification)
                },
                {
                    "v2.money_management.outbound_transfer.posted", typeof(
                    Events.V2MoneyManagementOutboundTransferPostedEventNotification)
                },
                {
                    "v2.money_management.outbound_transfer.returned", typeof(
                    Events.V2MoneyManagementOutboundTransferReturnedEventNotification)
                },
                {
                    "v2.money_management.outbound_transfer.updated", typeof(
                    Events.V2MoneyManagementOutboundTransferUpdatedEventNotification)
                },
                {
                    "v2.money_management.payout_method.updated", typeof(
                    Events.V2MoneyManagementPayoutMethodUpdatedEventNotification)
                },
                {
                    "v2.money_management.received_credit.available", typeof(
                    Events.V2MoneyManagementReceivedCreditAvailableEventNotification)
                },
                {
                    "v2.money_management.received_credit.failed", typeof(
                    Events.V2MoneyManagementReceivedCreditFailedEventNotification)
                },
                {
                    "v2.money_management.received_credit.returned", typeof(
                    Events.V2MoneyManagementReceivedCreditReturnedEventNotification)
                },
                {
                    "v2.money_management.received_credit.succeeded", typeof(
                    Events.V2MoneyManagementReceivedCreditSucceededEventNotification)
                },
                {
                    "v2.money_management.received_debit.canceled", typeof(
                    Events.V2MoneyManagementReceivedDebitCanceledEventNotification)
                },
                {
                    "v2.money_management.received_debit.failed", typeof(
                    Events.V2MoneyManagementReceivedDebitFailedEventNotification)
                },
                {
                    "v2.money_management.received_debit.pending", typeof(
                    Events.V2MoneyManagementReceivedDebitPendingEventNotification)
                },
                {
                    "v2.money_management.received_debit.succeeded", typeof(
                    Events.V2MoneyManagementReceivedDebitSucceededEventNotification)
                },
                {
                    "v2.money_management.received_debit.updated", typeof(
                    Events.V2MoneyManagementReceivedDebitUpdatedEventNotification)
                },
                {
                    "v2.money_management.transaction.created", typeof(
                    Events.V2MoneyManagementTransactionCreatedEventNotification)
                },
                {
                    "v2.money_management.transaction.updated", typeof(
                    Events.V2MoneyManagementTransactionUpdatedEventNotification)
                },
                {
                    "v2.payments.off_session_payment.attempt_failed", typeof(
                    Events.V2PaymentsOffSessionPaymentAttemptFailedEventNotification)
                },
                {
                    "v2.payments.off_session_payment.attempt_started", typeof(
                    Events.V2PaymentsOffSessionPaymentAttemptStartedEventNotification)
                },
                {
                    "v2.payments.off_session_payment.authorization_attempt_failed", typeof(
                    Events.V2PaymentsOffSessionPaymentAuthorizationAttemptFailedEventNotification)
                },
                {
                    "v2.payments.off_session_payment.authorization_attempt_started", typeof(
                    Events.V2PaymentsOffSessionPaymentAuthorizationAttemptStartedEventNotification)
                },
                {
                    "v2.payments.off_session_payment.canceled", typeof(
                    Events.V2PaymentsOffSessionPaymentCanceledEventNotification)
                },
                {
                    "v2.payments.off_session_payment.created", typeof(
                    Events.V2PaymentsOffSessionPaymentCreatedEventNotification)
                },
                {
                    "v2.payments.off_session_payment.failed", typeof(
                    Events.V2PaymentsOffSessionPaymentFailedEventNotification)
                },
                {
                    "v2.payments.off_session_payment.requires_capture", typeof(
                    Events.V2PaymentsOffSessionPaymentRequiresCaptureEventNotification)
                },
                {
                    "v2.payments.off_session_payment.succeeded", typeof(
                    Events.V2PaymentsOffSessionPaymentSucceededEventNotification)
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
