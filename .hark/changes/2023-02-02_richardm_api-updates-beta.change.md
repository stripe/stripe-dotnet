---
title: API Updates for beta branch
pr_url: https://github.com/stripe/stripe-dotnet/pull/2642
is_stripe_api_change: true
released_in_version: 41.7.0-beta.1
---

* Updated stable APIs to the latest version
* Add support for new resource `FinancialConnections.Transaction`
* Add support for `List` method on resource `Transaction`
* Add support for `Prefetch` on `-PaymentMethodOptionsUsBankAccountFinancialConnections`, and `-PaymentMethodOptionsUsBankAccountFinancialConnectionsOptions` across several APIs.
* Add support for `InferredBalancesRefresh`, `Subscriptions`, and `TransactionRefresh` on `FinancialConnectionsAccount`
* Add support for `ManualEntry` on `FinancialConnectionsSessionCreateOptions` and `FinancialConnectionsSession`
* Add support for `StatusDetails` and `Status` on `FinancialConnectionsSession`
* Add support for `AccountNumber` on `PaymentMethodUsBankAccount`
* Remove support for `Id` on `QuoteLinesStartsAtLineEndsAtOptions`
