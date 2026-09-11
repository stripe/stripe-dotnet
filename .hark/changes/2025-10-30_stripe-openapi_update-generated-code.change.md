---
title: Update generated code for private-preview
pr_link: https://github.com/stripe/stripe-dotnet/pull/3242
is_stripe_api_change: true
released_in_version: 49.2.0-alpha.2
---

* Add support for `PaymentMethodPreview` on `DelegatedCheckout.RequestedSession`
* Add support for `OrderId` on `DelegatedCheckout.RequestedSession.OrderDetails`
* Add support for `Lead` on `V2.Core.Account.Configuration.CardCreator.Capabilities.Commercial`, `V2.Core.Account.Identity.Attestations.TermsOfService.CardCreator.Commercial`, `V2CoreAccountConfigurationCardCreatorCapabilitiesCommercialOptions`, and `V2CoreAccountIdentityAttestationsTermsOfServiceCardCreatorCommercialOptions`
* Add support for `GlobalAccountHolder` on `V2.Core.Account.Identity.Attestations.TermsOfService.CardCreator.Commercial` and `V2CoreAccountIdentityAttestationsTermsOfServiceCardCreatorCommercialOptions`
