---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/3480
semver_level: major
is_stripe_api_change: true
---

* Add support for new resources `Risk.Form` and `V2.Data.SearchResultList`
* Add support for `Get` and `Update` methods on resource `Risk.Form`
* Add support for `Search` method on resource `V2.Data.SearchResultList`
* Add support for `BusinessProfileManagement` and `ReportingChart` on `AccountSession.Components`
* Add support for `SubscriptionPause` on `BillingPortal.Configuration.Features`
* Add support for `MarketingAttributions` on `Checkout.SessionCreateOptions` and `Checkout.Session`
* Add support for `MetronomeCommit` on `Checkout.Session.Item` and `CheckoutSessionItemOptions`
* Add support for `AdjustableQuantity` on `CheckoutSessionItemSubscriptionItemOptions`
* Add support for `MandateOptions` on `Checkout.Session.PaymentMethodOptions.Card`
* ⚠️ Remove support for `Details` on `Identity.VerificationReport.Email`
* Add support for `MerchantAmountExchangeRate` on `Issuing.TestHelpersAuthorizationCaptureOptions`, `Issuing.TestHelpersAuthorizationCreateOptions`, and `Issuing.TestHelpersTransactionCreateForceCaptureOptions`
* Add support for `Type` on `Issuing.Authorization` and `Issuing.TestHelpersAuthorizationCreateOptions`
* Add support for `SettlementDetails` on `Issuing.TestHelpersAuthorizationCaptureOptions` and `Issuing.TestHelpersTransactionCreateForceCaptureOptions`
* ⚠️ Remove support for `Healthcare` on `IssuingAuthorizationPurchaseDetailsOptions` and `IssuingTransactionPurchaseDetailsOptions`
* Add support for `ProductEligibilityInquiry` on `Issuing.Authorization`
* Add support for `AccountTaxIds`, `CustomFields`, `Description`, and `Footer` on `PaymentLink.SubscriptionData.InvoiceSettings`
* Add support for `ReferenceStatus` and `Reference` on `Refund.DestinationDetails.AfterpayClearpay`, `Refund.DestinationDetails.Klarna`, and `Refund.DestinationDetails.Paypal`
* Add support for `Bw`, `Ci`, `Gh`, and `Mu` on `Tax.Registration.CountryOptions`
* Add support for `Czk`, `Nok`, `Pln`, and `Sek` on `V2.Core.Account.Configuration.MoneyManager.Capabilities.BusinessStorage.Inbound`, `V2.Core.Account.Configuration.MoneyManager.Capabilities.BusinessStorage.Outbound`, `V2CoreAccountConfigurationMoneyManagerCapabilitiesBusinessStorageInboundOptions`, and `V2CoreAccountConfigurationMoneyManagerCapabilitiesBusinessStorageOutboundOptions`
* Add support for `StablecoinCustodial` on `V2.Core.Account.Configuration.Recipient.Capabilities.StripeBalance` and `V2CoreAccountConfigurationRecipientCapabilitiesStripeBalanceOptions`
* Add support for `AccountTakeoverConfirmation`, `AccountTakeoverReport`, `CredentialChange`, `MfaAddition`, and `MfaRemoval` on `V2.Signals.AccountActivityCreateOptions`, `V2.Signals.AccountActivity`, and `V2SignalsAccountEvaluationAccountActivityDetailsDataOptions`
* Add support for `AccountTakeover` on `V2.Signals.AccountEvaluation.EvaluatedSignals` and `V2.Signals.AccountSignal`
* Add support for `CustomerRisk` on `V2.Signals.AccountSignal`
* Add support for event notification `V2SignalsAccountSignalCustomerRiskReadyEvent` with related object `V2.Signals.AccountSignal`
