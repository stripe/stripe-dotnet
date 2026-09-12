---
title: Move to API version `2020-03-02` and remove deprecated properties
pr_url: https://github.com/stripe/stripe-dotnet/pull/1937
is_breaking: true
released_in_version: 35.0.0
---

* Removed `GeneratedCardId`, use `GeneratedCard` instead.
* Removed `ApplicationId`, use `Application` instead.
* Removed `Source` parameter when listing charges as this is deprecated.
* Removed `MaxAmount` in `AuthorizationControlsOptions` as this is deprecated.
