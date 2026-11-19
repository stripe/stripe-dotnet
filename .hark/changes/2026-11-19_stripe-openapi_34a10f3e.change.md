---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/3492
semver_level: major
is_stripe_api_change: true
released_in_version: 53.3.0-beta.1
---

* ⚠️ Remove support for resource `V2.Billing.Cadence`
* Add support for `Create` and `Refill` test helper methods on resource `Capital.FinancingOffer`
* ⚠️ Remove support for `Cancel`, `Create`, `Get`, `List`, and `Update` methods on resource `V2.Billing.Cadence`
* Add support for `ExportTaxTransactions`, `ProductTaxCodeSelector`, and `TaxThresholdMonitoring` on `AccountSession.Components`
* Add support for `Custom` on `CouponCreateOptions` and `Coupon`
* Add support for `Type` on `CouponCreateOptions` and `CustomerCustomerBalanceTransactionCreateOptions`
* Add support for `AppliedToInvoice` on `CustomerCustomerBalanceTransactionCreateOptions`
* Add support for `CustomerBalance` on `Invoice` and `QuotePreviewInvoice`
* ⚠️ Change type of `PaymentIntent.NextAction.VerifyWithMicrodeposits.ArrivalDate` and `SetupIntent.NextAction.VerifyWithMicrodeposits.ArrivalDate` from `DateTime` to `nullable(DateTime)`
* Add support for `Connect`, `DataExport`, `EventDestination`, `Radar`, and `UserAccess` on `V2.Iam.ActivityLog.Details`
* Add support for `ApplePay` on `V2.MoneyManagement.PayoutMethod` and `V2MoneyManagementOutboundSetupIntentPayoutMethodDataOptions`
* Add support for `Network` and `OriginatingBankAccount` on `V2.MoneyManagement.ReceivedDebit.BankTransfer`
* Add support for `Created` on `V2.MoneyManagement.ReceivedDebitListOptions`
* Add support for `LogsFrom` on `V2.Iam.ActivityLogListOptions`
* Add support for `Severity` on `EventsV2CoreHealthEventGenerationFailureResolvedEvent`
