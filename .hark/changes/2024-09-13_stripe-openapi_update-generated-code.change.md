---
title: Update generated code for beta
pr_link: https://github.com/stripe/stripe-dotnet/pull/2961
is_stripe_api_change: true
released_in_version: 45.13.0-beta.1
---

* Add support for new resources `Issuing.DisputeSettlementDetail` and `Issuing.Settlement`
* Add support for `Get` and `List` methods on resource `DisputeSettlementDetail`
* Remove support for `List` method on resource `QuotePhase`
* Add support for `Settlement` on `Issuing.TransactionListOptions` and `IssuingTransaction`
