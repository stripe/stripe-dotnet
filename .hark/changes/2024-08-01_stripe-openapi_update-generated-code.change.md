---
title: Update generated code
pr_link: https://github.com/stripe/stripe-dotnet/pull/2944
is_breaking: true
is_stripe_api_change: true
released_in_version: 45.6.0
---

* Add support for new resources `Billing.AlertTriggered` and `Billing.Alert`
* ⚠️ Remove support for `AuthorizationCode` on `ChargePaymentMethodDetailsCard`. This was accidentally released last week.
