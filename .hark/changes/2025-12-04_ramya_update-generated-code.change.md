---
title: Update generated code for private-preview
pr_link: https://github.com/stripe/stripe-dotnet/pull/3272
is_stripe_api_change: true
released_in_version: 50.1.0-alpha.4
---

* Add support for `CheckScanning` on `AccountSession.Components`
* Add support for `Client` on `V2.Core.Event.Reason.Request`
* Add support for `StripeBalancePayment` on `V2.MoneyManagement.ReceivedCredit` and `V2.MoneyManagement.ReceivedDebit`
* Add support for `BalanceTransfer` on `V2.MoneyManagement.ReceivedDebit`
* Add support for `Include` on `V2.Core.EventGetOptions` and `V2.Core.EventListOptions`
* Add support for event notifications `V2IamApiKeyCreatedEvent`, `V2IamApiKeyDefaultSecretRevealedEvent`, `V2IamApiKeyExpiredEvent`, `V2IamApiKeyPermissionsUpdatedEvent`, `V2IamApiKeyRotatedEvent`, and `V2IamApiKeyUpdatedEvent`
