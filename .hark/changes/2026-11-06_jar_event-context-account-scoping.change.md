---
title: Stop leaking a stale Stripe-Account when fetching an event's related object
pr_url: https://github.com/stripe/stripe-dotnet/pull/3494
semver_level: minor
jira_tickets_closed:
- RUN_DEVSDK-3692
---

Adds `StripeClient.WithStripeContext()` to construct a `StripeClient` with the supplied `StripeContext` with `Stripe-Account` cleared.  Adds calls to `WithStripeClient` from `EventNotification.FromJson` and when processing a `V2.Core.Event` API response.
