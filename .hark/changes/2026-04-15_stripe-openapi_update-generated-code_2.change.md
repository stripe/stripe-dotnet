---
title: Update generated code for private-preview
pr_link: https://github.com/stripe/stripe-dotnet/pull/3363
is_breaking: true
is_stripe_api_change: true
released_in_version: 51.1.0-alpha.4
---

* Add support for new resources `V2.Core.WorkflowRun` and `V2.Core.Workflow`
* Add support for `ReportAuthorized` method on resource `PaymentAttemptRecord`
* Add support for `Get` and `List` methods on resource `V2.Core.WorkflowRun`
* Add support for `Get`, `Invoke`, and `List` methods on resource `V2.Core.Workflow`
* Add support for `NextAction` and `Status` on `SharedPayment.IssuedToken`
* ⚠️ Remove support for `NetworkId` on `SharedPayment.IssuedToken.SellerDetails`
* Add support for `Bills` on `AccountSession.Components`
* Add support for `SettlementCurrencies` on `BalanceSettings.Payments` and `BalanceSettingsPaymentsOptions`
* Add support for `DefaultSettlementCurrency` on `BalanceSettings.Payments`
* Add support for `AccountFunding` on `Charge.PaymentMethodDetails.Card`
* Add support for `AutomaticSurcharge` on `Checkout.SessionCreateOptions`, `Checkout.Session`, `PaymentLinkCreateOptions`, and `PaymentLink`
* Add support for `Bizum` on `Checkout.Session.PaymentMethodOptions` and `CheckoutSessionPaymentMethodOptionsOptions`
* Add support for `SurchargeCost` on `Checkout.Session`
* Add support for `AmountSurcharge` on `Checkout.Session.TotalDetails`
* Add support for `SharedPaymentGrantedToken` on `ConfirmationTokenPaymentMethodDataOptions`, `PaymentIntentPaymentMethodDataOptions`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `Details` on `Identity.VerificationReport.Email`
* Add support for `Confirm` on `Identity.VerificationSessionCreateOptions` and `Identity.VerificationSessionUpdateOptions`
* Add support for `Subscription` on `InvoiceItem.Parent.ScheduleDetails`
* ⚠️ Remove support for `SharedPaymentGrantedToken` on `PaymentIntentConfirmOptions` and `PaymentIntentCreateOptions`
* Add support for `MoneyServices` on `PaymentIntent.PaymentDetails`
* ⚠️ Remove support for `ExternalReference` on `Plan`
