---
title: Update generated code for beta
pr_link: https://github.com/stripe/stripe-dotnet/pull/2765
is_stripe_api_change: true
released_in_version: 42.6.0-beta.1
---

* Add support for new resource `ConfirmationToken`
* Add support for `Get` method on resource `ConfirmationToken`
* Add support for `Create` method on resource `Issuing.CardDesign`
* Add support for `RejectTestmode` test helper method on resource `Issuing.CardDesign`
* Add support for `Features` on `IssuingCardBundle`
* Add support for `Preferences` on `Issuing.CardDesignListOptions`, `Issuing.CardDesignUpdateOptions`, and `IssuingCardDesign`
* Remove support for `Preference` on `Issuing.CardDesignListOptions`, `Issuing.CardDesignUpdateOptions`, and `IssuingCardDesign`
* Add support for `CardBundle` on `Issuing.CardDesignUpdateOptions`
* Add support for `CardLogo` and `CarrierText` on `Issuing.CardDesignUpdateOptions` and `IssuingCardDesign`
* Change type of `IssuingCardDesignLookupKeyOptions` and `IssuingCardDesignNameOptions` from `string` to `emptyStringable(string)`
* Add support for `RejectionReasons` on `IssuingCardDesign`
* Add support for `ConfirmationToken` on `PaymentIntentConfirmOptions`, `PaymentIntentCreateOptions`, `SetupIntentConfirmOptions`, and `SetupIntentCreateOptions`
