---
title: Update generated code for beta
pr_link: https://github.com/stripe/stripe-dotnet/pull/3376
is_breaking: true
is_stripe_api_change: true
released_in_version: 51.3.0-beta.1
---

* Add support for `Pause` method on resource `Subscription`
* Add support for `Get` method on resource `V2.Iam.ActivityLog`
* ⚠️ Change type of `ProductCatalog.TrialOffer.EndBehavior.Transition.Price` from `string` to `expandable($Price)`
* Add support for `AmountPaidOffStripe` on `QuotePreviewInvoice`
* Add support for `Discountable` on `QuotePreviewSubscriptionSchedule.Phase.AddInvoiceItem`
* Add support for `Bizum` and `Scalapay` on `SharedPayment.GrantedToken.PaymentMethodDetails`
* Change type of `SubscriptionItem.BilledUntil` from `nullable(DateTime)` to `DateTime`
* Add support for `PaymentBehavior` on `SubscriptionResumeOptions`
* Add support for `StatusDetails` on `Subscription`
* ⚠️ Change type of `V2.MoneyManagement.ReceivedCredit.BankTransfer.GbBankAccount.Network` from `literal('fps')` to `enum('chaps'|'fps')`
