<!--
THIS IS A GENERATED FILE. Any changes you make to it directly will be blown away.
Instead, edit a corresponding `.change.md` file and run `hark build`.
-->

# Changelog

> This changelog only covers the **public preview** releases. Each release builds on the most recent GA release; see those notes in [the GA changelog](https://github.com/stripe/stripe-dotnet/blob/master/CHANGELOG.md).

## 52.5.0-beta.1 - 2026-08-26
This release changes the pinned API version to `2026-08-26.preview`.

* [#3424](https://github.com/stripe/stripe-dotnet/pull/3424) Add non-verified methods to managed handlers
* ⚠️ [#3429](https://github.com/stripe/stripe-dotnet/pull/3429) Update generated code for beta
  * Add support for new resources `V2.Core.ApprovalRequest`, `V2.Signals.AccountActivity`, `V2.Signals.AccountEvaluation`, and `V2.Signals.AccountSignal`
  * Add support for `Get` and `List` methods on resource `V2.Signals.AccountSignal`
  * Add support for `Create` and `Get` methods on resource `V2.Signals.AccountEvaluation`
  * Add support for `Create`, `Delete`, and `Get` methods on resource `V2.Signals.AccountActivity`
  * Add support for `Cancel`, `Get`, `List`, and `Update` methods on resource `V2.Core.ApprovalRequest`
  * Add support for `Disable` method on resource `V2.MoneyManagement.PayoutMethod`
  * Add support for `DisableStripeUserAuthentication` on `AccountSessionComponentsPaymentMethodSettingsFeaturesOptions`
  * ⚠️ Remove support for `PaymentMethodTypes` on `PaymentIntentConfirmOptions`, `PaymentIntentCreateOptions`, `PaymentIntentUpdateOptions`, `SetupIntentCreateOptions`, and `SetupIntentUpdateOptions`
  * ⚠️ Change type of `ProductCatalog.TrialOffer.EndBehavior.Transition.Price` and `ProductCatalog.TrialOffer.Price` from `$Price` to `deletable($Price)`
  * Add support for `Billie` on `QuotePreviewInvoice.PaymentSettings.PaymentMethodOptions`
  * Add support for `PayoutMethods` on `V2.Core.Account.Defaults` and `V2CoreAccountDefaultsOptions`
  * Add support for `Restricted` on `V2.Core.Vault.GbBankAccount` and `V2.Core.Vault.UsBankAccount`
  * Add support for `EnabledDeliverySchemes` on `V2.MoneyManagement.PayoutMethod.BankAccount`
  * ⚠️ Remove support for `EnabledDeliveryOptions` on `V2.MoneyManagement.PayoutMethod.BankAccount`
  * Add support for event notifications `V2CoreApprovalRequestApprovedEvent`, `V2CoreApprovalRequestCanceledEvent`, `V2CoreApprovalRequestCreatedEvent`, `V2CoreApprovalRequestExpiredEvent`, `V2CoreApprovalRequestFailedEvent`, `V2CoreApprovalRequestRejectedEvent`, and `V2CoreApprovalRequestSucceededEvent` with related object `V2.Core.ApprovalRequest`
  * Add support for event notification `V2SignalsAccountEvaluationCompleteEvent` with related object `V2.Signals.AccountEvaluation`

## 52.3.0-beta.1 - 2026-07-29
This release changes the pinned API version to `2026-07-29.preview`.

* ⚠️ [#3406](https://github.com/stripe/stripe-dotnet/pull/3406) Update generated code for beta
  * Add support for `Get` and `List` methods on resource `ProductCatalog.TrialOffer`
  * Add support for `TaxItems` on `ChargePaymentDetailsCarRentalDataTotalTaxOptions`, `ChargePaymentDetailsFlightDataTotalTaxOptions`, `ChargePaymentDetailsLodgingDataTotalTaxOptions`, `PaymentIntent.PaymentDetails.CarRentalDatum.Total.Tax`, `PaymentIntent.PaymentDetails.FlightDatum.Total.Tax`, `PaymentIntent.PaymentDetails.LodgingDatum.Total.Tax`, `PaymentIntentPaymentDetailsCarRentalDataTotalTaxOptions`, `PaymentIntentPaymentDetailsFlightDataTotalTaxOptions`, and `PaymentIntentPaymentDetailsLodgingDataTotalTaxOptions`
  * ⚠️ Remove support for `Taxes` on `ChargePaymentDetailsCarRentalDataTotalTaxOptions`, `ChargePaymentDetailsFlightDataTotalTaxOptions`, `ChargePaymentDetailsLodgingDataTotalTaxOptions`, `PaymentIntent.PaymentDetails.CarRentalDatum.Total.Tax`, `PaymentIntent.PaymentDetails.FlightDatum.Total.Tax`, `PaymentIntent.PaymentDetails.LodgingDatum.Total.Tax`, `PaymentIntentPaymentDetailsCarRentalDataTotalTaxOptions`, `PaymentIntentPaymentDetailsFlightDataTotalTaxOptions`, and `PaymentIntentPaymentDetailsLodgingDataTotalTaxOptions`
  * Add support for `TaxId` on `Checkout.Session.CollectedInformation`
  * ⚠️ Remove support for `TaxIds` on `Checkout.Session.CollectedInformation`
  * Add support for `Mode` on `FinancialConnections.Session.ManualEntry`
  * Add support for `Name` on `Issuing.CardholderUpdateOptions`
  * Add support for `CustomFields`, `Description`, and `Footer` on `QuotePreviewSubscriptionSchedule.DefaultSettings.InvoiceSettings` and `QuotePreviewSubscriptionSchedule.Phase.InvoiceSettings`
  * Add support for `Trial` on `QuotePreviewSubscriptionSchedule.Phase`
  * ⚠️ Remove support for `AcssDebit`, `AfterpayClearpay`, `Alipay`, `Alma`, `AmazonPay`, `AuBecsDebit`, `BacsDebit`, `Bancontact`, `Billie`, `Bizum`, `Blik`, `Boleto`, `CardPresent`, `Cashapp`, `Crypto`, `CustomerBalance`, `Eps`, `Fpx`, `Giropay`, `Gopay`, `Grabpay`, `IdBankTransfer`, `Ideal`, `InteracPresent`, `KakaoPay`, `Konbini`, `KrCard`, `MbWay`, `Mobilepay`, `Multibanco`, `NaverPay`, `NzBankAccount`, `Oxxo`, `P24`, `PayByBank`, `Payco`, `Paynow`, `Paypal`, `Paypay`, `Payto`, `Pix`, `Promptpay`, `Qris`, `Rechnung`, `RevolutPay`, `SamsungPay`, `Satispay`, `Scalapay`, `SepaDebit`, `Shopeepay`, `Sofort`, `StripeBalance`, `Sunbit`, `Swish`, `Twint`, `Upi`, `UsBankAccount`, `WechatPay`, and `Zip` on `SharedPayment.GrantedToken.PaymentMethodDetails`
  * Add support for `UseStripeSdk` on `SharedPayment.IssuedTokenCreateOptions` and `SharedPayment.IssuedToken`
  * Add support for `RedirectToUrl` on `SharedPayment.IssuedToken.NextAction`
  * ⚠️ Change type of `SharedPayment.IssuedToken.NextAction.Type` from `literal('use_stripe_sdk')` to `enum('redirect_to_url'|'use_stripe_sdk')`
  * Add support for `Livemode` on `Tax.Location`
  * Add support for `Source` on `V2.Iam.ActivityLog.Details.UserRoles`
  * Add support for `Payout` on `V2.MoneyManagement.ReceivedCredit.BalanceTransfer`
  * ⚠️ Remove support for `PayoutV1` on `V2.MoneyManagement.ReceivedCredit.BalanceTransfer`

## 52.2.0-beta.1 - 2026-06-24
This release changes the pinned API version to `2026-06-24.preview`.

* ⚠️ [#3390](https://github.com/stripe/stripe-dotnet/pull/3390) Update generated code for beta
  * Add support for `Redaction` on `Card`, `Charge`, `Checkout.Session`, `Customer`, `Issuing.Authorization`, `Issuing.Card`, `Issuing.Cardholder`, `Issuing.Dispute`, `Issuing.Transaction`, `PaymentIntent`, `PaymentMethod`, `SetupIntent`, `Source`, and `Token`
  * Add support for `DisclaimerVariant` on `Capital.FinancingOffer` and `Capital.FinancingSummary.Details`
  * Add support for `Active` on `FinancialConnections.Account.StatusDetails` and `FinancialConnections.Authorization.StatusDetails`
  * Change type of `FinancialConnectionsSessionLimitsOptions.Accounts` from `longInteger` to `emptyable(longInteger)`
  * Add support for `Pause` on `InvoiceSubscriptionDetailsOptions`
  * Add support for `ReleaseDetails` on `Reserve.Hold`
  * Add support for `BuyerId` on `SharedPayment.GrantedToken.PaymentMethodDetails.Bizum` and `SharedPayment.GrantedToken.PaymentMethodDetails.Blik`
  * Add support for `Fingerprint` on `SharedPayment.GrantedToken.PaymentMethodDetails.Pix`
  * Add support for `MoneyManager` on `V2.Core.Account.Configuration`, `V2.Core.Account.Identity.Attestations.TermsOfService`, `V2CoreAccountConfigurationOptions`, `V2CoreAccountIdentityAttestationsTermsOfServiceOptions`, and `V2CoreAccountTokenIdentityAttestationsTermsOfServiceOptions`
  * ⚠️ Remove support for `Storer` on `V2.Core.Account.Configuration`, `V2.Core.Account.Identity.Attestations.TermsOfService`, `V2CoreAccountConfigurationOptions`, `V2CoreAccountIdentityAttestationsTermsOfServiceOptions`, and `V2CoreAccountTokenIdentityAttestationsTermsOfServiceOptions`
  * ⚠️ Remove support for `MaximumRps` on `V2.Core.BatchJobCreateOptions` and `V2.Core.BatchJob`
  * Add support for `Bic` on `V2.MoneyManagement.FinancialAddress.Credentials.UsBankAccount`
  * ⚠️ Remove support for `SwiftCode` on `V2.MoneyManagement.FinancialAddress.Credentials.UsBankAccount`
  * Add support for `Processing` on `V2.MoneyManagement.OutboundPayment.StatusDetails` and `V2.MoneyManagement.OutboundTransfer.StatusDetails`
  * Add support for `AccountHolderName` on `V2.MoneyManagement.ReceivedCredit.BankTransfer.UsBankAccount`
  * Add support for `Statuses` on `V2.MoneyManagement.FinancialAccountListOptions`
  * ⚠️ Remove support for `Status` on `V2.MoneyManagement.FinancialAccountListOptions`
  * Add support for event notifications `V2CoreAccountIncludingConfigurationMoneyManagerCapabilityStatusUpdatedEvent` and `V2CoreAccountIncludingConfigurationMoneyManagerUpdatedEvent` with related object `V2.Core.Account`
  * Add support for event notification `V2MoneyManagementOutboundPaymentUnderReviewEvent` with related object `V2.MoneyManagement.OutboundPayment`
  * Add support for event notification `V2MoneyManagementOutboundTransferUnderReviewEvent` with related object `V2.MoneyManagement.OutboundTransfer`
  * ⚠️ Remove support for event notifications `V2CoreAccountIncludingConfigurationStorerCapabilityStatusUpdatedEvent` and `V2CoreAccountIncludingConfigurationStorerUpdatedEvent` with related object `V2.Core.Account`

## 51.3.0-beta.1 - 2026-05-27
This release changes the pinned API version to `2026-05-27.preview`.

* ⚠️ [#3376](https://github.com/stripe/stripe-dotnet/pull/3376) Update generated code for beta
  * Add support for `Pause` method on resource `Subscription`
  * Add support for `Get` method on resource `V2.Iam.ActivityLog`
  * ⚠️ Change type of `ProductCatalog.TrialOffer.EndBehavior.Transition.Price` from `string` to `expandable($Price)`
  * Add support for `AmountPaidOffStripe` on `QuotePreviewInvoice`
  * Add support for `Discountable` on `QuotePreviewSubscriptionSchedule.Phase.AddInvoiceItem`
  * Add support for `Bizum` and `Scalapay` on `SharedPayment.GrantedToken.PaymentMethodDetails`
  * Change type of `SubscriptionItem.BilledUntil` from `nullable(DateTime)` to `DateTime`
  * Add support for `PaymentBehavior` on `SubscriptionResumeOptions`
  * Add support for `StatusDetails` on `Subscription`
  * ⚠️ Change type of `V2.MoneyManagement.ReceivedCredit.BankTransfer.GbBankAccount.Network` from `literal('fps')` to `enum('chaps'|'fps')`

## 51.2.0-beta.2 - 2026-04-24
* ⚠️ [#3374](https://github.com/stripe/stripe-dotnet/pull/3374) Update generated code for beta
  * Add support for new resources `V2.Commerce.ProductCatalogImport`, `V2.Data.Reporting.QueryRun`, `V2.Extend.WorkflowRun`, `V2.Extend.Workflow`, `V2.Iam.ActivityLog`, `V2.Network.BusinessProfile`, and `V2.OrchestratedCommerce.Agreement`
  * Add support for `Confirm`, `Create`, `Get`, `List`, and `Terminate` methods on resource `V2.OrchestratedCommerce.Agreement`
  * Add support for `Get` and `Me` methods on resource `V2.Network.BusinessProfile`
  * Add support for `List` method on resource `V2.Iam.ActivityLog`
  * Add support for `Get` and `List` methods on resource `V2.Extend.WorkflowRun`
  * Add support for `Get`, `Invoke`, and `List` methods on resource `V2.Extend.Workflow`
  * Add support for `Create` and `Get` methods on resources `V2.Commerce.ProductCatalogImport` and `V2.Data.Reporting.QueryRun`
  * ⚠️ Change type of `V2.Billing.Cadence.SettingsData.Collection.PaymentMethodOptions.Konbini`, `V2.Billing.CollectionSetting.PaymentMethodOptions.Konbini`, `V2.Billing.CollectionSettingVersion.PaymentMethodOptions.Konbini`, and `V2BillingCollectionSettingPaymentMethodOptionsOptions.Konbini` from `map(string: dynamic)` to `an object`
  * ⚠️ Change type of `V2.Billing.Cadence.SettingsData.Collection.PaymentMethodOptions.SepaDebit`, `V2.Billing.CollectionSetting.PaymentMethodOptions.SepaDebit`, `V2.Billing.CollectionSettingVersion.PaymentMethodOptions.SepaDebit`, and `V2BillingCollectionSettingPaymentMethodOptionsOptions.SepaDebit` from `map(string: dynamic)` to `an object`
  * ⚠️ Change type of `V2.MoneyManagement.InboundTransfer.TransferHistory.BankDebitProcessing` from `map(string: dynamic)` to `an object`
  * ⚠️ Change type of `V2.MoneyManagement.InboundTransfer.TransferHistory.BankDebitQueued` from `map(string: dynamic)` to `an object`
  * ⚠️ Change type of `V2.MoneyManagement.InboundTransfer.TransferHistory.BankDebitSucceeded` from `map(string: dynamic)` to `an object`
  * Change type of `V2CoreBatchJobEndpointOptions.HttpMethod` from `literal('post')` to `enum('delete'|'post')`
  * Add support for `TreasuryTransaction` on `EventsV2MoneyManagementTransactionCreatedEvent`
  * Add support for event notifications `V2CommerceProductCatalogImportsFailedEvent`, `V2CommerceProductCatalogImportsProcessingEvent`, `V2CommerceProductCatalogImportsSucceededEvent`, and `V2CommerceProductCatalogImportsSucceededWithErrorsEvent` with related object `V2.Commerce.ProductCatalogImport`
  * Add support for event notifications `V2DataReportingQueryRunCreatedEvent`, `V2DataReportingQueryRunFailedEvent`, `V2DataReportingQueryRunSucceededEvent`, and `V2DataReportingQueryRunUpdatedEvent` with related object `V2.Data.Reporting.QueryRun`
  * Add support for event notifications `V2ExtendWorkflowRunFailedEvent`, `V2ExtendWorkflowRunStartedEvent`, and `V2ExtendWorkflowRunSucceededEvent` with related object `V2.Extend.WorkflowRun`
  * Add support for event notifications `V2OrchestratedCommerceAgreementConfirmedEvent`, `V2OrchestratedCommerceAgreementCreatedEvent`, `V2OrchestratedCommerceAgreementPartiallyConfirmedEvent`, and `V2OrchestratedCommerceAgreementTerminatedEvent` with related object `V2.OrchestratedCommerce.Agreement`
  * Add support for error type `CannotProceedException`

## 51.2.0-beta.1 - 2026-04-23
This release changes the pinned API version to `2026-04-22.preview`.

* ⚠️ [#3367](https://github.com/stripe/stripe-dotnet/pull/3367) Update generated code for beta
  * Add support for new resources `SharedPayment.GrantedToken` and `SharedPayment.IssuedToken`
  * Add support for `Get` method on resource `SharedPayment.GrantedToken`
  * Add support for `Create` and `Revoke` test helper methods on resource `SharedPayment.GrantedToken`
  * Add support for `Create`, `Get`, and `Revoke` methods on resource `SharedPayment.IssuedToken`
  * Add support for `Blik` on `CheckoutSessionPaymentMethodOptionsOptions`, `Invoice.PaymentSettings.PaymentMethodOptions`, `InvoicePaymentSettingsPaymentMethodOptionsOptions`, `QuotePreviewInvoice.PaymentSettings.PaymentMethodOptions`, `Subscription.PaymentSettings.PaymentMethodOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptionsOptions`
  * Add support for `SharedPaymentGrantedToken` on `ConfirmationTokenPaymentMethodDataOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
  * Add support for `ValidationErrors` on `Privacy.RedactionJob`
  * Add support for `TaxDetails` on `Product`
  * ⚠️ Change type of `QuotePreviewInvoice.TotalTaxes.TaxRateDetails.TaxRate` from `string` to `expandable($TaxRate)`
  * Add support for `AdmissionsTax`, `AttendanceTax`, `EntertainmentTax`, `GrossReceiptsTax`, `HospitalityTax`, `LuxuryTax`, `ResortTax`, and `TourismTax` on `TaxRegistrationCountryOptionsUsOptions`
  * Add support for `Purpose` on `Treasury.OutboundPaymentCreateOptions` and `Treasury.OutboundPayment`

## 51.1.0-beta.2 - 2026-04-17
Please review the [changelog for 51.0.1](https://github.com/stripe/stripe-dotnet/blob/master/CHANGELOG.md#5101---2026-04-17) for more information about changes in this release.

## 51.1.0-beta.1 - 2026-03-25
This release changes the pinned API version to `2026-03-25.preview`.

It is built on top of SDK version 51.0.0 which contains breaking changes. Please review the [changelog for 51.0.0](https://github.com/stripe/stripe-dotnet/blob/master/CHANGELOG.md#5100---2026-03-25) if upgrading from older SDK versions.

* ⚠️ [#3337](https://github.com/stripe/stripe-dotnet/pull/3337) Update generated code for beta
  * Add support for new resources `ProductCatalog.TrialOffer`, `Tax.Location`, and `V2.Core.BatchJob`
  * Add support for `Create` method on resource `ProductCatalog.TrialOffer`
  * Add support for `Create`, `Get`, and `List` methods on resource `Tax.Location`
  * Add support for `Cancel`, `Create`, and `Get` methods on resource `V2.Core.BatchJob`
  * Add support for `PerformanceLocation` on `Tax.CalculationLineItem` and `TaxCalculationLineItemOptions`
  * Add support for `TrialOffer` on `InvoiceScheduleDetailsAmendmentItemActionAddOptions`, `InvoiceScheduleDetailsAmendmentItemActionSetOptions`, `InvoiceScheduleDetailsPhaseItemOptions`, `QuoteLine.Action.AddItem`, `QuoteLine.Action.SetItems`, `QuoteLineActionAddItemOptions`, `QuoteLineActionSetItemOptions`, `QuotePreviewSubscriptionSchedule.Phase.Item`, `SubscriptionSchedule.Phase.Item`, `SubscriptionScheduleAmendmentItemActionAddOptions`, `SubscriptionScheduleAmendmentItemActionSetOptions`, and `SubscriptionSchedulePhaseItemOptions`
  * Add support for `RiskReserved` on `Balance`
  * ⚠️ Remove support for `SourceType` on `Charge.PaymentMethodDetails.StripeBalance`, `ConfirmationToken.PaymentMethodPreview.StripeBalance`, `ConfirmationTokenPaymentMethodDataStripeBalanceOptions`, `PaymentAttemptRecord.PaymentMethodDetails.StripeBalance`, `PaymentIntentPaymentMethodDataStripeBalanceOptions`, `PaymentMethod.StripeBalance`, `PaymentMethodStripeBalanceOptions`, `PaymentRecord.PaymentMethodDetails.StripeBalance`, and `SetupIntentPaymentMethodDataStripeBalanceOptions`
  * Add support for `TaxDetails` on `CheckoutSessionLineItemPriceDataProductDataOptions`, `InvoiceLineItemPriceDataProductDataOptions`, `InvoiceLinePriceDataProductDataOptions`, `PaymentLinkLineItemPriceDataProductDataOptions`, `PlanProductOptions`, `PriceProductDataOptions`, `ProductCreateOptions`, and `ProductUpdateOptions`
  * Add support for `PendingInvoiceItemInterval` on `CheckoutSessionSubscriptionDataOptions`
  * Add support for `Hosted` and `UiMode` on `FinancialConnections.SessionCreateOptions` and `FinancialConnections.Session`
  * Add support for `Url` on `FinancialConnections.Session`
  * Add support for `ExpiresAfterSeconds` on `Invoice.PaymentSettings.PaymentMethodOptions.Pix`, `InvoicePaymentSettingsPaymentMethodOptionsPixOptions`, `QuotePreviewInvoice.PaymentSettings.PaymentMethodOptions.Pix`, `Subscription.PaymentSettings.PaymentMethodOptions.Pix`, and `SubscriptionPaymentSettingsPaymentMethodOptionsPixOptions`
  * Add support for `CurrentTrial` on `InvoiceSubscriptionDetailsItemOptions`, `SubscriptionItemCreateOptions`, `SubscriptionItemOptions`, `SubscriptionItemUpdateOptions`, and `SubscriptionItem`
  * Add support for `Surcharge` on `PaymentIntent.AmountDetails` and `PaymentIntentAmountDetailsOptions`
  * Add support for `AmountDetails` and `PaymentDetails` on `PaymentIntentDecrementAuthorizationOptions`
  * Add support for `MandateOptions` on `PaymentIntent.PaymentMethodOptions.StripeBalance`
  * Add support for `ManagedPayments` on `PaymentLinkCreateOptions` and `PaymentLink`
  * Add support for `StripeBalance` on `SetupIntent.PaymentMethodOptions` and `SetupIntentPaymentMethodOptionsOptions`
  * Add support for `BillingCycleAnchor` on `Subscription.TrialSettings.EndBehavior` and `SubscriptionTrialSettingsEndBehaviorOptions`
  * Add support for `AdmissionsTax`, `AttendanceTax`, `EntertainmentTax`, `GrossReceiptsTax`, `HospitalityTax`, `LuxuryTax`, `ResortTax`, and `TourismTax` on `Tax.Registration.CountryOptions.Us`
  * Add support for `Requirements` on `TaxCode`
  * ⚠️ Change type of `V2.Billing.Cadence.SettingsData.Collection.PaymentMethodOptions.Card.MandateOptions.Amount`, `V2.Billing.CollectionSetting.PaymentMethodOptions.Card.MandateOptions.Amount`, `V2.Billing.CollectionSettingVersion.PaymentMethodOptions.Card.MandateOptions.Amount`, and `V2BillingCollectionSettingPaymentMethodOptionsCardMandateOptionsOptions.Amount` from `longInteger` to `int64_string`
  * Add support for `Timezone` on `V2.Core.Account.Defaults` and `V2CoreAccountDefaultsOptions`
  * Add support for `AzureEventGrid` on `V2.Core.EventDestinationCreateOptions` and `V2.Core.EventDestination`
  * Add support for `SupportedCurrencies` on `V2.Core.Vault.GbBankAccount`, `V2.Core.Vault.UsBankAccount`, and `V2.MoneyManagement.PayoutMethod.Card`
  * Add support for `Restricted` on `V2.MoneyManagement.PayoutMethod`
  * Add support for `Currencies` on `V2.MoneyManagement.PayoutMethodsBankAccountSpec.Countries.Field`
  * Add support for `Counterparty` and `Description` on `V2.MoneyManagement.Transaction`
  * ⚠️ Add support for `Currency` on `V2.Core.Vault.GbBankAccountCreateOptions`, `V2.Core.Vault.UsBankAccountCreateOptions`, `V2MoneyManagementOutboundSetupIntentPayoutMethodDataBankAccountOptions`, and `V2MoneyManagementOutboundSetupIntentPayoutMethodDataCardOptions`
  * Add support for `Iban` on `V2.Core.Vault.GbBankAccountCreateOptions`
  * Add support for event notifications `V2CoreBatchJobBatchFailedEvent`, `V2CoreBatchJobCanceledEvent`, `V2CoreBatchJobCompletedEvent`, `V2CoreBatchJobCreatedEvent`, `V2CoreBatchJobReadyForUploadEvent`, `V2CoreBatchJobTimeoutEvent`, `V2CoreBatchJobUpdatedEvent`, `V2CoreBatchJobUploadTimeoutEvent`, `V2CoreBatchJobValidatingEvent`, and `V2CoreBatchJobValidationFailedEvent` with related object `V2.Core.BatchJob`
* [#3349](https://github.com/stripe/stripe-dotnet/pull/3349) Update generated code for beta

## 50.5.0-beta.1 - 2026-02-25
This release changes the pinned API version to `2026-02-25.preview`.

* [#3298](https://github.com/stripe/stripe-dotnet/pull/3298) Update generated code for beta
  * Add support for `SmartDisputes` on `Account.Settings`, `AccountSettingsOptions`, `V2.Core.Account.Configuration.Merchant`, and `V2CoreAccountConfigurationMerchantOptions`
  * Add support for `EmailCustomersOnSuccessfulPayment` on `Account.Settings.Payments` and `AccountSettingsPaymentsOptions`
  * Add support for `ManagedPayments` on `Checkout.SessionCreateOptions`, `Checkout.Session`, `PaymentIntent`, `SetupIntent`, and `Subscription`
  * Add support for `Purpose` on `V2.MoneyManagement.OutboundPaymentCreateOptions` and `V2.MoneyManagement.OutboundPayment`
  * Add support for `BranchNumber` and `SwiftCode` on `V2.MoneyManagement.PayoutMethod.BankAccount`

## 50.4.0-beta.1 - 2026-01-28
This release changes the pinned API version to `2026-01-28.preview`.

* [#3276](https://github.com/stripe/stripe-dotnet/pull/3276) Add EventNotificationHandler example
* [#3291](https://github.com/stripe/stripe-dotnet/pull/3291) Update generated code for beta
  * Add support for new resource `FinancialConnections.Authorization`
  * Add support for `Get` method on resource `FinancialConnections.Authorization`
  * Add support for `DetachPayment` method on resource `Invoice`
  * Remove support for `Cancel`, `ListLineItems`, and `Reopen` methods on resource `Order`
  * Remove support for `AttachCadence` method on resource `Subscription`
  * Add support for `AdditionalFiles` and `Site` on `Account.Settings.PaypayPayments` and `AccountSettingsPaypayPaymentsOptions`
  * Remove support for `Capital` on `Account.Settings`
  * Add support for `Authorization` and `StatusDetails` on `FinancialConnections.Account`
  * Add support for `RelinkOptions` on `FinancialConnections.SessionCreateOptions` and `FinancialConnections.Session`
  * Add support for `RelinkResult` on `FinancialConnections.Session`
  * Remove support for `BillingCadence` on `InvoiceCreatePreviewOptions`, `SubscriptionCreateOptions`, `SubscriptionUpdateOptions`, and `Subscription`
  * Remove support for `BillingCadenceDetails` on `Invoice.Parent` and `QuotePreviewInvoice.Parent`
  * Add support for `CarRentalData`, `FlightData`, and `LodgingData` on `PaymentIntent.PaymentDetails`
  * Add support for `AlternativeReference` on `V2.Core.Vault.GbBankAccount`, `V2.Core.Vault.UsBankAccount`, and `V2.MoneyManagement.PayoutMethod`
  * Add support for `AccountHolderAddress` and `AccountHolderName` on `V2.MoneyManagement.FinancialAddress.Credentials.UsBankAccount`
  * Add support for `Fingerprint` on `V2.MoneyManagement.PayoutMethod.Card`
  * Add support for snapshot event `InvoicePaymentDetached` with resource `InvoicePayment`

## 50.2.0-beta.1 - 2025-12-16
This release changes the pinned API version to `2025-12-15.preview`.

* [#3250](https://github.com/stripe/stripe-dotnet/pull/3250) Add EventNotificationHandler
  * This is a new, simplified way to handle event notifications (AKA thin event webhooks). Learn more in the docs: https://docs.stripe.com/webhooks/event-notification-handlers?lang=dotnet
* [#3263](https://github.com/stripe/stripe-dotnet/pull/3263) Update generated code for beta
  * Add support for new resources `Reserve.Hold`, `Reserve.Plan`, and `Reserve.Release`
  * Add support for `Get` and `List` methods on resources `Reserve.Hold` and `Reserve.Release`
  * Add support for `Get` method on resource `Reserve.Plan`
  * Change type of `V2.FinancialAddressGeneratedMicrodeposits.Amounts` from `amount` to `an object`
  * Change type of `CheckoutSessionPaymentMethodOptionsPaytoMandateOptionsOptions.Amount`, `PaymentIntentPaymentMethodOptionsPaytoMandateOptionsOptions.Amount`, and `SetupIntentPaymentMethodOptionsPaytoMandateOptionsOptions.Amount` from `longInteger` to `emptyable(longInteger)`
  * Change type of `CheckoutSessionPaymentMethodOptionsPaytoMandateOptionsOptions.AmountType`, `PaymentIntentPaymentMethodOptionsPaytoMandateOptionsOptions.AmountType`, and `SetupIntentPaymentMethodOptionsPaytoMandateOptionsOptions.AmountType` from `enum('fixed'|'maximum')` to `emptyable(enum('fixed'|'maximum'))`
  * Change type of `CheckoutSessionPaymentMethodOptionsPaytoMandateOptionsOptions.EndDate`, `PaymentIntentPaymentMethodOptionsPaytoMandateOptionsOptions.EndDate`, and `SetupIntentPaymentMethodOptionsPaytoMandateOptionsOptions.EndDate` from `string` to `emptyable(string)`
  * Change type of `CheckoutSessionPaymentMethodOptionsPaytoMandateOptionsOptions.PaymentSchedule`, `PaymentIntentPaymentMethodOptionsPaytoMandateOptionsOptions.PaymentSchedule`, and `SetupIntentPaymentMethodOptionsPaytoMandateOptionsOptions.PaymentSchedule` from `enum` to `emptyable(enum)`
  * Change type of `CheckoutSessionPaymentMethodOptionsPaytoMandateOptionsOptions.PaymentsPerPeriod`, `PaymentIntentPaymentMethodOptionsPaytoMandateOptionsOptions.PaymentsPerPeriod`, and `SetupIntentPaymentMethodOptionsPaytoMandateOptionsOptions.PaymentsPerPeriod` from `longInteger` to `emptyable(longInteger)`
  * Change type of `CheckoutSessionPaymentMethodOptionsPaytoMandateOptionsOptions.Purpose`, `PaymentIntentPaymentMethodOptionsPaytoMandateOptionsOptions.Purpose`, and `SetupIntentPaymentMethodOptionsPaytoMandateOptionsOptions.Purpose` from `enum` to `emptyable(enum)`
  * Change type of `CheckoutSessionPaymentMethodOptionsPaytoMandateOptionsOptions.StartDate` and `SetupIntentPaymentMethodOptionsPaytoMandateOptionsOptions.StartDate` from `string` to `emptyable(string)`
  * Add support for `AsyncWorkflows` on `PaymentIntent`
  * Add support for `Payto` on `QuotePreviewInvoice.PaymentSettings.PaymentMethodOptions`
  * Remove support for `Requested` on `V2.Core.Account.Configuration.Customer.Capabilities.AutomaticIndirectTax`, `V2.Core.Account.Configuration.Merchant.Capabilities.AchDebitPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.AcssDebitPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.AffirmPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.AfterpayClearpayPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.AlmaPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.AmazonPayPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.AuBecsDebitPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.BacsDebitPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.BancontactPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.BlikPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.BoletoPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.CardPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.CartesBancairesPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.CashappPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.EpsPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.FpxPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.GbBankTransferPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.GrabpayPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.IdealPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.JcbPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.JpBankTransferPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.KakaoPayPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.KlarnaPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.KonbiniPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.KrCardPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.LinkPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.MobilepayPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.MultibancoPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.MxBankTransferPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.NaverPayPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.OxxoPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.P24Payments`, `V2.Core.Account.Configuration.Merchant.Capabilities.PayByBankPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.PaycoPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.PaynowPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.PromptpayPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.RevolutPayPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.SamsungPayPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.SepaBankTransferPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.SepaDebitPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.StripeBalance.Payouts`, `V2.Core.Account.Configuration.Merchant.Capabilities.SwishPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.TwintPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.UsBankTransferPayments`, `V2.Core.Account.Configuration.Merchant.Capabilities.ZipPayments`, `V2.Core.Account.Configuration.Recipient.Capabilities.BankAccounts.Local`, `V2.Core.Account.Configuration.Recipient.Capabilities.BankAccounts.Wire`, `V2.Core.Account.Configuration.Recipient.Capabilities.Cards`, `V2.Core.Account.Configuration.Recipient.Capabilities.StripeBalance.Payouts`, `V2.Core.Account.Configuration.Recipient.Capabilities.StripeBalance.StripeTransfers`, `V2.Core.Account.Configuration.Storer.Capabilities.FinancialAddresses.BankAccounts`, `V2.Core.Account.Configuration.Storer.Capabilities.HoldsCurrencies.Eur`, `V2.Core.Account.Configuration.Storer.Capabilities.HoldsCurrencies.Gbp`, `V2.Core.Account.Configuration.Storer.Capabilities.HoldsCurrencies.Usd`, `V2.Core.Account.Configuration.Storer.Capabilities.InboundTransfers.BankAccounts`, `V2.Core.Account.Configuration.Storer.Capabilities.OutboundPayments.BankAccounts`, `V2.Core.Account.Configuration.Storer.Capabilities.OutboundPayments.Cards`, `V2.Core.Account.Configuration.Storer.Capabilities.OutboundPayments.FinancialAccounts`, `V2.Core.Account.Configuration.Storer.Capabilities.OutboundTransfers.BankAccounts`, and `V2.Core.Account.Configuration.Storer.Capabilities.OutboundTransfers.FinancialAccounts`
  * Change type of `V2.Core.Account.Identity.BusinessDetails.AnnualRevenue.Amount`, `V2.Core.Account.Identity.BusinessDetails.MonthlyEstimatedRevenue.Amount`, `V2.FinancialAddressCreditSimulationCreditOptions.Amount`, `V2.MoneyManagement.Adjustment.Amount`, `V2.MoneyManagement.InboundTransfer.Amount`, `V2.MoneyManagement.InboundTransferCreateOptions.Amount`, `V2.MoneyManagement.OutboundPayment.Amount`, `V2.MoneyManagement.OutboundPaymentCreateOptions.Amount`, `V2.MoneyManagement.OutboundPaymentQuote.Amount`, `V2.MoneyManagement.OutboundPaymentQuote.EstimatedFee.Amount`, `V2.MoneyManagement.OutboundPaymentQuoteCreateOptions.Amount`, `V2.MoneyManagement.OutboundTransfer.Amount`, `V2.MoneyManagement.OutboundTransferCreateOptions.Amount`, `V2.MoneyManagement.ReceivedCredit.Amount`, `V2.MoneyManagement.ReceivedDebit.Amount`, `V2.MoneyManagement.Transaction.Amount`, `V2CoreAccountIdentityBusinessDetailsAnnualRevenueOptions.Amount`, `V2CoreAccountIdentityBusinessDetailsMonthlyEstimatedRevenueOptions.Amount`, `V2CoreAccountTokenIdentityBusinessDetailsAnnualRevenueOptions.Amount`, and `V2CoreAccountTokenIdentityBusinessDetailsMonthlyEstimatedRevenueOptions.Amount` from `amount` to `an object`
  * Add support for `FinancialConnectionsAccount` on `V2.Core.Vault.UsBankAccount` and `V2.MoneyManagement.PayoutMethod.BankAccount`
  * Change type of `V2.MoneyManagement.FinancialAccount.Balance.Available`, `V2.MoneyManagement.Transaction.BalanceImpact.Available`, and `V2.MoneyManagement.TransactionEntry.BalanceImpact.Available` from `amount` to `an object`
  * Change type of `V2.MoneyManagement.FinancialAccount.Balance.InboundPending`, `V2.MoneyManagement.Transaction.BalanceImpact.InboundPending`, and `V2.MoneyManagement.TransactionEntry.BalanceImpact.InboundPending` from `amount` to `an object`
  * Change type of `V2.MoneyManagement.FinancialAccount.Balance.OutboundPending`, `V2.MoneyManagement.Transaction.BalanceImpact.OutboundPending`, and `V2.MoneyManagement.TransactionEntry.BalanceImpact.OutboundPending` from `amount` to `an object`
  * Change type of `V2.MoneyManagement.InboundTransfer.From.Debited`, `V2.MoneyManagement.OutboundPayment.From.Debited`, `V2.MoneyManagement.OutboundPaymentQuote.From.Debited`, and `V2.MoneyManagement.OutboundTransfer.From.Debited` from `amount` to `an object`
  * Change type of `V2.MoneyManagement.InboundTransfer.To.Credited`, `V2.MoneyManagement.OutboundPayment.To.Credited`, `V2.MoneyManagement.OutboundPaymentQuote.To.Credited`, and `V2.MoneyManagement.OutboundTransfer.To.Credited` from `amount` to `an object`
  * Add support for `Transfer` on `V2.MoneyManagement.ReceivedCredit.BalanceTransfer`
  * Add support for event notification `V2MoneyManagementPayoutMethodCreatedEvent` with related object `V2.MoneyManagement.PayoutMethod`
  * Add support for error type `ControlledByAlternateResourceException`
  * Remove support for error type `RateLimitException`

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
  * Add support for thin event `V2CoreHealthEventGenerationFailureResolvedEvent`
  * Remove support for thin events `V2PaymentsOffSessionPaymentAuthorizationAttemptFailedEvent`, `V2PaymentsOffSessionPaymentAuthorizationAttemptStartedEvent`, `V2PaymentsOffSessionPaymentCanceledEvent`, `V2PaymentsOffSessionPaymentCreatedEvent`, `V2PaymentsOffSessionPaymentFailedEvent`, `V2PaymentsOffSessionPaymentRequiresCaptureEvent`, and `V2PaymentsOffSessionPaymentSucceededEvent` with related object `V2.Payments.OffSessionPayment`

## 49.2.0-beta.1 - 2025-10-29
This release changes the pinned API version to `2025-10-29.preview`.

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
* [#3234](https://github.com/stripe/stripe-dotnet/pull/3234) Update generated code for beta
  * Add support for `CryptoStorer` on `V2CoreAccountIdentityAttestationsTermsOfServiceOptions`

## 49.1.0-beta.1 - 2025-09-30
This release changes the pinned API version to `2025-09-30.preview`.

It is built on top of SDK version 49.0.0 which contains breaking changes. Please review the [changelog for 49.0.0](https://github.com/stripe/stripe-dotnet/blob/master/CHANGELOG.md#4900---2025-09-30) if upgrading from older SDK versions.

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

## 48.5.0-beta.2 - 2025-08-08
* [#3155](https://github.com/stripe/stripe-dotnet/pull/3155) Fix links to pinned api versions in CHANGELOG.md in beta branch
* [#3160](https://github.com/stripe/stripe-dotnet/pull/3160) Bring back invoice payments APIs that were missing in the public preview SDKs
  * Add support for new resource `InvoicePayment`
  * Add support for `Get` and `List` methods on resource `InvoicePayment`

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

## 48.2.0-beta.2 - 2025-04-30
* [#3122](https://github.com/stripe/stripe-dotnet/pull/3122) Update generated code for beta
  Release specs are identical.

## 48.2.0-beta.1 - 2025-04-30
This release changes the pinned API version to `2025-04-30.preview`.

* [#3107](https://github.com/stripe/stripe-dotnet/pull/3107) Update generated code for beta
  This release changes the pinned API version to `2025-04-30.preview`.

  * Add support for `BillingMode` on `CheckoutSessionSubscriptionDataOptions`, `InvoiceScheduleDetailsOptions`, `InvoiceSubscriptionDetailsOptions`, `Quote.SubscriptionData`, `QuotePreviewSubscriptionSchedule`, `QuoteSubscriptionDataOptions`, `SubscriptionCreateOptions`, `SubscriptionScheduleCreateOptions`, `SubscriptionSchedule`, and `Subscription`
  * Add support for `AccountNumber` on `ConfirmationToken.PaymentMethodPreview.AcssDebit` and `PaymentMethod.AcssDebit`

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
* [#3092](https://github.com/stripe/stripe-dotnet/pull/3092) Handle external_account field
  - Changes `externalAccount` field in `externalAccounts.create` from a `string` to a union type.
* [#3094](https://github.com/stripe/stripe-dotnet/pull/3094) Update generated code for beta
  * Add support for new resources `Privacy.RedactionJobRootObjects`, `Privacy.RedactionJobValidationError`, and `Privacy.RedactionJob`
  * Add support for `Cancel`, `Create`, `Get`, `List`, `Run`, `Update`, and `Validate` methods on resource `RedactionJob`
  * Add support for `Get` and `List` methods on resource `RedactionJobValidationError`
  * Add support for `MinorityOwnedBusinessDesignation` on `AccountBusinessProfileOptions` and `AccountBusinessProfile`
  * Add support for `ExportTaxTransactions` and `PaymentDisputes` on `AccountSessionComponentsOptions`
  * Add support for `WalletOptions` on `Checkout.SessionCreateOptions` and `CheckoutSession`
  * Add support for `Klarna` on `PaymentMethodDomain`
  * Add support for `In` on `TaxRegistrationCountryOptionsOptions` and `TaxRegistrationCountryOptions`

## 48.1.0-beta.2 - 2025-04-02
* Re-releasing 48.1.0-beta.1 as it had publishing issues

## 48.1.0-beta.1 - 2025-04-02
This release changes the pinned API version to `2025-03-31.preview`.

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

* [#3079](https://github.com/stripe/stripe-dotnet/pull/3079) Update generated code for beta

### Changes
* [#3069](https://github.com/stripe/stripe-dotnet/pull/3069) Enhance beta version handling in ApiVersion
  * `StripeConfiguation.AddBetaVersion` will use the highest version number used for a beta feature instead of throwing an `Exception` on a conflict as it had done previously.

## 47.5.0-beta.1 - 2025-03-18
This release changes the pinned API version to `2025-02-24.acacia`.

* [#3062](https://github.com/stripe/stripe-dotnet/pull/3062) Beta SDK updates between Open API versions 1473 and 1505
  * Add support for `SucceedInputCollection` and `TimeoutInputCollection` test helper methods on resource `Terminal.Reader`
  * Add support for `TargetDate` on `OrderPaymentSettingsPaymentMethodOptionsAcssDebitOptions`, `OrderPaymentSettingsPaymentMethodOptionsAcssDebit`, `OrderPaymentSettingsPaymentMethodOptionsSepaDebitOptions`, and `OrderPaymentSettingsPaymentMethodOptionsSepaDebit`

## 47.4.0-beta.1 - 2025-02-07
* [#3049](https://github.com/stripe/stripe-dotnet/pull/3049) Update generated code for beta
  * Add support for `RejectedReason` on `AccountRiskControls`
  * Add support for `ProductTaxCodeSelector` on `AccountSessionComponentsOptions`
  * Add support for `Prices` on `BillingCreditBalanceSummaryFilterApplicabilityScopeOptions`, `BillingCreditGrantApplicabilityConfigScopeOptions`, and `BillingCreditGrantApplicabilityConfigScope`
  * Add support for `BrandProduct` on `ChargePaymentMethodDetailsAmazonPayFundingCard` and `ChargePaymentMethodDetailsRevolutPayFundingCard`
  * Add support for `Restrictions` on `CheckoutSessionPaymentMethodOptionsCardOptions` and `CheckoutSessionPaymentMethodOptionsCard`

## 47.3.0-beta.3 - 2025-01-23
* [#3048](https://github.com/stripe/stripe-dotnet/pull/3048) Update generated code for beta
  * Remove support for `StripeAccount` on `TerminalReaderActionCollectPaymentMethod`, `TerminalReaderActionConfirmPaymentIntent`, `TerminalReaderActionProcessPaymentIntent`, and `TerminalReaderActionRefundPayment`

## 47.3.0-beta.2 - 2025-01-17
This release changes the pinned API version to `2025-01-27.acacia`.

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

## 47.2.0-beta.3 - 2024-12-12
This release changes the pinned API version to `2024-12-18.acacia`.

* [#3033](https://github.com/stripe/stripe-dotnet/pull/3033) System.Text.Json Serialization Support in .NET SDK Objects
  - Add System.Text.Json support for serializing Stripe.net entities and objects for applications running on .NET 6 and above. Now you can pass a Stripe.net object or collection of objects to the System.Text.Json serializer and it will produce the correct JSON string.
* [#3035](https://github.com/stripe/stripe-dotnet/pull/3035) Update generated code for beta
  * Add support for `AllowRedisplay` on `Card` and `Source`
  * Remove support for `AmountRefunded` on `PaymentRecord`
  * Add support for `Account` on `TerminalReaderActionCollectPaymentMethod`, `TerminalReaderActionConfirmPaymentIntent`, `TerminalReaderActionProcessPaymentIntent`, and `TerminalReaderActionRefundPayment`

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

## 47.1.0-beta.3 - 2024-11-14
This release changes the pinned API version to `2024-11-20.acacia`.

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
This release changes the pinned API version to `2024-10-28.acacia`.

* [#3011](https://github.com/stripe/stripe-dotnet/pull/3011) Do not allow setting API Version directly on StripeConfiguration
  * `StripeConfiguration.ApiVersion` is no longer settable. If you were using this to set the beta headers, use the helper method `StripeConfiguration.AddBetaVersion()` instead.
* [#3018](https://github.com/stripe/stripe-dotnet/pull/3018) Update generated code for beta
  * Add support for `TriggerAction` method on resource `PaymentIntent`
  * Add support for `IdBankTransferPaymentsBca` and `IdBankTransferPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
  * Add support for `BankBcaOnboarding` on `AccountSettingsOptions` and `AccountSettings`
  * Add support for `SendMoney` on `AccountSessionComponentsRecipientsFeaturesOptions`
  * Add support for `IdBankTransfer` on `ChargePaymentMethodDetails`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `InvoicePaymentSettingsPaymentMethodOptionsOptions`, `InvoicePaymentSettingsPaymentMethodOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, `PaymentMethodCreateOptions`, `PaymentMethod`, `RefundDestinationDetails`, `SetupAttemptPaymentMethodDetails`, `SetupIntentPaymentMethodDataOptions`, `SubscriptionPaymentSettingsPaymentMethodOptionsOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptions`
  * Add support for `Gopay`, `Qris`, and `Shopeepay` on `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, and `PaymentMethodConfiguration`

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

## 46.2.0-beta.2 - 2024-10-08

## 46.2.0-beta.1 - 2024-10-03
This release changes the pinned API version to `2024-09-30.acacia`.

* [#2991](https://github.com/stripe/stripe-dotnet/pull/2991) Updates beta branch with changes in master and update generated code
  * Add support for `ReportingChart` on `AccountSessionComponentsOptions`
  * Remove support for `FromSchedule` on `QuoteSubscriptionData`
  * Add support for `AllowRedisplay` on `TerminalReaderCollectConfigOptions`

## 45.15.0-beta.1 - 2024-09-18
* [#2973](https://github.com/stripe/stripe-dotnet/pull/2973) Update generated code for beta
  * Remove support for resource `QuotePhase`
  * Remove support for `Get` and `ListLineItems` methods on resource `QuotePhase`
  * Add support for `SendMoney` and `TransferBalance` on `AccountSessionComponentsFinancialAccountFeaturesOptions`

## 45.13.0-beta.1 - 2024-09-13
* [#2961](https://github.com/stripe/stripe-dotnet/pull/2961) Update generated code for beta
  * Add support for new resources `Issuing.DisputeSettlementDetail` and `Issuing.Settlement`
  * Add support for `Get` and `List` methods on resource `DisputeSettlementDetail`
  * Remove support for `List` method on resource `QuotePhase`
  * Add support for `Settlement` on `Issuing.TransactionListOptions` and `IssuingTransaction`

## 45.12.0-beta.1 - 2024-09-05
* [#2956](https://github.com/stripe/stripe-dotnet/pull/2956) Update generated code for beta
  * Add support for new resources `Billing.MeterErrorReport` and `Terminal.ReaderCollectedData`
  * Add support for `Get` method on resource `ReaderCollectedData`
  * Add support for `Recipients` on `AccountSessionComponentsOptions`
  * Add support for `BusinessName` and `TaxIds` on `CheckoutSessionCollectedInformation`
  * Add support for `RegulatoryReportingFile` on `Issuing.CreditUnderwritingRecordCorrectOptions`, `Issuing.CreditUnderwritingRecordCreateFromProactiveReviewOptions`, `Issuing.CreditUnderwritingRecordReportDecisionOptions`, and `IssuingCreditUnderwritingRecord`
  * Remove support for `Rechnung` on `PaymentMethodUpdateOptions`

## 45.10.0-beta.1 - 2024-08-23
* [#2954](https://github.com/stripe/stripe-dotnet/pull/2954) Update generated code for beta
  * Add support for `Email` and `Phone` on `CheckoutSessionCollectedInformation`

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

## 45.8.0-beta.1 - 2024-08-12
* ⚠️ [#2947](https://github.com/stripe/stripe-dotnet/pull/2947) Update generated code for beta
  * Add support for `CapitalFinancingApplication` and `CapitalFinancing` on `AccountSessionComponents`
  * Add support for `Payto` on `CheckoutSessionPaymentMethodOptionsOptions` and `CheckoutSessionPaymentMethodOptions`
  * ⚠️  Remove support for `RiskCorrelationId` on `PaymentIntentPaymentMethodOptionsRechnungOptions` and `PaymentIntentPaymentMethodOptionsRechnung`

## 45.7.0-beta.1 - 2024-08-01
* [#2945](https://github.com/stripe/stripe-dotnet/pull/2945) Update generated code for beta
  * Add support for `AttachPayment` method on resource `Invoice`
  * Add support for `AppInstall` and `AppViewport` on `AccountSessionComponentsOptions`
  * Remove support for `PartnerRejectedDetails` on `DisputeEvidenceDetailsEnhancedEligibilityVisaCompellingEvidence3`
  * Add support for `LinesInvalid` on `QuoteStatusDetailsStaleLastReason`
  * Add support for `LastPriceMigrationError` on `SubscriptionSchedule` and `Subscription`

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

## 45.3.0-beta.1 - 2024-07-05
* ⚠️ [#2933](https://github.com/stripe/stripe-dotnet/pull/2933) Update generated code for beta
  * ⚠️ Remove support for `PaymentMethodUpdate` on `CustomerSessionComponentsPaymentElementFeaturesOptions` and `CustomerSessionComponentsPaymentElementFeatures`. Users are expected to completely migrate from using `payment_method_update`.
  * Add support for new resource `FinancialConnections.Institution`
  * Add support for `Get` and `List` methods on resource `Institution`
  * Add support for `Institution` on `CheckoutSessionPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters`, `FinancialConnectionsSessionFiltersOptions`, `FinancialConnectionsSessionFilters`, `InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsFiltersOptions`, `InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters`, `PaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFiltersOptions`, `PaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters`, `SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFiltersOptions`, `SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters`, `SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsFiltersOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters`
  * Add support for `PaymentMethodAllowRedisplayFilters`, `PaymentMethodRedisplayLimit`, `PaymentMethodRedisplay`, and `PaymentMethodSaveUsage` on `CustomerSessionComponentsPaymentElementFeaturesOptions` and `CustomerSessionComponentsPaymentElementFeatures`

## 45.2.0-beta.1 - 2024-06-27
This release changes the pinned API version to `2024-06-20`.

* [#2928](https://github.com/stripe/stripe-dotnet/pull/2928) Update generated code for beta
  * Remove support for `PaymentMethodSetAsDefault` on `CustomerSessionComponentsPaymentElementFeaturesOptions` and `CustomerSessionComponentsPaymentElementFeatures`

## 44.13.0-beta.1 - 2024-06-13
* [#2923](https://github.com/stripe/stripe-dotnet/pull/2923) Syncing changes from 44.12.0 release

## 44.12.0-beta.1 - 2024-06-06
* [#2920](https://github.com/stripe/stripe-dotnet/pull/2920) Update generated code for beta
  * Add support for `Twint` on `PaymentIntentPaymentMethodOptionsOptions` and `PaymentIntentPaymentMethodOptions`

## 44.11.0-beta.1 - 2024-05-30
* [#2915](https://github.com/stripe/stripe-dotnet/pull/2915) Update generated code for beta
  * Keeping up with the changes from version 44.11.0

## 44.10.0-beta.1 - 2024-05-23
* [#2912](https://github.com/stripe/stripe-dotnet/pull/2912) Update generated code for beta

## 44.9.0-beta.1 - 2024-05-16
* [#2908](https://github.com/stripe/stripe-dotnet/pull/2908) Update generated code for beta

## 44.7.0-beta.1 - 2024-05-09
* [#2905](https://github.com/stripe/stripe-dotnet/pull/2905) Update generated code for beta
  * No new beta features. Merging changes from the main branch.

## 44.6.0-beta.1 - 2024-05-02
* [#2901](https://github.com/stripe/stripe-dotnet/pull/2901) Update generated code for beta
  * Add support for `RechnungPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
  * Add support for `Rechnung` on `ChargePaymentMethodDetails`, `ConfirmationTokenPaymentMethodDataOptions`, `ConfirmationTokenPaymentMethodPreview`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethodUpdateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
  * Add support for `Multibanco` on `CheckoutSessionPaymentMethodOptionsOptions` and `CheckoutSessionPaymentMethodOptions`

## 44.5.0-beta.1 - 2024-04-25
* [#2896](https://github.com/stripe/stripe-dotnet/pull/2896) Update generated code for beta
  * Add support for `PaymentMethodSettings` on `AccountSessionComponentsOptions`
  * Add support for `CancelSubscriptionSchedule` on `QuoteLine` and `QuoteLinesOptions`

## 44.4.0-beta.1 - 2024-04-18
* [#2893](https://github.com/stripe/stripe-dotnet/pull/2893) Update generated code for beta
  * Add support for `CapitalOverview`, `TaxRegistrations`, and `TaxSettings` on `AccountSessionComponentsOptions`
  * Add support for `ExternalAccountCollection` on `AccountSessionComponentsFinancialAccountFeaturesOptions`
  * Add support for `SubscriptionTrialFromPlan` on `InvoiceUpcomingLinesOptions` and `InvoiceUpcomingOptions`

## 44.2.0-beta.1 - 2024-04-11
This release changes the pinned API version to `2024-04-10`.

* [#2886](https://github.com/stripe/stripe-dotnet/pull/2886) Update generated code for beta
  * Add support for `Get` method on resources `Entitlements.ActiveEntitlement` and `Entitlements.Feature`
  * Add support for `Fees`, `Losses`, `RequirementCollection`, and `StripeDashboard` on `AccountControllerOptions`
  * Add support for `HostedVoucherUrl` on `PaymentIntentNextActionMultibancoDisplayDetails`
  * Add support for `Toggles` on `TerminalReaderActionCollectInputsInputs` and `TerminalReaderInputsOptions`
  * Add support for `Email`, `Numeric`, `Phone`, and `Text` on `TerminalReaderActionCollectInputsInputs`

## 43.23.0-beta.1 - 2024-04-04
* [#2882](https://github.com/stripe/stripe-dotnet/pull/2882) Update generated code for beta
  * Add support for `Update` method on resource `Entitlements.Feature`
  * Add support for `RiskControls` on `AccountCreateOptions`, `AccountUpdateOptions`, and `Account`
  * Add support for `PromotionCode` on `InvoiceLinesDiscountsOptions`, `QuoteLineItemsDiscountsOptions`, `QuoteLinesActionsAddDiscountOptions`, and `QuotePhasesLineItemsDiscountsOptions`

## 43.22.0-beta.1 - 2024-03-28
* [#2878](https://github.com/stripe/stripe-dotnet/pull/2878) Update generated code for beta
  * Add support for `FinancialAccountTransactions`, `FinancialAccount`, `IssuingCard`, and `IssuingCardsList` on `AccountSessionComponentsOptions`
  * Remove support for `SubscriptionBillingCycleAnchor`, `SubscriptionCancelAtPeriodEnd`, `SubscriptionCancelAt`, `SubscriptionCancelNow`, `SubscriptionDefaultTaxRates`, `SubscriptionItems`, `SubscriptionPrebilling`, `SubscriptionProrationBehavior`, `SubscriptionProrationDate`, `SubscriptionResumeAt`, `SubscriptionStartDate`, and `SubscriptionTrialEnd` on `InvoiceCreatePreviewOptions`

## 43.21.0-beta.1 - 2024-03-21
* [#2870](https://github.com/stripe/stripe-dotnet/pull/2870) Update generated code for beta
  Release specs are identical.
* [#2875](https://github.com/stripe/stripe-dotnet/pull/2875) Update generated code for beta
  * Add support for new resources `Entitlements.ActiveEntitlementSummary` and `Entitlements.ActiveEntitlement`
  * Add support for `List` method on resource `ActiveEntitlement`
  * Add support for `Mobilepay` on `ConfirmationTokenPaymentMethodDataOptions` and `ConfirmationTokenPaymentMethodPreview`
  * Add support for `UseStripeSdk` on `ConfirmationToken`
  * Remove support for `PaymentMethod` on `ConfirmationToken`
  * Add support for `Metadata` on `Entitlements.FeatureCreateOptions` and `EntitlementsFeature`
  * Add support for `Active` on `EntitlementsFeature`

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

## 43.19.0-beta.1 - 2024-03-07
* [#2861](https://github.com/stripe/stripe-dotnet/pull/2861) Update generated code for beta

## 43.18.0-beta.1 - 2024-02-29
* [#2855](https://github.com/stripe/stripe-dotnet/pull/2855) Add helper to add beta version
* [#2853](https://github.com/stripe/stripe-dotnet/pull/2853) Update generated code for beta
  * Remove support for resource `Entitlements.Event`
  * Remove support for `Quantity` and `Type` on `Entitlements.FeatureCreateOptions` and `EntitlementsFeature`
  * Add support for `Livemode` on `IssuingPersonalizationDesign`
  * Add support for `ApplicationFeeAmount`, `Description`, `Metadata`, and `TransferData` on `PaymentIntentDecrementAuthorizationOptions`
  * Add support for `EnableCustomerCancellation` on `TerminalReaderActionCollectPaymentMethodCollectConfig` and `TerminalReaderCollectConfigOptions`

## 43.17.0-beta.1 - 2024-02-22
* [#2851](https://github.com/stripe/stripe-dotnet/pull/2851) Update generated code for beta

## 43.16.0-beta.1 - 2024-02-16
* [#2846](https://github.com/stripe/stripe-dotnet/pull/2846) Update generated code for beta
  * Add support for `DecrementAuthorization` method on resource `PaymentIntent`
  * Add support for `PaytoPayments` and `TwintPayments` on `AccountCapabilitiesOptions` and `AccountCapabilities`
  * Add support for `Payto` on `ChargePaymentMethodDetails`, `ConfirmationTokenPaymentMethodPreview`, `MandatePaymentMethodDetails`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethodUpdateOptions`, `PaymentMethod`, `SetupAttemptPaymentMethodDetails`, `SetupIntentPaymentMethodDataOptions`, `SetupIntentPaymentMethodOptionsOptions`, and `SetupIntentPaymentMethodOptions`
  * Add support for `Twint` on `ChargePaymentMethodDetails`, `ConfirmationTokenPaymentMethodPreview`, `PaymentIntentPaymentMethodDataOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
  * Add support for `DecrementalAuthorization` on `ChargePaymentMethodDetailsCard`
  * Add support for `DisplayBrand` on `ConfirmationTokenPaymentMethodPreviewCard`
  * Add support for `RequestDecrementalAuthorization` on `PaymentIntentPaymentMethodOptionsCardOptions` and `PaymentIntentPaymentMethodOptionsCard`

## 43.15.0-beta.1 - 2024-02-08
* [#2844](https://github.com/stripe/stripe-dotnet/pull/2844) Update generated code for beta
  * Add support for `PaymentMethodOptions` on `ConfirmationToken`

## 43.14.0-beta.1 - 2024-02-01
* [#2841](https://github.com/stripe/stripe-dotnet/pull/2841) Update generated code for beta
  * Add support for new resources `Entitlements.Event` and `Entitlements.Feature`
  * Add support for `Create` method on resource `Event`
  * Add support for `Create` and `List` methods on resource `Feature`
  * Add support for `Swish` on `ConfirmationTokenPaymentMethodPreview`
  * Add support for `AccountTaxIds` on `InvoiceScheduleDetailsPhasesInvoiceSettingsOptions`
  * Add support for `Feature` on `ProductFeaturesOptions` and `ProductFeatures`

## 43.13.0-beta.1 - 2024-01-26
* [#2836](https://github.com/stripe/stripe-dotnet/pull/2836) Update generated code for beta
  * Add support for `CreatePreview` method on resource `Invoice`
  * Add support for `ChargedOffAt` on `CapitalFinancingOffer`
  * Add support for `EnhancedEvidence` on `DisputeEvidenceOptions` and `DisputeEvidence`
  * Add support for `EnhancedEligibilityTypes` on `Dispute`
  * Add support for `EnhancedEligibility` on `DisputeEvidenceDetails`
  * Add support for `PromotionCode` on `InvoiceScheduleDetailsAmendmentsDiscountActionsAddOptions`, `InvoiceScheduleDetailsAmendmentsDiscountActionsRemoveOptions`, `InvoiceScheduleDetailsAmendmentsDiscountActionsSetOptions`, `InvoiceScheduleDetailsAmendmentsItemActionsAddDiscountsOptions`, `InvoiceScheduleDetailsAmendmentsItemActionsSetDiscountsOptions`, `InvoiceScheduleDetailsPhasesAddInvoiceItemsDiscountsOptions`, `InvoiceScheduleDetailsPhasesDiscountsOptions`, `InvoiceScheduleDetailsPhasesItemsDiscountsOptions`, `InvoiceSubscriptionDetailsItemsDiscountsOptions`, `InvoiceSubscriptionItemsDiscountsOptions`, `QuoteLineActionsAddDiscount`, `QuoteLineActionsAddItemDiscounts`, `QuoteLineActionsRemoveDiscount`, `QuoteLineActionsSetDiscounts`, `QuoteLineActionsSetItemsDiscounts`, `QuoteLinesActionsAddItemDiscountsOptions`, `QuoteLinesActionsRemoveDiscountOptions`, `QuoteLinesActionsSetDiscountsOptions`, `QuoteLinesActionsSetItemsDiscountsOptions`, `QuotePhasesDiscountsOptions`, `SubscriptionAddInvoiceItemsDiscountsOptions`, `SubscriptionDiscountsOptions`, `SubscriptionItemDiscountsOptions`, `SubscriptionItemsDiscountsOptions`, `SubscriptionScheduleAmendmentsDiscountActionsAddOptions`, `SubscriptionScheduleAmendmentsDiscountActionsRemoveOptions`, `SubscriptionScheduleAmendmentsDiscountActionsSetOptions`, `SubscriptionScheduleAmendmentsItemActionsAddDiscountsOptions`, `SubscriptionScheduleAmendmentsItemActionsSetDiscountsOptions`, `SubscriptionSchedulePhasesAddInvoiceItemsDiscountsOptions`, `SubscriptionSchedulePhasesAddInvoiceItemsDiscounts`, `SubscriptionSchedulePhasesDiscountsOptions`, `SubscriptionSchedulePhasesDiscounts`, `SubscriptionSchedulePhasesItemsDiscountsOptions`, and `SubscriptionSchedulePhasesItemsDiscounts`

## 43.12.0-beta.1 - 2024-01-18
* [#2830](https://github.com/stripe/stripe-dotnet/pull/2830) Beta: report RawRequest usage
* [#2835](https://github.com/stripe/stripe-dotnet/pull/2835) Update generated code for beta
  Release specs are identical.
* [#2833](https://github.com/stripe/stripe-dotnet/pull/2833) Update generated code for beta

## 43.11.0-beta.1 - 2024-01-12
* [#2828](https://github.com/stripe/stripe-dotnet/pull/2828) Update generated code for beta
  * Add support for `Amount` on `ChargePaymentDetailsFlightSegmentsOptions` and `PaymentIntentPaymentDetailsFlightSegmentsOptions`
  * Add support for `NumberOfRooms` and `RoomClass` on `ChargePaymentDetailsLodgingOptions` and `PaymentIntentPaymentDetailsLodgingOptions`
  * Add support for `BuyButton` on `CustomerSessionComponentsOptions` and `CustomerSessionComponents`

## 43.10.0-beta.1 - 2024-01-04
* [#2821](https://github.com/stripe/stripe-dotnet/pull/2821) Update generated code for beta
  * Updated stable APIs to the latest version

## 43.9.0-beta.1 - 2023-12-22
* [#2815](https://github.com/stripe/stripe-dotnet/pull/2815) Update generated code for beta
  * Add support for `CapitalFinancingPromotion` on `AccountSessionComponentsOptions` and `AccountSessionComponents`
  * Change type of `PaymentLinkSubscriptionDataInvoiceSettings` from `nullable(PaymentLinksResourceSubscriptionDataInvoiceSettings)` to `PaymentLinksResourceSubscriptionDataInvoiceSettings`
  * Add support for `ShipFromDetails` on `Tax.CalculationCreateOptions`, `TaxCalculation`, and `TaxTransaction`

## 43.8.0-beta.1 - 2023-12-14
* [#2810](https://github.com/stripe/stripe-dotnet/pull/2810) Update generated code for beta
  * Add support for `PreviewMode` and `SubscriptionDetails` on `InvoiceUpcomingLinesOptions` and `InvoiceUpcomingOptions`
  * Remove support for `SubscriptionTrialFromPlan` on `InvoiceUpcomingLinesOptions` and `InvoiceUpcomingOptions`
  * Add support for `BillingBehavior`, `EndBehavior`, and `ProrationBehavior` on `InvoiceScheduleDetailsOptions`

## 43.7.0-beta.1 - 2023-12-08
* [#2806](https://github.com/stripe/stripe-dotnet/pull/2806) Update generated code for beta
  * Add support for `Get` method on resource `FinancialConnections.Transaction`
  * Remove support for `IssuingCard` and `IssuingCardsList` on `AccountSessionComponentsOptions`
  * Add support for `PaymentMethodRemove`, `PaymentMethodSave`, and `PaymentMethodSetAsDefault` on `CustomerSessionComponentsPaymentElementFeaturesOptions` and `CustomerSessionComponentsPaymentElementFeatures`
  * Remove support for `PaymentMethodDetach` and `PaymentMethodSetAsCustomerDefault` on `CustomerSessionComponentsPaymentElementFeaturesOptions` and `CustomerSessionComponentsPaymentElementFeatures`

## 43.6.0-beta.1 - 2023-11-30
* [#2802](https://github.com/stripe/stripe-dotnet/pull/2802) Update generated code for beta

## 43.5.0-beta.1 - 2023-11-21
* [#2798](https://github.com/stripe/stripe-dotnet/pull/2798) Update generated code for beta
  * Rename `Receipient` to `Recipient` beneath `PaymentDetails` on `Charge` and `PaymentIntent` APIs.
  * Add support for `Components` on `CustomerSessionCreateOptions` and `CustomerSession`

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

## 43.3.0-beta.1 - 2023-11-10
* [#2792](https://github.com/stripe/stripe-dotnet/pull/2792) Update generated code for beta
  * Add support for `Metadata` on `QuotePhase` and `QuotePhasesOptions`
  * Add support for `LastReestimationDetails` on `QuoteComputed`

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
This release changes the pinned API version to `2023-10-16`.

* [#2782](https://github.com/stripe/stripe-dotnet/pull/2782) Update generated code for beta
  - Update pinned API version to `2023-10-16`

## 42.11.0-beta.1 - 2023-10-16
* [#2779](https://github.com/stripe/stripe-dotnet/pull/2779) Update generated code for beta

## 42.10.0-beta.1 - 2023-10-11
* [#2777](https://github.com/stripe/stripe-dotnet/pull/2777) Update generated code for beta
  * Add support for new resources `AccountNotice` and `Issuing.CreditUnderwritingRecord`
  * Add support for `Get`, `List`, and `Update` methods on resource `AccountNotice`
  * Add support for `Correct`, `CreateFromApplication`, `CreateFromProactiveReview`, `Get`, `List`, and `ReportDecision` methods on resource `CreditUnderwritingRecord`

## 42.9.0-beta.1 - 2023-10-05
* [#2775](https://github.com/stripe/stripe-dotnet/pull/2775) Update generated code for beta
  * Add support for `MarkDraft` and `MarkStale` methods on resource `Quote`
  * Remove support for `DraftQuote` and `MarkStaleQuote` methods on resource `Quote`
  * Add support for `Liability` on `CheckoutSessionAutomaticTaxOptions` and `CheckoutSessionAutomaticTax`
  * Add support for `Issuer` on `CheckoutSessionInvoiceCreationInvoiceDataOptions` and `CheckoutSessionInvoiceCreationInvoiceData`
  * Add support for `InvoiceSettings` on `CheckoutSessionSubscriptionDataOptions`
  * Add support for `PersonalizationDesign` on `Issuing.CardListOptions`
  * Add support for `AllowBackdatedLines` on `QuoteCreateOptions`, `QuoteUpdateOptions`, and `Quote`

## 42.8.0-beta.1 - 2023-09-28
* [#2773](https://github.com/stripe/stripe-dotnet/pull/2773) Update generated code for beta
  * Rename resources `Issuing.CardDesign` and `Issuing.CardBundle` to `Issuing.PersonalizationDesign` and `Issuing.PhysicalBundle`
  * Add support for `Features` on `AccountSessionComponentsAccountOnboardingOptions`, `AccountSessionComponentsPaymentDetailsOptions`, `AccountSessionComponentsPaymentDetails`, `AccountSessionComponentsPaymentsOptions`, `AccountSessionComponentsPayments`, `AccountSessionComponentsPayoutsOptions`, and `AccountSessionComponentsPayouts`
  * Add support for `Reason` on `Event`

## 42.7.0-beta.1 - 2023-09-21
* [#2768](https://github.com/stripe/stripe-dotnet/pull/2768) Update generated code for beta
  * Remove support for `Customer` on `ConfirmationToken`
  * Add support for `Issuer` on `InvoiceCreateOptions`, `InvoiceUpcomingLinesOptions`, `InvoiceUpcomingOptions`, `InvoiceUpdateOptions`, `Invoice`, `QuoteInvoiceSettingsOptions`, `QuoteInvoiceSettings`, `SubscriptionScheduleDefaultSettingsInvoiceSettingsOptions`, `SubscriptionScheduleDefaultSettingsInvoiceSettings`, `SubscriptionSchedulePhasesInvoiceSettingsOptions`, and `SubscriptionSchedulePhasesInvoiceSettings`
  * Add support for `OnBehalfOf` on `InvoiceUpcomingLinesOptions` and `InvoiceUpcomingOptions`
  * Add support for `Liability` on `InvoiceAutomaticTaxOptions`, `InvoiceAutomaticTax`, `QuoteAutomaticTaxOptions`, `QuoteAutomaticTax`, `SubscriptionAutomaticTaxOptions`, `SubscriptionAutomaticTax`, `SubscriptionScheduleDefaultSettingsAutomaticTaxOptions`, `SubscriptionScheduleDefaultSettingsAutomaticTax`, `SubscriptionSchedulePhasesAutomaticTaxOptions`, and `SubscriptionSchedulePhasesAutomaticTax`
  * Change type of `IssuingCardDesignCarrierTextOptions` from `carrier_text_param` to `emptyStringable(carrier_text_param)`
  * Add support for `InvoiceSettings` on `SubscriptionCreateOptions` and `SubscriptionUpdateOptions`
  * Remove `InvoiceLineItemDiscountDiscountEndDurationOptions`, `InvoiceLineItemDiscountDiscountEndOptions`, `InvoiceLineItemInvoiceItemDiscountDiscountEndDurationOptions`, `InvoiceLineItemInvoiceItemDiscountDiscountEndOptions`, `InvoiceLineItemSubscriptionItemDiscountDiscountEndDurationOptions`, `InvoiceLineItemSubscriptionItemDiscountDiscountEndOptions.cs`, `InvoiceLineItemSubscriptionItemDiscountOptions`, `InvoiceLineItemSubscriptionPrebillingOptions`. These are obsolete and not used anywhere.

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

## 42.5.0-beta.1 - 2023-09-07
* [#2749](https://github.com/stripe/stripe-dotnet/pull/2749) Update generated code for beta
  * Add support for new resources `QuotePreviewInvoice` and `QuotePreviewSchedule`
  * Remove support for `AppliesTo` on `Invoice` and `SubscriptionSchedule`
  * Add support for `Cl`, `Co`, `Id`, `Kr`, `Mx`, `My`, `Sa`, `Th`, `Tr`, and `Vn` on `TaxRegistrationCountryOptionsOptions` and `TaxRegistrationCountryOptions`
  * Remove support for `Hk` on `TaxRegistrationCountryOptionsOptions` and `TaxRegistrationCountryOptions`
* [#2759](https://github.com/stripe/stripe-dotnet/pull/2759) Update generated code for beta
  * Rename `QuoteService.ListPreviewInvoices` to `QuotePreviewInvoiceService.List` and `QuoteService.ListPreviewSubscriptionSchedules` to `QuotePreviewScheduleService.List`
  * Add support for `TaxForms` on `AccountSettingsOptions` and `AccountSettings`
  * Add support for `Components` on `AccountSessionCreateOptions` and `AccountSession`
* [#2762](https://github.com/stripe/stripe-dotnet/pull/2762) Update generated code for beta
  * Release specs are identical.
* [#2761](https://github.com/stripe/stripe-dotnet/pull/2761) Update generated code for beta
  * Remove support for `SubmitCard` test helper method on resource `Issuing.Card`
  * Add support for `CardDesign` on `Issuing.CardUpdateOptions`

## 42.4.0-beta.1 - 2023-09-01
* [#2759](https://github.com/stripe/stripe-dotnet/pull/2759) Update generated code for beta
  * Rename `QuoteService.ListPreviewInvoices` to `QuotePreviewInvoiceService.List` and `QuoteService.ListPreviewSubscriptionSchedules` to `QuotePreviewScheduleService.List`
  * Add support for `TaxForms` on `AccountSettingsOptions` and `AccountSettings`
  * Add support for `Components` on `AccountSessionCreateOptions` and `AccountSession`

## 42.0.0-beta.1 - 2023-08-24
This release changes the pinned API version to `2023-08-16`.

* [#2749](https://github.com/stripe/stripe-dotnet/pull/2749) Update generated code for beta
  * Add support for new resources `QuotePreviewInvoice` and `QuotePreviewSchedule`
  * Remove support for `AppliesTo` on `Invoice` and `SubscriptionSchedule`
  * Add support for `Cl`, `Co`, `Id`, `Kr`, `Mx`, `My`, `Sa`, `Th`, `Tr`, and `Vn` on `TaxRegistrationCountryOptionsOptions` and `TaxRegistrationCountryOptions`
  * Remove support for `Hk` on `TaxRegistrationCountryOptionsOptions` and `TaxRegistrationCountryOptions`

## 41.29.0-beta.1 - 2023-08-10
* [#2743](https://github.com/stripe/stripe-dotnet/pull/2743) Update generated code for beta
  * Add support for `Paypal` on `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, and `PaymentMethodConfiguration`

## 41.28.0-beta.1 - 2023-08-03
* [#2739](https://github.com/stripe/stripe-dotnet/pull/2739) Remove developer_message support
* [#2737](https://github.com/stripe/stripe-dotnet/pull/2737) Update generated code for beta
  * Add support for `SubmitCard` test helper method on resource `Issuing.Card`
  * Add support for `AddressValidation` on `IssuingCardShippingOptions` and `IssuingCardShipping`
  * Add support for `Shipping` on `Issuing.CardUpdateOptions`
  * Change type of `OrderDescriptionOptions`, `OrderLineItemsProductDataDescriptionOptions`, `OrderLineItemsProductDataTaxCodeOptions`, `OrderShippingDetailsPhoneOptions`, `PaymentMethodConfigurationApplicationOptions`, and `QuoteSubscriptionDataOverridesDescriptionOptions` from `string` to `emptyStringable(string)`
  * Add support for `Reason` on `QuoteMarkStaleQuoteOptions`
  * Add support for `MarkedStale` on `QuoteStatusDetailsStaleLastReason`

## 41.27.0-beta.1 - 2023-07-27
  * Updated stable APIs to the latest version

## 41.25.0-beta.1 - 2023-07-13
* [#2721](https://github.com/stripe/stripe-dotnet/pull/2721) Update generated code for beta
* [#2727](https://github.com/stripe/stripe-dotnet/pull/2727) Update generated code for beta
  Release specs are identical.
* [#2724](https://github.com/stripe/stripe-dotnet/pull/2724) Update generated code for beta
  * Add support for new resource `PaymentMethodConfiguration`
  * Add support for `Create`, `Get`, `List`, and `Update` methods on resource `PaymentMethodConfiguration`
  * Add support for `PaymentMethodConfiguration` on `PaymentIntentCreateOptions` and `PaymentIntentUpdateOptions`
  * Add support for `PaymentMethodConfigurationDetails` on `PaymentIntent`

## 41.23.0-beta.1 - 2023-06-29
* [#2718](https://github.com/stripe/stripe-dotnet/pull/2718) Update generated code for beta
  * Add support for `Metadata` on `InvoiceSubscriptionDetails`

## 41.22.0-beta.1 - 2023-06-22
* [#2715](https://github.com/stripe/stripe-dotnet/pull/2715) Update generated code for beta
  * Add support for new resource `CustomerSession`
  * Add support for `Create` method on resource `CustomerSession`
  * Change type of `TaxRegistrationCountryOptionsUsTypeOptions` and `TaxRegistrationCountryOptionsUsType` from `literal('state_sales_tax')` to `enum('local_lease_tax'|'state_sales_tax')`

## 41.21.0-beta.2 - 2023-06-15
* [#2711](https://github.com/stripe/stripe-dotnet/pull/2711) Update generated code for beta
* [#2712](https://github.com/stripe/stripe-dotnet/pull/2712) Update generated code for beta
  * Add support for `PaymentDetails` on `ChargeCaptureOptions`, `ChargeUpdateOptions`, `PaymentIntentCaptureOptions`, `PaymentIntentConfirmOptions`, `PaymentIntentCreateOptions`, `PaymentIntentUpdateOptions`, and `PaymentIntent`
  * Add support for `StatementDetails` on `PaymentIntentPaymentMethodOptionsCardOptions` and `PaymentIntentPaymentMethodOptionsCard`

## 41.21.0-beta.1 - 2023-06-08
* [#2704](https://github.com/stripe/stripe-dotnet/pull/2704) Update generated code for beta
  * Updated stable APIs to the latest version

## 41.20.0-beta.1 - 2023-06-01
* [#2698](https://github.com/stripe/stripe-dotnet/pull/2698) Update generated code for beta
* [#2702](https://github.com/stripe/stripe-dotnet/pull/2702) Update generated code for beta
  * Add support for `SubscriptionDetails` on `Invoice`
  * Add support for `SetPauseCollection` on `QuoteLine`, `QuoteLinesOptions`, and `SubscriptionScheduleAmendmentsOptions`
  * Add support for `PauseCollection` on `SubscriptionSchedulePhasesOptions` and `SubscriptionSchedulePhases`
  * Add support for `LocalAmusementTax` on `TaxRegistrationCountryOptionsUsOptions` and `TaxRegistrationCountryOptionsUs`
  * Remove support for `Locations` on `TaxSettingsUpdateOptions` and `TaxSettings`

## 41.19.0-beta.1 - 2023-05-25
* [#2700](https://github.com/stripe/stripe-dotnet/pull/2700) Handle developer_message in preview error responses

## 41.18.0-beta.1 - 2023-05-19
* [#2690](https://github.com/stripe/stripe-dotnet/pull/2690) StripeClient.RawRequest
* [#2697](https://github.com/stripe/stripe-dotnet/pull/2697) Update generated code for beta
  * Add support for `Subscribe` and `Unsubscribe` methods on resource `FinancialConnections.Account`
  * Add support for `NextRefreshAvailableAt` on `FinancialConnectionsAccountBalanceRefresh`, `FinancialConnectionsAccountInferredBalancesRefresh`, `FinancialConnectionsAccountOwnershipRefresh`, and `FinancialConnectionsAccountTransactionRefresh`
  * Add support for `StatusDetails` and `Status` on `TaxSettings`

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

## 41.16.0-beta.1 - 2023-05-04
* [#2686](https://github.com/stripe/stripe-dotnet/pull/2686) Update generated code for beta
  * Updated stable APIs to the latest version

## 41.15.0-beta.1 - 2023-04-27
* [#2683](https://github.com/stripe/stripe-dotnet/pull/2683) Update generated code for beta
  * Add support for `BillingCycleAnchor` and `ProrationBehavior` on `CheckoutSessionSubscriptionDataOptions`
  * Add support for `TerminalId` on `IssuingAuthorizationMerchantData` and `IssuingTransactionMerchantData`
  * Add support for `Metadata` on `PaymentIntentCaptureOptions`
  * Add support for `Checks` on `SetupAttemptPaymentMethodDetailsCard`
  * Add support for `TaxBreakdown` on `TaxCalculationShippingCost` and `TaxTransactionShippingCost`
  * Change type of `TaxRegistrationActiveFromOptions` and `TaxRegistrationExpiresAtOptions` from `longInteger` to `longInteger | literal('now')`

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

## 41.13.0-beta.1 - 2023-03-30
* [#2670](https://github.com/stripe/stripe-dotnet/pull/2670) Update generated code for beta

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

## 41.11.0-beta.1 - 2023-03-16
* [#2658](https://github.com/stripe/stripe-dotnet/pull/2658) API Updates
  * Add support for `CreateFromCalculation` method on resource `Tax.Transaction`
  * Add support for `Paypal` on `MandatePaymentMethodDetails`, `SetupAttemptPaymentMethodDetails`, `SetupIntentPaymentMethodOptionsOptions`, and `SetupIntentPaymentMethodOptions`
  * Add support for `SetupFutureUsage` on `OrderPaymentSettingsPaymentMethodOptionsPaypalOptions`, `OrderPaymentSettingsPaymentMethodOptionsPaypal`, `PaymentIntentPaymentMethodOptionsPaypalOptions`, and `PaymentIntentPaymentMethodOptionsPaypal`
  * Remove support for `AppliesTo` on `QuotePreviewInvoiceLinesOptions`
  * Add support for `ShippingCost` on `TaxCalculationCreateOptions`, `TaxCalculation`, `TaxTransactionCreateReversalOptions`, and `TaxTransaction`
  * Add support for `TaxBreakdown` on `TaxCalculation`
  * Remove support for `TaxSummary` on `TaxCalculation`

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

## 41.9.0-beta.1 - 2023-03-02
* [#2653](https://github.com/stripe/stripe-dotnet/pull/2653) API Updates for beta branch
  * Updated stable APIs to the latest version
  * Add support for new resources `Issuing.CardBundle` and `Issuing.CardDesign`
  * Add support for `Get` and `List` methods on resource `CardBundle`
  * Add support for `Get`, `List`, and `Update` methods on resource `CardDesign`
  * Remove support for `Controller` on `AccountUpdateOptions`
  * Add support for `CardDesign` on `IssuingCardCreateOptions` and `IssuingCard`

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

## 41.4.0-beta.1 - 2022-12-22
* [#2627](https://github.com/stripe/stripe-dotnet/pull/2627) API Updates for beta branch
  * Updated stable APIs to the latest version
  * Move `Stripe.TaxTransaction` and `Stripe.TaxCalculation` to `Stripe.Tax.Transaction` and `Stripe.Tax.Calculation`.

## 41.3.0-beta.2 - 2022-12-15
* [#2621](https://github.com/stripe/stripe-dotnet/pull/2621) API Updates for beta branch
  * Updated stable APIs to the latest version
  * Add support for new resources `QuoteLine`, `TaxCalculation`, and `TaxTransaction`
  * Add support for `Create` and `ListLineItems` methods on resource `TaxCalculation`
  * Add support for `CreateReversal`, `Create`, and `Get` methods on resource `TaxTransaction`

## 41.3.0-beta.1 - 2022-12-08
This release changes the pinned API version to `2022-11-15`.

* [#2618](https://github.com/stripe/stripe-dotnet/pull/2618) API Updates for beta branch
  * Updated stable APIs to the latest version
* [#2615](https://github.com/stripe/stripe-dotnet/pull/2615) API Updates for beta branch
  * Updated stable APIs to the latest version

## 40.17.0-beta.1 - 2022-11-10
* [#2606](https://github.com/stripe/stripe-dotnet/pull/2606) API Updates for beta branch
  * Updated stable APIs to the latest version
  * Add support for `Url` on `AuthorizationMerchantData`.
  * Add support for  `DiscountEnd` on `*DiscountOptions`.

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

## 40.14.0-beta.1 - 2022-10-14
* [#2590](https://github.com/stripe/stripe-dotnet/pull/2590) API Updates for beta branch
  * Updated stable APIs to the latest version
  * Add support for `ScheduleSettings` on `SubscriptionScheduleAmendOptions`

## 40.13.0-beta.1 - 2022-10-07
* [#2585](https://github.com/stripe/stripe-dotnet/pull/2585) API Updates for beta branch
  * Updated stable APIs to the latest version

## 40.12.0-beta.2 - 2022-10-04
* Updated stable APIs to the latest version

## 40.12.0-beta.1 - 2022-10-04
* [#2583](https://github.com/stripe/stripe-dotnet/pull/2583) API Updates for beta branch
  * Updated stable APIs to the latest version
  * Added `ReferenceId` to `PaymentIntentPaymentMethodOptionsPaypalOptions`

## 40.11.0-beta.1 - 2022-09-26
* [#2579](https://github.com/stripe/stripe-dotnet/pull/2579) API Updates for beta branch
  * Updated stable APIs to the latest version
  * Add `FinancingOffer`, `FinancingSummary` and `FinancingTransaction` resources.

## 40.5.0-beta.1 - 2022-08-26
* [#2566](https://github.com/stripe/stripe-dotnet/pull/2566) API Updates for beta branch
  * Updated stable APIs to the latest version
  * Add support for the beta [Gift Card API](https://stripe.com/docs/gift-cards).

## 40.4.0-beta.1 - 2022-08-23
* [#2561](https://github.com/stripe/stripe-dotnet/pull/2561) Make APIVersion configuration settable
* [#2563](https://github.com/stripe/stripe-dotnet/pull/2563) API Updates for beta branch
  - Updated stable APIs to the latest version
  - `Stripe-Version` beta headers are not pinned by-default and need to be manually specified, please refer to [beta SDKs README section](https://github.com/stripe/stripe-dotnet/blob/master/README.md#beta-sdks)

## 40.3.0-beta.1 - 2022-08-11
* [#2557](https://github.com/stripe/stripe-dotnet/pull/2557) API Updates for beta branch
  - Updated stable APIs to the latest version
  - Add RefundPayment method to Terminal resource

## 40.1.0-beta.1 - 2022-08-03
* [#2550](https://github.com/stripe/stripe-dotnet/pull/2550) API Updates for beta branch
  - Updated stable APIs to the latest version
  - Added the `Order` resource support

## 39.125.0-beta.1 - 2022-07-22
* [#2536](https://github.com/stripe/stripe-dotnet/pull/2536) API Updates for beta branch
  - Updated stable APIs to the latest version
  - Add `Price.MigrateTo` property
  - Add `SubscriptionSchedule.Amend` method.
  - Add `Discount.SubscriptionItem` property.
  - Add `Quote.SubscriptionData.BillingBehavior`, `BillingCycleAnchor`, `EndBehavior`, `FromSchedule`, `FromSubscription`, `Prebilling`, `ProrationBehavior` properties.
  - Add `Phases` parameter to `Quote.Create`
  - Add `Subscription.Discounts`, `Prebilling` properties.
* [#2540](https://github.com/stripe/stripe-dotnet/pull/2540) API Updates for beta branch
  - Updated stable APIs to the latest version
  - Add `QuotePhase` resource
* [#2542](https://github.com/stripe/stripe-dotnet/pull/2542) API Updates for beta branch
  - Updated stable APIs to the latest version

## 39.123.0-beta.1 - 2022-07-07
* [#2525](https://github.com/stripe/stripe-dotnet/pull/2525) API Updates for beta branch
  - Updated stable APIs to the latest version
* [#2529](https://github.com/stripe/stripe-dotnet/pull/2529) API Updates for beta branch
  - Include `server_side_confirmation_beta=v1` beta
  - Add `secretKeyConfirmation` to `PaymentIntent`

## 39.119.0-beta.1 - 2022-06-15
* [#2505](https://github.com/stripe/stripe-dotnet/pull/2505) API Updates
  Add support for NetworkDetails properties on ReceivedCredits/ReceivedDebits resources
