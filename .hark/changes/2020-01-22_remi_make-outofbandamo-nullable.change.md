---
title: Make `OutOfBandAmount` nullable on  `CreditNote`
pr_link: https://github.com/stripe/stripe-dotnet/pull/1902
released_in_version: 34.16.1
---

* This is technically a breaking change, but we're releasing as a patch version as the non-nullable type made it impossible to deserialize `credit_note` objects in many cases.
