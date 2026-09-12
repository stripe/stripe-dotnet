---
title: API Updates for beta branch
pr_url: https://github.com/stripe/stripe-dotnet/pull/2638
is_stripe_api_change: true
released_in_version: 41.6.0-beta.2
---

* Updated stable APIs to the latest version
* Add support for `ListTransactions` method on resource `Tax.Transaction`
* Add support for `BillingAgreementId` on `CheckoutSessionPaymentMethodOptionsPaypalOptions`
* Change type of `QuoteSubscriptionDataOverridesOptions` from `array(create_specs)` to `emptyStringable(array(update_specs))`
