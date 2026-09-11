---
title: Enhance beta version handling in ApiVersion
pr_link: https://github.com/stripe/stripe-dotnet/pull/3069
section: Changes
released_in_version: 48.1.0-beta.1
---

* `StripeConfiguation.AddBetaVersion` will use the highest version number used for a beta feature instead of throwing an `Exception` on a conflict as it had done previously.
