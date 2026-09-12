---
title: API Updates
pr_url: https://github.com/stripe/stripe-dotnet/pull/2442
is_stripe_api_change: true
released_in_version: 39.100.0
---

* Add support for PayNow and US Bank Accounts Debits payments
    * **Charge** ([API ref](https://stripe.com/docs/api/charges/object#charge_object-payment_method_details))
        * Add support for `Paynow` and `UsBankAccount` on `ChargePaymentMethodDetails`
    * **Mandate** ([API ref](https://stripe.com/docs/api/mandates/object#mandate_object-payment_method_details))
        * Add support for `UsBankAccount` on `MandatePaymentMethodDetails`
    * **Payment Intent** ([API ref](https://stripe.com/docs/api/payment_intents/object#payment_intent_object-payment_method_options))
        * Add support for `Paynow` and `UsBankAccount` on `PaymentIntentPaymentMethodOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodDataOptions`
        * Add support for `PaynowDisplayQrCode` on `PaymentIntentNextAction`
    * **Setup Intent** ([API ref](https://stripe.com/docs/api/setup_intents/object#setup_intent_object-payment_method_options))
        * Add support for `UsBankAccount` on `SetupIntentPaymentMethodOptionsOptions` and `SetupIntentPaymentMethodOptions`
    * **Setup Attempt** ([API ref](https://stripe.com/docs/api/setup_attempts/object#setup_attempt_object-payment_method_details))
        * Add support for `UsBankAccount` on `SetupAttemptPaymentMethodDetails`
    * **Payment Method** ([API ref](https://stripe.com/docs/api/payment_methods/object#payment_method_object-paynow))
        * Add support for `Paynow` and `UsBankAccount` on `PaymentMethod` and `PaymentMethodCreateOptions`
        * Add support for `UsBankAccount` on `PaymentMethodUpdateOptions`
    * **Checkout Session** ([API ref](https://stripe.com/docs/api/checkout/sessions/create#create_checkout_session-payment_method_types))
        * Add support for `UsBankAccount` on `Checkout.SessionPaymentMethodOptions` and `Checkout.SessionPaymentMethodOptionsOptions`
    * **Invoice** ([API ref](https://stripe.com/docs/api/invoices/object#invoice_object-payment_settings-payment_method_types))
        * Add support for `UsBankAccount` on `InvoicePaymentSettingsPaymentMethodOptions` and `InvoicePaymentSettingsPaymentMethodOptionsOptions`
    * **Subscription** ([API ref](https://stripe.com/docs/api/subscriptions/object#subscription_object-payment_settings-payment_method_types))
        * Add support for `UsBankAccount` on `SubscriptionPaymentSettingsPaymentMethodOptions` and `SubscriptionPaymentSettingsPaymentMethodOptionsOptions`
    * **Account capabilities** ([API ref](https://stripe.com/docs/api/accounts/object#account_object-capabilities))
    * Add support for `PaynowPayments` and `UsBankAccountAchPayments` on `AccountCapabilities` and `AccountCapabilitiesParams`
* Add support for `FailureBalanceTransaction` on `Charge`
* Add support for `TestClock` on `SubscriptionListOptions`
* Add support for `CaptureMethod` on `PaymentIntentPaymentMethodOptionsAfterpayClearpayOptions`, `PaymentIntentPaymentMethodOptionsAfterpayClearpay`, `PaymentIntentPaymentMethodOptionsCardOptions`, `PaymentIntentPaymentMethodOptionsCard`, `PaymentIntentPaymentMethodOptionsKlarnaOptions`, `PaymentIntentPaymentMethodOptionsKlarna`, and `PaymentIntentTypeSpecificPaymentMethodOptionsClient`
* Add additional support for verify microdeposits on Payment Intent and Setup Intent ([API ref](https://stripe.com/docs/api/payment_intents/verify_microdeposits))
    * Add support for `DescriptorCode` on `PaymentIntentVerifyMicrodepositsOptions` and `SetupIntentVerifyMicrodepositsOptions`
    * Add support for `MicrodepositType` on `PaymentIntentNextActionVerifyWithMicrodeposits` and `SetupIntentNextActionVerifyWithMicrodeposits`
