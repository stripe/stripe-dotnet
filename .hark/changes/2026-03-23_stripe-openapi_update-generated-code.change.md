---
title: Update generated code for beta
pr_url: https://github.com/stripe/stripe-dotnet/pull/3337
is_breaking: true
is_stripe_api_change: true
released_in_version: 51.1.0-beta.1
---

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
