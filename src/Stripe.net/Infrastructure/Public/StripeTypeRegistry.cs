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
                { "apps.install", typeof(Apps.Install) },
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
                { "billing.feedback_option", typeof(Billing.FeedbackOption) },
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
                {
                    "financial_connections.authorization", typeof(
                    FinancialConnections.Authorization)
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
                { "product_catalog.trial_offer", typeof(ProductCatalog.TrialOffer) },
                { "product_feature", typeof(ProductFeature) },
                { "promotion_code", typeof(PromotionCode) },
                { "quote", typeof(Quote) },
                { "radar.early_fraud_warning", typeof(Radar.EarlyFraudWarning) },
                { "radar.payment_evaluation", typeof(Radar.PaymentEvaluation) },
                { "radar.value_list", typeof(Radar.ValueList) },
                { "radar.value_list_item", typeof(Radar.ValueListItem) },
                { "refund", typeof(Refund) },
                { "reporting.report_run", typeof(Reporting.ReportRun) },
                { "reporting.report_type", typeof(Reporting.ReportType) },
                { "reserve.hold", typeof(Reserve.Hold) },
                { "reserve.plan", typeof(Reserve.Plan) },
                { "reserve.release", typeof(Reserve.Release) },
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
                { "tax.location", typeof(Tax.Location) },
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
                { "three_d_secure.authentication", typeof(ThreeDSecure.Authentication) },
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
                {
                    "v2.commerce.product_catalog_import", typeof(
                    V2.Commerce.ProductCatalogImport)
                },
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
                    "v1.account.application.authorized", typeof(
                    Events.V1AccountApplicationAuthorizedEvent)
                },
                {
                    "v1.account.application.deauthorized", typeof(
                    Events.V1AccountApplicationDeauthorizedEvent)
                },
                {
                    "v1.account.external_account.created", typeof(
                    Events.V1AccountExternalAccountCreatedEvent)
                },
                {
                    "v1.account.external_account.deleted", typeof(
                    Events.V1AccountExternalAccountDeletedEvent)
                },
                {
                    "v1.account.external_account.updated", typeof(
                    Events.V1AccountExternalAccountUpdatedEvent)
                },
                { "v1.account.updated", typeof(Events.V1AccountUpdatedEvent) },
                { "v1.application_fee.created", typeof(Events.V1ApplicationFeeCreatedEvent) },
                {
                    "v1.application_fee.refund.updated", typeof(
                    Events.V1ApplicationFeeRefundUpdatedEvent)
                },
                { "v1.application_fee.refunded", typeof(Events.V1ApplicationFeeRefundedEvent) },
                { "v1.balance.available", typeof(Events.V1BalanceAvailableEvent) },
                { "v1.balance_settings.updated", typeof(Events.V1BalanceSettingsUpdatedEvent) },
                { "v1.billing.alert.triggered", typeof(Events.V1BillingAlertTriggeredEvent) },
                {
                    "v1.billing.credit_balance_transaction.created", typeof(
                    Events.V1BillingCreditBalanceTransactionCreatedEvent)
                },
                {
                    "v1.billing.credit_grant.created", typeof(
                    Events.V1BillingCreditGrantCreatedEvent)
                },
                {
                    "v1.billing.credit_grant.updated", typeof(
                    Events.V1BillingCreditGrantUpdatedEvent)
                },
                { "v1.billing.meter.created", typeof(Events.V1BillingMeterCreatedEvent) },
                {
                    "v1.billing.meter.deactivated", typeof(
                    Events.V1BillingMeterDeactivatedEvent)
                },
                {
                    "v1.billing.meter.error_report_triggered", typeof(
                    Events.V1BillingMeterErrorReportTriggeredEvent)
                },
                {
                    "v1.billing.meter.no_meter_found", typeof(
                    Events.V1BillingMeterNoMeterFoundEvent)
                },
                {
                    "v1.billing.meter.reactivated", typeof(
                    Events.V1BillingMeterReactivatedEvent)
                },
                { "v1.billing.meter.updated", typeof(Events.V1BillingMeterUpdatedEvent) },
                {
                    "v1.billing_portal.configuration.created", typeof(
                    Events.V1BillingPortalConfigurationCreatedEvent)
                },
                {
                    "v1.billing_portal.configuration.updated", typeof(
                    Events.V1BillingPortalConfigurationUpdatedEvent)
                },
                {
                    "v1.billing_portal.session.created", typeof(
                    Events.V1BillingPortalSessionCreatedEvent)
                },
                { "v1.capability.updated", typeof(Events.V1CapabilityUpdatedEvent) },
                {
                    "v1.cash_balance.funds_available", typeof(
                    Events.V1CashBalanceFundsAvailableEvent)
                },
                { "v1.charge.captured", typeof(Events.V1ChargeCapturedEvent) },
                { "v1.charge.dispute.closed", typeof(Events.V1ChargeDisputeClosedEvent) },
                { "v1.charge.dispute.created", typeof(Events.V1ChargeDisputeCreatedEvent) },
                {
                    "v1.charge.dispute.funds_reinstated", typeof(
                    Events.V1ChargeDisputeFundsReinstatedEvent)
                },
                {
                    "v1.charge.dispute.funds_withdrawn", typeof(
                    Events.V1ChargeDisputeFundsWithdrawnEvent)
                },
                { "v1.charge.dispute.updated", typeof(Events.V1ChargeDisputeUpdatedEvent) },
                { "v1.charge.expired", typeof(Events.V1ChargeExpiredEvent) },
                { "v1.charge.failed", typeof(Events.V1ChargeFailedEvent) },
                { "v1.charge.pending", typeof(Events.V1ChargePendingEvent) },
                { "v1.charge.refund.updated", typeof(Events.V1ChargeRefundUpdatedEvent) },
                { "v1.charge.refunded", typeof(Events.V1ChargeRefundedEvent) },
                { "v1.charge.succeeded", typeof(Events.V1ChargeSucceededEvent) },
                { "v1.charge.updated", typeof(Events.V1ChargeUpdatedEvent) },
                {
                    "v1.checkout.session.async_payment_failed", typeof(
                    Events.V1CheckoutSessionAsyncPaymentFailedEvent)
                },
                {
                    "v1.checkout.session.async_payment_succeeded", typeof(
                    Events.V1CheckoutSessionAsyncPaymentSucceededEvent)
                },
                {
                    "v1.checkout.session.completed", typeof(
                    Events.V1CheckoutSessionCompletedEvent)
                },
                { "v1.checkout.session.expired", typeof(Events.V1CheckoutSessionExpiredEvent) },
                { "v1.climate.order.canceled", typeof(Events.V1ClimateOrderCanceledEvent) },
                { "v1.climate.order.created", typeof(Events.V1ClimateOrderCreatedEvent) },
                { "v1.climate.order.delayed", typeof(Events.V1ClimateOrderDelayedEvent) },
                { "v1.climate.order.delivered", typeof(Events.V1ClimateOrderDeliveredEvent) },
                {
                    "v1.climate.order.product_substituted", typeof(
                    Events.V1ClimateOrderProductSubstitutedEvent)
                },
                { "v1.climate.product.created", typeof(Events.V1ClimateProductCreatedEvent) },
                {
                    "v1.climate.product.pricing_updated", typeof(
                    Events.V1ClimateProductPricingUpdatedEvent)
                },
                { "v1.coupon.created", typeof(Events.V1CouponCreatedEvent) },
                { "v1.coupon.deleted", typeof(Events.V1CouponDeletedEvent) },
                { "v1.coupon.updated", typeof(Events.V1CouponUpdatedEvent) },
                { "v1.credit_note.created", typeof(Events.V1CreditNoteCreatedEvent) },
                { "v1.credit_note.updated", typeof(Events.V1CreditNoteUpdatedEvent) },
                { "v1.credit_note.voided", typeof(Events.V1CreditNoteVoidedEvent) },
                { "v1.customer.created", typeof(Events.V1CustomerCreatedEvent) },
                { "v1.customer.deleted", typeof(Events.V1CustomerDeletedEvent) },
                {
                    "v1.customer.discount.created", typeof(
                    Events.V1CustomerDiscountCreatedEvent)
                },
                {
                    "v1.customer.discount.deleted", typeof(
                    Events.V1CustomerDiscountDeletedEvent)
                },
                {
                    "v1.customer.discount.updated", typeof(
                    Events.V1CustomerDiscountUpdatedEvent)
                },
                {
                    "v1.customer.subscription.created", typeof(
                    Events.V1CustomerSubscriptionCreatedEvent)
                },
                {
                    "v1.customer.subscription.deleted", typeof(
                    Events.V1CustomerSubscriptionDeletedEvent)
                },
                {
                    "v1.customer.subscription.paused", typeof(
                    Events.V1CustomerSubscriptionPausedEvent)
                },
                {
                    "v1.customer.subscription.pending_update_applied", typeof(
                    Events.V1CustomerSubscriptionPendingUpdateAppliedEvent)
                },
                {
                    "v1.customer.subscription.pending_update_expired", typeof(
                    Events.V1CustomerSubscriptionPendingUpdateExpiredEvent)
                },
                {
                    "v1.customer.subscription.resumed", typeof(
                    Events.V1CustomerSubscriptionResumedEvent)
                },
                {
                    "v1.customer.subscription.trial_will_end", typeof(
                    Events.V1CustomerSubscriptionTrialWillEndEvent)
                },
                {
                    "v1.customer.subscription.updated", typeof(
                    Events.V1CustomerSubscriptionUpdatedEvent)
                },
                { "v1.customer.tax_id.created", typeof(Events.V1CustomerTaxIdCreatedEvent) },
                { "v1.customer.tax_id.deleted", typeof(Events.V1CustomerTaxIdDeletedEvent) },
                { "v1.customer.tax_id.updated", typeof(Events.V1CustomerTaxIdUpdatedEvent) },
                { "v1.customer.updated", typeof(Events.V1CustomerUpdatedEvent) },
                {
                    "v1.customer_cash_balance_transaction.created", typeof(
                    Events.V1CustomerCashBalanceTransactionCreatedEvent)
                },
                {
                    "v1.entitlements.active_entitlement_summary.updated", typeof(
                    Events.V1EntitlementsActiveEntitlementSummaryUpdatedEvent)
                },
                { "v1.file.created", typeof(Events.V1FileCreatedEvent) },
                {
                    "v1.financial_connections.account.account_numbers_updated", typeof(
                    Events.V1FinancialConnectionsAccountAccountNumbersUpdatedEvent)
                },
                {
                    "v1.financial_connections.account.created", typeof(
                    Events.V1FinancialConnectionsAccountCreatedEvent)
                },
                {
                    "v1.financial_connections.account.deactivated", typeof(
                    Events.V1FinancialConnectionsAccountDeactivatedEvent)
                },
                {
                    "v1.financial_connections.account.disconnected", typeof(
                    Events.V1FinancialConnectionsAccountDisconnectedEvent)
                },
                {
                    "v1.financial_connections.account.expected_deactivation_date_updated", typeof(
                    Events.V1FinancialConnectionsAccountExpectedDeactivationDateUpdatedEvent)
                },
                {
                    "v1.financial_connections.account.reactivated", typeof(
                    Events.V1FinancialConnectionsAccountReactivatedEvent)
                },
                {
                    "v1.financial_connections.account.refreshed_balance", typeof(
                    Events.V1FinancialConnectionsAccountRefreshedBalanceEvent)
                },
                {
                    "v1.financial_connections.account.refreshed_ownership", typeof(
                    Events.V1FinancialConnectionsAccountRefreshedOwnershipEvent)
                },
                {
                    "v1.financial_connections.account.refreshed_transactions", typeof(
                    Events.V1FinancialConnectionsAccountRefreshedTransactionsEvent)
                },
                {
                    "v1.financial_connections.account.supported_payment_method_types_updated", typeof(
                    Events.V1FinancialConnectionsAccountSupportedPaymentMethodTypesUpdatedEvent)
                },
                {
                    "v1.financial_connections.account.upcoming_account_number_expiry", typeof(
                    Events.V1FinancialConnectionsAccountUpcomingAccountNumberExpiryEvent)
                },
                {
                    "v1.financial_connections.account.upcoming_deactivation", typeof(
                    Events.V1FinancialConnectionsAccountUpcomingDeactivationEvent)
                },
                {
                    "v1.identity.verification_session.canceled", typeof(
                    Events.V1IdentityVerificationSessionCanceledEvent)
                },
                {
                    "v1.identity.verification_session.created", typeof(
                    Events.V1IdentityVerificationSessionCreatedEvent)
                },
                {
                    "v1.identity.verification_session.processing", typeof(
                    Events.V1IdentityVerificationSessionProcessingEvent)
                },
                {
                    "v1.identity.verification_session.redacted", typeof(
                    Events.V1IdentityVerificationSessionRedactedEvent)
                },
                {
                    "v1.identity.verification_session.requires_input", typeof(
                    Events.V1IdentityVerificationSessionRequiresInputEvent)
                },
                {
                    "v1.identity.verification_session.verified", typeof(
                    Events.V1IdentityVerificationSessionVerifiedEvent)
                },
                { "v1.invoice.created", typeof(Events.V1InvoiceCreatedEvent) },
                { "v1.invoice.deleted", typeof(Events.V1InvoiceDeletedEvent) },
                {
                    "v1.invoice.finalization_failed", typeof(
                    Events.V1InvoiceFinalizationFailedEvent)
                },
                { "v1.invoice.finalized", typeof(Events.V1InvoiceFinalizedEvent) },
                {
                    "v1.invoice.marked_uncollectible", typeof(
                    Events.V1InvoiceMarkedUncollectibleEvent)
                },
                { "v1.invoice.overdue", typeof(Events.V1InvoiceOverdueEvent) },
                { "v1.invoice.overpaid", typeof(Events.V1InvoiceOverpaidEvent) },
                { "v1.invoice.paid", typeof(Events.V1InvoicePaidEvent) },
                {
                    "v1.invoice.payment_action_required", typeof(
                    Events.V1InvoicePaymentActionRequiredEvent)
                },
                {
                    "v1.invoice.payment_attempt_required", typeof(
                    Events.V1InvoicePaymentAttemptRequiredEvent)
                },
                { "v1.invoice.payment_failed", typeof(Events.V1InvoicePaymentFailedEvent) },
                {
                    "v1.invoice.payment_succeeded", typeof(
                    Events.V1InvoicePaymentSucceededEvent)
                },
                { "v1.invoice.sent", typeof(Events.V1InvoiceSentEvent) },
                { "v1.invoice.upcoming", typeof(Events.V1InvoiceUpcomingEvent) },
                { "v1.invoice.updated", typeof(Events.V1InvoiceUpdatedEvent) },
                { "v1.invoice.voided", typeof(Events.V1InvoiceVoidedEvent) },
                { "v1.invoice.will_be_due", typeof(Events.V1InvoiceWillBeDueEvent) },
                { "v1.invoice_payment.paid", typeof(Events.V1InvoicePaymentPaidEvent) },
                { "v1.invoiceitem.created", typeof(Events.V1InvoiceitemCreatedEvent) },
                { "v1.invoiceitem.deleted", typeof(Events.V1InvoiceitemDeletedEvent) },
                {
                    "v1.issuing_authorization.created", typeof(
                    Events.V1IssuingAuthorizationCreatedEvent)
                },
                {
                    "v1.issuing_authorization.request", typeof(
                    Events.V1IssuingAuthorizationRequestEvent)
                },
                {
                    "v1.issuing_authorization.updated", typeof(
                    Events.V1IssuingAuthorizationUpdatedEvent)
                },
                { "v1.issuing_card.created", typeof(Events.V1IssuingCardCreatedEvent) },
                { "v1.issuing_card.updated", typeof(Events.V1IssuingCardUpdatedEvent) },
                {
                    "v1.issuing_cardholder.created", typeof(
                    Events.V1IssuingCardholderCreatedEvent)
                },
                {
                    "v1.issuing_cardholder.updated", typeof(
                    Events.V1IssuingCardholderUpdatedEvent)
                },
                { "v1.issuing_dispute.closed", typeof(Events.V1IssuingDisputeClosedEvent) },
                { "v1.issuing_dispute.created", typeof(Events.V1IssuingDisputeCreatedEvent) },
                {
                    "v1.issuing_dispute.funds_reinstated", typeof(
                    Events.V1IssuingDisputeFundsReinstatedEvent)
                },
                {
                    "v1.issuing_dispute.funds_rescinded", typeof(
                    Events.V1IssuingDisputeFundsRescindedEvent)
                },
                {
                    "v1.issuing_dispute.submitted", typeof(
                    Events.V1IssuingDisputeSubmittedEvent)
                },
                { "v1.issuing_dispute.updated", typeof(Events.V1IssuingDisputeUpdatedEvent) },
                {
                    "v1.issuing_personalization_design.activated", typeof(
                    Events.V1IssuingPersonalizationDesignActivatedEvent)
                },
                {
                    "v1.issuing_personalization_design.deactivated", typeof(
                    Events.V1IssuingPersonalizationDesignDeactivatedEvent)
                },
                {
                    "v1.issuing_personalization_design.rejected", typeof(
                    Events.V1IssuingPersonalizationDesignRejectedEvent)
                },
                {
                    "v1.issuing_personalization_design.updated", typeof(
                    Events.V1IssuingPersonalizationDesignUpdatedEvent)
                },
                { "v1.issuing_token.created", typeof(Events.V1IssuingTokenCreatedEvent) },
                { "v1.issuing_token.updated", typeof(Events.V1IssuingTokenUpdatedEvent) },
                {
                    "v1.issuing_transaction.created", typeof(
                    Events.V1IssuingTransactionCreatedEvent)
                },
                {
                    "v1.issuing_transaction.purchase_details_receipt_updated", typeof(
                    Events.V1IssuingTransactionPurchaseDetailsReceiptUpdatedEvent)
                },
                {
                    "v1.issuing_transaction.updated", typeof(
                    Events.V1IssuingTransactionUpdatedEvent)
                },
                { "v1.mandate.updated", typeof(Events.V1MandateUpdatedEvent) },
                {
                    "v1.payment_intent.amount_capturable_updated", typeof(
                    Events.V1PaymentIntentAmountCapturableUpdatedEvent)
                },
                { "v1.payment_intent.canceled", typeof(Events.V1PaymentIntentCanceledEvent) },
                { "v1.payment_intent.created", typeof(Events.V1PaymentIntentCreatedEvent) },
                {
                    "v1.payment_intent.partially_funded", typeof(
                    Events.V1PaymentIntentPartiallyFundedEvent)
                },
                {
                    "v1.payment_intent.payment_failed", typeof(
                    Events.V1PaymentIntentPaymentFailedEvent)
                },
                {
                    "v1.payment_intent.processing", typeof(
                    Events.V1PaymentIntentProcessingEvent)
                },
                {
                    "v1.payment_intent.requires_action", typeof(
                    Events.V1PaymentIntentRequiresActionEvent)
                },
                { "v1.payment_intent.succeeded", typeof(Events.V1PaymentIntentSucceededEvent) },
                { "v1.payment_link.created", typeof(Events.V1PaymentLinkCreatedEvent) },
                { "v1.payment_link.updated", typeof(Events.V1PaymentLinkUpdatedEvent) },
                { "v1.payment_method.attached", typeof(Events.V1PaymentMethodAttachedEvent) },
                {
                    "v1.payment_method.automatically_updated", typeof(
                    Events.V1PaymentMethodAutomaticallyUpdatedEvent)
                },
                { "v1.payment_method.detached", typeof(Events.V1PaymentMethodDetachedEvent) },
                { "v1.payment_method.updated", typeof(Events.V1PaymentMethodUpdatedEvent) },
                { "v1.payout.canceled", typeof(Events.V1PayoutCanceledEvent) },
                { "v1.payout.created", typeof(Events.V1PayoutCreatedEvent) },
                { "v1.payout.failed", typeof(Events.V1PayoutFailedEvent) },
                { "v1.payout.paid", typeof(Events.V1PayoutPaidEvent) },
                {
                    "v1.payout.reconciliation_completed", typeof(
                    Events.V1PayoutReconciliationCompletedEvent)
                },
                { "v1.payout.updated", typeof(Events.V1PayoutUpdatedEvent) },
                { "v1.person.created", typeof(Events.V1PersonCreatedEvent) },
                { "v1.person.deleted", typeof(Events.V1PersonDeletedEvent) },
                { "v1.person.updated", typeof(Events.V1PersonUpdatedEvent) },
                { "v1.plan.created", typeof(Events.V1PlanCreatedEvent) },
                { "v1.plan.deleted", typeof(Events.V1PlanDeletedEvent) },
                { "v1.plan.updated", typeof(Events.V1PlanUpdatedEvent) },
                { "v1.price.created", typeof(Events.V1PriceCreatedEvent) },
                { "v1.price.deleted", typeof(Events.V1PriceDeletedEvent) },
                { "v1.price.updated", typeof(Events.V1PriceUpdatedEvent) },
                { "v1.product.created", typeof(Events.V1ProductCreatedEvent) },
                { "v1.product.deleted", typeof(Events.V1ProductDeletedEvent) },
                { "v1.product.updated", typeof(Events.V1ProductUpdatedEvent) },
                { "v1.promotion_code.created", typeof(Events.V1PromotionCodeCreatedEvent) },
                { "v1.promotion_code.updated", typeof(Events.V1PromotionCodeUpdatedEvent) },
                { "v1.quote.accepted", typeof(Events.V1QuoteAcceptedEvent) },
                { "v1.quote.canceled", typeof(Events.V1QuoteCanceledEvent) },
                { "v1.quote.created", typeof(Events.V1QuoteCreatedEvent) },
                { "v1.quote.finalized", typeof(Events.V1QuoteFinalizedEvent) },
                {
                    "v1.radar.early_fraud_warning.created", typeof(
                    Events.V1RadarEarlyFraudWarningCreatedEvent)
                },
                {
                    "v1.radar.early_fraud_warning.updated", typeof(
                    Events.V1RadarEarlyFraudWarningUpdatedEvent)
                },
                { "v1.refund.created", typeof(Events.V1RefundCreatedEvent) },
                { "v1.refund.failed", typeof(Events.V1RefundFailedEvent) },
                { "v1.refund.updated", typeof(Events.V1RefundUpdatedEvent) },
                { "v1.review.closed", typeof(Events.V1ReviewClosedEvent) },
                { "v1.review.opened", typeof(Events.V1ReviewOpenedEvent) },
                { "v1.setup_intent.canceled", typeof(Events.V1SetupIntentCanceledEvent) },
                { "v1.setup_intent.created", typeof(Events.V1SetupIntentCreatedEvent) },
                {
                    "v1.setup_intent.requires_action", typeof(
                    Events.V1SetupIntentRequiresActionEvent)
                },
                { "v1.setup_intent.setup_failed", typeof(Events.V1SetupIntentSetupFailedEvent) },
                { "v1.setup_intent.succeeded", typeof(Events.V1SetupIntentSucceededEvent) },
                {
                    "v1.sigma.scheduled_query_run.created", typeof(
                    Events.V1SigmaScheduledQueryRunCreatedEvent)
                },
                { "v1.source.canceled", typeof(Events.V1SourceCanceledEvent) },
                { "v1.source.chargeable", typeof(Events.V1SourceChargeableEvent) },
                { "v1.source.failed", typeof(Events.V1SourceFailedEvent) },
                {
                    "v1.source.refund_attributes_required", typeof(
                    Events.V1SourceRefundAttributesRequiredEvent)
                },
                {
                    "v1.subscription_schedule.aborted", typeof(
                    Events.V1SubscriptionScheduleAbortedEvent)
                },
                {
                    "v1.subscription_schedule.canceled", typeof(
                    Events.V1SubscriptionScheduleCanceledEvent)
                },
                {
                    "v1.subscription_schedule.completed", typeof(
                    Events.V1SubscriptionScheduleCompletedEvent)
                },
                {
                    "v1.subscription_schedule.created", typeof(
                    Events.V1SubscriptionScheduleCreatedEvent)
                },
                {
                    "v1.subscription_schedule.expiring", typeof(
                    Events.V1SubscriptionScheduleExpiringEvent)
                },
                {
                    "v1.subscription_schedule.released", typeof(
                    Events.V1SubscriptionScheduleReleasedEvent)
                },
                {
                    "v1.subscription_schedule.updated", typeof(
                    Events.V1SubscriptionScheduleUpdatedEvent)
                },
                { "v1.tax.settings.updated", typeof(Events.V1TaxSettingsUpdatedEvent) },
                { "v1.tax_rate.created", typeof(Events.V1TaxRateCreatedEvent) },
                { "v1.tax_rate.updated", typeof(Events.V1TaxRateUpdatedEvent) },
                {
                    "v1.terminal.reader.action_failed", typeof(
                    Events.V1TerminalReaderActionFailedEvent)
                },
                {
                    "v1.terminal.reader.action_succeeded", typeof(
                    Events.V1TerminalReaderActionSucceededEvent)
                },
                {
                    "v1.terminal.reader.action_updated", typeof(
                    Events.V1TerminalReaderActionUpdatedEvent)
                },
                {
                    "v1.test_helpers.test_clock.advancing", typeof(
                    Events.V1TestHelpersTestClockAdvancingEvent)
                },
                {
                    "v1.test_helpers.test_clock.created", typeof(
                    Events.V1TestHelpersTestClockCreatedEvent)
                },
                {
                    "v1.test_helpers.test_clock.deleted", typeof(
                    Events.V1TestHelpersTestClockDeletedEvent)
                },
                {
                    "v1.test_helpers.test_clock.internal_failure", typeof(
                    Events.V1TestHelpersTestClockInternalFailureEvent)
                },
                {
                    "v1.test_helpers.test_clock.ready", typeof(
                    Events.V1TestHelpersTestClockReadyEvent)
                },
                { "v1.topup.canceled", typeof(Events.V1TopupCanceledEvent) },
                { "v1.topup.created", typeof(Events.V1TopupCreatedEvent) },
                { "v1.topup.failed", typeof(Events.V1TopupFailedEvent) },
                { "v1.topup.reversed", typeof(Events.V1TopupReversedEvent) },
                { "v1.topup.succeeded", typeof(Events.V1TopupSucceededEvent) },
                { "v1.transfer.created", typeof(Events.V1TransferCreatedEvent) },
                { "v1.transfer.reversed", typeof(Events.V1TransferReversedEvent) },
                { "v1.transfer.updated", typeof(Events.V1TransferUpdatedEvent) },
                {
                    "v2.commerce.product_catalog.imports.failed", typeof(
                    Events.V2CommerceProductCatalogImportsFailedEvent)
                },
                {
                    "v2.commerce.product_catalog.imports.processing", typeof(
                    Events.V2CommerceProductCatalogImportsProcessingEvent)
                },
                {
                    "v2.commerce.product_catalog.imports.succeeded", typeof(
                    Events.V2CommerceProductCatalogImportsSucceededEvent)
                },
                {
                    "v2.commerce.product_catalog.imports.succeeded_with_errors", typeof(
                    Events.V2CommerceProductCatalogImportsSucceededWithErrorsEvent)
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
                    "v1.account.application.authorized", typeof(
                    Events.V1AccountApplicationAuthorizedEventNotification)
                },
                {
                    "v1.account.application.deauthorized", typeof(
                    Events.V1AccountApplicationDeauthorizedEventNotification)
                },
                {
                    "v1.account.external_account.created", typeof(
                    Events.V1AccountExternalAccountCreatedEventNotification)
                },
                {
                    "v1.account.external_account.deleted", typeof(
                    Events.V1AccountExternalAccountDeletedEventNotification)
                },
                {
                    "v1.account.external_account.updated", typeof(
                    Events.V1AccountExternalAccountUpdatedEventNotification)
                },
                { "v1.account.updated", typeof(Events.V1AccountUpdatedEventNotification) },
                {
                    "v1.application_fee.created", typeof(
                    Events.V1ApplicationFeeCreatedEventNotification)
                },
                {
                    "v1.application_fee.refund.updated", typeof(
                    Events.V1ApplicationFeeRefundUpdatedEventNotification)
                },
                {
                    "v1.application_fee.refunded", typeof(
                    Events.V1ApplicationFeeRefundedEventNotification)
                },
                { "v1.balance.available", typeof(Events.V1BalanceAvailableEventNotification) },
                {
                    "v1.balance_settings.updated", typeof(
                    Events.V1BalanceSettingsUpdatedEventNotification)
                },
                {
                    "v1.billing.alert.triggered", typeof(
                    Events.V1BillingAlertTriggeredEventNotification)
                },
                {
                    "v1.billing.credit_balance_transaction.created", typeof(
                    Events.V1BillingCreditBalanceTransactionCreatedEventNotification)
                },
                {
                    "v1.billing.credit_grant.created", typeof(
                    Events.V1BillingCreditGrantCreatedEventNotification)
                },
                {
                    "v1.billing.credit_grant.updated", typeof(
                    Events.V1BillingCreditGrantUpdatedEventNotification)
                },
                {
                    "v1.billing.meter.created", typeof(
                    Events.V1BillingMeterCreatedEventNotification)
                },
                {
                    "v1.billing.meter.deactivated", typeof(
                    Events.V1BillingMeterDeactivatedEventNotification)
                },
                {
                    "v1.billing.meter.error_report_triggered", typeof(
                    Events.V1BillingMeterErrorReportTriggeredEventNotification)
                },
                {
                    "v1.billing.meter.no_meter_found", typeof(
                    Events.V1BillingMeterNoMeterFoundEventNotification)
                },
                {
                    "v1.billing.meter.reactivated", typeof(
                    Events.V1BillingMeterReactivatedEventNotification)
                },
                {
                    "v1.billing.meter.updated", typeof(
                    Events.V1BillingMeterUpdatedEventNotification)
                },
                {
                    "v1.billing_portal.configuration.created", typeof(
                    Events.V1BillingPortalConfigurationCreatedEventNotification)
                },
                {
                    "v1.billing_portal.configuration.updated", typeof(
                    Events.V1BillingPortalConfigurationUpdatedEventNotification)
                },
                {
                    "v1.billing_portal.session.created", typeof(
                    Events.V1BillingPortalSessionCreatedEventNotification)
                },
                { "v1.capability.updated", typeof(Events.V1CapabilityUpdatedEventNotification) },
                {
                    "v1.cash_balance.funds_available", typeof(
                    Events.V1CashBalanceFundsAvailableEventNotification)
                },
                { "v1.charge.captured", typeof(Events.V1ChargeCapturedEventNotification) },
                {
                    "v1.charge.dispute.closed", typeof(
                    Events.V1ChargeDisputeClosedEventNotification)
                },
                {
                    "v1.charge.dispute.created", typeof(
                    Events.V1ChargeDisputeCreatedEventNotification)
                },
                {
                    "v1.charge.dispute.funds_reinstated", typeof(
                    Events.V1ChargeDisputeFundsReinstatedEventNotification)
                },
                {
                    "v1.charge.dispute.funds_withdrawn", typeof(
                    Events.V1ChargeDisputeFundsWithdrawnEventNotification)
                },
                {
                    "v1.charge.dispute.updated", typeof(
                    Events.V1ChargeDisputeUpdatedEventNotification)
                },
                { "v1.charge.expired", typeof(Events.V1ChargeExpiredEventNotification) },
                { "v1.charge.failed", typeof(Events.V1ChargeFailedEventNotification) },
                { "v1.charge.pending", typeof(Events.V1ChargePendingEventNotification) },
                {
                    "v1.charge.refund.updated", typeof(
                    Events.V1ChargeRefundUpdatedEventNotification)
                },
                { "v1.charge.refunded", typeof(Events.V1ChargeRefundedEventNotification) },
                { "v1.charge.succeeded", typeof(Events.V1ChargeSucceededEventNotification) },
                { "v1.charge.updated", typeof(Events.V1ChargeUpdatedEventNotification) },
                {
                    "v1.checkout.session.async_payment_failed", typeof(
                    Events.V1CheckoutSessionAsyncPaymentFailedEventNotification)
                },
                {
                    "v1.checkout.session.async_payment_succeeded", typeof(
                    Events.V1CheckoutSessionAsyncPaymentSucceededEventNotification)
                },
                {
                    "v1.checkout.session.completed", typeof(
                    Events.V1CheckoutSessionCompletedEventNotification)
                },
                {
                    "v1.checkout.session.expired", typeof(
                    Events.V1CheckoutSessionExpiredEventNotification)
                },
                {
                    "v1.climate.order.canceled", typeof(
                    Events.V1ClimateOrderCanceledEventNotification)
                },
                {
                    "v1.climate.order.created", typeof(
                    Events.V1ClimateOrderCreatedEventNotification)
                },
                {
                    "v1.climate.order.delayed", typeof(
                    Events.V1ClimateOrderDelayedEventNotification)
                },
                {
                    "v1.climate.order.delivered", typeof(
                    Events.V1ClimateOrderDeliveredEventNotification)
                },
                {
                    "v1.climate.order.product_substituted", typeof(
                    Events.V1ClimateOrderProductSubstitutedEventNotification)
                },
                {
                    "v1.climate.product.created", typeof(
                    Events.V1ClimateProductCreatedEventNotification)
                },
                {
                    "v1.climate.product.pricing_updated", typeof(
                    Events.V1ClimateProductPricingUpdatedEventNotification)
                },
                { "v1.coupon.created", typeof(Events.V1CouponCreatedEventNotification) },
                { "v1.coupon.deleted", typeof(Events.V1CouponDeletedEventNotification) },
                { "v1.coupon.updated", typeof(Events.V1CouponUpdatedEventNotification) },
                {
                    "v1.credit_note.created", typeof(
                    Events.V1CreditNoteCreatedEventNotification)
                },
                {
                    "v1.credit_note.updated", typeof(
                    Events.V1CreditNoteUpdatedEventNotification)
                },
                { "v1.credit_note.voided", typeof(Events.V1CreditNoteVoidedEventNotification) },
                { "v1.customer.created", typeof(Events.V1CustomerCreatedEventNotification) },
                { "v1.customer.deleted", typeof(Events.V1CustomerDeletedEventNotification) },
                {
                    "v1.customer.discount.created", typeof(
                    Events.V1CustomerDiscountCreatedEventNotification)
                },
                {
                    "v1.customer.discount.deleted", typeof(
                    Events.V1CustomerDiscountDeletedEventNotification)
                },
                {
                    "v1.customer.discount.updated", typeof(
                    Events.V1CustomerDiscountUpdatedEventNotification)
                },
                {
                    "v1.customer.subscription.created", typeof(
                    Events.V1CustomerSubscriptionCreatedEventNotification)
                },
                {
                    "v1.customer.subscription.deleted", typeof(
                    Events.V1CustomerSubscriptionDeletedEventNotification)
                },
                {
                    "v1.customer.subscription.paused", typeof(
                    Events.V1CustomerSubscriptionPausedEventNotification)
                },
                {
                    "v1.customer.subscription.pending_update_applied", typeof(
                    Events.V1CustomerSubscriptionPendingUpdateAppliedEventNotification)
                },
                {
                    "v1.customer.subscription.pending_update_expired", typeof(
                    Events.V1CustomerSubscriptionPendingUpdateExpiredEventNotification)
                },
                {
                    "v1.customer.subscription.resumed", typeof(
                    Events.V1CustomerSubscriptionResumedEventNotification)
                },
                {
                    "v1.customer.subscription.trial_will_end", typeof(
                    Events.V1CustomerSubscriptionTrialWillEndEventNotification)
                },
                {
                    "v1.customer.subscription.updated", typeof(
                    Events.V1CustomerSubscriptionUpdatedEventNotification)
                },
                {
                    "v1.customer.tax_id.created", typeof(
                    Events.V1CustomerTaxIdCreatedEventNotification)
                },
                {
                    "v1.customer.tax_id.deleted", typeof(
                    Events.V1CustomerTaxIdDeletedEventNotification)
                },
                {
                    "v1.customer.tax_id.updated", typeof(
                    Events.V1CustomerTaxIdUpdatedEventNotification)
                },
                { "v1.customer.updated", typeof(Events.V1CustomerUpdatedEventNotification) },
                {
                    "v1.customer_cash_balance_transaction.created", typeof(
                    Events.V1CustomerCashBalanceTransactionCreatedEventNotification)
                },
                {
                    "v1.entitlements.active_entitlement_summary.updated", typeof(
                    Events.V1EntitlementsActiveEntitlementSummaryUpdatedEventNotification)
                },
                { "v1.file.created", typeof(Events.V1FileCreatedEventNotification) },
                {
                    "v1.financial_connections.account.account_numbers_updated", typeof(
                    Events.V1FinancialConnectionsAccountAccountNumbersUpdatedEventNotification)
                },
                {
                    "v1.financial_connections.account.created", typeof(
                    Events.V1FinancialConnectionsAccountCreatedEventNotification)
                },
                {
                    "v1.financial_connections.account.deactivated", typeof(
                    Events.V1FinancialConnectionsAccountDeactivatedEventNotification)
                },
                {
                    "v1.financial_connections.account.disconnected", typeof(
                    Events.V1FinancialConnectionsAccountDisconnectedEventNotification)
                },
                {
                    "v1.financial_connections.account.expected_deactivation_date_updated", typeof(
                    Events.V1FinancialConnectionsAccountExpectedDeactivationDateUpdatedEventNotification)
                },
                {
                    "v1.financial_connections.account.reactivated", typeof(
                    Events.V1FinancialConnectionsAccountReactivatedEventNotification)
                },
                {
                    "v1.financial_connections.account.refreshed_balance", typeof(
                    Events.V1FinancialConnectionsAccountRefreshedBalanceEventNotification)
                },
                {
                    "v1.financial_connections.account.refreshed_ownership", typeof(
                    Events.V1FinancialConnectionsAccountRefreshedOwnershipEventNotification)
                },
                {
                    "v1.financial_connections.account.refreshed_transactions", typeof(
                    Events.V1FinancialConnectionsAccountRefreshedTransactionsEventNotification)
                },
                {
                    "v1.financial_connections.account.supported_payment_method_types_updated", typeof(
                    Events.V1FinancialConnectionsAccountSupportedPaymentMethodTypesUpdatedEventNotification)
                },
                {
                    "v1.financial_connections.account.upcoming_account_number_expiry", typeof(
                    Events.V1FinancialConnectionsAccountUpcomingAccountNumberExpiryEventNotification)
                },
                {
                    "v1.financial_connections.account.upcoming_deactivation", typeof(
                    Events.V1FinancialConnectionsAccountUpcomingDeactivationEventNotification)
                },
                {
                    "v1.identity.verification_session.canceled", typeof(
                    Events.V1IdentityVerificationSessionCanceledEventNotification)
                },
                {
                    "v1.identity.verification_session.created", typeof(
                    Events.V1IdentityVerificationSessionCreatedEventNotification)
                },
                {
                    "v1.identity.verification_session.processing", typeof(
                    Events.V1IdentityVerificationSessionProcessingEventNotification)
                },
                {
                    "v1.identity.verification_session.redacted", typeof(
                    Events.V1IdentityVerificationSessionRedactedEventNotification)
                },
                {
                    "v1.identity.verification_session.requires_input", typeof(
                    Events.V1IdentityVerificationSessionRequiresInputEventNotification)
                },
                {
                    "v1.identity.verification_session.verified", typeof(
                    Events.V1IdentityVerificationSessionVerifiedEventNotification)
                },
                { "v1.invoice.created", typeof(Events.V1InvoiceCreatedEventNotification) },
                { "v1.invoice.deleted", typeof(Events.V1InvoiceDeletedEventNotification) },
                {
                    "v1.invoice.finalization_failed", typeof(
                    Events.V1InvoiceFinalizationFailedEventNotification)
                },
                { "v1.invoice.finalized", typeof(Events.V1InvoiceFinalizedEventNotification) },
                {
                    "v1.invoice.marked_uncollectible", typeof(
                    Events.V1InvoiceMarkedUncollectibleEventNotification)
                },
                { "v1.invoice.overdue", typeof(Events.V1InvoiceOverdueEventNotification) },
                { "v1.invoice.overpaid", typeof(Events.V1InvoiceOverpaidEventNotification) },
                { "v1.invoice.paid", typeof(Events.V1InvoicePaidEventNotification) },
                {
                    "v1.invoice.payment_action_required", typeof(
                    Events.V1InvoicePaymentActionRequiredEventNotification)
                },
                {
                    "v1.invoice.payment_attempt_required", typeof(
                    Events.V1InvoicePaymentAttemptRequiredEventNotification)
                },
                {
                    "v1.invoice.payment_failed", typeof(
                    Events.V1InvoicePaymentFailedEventNotification)
                },
                {
                    "v1.invoice.payment_succeeded", typeof(
                    Events.V1InvoicePaymentSucceededEventNotification)
                },
                { "v1.invoice.sent", typeof(Events.V1InvoiceSentEventNotification) },
                { "v1.invoice.upcoming", typeof(Events.V1InvoiceUpcomingEventNotification) },
                { "v1.invoice.updated", typeof(Events.V1InvoiceUpdatedEventNotification) },
                { "v1.invoice.voided", typeof(Events.V1InvoiceVoidedEventNotification) },
                { "v1.invoice.will_be_due", typeof(Events.V1InvoiceWillBeDueEventNotification) },
                {
                    "v1.invoice_payment.paid", typeof(
                    Events.V1InvoicePaymentPaidEventNotification)
                },
                {
                    "v1.invoiceitem.created", typeof(
                    Events.V1InvoiceitemCreatedEventNotification)
                },
                {
                    "v1.invoiceitem.deleted", typeof(
                    Events.V1InvoiceitemDeletedEventNotification)
                },
                {
                    "v1.issuing_authorization.created", typeof(
                    Events.V1IssuingAuthorizationCreatedEventNotification)
                },
                {
                    "v1.issuing_authorization.request", typeof(
                    Events.V1IssuingAuthorizationRequestEventNotification)
                },
                {
                    "v1.issuing_authorization.updated", typeof(
                    Events.V1IssuingAuthorizationUpdatedEventNotification)
                },
                {
                    "v1.issuing_card.created", typeof(
                    Events.V1IssuingCardCreatedEventNotification)
                },
                {
                    "v1.issuing_card.updated", typeof(
                    Events.V1IssuingCardUpdatedEventNotification)
                },
                {
                    "v1.issuing_cardholder.created", typeof(
                    Events.V1IssuingCardholderCreatedEventNotification)
                },
                {
                    "v1.issuing_cardholder.updated", typeof(
                    Events.V1IssuingCardholderUpdatedEventNotification)
                },
                {
                    "v1.issuing_dispute.closed", typeof(
                    Events.V1IssuingDisputeClosedEventNotification)
                },
                {
                    "v1.issuing_dispute.created", typeof(
                    Events.V1IssuingDisputeCreatedEventNotification)
                },
                {
                    "v1.issuing_dispute.funds_reinstated", typeof(
                    Events.V1IssuingDisputeFundsReinstatedEventNotification)
                },
                {
                    "v1.issuing_dispute.funds_rescinded", typeof(
                    Events.V1IssuingDisputeFundsRescindedEventNotification)
                },
                {
                    "v1.issuing_dispute.submitted", typeof(
                    Events.V1IssuingDisputeSubmittedEventNotification)
                },
                {
                    "v1.issuing_dispute.updated", typeof(
                    Events.V1IssuingDisputeUpdatedEventNotification)
                },
                {
                    "v1.issuing_personalization_design.activated", typeof(
                    Events.V1IssuingPersonalizationDesignActivatedEventNotification)
                },
                {
                    "v1.issuing_personalization_design.deactivated", typeof(
                    Events.V1IssuingPersonalizationDesignDeactivatedEventNotification)
                },
                {
                    "v1.issuing_personalization_design.rejected", typeof(
                    Events.V1IssuingPersonalizationDesignRejectedEventNotification)
                },
                {
                    "v1.issuing_personalization_design.updated", typeof(
                    Events.V1IssuingPersonalizationDesignUpdatedEventNotification)
                },
                {
                    "v1.issuing_token.created", typeof(
                    Events.V1IssuingTokenCreatedEventNotification)
                },
                {
                    "v1.issuing_token.updated", typeof(
                    Events.V1IssuingTokenUpdatedEventNotification)
                },
                {
                    "v1.issuing_transaction.created", typeof(
                    Events.V1IssuingTransactionCreatedEventNotification)
                },
                {
                    "v1.issuing_transaction.purchase_details_receipt_updated", typeof(
                    Events.V1IssuingTransactionPurchaseDetailsReceiptUpdatedEventNotification)
                },
                {
                    "v1.issuing_transaction.updated", typeof(
                    Events.V1IssuingTransactionUpdatedEventNotification)
                },
                { "v1.mandate.updated", typeof(Events.V1MandateUpdatedEventNotification) },
                {
                    "v1.payment_intent.amount_capturable_updated", typeof(
                    Events.V1PaymentIntentAmountCapturableUpdatedEventNotification)
                },
                {
                    "v1.payment_intent.canceled", typeof(
                    Events.V1PaymentIntentCanceledEventNotification)
                },
                {
                    "v1.payment_intent.created", typeof(
                    Events.V1PaymentIntentCreatedEventNotification)
                },
                {
                    "v1.payment_intent.partially_funded", typeof(
                    Events.V1PaymentIntentPartiallyFundedEventNotification)
                },
                {
                    "v1.payment_intent.payment_failed", typeof(
                    Events.V1PaymentIntentPaymentFailedEventNotification)
                },
                {
                    "v1.payment_intent.processing", typeof(
                    Events.V1PaymentIntentProcessingEventNotification)
                },
                {
                    "v1.payment_intent.requires_action", typeof(
                    Events.V1PaymentIntentRequiresActionEventNotification)
                },
                {
                    "v1.payment_intent.succeeded", typeof(
                    Events.V1PaymentIntentSucceededEventNotification)
                },
                {
                    "v1.payment_link.created", typeof(
                    Events.V1PaymentLinkCreatedEventNotification)
                },
                {
                    "v1.payment_link.updated", typeof(
                    Events.V1PaymentLinkUpdatedEventNotification)
                },
                {
                    "v1.payment_method.attached", typeof(
                    Events.V1PaymentMethodAttachedEventNotification)
                },
                {
                    "v1.payment_method.automatically_updated", typeof(
                    Events.V1PaymentMethodAutomaticallyUpdatedEventNotification)
                },
                {
                    "v1.payment_method.detached", typeof(
                    Events.V1PaymentMethodDetachedEventNotification)
                },
                {
                    "v1.payment_method.updated", typeof(
                    Events.V1PaymentMethodUpdatedEventNotification)
                },
                { "v1.payout.canceled", typeof(Events.V1PayoutCanceledEventNotification) },
                { "v1.payout.created", typeof(Events.V1PayoutCreatedEventNotification) },
                { "v1.payout.failed", typeof(Events.V1PayoutFailedEventNotification) },
                { "v1.payout.paid", typeof(Events.V1PayoutPaidEventNotification) },
                {
                    "v1.payout.reconciliation_completed", typeof(
                    Events.V1PayoutReconciliationCompletedEventNotification)
                },
                { "v1.payout.updated", typeof(Events.V1PayoutUpdatedEventNotification) },
                { "v1.person.created", typeof(Events.V1PersonCreatedEventNotification) },
                { "v1.person.deleted", typeof(Events.V1PersonDeletedEventNotification) },
                { "v1.person.updated", typeof(Events.V1PersonUpdatedEventNotification) },
                { "v1.plan.created", typeof(Events.V1PlanCreatedEventNotification) },
                { "v1.plan.deleted", typeof(Events.V1PlanDeletedEventNotification) },
                { "v1.plan.updated", typeof(Events.V1PlanUpdatedEventNotification) },
                { "v1.price.created", typeof(Events.V1PriceCreatedEventNotification) },
                { "v1.price.deleted", typeof(Events.V1PriceDeletedEventNotification) },
                { "v1.price.updated", typeof(Events.V1PriceUpdatedEventNotification) },
                { "v1.product.created", typeof(Events.V1ProductCreatedEventNotification) },
                { "v1.product.deleted", typeof(Events.V1ProductDeletedEventNotification) },
                { "v1.product.updated", typeof(Events.V1ProductUpdatedEventNotification) },
                {
                    "v1.promotion_code.created", typeof(
                    Events.V1PromotionCodeCreatedEventNotification)
                },
                {
                    "v1.promotion_code.updated", typeof(
                    Events.V1PromotionCodeUpdatedEventNotification)
                },
                { "v1.quote.accepted", typeof(Events.V1QuoteAcceptedEventNotification) },
                { "v1.quote.canceled", typeof(Events.V1QuoteCanceledEventNotification) },
                { "v1.quote.created", typeof(Events.V1QuoteCreatedEventNotification) },
                { "v1.quote.finalized", typeof(Events.V1QuoteFinalizedEventNotification) },
                {
                    "v1.radar.early_fraud_warning.created", typeof(
                    Events.V1RadarEarlyFraudWarningCreatedEventNotification)
                },
                {
                    "v1.radar.early_fraud_warning.updated", typeof(
                    Events.V1RadarEarlyFraudWarningUpdatedEventNotification)
                },
                { "v1.refund.created", typeof(Events.V1RefundCreatedEventNotification) },
                { "v1.refund.failed", typeof(Events.V1RefundFailedEventNotification) },
                { "v1.refund.updated", typeof(Events.V1RefundUpdatedEventNotification) },
                { "v1.review.closed", typeof(Events.V1ReviewClosedEventNotification) },
                { "v1.review.opened", typeof(Events.V1ReviewOpenedEventNotification) },
                {
                    "v1.setup_intent.canceled", typeof(
                    Events.V1SetupIntentCanceledEventNotification)
                },
                {
                    "v1.setup_intent.created", typeof(
                    Events.V1SetupIntentCreatedEventNotification)
                },
                {
                    "v1.setup_intent.requires_action", typeof(
                    Events.V1SetupIntentRequiresActionEventNotification)
                },
                {
                    "v1.setup_intent.setup_failed", typeof(
                    Events.V1SetupIntentSetupFailedEventNotification)
                },
                {
                    "v1.setup_intent.succeeded", typeof(
                    Events.V1SetupIntentSucceededEventNotification)
                },
                {
                    "v1.sigma.scheduled_query_run.created", typeof(
                    Events.V1SigmaScheduledQueryRunCreatedEventNotification)
                },
                { "v1.source.canceled", typeof(Events.V1SourceCanceledEventNotification) },
                { "v1.source.chargeable", typeof(Events.V1SourceChargeableEventNotification) },
                { "v1.source.failed", typeof(Events.V1SourceFailedEventNotification) },
                {
                    "v1.source.refund_attributes_required", typeof(
                    Events.V1SourceRefundAttributesRequiredEventNotification)
                },
                {
                    "v1.subscription_schedule.aborted", typeof(
                    Events.V1SubscriptionScheduleAbortedEventNotification)
                },
                {
                    "v1.subscription_schedule.canceled", typeof(
                    Events.V1SubscriptionScheduleCanceledEventNotification)
                },
                {
                    "v1.subscription_schedule.completed", typeof(
                    Events.V1SubscriptionScheduleCompletedEventNotification)
                },
                {
                    "v1.subscription_schedule.created", typeof(
                    Events.V1SubscriptionScheduleCreatedEventNotification)
                },
                {
                    "v1.subscription_schedule.expiring", typeof(
                    Events.V1SubscriptionScheduleExpiringEventNotification)
                },
                {
                    "v1.subscription_schedule.released", typeof(
                    Events.V1SubscriptionScheduleReleasedEventNotification)
                },
                {
                    "v1.subscription_schedule.updated", typeof(
                    Events.V1SubscriptionScheduleUpdatedEventNotification)
                },
                {
                    "v1.tax.settings.updated", typeof(
                    Events.V1TaxSettingsUpdatedEventNotification)
                },
                { "v1.tax_rate.created", typeof(Events.V1TaxRateCreatedEventNotification) },
                { "v1.tax_rate.updated", typeof(Events.V1TaxRateUpdatedEventNotification) },
                {
                    "v1.terminal.reader.action_failed", typeof(
                    Events.V1TerminalReaderActionFailedEventNotification)
                },
                {
                    "v1.terminal.reader.action_succeeded", typeof(
                    Events.V1TerminalReaderActionSucceededEventNotification)
                },
                {
                    "v1.terminal.reader.action_updated", typeof(
                    Events.V1TerminalReaderActionUpdatedEventNotification)
                },
                {
                    "v1.test_helpers.test_clock.advancing", typeof(
                    Events.V1TestHelpersTestClockAdvancingEventNotification)
                },
                {
                    "v1.test_helpers.test_clock.created", typeof(
                    Events.V1TestHelpersTestClockCreatedEventNotification)
                },
                {
                    "v1.test_helpers.test_clock.deleted", typeof(
                    Events.V1TestHelpersTestClockDeletedEventNotification)
                },
                {
                    "v1.test_helpers.test_clock.internal_failure", typeof(
                    Events.V1TestHelpersTestClockInternalFailureEventNotification)
                },
                {
                    "v1.test_helpers.test_clock.ready", typeof(
                    Events.V1TestHelpersTestClockReadyEventNotification)
                },
                { "v1.topup.canceled", typeof(Events.V1TopupCanceledEventNotification) },
                { "v1.topup.created", typeof(Events.V1TopupCreatedEventNotification) },
                { "v1.topup.failed", typeof(Events.V1TopupFailedEventNotification) },
                { "v1.topup.reversed", typeof(Events.V1TopupReversedEventNotification) },
                { "v1.topup.succeeded", typeof(Events.V1TopupSucceededEventNotification) },
                { "v1.transfer.created", typeof(Events.V1TransferCreatedEventNotification) },
                { "v1.transfer.reversed", typeof(Events.V1TransferReversedEventNotification) },
                { "v1.transfer.updated", typeof(Events.V1TransferUpdatedEventNotification) },
                {
                    "v2.commerce.product_catalog.imports.failed", typeof(
                    Events.V2CommerceProductCatalogImportsFailedEventNotification)
                },
                {
                    "v2.commerce.product_catalog.imports.processing", typeof(
                    Events.V2CommerceProductCatalogImportsProcessingEventNotification)
                },
                {
                    "v2.commerce.product_catalog.imports.succeeded", typeof(
                    Events.V2CommerceProductCatalogImportsSucceededEventNotification)
                },
                {
                    "v2.commerce.product_catalog.imports.succeeded_with_errors", typeof(
                    Events.V2CommerceProductCatalogImportsSucceededWithErrorsEventNotification)
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
