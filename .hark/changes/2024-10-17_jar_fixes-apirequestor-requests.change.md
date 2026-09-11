---
title: Fixes ApiRequestorAdapter requests with BaseAddress other than Api
pr_link: https://github.com/stripe/stripe-dotnet/pull/3007
released_in_version: 46.2.1
---

- fixes bug where OAuthTokenService created without an explicit StripeClient accesses the wrong base url
