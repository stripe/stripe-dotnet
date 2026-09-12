---
title: Build SDK w/ V2 OpenAPI spec
pr_url: https://github.com/stripe/stripe-dotnet/pull/3167
is_breaking: true
released_in_version: 49.0.0
---

- ⚠️ The delete methods for v2 APIs (the ones in the `StripeClient.v2` namespace) now return a `V2DeletedObject` which has the id of the object that has been deleted and a string representing the type of the object that has been deleted.
