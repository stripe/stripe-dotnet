---
title: Type changes
pr_link: https://github.com/stripe/stripe-dotnet/pull/2744
is_breaking: true
released_in_version: 42.0.0
---

* ⚠️ Generate more accurate types for `AccountSettingsPayoutsScheduleOptions.DelayDays`, `SubscriptionSchedulePhaseOptions.EndDate`, `SubscriptionSchedulePhaseOptions.StartDate`, and
`SubscriptionSchedulePhaseOptions.TrialEnd`. These fields are dates or numbers that also support special signifier strings like "now". They have been changed to use `AnyOf<...>`.
