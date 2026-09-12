---
title: Update generated code for private-preview
pr_url: https://github.com/stripe/stripe-dotnet/pull/3314
is_breaking: true
is_stripe_api_change: true
released_in_version: 50.5.0-alpha.3
---

* Add support for new resource `Radar.IssuingAuthorizationEvaluation`
* Add support for `Create` method on resource `Radar.IssuingAuthorizationEvaluation`
* ⚠️ Rename `AffiliateAttributions` to `AffiliateAttribution` on `DelegatedCheckout.RequestedSessionConfirmOptions` and `DelegatedCheckout.RequestedSessionCreateOptions`
* Add support for `AmountToCounter` on `Dispute`
* Add support for `FrozenFields` on `InvoiceItem`
* Add support for `Consumer` on `V2.Core.Account.Configuration.CardCreator.Capabilities`, `V2.Core.Account.Identity.Attestations.TermsOfService.CardCreator`, `V2CoreAccountConfigurationCardCreatorCapabilitiesOptions`, and `V2CoreAccountIdentityAttestationsTermsOfServiceCardCreatorOptions`
* Add support for `FifthThird` on `V2.Core.Account.Configuration.CardCreator.Capabilities.Commercial`, `V2.Core.Account.Identity.Attestations.TermsOfService.CardCreator.Commercial`, `V2CoreAccountConfigurationCardCreatorCapabilitiesCommercialOptions`, and `V2CoreAccountIdentityAttestationsTermsOfServiceCardCreatorCommercialOptions`
* Add support for `PrepaidCard` on `V2.Core.Account.Configuration.CardCreator.Capabilities.Commercial.CrossRiverBank`, `V2.Core.Account.Identity.Attestations.TermsOfService.CardCreator.Commercial.CrossRiverBank`, `V2CoreAccountConfigurationCardCreatorCapabilitiesCommercialCrossRiverBankOptions`, and `V2CoreAccountIdentityAttestationsTermsOfServiceCardCreatorCommercialCrossRiverBankOptions`
* Add support for `PaymentMethodData` on `V2.Payments.OffSessionPaymentCreateOptions`
