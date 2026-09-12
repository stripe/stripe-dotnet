---
title: Improvements to parameter encoding
pr_url: https://github.com/stripe/stripe-dotnet/pull/1044
released_in_version: 11.6.1
---

* Main user-facing fix is that dictionary keys are now URL-encoded correctly (in case they contained characters incompatible with URLs)
