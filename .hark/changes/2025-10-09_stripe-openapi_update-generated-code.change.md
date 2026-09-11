---
title: Update generated code for private-preview
pr_link: https://github.com/stripe/stripe-dotnet/pull/3218
is_stripe_api_change: true
released_in_version: 49.1.0-alpha.2
---

* Add support for new resource `PaymentMethodBalance`
* Add support for `CheckBalance` method on resource `PaymentMethod`
* Add support for `Benefits` on `Card`, `Charge.PaymentMethodDetails.Card`, `ConfirmationToken.PaymentMethodPreview.Card`, and `PaymentMethod.Card`
* Add support for `Benefit` on `PaymentIntent.PaymentDetails` and `PaymentIntentPaymentDetailsOptions`
* Add support for `SetupDetails` on `SetupIntentConfirmOptions`, `SetupIntentCreateOptions`, `SetupIntentUpdateOptions`, and `SetupIntent`
* Add support for `CardCreator` on `V2.Core.Account.Configuration`, `V2.Core.Account.Identity.Attestations.TermsOfService`, `V2CoreAccountConfigurationOptions`, and `V2CoreAccountIdentityAttestationsTermsOfServiceOptions`
* Add support for thin events `V2CoreAccountIncludingConfigurationCardCreatorCapabilityStatusUpdatedEvent` and `V2CoreAccountIncludingConfigurationCardCreatorUpdatedEvent` with related object `V2.Core.Account`
* Remove support for thin events `V1CustomerDiscountCreatedEvent`, `V1CustomerDiscountDeletedEvent`, and `V1CustomerDiscountUpdatedEvent` with related object `Discount`
