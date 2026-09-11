---
title: urlencode ids in url paths
pr_link: https://github.com/stripe/stripe-dotnet/pull/2955
released_in_version: 45.9.0
---

- id strings passed to service methods (like `PaymentMethodService.Get("...")`) are now correctly URL Encoded. This is an important update if you pass user inupt into any of those methods
