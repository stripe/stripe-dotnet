---
title: Fix `SucceededAt` on `ReportRun` to be nullable
pr_link: https://github.com/stripe/stripe-dotnet/pull/1824
released_in_version: 32.1.3
---

* This is technically a breaking change, but we're releasing as a patch version as the non-nullable type made it impossible to deserialize `report_run` objects in many cases.
