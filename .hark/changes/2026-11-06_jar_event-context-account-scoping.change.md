---
title: Stop leaking a stale Stripe-Account when fetching an event's related object
pr_url: https://github.com/stripe/stripe-dotnet/pull/3494
semver_level: minor
jira_tickets_closed:
- RUN_DEVSDK-3692
---

Adds `StripeClient.WithStripeContext()`, which returns a client scoped to a given `StripeContext` with `Stripe-Account` cleared. `EventNotification.FetchEvent()`/`FetchRelatedObject()` and `Event.FetchRelatedObject()` now use it (or the equivalent on the underlying requestor) so a connected account configured on the parsing or retrieving client no longer rides along on requests scoped to an event's own context. Dispatch callbacks registered on `StripeEventNotificationHandler`/`StripeEventNotificationHandlerWithoutVerification` can now call `args.EventNotification.FetchRelatedObject()` directly and get the same context-scoped behavior as `args.Client`.
