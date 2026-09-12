---
title: Update generated code for private-preview
pr_url: https://github.com/stripe/stripe-dotnet/pull/3410
is_breaking: true
is_stripe_api_change: true
released_in_version: 52.2.0-alpha.4
---

* ⚠️ Remove support for resource `FrMealVouchersOnboarding`
* ⚠️ Remove support for `Create`, `Get`, `List`, and `Update` methods on resource `FrMealVouchersOnboarding`
* Add support for `Create` method on resource `PaymentRecord`
* ⚠️ Remove support for `FinancialAccountsTransactions`, `FinancialAccounts`, and `RecipientsList` on `AccountSessionComponentsOptions`
* Add support for `SmartDisputesManagement` on `AccountSession.Components.DisputesList.Features`, `AccountSession.Components.PaymentDetails.Features`, `AccountSession.Components.PaymentDisputes.Features`, and `AccountSession.Components.Payments.Features`
* Add support for `Mode` on `FinancialConnections.Session.ManualEntry`
* Add support for `BusinessName` on `Issuing.Card.Shipping`
* Add support for `PauseSchedules` on `QuotePreviewSubscriptionSchedule`, `SubscriptionScheduleCreateOptions`, `SubscriptionScheduleUpdateOptions`, and `SubscriptionSchedule`
* Add support for `Trial` on `QuotePreviewSubscriptionSchedule.Phase` and `SubscriptionSchedule.Phase`
* Add support for `PaymentRecord` on `RefundCreateOptions`
* Add support for `RedirectToUrl` on `SharedPayment.IssuedToken.NextAction`
* ⚠️ Change type of `SharedPayment.IssuedToken.NextAction.Type` from `literal('use_stripe_sdk')` to `enum('redirect_to_url'|'use_stripe_sdk')`
* Add support for snapshot events `FinancialConnectionsAccountExpectedDeactivationDateUpdated`, `FinancialConnectionsAccountSupportedPaymentMethodTypesUpdated`, and `FinancialConnectionsAccountUpcomingDeactivation` with resource `FinancialConnections.Account`
* Add support for snapshot events `FinancialConnectionsAuthorizationExpectedDeactivationDateUpdated` and `FinancialConnectionsAuthorizationUpcomingDeactivation` with resource `FinancialConnections.Authorization`
