---
title: Support `Bancontact/iDEAL/Sofort -> SEPA DD`
pr_link: https://github.com/stripe/stripe-dotnet/pull/2216
is_stripe_api_change: true
released_in_version: 39.12.0
---

* Add support for generated_sepa_debit and generated_sepa_debit_mandate to ChargePaymentMethodDetailsBancontact, ChargePaymentMethodDetailsIdeal, and ChargePaymentMethodDetailsSofort.
* Add support for generated_from to PaymentMethodSepaDebit
* Add support for bancontact, ideal, and sofort to SetupAttemptPaymentMethodDetails
