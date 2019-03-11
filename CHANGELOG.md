# Changelog

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
