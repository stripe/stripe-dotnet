---
title: API Updates
pr_link: https://github.com/stripe/stripe-dotnet/pull/2502
is_stripe_api_change: true
released_in_version: 39.117.0
---

* Add support for `Affirm`, `Bancontact`, `Card`, `Ideal`, `P24`, and `Sofort` on `Checkout.SessionPaymentMethodOptionsOptions` and `Checkout.SessionPaymentMethodOptions`
* Add support for `AfterpayClearpay`, `AuBecsDebit`, `BacsDebit`, `Eps`, `Fpx`, `Giropay`, `Grabpay`, `Klarna`, `Paynow`, and `SepaDebit` on `Checkout.SessionPaymentMethodOptionsOptions`
* Add support for `SetupFutureUsage` on `Checkout.SessionPaymentMethodOptionsAcssDebitOptions`, `Checkout.SessionPaymentMethodOptionsAcssDebit`, `Checkout.SessionPaymentMethodOptionsAfterpayClearpay`, `Checkout.SessionPaymentMethodOptionsAlipayOptions`, `Checkout.SessionPaymentMethodOptionsAlipay`, `Checkout.SessionPaymentMethodOptionsAuBecsDebit`, `Checkout.SessionPaymentMethodOptionsBacsDebit`, `Checkout.SessionPaymentMethodOptionsBoletoOptions`, `Checkout.SessionPaymentMethodOptionsBoleto`, `Checkout.SessionPaymentMethodOptionsEps`, `Checkout.SessionPaymentMethodOptionsFpx`, `Checkout.SessionPaymentMethodOptionsGiropay`, `Checkout.SessionPaymentMethodOptionsGrabpay`, `Checkout.SessionPaymentMethodOptionsKlarna`, `Checkout.SessionPaymentMethodOptionsKonbiniOptions`, `Checkout.SessionPaymentMethodOptionsKonbini`, `Checkout.SessionPaymentMethodOptionsOxxoOptions`, `Checkout.SessionPaymentMethodOptionsOxxo`, `Checkout.SessionPaymentMethodOptionsPaynow`, `Checkout.SessionPaymentMethodOptionsSepaDebit`, `Checkout.SessionPaymentMethodOptionsUsBankAccountOptions`, `Checkout.SessionPaymentMethodOptionsUsBankAccount`, and `Checkout.SessionPaymentMethodOptionsWechatPayOptions`
* Add support for `AttachToSelf` on `SetupAttempt`, `SetupIntentCreateOptions`, `SetupIntentListOptions`, and `SetupIntentUpdateOptions`
* Add support for `FlowDirections` on `SetupAttempt`, `SetupIntentCreateOptions`, and `SetupIntentUpdateOptions`
