---
title: Update generated code.
pr_link: https://github.com/stripe/stripe-dotnet/pull/3159
is_stripe_api_change: true
released_in_version: 48.5.0
---

* Add support for `BalanceReport`, `PayoutDetails`, and `PayoutReconciliationReport` on `AccountSession.Components` and `AccountSessionComponentsOptions`
* Add support for `Name` on `BillingPortal.ConfigurationCreateOptions`, `BillingPortal.ConfigurationUpdateOptions`, and `BillingPortal.Configuration`
* Add support for `Installments` on `Charge.PaymentMethodDetails.Alma`
* Add support for `TransactionId` on `Charge.PaymentMethodDetails.Alma`, `Charge.PaymentMethodDetails.AmazonPay`, `Charge.PaymentMethodDetails.Billie`, `Charge.PaymentMethodDetails.KakaoPay`, `Charge.PaymentMethodDetails.KrCard`, `Charge.PaymentMethodDetails.NaverPay`, `Charge.PaymentMethodDetails.Payco`, `Charge.PaymentMethodDetails.RevolutPay`, `Charge.PaymentMethodDetails.SamsungPay`, and `Charge.PaymentMethodDetails.Satispay`
* Add support for `Location` and `Reader` on `Charge.PaymentMethodDetails.Paynow`
* Add support for `AmountIncludesIof` on `Checkout.Session.PaymentMethodOptions.Pix`, `CheckoutSessionPaymentMethodOptionsPixOptions`, `PaymentIntent.PaymentMethodOptions.Pix`, and `PaymentIntentPaymentMethodOptionsPixOptions`
* Add support for `Metadata` and `Period` on `InvoiceScheduleDetailsPhaseAddInvoiceItemOptions`, `SubscriptionAddInvoiceItemOptions`, `SubscriptionSchedule.Phase.AddInvoiceItem`, and `SubscriptionSchedulePhaseAddInvoiceItemOptions`
* Add support for `ExpMonth` and `ExpYear` on `Issuing.CardCreateOptions`
* Add support for `ExcludedPaymentMethodTypes` on `PaymentIntentCreateOptions` and `PaymentIntent`
* Add support for `PayoutMethod` on `PayoutCreateOptions` and `Payout`
* Add support for `Mxn` on `Terminal.Configuration.Tipping` and `TerminalConfigurationTippingOptions`
* Add support for `Card` on `Terminal.TestHelpersReaderPresentPaymentMethodOptions`
