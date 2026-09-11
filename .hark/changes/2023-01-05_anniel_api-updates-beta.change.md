---
title: API Updates for beta branch
pr_link: https://github.com/stripe/stripe-dotnet/pull/2630
is_stripe_api_change: true
released_in_version: 41.5.0-beta.1
---

* Updated stable APIs to the latest version
* Add support for `MarkStaleQuote` method on resource `Quote`
* Add support for `Duration` and `LineEndsAt` on `QuoteSubscriptionDataBillOnAcceptanceBillUntilOptions` and `QuoteSubscriptionDataOverridesBillOnAcceptanceBillUntilOptions`
* Remove support for `LineStartsAt` on `QuoteSubscriptionDataBillOnAcceptanceBillUntilOptions` and `QuoteSubscriptionDataOverridesBillOnAcceptanceBillUntilOptions`
* Add support for `Metadata` on `TerminalReaderActionRefundPayment` and `TerminalReaderRefundPaymentOptions`
