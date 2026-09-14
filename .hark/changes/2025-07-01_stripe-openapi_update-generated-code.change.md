---
title: Update generated code for beta
pr_url: https://github.com/stripe/stripe-dotnet/pull/3132
is_stripe_api_change: true
released_in_version: 48.4.0-beta.1
---

* Change type of `CheckoutSessionSubscriptionDataOptions.BillingMode`, `InvoiceScheduleDetailsOptions.BillingMode`, `InvoiceSubscriptionDetailsOptions.BillingMode`, `Quote.SubscriptionData.BillingMode`, `QuoteSubscriptionDataOptions.BillingMode`, `SubscriptionCreateOptions.BillingMode`, and `SubscriptionScheduleCreateOptions.BillingMode` from `enum('classic'|'flexible')` to `billing_mode`
* Add support for `SubmissionMethod` on `Dispute.EvidenceDetails`
* Add support for `OnDemand` and `Subscriptions` on `OrderPaymentSettingsPaymentMethodOptionsKlarnaOptions`
* Change type of `Order.Payment.Settings.PaymentMethodOptions.Klarna.SetupFutureUsage` and `OrderPaymentSettingsPaymentMethodOptionsKlarnaOptions.SetupFutureUsage` from `literal('none')` to `enum('none'|'off_session'|'on_session')`
* Add support for `Crypto` on `PaymentAttemptRecord.PaymentMethodDetails` and `PaymentRecord.PaymentMethodDetails`
* Change type of `PaymentIntent.PaymentMethodOptions.Gopay.SetupFutureUsage` and `PaymentIntentPaymentMethodOptionsGopayOptions.SetupFutureUsage` from `literal('none')` to `enum('none'|'off_session')`
* Change type of `QuotePreviewSubscriptionSchedule.BillingMode`, `Subscription.BillingMode`, and `SubscriptionSchedule.BillingMode` from `enum('classic'|'flexible')` to `SubscriptionsResourceBillingMode`
* Change type of `SubscriptionMigrateOptions.BillingMode` from `literal('flexible')` to `billing_mode_migrate`
* Remove support for `BillingModeDetails` on `Subscription`
* Add support for `ProofOfAddress` on `V2.Core.Account.Identity.BusinessDetails.Documents` and `V2CoreAccountIdentityBusinessDetailsDocumentsOptions`
* Add support for `Metadata` on `V2.MoneyManagement.FinancialAccount`
* Remove support for `Description` on `V2.MoneyManagement.FinancialAccount`
* Remove support for `Attempts` on `V2.Payments.OffSessionPayment`
* Change type of `V2.Payments.OffSessionPayment.TransferData.Amount` from `integer` to `nullable(integer)`
* Add support for `FromAccount`, `OutboundPayment`, and `OutboundTransfer` on `V2.MoneyManagement.ReceivedCredit.BalanceTransfer`
* Change type of `V2.MoneyManagement.ReceivedCredit.BalanceTransfer.Type` from `literal('payout_v1')` to `enum('outbound_payment'|'outbound_transfer'|'payout_v1')`
