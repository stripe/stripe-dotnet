---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/2891
is_stripe_api_change: true
released_in_version: 44.2.0
---

* Add support for new resource `Entitlements.ActiveEntitlementSummary`
* Add support for `Balances` and `PayoutsList` on `AccountSessionComponentsOptions` and `AccountSessionComponents`
* Remove support for `Config` on `Forwarding.RequestCreateOptions` and `ForwardingRequest`. This field is no longer used by the Forwarding Request API.
* Add support for `CaptureMethod` on `PaymentIntentPaymentMethodOptionsRevolutPayOptions` and `PaymentIntentPaymentMethodOptionsRevolutPay`
* Add support for `Swish` on `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, and `PaymentMethodConfiguration`
