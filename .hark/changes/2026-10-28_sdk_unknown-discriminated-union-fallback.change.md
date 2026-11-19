---
title: Fix forward-compatible deserialization of unknown discriminated-union variants
semver_level: patch
released_in_version: 53.2.0
---

Preserve unknown string discriminators on concrete union bases with both Newtonsoft.Json and System.Text.Json, including safe serialization of fallback values.
