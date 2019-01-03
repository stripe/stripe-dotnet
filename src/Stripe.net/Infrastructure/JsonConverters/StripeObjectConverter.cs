namespace Stripe.Infrastructure
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// This converter is used to deserialize attributes declared as `IHasObject` into concrete
    /// model classes. In other words, this converter can deserialize any Stripe object based on
    /// the value of the <c>object</c> attribute. This is useful when the type of the object has
    /// to be determined at runtime, such as when decoding the <c>data.object</c> attribute of
    /// event objects.
    /// </summary>
    internal class StripeObjectConverter : AbstractStripeObjectConverter<IHasObject>
    {
        protected override Dictionary<string, Func<string, IHasObject>> ObjectsToMapperFuncs
            => new Dictionary<string, Func<string, IHasObject>>
        {
            { "account", Mapper<Account>.MapFromJson },
            { "apple_pay_domain", Mapper<ApplePayDomain>.MapFromJson },
            { "application", Mapper<Application>.MapFromJson },
            { "application_fee", Mapper<ApplicationFee>.MapFromJson },
            { "balance", Mapper<Balance>.MapFromJson },
            { "balance_transaction", Mapper<BalanceTransaction>.MapFromJson },
            { "bank_account", Mapper<BankAccount>.MapFromJson },
            { "card", Mapper<Card>.MapFromJson },
            { "charge", Mapper<Charge>.MapFromJson },
            { "country_spec", Mapper<CountrySpec>.MapFromJson },
            { "coupon", Mapper<Coupon>.MapFromJson },
            { "customer", Mapper<Customer>.MapFromJson },
            { "discount", Mapper<Discount>.MapFromJson },
            { "dispute", Mapper<Dispute>.MapFromJson },
            { "ephemeral_key", Mapper<EphemeralKey>.MapFromJson },
            { "event", Mapper<Event>.MapFromJson },
            { "exchange_rate", Mapper<ExchangeRate>.MapFromJson },
            { "fee_refund", Mapper<ApplicationFeeRefund>.MapFromJson },
            { "file", Mapper<File>.MapFromJson },
            { "file_link", Mapper<FileLink>.MapFromJson },
            { "invoice", Mapper<Invoice>.MapFromJson },
            { "invoiceitem", Mapper<InvoiceItem>.MapFromJson },
            { "issuing.authorization", Mapper<Issuing.Authorization>.MapFromJson },
            { "issuing.cardholder", Mapper<Issuing.Cardholder>.MapFromJson },
            { "issuing.card", Mapper<Issuing.Card>.MapFromJson },
            { "issuing.dispute", Mapper<Issuing.Dispute>.MapFromJson },
            { "issuing.transaction", Mapper<Issuing.Transaction>.MapFromJson },
            { "login_link", Mapper<LoginLink>.MapFromJson },
            { "order", Mapper<Order>.MapFromJson },
            { "order_item", Mapper<OrderItem>.MapFromJson },
            { "order_return", Mapper<OrderReturn>.MapFromJson },
            { "payment_intent", Mapper<PaymentIntent>.MapFromJson },
            { "payout", Mapper<Payout>.MapFromJson },
            { "plan", Mapper<Plan>.MapFromJson },
            { "product", Mapper<Product>.MapFromJson },
            { "radar.value_list", Mapper<Radar.ValueList>.MapFromJson },
            { "radar.value_list_item", Mapper<Radar.ValueListItem>.MapFromJson },
            { "recipient", Mapper<Recipient>.MapFromJson },
            { "refund", Mapper<Refund>.MapFromJson },
            { "reporting.report_run", Mapper<Reporting.ReportRun>.MapFromJson },
            { "reporting.report_type", Mapper<Reporting.ReportType>.MapFromJson },
            { "scheduled_query_run", Mapper<Sigma.ScheduledQueryRun>.MapFromJson },
            { "sku", Mapper<Sku>.MapFromJson },
            { "source", Mapper<Source>.MapFromJson },
            { "source_mandate_notification", Mapper<SourceMandateNotification>.MapFromJson },
            { "source_transaction", Mapper<SourceTransaction>.MapFromJson },
            { "subscription", Mapper<Subscription>.MapFromJson },
            { "subscription_item", Mapper<SubscriptionItem>.MapFromJson },
            { "terminal.connection_token", Mapper<Terminal.ConnectionToken>.MapFromJson },
            { "terminal.location", Mapper<Terminal.Location>.MapFromJson },
            { "terminal.reader", Mapper<Terminal.Reader>.MapFromJson },
            { "three_d_secure", Mapper<ThreeDSecure>.MapFromJson },
            { "token", Mapper<Token>.MapFromJson },
            { "topup", Mapper<Topup>.MapFromJson },
            { "transfer", Mapper<Transfer>.MapFromJson },
            { "transfer_reversal", Mapper<TransferReversal>.MapFromJson },
            { "usage_record", Mapper<UsageRecord>.MapFromJson },
            { "usage_record_summary", Mapper<UsageRecordSummary>.MapFromJson },
        };
    }
}
