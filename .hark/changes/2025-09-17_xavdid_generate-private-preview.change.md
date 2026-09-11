---
title: generate private-preview SDK w/ mid Sept changes
pr_link: https://github.com/stripe/stripe-dotnet/pull/3173
is_stripe_api_change: true
released_in_version: 48.6.0-alpha.2
---

* Add support for `Get` method on resource `V2.Core.ClaimableSandbox`
* Add support for `Category` and `Priority` on `V2.Billing.ServiceAction.CreditGrantPerTenant`, `V2.Billing.ServiceAction.CreditGrant`, `V2BillingServiceActionCreditGrantOptions`, and `V2BillingServiceActionCreditGrantPerTenantOptions`
* Add support for `Invoices` on `EventsV2BillingCadenceBilledEvent`
* Add support for thin events `V2CoreClaimableSandboxClaimedEvent`, `V2CoreClaimableSandboxExpiredEvent`, `V2CoreClaimableSandboxExpiringEvent`, and `V2CoreClaimableSandboxSandboxDetailsOwnerAccountUpdatedEvent` with related object `V2.Core.ClaimableSandbox`
* Remove support for thin event `V2BillingCadenceErroredEvent` with related object `V2.Billing.Cadence`
