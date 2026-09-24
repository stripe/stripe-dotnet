---
title: Move `BankAccountOptions` to the `Stripe` namespace
pr_url: https://github.com/stripe/stripe-dotnet/pull/1191
released_in_version: 16.3.0
---

* This change is technically breaking, but it won't break most code because it's like to already have a `using Stripe` in the same file, so we've released it as a minor release
