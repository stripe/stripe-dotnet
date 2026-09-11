---
title: Regenerate with decimal_string enabled for v2 APIs
pr_link: https://github.com/stripe/stripe-dotnet/pull/3329
is_breaking: true
released_in_version: 51.0.0
---

- V2 API decimal fields changed type from `string` to `decimal?`. Code that reads or writes these fields as `string` will need to use `decimal?` instead. Affected fields:
  - **AccountPersonRelationship**: `PercentOwnership`
  - **AccountIdentityIndividualRelationship**: `PercentOwnership`
  - Options: `AccountCreateIdentityIndividualRelationshipOptions`, `AccountUpdateIdentityIndividualRelationshipOptions`, `AccountTokenCreateIdentityIndividualRelationshipOptions`, `PersonCreateRelationshipOptions`, `PersonUpdateRelationshipOptions`, `PersonTokenCreateRelationshipOptions`
