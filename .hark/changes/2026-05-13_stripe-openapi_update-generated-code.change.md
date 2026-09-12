---
title: Update generated code for private-preview
pr_url: https://github.com/stripe/stripe-dotnet/pull/3382
is_breaking: true
is_stripe_api_change: true
released_in_version: 51.2.0-alpha.5
---

* Add support for new resources `V2.Core.FeeBatch`, `V2.Core.FeeEntry`, `V2.MoneyManagement.DebitDispute`, and `V2.MoneyManagement.FinancialAccountStatement`
* Add support for `SimulateNetworkLifecyclePreArbitrationResponse` and `SimulateNetworkLifecyclePreArbitrationSubmission` test helper methods on resource `Issuing.Dispute`
* Add support for `List` method on resource `PaymentLocation`
* Add support for `Get` and `List` methods on resources `V2.Core.FeeBatch`, `V2.Core.FeeEntry`, and `V2.MoneyManagement.FinancialAccountStatement`
* Add support for `Create`, `Get`, and `List` methods on resource `V2.MoneyManagement.DebitDispute`
* Add support for `Discounts` on `DelegatedCheckout.RequestedSessionCreateOptions`, `DelegatedCheckout.RequestedSessionUpdateOptions`, and `DelegatedCheckout.RequestedSession`
* Add support for `AmountSale` on `DelegatedCheckout.RequestedSession.LineItemDetail` and `DelegatedCheckout.RequestedSession.TotalDetails`
* Add support for `AmountDiscount` and `Breakdown` on `DelegatedCheckout.RequestedSession.TotalDetails`
* ⚠️ Remove support for `CheckDepositAddress` on `Invoice.PaymentSettings.PaymentMethodOptions.CheckScan`, `InvoicePaymentSettingsPaymentMethodOptionsCheckScanOptions`, `QuotePreviewInvoice.PaymentSettings.PaymentMethodOptions.CheckScan`, `Subscription.PaymentSettings.PaymentMethodOptions.CheckScan`, and `SubscriptionPaymentSettingsPaymentMethodOptionsCheckScanOptions`
* Add support for `PaymentEvaluations` on `PaymentAttemptRecordReportGuaranteedOptions`, `PaymentRecordGuaranteedOptions`, and `PaymentRecordReportPaymentAttemptGuaranteedOptions`
* Add support for `Location` on `PaymentIntentPaymentDetailsOptions` and `SetupIntentSetupDetailsOptions`
* Add support for `OnboardingDataUpdateAcknowledged` on `PaymentLocationUpdateOptions`
* Add support for `Customer` on `Radar.CustomerEvaluationUpdateOptions`
* Add support for `Status` on `Radar.CustomerEvaluationUpdateOptions` and `Radar.CustomerEvaluation`
* Add support for `PaymentBehavior` on `SubscriptionResumeOptions`
* Add support for `DisputeDetails` on `V2.MoneyManagement.ReceivedDebit`
* Add support for `DebitDispute` on `V2.MoneyManagement.Transaction.Flow` and `V2.MoneyManagement.TransactionEntry.TransactionDetails.Flow`
* Add support for `PaymentAttemptRecord` on `EventsV2PaymentsOffSessionPaymentAttemptFailedEvent` and `EventsV2PaymentsOffSessionPaymentFailedEvent`
* Add support for event notifications `V2MoneyManagementFinancialAccountStatementCreatedEvent` and `V2MoneyManagementFinancialAccountStatementRestatedEvent` with related object `V2.MoneyManagement.FinancialAccountStatement`
