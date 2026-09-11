---
title: Allow `VoidedAt` on `CreditNote` to be nullable
pr_link: https://github.com/stripe/stripe-dotnet/pull/1783
released_in_version: 29.0.1
---

* This is technically a breaking change, but we're releasing as a patch version as the non-nullable type made it impossible to deserialize `credit_note` objects in most cases.
