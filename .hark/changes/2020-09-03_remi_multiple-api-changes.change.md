---
title: Multiple API changes
pr_link: https://github.com/stripe/stripe-dotnet/pull/2198
is_stripe_api_change: true
released_in_version: 39.2.0
---

* Improve support for the Issuing `Dispute` APIs. Added the Submit API, missing parameters on creation, update and list and returned evidence details
* Add support for `dispute` on Issuing `Transaction`
* Add `AvailablePayoutMethods` on `BankAccount`
* Add `PaymentStatus` on Checkout `Session`
