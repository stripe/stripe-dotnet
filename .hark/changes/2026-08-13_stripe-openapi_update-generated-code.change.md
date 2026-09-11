---
title: Update generated code for private-preview
pr_link: https://github.com/stripe/stripe-dotnet/pull/3421
is_breaking: true
is_stripe_api_change: true
released_in_version: 52.4.0-alpha.1
---

* Add support for new resource `V2.Tax.OperationsResolveAddressResult`
* Add support for `ResolveAddress` method on resource `V2.Tax.OperationsResolveAddressResult`
* Add support for `Confirm` and `FxQuote` methods on resource `V2.MoneyManagement.PayoutIntent`
* Add support for `CustomerUpdate` on `BillingPortal.Session.Flow`
* Add support for `FundingSourceGroup` on `Charge.PaymentMethodDetails.Link`
* ⚠️ Remove support for `PricingGroup` on `Charge.PaymentMethodDetails.Link`
* Add support for `Celo` on `Crypto.OnrampSession.TransactionDetails.WalletAddresses`
* Add support for `CustomerPortal` on `CustomerSession.Components`
* Add support for `AppliedToInvoice` and `Type` on `CustomerCustomerBalanceTransactionCreateOptions`
* Add support for `ClassificationState` and `EnrichmentState` on `FinancialConnections.Account`
* Add support for `Country` on `FinancialConnections.Session.Filters`
* Add support for `Classifications` and `Enrichments` on `FinancialConnections.Transaction`
* Add support for `CustomerBalance` on `Invoice` and `QuotePreviewInvoice`
* Add support for `Billie` on `Invoice.PaymentSettings.PaymentMethodOptions`, `QuotePreviewInvoice.PaymentSettings.PaymentMethodOptions`, and `Subscription.PaymentSettings.PaymentMethodOptions`
* Add support for `HoldAmountDetails` and `HoldAmount` on `Issuing.Authorization.PendingRequest` and `Issuing.Authorization.RequestHistory`
* Add support for `NetworkDeclineCode` on `PaymentAttemptRecordPaymentMethodDetailsCardOptions` and `PaymentRecordPaymentMethodDetailsCardOptions`
* Add support for `SetupFutureUsage` on `PaymentIntent.PaymentMethodOptions.Sequra`
* Add support for `Status` on `QuotePreviewSubscriptionSchedule.PauseSchedule.Pause`, `QuotePreviewSubscriptionSchedule.PauseSchedule.Resume`, `SubscriptionSchedule.PauseSchedule.Pause`, and `SubscriptionSchedule.PauseSchedule.Resume`
* Change type of `SubscriptionSchedulePauseSchedulesOptions.Resume` from `pause_schedule_update_resume_params` to `emptyable(pause_schedule_update_resume_params)`
* Add support for `Acquirer` on `EventsV2CoreHealthAuthorizationRateDropFiringEventImpactDimension`, `EventsV2CoreHealthAuthorizationRateDropResolvedEventImpactDimension`, `V2.Core.Health.Alert.AuthorizationRateDrop.Dimension`, and `V2.Core.Health.AlertHistoryEntry.AuthorizationRateDrop.Dimension`
* ⚠️ Change type of `EventsV2CoreHealthAuthorizationRateDropFiringEventImpactDimension.Type`, `EventsV2CoreHealthAuthorizationRateDropResolvedEventImpactDimension.Type`, `V2.Core.Health.Alert.AuthorizationRateDrop.Dimension.Type`, and `V2.Core.Health.AlertHistoryEntry.AuthorizationRateDrop.Dimension.Type` from `literal('issuer')` to `enum('acquirer'|'issuer')`
* Add support for `ConfirmationMethod` on `V2.MoneyManagement.PayoutIntentCreateOptions` and `V2.MoneyManagement.PayoutIntent`
* Add support for `EstimatedFees` and `FxQuote` on `V2.MoneyManagement.PayoutIntent`
* Add support for `Debited` on `V2.MoneyManagement.PayoutIntent.From`
* Add support for `Confirm` on `V2.MoneyManagement.PayoutIntent.NextAction`
* ⚠️ Change type of `V2.MoneyManagement.PayoutIntent.NextAction.Type` from `literal('handle_failure')` to `enum('confirm'|'handle_failure')`
* Add support for `Credited` on `V2.MoneyManagement.PayoutIntent.To`
* Add support for event notification `V1BalanceSettingsUpdatedEvent` with related object `BalanceSettings`
* Add support for event notification `V1BillingCreditBalanceTransactionCreatedEvent` with related object `Billing.CreditBalanceTransaction`
* Add support for event notifications `V1BillingCreditGrantCreatedEvent` and `V1BillingCreditGrantUpdatedEvent` with related object `Billing.CreditGrant`
* Add support for event notifications `V1BillingMeterCreatedEvent`, `V1BillingMeterDeactivatedEvent`, `V1BillingMeterReactivatedEvent`, and `V1BillingMeterUpdatedEvent` with related object `Billing.Meter`
* Add support for event notifications `V1FinancialConnectionsAccountAccountNumbersUpdatedEvent`, `V1FinancialConnectionsAccountExpectedDeactivationDateUpdatedEvent`, `V1FinancialConnectionsAccountSupportedPaymentMethodTypesUpdatedEvent`, `V1FinancialConnectionsAccountUpcomingAccountNumberExpiryEvent`, and `V1FinancialConnectionsAccountUpcomingDeactivationEvent` with related object `FinancialConnections.Account`
* Add support for event notification `V1InvoicePaymentAttemptRequiredEvent` with related object `Invoice`
* Add support for error type `FxQuoteNeedsRefreshException`
