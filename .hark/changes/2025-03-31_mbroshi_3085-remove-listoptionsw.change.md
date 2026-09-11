---
title: "and [#3085](https://github.com/stripe/stripe-dotnet/pull/3085) Remove `ListOptionsWithCreated` and clean up services that incorrectly extend `ListOptions`"
pr_link: https://github.com/stripe/stripe-dotnet/pull/3078
released_in_version: 48.0.0
---

* Remove `ListOptionsWithCreated` base class. The classes that use to extend it now extend `ListOptions` and have the the `created` field defined explicitly.
* Classes`ReportTypeService` and `AccountCapabilityService` no longer implement the `IListable` interface, and the `ListAutoPaging` and `ListAutoPagingAsync` methods are removed. This is because the list APIs here are not pageable. See #2227 for more details.
   * As a consequence, the classes `ReportTypeOptions` and `AccountCapabilityOptions` no longer extend `ListOptions` as well
