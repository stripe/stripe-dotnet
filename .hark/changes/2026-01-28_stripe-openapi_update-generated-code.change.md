---
title: Update generated code for beta
pr_url: https://github.com/stripe/stripe-dotnet/pull/3291
is_stripe_api_change: true
released_in_version: 50.4.0-beta.1
---

* Add support for new resource `FinancialConnections.Authorization`
* Add support for `Get` method on resource `FinancialConnections.Authorization`
* Add support for `DetachPayment` method on resource `Invoice`
* Remove support for `Cancel`, `ListLineItems`, and `Reopen` methods on resource `Order`
* Remove support for `AttachCadence` method on resource `Subscription`
* Add support for `AdditionalFiles` and `Site` on `Account.Settings.PaypayPayments` and `AccountSettingsPaypayPaymentsOptions`
* Remove support for `Capital` on `Account.Settings`
* Add support for `Authorization` and `StatusDetails` on `FinancialConnections.Account`
* Add support for `RelinkOptions` on `FinancialConnections.SessionCreateOptions` and `FinancialConnections.Session`
* Add support for `RelinkResult` on `FinancialConnections.Session`
* Remove support for `BillingCadence` on `InvoiceCreatePreviewOptions`, `SubscriptionCreateOptions`, `SubscriptionUpdateOptions`, and `Subscription`
* Remove support for `BillingCadenceDetails` on `Invoice.Parent` and `QuotePreviewInvoice.Parent`
* Add support for `CarRentalData`, `FlightData`, and `LodgingData` on `PaymentIntent.PaymentDetails`
* Add support for `AlternativeReference` on `V2.Core.Vault.GbBankAccount`, `V2.Core.Vault.UsBankAccount`, and `V2.MoneyManagement.PayoutMethod`
* Add support for `AccountHolderAddress` and `AccountHolderName` on `V2.MoneyManagement.FinancialAddress.Credentials.UsBankAccount`
* Add support for `Fingerprint` on `V2.MoneyManagement.PayoutMethod.Card`
* Add support for snapshot event `InvoicePaymentDetached` with resource `InvoicePayment`
