---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/3493
semver_level: minor
is_stripe_api_change: true
---

* Add support for new resource `V2.Core.ClaimableSandbox`
* Add support for `Create`, `Get`, and `RenewOnboardingLink` methods on resource `V2.Core.ClaimableSandbox`
* Add support for `FundingSources` on `Charge.PaymentMethodDetails.Card.Wallet.Link` and `Charge.PaymentMethodDetails.Link`
* Add support for `Fingerprint` on `Charge.PaymentMethodDetails.Paypay`, `PaymentAttemptRecord.PaymentMethodDetails.Paypay`, and `PaymentRecord.PaymentMethodDetails.Paypay`
* Add support for `AddressCollectionPrecision` on `Checkout.Session.AutomaticTax` and `CheckoutSessionAutomaticTaxOptions`
* Add support for `CarRentalData` and `LodgingData` on `PaymentIntent.PaymentDetails` and `PaymentIntentPaymentDetailsOptions`
* Change type of `PaymentLinkPaymentIntentDataOptions.CaptureMethod` from `enum('automatic'|'automatic_async'|'manual')` to `emptyable(enum('automatic'|'automatic_async'|'manual'))`
* Add support for `CaptureMethod` on `PaymentLinkPaymentIntentDataOptions`
* Add support for `LossMessage` on `Product.MarketingFeature`, `ProductMarketingFeatureOptions`, and `ProductMarketingFeaturesOptions`
* Add support for `Application` on `Refund`
* Add support for `Bizum` and `Upi` on `Refund.DestinationDetails`
* Add support for `TaxInvoiceMonth` on `Reporting.ReportRun.Parameters` and `ReportingReportRunParametersOptions`
* Add support for `Igic` on `Tax.Registration.CountryOptions.Es` and `TaxRegistrationCountryOptionsEsOptions`
* Add support for `NetworkDetails` on `Treasury.InboundTransfer.FailureDetails`, `Treasury.OutboundPayment.ReturnedDetails`, `Treasury.OutboundTransfer.ReturnedDetails`, and `TreasuryInboundTransferFailureDetailsOptions`
* Add support for `FailureDetails` on `Treasury.TestHelpersInboundTransferReturnInboundTransferOptions`
* Add support for `AccountDashboard` on `V2.Core.AccountLink.UseCase` and `V2CoreAccountLinkUseCaseOptions`
* Add support for `PaypayPayments` on `V2.Core.Account.Configuration.Merchant.Capabilities`, `V2.Core.Account.Configuration.Merchant`, `V2CoreAccountConfigurationMerchantCapabilitiesOptions`, and `V2CoreAccountConfigurationMerchantOptions`
* Add support for `BilliePayments`, `MbWayPayments`, `NzBankAccountBecsDebitPayments`, and `PixPayments` on `V2.Core.Account.Configuration.Merchant.Capabilities` and `V2CoreAccountConfigurationMerchantCapabilitiesOptions`
* Add support for `AdditionalMaterial` on `V2.Core.Account.Configuration.Merchant.KonbiniPayments` and `V2CoreAccountConfigurationMerchantKonbiniPaymentsOptions`
* Add support for event notifications `V2CoreClaimableSandboxClaimedEvent`, `V2CoreClaimableSandboxCreatedEvent`, `V2CoreClaimableSandboxExpiredEvent`, `V2CoreClaimableSandboxExpiringEvent`, and `V2CoreClaimableSandboxUpdatedEvent` with related object `V2.Core.ClaimableSandbox`
