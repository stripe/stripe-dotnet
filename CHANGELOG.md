# Changelog

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
* [#2205](https://github.com/stripe/stripe-dotnet/pull/2205) Add support for `CheckoutSession` on `Discount`

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


## 38.0.0  and 39.0.0 - 2020-08-27

We experienced multiple errors during the release of 38.0.0 and 39.0.0 that could not be reverted. The next major version after 37.X is the version 39.1.2 above.

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
* [#2077](https://github.com/stripe/stripe-dotnet/pull/2077) Add support for `IssuingDisputeFundsReinstated` event type.

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
* [#1780](https://github.com/stripe/stripe-dotnet/pull/1780) Bump API version to [`2019-09-09`](https://stripe.com/docs/upgrades#2019-09-09)

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
* [#1747](https://github.com/stripe/stripe-dotnet/pull/1747) Move to API version [`2019-08-14`](https://stripe.com/docs/upgrades#2019-08-14)
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
* [#1552](https://github.com/stripe/stripe-dotnet/pull/1552) Add support for API version [2019-03-14](https://stripe.com/docs/upgrades#2019-03-14):
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
* [#1259](https://github.com/stripe/stripe-dotnet/pull/1259) Upgrade to API version [2018-08-23](https://stripe.com/docs/upgrades#2018-08-23)

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

## Older releases

Note that this changelog is relatively new and we haven't yet backfilled it.
For details on old releases, check out the releases page:

https://github.com/stripe/stripe-dotnet/releases

<!--
# vim: set tw=0:
-->
