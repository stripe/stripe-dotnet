// File generated from our OpenAPI spec
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
                { "account", typeof(Account) },
                { "account_link", typeof(AccountLink) },
                { "account_session", typeof(AccountSession) },
                { "apple_pay_domain", typeof(ApplePayDomain) },
                { "application", typeof(Application) },
                { "application_fee", typeof(ApplicationFee) },
                { "apps.secret", typeof(Apps.Secret) },
                { "balance", typeof(Balance) },
                { "balance_transaction", typeof(BalanceTransaction) },
                { "bank_account", typeof(BankAccount) },
                { "billing.meter", typeof(Billing.Meter) },
                { "billing.meter_event", typeof(Billing.MeterEvent) },
                {
                    "billing.meter_event_adjustment", typeof(
                        Billing.MeterEventAdjustment)
                },
                {
                    "billing.meter_event_summary", typeof(
                        Billing.MeterEventSummary)
                },
                {
                    "billing_portal.configuration", typeof(
                        BillingPortal.Configuration)
                },
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
                {
                    "connect_collection_transfer", typeof(
                        ConnectCollectionTransfer)
                },
                { "country_spec", typeof(CountrySpec) },
                { "coupon", typeof(Coupon) },
                { "credit_note", typeof(CreditNote) },
                { "credit_note_line_item", typeof(CreditNoteLineItem) },
                { "customer", typeof(Customer) },
                {
                    "customer_balance_transaction", typeof(
                        CustomerBalanceTransaction)
                },
                {
                    "customer_cash_balance_transaction", typeof(
                        CustomerCashBalanceTransaction)
                },
                { "customer_session", typeof(CustomerSession) },
                { "discount", typeof(Discount) },
                { "dispute", typeof(Dispute) },
                { "ephemeral_key", typeof(EphemeralKey) },
                { "event", typeof(Event) },
                { "fee_refund", typeof(ApplicationFeeRefund) },
                { "file", typeof(File) },
                { "file_link", typeof(FileLink) },
                {
                    "financial_connections.account", typeof(
                        FinancialConnections.Account)
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
                    "financial_connections.session", typeof(
                        FinancialConnections.Session)
                },
                {
                    "financial_connections.transaction", typeof(
                        FinancialConnections.Transaction)
                },
                { "forwarding.request", typeof(Forwarding.Request) },
                { "funding_instructions", typeof(FundingInstructions) },
                {
                    "identity.verification_report", typeof(
                        Identity.VerificationReport)
                },
                {
                    "identity.verification_session", typeof(
                        Identity.VerificationSession)
                },
                { "invoice", typeof(Invoice) },
                { "invoiceitem", typeof(InvoiceItem) },
                { "issuing.authorization", typeof(Issuing.Authorization) },
                { "issuing.card", typeof(Issuing.Card) },
                { "issuing.cardholder", typeof(Issuing.Cardholder) },
                { "issuing.dispute", typeof(Issuing.Dispute) },
                {
                    "issuing.personalization_design", typeof(
                        Issuing.PersonalizationDesign)
                },
                { "issuing.physical_bundle", typeof(Issuing.PhysicalBundle) },
                { "issuing.token", typeof(Issuing.Token) },
                { "issuing.transaction", typeof(Issuing.Transaction) },
                { "item", typeof(LineItem) },
                { "line_item", typeof(InvoiceLineItem) },
                { "login_link", typeof(LoginLink) },
                { "mandate", typeof(Mandate) },
                { "payment_intent", typeof(PaymentIntent) },
                { "payment_link", typeof(PaymentLink) },
                { "payment_method", typeof(PaymentMethod) },
                {
                    "payment_method_configuration", typeof(
                        PaymentMethodConfiguration)
                },
                { "payment_method_domain", typeof(PaymentMethodDomain) },
                { "payout", typeof(Payout) },
                { "person", typeof(Person) },
                { "plan", typeof(Plan) },
                { "platform_tax_fee", typeof(PlatformTaxFee) },
                { "price", typeof(Price) },
                { "product", typeof(Product) },
                { "promotion_code", typeof(PromotionCode) },
                { "quote", typeof(Quote) },
                {
                    "radar.early_fraud_warning", typeof(Radar.EarlyFraudWarning)
                },
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
                {
                    "source_mandate_notification", typeof(
                        SourceMandateNotification)
                },
                { "source_transaction", typeof(SourceTransaction) },
                { "subscription", typeof(Subscription) },
                { "subscription_item", typeof(SubscriptionItem) },
                { "subscription_schedule", typeof(SubscriptionSchedule) },
                { "tax.calculation", typeof(Tax.Calculation) },
                {
                    "tax.calculation_line_item", typeof(Tax.CalculationLineItem)
                },
                { "tax.registration", typeof(Tax.Registration) },
                { "tax.settings", typeof(Tax.Settings) },
                { "tax.transaction", typeof(Tax.Transaction) },
                {
                    "tax.transaction_line_item", typeof(Tax.TransactionLineItem)
                },
                { "tax_code", typeof(TaxCode) },
                { "tax_deducted_at_source", typeof(TaxDeductedAtSource) },
                { "tax_id", typeof(TaxId) },
                { "tax_rate", typeof(TaxRate) },
                { "terminal.configuration", typeof(Terminal.Configuration) },
                {
                    "terminal.connection_token", typeof(
                        Terminal.ConnectionToken)
                },
                { "terminal.location", typeof(Terminal.Location) },
                { "terminal.reader", typeof(Terminal.Reader) },
                { "test_helpers.test_clock", typeof(TestHelpers.TestClock) },
                { "token", typeof(Token) },
                { "topup", typeof(Topup) },
                { "transfer", typeof(Transfer) },
                { "transfer_reversal", typeof(TransferReversal) },
                { "treasury.credit_reversal", typeof(Treasury.CreditReversal) },
                { "treasury.debit_reversal", typeof(Treasury.DebitReversal) },
                {
                    "treasury.financial_account", typeof(
                        Treasury.FinancialAccount)
                },
                {
                    "treasury.financial_account_features", typeof(
                        Treasury.FinancialAccountFeatures)
                },
                {
                    "treasury.inbound_transfer", typeof(
                        Treasury.InboundTransfer)
                },
                {
                    "treasury.outbound_payment", typeof(
                        Treasury.OutboundPayment)
                },
                {
                    "treasury.outbound_transfer", typeof(
                        Treasury.OutboundTransfer)
                },
                { "treasury.received_credit", typeof(Treasury.ReceivedCredit) },
                { "treasury.received_debit", typeof(Treasury.ReceivedDebit) },
                { "treasury.transaction", typeof(Treasury.Transaction) },
                {
                    "treasury.transaction_entry", typeof(
                        Treasury.TransactionEntry)
                },
                { "usage_record", typeof(UsageRecord) },
                { "usage_record_summary", typeof(UsageRecordSummary) },
                { "webhook_endpoint", typeof(WebhookEndpoint) },
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
    }
}