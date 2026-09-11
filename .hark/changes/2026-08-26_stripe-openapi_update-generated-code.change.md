---
title: Update generated code for beta
pr_link: https://github.com/stripe/stripe-dotnet/pull/3429
is_breaking: true
is_stripe_api_change: true
released_in_version: 52.5.0-beta.1
---

* Add support for new resources `V2.Core.ApprovalRequest`, `V2.Signals.AccountActivity`, `V2.Signals.AccountEvaluation`, and `V2.Signals.AccountSignal`
* Add support for `Get` and `List` methods on resource `V2.Signals.AccountSignal`
* Add support for `Create` and `Get` methods on resource `V2.Signals.AccountEvaluation`
* Add support for `Create`, `Delete`, and `Get` methods on resource `V2.Signals.AccountActivity`
* Add support for `Cancel`, `Get`, `List`, and `Update` methods on resource `V2.Core.ApprovalRequest`
* Add support for `Disable` method on resource `V2.MoneyManagement.PayoutMethod`
* Add support for `DisableStripeUserAuthentication` on `AccountSessionComponentsPaymentMethodSettingsFeaturesOptions`
* ⚠️ Remove support for `PaymentMethodTypes` on `PaymentIntentConfirmOptions`, `PaymentIntentCreateOptions`, `PaymentIntentUpdateOptions`, `SetupIntentCreateOptions`, and `SetupIntentUpdateOptions`
* ⚠️ Change type of `ProductCatalog.TrialOffer.EndBehavior.Transition.Price` and `ProductCatalog.TrialOffer.Price` from `$Price` to `deletable($Price)`
* Add support for `Billie` on `QuotePreviewInvoice.PaymentSettings.PaymentMethodOptions`
* Add support for `PayoutMethods` on `V2.Core.Account.Defaults` and `V2CoreAccountDefaultsOptions`
* Add support for `Restricted` on `V2.Core.Vault.GbBankAccount` and `V2.Core.Vault.UsBankAccount`
* Add support for `EnabledDeliverySchemes` on `V2.MoneyManagement.PayoutMethod.BankAccount`
* ⚠️ Remove support for `EnabledDeliveryOptions` on `V2.MoneyManagement.PayoutMethod.BankAccount`
* Add support for event notifications `V2CoreApprovalRequestApprovedEvent`, `V2CoreApprovalRequestCanceledEvent`, `V2CoreApprovalRequestCreatedEvent`, `V2CoreApprovalRequestExpiredEvent`, `V2CoreApprovalRequestFailedEvent`, `V2CoreApprovalRequestRejectedEvent`, and `V2CoreApprovalRequestSucceededEvent` with related object `V2.Core.ApprovalRequest`
* Add support for event notification `V2SignalsAccountEvaluationCompleteEvent` with related object `V2.Signals.AccountEvaluation`
