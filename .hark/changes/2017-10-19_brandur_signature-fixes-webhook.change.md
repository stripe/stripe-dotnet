---
title: Signature fixes for webhook signature verification
pr_url: https://github.com/stripe/stripe-dotnet/pull/1035
released_in_version: 11.6.0
---

* Explicitly dispose of `HMACSHA256` after use so that its buffer cannot be inadvertently leaked
* Use `SafeUTF8.GetBytes` so that unrecognized codepoints are not silently replaced with "?"
