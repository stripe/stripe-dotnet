# Changelog

## 50.1.0-beta.1 - 2025-11-18
This release changes the pinned API version to `2025-11-17.preview`.

* [#3241](https://github.com/stripe/stripe-dotnet/pull/3241) Update generated code for beta
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
  * Add support for `changes` on `V2.Core.Event`
  * Add support for thin event `V2CoreHealthEventGenerationFailureResolvedEvent`
  * Remove support for thin events `V2PaymentsOffSessionPaymentAuthorizationAttemptFailedEvent`, `V2PaymentsOffSessionPaymentAuthorizationAttemptStartedEvent`, `V2PaymentsOffSessionPaymentCanceledEvent`, `V2PaymentsOffSessionPaymentCreatedEvent`, `V2PaymentsOffSessionPaymentFailedEvent`, `V2PaymentsOffSessionPaymentRequiresCaptureEvent`, and `V2PaymentsOffSessionPaymentSucceededEvent` with related object `V2.Payments.OffSessionPayment`

## 50.0.0 - 2025-11-18
This release changes the pinned API version to `2025-11-17.clover`.

* [#3256](https://github.com/stripe/stripe-dotnet/pull/3256) Update generated code
  * ⚠️ Remove support for `Gt`, `Gte`, `Lt`, and `Lte` on `V2.Core.EventListOptions` in favor of `Created`.
* [#3254](https://github.com/stripe/stripe-dotnet/pull/3254) Check if a datetime is in millis
  * Bug fix for [#3253](https://github.com/stripe/stripe-dotnet/issues/3253). UnixDateTimeConverter now handles timestamps in milliseconds. 
* [#3249](https://github.com/stripe/stripe-dotnet/pull/3249) Update v2 array parameter serialization to use indexed format
  - `Retrieve` and `List` calls for `/v2` endpoints now use indexed format (e.g., `?include[0]=foo&include[1]=bar`) instead of repeated parameter format (e.g., `?include=foo&include=bar`) when communicating with the Stripe API. This may break any unit tests that expect the latter behavior when setting up a mock server. Instead, they should now expect the former.
* [#3246](https://github.com/stripe/stripe-dotnet/pull/3246) Update generated code
  * Add support for new resources `Tax.Association` and `Terminal.OnboardingLink`
  * Add support for `Find` method on resource `Tax.Association`
  * Add support for `Create` method on resource `Terminal.OnboardingLink`
  * Add support for `PaymentMethodConfiguration` on `BillingPortal.Configuration.Features.PaymentMethodUpdate`
  * Add support for `TransactionId` on `Charge.PaymentMethodDetails.Ideal`, `PaymentAttemptRecord.PaymentMethodDetails.Ideal`, and `PaymentRecord.PaymentMethodDetails.Ideal`
  * Add support for `Created` on `CustomerCustomerBalanceTransactionListOptions` and `InvoicePaymentListOptions`
  * Add support for `AccountNumbers` on `FinancialConnections.Account`
  * Add support for `FraudRisk` on `IssuingAuthorizationRiskAssessmentOptions`
  * Add support for `LatestFraudWarning` on `Issuing.Card`
  * Add support for `Hooks` on `PaymentIntentCaptureOptions`, `PaymentIntentConfirmOptions`, `PaymentIntentCreateOptions`, `PaymentIntentIncrementAuthorizationOptions`, `PaymentIntentUpdateOptions`, and `PaymentIntent`
  * Add support for `MbWay` and `Twint` on `Refund.DestinationDetails`
  * Add support for snapshot events `FinancialConnectionsAccountAccountNumbersUpdated` and `FinancialConnectionsAccountUpcomingAccountNumberExpiry` with resource `FinancialConnections.Account`

## 49.2.0 - 2025-11-05
* [#3244](https://github.com/stripe/stripe-dotnet/pull/3244) Update generated code
  * Add support for `CaptureMethod` on `PaymentIntent.PaymentMethodOptions.CardPresent` and `PaymentIntentPaymentMethodOptionsCardPresentOptions`

## 49.2.0-beta.1 - 2025-10-29

This release changes the pinned API version to `2025-10-29.preview`.

* [#3234](https://github.com/stripe/stripe-dotnet/pull/3234) Update generated code for beta
  * Add support for `CryptoStorer` on `V2CoreAccountIdentityAttestationsTermsOfServiceOptions`
* [#3211](https://github.com/stripe/stripe-dotnet/pull/3211) Update generated code for beta
  * Add support for `Update` method on resource `V2.MoneyManagement.FinancialAccount`
  * Add support for `ConfirmMicrodeposits`, `List`, and `SendMicrodeposits` methods on resource `V2.Core.Vault.UsBankAccount`
  * Add support for `List` method on resource `V2.Core.Vault.GbBankAccount`
  * Add support for `PaymentPortalUrl` on `Charge.PaymentMethodDetails.Rechnung`, `PaymentAttemptRecord.PaymentMethodDetails.Rechnung`, and `PaymentRecord.PaymentMethodDetails.Rechnung`
  * Add support for `TaxIdElement` on `CustomerSession.Components` and `CustomerSessionComponentsOptions`
  * Add support for `StartingAfter` on `PaymentAttemptRecordListOptions`
  * Add support for `Reference` on `PaymentIntentAmountDetailsLineItem.PaymentMethodOptions.Klarna` and `PaymentIntentAmountDetailsLineItemsPaymentMethodOptionsKlarnaOptions`
  * Add support for `SubscriptionReference` on `PaymentIntentAmountDetailsLineItem.PaymentMethodOptions.Klarna`
  * Add support for `Closed` on `V2.Core.AccountListOptions` and `V2.Core.Account`
  * Add support for `Usd` on `V2.Core.Account.Configuration.Storer.Capabilities.HoldsCurrencies` and `V2CoreAccountConfigurationStorerCapabilitiesHoldsCurrenciesOptions`
  * Add support for `RepresentativeDeclaration` on `V2.Core.Account.Identity.Attestations` and `V2CoreAccountIdentityAttestationsOptions`
  * Add support for `Verification` on `V2.Core.Vault.UsBankAccount`
  * Add support for `V1Id` on `EventsV2MoneyManagementTransactionCreatedEvent`
  * Remove support for thin event `V2BillingBillSettingUpdatedEvent` with related object `V2.Billing.BillSetting`

## 49.1.0 - 2025-10-29

This release changes the pinned API version to `2025-10-29.clover`.

* [#3236](https://github.com/stripe/stripe-dotnet/pull/3236) Update generated code
  * Improve docs for PaymentIntent related endpoints
* [#3230](https://github.com/stripe/stripe-dotnet/pull/3230) Update generated code
  * Add support for new resources `PaymentAttemptRecord`, `PaymentIntentAmountDetailsLineItem`, and `PaymentRecord`
  * Add support for `Get` and `List` methods on resource `PaymentAttemptRecord`
  * Add support for `Get`, `ReportPaymentAttemptCanceled`, `ReportPaymentAttemptFailed`, `ReportPaymentAttemptGuaranteed`, `ReportPaymentAttemptInformational`, `ReportPaymentAttempt`, `ReportPayment`, and `ReportRefund` methods on resource `PaymentRecord`
  * Add support for `List` method on resource `PaymentIntentAmountDetailsLineItem`
  * Add support for `RepresentativeDeclaration` on `Account.Company`, `AccountCompanyOptions`, and `TokenAccountCompanyOptions`
  * Add support for `PaymentMethodConfiguration` on `BillingPortalConfigurationFeaturesPaymentMethodUpdateOptions`
  * Add support for `Twint` on `Checkout.Session.PaymentMethodOptions` and `CheckoutSessionPaymentMethodOptionsOptions`
  * Add support for `PaymentRecordRefund` and `Type` on `CreditNote.Refund` and `CreditNoteRefundOptions`
  * Add support for `CustomerSheet` and `MobilePaymentElement` on `CustomerSession.Components` and `CustomerSessionComponentsOptions`
  * Add support for `Provider` on `Customer.Tax`
  * Add support for `PaymentRecord` on `InvoiceAttachPaymentOptions`, `InvoicePayment.Payment`, and `InvoicePaymentPaymentOptions`
  * Change type of `InvoicePaymentPaymentOptions.Type` from `literal('payment_intent')` to `enum('payment_intent'|'payment_record')`
  * Add support for `AmountDetails` on `PaymentIntentCaptureOptions`, `PaymentIntentConfirmOptions`, `PaymentIntentCreateOptions`, `PaymentIntentIncrementAuthorizationOptions`, and `PaymentIntentUpdateOptions`
  * Add support for `PaymentDetails` on `PaymentIntentCaptureOptions`, `PaymentIntentConfirmOptions`, `PaymentIntentCreateOptions`, `PaymentIntentIncrementAuthorizationOptions`, `PaymentIntentUpdateOptions`, and `PaymentIntent`
  * Add support for `DiscountAmount`, `LineItems`, `Shipping`, and `Tax` on `PaymentIntent.AmountDetails`
  * Add support for `NameCollection` on `PaymentLinkCreateOptions`, `PaymentLinkUpdateOptions`, and `PaymentLink`
  * Add support for `Crypto` on `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, and `Refund.DestinationDetails`
  * Add support for `MbWay` on `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, and `PaymentMethodConfiguration`
  * Add support for `Custom` on `PaymentMethodCreateOptions` and `PaymentMethod`
  * Add support for `ExcludedPaymentMethodTypes` on `SetupIntentCreateOptions`, `SetupIntentUpdateOptions`, and `SetupIntent`
  * Add support for `Tw` on `Tax.Registration.CountryOptions` and `TaxRegistrationCountryOptionsOptions`
  * Add support for `Gip` on `Terminal.Configuration.Tipping` and `TerminalConfigurationTippingOptions`
  * Add support for `LastSeenAt` on `Terminal.Reader`
  * Add support for `Gt`, `Gte`, `Lt`, `Lte`, and `Types` on `V2.Core.EventListOptions`
  * Add support for snapshot event `BalanceSettingsUpdated` with resource `BalanceSettings`
  * Add support for snapshot event `InvoicePaymentAttemptRequired` with resource `Invoice`
* [#3223](https://github.com/stripe/stripe-dotnet/pull/3223) Fixes STJDefaultConverter to safely ignore unknown properties
  * Fixes a bug when using System.Text.Json to deserialize JSON that has properties not present in the target object.

## 49.1.0-beta.1 - 2025-09-30
This release changes the pinned API version to `2025-09-30.preview`. It is built on top of SDK version 49.0.0 which contains breaking changes. Please review the [changelog for 49.0.0](https://github.com/stripe/stripe-dotnet/blob/master/CHANGELOG.md#4900---2025-09-30) if upgrading from older SDK versions.

* [#3193](https://github.com/stripe/stripe-dotnet/pull/3193) Update generated code for beta
  * Add support for `AttachCadence` method on resource `Subscription`
  * Add support for `BillingCadence` on `InvoiceCreatePreviewOptions`, `SubscriptionCreateOptions`, `SubscriptionUpdateOptions`, and `Subscription`
  * Add support for `BillingCadenceDetails` on `Invoice.Parent` and `QuotePreviewInvoice.Parent`
* [#3191](https://github.com/stripe/stripe-dotnet/pull/3191) Update generated code for beta
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
* [#3180](https://github.com/stripe/stripe-dotnet/pull/3180) Update generated code for beta
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
* [#3178](https://github.com/stripe/stripe-dotnet/pull/3178) Update generated code for beta
  * Add support for new resources `Billing.Analytics.MeterUsageRow` and `Billing.Analytics.MeterUsage`
  * Remove support for resources `Billing.MeterUsageRow` and `Billing.MeterUsage`
  * Add support for `Get` method on resource `Billing.Analytics.MeterUsage`
  * Remove support for `Get` method on resource `Billing.MeterUsage`
  * Add support for `ReportPaymentAttemptInformational` method on resource `PaymentRecord`
  * Add support for `MinimumBalanceByCurrency` on `BalanceSettings.Payments.Payouts` and `BalanceSettingsPaymentsPayoutsOptions`
  * Change type of `BalanceSettingsPaymentsSettlementTimingOptions.DelayDaysOverride` from `longInteger` to `emptyable(longInteger)`
  * Add support for `DelayDaysOverride` on `BalanceSettings.Payments.SettlementTiming`
  * Add support for `AutomaticTax` and `InvoiceCreation` on `Checkout.SessionUpdateOptions`
  * Add support for `UnitLabel` on `CheckoutSessionLineItemPriceDataProductDataOptions`
  * Add support for `InvoiceSettings` on `CheckoutSessionSubscriptionDataOptions`
  * Add support for `IntendedSubmissionMethod` on `DisputeUpdateOptions` and `Dispute`
  * Change type of `Dispute.SmartDisputes.RecommendedEvidence` from `string` to `array(string)`
  * Add support for `Pix` on `Invoice.PaymentSettings.PaymentMethodOptions`, `InvoicePaymentSettingsPaymentMethodOptionsOptions`, `QuotePreviewInvoice.PaymentSettings.PaymentMethodOptions`, `Subscription.PaymentSettings.PaymentMethodOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptionsOptions`
  * Add support for `BillingSchedules` on `InvoiceSubscriptionDetailsOptions`, `SubscriptionCreateOptions`, `SubscriptionUpdateOptions`, and `Subscription`
  * Add support for `Paypay` on `PaymentAttemptRecord.PaymentMethodDetails` and `PaymentRecord.PaymentMethodDetails`
  * Add support for `Wallet` on `PaymentAttemptRecord.PaymentMethodDetails.Card` and `PaymentRecord.PaymentMethodDetails.Card`
  * Add support for `Flexible` on `QuotePreviewSubscriptionSchedule.BillingMode`
  * Add support for `BilledUntil` on `SubscriptionItem`

## 49.0.0 - 2025-09-30
This release changes the pinned API version to `2025-09-30.clover` and contains breaking changes (prefixed with ⚠️ below)

* [#3168](https://github.com/stripe/stripe-dotnet/pull/3168) ⚠️ Add strongly typed EventNotifications
  We've overhauled how V2 Events are handled in the SDK! This approach should provide a lot more information at authoring and compile time, leading to more robust integrations. As part of this process, there are a number of changes to be aware of.
  - Added matching `EventNotification` classes to every v2 `Event`. For example, there's now a `V1BillingMeterErrorReportTriggeredEventNotification` to match the existing `V1BillingMeterErrorReportTriggeredEvent`. Each notification class defines a `fetchEvent()` method to retrieve its corresponding event. For events with related objects, there's a `fetchRelatedObject()` method that performs the API call and casts the response to the correct type.
  - ⚠️ Rename function `StripeClient.parseThinEvent` to `StripeClient.parseEventNotification` and remove the `Stripe.ThinEvent` class.
      - This function now returns a `Stripe.V2.Core.EventNotification` (which is the shared base class that all of the more specific `Stripe..Events.*EventNotification` classes  share) instead of `Stripe.ThinEvent`. When applicable, these event notifications will have the `relatedObject` property and a `fetchRelatedObject()` function. They also have a `fetchEvent()` method to retrieve their corresponding `Stripe.Event.*Event` instance.
      - If you parse an event the SDK doesn't have types for (e.g. it's newer than the SDK you're using), you'll get an instance of `Stripe.Events.UnknownEventNotification` instead of a more specific type. It has both the `relatedObject` property and the `FetchRelatedObject()` function (but they may be/return `null`)
* [#3194](https://github.com/stripe/stripe-dotnet/pull/3194) Add `StripeContext` object
  - Add the `StripeContext` class. Previously, one could only pass a string for `StripeContext` property of the `RequestOptions` class. You can now use the new class as well.
  - ⚠️ Change `EventNotification` (formerly known as `ThinEvent`)'s `context` property from `string` to `StripeContext`
* [#3200](https://github.com/stripe/stripe-dotnet/pull/3200) Move `V2.Event` API resources to `V2.Core.Events`
  - ⚠️ Move all V2 Event-related classes (`Event`, `EventDestination`,`EventReason` etc) from `Stripe.V2` to `Stripe.V2.Core`. They now correctly match their API path and are in line with all other resources. To update your code:
     - `Stripe.V2.Event` -> `Stripe.V2.Core.Event`
     - `Stripe.V2.EventDestination` -> `Stripe.V2.Core.EventDestination`
     - `Stripe.V2.EventReason` -> `Stripe.V2.Core.EventReason`
     - `Stripe.V2.EventReasonRequest` -> `Stripe.V2.Core.EventReasonRequest`
     - `Stripe.V2.EventRelatedObject` -> `Stripe.V2.Core.EventRelatedObject`
* [#3206](https://github.com/stripe/stripe-dotnet/pull/3206) ⚠️ Drop support for .NET Core 3.1 & clarify policy
  -  Read our new [language version support policy](https://docs.stripe.com/sdks/versioning?lang=dotnet#stripe-sdk-language-version-support-policy)
       - ⚠️ In this release, we drop support for .NET Core 3.1.
       - Support for .NET Core versions 5 & 7 are deprecated and will be removed in the next major version scheduled for March 2026
* [#3197](https://github.com/stripe/stripe-dotnet/pull/3197) Remove unused obsolete classes SourceTransactionsListOptions and SourceTransactionsGetOptions
  * ⚠️ Removed class `SourceTransactionsListOptions` in favor of `SourceTransactionListOptions`
  * ⚠️ Removed unused class `SourceTransactionsGetOptions`
* [#3167](https://github.com/stripe/stripe-dotnet/pull/3167) ⚠️ Build SDK w/ V2 OpenAPI spec
  - ⚠️ The delete methods for v2 APIs (the ones in the `StripeClient.v2` namespace) now return a `V2DeletedObject` which has the id of the object that has been deleted and a string representing the type of the object that has been deleted.
* [#3171](https://github.com/stripe/stripe-dotnet/pull/3171) Adds ability to specify file name and type when calling FileService.Create
  * ⚠️ Changes `FileCreateOptions`.`File` from a `Stream` to a `MultipartFileContent` type.  This type lets you optionally specify a `Name` and `Type` to use when creating the file.
* [#3174](https://github.com/stripe/stripe-dotnet/pull/3174) `just format` formats entire solution
* [#3172](https://github.com/stripe/stripe-dotnet/pull/3172) Update generated code
  * ⚠️ Changes type of `UseStripeSdk` in `PaymentIntentNextAction` and `SetupIntentNextAction` to be `Dictionary<string, object>`
  * ⚠️ Removes `PaymentIntentNextActionUseStripeSdk` and `SetupIntentNextActionUseStripeSdk`
* [#3170](https://github.com/stripe/stripe-dotnet/pull/3170) Adds public BaseUrl to RawRequestOptions
  * Adds `BaseUrl` to `RawRequestOptions` for raw request calls to endpoints at hosts other than `api.stripe.com`


* [#3175](https://github.com/stripe/stripe-dotnet/pull/3175), [#3190](https://github.com/stripe/stripe-dotnet/pull/3190), [#3205](https://github.com/stripe/stripe-dotnet/pull/3205) Update generated code based on incoming API changes in the `2025-09-30.clover` API version.
  * ⚠️ Remove support for `BalanceReport` and `PayoutReconciliationReport` on `AccountSession.Components` and `AccountSessionComponentsOptions`
  * ⚠️ Change type of `InvoiceSubscriptionDetailsOptions.CancelAt`, `SubscriptionCreateOptions.CancelAt` and `SubscriptionUpdateOptions.CancelAt` from `DateTime` to `DateTime | enum('max_period_end'|'min_period_end')`
  * ⚠️ Remove support for `Coupon` on `Discount`, `PromotionCodeCreateOptions`, and `PromotionCode`. Use `Discount.Source.Coupon`, `PromotionCodeCreateOptions.Promotion.Coupon`, and `PromotionCode.Promotion.Coupon` instead.
  * ⚠️ Remove support for `Link` and `PayByBank` on `PaymentMethodUpdateOptions`
  * Add support for new resource `BalanceSettings`
  * Add support for `Get` and `Update` methods on resource `BalanceSettings`
  * Add support for `Source` on `Discount`
  * Add support for `MbWayPayments` on `Account.Capabilities` and `AccountCapabilitiesOptions`
  * Add support for `TrialUpdateBehavior` on `BillingPortal.Configuration.Features.SubscriptionUpdate` and `BillingPortalConfigurationFeaturesSubscriptionUpdateOptions`
  * Add support for `MbWay` on `Charge.PaymentMethodDetails`, `ConfirmationToken.PaymentMethodPreview`, `ConfirmationTokenPaymentMethodDataOptions`, `PaymentIntent.PaymentMethodOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
  * Add support for `BrandingSettings` and `NameCollection` on `Checkout.SessionCreateOptions` and `Checkout.Session`
  * Add support for `ExcludedPaymentMethodTypes` on `Checkout.SessionCreateOptions`, `Checkout.Session`, `PaymentIntentConfirmOptions`, and `PaymentIntentUpdateOptions`
  * Add support for `UnitLabel` on `CheckoutSessionLineItemPriceDataProductDataOptions`, `InvoiceLineItemPriceDataProductDataOptions`, `InvoiceLinePriceDataProductDataOptions`, and `PaymentLinkLineItemPriceDataProductDataOptions`
  * Add support for `Alma`, `Billie`, and `Satispay` on `Checkout.Session.PaymentMethodOptions` and `CheckoutSessionPaymentMethodOptionsOptions`
  * Add support for `DemoPay` on `CheckoutSessionPaymentMethodOptionsOptions`
  * Add support for `CaptureMethod` on `Checkout.Session.PaymentMethodOptions.Affirm`, `Checkout.Session.PaymentMethodOptions.AfterpayClearpay`, `Checkout.Session.PaymentMethodOptions.AmazonPay`, `Checkout.Session.PaymentMethodOptions.Card`, `Checkout.Session.PaymentMethodOptions.Cashapp`, `Checkout.Session.PaymentMethodOptions.Klarna`, `Checkout.Session.PaymentMethodOptions.Link`, `Checkout.Session.PaymentMethodOptions.Mobilepay`, `Checkout.Session.PaymentMethodOptions.RevolutPay`, `CheckoutSessionPaymentMethodOptionsAffirmOptions`, `CheckoutSessionPaymentMethodOptionsAfterpayClearpayOptions`, `CheckoutSessionPaymentMethodOptionsAmazonPayOptions`, `CheckoutSessionPaymentMethodOptionsCardOptions`, `CheckoutSessionPaymentMethodOptionsCashappOptions`, `CheckoutSessionPaymentMethodOptionsKlarnaOptions`, `CheckoutSessionPaymentMethodOptionsLinkOptions`, `CheckoutSessionPaymentMethodOptionsMobilepayOptions`, and `CheckoutSessionPaymentMethodOptionsRevolutPayOptions`
  * Add support for `Flexible` on `CheckoutSessionSubscriptionDataBillingModeOptions`, `InvoiceScheduleDetailsBillingModeOptions`, `InvoiceSubscriptionDetailsBillingModeOptions`, `Quote.SubscriptionData.BillingMode`, `QuoteSubscriptionDataBillingModeOptions`, `Subscription.BillingMode`, `SubscriptionBillingModeOptions`, `SubscriptionSchedule.BillingMode`, and `SubscriptionScheduleBillingModeOptions`
  * Add support for `BusinessName` and `IndividualName` on `Checkout.Session.CollectedInformation`, `Checkout.Session.CustomerDetails`, `CustomerCreateOptions`, `CustomerUpdateOptions`, and `Customer`
  * Add support for `ChargebackLossReasonCode` on `Dispute.PaymentMethodDetails.Klarna`
  * Add support for `NetAmount` and `ProrationDetails` on `InvoiceItem`
  * Remove support for `Iterations` on `InvoiceScheduleDetailsPhaseOptions` and `SubscriptionSchedulePhaseOptions`
  * Add support for `FraudDisputabilityLikelihood` and `RiskAssessment` on `Issuing.TestHelpersAuthorizationCreateOptions`
  * Add support for `SecondLine` on `Issuing.Card`
  * Add support for `FrMealVoucherConecs` on `PaymentMethodConfigurationCreateOptions` and `PaymentMethodConfigurationUpdateOptions`
  * Add support for `Promotion` on `PromotionCodeCreateOptions` and `PromotionCode`
  * Add support for `Provider` on `Tax.Settings.Defaults`
  * Add support for `BbposWisepad3` on `Terminal.ConfigurationCreateOptions`, `Terminal.ConfigurationUpdateOptions`, and `Terminal.Configuration`
  * Add support for `AddressKana`, `AddressKanji`, `DisplayNameKana`, `DisplayNameKanji`, and `Phone` on `Terminal.LocationCreateOptions`, `Terminal.LocationUpdateOptions`, and `Terminal.Location`

## 48.6.0-beta.1 - 2025-08-27
This release changes the pinned API version to `2025-08-27.preview`.

* [#3156](https://github.com/stripe/stripe-dotnet/pull/3156) Update generated code for beta
  * Add support for `Get` and `List` methods on resource `InvoicePayment`
  * Add support for `List` method on resource `Mandate`
  * Add support for `Applied` on `V2.Core.Account.Configuration.Customer`, `V2.Core.Account.Configuration.Merchant`, `V2.Core.Account.Configuration.Recipient`, `V2.Core.Account.Configuration.Storer`, `V2CoreAccountConfigurationCustomerOptions`, `V2CoreAccountConfigurationMerchantOptions`, `V2CoreAccountConfigurationRecipientOptions`, and `V2CoreAccountConfigurationStorerOptions`
  * Change type of `Billing.AlertTriggered.Value` from `longInteger` to `decimal_string`
  * Add support for `DisplayName` on `V2.MoneyManagement.FinancialAccountCreateOptions` and `V2.MoneyManagement.FinancialAccount`
  * Add support for `CurrencyConversion` on `V2.MoneyManagement.Transaction.Flow` and `V2.MoneyManagement.TransactionEntry.TransactionDetails.Flow`
  * Add support for `Payments` on `BalanceSettingsUpdateOptions` and `BalanceSettings`
  * Remove support for `DebitNegativeBalances`, `Payouts`, and `SettlementTiming` on `BalanceSettingsUpdateOptions` and `BalanceSettings`
  * Add support for `Mandate` on `Charge.PaymentMethodDetails.Pix`, `PaymentAttemptRecord.PaymentMethodDetails.Pix`, and `PaymentRecord.PaymentMethodDetails.Pix`
  * Add support for `CouponData` on `CheckoutSessionDiscountOptions`
  * Add support for `MandateOptions` on `Checkout.Session.PaymentMethodOptions.Pix`, `CheckoutSessionPaymentMethodOptionsPixOptions`, `PaymentIntent.PaymentMethodOptions.Pix`, and `PaymentIntentPaymentMethodOptionsPixOptions`
  * Change type of `Checkout.Session.PaymentMethodOptions.Pix.SetupFutureUsage`, `CheckoutSessionPaymentMethodOptionsPixOptions.SetupFutureUsage`, `PaymentIntent.PaymentMethodOptions.Pix.SetupFutureUsage`, and `PaymentIntentPaymentMethodOptionsPixOptions.SetupFutureUsage` from `literal('none')` to `enum('none'|'off_session')`
  * Add support for `Amount` on `Mandate.MultiUse`, `PaymentAttemptRecord`, and `PaymentRecord`
  * Add support for `Currency` on `Mandate.MultiUse`
  * Add support for `Pix` on `Mandate.PaymentMethodDetails`, `SetupAttempt.PaymentMethodDetails`, `SetupIntent.PaymentMethodOptions`, and `SetupIntentPaymentMethodOptionsOptions`
  * Add support for `Limit` on `PaymentAttemptRecordListOptions`
  * Add support for `AmountAuthorized`, `AmountRefunded`, and `Application` on `PaymentAttemptRecord` and `PaymentRecord`
  * Add support for `ProcessorDetails` on `PaymentAttemptRecord`, `PaymentRecordReportPaymentOptions`, and `PaymentRecord`
  * Remove support for `PaymentReference` on `PaymentAttemptRecord`, `PaymentRecordReportPaymentOptions`, and `PaymentRecord`
  * Add support for `Installments` on `PaymentAttemptRecord.PaymentMethodDetails.Alma` and `PaymentRecord.PaymentMethodDetails.Alma`
  * Add support for `TransactionId` on `PaymentAttemptRecord.PaymentMethodDetails.Alma`, `PaymentAttemptRecord.PaymentMethodDetails.AmazonPay`, `PaymentAttemptRecord.PaymentMethodDetails.Billie`, `PaymentAttemptRecord.PaymentMethodDetails.KakaoPay`, `PaymentAttemptRecord.PaymentMethodDetails.KrCard`, `PaymentAttemptRecord.PaymentMethodDetails.NaverPay`, `PaymentAttemptRecord.PaymentMethodDetails.Payco`, `PaymentAttemptRecord.PaymentMethodDetails.RevolutPay`, `PaymentAttemptRecord.PaymentMethodDetails.SamsungPay`, `PaymentAttemptRecord.PaymentMethodDetails.Satispay`, `PaymentRecord.PaymentMethodDetails.Alma`, `PaymentRecord.PaymentMethodDetails.AmazonPay`, `PaymentRecord.PaymentMethodDetails.Billie`, `PaymentRecord.PaymentMethodDetails.KakaoPay`, `PaymentRecord.PaymentMethodDetails.KrCard`, `PaymentRecord.PaymentMethodDetails.NaverPay`, `PaymentRecord.PaymentMethodDetails.Payco`, `PaymentRecord.PaymentMethodDetails.RevolutPay`, `PaymentRecord.PaymentMethodDetails.SamsungPay`, and `PaymentRecord.PaymentMethodDetails.Satispay`
  * Add support for `Location` and `Reader` on `PaymentAttemptRecord.PaymentMethodDetails.Paynow` and `PaymentRecord.PaymentMethodDetails.Paynow`
  * Add support for `LatestActiveMandate` on `PaymentMethod`
  * Add support for `Metadata` and `Period` on `QuotePreviewSubscriptionSchedule.Phase.AddInvoiceItem`
  * Add support for `PixDisplayQrCode` on `SetupIntent.NextAction`
  * Add support for `ReaderSecurity` on `Terminal.ConfigurationCreateOptions`, `Terminal.ConfigurationUpdateOptions`, and `Terminal.Configuration`

## 48.5.0 - 2025-08-27
* [#3164](https://github.com/stripe/stripe-dotnet/pull/3164) Add section on private preview SDKs in readme
* [#3159](https://github.com/stripe/stripe-dotnet/pull/3159) Update generated code. This release changes the pinned API version to `2025-08-27.basil`.
  * Add support for `BalanceReport`, `PayoutDetails`, and `PayoutReconciliationReport` on `AccountSession.Components` and `AccountSessionComponentsOptions`
  * Add support for `Name` on `BillingPortal.ConfigurationCreateOptions`, `BillingPortal.ConfigurationUpdateOptions`, and `BillingPortal.Configuration`
  * Add support for `Installments` on `Charge.PaymentMethodDetails.Alma`
  * Add support for `TransactionId` on `Charge.PaymentMethodDetails.Alma`, `Charge.PaymentMethodDetails.AmazonPay`, `Charge.PaymentMethodDetails.Billie`, `Charge.PaymentMethodDetails.KakaoPay`, `Charge.PaymentMethodDetails.KrCard`, `Charge.PaymentMethodDetails.NaverPay`, `Charge.PaymentMethodDetails.Payco`, `Charge.PaymentMethodDetails.RevolutPay`, `Charge.PaymentMethodDetails.SamsungPay`, and `Charge.PaymentMethodDetails.Satispay`
  * Add support for `Location` and `Reader` on `Charge.PaymentMethodDetails.Paynow`
  * Add support for `AmountIncludesIof` on `Checkout.Session.PaymentMethodOptions.Pix`, `CheckoutSessionPaymentMethodOptionsPixOptions`, `PaymentIntent.PaymentMethodOptions.Pix`, and `PaymentIntentPaymentMethodOptionsPixOptions`
  * Add support for `Metadata` and `Period` on `InvoiceScheduleDetailsPhaseAddInvoiceItemOptions`, `SubscriptionAddInvoiceItemOptions`, `SubscriptionSchedule.Phase.AddInvoiceItem`, and `SubscriptionSchedulePhaseAddInvoiceItemOptions`
  * Add support for `ExpMonth` and `ExpYear` on `Issuing.CardCreateOptions`
  * Add support for `ExcludedPaymentMethodTypes` on `PaymentIntentCreateOptions` and `PaymentIntent`
  * Add support for `PayoutMethod` on `PayoutCreateOptions` and `Payout`
  * Add support for `Mxn` on `Terminal.Configuration.Tipping` and `TerminalConfigurationTippingOptions`
  * Add support for `Card` on `Terminal.TestHelpersReaderPresentPaymentMethodOptions`

## 48.5.0-beta.2 - 2025-08-08
* [#3160](https://github.com/stripe/stripe-dotnet/pull/3160) Bring back invoice payments APIs that were missing in the public preview SDKs
    * Add support for new resource `InvoicePayment`
    * Add support for `Get` and `List` methods on resource `InvoicePayment`
  
* [#3155](https://github.com/stripe/stripe-dotnet/pull/3155) Fix links to pinned api versions in CHANGELOG.md in beta branch

## 48.5.0-beta.1 - 2025-07-30
This release changes the pinned API version to `2025-07-30.preview`.

* [#3143](https://github.com/stripe/stripe-dotnet/pull/3143) Update generated code for beta
  * Add support for new resources `Billing.MeterUsageRow`, `Billing.MeterUsage`, and `Terminal.OnboardingLink`
  * Add support for `Get` method on resource `Billing.MeterUsage`
  * Add support for `Create` method on resource `Terminal.OnboardingLink`
  * Add support for `MonthlyPayoutDays` and `WeeklyPayoutDays` on `BalanceSettings.Payouts.Schedule` and `BalanceSettingsPayoutsScheduleOptions`
  * Remove support for `MonthlyAnchor` and `WeeklyAnchor` on `BalanceSettings.Payouts.Schedule` and `BalanceSettingsPayoutsScheduleOptions`
  * Add support for `DelayDaysOverride` on `BalanceSettingsSettlementTimingOptions`
  * Remove support for `DelayDays` on `BalanceSettingsSettlementTimingOptions`
  * Add support for `UpdateDiscounts` on `CheckoutSessionPermissionsOptions`
  * Add support for `Discounts` and `SubscriptionData` on `Checkout.SessionUpdateOptions`
  * Add support for `SmartDisputes` on `Dispute`
  * Add support for `Upi` on `Invoice.PaymentSettings.PaymentMethodOptions`, `InvoicePaymentSettingsPaymentMethodOptionsOptions`, `QuotePreviewInvoice.PaymentSettings.PaymentMethodOptions`, `Subscription.PaymentSettings.PaymentMethodOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptionsOptions`
  * Add support for `TransactionId` on `PaymentAttemptRecord.PaymentMethodDetails.Cashapp` and `PaymentRecord.PaymentMethodDetails.Cashapp`
  * Add support for `AmountDetails` on `PaymentIntentCaptureOptions`, `PaymentIntentConfirmOptions`, `PaymentIntentCreateOptions`, `PaymentIntentIncrementAuthorizationOptions`, and `PaymentIntentUpdateOptions`
  * Add support for `PaymentDetails` on `PaymentIntentIncrementAuthorizationOptions`
  * Add support for `Storer` on `V2.Core.Account.Identity.Attestations.TermsOfService` and `V2CoreAccountIdentityAttestationsTermsOfServiceOptions`
  * Add support for `CollectionOptions` on `V2.Core.AccountLink.UseCase.AccountOnboarding`, `V2.Core.AccountLink.UseCase.AccountUpdate`, `V2CoreAccountLinkUseCaseAccountOnboardingOptions`, and `V2CoreAccountLinkUseCaseAccountUpdateOptions`
  * Change type of `V2.Core.AccountLink.UseCase.AccountOnboarding.Configurations`, `V2.Core.AccountLink.UseCase.AccountUpdate.Configurations`, `V2CoreAccountLinkUseCaseAccountOnboardingOptions.Configurations`, and `V2CoreAccountLinkUseCaseAccountUpdateOptions.Configurations` from `literal('recipient')` to `enum('customer'|'merchant'|'recipient'|'storer')`
  * Add support for `BankAccountType` on `V2.MoneyManagement.PayoutMethod.BankAccount`
  * Add support for thin event `V2CoreAccountLinkReturnedEvent`
  * Add support for thin event `V2MoneyManagementPayoutMethodUpdatedEvent` with related object `V2.MoneyManagement.PayoutMethod`
  * Remove support for thin event `V2CoreAccountLinkCompletedEvent`
  * Remove support for thin event `V2OffSessionPaymentRequiresCaptureEvent` with related object `V2.Payments.OffSessionPayment`

## 48.4.0 - 2025-07-30
This release changes the pinned API version to `2025-07-30.basil`.

* [#3151](https://github.com/stripe/stripe-dotnet/pull/3151) Update generated code
  * Add support for `InstantPayoutsPromotion` on `AccountSession.Components` and `AccountSessionComponentsOptions`
  * Add support for `AdjustableQuantity` on `BillingPortal.Configuration.Features.SubscriptionUpdate.Products` and `BillingPortalConfigurationFeaturesSubscriptionUpdateProductsOptions`
  * Add support for `TransactionId` on `Charge.PaymentMethodDetails.Cashapp`
  * Add support for `OriginContext` on `Checkout.SessionCreateOptions` and `Checkout.Session`
  * Add support for `Template` on `Checkout.Session.InvoiceCreation.InvoiceData.RenderingOptions`, `CheckoutSessionInvoiceCreationInvoiceDataRenderingOptionsOptions`, `PaymentLink.InvoiceCreation.InvoiceData.RenderingOptions`, and `PaymentLinkInvoiceCreationInvoiceDataRenderingOptionsOptions`
  * Add support for `SetupFutureUsage` on `Checkout.Session.PaymentMethodOptions.Pix` and `CheckoutSessionPaymentMethodOptionsPixOptions`
  * Add support for `Duration` on `InvoiceScheduleDetailsPhaseOptions` and `SubscriptionSchedulePhaseOptions`
  * Add support for `PriceData` on `PaymentLinkLineItemOptions`
  * Add support for `Standard` on `Tax.Registration.CountryOptions.Ae`, `Tax.Registration.CountryOptions.Au`, `Tax.Registration.CountryOptions.Ch`, `Tax.Registration.CountryOptions.Gb`, `Tax.Registration.CountryOptions.Jp`, `Tax.Registration.CountryOptions.No`, `Tax.Registration.CountryOptions.Nz`, `Tax.Registration.CountryOptions.Sg`, `TaxRegistrationCountryOptionsAeOptions`, `TaxRegistrationCountryOptionsAlOptions`, `TaxRegistrationCountryOptionsAoOptions`, `TaxRegistrationCountryOptionsAuOptions`, `TaxRegistrationCountryOptionsAwOptions`, `TaxRegistrationCountryOptionsBaOptions`, `TaxRegistrationCountryOptionsBbOptions`, `TaxRegistrationCountryOptionsBdOptions`, `TaxRegistrationCountryOptionsBfOptions`, `TaxRegistrationCountryOptionsBhOptions`, `TaxRegistrationCountryOptionsBsOptions`, `TaxRegistrationCountryOptionsCdOptions`, `TaxRegistrationCountryOptionsChOptions`, `TaxRegistrationCountryOptionsEtOptions`, `TaxRegistrationCountryOptionsGbOptions`, `TaxRegistrationCountryOptionsGnOptions`, `TaxRegistrationCountryOptionsIsOptions`, `TaxRegistrationCountryOptionsJpOptions`, `TaxRegistrationCountryOptionsMeOptions`, `TaxRegistrationCountryOptionsMkOptions`, `TaxRegistrationCountryOptionsMrOptions`, `TaxRegistrationCountryOptionsNoOptions`, `TaxRegistrationCountryOptionsNzOptions`, `TaxRegistrationCountryOptionsOmOptions`, `TaxRegistrationCountryOptionsRsOptions`, `TaxRegistrationCountryOptionsSgOptions`, `TaxRegistrationCountryOptionsSrOptions`, `TaxRegistrationCountryOptionsUyOptions`, `TaxRegistrationCountryOptionsZaOptions`, and `TaxRegistrationCountryOptionsZwOptions`
  * Add support for `Aed`, `Bgn`, `Huf`, and `Ron` on `Terminal.Configuration.Tipping` and `TerminalConfigurationTippingOptions`
* [#3152](https://github.com/stripe/stripe-dotnet/pull/3152) Mark StripeConfiguration as partial so we can add configuration in beta branch
* [#3150](https://github.com/stripe/stripe-dotnet/pull/3150) Adds usage string to telemetry on API calls made through `StripeClient` service accessors

## 48.4.0-beta.2 - 2025-07-09
* [#3145](https://github.com/stripe/stripe-dotnet/pull/3145) Pull in V2 FinancialAccount changes for June release
  * Add support for `Close` and `Create` methods on resource `V2.MoneyManagement.FinancialAccount`
  * Add support for `Storer` on `V2.Core.Account.Configuration` and `V2CoreAccountConfigurationOptions`
  * Add support for `StatusDetails` on `V2.MoneyManagement.FinancialAccount`
  * Add support for `Status` on `V2.MoneyManagement.FinancialAccountListOptions`
  * Add support for thin events `V2CoreAccountIncludingConfigurationStorerCapabilityStatusUpdatedEvent` and `V2CoreAccountIncludingConfigurationStorerUpdatedEvent` with related object `V2.Core.Account`
  * Add support for error types `AlreadyExistsException` and `NonZeroBalanceException`

## 48.4.0-beta.1 - 2025-07-01
This release changes the pinned API version to `2025-06-30.preview`.

* [#3132](https://github.com/stripe/stripe-dotnet/pull/3132) Update generated code for beta
  * Change type of `CheckoutSessionSubscriptionDataOptions.BillingMode`, `InvoiceScheduleDetailsOptions.BillingMode`, `InvoiceSubscriptionDetailsOptions.BillingMode`, `Quote.SubscriptionData.BillingMode`, `QuoteSubscriptionDataOptions.BillingMode`, `SubscriptionCreateOptions.BillingMode`, and `SubscriptionScheduleCreateOptions.BillingMode` from `enum('classic'|'flexible')` to `billing_mode`
  * Add support for `SubmissionMethod` on `Dispute.EvidenceDetails`
  * Add support for `OnDemand` and `Subscriptions` on `OrderPaymentSettingsPaymentMethodOptionsKlarnaOptions`
  * Change type of `Order.Payment.Settings.PaymentMethodOptions.Klarna.SetupFutureUsage` and `OrderPaymentSettingsPaymentMethodOptionsKlarnaOptions.SetupFutureUsage` from `literal('none')` to `enum('none'|'off_session'|'on_session')`
  * Add support for `Crypto` on `PaymentAttemptRecord.PaymentMethodDetails` and `PaymentRecord.PaymentMethodDetails`
  * Change type of `PaymentIntent.PaymentMethodOptions.Gopay.SetupFutureUsage` and `PaymentIntentPaymentMethodOptionsGopayOptions.SetupFutureUsage` from `literal('none')` to `enum('none'|'off_session')`
  * Change type of `QuotePreviewSubscriptionSchedule.BillingMode`, `Subscription.BillingMode`, and `SubscriptionSchedule.BillingMode` from `enum('classic'|'flexible')` to `SubscriptionsResourceBillingMode`
  * Change type of `SubscriptionMigrateOptions.BillingMode` from `literal('flexible')` to `billing_mode_migrate`
  * Remove support for `BillingModeDetails` on `Subscription`
  * Add support for `ProofOfAddress` on `V2.Core.Account.Identity.BusinessDetails.Documents` and `V2CoreAccountIdentityBusinessDetailsDocumentsOptions`
  * Add support for `Metadata` on `V2.MoneyManagement.FinancialAccount`
  * Remove support for `Description` on `V2.MoneyManagement.FinancialAccount`
  * Remove support for `Attempts` on `V2.Payments.OffSessionPayment`
  * Change type of `V2.Payments.OffSessionPayment.TransferData.Amount` from `integer` to `nullable(integer)`
  * Add support for `FromAccount`, `OutboundPayment`, and `OutboundTransfer` on `V2.MoneyManagement.ReceivedCredit.BalanceTransfer`
  * Change type of `V2.MoneyManagement.ReceivedCredit.BalanceTransfer.Type` from `literal('payout_v1')` to `enum('outbound_payment'|'outbound_transfer'|'payout_v1')`

## 48.3.0 - 2025-07-01
This release changes the pinned API version to `2025-06-30.basil`.

* [#3139](https://github.com/stripe/stripe-dotnet/pull/3139) Update generated code
  * Add support for `Migrate` method on resource `Subscription`
  * Add support for `CollectPaymentMethod` and `ConfirmPaymentIntent` methods on resource `Terminal.Reader`
  * Add support for `CryptoPayments` on `Account.Capabilities` and `AccountCapabilitiesOptions`
  * Add support for `ProofOfAddress` on `AccountDocumentsOptions`
  * Add support for `MonthlyPayoutDays` and `WeeklyPayoutDays` on `Account.Settings.Payouts.Schedule` and `AccountSettingsPayoutsScheduleOptions`
  * Add support for `Crypto` on `Charge.PaymentMethodDetails`, `ConfirmationToken.PaymentMethodPreview`, `ConfirmationTokenPaymentMethodDataOptions`, `PaymentIntent.PaymentMethodOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
  * Change type of `Charge.PaymentMethodDetails.Card.Installments.Plan.Type`, `ConfirmationToken.PaymentMethodOptions.Card.Installments.Plan.Type`, `ConfirmationTokenPaymentMethodOptionsCardInstallmentsPlanOptions.Type`, `InvoicePaymentSettingsPaymentMethodOptionsCardInstallmentsPlanOptions.Type`, `PaymentIntent.PaymentMethodOptions.Card.Installments.AvailablePlans.Type`, `PaymentIntent.PaymentMethodOptions.Card.Installments.Plan.Type`, and `PaymentIntentPaymentMethodOptionsCardInstallmentsPlanOptions.Type` from `literal('fixed_count')` to `enum('bonus'|'fixed_count'|'revolving')`
  * Add support for `Subscriptions` on `CheckoutSessionPaymentMethodOptionsKlarnaOptions` and `PaymentIntentPaymentMethodOptionsKlarnaOptions`
  * Add support for `BillingMode` on `CheckoutSessionSubscriptionDataOptions`, `InvoiceScheduleDetailsOptions`, `InvoiceSubscriptionDetailsOptions`, `Quote.SubscriptionData`, `QuoteSubscriptionDataOptions`, `SubscriptionCreateOptions`, `SubscriptionScheduleCreateOptions`, `SubscriptionSchedule`, and `Subscription`
  * Change type of `Dispute.EnhancedEligibilityTypes` from `literal('visa_compelling_evidence_3')` to `enum('visa_compelling_evidence_3'|'visa_compliance')`
  * Add support for `RelatedPerson` on `Identity.VerificationSessionCreateOptions` and `Identity.VerificationSession`
  * Add support for `Matching` on `Identity.VerificationSession.Options`
  * Add support for `Klarna` on `Mandate.PaymentMethodDetails`, `SetupIntent.PaymentMethodOptions`, and `SetupIntentPaymentMethodOptionsOptions`
  * Add support for `OnDemand` on `PaymentIntentPaymentMethodOptionsKlarnaOptions`
  * Change type of `PaymentIntent.PaymentMethodOptions.Klarna.SetupFutureUsage` and `PaymentIntentPaymentMethodOptionsKlarnaOptions.SetupFutureUsage` from `literal('none')` to `enum('none'|'off_session'|'on_session')`
  * Add support for `Ua` on `Tax.Registration.CountryOptions` and `TaxRegistrationCountryOptionsOptions`
  * Change type of `Terminal.LocationUpdateOptions.DisplayName` from `string` to `emptyable(string)`
  * Add support for `CollectPaymentMethod` and `ConfirmPaymentIntent` on `Terminal.Reader.Action`
  * Add support for `Status` on `Treasury.FinancialAccountListOptions`
  * Add support for snapshot event `TerminalReaderActionUpdated` with resource `Terminal.Reader`
* [#3137](https://github.com/stripe/stripe-dotnet/pull/3137) Updated stripeclient snippets in Readme.md

## 48.3.0-beta.2 - 2025-06-26
* [#3142](https://github.com/stripe/stripe-dotnet/pull/3142) Pull in OffSessionPayment changes for the May release

## 48.3.0-beta.1 - 2025-05-29
This release changes the pinned API version to `2025-05-28.preview`.

* [#3123](https://github.com/stripe/stripe-dotnet/pull/3123) Update generated code for beta
  ### Breaking changes
  * Remove support for deprecated previews
    * Remove support for resources `Billing.MeterErrorReport`, `GiftCards.Card`, `GiftCards.Transaction`, and `Privacy.RedactionJobRootObjects`
    * Remove support for `Create`, `Get`, `List`, `Update`, and `Validate` methods on resource `GiftCards.Card`
    * Remove support for `Cancel`, `Confirm`, `Create`, `Get`, `List`, and `Update` methods on resource `GiftCards.Transaction`
    * Remove support for `Provisioning` on `ProductCreateOptions` and `Product`
  * Change type of `CheckoutSessionLineItemOptions.Quantity` from `emptyable(longInteger)` to `longInteger`
  * Change type of `InvoiceSubscriptionDetailsOptions.CancelAt`, `SubscriptionCreateOptions.CancelAt`, and `SubscriptionUpdateOptions.CancelAt` from `DateTime` to `DateTime | enum('max_period_end'|'min_period_end')`
  * Remove support for `Credits` on `OrderCreateOptions`, `OrderUpdateOptions`, and `Order`
  * Remove support for `AmountRemaining` on `Order`
  * Remove support for `AmountCredit` on `Order.TotalDetails`
  * Remove support for `AsyncWorkflows` on `PaymentIntentCaptureOptions`, `PaymentIntentConfirmOptions`, `PaymentIntentCreateOptions`, `PaymentIntentDecrementAuthorizationOptions`, `PaymentIntentIncrementAuthorizationOptions`, `PaymentIntentUpdateOptions`, and `PaymentIntent`
  * Change type of `PaymentRecordReportPaymentAttemptCanceledOptions.Metadata`, `PaymentRecordReportPaymentAttemptFailedOptions.Metadata`, `PaymentRecordReportPaymentAttemptGuaranteedOptions.Metadata`, `PaymentRecordReportPaymentAttemptOptions.Metadata`, and `PaymentRecordReportPaymentOptions.Metadata` from `map(string: string)` to `emptyable(map(string: string))`
  * Change type of `Privacy.RedactionJob.Objects` from `$Privacy.RedactionJobRootObjects` to `RedactionResourceRootObjects`
  * Change type of `Privacy.RedactionJobValidationError.ErroringObject` from `map(string: string)` to `RedactionResourceErroringObject`
  * Remove support for `StatusDetails` and `Status` on `Tax.Association`
  * Remove support for snapshot event `BillingMeterErrorReportTriggered` with resource `Billing.MeterErrorReport`

  ### Other changes
  * Add support for `Migrate` method on resource `Subscription`
  * Add support for `Distance`, `PickupLocationName`, `ReturnLocationName`, and `VehicleIdentificationNumber` on `ChargePaymentDetailsCarRentalOptions`, `PaymentIntent.PaymentDetails.CarRental`, and `PaymentIntentPaymentDetailsCarRentalOptions`
  * Add support for `DriverIdentificationNumber` and `DriverTaxNumber` on `ChargePaymentDetailsCarRentalDriverOptions`, `PaymentIntent.PaymentDetails.CarRental.Driver`, and `PaymentIntentPaymentDetailsCarRentalDriverOptions`
  * Add support for `Institution` on `FinancialConnections.Account`
  * Add support for `Countries` on `FinancialConnections.Institution`
  * Add support for `Location` and `Reader` on `PaymentAttemptRecord.PaymentMethodDetails.Affirm`, `PaymentAttemptRecord.PaymentMethodDetails.WechatPay`, `PaymentRecord.PaymentMethodDetails.Affirm`, and `PaymentRecord.PaymentMethodDetails.WechatPay`
  * Add support for `Hooks` on `PaymentIntentCaptureOptions`, `PaymentIntentConfirmOptions`, `PaymentIntentCreateOptions`, `PaymentIntentDecrementAuthorizationOptions`, `PaymentIntentIncrementAuthorizationOptions`, `PaymentIntentUpdateOptions`, and `PaymentIntent`
  * Add support for `CardPresent` on `PaymentIntentAmountDetailsLineItem.PaymentMethodOptions`
  * Add support for `Livemode` on `Privacy.RedactionJob`
  * Add support for `BillingThresholds` on `QuotePreviewSubscriptionSchedule.DefaultSettings`, `QuotePreviewSubscriptionSchedule.Phase.Item`, and `QuotePreviewSubscriptionSchedule.Phase`
  * Add support for `BillingModeDetails` on `Subscription`
  * Add support for `TaxTransactionAttempts` on `Tax.Association`
  * Add support for `ConfirmConfig` on `Terminal.Reader.Action.ConfirmPaymentIntent` and `Terminal.ReaderConfirmPaymentIntentOptions`

## 48.2.0 - 2025-05-29
 This release changes the pinned API version to `2025-05-28.basil`.

* [#3128](https://github.com/stripe/stripe-dotnet/pull/3128) Update generated code.
  * Add support for `AttachPayment` method on resource `Invoice`
  * Add support for `CollectInputs` method on resource `Terminal.Reader`
  * Add support for `SucceedInputCollection` and `TimeoutInputCollection` test helper methods on resource `Terminal.Reader`
  * Add support for `PixPayments` on `Account.Capabilities` and `AccountCapabilitiesOptions`
  * Add support for `DisputesList` and `PaymentDisputes` on `AccountSession.Components` and `AccountSessionComponentsOptions`
  * Add support for `RefundAndDisputePrefunding` on `Balance`
  * Add support for `BalanceType` on `BalanceTransaction`
  * Add support for `Location` and `Reader` on `Charge.PaymentMethodDetails.Affirm` and `Charge.PaymentMethodDetails.WechatPay`
  * Add support for `PaymentMethodRemove` on `CheckoutSessionSavedPaymentMethodOptionsOptions`
  * Add support for `SetupFutureUsage` on `Checkout.Session.PaymentMethodOptions.NaverPay`
  * Add support for `PostPaymentAmount` and `PrePaymentAmount` on `CreditNote`
  * Add support for `Sex`, `UnparsedPlaceOfBirth`, and `UnparsedSex` on `Identity.VerificationReport.Document` and `Identity.VerificationSession.VerifiedOutputs`
  * Add support for `BillingThresholds` on `InvoiceScheduleDetailsPhaseItemOptions`, `InvoiceScheduleDetailsPhaseOptions`, `InvoiceSubscriptionDetailsItemOptions`, `SubscriptionCreateOptions`, `SubscriptionItemCreateOptions`, `SubscriptionItemOptions`, `SubscriptionItemUpdateOptions`, `SubscriptionItem`, `SubscriptionSchedule.DefaultSettings`, `SubscriptionSchedule.Phase.Item`, `SubscriptionSchedule.Phase`, `SubscriptionScheduleDefaultSettingsOptions`, `SubscriptionSchedulePhaseItemOptions`, `SubscriptionSchedulePhaseOptions`, `SubscriptionUpdateOptions`, and `Subscription`
  * Add support for `Satispay` on `PaymentIntent.PaymentMethodOptions` and `PaymentIntentPaymentMethodOptionsOptions`
  * Add support for `CaptureMethod` on `PaymentIntent.PaymentMethodOptions.Billie`
  * Add support for `KakaoPay`, `KrCard`, `NaverPay`, `Payco`, and `SamsungPay` on `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, and `PaymentMethodConfiguration`
  * Add support for `NetworkDeclineCode` on `Refund.DestinationDetails.Paypal`
  * Add support for `Metadata` on `Tax.CalculationLineItem` and `TaxCalculationLineItemOptions`
  * Add support for `ReturnUrl` on `Terminal.Reader.Action.ProcessPaymentIntent.ProcessConfig` and `TerminalReaderProcessConfigOptions`
  * Add support for `CollectInputs` on `Terminal.Reader.Action`
  * Add support for snapshot event `InvoicePaymentPaid` with resource `InvoicePayment`
* [#3124](https://github.com/stripe/stripe-dotnet/pull/3124) Adds CONTRIBUTING.md

## 48.2.0-beta.2 - 2025-04-30
* [#3122](https://github.com/stripe/stripe-dotnet/pull/3122) Update generated code for beta
  Release specs are identical.

## 48.2.0-beta.1 - 2025-04-30
* [#3107](https://github.com/stripe/stripe-dotnet/pull/3107) Update generated code for beta
  This release changes the pinned API version to `2025-04-30.preview`.

  * Add support for `BillingMode` on `CheckoutSessionSubscriptionDataOptions`, `InvoiceScheduleDetailsOptions`, `InvoiceSubscriptionDetailsOptions`, `Quote.SubscriptionData`, `QuotePreviewSubscriptionSchedule`, `QuoteSubscriptionDataOptions`, `SubscriptionCreateOptions`, `SubscriptionScheduleCreateOptions`, `SubscriptionSchedule`, and `Subscription`
  * Add support for `AccountNumber` on `ConfirmationToken.PaymentMethodPreview.AcssDebit` and `PaymentMethod.AcssDebit`

## 48.1.0 - 2025-04-30

  This release changes the pinned API version to `2025-04-30.basil`.

* [#3102](https://github.com/stripe/stripe-dotnet/pull/3102) Update generated code
  * Add support for `MinorityOwnedBusinessDesignation` on `Account.BusinessProfile` and `AccountBusinessProfileOptions`
  * Add support for `RegistrationDate` on `Account.Company`, `AccountCompanyOptions`, and `TokenAccountCompanyOptions`
  * Add support for `UsCfpbData` on `AccountCreateOptions`, `AccountUpdateOptions`, `Person`, and `TokenPersonOptions`
  * Add support for `TaxId` on `Charge.BillingDetails`, `ConfirmationToken.PaymentMethodPreview.BillingDetails`, `ConfirmationTokenPaymentMethodDataBillingDetailsOptions`, `PaymentIntentPaymentMethodDataBillingDetailsOptions`, `PaymentMethod.BillingDetails`, `PaymentMethodBillingDetailsOptions`, and `SetupIntentPaymentMethodDataBillingDetailsOptions`
  * Add support for `WalletOptions` on `Checkout.SessionCreateOptions` and `Checkout.Session`
  * Add support for `Provider` on `Checkout.Session.AutomaticTax`, `Invoice.AutomaticTax`, and `Quote.AutomaticTax`
  * Add support for `PaymentMethodOptions` on `TestHelpersConfirmationTokenCreateOptions`
  * Add support for `Installments` on `ConfirmationToken.PaymentMethodOptions.Card`
  * Add support for `Context` on `Event`
  * Add support for `Billie` on `PaymentIntent.PaymentMethodOptions` and `PaymentIntentPaymentMethodOptionsOptions`
  * Add support for `Pix` on `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, and `PaymentMethodConfiguration`
  * Add support for `Klarna` on `PaymentMethodDomain`
  * Add support for `PendingReason` on `Refund`
  * Add support for `Aw`, `Az`, `Bd`, `Bf`, `Bj`, `Cm`, `Cv`, `Et`, `In`, `Kg`, `La`, and `Ph` on `Tax.Registration.CountryOptions` and `TaxRegistrationCountryOptionsOptions`

## 48.1.0-beta.4 - 2025-04-17
* [#3099](https://github.com/stripe/stripe-dotnet/pull/3099) Update generated code for beta
  * Add support for new resources `FxQuote` and `PaymentIntentAmountDetailsLineItem`
  * Add support for `Create`, `Get`, and `List` methods on resource `FxQuote`
  * Remove support for `AttachPaymentIntent` method on resource `Invoice`
  * Add support for `RegistrationDate` on `AccountCompanyOptions`, `AccountCompany`, and `TokenAccountCompanyOptions`
  * Add support for `CustomerReference` and `OrderReference` on `ChargePaymentDetailsOptions`, `PaymentIntentPaymentDetailsOptions`, and `PaymentIntentPaymentDetails`
  * Add support for `TaxId` on `ChargeBillingDetails`, `ConfirmationTokenPaymentMethodDataBillingDetailsOptions`, `ConfirmationTokenPaymentMethodPreviewBillingDetails`, `PaymentIntentPaymentMethodDataBillingDetailsOptions`, `PaymentMethodBillingDetailsOptions`, `PaymentMethodBillingDetails`, `SetupIntentPaymentMethodDataBillingDetailsOptions`, and `TreasuryOutboundPaymentDestinationPaymentMethodDataBillingDetailsOptions`
  * Add support for `PriceData` on `CheckoutSessionLineItemsOptions`
  * Change type of `CheckoutSessionLineItemsOptions.Quantity` from `longInteger` to `emptyable(longInteger)`
  * Add support for `Script` on `CouponCreateOptions` and `Coupon`
  * Add support for `Type` on `Coupon`
  * Add support for `FxQuote` on `PaymentIntentConfirmOptions`, `PaymentIntentCreateOptions`, `PaymentIntentUpdateOptions`, `PaymentIntent`, `TransferCreateOptions`, and `Transfer`
  * Add support for `DiscountAmount`, `LineItems`, `Shipping`, and `Tax` on `PaymentIntentAmountDetails`
  * Add support for `Pix` on `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, and `PaymentMethodConfiguration`
  * Add support for `UsCfpbData` on `Person` and `TokenPersonOptions`
  * Add support for `PendingReason` on `Refund`
  * Add support for `Aw`, `Az`, `Bd`, `Bj`, `Et`, `Kg`, `La`, and `Ph` on `TaxRegistrationCountryOptionsOptions` and `TaxRegistrationCountryOptions`
  * Add support for snapshot event `FxQuoteExpired` with resource `FxQuote`

## 48.1.0-beta.3 - 2025-04-10
* [#3094](https://github.com/stripe/stripe-dotnet/pull/3094) Update generated code for beta
  * Add support for new resources `Privacy.RedactionJobRootObjects`, `Privacy.RedactionJobValidationError`, and `Privacy.RedactionJob`
  * Add support for `Cancel`, `Create`, `Get`, `List`, `Run`, `Update`, and `Validate` methods on resource `RedactionJob`
  * Add support for `Get` and `List` methods on resource `RedactionJobValidationError`
  * Add support for `MinorityOwnedBusinessDesignation` on `AccountBusinessProfileOptions` and `AccountBusinessProfile`
  * Add support for `ExportTaxTransactions` and `PaymentDisputes` on `AccountSessionComponentsOptions`
  * Add support for `WalletOptions` on `Checkout.SessionCreateOptions` and `CheckoutSession`
  * Add support for `Klarna` on `PaymentMethodDomain`
  * Add support for `In` on `TaxRegistrationCountryOptionsOptions` and `TaxRegistrationCountryOptions`
* [#3092](https://github.com/stripe/stripe-dotnet/pull/3092) Handle external_account field
  - Changes `externalAccount` field in `externalAccounts.create` from a `string` to a union type.
* [#3091](https://github.com/stripe/stripe-dotnet/pull/3091) Xavdid/merge dotnet beta & fix tests

## 48.1.0-beta.2 - 2025-04-02
* Re-releasing 48.1.0-beta.1 as it had publishing issues

## 48.1.0-beta.1 - 2025-04-02
* [#3079](https://github.com/stripe/stripe-dotnet/pull/3079) Update generated code for beta

This release changes the pinned API version to `2025-03-31.preview`

### Breaking Changes
  * Remove support for `AmountOverpaid` on `InvoicePayment`
  * Change type of `InvoicePayment.IsDefault` from `nullable(boolean)` to `boolean`
  * Remove support for `InterchangeFees`, `NetTotal`, `NetworkFees`, and `TransactionVolume` on `IssuingSettlement`
  * Change type of `PaymentAttemptRecordPaymentMethodDetails.Type` and `PaymentRecordPaymentMethodDetails.Type` from `literal('custom')` to `string`
  * Remove support for `ApplicationFeeAmount`, `Discount`, `PaidOutOfBand`, `Paid`, `PaymentIntent`, `Quote`, `SubscriptionDetails`, `SubscriptionProrationDate`, `Tax`, `TotalTaxAmounts`, and `TransferData` on `QuotePreviewInvoice`
  * Remove support for `BillingThresholds` on `QuotePreviewSubscriptionScheduleDefaultSettings`, `QuotePreviewSubscriptionSchedulePhasesItems`, and `QuotePreviewSubscriptionSchedulePhases`
  * Remove support for `Coupon` on `QuotePreviewSubscriptionSchedulePhases`
  * Remove support for `Value` on `TerminalReaderActionCollectInputsInputsSelectionChoices`, `TerminalReaderActionCollectInputsInputsSelection`, and `TerminalReaderInputsSelectionChoicesOptions`
  * Change type of `QuotePreviewInvoice.Parent.SubscriptionDetail.subscription` from `string` to `expandable($Subscription)`
  * Change `CheckoutSession.Permission.update` to be optional
  * Change type of `PaymentAttemptRecord.PaymentMethodDetail.type` and `PaymentRecord.PaymentMethodDetail.type` from `literal('custom')` to `string`
  * Change type of `PaymentAttemptRecord.payment_record` from `string` to `nullable(string)`
  * Change `PaymentAttemptRecord.PaymentMethodDetail.custom` and `PaymentRecord.PaymentMethodDetail.custom` to be optional
  * Change type of `PaymentRecord.latest_payment_attempt_record` from `string` to `nullable(string)`
  * Change type of `Order.CreateParamsPaymentSettingPaymentMethodOptionWechatPay.client` and `Order.UpdateParamsPaymentSettingPaymentMethodOptionWechatPay.client` to be optional


### Additions
  * Add support for new resources `BalanceSettings`
  * Add support for `Get` and `Update` methods on resource `BalanceSettings`
  * Add support for `Create`, `Delete`, `Get`, `List`, and `Update` methods on a new `ExternalAccountService` to access cards and bank accounts made available in the new path `v1/external_accounts`
  * Add support for `StripeBalancePayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
  * Add support for `CustomerAccount` on `Billing.CreditBalanceSummaryRetrieveOptions`, `Billing.CreditBalanceTransactionListOptions`, `Billing.CreditGrantCreateOptions`, `Billing.CreditGrantListOptions`, `BillingCreditBalanceSummary`, `BillingCreditGrant`, `BillingPortal.SessionCreateOptions`, `BillingPortalSession`, `Checkout.SessionCreateOptions`, `Checkout.SessionListOptions`, `CheckoutSession`, `ConfirmationTokenPaymentMethodPreview`, `CreditNoteListOptions`, `CreditNote`, `CustomerBalanceTransaction`, `CustomerCashBalanceTransaction`, `CustomerCashBalance`, `CustomerPaymentMethod`, `CustomerSessionCreateOptions`, `CustomerSession`, `CustomerTaxIdOwner`, `CustomerTaxId`, `Customer`, `Discount`, `FinancialConnectionsAccountAccountHolderOptions`, `FinancialConnectionsAccountAccountHolder`, `FinancialConnectionsSessionAccountHolderOptions`, `FinancialConnectionsSessionAccountHolder`, `InvoiceCreateOptions`, `InvoiceCreatePreviewOptions`, `InvoiceItemCreateOptions`, `InvoiceItemListOptions`, `InvoiceItem`, `InvoiceListOptions`, `Invoice`, `PaymentIntentCreateOptions`, `PaymentIntentListOptions`, `PaymentIntentUpdateOptions`, `PaymentIntent`, `PaymentMethodAttachOptions`, `PaymentMethod`, `PromotionCodeCreateOptions`, `PromotionCodeListOptions`, `PromotionCode`, `QuoteCreateOptions`, `QuoteListOptions`, `QuotePreviewInvoice`, `QuotePreviewSubscriptionSchedule`, `QuoteUpdateOptions`, `Quote`, `SetupAttempt`, `SetupIntentCreateOptions`, `SetupIntentListOptions`, `SetupIntentUpdateOptions`, `SetupIntent`, `Subscription.CreateParams`, `Subscription.ListParams`, `SubscriptionSchedule.CreateParams`, `SubscriptionSchedule.ListParams`, `SubscriptionSchedule`, `Subscription`, `TaxIdOwnerOptions`, `TaxIdOwner`, and `TaxId`
  * Add support for `StripeBalance` on `ChargePaymentMethodDetails`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `CustomerPaymentMethod`, `PaymentAttemptRecordPaymentMethodDetails`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, `PaymentRecordPaymentMethodDetails`, `SetupAttemptPaymentMethodDetails`, and `SetupIntentPaymentMethodDataOptions`
  * Add support for `UpdateLineItems` and `UpdateShippingDetails` on `CheckoutSessionPermissionsOptions` and `CheckoutSessionPermissions`
  * Add support for `Provider` on `CheckoutSessionAutomaticTax`, `InvoiceAutomaticTax`, `QuoteAutomaticTax`, and `QuotePreviewInvoiceAutomaticTax`
  * Add support for `TaxCalculationReference` on `CreditNoteLineItem`, `CreditNotePreviewLines`, `InvoiceLineItem`, `LineItem`, `PaymentLinkLineItem`, `QuoteComputedUpfrontLineItems`, `QuoteLineItem`, and `SessionLineItem`
  * Add support for `PaymentMethodOptions` on `TestHelpersConfirmationTokenCreateOptions`
  * Add support for `Installments` on `ConfirmationTokenPaymentMethodOptionsCard`
  * Add support for `Context` on `Event`
  * Add support for `RelatedCustomerAccount` on `Identity.VerificationSessionCreateOptions`, `Identity.VerificationSessionListOptions`, and `IdentityVerificationSession`
  * Add support for `NetworkData` on `IssuingDisputeSettlementDetail`
  * Add support for `InterchangeFeesAmount`, `NetTotalAmount`, `NetworkFeesAmount`, `OtherFeesAmount`, `OtherFeesCount`, and `TransactionAmount` on `IssuingSettlement`
  * Add support for `ReportedBy` on `PaymentAttemptRecord`
  * Add support for `AchCreditTransfer`, `AchDebit`, `AcssDebit`, `Affirm`, `AfterpayClearpay`, `Alipay`, `Alma`, `AmazonPay`, `AuBecsDebit`, `BacsDebit`, `Bancontact`, `Blik`, `Boleto`, `CardPresent`, `Card`, `Cashapp`, `CustomerBalance`, `Eps`, `Fpx`, `Giropay`, `Gopay`, `Grabpay`, `IdBankTransfer`, `Ideal`, `InteracPresent`, `KakaoPay`, `Klarna`, `Konbini`, `KrCard`, `Link`, `MbWay`, `Mobilepay`, `Multibanco`, `NaverPay`, `NzBankAccount`, `Oxxo`, `P24`, `PayByBank`, `Payco`, `Paynow`, `Paypal`, `Payto`, `Pix`, `Promptpay`, `Qris`, `Rechnung`, `RevolutPay`, `SamsungPay`, `Satispay`, `SepaCreditTransfer`, `SepaDebit`, `Shopeepay`, `Sofort`, `StripeAccount`, `Swish`, `Twint`, `UsBankAccount`, `WechatPay`, `Wechat`, and `Zip` on `PaymentAttemptRecordPaymentMethodDetails` and `PaymentRecordPaymentMethodDetails`
  * Add support for `Billie` on `PaymentAttemptRecordPaymentMethodDetails`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, and `PaymentRecordPaymentMethodDetails`
  * Add support for `PayoutMethod` on `PayoutCreateOptions` and `Payout`
  * Add support for `ConfirmationSecret`, `Parent`, and `TotalTaxes` on `QuotePreviewInvoice`
  * Add support for `Id` and `Text` on `TerminalReaderActionCollectInputsInputsSelectionChoices`, `TerminalReaderActionCollectInputsInputsSelection`, and `TerminalReaderInputsSelectionChoicesOptions`

#### New APIs for Money CardManagement
  * Add support for new resources `V2.FinancialAddressCreditSimulation`, `V2.FinancialAddressGeneratedMicrodeposits`, `V2.MoneyManagement.Adjustment`, `V2.MoneyManagement.FinancialAccount`, `V2.MoneyManagement.FinancialAddress`, `V2.MoneyManagement.InboundTransfer`, `V2.MoneyManagement.OutboundPaymentQuote`, `V2.MoneyManagement.OutboundPayment`, `V2.MoneyManagement.OutboundSetupIntent`, `V2.MoneyManagement.OutboundTransfer`, `V2.MoneyManagement.PayoutMethod`, `V2.MoneyManagement.PayoutMethodsBankAccountSpec`, `V2.MoneyManagement.ReceivedCredit`, `V2.MoneyManagement.ReceivedDebit`, `V2.MoneyManagement.TransactionEntry`, and `V2.MoneyManagement.Transaction`
  * Add support for `Create` method on resource `V2.MoneyManagement.OutboundPaymentQuote`
  * Add support for `Get` and `List` methods on resources `V2.MoneyManagement.Adjustment`, `V2.MoneyManagement.FinancialAccount`, `V2.MoneyManagement.ReceivedCredit`, `V2.MoneyManagement.ReceivedDebit`, `V2.MoneyManagement.TransactionEntry`, and `V2.MoneyManagement.Transaction`
  * Add support for `Create`, `Get`, and `List` methods on resources `V2.MoneyManagement.FinancialAddress` and `V2.MoneyManagement.InboundTransfer`
  * Add support for `Cancel`, `Create`, `Get`, and `List` methods on resources `V2.MoneyManagement.OutboundPayment` and `V2.MoneyManagement.OutboundTransfer`
  * Add support for `Archive`, `Get`, `List`, and `Unarchive` methods on resource `V2.MoneyManagement.PayoutMethod`
  * Add support for `Cancel`, `Create`, `Get`, `List`, and `Update` methods on resource `V2.MoneyManagement.OutboundSetupIntent`
  * Add support for `Get` method on resource `V2.MoneyManagement.PayoutMethodsBankAccountSpec`
  * Add support for new thin events `V2CoreAccountPersonCreatedEvent`, `V2CoreAccountPersonDeletedEvent`, and `V2CoreAccountPersonUpdatedEvent` with related object `V2.Core.Person`
  * Add support for new thin event `V2MoneyManagementFinancialAccountCreatedEvent` with related object `V2.MoneyManagement.FinancialAccount`
  * Add support for new thin events `V2MoneyManagementFinancialAddressActivatedEvent` and `V2MoneyManagementFinancialAddressFailedEvent` with related object `V2.MoneyManagement.FinancialAddress`
  * Add support for new thin events `V2MoneyManagementInboundTransferAvailableEvent`, `V2MoneyManagementInboundTransferBankDebitFailedEvent`, `V2MoneyManagementInboundTransferBankDebitProcessingEvent`, `V2MoneyManagementInboundTransferBankDebitQueuedEvent`, `V2MoneyManagementInboundTransferBankDebitReturnedEvent`, and `V2MoneyManagementInboundTransferBankDebitSucceededEvent` with related object `V2.MoneyManagement.InboundTransfer`
  * Add support for new thin events `V2MoneyManagementOutboundPaymentCanceledEvent`, `V2MoneyManagementOutboundPaymentCreatedEvent`, `V2MoneyManagementOutboundPaymentFailedEvent`, `V2MoneyManagementOutboundPaymentPostedEvent`, and `V2MoneyManagementOutboundPaymentReturnedEvent` with related object `V2.MoneyManagement.OutboundPayment`
  * Add support for new thin events `V2MoneyManagementOutboundTransferCanceledEvent`, `V2MoneyManagementOutboundTransferCreatedEvent`, `V2MoneyManagementOutboundTransferFailedEvent`, `V2MoneyManagementOutboundTransferPostedEvent`, and `V2MoneyManagementOutboundTransferReturnedEvent` with related object `V2.MoneyManagement.OutboundTransfer`
  * Add support for new thin events `V2MoneyManagementReceivedCreditAvailableEvent`, `V2MoneyManagementReceivedCreditFailedEvent`, `V2MoneyManagementReceivedCreditReturnedEvent`, and `V2MoneyManagementReceivedCreditSucceededEvent` with related object `V2.MoneyManagement.ReceivedCredit`
  * Add support for new thin events `V2MoneyManagementReceivedDebitCanceledEvent`, `V2MoneyManagementReceivedDebitFailedEvent`, `V2MoneyManagementReceivedDebitPendingEvent`, `V2MoneyManagementReceivedDebitSucceededEvent`, and `V2MoneyManagementReceivedDebitUpdatedEvent` with related object `V2.MoneyManagement.ReceivedDebit`
  * Add support for new error types `AlreadyCanceledException`, `BlockedByStripeException`, `ControlledByDashboardException`, `FeatureNotEnabledException`, `FinancialAccountNotOpenException`, `InsufficientFundsException`, `InvalidPayoutMethodException`, `NotCancelableException`, and `RecipientNotNotifiableException`

#### New APIs for Accounts v2 in private preview
See [SaaS platform payments with subscription billing using Accounts v2](https://docs.stripe.com/connect/accounts-v2/saas-platform-payments-billing)

  * Add support for new resources `V2.Core.AccountLink`, `V2.Core.Account`, `V2.Core.Person`, `V2.Core.Vault.GbBankAccount`, `V2.Core.Vault.UsBankAccount`
  * Add support for `Close`, `Create`, `Get`, `List`, and `Update` methods on resource `V2.Core.Account`
  * Add support for `AcknowledgeConfirmationOfPayee`, `Archive`, `Create`, `Get`, and `InitiateConfirmationOfPayee` methods on resource `V2.Core.Vault.GbBankAccount`
  * Add support for `Archive`, `Create`, `Get`, and `Update` methods on resource `V2.Core.Vault.UsBankAccount`
  * Add support for new thin events `V2CoreAccountIncludingConfigurationCustomerCapabilityStatusUpdatedEvent`, `V2CoreAccountIncludingConfigurationCustomerUpdatedEvent`, `V2CoreAccountIncludingConfigurationMerchantCapabilityStatusUpdatedEvent`, `V2CoreAccountIncludingConfigurationMerchantUpdatedEvent`, `V2CoreAccountIncludingConfigurationRecipientCapabilityStatusUpdatedEvent`, `V2CoreAccountIncludingConfigurationRecipientUpdatedEvent`, `V2CoreAccountIncludingIdentityUpdatedEvent`, and `V2CoreAccountIncludingRequirementsUpdatedEvent`
  * Add support for new thin event `V2CoreAccountLinkCompletedEvent` with related object `V2.Core.AccountLink`

### Changes
  * Change `CustomerSession.CreateParams.customer`, `InvoiceItem.CreateParams.customer`, `PaymentMethod.AttachParams.customer`, `Subscription.CreateParams.customer`, `billing.CreditBalanceSummary.RetrieveParams.customer`, `billing.CreditBalanceTransaction.ListParams.customer`, `billing.CreditGrant.CreateParams.customer`, and `billingportal.Session.CreateParams.customer` to be optional
  * Change type of `Invoice.Parent.SubscriptionDetail.PauseCollection.behavior` and `QuotePreviewInvoice.Parent.SubscriptionDetail.PauseCollection.behavior` from `string` to `enum('keep_as_draft'|'mark_uncollectible'|'void')`
  * Change `CreditNote.refunds` to be required
  * Change `Invoice.amount_overpaid` and `QuotePreviewInvoice.amount_overpaid` to be required
  * Change type of `PaymentAttemptRecord.PaymentMethodDetail.custom` and `PaymentRecord.PaymentMethodDetail.custom` from `nullable(PaymentsPrimitivesPaymentRecordsResourcePaymentMethodCustomDetails)` to `PaymentsPrimitivesPaymentRecordsResourcePaymentMethodCustomDetails`
  * Change `PaymentRecord.ReportPaymentParams.payment_reference` to be optional
  
* [#3069](https://github.com/stripe/stripe-dotnet/pull/3069) Enhance beta version handling in ApiVersion
  * `StripeConfiguation.AddBetaVersion` will use the highest version number used for a beta feature instead of throwing an `Exception` on a conflict as it had done previously.

## 48.0.2 - 2025-04-15
* [#3101](https://github.com/stripe/stripe-dotnet/pull/3101) Replace Dictionary with ConcurrentDictionary in SerializablePropertyCache to fix a concurrency related error reported in [#3100](https://github.com/stripe/stripe-dotnet/issues/3100)

## 48.0.1 - 2025-04-14
* [#3090](https://github.com/stripe/stripe-dotnet/pull/3090) Disable Json.NET metadata special handling. Fixes issue [#3068](https://github.com/stripe/stripe-dotnet/issues/3068)

## 48.0.0 - 2025-04-01
* [#3074](https://github.com/stripe/stripe-dotnet/pull/3074) System.Text.Json Serialization Support release to GA
  * Add System.Text.Json support for serializing Stripe.net entities and objects for applications running on .NET 6 and above. Now you can pass a Stripe.net object or collection of objects to the System.Text.Json serializer and it will produce the correct JSON string.
* [#3056](https://github.com/stripe/stripe-dotnet/pull/3056) Support for APIs in the new API version 2025-03-31.basil

  This release changes the pinned API version to `2025-03-31.basil`.

  ### ⚠️ Breaking changes  due to changes in the Stripe API

  Please review details for the breaking changes and alternatives in the [Stripe API changelog](https://docs.stripe.com/changelog/basil) before upgrading.

  * Remove support for resources `SubscriptionItemUsageRecordSummary` and `SubscriptionItemUsageRecord`
  * Remove support for `Create` method on resource `SubscriptionItemUsageRecord`
  * Remove support for `List`, `ListAsync`, `ListAutoPaginating`, and `ListAutoPaginatingAsync` methods on resource `SubscriptionItemUsageRecordSummary`
  * Remove support for `Upcoming` and `UpcomingAsync` methods on resource `Invoice`
  * Remove support for `Invoice` on `Charge` and `PaymentIntent`
  * Remove support for `ShippingDetails` on `CheckoutSession`
  * Remove support for `Carrier`, `Phone`, and `TrackingNumber` on `SessionCollectedInformationShippingDetails`
  * Remove support for `Refund` on `CreditNoteCreateOptions`, `CreditNotePreviewLinesListOptions`, `CreditNotePreviewOptions`, and `CreditNote`
  * Remove support for `TaxAmounts` on `CreditNoteLineItem`, `CreditNote`, and `InvoiceLineItem`
  * Remove support for `AmountExcludingTax` and `UnitAmountExcludingTax` on `CreditNoteLineItem` and `InvoiceLineItem`
  * Remove support for `Coupon` on `CustomerCreateOptions`, `CustomerUpdateOptions`, `InvoiceCreatePreviewOptions`, `InvoiceScheduleDetailsPhasesOptions`, `SubscriptionCreateOptions`, `SubscriptionSchedulePhasesOptions`, `SubscriptionSchedulePhases`, and `SubscriptionUpdateOptions`
  * Remove support for `PromotionCode` on `CustomerCreateOptions`, `CustomerUpdateOptions`, `SubscriptionCreateOptions`, and `SubscriptionUpdateOptions`
  * Remove support for `Price` on `InvoiceItemCreateOptions`, `InvoiceItemUpdateOptions`, `InvoiceItem`, `InvoiceLineItemUpdateOptions`, `InvoiceLineItem`, and `InvoiceLinesOptions`
  * Remove support for `BillingThresholds` on `InvoiceScheduleDetailsPhaseItemOptions`, `InvoiceScheduleDetailsPhaseOptions`, `InvoiceSubscriptionDetailsItemOptions`, `SubscriptionCreateOptions`, `SubscriptionItemCreateOptions`, `SubscriptionItemUpdateOptions`, `SubscriptionItem`, `SubscriptionItemsOptions`, `SubscriptionScheduleDefaultSettingsOptions`, `SubscriptionScheduleDefaultSettings`, `SubscriptionSchedulePhaseItemOptions`, `SubscriptionSchedulePhaseItem`, `SubscriptionSchedulePhaseOptions`, `SubscriptionSchedulePhase`, `SubscriptionUpdateOptions`, and `Subscription`
  * Remove support for `ApplicationFeeAmount`, `Charge`, `PaidOutOfBand`, `Paid`, `PaymentIntent`, `Quote`, `Subscription`, `SubscriptionDetails`, `SubscriptionProrationDate`, `Tax`, `TotalTaxAmounts`, and `TransferData` on `Invoice`
  * Remove support for `Discount` on `Invoice` and `Subscription`
  * Remove support for `InvoiceItem`, `ProrationDetails`, `Proration`, `TaxRates`, and `Type` on `InvoiceLineItem`
  * Remove support for `Plan` and `SubscriptionItem` on `InvoiceItem` and `InvoiceLineItem`
  * Remove support for `UnitAmount` on `InvoiceItemCreateOptions`, `InvoiceItemUpdateOptions`, and `InvoiceItem`
  * Remove support for `SubscriptionItems` on `InvoiceLineItemListOptions` and `InvoiceLineItemsListOptions`
  * Remove support for `Subscription` and `UnitAmountDecimal` on `InvoiceItem`
  * Remove support for `NaverPay` on `PaymentMethodUpdateOptions`
  * Remove support for `AggregateUsage` on `PlanCreateOptions`, `Plan`, `PriceRecurringOptions`, and `PriceRecurring`
  * Remove support for `CurrentPeriodEnd` and `CurrentPeriodStart` on `Subscription`
  * Remove support for Page on `V2.EventDestinationListOptions` and `V2.EventListOptions`

  ### Additions

  * Add support for new resource `InvoicePayment`
  * Add support for `Get` and `List` methods on resource `InvoicePayment`
  * Add support for `BilliePayments`, `NzBankAccountBecsDebitPayments`, and `SatispayPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
  * Add support for `HostedPaymentMethodSave` on `AccountSettingsInvoicesOptions` and `AccountSettingsInvoices`
  * Add support for `Invoices` on `AccountSettingsOptions`
  * Add support for `PresentmentDetails` on `Charge`, `CheckoutSession`, `PaymentIntent`, and `Refund`
  * Add support for `Billie` and `Satispay` on `ChargePaymentMethodDetails`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `CustomerPaymentMethod`, `PaymentIntentPaymentMethodDataOptions`, `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, `PaymentMethodCreateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
  * Add support for `NzBankAccount` on `ChargePaymentMethodDetails`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `CustomerPaymentMethod`, `MandatePaymentMethodDetails`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, `PaymentMethodCreateOptions`, `PaymentMethod`, `SetupAttemptPaymentMethodDetails`, and `SetupIntentPaymentMethodDataOptions`
  * Add support for `OptionalItems` on `Checkout.SessionCreateOptions`, `CheckoutSession`, `PaymentLinkCreateOptions`, and `PaymentLink`
  * Add support for `Permissions` on `Checkout.SessionCreateOptions` and `CheckoutSession`
  * Add support for `ShippingOptions` on `Checkout.SessionUpdateOptions`
  * Add support for `BuyerId` on `ConfirmationTokenPaymentMethodPreviewNaverPay`, `CustomerPaymentMethodNaverPay`, and `PaymentMethodNaverPay`
  * Add support for `Refunds` on `CreditNoteCreateOptions`, `CreditNotePreviewLinesListOptions`, `CreditNotePreviewOptions`, and `CreditNote`
  * Add support for `TotalTaxes` on `CreditNote` and `Invoice`
  * Add support for `Taxes` on `CreditNoteLineItem` and `InvoiceLineItem`
  * Add support for `TaxabilityReason` on `InvoiceLineItemTaxAmountsOptions` and `InvoiceLinesTaxAmountsOptions`
  * Add support for `JurisdictionLevel` on `InvoiceLineItemTaxAmountsTaxRateDataOptions` and `InvoiceLinesTaxAmountsTaxRateDataOptions`
  * Add support for `AmountOverpaid`, `ConfirmationSecret`, and `Payments` on `Invoice`
  * Add support for `Parent` on `InvoiceItem`, `InvoiceLineItem`, and `Invoice`
  * Add support for `NaverPay` on `MandatePaymentMethodDetails` and `SetupAttemptPaymentMethodDetails`
  * Add support for `SetupFutureUsage` on `PaymentIntentPaymentMethodOptionsNaverPayOptions` and `PaymentIntentPaymentMethodOptionsNaverPay`
  * Add support for `DefaultValue` on `PaymentLinkCustomFieldsDropdownOptions`, `PaymentLinkCustomFieldsDropdown`, `PaymentLinkCustomFieldsNumericOptions`, `PaymentLinkCustomFieldsNumeric`, `PaymentLinkCustomFieldsTextOptions`, and `PaymentLinkCustomFieldsText`
  * Add support for `NzBankTransfer` on `RefundDestinationDetails`
  * Add support for `CurrentPeriodEnd` and `CurrentPeriodStart` on `SubscriptionItem`
  * Add support for `Wifi` on `Terminal.ConfigurationCreateOptions`, `Terminal.ConfigurationUpdateOptions`, and `TerminalConfiguration`

  ### ⚠️ Other Breaking changes in the SDK
* [#3065](https://github.com/stripe/stripe-dotnet/pull/3065) Merge breaking changes from sdk-release/next-major branch to master
  * Adds `StripeAccount` and `StripeContext` to `StripeClientOptions`, so you can specify the Stripe-Account or Stripe-Context header at the client (instead of the individual request) level. See [PR #3058](https://github.com/stripe/stripe-dotnet/pull/3058)
  * Removes `ApiMode` from `RawRequestOptions`.  ApiMode is automatically determined from the path passed to RawRequest. See [PR #3052](https://github.com/stripe/stripe-dotnet/pull/3052)
  * Deprecates `ServiceNested` and `Service<T>` classes.  To implement custom services, use the request methods defined on `StripeClient`. See [PR #3051](https://github.com/stripe/stripe-dotnet/pull/3051)
  * Fixes `ListAutoPaging` and `ListAutoPagingAsync` to not mutate options object passed in. See [PR #2899](https://github.com/stripe/stripe-dotnet/pull/2899)
* [#3078](https://github.com/stripe/stripe-dotnet/pull/3078) and [#3085](https://github.com/stripe/stripe-dotnet/pull/3085) Remove `ListOptionsWithCreated` and clean up services that incorrectly extend `ListOptions`
  * Remove `ListOptionsWithCreated` base class. The classes that use to extend it now extend `ListOptions` and have the the `created` field defined explicitly.
  * Classes`ReportTypeService` and `AccountCapabilityService` no longer implement the `IListable` interface, and the `ListAutoPaging` and `ListAutoPagingAsync` methods are removed. This is because the list APIs here are not pageable. See #2227 for more details.
     * As a consequence, the classes `ReportTypeOptions` and `AccountCapabilityOptions` no longer extend `ListOptions` as well

## 47.5.0-beta.1 - 2025-03-18
* [#3062](https://github.com/stripe/stripe-dotnet/pull/3062) Beta SDK updates between Open API versions 1473 and 1505
  
  * Add support for `SucceedInputCollection` and `TimeoutInputCollection` test helper methods on resource `Terminal.Reader`
  * Add support for `TargetDate` on `OrderPaymentSettingsPaymentMethodOptionsAcssDebitOptions`, `OrderPaymentSettingsPaymentMethodOptionsAcssDebit`, `OrderPaymentSettingsPaymentMethodOptionsSepaDebitOptions`, and `OrderPaymentSettingsPaymentMethodOptionsSepaDebit`

## 47.4.0 - 2025-02-24
* [#3050](https://github.com/stripe/stripe-dotnet/pull/3050) Update generated code
  * Add support for `Prices` on `BillingCreditBalanceSummaryFilterApplicabilityScopeOptions`, `BillingCreditGrantApplicabilityConfigScopeOptions`, and `BillingCreditGrantApplicabilityConfigScope`
  * Add support for `Priority` on `Billing.CreditGrantCreateOptions` and `BillingCreditGrant`
  * Add support for `TargetDate` on `CheckoutSessionPaymentMethodOptionsAcssDebitOptions`, `CheckoutSessionPaymentMethodOptionsAcssDebit`, `CheckoutSessionPaymentMethodOptionsAuBecsDebitOptions`, `CheckoutSessionPaymentMethodOptionsAuBecsDebit`, `CheckoutSessionPaymentMethodOptionsBacsDebitOptions`, `CheckoutSessionPaymentMethodOptionsBacsDebit`, `CheckoutSessionPaymentMethodOptionsSepaDebitOptions`, `CheckoutSessionPaymentMethodOptionsSepaDebit`, `CheckoutSessionPaymentMethodOptionsUsBankAccountOptions`, `CheckoutSessionPaymentMethodOptionsUsBankAccount`, `PaymentIntentPaymentMethodOptionsAcssDebitOptions`, `PaymentIntentPaymentMethodOptionsAcssDebit`, `PaymentIntentPaymentMethodOptionsAuBecsDebitOptions`, `PaymentIntentPaymentMethodOptionsAuBecsDebit`, `PaymentIntentPaymentMethodOptionsBacsDebitOptions`, `PaymentIntentPaymentMethodOptionsBacsDebit`, `PaymentIntentPaymentMethodOptionsSepaDebitOptions`, `PaymentIntentPaymentMethodOptionsSepaDebit`, `PaymentIntentPaymentMethodOptionsUsBankAccountOptions`, and `PaymentIntentPaymentMethodOptionsUsBankAccount`
  * Add support for `Restrictions` on `CheckoutSessionPaymentMethodOptionsCardOptions` and `CheckoutSessionPaymentMethodOptionsCard`
  * Add support for `CollectedInformation` on `Checkout.SessionUpdateOptions` and `CheckoutSession`
  * Add support for `Metadata` on `ProductDefaultPriceDataOptions`
* [#3054](https://github.com/stripe/stripe-dotnet/pull/3054) Improved examples
* [#3055](https://github.com/stripe/stripe-dotnet/pull/3055) add codeowners file

## 47.4.0-beta.1 - 2025-02-07
* [#3049](https://github.com/stripe/stripe-dotnet/pull/3049) Update generated code for beta
  * Add support for `RejectedReason` on `AccountRiskControls`
  * Add support for `ProductTaxCodeSelector` on `AccountSessionComponentsOptions`
  * Add support for `Prices` on `BillingCreditBalanceSummaryFilterApplicabilityScopeOptions`, `BillingCreditGrantApplicabilityConfigScopeOptions`, and `BillingCreditGrantApplicabilityConfigScope`
  * Add support for `BrandProduct` on `ChargePaymentMethodDetailsAmazonPayFundingCard` and `ChargePaymentMethodDetailsRevolutPayFundingCard`
  * Add support for `Restrictions` on `CheckoutSessionPaymentMethodOptionsCardOptions` and `CheckoutSessionPaymentMethodOptionsCard`

## 47.3.0 - 2025-01-27
* [#3044](https://github.com/stripe/stripe-dotnet/pull/3044) Update generated code
  * Add support for `Close` method on resource `Treasury.FinancialAccount`
  * Add support for `PayByBankPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
  * Add support for `DirectorshipDeclaration` and `OwnershipExemptionReason` on `AccountCompanyOptions`, `AccountCompany`, and `TokenAccountCompanyOptions`
  * Add support for `ProofOfUltimateBeneficialOwnership` on `AccountDocumentsOptions`
  * Add support for `FinancialAccount` on `AccountSessionComponentsOptions`, `AccountSessionComponents`, and `TreasuryOutboundTransferDestinationPaymentMethodDetails`
  * Add support for `FinancialAccountTransactions`, `IssuingCard`, and `IssuingCardsList` on `AccountSessionComponentsOptions` and `AccountSessionComponents`
  * Add support for `AdviceCode` on `ChargeOutcome`, `InvoiceLastFinalizationError`, `PaymentIntentLastPaymentError`, `SetupAttemptSetupError`, `SetupIntentLastSetupError`, and `StripeError`
  * Add support for `PayByBank` on `ChargePaymentMethodDetails`, `CheckoutSessionPaymentMethodOptionsOptions`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, `PaymentMethodCreateOptions`, `PaymentMethodUpdateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
  * Add support for `Country` on `ChargePaymentMethodDetailsPaypal`, `ConfirmationTokenPaymentMethodPreviewPaypal`, and `PaymentMethodPaypal`
  * Add support for `Discounts` on `CheckoutSession`
  * Add support for `PhoneNumberCollection` on `PaymentLinkUpdateOptions`
  * Add support for `Jpy` on `TerminalConfigurationTippingOptions` and `TerminalConfigurationTipping`
  * Add support for `Nickname` on `Treasury.FinancialAccountCreateOptions`, `Treasury.FinancialAccountUpdateOptions`, and `TreasuryFinancialAccount`
  * Add support for `ForwardingSettings` on `Treasury.FinancialAccountUpdateOptions`
  * Add support for `IsDefault` on `TreasuryFinancialAccount`
  * Add support for `DestinationPaymentMethodData` on `Treasury.OutboundTransferCreateOptions`
  * Change type of `TreasuryOutboundTransferDestinationPaymentMethodDetailsType` from `literal('us_bank_account')` to `enum('financial_account'|'us_bank_account')`
  * Add support for `OutboundTransfer` on `TreasuryReceivedCreditLinkedFlowsSourceFlowDetails`
* [#3046](https://github.com/stripe/stripe-dotnet/pull/3046) update justfile import
* [#3045](https://github.com/stripe/stripe-dotnet/pull/3045) Added CONTRIBUTING.md file
* [#3047](https://github.com/stripe/stripe-dotnet/pull/3047) Pin ubuntu version in ci
* [#3040](https://github.com/stripe/stripe-dotnet/pull/3040) Add justfile, remove coveralls
* [#3042](https://github.com/stripe/stripe-dotnet/pull/3042) Remove debug build and test from CI
* [#3039](https://github.com/stripe/stripe-dotnet/pull/3039) Fixed supported frameworks in project description and readme
* [#3038](https://github.com/stripe/stripe-dotnet/pull/3038) Added pull request template

## 47.3.0-beta.3 - 2025-01-23
* [#3048](https://github.com/stripe/stripe-dotnet/pull/3048) Update generated code for beta
  * Remove support for `StripeAccount` on `TerminalReaderActionCollectPaymentMethod`, `TerminalReaderActionConfirmPaymentIntent`, `TerminalReaderActionProcessPaymentIntent`, and `TerminalReaderActionRefundPayment`

## 47.3.0-beta.2 - 2025-01-17
* [#3043](https://github.com/stripe/stripe-dotnet/pull/3043) Update generated code for beta
  * Add support for `PayByBankPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
  * Add support for `DirectorshipDeclaration` on `AccountCompanyOptions` and `TokenAccountCompanyOptions`
  * Add support for `ProofOfUltimateBeneficialOwnership` on `AccountDocumentsOptions`
  * Add support for `TaxThresholdMonitoring` on `AccountSessionComponentsOptions`
  * Add support for `FinancialAccountTransactions`, `FinancialAccount`, `IssuingCard`, and `IssuingCardsList` on `AccountSessionComponents`
  * Add support for `PayByBank` on `ChargePaymentMethodDetails`, `CheckoutSessionPaymentMethodOptionsOptions`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, `PaymentMethodCreateOptions`, `PaymentMethodUpdateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
  * Add support for `Discounts` on `CheckoutSession`
  * Add support for `Jpy` on `TerminalConfigurationTippingOptions` and `TerminalConfigurationTipping`

## 47.3.0-beta.1 - 2025-01-09
* [#3037](https://github.com/stripe/stripe-dotnet/pull/3037) Update generated code for beta
  * Add support for `Close` method on resource `Treasury.FinancialAccount`
  * Add support for `OwnershipExemptionReason` on `AccountCompanyOptions`, `AccountCompany`, and `TokenAccountCompanyOptions`
  * Add support for `DirectorshipDeclaration` on `AccountCompany`
  * Add support for `AdviceCode` on `ChargeOutcome`, `InvoiceLastFinalizationError`, `PaymentIntentLastPaymentError`, `SetupAttemptSetupError`, `SetupIntentLastSetupError`, and `StripeError`
  * Add support for `BrandProduct` on `Card`, `SourceCardPresent`, `SourceCard`, and `SourceThreeDSecure`
  * Add support for `Country` on `ChargePaymentMethodDetailsPaypal`, `ConfirmationTokenPaymentMethodPreviewPaypal`, and `PaymentMethodPaypal`
  * Add support for `PhoneNumberCollection` on `PaymentLinkUpdateOptions`
  * Add support for `Nickname` on `Treasury.FinancialAccountCreateOptions`, `Treasury.FinancialAccountUpdateOptions`, and `TreasuryFinancialAccount`
  * Add support for `ForwardingSettings` on `Treasury.FinancialAccountUpdateOptions`
  * Add support for `IsDefault` on `TreasuryFinancialAccount`
  * Add support for `DestinationPaymentMethodData` on `Treasury.OutboundTransferCreateOptions`
  * Add support for `FinancialAccount` on `TreasuryOutboundTransferDestinationPaymentMethodDetails`
  * Change type of `TreasuryOutboundTransferDestinationPaymentMethodDetailsType` from `literal('us_bank_account')` to `enum('financial_account'|'us_bank_account')`
  * Add support for `OutboundTransfer` on `TreasuryReceivedCreditLinkedFlowsSourceFlowDetails`

## 47.2.0 - 2024-12-18
* [#3036](https://github.com/stripe/stripe-dotnet/pull/3036) This release changes the pinned API version to `2024-12-18.acacia`.
  * Add support for `NetworkAdviceCode` and `NetworkDeclineCode` on `ChargeOutcome`, `InvoiceLastFinalizationError`, `PaymentIntentLastPaymentError`, `SetupAttemptSetupError`, `SetupIntentLastSetupError`, and `StripeError`
  * Add support for `CreditsApplicationInvoiceVoided` on `BillingCreditBalanceTransactionCredit`
  * Change type of `BillingCreditBalanceTransactionCreditType` from `literal('credits_granted')` to `enum('credits_application_invoice_voided'|'credits_granted')`
  * Add support for `AllowRedisplay` on `Card` and `Source`
  * Add support for `RegulatedStatus` on `Card`, `ChargePaymentMethodDetailsCard`, `ConfirmationTokenPaymentMethodPreviewCard`, and `PaymentMethodCard`
  * Add support for `Funding` on `ChargePaymentMethodDetailsAmazonPay` and `ChargePaymentMethodDetailsRevolutPay`
  * Add support for `NetworkTransactionId` on `ChargePaymentMethodDetailsCard`
  * Add support for `ReferencePrefix` on `CheckoutSessionPaymentMethodOptionsBacsDebitMandateOptionsOptions`, `CheckoutSessionPaymentMethodOptionsBacsDebitMandateOptions`, `CheckoutSessionPaymentMethodOptionsSepaDebitMandateOptionsOptions`, `CheckoutSessionPaymentMethodOptionsSepaDebitMandateOptions`, `PaymentIntentPaymentMethodOptionsBacsDebitMandateOptionsOptions`, `PaymentIntentPaymentMethodOptionsBacsDebitMandateOptions`, `PaymentIntentPaymentMethodOptionsSepaDebitMandateOptionsOptions`, `PaymentIntentPaymentMethodOptionsSepaDebitMandateOptions`, `SetupIntentPaymentMethodOptionsBacsDebitMandateOptionsOptions`, `SetupIntentPaymentMethodOptionsBacsDebitMandateOptions`, `SetupIntentPaymentMethodOptionsSepaDebitMandateOptionsOptions`, and `SetupIntentPaymentMethodOptionsSepaDebitMandateOptions`
  * Add support for `VisaCompliance` on `DisputeEvidenceDetailsEnhancedEligibility`, `DisputeEvidenceEnhancedEvidenceOptions`, and `DisputeEvidenceEnhancedEvidence`
  * Add support for `AccountHolderAddress` and `BankAddress` on `FundingInstructionsBankTransferFinancialAddressesIban`, `FundingInstructionsBankTransferFinancialAddressesSortCode`, `FundingInstructionsBankTransferFinancialAddressesSpei`, `FundingInstructionsBankTransferFinancialAddressesZengin`, `PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesIban`, `PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesSortCode`, `PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesSpei`, and `PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesZengin`
  * Add support for `AccountHolderName` on `FundingInstructionsBankTransferFinancialAddressesSpei` and `PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesSpei`
  * Add support for `DisabledReason` on `InvoiceAutomaticTax`, `SubscriptionAutomaticTax`, `SubscriptionScheduleDefaultSettingsAutomaticTax`, and `SubscriptionSchedulePhasesAutomaticTax`
  * Add support for `TaxId` on `IssuingAuthorizationMerchantData` and `IssuingTransactionMerchantData`
  * Add support for `TrialPeriodDays` on `PaymentLinkSubscriptionDataOptions`
  * Add support for `Al`, `Am`, `Ao`, `Ba`, `Bb`, `Bs`, `Cd`, `Gn`, `Kh`, `Me`, `Mk`, `Mr`, `Np`, `Pe`, `Sn`, `Sr`, `Tj`, `Ug`, `Uy`, `Zm`, and `Zw` on `TaxRegistrationCountryOptionsOptions` and `TaxRegistrationCountryOptions`

## 47.2.0-beta.3 - 2024-12-12
* [#3035](https://github.com/stripe/stripe-dotnet/pull/3035) Update generated code for beta
  * Add support for `AllowRedisplay` on `Card` and `Source`
  * Remove support for `AmountRefunded` on `PaymentRecord`
  * Add support for `Account` on `TerminalReaderActionCollectPaymentMethod`, `TerminalReaderActionConfirmPaymentIntent`, `TerminalReaderActionProcessPaymentIntent`, and `TerminalReaderActionRefundPayment`
* [#3033](https://github.com/stripe/stripe-dotnet/pull/3033) System.Text.Json Serialization Support in .NET SDK Objects
  - Add System.Text.Json support for serializing Stripe.net entities and objects for applications running on .NET 6 and above. Now you can pass a Stripe.net object or collection of objects to the System.Text.Json serializer and it will produce the correct JSON string.

## 47.2.0-beta.2 - 2024-12-05
* [#3032](https://github.com/stripe/stripe-dotnet/pull/3032) Update generated code for beta
  * Add support for `AutomaticIndirectTax` on `AccountCapabilitiesOptions` and `AccountCapabilities`
  * Add support for `ReferencePrefix` on `CheckoutSessionPaymentMethodOptionsBacsDebitMandateOptionsOptions`, `CheckoutSessionPaymentMethodOptionsBacsDebitMandateOptions`, `CheckoutSessionPaymentMethodOptionsSepaDebitMandateOptionsOptions`, `CheckoutSessionPaymentMethodOptionsSepaDebitMandateOptions`, `OrderPaymentSettingsPaymentMethodOptionsSepaDebitMandateOptionsOptions`, `OrderPaymentSettingsPaymentMethodOptionsSepaDebitMandateOptions`, `PaymentIntentPaymentMethodOptionsBacsDebitMandateOptionsOptions`, `PaymentIntentPaymentMethodOptionsBacsDebitMandateOptions`, `PaymentIntentPaymentMethodOptionsSepaDebitMandateOptionsOptions`, `PaymentIntentPaymentMethodOptionsSepaDebitMandateOptions`, `SetupIntentPaymentMethodOptionsBacsDebitMandateOptionsOptions`, `SetupIntentPaymentMethodOptionsBacsDebitMandateOptions`, `SetupIntentPaymentMethodOptionsSepaDebitMandateOptionsOptions`, and `SetupIntentPaymentMethodOptionsSepaDebitMandateOptions`
  * Add support for `DisabledReason` on `InvoiceAutomaticTax`, `SubscriptionAutomaticTax`, `SubscriptionScheduleDefaultSettingsAutomaticTax`, and `SubscriptionSchedulePhasesAutomaticTax`
  * Add support for `TrialPeriodDays` on `PaymentLinkSubscriptionDataOptions`

## 47.2.0-beta.1 - 2024-11-21
* [#3031](https://github.com/stripe/stripe-dotnet/pull/3031) Update generated code for beta
  * Add support for `NetworkAdviceCode` and `NetworkDeclineCode` on `ChargeOutcome`, `InvoiceLastFinalizationError`, `PaymentIntentLastPaymentError`, `SetupAttemptSetupError`, `SetupIntentLastSetupError`, and `StripeError`
  * Add support for `Funding` on `ChargePaymentMethodDetailsAmazonPay` and `ChargePaymentMethodDetailsRevolutPay`
  * Add support for `AmountRequested` and `PartialAuthorization` on `ChargePaymentMethodDetailsCard`
  * Add support for `Metadata` on `CheckoutSessionLineItemsOptions` and `LineItem`
  * Add support for `LineItems` on `Checkout.SessionUpdateOptions`, `CheckoutSessionPermissionsUpdateOptions`, and `CheckoutSessionPermissionsUpdate`
  * Add support for `AdjustableQuantity` and `Display` on `LineItem`
  * Add support for `RequestPartialAuthorization` on `PaymentIntentPaymentMethodOptionsCardOptions` and `PaymentIntentPaymentMethodOptionsCard`
  * Add support for `PaymentMethodOptions` on `PaymentIntentIncrementAuthorizationOptions`

## 47.1.0 - 2024-11-20
* [#3025](https://github.com/stripe/stripe-dotnet/pull/3025) This release changes the pinned API version to `2024-11-20.acacia`.
  * Add support for `Respond` test helper method on resource `Issuing.Authorization`
  * Add support for `Authorizer` on `AccountRelationshipOptions` and `TokenPersonRelationshipOptions`
  * Add support for `AdaptivePricing` on `Checkout.SessionCreateOptions` and `CheckoutSession`
  * Add support for `MandateOptions` on `CheckoutSessionPaymentMethodOptionsBacsDebitOptions`, `CheckoutSessionPaymentMethodOptionsBacsDebit`, `CheckoutSessionPaymentMethodOptionsSepaDebitOptions`, and `CheckoutSessionPaymentMethodOptionsSepaDebit`
  * Add support for `RequestExtendedAuthorization`, `RequestIncrementalAuthorization`, `RequestMulticapture`, and `RequestOvercapture` on `CheckoutSessionPaymentMethodOptionsCardOptions` and `CheckoutSessionPaymentMethodOptionsCard`
  * Add support for `CaptureMethod` on `CheckoutSessionPaymentMethodOptionsKakaoPayOptions`, `CheckoutSessionPaymentMethodOptionsKrCardOptions`, `CheckoutSessionPaymentMethodOptionsNaverPayOptions`, `CheckoutSessionPaymentMethodOptionsPaycoOptions`, and `CheckoutSessionPaymentMethodOptionsSamsungPayOptions`
  * Add support for `AccountHolderAddress`, `AccountHolderName`, `AccountType`, and `BankAddress` on `FundingInstructionsBankTransferFinancialAddressesAba`, `FundingInstructionsBankTransferFinancialAddressesSwift`, `PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesAba`, and `PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesSwift`
  * Add support for `MerchantAmount` and `MerchantCurrency` on `Issuing.TestHelpersAuthorizationCreateOptions`
  * Add support for `FraudChallenges` and `VerifiedByFraudChallenge` on `IssuingAuthorization`
  * Add support for `SubmitType` on `PaymentLinkUpdateOptions`
  * Add support for `TraceId` on `Payout`
  * Add support for `NetworkDeclineCode` on `RefundDestinationDetailsBlik` and `RefundDestinationDetailsSwish`
* [#3021](https://github.com/stripe/stripe-dotnet/pull/3021) Fix URL encoding of id strings passed to service methods
* [#3026](https://github.com/stripe/stripe-dotnet/pull/3026) Fix V2 list options base class
  * Remove `StartingAfter` and `EndingBefore` properties from `Stripe.V2.EventListOptions` and `Stripe.V2.EventDestinationListOptions`.  These properties are not supported on V2 List APIs and would result in a HTTP 400 error if provided.

## 47.1.0-beta.3 - 2024-11-14
* [#3027](https://github.com/stripe/stripe-dotnet/pull/3027) Update generated code for beta
  * Add support for `AccountHolderAddress` and `BankAddress` on `FundingInstructionsBankTransferFinancialAddressesIban`, `FundingInstructionsBankTransferFinancialAddressesSortCode`, `FundingInstructionsBankTransferFinancialAddressesSpei`, `FundingInstructionsBankTransferFinancialAddressesZengin`, `PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesIban`, `PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesSortCode`, `PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesSpei`, and `PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesZengin`
  * Add support for `AccountHolderName` on `FundingInstructionsBankTransferFinancialAddressesSpei` and `PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesSpei`

## 47.1.0-beta.2 - 2024-11-07
* [#3022](https://github.com/stripe/stripe-dotnet/pull/3022) Update generated code for beta
  * Add support for new resources `Issuing.FraudLiabilityDebit`, `PaymentAttemptRecord`, and `PaymentRecord`
  * Add support for `Get` and `List` methods on resources `FraudLiabilityDebit` and `PaymentAttemptRecord`
  * Add support for `Get`, `ReportPaymentAttemptCanceled`, `ReportPaymentAttemptFailed`, `ReportPaymentAttemptGuaranteed`, `ReportPaymentAttempt`, and `ReportPayment` methods on resource `PaymentRecord`
  * Remove support for `MoneyMovement` on `AccountSessionComponentsFinancialAccountFeaturesOptions`
  * Add support for `CardManagement`, `CardSpendDisputeManagement`, `CardholderManagement`, and `SpendControlManagement` on `AccountSessionComponentsIssuingCardFeaturesOptions`
  * Add support for `DisableStripeUserAuthentication` on `AccountSessionComponentsIssuingCardsListFeaturesOptions`
  * Add support for `AdaptivePricing` on `Checkout.SessionCreateOptions` and `CheckoutSession`
  * Add support for `MandateOptions` on `CheckoutSessionPaymentMethodOptionsBacsDebitOptions`, `CheckoutSessionPaymentMethodOptionsBacsDebit`, `CheckoutSessionPaymentMethodOptionsSepaDebitOptions`, and `CheckoutSessionPaymentMethodOptionsSepaDebit`
  * Add support for `RequestDecrementalAuthorization`, `RequestExtendedAuthorization`, `RequestIncrementalAuthorization`, `RequestMulticapture`, and `RequestOvercapture` on `CheckoutSessionPaymentMethodOptionsCardOptions` and `CheckoutSessionPaymentMethodOptionsCard`
  * Add support for `CaptureMethod` on `CheckoutSessionPaymentMethodOptionsKakaoPayOptions`, `CheckoutSessionPaymentMethodOptionsKrCardOptions`, `CheckoutSessionPaymentMethodOptionsNaverPayOptions`, `CheckoutSessionPaymentMethodOptionsPaycoOptions`, and `CheckoutSessionPaymentMethodOptionsSamsungPayOptions`
  * Add support for `AccountHolderAddress`, `AccountHolderName`, `AccountType`, and `BankAddress` on `FundingInstructionsBankTransferFinancialAddressesAba`, `FundingInstructionsBankTransferFinancialAddressesSwift`, `PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesAba`, and `PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesSwift`
  * Add support for `PaymentRecordData` and `PaymentRecord` on `InvoiceAttachPaymentOptions`
  * Remove support for `OutOfBandPayment` on `InvoiceAttachPaymentOptions`
  * Add support for `AmountOverpaid` on `Invoice`
  * Add support for `MerchantAmount` and `MerchantCurrency` on `Issuing.TestHelpersAuthorizationCreateOptions`
  * Add support for `SubmitType` on `PaymentLinkUpdateOptions`

## 47.1.0-beta.1 - 2024-10-29
* [#3018](https://github.com/stripe/stripe-dotnet/pull/3018) Update generated code for beta
  * Add support for `TriggerAction` method on resource `PaymentIntent`
  * Add support for `IdBankTransferPaymentsBca` and `IdBankTransferPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
  * Add support for `BankBcaOnboarding` on `AccountSettingsOptions` and `AccountSettings`
  * Add support for `SendMoney` on `AccountSessionComponentsRecipientsFeaturesOptions`
  * Add support for `IdBankTransfer` on `ChargePaymentMethodDetails`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `InvoicePaymentSettingsPaymentMethodOptionsOptions`, `InvoicePaymentSettingsPaymentMethodOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, `PaymentMethodCreateOptions`, `PaymentMethod`, `RefundDestinationDetails`, `SetupAttemptPaymentMethodDetails`, `SetupIntentPaymentMethodDataOptions`, `SubscriptionPaymentSettingsPaymentMethodOptionsOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptions`
  * Add support for `Gopay`, `Qris`, and `Shopeepay` on `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, and `PaymentMethodConfiguration`
* [#3011](https://github.com/stripe/stripe-dotnet/pull/3011) Do not allow setting API Version directly on StripeConfiguration
  * `StripeConfiguration.ApiVersion` is no longer settable. If you were using this to set the beta headers, use the helper method `StripeConfiguration.AddBetaVersion()` instead.

## 47.0.0 - 2024-10-29

Historically, when upgrading webhooks to a new API version, you also had to upgrade your SDK version. Your webhook's API version needed to match the API version pinned by the SDK you were using to ensure successful deserialization of events. With the `2024-09-30.acacia` release, Stripe follows a [new API release process](https://stripe.com/blog/introducing-stripes-new-api-release-process). As a result, you can safely upgrade your webhook endpoints to any API version within a biannual release (like `acacia`) without upgrading the SDK.

However, [a bug](https://github.com/stripe/stripe-dotnet/pull/3010) in the `46.x.y` SDK releases meant that webhook version upgrades from the SDK's pinned `2024-09-30.acacia` version to the new `2024-10-28.acacia` version would fail. Therefore, we are shipping SDK support for `2024-10-28.acacia` as a major version to enforce the idea that an SDK upgrade is also required. Future API versions in the `acacia` line will be released as minor versions.

* [#2997](https://github.com/stripe/stripe-dotnet/pull/2997) This release changes the pinned API version to `2024-10-28.acacia`."
  * Add support for new resource `V2.EventDestinations`
  * Add support for `Create`, `Get`, `Update`, `List`, `Delete`, `Disable`, `Enable` and `Ping` methods on resource `V2.EventDestinations`
  * Add support for `SubmitCard` test helper method on resource `Issuing.Card`
  * Add support for `Groups` on `AccountCreateOptions`, `AccountUpdateOptions`, and `Account`
  * Add support for `AlmaPayments`, `KakaoPayPayments`, `KrCardPayments`, `NaverPayPayments`, `PaycoPayments`, and `SamsungPayPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
  * Add support for `DisableStripeUserAuthentication` on `AccountSessionComponentsAccountManagementFeaturesOptions`, `AccountSessionComponentsAccountManagementFeatures`, `AccountSessionComponentsAccountOnboardingFeaturesOptions`, `AccountSessionComponentsAccountOnboardingFeatures`, `AccountSessionComponentsBalancesFeaturesOptions`, `AccountSessionComponentsBalancesFeatures`, `AccountSessionComponentsNotificationBannerFeaturesOptions`, `AccountSessionComponentsNotificationBannerFeatures`, `AccountSessionComponentsPayoutsFeaturesOptions`, and `AccountSessionComponentsPayoutsFeatures`
  * Add support for `ScheduleAtPeriodEnd` on `BillingPortalConfigurationFeaturesSubscriptionUpdateOptions` and `BillingPortalConfigurationFeaturesSubscriptionUpdate`
  * Add support for `Alma` on `ChargePaymentMethodDetails`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, `PaymentMethodCreateOptions`, `PaymentMethod`, `RefundDestinationDetails`, and `SetupIntentPaymentMethodDataOptions`
  * Add support for `KakaoPay` and `KrCard` on `ChargePaymentMethodDetails`, `CheckoutSessionPaymentMethodOptionsOptions`, `CheckoutSessionPaymentMethodOptions`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `MandatePaymentMethodDetails`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, `SetupAttemptPaymentMethodDetails`, and `SetupIntentPaymentMethodDataOptions`
  * Add support for `NaverPay` on `ChargePaymentMethodDetails`, `CheckoutSessionPaymentMethodOptionsOptions`, `CheckoutSessionPaymentMethodOptions`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethodUpdateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
  * Add support for `Payco` and `SamsungPay` on `ChargePaymentMethodDetails`, `CheckoutSessionPaymentMethodOptionsOptions`, `CheckoutSessionPaymentMethodOptions`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
  * Add support for `EnhancedEvidence` on `DisputeEvidenceOptions` and `DisputeEvidence`
  * Add support for `EnhancedEligibilityTypes` on `Dispute`
  * Add support for `EnhancedEligibility` on `DisputeEvidenceDetails`
  * Add support for `Metadata` on `Forwarding.RequestCreateOptions` and `ForwardingRequest`
  * Add support for `AutomaticallyFinalizesAt` on `InvoiceCreateOptions` and `InvoiceUpdateOptions`
  * Add support for `AmazonPay` on `PaymentMethodDomain`
  * Add support for `FlatAmount` and `RateType` on `TaxCalculationTaxBreakdownTaxRateDetails` and `TaxRate`
  * Add support for `By`, `Cr`, `Ec`, `Ma`, `Md`, `Rs`, `Ru`, `Tz`, and `Uz` on `TaxRegistrationCountryOptionsOptions` and `TaxRegistrationCountryOptions`
  * Add support for `Pln` on `TerminalConfigurationTippingOptions` and `TerminalConfigurationTipping`

## 46.3.0-beta.1 - 2024-10-18
* [#3000](https://github.com/stripe/stripe-dotnet/pull/3000) Update generated code for beta
  * Add support for `AlmaPayments`, `GopayPayments`, `KakaoPayPayments`, `KrCardPayments`, `NaverPayPayments`, `PaycoPayments`, `QrisPayments`, `SamsungPayPayments`, `ShopeepayPayments`, `TreasuryEvolve`, `TreasuryFifthThird`, and `TreasuryGoldmanSachs` on `AccountCapabilitiesOptions` and `AccountCapabilities`
  * Add support for `ScheduleAtPeriodEnd` on `BillingPortalConfigurationFeaturesSubscriptionUpdateOptions` and `BillingPortalConfigurationFeaturesSubscriptionUpdate`
  * Add support for `Alma` on `ChargePaymentMethodDetails`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, `PaymentMethodCreateOptions`, `PaymentMethod`, `RefundDestinationDetails`, and `SetupIntentPaymentMethodDataOptions`
  * Add support for `Gopay`, `Qris`, and `Shopeepay` on `ChargePaymentMethodDetails`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
  * Add support for `Metadata` on `Forwarding.RequestCreateOptions`
  * Add support for `AmazonPay` on `PaymentMethodDomain`
  * Add support for `ExternalReference` on `TaxFormPayeeOptions` and `TaxFormPayee`
  * Change type of `TaxFormPayeeTypeOptions` and `TaxFormPayeeType` from `literal('account')` to `enum('account'|'external_reference')`
  * Add support for `AuSerr`, `CaMrdp`, `EuDac7`, `GbMrdp`, and `NzMrdp` on `TaxForm`
  * Add support for `Pln` on `TerminalConfigurationTippingOptions` and `TerminalConfigurationTipping`
  * Add support for `Bank` on `TreasuryFinancialAccountFeaturesFinancialAddressesAbaOptions`, `TreasuryFinancialAccountFeaturesFinancialAddressesAba`, and `TreasuryFinancialAccountFinancialAddressesAbaOptions`
* [#3004](https://github.com/stripe/stripe-dotnet/pull/3004) Ramya/merge dotnet beta

## 46.2.2 - 2024-10-29
* [#3010](https://github.com/stripe/stripe-dotnet/pull/3010) Update webhook API version validation
  - Update webhook event processing to accept events from any API version within the supported major release

## 46.2.1 - 2024-10-18
* [#3008](https://github.com/stripe/stripe-dotnet/pull/3008) update object tags for meter-related classes
  - fixes a bug where the `object` property of the `MeterEvent`, `MeterEventAdjustment`, and `MeterEventSession` didn't match the server.
* [#3007](https://github.com/stripe/stripe-dotnet/pull/3007) Fixes ApiRequestorAdapter requests with BaseAddress other than Api
  - fixes bug where OAuthTokenService created without an explicit StripeClient accesses the wrong base url

* [#3003](https://github.com/stripe/stripe-dotnet/pull/3003) Cleaned up examples and added documentation

## 46.2.0 - 2024-10-09
* [#3002](https://github.com/stripe/stripe-dotnet/pull/3002) Add ConfigureAwait calls to async calls that are awaited
  * Fixes issue [#2998](https://github.com/stripe/stripe-dotnet/issues/2998) that was introduced in v46

## 46.2.0-beta.3 - 2024-10-08
* [#2975](https://github.com/stripe/stripe-dotnet/pull/2975) Update generated code for beta
  * Add support for `SubmitCard` test helper method on resource `Issuing.Card`
  * Add support for `Groups` on `AccountCreateOptions`, `AccountUpdateOptions`, and `Account`
  * Add support for `DisableStripeUserAuthentication` on `AccountSessionComponentsAccountManagementFeaturesOptions`, `AccountSessionComponentsAccountManagementFeatures`, `AccountSessionComponentsAccountOnboardingFeaturesOptions`, `AccountSessionComponentsAccountOnboardingFeatures`, `AccountSessionComponentsBalancesFeaturesOptions`, `AccountSessionComponentsBalancesFeatures`, `AccountSessionComponentsFinancialAccountFeaturesOptions`, `AccountSessionComponentsNotificationBannerFeaturesOptions`, `AccountSessionComponentsNotificationBannerFeatures`, `AccountSessionComponentsPayoutsFeaturesOptions`, and `AccountSessionComponentsPayoutsFeatures`
  * Add support for `CardSpendDisputeManagement` and `SpendControlManagement` on `AccountSessionComponentsIssuingCardsListFeaturesOptions`
  * Add support for `KakaoPay` and `KrCard` on `ChargePaymentMethodDetails`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `MandatePaymentMethodDetails`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, `SetupAttemptPaymentMethodDetails`, and `SetupIntentPaymentMethodDataOptions`
  * Add support for `NaverPay` on `ChargePaymentMethodDetails`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethodUpdateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
  * Add support for `Payco` and `SamsungPay` on `ChargePaymentMethodDetails`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
  * Add support for `Metadata` on `ForwardingRequest`
  * Add support for `LineItems` on `OrderPaymentSettingsPaymentMethodOptionsPaypalOptions`, `OrderPaymentSettingsPaymentMethodOptionsPaypal`, `PaymentIntentPaymentMethodOptionsPaypalOptions`, and `PaymentIntentPaymentMethodOptionsPaypal`
  * Add support for `FlatAmount` and `RateType` on `TaxCalculationTaxBreakdownTaxRateDetails` and `TaxRate`
  * Add support for `By`, `Cr`, `Ec`, `Ma`, `Md`, `Rs`, `Ru`, `Tz`, and `Uz` on `TaxRegistrationCountryOptionsOptions` and `TaxRegistrationCountryOptions`

## 46.2.0-beta.1 - 2024-10-03
* [#2991](https://github.com/stripe/stripe-dotnet/pull/2991) Updates beta branch with changes in master and update generated code
  * Add support for `ReportingChart` on `AccountSessionComponentsOptions`
  * Remove support for `FromSchedule` on `QuoteSubscriptionData`
  * Add support for `AllowRedisplay` on `TerminalReaderCollectConfigOptions`

## 46.1.0 - 2024-10-03
* [#2995](https://github.com/stripe/stripe-dotnet/pull/2995) Update the class for `ThinEvent` to include `Livemode ` and `Reason`
* [#2992](https://github.com/stripe/stripe-dotnet/pull/2992) Remove special case Newtonsoft v12 for .net8.0
* [#2993](https://github.com/stripe/stripe-dotnet/pull/2993) Update generated code
  * Remove the support for resource `Margin` that was accidentally made public in the last release

## 46.0.0 - 2024-10-01

* [#2980](https://github.com/stripe/stripe-dotnet/pull/2980) Support for APIs in the new API version 2024-09-30.acacia

  This release changes the pinned API version to `2024-09-30.acacia`. Please read the [API Changelog](https://docs.stripe.com/changelog/acacia#2024-09-30.acacia) and carefully review the API changes before upgrading.

  ### ⚠️ Breaking changes due to changes in the API

  * Rename `UsageThresholdConfig` to `UsageThreshold` on `Billing.Alert` and `Billing.AlertCreateOptions`
  * Remove support for `Filter` on `Billing.Alert` and `BillingAlert.AlertCreateOptions `. Use the filters on the `UsageThreshold` instead
  * Remove support for `CustomerConsentCollected` on `Terminal.ReaderProcessSetupIntentOptions`

  ### ⚠️ Other Breaking changes in the SDK

  Refer to our [migration guide for v46](https://github.com/stripe/stripe-dotnet/wiki/Migration-guide-for-v46) for a list of backwards incompatible changes in this release.  Here is a summary of things to watch out for:

  * [Remove obsolete properties and methods](https://github.com/stripe/stripe-dotnet/wiki/Migration-guide-for-v46#removals) from `Service` and `ServiceNested` base classes including `CreateEntity` and other `*Entity` and `*EntityAsync` methods, `BasePath`, and `BaseUrl`
  * [Rename `Stripe.Event` to `Stripe.EventTypes`](https://github.com/stripe/stripe-dotnet/wiki/Migration-guide-for-v46#renaming-stripeevents-to-stripeeventtypes). This class contains constants for event type strings.
  * For more predictable naming of child services and their corresponding Options classes:
      * [Rename child service classes](https://github.com/stripe/stripe-dotnet/wiki/Migration-guide-for-v46#renaming-child-services) to have the parent service's name as a prefix, e.g. `CapabilityService` is now `AccountCapabilityService`, and rename associated Options classes to match. This makes the classes more discoverable and the relationship between parent and child more clear
      * [Rename Options classes for child services](https://github.com/stripe/stripe-dotnet/wiki/Migration-guide-for-v46#renaming-options-classes) so that the name of the service or resource (e.g. `CustomerFundingInstructions`) comes before the verb (e.g. `Create`, `List`).
  * [Nested child service methods have been separated into separate services](https://github.com/stripe/stripe-dotnet/wiki/Migration-guide-for-v46#separating-child-service-methods-into-new-services). These child services were previously represented as special methods within a parent service.
  * `Newtonsoft.Json` dependency has been upgraded for all .NET target runtimes. This is potentially a breaking change if you also depend on `Newtonsoft.Json` directly from your application. To migrate, please upgrade the version of Newtonsoft.Json your application depends on.  If you have runtime conflicts with another library dependency, you can use `<bindingRedirect>` to specify which version .NET should load (see https://stackoverflow.com/a/51053646 and https://learn.microsoft.com/en-us/dotnet/framework/configure-apps/file-schema/runtime/bindingredirect-element)

  ### Additions

  * Add support for `UsageThreshold` on `Billing.AlertCreateOptions` and `BillingAlert`
  * Add support for `CustomUnitAmount` on `ProductDefaultPriceDataOptions`
  * Add support for `AllowRedisplay` on `Terminal.ReaderProcessSetupIntentOptions` and `TerminalReaderProcessConfigOptions`
  * Add support for new Usage Billing APIs `Billing.MeterEvent`, `Billing.MeterEventAdjustments`, `Billing.MeterEventSession`, `Billing.MeterEventStream` and the new Events API `Core.Events` under the [v2 namespace ](https://docs.corp.stripe.com/api-v2-overview)
  * Add method `ParseThinEvent()` on the `StripeClient` class to parse [thin events](https://docs.corp.stripe.com/event-destinations#events-overview).
  * Add methods [RawRequestAsync()](https://github.com/stripe/stripe-dotnet/tree/master?tab=readme-ov-file#custom-requests) on the `StripeClient` class that takes a HTTP method type, url and relevant parameters to make requests to the Stripe API that are not yet supported in the SDK.

  #### StripeClient

  Add access to services to StripeClient under `V1` and `V2` property accessors, so that instead of
  ```csharp
  StripeConfiguration.ApiKey = apiKey;
  var svc = new CustomerService();
  svc.Get(customerId);
  ```
  you can write:
  ```csharp
  var client = new StripeClient(apiKey);
  client.V1.Customers.Get(customerId)
  ```
  This supports a move towards a services-based client pattern where a `StripeClient` instance consolidates configuration and service access. This enables you simultaneously use multiple clients with different configuration options (such as API keys), and makes it much easier to discover what services are available by inspecting the V1 and V2 properties (either manually or via your code editors auto-completion).

## 45.15.0-beta.1 - 2024-09-18
* [#2973](https://github.com/stripe/stripe-dotnet/pull/2973) Update generated code for beta
  * Remove support for resource `QuotePhase`
  * Remove support for `Get` and `ListLineItems` methods on resource `QuotePhase`
  * Add support for `SendMoney` and `TransferBalance` on `AccountSessionComponentsFinancialAccountFeaturesOptions`

## 45.14.0 - 2024-09-18
* [#2969](https://github.com/stripe/stripe-dotnet/pull/2969) Update generated code
  * Add support for `PayerDetails` on `ChargePaymentMethodDetailsKlarna`
  * Add support for `AmazonPay` on `DisputePaymentMethodDetails`
  * Add support for `AutomaticallyFinalizesAt` on `Invoice`
  * Add support for `StateSalesTax` on `TaxRegistrationCountryOptionsUsOptions` and `TaxRegistrationCountryOptionsUs`

## 45.13.0 - 2024-09-13
* [#2962](https://github.com/stripe/stripe-dotnet/pull/2962) Update generated code
  * Add support for new resource `InvoiceRenderingTemplate`
  * Add support for `Archive`, `Get`, `List`, and `Unarchive` methods on resource `InvoiceRenderingTemplate`
  * Add support for `Required` on `CheckoutSessionTaxIdCollectionOptions`, `CheckoutSessionTaxIdCollection`, `PaymentLinkTaxIdCollectionOptions`, and `PaymentLinkTaxIdCollection`
  * Add support for `Template` on `CustomerInvoiceSettingsRenderingOptionsOptions`, `CustomerInvoiceSettingsRenderingOptions`, `InvoiceRenderingOptions`, and `InvoiceRendering`
  * Add support for `TemplateVersion` on `InvoiceRenderingOptions` and `InvoiceRendering`

## 45.13.0-beta.1 - 2024-09-13
* [#2961](https://github.com/stripe/stripe-dotnet/pull/2961) Update generated code for beta
  * Add support for new resources `Issuing.DisputeSettlementDetail` and `Issuing.Settlement`
  * Add support for `Get` and `List` methods on resource `DisputeSettlementDetail`
  * Remove support for `List` method on resource `QuotePhase`
  * Add support for `Settlement` on `Issuing.TransactionListOptions` and `IssuingTransaction`

## 45.12.0 - 2024-09-13
* [#2965](https://github.com/stripe/stripe-dotnet/pull/2965) Stop using deprecated versions of actions
* [#2968](https://github.com/stripe/stripe-dotnet/pull/2968) Update upload artifact version in GH actions
* [#2963](https://github.com/stripe/stripe-dotnet/pull/2963) Add .editorconfig file with minimal change to align with StypeCopAnalyzer

## 45.12.0-beta.1 - 2024-09-05
* [#2956](https://github.com/stripe/stripe-dotnet/pull/2956) Update generated code for beta
  * Add support for new resources `Billing.MeterErrorReport` and `Terminal.ReaderCollectedData`
  * Add support for `Get` method on resource `ReaderCollectedData`
  * Add support for `Recipients` on `AccountSessionComponentsOptions`
  * Add support for `BusinessName` and `TaxIds` on `CheckoutSessionCollectedInformation`
  * Add support for `RegulatoryReportingFile` on `Issuing.CreditUnderwritingRecordCorrectOptions`, `Issuing.CreditUnderwritingRecordCreateFromProactiveReviewOptions`, `Issuing.CreditUnderwritingRecordReportDecisionOptions`, and `IssuingCreditUnderwritingRecord`
  * Remove support for `Rechnung` on `PaymentMethodUpdateOptions`

## 45.11.0 - 2024-09-05
* [#2952](https://github.com/stripe/stripe-dotnet/pull/2952) Update generated code
  * Add support for `SubscriptionItem` and `Subscription` on `BillingAlertFilterOptions`

## 45.10.0 - 2024-08-29
* [#2957](https://github.com/stripe/stripe-dotnet/pull/2957) Generate SDK for OpenAPI spec version 1230
  * Add support for `StatusDetails` on `TestHelpersTestClock`
  * Added new const `IssuingRegulatoryReporting` with value `issuing_regulatory_reporting` to be used as a FilePurpose

## 45.10.0-beta.1 - 2024-08-23
* [#2954](https://github.com/stripe/stripe-dotnet/pull/2954) Update generated code for beta
  * Add support for `Email` and `Phone` on `CheckoutSessionCollectedInformation`

## 45.9.0 - 2024-08-23
* [#2955](https://github.com/stripe/stripe-dotnet/pull/2955) urlencode ids in url paths
  - id strings passed to service methods (like `PaymentMethodService.Get("...")`) are now correctly URL Encoded. This is an important update if you pass user inupt into any of those methods

## 45.9.0-beta.2 - 2024-08-22
* [#2953](https://github.com/stripe/stripe-dotnet/pull/2953) Update generated code for beta
  * Add support for `MbWayPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
  * Add support for `MbWay` on `ChargePaymentMethodDetails`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
  * Remove support for `Phases` on `QuoteCreateOptions` and `QuoteUpdateOptions`
  * Remove support for `FromSchedule` on `QuoteSubscriptionDataOptions`

## 45.9.0-beta.1 - 2024-08-15
* [#2951](https://github.com/stripe/stripe-dotnet/pull/2951) Update generated code for beta
  * Add support for `CapitalFinancingApplication` and `CapitalFinancing` on `AccountSessionComponentsOptions`
  * Add support for `Permissions` on `Checkout.SessionCreateOptions` and `CheckoutSession`
  * Add support for `CollectedInformation` on `Checkout.SessionUpdateOptions` and `CheckoutSession`
  * Add support for `ShippingOptions` on `Checkout.SessionUpdateOptions`

## 45.8.0 - 2024-08-15
* [#2949](https://github.com/stripe/stripe-dotnet/pull/2949) Update generated code
  * Add support for `AuthorizationCode` on `ChargePaymentMethodDetailsCard`
  * Add support for `Wallet` on `ChargePaymentMethodDetailsCardPresent`, `ConfirmationTokenPaymentMethodPreviewCardGeneratedFromPaymentMethodDetailsCardPresent`, `ConfirmationTokenPaymentMethodPreviewCardPresent`, `PaymentMethodCardGeneratedFromPaymentMethodDetailsCardPresent`, and `PaymentMethodCardPresent`
  * Add support for `MandateOptions` on `PaymentIntentPaymentMethodOptionsBacsDebitOptions` and `PaymentIntentPaymentMethodOptionsBacsDebit`
  * Add support for `BacsDebit` on `SetupIntentPaymentMethodOptionsOptions` and `SetupIntentPaymentMethodOptions`
  * Add support for `Chips` on `TreasuryOutboundPaymentTrackingDetailsUsDomesticWireOptions`, `TreasuryOutboundPaymentTrackingDetailsUsDomesticWire`, `TreasuryOutboundTransferTrackingDetailsUsDomesticWireOptions`, and `TreasuryOutboundTransferTrackingDetailsUsDomesticWire`
* [#2950](https://github.com/stripe/stripe-dotnet/pull/2950) Update beta readme to not use a concrete version

## 45.8.0-beta.1 - 2024-08-12
* [#2947](https://github.com/stripe/stripe-dotnet/pull/2947) Update generated code for beta
  * Add support for `CapitalFinancingApplication` and `CapitalFinancing` on `AccountSessionComponents`
  * Add support for `Payto` on `CheckoutSessionPaymentMethodOptionsOptions` and `CheckoutSessionPaymentMethodOptions`
  * ⚠️  Remove support for `RiskCorrelationId` on `PaymentIntentPaymentMethodOptionsRechnungOptions` and `PaymentIntentPaymentMethodOptionsRechnung`

## 45.7.0 - 2024-08-08
* [#2946](https://github.com/stripe/stripe-dotnet/pull/2946) Update generated code
  * Add support for `Activate`, `Archive`, `Create`, `Deactivate`, `Get`, and `List` methods on resource `Billing.Alert`
  * Add support for `Get` method on resource `Tax.Calculation`
  * Add support for `Type` on `ChargePaymentMethodDetailsCardPresentOffline`, `ConfirmationTokenPaymentMethodPreviewCardGeneratedFromPaymentMethodDetailsCardPresentOffline`, `PaymentMethodCardGeneratedFromPaymentMethodDetailsCardPresentOffline`, and `SetupAttemptPaymentMethodDetailsCardPresentOffline`
  * Add support for `Offline` on `ConfirmationTokenPaymentMethodPreviewCardPresent` and `PaymentMethodCardPresent`
  * Add support for `RelatedCustomer` on `Identity.VerificationSessionCreateOptions`, `Identity.VerificationSessionListOptions`, and `IdentityVerificationSession`

## 45.7.0-beta.1 - 2024-08-01
* [#2945](https://github.com/stripe/stripe-dotnet/pull/2945) Update generated code for beta
  * Add support for `AttachPayment` method on resource `Invoice`
  * Add support for `AppInstall` and `AppViewport` on `AccountSessionComponentsOptions`
  * Remove support for `PartnerRejectedDetails` on `DisputeEvidenceDetailsEnhancedEligibilityVisaCompellingEvidence3`
  * Add support for `LinesInvalid` on `QuoteStatusDetailsStaleLastReason`
  * Add support for `LastPriceMigrationError` on `SubscriptionSchedule` and `Subscription`

## 45.6.0 - 2024-08-01
* [#2944](https://github.com/stripe/stripe-dotnet/pull/2944) Update generated code
  * Add support for new resources `Billing.AlertTriggered` and `Billing.Alert`
  * ⚠️ Remove support for `AuthorizationCode` on `ChargePaymentMethodDetailsCard`. This was accidentally released last week.

## 45.6.0-beta.1 - 2024-07-25
* [#2938](https://github.com/stripe/stripe-dotnet/pull/2938) Update generated code for beta
  ⚠️ `InvoicePayment.Charge` and `InvoicePayment.PaymentIntent` were removed in favor of `InvoicePaymentPayment`, which encapsulates both. The Charge and PaymentIntent fields are now found at `InvoicePaymentPayment.Charge` `InvoicePaymentPayment.PaymentIntent`
  
  * Add support for new resources `Billing.AlertTriggered`, `Billing.Alert`, and `Tax.Association`
  * Add support for `Activate`, `Archive`, `Create`, `Deactivate`, `Get`, and `List` methods on resource `Alert`
  * Add support for `Find` method on resource `Association`
  * Add support for `Capital` on `AccountSettingsOptions` and `AccountSettings`
  * Add support for `AsyncWorkflows` on `PaymentIntentCaptureOptions`, `PaymentIntentConfirmOptions`, `PaymentIntentCreateOptions`, `PaymentIntentDecrementAuthorizationOptions`, `PaymentIntentIncrementAuthorizationOptions`, `PaymentIntentUpdateOptions`, and `PaymentIntent`
  * Add support for `Payto` on `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, and `PaymentMethodConfiguration`
  * Add support for `DisplayName` on `Treasury.FinancialAccountCreateOptions`, `Treasury.FinancialAccountUpdateOptions`, and `TreasuryFinancialAccount`

## 45.5.0 - 2024-07-25
* [#2943](https://github.com/stripe/stripe-dotnet/pull/2943) Update generated code
  * Add support for `TaxRegistrations` and `TaxSettings` on `AccountSessionComponentsOptions` and `AccountSessionComponents`
* [#2942](https://github.com/stripe/stripe-dotnet/pull/2942) Update generated code
  * Add support for `Update` method on resource `Checkout.Session`
  * Add support for `TransactionId` on `ChargePaymentMethodDetailsAffirm`
  * Add support for `BuyerId` on `ChargePaymentMethodDetailsBlik`
  * Add support for `AuthorizationCode` on `ChargePaymentMethodDetailsCard`
  * Add support for `BrandProduct` on `ChargePaymentMethodDetailsCardPresent`, `ConfirmationTokenPaymentMethodPreviewCardGeneratedFromPaymentMethodDetailsCardPresent`, `ConfirmationTokenPaymentMethodPreviewCardPresent`, `PaymentMethodCardGeneratedFromPaymentMethodDetailsCardPresent`, and `PaymentMethodCardPresent`
  * Add support for `NetworkTransactionId` on `ChargePaymentMethodDetailsCardPresent`, `ChargePaymentMethodDetailsInteracPresent`, `ConfirmationTokenPaymentMethodPreviewCardGeneratedFromPaymentMethodDetailsCardPresent`, and `PaymentMethodCardGeneratedFromPaymentMethodDetailsCardPresent`
  * Add support for `CaseType` on `DisputePaymentMethodDetailsCard`
  * Add support for `Twint` on `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, and `PaymentMethodConfiguration`

## 45.4.0 - 2024-07-18
* [#2940](https://github.com/stripe/stripe-dotnet/pull/2940) Update generated code
  * Add support for `Customer` on `ConfirmationTokenPaymentMethodPreview`

## 45.3.0 - 2024-07-11
* [#2939](https://github.com/stripe/stripe-dotnet/pull/2939) Update generated code
  * Add support for `PaymentMethodOptions` on `ConfirmationToken`
  * Add support for `PaymentElement` on `CustomerSessionComponentsOptions` and `CustomerSessionComponents`
  * Add support for `AddressValidation` on `IssuingCardShippingOptions` and `IssuingCardShipping`
  * Add support for `Shipping` on `Issuing.CardUpdateOptions`

## 45.3.0-beta.1 - 2024-07-05
* [#2933](https://github.com/stripe/stripe-dotnet/pull/2933) Update generated code for beta
  * ⚠️ Remove support for `PaymentMethodUpdate` on `CustomerSessionComponentsPaymentElementFeaturesOptions` and `CustomerSessionComponentsPaymentElementFeatures`. Users are expected to completely migrate from using `payment_method_update`.
  * Add support for new resource `FinancialConnections.Institution`
  * Add support for `Get` and `List` methods on resource `Institution`
  * Add support for `Institution` on `CheckoutSessionPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters`, `FinancialConnectionsSessionFiltersOptions`, `FinancialConnectionsSessionFilters`, `InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsFiltersOptions`, `InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters`, `PaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFiltersOptions`, `PaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters`, `SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFiltersOptions`, `SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters`, `SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsFiltersOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters`
  * Add support for `PaymentMethodAllowRedisplayFilters`, `PaymentMethodRedisplayLimit`, `PaymentMethodRedisplay`, and `PaymentMethodSaveUsage` on `CustomerSessionComponentsPaymentElementFeaturesOptions` and `CustomerSessionComponentsPaymentElementFeatures`

## 45.2.0 - 2024-07-05
* [#2932](https://github.com/stripe/stripe-dotnet/pull/2932) Update generated code
  * Add support for `AddLines`, `RemoveLines`, and `UpdateLines` methods on resource `Invoice`
  * Add support for `PostedAt` on `Tax.TransactionCreateFromCalculationOptions` and `TaxTransaction`

## 45.2.0-beta.1 - 2024-06-27
* [#2928](https://github.com/stripe/stripe-dotnet/pull/2928) Update generated code for beta
  * Remove support for `PaymentMethodSetAsDefault` on `CustomerSessionComponentsPaymentElementFeaturesOptions` and `CustomerSessionComponentsPaymentElementFeatures`

## 45.1.0 - 2024-06-27
* [#2931](https://github.com/stripe/stripe-dotnet/pull/2931) Update generated code
  * Add support for `Filters` on `CheckoutSessionPaymentMethodOptionsUsBankAccountFinancialConnections`, `InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsOptions`, `InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnections`, `PaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsOptions`, `PaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnections`, `SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsOptions`, `SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnections`, `SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnections`
  * Add support for `EmailType` on `CreditNoteCreateOptions`, `CreditNotePreviewLinesOptions`, and `CreditNotePreviewOptions`
  * Add support for `AccountSubcategories` on `FinancialConnectionsSessionFiltersOptions` and `FinancialConnectionsSessionFilters`
  * Add support for `RebootWindow` on `Terminal.ConfigurationCreateOptions`, `Terminal.ConfigurationUpdateOptions`, and `TerminalConfiguration`

## 45.0.0 - 2024-06-24
* [#2929](https://github.com/stripe/stripe-dotnet/pull/2929) Update generated code

  This release changes the pinned API version to 2024-06-20. Please read the [API Changelog](https://docs.stripe.com/changelog/2024-06-20) and carefully review the API changes before upgrading.

  ### ⚠️ Breaking changes

    * Remove the unused resource `PlatformTaxFee`
    * Rename `VolumeDecimal` to `QuantityDecimal` on `IssuingAuthorizationPurchaseDetailsFuelOptions`, `IssuingTransactionPurchaseDetailsFuelOptions`, and `IssuingTransactionPurchaseDetailsFuel`

  ### Additions

  * Add support for `FinalizeAmount` test helper method on resource `Issuing.Authorization`
  * Add support for new values `platform_disabled`, `paused.inactivity` and `other` on enums `CapabilityRequirements.DisabledReason` and `CapabilityFutureRequirements.DisabledReason`
  * Add support for `Fleet` on `Issuing.TestHelpersAuthorizationCreateOptions`, `IssuingAuthorizationPurchaseDetailsOptions`, `IssuingAuthorization`, `IssuingTransactionPurchaseDetailsOptions`, and `IssuingTransactionPurchaseDetails`
  * Add support for `Fuel` on `Issuing.TestHelpersAuthorizationCreateOptions` and `IssuingAuthorization`
  * Add support for `IndustryProductCode` and `QuantityDecimal` on `IssuingAuthorizationPurchaseDetailsFuelOptions`, `IssuingTransactionPurchaseDetailsFuelOptions`, and `IssuingTransactionPurchaseDetailsFuel`

## 44.13.0 - 2024-06-17
* [#2927](https://github.com/stripe/stripe-dotnet/pull/2927) Update generated code
  * Add support for `TaxIdCollection` on `PaymentLinkUpdateOptions`

## 44.13.0-beta.1 - 2024-06-13
* [#2923](https://github.com/stripe/stripe-dotnet/pull/2923) Syncing changes from 44.12.0 release

## 44.12.0 - 2024-06-13
* [#2922](https://github.com/stripe/stripe-dotnet/pull/2922) Update generated code
  * Add support for `MultibancoPayments` and `TwintPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
  * Add support for `Twint` on `ChargePaymentMethodDetails`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
  * Add support for `Multibanco` on `CheckoutSessionPaymentMethodOptionsOptions`, `CheckoutSessionPaymentMethodOptions`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, `PaymentMethodCreateOptions`, `PaymentMethod`, `RefundDestinationDetails`, and `SetupIntentPaymentMethodDataOptions`
  * Add support for `MultibancoDisplayDetails` on `PaymentIntentNextAction`
  * Add support for `InvoiceSettings` on `Subscription`

## 44.12.0-beta.1 - 2024-06-06
* [#2920](https://github.com/stripe/stripe-dotnet/pull/2920) Update generated code for beta
  * Add support for `Twint` on `PaymentIntentPaymentMethodOptionsOptions` and `PaymentIntentPaymentMethodOptions`

## 44.11.0 - 2024-06-06
* [#2921](https://github.com/stripe/stripe-dotnet/pull/2921) Update generated code
  * Add support for `GbBankTransferPayments`, `JpBankTransferPayments`, `MxBankTransferPayments`, `SepaBankTransferPayments`, and `UsBankTransferPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`

## 44.11.0-beta.1 - 2024-05-30
* [#2915](https://github.com/stripe/stripe-dotnet/pull/2915) Update generated code for beta
  * Keeping up with the changes from version 44.11.0

## 44.10.0 - 2024-05-30
* [#2916](https://github.com/stripe/stripe-dotnet/pull/2916) Update generated code
  * Add support for `DefaultValue` on `CheckoutSessionCustomFieldsDropdownOptions`, `CheckoutSessionCustomFieldsDropdown`, `CheckoutSessionCustomFieldsNumericOptions`, `CheckoutSessionCustomFieldsNumeric`, `CheckoutSessionCustomFieldsTextOptions`, and `CheckoutSessionCustomFieldsText`
  * Add support for `GeneratedFrom` on `ConfirmationTokenPaymentMethodPreviewCard` and `PaymentMethodCard`
* [#2919](https://github.com/stripe/stripe-dotnet/pull/2919) Add missing information for InvoiceTaxAmount
  * Add missing information for `TaxableAmount` and `TaxabilityReason` on `InvoiceTaxAmount`. Fixes [#2918](https://github.com/stripe/stripe-dotnet/issues/2918)

## 44.10.0-beta.1 - 2024-05-23
* [#2912](https://github.com/stripe/stripe-dotnet/pull/2912) Update generated code for beta

## 44.9.0 - 2024-05-23
* [#2913](https://github.com/stripe/stripe-dotnet/pull/2913) Update generated code
  * Add support for `ExternalAccountCollection` on `AccountSessionComponentsBalancesFeaturesOptions`, `AccountSessionComponentsBalancesFeatures`, `AccountSessionComponentsPayoutsFeaturesOptions`, and `AccountSessionComponentsPayoutsFeatures`
  * Add support for `PaymentMethodRemove` on `CheckoutSessionSavedPaymentMethodOptions`

## 44.9.0-beta.1 - 2024-05-16
* [#2908](https://github.com/stripe/stripe-dotnet/pull/2908) Update generated code for beta

## 44.8.0 - 2024-05-16
* [#2909](https://github.com/stripe/stripe-dotnet/pull/2909) Update generated code
  * Add support for `FeeSource` on `ApplicationFee`
  * Add support for `NetAvailable` on `BalanceInstantAvailable`
  * Add support for `PreferredLocales` on `ChargePaymentMethodDetailsCardPresent`, `ConfirmationTokenPaymentMethodPreviewCardPresent`, and `PaymentMethodCardPresent`
  * Add support for `Klarna` on `DisputePaymentMethodDetails`
  * Add support for `Archived` and `LookupKey` on `Entitlements.FeatureListOptions`
  * Add support for `NoValidAuthorization` on `IssuingDisputeEvidenceOptions` and `IssuingDisputeEvidence`
  * Add support for `LossReason` on `IssuingDispute`
  * Add support for `Routing` on `PaymentIntentPaymentMethodOptionsCardPresentOptions` and `PaymentIntentPaymentMethodOptionsCardPresent`
  * Add support for `ApplicationFeeAmount` and `ApplicationFee` on `Payout`
  * Add support for `StripeS700` on `Terminal.ConfigurationCreateOptions`, `Terminal.ConfigurationUpdateOptions`, and `TerminalConfiguration`

## 44.7.0 - 2024-05-09
* [#2907](https://github.com/stripe/stripe-dotnet/pull/2907) Update generated code
  * Remove support for `PendingInvoiceItemsBehavior` on `SubscriptionCreateOptions` that was prematurely added in the previous release on the same day

## 44.7.0-beta.1 - 2024-05-09
* [#2905](https://github.com/stripe/stripe-dotnet/pull/2905) Update generated code for beta
  * No new beta features. Merging changes from the main branch.

## 44.6.0 - 2024-05-09
* [#2906](https://github.com/stripe/stripe-dotnet/pull/2906) Update generated code
  * Add support for `Update` test helper method on resources `Treasury.OutboundPayment` and `Treasury.OutboundTransfer`
  * Add support for `AllowRedisplay` on `ConfirmationTokenPaymentMethodPreview` and `PaymentMethod`
  * Change type of `EntitlementsFeatureMetadataOptions` from `map(string: string)` to `emptyable(map(string: string))`
  * Add support for `PreviewMode` on `InvoiceCreatePreviewOptions`, `InvoiceUpcomingLinesOptions`, and `InvoiceUpcomingOptions`
  * Add support for `TrackingDetails` on `TreasuryOutboundPayment` and `TreasuryOutboundTransfer`

## 44.6.0-beta.1 - 2024-05-02
* [#2901](https://github.com/stripe/stripe-dotnet/pull/2901) Update generated code for beta
  * Add support for `RechnungPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
  * Add support for `Rechnung` on `ChargePaymentMethodDetails`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethodUpdateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
  * Add support for `Multibanco` on `CheckoutSessionPaymentMethodOptionsOptions` and `CheckoutSessionPaymentMethodOptions`

## 44.5.0 - 2024-05-02
* [#2900](https://github.com/stripe/stripe-dotnet/pull/2900) Update generated code
  * Add support for `Paypal` on `DisputePaymentMethodDetails`
  * Change type of `DisputePaymentMethodDetailsType` from `literal('card')` to `enum('card'|'paypal')`
  * Add support for `PaymentMethodTypes` on `PaymentIntentConfirmOptions`
  * Add support for `ShipFromDetails` on `Tax.CalculationCreateOptions`, `TaxCalculation`, and `TaxTransaction`
  * Add support for `Bh`, `Eg`, `Ge`, `Ke`, `Kz`, `Ng`, and `Om` on `TaxRegistrationCountryOptionsOptions` and `TaxRegistrationCountryOptions`
* [#2904](https://github.com/stripe/stripe-dotnet/pull/2904) Add config for dotnet8.0
* [#2903](https://github.com/stripe/stripe-dotnet/pull/2903) Fix clientId getter

## 44.5.0-beta.1 - 2024-04-25
* [#2896](https://github.com/stripe/stripe-dotnet/pull/2896) Update generated code for beta
  * Add support for `PaymentMethodSettings` on `AccountSessionComponentsOptions`
  * Add support for `CancelSubscriptionSchedule` on `QuoteLine` and `QuoteLinesOptions`

## 44.4.0 - 2024-04-25
* [#2897](https://github.com/stripe/stripe-dotnet/pull/2897) Update generated code
  * Add support for `SetupFutureUsage` on `CheckoutSessionPaymentMethodOptionsAmazonPay`, `CheckoutSessionPaymentMethodOptionsRevolutPay`, `PaymentIntentPaymentMethodOptionsAmazonPay`, and `PaymentIntentPaymentMethodOptionsRevolutPay`
  * Change type of `EntitlementsActiveEntitlementFeature` from `string` to `expandable($Entitlements.Feature)`
  * Remove support for inadvertently released identity verification features `Email` and `Phone` on `IdentityVerificationSessionOptionsOptions`
  * Add support for `AmazonPay` and `RevolutPay` on `MandatePaymentMethodDetails` and `SetupAttemptPaymentMethodDetails`
  * Add support for `EndingBefore`, `Limit`, and `StartingAfter` on `PaymentMethodConfigurationListOptions`
  * Add support for `Mobilepay` on `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, and `PaymentMethodConfiguration`

## 44.4.0-beta.1 - 2024-04-18
* [#2893](https://github.com/stripe/stripe-dotnet/pull/2893) Update generated code for beta
  * Add support for `CapitalOverview`, `TaxRegistrations`, and `TaxSettings` on `AccountSessionComponentsOptions`
  * Add support for `ExternalAccountCollection` on `AccountSessionComponentsFinancialAccountFeaturesOptions`
  * Add support for `SubscriptionTrialFromPlan` on `InvoiceUpcomingLinesOptions` and `InvoiceUpcomingOptions`

## 44.3.0 - 2024-04-18
* [#2894](https://github.com/stripe/stripe-dotnet/pull/2894) Update generated code
  * Add support for `CreatePreview` method on resource `Invoice`
  * Add support for `PaymentMethodData` on `Checkout.SessionCreateOptions`
  * Add support for `SavedPaymentMethodOptions` on `Checkout.SessionCreateOptions` and `CheckoutSession`
  * Add support for `Mobilepay` on `CheckoutSessionPaymentMethodOptionsOptions` and `CheckoutSessionPaymentMethodOptions`
  * Add support for `AllowRedisplay` on `ConfirmationTokenPaymentMethodDataOptions`, `CustomerListPaymentMethodsOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentMethodCreateOptions`, `PaymentMethodUpdateOptions`, and `SetupIntentPaymentMethodDataOptions`
  * Add support for `ScheduleDetails` and `SubscriptionDetails` on `InvoiceUpcomingLinesOptions` and `InvoiceUpcomingOptions`

## 44.2.0 - 2024-04-16
* [#2891](https://github.com/stripe/stripe-dotnet/pull/2891) Update generated code
  * Add support for new resource `Entitlements.ActiveEntitlementSummary`
  * Add support for `Balances` and `PayoutsList` on `AccountSessionComponentsOptions` and `AccountSessionComponents`
  * Remove support for `Config` on `Forwarding.RequestCreateOptions` and `ForwardingRequest`. This field is no longer used by the Forwarding Request API.
  * Add support for `CaptureMethod` on `PaymentIntentPaymentMethodOptionsRevolutPayOptions` and `PaymentIntentPaymentMethodOptionsRevolutPay`
  * Add support for `Swish` on `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, and `PaymentMethodConfiguration`
* [#2892](https://github.com/stripe/stripe-dotnet/pull/2892) Add sections to StripeTypeRegistry

## 44.2.0-beta.1 - 2024-04-11
* [#2886](https://github.com/stripe/stripe-dotnet/pull/2886) Update generated code for beta
  * Add support for `Get` method on resources `Entitlements.ActiveEntitlement` and `Entitlements.Feature`
  * Add support for `Fees`, `Losses`, `RequirementCollection`, and `StripeDashboard` on `AccountControllerOptions`
  * Add support for `HostedVoucherUrl` on `PaymentIntentNextActionMultibancoDisplayDetails`
  * Add support for `Toggles` on `TerminalReaderActionCollectInputsInputs` and `TerminalReaderInputsOptions`
  * Add support for `Email`, `Numeric`, `Phone`, and `Text` on `TerminalReaderActionCollectInputsInputs`

## 44.1.0 - 2024-04-11
* [#2889](https://github.com/stripe/stripe-dotnet/pull/2889) Update generated code
  * Add support for `AccountManagement` and `NotificationBanner` on `AccountSessionComponentsOptions` and `AccountSessionComponents`
  * Add support for `ExternalAccountCollection` on `AccountSessionComponentsAccountOnboardingFeaturesOptions` and `AccountSessionComponentsAccountOnboardingFeatures`
  * Change type of `BillingMeterEventAdjustmentCancel` from `BillingMeterResourceBillingMeterEventAdjustmentCancel` to `nullable(BillingMeterResourceBillingMeterEventAdjustmentCancel)`
  * Add support for `AmazonPay` on `ChargePaymentMethodDetails`, `CheckoutSessionPaymentMethodOptionsOptions`, `CheckoutSessionPaymentMethodOptions`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, `PaymentMethodCreateOptions`, `PaymentMethod`, `RefundDestinationDetails`, `SetupIntentPaymentMethodDataOptions`, `SetupIntentPaymentMethodOptionsOptions`, and `SetupIntentPaymentMethodOptions`
  * Add support for `NextRefreshAvailableAt` on `FinancialConnectionsAccountOwnershipRefresh`

## 44.0.0 - 2024-04-10
* [#2884](https://github.com/stripe/stripe-dotnet/pull/2884)

  * This release changes the pinned API version to `2024-04-10`. Please read the [API Changelog](https://docs.stripe.com/changelog/2024-04-10) and carefully review the API changes before upgrading.

  ### ⚠️ Breaking changes

  * Change the property `Amount` on `SourceTransaction` to not be nullable
  * Remove the below unused classes
      * `InvoiceLineItemAutomaticTaxOptions`
      * `InvoiceLineItemCustomerDetailsOptions`
      * `InvoiceLineItemCustomerDetailsTaxIdOptions`
      * `InvoiceLineItemCustomerDetailsTaxOptions`
  * Change the type of the below date fields from `long` to `DateTime`
      * `AccountSettingsCardIssuingTosAcceptance.Date`
      * `AccountSettingsTreasuryTosAcceptance.Date`
      * `PaymentIntentNextActionPixDisplayQrCode.ExpiresAt`
      * `PaymentIntentPaymentMethodOptionsPix.ExpiresAt`
      * `CalculationCreateOptions.TaxDate`
  * Rename `Features` to `MarketingFeatures` on `ProductCreateOptions`, `ProductUpdateOptions`, and `Product`.

  #### ⚠️ Removal of enum values, properties and events that are no longer part of the publicly documented Stripe API
   * Remove `BillingPortal.ConfigurationFeatures.SubscriptionPause` and `BillingPortal.ConfigurationFeaturesOptions.SubscriptionPause` as the feature to pause subscription on the portal has been deprecated.
   * Remove the below deprecated events from `Event.Type`, `WebhookEndpointCreateOptions.EnabledEvents`, `WebhookEndpointUpdateOptions.EnabledEvents` and the constants in `Events`
     * `invoiceitem.updated`
     * `order.created`
     * `recipient.created`
     * `recipient.deleted`
     * `recipient.updated`
     * `sku.created`
     * `sku.deleted`
     * `sku.updated`
   * Remove the support for the below deprecated values in `BalanceTransaction.Type`
      * `obligation_inbound`
      * `obligation_payout`
      * `obligation_payout_failure`
      * `obligation_reversal_outbound`
   * Remove the support for `various` in `Climate.Supplier.RemovalPathway`
   * Remove support for `id_bank_transfer`, `multibanco`, `netbanking`, `pay_by_bank`, and `upi` on `PaymentMethodConfiguration` by removing the below classes
     * `PaymentMethodConfigurationIdBankTransfer`
     * `PaymentMethodConfigurationMultibanco`
     * `PaymentMethodConfigurationNetbanking`
     * `PaymentMethodConfigurationPayByBank`
     * `PaymentMethodConfigurationUpi`
   * Remove the support for `challenge_only` in `SetupIntentPaymentMethodOptionsCard.RequestThreeDSecure`
   * Remove deprecated property `CustomerData` on `SourceTransaction`
   * Remove the support for deprecated value `service_tax` in `TaxRate.TaxType`, `TaxRateCreateParams.TaxType`, `TaxRateUpdateParams.TaxType`
   * Remove the deprecated value `include_and_require` in `InvoiceCreateParams.PendingInvoiceItemsBehavior`
   * Remove the deprecated property `SubscriptionProrate` on `UpcomingInvoiceListLineItemsOptions`. Use `SubscriptionProrationBehavior` instead.
   * Remove the property `RequestIncrementalAuthorization` on `PaymentIntentPaymentMethodOptionsCardPresentOptions`. This was shipped by mistake.
   * Remove the support for deprecated value `obligation` on `ReportRunParameterOptions.ReportingCategory`
   * Remove the legacy field `RenderingOptions` in `Invoice`, `InvoiceCreateOptions` and `InvoiceUpdateOptions`.
   * Rename the type of field `Rendering` in `InvoiceCreateOptions` and `InvoiceUpdateOptions` from `InvoiceRenderingOptionsOptions` to `InvoiceRenderingOptions`

## 43.23.0 - 2024-04-09
* [#2887](https://github.com/stripe/stripe-dotnet/pull/2887) Update generated code
  * Add support for new resources `Entitlements.ActiveEntitlement` and `Entitlements.Feature`
  * Add support for `Get` and `List` methods on resource `ActiveEntitlement`
  * Add support for `Create`, `Get`, `List`, and `Update` methods on resource `Feature`
  * Add support for `Controller` on `AccountCreateOptions`
  * Add support for `Fees`, `Losses`, `RequirementCollection`, and `StripeDashboard` on `AccountController`
  * Add support for `EventName` on `Billing.MeterEventAdjustmentCreateOptions` and `BillingMeterEventAdjustment`
  * Add support for `Cancel` and `Type` on `BillingMeterEventAdjustment`

## 43.23.0-beta.1 - 2024-04-04
* [#2882](https://github.com/stripe/stripe-dotnet/pull/2882) Update generated code for beta
  * Add support for `Update` method on resource `Entitlements.Feature`
  * Add support for `RiskControls` on `AccountCreateOptions`, `AccountUpdateOptions`, and `Account`
  * Add support for `PromotionCode` on `InvoiceLinesDiscountsOptions`, `QuoteLineItemsDiscountsOptions`, `QuoteLinesActionsAddDiscountOptions`, and `QuotePhasesLineItemsDiscountsOptions`

## 43.22.0 - 2024-04-04
* [#2881](https://github.com/stripe/stripe-dotnet/pull/2881) Update generated code
  * Change type of `CheckoutSessionPaymentMethodOptionsSwishReferenceOptions` from `emptyable(string)` to `string`
  * Add support for `SubscriptionItem` on `Discount`
  * Add support for `Email` and `Phone` on `IdentityVerificationReport`, `IdentityVerificationSessionOptionsOptions`, `IdentityVerificationSessionOptions`, and `IdentityVerificationSessionVerifiedOutputs`
  * Add support for `VerificationFlow` on `Identity.VerificationSessionCreateOptions`, `IdentityVerificationReport`, and `IdentityVerificationSession`
  * Add support for `ProvidedDetails` on `Identity.VerificationSessionCreateOptions`, `Identity.VerificationSessionUpdateOptions`, and `IdentityVerificationSession`
  * Add support for `PromotionCode` on `InvoiceDiscountsOptions`, `InvoiceItemDiscountsOptions`, and `QuoteDiscountsOptions`
  * Add support for `Discounts` on `InvoiceSubscriptionItemsOptions`, `QuoteLineItemsOptions`, `SubscriptionAddInvoiceItemsOptions`, `SubscriptionCreateOptions`, `SubscriptionItemCreateOptions`, `SubscriptionItemUpdateOptions`, `SubscriptionItem`, `SubscriptionItemsOptions`, `SubscriptionSchedulePhasesAddInvoiceItemsOptions`, `SubscriptionSchedulePhasesAddInvoiceItems`, `SubscriptionSchedulePhasesItemsOptions`, `SubscriptionSchedulePhasesItems`, `SubscriptionSchedulePhasesOptions`, `SubscriptionSchedulePhases`, `SubscriptionUpdateOptions`, and `Subscription`
  * Add support for `AllowedMerchantCountries` and `BlockedMerchantCountries` on `IssuingCardSpendingControlsOptions`, `IssuingCardSpendingControls`, `IssuingCardholderSpendingControlsOptions`, and `IssuingCardholderSpendingControls`
  * Add support for `Zip` on `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, and `PaymentMethodConfiguration`
  * Add support for `Offline` on `SetupAttemptPaymentMethodDetailsCardPresent`
  * Add support for `CardPresent` on `SetupIntentPaymentMethodOptionsOptions` and `SetupIntentPaymentMethodOptions`

## 43.22.0-beta.1 - 2024-03-28
* [#2878](https://github.com/stripe/stripe-dotnet/pull/2878) Update generated code for beta
  * Add support for `FinancialAccountTransactions`, `FinancialAccount`, `IssuingCard`, and `IssuingCardsList` on `AccountSessionComponentsOptions`
  * Remove support for `SubscriptionBillingCycleAnchor`, `SubscriptionCancelAtPeriodEnd`, `SubscriptionCancelAt`, `SubscriptionCancelNow`, `SubscriptionDefaultTaxRates`, `SubscriptionItems`, `SubscriptionPrebilling`, `SubscriptionProrationBehavior`, `SubscriptionProrationDate`, `SubscriptionResumeAt`, `SubscriptionStartDate`, and `SubscriptionTrialEnd` on `InvoiceCreatePreviewOptions`

## 43.21.0 - 2024-03-28
* [#2877](https://github.com/stripe/stripe-dotnet/pull/2877) Update generated code
  * Add support for new resources `Billing.MeterEventAdjustment`, `Billing.MeterEvent`, and `Billing.Meter`
  * Add support for `Create`, `Deactivate`, `Get`, `List`, `Reactivate`, and `Update` methods on resource `Meter`
  * Add support for `Create` method on resources `MeterEventAdjustment` and `MeterEvent`
  * Add support for `AmazonPayPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
  * Add support for `DestinationOnBehalfOfChargeManagement` on `AccountSessionComponentsPaymentDetailsFeaturesOptions`, `AccountSessionComponentsPaymentDetailsFeatures`, `AccountSessionComponentsPaymentsFeaturesOptions`, and `AccountSessionComponentsPaymentsFeatures`
  * Add support for `Mandate` on `ChargePaymentMethodDetailsUsBankAccount`, `TreasuryInboundTransferOriginPaymentMethodDetailsUsBankAccount`, `TreasuryOutboundPaymentDestinationPaymentMethodDetailsUsBankAccount`, and `TreasuryOutboundTransferDestinationPaymentMethodDetailsUsBankAccount`
  * Add support for `SecondLine` on `Issuing.CardCreateOptions`
  * Add support for `Meter` on `PlanCreateOptions`, `Plan`, `PriceRecurringOptions`, and `PriceRecurring`
* [#2876](https://github.com/stripe/stripe-dotnet/pull/2876) Generate assertions in generated tests

## 43.21.0-beta.1 - 2024-03-21
* [#2875](https://github.com/stripe/stripe-dotnet/pull/2875) Update generated code for beta
  * Add support for new resources `Entitlements.ActiveEntitlementSummary` and `Entitlements.ActiveEntitlement`
  * Add support for `List` method on resource `ActiveEntitlement`
  * Add support for `Mobilepay` on `ConfirmationTokenPaymentMethodDataOptions` and `ConfirmationTokenPaymentMethodPreview`
  * Add support for `UseStripeSdk` on `ConfirmationToken`
  * Remove support for `PaymentMethod` on `ConfirmationToken`
  * Add support for `Metadata` on `Entitlements.FeatureCreateOptions` and `EntitlementsFeature`
  * Add support for `Active` on `EntitlementsFeature`
* [#2870](https://github.com/stripe/stripe-dotnet/pull/2870) Update generated code for beta
  Release specs are identical.

## 43.20.0 - 2024-03-21
* [#2874](https://github.com/stripe/stripe-dotnet/pull/2874) Update generated code
  * Add support for new resources `ConfirmationToken` and `Forwarding.Request`
  * Add support for `Get` method on resource `ConfirmationToken`
  * Add support for `Create`, `Get`, and `List` methods on resource `Request`
  * Add support for `MobilepayPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
  * Add support for `Mobilepay` on `ChargePaymentMethodDetails`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
  * Add support for `PaymentReference` on `ChargePaymentMethodDetailsUsBankAccount`
  * Add support for `ConfirmationToken` on `PaymentIntentConfirmOptions`, `PaymentIntentCreateOptions`, `SetupIntentConfirmOptions`, and `SetupIntentCreateOptions`
  * Add support for `Name` on `Terminal.ConfigurationCreateOptions`, `Terminal.ConfigurationUpdateOptions`, and `TerminalConfiguration`
  * Add support for `Payout` on `TreasuryReceivedDebitLinkedFlows`
* [#2868](https://github.com/stripe/stripe-dotnet/pull/2868) Autogenerate more files
* [#2869](https://github.com/stripe/stripe-dotnet/pull/2869) Add obsolete attributes to deprecated APIs and doc comments to methods

## 43.20.0-beta.1 - 2024-03-14
* [#2866](https://github.com/stripe/stripe-dotnet/pull/2866) Update generated code for beta
  * Add support for new resources `Billing.MeterEventAdjustment`, `Billing.MeterEvent`, and `Billing.Meter`
  * Add support for `Create`, `Deactivate`, `Get`, `List`, `Reactivate`, and `Update` methods on resource `Meter`
  * Add support for `Create` method on resources `MeterEventAdjustment` and `MeterEvent`
  * Add support for `Create` test helper method on resource `ConfirmationToken`
  * Add support for `AddLines`, `RemoveLines`, and `UpdateLines` methods on resource `Invoice`
  * Add support for `Multibanco` on `ConfirmationTokenPaymentMethodPreview`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, `PaymentMethodCreateOptions`, `PaymentMethod`, `RefundDestinationDetails`, and `SetupIntentPaymentMethodDataOptions`
  * Add support for `SecondLine` on `IssuingPhysicalBundleFeatures`
  * Add support for `MultibancoDisplayDetails` on `PaymentIntentNextAction`
  * Add support for `Meter` on `PlanCreateOptions`, `Plan`, `PriceRecurringOptions`, and `PriceRecurring`

## 43.19.0 - 2024-03-14
* [#2865](https://github.com/stripe/stripe-dotnet/pull/2865) Update generated code
  * Add support for new resources `Issuing.PersonalizationDesign` and `Issuing.PhysicalBundle`
  * Add support for `Create`, `Get`, `List`, and `Update` methods on resource `PersonalizationDesign`
  * Add support for `Get` and `List` methods on resource `PhysicalBundle`
  * Add support for `PersonalizationDesign` on `Issuing.CardCreateOptions`, `Issuing.CardListOptions`, `Issuing.CardUpdateOptions`, and `IssuingCard`
  * Change type of `SubscriptionApplicationFeePercentOptions` from `number` to `emptyStringable(number)`
  * Add support for `SepaDebit` on `SubscriptionPaymentSettingsPaymentMethodOptionsOptions` and `SubscriptionPaymentSettingsPaymentMethodOptions`

## 43.19.0-beta.1 - 2024-03-07
* [#2861](https://github.com/stripe/stripe-dotnet/pull/2861) Update generated code for beta

## 43.18.0 - 2024-03-07
* [#2863](https://github.com/stripe/stripe-dotnet/pull/2863) Update generated code
  * Add support for `Documents` on `AccountSessionComponentsOptions` and `AccountSessionComponents`
  * Add support for `RequestThreeDSecure` on `CheckoutSessionPaymentMethodOptionsCardOptions` and `CheckoutSessionPaymentMethodOptionsCard`
  * Add support for `Created` on `CreditNoteListOptions`
  * Add support for `SepaDebit` on `InvoicePaymentSettingsPaymentMethodOptionsOptions` and `InvoicePaymentSettingsPaymentMethodOptions`
* [#2864](https://github.com/stripe/stripe-dotnet/pull/2864) Update development section of readme
* [#2862](https://github.com/stripe/stripe-dotnet/pull/2862) Explicitly define paths in manually maintained services

## 43.18.0-beta.1 - 2024-02-29
* [#2853](https://github.com/stripe/stripe-dotnet/pull/2853) Update generated code for beta
  * Remove support for resource `Entitlements.Event`
  * Remove support for `Quantity` and `Type` on `Entitlements.FeatureCreateOptions` and `EntitlementsFeature`
  * Add support for `Livemode` on `IssuingPersonalizationDesign`
  * Add support for `ApplicationFeeAmount`, `Description`, `Metadata`, and `TransferData` on `PaymentIntentDecrementAuthorizationOptions`
  * Add support for `EnableCustomerCancellation` on `TerminalReaderActionCollectPaymentMethodCollectConfig` and `TerminalReaderCollectConfigOptions`
* [#2855](https://github.com/stripe/stripe-dotnet/pull/2855) Add helper to add beta version

## 43.17.0 - 2024-02-29
* [#2854](https://github.com/stripe/stripe-dotnet/pull/2854) Update generated code
  * Add support for `Number` on `InvoiceCreateOptions` and `InvoiceUpdateOptions`
  * Add support for `EnableCustomerCancellation` on `TerminalReaderActionProcessPaymentIntentProcessConfig`, `TerminalReaderActionProcessSetupIntentProcessConfig`, and `TerminalReaderProcessConfigOptions`
  * Add support for `RefundPaymentConfig` on `Terminal.ReaderRefundPaymentOptions` and `TerminalReaderActionRefundPayment`
  * Add support for `PaymentMethod` on `TokenBankAccountOptions`
* [#2858](https://github.com/stripe/stripe-dotnet/pull/2858) Update README to use AddBetaVersion
* [#2859](https://github.com/stripe/stripe-dotnet/pull/2859) Use make CI test
* [#2856](https://github.com/stripe/stripe-dotnet/pull/2856) Obsolete BasePath, InstanceUrl, and ClassUrl

## 43.17.0-beta.1 - 2024-02-22
* [#2851](https://github.com/stripe/stripe-dotnet/pull/2851) Update generated code for beta

## 43.16.0 - 2024-02-22
* [#2850](https://github.com/stripe/stripe-dotnet/pull/2850) Update generated code
  * Add support for `ClientReferenceId` on `Identity.VerificationReportListOptions`, `Identity.VerificationSessionCreateOptions`, `Identity.VerificationSessionListOptions`, `IdentityVerificationReport`, and `IdentityVerificationSession`
  * Add support for `Created` on `Treasury.OutboundPaymentListOptions`

## 43.16.0-beta.1 - 2024-02-16
* [#2846](https://github.com/stripe/stripe-dotnet/pull/2846) Update generated code for beta
  * Add support for `DecrementAuthorization` method on resource `PaymentIntent`
  * Add support for `PaytoPayments` and `TwintPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
  * Add support for `Payto` on `ChargePaymentMethodDetails`, `ConfirmationTokenPaymentMethodPreview`, `MandatePaymentMethodDetails`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethodUpdateOptions`, `PaymentMethod`, `SetupAttemptPaymentMethodDetails`, `SetupIntentPaymentMethodDataOptions`, `SetupIntentPaymentMethodOptionsOptions`, and `SetupIntentPaymentMethodOptions`
  * Add support for `Twint` on `ChargePaymentMethodDetails`, `ConfirmationTokenPaymentMethodPreview`, `PaymentIntentPaymentMethodDataOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
  * Add support for `DecrementalAuthorization` on `ChargePaymentMethodDetailsCard`
  * Add support for `DisplayBrand` on `ConfirmationTokenPaymentMethodPreviewCard`
  * Add support for `RequestDecrementalAuthorization` on `PaymentIntentPaymentMethodOptionsCardOptions` and `PaymentIntentPaymentMethodOptionsCard`

## 43.15.0 - 2024-02-15
* [#2847](https://github.com/stripe/stripe-dotnet/pull/2847) Update generated code
  * Add support for `Networks` on `Card`, `PaymentMethodCardOptions`, and `TokenCardOptions`
  * Add support for `DisplayBrand` on `PaymentMethodCard`
* [#2849](https://github.com/stripe/stripe-dotnet/pull/2849) Add README to NuGet package

## 43.15.0-beta.1 - 2024-02-08
* [#2844](https://github.com/stripe/stripe-dotnet/pull/2844) Update generated code for beta
  * Add support for `PaymentMethodOptions` on `ConfirmationToken`

## 43.14.0 - 2024-02-08
* [#2843](https://github.com/stripe/stripe-dotnet/pull/2843) Update generated code
  * Add support for `Invoices` on `AccountSettingsOptions` and `AccountSettings`
  * Add support for `SetupFutureUsage` on `PaymentIntentPaymentMethodOptionsBlikOptions` and `PaymentIntentPaymentMethodOptionsBlik`
  * Add support for `RequireCvcRecollection` on `PaymentIntentPaymentMethodOptionsCardOptions` and `PaymentIntentPaymentMethodOptionsCard`
  * Add support for `AccountTaxIds` on `SubscriptionInvoiceSettingsOptions`, `SubscriptionScheduleDefaultSettingsInvoiceSettingsOptions`, `SubscriptionScheduleDefaultSettingsInvoiceSettings`, `SubscriptionSchedulePhasesInvoiceSettingsOptions`, and `SubscriptionSchedulePhasesInvoiceSettings`

## 43.14.0-beta.1 - 2024-02-01
* [#2841](https://github.com/stripe/stripe-dotnet/pull/2841) Update generated code for beta
  * Add support for new resources `Entitlements.Event` and `Entitlements.Feature`
  * Add support for `Create` method on resource `Event`
  * Add support for `Create` and `List` methods on resource `Feature`
  * Add support for `Swish` on `ConfirmationTokenPaymentMethodPreview`
  * Add support for `AccountTaxIds` on `InvoiceScheduleDetailsPhasesInvoiceSettingsOptions`
  * Add support for `Feature` on `ProductFeaturesOptions` and `ProductFeatures`

## 43.13.0 - 2024-02-01
* [#2840](https://github.com/stripe/stripe-dotnet/pull/2840) Update generated code
  * Add support for `SwishPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
  * Add support for `Relationship` on `AccountIndividualOptions` and `TokenAccountIndividualOptions`
  * Add support for `Swish` on `ChargePaymentMethodDetails`, `CheckoutSessionPaymentMethodOptionsOptions`, `CheckoutSessionPaymentMethodOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, `RefundDestinationDetails`, and `SetupIntentPaymentMethodDataOptions`
  * Add support for `SwishHandleRedirectOrDisplayQrCode` on `PaymentIntentNextAction`
  * Add support for `JurisdictionLevel` on `TaxRate`

## 43.13.0-beta.1 - 2024-01-26
* [#2836](https://github.com/stripe/stripe-dotnet/pull/2836) Update generated code for beta
  * Add support for `CreatePreview` method on resource `Invoice`
  * Add support for `ChargedOffAt` on `CapitalFinancingOffer`
  * Add support for `EnhancedEvidence` on `DisputeEvidenceOptions` and `DisputeEvidence`
  * Add support for `EnhancedEligibilityTypes` on `Dispute`
  * Add support for `EnhancedEligibility` on `DisputeEvidenceDetails`
  * Add support for `PromotionCode` on `InvoiceScheduleDetailsAmendmentsDiscountActionsAddOptions`, `InvoiceScheduleDetailsAmendmentsDiscountActionsRemoveOptions`, `InvoiceScheduleDetailsAmendmentsDiscountActionsSetOptions`, `InvoiceScheduleDetailsAmendmentsItemActionsAddDiscountsOptions`, `InvoiceScheduleDetailsAmendmentsItemActionsSetDiscountsOptions`, `InvoiceScheduleDetailsPhasesAddInvoiceItemsDiscountsOptions`, `InvoiceScheduleDetailsPhasesDiscountsOptions`, `InvoiceScheduleDetailsPhasesItemsDiscountsOptions`, `InvoiceSubscriptionDetailsItemsDiscountsOptions`, `InvoiceSubscriptionItemsDiscountsOptions`, `QuoteLineActionsAddDiscount`, `QuoteLineActionsAddItemDiscounts`, `QuoteLineActionsRemoveDiscount`, `QuoteLineActionsSetDiscounts`, `QuoteLineActionsSetItemsDiscounts`, `QuoteLinesActionsAddItemDiscountsOptions`, `QuoteLinesActionsRemoveDiscountOptions`, `QuoteLinesActionsSetDiscountsOptions`, `QuoteLinesActionsSetItemsDiscountsOptions`, `QuotePhasesDiscountsOptions`, `SubscriptionAddInvoiceItemsDiscountsOptions`, `SubscriptionDiscountsOptions`, `SubscriptionItemDiscountsOptions`, `SubscriptionItemsDiscountsOptions`, `SubscriptionScheduleAmendmentsDiscountActionsAddOptions`, `SubscriptionScheduleAmendmentsDiscountActionsRemoveOptions`, `SubscriptionScheduleAmendmentsDiscountActionsSetOptions`, `SubscriptionScheduleAmendmentsItemActionsAddDiscountsOptions`, `SubscriptionScheduleAmendmentsItemActionsSetDiscountsOptions`, `SubscriptionSchedulePhasesAddInvoiceItemsDiscountsOptions`, `SubscriptionSchedulePhasesAddInvoiceItemsDiscounts`, `SubscriptionSchedulePhasesDiscountsOptions`, `SubscriptionSchedulePhasesDiscounts`, `SubscriptionSchedulePhasesItemsDiscountsOptions`, and `SubscriptionSchedulePhasesItemsDiscounts`

## 43.12.0 - 2024-01-25
* [#2837](https://github.com/stripe/stripe-dotnet/pull/2837) Update generated code
  * Add support for `AnnualRevenue` and `EstimatedWorkerCount` on `AccountBusinessProfileOptions` and `AccountBusinessProfile`
  * Add support for `CollectionOptions` on `AccountLinkCreateOptions`
  * Add support for `Liability` on `CheckoutSessionAutomaticTaxOptions`, `CheckoutSessionAutomaticTax`, `PaymentLinkAutomaticTaxOptions`, `PaymentLinkAutomaticTax`, `QuoteAutomaticTaxOptions`, `QuoteAutomaticTax`, `SubscriptionScheduleDefaultSettingsAutomaticTaxOptions`, `SubscriptionScheduleDefaultSettingsAutomaticTax`, `SubscriptionSchedulePhasesAutomaticTaxOptions`, and `SubscriptionSchedulePhasesAutomaticTax`
  * Add support for `Issuer` on `CheckoutSessionInvoiceCreationInvoiceDataOptions`, `CheckoutSessionInvoiceCreationInvoiceData`, `PaymentLinkInvoiceCreationInvoiceDataOptions`, `PaymentLinkInvoiceCreationInvoiceData`, `QuoteInvoiceSettingsOptions`, `QuoteInvoiceSettings`, `SubscriptionScheduleDefaultSettingsInvoiceSettingsOptions`, `SubscriptionScheduleDefaultSettingsInvoiceSettings`, `SubscriptionSchedulePhasesInvoiceSettingsOptions`, and `SubscriptionSchedulePhasesInvoiceSettings`
  * Add support for `InvoiceSettings` on `CheckoutSessionSubscriptionDataOptions`, `PaymentLinkSubscriptionDataOptions`, and `PaymentLinkSubscriptionData`
  * Add support for `PromotionCode` on `InvoiceDiscountsOptions` and `InvoiceInvoiceItemsDiscountsOptions`
  * Add support for `AccountType` on `PaymentMethodUsBankAccountOptions`
* [#2831](https://github.com/stripe/stripe-dotnet/pull/2831) Update generated code
  * Add support for `Issuer` on `InvoiceCreateOptions`, `InvoiceUpcomingLinesOptions`, `InvoiceUpcomingOptions`, `InvoiceUpdateOptions`, and `Invoice`
  * Add support for `Liability` on `InvoiceAutomaticTaxOptions`, `InvoiceAutomaticTax`, `SubscriptionAutomaticTaxOptions`, and `SubscriptionAutomaticTax`
  * Add support for `Pin` on `Issuing.CardCreateOptions`
  * Add support for `RevocationReason` on `MandatePaymentMethodDetailsBacsDebit`
  * Add support for `CustomerBalance` on `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, and `PaymentMethodConfiguration`
  * Add support for `InvoiceSettings` on `SubscriptionCreateOptions` and `SubscriptionUpdateOptions`

## 43.12.0-beta.1 - 2024-01-18
* [#2835](https://github.com/stripe/stripe-dotnet/pull/2835) Update generated code for beta
  Release specs are identical.
* [#2833](https://github.com/stripe/stripe-dotnet/pull/2833) Update generated code for beta

* [#2830](https://github.com/stripe/stripe-dotnet/pull/2830) Beta: report RawRequest usage

## 43.11.0 - 2024-01-18
* [#2831](https://github.com/stripe/stripe-dotnet/pull/2831) Update generated code
  * Add support for `Issuer` on `InvoiceCreateOptions`, `InvoiceUpcomingLinesOptions`, `InvoiceUpcomingOptions`, `InvoiceUpdateOptions`, and `Invoice`
  * Add support for `Liability` on `InvoiceAutomaticTaxOptions`, `InvoiceAutomaticTax`, `SubscriptionAutomaticTaxOptions`, and `SubscriptionAutomaticTax`
  * Add support for `Pin` on `Issuing.CardCreateOptions`
  * Add support for `RevocationReason` on `MandatePaymentMethodDetailsBacsDebit`
  * Add support for `CustomerBalance` on `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, and `PaymentMethodConfiguration`
  * Add support for `InvoiceSettings` on `SubscriptionCreateOptions` and `SubscriptionUpdateOptions`

## 43.11.0-beta.1 - 2024-01-12
* [#2828](https://github.com/stripe/stripe-dotnet/pull/2828) Update generated code for beta
  * Add support for `Amount` on `ChargePaymentDetailsFlightSegmentsOptions` and `PaymentIntentPaymentDetailsFlightSegmentsOptions`
  * Add support for `NumberOfRooms` and `RoomClass` on `ChargePaymentDetailsLodgingOptions` and `PaymentIntentPaymentDetailsLodgingOptions`
  * Add support for `BuyButton` on `CustomerSessionComponentsOptions` and `CustomerSessionComponents`

## 43.10.0 - 2024-01-12
* [#2827](https://github.com/stripe/stripe-dotnet/pull/2827) Update generated code
  * Add support for new resource `CustomerSession`
  * Add support for `Create` method on resource `CustomerSession`
  * Remove support for `Expand` on `BankAccountDeleteOptions` and `CardDeleteOptions`
  * Add support for `AccountType`, `DefaultForCurrency`, and `Documents` on `BankAccountUpdateOptions` and `CardUpdateOptions`
  * Remove support for `Owner` on `BankAccountUpdateOptions` and `CardUpdateOptions`
  * Change type of `BankAccountAccountHolderTypeOptions` and `CardAccountHolderTypeOptions` from `enum('company'|'individual')` to `emptyStringable(enum('company'|'individual'))`
  * Add support for `BillingCycleAnchorConfig` on `SubscriptionCreateOptions` and `Subscription`
* [#2807](https://github.com/stripe/stripe-dotnet/pull/2807) Add 'Usage' to RequestTelemetry

## 43.10.0-beta.1 - 2024-01-04
* [#2821](https://github.com/stripe/stripe-dotnet/pull/2821) Update generated code for beta
  * Updated stable APIs to the latest version

## 43.9.0 - 2024-01-04
* [#2822](https://github.com/stripe/stripe-dotnet/pull/2822) Update generated code
  * Add support for `Get` method on resource `Tax.Registration`

## 43.9.0-beta.1 - 2023-12-22
* [#2815](https://github.com/stripe/stripe-dotnet/pull/2815) Update generated code for beta
  * Add support for `CapitalFinancingPromotion` on `AccountSessionComponentsOptions` and `AccountSessionComponents`
  * Change type of `PaymentLinkSubscriptionDataInvoiceSettings` from `nullable(PaymentLinksResourceSubscriptionDataInvoiceSettings)` to `PaymentLinksResourceSubscriptionDataInvoiceSettings`
  * Add support for `ShipFromDetails` on `Tax.CalculationCreateOptions`, `TaxCalculation`, and `TaxTransaction`

## 43.8.0 - 2023-12-22
* [#2818](https://github.com/stripe/stripe-dotnet/pull/2818) Update generated code
  * Add support for `CollectionMethod` on `MandatePaymentMethodDetailsUsBankAccount`
  * Add support for `MandateOptions` on `PaymentIntentPaymentMethodOptionsUsBankAccountOptions`, `PaymentIntentPaymentMethodOptionsUsBankAccount`, `SetupIntentPaymentMethodOptionsUsBankAccountOptions`, and `SetupIntentPaymentMethodOptionsUsBankAccount`
* [#2814](https://github.com/stripe/stripe-dotnet/pull/2814) Update generated code
  * Add support for new resource `FinancialConnections.Transaction`
  * Add support for `Get` and `List` methods on resource `Transaction`
  * Add support for `Subscribe` and `Unsubscribe` methods on resource `FinancialConnections.Account`
  * Add support for `Features` on `AccountSessionComponentsPayoutsOptions`
  * Add support for `EditPayoutSchedule`, `InstantPayouts`, and `StandardPayouts` on `AccountSessionComponentsPayoutsFeatures`
  * Change type of `CheckoutSessionPaymentMethodOptionsUsBankAccountFinancialConnectionsPrefetchOptions`, `CheckoutSessionPaymentMethodOptionsUsBankAccountFinancialConnectionsPrefetch`, `InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsPrefetchOptions`, `InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsPrefetch`, `PaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsPrefetchOptions`, `PaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsPrefetch`, `SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsPrefetchOptions`, `SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsPrefetch`, `SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsPrefetchOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsPrefetch` from `literal('balances')` to `enum('balances'|'transactions')`
  * Add support for `Subscriptions` and `TransactionRefresh` on `FinancialConnectionsAccount`
  * Add support for `NextRefreshAvailableAt` on `FinancialConnectionsAccountBalanceRefresh`
  * Add support for `RevolutPay` on `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, and `PaymentMethodConfiguration`
  * Add support for `DestinationDetails` on `Refund`

## 43.8.0-beta.1 - 2023-12-14
* [#2810](https://github.com/stripe/stripe-dotnet/pull/2810) Update generated code for beta
  * Add support for `PreviewMode` and `SubscriptionDetails` on `InvoiceUpcomingLinesOptions` and `InvoiceUpcomingOptions`
  * Remove support for `SubscriptionTrialFromPlan` on `InvoiceUpcomingLinesOptions` and `InvoiceUpcomingOptions`
  * Add support for `BillingBehavior`, `EndBehavior`, and `ProrationBehavior` on `InvoiceScheduleDetailsOptions`
* [#2811](https://github.com/stripe/stripe-dotnet/pull/2811) Merge master -> beta

## 43.7.0 - 2023-12-14
* [#2813](https://github.com/stripe/stripe-dotnet/pull/2813) Update generated code
  * Add support for `PaymentMethodReuseAgreement` on `CheckoutSessionConsentCollectionOptions`, `CheckoutSessionConsentCollection`, `PaymentLinkConsentCollectionOptions`, and `PaymentLinkConsentCollection`
  * Add support for `AfterSubmit` on `CheckoutSessionCustomTextOptions`, `CheckoutSessionCustomText`, `PaymentLinkCustomTextOptions`, and `PaymentLinkCustomText`
  * Add support for `Created` on `Radar.EarlyFraudWarningListOptions`
* [#2804](https://github.com/stripe/stripe-dotnet/pull/2804) Support passing in options to singleton retrieve methods
  * Add support for passing request parameters to `Get` on `Balance` and `Tax.Settings`.
* [#2809](https://github.com/stripe/stripe-dotnet/pull/2809) Add backcompat check

## 43.7.0-beta.1 - 2023-12-08
* [#2806](https://github.com/stripe/stripe-dotnet/pull/2806) Update generated code for beta
  * Add support for `Get` method on resource `FinancialConnections.Transaction`
  * Remove support for `IssuingCard` and `IssuingCardsList` on `AccountSessionComponentsOptions`
  * Add support for `PaymentMethodRemove`, `PaymentMethodSave`, and `PaymentMethodSetAsDefault` on `CustomerSessionComponentsPaymentElementFeaturesOptions` and `CustomerSessionComponentsPaymentElementFeatures`
  * Remove support for `PaymentMethodDetach` and `PaymentMethodSetAsCustomerDefault` on `CustomerSessionComponentsPaymentElementFeaturesOptions` and `CustomerSessionComponentsPaymentElementFeatures`

## 43.6.0 - 2023-12-07
* [#2805](https://github.com/stripe/stripe-dotnet/pull/2805) Update generated code
  * Add support for `PaymentDetails`, `Payments`, and `Payouts` on `AccountSessionComponentsOptions` and `AccountSessionComponents`
  * Add support for `Features` on `AccountSessionComponentsAccountOnboardingOptions` and `AccountSessionComponentsAccountOnboarding`
  * Add support for `InactiveMessage` and `Restrictions` on `PaymentLinkCreateOptions`, `PaymentLinkUpdateOptions`, and `PaymentLink`
  * Add support for `TransferGroup` on `PaymentLinkPaymentIntentDataOptions` and `PaymentLinkPaymentIntentData`
  * Add support for `TrialSettings` on `PaymentLinkSubscriptionDataOptions` and `PaymentLinkSubscriptionData`

## 43.6.0-beta.1 - 2023-11-30
* [#2802](https://github.com/stripe/stripe-dotnet/pull/2802) Update generated code for beta

## 43.5.0 - 2023-11-30
* [#2801](https://github.com/stripe/stripe-dotnet/pull/2801) Update generated code
  * Add support for new resources `Climate.Order`, `Climate.Product`, and `Climate.Supplier`
  * Add support for `Cancel`, `Create`, `Get`, `List`, and `Update` methods on resource `Order`
  * Add support for `Get` and `List` methods on resources `Product` and `Supplier`
  * Add support for `Created` on `Checkout.SessionListOptions`
  * Add support for `ValidateLocation` on `CustomerTaxOptions`

## 43.5.0-beta.1 - 2023-11-21
* [#2798](https://github.com/stripe/stripe-dotnet/pull/2798) Update generated code for beta
  * Rename `Receipient` to `Recipient` beneath `PaymentDetails` on `Charge` and `PaymentIntent` APIs.
  * Add support for `Components` on `CustomerSessionCreateOptions` and `CustomerSession`

## 43.4.0 - 2023-11-21
* [#2797](https://github.com/stripe/stripe-dotnet/pull/2797) Update generated code
  * Add support for `ElectronicCommerceIndicator` on `ChargePaymentMethodDetailsCardThreeDSecure` and `SetupAttemptPaymentMethodDetailsCardThreeDSecure`
  * Add support for `ExemptionIndicatorApplied` and `ExemptionIndicator` on `ChargePaymentMethodDetailsCardThreeDSecure`
  * Add support for `TransactionId` on `ChargePaymentMethodDetailsCardThreeDSecure`, `IssuingAuthorizationNetworkData`, `IssuingTransactionNetworkData`, and `SetupAttemptPaymentMethodDetailsCardThreeDSecure`
  * Add support for `Offline` on `ChargePaymentMethodDetailsCardPresent`
  * Add support for `SystemTraceAuditNumber` on `IssuingAuthorizationNetworkData`
  * Add support for `NetworkRiskScore` on `IssuingAuthorizationPendingRequest` and `IssuingAuthorizationRequestHistory`
  * Add support for `RequestedAt` on `IssuingAuthorizationRequestHistory`
  * Add support for `AuthorizationCode` on `IssuingTransactionNetworkData`
  * Add support for `ThreeDSecure` on `PaymentIntentPaymentMethodOptionsCardOptions` and `SetupIntentPaymentMethodOptionsCardOptions`

## 43.4.0-beta.1 - 2023-11-16
* [#2795](https://github.com/stripe/stripe-dotnet/pull/2795) Update generated code for beta
  * Add support for `IssuingCard` and `IssuingCardsList` on `AccountSessionComponentsOptions`
  * Add support for `EventDetails` and `Subscription` on `ChargePaymentDetailsOptions`, `PaymentIntentPaymentDetailsOptions`, and `PaymentIntentPaymentDetails`
  * Add support for `Affiliate` and `Delivery` on `ChargePaymentDetailsCarRentalOptions`, `ChargePaymentDetailsFlightOptions`, `ChargePaymentDetailsLodgingOptions`, `PaymentIntentPaymentDetailsCarRentalOptions`, `PaymentIntentPaymentDetailsCarRental`, `PaymentIntentPaymentDetailsFlightOptions`, and `PaymentIntentPaymentDetailsLodgingOptions`
  * Add support for `Drivers` on `ChargePaymentDetailsCarRentalOptions`, `PaymentIntentPaymentDetailsCarRentalOptions`, and `PaymentIntentPaymentDetailsCarRental`
  * Add support for `Passengers` on `ChargePaymentDetailsFlightOptions`, `ChargePaymentDetailsLodgingOptions`, `PaymentIntentPaymentDetailsFlightOptions`, and `PaymentIntentPaymentDetailsLodgingOptions`
  * Add support for `Created` on `CustomerSession`
  * Change type of `Timestamp` property from `long` to `DateTime` on `InvoiceInvoiceItemDiscountDiscountEndOptions`, `InvoiceScheduleDetailsAmendmentAmendmentEndOptions`, `InvoiceScheduleDetailsAmendmentAmendmentStartOptions`, `InvoiceScheduleDetailsAmendmentItemActionAddDiscountDiscountEndOptions`, `InvoiceScheduleDetailsAmendmentItemActionSetDiscountDiscountEndOptions`, `InvoiceScheduleDetailsPhaseAddInvoiceItemDiscountDiscountEndOptions`, `InvoiceScheduleDetailsPhaseDiscountDiscountEndOptions`, `InvoiceScheduleDetailsPhaseItemDiscountDiscountEndOptions`,`InvoiceScheduleDetailsPrebillingBillUntilOptions`, and `InvoiceSubscriptionItemDiscountDiscountEndOptions`
  * Change `long` to `DateTime` in `AnyOf` type for `EndDate`, `StartDate`, and `TrialEnd` on `InvoiceScheduleDetailsPhaseOptions`

## 43.3.0 - 2023-11-16
* [#2796](https://github.com/stripe/stripe-dotnet/pull/2796) Update generated code
  * Add support for `BacsDebitPayments` on `AccountSettingsOptions`
  * Add support for `ServiceUserNumber` on `AccountSettingsBacsDebitPayments`
  * Add support for `CaptureBefore` on `ChargePaymentMethodDetailsCard`
  * Add support for `Status` on `Checkout.SessionListOptions`
  * Add support for `Paypal` on `CheckoutSessionPaymentMethodOptions`
  * Add support for `TaxAmounts` on `CreditNoteLinesOptions`
  * Add support for `NetworkData` on `IssuingTransaction`

## 43.3.0-beta.1 - 2023-11-10
* [#2792](https://github.com/stripe/stripe-dotnet/pull/2792) Update generated code for beta
  * Add support for `Metadata` on `QuotePhase` and `QuotePhasesOptions`
  * Add support for `LastReestimationDetails` on `QuoteComputed`

## 43.2.0 - 2023-11-09
* [#2793](https://github.com/stripe/stripe-dotnet/pull/2793) Update generated code
  * Add support for `Metadata` on `QuoteSubscriptionDataOptions` and `QuoteSubscriptionData`
* [#2794](https://github.com/stripe/stripe-dotnet/pull/2794) Generate CardCreateNestedOptions

## 43.2.0-beta.1 - 2023-11-02
* [#2788](https://github.com/stripe/stripe-dotnet/pull/2788) Update generated code for beta
  * Add support for `AttachPaymentIntent` method on resource `Invoice`
  * Add support for `RevolutPay` on `ConfirmationTokenPaymentMethodPreview`
  * Add support for `Refunds` on `CreditNoteCreateOptions`, `CreditNotePreviewLinesOptions`, `CreditNotePreviewOptions`, and `CreditNote`
  * Add support for `PostPaymentAmount` and `PrePaymentAmount` on `CreditNote`
  * Add support for `ScheduleDetails` on `InvoiceUpcomingLinesOptions` and `InvoiceUpcomingOptions`
  * Add support for `AmountsDue` on `InvoiceCreateOptions`, `InvoiceUpdateOptions`, and `Invoice`
  * Add support for `Payments` on `Invoice`
  * Add support for `Created` on `IssuingPersonalizationDesign`
  * Add support for `EndingBefore`, `Limit`, and `StartingAfter` on `Tax.RegistrationListOptions`
  * Change type of `TaxRegistrationActiveFromOptions` and `TaxRegistrationExpiresAtOptions` to `literal('now') | DateTime`
  * Change type of `TaxRegistrationActiveFrom`, `TaxRegistrationCreated`, `TaxRegistrationExpiresAtOptions`, and `TaxRegistrationExpiresAt` from `longInteger` to `DateTime`

## 43.1.0 - 2023-11-02
* [#2787](https://github.com/stripe/stripe-dotnet/pull/2787) Update generated code
  * Add support for new resource `Tax.Registration`
  * Add support for `Create`, `List`, and `Update` methods on resource `Registration`
  * Add support for `RevolutPay` throughout the API.
  * Add support for `Aba` and `Swift` on `FundingInstructionsBankTransferFinancialAddresses` and `PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddresses`
  * Add support for `Url` on `IssuingAuthorizationMerchantDataOptions`, `IssuingAuthorizationMerchantData`, `IssuingTransactionMerchantDataOptions`, and `IssuingTransactionMerchantData`
  * Add support for `AuthenticationExemption` and `ThreeDSecure` on `IssuingAuthorizationVerificationDataOptions` and `IssuingAuthorizationVerificationData`
  * Add support for `Description` on `PaymentLinkPaymentIntentDataOptions` and `PaymentLinkPaymentIntentData`
* [#2791](https://github.com/stripe/stripe-dotnet/pull/2791) Use RequestAsync directly
* [#2790](https://github.com/stripe/stripe-dotnet/pull/2790) Generate all resource classes
* [#2789](https://github.com/stripe/stripe-dotnet/pull/2789) Add list enum comments and autogenerate more options

## 43.1.0-beta.2 - 2023-10-26
* [#2784](https://github.com/stripe/stripe-dotnet/pull/2784) Update generated code for beta
  * Add support for new resource `Margin`
  * Add support for `Create`, `Get`, `List`, and `Update` methods on resource `Margin`
  * Add support for `Subsellers` on `CheckoutSessionPaymentMethodOptionsPaypalOptions`, `OrderPaymentSettingsPaymentMethodOptionsPaypalOptions`, `OrderPaymentSettingsPaymentMethodOptionsPaypal`, `PaymentIntentPaymentMethodOptionsPaypalOptions`, `PaymentIntentPaymentMethodOptionsPaypal`, `SetupIntentPaymentMethodOptionsPaypalOptions`, and `SetupIntentPaymentMethodOptionsPaypal`
  * Add support for `DefaultMargins` on `InvoiceCreateOptions`, `InvoiceUpdateOptions`, and `Invoice`
  * Add support for `TotalMarginAmounts` on `Invoice`
  * Add support for `Margins` on `InvoiceItemCreateOptions`, `InvoiceItemUpdateOptions`, and `InvoiceItem`
  * Add support for `IsDefault` on `IssuingPersonalizationDesignPreferencesOptions` and `IssuingPersonalizationDesignPreferences`
  * Add support for `IsPlatformDefault` on `IssuingPersonalizationDesignPreferencesOptions` and `IssuingPersonalizationDesignPreferences`
  * Remove support for `AccountDefault` on `IssuingPersonalizationDesignPreferencesOptions` and `IssuingPersonalizationDesignPreferences`
  * Remove support for `PlatformDefault` on `IssuingPersonalizationDesignPreferencesOptions` and `IssuingPersonalizationDesignPreferences`
  * Add support for `Liability` on `PaymentLinkAutomaticTaxOptions` and `PaymentLinkAutomaticTax`
  * Add support for `Issuer` on `PaymentLinkInvoiceCreationInvoiceDataOptions` and `PaymentLinkInvoiceCreationInvoiceData`
  * Add support for `InvoiceSettings` on `PaymentLinkSubscriptionDataOptions` and `PaymentLinkSubscriptionData`

## 43.1.0-beta.1 - 2023-10-17
* [#2782](https://github.com/stripe/stripe-dotnet/pull/2782) Update generated code for beta
  - Update pinned API version to `2023-10-16`

## 43.0.0 - 2023-10-16
* This release changes the pinned API version to `2023-10-16`. Please read the [API Changelog](https://docs.stripe.com/changelog/2023-10-16) and carefully review the API changes before upgrading `Stripe.net`.
* [#2781](https://github.com/stripe/stripe-dotnet/pull/2781) Update generated code
  * Add support for `LegalGuardian` on `AccountRelationshipOptions` and `TokenPersonRelationshipOptions`
  * Add support for `AdditionalTosAcceptances` on `TokenPersonOptions`

## 42.11.0-beta.1 - 2023-10-16
* [#2779](https://github.com/stripe/stripe-dotnet/pull/2779) Update generated code for beta

## 42.10.0 - 2023-10-16
* [#2780](https://github.com/stripe/stripe-dotnet/pull/2780) Update generated code
  * Add support for `issuing_token.created` and `issuing_token.updated` event types.

## 42.10.0-beta.1 - 2023-10-11
* [#2777](https://github.com/stripe/stripe-dotnet/pull/2777) Update generated code for beta
  * Add support for new resources `AccountNotice` and `Issuing.CreditUnderwritingRecord`
  * Add support for `Get`, `List`, and `Update` methods on resource `AccountNotice`
  * Add support for `Correct`, `CreateFromApplication`, `CreateFromProactiveReview`, `Get`, `List`, and `ReportDecision` methods on resource `CreditUnderwritingRecord`

## 42.9.0 - 2023-10-11
* [#2778](https://github.com/stripe/stripe-dotnet/pull/2778) Update generated code
  * Add support for `RedirectOnCompletion`, `ReturnUrl`, and `UiMode` on `Checkout.SessionCreateOptions` and `CheckoutSession`
  * Add support for `ClientSecret` on `CheckoutSession`
  * Add support for `PostalCode` on `IssuingAuthorizationVerificationData`
  * Add support for `Offline` on `Terminal.ConfigurationCreateOptions`, `Terminal.ConfigurationUpdateOptions`, and `TerminalConfiguration`

## 42.9.0-beta.1 - 2023-10-05
* [#2775](https://github.com/stripe/stripe-dotnet/pull/2775) Update generated code for beta
  * Add support for `MarkDraft` and `MarkStale` methods on resource `Quote`
  * Remove support for `DraftQuote` and `MarkStaleQuote` methods on resource `Quote`
  * Add support for `Liability` on `CheckoutSessionAutomaticTaxOptions` and `CheckoutSessionAutomaticTax`
  * Add support for `Issuer` on `CheckoutSessionInvoiceCreationInvoiceDataOptions` and `CheckoutSessionInvoiceCreationInvoiceData`
  * Add support for `InvoiceSettings` on `CheckoutSessionSubscriptionDataOptions`
  * Add support for `PersonalizationDesign` on `Issuing.CardListOptions`
  * Add support for `AllowBackdatedLines` on `QuoteCreateOptions`, `QuoteUpdateOptions`, and `Quote`

## 42.8.0 - 2023-10-05
* [#2776](https://github.com/stripe/stripe-dotnet/pull/2776) Update generated code
  * Add support for new resource `Issuing.Token`
  * Add support for `Get`, `List`, and `Update` methods on resource `Token`
  * Add support for `AmountAuthorized`, `ExtendedAuthorization`, `IncrementalAuthorization`, `Multicapture`, and `Overcapture` on `ChargePaymentMethodDetailsCard`
  * Add support for `Token` on `IssuingAuthorization` and `IssuingTransaction`
  * Add support for `AuthorizationCode` on `IssuingAuthorizationRequestHistory`
  * Add support for `RequestExtendedAuthorization`, `RequestMulticapture`, and `RequestOvercapture` on `PaymentIntentPaymentMethodOptionsCardOptions` and `PaymentIntentPaymentMethodOptionsCard`
  * Add support for `RequestIncrementalAuthorization` on `PaymentIntentPaymentMethodOptionsCardOptions`, `PaymentIntentPaymentMethodOptionsCardPresentOptions`, and `PaymentIntentPaymentMethodOptionsCard`
  * Add support for `FinalCapture` on `PaymentIntentCaptureOptions`
  * Add support for `Metadata` on `PaymentLinkPaymentIntentDataOptions`, `PaymentLinkPaymentIntentData`, `PaymentLinkSubscriptionDataOptions`, and `PaymentLinkSubscriptionData`
  * Add support for `StatementDescriptorSuffix` and `StatementDescriptor` on `PaymentLinkPaymentIntentDataOptions` and `PaymentLinkPaymentIntentData`
  * Add support for `PaymentIntentData` and `SubscriptionData` on `PaymentLinkUpdateOptions`

## 42.8.0-beta.1 - 2023-09-28
* [#2773](https://github.com/stripe/stripe-dotnet/pull/2773) Update generated code for beta
  * Rename resources `Issuing.CardDesign` and `Issuing.CardBundle` to `Issuing.PersonalizationDesign` and `Issuing.PhysicalBundle`
  * Add support for `Features` on `AccountSessionComponentsAccountOnboardingOptions`, `AccountSessionComponentsPaymentDetailsOptions`, `AccountSessionComponentsPaymentDetails`, `AccountSessionComponentsPaymentsOptions`, `AccountSessionComponentsPayments`, `AccountSessionComponentsPayoutsOptions`, and `AccountSessionComponentsPayouts`
  * Add support for `Reason` on `Event`

## 42.7.0 - 2023-09-28
* [#2772](https://github.com/stripe/stripe-dotnet/pull/2772) Update generated code
  * Add support for `Rendering` on `InvoiceCreateOptions`, `InvoiceUpdateOptions`, and `Invoice`

## 42.7.0-beta.1 - 2023-09-21
* [#2768](https://github.com/stripe/stripe-dotnet/pull/2768) Update generated code for beta
  * Remove support for `Customer` on `ConfirmationToken`
  * Add support for `Issuer` on `InvoiceCreateOptions`, `InvoiceUpcomingLinesOptions`, `InvoiceUpcomingOptions`, `InvoiceUpdateOptions`, `Invoice`, `QuoteInvoiceSettingsOptions`, `QuoteInvoiceSettings`, `SubscriptionScheduleDefaultSettingsInvoiceSettingsOptions`, `SubscriptionScheduleDefaultSettingsInvoiceSettings`, `SubscriptionSchedulePhasesInvoiceSettingsOptions`, and `SubscriptionSchedulePhasesInvoiceSettings`
  * Add support for `OnBehalfOf` on `InvoiceUpcomingLinesOptions` and `InvoiceUpcomingOptions`
  * Add support for `Liability` on `InvoiceAutomaticTaxOptions`, `InvoiceAutomaticTax`, `QuoteAutomaticTaxOptions`, `QuoteAutomaticTax`, `SubscriptionAutomaticTaxOptions`, `SubscriptionAutomaticTax`, `SubscriptionScheduleDefaultSettingsAutomaticTaxOptions`, `SubscriptionScheduleDefaultSettingsAutomaticTax`, `SubscriptionSchedulePhasesAutomaticTaxOptions`, and `SubscriptionSchedulePhasesAutomaticTax`
  * Change type of `IssuingCardDesignCarrierTextOptions` from `carrier_text_param` to `emptyStringable(carrier_text_param)`
  * Add support for `InvoiceSettings` on `SubscriptionCreateOptions` and `SubscriptionUpdateOptions`
  * Remove `InvoiceLineItemDiscountDiscountEndDurationOptions`, `InvoiceLineItemDiscountDiscountEndOptions`, `InvoiceLineItemInvoiceItemDiscountDiscountEndDurationOptions`, `InvoiceLineItemInvoiceItemDiscountDiscountEndOptions`, `InvoiceLineItemSubscriptionItemDiscountDiscountEndDurationOptions`, `InvoiceLineItemSubscriptionItemDiscountDiscountEndOptions.cs`, `InvoiceLineItemSubscriptionItemDiscountOptions`, `InvoiceLineItemSubscriptionPrebillingOptions`. These are obsolete and not used anywhere.

## 42.6.0 - 2023-09-21
* [#2769](https://github.com/stripe/stripe-dotnet/pull/2769) Update generated code
  * Add support for `TermsOfServiceAcceptance` on `CheckoutSessionCustomTextOptions`, `CheckoutSessionCustomText`, `PaymentLinkCustomTextOptions`, and `PaymentLinkCustomText`
* [#2770](https://github.com/stripe/stripe-dotnet/pull/2770) Add comments for query parameters

## 42.6.0-beta.1 - 2023-09-14
* [#2765](https://github.com/stripe/stripe-dotnet/pull/2765) Update generated code for beta
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

## 42.5.0 - 2023-09-14
* [#2767](https://github.com/stripe/stripe-dotnet/pull/2767) Update generated code
  * Add support for new resource `PaymentMethodConfiguration`
  * Add support for `Create`, `Get`, `List`, and `Update` methods on resource `PaymentMethodConfiguration`
  * Add support for `PaymentMethodConfiguration` on `Checkout.SessionCreateOptions`, `PaymentIntentCreateOptions`, `PaymentIntentUpdateOptions`, `SetupIntentCreateOptions`, and `SetupIntentUpdateOptions`
  * Add support for `PaymentMethodConfigurationDetails` on `CheckoutSession`, `PaymentIntent`, and `SetupIntent`
* [#2764](https://github.com/stripe/stripe-dotnet/pull/2764) Update generated code
  * Add support for `Capture`, `Create`, `Expire`, `Increment`, and `Reverse` test helper methods on resource `Issuing.Authorization`
  * Add support for `CreateForceCapture`, `CreateUnlinkedRefund`, and `Refund` test helper methods on resource `Issuing.Transaction`
  * Add support for `Nonce` on `EphemeralKeyCreateOptions`
  * Add support for `CashbackAmount` on `IssuingAuthorizationAmountDetails`, `IssuingAuthorizationPendingRequestAmountDetails`, `IssuingAuthorizationRequestHistoryAmountDetails`, and `IssuingTransactionAmountDetails`
  * Add support for `SerialNumber` on `Terminal.ReaderListOptions`

## 42.5.0-beta.1 - 2023-09-07
* [#2762](https://github.com/stripe/stripe-dotnet/pull/2762) Update generated code for beta
  * Release specs are identical.
* [#2761](https://github.com/stripe/stripe-dotnet/pull/2761) Update generated code for beta
  * Remove support for `SubmitCard` test helper method on resource `Issuing.Card`
  * Add support for `CardDesign` on `Issuing.CardUpdateOptions`
* [#2759](https://github.com/stripe/stripe-dotnet/pull/2759) Update generated code for beta
  * Rename `QuoteService.ListPreviewInvoices` to `QuotePreviewInvoiceService.List` and `QuoteService.ListPreviewSubscriptionSchedules` to `QuotePreviewScheduleService.List`
  * Add support for `TaxForms` on `AccountSettingsOptions` and `AccountSettings`
  * Add support for `Components` on `AccountSessionCreateOptions` and `AccountSession`
* [#2749](https://github.com/stripe/stripe-dotnet/pull/2749) Update generated code for beta
  * Add support for new resources `QuotePreviewInvoice` and `QuotePreviewSchedule`
  * Remove support for `AppliesTo` on `Invoice` and `SubscriptionSchedule`
  * Add support for `Cl`, `Co`, `Id`, `Kr`, `Mx`, `My`, `Sa`, `Th`, `Tr`, and `Vn` on `TaxRegistrationCountryOptionsOptions` and `TaxRegistrationCountryOptions`
  * Remove support for `Hk` on `TaxRegistrationCountryOptionsOptions` and `TaxRegistrationCountryOptions`

## 42.4.0 - 2023-09-07
* [#2760](https://github.com/stripe/stripe-dotnet/pull/2760) Update generated code
  * Add support for new resource `PaymentMethodDomain`
  * Add support for `Create`, `Get`, `List`, `Update`, and `Validate` methods on resource `PaymentMethodDomain`
  * Add support for `Features` on `ProductCreateOptions`, `ProductUpdateOptions`, and `Product`
* [#2755](https://github.com/stripe/stripe-dotnet/pull/2755) Update generated code
  * Add support for new resource `AccountSession`
  * Add support for `Create` method on resource `AccountSession`
  * Add support for `Application` on `PaymentLink`
* [#2753](https://github.com/stripe/stripe-dotnet/pull/2753) Update generated code
  * Add support for `Retention` on `BillingPortalSessionFlowDataSubscriptionCancelOptions` and `BillingPortalSessionFlowSubscriptionCancel`
  * Add support for `Prefetch` on `CheckoutSessionPaymentMethodOptionsUsBankAccountFinancialConnectionsOptions`, `CheckoutSessionPaymentMethodOptionsUsBankAccountFinancialConnections`, `FinancialConnections.SessionCreateOptions`, `FinancialConnectionsSession`, `InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsOptions`, `InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnections`, `PaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsOptions`, `PaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnections`, `SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsOptions`, `SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnections`, `SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnections`
  * Add support for `PaymentMethodDetails` on `Dispute`
  * Add support for `BalanceTransaction` on `CustomerCashBalanceTransactionAdjustedForOverdraft`

## 42.4.0-beta.1 - 2023-09-01
* [#2759](https://github.com/stripe/stripe-dotnet/pull/2759) Update generated code for beta
  * Rename `QuoteService.ListPreviewInvoices` to `QuotePreviewInvoiceService.List` and `QuoteService.ListPreviewSubscriptionSchedules` to `QuotePreviewScheduleService.List`
  * Add support for `TaxForms` on `AccountSettingsOptions` and `AccountSettings`
  * Add support for `Components` on `AccountSessionCreateOptions` and `AccountSession`

## 42.3.0 - 2023-08-31
* [#2755](https://github.com/stripe/stripe-dotnet/pull/2755) Update generated code
  * Add support for new resource `AccountSession`
  * Add support for `Create` method on resource `AccountSession`
  * Add support for `Application` on `PaymentLink`

## 42.2.0 - 2023-08-24
* [#2753](https://github.com/stripe/stripe-dotnet/pull/2753) Update generated code
  * Add support for `Retention` on `BillingPortalSessionFlowDataSubscriptionCancelOptions` and `BillingPortalSessionFlowSubscriptionCancel`
  * Add support for `Prefetch` on `CheckoutSessionPaymentMethodOptionsUsBankAccountFinancialConnectionsOptions`, `CheckoutSessionPaymentMethodOptionsUsBankAccountFinancialConnections`, `FinancialConnections.SessionCreateOptions`, `FinancialConnectionsSession`, `InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsOptions`, `InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnections`, `PaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsOptions`, `PaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnections`, `SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsOptions`, `SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnections`, `SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnections`
  * Add support for `PaymentMethodDetails` on `Dispute`
  * Add support for `BalanceTransaction` on `CustomerCashBalanceTransactionAdjustedForOverdraft`

## 42.1.0 - 2023-08-17
* [#2752](https://github.com/stripe/stripe-dotnet/pull/2752) Update generated code
  * Add support for `FlatAmount` on `Tax.TransactionCreateReversalOptions`

## 42.0.0 - 2023-08-16
* This release changes the pinned API version to `2023-08-16`. Please read the [API Changelog](https://docs.stripe.com/changelog/2023-08-16) and carefully review the API changes before upgrading `stripe-dotnet`.
* More information is available in the [stripe-dotnet v42 migration guide](https://github.com/stripe/stripe-dotnet/wiki/Migration-guide-for-v42)
* [#2750](https://github.com/stripe/stripe-dotnet/pull/2750) Update generated code
  "⚠️" symbol highlights breaking changes.
  * ⚠️Remove support for `AvailableOn` on `BalanceTransactionListOptions`
    * Use of this parameter is discouraged. You may use [`.AddExtraParam`](https://github.com/stripe/stripe-dotnet/#parameters) if sending the parameter is still required.
  * ⚠️Remove support for `Destination` on `Charge`
    * Please use `TransferData` or `OnBehalfOf` instead.
  * ⚠️Remove support for `ShippingRates` on `Checkout.SessionCreateOptions`
    * Please use `ShippingOptions` instead.
  * ⚠️Remove support for `Coupon` and `TrialFromPlan` on `CheckoutSessionSubscriptionDataOptions`
    * Please [migrate to the Prices API](https://stripe.com/docs/billing/migration/migrating-prices), or use [`.AddExtraParam`](https://github.com/stripe/stripe-dotnet/#parameters) if sending the parameter is still required.
  * ⚠️Remove support for `Blik` on `MandatePaymentMethodDetails`, `PaymentMethodUpdateOptions`, `SetupAttemptPaymentMethodDetails`, `SetupIntentPaymentMethodOptionsOptions`, and `SetupIntentPaymentMethodOptions`
      * These fields were mistakenly released.
  * ⚠️Remove support for `AcssDebit`, `Affirm`, `AuBecsDebit`, `BacsDebit`, `Cashapp`, `SepaDebit`, and `Zip` on `PaymentMethodUpdateOptions`
      * These fields were empty hashes.
  * ⚠️Remove support for `Country` on `PaymentMethodLink`
      * This field was not fully operational.
  * ⚠️Remove support for `Recurring` on `PriceUpdateOptions`
      * This property should be set on create only.
  * ⚠️Remove support for `Attributes`, `Caption`, and `DeactivateOn` on `ProductCreateOptions`, `ProductUpdateOptions`, and `Product`
    * These fields are not fully operational.
  * ⚠️Remove support for `AlternateStatementDescriptors` and `Dispute` on `Charge`
    * Use of these parameters is discouraged.
* [#2744](https://github.com/stripe/stripe-dotnet/pull/2744) Type changes
  * ⚠️ Generate more accurate types for `AccountSettingsPayoutsScheduleOptions.DelayDays`, `SubscriptionSchedulePhaseOptions.EndDate`, `SubscriptionSchedulePhaseOptions.StartDate`, and
  `SubscriptionSchedulePhaseOptions.TrialEnd`. These fields are dates or numbers that also support special signifier strings like "now". They have been changed to use `AnyOf<...>`.
* [#2746](http://github.com/stripe/stripe-dotnet/pull/2746) Type changes
  * ⚠️ Change type of `AccountSettingsPayoutsScheduleOptions.MonthlyAnchor` from string to long.
* [#2751](https://github.com/stripe/stripe-dotnet/pull/2751)
  * ⚠️ Remove several deprecated constants from `Event`
  * ⚠️ Make `Discount.Start` non-nullable
  * ⚠️ Reflect that `Discount.Subscription` is not expandable
  * ⚠️ Reflect that several fields on `InvoiceLineItem` are expandable.

## 42.0.0-beta.1 - 2023-08-24
* [#2749](https://github.com/stripe/stripe-dotnet/pull/2749) Update generated code for beta
  * Add support for new resources `QuotePreviewInvoice` and `QuotePreviewSchedule`
  * Remove support for `AppliesTo` on `Invoice` and `SubscriptionSchedule`
  * Add support for `Cl`, `Co`, `Id`, `Kr`, `Mx`, `My`, `Sa`, `Th`, `Tr`, and `Vn` on `TaxRegistrationCountryOptionsOptions` and `TaxRegistrationCountryOptions`
  * Remove support for `Hk` on `TaxRegistrationCountryOptionsOptions` and `TaxRegistrationCountryOptions`

## 41.29.0-beta.1 - 2023-08-10
* [#2743](https://github.com/stripe/stripe-dotnet/pull/2743) Update generated code for beta
  * Add support for `Paypal` on `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, and `PaymentMethodConfiguration`

## 41.28.0 - 2023-08-10
* [#2742](https://github.com/stripe/stripe-dotnet/pull/2742) Update generated code
  * Add support for `AdjustedForOverdraft` to `CustomerCashBalanceTransaction`

## 41.28.0-beta.1 - 2023-08-03
* [#2737](https://github.com/stripe/stripe-dotnet/pull/2737) Update generated code for beta
  * Add support for `SubmitCard` test helper method on resource `Issuing.Card`
  * Add support for `AddressValidation` on `IssuingCardShippingOptions` and `IssuingCardShipping`
  * Add support for `Shipping` on `Issuing.CardUpdateOptions`
  * Change type of `OrderDescriptionOptions`, `OrderLineItemsProductDataDescriptionOptions`, `OrderLineItemsProductDataTaxCodeOptions`, `OrderShippingDetailsPhoneOptions`, `PaymentMethodConfigurationApplicationOptions`, and `QuoteSubscriptionDataOverridesDescriptionOptions` from `string` to `emptyStringable(string)`
  * Add support for `Reason` on `QuoteMarkStaleQuoteOptions`
  * Add support for `MarkedStale` on `QuoteStatusDetailsStaleLastReason`
* [#2739](https://github.com/stripe/stripe-dotnet/pull/2739) Remove developer_message support

## 41.27.0 - 2023-08-03
* [#2741](https://github.com/stripe/stripe-dotnet/pull/2741) Update generated code
  * Add support for `PreferredSettlementSpeed` on `PaymentIntentPaymentMethodOptionsUsBankAccountOptions` and `PaymentIntentPaymentMethodOptionsUsBankAccount`
* [#2738](https://github.com/stripe/stripe-dotnet/pull/2738) Update generated code
  * Add support for `SubscriptionDetails` on `Invoice`

## 41.27.0-beta.1 - 2023-07-27
  * Updated stable APIs to the latest version

## 41.26.0 - 2023-07-27
* [#2733](https://github.com/stripe/stripe-dotnet/pull/2733) Update generated code
  * Add support for `MonthlyEstimatedRevenue` on `AccountBusinessProfileOptions` and `AccountBusinessProfile`
* [#2735](https://github.com/stripe/stripe-dotnet/pull/2735) Auto-generate event constants
  * Add support for `BillingPortalSessionCreated`, `FinancialConnectionsAccountCreated`, `FinancialConnectionsAccountDeactivated`, `FinancialConnectionsAccountDisconnected`, `FinancialConnectionsAccountReactivated`, `FinancialConnectionsAccountRefreshedBalance`, and `TaxSettingsUpdated` on `Event`

## 41.25.0 - 2023-07-20
* [#2732](https://github.com/stripe/stripe-dotnet/pull/2732) Update generated code
  * Add support for `UseStripeSdk` on `SetupIntentConfirmOptions` and `SetupIntentCreateOptions`
* [#2728](https://github.com/stripe/stripe-dotnet/pull/2728) Update generated code
  * Add support for UseStripeSdk on SetupIntentConfirmOptions and SetupIntentCreateOptions

## 41.25.0-beta.1 - 2023-07-13
* [#2727](https://github.com/stripe/stripe-dotnet/pull/2727) Update generated code for beta
  Release specs are identical.
* [#2724](https://github.com/stripe/stripe-dotnet/pull/2724) Update generated code for beta
  * Add support for new resource `PaymentMethodConfiguration`
  * Add support for `Create`, `Get`, `List`, and `Update` methods on resource `PaymentMethodConfiguration`
  * Add support for `PaymentMethodConfiguration` on `PaymentIntentCreateOptions` and `PaymentIntentUpdateOptions`
  * Add support for `PaymentMethodConfigurationDetails` on `PaymentIntent`
* [#2721](https://github.com/stripe/stripe-dotnet/pull/2721) Update generated code for beta

## 41.24.0 - 2023-07-13
* [#2725](https://github.com/stripe/stripe-dotnet/pull/2725) Update generated code
  * Add support for new resource `Tax.Settings`
  * Add support for `Get` and `Update` methods on resource `Settings`
  * Add support for `OrderId` on `ChargePaymentMethodDetailsAfterpayClearpay`
  * Add support for `AllowRedirects` on `PaymentIntentAutomaticPaymentMethodsOptions`, `PaymentIntentAutomaticPaymentMethods`, `SetupIntentAutomaticPaymentMethodsOptions`, and `SetupIntentAutomaticPaymentMethods`
  * Add support for `Product` on `TaxTransactionLineItem`

## 41.23.0 - 2023-07-06
* [#2720](https://github.com/stripe/stripe-dotnet/pull/2720) Update generated code
  * Add support for `Numeric` and `Text` on `PaymentLinkCustomFields`
  * Add support for `AutomaticTax` on `SubscriptionListOptions`

## 41.23.0-beta.1 - 2023-06-29
* [#2718](https://github.com/stripe/stripe-dotnet/pull/2718) Update generated code for beta
  * Add support for `Metadata` on `InvoiceSubscriptionDetails`

## 41.22.0 - 2023-06-29
* [#2717](https://github.com/stripe/stripe-dotnet/pull/2717) Update generated code
  * Add support for `EffectiveAt` on `CreditNoteCreateOptions`, `CreditNotePreviewLinesOptions`, `CreditNotePreviewOptions`, `CreditNote`, `InvoiceCreateOptions`, `InvoiceUpdateOptions`, and `Invoice`

## 41.22.0-beta.1 - 2023-06-22
* [#2715](https://github.com/stripe/stripe-dotnet/pull/2715) Update generated code for beta
  * Add support for new resource `CustomerSession`
  * Add support for `Create` method on resource `CustomerSession`
  * Change type of `TaxRegistrationCountryOptionsUsTypeOptions` and `TaxRegistrationCountryOptionsUsType` from `literal('state_sales_tax')` to `enum('local_lease_tax'|'state_sales_tax')`

## 41.21.0 - 2023-06-22
* [#2714](https://github.com/stripe/stripe-dotnet/pull/2714) Update generated code
  * Add support for `OnBehalfOf` on `Mandate`
* [#2716](https://github.com/stripe/stripe-dotnet/pull/2716) Deserialization test
* [#2713](https://github.com/stripe/stripe-dotnet/pull/2713) Update generated code
  * Release specs are identical.
* [#2710](https://github.com/stripe/stripe-dotnet/pull/2710) Update generated code
  * Change type of `FileFileOptions` from `string` to `file`

## 41.21.0-beta.2 - 2023-06-15
* [#2712](https://github.com/stripe/stripe-dotnet/pull/2712) Update generated code for beta
  * Add support for `PaymentDetails` on `ChargeCaptureOptions`, `ChargeUpdateOptions`, `PaymentIntentCaptureOptions`, `PaymentIntentConfirmOptions`, `PaymentIntentCreateOptions`, `PaymentIntentUpdateOptions`, and `PaymentIntent`
  * Add support for `StatementDetails` on `PaymentIntentPaymentMethodOptionsCardOptions` and `PaymentIntentPaymentMethodOptionsCard`
* [#2711](https://github.com/stripe/stripe-dotnet/pull/2711) Update generated code for beta

## 41.21.0-beta.1 - 2023-06-08
* [#2704](https://github.com/stripe/stripe-dotnet/pull/2704) Update generated code for beta
  * Updated stable APIs to the latest version

## 41.20.0 - 2023-06-08
* [#2705](https://github.com/stripe/stripe-dotnet/pull/2705) Update generated code
  * Add support for `TaxabilityReason` on `Tax.CalculationTaxBreakdown`
* [#2709](https://github.com/stripe/stripe-dotnet/pull/2709) Revert "Move ShippingOptions"
* [#2707](https://github.com/stripe/stripe-dotnet/pull/2707) Move ShippingOptions
* [#2703](https://github.com/stripe/stripe-dotnet/pull/2703) Fix stripe_net_target_framework telemetry

## 41.20.0-beta.1 - 2023-06-01
* [#2702](https://github.com/stripe/stripe-dotnet/pull/2702) Update generated code for beta
  * Add support for `SubscriptionDetails` on `Invoice`
  * Add support for `SetPauseCollection` on `QuoteLine`, `QuoteLinesOptions`, and `SubscriptionScheduleAmendmentsOptions`
  * Add support for `PauseCollection` on `SubscriptionSchedulePhasesOptions` and `SubscriptionSchedulePhases`
  * Add support for `LocalAmusementTax` on `TaxRegistrationCountryOptionsUsOptions` and `TaxRegistrationCountryOptionsUs`
  * Remove support for `Locations` on `TaxSettingsUpdateOptions` and `TaxSettings`
* [#2698](https://github.com/stripe/stripe-dotnet/pull/2698) Update generated code for beta

## 41.19.0 - 2023-06-01
* [#2701](https://github.com/stripe/stripe-dotnet/pull/2701) Update generated code
  * Add support for `Numeric` and `Text` on `Checkout.SessionCustomFieldsOptions` and `PaymentLinkCustomFieldsOptions`
  * Add support for `MaximumLength` and `MinimumLength` on `Checkout.SessionCustomFieldsNumeric` and `Checkout.SessionCustomFieldsText`
  * Add support for `PreferredLocales` on `Issuing.CardholderCreateOptions`, `Issuing.CardholderUpdateOptions`, and `Issuing.Cardholder`
  * Add support for `Description`, `Iin`, and `Issuer` on `PaymentMethodCardPresent` and `PaymentMethodInteracPresent`
  * Add support for `PayerEmail` on `PaymentMethodPaypal`

## 41.19.0-beta.1 - 2023-05-25
* [#2700](https://github.com/stripe/stripe-dotnet/pull/2700) Handle developer_message in preview error responses

## 41.18.0 - 2023-05-25
* [#2699](https://github.com/stripe/stripe-dotnet/pull/2699) Update generated code
  * Add support for `ZipPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
  * Add support for `Zip` on `ChargePaymentMethodDetails`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethodUpdateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`

## 41.18.0-beta.1 - 2023-05-19
* [#2697](https://github.com/stripe/stripe-dotnet/pull/2697) Update generated code for beta
  * Add support for `Subscribe` and `Unsubscribe` methods on resource `FinancialConnections.Account`
  * Add support for `NextRefreshAvailableAt` on `FinancialConnectionsAccountBalanceRefresh`, `FinancialConnectionsAccountInferredBalancesRefresh`, `FinancialConnectionsAccountOwnershipRefresh`, and `FinancialConnectionsAccountTransactionRefresh`
  * Add support for `StatusDetails` and `Status` on `TaxSettings`
* [#2690](https://github.com/stripe/stripe-dotnet/pull/2690) StripeClient.RawRequest

## 41.17.0 - 2023-05-19
* [#2696](https://github.com/stripe/stripe-dotnet/pull/2696) Update generated code
  * Add support for `SubscriptionUpdateConfirm` and `SubscriptionUpdate` on `BillingPortal.SessionFlowDataOptions` and `BillingPortal.SessionFlow`
  * Add support for `Link` on `ChargePaymentMethodDetailsCardWallet` and `PaymentMethodCardWallet`
  * Add support for `BuyerId` and `Cashtag` on `ChargePaymentMethodDetailsCashapp` and `PaymentMethodCashapp`

## 41.17.0-beta.1 - 2023-05-11
* [#2691](https://github.com/stripe/stripe-dotnet/pull/2691) Update generated code for beta
  * Add support for `PayerEmail`, `PayerName`, and `SellerProtection` on `ChargePaymentMethodDetailsPaypal`
  * Add support for `CaptureMethod`, `PreferredLocale`, `ReferenceId`, and `SetupFutureUsage` on `CheckoutSessionPaymentMethodOptionsPaypalOptions`
  * Add support for `Reference` on `CheckoutSessionPaymentMethodOptionsPaypalOptions`, `OrderPaymentSettingsPaymentMethodOptionsPaypalOptions`, `OrderPaymentSettingsPaymentMethodOptionsPaypal`, `PaymentIntentPaymentMethodOptionsPaypalOptions`, and `PaymentIntentPaymentMethodOptionsPaypal`
  * Add support for `RiskCorrelationId` on `CheckoutSessionPaymentMethodOptionsPaypalOptions`, `OrderPaymentSettingsPaymentMethodOptionsPaypalOptions`, and `PaymentIntentPaymentMethodOptionsPaypalOptions`
  * Remove support for `BillingAgreementId` and `Currency` on `CheckoutSessionPaymentMethodOptionsPaypalOptions`
  * Add support for `Fingerprint`, `PayerId`, and `VerifiedEmail` on `MandatePaymentMethodDetailsPaypal` and `PaymentMethodPaypal`
  * Add support for `TaxabilityReason` and `TaxableAmount` on `OrderShippingCostTaxes`, `OrderTotalDetailsBreakdownTaxes`, and `QuotePhaseTotalDetailsBreakdownTaxes`
  * Add support for `HeadOffice` on `TaxSettingsUpdateOptions` and `TaxSettings`

## 41.16.0 - 2023-05-11
* [#2692](https://github.com/stripe/stripe-dotnet/pull/2692) Update generated code
  * Add support for `Paypal` on `ChargePaymentMethodDetails`, `Checkout.SessionPaymentMethodOptionsOptions`, `MandatePaymentMethodDetails`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, `SetupAttemptPaymentMethodDetails`, `SetupIntentPaymentMethodDataOptions`, `SetupIntentPaymentMethodOptionsOptions`, and `SetupIntentPaymentMethodOptions`
  * Add support for `NetworkToken` on `ChargePaymentMethodDetailsCard`
  * Add support for `TaxabilityReason` and `TaxableAmount` on `Checkout.SessionShippingCostTaxes`, `Checkout.SessionTotalDetailsBreakdownTaxes`, `CreditNoteShippingCostTaxes`, `CreditNoteTaxAmounts`, `InvoiceShippingCostTaxes`, `InvoiceTotalTaxAmounts`, `LineItemTaxes`, `QuoteComputedRecurringTotalDetailsBreakdownTaxes`, `QuoteComputedUpfrontTotalDetailsBreakdownTaxes`, and `QuoteTotalDetailsBreakdownTaxes`
  * Add support for `Brand`, `CardholderName`, `Country`, `ExpMonth`, `ExpYear`, `Fingerprint`, `Funding`, `Last4`, `Networks`, and `ReadMethod` on `PaymentMethodCardPresent` and `PaymentMethodInteracPresent`
  * Add support for `PreferredLocales` on `PaymentMethodInteracPresent`
  * Add support for `EffectivePercentage` on `TaxRate`
  * Add support for `GbBankTransfer ` and `JpBankTransfer ` on `CustomerCashBalanceTransactionFundedBankTransfer`

## 41.16.0-beta.1 - 2023-05-04
* [#2686](https://github.com/stripe/stripe-dotnet/pull/2686) Update generated code for beta
  * Updated stable APIs to the latest version

## 41.15.0 - 2023-05-04
* [#2687](https://github.com/stripe/stripe-dotnet/pull/2687) Update generated code
  * Add support for `Link` on `Checkout.SessionPaymentMethodOptionsOptions` and `Checkout.SessionPaymentMethodOptions`
  * Add support for `Brand`, `Country`, `Description`, `ExpMonth`, `ExpYear`, `Fingerprint`, `Funding`, `Iin`, `Issuer`, `Last4`, `Network`, and `Wallet` on `SetupAttemptPaymentMethodDetailsCard`

## 41.15.0-beta.1 - 2023-04-27
* [#2683](https://github.com/stripe/stripe-dotnet/pull/2683) Update generated code for beta
  * Add support for `BillingCycleAnchor` and `ProrationBehavior` on `CheckoutSessionSubscriptionDataOptions`
  * Add support for `TerminalId` on `IssuingAuthorizationMerchantData` and `IssuingTransactionMerchantData`
  * Add support for `Metadata` on `PaymentIntentCaptureOptions`
  * Add support for `Checks` on `SetupAttemptPaymentMethodDetailsCard`
  * Add support for `TaxBreakdown` on `TaxCalculationShippingCost` and `TaxTransactionShippingCost`
  * Change type of `TaxRegistrationActiveFromOptions` and `TaxRegistrationExpiresAtOptions` from `longInteger` to `longInteger | literal('now')`

## 41.14.0 - 2023-04-27
* [#2682](https://github.com/stripe/stripe-dotnet/pull/2682) Update generated code
  * Add support for `BillingCycleAnchor` and `ProrationBehavior` on `Checkout.SessionSubscriptionDataOptions`
  * Add support for `TerminalId` on `Issuing.AuthorizationMerchantData` and `Issuing.TransactionMerchantData`
  * Add support for `Metadata` on `PaymentIntentCaptureOptions`
  * Add support for `Checks` on `SetupAttemptPaymentMethodDetailsCard`
  * Add support for `TaxBreakdown` on `Tax.CalculationShippingCost` and `Tax.TransactionShippingCost`
* [#2685](https://github.com/stripe/stripe-dotnet/pull/2685) Fix incorrect ApiKey snippet in README
* [#2679](https://github.com/stripe/stripe-dotnet/pull/2679) Update generated code
* [#2676](https://github.com/stripe/stripe-dotnet/pull/2676) Update generated code
* [#2673](https://github.com/stripe/stripe-dotnet/pull/2673) Added Events.CustomerSubscriptionPaused/Resumed.

## 41.14.0-beta.3 - 2023-04-20
* [#2680](https://github.com/stripe/stripe-dotnet/pull/2680) Update generated code for beta
  * Add support for `Zip` on `PaymentIntentPaymentMethodOptionsOptions` and `PaymentIntentPaymentMethodOptions`
  * Add support for `CountryOptions` on `TaxRegistrationCreateOptions` and `TaxRegistration`
  * Remove support for `State` and `Type` on `TaxRegistrationCreateOptions` and `TaxRegistration`

## 41.14.0-beta.2 - 2023-04-13
* [#2675](https://github.com/stripe/stripe-dotnet/pull/2675) Update generated code for beta
  * Add support for `CollectPaymentMethod` and `ConfirmPaymentIntent` methods on resource `Terminal.Reader`
  * Add support for `PaypalPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
  * Add support for `CollectPaymentMethod` and `ConfirmPaymentIntent` on `TerminalReaderAction`
  * Add support for `StripeAccount` on `TerminalReaderActionProcessPaymentIntent` and `TerminalReaderActionRefundPayment`

## 41.14.0-beta.1 - 2023-04-06
* [#2671](https://github.com/stripe/stripe-dotnet/pull/2671) Update generated code for beta
  * Add support for `TreasuryTransaction` on `CapitalFinancingTransactionListOptions`
  * Add support for `Transaction` on `CapitalFinancingTransactionDetails`

## 41.13.0 - 2023-04-06
* [#2672](https://github.com/stripe/stripe-dotnet/pull/2672) Update generated code
  * Add support for `Country` on `PaymentMethodLink`
  * Add support for `StatusDetails` on `PaymentMethodUsBankAccount`

## 41.13.0-beta.1 - 2023-03-30
* [#2670](https://github.com/stripe/stripe-dotnet/pull/2670) Update generated code for beta

## 41.12.0 - 2023-03-30
* [#2667](https://github.com/stripe/stripe-dotnet/pull/2667) Update generated code
  * Remove support for `Create` method on resource `Tax.Transaction`
    * This is not a breaking change, as this method was deprecated before the Tax Transactions API was released in favor of the `CreateFromCalculation ` method.
  * Add support for `ExportLicenseId` and `ExportPurposeCode` on `AccountCompanyOptions`, `AccountCompany`, and `TokenAccountCompanyOptions`
  * Add support for `AmountTip` on `TestHelpersTerminal.ReaderPresentPaymentMethodOptions`
* [#2669](https://github.com/stripe/stripe-dotnet/pull/2669) Update .gitattributes

## 41.12.0-beta.1 - 2023-03-23
* [#2662](https://github.com/stripe/stripe-dotnet/pull/2662) Update generated code for beta (new)
  * Add support for new resources `Tax.CalculationLineItem` and `Tax.TransactionLineItem`
  * Add support for `CollectInputs` method on resource `Terminal.Reader`
  * Add support for `FinancingOffer` on `CapitalFinancingSummary`
  * Add support for `FxRate` on `CheckoutSessionCurrencyConversion`
  * Add support for `AutomaticPaymentMethods` on `SetupIntentCreateOptions` and `SetupIntent`
  * Remove support for `Preview` on `TaxCalculationCreateOptions`
  * Change type of `TaxCalculationLineItems` from `$LineItem` to `$Tax.CalculationLineItem`
  * Change type of `TaxTransactionLineItems` from `$LineItem` to `$Tax.TransactionLineItem`
  * Add support for `CollectInputs` on `TerminalReaderAction`

## 41.11.0 - 2023-03-23
* [#2661](https://github.com/stripe/stripe-dotnet/pull/2661) Update generated code
  * Add support for new resources `Tax.CalculationLineItem`, `Tax.Calculation`, `Tax.TransactionLineItem`, and `Tax.Transaction`
  * Add support for `Create` and `ListLineItems` methods on resource `Calculation`
  * Add support for `CreateFromCalculation`, `CreateReversal`, `Create`, `Get`, and `ListLineItems` methods on resource `Transaction`
  * Add support for `CurrencyConversion` on `Checkout.Session`
  * Add support for `AutomaticPaymentMethods` on `SetupIntentCreateOptions` and `SetupIntent`

## 41.11.0-beta.1 - 2023-03-16
* [#2658](https://github.com/stripe/stripe-dotnet/pull/2658) API Updates
  * Add support for `CreateFromCalculation` method on resource `Tax.Transaction`
  * Add support for `Paypal` on `MandatePaymentMethodDetails`, `SetupAttemptPaymentMethodDetails`, `SetupIntentPaymentMethodOptionsOptions`, and `SetupIntentPaymentMethodOptions`
  * Add support for `SetupFutureUsage` on `OrderPaymentSettingsPaymentMethodOptionsPaypalOptions`, `OrderPaymentSettingsPaymentMethodOptionsPaypal`, `PaymentIntentPaymentMethodOptionsPaypalOptions`, and `PaymentIntentPaymentMethodOptionsPaypal`
  * Remove support for `AppliesTo` on `QuotePreviewInvoiceLinesOptions`
  * Add support for `ShippingCost` on `TaxCalculationCreateOptions`, `TaxCalculation`, `TaxTransactionCreateReversalOptions`, and `TaxTransaction`
  * Add support for `TaxBreakdown` on `TaxCalculation`
  * Remove support for `TaxSummary` on `TaxCalculation`

## 41.10.0 - 2023-03-16
* [#2659](https://github.com/stripe/stripe-dotnet/pull/2659) API Updates
  * Add support for `CashappPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
  * Add support for `FutureRequirements` and `Requirements` on `BankAccount`
  * Add support for `Cashapp` on `ChargePaymentMethodDetails`, `Checkout.SessionPaymentMethodOptionsOptions`, `Checkout.SessionPaymentMethodOptions`, `MandatePaymentMethodDetails`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethodUpdateOptions`, `PaymentMethod`, `SetupAttemptPaymentMethodDetails`, and `SetupIntentPaymentMethodDataOptions`
  * Add support for `Country` on `ChargePaymentMethodDetailsLink`
  * Add support for `PreferredLocale` on `PaymentIntentPaymentMethodOptionsAffirmOptions` and `PaymentIntentPaymentMethodOptionsAffirm`
  * Add support for `CashappHandleRedirectOrDisplayQrCode` on `PaymentIntentNextAction` and `SetupIntentNextAction`

* [#2657](https://github.com/stripe/stripe-dotnet/pull/2657) Update generated code (new)
  * Add support for `CashappPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
  * Add support for `Cashapp` on `ChargePaymentMethodDetails`, `Checkout.SessionPaymentMethodOptionsOptions`, `Checkout.SessionPaymentMethodOptions`, `MandatePaymentMethodDetails`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethodUpdateOptions`, `PaymentMethod`, `SetupAttemptPaymentMethodDetails`, and `SetupIntentPaymentMethodDataOptions`
  * Add support for `PreferredLocale` on `PaymentIntentPaymentMethodOptionsAffirmOptions` and `PaymentIntentPaymentMethodOptionsAffirm`
  * Add support for `CashappHandleRedirectOrDisplayQrCode` on `PaymentIntentNextAction` and `SetupIntentNextAction`

## 41.10.0-beta.1 - 2023-03-09
* [#2655](https://github.com/stripe/stripe-dotnet/pull/2655) API Updates for beta branch
  * Updated stable APIs to the latest version
  * Remove support for `ListTransactions` method on resource `Tax.Transaction`
  * Add support for `UpdateBehavior` on `SubscriptionPrebillingOptions`, `SubscriptionPrebilling`, `SubscriptionSchedulePrebillingOptions`, and `SubscriptionSchedulePrebilling`
  * Add support for `Prebilling` on `SubscriptionScheduleAmendOptions`
  * Add support for `TaxabilityOverride` on `TaxCalculationCustomerDetailsOptions`, `TaxCalculationCustomerDetails`, and `TaxTransactionCustomerDetails`
  * Add support for `TaxSummary` on `TaxCalculation`
  * Remove support for `TaxBreakdown` on `TaxCalculation`
  * Add support for `TaxBehavior` on `TaxSettingsDefaultsOptions` and `TaxSettingsDefaults`

## 41.9.0 - 2023-03-09
* [#2654](https://github.com/stripe/stripe-dotnet/pull/2654) API Updates
  * Add support for `CardIssuing` on `Issuing.CardholderIndividualOptions`
  * Add support for `CancellationDetails` on `SubscriptionCancelOptions`, `SubscriptionUpdateOptions`, and `Subscription`
* [#2652](https://github.com/stripe/stripe-dotnet/pull/2652) Improve webhook error

## 41.9.0-beta.1 - 2023-03-02
* [#2653](https://github.com/stripe/stripe-dotnet/pull/2653) API Updates for beta branch
  * Updated stable APIs to the latest version
  * Add support for new resources `Issuing.CardBundle` and `Issuing.CardDesign`
  * Add support for `Get` and `List` methods on resource `CardBundle`
  * Add support for `Get`, `List`, and `Update` methods on resource `CardDesign`
  * Remove support for `Controller` on `AccountUpdateOptions`
  * Add support for `CardDesign` on `IssuingCardCreateOptions` and `IssuingCard`

## 41.8.0 - 2023-03-02
* [#2651](https://github.com/stripe/stripe-dotnet/pull/2651) API Updates
  * Add support for `ReconciliationStatus` on `Payout`
* [#2648](https://github.com/stripe/stripe-dotnet/pull/2648) API Updates

## 41.8.0-beta.2 - 2023-02-23
* [#2649](https://github.com/stripe/stripe-dotnet/pull/2649) API Updates for beta branch
  * Updated stable APIs to the latest version
  * Add support for `ManualEntry` on `CheckoutSessionPaymentMethodOptionsUsBankAccountFinancialConnections`, `PaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsOptions`, `PaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnections`, `SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsOptions`, and `SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnections`

## 41.8.0-beta.1 - 2023-02-16
* [#2647](https://github.com/stripe/stripe-dotnet/pull/2647) API Updates for beta branch
  * Updated stable APIs to the latest version
  * Add support for `CurrencyConversion` on `CheckoutSession`
  * Add support for `Limits` on `FinancialConnectionsSessionCreateOptions` and `FinancialConnectionsSession`
  * Remove support for `Enabled` on `FinancialConnectionsSessionManualEntryOptions`
  * Remove support for `Reference` on `TaxCalculationCreateOptions` and `TaxCalculation`
  * Add support for `Reference` on `TaxTransactionCreateOptions`

## 41.7.0 - 2023-02-16
* [#2643](https://github.com/stripe/stripe-dotnet/pull/2643) API Updates
  * Add support for `RefundPayment` method on resource `Terminal.Reader`
  * Add support for `CustomFields` on `Checkout.SessionCreateOptions`, `Checkout.Session`, `PaymentLinkCreateOptions`, `PaymentLinkUpdateOptions`, and `PaymentLink`
  * Add support for `InteracPresent` on `TestHelpersTerminal.ReaderPresentPaymentMethodOptions`
  * Change type of `Terminal.ReaderTypeOptions` from `literal('card_present')` to `enum('card_present'|'interac_present')`
  * Add support for `RefundPayment` on `Terminal.ReaderAction`
  * Update `ShippingAddress` on `SessionCustomTextOptions` and `PaymentLinkCustomTextOptions` to use `SessionCustomTextShippingAddressOptions` and `PaymentLinkCustomTextShippingAddressOptions` instead of shared `AddressOptions`. This did not work before and did not align with the API definitions (extension of https://github.com/stripe/stripe-dotnet/pull/2644).
* [#2646](https://github.com/stripe/stripe-dotnet/pull/2646) Add missing parameters to the Upcoming Invoice API

## 41.7.0-beta.1 - 2023-02-02
* [#2642](https://github.com/stripe/stripe-dotnet/pull/2642) API Updates for beta branch
  * Updated stable APIs to the latest version
  * Add support for new resource `FinancialConnections.Transaction`
  * Add support for `List` method on resource `Transaction`
  * Add support for `Prefetch` on `-PaymentMethodOptionsUsBankAccountFinancialConnections`, and `-PaymentMethodOptionsUsBankAccountFinancialConnectionsOptions` across several APIs.
  * Add support for `InferredBalancesRefresh`, `Subscriptions`, and `TransactionRefresh` on `FinancialConnectionsAccount`
  * Add support for `ManualEntry` on `FinancialConnectionsSessionCreateOptions` and `FinancialConnectionsSession`
  * Add support for `StatusDetails` and `Status` on `FinancialConnectionsSession`
  * Add support for `AccountNumber` on `PaymentMethodUsBankAccount`
  * Remove support for `Id` on `QuoteLinesStartsAtLineEndsAtOptions`

## 41.6.0 - 2023-02-02
* [#2640](https://github.com/stripe/stripe-dotnet/pull/2640) API Updates
  * Add support for `Resume` method on resource `Subscription`
  * Add support for `PaymentLink` on `Checkout.SessionListOptions`
  * Add support for `TrialSettings` on `Checkout.SessionSubscriptionDataOptions`, `SubscriptionCreateOptions`, `SubscriptionUpdateOptions`, and `Subscription`
  * Add support for `ShippingCost` on `CreditNoteCreateOptions`, `CreditNotePreviewLinesOptions`, `CreditNotePreviewOptions`, `CreditNote`, `InvoiceCreateOptions`, `InvoiceUpdateOptions`, and `Invoice`
  * Add support for `AmountShipping` on `CreditNote` and `Invoice`
  * Add support for `ShippingDetails` on `InvoiceCreateOptions`, `InvoiceUpdateOptions`, and `Invoice`
  * Add support for `SubscriptionResumeAt` on `InvoiceUpcomingLinesOptions` and `InvoiceUpcomingOptions`
  * Add support for `InvoiceCreation` on `PaymentLinkCreateOptions`, `PaymentLinkUpdateOptions`, and `PaymentLink`

## 41.6.0-beta.2 - 2023-01-26
* [#2638](https://github.com/stripe/stripe-dotnet/pull/2638) API Updates for beta branch
  * Updated stable APIs to the latest version
  * Add support for `ListTransactions` method on resource `Tax.Transaction`
  * Add support for `BillingAgreementId` on `CheckoutSessionPaymentMethodOptionsPaypalOptions`
  * Change type of `QuoteSubscriptionDataOverridesOptions` from `array(create_specs)` to `emptyStringable(array(update_specs))`

## 41.6.0-beta.1 - 2023-01-19
* [#2635](https://github.com/stripe/stripe-dotnet/pull/2635) API Updates for beta branch
  * Updated stable APIs to the latest version
  * Add support for `Tax.Settings` resource.

## 41.5.0 - 2023-01-19
* [#2633](https://github.com/stripe/stripe-dotnet/pull/2633) API Updates
  * Add support for `VerificationSession` on `EphemeralKeyCreateOptions`
* [#2622](https://github.com/stripe/stripe-dotnet/pull/2622) Fix missing IDisposable using

## 41.5.0-beta.2 - 2023-01-12
* [#2632](https://github.com/stripe/stripe-dotnet/pull/2632) API Updates for beta branch
  * Updated stable APIs to the latest version
  * Add support for new resource `Tax.Registration`
  * Add support for `Create`, `List`, and `Update` methods on resource `Registration`
  * Add support for `Controller` on `AccountCreateOptions` and `AccountUpdateOptions`
  * Add support for `Application` and `Dashboard` on `AccountController`
  * Remove support for `Timestamp` on `QuoteLineActionsAddDiscountDiscountEnd`
  * Change type of `QuoteLineActionsAddDiscountDiscountEndType` from `literal('timestamp')` to `literal('line_ends_at')`
  * Remove support for `Index` on `QuoteLineActionsAddItemDiscounts`, `QuoteLineActionsRemoveDiscount`, `QuoteLineActionsSetDiscounts`, `QuoteLineActionsSetItemsDiscounts`, `SubscriptionSchedulePhasesAddInvoiceItemsDiscounts`, `SubscriptionSchedulePhasesDiscounts`, and `SubscriptionSchedulePhasesItemsDiscounts`

## 41.5.0-beta.1 - 2023-01-05
* [#2630](https://github.com/stripe/stripe-dotnet/pull/2630) API Updates for beta branch
  * Updated stable APIs to the latest version
  * Add support for `MarkStaleQuote` method on resource `Quote`
  * Add support for `Duration` and `LineEndsAt` on `QuoteSubscriptionDataBillOnAcceptanceBillUntilOptions` and `QuoteSubscriptionDataOverridesBillOnAcceptanceBillUntilOptions`
  * Remove support for `LineStartsAt` on `QuoteSubscriptionDataBillOnAcceptanceBillUntilOptions` and `QuoteSubscriptionDataOverridesBillOnAcceptanceBillUntilOptions`
  * Add support for `Metadata` on `TerminalReaderActionRefundPayment` and `TerminalReaderRefundPaymentOptions`

## 41.4.0 - 2023-01-05
* [#2629](https://github.com/stripe/stripe-dotnet/pull/2629) API Updates
  * Add support for `CardIssuing` on `Issuing.CardholderIndividual`

## 41.4.0-beta.1 - 2022-12-22
* [#2627](https://github.com/stripe/stripe-dotnet/pull/2627) API Updates for beta branch
  * Updated stable APIs to the latest version
  * Move `Stripe.TaxTransaction` and `Stripe.TaxCalculation` to `Stripe.Tax.Transaction` and `Stripe.Tax.Calculation`.

## 41.3.0 - 2022-12-22
* [#2626](https://github.com/stripe/stripe-dotnet/pull/2626) API Updates
  * Add support for `UsingMerchantDefault` on `CashBalanceSettings`
* [#2625](https://github.com/stripe/stripe-dotnet/pull/2625) Stop `FileService` from mutating its `RequestOptions` argument

## 41.3.0-beta.2 - 2022-12-15
* [#2621](https://github.com/stripe/stripe-dotnet/pull/2621) API Updates for beta branch
  * Updated stable APIs to the latest version
  * Add support for new resources `QuoteLine`, `TaxCalculation`, and `TaxTransaction`
  * Add support for `Create` and `ListLineItems` methods on resource `TaxCalculation`
  * Add support for `CreateReversal`, `Create`, and `Get` methods on resource `TaxTransaction`

## 41.3.0-beta.1 - 2022-12-08
* [#2618](https://github.com/stripe/stripe-dotnet/pull/2618) API Updates for beta branch
  * Updated stable APIs to the latest version
* [#2615](https://github.com/stripe/stripe-dotnet/pull/2615) API Updates for beta branch
  * Updated stable APIs to the latest version

## 41.2.0 - 2022-12-06
* [#2614](https://github.com/stripe/stripe-dotnet/pull/2614) API Updates
  * Add support for `FlowData` on `BillingPortal.SessionCreateOptions`
  * Add support for `Flow` on `BillingPortal.Session`
* [#2613](https://github.com/stripe/stripe-dotnet/pull/2613) API Updates
  * Add support for `IndiaInternationalPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
  * Add support for `InvoiceCreation` on `Checkout.SessionCreateOptions` and `Checkout.Session`
  * Add support for `Invoice` on `Checkout.Session`
  * Add support for `Metadata` on `SubscriptionSchedulePhasesItemsOptions` and `SubscriptionSchedulePhasesItems`

## 41.1.0 - 2022-11-17
* [#2610](https://github.com/stripe/stripe-dotnet/pull/2610) API Updates
  * Add support for `HostedInstructionsUrl` on `PaymentIntentNextActionWechatPayDisplayQrCode`
* [#2609](https://github.com/stripe/stripe-dotnet/pull/2609) API Updates
  * Add support for `CustomText` on `Checkout.SessionCreateOptions`, `Checkout.Session`, `PaymentLinkCreateOptions`, `PaymentLinkUpdateOptions`, and `PaymentLink`
  * Add support for `HostedInstructionsUrl` on `PaymentIntentNextActionPaynowDisplayQrCode`

## 41.0.0 - 2022-11-16

Breaking changes that arose during code generation of the library that we postponed for the next major version. For changes to the Stripe products, read more at https://docs.stripe.com/changelog/2022-11-15.

"⚠️" symbol highlights breaking changes.

⚠️ Removed
- Removed deprecated `Sku` resource (#2588)
- Removed `LineItem.Product` property that was released by mistake. (#2587)
- Removed deprecated `SessionSubscriptionDataOptions.Items` property. (#2587)
- Removed deprecated `Amount`, `Currency`, `Description`, `Images`, `Name` properties from `SessionLineItemOptions` (https://github.com/stripe/stripe-dotnet/pull/2604)
- Removed `Charges` field on `PaymentIntent` and replace it with `LatestCharge`. (https://github.com/stripe/stripe-dotnet/pull/2604)
- Removed unused `SessionDisplayItem` class. (#2588)
- Removed unused `SessionDisplayItemCustom` class. (#2588)
- Remove support for `TosShownAndAccepted` on `Checkout.SessionPaymentMethodOptionsPaynowOptions`. The property was mistakenly released and never worked. (#2605)

⚠️ Changed
- `IncrementalAuthorizationSupported` and `OvercaptureSupported` become non-nullable in `ChargePaymentMethodDetailsCardPresent`.

## 40.17.0-beta.1 - 2022-11-10
* [#2606](https://github.com/stripe/stripe-dotnet/pull/2606) API Updates for beta branch
  * Updated stable APIs to the latest version
  * Add support for `Url` on `AuthorizationMerchantData`.
  * Add support for  `DiscountEnd` on `*DiscountOptions`.

## 40.16.0 - 2022-11-08
* [#2602](https://github.com/stripe/stripe-dotnet/pull/2602) API Updates
  * Add support for `ReasonMessage` on `Issuing.AuthorizationRequestHistory`
* [#2598](https://github.com/stripe/stripe-dotnet/pull/2598) Next major release changes
* [#2599](https://github.com/stripe/stripe-dotnet/pull/2599) Merge master and update generated code

## 40.15.0 - 2022-11-03
* [#2596](https://github.com/stripe/stripe-dotnet/pull/2596) API Updates
  * Add support for `OnBehalfOf` on `Checkout.SessionSubscriptionDataOptions`, `SubscriptionCreateOptions`, `SubscriptionScheduleDefaultSettingsOptions`, `SubscriptionScheduleDefaultSettings`, `SubscriptionSchedulePhasesOptions`, `SubscriptionSchedulePhases`, `SubscriptionUpdateOptions`, and `Subscription`
  * Add support for `TaxBehavior` and `TaxCode` on `InvoiceInvoiceItemsOptions`, `InvoiceItemCreateOptions`, and `InvoiceItemUpdateOptions`

## 40.15.0-beta.2 - 2022-11-02
* [#2597](https://github.com/stripe/stripe-dotnet/pull/2597) API Updates for beta branch
  * Updated stable APIs to the latest version
  * Add support for `cashappPayments` and `zipPayments` on `Account`.
  * Add support for `cashapp` and `zip` on `Charge`, `PaymentMethod`.
  * Add support for `trialSettings` on `SubscriptionSchedule`.

## 40.15.0-beta.1 - 2022-10-21
* [#2593](https://github.com/stripe/stripe-dotnet/pull/2593) API Updates for beta branch
  * Updated stable APIs to the latest version
  * Add support for `Paypal` on `ChargePaymentMethodDetails` and `Source`
  * Add support for `NetworkData` on `IssuingTransaction`
  * Add support for `BillingCycleAnchor` on `SubscriptionScheduleAmendmentsOptions`

## 40.14.0 - 2022-10-20
* [#2591](https://github.com/stripe/stripe-dotnet/pull/2591) API Updates
  * Add support for `Tipping` on `Terminal.ReaderActionProcessPaymentIntentProcessConfig` and `Terminal.ReaderProcessConfigOptions`

## 40.14.0-beta.1 - 2022-10-14
* [#2590](https://github.com/stripe/stripe-dotnet/pull/2590) API Updates for beta branch
  * Updated stable APIs to the latest version
  * Add support for `ScheduleSettings` on `SubscriptionScheduleAmendOptions`

## 40.13.0 - 2022-10-13
* [#2589](https://github.com/stripe/stripe-dotnet/pull/2589) API Updates
  * Add support for `NetworkData` on `Issuing.Authorization`
* [#2586](https://github.com/stripe/stripe-dotnet/pull/2586) Add request_log_url on StripeError

## 40.13.0-beta.1 - 2022-10-07
* [#2585](https://github.com/stripe/stripe-dotnet/pull/2585) API Updates for beta branch
  * Updated stable APIs to the latest version

## 40.12.0 - 2022-10-06
* [#2584](https://github.com/stripe/stripe-dotnet/pull/2584) API Updates
  * Add support for `Klarna` on `SetupAttemptPaymentMethodDetails`

## 40.12.0-beta.2 - 2022-10-04
* Updated stable APIs to the latest version

## 40.12.0-beta.1 - 2022-10-04
* [#2583](https://github.com/stripe/stripe-dotnet/pull/2583) API Updates for beta branch
  * Updated stable APIs to the latest version
  * Added `ReferenceId` to `PaymentIntentPaymentMethodOptionsPaypalOptions`

## 40.11.0 - 2022-09-29
* [#2580](https://github.com/stripe/stripe-dotnet/pull/2580) API Updates
  * Change type of `ChargePaymentMethodDetailsCardPresentIncrementalAuthorizationSupported` and `ChargePaymentMethodDetailsCardPresentOvercaptureSupported` from `nullable(boolean)` to `boolean`
  * Add support for `Created` on `Checkout.Session`
  * Add support for `SetupFutureUsage` on `PaymentIntentPaymentMethodOptionsPixOptions` and `PaymentIntentPaymentMethodOptionsPix`
  * Deprecate `SessionSubscriptionDataOptions.items` (use the `line_items` param instead). This will be removed in the next major version.

## 40.11.0-beta.1 - 2022-09-26
* [#2579](https://github.com/stripe/stripe-dotnet/pull/2579) API Updates for beta branch
  * Updated stable APIs to the latest version
  * Add `FinancingOffer`, `FinancingSummary` and `FinancingTransaction` resources.

## 40.10.0 - 2022-09-22
* [#2578](https://github.com/stripe/stripe-dotnet/pull/2578) API Updates
  * Add support for `TermsOfService` on `Checkout.SessionConsentCollectionOptions`, `Checkout.SessionConsentCollection`, `Checkout.SessionConsent`, `PaymentLinkConsentCollectionOptions`, and `PaymentLinkConsentCollection`
  * ⚠️  Remove support for `Plan` on `Checkout.SessionPaymentMethodOptionsCardInstallmentsOptions`. The property was mistakenly released and never worked.
  * Add support for `StatementDescriptor` on `PaymentIntentIncrementAuthorizationOptions`

## 40.9.0 - 2022-09-15
* [#2577](https://github.com/stripe/stripe-dotnet/pull/2577) API Updates
  * Add support for `Pix` on `ChargePaymentMethodDetails`, `Checkout.SessionPaymentMethodOptionsOptions`, `Checkout.SessionPaymentMethodOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
  * Add support for `FromInvoice` on `InvoiceCreateOptions` and `Invoice`
  * Add support for `LatestRevision` on `Invoice`
  * Add support for `Amount` on `Issuing.DisputeCreateOptions` and `Issuing.DisputeUpdateOptions`
  * Add support for `PixDisplayQrCode` on `PaymentIntentNextAction`
  * Add support for `Created` on `Treasury.CreditReversal` and `Treasury.DebitReversal`

## 40.8.0 - 2022-09-09
* [#2575](https://github.com/stripe/stripe-dotnet/pull/2575) API Updates
  * Add support for `RequireSignature` on `Issuing.CardShippingOptions` and `Issuing.CardShipping`

## 40.7.0 - 2022-09-06
* [#2574](https://github.com/stripe/stripe-dotnet/pull/2574) API Updates
  * Add support for new value `terminal_reader_splashscreen` on `FilePurpose`

## 40.6.0 - 2022-08-31
* [#2573](https://github.com/stripe/stripe-dotnet/pull/2573) API Updates
  * Add support for `Description` on `PaymentLinkSubscriptionDataOptions` and `PaymentLinkSubscriptionData`
* [#2570](https://github.com/stripe/stripe-dotnet/pull/2570) Update Coveralls command line arguments
* [#2569](https://github.com/stripe/stripe-dotnet/pull/2569) Add test coverage using Coveralls

## 40.5.0 - 2022-08-26
* [#2568](https://github.com/stripe/stripe-dotnet/pull/2568) API Updates
  * Add support for `LoginPage` on `BillingPortal.ConfigurationCreateOptions`, `BillingPortal.ConfigurationUpdateOptions`, and `BillingPortal.Configuration`
  * Add support for `Customs` and `PhoneNumber` on `Issuing.CardShippingOptions` and `Issuing.CardShipping`
  * Add support for `Description` on `QuoteSubscriptionDataOptions`, `QuoteSubscriptionData`, `SubscriptionScheduleDefaultSettingsOptions`, `SubscriptionScheduleDefaultSettings`, `SubscriptionSchedulePhasesOptions`, and `SubscriptionSchedulePhases`
* [#2565](https://github.com/stripe/stripe-dotnet/pull/2565) Update README.md to clarify that API version can only be change in beta

## 40.5.0-beta.1 - 2022-08-26
* [#2566](https://github.com/stripe/stripe-dotnet/pull/2566) API Updates for beta branch
  * Updated stable APIs to the latest version
  * Add support for the beta [Gift Card API](https://stripe.com/docs/gift-cards).

## 40.4.0 - 2022-08-23
* [#2562](https://github.com/stripe/stripe-dotnet/pull/2562) Add beta README.md section
* [#2564](https://github.com/stripe/stripe-dotnet/pull/2564) API Updates
  * Change the return type of `CustomerService.FundCashBalance` test helper from `CustomerBalanceTransaction` to `CustomerCashBalanceTransaction`.
    * This would generally be considered a breaking change, but we've worked with all existing users to migrate and are comfortable releasing this as a minor as it is solely a test helper method. This was essentially broken prior to this change.

## 40.4.0-beta.1 - 2022-08-23
* [#2563](https://github.com/stripe/stripe-dotnet/pull/2563) API Updates for beta branch
  - Updated stable APIs to the latest version
  - `Stripe-Version` beta headers are not pinned by-default and need to be manually specified, please refer to [beta SDKs README section](https://github.com/stripe/stripe-dotnet/blob/master/README.md#beta-sdks) 
* [#2561](https://github.com/stripe/stripe-dotnet/pull/2561) Make APIVersion configuration settable

## 40.3.0 - 2022-08-19
* [#2560](https://github.com/stripe/stripe-dotnet/pull/2560) API Updates
  * Add support for new resource `CustomerCashBalanceTransaction`
  * Add support for `Currency` on `PaymentLink`
  * Add support for `Network` on `SetupIntentPaymentMethodOptionsCardOptions`, `SubscriptionPaymentSettingsPaymentMethodOptionsCardOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptionsCard`
* [#2559](https://github.com/stripe/stripe-dotnet/pull/2559) Add a support section to the readme
* [#2558](https://github.com/stripe/stripe-dotnet/pull/2558) Update README.md

## 40.3.0-beta.1 - 2022-08-11
* [#2557](https://github.com/stripe/stripe-dotnet/pull/2557) API Updates for beta branch
  - Updated stable APIs to the latest version
  - Add RefundPayment method to Terminal resource

## 40.2.0 - 2022-08-11
* [#2556](https://github.com/stripe/stripe-dotnet/pull/2556) API Updates
  * Add support for `PaymentMethodCollection` on `Checkout.SessionCreateOptions`, `Checkout.Session`, `PaymentLinkCreateOptions`, `PaymentLinkUpdateOptions`, and `PaymentLink`

* [#2555](https://github.com/stripe/stripe-dotnet/pull/2555) Set MaxDepth for serialization and deserialization
* [#2554](https://github.com/stripe/stripe-dotnet/pull/2554) Add test for FileCreation from base64 in memory

## 40.1.0 - 2022-08-09
* [#2553](https://github.com/stripe/stripe-dotnet/pull/2553) API Updates
  * Add support for `ProcessConfig` on `Terminal.ReaderActionProcessPaymentIntent`
* [#2551](https://github.com/stripe/stripe-dotnet/pull/2551) API Updates
  * Add support for `ExpiresAt` on `Apps.SecretCreateOptions` and `Apps.Secret`

## 40.1.0-beta.1 - 2022-08-03
* [#2550](https://github.com/stripe/stripe-dotnet/pull/2550) API Updates for beta branch
  - Updated stable APIs to the latest version
  - Added the `Order` resource support

## 40.0.0 - 2022-08-02

Major version release for API version 2022-08-01. Default API version changed to "2022-08-01".

* Moving to use the new API version "2022-08-01". To learn more about these changes to Stripe products, see https://docs.stripe.com/changelog/2022-08-01
* Cleaning up the SDK to remove deprecated/unused APIs and rename classes/methods/properties to sync with product APIs. Read more detailed description at https://github.com/stripe/stripe-dotnet/wiki/Migration-guide-for-v40.

"⚠️" symbol highlights breaking changes.

* [#2549](https://github.com/stripe/stripe-dotnet/pull/2549) API Updates
* [#2547](https://github.com/stripe/stripe-dotnet/pull/2547) Next major release changes

## 39.126.0 - 2022-07-26
* [#2544](https://github.com/stripe/stripe-dotnet/pull/2544) API Updates
  * Add support for `CustomerBalance` on `Checkout.SessionPaymentMethodOptionsOptions` and `Checkout.SessionPaymentMethodOptions`

## 39.125.0 - 2022-07-25
* [#2543](https://github.com/stripe/stripe-dotnet/pull/2543) API Updates
  * Add support for `Installments` on `Checkout.SessionPaymentMethodOptionsCardOptions`, `Checkout.SessionPaymentMethodOptionsCard`, `InvoicePaymentSettingsPaymentMethodOptionsCardOptions`, and `InvoicePaymentSettingsPaymentMethodOptionsCard`
  * Add support for `DefaultCurrency` and `InvoiceCreditBalance` on `Customer`
  * Add support for `Currency` on `InvoiceCreateOptions`
  * Add support for `DefaultMandate` on `InvoicePaymentSettingsOptions` and `InvoicePaymentSettings`
  * Add support for `Mandate` on `InvoicePayOptions`

## 39.125.0-beta.1 - 2022-07-22
* [#2542](https://github.com/stripe/stripe-dotnet/pull/2542) API Updates for beta branch
  - Updated stable APIs to the latest version
* [#2540](https://github.com/stripe/stripe-dotnet/pull/2540) API Updates for beta branch
  - Updated stable APIs to the latest version
  - Add `QuotePhase` resource
* [#2536](https://github.com/stripe/stripe-dotnet/pull/2536) API Updates for beta branch
  - Updated stable APIs to the latest version
  - Add `Price.MigrateTo` property
  - Add `SubscriptionSchedule.Amend` method.
  - Add `Discount.SubscriptionItem` property.
  - Add `Quote.SubscriptionData.BillingBehavior`, `BillingCycleAnchor`, `EndBehavior`, `FromSchedule`, `FromSubscription`, `Prebilling`, `ProrationBehavior` properties.
  - Add `Phases` parameter to `Quote.Create`
  - Add `Subscription.Discounts`, `Prebilling` properties.

## 39.124.0 - 2022-07-18
* [#2534](https://github.com/stripe/stripe-dotnet/pull/2534) API Updates
  * Add support for `BlikPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
  * Add support for `Blik` on `ChargePaymentMethodDetails`, `MandatePaymentMethodDetails`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethodUpdateOptions`, `PaymentMethod`, `SetupAttemptPaymentMethodDetails`, `SetupIntentPaymentMethodDataOptions`, `SetupIntentPaymentMethodOptionsOptions`, and `SetupIntentPaymentMethodOptions`
  * Change type of `Checkout.SessionConsentCollectionPromotionsOptions`, `Checkout.SessionConsentCollectionPromotions`, `PaymentLinkConsentCollectionPromotionsOptions`, and `PaymentLinkConsentCollectionPromotions` from `literal('auto')` to `enum('auto'|'none')`

## 39.123.0 - 2022-07-12
* [#2530](https://github.com/stripe/stripe-dotnet/pull/2530) API Updates
  * Add support for `CustomerDetails` on `Checkout.SessionListOptions`

## 39.123.0-beta.1 - 2022-07-07
* [#2529](https://github.com/stripe/stripe-dotnet/pull/2529) API Updates for beta branch
  - Include `server_side_confirmation_beta=v1` beta
  - Add `secretKeyConfirmation` to `PaymentIntent`
* [#2525](https://github.com/stripe/stripe-dotnet/pull/2525) API Updates for beta branch
  - Updated stable APIs to the latest version

## 39.122.0 - 2022-07-07
* [#2528](https://github.com/stripe/stripe-dotnet/pull/2528) API Updates
  * Add support for `Currency` on `Checkout.SessionCreateOptions`, `InvoiceUpcomingLinesOptions`, `InvoiceUpcomingOptions`, `PaymentLinkCreateOptions`, `SubscriptionCreateOptions`, `SubscriptionSchedulePhasesOptions`, `SubscriptionSchedulePhases`, and `Subscription`
  * Add support for `CurrencyOptions` on `Checkout.SessionShippingOptionsShippingRateDataFixedAmountOptions`, `CouponCreateOptions`, `CouponUpdateOptions`, `Coupon`, `OrderShippingCostShippingRateDataFixedAmountOptions`, `PriceCreateOptions`, `PriceUpdateOptions`, `Price`, `ProductDefaultPriceDataOptions`, `PromotionCodeRestrictionsOptions`, `PromotionCodeRestrictions`, `ShippingRateFixedAmountOptions`, and `ShippingRateFixedAmount`
  * Add support for `Restrictions` on `PromotionCodeUpdateOptions`
  * Add support for `FixedAmount` and `TaxBehavior` on `ShippingRateUpdateOptions`
* [#2526](https://github.com/stripe/stripe-dotnet/pull/2526) API Updates
  * Add support for `Customer` on `Checkout.SessionListOptions` and `RefundCreateOptions`
  * Add support for `Currency` and `Origin` on `RefundCreateOptions`

## 39.121.0 - 2022-06-29
* [#2524](https://github.com/stripe/stripe-dotnet/pull/2524) API Updates
  * Add support for `DeliverCard`, `FailCard`, `ReturnCard`, and `ShipCard` test helper methods on resource `Issuing.Card`
  * Change type of `PaymentLinkPaymentMethodTypesOptions` and `PaymentLinkPaymentMethodTypes` from `literal('card')` to `enum`
  * Add support for `HostedRegulatoryReceiptUrl` on `Treasury.ReceivedCredit` and `Treasury.ReceivedDebit`

## 39.120.0 - 2022-06-23
* [#2518](https://github.com/stripe/stripe-dotnet/pull/2518) API Updates
  * Add support for `CaptureMethod` on `PaymentIntentConfirmOptions` and `PaymentIntentUpdateOptions`
* [#2513](https://github.com/stripe/stripe-dotnet/pull/2513) API Updates
  * Add support for `PromptpayPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
  * Add support for `Promptpay` on `ChargePaymentMethodDetails`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
  * Add support for `SubtotalExcludingTax` on `CreditNote` and `Invoice`
  * Add support for `AmountExcludingTax` and `UnitAmountExcludingTax` on `CreditNoteLineItem` and `InvoiceLineItem`
  * Add support for `RenderingOptions` on `InvoiceCreateOptions` and `InvoiceUpdateOptions`
  * Add support for `TotalExcludingTax` on `Invoice`
  * Add support for `AutomaticPaymentMethods` on `OrderPaymentSettings`
  * Add support for `PromptpayDisplayQrCode` on `PaymentIntentNextAction`
* [#2517](https://github.com/stripe/stripe-dotnet/pull/2517) Use the generated API version
* [#2516](https://github.com/stripe/stripe-dotnet/pull/2516) chore: Remove empty file.
* [#2509](https://github.com/stripe/stripe-dotnet/pull/2509) Document how to access unsupported parameters and properties

## 39.119.0 - 2022-06-17
* [#2508](https://github.com/stripe/stripe-dotnet/pull/2508) API Updates
  * Add support for `FundCashBalance` test helper method on resource `Customer`
  * Add support for `StatementDescriptorPrefixKana` and `StatementDescriptorPrefixKanji` on `AccountSettingsCardPaymentsOptions`, `AccountSettingsCardPayments`, and `AccountSettingsPayments`
  * Add support for `StatementDescriptorSuffixKana` and `StatementDescriptorSuffixKanji` on `Checkout.SessionPaymentMethodOptionsCardOptions`, `Checkout.SessionPaymentMethodOptionsCard`, `PaymentIntentPaymentMethodOptionsCardOptions`, and `PaymentIntentPaymentMethodOptionsCard`
  * Add support for `TotalExcludingTax` on `CreditNote`
  * Change type of `CustomerInvoiceSettingsRenderingOptionsOptions` from `rendering_options_param` to `emptyStringable(rendering_options_param)`
  * Add support for `RenderingOptions` on `CustomerInvoiceSettings` and `Invoice`
* [#2507](https://github.com/stripe/stripe-dotnet/pull/2507) Trigger workflows on beta branches
* [#2506](https://github.com/stripe/stripe-dotnet/pull/2506) Support updating pre-release versions

## 39.119.0-beta.1 - 2022-06-15
* [#2505](https://github.com/stripe/stripe-dotnet/pull/2505) API Updates
  Add support for NetworkDetails properties on ReceivedCredits/ReceivedDebits resources

## 39.118.0 - 2022-06-09
* [#2503](https://github.com/stripe/stripe-dotnet/pull/2503) API Updates
  * Add support for `Treasury` on `AccountSettingsOptions` and `AccountSettings`
  * Add support for `RenderingOptions` on `CustomerInvoiceSettingsOptions`
  * Add support for `EuBankTransfer` on `CustomerBankTransferOptions`, `InvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransferOptions`, `InvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransfer`, `OrderPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransferOptions`, `OrderPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransfer`, `PaymentIntentPaymentMethodOptionsCustomerBalanceBankTransferOptions`, `PaymentIntentPaymentMethodOptionsCustomerBalanceBankTransfer`, `SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransferOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransfer`
  * Change type of `CustomerBankTransferRequestedAddressTypesOptions` from `literal('zengin')` to `enum('iban'|'sort_code'|'spei'|'zengin')`
  * Change type of `CustomerBankTransferTypeOptions`, `OrderPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransferTypeOptions`, `OrderPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransferType`, `PaymentIntentNextActionDisplayBankTransferInstructionsType`, `PaymentIntentPaymentMethodOptionsCustomerBalanceBankTransferTypeOptions`, and `PaymentIntentPaymentMethodOptionsCustomerBalanceBankTransferType` from `literal('jp_bank_transfer')` to `enum('eu_bank_transfer'|'gb_bank_transfer'|'jp_bank_transfer'|'mx_bank_transfer')`
  * Add support for `Iban`, `SortCode`, and `Spei` on `FundingInstructionsBankTransferFinancialAddresses` and `PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddresses`
  * Change type of `OrderPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransferRequestedAddressTypesOptions`, `OrderPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransferRequestedAddressTypes`, `PaymentIntentPaymentMethodOptionsCustomerBalanceBankTransferRequestedAddressTypesOptions`, and `PaymentIntentPaymentMethodOptionsCustomerBalanceBankTransferRequestedAddressTypes` from `literal('zengin')` to `enum`
  * Add support for `CustomUnitAmount` on `PriceCreateOptions` and `Price`

## 39.117.0 - 2022-06-08
* [#2502](https://github.com/stripe/stripe-dotnet/pull/2502) API Updates
  * Add support for `Affirm`, `Bancontact`, `Card`, `Ideal`, `P24`, and `Sofort` on `Checkout.SessionPaymentMethodOptionsOptions` and `Checkout.SessionPaymentMethodOptions`
  * Add support for `AfterpayClearpay`, `AuBecsDebit`, `BacsDebit`, `Eps`, `Fpx`, `Giropay`, `Grabpay`, `Klarna`, `Paynow`, and `SepaDebit` on `Checkout.SessionPaymentMethodOptionsOptions`
  * Add support for `SetupFutureUsage` on `Checkout.SessionPaymentMethodOptionsAcssDebitOptions`, `Checkout.SessionPaymentMethodOptionsAcssDebit`, `Checkout.SessionPaymentMethodOptionsAfterpayClearpay`, `Checkout.SessionPaymentMethodOptionsAlipayOptions`, `Checkout.SessionPaymentMethodOptionsAlipay`, `Checkout.SessionPaymentMethodOptionsAuBecsDebit`, `Checkout.SessionPaymentMethodOptionsBacsDebit`, `Checkout.SessionPaymentMethodOptionsBoletoOptions`, `Checkout.SessionPaymentMethodOptionsBoleto`, `Checkout.SessionPaymentMethodOptionsEps`, `Checkout.SessionPaymentMethodOptionsFpx`, `Checkout.SessionPaymentMethodOptionsGiropay`, `Checkout.SessionPaymentMethodOptionsGrabpay`, `Checkout.SessionPaymentMethodOptionsKlarna`, `Checkout.SessionPaymentMethodOptionsKonbiniOptions`, `Checkout.SessionPaymentMethodOptionsKonbini`, `Checkout.SessionPaymentMethodOptionsOxxoOptions`, `Checkout.SessionPaymentMethodOptionsOxxo`, `Checkout.SessionPaymentMethodOptionsPaynow`, `Checkout.SessionPaymentMethodOptionsSepaDebit`, `Checkout.SessionPaymentMethodOptionsUsBankAccountOptions`, `Checkout.SessionPaymentMethodOptionsUsBankAccount`, and `Checkout.SessionPaymentMethodOptionsWechatPayOptions`
  * Add support for `AttachToSelf` on `SetupAttempt`, `SetupIntentCreateOptions`, `SetupIntentListOptions`, and `SetupIntentUpdateOptions`
  * Add support for `FlowDirections` on `SetupAttempt`, `SetupIntentCreateOptions`, and `SetupIntentUpdateOptions`

## 39.116.0 - 2022-06-01
* [#2498](https://github.com/stripe/stripe-dotnet/pull/2498) API Updates
  * Add support for `RadarOptions` on `ChargeCreateOptions`, `Charge`, `PaymentIntentConfirmOptions`, `PaymentIntentCreateOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
  * Add support for `AccountHolderName`, `AccountNumber`, `AccountType`, `BankCode`, `BankName`, `BranchCode`, and `BranchName` on `FundingInstructionsBankTransferFinancialAddressesZengin` and `PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesZengin`
  * Change type of `OrderPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransferType` and `PaymentIntentPaymentMethodOptionsCustomerBalanceBankTransferType` from `enum` to `literal('jp_bank_transfer')`
  * Add support for `Network` on `SetupIntentPaymentMethodOptionsCard`

## 39.115.0 - 2022-05-26
* [#2494](https://github.com/stripe/stripe-dotnet/pull/2494) API Updates
  * Add support for `AffirmPayments` and `LinkPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
  * Add support for `IdNumberSecondary` on `AccountIndividualOptions`, `PersonCreateOptions`, `PersonUpdateOptions`, `TokenAccountIndividualOptions`, and `TokenPersonOptions`
  * Add support for `HostedInstructionsUrl` on `PaymentIntentNextActionDisplayBankTransferInstructions`
  * Add support for `IdNumberSecondaryProvided` on `Person`
  * Add support for `CardIssuing` on `Treasury.FinancialAccountFeaturesOptions` and `Treasury.FinancialAccountUpdateFeaturesOptions`

## 39.114.0 - 2022-05-23
* [#2492](https://github.com/stripe/stripe-dotnet/pull/2492) API Updates
  * Add support for `Treasury` on `AccountCapabilitiesOptions` and `AccountCapabilities`

## 39.113.0 - 2022-05-23
* [#2491](https://github.com/stripe/stripe-dotnet/pull/2491) API Updates
  * Add support for new resource `Apps.Secret`
  * Add support for `Affirm` on `ChargePaymentMethodDetails`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethodUpdateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
  * Add support for `Link` on `ChargePaymentMethodDetails`, `MandatePaymentMethodDetails`, `OrderPaymentSettingsPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethodUpdateOptions`, `PaymentMethod`, `SetupAttemptPaymentMethodDetails`, `SetupIntentPaymentMethodDataOptions`, `SetupIntentPaymentMethodOptionsOptions`, and `SetupIntentPaymentMethodOptions`
* [#2490](https://github.com/stripe/stripe-dotnet/pull/2490) Do not create a symbol package now that symbols are embedded

## 39.112.0 - 2022-05-19
* [#2489](https://github.com/stripe/stripe-dotnet/pull/2489) API Updates
  * Add support for new resources `Treasury.CreditReversal`, `Treasury.DebitReversal`, `Treasury.FinancialAccountFeatures`, `Treasury.FinancialAccount`, `Treasury.FlowDetails`, `Treasury.InboundTransfer`, `Treasury.OutboundPayment`, `Treasury.OutboundTransfer`, `Treasury.ReceivedCredit`, `Treasury.ReceivedDebit`, `Treasury.TransactionEntry`, and `Treasury.Transaction`
  * Add support for `RetrievePaymentMethod` method on resource `Customer`
  * Add support for `ListOwners` and `List` methods on resource `FinancialConnections.Account`
  * Change type of `BillingPortal.SessionReturnUrl` from `string` to `nullable(string)`
  * Add support for `AfterpayClearpay`, `AuBecsDebit`, `BacsDebit`, `Eps`, `Fpx`, `Giropay`, `Grabpay`, `Klarna`, `Paynow`, and `SepaDebit` on `Checkout.SessionPaymentMethodOptions`
  * Add support for `Treasury` on `Issuing.Authorization`, `Issuing.DisputeCreateOptions`, `Issuing.Dispute`, and `Issuing.Transaction`
  * Add support for `FinancialAccount` on `Issuing.CardCreateOptions` and `Issuing.Card`
  * Add support for `ClientSecret` on `Order`
  * Add support for `Networks` on `PaymentIntentPaymentMethodOptionsUsBankAccountOptions`, `PaymentMethodUsBankAccount`, and `SetupIntentPaymentMethodOptionsUsBankAccountOptions`
  * Add support for `AttachToSelf` and `FlowDirections` on `SetupIntent`
  * Add support for `SaveDefaultPaymentMethod` on `SubscriptionPaymentSettingsOptions` and `SubscriptionPaymentSettings`
  * Add support for `Czk` on `Terminal.ConfigurationTippingOptions` and `Terminal.ConfigurationTipping`
* [#2488](https://github.com/stripe/stripe-dotnet/pull/2488) Add Treasury webhook endpoints.
  * Add event constants `TreasuryCheckDepositCanceled`, `TreasuryCheckDepositCreated`, `TreasuryCheckDepositProcessing`, `TreasuryCheckDepositReceived`, `TreasuryCheckDepositRequiresAction`, `TreasuryCheckDepositRequiresConfirmation`, `TreasuryCheckDepositReversed`, `Treasury.CreditReversalCreated`, `Treasury.CreditReversalPosted`, `Treasury.DebitReversalCompleted`, `Treasury.DebitReversalCreated`, `Treasury.DebitReversalInitialCreditGranted`, `Treasury.FinancialAccountClosed`, `Treasury.FinancialAccountCreated`, `Treasury.FinancialAccountFeaturesStatusUpdated`, `Treasury.InboundTransferCanceled`, `Treasury.InboundTransferCreated`, `Treasury.InboundTransferFailed`, `Treasury.InboundTransferSucceeded`, `Treasury.OutboundPaymentCanceled`, `Treasury.OutboundPaymentCreated`, `Treasury.OutboundPaymentExpectedArrivalDateUpdated`, `Treasury.OutboundPaymentFailed`, `Treasury.OutboundPaymentPosted`, `Treasury.OutboundPaymentReturned`, `Treasury.OutboundTransferCanceled`, `Treasury.OutboundTransferCreated`, `Treasury.OutboundTransferExpectedArrivalDateUpdated`, `Treasury.OutboundTransferFailed`, `Treasury.OutboundTransferPosted`, `Treasury.OutboundTransferReturned`, `Treasury.ReceivedCreditCreated`, `Treasury.ReceivedCreditFailed`, `Treasury.ReceivedCreditReversed`, `Treasury.ReceivedCreditSucceeded`, and `Treasury.ReceivedDebitCreated`.
* [#2485](https://github.com/stripe/stripe-dotnet/pull/2485) Add search methods to InvoiceService
* [#2487](https://github.com/stripe/stripe-dotnet/pull/2487) Set CheckEolTargetFramework to false
* [#2486](https://github.com/stripe/stripe-dotnet/pull/2486) Revert dotnet format changes
* [#2484](https://github.com/stripe/stripe-dotnet/pull/2484) Enable embedded symbols

## 39.111.0 - 2022-05-11
* [#2480](https://github.com/stripe/stripe-dotnet/pull/2480) API Updates
  * Add support for `Description` on `Checkout.SessionSubscriptionDataOptions`, `SubscriptionCreateOptions`, `SubscriptionUpdateOptions`, and `Subscription`
  * Add support for `ConsentCollection`, `PaymentIntentData`, `ShippingOptions`, `SubmitType`, and `TaxIdCollection` on `PaymentLinkCreateOptions` and `PaymentLink`
  * Add support for `CustomerCreation` on `PaymentLinkCreateOptions`, `PaymentLinkUpdateOptions`, and `PaymentLink`
  * Add support for `Metadata` on `SubscriptionSchedulePhasesOptions` and `SubscriptionSchedulePhases`
* [#2478](https://github.com/stripe/stripe-dotnet/pull/2478) Make dotnet formatting faster
* [#2479](https://github.com/stripe/stripe-dotnet/pull/2479) API Updates

  * Add support for `AmountDiscount`, `AmountTax`, and `Product` on `LineItem`

## 39.110.0 - 2022-05-05
* [#2475](https://github.com/stripe/stripe-dotnet/pull/2475) API Updates
  * Add support for `DefaultPriceData` on `ProductCreateOptions`
  * Add support for `DefaultPrice` on `ProductUpdateOptions` and `Product`
  * Add support for `InstructionsEmail` on `RefundCreateOptions` and `Refund`

## 39.109.0 - 2022-05-05
* [#2474](https://github.com/stripe/stripe-dotnet/pull/2474) API Updates
  * Add support for new resources `FinancialConnections.AccountOwner`, `FinancialConnections.AccountOwnership`, `FinancialConnections.Account`, and `FinancialConnections.Session`
  * Add support for `FinancialConnections` on `Checkout.SessionPaymentMethodOptionsUsBankAccountOptions`, `Checkout.SessionPaymentMethodOptionsUsBankAccount`, `InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountOptions`, `InvoicePaymentSettingsPaymentMethodOptionsUsBankAccount`, `PaymentIntentPaymentMethodOptionsUsBankAccountOptions`, `PaymentIntentPaymentMethodOptionsUsBankAccount`, `SetupIntentPaymentMethodOptionsUsBankAccountOptions`, `SetupIntentPaymentMethodOptionsUsBankAccount`, `SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccount`
  * Add support for `FinancialConnections.Account` on `PaymentIntentPaymentMethodDataUsBankAccountOptions`, `PaymentMethodUsBankAccountOptions`, `PaymentMethodUsBankAccount`, and `SetupIntentPaymentMethodDataUsBankAccountOptions`

* [#2473](https://github.com/stripe/stripe-dotnet/pull/2473) API Updates
  * Add support for `RegisteredAddress` on `AccountIndividualOptions`, `PersonCreateOptions`, `PersonUpdateOptions`, `Person`, `TokenAccountIndividualOptions`, and `TokenPersonOptions`
  * Change type of `PaymentIntentAmountDetailsTipAmount` from `nullable(integer)` to `integer`
  * Add support for `PaymentMethodData` on `SetupIntentConfirmOptions`, `SetupIntentCreateOptions`, and `SetupIntentUpdateOptions`

## 39.108.0 - 2022-05-03
* [#2472](https://github.com/stripe/stripe-dotnet/pull/2472) API Updates
  * Add support for new resource `CashBalance`
  * Change type of `BillingPortal.ConfigurationApplication` from `$Application` to `deletable($Application)`
  * Add support for `Alipay` on `Checkout.SessionPaymentMethodOptionsOptions` and `Checkout.SessionPaymentMethodOptions`
  * Add support for `CashBalance` on `Customer`
  * Add support for `Application` on `Invoice`, `Quote`, `SubscriptionSchedule`, and `Subscription`

* [#2470](https://github.com/stripe/stripe-dotnet/pull/2470) Add missing payment links events
* [#2468](https://github.com/stripe/stripe-dotnet/pull/2468) Harden ValidateSignature against invalid input
* [#2467](https://github.com/stripe/stripe-dotnet/pull/2467) Cleanup .NET project files

## 39.107.0 - 2022-04-21
* [#2463](https://github.com/stripe/stripe-dotnet/pull/2463) API Updates
  * Add support for `Expire` test helper method on resource `Refund`

## 39.106.0 - 2022-04-20
* [#2455](https://github.com/stripe/stripe-dotnet/pull/2455) API Updates
  * Add support for new resources `FundingInstructions` and `Terminal.Configuration`
  * Add support for `CreateFundingInstructions` method on resource `Customer`
  * Add support for `CustomerBalance` on `ChargePaymentMethodDetails`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, and `PaymentMethod`
  * Add support for `CashBalance` on `CustomerCreateOptions` and `CustomerUpdateOptions`
  * Add support for `AmountDetails` on `PaymentIntent`
  * Add support for `DisplayBankTransferInstructions` on `PaymentIntentNextAction`
  * Add support for `ConfigurationOverrides` on `Terminal.LocationCreateOptions`, `Terminal.LocationUpdateOptions`, and `Terminal.Location`
* [#2459](https://github.com/stripe/stripe-dotnet/pull/2459) Auto-generate constant files for resource properties.

## 39.105.0 - 2022-04-13
* [#2453](https://github.com/stripe/stripe-dotnet/pull/2453) API Updates
  * Add support for `IncrementAuthorization` method on resource `PaymentIntent`
  * Add support for `IncrementalAuthorizationSupported` on `ChargePaymentMethodDetailsCardPresent`
  * Add support for `RequestIncrementalAuthorizationSupport` on `PaymentIntentPaymentMethodOptionsCardPresentOptions` and `PaymentIntentPaymentMethodOptionsCardPresent`

## 39.104.0 - 2022-04-08
* [#2450](https://github.com/stripe/stripe-dotnet/pull/2450) API Updates
  * Add support for `ApplyCustomerBalance` method on resource `PaymentIntent`
  * Add `cash_balance.funds_available` event constant.

## 39.103.0 - 2022-04-01
* [#2446](https://github.com/stripe/stripe-dotnet/pull/2446) API Updates
  * Add support for `BankTransferPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
  * Add support for `CaptureBefore` on `ChargePaymentMethodDetailsCardPresent`
  * Add support for `Address` and `Name` on `Checkout.SessionCustomerDetails`
  * Add support for `CustomerBalance` on `InvoicePaymentSettingsPaymentMethodOptionsOptions`, `InvoicePaymentSettingsPaymentMethodOptions`, `SubscriptionPaymentSettingsPaymentMethodOptionsOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptions`
  * Add support for `RequestExtendedAuthorization` on `PaymentIntentPaymentMethodOptionsCardPresentOptions` and `PaymentIntentPaymentMethodOptionsCardPresent`
  * Add `payment_intent.partially_funded`, `terminal.reader.action_failed`, and `terminal.reader.action_succeeded` event constants.

## 39.102.0 - 2022-03-30
* [#2444](https://github.com/stripe/stripe-dotnet/pull/2444) API Updates
  * Add support for `CancelAction`, `ProcessPaymentIntent`, `ProcessSetupIntent`, and `SetReaderDisplay` methods on resource `Terminal.Reader`
  * Add support for `Action` on `Terminal.Reader`

## 39.101.0 - 2022-03-29
* [#2443](https://github.com/stripe/stripe-dotnet/pull/2443) API Updates
  * Add support for Search API
     * Add support for `Search` method on resources `Charge`, `Customer`, `Invoice`, `PaymentIntent`, `Price`, `Product`, and `Subscription`

## 39.100.0 - 2022-03-25
* [#2442](https://github.com/stripe/stripe-dotnet/pull/2442) API Updates
  * Add support for PayNow and US Bank Accounts Debits payments
      * **Charge** ([API ref](https://stripe.com/docs/api/charges/object#charge_object-payment_method_details))
          * Add support for `Paynow` and `UsBankAccount` on `ChargePaymentMethodDetails`
      * **Mandate** ([API ref](https://stripe.com/docs/api/mandates/object#mandate_object-payment_method_details))
          * Add support for `UsBankAccount` on `MandatePaymentMethodDetails`
      * **Payment Intent** ([API ref](https://stripe.com/docs/api/payment_intents/object#payment_intent_object-payment_method_options))
          * Add support for `Paynow` and `UsBankAccount` on `PaymentIntentPaymentMethodOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodDataOptions`
          * Add support for `PaynowDisplayQrCode` on `PaymentIntentNextAction`
      * **Setup Intent** ([API ref](https://stripe.com/docs/api/setup_intents/object#setup_intent_object-payment_method_options))
          * Add support for `UsBankAccount` on `SetupIntentPaymentMethodOptionsOptions` and `SetupIntentPaymentMethodOptions`
      * **Setup Attempt** ([API ref](https://stripe.com/docs/api/setup_attempts/object#setup_attempt_object-payment_method_details))
          * Add support for `UsBankAccount` on `SetupAttemptPaymentMethodDetails`
      * **Payment Method** ([API ref](https://stripe.com/docs/api/payment_methods/object#payment_method_object-paynow))
          * Add support for `Paynow` and `UsBankAccount` on `PaymentMethod` and `PaymentMethodCreateOptions`
          * Add support for `UsBankAccount` on `PaymentMethodUpdateOptions`
      * **Checkout Session** ([API ref](https://stripe.com/docs/api/checkout/sessions/create#create_checkout_session-payment_method_types))
          * Add support for `UsBankAccount` on `Checkout.SessionPaymentMethodOptions` and `Checkout.SessionPaymentMethodOptionsOptions`
      * **Invoice** ([API ref](https://stripe.com/docs/api/invoices/object#invoice_object-payment_settings-payment_method_types))
          * Add support for `UsBankAccount` on `InvoicePaymentSettingsPaymentMethodOptions` and `InvoicePaymentSettingsPaymentMethodOptionsOptions`
      * **Subscription** ([API ref](https://stripe.com/docs/api/subscriptions/object#subscription_object-payment_settings-payment_method_types))
          * Add support for `UsBankAccount` on `SubscriptionPaymentSettingsPaymentMethodOptions` and `SubscriptionPaymentSettingsPaymentMethodOptionsOptions`
      * **Account capabilities** ([API ref](https://stripe.com/docs/api/accounts/object#account_object-capabilities))
      * Add support for `PaynowPayments` and `UsBankAccountAchPayments` on `AccountCapabilities` and `AccountCapabilitiesParams`
  * Add support for `FailureBalanceTransaction` on `Charge`
  * Add support for `TestClock` on `SubscriptionListOptions`
  * Add support for `CaptureMethod` on `PaymentIntentPaymentMethodOptionsAfterpayClearpayOptions`, `PaymentIntentPaymentMethodOptionsAfterpayClearpay`, `PaymentIntentPaymentMethodOptionsCardOptions`, `PaymentIntentPaymentMethodOptionsCard`, `PaymentIntentPaymentMethodOptionsKlarnaOptions`, `PaymentIntentPaymentMethodOptionsKlarna`, and `PaymentIntentTypeSpecificPaymentMethodOptionsClient`
  * Add additional support for verify microdeposits on Payment Intent and Setup Intent ([API ref](https://stripe.com/docs/api/payment_intents/verify_microdeposits))
      * Add support for `DescriptorCode` on `PaymentIntentVerifyMicrodepositsOptions` and `SetupIntentVerifyMicrodepositsOptions`
      * Add support for `MicrodepositType` on `PaymentIntentNextActionVerifyWithMicrodeposits` and `SetupIntentNextActionVerifyWithMicrodeposits`

## 39.99.0 - 2022-03-23
* [#2441](https://github.com/stripe/stripe-dotnet/pull/2441) Add new TestClock webhook event constants.
  * Add  `test_helpers.test_clock.advancing`, `test_helpers.test_clock.created`, `test_helpers.test_clock.deleted`, `test_helpers.test_clock.internal_failure`, and `test_helpers.test_clock.ready` events.
* [#2440](https://github.com/stripe/stripe-dotnet/pull/2440) API Updates
  * Add support for `Cancel` method on resource `Refund`
  * Add support for `TestClock` on `QuoteListOptions`

## 39.98.0 - 2022-03-18
* [#2439](https://github.com/stripe/stripe-dotnet/pull/2439) API Updates
  * Add support for `Status` on `Card`
* [#2438](https://github.com/stripe/stripe-dotnet/pull/2438) Add missing enums for File purpose
* [#2437](https://github.com/stripe/stripe-dotnet/pull/2437) Add support for SearchResult objects

## 39.97.0 - 2022-03-11
* [#2436](https://github.com/stripe/stripe-dotnet/pull/2436) API Updates
  * Add support for `Mandate` on `ChargePaymentMethodDetailsCard`
  * Add support for `MandateOptions` on `PaymentIntentPaymentMethodOptionsCardOptions`, `PaymentIntentPaymentMethodOptionsCard`, `SetupIntentPaymentMethodOptionsCardOptions`, and `SetupIntentPaymentMethodOptionsCard`
  * Add support for `CardAwaitNotification` on `PaymentIntentNextAction`
  * Add support for `CustomerNotification` on `PaymentIntentProcessingCard`

## 39.96.0 - 2022-03-09
* [#2435](https://github.com/stripe/stripe-dotnet/pull/2435) API Updates
  * Add support for `TestClock` on `CustomerListOptions`

## 39.95.0 - 2022-03-02
* [#2432](https://github.com/stripe/stripe-dotnet/pull/2432) API Updates
  * Add support for new resources `InvoiceLineItemProrationDetails` and `InvoiceLineItemProrationDetailsCreditedItems`
  * Add support for `ProrationDetails` on `InvoiceLineItem`

## 39.94.0 - 2022-03-01
* [#2430](https://github.com/stripe/stripe-dotnet/pull/2430) [#2431](https://github.com/stripe/stripe-dotnet/pull/2431) API Updates
  * Add support for new resource `TestHelpers.TestClock`
  * Add support for `TestClock` on `CustomerCreateOptions`, `Customer`, `Invoice`, `InvoiceItem`, `QuoteCreateOptions`, `Quote`, `Subscription`, and `SubscriptionSchedule`
  * Add support for `PendingInvoiceItemsBehavior` on `InvoiceCreateOptions`
  * Change type of `ProductUrlOptions` from `string` to `emptyStringable(string)`
  * Add support for `NextAction` on `Refund`

## 39.93.0 - 2022-02-25
* [#2426](https://github.com/stripe/stripe-dotnet/pull/2426) API Updates
  * Add support for `KonbiniPayments` on `AccountCapabilitiesOptions`, `AccountCapabilitiesOptions`, and `AccountCapabilities`
  * Add support for `Konbini` on `ChargePaymentMethodDetails`, `Checkout.SessionPaymentMethodOptionsOptions`, `Checkout.SessionPaymentMethodOptions`, `InvoicePaymentSettingsPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, `SubscriptionPaymentSettingsPaymentMethodOptionsOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptions`
  * Add support for `KonbiniDisplayDetails` on `PaymentIntentNextAction`

## 39.92.0 - 2022-02-23
* [#2425](https://github.com/stripe/stripe-dotnet/pull/2425) API Updates
  * Add support for `SetupFutureUsage` on `PaymentIntentPaymentMethodOptions.*`

## 39.91.0 - 2022-02-16
* [#2422](https://github.com/stripe/stripe-dotnet/pull/2422) API Updates
  * Add support for `VerifyMicrodeposits` method on resources `PaymentIntent` and `SetupIntent`
* [#2421](https://github.com/stripe/stripe-dotnet/pull/2421) API Updates
  * Add support for `Pin` on `Issuing.CardUpdateOptions`

## 39.90.0 - 2022-02-06
* [#2411](https://github.com/stripe/stripe-dotnet/pull/2411) Add net60 and netcoreapp3.1 targets

## 39.89.0 - 2022-01-25
* [#2416](https://github.com/stripe/stripe-dotnet/pull/2416) API Updates
  * Add support for `PhoneNumberCollection` on `PaymentLinkCreateOptions` and `PaymentLink`

## 39.88.0 - 2022-01-20
* [#2415](https://github.com/stripe/stripe-dotnet/pull/2415) API Updates
  * Add support for new resource `PaymentLink`
  * Add support for `PaymentLink` on `Checkout.Session`

## 39.87.0 - 2022-01-19
* [#2414](https://github.com/stripe/stripe-dotnet/pull/2414) API Updates
  * Add support for `BacsDebit` and `Eps` on `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptionsOptions`, and `PaymentIntentPaymentMethodOptions`
  * Add support for `ImageUrlPng` and `ImageUrlSvg` on `PaymentIntentNextActionWechatPayDisplayQrCode`

## 39.86.0 - 2022-01-13
* [#2413](https://github.com/stripe/stripe-dotnet/pull/2413) API Updates
  * Add support for `PaidOutOfBand` on `Invoice`

## 39.85.0 - 2022-01-12
* [#2412](https://github.com/stripe/stripe-dotnet/pull/2412) API Updates
  * Add support for `CustomerCreation` on `Checkout.SessionCreateOptions` and `Checkout.Session`
  * Add support for `Fpx` and `Grabpay` on `PaymentIntentPaymentMethodOptionsOptions`,  and `PaymentIntentPaymentMethodOptions`

* [#2408](https://github.com/stripe/stripe-dotnet/pull/2408) API Updates
  * Add support for `MandateOptions` on `SubscriptionPaymentSettingsPaymentMethodOptionsCardOptions`, `SubscriptionPaymentSettingsPaymentMethodOptionsCardOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptionsCard`

## 39.84.0 - 2021-12-22
* [#2406](https://github.com/stripe/stripe-dotnet/pull/2406) API Updates
  * Add support for `AuBecsDebit` on `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptionsOptions`, and `PaymentIntentPaymentMethodOptions`

* [#2405](https://github.com/stripe/stripe-dotnet/pull/2405) API Updates
  * Add support for `Boleto` on `SetupAttemptPaymentMethodDetails`

* [#2404](https://github.com/stripe/stripe-dotnet/pull/2404) API Updates
  * Add support for `Processing` on `PaymentIntent`

## 39.83.0 - 2021-12-15
* [#2403](https://github.com/stripe/stripe-dotnet/pull/2403) API Updates
  * Add support for `SetupFutureUsage` on `PaymentIntentPaymentMethodOptionsCardOptions` and `PaymentIntentPaymentMethodOptionsCard`
  * Update comments for `Coupon`, `Customer`, `PersonRelationship`, and `PromotionCode` resources, and `PersonRelationshipOptions` and `TokenPersonRelationshipOptions` options

## 39.82.0 - 2021-12-09
* [#2402](https://github.com/stripe/stripe-dotnet/pull/2402) API Updates
  * Add support for `Metadata` on `BillingPortal.ConfigurationCreateOptions`, `BillingPortal.ConfigurationUpdateOptions`, and `BillingPortal.Configuration`

## 39.81.0 - 2021-12-09
* [#2401](https://github.com/stripe/stripe-dotnet/pull/2401) API Updates
  * Add support for `Giropay` on `PaymentIntentPaymentMethodOptionsOptions` and `PaymentIntentPaymentMethodOptions`
  * Update comment for `TaxId.Type` with new possible types

## 39.80.0 - 2021-11-19
* [#2398](https://github.com/stripe/stripe-dotnet/pull/2398) API Updates
  * Add support for `Wallets` on `Issuing.Card`

## 39.79.0 - 2021-11-17
* [#2397](https://github.com/stripe/stripe-dotnet/pull/2397) API Updates
  * Add support for `AutomaticPaymentMethods` on `PaymentIntentCreateOptions` and `PaymentIntent`

## 39.78.1 - 2021-11-16
* [#2395](https://github.com/stripe/stripe-dotnet/pull/2395)  Update StripeTypeRegistry to be generated.
  * Fixes `ShippingRate` entry in `StripeTypeRegistry` to use `shipping_rate` object name.

## 39.78.0 - 2021-11-16
* [#2394](https://github.com/stripe/stripe-dotnet/pull/2394) API Updates
  * Add support for new resource `ShippingRate`
  * Add support for `ShippingOptions` on `Checkout.SessionCreateOptions` and `Checkout.Session`
  * Add support for `ShippingRate` on `Checkout.Session`

## 39.77.0 - 2021-11-11
* [#2393](https://github.com/stripe/stripe-dotnet/pull/2393) API Updates
  * Add support for `Expire` method on resource `Checkout.Session`
  * Add support for `Status` on `Checkout.Session`

## 39.76.0 - 2021-11-04
* [#2390](https://github.com/stripe/stripe-dotnet/pull/2390) Add missing events to Events.cs
  * Add support for `BillingPortalConfigurationCreated`, `BillingPortalConfigurationUpdated`, `CheckoutSessionExpired`, `InvoiceFinalizationFailed`, `QuoteAccepted`, `QuoteCanceled`, `QuoteCreated`, `QuoteFinalized`, `TransferFailed`, and `TransferPaid` on `Events`
  * Marks `InvoiceFinalizationError` as deprecated. This has been `InvoiceFinalizationFailed` in recent versions of the Stripe API.

## 39.75.1 - 2021-11-04
* [#2391](https://github.com/stripe/stripe-dotnet/pull/2391) API Updates
  * Remove support for `OwnershipDeclarationShownAndSigned` on `TokenAccountOptions`. This API was unused.
  * Add support for `OwnershipDeclarationShownAndSigned` on `TokenAccountCompanyOptions`

## 39.75.0 - 2021-11-01
* [#2388](https://github.com/stripe/stripe-dotnet/pull/2388) API Updates
  * Add support for `OwnershipDeclaration` on `AccountCompanyOptions`, `AccountCompanyOptions`, `AccountCompany`, and `TokenAccountCompanyOptions`
  * Add support for `ProofOfRegistration` on `AccountDocumentsOptions` and `AccountDocumentsOptions`
  * Add support for `OwnershipDeclarationShownAndSigned` on `TokenAccountOptions`
  * Add top-level documentation for resource classes

## 39.74.0 - 2021-10-20
* [#2386](https://github.com/stripe/stripe-dotnet/pull/2386) API Updates
  * Add support for `BuyerId` on `ChargePaymentMethodDetailsAlipay`

## 39.73.0 - 2021-10-11
* [#2378](https://github.com/stripe/stripe-dotnet/pull/2378) API Updates
  * Add support for `PaymentMethodCategory` and `PreferredLocale` on `ChargePaymentMethodDetailsKlarna`
  * Add support for `Klarna` on `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, and `PaymentMethod`

## 39.72.0 - 2021-10-11
* [#2376](https://github.com/stripe/stripe-dotnet/pull/2376) API Updates
  * Add support for `ListPaymentMethods` method on resource `Customer`

## 39.71.0 - 2021-10-07
* [#2375](https://github.com/stripe/stripe-dotnet/pull/2375) API Updates
  * Add support for `PhoneNumberCollection` on `Checkout.SessionCreateOptions` and `Checkout.Session`
  * Add support for `Phone` on `Checkout.SessionCustomerDetails`

## 39.70.0 - 2021-09-29
* [#2373](https://github.com/stripe/stripe-dotnet/pull/2373) API Updates
  * Add support for `KlarnaPayments` on `AccountCapabilitiesOptions`, `AccountCapabilitiesOptions`, and `AccountCapabilities`

## 39.69.0 - 2021-09-24
* [#2372](https://github.com/stripe/stripe-dotnet/pull/2372) API Updates
  * Add support for `AmountAuthorized` and `OvercaptureSupported` on `ChargePaymentMethodDetailsCardPresent`

## 39.68.0 - 2021-09-16
* [#2371](https://github.com/stripe/stripe-dotnet/pull/2371) API Updates
  * Add support for `FullNameAliases` on `AccountIndividualOptions`,  `PersonCreateOptions`, `PersonUpdateOptions`, `Person`, `TokenAccountIndividualOptions`, and `TokenPersonOptions`

## 39.67.0 - 2021-09-15
* [#2370](https://github.com/stripe/stripe-dotnet/pull/2370) API Updates
  * Add support for `DefaultFor` on `Checkout.SessionPaymentMethodOptionsAcssDebitMandateOptionsOptions`, `Checkout.SessionPaymentMethodOptionsAcssDebitMandateOptions`, `MandatePaymentMethodDetailsAcssDebit`, `SetupIntentPaymentMethodOptionsAcssDebitMandateOptionsOptions`, and `SetupIntentPaymentMethodOptionsAcssDebitMandateOptions`
  * Add support for `AcssDebit` on `InvoicePaymentSettingsPaymentMethodOptionsOptions`, `InvoicePaymentSettingsPaymentMethodOptions`, `SubscriptionPaymentSettingsPaymentMethodOptionsOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptions`
  * Add support for `Livemode` on `Reporting.ReportType`

## 39.66.0 - 2021-09-01
* [#2367](https://github.com/stripe/stripe-dotnet/pull/2367) API Updates
  * Add support for `FutureRequirements` on `Account`, `Capability`, and `Person`
  * Add support for `Alternatives` on `AccountRequirements`, `CapabilityRequirements`, and `PersonRequirements`

## 39.65.0 - 2021-09-01
* [#2366](https://github.com/stripe/stripe-dotnet/pull/2366) API Updates
  * Add support for `AfterExpiration`, `ConsentCollection`, and `ExpiresAt` on `Checkout.SessionCreateOptions` and `Checkout.Session`
  * Add support for `Consent` and `RecoveredFrom` on `Checkout.Session`

## 39.64.0 - 2021-08-27
* [#2365](https://github.com/stripe/stripe-dotnet/pull/2365) API Updates
  * Add support for `CancellationReason` on `BillingPortal.ConfigurationFeaturesSubscriptionCancelOptions` and `BillingPortal.ConfigurationFeaturesSubscriptionCancel`
  * Add support for `Sofort` to `ChargePaymentMethodDetails`
  * Add support for `GeneratedSepaDebit` and `PreferredLanguage` to `ChargePaymentMethodDetailsSofort`

## 39.63.0 - 2021-08-11
* [#2358](https://github.com/stripe/stripe-dotnet/pull/2358) API Updates
  * Add support for `Locale` on `BillingPortal.SessionCreateOptions` and `BillingPortal.Session`

## 39.62.0 - 2021-07-28
* [#2356](https://github.com/stripe/stripe-dotnet/pull/2356) API Updates
  * Add support for `AccountType` on `BankAccount`, `ExternalAccountUpdateOptions`, and `TokenBankAccountOptions`
* [#2354](https://github.com/stripe/stripe-dotnet/pull/2354) Adding automatic tax to Upcoming Invoice Options
* [#2355](https://github.com/stripe/stripe-dotnet/pull/2355) Adding customer details to Upcoming Invoice Options
* [#2351](https://github.com/stripe/stripe-dotnet/pull/2351) API Updates
  * Add support for `CategoryCode` on `Issuing` `AuthorizationMerchantData` and `Issuing` `TransactionMerchantData`

## 39.61.0 - 2021-07-22
* [#2350](https://github.com/stripe/stripe-dotnet/pull/2350) API Updates
  * Add support for `PaymentSettings` on `SubscriptionCreateOptions`, `SubscriptionUpdateOptions`, and `Subscription`

## 39.60.0 - 2021-07-20
* [#2349](https://github.com/stripe/stripe-dotnet/pull/2349) API Updates
  * Add support for `Wallet` on `Issuing.Transaction`
  * Add support for `Ideal` on `PaymentIntentPaymentMethodOptionsOptions`

* [#2348](https://github.com/stripe/stripe-dotnet/pull/2348) Remove unused API error types from docs.

## 39.59.0 - 2021-07-14
* [#2346](https://github.com/stripe/stripe-dotnet/pull/2346) API Updates
  * Add support for `ListComputedUpfrontLineItems` method on resource `Quote`

## 39.58.0 - 2021-07-09
* [#2345](https://github.com/stripe/stripe-dotnet/pull/2345) API Updates
  * Add support for new resource `Quote`
  * Add support for `Quote` on `Invoice`

## 39.57.0 - 2021-06-30
* [#2340](https://github.com/stripe/stripe-dotnet/pull/2340) API Updates
  * Add support for `WechatPay` on `ChargePaymentMethodDetails`, `Checkout.SessionPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, and `PaymentMethod`
  * Add support for `WechatPayDisplayQrCode`, `WechatPayRedirectToAndroidApp`, and `WechatPayRedirectToIosApp` on `PaymentIntentNextAction`

## 39.56.1 - 2021-06-30
* [#2343](https://github.com/stripe/stripe-dotnet/pull/2343) Fix another missing `ConfigureAwait` call
* [#2342](https://github.com/stripe/stripe-dotnet/pull/2342) Add missing `ConfigureAwait` call to `SystemNetHttpClient.SendHttpRequest`

## 39.56.0 - 2021-06-29
* [#2339](https://github.com/stripe/stripe-dotnet/pull/2339) API Updates
  * Added support for `boleto_payments` on `AccountCapabilities`
  * Added support for `boleto` and `oxxo` on `Checkout.SessionPaymentMethodOptions`
* [#2333](https://github.com/stripe/stripe-dotnet/pull/2333) Add infrastructure for handling streaming binary responses

## 39.55.0 - 2021-06-25
* [#2336](https://github.com/stripe/stripe-dotnet/pull/2336) API Updates
  * Added support for `boleto` on `ChargePaymentMethodDetails`, `PaymentIntentPaymentMethodOptions`, `PaymentMethod`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, and `PaymentMethodCreateOptions`.
  * Added support for `boleto_display_details` on `PaymentIntentNextAction`

## 39.54.0 - 2021-06-16
* [#2330](https://github.com/stripe/stripe-dotnet/pull/2330) API Updates
  * Add support for `url` on Checkout `Session`

## 39.53.0 - 2021-06-07
* [#2327](https://github.com/stripe/stripe-dotnet/pull/2327) API Updates
  * Added support for `tax_id_collection` on `Session#create` and `Checkout.Session`
  * Added `Secret` property to `EphemeralKey`

## 39.52.0 - 2021-06-04
* [#2326](https://github.com/stripe/stripe-dotnet/pull/2326) API Updates
  * Add support for `Controller` on `Account`

## 39.51.0 - 2021-06-04
* [#2325](https://github.com/stripe/stripe-dotnet/pull/2325) API Updates
  * Add support for new `TaxCode` API.
  * Add support for `TaxCode` on `Product` API, and `PriceProductDataOptions`
  * Add support for `Tax` on `Customer` API
  * Add support for `AutomaticTax` on Checkout `Session` API, `Invoice` API, `SubscriptionScheduleDefaultSettings` API, `SubscriptionSchedulePhase` API, `SubscriptionCreateOptions`, and `SubscriptionUpdateOptions`
  * Add support for `TaxBehavior` on `Price` API, Checkout `SessionLineItemPriceDataOptions`, `InvoiceSubscriptionItemPriceDataOptions`, `SubscriptionSchedulePhaseAddInvoiceItemPriceDataOptions`, `SubscriptionSchedulePhaseItemPriceDataOptions`, and `SubscriptionAddInvoiceItemPriceDataOptions`
  * Add support for `TaxType` on `TaxRate` API
  * Add support for `CustomerUpdate` on Checkout `SessionCreateOptions`

## 39.50.0 - 2021-05-26
* [#2323](https://github.com/stripe/stripe-dotnet/pull/2323) API Updates
  * Added support for `documents` on `PersonUpdateOptions`, `PersonCreateOptions` and `TokenPersonOptions`

## 39.49.0 - 2021-05-19
* [#2319](https://github.com/stripe/stripe-dotnet/pull/2319) API Updates
  * Add support for Identity VerificationSession and VerificationReport APIs

## 39.48.0 - 2021-05-06
* [#2315](https://github.com/stripe/stripe-dotnet/pull/2315) API Updates
  * Add support for `reference` on `ChargePaymentMethodDetailsAfterpayClearpay`
  * Add support for `afterpay_clearpay` on `PaymentIntentPaymentMethodOptions` and `PaymentIntentPaymentMethodOptionsOptions`.

## 39.47.0 - 2021-05-05
* [#2314](https://github.com/stripe/stripe-dotnet/pull/2314) API Updates
  * Add support for `payment_intent` on `Radar.EarlyFraudWarning`

## 39.46.0 - 2021-05-05
* [#2312](https://github.com/stripe/stripe-dotnet/pull/2312) API Updates
  * Add support for `card_present` on `PaymentIntentPaymentMethodOptionsOptions`, and `PaymentIntentMethodOptions`
  * Add `default_incomplete` as a new `payment_behavior` of `SubscriptionOptions` and `SubscriptionItemOptions`.

## 39.45.0 - 2021-04-16
* [#2307](https://github.com/stripe/stripe-dotnet/pull/2307) API Updates
  * Add support for `currency` on `SessionPaymentMethodOptionsAcssDebit`.

## 39.44.0 - 2021-04-12
* [#2303](https://github.com/stripe/stripe-dotnet/pull/2303) API Updates
  * Add support for `acss_debit_payments` on `AccountCapabilities`
  * Add support for `acss_debit` on `SetupIntentPaymentMethodOptionsOptions`, `SetupAttemptPaymentMethodDetailsOptions`, `PaymentMethod`, `PaymentMethodOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodDataOptions`, and `MandatePaymentMethodDetails`, and `Checkout.SessionPaymentMethodOptions`.
  * Add `acss_debit` to the `type` enum of `PaymentMethod`, `PaymentIntent` and `Checkout.SessionCreateOptions.payment_method_types`.
  * Add support for `verify_with_microdeposits` on `PaymentIntentNextAction` and `SetupIntentNextAction`

## 39.43.0 - 2021-04-02
* [#2302](https://github.com/stripe/stripe-dotnet/pull/2302) API Updates
  * Add support for `subscription_pause` on `BillingPortal.ConfigurationFeaturesOptions` and `BillingPortal.ConfigurationFeatures`

## 39.42.0 - 2021-03-31
* [#2299](https://github.com/stripe/stripe-dotnet/pull/2299) API Updates
  * Add support for `transfer_data` on `Checkout.SessionSubscriptionDataOptions`

## 39.41.0 - 2021-03-26
* [#2297](https://github.com/stripe/stripe-dotnet/pull/2297) API Updates
  * Add support for `AccountSettings.CardIssuing`, `AccountSettingsCardIssuing.TosAcceptance`
  * Add support for `AccountSettingsOptions.CardIssuing`, `AccountSettingsCardIssuingOptions.TosAcceptance`

## 39.40.0 - 2021-03-22
* [#2295](https://github.com/stripe/stripe-dotnet/pull/2295) API Updates
  * Add support for `shipping_rates` on `SessionCreateOptions`
  * Add support for `amount_shipping` on `Checkout.SessionTotalDetails`

## 39.39.0 - 2021-03-01
* [#2287](https://github.com/stripe/stripe-dotnet/pull/2287) Add enum support for SubscriptionTrialEnd on the Upcoming Invoice API

## 39.38.0 - 2021-02-22
* [#2290](https://github.com/stripe/stripe-dotnet/pull/2290) Add support for billing portal configuration API

## 39.37.0 - 2021-02-17
* [#2289](https://github.com/stripe/stripe-dotnet/pull/2289) API Updates
  * Add support for on_behalf_of to Invoice

## 39.36.0 - 2021-02-16
* [#2288](https://github.com/stripe/stripe-dotnet/pull/2288) API Updates
  * Add support for `afterpay_clearpay` on `PaymentMethod`, `PaymentIntentPaymentMethodData`, and `ChargePaymentMethodDetails`.
  * Add support for `adjustable_quantity` on `SessionLineItemOptions`
  * Add support for `bacs_debit`, `au_becs_debit` and `sepa_debit` on `SetupAttempt.payment_method_details`

## 39.35.0 - 2021-02-08
* [#2282](https://github.com/stripe/stripe-dotnet/pull/2282) API Updates
  * Add support for `afterpay_clearpay_payments` on `Account.capabilities`
  * Add support for `payment_settings` on `Invoice`

## 39.34.0 - 2021-02-03
* [#2279](https://github.com/stripe/stripe-dotnet/pull/2279) Add `nationality` to Person
* [#2278](https://github.com/stripe/stripe-dotnet/pull/2278) Add link to playlist from README
* [#2277](https://github.com/stripe/stripe-dotnet/pull/2277) API Updates
  * Add support for `nationality` on `Person`, `PersonUpdateOptions`, `PersonCreateOptions` and `TokenCreateParams.person`

## 39.33.0 - 2021-01-21
* [#2274](https://github.com/stripe/stripe-dotnet/pull/2274) API Updates
  * Add support for `dynamic_tax_rates` on `SessionLineItemOptions`
  * Add support for `customer_details` on `Checkout.Session`
  * Add support for `type` on `TransactionListOptions`
  * Add support for `country` and `state` on `TaxRateCreateOptions`, `TaxRateUpdateOptions` and `TaxRate`

## 39.32.0 - 2021-01-07
* [#2271](https://github.com/stripe/stripe-dotnet/pull/2271) API Updates
  * Add support for `company_registration_verification`, `company_ministerial_decree`, `company_memorandum_of_association`, `company_license` and `company_tax_id_verification` on `Account#update.documents` and `Account#create.documents`
* [#2266](https://github.com/stripe/stripe-dotnet/pull/2266) Improve the changelog to cover the issue with 37.X and 38.X not being released

## 39.31.0 - 2020-12-15
* [#2263](https://github.com/stripe/stripe-dotnet/pull/2263) API Updates
  * Add support for card_present on SetupAttempt.payment_method_details

## 39.30.0 - 2020-12-10
* [#2262](https://github.com/stripe/stripe-dotnet/pull/2262) Multiple API Changes
  * Add support for passing `Bank` for eps on `PaymentIntent` or `PaymentMethod`.
  * Add support for passing `tos_shown_and_accepted` on `PaymentIntent`.
* [#2246](https://github.com/stripe/stripe-dotnet/pull/2246) Add .NET 5.0 target
* [#2261](https://github.com/stripe/stripe-dotnet/pull/2261) Update the package description

## 39.29.0 - 2020-12-03
* [#2260](https://github.com/stripe/stripe-dotnet/pull/2260) Add support for `Documents` on `Account` create and update

## 39.28.0 - 2020-11-24
* [#2257](https://github.com/stripe/stripe-dotnet/pull/2257) Multiple API changes
  * Add support for `AccountTaxIds` on `Invoice`
  * Add support for `SepaDebit` in `PaymentMethodOptions` on `PaymentIntent`

## 39.27.0 - 2020-11-20
* [#2255](https://github.com/stripe/stripe-dotnet/pull/2255) Add support for `GrabpayPayments` as a capability on `Account`

## 39.26.0 - 2020-11-19
* [#2254](https://github.com/stripe/stripe-dotnet/pull/2254) Add support for mandate_options on SetupIntent.payment_method_options.sepa_debit.

## 39.25.0 - 2020-11-18
* [#2252](https://github.com/stripe/stripe-dotnet/pull/2252) Add support for `grabpay` on `PaymentMethod`

## 39.24.0 - 2020-11-17
* [#2250](https://github.com/stripe/stripe-dotnet/pull/2250) Multiple API changes
  * Add support for sepa_debit on SetupIntentPaymentMethodOptions
* [#2248](https://github.com/stripe/stripe-dotnet/pull/2248) Mark `SubscriptionProrate` as obsolete on `UpcomingInvoiceOptions`

## 39.23.0 - 2020-11-09
* [#2245](https://github.com/stripe/stripe-dotnet/pull/2245) Add constant for `invoice.finalizaton_error` as an `Event`
* [#2244](https://github.com/stripe/stripe-dotnet/pull/2244) Multiple API changes
  * Add support for `LastFinalizationError` on `Invoice`
  * Add support for Issuing `Dispute` to `IBalanceTransactionSource` to support proper deserialization on the `BalanceTransaction.Source`
  * Add support for `PaymentMethodType` on `StripeError`

## 39.22.0 - 2020-11-04
* [#2243](https://github.com/stripe/stripe-dotnet/pull/2243) Add support for `RegistrationNumber` in `AccountCompany` on `Account`

## 39.21.0 - 2020-10-29
* [#2239](https://github.com/stripe/stripe-dotnet/pull/2239) Avoid async in autopagination when NET461

## 39.20.0 - 2020-10-27
* [#2233](https://github.com/stripe/stripe-dotnet/pull/2233) Add `PreferredLocales` on `Charge` for payments made via Interac Present transactions

## 39.19.0 - 2020-10-26
* [#2232](https://github.com/stripe/stripe-dotnet/pull/2232) Multiple API changes
  * Add support for passing `CvcToken` in `PaymentIntentPaymentMethodOptionsCardOptions ` on `PaymentIntent`
  * Add support for creating a CVC Token on `Token`.

## 39.18.0 - 2020-10-23
* [#2231](https://github.com/stripe/stripe-dotnet/pull/2231) Add support for passing `Bank` for P24 on `PaymentIntent` or `PaymentMethod`

## 39.17.0 - 2020-10-22
* [#2230](https://github.com/stripe/stripe-dotnet/pull/2230) Support passing `TaxRates` when creating invoice items through `Subscription` or `SubscriptionSchedule`
* [#2225](https://github.com/stripe/stripe-dotnet/pull/2225) Add support for `discounts` to `SessionCreateOptions`

## 39.16.0 - 2020-10-14
* [#2224](https://github.com/stripe/stripe-dotnet/pull/2224) Add support for the Payout Reverse API

## 39.15.0 - 2020-10-12
* [#2222](https://github.com/stripe/stripe-dotnet/pull/2222) Add support for `Description`, `Iin` and `Issuer` in `PaymentMethodDetails` for `CardPresent` and `InteracPresent` on `Charge`

## 39.14.0 - 2020-10-12
* [#2221](https://github.com/stripe/stripe-dotnet/pull/2221) Add support for `setup_intent.requires_action` on Event

## 39.13.0 - 2020-10-09
* [#999](https://github.com/stripe/stripe-dotnet/pull/999) Add support for internal-only properties `description`, `iin`, and `issuer` on `ChargePaymentMethodDetailsCardPresent` and `ChargePaymentMethodDetailsInteracPresent`.

## 39.12.0 - 2020-10-08
* [#2216](https://github.com/stripe/stripe-dotnet/pull/2216) Support `Bancontact/iDEAL/Sofort -> SEPA DD`
  * Add support for generated_sepa_debit and generated_sepa_debit_mandate to ChargePaymentMethodDetailsBancontact, ChargePaymentMethodDetailsIdeal, and ChargePaymentMethodDetailsSofort.
  * Add support for generated_from to PaymentMethodSepaDebit
  * Add support for bancontact, ideal, and sofort to SetupAttemptPaymentMethodDetails

## 39.11.0 - 2020-10-02
* [#2215](https://github.com/stripe/stripe-dotnet/pull/2215) Add support for `TosAcceptance.ServiceAgreement` on `Account`
* [#2214](https://github.com/stripe/stripe-dotnet/pull/2214) Add support for new payments capabilities on `Account`

## 39.10.0 - 2020-09-30
* [#2212](https://github.com/stripe/stripe-dotnet/pull/2212) Add support for `SubscriptionProrationBehavior` on `UpcomingInvoiceListLineItemsOptions`

## 39.9.0 - 2020-09-29
* [#2211](https://github.com/stripe/stripe-dotnet/pull/2211) Add support for the `SetupAttempt` resource and List API

## 39.8.0 - 2020-09-28
* [#2210](https://github.com/stripe/stripe-dotnet/pull/2210) Add support for `oxxo_payments` capability on `Account`

## 39.7.0 - 2020-09-24
* [#2209](https://github.com/stripe/stripe-dotnet/pull/2209) Add support for OXXO on `PaymentMethod` and `PaymentIntent`

## 39.6.0 - 2020-09-23
* [#2208](https://github.com/stripe/stripe-dotnet/pull/2208) Add support for `IssuingDisputeClosed` and `IssuingDisputeSubmitted` on `Event`
* [#2207](https://github.com/stripe/stripe-dotnet/pull/2207) Add support for `InstantAvailable` on `Balance`

## 39.5.0 - 2020-09-21
* [#2204](https://github.com/stripe/stripe-dotnet/pull/2204) Add support for `AmountCaptured` on `Charge`
* [#2205](https://github.com/stripe/stripe-dotnet/pull/2205) Add support for `Checkout.Session` on `Discount`

## 39.4.0 - 2020-09-13
* [#2203](https://github.com/stripe/stripe-dotnet/pull/2203) Add support for `promotion_code.created` and `promotion_code.updated` on `Event`

## 39.3.0 - 2020-09-08
* [#2199](https://github.com/stripe/stripe-dotnet/pull/2199) Add support for Sofort on `PaymentMethod` and `PaymentIntent`

## 39.2.0 - 2020-09-03
* [#2198](https://github.com/stripe/stripe-dotnet/pull/2198) Multiple API changes
  * Improve support for the Issuing `Dispute` APIs. Added the Submit API, missing parameters on creation, update and list and returned evidence details
  * Add support for `dispute` on Issuing `Transaction`
  * Add `AvailablePayoutMethods` on `BankAccount`
  * Add `PaymentStatus` on Checkout `Session`

## 39.1.2 - 2020-09-01

    Major version release for API version 2020-08-27.

    Pull requests included in this release (⚠️ = breaking changes):

    * Set default value on non-nullable `DateTime` properties for deserializing with `UnixDateTimeConverter`
    * [#2190](https://github.com/stripe/stripe-dotnet/pull/2190) Add support for `PaymentMethodAutomaticallyUpdated` on `Event`
    * [#2006](https://github.com/stripe/stripe-dotnet/pull/2006) Default the number of network retries to 2
    * [#2097](https://github.com/stripe/stripe-dotnet/pull/2097) Correct namespaces for Issuing and Checkout
    * [#2189](https://github.com/stripe/stripe-dotnet/pull/2189) ⚠️ Removes `Bitcoin` from `ChargePaymentMethodDetails`
    * [#2189](https://github.com/stripe/stripe-dotnet/pull/2189) ⚠️ Removes `UnifiedProration` from `InvoiceItem` and `InvoiceLineItem`
    * [#2189](https://github.com/stripe/stripe-dotnet/pull/2189) ⚠️ Removes `Plan` from `Quantity` from `Subscription`
    * [#2189](https://github.com/stripe/stripe-dotnet/pull/2189) ⚠️ Removes `FailureUrl` and `SuccessUrl` from `AccountLinkCreateOptions`
    * [#2189](https://github.com/stripe/stripe-dotnet/pull/2189) ⚠️ Removes `RequestedCapabilities` from `AccountCreateOptions` and `AccountUpdateOptions`
    * [#2189](https://github.com/stripe/stripe-dotnet/pull/2189) ⚠️ Removes `SavePaymentMethod` and `Source` from `PaymentIntentConfirmOptions`, `PaymentIntentCreateOptions`, and `PaymentIntentUpdateOptions`
    * [#2098](https://github.com/stripe/stripe-dotnet/pull/2098) ⚠️ Remove `ThreeDSecure` and `Bitcoin` resources
    * [#2099](https://github.com/stripe/stripe-dotnet/pull/2099) ⚠️ and [#2036](https://github.com/stripe/stripe-dotnet/pull/2036) Rename all arguments names for services methods to use `id` and `parentId` and be consistent
    * [#2101](https://github.com/stripe/stripe-dotnet/pull/2101) ⚠️ Drop support for .NET Framework 4.5 and require .NET Framework 4.6.1 at a minimum
    * [#2102](https://github.com/stripe/stripe-dotnet/pull/2102) ⚠️ Update Newtonsoft.Json for netstandard2.0 target
    * [#2104](https://github.com/stripe/stripe-dotnet/pull/2104) ⚠️ Prepare future migration to Newtonsoft.Json's `UnixDateTimeConverter`
    * [#2109](https://github.com/stripe/stripe-dotnet/pull/2109) ⚠️ Fix various properties to be explicitly nullable or not nullable
    * [#2110](https://github.com/stripe/stripe-dotnet/pull/2110) ⚠️ Add missing interface to a few services and fix some options inheritance to match the API
    * [#2113](https://github.com/stripe/stripe-dotnet/pull/2113) ⚠️ Moves `notification_method` from `SourceMandateAcceptanceOptions` to `SourceMandateOptions`
    * [#2113](https://github.com/stripe/stripe-dotnet/pull/2113) ⚠️ Removes `paid` from `InvoiceListOptions`
    * [#2113](https://github.com/stripe/stripe-dotnet/pull/2113) ⚠️ Removes metadata from `DisputeEvidenceOptions`
    * [#2113](https://github.com/stripe/stripe-dotnet/pull/2113) ⚠️ Updates `InvoiceListOptions` to use `ListOptionsWithCreated` base class
    * [#2118](https://github.com/stripe/stripe-dotnet/pull/2118) ⚠️ Remove deprecated tax_percent field from Customer, Invoice, Subscription, and SubscriptionSchedule
    * [#2124](https://github.com/stripe/stripe-dotnet/pull/2124) ⚠️ Set service method options parameter defaults to `null`
    * [#2128](https://github.com/stripe/stripe-dotnet/pull/2128) ⚠️ Removes `Destination` from `ChargeCaptureOptions`
    * [#2131](https://github.com/stripe/stripe-dotnet/pull/2131) ⚠️ Changes SSNLast4 to SsnLast4 to match all other naming
    * [#2136](https://github.com/stripe/stripe-dotnet/pull/2136) ⚠️ Makes `Price` and `Rate` included by default on `LineItem` and `LineItemTax` respectively
    * [#2140](https://github.com/stripe/stripe-dotnet/pull/2140) ⚠️ Removes `Recipient`
    * [#2142](https://github.com/stripe/stripe-dotnet/pull/2142) ⚠️ Stop sharing from `PaymentIntentPaymentMethodDataOptions`
    * [#2142](https://github.com/stripe/stripe-dotnet/pull/2142) ⚠️ Stop sharing sub hashes from `PaymentMethodCreateOptions` and `PaymentMethodUpdateOptions`
    * [#2144](https://github.com/stripe/stripe-dotnet/pull/2144) ⚠️ Rename nested `PlanProductCreateOptions` to `PlanProductOptions`
    * [#2156](https://github.com/stripe/stripe-dotnet/pull/2156) ⚠️ Unshare `SubscriptionSchedule` objects
    * [#2159](https://github.com/stripe/stripe-dotnet/pull/2159) ⚠️ Unshare `Account` objects
    * [#2160](https://github.com/stripe/stripe-dotnet/pull/2160) ⚠️ Unshare `TokenAccountIndividual` objects
    * [#2163](https://github.com/stripe/stripe-dotnet/pull/2163) ⚠️ Unshare `CustomerInvoiceSettings` objects
    * [#2164](https://github.com/stripe/stripe-dotnet/pull/2164) ⚠️ Unshare `Sku` and `Product` objects
    * [#2165](https://github.com/stripe/stripe-dotnet/pull/2165) ⚠️ Removes `date` from `InvoiceLineItem`
    * [#2165](https://github.com/stripe/stripe-dotnet/pull/2165) ⚠️ Renames `InvoiceTaxAmount` to `InvoiceLineItemTaxAmount` on `InvoiceLineItem`
    * [#2165](https://github.com/stripe/stripe-dotnet/pull/2165) ⚠️ Unshare `Period` Objects
    * [#2165](https://github.com/stripe/stripe-dotnet/pull/2165) ⚠️ Unshared `CreditNoteLineItemDiscountAmount` and uses a new `InvoiceLineItemDiscountAmount` on `InvoiceLineItem`
    * [#2166](https://github.com/stripe/stripe-dotnet/pull/2166) ⚠️ Update `LoginLinkService` to use new `parentId` pattern
    * [#2167](https://github.com/stripe/stripe-dotnet/pull/2167) ⚠️ Rename `FileLinkData` to `FileFileLinkData`
    * [#2168](https://github.com/stripe/stripe-dotnet/pull/2168) ⚠️ Unshare `BillingDetails` objects
    * [#2169](https://github.com/stripe/stripe-dotnet/pull/2169) ⚠️ Unshare `SubscriptionItem` objects
    * [#2170](https://github.com/stripe/stripe-dotnet/pull/2170) ⚠️ Merge nested `SourceCardUpdateOptions` to `SourceCardOptions`
    * [#2171](https://github.com/stripe/stripe-dotnet/pull/2171) ⚠️ Move `SessionLineItemPriceDataProductDataOptions` into the `Checkout` namespace
    * [#2171](https://github.com/stripe/stripe-dotnet/pull/2171) ⚠️ Rename `SessionPaymentIntentTransferDataOptions` to `SessionPaymentIntentDataTransferDataOptions`
    * [#2176](https://github.com/stripe/stripe-dotnet/pull/2176) ⚠️ Use new `parentId` pattern in the `ApplicationFeeRefundService`
    * [#2178](https://github.com/stripe/stripe-dotnet/pull/2178) ⚠️ Unshare `ChargeDestinationOptions`
    * [#2181](https://github.com/stripe/stripe-dotnet/pull/2181) ⚠️ Updates doc strings to match the OpenAPI spec
    * [#2193](https://github.com/stripe/stripe-dotnet/pull/2193) Configure license and icon within repo

## 37.35.0 - 2020-08-27
* [#2186](https://github.com/stripe/stripe-dotnet/pull/2186) Add support for `SepaCreditTransfer` in `SourceTransaction`

## 37.34.0 - 2020-08-19
* [#2185](https://github.com/stripe/stripe-dotnet/pull/2185) Add support for `ExpiresAt` on `File`

## 37.33.0 - 2020-08-17
* [#2184](https://github.com/stripe/stripe-dotnet/pull/2184) Add support for `AmountDetails` on Issuing `Authorization` and `Transaction`

## 37.32.0 - 2020-08-17
* [#2182](https://github.com/stripe/stripe-dotnet/pull/2182) Add support for `PaymentIntentRequiresAction` on `Event`

## 37.31.0 - 2020-08-13
* [#2179](https://github.com/stripe/stripe-dotnet/pull/2179) Add support for `BankName` on `ChargePaymentMethodDetailsAcssDebit`

## 37.30.0 - 2020-08-07
* [#2162](https://github.com/stripe/stripe-dotnet/pull/2162) Adds support for `Alipay` on `PaymentIntent` and `PaymentMethod`

## 37.29.0 - 2020-08-05
* [#2153](https://github.com/stripe/stripe-dotnet/pull/2153) Multiple API Changes
  * Add the `PromotionCode` resource and APIs
  * Add support for `AllowPromotionCodes` on Checkout `Session`
  * Add support for `AppliesTo` on `Coupon`
  * Add support for `PromotionCode` on `Customer` and `Subscription` creation or update

## 37.28.0 - 2020-08-04
* [#2152](https://github.com/stripe/stripe-dotnet/pull/2152) Add support for `AccountType` in `ChargePaymentMethodDetailsCardPresentReceipt`

## 37.27.0 - 2020-07-29
* [#2121](https://github.com/stripe/stripe-dotnet/pull/2121) Add support for multiple coupons on Billing APIs
  * Add support for arrays of expandable API resources otherwise returning an array of strings by default
  * Add support for `Id`, `Invoice` and `InvoiceItem` on `Discount`.
  * Add support for `Discounts` on `Invoice`, `InvoiceItem`, `InvoiceLineItem`
  * Add support for `DiscountAmounts` on `CreditNote`, `CreditNoteLineItem`, `InvoiceLineItem`
  * Add support for `TotalDiscountAmounts` on `Invoice`
* [#2145](https://github.com/stripe/stripe-dotnet/pull/2145) Add support for `BillingThresholds` on `SubscriptionItemOptions`

## 37.26.0 - 2020-07-25
* [#2143](https://github.com/stripe/stripe-dotnet/pull/2143) Add `FpxPayments` to `AccountCapabilities` on `Account`

## 37.25.0 - 2020-07-24
* [#2141](https://github.com/stripe/stripe-dotnet/pull/2141) Add support for `FPXPayments` as a `Capability` on `Account` create and update

## 37.24.0 - 2020-07-22
* [#2129](https://github.com/stripe/stripe-dotnet/pull/2129) Add `CarteBancairesPayments` as a `Capability`

## 37.23.0 - 2020-07-21
* [#2127](https://github.com/stripe/stripe-dotnet/pull/2127) Adds `TransferData` and `TransferGroup` to `Charge` capture

## 37.22.0 - 2020-07-21
* [#2125](https://github.com/stripe/stripe-dotnet/pull/2125) Add `Pii` on `Token` creation

## 37.21.0 - 2020-07-20
* [#2123](https://github.com/stripe/stripe-dotnet/pull/2123) Add `Capabilities` to `Account` create and update

## 37.20.0 - 2020-07-17
* [#2120](https://github.com/stripe/stripe-dotnet/pull/2120) Add support for `PoliticalExposure` on `Person`

## 37.19.0 - 2020-07-16
* [#2119](https://github.com/stripe/stripe-dotnet/pull/2119) Add support for `Deleted` on `LineItem`

## 37.18.0 - 2020-07-15
* [#2117](https://github.com/stripe/stripe-dotnet/pull/2117) Add support for `AmountTotal`, `AmountSubtotal`, `Currency` and `TotalDetails` on Checkout `Session`

## 37.17.0 - 2020-07-13
* [#2114](https://github.com/stripe/stripe-dotnet/pull/2114) Adds `BillingCycleAnchor` to default_settings and phases for `SubscriptionSchedules`
* [#2112](https://github.com/stripe/stripe-dotnet/pull/2112) Removes unused imports, alphabetizes, and removes some comments
* [#2111](https://github.com/stripe/stripe-dotnet/pull/2111) Add support for `Metadata` on Issuing `Dispute`

## 37.16.0 - 2020-07-06
* [#2108](https://github.com/stripe/stripe-dotnet/pull/2108) Multiple API changes
  * Add `Network` on `PaymentMethodCardOptions`
  * Add `RefundAttributesMethod` and `RefundAttributesStatus` on `SourceReceiver`

## 37.15.1 - 2020-07-03
* [#2106](https://github.com/stripe/stripe-dotnet/pull/2106) Fix `Mandate` deserialization for BACS Debit where `NetworkStatus` is now a string
* [#2103](https://github.com/stripe/stripe-dotnet/pull/2103) Add Newtonsoft.Json version to X-Stripe-Client-User-Agent

## 37.15.0 - 2020-07-01
* [#2100](https://github.com/stripe/stripe-dotnet/pull/2100) Adds misc missing fields across resources
* [#2091](https://github.com/stripe/stripe-dotnet/pull/2091) Fix incorrect documentation on the Upcoming Invoice parameters

## 37.14.0 - 2020-06-24
* [#2090](https://github.com/stripe/stripe-dotnet/pull/2090) Add support for `invoice.paid` event

## 37.13.0 - 2020-06-23
* [#2086](https://github.com/stripe/stripe-dotnet/pull/2086) Add support for `Discounts` on `LineItem`
* [#2087](https://github.com/stripe/stripe-dotnet/pull/2087) Add support for `ShippingDelay` on `Source` for Klarna
* [#2088](https://github.com/stripe/stripe-dotnet/pull/2088) Add missing values in `FilePurpose`
* [#2085](https://github.com/stripe/stripe-dotnet/pull/2085) Fixed typo in `SessionSubscriptionDataOptions`

## 37.12.0 - 2020-06-22
* [#2083](https://github.com/stripe/stripe-dotnet/pull/2083) Add `SubscriptionStartDate` to the Upcoming Invoice API
* [#2082](https://github.com/stripe/stripe-dotnet/pull/2082) Add support for `Price` on Upcoming Invoice API

## 37.11.0 - 2020-06-18
* [#2074](https://github.com/stripe/stripe-dotnet/pull/2074) Add support for `RefreshURL` and `ReturnURL` on `AccountLink`
* [#2077](https://github.com/stripe/stripe-dotnet/pull/2077) Add support for `Issuing.DisputeFundsReinstated` event type.

## 37.10.0 - 2020-06-11
* [#2072](https://github.com/stripe/stripe-dotnet/pull/2072) Add support for `Mandate` in `ChargePaymentMethodDetailsAcssDebit`
* [#2073](https://github.com/stripe/stripe-dotnet/pull/2073) Add support for `Transaction` on Issuing `Dispute`

## 37.9.0 - 2020-06-10
* [#2069](https://github.com/stripe/stripe-dotnet/pull/2069) Add support for Cartes Bancaires payments on `PaymentIntent` and `PaymentMethod`

## 37.8.0 - 2020-06-03
* [#2065](https://github.com/stripe/stripe-dotnet/pull/2065) Add support for `TransferGroup` on Checkout `Session`

## 37.7.0 - 2020-06-03
* [#2064](https://github.com/stripe/stripe-dotnet/pull/2064) Add support for `CheckoutSessionAsyncPaymentFailed` and `CheckoutSessionAsyncPaymentSucceeded` on `Event`
* [#2063](https://github.com/stripe/stripe-dotnet/pull/2063) Add support for BACS Debit as a `Capability` on `Account`
* [#2062](https://github.com/stripe/stripe-dotnet/pull/2062) Add support for Bancontact, EPS, Giropay and P24 on `PaymentMethod`
* [#2061](https://github.com/stripe/stripe-dotnet/pull/2061) Add support for `Settings.SepaDebitPayments.CreditorId` on `Account`

## 37.6.0 - 2020-05-29
* [#2058](https://github.com/stripe/stripe-dotnet/pull/2058) Add support for BACS Debit as a `PaymentMethod`. Also fixed `AcssDebit` on `ChargePaymentMethodDetails` to be `ChargePaymentMethodDetailsAcssDebit`.

## 37.5.0 - 2020-05-28
* [#2057](https://github.com/stripe/stripe-dotnet/pull/2057) Add support for `ProductData` on `SessionLineItemPriceDataOptions`
* [#2056](https://github.com/stripe/stripe-dotnet/pull/2056) Add `AuthenticationFlow` in `ChargePaymentMethodDetailsCardThreeDSecure`

## 37.4.0 - 2020-05-22
* [#2055](https://github.com/stripe/stripe-dotnet/pull/2055) Add support for `Result` and `ResultReason` in `ChargePaymentMethodDetailsCardThreeDSecure`

## 37.3.0 - 2020-05-20
* [#2054](https://github.com/stripe/stripe-dotnet/pull/2054) Multiple API changes
  * Add `PaymentMethodTypeInteracPresent` as a `Type` on `PaymentMethod`
  * Add `ChargePaymentMethodDetailsInteracPresent` on `Charge`
  * Add `TransferData ` on `SubscriptionSchedule`

## 37.2.0 - 2020-05-20
* [#2051](https://github.com/stripe/stripe-dotnet/pull/2051) Enable TLS 1.2 on all runtimes
* [#2053](https://github.com/stripe/stripe-dotnet/pull/2053) Add multiple missing features and better docs
  * Add `NetworkReasonCode` on `Dispute` which is a gated feature
  * Fix `RefundId` on `OrderReturn`, `CustomerId` on `Order` and `BalanceTransactionId` on `Topup` to be deserialized properly
  * Add `Deleted` on `ValueList` and `ValueListItem`
  * Add `BillingThresholds` on `SubscriptionItem`

## 37.1.0 - 2020-05-18
* [#2047](https://github.com/stripe/stripe-dotnet/pull/2047) Multiple API changes
  * Add `BalanceTransactions` as a a list of `BalanceTransaction` on Issuing `Dispute`
  * Add `Fingerprint` and `TransactionId` in `ChargePaymentMethodDetailsAlipay` on `Charge`
  * Add `Amount` in `InvoiceTransferData` and `InvoiceTransferDataOptions` on `Invoice`
  * Add `AmountPercent` in `SubscriptionTransferData` and `SubscriptionTransferDataOptions` on `Subscription`

## 37.0.0 - 2020-05-18
* [#2039](https://github.com/stripe/stripe-dotnet/pull/2039) Major version released with the following breaking changes in it:
  * [#2036](https://github.com/stripe/stripe-dotnet/pull/2036) Fix `Quantity` to be nullable on `CreditNoteLineItem`
  * [#2037](https://github.com/stripe/stripe-dotnet/pull/2037) Removed deprecated `ExchangeRate` resource and APIs
    * The `ExchangeRate` APIs have been in a small private beta for a few years and have never been used in stripe-dotnet this year. We are considering this API mostly deprecated as we're working on re-building the feature. This will require large changes to the resource and APIs once we are ready to ship it.
  * [#2038](https://github.com/stripe/stripe-dotnet/pull/2038) Removed deprecated parameters
    * Removed `PrimaryColor` in `AccountBusinessProfileOptions`. Use `PrimaryColor` in `AccountSettingsBrandingOptions` instead.
    * Removed `metadata` on `CreditNoteLineOptions` as it was never supported
  * [#2043](https://github.com/stripe/stripe-dotnet/pull/2043) Multiple properties renamed
    * Properties lost their `Id` suffix such as `PaymentMethodId` renamed to `PaymentMethod` on `Charge`
    * `IIN` is now `Iin` on `Card`
    * `AmountReceivd` is now `AmountReceived` on `ChargePaymentMethodDetailsBitcoin`
    * `BankCode` is now `Bank` on `ChargePaymentMethodDetailsIdeal`.
    * `CustomerPurchaseIP` is now `CustomerPurchaseIp` on `DisputeEvidence` and `DisputeEvidenceOptions`
    * `OrderItems` is now `Items` on `Order` and `OrderReturn`
    * `CardList` is now `Cards` on `Recipient`
    * `BankAddressLinePostalCode` is now `BankAddressPostalCode` on `SourceAcssDebit`
    * Properties on `StripeError` have been renamed, `ChargeId` is `Charge`, `ErrorType` is `Type` and `Parameter` is `Param`

## 36.12.2 - 2020-05-13
* [#2044](https://github.com/stripe/stripe-dotnet/pull/2044) Fix `Taxes` on `LineItem` to be de-serialized properly
* [#2043](https://github.com/stripe/stripe-dotnet/pull/2043) Fix parameter classes to pass `Product` or `ProductData` on `Price`

## 36.12.1 - 2020-05-13
* [#2041](https://github.com/stripe/stripe-dotnet/pull/2041) Fix `LineItems` on Checkout `Session` to be a `StripeList`

## 36.12.0 - 2020-05-13
* [#2019](https://github.com/stripe/stripe-dotnet/pull/2019) Add support for `PaymentMethodData` on `PaymentIntent`
* [#2033](https://github.com/stripe/stripe-dotnet/pull/2033) Add support for `PurchaseDetails` on Issuing `Transaction`

## 36.11.0 - 2020-05-12
* [#2020](https://github.com/stripe/stripe-dotnet/pull/2020) Add support for the `LineItem` resource and APIs

## 36.10.0 - 2020-05-11
* [#2031](https://github.com/stripe/stripe-dotnet/pull/2031) Add support for `Product` for Klarna `Source`

## 36.9.0 - 2020-05-07
* [#2028](https://github.com/stripe/stripe-dotnet/pull/2028) Add support for `SupportAddress` on `Account` create and update
* [#2026](https://github.com/stripe/stripe-dotnet/pull/2026) Fix parameters supported in `Recurring` for `PriceData` across the API

## 36.8.1 - 2020-05-05
* [#2025](https://github.com/stripe/stripe-dotnet/pull/2025) Mark `Metadata` on `CreditNoteLineOptions` as obsolete

## 36.8.0 - 2020-05-01
* [#2018](https://github.com/stripe/stripe-dotnet/pull/2018) Add support for `Issuing` on `Balance`

## 36.7.0 - 2020-04-29
* [#2010](https://github.com/stripe/stripe-dotnet/pull/2010) Add support for the `Price` resource and APIs

## 36.6.0 - 2020-04-23
* [#2017](https://github.com/stripe/stripe-dotnet/pull/2017) Add `CardIssuing` and `JcbPayments` as capabilities on `Account`

## 36.5.0 - 2020-04-22
* [#2014](https://github.com/stripe/stripe-dotnet/pull/2014) Add support for `Coupon` for subscriptions on Checkout

## 36.4.0 - 2020-04-22
* [#1998](https://github.com/stripe/stripe-dotnet/pull/1998) Add support for the `BillingPortal` namespace and the `Session` API and resource

## 36.3.0 - 2020-04-21
* [#2005](https://github.com/stripe/stripe-dotnet/pull/2005) Swallow exceptions when gathering runtime information to avoid raising an error when generating the user agent details for a request
* [#2011](https://github.com/stripe/stripe-dotnet/pull/2011) Add `Deleted` on `Invoice` and all missing docstrings

## 36.2.0 - 2020-04-17
* [#2007](https://github.com/stripe/stripe-dotnet/pull/2007) Add `CardholderName` to `ChargePaymentMethodDetailsCardPresent`

## 36.1.0 - 2020-04-16
* [#2004](https://github.com/stripe/stripe-dotnet/pull/2004) Add `InstitutionNumber` and `TransitNumber` on `ChargePaymentMethodDetailsAcssDebit`
* [#2000](https://github.com/stripe/stripe-dotnet/pull/2000) Ability to inspect the configuration of SystemNetHttpClient
* [#2003](https://github.com/stripe/stripe-dotnet/pull/2003) Add support for `Cvc` and `Number` on Issuing `Card`

## 36.0.0 - 2020-04-16
* [#1993](https://github.com/stripe/stripe-dotnet/pull/1993) Multiple breaking API changes while removing deprecated Issuing features
  * [#1992](https://github.com/stripe/stripe-dotnet/pull/1992), [#1994](https://github.com/stripe/stripe-dotnet/pull/1994) Change `Error` on `ScheduledQueryRun` from `string` to `ScheduledQueryRunError`
  * [#1961](https://github.com/stripe/stripe-dotnet/pull/1961) Multiple renames of classes and related fixes
    * Renamed  the class `Fee` to `BalanceTransactionFee` on `BalanceTransaction`
    * Renamed the class `Outcome` to `ChargeOutcome` on `Charge`
    * Renamed the classes `Evidence` to `DisputeEvidence` and `EvidenceDetails` to `DisputeEvidenceDetails` on `Dispute`
    * Renamed the class `OutcomeRule` to `Rule` and moved it to the `Radar` namespace
    * Renamed the classes `ShippingMethod` to `OrderShippingMethod`, `StatusTransitions` to `OrderStatusTransitions` and `DeliveryEstimate` to `OrderShippingMethodDeliveryEstimate` on `Order`
    * Renamed the class `Inventory` to `SkuInventory` on `Sku`
    * Fixed the type of `NextPendingInvoiceItemInvoice` on `Subscription` to be a `DateTime?`
    * `FraudDetails` on `Charge` is now a class `ChargeFraudDetails` instead of a dictionary
    * Removed `Connect` on the `WebhookEndpoint` resource as it is not supported
  - [#2001](https://github.com/stripe/stripe-dotnet/pull/2001) Remove deprecated API features
    * Remove `Percentage` filter when listing `TaxRate` as this does not work
    * Remove `Country` and `RoutingNumber` from `ChargePaymentMethodDetailsAcssDebit`
    * Remove `RenewalInterval` on `SubscriptionSchedule`
    * Rename `Parameters` to `ReportRunParameters` on `ReportRun`
    * Fix all Checkout classes to be in the `Stripe.Checkout` namespace
  * [#1968](https://github.com/stripe/stripe-dotnet/pull/1968) Remove all deprecated features associated with the Issuing API and resources

## 35.17.0 - 2020-04-14
* [#1999](https://github.com/stripe/stripe-dotnet/pull/1999) Add support for `SecondaryColor` on `Account`

## 35.16.0 - 2020-04-13
* [#1997](https://github.com/stripe/stripe-dotnet/pull/1997) Add `Description` on `WebhookEndpoint`

## 35.15.0 - 2020-04-13
* [#1996](https://github.com/stripe/stripe-dotnet/pull/1996) Add missing events for `TaxId` and `Capability`

## 35.14.0 - 2020-04-10
* [#1988](https://github.com/stripe/stripe-dotnet/pull/1988) Add support for `CancellationReason` on Issuing `Card`

## 35.13.0 - 2020-04-09
* [#1987](https://github.com/stripe/stripe-dotnet/pull/1987) Add missing properties on `Review`

## 35.12.1 - 2020-04-08
* [#1982](https://github.com/stripe/stripe-dotnet/pull/1982) Fix deadlock in `AsyncUtils.ToEnumerable()`

## 35.12.0 - 2020-04-03
* [#1978](https://github.com/stripe/stripe-dotnet/pull/1978) Add `CalculatedStatementDescriptor` on `Charge`

## 35.11.1 - 2020-03-31
* [#1976](https://github.com/stripe/stripe-dotnet/pull/1976) Remove System.Linq.Async dependency

## 35.11.0 - 2020-03-30
* [#1970](https://github.com/stripe/stripe-dotnet/pull/1970) Add `RawJObject` getter to `StripeEntity`
* [#1973](https://github.com/stripe/stripe-dotnet/pull/1973) Support for asynchronous autopagination
* [#1972](https://github.com/stripe/stripe-dotnet/pull/1972) Add `net461` as a target framework

## 35.10.0 - 2020-03-26
* [#1966](https://github.com/stripe/stripe-dotnet/pull/1966) Add support for `SpendingControls` on Issuing `Card` and `Cardholder`

## 35.9.0 - 2020-03-24
* [#1965](https://github.com/stripe/stripe-dotnet/pull/1965) Add support for `PauseCollection` on `Subscription`

## 35.8.0 - 2020-03-23
* [#1964](https://github.com/stripe/stripe-dotnet/pull/1964) Add new capabilities for AU Becs Debit and tax reporting

## 35.7.1 - 2020-03-23
* [#1963](https://github.com/stripe/stripe-dotnet/pull/1963) Support RequestedAt being nullable
    * This is technically a breaking change, but we're releasing as a patch version as the non-nullable type made it impossible to deserialize `Capability` objects in many cases.

## 35.7.0 - 2020-03-20
* [#1960](https://github.com/stripe/stripe-dotnet/pull/1960) Add new fields to Issuing `Card` and `Authorization`
  * Add `Amount` and `AmountCurrency` to `Authorization`
  * Add `MerchantAmount` and `MerchantCurrency` to `Authorization`
  * Add `PendingRequest` to `Authorization`
  * Add `ReplacedBy` to `Card`
  * Add `Amount` and `Metadata` to `AuthorizationApproveOptions`
  * Add `Metadata` to `AuthorizationDeclineOptions`

## 35.6.0 - 2020-03-13
* [#1955](https://github.com/stripe/stripe-dotnet/pull/1955) Multiple changes for Issuing APIs
  * Rename `Speed` to `Service` on Issuing `Card`
  * Rename `WalletProvider` to `Wallet` and `AddressZipCheck` to `AddressPostalCodeCheck` on Issuing `Authorization`
  * Mark `IsDefault` as deprecated on Issuing `Cardholder`

## 35.5.0 - 2020-03-12
* [#1953](https://github.com/stripe/stripe-dotnet/pull/1953) Add support for `Shipping` and `ShippingAddressCollection` on Checkout `Session`

## 35.4.0 - 2020-03-12
* [#1951](https://github.com/stripe/stripe-dotnet/pull/1951) Add multiple missing features
  * `DomainName` filter when listing `ApplePayDomain`
  * `Name` filter when listing Issuing `Card`
  * `Amount` on `Source` Update
  * `TransferGroup` on `Topup` creation
  * `Description` on `Topup` update
  * `Status` filter when listing `Topup`
* [#1952](https://github.com/stripe/stripe-dotnet/pull/1952) Add support for `ThreeDSecure` on Issuing `Authorization`

## 35.3.0 - 2020-03-04
* [#1945](https://github.com/stripe/stripe-dotnet/pull/1945) Add support for `Description`, `Iin` and `Issuer` on `PaymentMethod`
* [#1944](https://github.com/stripe/stripe-dotnet/pull/1944) Add support for `Metadata` on `WebhookEndpoint`

## 35.2.0 - 2020-03-04
* [#1942](https://github.com/stripe/stripe-dotnet/pull/1942) Add support for `ExpiryCheck` on Issuing `Authorization`

## 35.1.0 - 2020-03-04
* [#1940](https://github.com/stripe/stripe-dotnet/pull/1940) Add support for `Errors` in `Requirements` on `Account`, `Capability` and `Person`
* [#1941](https://github.com/stripe/stripe-dotnet/pull/1941) Add support for `payment_intent.processing`

## 35.0.0 - 2020-03-03
Major version release for new API version `2020-03-02`.

Pull requests included in this release (cf. [#1934](https://github.com/stripe/stripe-dotnet/pull/1934)) (⚠️ = breaking changes):

* [#1933](https://github.com/stripe/stripe-dotnet/pull/1933) ⚠️ Drop support for .NET Standard 1.2
* [#1935](https://github.com/stripe/stripe-dotnet/pull/1935) Remove conditional compilation macros in tests
* [#1932](https://github.com/stripe/stripe-dotnet/pull/1932) ⚠️ Add support for passing parameters when deleting a Subscription Item
* [#1936](https://github.com/stripe/stripe-dotnet/pull/1936) Get accurate runtime version
* [#1937](https://github.com/stripe/stripe-dotnet/pull/1937) ⚠️ Move to API version `2020-03-02` and remove deprecated properties
* [#1938](https://github.com/stripe/stripe-dotnet/pull/1938) Add support for `NextInvoiceSequence` on `Customer`

## 34.26.0 - 2020-02-24
* [#1928](https://github.com/stripe/stripe-dotnet/pull/1928) Add support for listing Checkout `Session` and passing tax rate information

## 34.25.0 - 2020-02-21
* [#1926](https://github.com/stripe/stripe-dotnet/pull/1926) Add support for `ProrationBehavior` on `SubscriptionSchedule`
* [#1927](https://github.com/stripe/stripe-dotnet/pull/1927) Add support for `Timezone` on `ReportRun`
* [#1910](https://github.com/stripe/stripe-dotnet/pull/1910) Add support for Wechat on `Source`

## 34.24.0 - 2020-02-20
* [#1925](https://github.com/stripe/stripe-dotnet/pull/1925) Add `stripe_net_target_framework` key to extended user agent
* [#1924](https://github.com/stripe/stripe-dotnet/pull/1924) Bump dependencies

## 34.23.0 - 2020-02-17
* [#1923](https://github.com/stripe/stripe-dotnet/pull/1923) Add support for `additional_verification` as a valid `purpose` on `File`

## 34.22.0 - 2020-02-12
* [#1921](https://github.com/stripe/stripe-dotnet/pull/1921) Add support for `Amount` on `SessionPaymentIntentTransferDataOptions`

## 34.21.0 - 2020-02-12
* [#1920](https://github.com/stripe/stripe-dotnet/pull/1920) Add `PaymentMethodOptions` when updating a `PaymentIntent` and a `SetupIntent`

## 34.20.1 - 2020-02-11
* [#1919](https://github.com/stripe/stripe-dotnet/pull/1919) Use a static instance for default `HttpClient`
* [#1914](https://github.com/stripe/stripe-dotnet/pull/1914) Remove specialize private setter on `Coupon`
* [#1911](https://github.com/stripe/stripe-dotnet/pull/1911) Rename a couple directories and files to follow convention

## 34.20.0 - 2020-02-05
* [#1908](https://github.com/stripe/stripe-dotnet/pull/1908) Add support for returning orders

## 34.19.0 - 2020-02-03
* [#1903](https://github.com/stripe/stripe-dotnet/pull/1903) Adds support for `ErrorOnRequiresAction` on `PaymentIntent`

## 34.18.0 - 2020-01-30
* [#1906](https://github.com/stripe/stripe-dotnet/pull/1906) Add support for `Structure` on `Account`

## 34.17.0 - 2020-01-24
* [#1905](https://github.com/stripe/stripe-dotnet/pull/1905) Add support for `Shipping.Speed` and `Shipping.TrackingURL` on Issuing `Card`

## 34.16.1 - 2020-01-22
* [#1902](https://github.com/stripe/stripe-dotnet/pull/1902) Make `OutOfBandAmount` nullable on  `CreditNote`
    * This is technically a breaking change, but we're releasing as a patch version as the non-nullable type made it impossible to deserialize `credit_note` objects in many cases.

## 34.16.0 - 2020-01-17
* [#1899](https://github.com/stripe/stripe-dotnet/pull/1899) Add support for `Metadata` on Checkout `Session`

## 34.15.0 - 2020-01-15
* [#1895](https://github.com/stripe/stripe-dotnet/pull/1895) Add support for `PendingUpdate` and `ProrationBehavior` on `Subscription` APIs.

## 34.14.0 - 2020-01-14
* [#1896](https://github.com/stripe/stripe-dotnet/pull/1896) Add support for `CreditNoteLineItem`

## 34.13.0 - 2020-01-10
* [#1894](https://github.com/stripe/stripe-dotnet/pull/1894) Fix sepa debit deserialization on MandatePaymentMethodDetails

## 34.12.0 - 2020-01-06
* [#1893](https://github.com/stripe/stripe-dotnet/pull/1893) Add `ReportingCategory` to `BalanceTransaction`

## 34.11.0 - 2020-01-03
* [#1892](https://github.com/stripe/stripe-dotnet/pull/1892) Improve support for `SpendingLimits` on Issuing `Card`

## 34.10.1 - 2020-01-03
* [#1891](https://github.com/stripe/stripe-dotnet/pull/1891) Internal cleanup of the library to remove SharedOptions classes and define parameters in their respective Create or Update options classes.

## 34.10.0 - 2019-12-30
* [#1885](https://github.com/stripe/stripe-dotnet/pull/1885) Add public `Service.Client` setter

## 34.9.0 - 2019-12-24
* [#1890](https://github.com/stripe/stripe-dotnet/pull/1890) Add `new()` constraint to options generic types

## 34.8.0 - 2019-12-21
* [#1888](https://github.com/stripe/stripe-dotnet/pull/1888) Adds `ExecutivesProvided` to `Account`

## 34.7.0 - 2019-12-19
* [#1887](https://github.com/stripe/stripe-dotnet/pull/1887) Add support for `Metadata` and `Livemode` to Terminal `Reader` and `Location`

## 34.6.0 - 2019-12-17
* [#1881](https://github.com/stripe/stripe-dotnet/pull/1881) Make `StripeTypeRegistry.ObjectsToTypes` dictionary public

## 34.5.0 - 2019-12-13
* [#1878](https://github.com/stripe/stripe-dotnet/pull/1878) Mark `Connect` as obsolete on `WebhookEndpoint` and add documentation

## 34.4.0 - 2019-12-12
* [#1877](https://github.com/stripe/stripe-dotnet/pull/1877) Add support for `AuthorizationControls` on Issuing `Cardholder`

## 34.3.0 - 2019-12-09
* [#1872](https://github.com/stripe/stripe-dotnet/pull/1872) Add support for AU BECS Debit on PaymentMethod

## 34.2.0 - 2019-12-09
* [#1869](https://github.com/stripe/stripe-dotnet/pull/1869) Add `EventUtility.ValidateSignature` method

## 34.1.0 - 2019-12-04
* [#1866](https://github.com/stripe/stripe-dotnet/pull/1866) Add `Network` and `GeneratedCard` on `Charge` for card and card-present transactions

## 34.0.0 - 2019-12-03
* [#1838](https://github.com/stripe/stripe-dotnet/pull/1838) Major version released with the following breaking changes in it:
  * [#1863](https://github.com/stripe/stripe-dotnet/pull/1863) ⚠️  Pin to API version `2019-12-03`
  * [#1837](https://github.com/stripe/stripe-dotnet/pull/1837) ⚠️  Renamed `ParametersOptions` to `ReportRunParametersOptions` on `ReportRun`
  * [#1841](https://github.com/stripe/stripe-dotnet/pull/1841) ⚠️  `Created` is not be nullable anymore on any resource
  * [#1852](https://github.com/stripe/stripe-dotnet/pull/1852) ⚠️  Removed `PhonNumber` on Issuing `Cardholder` in favour of `PhoneNumber` and `PersonalIdNumber` on Person creation and update in favour of `IdNumber`
  * [#1850](https://github.com/stripe/stripe-dotnet/pull/1850) ⚠️  Rename a few options classes to have Options in the name instead of Option
    * `InvoiceUpcomingInvoiceItemOption` is now `InvoiceUpcomingInvoiceItemOptions`.
    * `SubscriptionItemOption` is now `SubscriptionItemOptions`.
    * `SubscriptionItemUpdateOption` is now merged into `SubscriptionItemOptions`.
  * [#1851](https://github.com/stripe/stripe-dotnet/pull/1851) Fix multiple TODOs in tests

## 33.9.0 - 2019-12-02
* [#1861](https://github.com/stripe/stripe-dotnet/pull/1861) Allow filtering Invoices by `Status`

## 33.8.0 - 2019-11-26
* [#1856](https://github.com/stripe/stripe-dotnet/pull/1856) Add support for `CreditNote` preview
* [#1855](https://github.com/stripe/stripe-dotnet/pull/1855) Default optional options for custom actions to null
* [#1854](https://github.com/stripe/stripe-dotnet/pull/1854) Add support for reverse auto-pagination passing `EndingBefore`

## 33.7.0 - 2019-11-25
* [#1849](https://github.com/stripe/stripe-dotnet/pull/1849) Add support for `OutOfBandAmount` on `CreditNote` creation

## 33.6.0 - 2019-11-22
* [#1847](https://github.com/stripe/stripe-dotnet/pull/1847) Add support for `SubscriptionScheduleStartDate.Now`

## 33.5.0 - 2019-11-21
* [#1845](https://github.com/stripe/stripe-dotnet/pull/1845) Add `PaymentIntent` filter when listing `Dispute`s

## 33.4.0 - 2019-11-19
* [#1842](https://github.com/stripe/stripe-dotnet/pull/1842) Add support for `ViolatedAuthorizationControls` on Issuing `Authorization`

## 33.3.0 - 2019-11-07
* [#1835](https://github.com/stripe/stripe-dotnet/pull/1835) Add support for Issuing Cardholder verification
* [#1836](https://github.com/stripe/stripe-dotnet/pull/1836) stripe-mock Windows binary is now a ZIP

## 33.2.0 - 2019-11-06
* [#1831](https://github.com/stripe/stripe-dotnet/pull/1831) Multiple API changes
  * Add `Disputed` to `Charge`
  * Add `PaymentIntent` to `Refund` and `Dispute`
  * Add `Charge` to `DisputeListParams`
  * Add `PaymentIntent` to `RefundListParams` and `RefundParams`

## 33.1.0 - 2019-11-06
* [#1830](https://github.com/stripe/stripe-dotnet/pull/1830) Add support for iDEAL and SEPA debit on `PaymentMethod`

## 33.0.0 - 2019-11-05
* [#1826](https://github.com/stripe/stripe-dotnet/pull/1826) Move to the latest API version and add new changes
  * Move to API version `2019-11-05`
  * Add `DefaultSettings` on `SubscriptionSchedule`
  * Remove `BillingThresholds`, `CollectionMethod`, `DefaultPaymentMethod` and `DefaultSource` and `invoice_settings` from `SubscriptionSchedule`
  * `OffSession` on `PaymentIntent` is now always a boolean
  * Disabling using global settings when serializing or deserializing JSON.

## 32.2.0 - 2019-11-04
* [#1829](https://github.com/stripe/stripe-dotnet/pull/1829) Add support for `UseStripeSdk` on `PaymentIntent` create and confirm

## 32.1.3 - 2019-10-28
* [#1824](https://github.com/stripe/stripe-dotnet/pull/1824) Fix `SucceededAt` on `ReportRun` to be nullable
    * This is technically a breaking change, but we're releasing as a patch version as the non-nullable type made it impossible to deserialize `report_run` objects in many cases.

## 32.1.2 - 2019-10-24
* [#1822](https://github.com/stripe/stripe-dotnet/pull/1822) Add missing `Installments` option in `PaymentIntentPaymentMethodOptionsCardOptions`

## 32.1.1 - 2019-10-24
* [#1821](https://github.com/stripe/stripe-dotnet/pull/1821) Fix installments to use the correct type
* [#1820](https://github.com/stripe/stripe-dotnet/pull/1820) Contributor Convenant

## 32.1.0 - 2019-10-23
* [#1819](https://github.com/stripe/stripe-dotnet/pull/1819) Add support for `PendingInvoiceItemInterval` on `Subscription`
* [#1818](https://github.com/stripe/stripe-dotnet/pull/1818) Add support for installments for MX accounts

## 32.0.0 - 2019-10-18
* [#1815](https://github.com/stripe/stripe-dotnet/pull/1815) Multiple breaking changes:
  * Pin to the latest API version `2019-10-17`
  * Remove `RenewalBehavior` on `SubscriptionSchedule`
  * Remove `RenewalInterval` as a parameter on `SubscriptionSchedule`

## 31.2.0 - 2019-10-17
* [#1814](https://github.com/stripe/stripe-dotnet/pull/1814) Add various API changes
  * `Requirements` and `IsDefault` on Issuing `Cardholder`.
  * Fix the name of `PhoneNumber` on Issuing `Cardholder`.
  * `PaymentMethodDetails.AuBecsDebit` on `Charge`.
  * `PaymentBehavior` on `SubscriptionItem` creation is now supported.
  * `SubscriptionData.TrialFromPlan` is now supported on Checkout `Session` creation.

## 31.1.0 - 2019-10-10
* [#1813](https://github.com/stripe/stripe-dotnet/pull/1813) Add support for Account and Person `Token` creation

## 31.0.0 - 2019-10-10
* [#1812](https://github.com/stripe/stripe-dotnet/pull/1812) Remove the `Card.ThreeDSecure` property

## 30.1.0 - 2019-10-09
* [#1810](https://github.com/stripe/stripe-dotnet/pull/1810) Add `DeviceType` filter when listing Terminal `Reader`s

## 30.0.1 - 2019-10-09
* [#1809](https://github.com/stripe/stripe-dotnet/pull/1809) Fix `Quantity` to be nullable on `SubscriptionSchedulePhaseItem`

## 30.0.0 - 2019-10-08
* [#1694](https://github.com/stripe/stripe-dotnet/pull/1694)
Major version release. Refer to our [migration guide for v30](https://github.com/stripe/stripe-dotnet/wiki/Migration-guide-for-v30) for a list of backwards incompatible changes to watch out for.

Pull requests included in this release (cf. [#1694](https://github.com/stripe/stripe-dotnet/pull/1694)) (⚠️ = breaking changes):
* [#1675](https://github.com/stripe/stripe-dotnet/pull/1675) ⚠️ Better string enums
* [#1699](https://github.com/stripe/stripe-dotnet/pull/1699) ⚠️ Init options with forced parameter values
* [#1713](https://github.com/stripe/stripe-dotnet/pull/1713) ⚠️ Remove various deprecated parameters and properties
* [#1715](https://github.com/stripe/stripe-dotnet/pull/1715) ⚠️ Remove support for `ExpandXXX` on each service
* [#1736](https://github.com/stripe/stripe-dotnet/pull/1736) ⚠️ Properly use `SetupIntentPaymentMethodOptionsCardOptions` in `SetupIntentPaymentMethodOptionsOptions`
* [#1738](https://github.com/stripe/stripe-dotnet/pull/1738) ⚠️ Removed `Id` and `FileId` suffixes to stay as close to the API as possible
* [#1744](https://github.com/stripe/stripe-dotnet/pull/1744) Add a test to ensure that JSON names match property names
* [#1739](https://github.com/stripe/stripe-dotnet/pull/1739) ⚠️ Renaming a few more fields for consistency
* [#1751](https://github.com/stripe/stripe-dotnet/pull/1751) Remove dead code for service expansions
* [#1752](https://github.com/stripe/stripe-dotnet/pull/1752) Bump Stylecop.Analyzers to latest version
* [#1755](https://github.com/stripe/stripe-dotnet/pull/1755) Bump SourceLink and create symbol package
* [#1788](https://github.com/stripe/stripe-dotnet/pull/1788) Add a test to ensure all resources inherit from `StripeEntity<>` and fix all the ones not doing it yet
* [#1761](https://github.com/stripe/stripe-dotnet/pull/1761) ⚠️ Add a wholesome test to ensure proper JSON converters are applied
* [#1802](https://github.com/stripe/stripe-dotnet/pull/1802) ⚠️ Remove more deprecated stuff
* [#1803](https://github.com/stripe/stripe-dotnet/pull/1803) ⚠️ Remove more `Id`/`FileId` suffixes
* [#1805](https://github.com/stripe/stripe-dotnet/pull/1805) ⚠️ Rename `SourceThreeDSecureCreateOptions.CardId` to `SourceThreeDSecureCreateOptions.Card`
* [#1806](https://github.com/stripe/stripe-dotnet/pull/1806) ⚠️ Fix `ExternalAccountUpdateOptions`
* [#1804](https://github.com/stripe/stripe-dotnet/pull/1804) Enable test for JSON<->property name consistency
* [#1807](https://github.com/stripe/stripe-dotnet/pull/1807) ⚠️ Rename `AccountOpener` to `Representative` and move to latest API version `2019-10-08`

## 29.6.0 - 2019-10-03
* [#1800](https://github.com/stripe/stripe-dotnet/pull/1800) Add `PaymentIntentCanceled` and `SetupIntentCanceled` constants
* [#1799](https://github.com/stripe/stripe-dotnet/pull/1799) Start testing .NET Core 3.0
* [#1798](https://github.com/stripe/stripe-dotnet/pull/1798) Exclude auto-implemented properties from code coverage

## 29.5.0 - 2019-09-27
* [#1797](https://github.com/stripe/stripe-dotnet/pull/1797) Support `Status` filter when listing Terminal `Reader`s

## 29.4.0 - 2019-09-26
* [#1794](https://github.com/stripe/stripe-dotnet/pull/1794) Add support for FPX payment method

## 29.3.0 - 2019-09-25
* [#1789](https://github.com/stripe/stripe-dotnet/pull/1789) Add `Last4` in AU BECS `Source`

## 29.2.1 - 2019-09-23
* [#1791](https://github.com/stripe/stripe-dotnet/pull/1791) Add support for `Stripe-Should-Retry` header

## 29.2.0 - 2019-09-19
* [#1786](https://github.com/stripe/stripe-dotnet/pull/1786) Properly pass the type in `StripeEntity`

## 29.1.0 - 2019-09-13
* [#1785](https://github.com/stripe/stripe-dotnet/pull/1785) Properly name `UnitAmountDecimal` on `PlanTier`

## 29.0.1 - 2019-09-12
* [#1783](https://github.com/stripe/stripe-dotnet/pull/1783) Allow `VoidedAt` on `CreditNote` to be nullable
  * This is technically a breaking change, but we're releasing as a patch version as the non-nullable type made it impossible to deserialize `credit_note` objects in most cases.

## 29.0.0 - 2019-09-10
* [#1780](https://github.com/stripe/stripe-dotnet/pull/1780) Bump API version to [`2019-09-09`](https://docs.stripe.com/changelog/2019-09-09)

## 28.11.0 - 2019-09-09
* [#1778](https://github.com/stripe/stripe-dotnet/pull/1778) Changes to `Account` and `Person` for identity verification

## 28.10.0 - 2019-09-04
* [#1775](https://github.com/stripe/stripe-dotnet/pull/1775) Add support for `Authentication` and `Url` on Issuing `Authorization`

## 28.9.0 - 2019-09-03
* [#1774](https://github.com/stripe/stripe-dotnet/pull/1774) Add decimal properties to `PlanTierOptions`

## 28.8.0 - 2019-08-29
* [#1770](https://github.com/stripe/stripe-dotnet/pull/1770) Add support for `EndBehavior` on `SubscriptionSchedule`

## 28.7.0 - 2019-08-29
* [#1771](https://github.com/stripe/stripe-dotnet/pull/1771) Add `StripeConfiguration.EnableTelemetry` flag

## 28.6.0 - 2019-08-26
* [#1767](https://github.com/stripe/stripe-dotnet/pull/1767) Add `PendingVerification` on `Account`, `Person` and `Capability`

## 28.5.0 - 2019-08-22
* [#1763](https://github.com/stripe/stripe-dotnet/pull/1763) Add support for decimal amounts on `InvoiceItem` and `Plan` and missing `Period`

## 28.4.0 - 2019-08-21
* [#1758](https://github.com/stripe/stripe-dotnet/pull/1758) A few Billing changes
  * Add support for `Schedule` to `Subscription`
  * Add missing parameters to `UpcomingInvoiceOptions` and `UpcomingInvoiceListLineItemsOptions`: `Schedule`, `SubscriptionCancelAt` and `SubscriptionCancelNow`
  * Add missing properties and parameters for a `SubscriptionSchedule` phase: `BillingThresholds`, `CollectionMethod`, `DefaultPaymentMethod` and `InvoiceSettings`
* [#1760](https://github.com/stripe/stripe-dotnet/pull/1760) Add support for `Mode` and `SetupIntent` on Checkout `Session`

## 28.3.0 - 2019-08-20
* [#1756](https://github.com/stripe/stripe-dotnet/pull/1756) Add missing `StartDate` parameter for `SubscriptionSchedule` Update

## 28.2.0 - 2019-08-16
* [#1750](https://github.com/stripe/stripe-dotnet/pull/1750) Make `ChargePaymentMethodDetailsCard.Moto` nullable

## 28.1.0 - 2019-08-15
* [#1748](https://github.com/stripe/stripe-dotnet/pull/1748)
  * Add support for `PIN` on Issuing `Card` to reflect the status of a card's PIN
  * Add support for `Executive` on Person create, update and list

## 28.0.0 - 2019-08-14
* [#1747](https://github.com/stripe/stripe-dotnet/pull/1747) Move to API version [`2019-08-14`](https://docs.stripe.com/changelog/2019-08-14)
  * Rename `platform_payments` to `transfers` in `Account`
  * Introduce `executive` as a relationship on `Person`
* [#1746](https://github.com/stripe/stripe-dotnet/pull/1746) Fix argument names in `SetupIntentService` methods

## 27.25.1 - 2019-08-14
* [#1745](https://github.com/stripe/stripe-dotnet/pull/1745) Fix duplicate expand values issue

## 27.25.0 - 2019-08-14
* [#1742](https://github.com/stripe/stripe-dotnet/pull/1742) Support passing `Metadata` on `BankAccount` creation

## 27.24.0 - 2019-08-09
* [#1734](https://github.com/stripe/stripe-dotnet/pull/1734) Remove `SubscriptionScheduleRevision`.
  * Note that this is technically a breaking change, however we've chosen to release it as a minor version in light of the fact that this resource and its API methods were virtually unused.

## 27.23.0 - 2019-08-08
* [#1732](https://github.com/stripe/stripe-dotnet/pull/1732)
  * Add support for `PaymentMethodDetails.Card.Moto` on `Charge`
  * Add support `StatementDescriptorSuffix` on `Charge` and `PaymentIntent`
  * Add support `SubscriptionData.ApplicationFeePercent` on Checkout `Session`

## 27.22.0 - 2019-08-08
* [#1733](https://github.com/stripe/stripe-dotnet/pull/1733) Add missing `IHas*` interfaces everywhere

## 27.21.0 - 2019-08-01
* [#1723](https://github.com/stripe/stripe-dotnet/pull/1723) Add support for Klarna on Sources

## 27.20.0 - 2019-07-31
* [#1727](https://github.com/stripe/stripe-dotnet/pull/1727) Add missing Radar events

## 27.19.0 - 2019-07-30
* [#1724](https://github.com/stripe/stripe-dotnet/pull/1724) Move the List `BalanceTransaction` API to `/v1/balance_transactions`

## 27.18.0 - 2019-07-26
* [#1722](https://github.com/stripe/stripe-dotnet/pull/1722) Add support for `Metadata` on `SubscriptionItemOption`

## 27.17.0 - 2019-07-25
* [#1719](https://github.com/stripe/stripe-dotnet/pull/1719) Add support for `Authenticated` on Charge for 3DS results in `ChargePaymentMethodDetailsCardThreeDSecure`

## 27.16.1 - 2019-07-23
* [#1718](https://github.com/stripe/stripe-dotnet/pull/1718) Fix `NullReferenceException` when auto-paginating without parameters

## 27.16.0 - 2019-07-22
* [#1716](https://github.com/stripe/stripe-dotnet/pull/1716) Add support for `StatementDescriptor` on `PaymentIntent` capture

## 27.15.0 - 2019-07-19
* [#1711](https://github.com/stripe/stripe-dotnet/pull/1711) Add `Customer` filter when listing `CreditNote`
* [#1712](https://github.com/stripe/stripe-dotnet/pull/1712) Add `OffSession` parameter when updating `SubscriptionItem`

## 27.14.1 - 2019-07-18
* [#1703](https://github.com/stripe/stripe-dotnet/pull/1703) Ignore null elements when autopaginating

## 27.14.0 - 2019-07-17
* [#1710](https://github.com/stripe/stripe-dotnet/pull/1710) Add support for `VoidedAt` on `CreditNote`

## 27.13.0 - 2019-07-15
* [#1708](https://github.com/stripe/stripe-dotnet/pull/1708) Add support for `PaymentMethodOptions` on `PaymentIntent` and `SetupIntent`

## 27.12.0 - 2019-07-15
* [#1706](https://github.com/stripe/stripe-dotnet/pull/1706) Various changes relaed to SCA for Billing
  * Add support for `PendingSetupIntent` on `Subscription`
  * Add support for `PaymentBehavior` on `Subscription` creation and update
  * Add support for `PaymentBehavior` on `SubscriptionItem` update
  * Add support for `OffSession` when paying an `Invoice`
  * Add support for `OffSession` on `Subscription` creation and update

## 27.11.0 - 2019-07-11
* [#1705](https://github.com/stripe/stripe-dotnet/pull/1705) Fix missing interfaces

## 27.10.0 - 2019-07-09
* [#1696](https://github.com/stripe/stripe-dotnet/pull/1696) Add support for `Confirm` and `ReturnUrl` on `SetupIntent` creation

## 27.9.1 - 2019-07-09
* [#1702](https://github.com/stripe/stripe-dotnet/pull/1702) Don't create `AnyOf` instances with null values

## 27.9.0 - 2019-07-05
* [#1687](https://github.com/stripe/stripe-dotnet/pull/1687) Add support for `SetupFutureUsage` on `PaymentIntent` update and confirm
* [#1693](https://github.com/stripe/stripe-dotnet/pull/1693) Add support for `SetupFutureUsage` on Checkout `Session`

## 27.8.1 - 2019-07-03
* [#1689](https://github.com/stripe/stripe-dotnet/pull/1689) Add documentation for the `PaymentIntent` resource and APIs

## 27.8.0 - 2019-07-02
* [#1688](https://github.com/stripe/stripe-dotnet/pull/1688) Remove `Equals` and `GetHashCode` methods from `AnyOf`

## 27.7.0 - 2019-07-02
* [#1679](https://github.com/stripe/stripe-dotnet/pull/1679) Add `CollectionMethod` for `Invoice` and `Subscription`

## 27.6.0 - 2019-07-01
* [#1686](https://github.com/stripe/stripe-dotnet/pull/1686) Allow `OffSession` to be a bool or a string on `PaymentIntent` creation and confirmation

## 27.5.0 - 2019-07-01
* [#1682](https://github.com/stripe/stripe-dotnet/pull/1682) Add support for the `SetupIntent` resource and APIs
* [#1684](https://github.com/stripe/stripe-dotnet/pull/1684) Add `DefaultSource` and `DefaultPaymentMethod` on `SubscriptionSchedule`

## 27.4.0 - 2019-06-26
* [#1680](https://github.com/stripe/stripe-dotnet/pull/1680) Allow null API key in `StripeClient`

## 27.3.2 - 2019-06-20
* [#1671](https://github.com/stripe/stripe-dotnet/pull/1671) Use own JSON encoding options for telemetry data

## 27.3.1 - 2019-06-17
* [#1668](https://github.com/stripe/stripe-dotnet/pull/1668) Manually enable TLS 1.2 for .NET Framework 4.5

## 27.3.0 - 2019-06-17
* [#1606](https://github.com/stripe/stripe-dotnet/pull/1606) Add support for `CustomerBalanceTransaction` resource and APIs

## 27.2.0 - 2019-06-14
* [#1664](https://github.com/stripe/stripe-dotnet/pull/1664) Add support for `MerchantAmount` `MerchantCurrency` to Issuing `Transaction`
* [#1665](https://github.com/stripe/stripe-dotnet/pull/1665) Add support for `SubmitType` to Checkout `Session`

## 27.1.3 - 2019-06-12
* [#1660](https://github.com/stripe/stripe-dotnet/pull/1660) Fix possible NRE in expandable field accessors
* [#1661](https://github.com/stripe/stripe-dotnet/pull/1661) Fix handling of null values with `AnyOf`

## 27.1.2 - 2019-06-10
* [#1658](https://github.com/stripe/stripe-dotnet/pull/1658) Add `ConfigureAwait(false)` to all async calls

## 27.1.1 - 2019-06-10
* [#1656](https://github.com/stripe/stripe-dotnet/pull/1656) Fix JSON property name for `Person.IdNumberProvided`
* [#1657](https://github.com/stripe/stripe-dotnet/pull/1657) Fix file creation requests

## 27.1.0 - 2019-06-10
* [#1655](https://github.com/stripe/stripe-dotnet/pull/1655) Add setters for expandable fields properties

## 27.0.0 - 2019-06-07
Major version release. Refer to our [migration guide for v27](https://github.com/stripe/stripe-dotnet/wiki/Migration-guide-for-v27) for a list of backwards incompatible changes to watch out for.

Pull requests included in this release (cf. [#1482](https://github.com/stripe/stripe-dotnet/pull/1482)):
* [#1480](https://github.com/stripe/stripe-dotnet/pull/1480) Remove unnecessary uses of `Mapper`
* [#1478](https://github.com/stripe/stripe-dotnet/pull/1478) Better serialization
* [#1483](https://github.com/stripe/stripe-dotnet/pull/1483) Standardize signature of `OAuthTokenService.Deauthorize`
* [#1484](https://github.com/stripe/stripe-dotnet/pull/1484) New `FromJson` method
* [#1485](https://github.com/stripe/stripe-dotnet/pull/1485) Modernize `StripeConfiguration`
* [#1488](https://github.com/stripe/stripe-dotnet/pull/1488) Simplify `Service` request methods
* [#1489](https://github.com/stripe/stripe-dotnet/pull/1489) Replace `Parameter` custom class with `KeyValuePair<string, string>`
* [#1490](https://github.com/stripe/stripe-dotnet/pull/1490) Move base URLs out of resource services where possible
* [#1481](https://github.com/stripe/stripe-dotnet/pull/1481) Rewrite expandable field handling
* [#1493](https://github.com/stripe/stripe-dotnet/pull/1493) Refactor `Client` class
* [#1494](https://github.com/stripe/stripe-dotnet/pull/1494) Minor code fixes
* [#1496](https://github.com/stripe/stripe-dotnet/pull/1496) Remove `Mapper` class
* [#1500](https://github.com/stripe/stripe-dotnet/pull/1500) Minor improvements in `EventUtility`
* [#1499](https://github.com/stripe/stripe-dotnet/pull/1499) Simplify handling of `Expand` and `ExtraParams`
* [#1504](https://github.com/stripe/stripe-dotnet/pull/1504) More request encoding refactoring
* [#1508](https://github.com/stripe/stripe-dotnet/pull/1508) Introduce new `Request` class to represent requests to Stripe's API
* [#1509](https://github.com/stripe/stripe-dotnet/pull/1509) Fixes to `FileService` and `OAuthTokenService`
* [#1487](https://github.com/stripe/stripe-dotnet/pull/1487) Replace `Requestor` with `StripeClient` and `HttpClient`
* [#1511](https://github.com/stripe/stripe-dotnet/pull/1511) Remove extension methods
* [#1513](https://github.com/stripe/stripe-dotnet/pull/1513) Add support for telemetry
* [#1516](https://github.com/stripe/stripe-dotnet/pull/1516) Make `parent` on `OrderItem` expandable
* [#1519](https://github.com/stripe/stripe-dotnet/pull/1519) Add missing attributes to `StripeError`
* [#1518](https://github.com/stripe/stripe-dotnet/pull/1518) Automatic request retries
* [#1534](https://github.com/stripe/stripe-dotnet/pull/1534) Remove parameters are internal only on `PaymentIntent`
* [#1537](https://github.com/stripe/stripe-dotnet/pull/1537) Various minor cleanups
* [#1536](https://github.com/stripe/stripe-dotnet/pull/1536) Check validity of JSON in OK responses
* [#1520](https://github.com/stripe/stripe-dotnet/pull/1520) API key validation
* [#1538](https://github.com/stripe/stripe-dotnet/pull/1538) Enforce that all properties have a Json attribute
* [#1542](https://github.com/stripe/stripe-dotnet/pull/1542) Improved OAuth support
* [#1563](https://github.com/stripe/stripe-dotnet/pull/1563) Rename `DuplicateChargeDocumentation` to be more consistent with `FileId`
* [#1495](https://github.com/stripe/stripe-dotnet/pull/1495) `AnyOf<>` generic class to handle polymorphic parameters
* [#1598](https://github.com/stripe/stripe-dotnet/pull/1598) Add support for `file_link_data`
* [#1596](https://github.com/stripe/stripe-dotnet/pull/1596) Add support for passing application information
* [#1603](https://github.com/stripe/stripe-dotnet/pull/1603) Rename `StripeConnectAccountId` to `StripeAccount`
* [#1602](https://github.com/stripe/stripe-dotnet/pull/1602) Update README
* [#1609](https://github.com/stripe/stripe-dotnet/pull/1609) Add wholesome test to check JSON names
* [#1615](https://github.com/stripe/stripe-dotnet/pull/1615) Remove `System.Collections.Immutable` dependency
* [#1616](https://github.com/stripe/stripe-dotnet/pull/1616) Raise `ArgumentException` on null or empty IDs
* [#1623](https://github.com/stripe/stripe-dotnet/pull/1623) Move default values for `SystemNetHttpClient`
* [#1622](https://github.com/stripe/stripe-dotnet/pull/1622) Remove `StripeConfiguration.EnableTelemetry` flag
* [#1631](https://github.com/stripe/stripe-dotnet/pull/1631) Refactor `StripeClient` setup in tests
* [#1632](https://github.com/stripe/stripe-dotnet/pull/1632) Set base URLs in StripeClient instead of StripeConfiguration
* [#1633](https://github.com/stripe/stripe-dotnet/pull/1633) Add support for setting API key and client ID in `StripeClient`
* [#1634](https://github.com/stripe/stripe-dotnet/pull/1634) Use `StripeClient` instance in tests
* [#1635](https://github.com/stripe/stripe-dotnet/pull/1635) Add support for setting `MaxNetworkRetries` and `AppInfo` in `SystemNetHttpClient`
* [#1640](https://github.com/stripe/stripe-dotnet/pull/1640) Make base URLs in `StripeClient` readonly
* [#1639](https://github.com/stripe/stripe-dotnet/pull/1639) Make client in services readonly
* [#1643](https://github.com/stripe/stripe-dotnet/pull/1643) Add `AddRangeExpand` method to `BaseOptions`
* [#1644](https://github.com/stripe/stripe-dotnet/pull/1644) Add options classes for `Get`/`GetAsync` methods
* [#1646](https://github.com/stripe/stripe-dotnet/pull/1646) Deprecate `Expand` properties on services
* [#1647](https://github.com/stripe/stripe-dotnet/pull/1647) Use constants instead of static strings
* [#1648](https://github.com/stripe/stripe-dotnet/pull/1648) Update `README.md`

## 26.1.0 - 2019-06-06
* [#1637](https://github.com/stripe/stripe-dotnet/pull/1637) Add support for `Location` on Terminal `ConnectionToken`
* [#1638](https://github.com/stripe/stripe-dotnet/pull/1638) Add support for `Balance` and deprecate `AccountBalance` on Customer

## 26.0.0 - 2019-05-24
* [#1628](https://github.com/stripe/stripe-dotnet/pull/1628) Pin library to API version `2019-05-16`

## 25.20.0 - 2019-05-24
* [#1626](https://github.com/stripe/stripe-dotnet/pull/1626) Add support for `radar.early_warning_fraud` resource
* [#1629](https://github.com/stripe/stripe-dotnet/pull/1629) Add missing `description` parameter to `PayoutCreateOptions`

## 25.19.1 - 2019-05-22
* [#1624](https://github.com/stripe/stripe-dotnet/pull/1624) Update comment for `TaxId.Type` with new possible types

## 25.19.0 - 2019-05-16
* [#1617](https://github.com/stripe/stripe-dotnet/pull/1617) Add `OffSession` parameter to `PaymentIntent`
* [#1618](https://github.com/stripe/stripe-dotnet/pull/1618) Add support for kana and kanji variations of statement descriptors

## 25.18.0 - 2019-05-14
* [#1612](https://github.com/stripe/stripe-dotnet/pull/1612) Add support for the `Capability` resource and APIs

## 25.17.0 - 2019-05-10
* [#1613](https://github.com/stripe/stripe-dotnet/pull/1613) Add `StartDate` to `Subscription`

## 25.16.1 - 2019-05-07
* [#1610](https://github.com/stripe/stripe-dotnet/pull/1610) Mark `OperatorAccount` as deprecated across all Terminal APIs

## 25.16.0 - 2019-05-06
* [#1607](https://github.com/stripe/stripe-dotnet/pull/1607) Support listing Charges by PaymentIntent id
* [#1608](https://github.com/stripe/stripe-dotnet/pull/1608) Add missing constants for known Events

## 25.15.0 - 2019-05-03
* [#1601](https://github.com/stripe/stripe-dotnet/pull/1601) Add support for `ReplacementFor` and `ReplacementReason` on Issuing `Card` creation
* [#1605](https://github.com/stripe/stripe-dotnet/pull/1605) Fix multiple properties to have the right JSON name.

## 25.14.0 - 2019-05-02
* [#1600](https://github.com/stripe/stripe-dotnet/pull/1600) Add support for `CustomerId` on `PaymentIntentListOptions`

## 25.13.0 - 2019-04-29
* [#1595](https://github.com/stripe/stripe-dotnet/pull/1595) Add support for ACSS debit Sources

## 25.12.0 - 2019-04-24
* [#1593](https://github.com/stripe/stripe-dotnet/pull/1593) Add missing event types

## 25.11.0 - 2019-04-24
* [#1572](https://github.com/stripe/stripe-dotnet/pull/1572) Add support for the `TaxRate` resource and APIs

## 25.10.0 - 2019-04-22
* [#1578](https://github.com/stripe/stripe-dotnet/pull/1578) Add support for the `TaxId` resource and APIs
* [#1587](https://github.com/stripe/stripe-dotnet/pull/1587) Add missing `person.*` events
* [#1588](https://github.com/stripe/stripe-dotnet/pull/1588) Add `CustomerEmail` to `Invoice`

## 25.9.0 - 2019-04-18
* [#1564](https://github.com/stripe/stripe-dotnet/pull/1564) Add support for the `CreditNote` resource and APIs
* [#1574](https://github.com/stripe/stripe-dotnet/pull/1574) Add support for `Address`, `Name`, `Phone` and `PreferredLocales` on `Customer` and related fields on `Invoice`

## 25.8.0 - 2019-04-16
* [#1440](https://github.com/stripe/stripe-dotnet/pull/1440) Add support for the Checkout `Session` resource and APIs
* [#1577](https://github.com/stripe/stripe-dotnet/pull/1577) Add support for `Version` and `Succeeded` properties in `ChargePaymentMethodDetailsCardThreeDSecure`
* [#1581](https://github.com/stripe/stripe-dotnet/pull/1581) Add support for passing `PaymentMethodId` on `Customer` creation

## 25.7.1 - 2019-04-16
* [#1582](https://github.com/stripe/stripe-dotnet/pull/1582) Fix `AuthorizationResponseCode` and `CardholderVerificationMethod` on `ChargePaymentMethodDetailsCardPresentReceipt` to be `string` instead of `long`
* [#1583](https://github.com/stripe/stripe-dotnet/pull/1583) Fix `BillingDetailsOptions` to support `Email`, `Name` and `Phone` and remove the other invalid properties for `PaymentMethod` create and update

## 25.7.0 - 2019-04-15
* [#1580](https://github.com/stripe/stripe-dotnet/pull/1580) Make `payment_intent` on `Invoice` expandable instead of being auto-expanded

## 25.6.0 - 2019-04-09
* [#1573](https://github.com/stripe/stripe-dotnet/pull/1573) Add support for the `confirmation_method` parameter on `PaymentIntent` creation

## 25.5.0 - 2019-04-09
* [#1567](https://github.com/stripe/stripe-dotnet/pull/1567) Add support for `PaymentIntent` and `PaymentMethod` on `Customer`, `Invoice` and `Subscription`

## 25.4.0 - 2019-04-05
* [#1568](https://github.com/stripe/stripe-dotnet/pull/1568) Add BECS Source Type

## 25.3.0 - 2019-03-29
* [#1562](https://github.com/stripe/stripe-dotnet/pull/1562) Add support for `submit` when updating a `Dispute`

## 25.2.0 - 2019-03-25
* [#1559](https://github.com/stripe/stripe-dotnet/pull/1559) Added `Incomplete` and `IncompleteExpired` subscription statuses

## 25.1.0 - 2019-03-22
* [#1557](https://github.com/stripe/stripe-dotnet/pull/1557) Add support for `person_token` on `Person` creation

## 25.0.0 - 2019-03-19
* [#1552](https://github.com/stripe/stripe-dotnet/pull/1552) Add support for API version [2019-03-14](https://docs.stripe.com/changelog/2019-03-14):
  * The library is now pinned to API version `2019-03-14`.
  * Subscriptions are now created with `status: "incomplete"` if the first payment fails.
  * `PaymentIntentLastPaymentError` was removed in favour of `StripeError`.

## 24.6.0 - 2019-03-18
* [#1541](https://github.com/stripe/stripe-dotnet/pull/1541) Add support for the `PaymentMethod` resource and APIs
* [#1554](https://github.com/stripe/stripe-dotnet/pull/1554) Add support for deleting a Terminal `Location` and `Reader`

## 24.5.0 - 2019-03-13
* [#1551](https://github.com/stripe/stripe-dotnet/pull/1551) Add support for `columns` on `ReportRun` and `default_columns` on `ReportType`

## 24.4.1 - 2019-03-11
* Fix 24.4.0 release. The version that was pushed to NuGet did not include the changes from 24.4.0.

## 24.4.0 - 2019-03-11
* [#1550](https://github.com/stripe/stripe-dotnet/pull/1550) Add support for `amount` on `Issuing.Transaction`

## 24.3.0 - 2019-03-06
* [#1548](https://github.com/stripe/stripe-dotnet/pull/1548) Add support for `backdate_start_date` and `cancel_at` on `Subscription`

## 24.2.0 - 2019-03-05
* [#1547](https://github.com/stripe/stripe-dotnet/pull/1547) Add support for `current_period_end` and `current_period_start` when listing `Invoice`s

## 24.1.0 - 2019-02-28
* [#1533](https://github.com/stripe/stripe-dotnet/pull/1533) Add support for `client_secret` and `shipping` on `PaymentIntent` confirmation
* [#1539](https://github.com/stripe/stripe-dotnet/pull/1539) Add support for `status_transitions` and `created` on `Invoice`
* [#1545](https://github.com/stripe/stripe-dotnet/pull/1545) Add support for `latest_invoice` on `Subscription`
* [#1546](https://github.com/stripe/stripe-dotnet/pull/1546) Add support for `api_version` on `WebhookEndpoint`

## 24.0.2 - 2019-02-20
* [#1531](https://github.com/stripe/stripe-dotnet/pull/1531) Fix deserialization of `ChargeTransferData.Amount` when it is `null`

## 24.0.1 - 2019-02-20
* [#1527](https://github.com/stripe/stripe-dotnet/pull/1527) Fix encoding for `SubscriptionScheduleInvoiceSettingsOptions` and `SubscriptionScheduleRenewalIntervalOptions`
* [#1530](https://github.com/stripe/stripe-dotnet/pull/1530) Fix pinned API version to `2019-02-19`

## 24.0.0 - 2019-02-19
**Important:** This version is non-functional and has been yanked in favor of 24.0.1.
* [#1492](https://github.com/stripe/stripe-dotnet/pull/1492) Changes related to the new API version `2019-02-19`:
  * The library is now pinned to API version `2019-02-19`
  * Numerous changes to the `Account` resource and APIs:
    * The `legal_entity` property on the Account API resource has been replaced with `individual`, `company`, and `business_type`.
    * The `verification` hash has been replaced with a `requirements` hash.
    * Multiple top-level properties were moved to the `settings` hash.
    * The `keys` property on `Account` has been removed. Platforms should authenticate as their connected accounts with their own key via the `Stripe-Account` [header](https://stripe.com/docs/connect/authentication#authentication-via-the-stripe-account-header).
  * The `Birthday` class is now named `Dob`.
  * The `TermsOfServiceAcceptance` class is now named `AccountTosAcceptance`.
  * The `requested_capabilities` property on `Account` creation is now required for accounts in the US.
  * The deprecated parameter `save_source_to_customer` on `PaymentIntent` has now been removed. Use `save_payment_method` instead.

## 23.2.0 - 2019-02-19
* [#1526](https://github.com/stripe/stripe-dotnet/pull/1526) Add support for `card_present` sources

## 23.1.0 - 2019-02-18
* [#1523](https://github.com/stripe/stripe-dotnet/pull/1523) Add support for `save_payment_method` when creating, updating and confirming a `PaymentIntent`
* [#1524](https://github.com/stripe/stripe-dotnet/pull/1524) Add support for `requested_capabilities` when creating or updating an `Account` and `capabilities` on the `Account` resource

## 23.0.0 - 2019-02-12
* [#1469](https://github.com/stripe/stripe-dotnet/pull/1469) Add support for `transfer_data[destination]` on `Subscription`.
* [#1501](https://github.com/stripe/stripe-dotnet/pull/1501) Add support for API version `2019-02-11` with changes to Payment Intents
  * The library is now pinned to API version `2019-02-11`.
  * `PaymentIntentSourceAction`, `PaymentIntentSourceActionValueAuthorizeWithUrl` and `NextSourceAction` are now replaced by `PaymentIntentNextAction`, `PaymentIntentNextActionRedirectToUrl` and `NextAction` instead.
  * `AllowedSourceTypes` is now replaced by `PaymentMethodTypes` instead.

## 22.9.0 - 2019-02-12
* [#1491](https://github.com/stripe/stripe-dotnet/pull/1491) Add support for `SubscriptionSchedule` and `SubscriptionScheduleRevision`. Also add support for `InvoiceSettings` on `Customer
* [#1512](https://github.com/stripe/stripe-dotnet/pull/1512) Add support for `TransferData.Amount` on `Charge`

## 22.8.1 - 2019-02-04
* [#1498](https://github.com/stripe/stripe-dotnet/pull/1498) Handle OAuth error messages in `StripeException`

## 22.8.0 - 2019-01-25
* [#1470](https://github.com/stripe/stripe-dotnet/pull/1470) Add support for OAuth methods

## 22.7.0 - 2019-01-19
* [#1438](https://github.com/stripe/stripe-dotnet/pull/1438) Revert license change

## 22.6.0 - 2019-01-17
* [#1475](https://github.com/stripe/stripe-dotnet/pull/1475) Add `OperatorAccount` to Terminal options
* [#1476](https://github.com/stripe/stripe-dotnet/pull/1476) Added `receipt_url` property to `Charge`
* [#1477](https://github.com/stripe/stripe-dotnet/pull/1477) Added `paid_out_of_band` to `Invoice`

## 22.5.0 - 2019-01-17
* [#1471](https://github.com/stripe/stripe-dotnet/pull/1471) Add support for `custom_fields` and `footer` on `Invoice`
* [#1472](https://github.com/stripe/stripe-dotnet/pull/1472) Add support for billing thresholds

## 22.4.0 - 2019-01-10
* [#1456](https://github.com/stripe/stripe-dotnet/pull/1456) Add support for `transfer_data` and `application_fee_amount` on `Charge`
* [#1468](https://github.com/stripe/stripe-dotnet/pull/1468) Add support for `validate` on `Customer` update and `Card` update and creation

## 22.3.0 - 2019-01-09
* [#1415](https://github.com/stripe/stripe-dotnet/pull/1415) Add support for the `AccountLink` resource

## 22.2.0 - 2019-01-09
* [#1467](https://github.com/stripe/stripe-dotnet/pull/1467) Add support for new parameters under `invoice_items[]` for the Upcoming Invoice API

## 22.1.0 - 2019-01-08
* [#1457](https://github.com/stripe/stripe-dotnet/pull/1457) Add support for `invoice` and `pending` when listing invoice items
* [#1458](https://github.com/stripe/stripe-dotnet/pull/1458) Add support for `wallet_provider` on `Issuing.Authorization`

## 22.0.0 - 2019-01-07
Major version release. Refer to our [migration guide for v22](https://github.com/stripe/stripe-dotnet/wiki/Migration-guide-for-v22) for a list of backwards incompatible changes to watch out for.

Pull requests included in this release (cf. [#1416](https://github.com/stripe/stripe-dotnet/pull/1416)):
* [#1413](https://github.com/stripe/stripe-dotnet/pull/1413) Allow paging on upcoming invoice line items
* [#1417](https://github.com/stripe/stripe-dotnet/pull/1417) Add support for verifying sources
* [#1418](https://github.com/stripe/stripe-dotnet/pull/1418) Replace `RecipientActiveAccount` with `BankAccount`
* [#1396](https://github.com/stripe/stripe-dotnet/pull/1396) Fix deserialization logic for polymorphic types
* [#1419](https://github.com/stripe/stripe-dotnet/pull/1419) Replace public fields with properties
* [#1422](https://github.com/stripe/stripe-dotnet/pull/1422) Specify culture for string operations
* [#1424](https://github.com/stripe/stripe-dotnet/pull/1424) Remove overlapping method overloads
* [#1425](https://github.com/stripe/stripe-dotnet/pull/1425) Move `SerializerSettings` to `StripeConfiguration`
* [#1426](https://github.com/stripe/stripe-dotnet/pull/1426) Remove UTF-8 BOMs
* [#1423](https://github.com/stripe/stripe-dotnet/pull/1423) Replace constants with static read-only properties
* [#1427](https://github.com/stripe/stripe-dotnet/pull/1427) Fix compiler warnings
* [#1428](https://github.com/stripe/stripe-dotnet/pull/1428) Make `ObjectsToTypes` dictionary immutable
* [#1429](https://github.com/stripe/stripe-dotnet/pull/1429) Remove `StripeList.TotalCount`
* [#1430](https://github.com/stripe/stripe-dotnet/pull/1430) Rename some properties for consistency
* [#1431](https://github.com/stripe/stripe-dotnet/pull/1431) Rename `StripeDefaultCard` to `DefaultCard` on Recipient
* [#1434](https://github.com/stripe/stripe-dotnet/pull/1434) Make `Deleted` nullable on all Stripe objects
* [#1436](https://github.com/stripe/stripe-dotnet/pull/1436) Make object instances in tests readonly
* [#1435](https://github.com/stripe/stripe-dotnet/pull/1435) Enable SourceLink
* [#1437](https://github.com/stripe/stripe-dotnet/pull/1437) Use Mono for .NET Framework targets on UNIX systems
* [#1438](https://github.com/stripe/stripe-dotnet/pull/1438) Fix license packaging
* [#1439](https://github.com/stripe/stripe-dotnet/pull/1439) Fix some remaining StyleCop rules violations
* [#1433](https://github.com/stripe/stripe-dotnet/pull/1433) Fix JSON serialization of Stripe objects
* [#1441](https://github.com/stripe/stripe-dotnet/pull/1442) Disable optimizations in `SecureCompare`
* [#1444](https://github.com/stripe/stripe-dotnet/pull/1444) Refactor test infrastructure
* [#1447](https://github.com/stripe/stripe-dotnet/pull/1447) Minor fixes
* [#1446](https://github.com/stripe/stripe-dotnet/pull/1446) Force the use of lists over arrays
* [#1451](https://github.com/stripe/stripe-dotnet/pull/1451) Remove `Updated` and `UpdatedBy` from `ValueList`
* [#1450](https://github.com/stripe/stripe-dotnet/pull/1450) Better handling of API version mismatch when deserializing events
* [#1414](https://github.com/stripe/stripe-dotnet/pull/1414) Add support for auto-pagination

## 21.9.0 - 2019-01-03
* [#1455](https://github.com/stripe/stripe-dotnet/pull/1455) Add support for deserializing `account.application.*` events

## 21.8.1 - 2019-01-03
* [#1453](https://github.com/stripe/stripe-dotnet/pull/1453) Fix an issue where a `System.ArgumentNullException` exception would be thrown when deserializing some events

## 21.8.0 - 2018-12-27
* [#1449](https://github.com/stripe/stripe-dotnet/pull/1449) Add support for `invoice_now` and `prorate` option on Subscription cancelation

## 21.7.1 - 2018-12-21
* [#1443](https://github.com/stripe/stripe-dotnet/pull/1443) Fix properties on `AuthorizationControls` to be nullable. This should be a breaking change but since Issuing is in beta and the code does not work, we released it as a patch

## 21.7.0 - 2018-11-28
* [#1407](https://github.com/stripe/stripe-dotnet/pull/1407) Add support for the `Review` APIs
* [#1408](https://github.com/stripe/stripe-dotnet/pull/1408) Add missing properties to the `Refund` resource

## 21.6.0 - 2018-11-27
* [#1386](https://github.com/stripe/stripe-dotnet/pull/1386) Add support for `ValueList` and `ValueListItem` for Radar

## 21.5.0 - 2018-11-25
* [#1405](https://github.com/stripe/stripe-dotnet/pull/1405) Add support for `issuing_card` when creating an `EphemeralKey`

## 21.4.1 - 2018-11-16
* [#1395](https://github.com/stripe/stripe-dotnet/pull/1395) Fix deserialization of objects with `DateTime` properties

## 21.4.0 - 2018-11-14
* [#1394](https://github.com/stripe/stripe-dotnet/pull/1394) Add support for `type` when listing `Products`

## 21.3.0 - 2018-11-14
* [#1393](https://github.com/stripe/stripe-dotnet/pull/1393) Add `last_payment_error` on `PaymentIntent`

## 21.2.0 - 2018-11-12
* [#1387](https://github.com/stripe/stripe-dotnet/pull/1387) Add XML comments to `IBalanceTransactionSource`, `IExternalAccount` and `IPaymentSource`
* [#1388](https://github.com/stripe/stripe-dotnet/pull/1388) Add support for Terminal resources
* [#1389](https://github.com/stripe/stripe-dotnet/pull/1389) Add support for providing `client_secret` when retrieving sources and payment intents
* [#1390](https://github.com/stripe/stripe-dotnet/pull/1390) Rename files to fix warnings

## 21.1.0 - 2018-11-09
* [#1383](https://github.com/stripe/stripe-dotnet/pull/1383) Add `Created` and `CreatedRange` to `CouponListOptions`, `ProductListOptions` and `RefundListOptions`
* [#1385](https://github.com/stripe/stripe-dotnet/pull/1385) Add `Source` to `ChargeListOptions`

## 21.0.0 - 2018-11-08
* [#1343](https://github.com/stripe/stripe-dotnet/pull/1343) Add new API endpoints for the `Invoice` resource.
* [#1373](https://github.com/stripe/stripe-dotnet/pull/1373) Add support for `flat_amount` on `Plan`.
* [#1372](https://github.com/stripe/stripe-dotnet/pull/1372) Support new properties and parameters for PaymentIntent: #1372

## 20.4.1 - 2018-11-08
* [#1377](https://github.com/stripe/stripe-dotnet/pull/1377) Fix an issue where dictionary keys (such as `Metadata` keys) weren't URL-encoded

## 20.4.0 - 2018-11-05
* [#1366](https://github.com/stripe/stripe-dotnet/pull/1366) Add `TrialPeriodDays` to `PlanUpdateOptions`

## 20.3.0 - 2018-10-31
* [#1332](https://github.com/stripe/stripe-dotnet/pull/1332) Add support for the `Person` resource
* [#1342](https://github.com/stripe/stripe-dotnet/pull/1342) Add support for the `WebhookEndpoint` resource
* [#1364](https://github.com/stripe/stripe-dotnet/pull/1364) Add support for `unit_label` on Product creation and `active` on Plan creation

## 20.2.0 - 2018-10-25
* [#1353](https://github.com/stripe/stripe-dotnet/pull/1353) Fix encoder to handle null values in dictionaries
* [#1355](https://github.com/stripe/stripe-dotnet/pull/1355) Fix handling of `Expand*` properties in list requests
* [#1356](https://github.com/stripe/stripe-dotnet/pull/1356) Add `AuthorizationControls` to `Issuing.CardCreateOptions` and `Issuing.CardUpdateOptions`
* [#1358](https://github.com/stripe/stripe-dotnet/pull/1358) Ignore culture when encoding parameters

## 20.1.0 - 2018-10-23
* [#1347](https://github.com/stripe/stripe-dotnet/pull/1347) Add `IHasMetadata` interface to all resource classes that support metadata
* [#1348](https://github.com/stripe/stripe-dotnet/pull/1348) Add `CardId` and `BankAccountId` to `TokenCreateOptions`

## 20.0.0 - 2018-10-22
Major version release. Refer to our [migration guide for v20](https://github.com/stripe/stripe-dotnet/wiki/Migration-guide-for-v20) for a list of backwards incompatible changes to watch out for.

Pull requests included in this release (cf. [#1293](https://github.com/stripe/stripe-dotnet/pull/1293)):
* [#1275](https://github.com/stripe/stripe-dotnet/pull/1275) Properly re-architecture the library to handle various source abstractions
* [#1276](https://github.com/stripe/stripe-dotnet/pull/1276) Rewrite parameter encoding logic
* [#1282](https://github.com/stripe/stripe-dotnet/pull/1282) Rename `SourceTransactionCanceled` constant to `SourceTransactionCreated`, add `SourceTransactionUpdated` constant
* [#1283](https://github.com/stripe/stripe-dotnet/pull/1283) Handle `DateTime`s directly in the encoder
* [#1284](https://github.com/stripe/stripe-dotnet/pull/1284) Remove `StripeDeleted` class, add `Deleted` property to deletable resource classes
* [#1285](https://github.com/stripe/stripe-dotnet/pull/1285) Rename `image` property to `Image` in `StripeSku` and `StripeSkuSharedOptions` classes
* [#1252](https://github.com/stripe/stripe-dotnet/pull/1252) Remove the `Stripe` prefix from all classes
* [#1286](https://github.com/stripe/stripe-dotnet/pull/1286) Rename `ScheduledQuery*` to `ScheduledQueryRun*`, move `ScheduledQueryRun` classes in `Stripe.Sigma` namespace
* [#1287](https://github.com/stripe/stripe-dotnet/pull/1287) Standardize method signatures in `InvoiceService` and `RefundService`
* [#1288](https://github.com/stripe/stripe-dotnet/pull/1288) Standardize method signatures in `FileUploadService`
* [#1291](https://github.com/stripe/stripe-dotnet/pull/1291) Move balance transaction methods out of `BalanceService` and into new `BalanceTransactionService` class
* [#1269](https://github.com/stripe/stripe-dotnet/pull/1269) Add interfaces to all services for standard CRUD methods
* [#1298](https://github.com/stripe/stripe-dotnet/pull/1298) Make all value types in options classes nullable
* [#1302](https://github.com/stripe/stripe-dotnet/pull/1302) Upgrade to API version 2018-09-24
* [#1301](https://github.com/stripe/stripe-dotnet/pull/1301) Update all options classes to match the API's nesting structure
* [#1303](https://github.com/stripe/stripe-dotnet/pull/1303) Rename `LiveMode` property to `Livemode` everywhere
* [#1304](https://github.com/stripe/stripe-dotnet/pull/1304) Sanitize source files
* [#1306](https://github.com/stripe/stripe-dotnet/pull/1306) Remove +x flag from source files
* [#1305](https://github.com/stripe/stripe-dotnet/pull/1305) Use `BasicService` as the parent class for all services
* [#1307](https://github.com/stripe/stripe-dotnet/pull/1307) Sort service methods alphabetically
* [#1310](https://github.com/stripe/stripe-dotnet/pull/1310) Verify requests in tests
* [#1308](https://github.com/stripe/stripe-dotnet/pull/1308) Standardize request method implementations in services
* [#1309](https://github.com/stripe/stripe-dotnet/pull/1309) Group resource class files in folders
* [#1312](https://github.com/stripe/stripe-dotnet/pull/1312) Group test files in folders to match main project's structure
* [#1311](https://github.com/stripe/stripe-dotnet/pull/1311) Add missing properties on resource and options class, rename a few properties
* [#1315](https://github.com/stripe/stripe-dotnet/pull/1315) Add `InvoiceItem` class, distinct from `InvoiceLineItem`
* [#1316](https://github.com/stripe/stripe-dotnet/pull/1316) Automatically convert Unix timestamps to `DateTime`s
* [#1318](https://github.com/stripe/stripe-dotnet/pull/1318) Create coverage report and upload to coveralls.io
* [#1319](https://github.com/stripe/stripe-dotnet/pull/1319) Fix artifacts path in `appveyor.yml`
* [#1317](https://github.com/stripe/stripe-dotnet/pull/1317) Revamp interfaces on Stripe resource classes
* [#1320](https://github.com/stripe/stripe-dotnet/pull/1320) Replace `ExternalAccount` and `PaymentSource` classes by `IExternalAccount`  and `IPaymentSource` interfaces
* [#1321](https://github.com/stripe/stripe-dotnet/pull/1321) Replace `BalanceTransactionSource` class by `IBalanceTransactionSource` interface
* [#1322](https://github.com/stripe/stripe-dotnet/pull/1322) Use `IHasObject` interface instead of `dynamic` for `data.object` attribute of event objects
* [#1323](https://github.com/stripe/stripe-dotnet/pull/1323) Fix remaining warnings in .NET Framework specific code
* [#1328](https://github.com/stripe/stripe-dotnet/pull/1328) Add some missing tests
* [#1329](https://github.com/stripe/stripe-dotnet/pull/1329) Use an interface for `PaymentIntentSourceAction`
* [#1331](https://github.com/stripe/stripe-dotnet/pull/1331) Use `long` instead of `int` for all integer numeric types
* [#1340](https://github.com/stripe/stripe-dotnet/pull/1340) Change the signature of request methods on `UsageRecordService` to accept a subscription item ID
* [#1337](https://github.com/stripe/stripe-dotnet/pull/1337) Rename `SourceTokenOrExistingSourceId` to `SourceId` in `ChargeCreationOptions` class
* [#1345](https://github.com/stripe/stripe-dotnet/pull/1345) Add `ChargeExpired` constant

## 19.10.0 - 2018-10-09
* [#1327](https://github.com/stripe/stripe-dotnet/pull/1327) Add `TransferGroup` to `StripeChargeUpdateOptions`

## 19.9.2 - 2018-09-28
* [#1297](https://github.com/stripe/stripe-dotnet/pull/1297) Add .NET Standard 2.0 target

## 19.9.1 - 2018-09-27
* [#1300](https://github.com/stripe/stripe-dotnet/pull/1300) Make internals visible to Newtonsoft.Json

## 19.9.0 - 2018-09-26
* [#1296](https://github.com/stripe/stripe-dotnet/pull/1296) Add `Description` on `StripeTransfer`, `StripeTransferCreateOptions` and `StripeTransferUpdateOptions`

## 19.8.0 - 2018-09-24
* [#1222](https://github.com/stripe/stripe-dotnet/pull/1222) Add support for Payment Intent resource.

## 19.7.0 - 2018-09-20
* [#1290](https://github.com/stripe/stripe-dotnet/pull/1290) Add `AccountToken` to `StripeAccountCreateOptions` and `StripeAccountUpdateOptions`

## 19.6.0 - 2018-09-11
* [#1280](https://github.com/stripe/stripe-dotnet/pull/1280) Enable XML documentation
* [#1279](https://github.com/stripe/stripe-dotnet/pull/1279) Add missing attributes to `StripeThreeDSecure`

## 19.5.0 - 2018-09-06
* [#1273](https://github.com/stripe/stripe-dotnet/pull/1273) Add `ExchangeRate` to `StripeBalanceTransaction`
* [#1270](https://github.com/stripe/stripe-dotnet/pull/1270) Add `StatusTransitions` to `StripeOrderListOptions`

## 19.4.0 - 2018-09-05
* [#1272](https://github.com/stripe/stripe-dotnet/pull/1272) Add support for reporting resources

## 19.3.0 - 2018-09-04
* [#1268](https://github.com/stripe/stripe-dotnet/pull/1268) Add `Mandate` and `Receiver` to `StripeSourceCreateOptions`

## 19.2.0 - 2018-08-29
* [#1266](https://github.com/stripe/stripe-dotnet/pull/1266) Fix type of `PercentOff` on `StripeCoupon` (this is technically breaking, but the previous implementation didn't work, so we're releasing as a minor)

## 19.1.0 - 2018-08-28
* [#1262](https://github.com/stripe/stripe-dotnet/pull/1262) Add `AuthorizationCode` to `StripeCharge`

## 19.0.1 - 2018-08-27
* Fix 19.0.0 release. The version that was pushed to NuGet did not include the changes from 19.0.0.

## 19.0.0 - 2018-08-27
* [#1259](https://github.com/stripe/stripe-dotnet/pull/1259) Upgrade to API version [2018-08-23](https://docs.stripe.com/changelog/2018-08-23)

List of backwards incompatible changes:
* `BusinessVatId` on `StripeCustomer` / `StripeCustomerCreateOptions` / `StripeCustomerUpdateOptions` is replaced with `TaxInfo`
* `Amount` on `StripePlanTier` / `StripePlanTierOptions` is replaced with `UnitAmount`
* `PercentOff` on `StripeCouponCreateOptions` is now a `decimal` (used to be an `int`)
* Request methods on `StripeSubscriptionService` no longer accept a `string customerId` argument. Instead, the customer ID should be provided in the appropriate options class (`StripeSubscriptionCreateOptions`, etc.)
* `StripeSubscriptionService.Cancel` & `CancelAsync` no longer accept a `bool cancelAtPeriodEnd` argument. If you want to delete a subscription at the end of the period, you can _update_ the subscription with `CancelAtPeriodEnd`
* `StripeProduct` no longer has a `Skus` property

## 18.0.0 - 2018-08-23
* [#1257](https://github.com/stripe/stripe-dotnet/pull/1257) Add support for passing options to `StripeInvoiceService.Pay` / `PayAsync`

## 17.11.0 - 2018-08-23
* [#1255](https://github.com/stripe/stripe-dotnet/pull/1255) Make `StripeInvoiceItemCreateOptions.Amount` optional

## 17.10.0 - 2018-08-21
* [#1251](https://github.com/stripe/stripe-dotnet/pull/1251) Add support for usage record summaries

## 17.9.0 - 2018-08-16
* [#1250](https://github.com/stripe/stripe-dotnet/pull/1250) Add `UnitLabel` to `StripeProduct` and fix deserialization of `BillingReason` on `StripeInvoice`

## 17.8.0 - 2018-08-03
* [#1244](https://github.com/stripe/stripe-dotnet/pull/1244) Add support for file links
* [#1245](https://github.com/stripe/stripe-dotnet/pull/1245) Add cancel support for topups

## 17.7.0 - 2018-07-31
* [#1242](https://github.com/stripe/stripe-dotnet/pull/1242) Add `Created` to `StripeAccount`

## 17.6.0 - 2018-07-27
* [#1239](https://github.com/stripe/stripe-dotnet/pull/1239) Add `RiskScore` to `StripeOutcome`

## 17.5.0 - 2018-07-26
* [#1237](https://github.com/stripe/stripe-dotnet/pull/1237) Add support for Stripe Issuing

## 17.4.0 - 2018-07-23
* [#1165](https://github.com/stripe/stripe-dotnet/pull/1165) Add support for expanding `Source` on `StripeBalanceTransaction`

## 17.3.1 - 2018-07-16
* [#1232](https://github.com/stripe/stripe-dotnet/pull/1232) Fix some code style issues reported by [StyleCop.Analyzers](https://github.com/DotNetAnalyzers/StyleCopAnalyzers). This should have no functional impact on the library.

## 17.3.0 - 2018-07-13
* [#1234](https://github.com/stripe/stripe-dotnet/pull/1234) Add `Customer` to `StripeSourceCreateOptions`

## 17.2.0 - 2018-07-13
* [#1233](https://github.com/stripe/stripe-dotnet/pull/1233) Add `OriginalSource` to `StripeSourceCreateOptions`

## 17.1.0 - 2018-07-12
* [#1228](https://github.com/stripe/stripe-dotnet/pull/1228) Add `AutoAdvance` to `StripeInvoice`

## 17.0.0 - 2018-07-11
* [#1210](https://github.com/stripe/stripe-dotnet/pull/1210) Fix `CustomerSourcedDeleted` typo to `CustomerSourceDeleted`, add `CustomerSourceExpiring`
* [#1214](https://github.com/stripe/stripe-dotnet/pull/1214) Add `InvoiceItems` and `SubscriptionBillingCycleAnchor` to `StripeUpcomingInvoiceOptions`
* [#1224](https://github.com/stripe/stripe-dotnet/pull/1224) Change webhook signature verification to allow for future timestamps (within the tolerance)

## 16.16.1 - 2018-07-11
* [#1218](https://github.com/stripe/stripe-dotnet/pull/1218) Generic plugin for encoding lists

## 16.16.0 - 2018-07-06
* [#1223](https://github.com/stripe/stripe-dotnet/pull/1223) Add missing properties to invoice item objects and creation/update requests

## 16.15.0 - 2018-07-03
* [#1221](https://github.com/stripe/stripe-dotnet/pull/1221) Add support for expanding `Outcome.Rule` on `StripeCharge`

## 16.14.0 - 2018-06-29
* [#1216](https://github.com/stripe/stripe-dotnet/pull/1216) Add support for Level 3 Data on charge creation

## 16.13.0 - 2018-06-28
* [#1219](https://github.com/stripe/stripe-dotnet/pull/1219) Add `Name` to `StripeCouponUpdateOptions`

## 16.12.0 - 2018-06-20
* [#1213](https://github.com/stripe/stripe-dotnet/pull/1213) Add `AggregateUsage` to `StripePlanCreateOptions`

## 16.11.0 - 2018-06-20
* [#1207](https://github.com/stripe/stripe-dotnet/pull/1207) Add `AmountRemaining` and `BillingReason` to `StripeInvoice`
* [#1208](https://github.com/stripe/stripe-dotnet/pull/1208) Fix namespace of `StripeListOptionsWithCreated`
* [#1211](https://github.com/stripe/stripe-dotnet/pull/1211) Add `Name` to `StripeCoupon` and `StripeCouponCreateOptions`

## 16.10.0 - 2018-06-13
* [#1205](https://github.com/stripe/stripe-dotnet/pull/1205) Add `Action` to `StripeUsageRecordCreateOptions`

## 16.9.0 - 2018-06-12
* [#1201](https://github.com/stripe/stripe-dotnet/pull/1201) Add support for `document_back` on account objects and creation/update requests

## 16.8.0 - 2018-06-12
* [#1203](https://github.com/stripe/stripe-dotnet/pull/1203) Add `ProductId` to `StripePlanUpdateOptions`

## 16.7.0 - 2018-06-06
* [#1200](https://github.com/stripe/stripe-dotnet/pull/1200) Add `Active` to plan parameter and response classes

## 16.6.0 - 2018-06-06
* [#1199](https://github.com/stripe/stripe-dotnet/pull/1199) Add `HostedInvoiceUrl` and `InvoicePdf` to invoices

## 16.5.0 - 2018-06-06
* [#1198](https://github.com/stripe/stripe-dotnet/pull/1198) Add `Subscription` to `StripeSubscriptionItem`

## 16.4.0 - 2018-06-01
* [#1195](https://github.com/stripe/stripe-dotnet/pull/1195) Add `Email` to `StripeCustomerListOptions` (for real this time)

## 16.3.0 - 2018-05-23
* [#1191](https://github.com/stripe/stripe-dotnet/pull/1191) Move `BankAccountOptions` to the `Stripe` namespace
    * This change is technically breaking, but it won't break most code because it's like to already have a `using Stripe` in the same file, so we've released it as a minor release

## 16.2.0 - 2018-05-21
* [#1110](https://github.com/stripe/stripe-dotnet/pull/1110) Add support for topups
* [#1189](https://github.com/stripe/stripe-dotnet/pull/1189) Add support for SEPA credit transfer sources

## 16.1.0 - 2018-05-10
* [#1182](https://github.com/stripe/stripe-dotnet/pull/1182) Add support `SubscriptionTaxPercent` and `SubscriptionTrialFromPlan` parameters for fetching upcoming invoices

## 16.0.0 - 2018-05-09
* [#1176](https://github.com/stripe/stripe-dotnet/pull/1176) Properly handle bank account token deserialization

## 15.8.0 - 2018-05-07
* [#1174](https://github.com/stripe/stripe-dotnet/pull/1174) Add support for Sigma scheduled queries

## 15.7.0 - 2018-05-03
* [#1172](https://github.com/stripe/stripe-dotnet/pull/1172) Add support for `invoice_prefix` attribute on customer objects and creation/update requests

## 15.6.2 - 2018-04-24
* [#1163](https://github.com/stripe/stripe-dotnet/pull/1163) Fix encoding of `BillingCycleAnchor` property in `StripeSubscriptionCreateOptions`

## 15.6.1 - 2018-04-19
* [#1160](https://github.com/stripe/stripe-dotnet/pull/1160) Add internal properties to `StripeCard`

## 15.6.0 - 2018-04-18
* [#1159](https://github.com/stripe/stripe-dotnet/pull/1159) Add `AmountPaid` property to `StripeInvoice` and `TrialFromPlan` property to `SubscriptionSharedOptions`

## 15.5.0 - 2018-04-16
* [#1146](https://github.com/stripe/stripe-dotnet/pull/1146) Fix `BillingCycleAnchor` in `StripeSubscriptionCreateOptions` to only accept timestamps
* [#1157](https://github.com/stripe/stripe-dotnet/pull/1157) Add `Email` to `StripeCustomerListOptions`

## 15.4.0 - 2018-04-16
* [#1154](https://github.com/stripe/stripe-dotnet/pull/1154) Add `SepaDebitIdealSourceId` property to `StripeSourceCreateOptions` (for creating SEPA Direct Debit sources from iDEAL sources)

## 15.3.2 - 2018-04-09
* [#1152](https://github.com/stripe/stripe-dotnet/pull/1152) Fix an issue where user-settable IDs would not be URL-encoded

## 15.3.1 - 2018-04-06
* [#1151](https://github.com/stripe/stripe-dotnet/pull/1151) Fix an issue when running the library with .NET Framework 4.5+ in non-Windows environments

## 15.3.0 - 2018-04-04
* [#1150](https://github.com/stripe/stripe-dotnet/pull/1150) Flexible/Metered Billing API support

## 15.2.1 - 2018-03-27
* [#1147](https://github.com/stripe/stripe-dotnet/pull/1147) Fix `CancelAtPeriodEnd` parameter in `StripeSubscriptionUpdateOptions`

## 15.2.0 - 2018-03-26
* [#1145](https://github.com/stripe/stripe-dotnet/pull/999) Use `ConfigureAwait(false)` for all async invocations

## 15.1.0 - 2018-03-23
* [#1144](https://github.com/stripe/stripe-dotnet/pull/1144) Modify `StripeDateTimeConverter` so that it writes timestamps as standard epochs instead of in Microsoft's custom `Date` format

## 15.0.0 - 2018-03-21
* [#1139](https://github.com/stripe/stripe-dotnet/pull/1139) Add support for expanding more attributes and change `Charge.Outcome` to be auto-expanded
* [#1140](https://github.com/stripe/stripe-dotnet/pull/1140) Add support for arbitrary attribute expansion
* [#1143](https://github.com/stripe/stripe-dotnet/pull/1143) Fix `Metadata` encoding on `StripeSubscriptionItem`

## 14.0.0 - 2018-03-16
* [#1138](https://github.com/stripe/stripe-dotnet/pull/1138) Add support for `redirect_url` in login link creation requests

## 13.5.0 - 2018-03-15
* [#1135](https://github.com/stripe/stripe-dotnet/pull/1135) Add support for `Created` and `ProductId` parameters in plan listing requests

## 13.4.0 - 2018-03-13
* [#1128](https://github.com/stripe/stripe-dotnet/pull/1128) Add support for custom URL bases

## 13.3.1 - 2018-03-05
* [#1126](https://github.com/stripe/stripe-dotnet/pull/1126) Revert Newtonsoft.Json dependency back to 9.0.1

## 13.3.0 - 2018-03-01
* [#1117](https://github.com/stripe/stripe-dotnet/pull/1117) Add `ISupportMetadata` interface to all Stripe entities that support metadata
* [#1119](https://github.com/stripe/stripe-dotnet/pull/1119) Add `FailureReason` property to `StripeRedirect`
* [#1123](https://github.com/stripe/stripe-dotnet/pull/1123) Upgrade Newtonsoft.Json dependency to 11.0.1

## 13.2.0 - 2018-02-27
* [#1114](https://github.com/stripe/stripe-dotnet/pull/1114) Update subscription request parameters
* [#1115](https://github.com/stripe/stripe-dotnet/pull/1115) Remove unneeded parameters in `SourceCard`

## 13.1.0 - 2018-02-22
* [#1105](https://github.com/stripe/stripe-dotnet/pull/1105) Add parameterless constructors to all services

## 13.0.2 - 2018-02-22
* [#1107](https://github.com/stripe/stripe-dotnet/pull/1107) Minor webhook signing improvements

## 13.0.1 - 2018-02-19
* [#1103](https://github.com/stripe/stripe-dotnet/pull/1103) Add support for expanding `product` on plan objects

## 13.0.0 - 2018-02-13
* [#1097](https://github.com/stripe/stripe-dotnet/pull/1097) Add support for deserializing `source_mandate_notification` objects
* [#1099](https://github.com/stripe/stripe-dotnet/pull/1099) Upgrade API version to 2018-02-06 and add support for Product & Plan API

## 12.1.0 - 2018-01-19
* [#1096](https://github.com/stripe/stripe-dotnet/pull/1096) Add support for `StripeSource` class in `Source` wrapper

## 12.0.0 - 2018-01-16
* [#967](https://github.com/stripe/stripe-dotnet/pull/967) Remove the `TotalCount` property of list objects
* [#1072](https://github.com/stripe/stripe-dotnet/pull/1072) Add support for managing external accounts
* [#1080](https://github.com/stripe/stripe-dotnet/pull/1080) Fix card listing
* [#1083](https://github.com/stripe/stripe-dotnet/pull/1083) Add specialized `ListOptions` classes for all API resources
* [#1084](https://github.com/stripe/stripe-dotnet/pull/1084) Fix `single_use` string constant
* [#1086](https://github.com/stripe/stripe-dotnet/pull/1086) Fix `fulfiled` attribute
* [#1089](https://github.com/stripe/stripe-dotnet/pull/1089) Use top-level `statement_descriptor` attribute on source objects
* [#1091](https://github.com/stripe/stripe-dotnet/pull/1091) Fix synchronous `login_link` creation
* [#1093](https://github.com/stripe/stripe-dotnet/pull/1093) Upgrade to API version 2017-12-14

## 11.10.0 - 2017-12-26
* [#1069](https://github.com/stripe/stripe-dotnet/pull/1069) Allow setting `three_d_secure[customer]` when creating 3DS sources
* [#1071](https://github.com/stripe/stripe-dotnet/pull/1071) Add support for account debits
* [#1074](https://github.com/stripe/stripe-dotnet/pull/1074) Add support for expanding `application` on charge objects
* [#1077](https://github.com/stripe/stripe-dotnet/pull/1077) Fix parameters being sent twice when creating subscriptions

## 11.9.0 - 2017-11-29
* [#1064](https://github.com/stripe/stripe-dotnet/pull/1064) Support for listing sources on customers

## 11.8.2 - 2017-11-23
* [#1054](https://github.com/stripe/stripe-dotnet/pull/1054) Fix file uploading when the extension is not known
* [#1055](https://github.com/stripe/stripe-dotnet/pull/1055) Fix `DueDate` encoding for `StripeInvoiceCreateOptions`

## 11.8.1 - 2017-11-22
* [#1060](https://github.com/stripe/stripe-dotnet/pull/1060) Fix invoice listing

## 11.8.0 - 2017-11-21
* [#1056](https://github.com/stripe/stripe-dotnet/pull/1056) Add `Automatic` for `StripePayout`
* [#1057](https://github.com/stripe/stripe-dotnet/pull/1057) Support for passing extra parameters
* [#1058](https://github.com/stripe/stripe-dotnet/pull/1058) Add `Paid` for `StripeInvoiceListOptions`

## 11.7.1 - 2017-10-31
* [#1050](https://github.com/stripe/stripe-dotnet/pull/1050) Make exchange rate APIs singular (released as patch because these APIs are brand new and because 11.7.0 never made it to Nuget anyway)

## 11.7.0 - 2017-10-30
* [#1047](https://github.com/stripe/stripe-dotnet/pull/1047) Support for listing source transactions
* [#1049](https://github.com/stripe/stripe-dotnet/pull/1049) Support for listing and retrieving exchange rates

## 11.6.1 - 2017-10-24
* [#1044](https://github.com/stripe/stripe-dotnet/pull/1044) Improvements to parameter encoding
    * Main user-facing fix is that dictionary keys are now URL-encoded correctly (in case they contained characters incompatible with URLs)

## 11.6.0 - 2017-10-19
* [#1035](https://github.com/stripe/stripe-dotnet#1035) Signature fixes for webhook signature verification
    * Explicitly dispose of `HMACSHA256` after use so that its buffer cannot be inadvertently leaked
    * Use `SafeUTF8.GetBytes` so that unrecognized codepoints are not silently replaced with "?"
* [#1040](https://github.com/stripe/stripe-dotnet/pull/1040) Add a few field definitions that were missing from API resources

## 11.5.0 - 2017-10-16
* [#1034](https://github.com/stripe/stripe-dotnet#1034) Add `Customer` to `StripeBankAccount`

## 11.4.0 - 2017-10-13
* [#1031](https://github.com/stripe/stripe-dotnet#1031) Support for manual subscription payments

## 11.3.0 - 2017-10-11
* [#1028](https://github.com/stripe/stripe-dotnet#1028) Support for attaching/detaching sources to/from customers
* [#1029](https://github.com/stripe/stripe-dotnet#1029) Correctly encode custom coupon and plan IDs in API URLs

## 11.2.0 - 2017-10-10
* [#986](https://github.com/stripe/stripe-dotnet#986) Add support for shipping on customer create and update
* [#997](https://github.com/stripe/stripe-dotnet#997) Add support for the Ephmeral Key API resource

## 11.1.0 - 2017-10-10
* [#1002](https://github.com/stripe/stripe-dotnet#1002) Add access for `StripeResponse` on `StripeException`
* [#1005](https://github.com/stripe/stripe-dotnet#1005) Add support for updating card source expiration date
* [#1008](https://github.com/stripe/stripe-dotnet#1008) Use bearer authorization everywhere and by default
* [#1021](https://github.com/stripe/stripe-dotnet#1021) Add `PreferredLanguage` for Bancontact sources

## 11.0.0 - 2017-10-10
* [#1007](https://github.com/stripe/stripe-dotnet#1007) Add support for Apple Pay Domain resource
* [#1018](https://github.com/stripe/stripe-dotnet#1018) Add event constants `ChargeRefundUpdated` and `InvoiceUpcoming`
* [#1019](https://github.com/stripe/stripe-dotnet#1019) Add `StripeChargeCaptureOptions` and use it for charge capture
* [#1022](https://github.com/stripe/stripe-dotnet#1022) Add support for SKUs
* [#1025](https://github.com/stripe/stripe-dotnet#1025) Add `Discountable` for `StripeInvoiceLineItem`

