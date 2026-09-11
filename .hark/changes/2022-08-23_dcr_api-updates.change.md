---
title: API Updates
pr_link: https://github.com/stripe/stripe-dotnet/pull/2564
is_stripe_api_change: true
released_in_version: 40.4.0
---

* Change the return type of `CustomerService.FundCashBalance` test helper from `CustomerBalanceTransaction` to `CustomerCashBalanceTransaction`.
  * This would generally be considered a breaking change, but we've worked with all existing users to migrate and are comfortable releasing this as a minor as it is solely a test helper method. This was essentially broken prior to this change.
