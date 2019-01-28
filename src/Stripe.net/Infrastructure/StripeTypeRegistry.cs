namespace Stripe.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Reflection;

    internal static class StripeTypeRegistry
    {
        /// <summary>
        /// Dictionary mapping the values contained in the `object` key of JSON payloads returned
        /// by Stripe's API to concrete types of model classes.
        /// </summary>
        public static readonly ImmutableDictionary<string, Type> ObjectsToTypes = new Dictionary<string, Type>
        {
            { "account", typeof(Account) },
            { "account_link", typeof(AccountLink) },
            { "apple_pay_domain", typeof(ApplePayDomain) },
            { "application", typeof(Application) },
            { "application_fee", typeof(ApplicationFee) },
            { "balance", typeof(Balance) },
            { "balance_transaction", typeof(BalanceTransaction) },
            { "bank_account", typeof(BankAccount) },
            { "card", typeof(Card) },
            { "charge", typeof(Charge) },
            { "country_spec", typeof(CountrySpec) },
            { "coupon", typeof(Coupon) },
            { "customer", typeof(Customer) },
            { "discount", typeof(Discount) },
            { "dispute", typeof(Dispute) },
            { "ephemeral_key", typeof(EphemeralKey) },
            { "event", typeof(Event) },
            { "exchange_rate", typeof(ExchangeRate) },
            { "fee_refund", typeof(ApplicationFeeRefund) },
            { "file", typeof(File) },
            { "file_link", typeof(FileLink) },
            { "invoice", typeof(Invoice) },
            { "invoiceitem", typeof(InvoiceItem) },
            { "issuing.authorization", typeof(Issuing.Authorization) },
            { "issuing.card", typeof(Issuing.Card) },
            { "issuing.cardholder", typeof(Issuing.Cardholder) },
            { "issuing.card_details", typeof(Issuing.CardDetails) },
            { "issuing.dispute", typeof(Issuing.Dispute) },
            { "issuing.transaction", typeof(Issuing.Transaction) },
            { "line_item", typeof(InvoiceLineItem) },
            { "login_link", typeof(LoginLink) },
            { "order", typeof(Order) },
            { "order_item", typeof(OrderItem) },
            { "order_return", typeof(OrderReturn) },
            { "payment_intent", typeof(PaymentIntent) },
            { "payout", typeof(Payout) },
            { "person", typeof(Person) },
            { "plan", typeof(Plan) },
            { "product", typeof(Product) },
            { "radar.value_list", typeof(Radar.ValueList) },
            { "radar.value_list_item", typeof(Radar.ValueListItem) },
            { "recipient", typeof(Recipient) },
            { "refund", typeof(Refund) },
            { "review", typeof(Review) },
            { "reporting.report_run", typeof(Reporting.ReportRun) },
            { "reporting.report_type", typeof(Reporting.ReportType) },
            { "scheduled_query_run", typeof(Sigma.ScheduledQueryRun) },
            { "sku", typeof(Sku) },
            { "source", typeof(Source) },
            { "source_mandate_notification", typeof(SourceMandateNotification) },
            { "source_transaction", typeof(SourceTransaction) },
            { "subscription", typeof(Subscription) },
            { "subscription_item", typeof(SubscriptionItem) },
            { "subscription_schedule", typeof(SubscriptionSchedule) },
            { "subscription_schedule_revision", typeof(SubscriptionScheduleRevision) },
            { "terminal.connection_token", typeof(Terminal.ConnectionToken) },
            { "terminal.location", typeof(Terminal.Location) },
            { "terminal.reader", typeof(Terminal.Reader) },
            { "three_d_secure", typeof(ThreeDSecure) },
            { "token", typeof(Token) },
            { "topup", typeof(Topup) },
            { "transfer", typeof(Transfer) },
            { "transfer_reversal", typeof(TransferReversal) },
            { "usage_record", typeof(UsageRecord) },
            { "usage_record_summary", typeof(UsageRecordSummary) },
            { "webhook_endpoint", typeof(WebhookEndpoint) },
        }.ToImmutableDictionary();

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
