---
title: Update generated code for beta
pr_link: https://github.com/stripe/stripe-dotnet/pull/3406
is_breaking: true
is_stripe_api_change: true
released_in_version: 52.3.0-beta.1
---

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
