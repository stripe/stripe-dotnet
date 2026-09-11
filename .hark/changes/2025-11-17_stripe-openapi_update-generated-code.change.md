---
title: Update generated code for beta
pr_link: https://github.com/stripe/stripe-dotnet/pull/3241
is_stripe_api_change: true
released_in_version: 50.1.0-beta.1
---

* Add support for new resources `V2.Core.AccountPersonToken` and `V2.Core.AccountToken`
* Remove support for resource `V2.Payments.OffSessionPayment`
* Add support for `Create` and `Get` methods on resources `V2.Core.AccountPersonToken` and `V2.Core.AccountToken`
* Remove support for `Cancel`, `Capture`, `Create`, `Get`, and `List` methods on resource `V2.Payments.OffSessionPayment`
* Add support for `SpecifiedCommercialTransactionsActUrl` on `Account.BusinessProfile` and `AccountBusinessProfileOptions`
* Add support for `PaypayPayments` on `Account.Settings` and `AccountSettingsOptions`
* Change type of `BillingAnalyticsMeterUsageMeterOptions.DimensionFilters` from `string` to `array(string)`
* Change type of `BillingAnalyticsMeterUsageMeterOptions.TenantFilters` from `string` to `array(string)`
* Add support for `CarRentalData`, `FlightData`, and `LodgingData` on `ChargePaymentDetailsOptions` and `PaymentIntentPaymentDetailsOptions`
* Add support for `SupplementaryPurchaseData` on `OrderPaymentSettingsPaymentMethodOptionsKlarnaOptions` and `PaymentIntentPaymentMethodOptionsKlarnaOptions`
* Add support for `AllowRedisplay` and `CustomerAccount` on `PaymentMethodListOptions`
* Add support for `FutureRequirements` on `V2.Core.Account`
* Add support for `KonbiniPayments` and `ScriptStatementDescriptor` on `V2.Core.Account.Configuration.Merchant` and `V2CoreAccountConfigurationMerchantOptions`
* Add support for `Eur` on `V2.Core.Account.Configuration.Storer.Capabilities.HoldsCurrencies` and `V2CoreAccountConfigurationStorerCapabilitiesHoldsCurrenciesOptions`
* Add support for `RequirementsCollector` on `V2.Core.Account.Defaults.Responsibilities`
* Remove support for `Collector` on `V2.Core.Account.Requirements`
* Add support for `Changes` on `V2.Core.Event`
* Add support for `AccountToken` on `V2.Core.AccountCreateOptions` and `V2.Core.AccountUpdateOptions`
* Add support for `PersonToken` on `V2.Core.AccountPersonCreateOptions` and `V2.Core.AccountPersonUpdateOptions`
* Add support for thin event `V2CoreHealthEventGenerationFailureResolvedEvent`
* Remove support for thin events `V2PaymentsOffSessionPaymentAuthorizationAttemptFailedEvent`, `V2PaymentsOffSessionPaymentAuthorizationAttemptStartedEvent`, `V2PaymentsOffSessionPaymentCanceledEvent`, `V2PaymentsOffSessionPaymentCreatedEvent`, `V2PaymentsOffSessionPaymentFailedEvent`, `V2PaymentsOffSessionPaymentRequiresCaptureEvent`, and `V2PaymentsOffSessionPaymentSucceededEvent` with related object `V2.Payments.OffSessionPayment`
