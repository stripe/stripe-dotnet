# V20 Migration Guide

Version 20 of stripe-dotnet contains some very sizable breaking changes.

The major reason that we moved forward on them was to clean up the abstraction
around properties or endpoints that can return more than one resource. Before,
we had a class that pointed to each potential sub-resource along with a `Type`
property to indicate which one was filled. We wanted to replace this with an
interface to make it easier to integrate and match the API more closely.

Because this is a large change, we also took the opportunity to do some
housekeeping throughout the library. Most of this involves renaming fields and
some resources to be more accurate according to how they're named in Stripe's
REST API, but it also involves some smaller changes like moving some types and
constants around.

Please see the list below for the complete set of changes.

* Most classes have been renamed to remove the `Stripe` prefix. For example:
    * `StripeCharge` is now `Charge`.
    * `StripeRefundService` is now `RefundService`.
* All `Delete` methods now return an instance of the resource with `Deleted` set
to `true`. We have also removed the `StripeDeleted` class.
* All parameters are now marked as nullable by default.
* Added interfaces to handle endpoints that can return different resources. For
  example:
    * `IPaymentSource` represents all resources that can be used to create a
      Charge. This can be a `Card`, `BankAccount`, `Source` or `Account`.
    * `IBalanceTransactionSource` represents all resources that can be the
      source of a Balance Transaction such as `Charge` or `Refund`.
* `StripeSource` is now named `Source` as the other `Source` class was removed
  in favour of `IPaymentSource`. We have also added support for all existing
  source types and related properties or parameters.
* Some fields or parameters have been renamed so that they're more consistent
  with their name in Stripe's REST API or the rest of the library. For example:
    * `DateFilter` on List APIs becomes `DateRangeOptions`.
    * `LiveMode` becomes `Livemode`.
    * `BirthDay` becomes `Dob`.
    * `LegalEntityVerification` becomes `Verification`.
* Most classes used as parameters for API methods with nested parameters have
  been modified to reflect the structure in Stripe's REST API. For example 
  `PersonalAddressLine1` on `StripeAccountLegalEntityOptions` has now been 
  renamed to `Line1` on `AddressOptions` which is itself under `PersonalAddress`
  on `AccountLegalEntityOptions`.
* We now have a dedicated service and related classes for the Invoice Item
  resource instead of using the ones for the Invoice Line Item resource.
* Methods for `UsageRecordService` now take a subscription item id as the first
  parameter.
* Some fields or parameters have been renamed so that they're more consistent
  with their name in Stripe's REST API or the rest of the library. For example:
    * `DateFilter` on List APIs becomes `DateRangeOptions`.
    * `LiveMode` becomes `Livemode`.
    * `CityOrTown` becomes `City`.
* Moved to API version [2018-09-24](https://stripe.com/docs/upgrades#2018-09-24)
  leading to the following changes:
    * Removal of `StripeFileUpload` in favour of `File`.
    * The `TransactionId` parameter on the Issuing Create Dispute API is now
      called `DisputedTransactionId`.
* All integer values now use `long` as their type instead of `int`.

As usual, if you find bugs, please [open them on the repository][issues], or
reach out to [our support team][support_team] if you have any other questions.

[issues]: https://github.com/stripe/stripe-dotnet/issues/new
[support_team]: https://support.stripe.com/email
