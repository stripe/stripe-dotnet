---
title: Update generated code for private-preview
pr_link: https://github.com/stripe/stripe-dotnet/pull/3407
is_breaking: true
is_stripe_api_change: true
released_in_version: 52.2.0-alpha.3
---

* Add support for `ActivateGiftCard`, `CashoutGiftCard`, `CheckGiftCardBalance`, and `ReloadGiftCard` methods on resource `Terminal.Reader`
* Add support for `AggregationPeriod` on `Billing.AlertRecovered`
* Add support for `AdministrativeAddress` and `PrincipalPlaceOfBusiness` on `Account.Company`
* Add support for `AddressCollectionPrecision` on `Checkout.Session.AutomaticTax`
* Add support for `TaxId` on `Checkout.Session.CollectedInformation`
* ⚠️ Remove support for `TaxIds` on `Checkout.Session.CollectedInformation`
* Add support for `SetupFutureUsage` on `Checkout.Session.PaymentMethodOptions.Payco`, `Checkout.Session.PaymentMethodOptions.SamsungPay`, `PaymentIntent.PaymentMethodOptions.Payco`, `PaymentIntent.PaymentMethodOptions.Paypay`, `PaymentIntent.PaymentMethodOptions.SamsungPay`, and `PaymentIntentPaymentMethodOptionsPaypayOptions`
* Add support for `Network` on `Dispute.PaymentMethodDetails.Card`
* Add support for `RequirePaymentMethodSupport` on `FinancialConnections.Session.Filters`
* Add support for `NetworkData` on `Issuing.Authorization.RequestHistory`
* Add support for `AcquiringInstitutionCountry`, `AcquiringInstitutionId`, `RetrievalReferenceNumber`, `RoutedNetwork`, and `TraceId` on `Issuing.Transaction.NetworkData`
* Add support for `CustomFields`, `Description`, and `Footer` on `Quote.InvoiceSettings`, `QuotePreviewSubscriptionSchedule.DefaultSettings.InvoiceSettings`, `QuotePreviewSubscriptionSchedule.Phase.InvoiceSettings`, `SubscriptionSchedule.DefaultSettings.InvoiceSettings`, and `SubscriptionSchedule.Phase.InvoiceSettings`
* Add support for `Paypay` on `SetupAttempt.PaymentMethodDetails`
* Add support for `MassTransitParkingTax` and `ParkingTax` on `Tax.Registration.CountryOptions.Us`
* Add support for `GiftCardBrand` on `TerminalReaderCollectConfigOptions` and `TerminalReaderProcessConfigOptions`
* Add support for `ActivateGiftCard`, `CashoutGiftCard`, `CheckGiftCardBalance`, `DeactivateGiftCard`, and `ReloadGiftCard` on `Terminal.Reader.Action`
* Add support for `StatusTransitions` on `V2.Billing.Contract`
* ⚠️ Remove support for `OneTimeFees` on `V2.Billing.ContractCreateOptions` and `V2.Billing.Contract`
* ⚠️ Remove support for `StatusDetails` on `V2.Billing.Contract`
* Add support for `Id` and `Priority` on `V2.Billing.Contract.PricingLines.Data.Pricing.PriceDetails.PricingOverrides.Data`
* ⚠️ Remove support for `PricingOverride` on `V2.Billing.Contract.PricingLines.Data.Pricing.PriceDetails.PricingOverrides.Data`
* ⚠️ Remove support for `TieringMode` and `Tiers` on `V2.Billing.Contract.PricingLines.Data.Pricing.PriceDetails.PricingOverrides.Data.OverwritePrice`, `V2BillingContractPricingLineActionAddPricingPriceDetailsPricingOverrideOverwritePriceOptions`, `V2BillingContractPricingLineActionUpdatePricingPriceDetailsPricingOverrideActionAddOverwritePriceOptions`, `V2BillingContractPricingLinePricingPriceDetailsPricingOverrideOverwritePriceOptions`, and `V2BillingContractPricingOverrideActionAddOverwritePriceOptions`
* Add support for `MultiplyPricing` on `V2.Billing.Contract.PricingOverrides.Data`, `V2BillingContractPricingOverrideActionAddOptions`, and `V2BillingContractPricingOverrideOptions`
* ⚠️ Remove support for `Multiplier` on `V2.Billing.Contract.PricingOverrides.Data`, `V2BillingContractPricingOverrideActionAddOptions`, and `V2BillingContractPricingOverrideOptions`
* ⚠️ Change type of `V2.Billing.Contract.PricingOverrides.Data.Type`, `V2BillingContractPricingOverrideActionAddOptions.Type`, and `V2BillingContractPricingOverrideOptions.Type` from `literal('multiplier')` to `literal('multiply_pricing')`
* Add support for `RelatedNetworkObject` on `V2.Core.AccountListOptions` and `V2.Core.Account`
* Add support for `NetworkBusinessProfileWallet` on `V2.MoneyManagement.PayoutMethod`
* Add support for `StripeNetworkTransfer` on `V2.MoneyManagement.ReceivedCredit`
* ⚠️ Change type of `V2BillingContractPricingLineActionAddPricingPriceDetailsPricingOverrideEndsAtOptions.Type`, `V2BillingContractPricingLineEndsAtOptions.Type`, `V2BillingContractPricingLinePricingPriceDetailsPricingOverrideEndsAtOptions.Type`, and `V2BillingContractPricingOverrideEndsAtOptions.Type` from `enum('contract_end'|'timestamp')` to `literal('timestamp')`
* ⚠️ Change type of `V2BillingContractPricingLineActionAddPricingPriceDetailsPricingOverrideStartsAtOptions.Type`, `V2BillingContractPricingLinePricingPriceDetailsPricingOverrideStartsAtOptions.Type`, `V2BillingContractPricingLineStartsAtOptions.Type`, and `V2BillingContractPricingOverrideStartsAtOptions.Type` from `enum('contract_start'|'timestamp')` to `literal('timestamp')`
* ⚠️ Change type of `V2BillingContractPricingLineActionAddEndsAtOptions.Type`, `V2BillingContractPricingLineActionUpdateEndsAtOptions.Type`, `V2BillingContractPricingLineActionUpdatePricingPriceDetailsPricingOverrideActionAddEndsAtOptions.Type`, `V2BillingContractPricingLineActionUpdatePricingPriceDetailsPricingOverrideActionUpdateEndsAtOptions.Type`, `V2BillingContractPricingOverrideActionAddEndsAtOptions.Type`, and `V2BillingContractPricingOverrideActionUpdateEndsAtOptions.Type` from `enum('billing_period_end'|'timestamp')` to `literal('timestamp')`
* ⚠️ Change type of `V2BillingContractPricingLineActionAddStartsAtOptions.Type`, `V2BillingContractPricingLineActionUpdatePricingPriceDetailsPricingOverrideActionAddStartsAtOptions.Type`, `V2BillingContractPricingLineActionUpdatePricingPriceDetailsPricingOverrideActionUpdateStartsAtOptions.Type`, `V2BillingContractPricingLineActionUpdateStartsAtOptions.Type`, `V2BillingContractPricingOverrideActionAddStartsAtOptions.Type`, and `V2BillingContractPricingOverrideActionUpdateStartsAtOptions.Type` from `enum('billing_period_start'|'timestamp')` to `literal('timestamp')`
* Add support for event notifications `V2BillingContractActivatedEvent`, `V2BillingContractCanceledEvent`, `V2BillingContractCreatedEvent`, `V2BillingContractEndedEvent`, and `V2BillingContractUpdatedEvent` with related object `V2.Billing.Contract`
