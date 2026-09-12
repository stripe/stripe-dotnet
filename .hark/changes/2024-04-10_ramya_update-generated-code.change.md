---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/2884
released_in_version: 44.0.0
---

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
