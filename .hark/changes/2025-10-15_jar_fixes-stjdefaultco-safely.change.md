---
title: Fixes STJDefaultConverter to safely ignore unknown properties
pr_link: https://github.com/stripe/stripe-dotnet/pull/3223
released_in_version: 49.1.0
---

* Fixes a bug when using System.Text.Json to deserialize JSON that has properties not present in the target object.
