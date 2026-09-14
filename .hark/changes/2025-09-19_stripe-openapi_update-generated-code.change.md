---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/3172
semver_level: major
is_stripe_api_change: true
released_in_version: 49.0.0
---

* ⚠️ Changes type of `UseStripeSdk` in `PaymentIntentNextAction` and `SetupIntentNextAction` to be `Dictionary<string, object>`
* ⚠️ Removes `PaymentIntentNextActionUseStripeSdk` and `SetupIntentNextActionUseStripeSdk`
