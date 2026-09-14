---
title: Update generated code for beta
pr_url: https://github.com/stripe/stripe-dotnet/pull/3180
is_stripe_api_change: true
released_in_version: 49.1.0-beta.1
---

* Add support for new resources `V2.Billing.BillSettingVersion`, `V2.Billing.BillSetting`, `V2.Billing.Cadence`, `V2.Billing.CollectionSettingVersion`, `V2.Billing.CollectionSetting`, and `V2.Billing.Profile`
* Add support for `Create`, `Get`, `List`, and `Update` methods on resources `V2.Billing.BillSetting`, `V2.Billing.CollectionSetting`, and `V2.Billing.Profile`
* Add support for `Get` and `List` methods on resources `V2.Billing.BillSettingVersion` and `V2.Billing.CollectionSettingVersion`
* Add support for `Cancel`, `Create`, `Get`, `List`, and `Update` methods on resource `V2.Billing.Cadence`
* Add support for `Profile` on `V2.Core.Account.Defaults` and `V2CoreAccountDefaultsOptions`
* Add support for `IP` on `V2.Core.Account.Identity.Attestations.DirectorshipDeclaration`, `V2.Core.Account.Identity.Attestations.OwnershipDeclaration`, `V2.Core.Account.Identity.Attestations.TermsOfService.Account`, `V2.Core.Account.Identity.Attestations.TermsOfService.Storer`, `V2.Core.Account.Identity.Individual.AdditionalTermsOfService.Account`, `V2.Core.Person.AdditionalTermsOfService.Account`, `V2CoreAccountIdentityAttestationsTermsOfServiceAccountOptions`, `V2CoreAccountIdentityAttestationsTermsOfServiceStorerOptions`, and `V2CorePersonAdditionalTermsOfServiceAccountOptions`
* Remove support for `Ip` on `V2.Core.Account.Identity.Attestations.DirectorshipDeclaration`, `V2.Core.Account.Identity.Attestations.OwnershipDeclaration`, `V2.Core.Account.Identity.Attestations.TermsOfService.Account`, `V2.Core.Account.Identity.Attestations.TermsOfService.Storer`, `V2.Core.Account.Identity.Individual.AdditionalTermsOfService.Account`, `V2.Core.Person.AdditionalTermsOfService.Account`, `V2CoreAccountIdentityAttestationsTermsOfServiceAccountOptions`, `V2CoreAccountIdentityAttestationsTermsOfServiceStorerOptions`, and `V2CorePersonAdditionalTermsOfServiceAccountOptions`
* Remove support for `DoingBusinessAs`, `ProductDescription`, and `Url` on `V2.Core.Account.Identity.BusinessDetails` and `V2CoreAccountIdentityBusinessDetailsOptions`
* Add support for `SettlementCurrency` on `V2.MoneyManagement.FinancialAddress`
* Add support for `SepaBankAccount` on `V2.MoneyManagement.FinancialAddress.Credentials` and `V2.MoneyManagement.ReceivedCredit.BankTransfer`
* Add support for `AmountDetails` and `PaymentsOrchestration` on `V2.Payments.OffSessionPaymentCreateOptions` and `V2.Payments.OffSessionPayment`
* Add support for `RetryPolicy` on `V2.Payments.OffSessionPayment.RetryDetails` and `V2PaymentsOffSessionPaymentRetryDetailsOptions`
* Change type of `V2.MoneyManagement.OutboundPaymentQuote.FxQuote.LockDuration` from `literal('five_minutes')` to `enum('five_minutes'|'none')`
* Change type of `V2.MoneyManagement.OutboundPaymentQuote.FxQuote.LockExpiresAt` from `DateTime` to `nullable(DateTime)`
* Add support for `OriginType` on `V2.MoneyManagement.ReceivedCredit.BankTransfer`
* Remove support for `PaymentMethodType` on `V2.MoneyManagement.ReceivedCredit.BankTransfer`
* Add support for `MandateData` and `PaymentMethodOptions` on `V2.Payments.OffSessionPaymentCreateOptions`
* Add support for `Type` on `V2.MoneyManagement.FinancialAddressCreateOptions`
* Remove support for `Currency` on `V2.MoneyManagement.FinancialAddressCreateOptions`
* Add support for thin event `V2BillingBillSettingUpdatedEvent` with related object `V2.Billing.BillSetting`
* Add support for error type `RateLimitException`
