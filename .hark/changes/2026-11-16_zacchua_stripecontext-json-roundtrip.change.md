---
title: Keep `StripeContext` segments when serializing it with Newtonsoft.Json or System.Text.Json
semver_level: patch
jira_tickets_closed:
- RUN_DEVSDK-3730
---

- `StripeContext` now serializes as its `Stripe-Context` string (e.g. `"acct_123/acct_456"`), matching the API's wire format, instead of `{"Segments": [...]}`. Previously, deserializing that object produced an empty context, so an `EventNotification` that went through JSON lost its context and the event notification handler made requests without a `Stripe-Context` header.
- Deserializing still accepts the previous `{"Segments": [...]}` shape, so already-serialized payloads restore correctly.
- System.Text.Json can now deserialize an `EventNotification` from a webhook payload with a `context` string.
