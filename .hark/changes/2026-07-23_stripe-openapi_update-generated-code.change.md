---
title: Update generated code for private-preview
pr_url: https://github.com/stripe/stripe-dotnet/pull/3414
is_breaking: true
is_stripe_api_change: true
released_in_version: 52.2.0-alpha.5
---

* Add support for new resources `Billing.AlertNotification` and `Crypto.DepositAddress`
* Add support for `Create`, `Get`, and `List` methods on resource `Crypto.DepositAddress`
* Add support for `List` method on resource `Billing.AlertNotification`
* Add support for `Vipps` on `ConfirmationToken.PaymentMethodPreview`, `ConfirmationTokenPaymentMethodDataOptions`, `PaymentIntent.PaymentMethodOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, `PaymentMethodCreateOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `Sui` on `Crypto.OnrampSession.TransactionDetails.WalletAddresses`
* Add support for `UseStripeSdk` on `DelegatedCheckout.RequestedSessionConfirmOptions`
* Add support for `EvCharging` on `PaymentIntentAmountDetailsLineItem.PaymentMethodOptions.Card` and `PaymentIntentAmountDetailsLineItemsPaymentMethodOptionsCardOptions`
* Add support for `TaxItems` on `PaymentIntent.PaymentDetails.CarRentalDatum.Total.Tax`, `PaymentIntent.PaymentDetails.FlightDatum.Total.Tax`, and `PaymentIntent.PaymentDetails.LodgingDatum.Total.Tax`
* ⚠️ Remove support for `Taxes` on `PaymentIntent.PaymentDetails.CarRentalDatum.Total.Tax`, `PaymentIntent.PaymentDetails.FlightDatum.Total.Tax`, and `PaymentIntent.PaymentDetails.LodgingDatum.Total.Tax`
* Add support for `Card` on `RadarPaymentEvaluationPaymentDetailsPaymentMethodDetailsOptions`
* ⚠️ Remove support for `AcssDebit`, `AfterpayClearpay`, `Alipay`, `Alma`, `AmazonPay`, `AuBecsDebit`, `BacsDebit`, `Bancontact`, `Billie`, `Bizum`, `Blik`, `Boleto`, `CardPresent`, `Cashapp`, `Crypto`, `CustomerBalance`, `Eps`, `Fpx`, `GiftCard`, `Giropay`, `Gopay`, `Grabpay`, `IdBankTransfer`, `Ideal`, `InteracPresent`, `KakaoPay`, `Konbini`, `KrCard`, `MbWay`, `Mobilepay`, `Multibanco`, `NaverPay`, `NzBankAccount`, `Oxxo`, `P24`, `PayByBank`, `Payco`, `Paynow`, `Paypal`, `Paypay`, `Payto`, `Pix`, `Promptpay`, `Qris`, `Rechnung`, `RevolutPay`, `SamsungPay`, `Satispay`, `Scalapay`, `SepaDebit`, `Shopeepay`, `Sofort`, `StripeBalance`, `Sunbit`, `Swish`, `Tamara`, `Twint`, `Upi`, `UsBankAccount`, `WechatPay`, and `Zip` on `SharedPayment.GrantedToken.PaymentMethodDetails`
* Add support for `SpendCard` on `V2.Core.Account.Configuration.CardCreator.Capabilities.Commercial.Stripe` and `V2CoreAccountConfigurationCardCreatorCapabilitiesCommercialStripeOptions`
