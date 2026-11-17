---
title: Keep `StripeContext` segments when serializing it with Newtonsoft.Json or System.Text.Json
semver_level: patch
jira_tickets_closed:
- RUN_DEVSDK-3730
---

`StripeContext` now serializes as its `Stripe-Context` string (e.g. `"acct_123/acct_456"`), matching the API's wire format, instead of `{"Segments": [...]}`, which didn't deserialize correctly. Payloads previously serialized as `{"Segments": [...]}` still deserialize correctly.
