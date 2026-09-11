---
title: Update generated code for beta
pr_link: https://github.com/stripe/stripe-dotnet/pull/3298
is_stripe_api_change: true
released_in_version: 50.5.0-beta.1
---

* Add support for `SmartDisputes` on `Account.Settings`, `AccountSettingsOptions`, `V2.Core.Account.Configuration.Merchant`, and `V2CoreAccountConfigurationMerchantOptions`
* Add support for `EmailCustomersOnSuccessfulPayment` on `Account.Settings.Payments` and `AccountSettingsPaymentsOptions`
* Add support for `ManagedPayments` on `Checkout.SessionCreateOptions`, `Checkout.Session`, `PaymentIntent`, `SetupIntent`, and `Subscription`
* Add support for `Purpose` on `V2.MoneyManagement.OutboundPaymentCreateOptions` and `V2.MoneyManagement.OutboundPayment`
* Add support for `BranchNumber` and `SwiftCode` on `V2.MoneyManagement.PayoutMethod.BankAccount`
