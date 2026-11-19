---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/3497
semver_level: major
is_stripe_api_change: true
released_in_version: 53.3.0-alpha.1
---

* Add support for new resources `V2.Billing.GroupInvoice`, `V2.Billing.GroupSpendModifier`, and `V2.Billing.Group`
* ⚠️ Remove support for resources `V2.Billing.CadenceSpendModifier` and `V2.Billing.ContractPricingLineQuantityChange`
* Add support for `Create` and `Update` methods on resource `InvoiceRenderingTemplate`
* Add support for `Cancel`, `Create`, `Get`, `List`, and `Update` methods on resource `V2.Billing.Group`
* Add support for `Get` method on resource `V2.Billing.GroupSpendModifier`
* Add support for `Create` method on resource `V2.Billing.GroupInvoice`
* ⚠️ Remove support for `Get` method on resource `V2.Billing.CadenceSpendModifier`
* ⚠️ Remove support for `BillingCadence` on `Billing.Alert.SpendThreshold.Filters`, `Billing.AlertTriggered.GroupBy`, `BillingAlertSpendThresholdFiltersOptions`, `InvoiceCreatePreviewOptions`, `InvoiceListOptions`, `SubscriptionCreateOptions`, `SubscriptionListOptions`, `SubscriptionUpdateOptions`, `Subscription`, `V2.Billing.PricingPlanSubscriptionListOptions`, `V2.Billing.PricingPlanSubscription`, `V2.Billing.RateCardSubscriptionCreateOptions`, `V2.Billing.RateCardSubscriptionListOptions`, and `V2.Billing.RateCardSubscription`
* Add support for `ScheduledFee` on `V2.Billing.ContractTerm`, `V2BillingContractActionAddTermOptions`, `V2BillingContractActionUpdateTermOptions`, and `V2BillingContractTermOptions`
* ⚠️ Remove support for `AdHocProduct` on `V2.Billing.ContractTerm`, `V2BillingContractActionAddTermOptions`, `V2BillingContractActionUpdateTermOptions`, and `V2BillingContractTermOptions`
* ⚠️ Remove support for `Cadence` on `Billing.AlertNotification`, `Billing.BillingAlertAlertNotificationListOptions`, `V2.Billing.IntentCreateOptions`, and `V2.Billing.Intent`
* ⚠️ Remove support for `PricingToken` on `Checkout.SessionCreateOptions`
* Add support for `PassThroughFeeCost` on `Checkout.Session`
* Add support for `AmountPassThroughFee` on `Checkout.Session.TotalDetails`
* Add support for `LinkSharedData` on `Identity.VerificationSessionCreateOptions`
* Add support for `LineItemPolicy`, `RenderingSettings`, and `SummaryItemPolicies` on `InvoiceRenderingTemplate`
* Add support for `BillingGroup` on `InvoiceCreatePreviewOptions`, `InvoiceListOptions`, `V2.Billing.IntentCreateOptions`, `V2.Billing.Intent`, `V2.Billing.PricingPlanSubscriptionListOptions`, `V2.Billing.PricingPlanSubscription`, `V2.Billing.RateCardSubscriptionListOptions`, and `V2.Billing.RateCardSubscription`
* Add support for `AppliedCreditMemos` on `Invoice` and `QuotePreviewInvoice`
* Add support for `BillingGroupDetails` on `Invoice.Parent` and `QuotePreviewInvoice.Parent`
* ⚠️ Remove support for `BillingCadenceDetails` on `Invoice.Parent` and `QuotePreviewInvoice.Parent`
* Add support for `TokenServiceProviderId` on `Issuing.Authorization.TokenDetails.NetworkData.Visa` and `Issuing.Token.NetworkData.Visa`
* Add support for `AmountType`, `Amount`, `Currency`, `Description`, `EndDate`, `IntervalCount`, `Interval`, `Reference`, and `StartDate` on `Mandate.PaymentMethodDetails.Card.India`
* Add support for `ThreeDSecure` on `PaymentAttemptRecordPaymentMethodDetailsCardOptions` and `PaymentRecordPaymentMethodDetailsCardOptions`
* Add support for `ProviderSignatureData` and `ProviderSignature` on `PaymentIntent.PaymentMethodOptions.CardPresent.AadeData` and `PaymentIntentPaymentMethodOptionsCardPresentAadeDataOptions`
* ⚠️ Remove support for `MarkData` and `SignedMark` on `PaymentIntent.PaymentMethodOptions.CardPresent.AadeData` and `PaymentIntentPaymentMethodOptionsCardPresentAadeDataOptions`
* Add support for `RequestMulticapture` on `PaymentIntent.PaymentMethodOptions.Vipps` and `PaymentIntentPaymentMethodOptionsVippsOptions`
* Add support for `IsFreeTrialTransaction` on `PaymentIntentRadarOptionsOptions`
* Add support for `RadarOptions` on `PaymentIntent`
* Add support for `AeonPay`, `AuPay`, `Dbarai`, and `Merpay` on `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, and `PaymentMethodConfiguration`
* Add support for `RequestedSignals` on `Radar.PaymentEvaluationCreateOptions` and `Radar.PaymentEvaluation`
* Add support for `GiftCard` on `Refund.DestinationDetails`
* Add support for `DaysAfterFulfillment` on `Reserve.Plan.RollingRelease`
* Add support for `Rendering` on `SubscriptionScheduleDefaultSettingsInvoiceSettingsOptions`
* Add support for `DebitBehavior` on `Subscription.PaymentSettings.PaymentMethodOptions.Card`, `Subscription.PaymentSettings.PaymentMethodOptions.Pix`, `Subscription.PaymentSettings.PaymentMethodOptions.Upi`, `SubscriptionPaymentSettingsPaymentMethodOptionsCardOptions`, `SubscriptionPaymentSettingsPaymentMethodOptionsPixOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptionsUpiOptions`
* Add support for `PresentmentDetails` on `Subscription.PendingUpdate`
* ⚠️ Remove support for `DeviceHealthDetails` and `DeviceHealth` on `Terminal.Reader`
* Add support for `BillingGroupData` on `V2.Billing.IntentCreateOptions` and `V2.Billing.Intent`
* ⚠️ Remove support for `CadenceData` on `V2.Billing.IntentCreateOptions` and `V2.Billing.Intent`
* Add support for `TouchNGoPayments`, `TruemoneyPayments`, `WechatPayMobileWebPayments`, `WechatPayPayments`, and `WeroPayments` on `V2.Core.Account.Configuration.Merchant.Capabilities` and `V2CoreAccountConfigurationMerchantCapabilitiesOptions`
* Add support for `BusinessDemandDepositAccountFifthThirdStorage` on `V2.Core.Account.Configuration.MoneyManager.Capabilities` and `V2CoreAccountConfigurationMoneyManagerCapabilitiesOptions`
* Add support for `Tips` on `V2.Core.Account.Configuration.Recipient.Capabilities.BankAccounts` and `V2CoreAccountConfigurationRecipientCapabilitiesBankAccountsOptions`
* Add support for `BusinessDemandDepositAccountFifthThird` on `V2.Core.Account.Identity.Attestations.TermsOfService` and `V2CoreAccountIdentityAttestationsTermsOfServiceOptions`
* Add support for `Channel` on `V2.Core.ClaimableSandboxCreateOptions` and `V2.Core.ClaimableSandbox`
* ⚠️ Remove support for `AppChannel` on `V2.Core.ClaimableSandboxCreateOptions` and `V2.Core.ClaimableSandbox`
* Add support for `ReturnUrl` on `V2.Core.ClaimableSandbox.OnboardingLinkDetails` and `V2CoreClaimableSandboxOnboardingLinkDetailsOptions`
* ⚠️ Change type of `V2.Core.ClaimableSandbox.SandboxDetails.ApiKeys.Mcp` from `string` to `an object`
* ⚠️ Change type of `V2.Core.ClaimableSandbox.SandboxDetails.ApiKeys.Publishable` from `string` to `an object`
* ⚠️ Change type of `V2.Core.ClaimableSandbox.SandboxDetails.ApiKeys.Secret` from `string` to `an object`
* Add support for `CustomPaymentMethodAdapterDegraded` on `V2.Core.Health.AlertHistoryEntry` and `V2.Core.Health.Alert`
* Add support for `FundsHoldingStructure` on `V2.MoneyManagement.FinancialAccount.Storage` and `V2MoneyManagementFinancialAccountStorageOptions`
* Add support for `AuBecsDebit` on `V2.MoneyManagement.InboundTransfer.From.PaymentMethod`
* Add support for `Network` on `V2.MoneyManagement.ReceivedDebit.BankTransfer`
* Add support for `SettlementTiming` on `V2.MoneyManagement.FundingIntentUpdateOptions`
* Add support for `Include` on `V2.Core.ClaimableSandboxGetOptions`
* ⚠️ Add support for `BillingGroup` on `V2.Billing.RateCardSubscriptionCreateOptions`
* ⚠️ Remove support for `OneTimeFees`, `PricingLines`, and `PricingOverrides` on `V2.Billing.ContractCreateOptions`
* Add support for `ContractNumber` on `V2.Billing.ContractUpdateOptions`
* ⚠️ Remove support for `OneTimeFeeActions`, `PricingLineActions`, and `PricingOverrideActions` on `V2.Billing.ContractUpdateOptions`
* ⚠️ Remove support for `CancelPricingLines` on `V2.Billing.ContractCancelOptions`
* Add support for `Charge` on `EventsV2PaymentsOffSessionPaymentAttemptFailedEvent`, `EventsV2PaymentsOffSessionPaymentFailedEvent`, and `EventsV2PaymentsOffSessionPaymentSucceededEvent`
* Add support for `LastAttemptError` on `EventsV2PaymentsOffSessionPaymentAttemptFailedEvent` and `EventsV2PaymentsOffSessionPaymentFailedEvent`
* Add support for `PaymentAttemptRecord` on `EventsV2PaymentsOffSessionPaymentSucceededEvent`
* Add support for event notifications `V2BillingContractTermPricingOverrideEndedEvent`, `V2BillingContractTermPricingOverrideStartedEvent`, `V2BillingContractTermRecurringPriceEndedEvent`, `V2BillingContractTermRecurringPriceStartedEvent`, `V2BillingContractTermScheduledFeeServicePeriodEndedEvent`, and `V2BillingContractTermScheduledFeeServicePeriodStartedEvent` with related object `V2.Billing.ContractTerm`
* Add support for event notifications `V2CoreHealthCustomPaymentMethodAdapterDegradedFiringEvent` and `V2CoreHealthCustomPaymentMethodAdapterDegradedResolvedEvent`
* Add support for event notifications `V2SignalsPaymentRetryEvaluationCanceledEvent`, `V2SignalsPaymentRetryEvaluationCompletedEvent`, `V2SignalsPaymentRetryEvaluationCreatedEvent`, `V2SignalsPaymentRetryEvaluationExpiredEvent`, and `V2SignalsPaymentRetryEvaluationUpdatedEvent` with related object `V2.Signals.PaymentRetryEvaluation`
* ⚠️ Remove support for event notifications `V2BillingCadenceBilledEvent`, `V2BillingCadenceCanceledEvent`, and `V2BillingCadenceCreatedEvent` with related object `V2.Billing.Cadence`
* ⚠️ Add error type `RateLimitException` on `V2.Core.ClaimableSandbox#Create`
