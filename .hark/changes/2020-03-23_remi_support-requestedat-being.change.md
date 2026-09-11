---
title: Support RequestedAt being nullable
pr_link: https://github.com/stripe/stripe-dotnet/pull/1963
released_in_version: 35.7.1
---

* This is technically a breaking change, but we're releasing as a patch version as the non-nullable type made it impossible to deserialize `Capability` objects in many cases.
