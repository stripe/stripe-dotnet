---
title: API Updates
pr_link: https://github.com/stripe/stripe-dotnet/pull/2489
is_stripe_api_change: true
released_in_version: 39.112.0
---

* Add support for new resources `Treasury.CreditReversal`, `Treasury.DebitReversal`, `Treasury.FinancialAccountFeatures`, `Treasury.FinancialAccount`, `Treasury.FlowDetails`, `Treasury.InboundTransfer`, `Treasury.OutboundPayment`, `Treasury.OutboundTransfer`, `Treasury.ReceivedCredit`, `Treasury.ReceivedDebit`, `Treasury.TransactionEntry`, and `Treasury.Transaction`
* Add support for `RetrievePaymentMethod` method on resource `Customer`
* Add support for `ListOwners` and `List` methods on resource `FinancialConnections.Account`
* Change type of `BillingPortal.SessionReturnUrl` from `string` to `nullable(string)`
* Add support for `AfterpayClearpay`, `AuBecsDebit`, `BacsDebit`, `Eps`, `Fpx`, `Giropay`, `Grabpay`, `Klarna`, `Paynow`, and `SepaDebit` on `Checkout.SessionPaymentMethodOptions`
* Add support for `Treasury` on `Issuing.Authorization`, `Issuing.DisputeCreateOptions`, `Issuing.Dispute`, and `Issuing.Transaction`
* Add support for `FinancialAccount` on `Issuing.CardCreateOptions` and `Issuing.Card`
* Add support for `ClientSecret` on `Order`
* Add support for `Networks` on `PaymentIntentPaymentMethodOptionsUsBankAccountOptions`, `PaymentMethodUsBankAccount`, and `SetupIntentPaymentMethodOptionsUsBankAccountOptions`
* Add support for `AttachToSelf` and `FlowDirections` on `SetupIntent`
* Add support for `SaveDefaultPaymentMethod` on `SubscriptionPaymentSettingsOptions` and `SubscriptionPaymentSettings`
* Add support for `Czk` on `Terminal.ConfigurationTippingOptions` and `Terminal.ConfigurationTipping`
