---
title: Update generated code for private-preview
pr_link: https://github.com/stripe/stripe-dotnet/pull/3235
is_stripe_api_change: true
released_in_version: 49.2.0-alpha.1
---

* Add support for `ReportRefund` method on resource `PaymentRecord`
* Add support for `RepresentativeDeclaration` on `Account.Company`, `AccountCompanyOptions`, and `TokenAccountCompanyOptions`
* Add support for `PaymentMethodConfiguration` on `BillingPortalConfigurationFeaturesPaymentMethodUpdateOptions`
* Add support for `PaymentPortalUrl` on `Charge.PaymentMethodDetails.Rechnung`, `PaymentAttemptRecord.PaymentMethodDetails.Rechnung`, and `PaymentRecord.PaymentMethodDetails.Rechnung`
* Add support for `Twint` on `Checkout.Session.PaymentMethodOptions` and `CheckoutSessionPaymentMethodOptionsOptions`
* Add support for `CustomerSheet`, `MobilePaymentElement`, and `TaxIdElement` on `CustomerSession.Components` and `CustomerSessionComponentsOptions`
* Add support for `Provider` on `Customer.Tax`
* Add support for `StartingAfter` on `PaymentAttemptRecordListOptions`
* Add support for `Reference` on `PaymentIntentAmountDetailsLineItem.PaymentMethodOptions.Klarna` and `PaymentIntentAmountDetailsLineItemsPaymentMethodOptionsKlarnaOptions`
* Add support for `SubscriptionReference` on `PaymentIntentAmountDetailsLineItem.PaymentMethodOptions.Klarna`
* Add support for `NameCollection` on `PaymentLinkCreateOptions`, `PaymentLinkUpdateOptions`, and `PaymentLink`
* Add support for `Crypto` on `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, and `Refund.DestinationDetails`
* Add support for `MbWay` on `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, and `PaymentMethodConfiguration`
* Add support for `Custom` on `PaymentMethodCreateOptions` and `PaymentMethod`
* Add support for `ExcludedPaymentMethodTypes` on `SetupIntentCreateOptions`, `SetupIntentUpdateOptions`, and `SetupIntent`
* Add support for `Tw` on `Tax.Registration.CountryOptions` and `TaxRegistrationCountryOptionsOptions`
* Add support for `Gip` on `Terminal.Configuration.Tipping` and `TerminalConfigurationTippingOptions`
* Add support for `LastSeenAt` on `Terminal.Reader`
* Add support for `HighRiskActivitiesDescription`, `HighRiskActivities`, `MoneyServicesDescription`, `OperatesInProhibitedCountries`, `ParticipatesInRegulatedActivity`, `PurposeOfFundsDescription`, `PurposeOfFunds`, `RegulatedActivity`, `SourceOfFundsDescription`, and `SourceOfFunds` on `V2.Core.Account.Configuration.Storer` and `V2CoreAccountConfigurationStorerOptions`
* Add support for `CryptoWallets` on `V2.Core.Account.Configuration.Storer.Capabilities.FinancialAddresses`, `V2.Core.Account.Configuration.Storer.Capabilities.OutboundPayments`, `V2.Core.Account.Configuration.Storer.Capabilities.OutboundTransfers`, `V2CoreAccountConfigurationStorerCapabilitiesFinancialAddressesOptions`, `V2CoreAccountConfigurationStorerCapabilitiesOutboundPaymentsOptions`, and `V2CoreAccountConfigurationStorerCapabilitiesOutboundTransfersOptions`
* Add support for `Usdc` on `V2.Core.Account.Configuration.Storer.Capabilities.HoldsCurrencies` and `V2CoreAccountConfigurationStorerCapabilitiesHoldsCurrenciesOptions`
* Add support for `CryptoStorer` on `V2.Core.Account.Identity.Attestations.TermsOfService` and `V2CoreAccountIdentityAttestationsTermsOfServiceOptions`
* Add support for `ComplianceScreeningDescription` on `V2.Core.Account.Identity.BusinessDetails` and `V2CoreAccountIdentityBusinessDetailsOptions`
* Add support for `ExternalAmount` on `V2.MoneyManagement.ReceivedCredit` and `V2.MoneyManagement.ReceivedDebit`
