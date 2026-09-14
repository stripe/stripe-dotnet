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
