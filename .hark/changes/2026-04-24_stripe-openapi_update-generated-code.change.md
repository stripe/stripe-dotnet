---
title: Update generated code for beta
pr_url: https://github.com/stripe/stripe-dotnet/pull/3374
is_breaking: true
is_stripe_api_change: true
released_in_version: 51.2.0-beta.2
---

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
