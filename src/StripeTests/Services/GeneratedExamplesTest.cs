// File generated from our OpenAPI spec
namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Stripe;
    using Xunit;

    public class GeneratedExamplesTest : BaseStripeTest
    {
        public GeneratedExamplesTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void TestAccountLinkServiceCreate()
        {
            var options = new AccountLinkCreateOptions
            {
                Account = "acct_xxxxxxxxxxxxx",
                RefreshUrl = "https://example.com/reauth",
                ReturnUrl = "https://example.com/return",
                Type = "account_onboarding",
            };
            var service = new AccountLinkService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestAccountServiceCreate()
        {
            var options = new AccountCreateOptions
            {
                Type = "custom",
                Country = "US",
                Email = "jenny.rosen@example.com",
                Capabilities = new AccountCapabilitiesOptions
                {
                    CardPayments = new AccountCapabilitiesCardPaymentsOptions
                    {
                        Requested = true,
                    },
                    Transfers = new AccountCapabilitiesTransfersOptions
                    {
                        Requested = true,
                    },
                },
            };
            var service = new AccountService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestAccountServiceDelete()
        {
            var service = new AccountService(this.StripeClient);
            service.Delete("acct_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestAccountServiceList()
        {
            var options = new AccountListOptions { Limit = 3 };
            var service = new AccountService(this.StripeClient);
            StripeList<Account> accounts = service.List(options);
        }

        [Fact]
        public void TestAccountServiceReject()
        {
            var options = new AccountRejectOptions { Reason = "fraud" };
            var service = new AccountService(this.StripeClient);
            service.Reject("acct_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestAccountServiceRetrieve()
        {
            var service = new AccountService(this.StripeClient);
            service.Get("acct_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestAccountServiceUpdate()
        {
            var options = new AccountUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new AccountService(this.StripeClient);
            service.Update("acct_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestApplicationFeeRefundServiceCreate()
        {
            var service = new ApplicationFeeRefundService(this.StripeClient);
            service.Create("fee_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestApplicationFeeRefundServiceList()
        {
            var options = new ApplicationFeeRefundListOptions { Limit = 3 };
            var service = new ApplicationFeeRefundService(this.StripeClient);
            StripeList<ApplicationFeeRefund> applicationfeerefunds = service.List(
                "fee_xxxxxxxxxxxxx",
                options);
        }

        [Fact]
        public void TestApplicationFeeRefundServiceRetrieve()
        {
            var service = new ApplicationFeeRefundService(this.StripeClient);
            service.Get("fee_xxxxxxxxxxxxx", "fr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestApplicationFeeRefundServiceUpdate()
        {
            var options = new ApplicationFeeRefundUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new ApplicationFeeRefundService(this.StripeClient);
            service.Update("fee_xxxxxxxxxxxxx", "fr_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestApplicationFeeServiceList()
        {
            var options = new ApplicationFeeListOptions { Limit = 3 };
            var service = new ApplicationFeeService(this.StripeClient);
            StripeList<ApplicationFee> applicationfees = service.List(options);
        }

        [Fact]
        public void TestApplicationFeeServiceRetrieve()
        {
            var service = new ApplicationFeeService(this.StripeClient);
            service.Get("fee_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestAppsSecretServiceCreate()
        {
            var options = new Stripe.Apps.SecretCreateOptions
            {
                Name = "sec_123",
                Payload = "very secret string",
                Scope = new Stripe.Apps.SecretScopeOptions { Type = "account" },
            };
            var service = new Stripe.Apps.SecretService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestAppsSecretServiceCreate2()
        {
            var options = new Stripe.Apps.SecretCreateOptions
            {
                Name = "my-api-key",
                Payload = "secret_key_xxxxxx",
                Scope = new Stripe.Apps.SecretScopeOptions { Type = "account" },
            };
            var service = new Stripe.Apps.SecretService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestAppsSecretServiceDeleteWhere()
        {
            var options = new Stripe.Apps.SecretDeleteWhereOptions
            {
                Name = "my-api-key",
                Scope = new Stripe.Apps.SecretScopeOptions { Type = "account" },
            };
            var service = new Stripe.Apps.SecretService(this.StripeClient);
            service.DeleteWhere(options);
        }

        [Fact]
        public void TestAppsSecretServiceFind()
        {
            var options = new Stripe.Apps.SecretFindOptions
            {
                Name = "sec_123",
                Scope = new Stripe.Apps.SecretScopeOptions { Type = "account" },
            };
            var service = new Stripe.Apps.SecretService(this.StripeClient);
            service.Find(options);
        }

        [Fact]
        public void TestAppsSecretServiceList()
        {
            var options = new Stripe.Apps.SecretListOptions
            {
                Scope = new Stripe.Apps.SecretScopeOptions { Type = "account" },
                Limit = 2,
            };
            var service = new Stripe.Apps.SecretService(this.StripeClient);
            StripeList<Stripe.Apps.Secret> secrets = service.List(options);
        }

        [Fact]
        public void TestAppsSecretServiceList2()
        {
            var options = new Stripe.Apps.SecretListOptions
            {
                Scope = new Stripe.Apps.SecretScopeOptions { Type = "account" },
                Limit = 2,
            };
            var service = new Stripe.Apps.SecretService(this.StripeClient);
            StripeList<Stripe.Apps.Secret> secrets = service.List(options);
        }

        [Fact]
        public void TestBalanceTransactionServiceList()
        {
            var options = new BalanceTransactionListOptions { Limit = 3 };
            var service = new BalanceTransactionService(this.StripeClient);
            StripeList<BalanceTransaction> balancetransactions = service.List(
                options);
        }

        [Fact]
        public void TestBalanceTransactionServiceRetrieve()
        {
            var service = new BalanceTransactionService(this.StripeClient);
            service.Get("txn_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestBillingPortalConfigurationServiceCreate()
        {
            var options = new Stripe.BillingPortal.ConfigurationCreateOptions
            {
                Features = new Stripe.BillingPortal.ConfigurationFeaturesOptions
                {
                    CustomerUpdate = new Stripe.BillingPortal.ConfigurationFeaturesCustomerUpdateOptions
                    {
                        AllowedUpdates = new List<string> { "email", "tax_id" },
                        Enabled = true,
                    },
                    InvoiceHistory = new Stripe.BillingPortal.ConfigurationFeaturesInvoiceHistoryOptions
                    {
                        Enabled = true,
                    },
                },
                BusinessProfile = new Stripe.BillingPortal.ConfigurationBusinessProfileOptions
                {
                    PrivacyPolicyUrl = "https://example.com/privacy",
                    TermsOfServiceUrl = "https://example.com/terms",
                },
            };
            var service = new Stripe.BillingPortal.ConfigurationService(
                this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestBillingPortalConfigurationServiceList()
        {
            var options = new Stripe.BillingPortal.ConfigurationListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.BillingPortal.ConfigurationService(
                this.StripeClient);
            StripeList<Stripe.BillingPortal.Configuration> configurations = service.List(
                options);
        }

        [Fact]
        public void TestBillingPortalConfigurationServiceRetrieve()
        {
            var service = new Stripe.BillingPortal.ConfigurationService(
                this.StripeClient);
            service.Get("bpc_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestBillingPortalConfigurationServiceUpdate()
        {
            var options = new Stripe.BillingPortal.ConfigurationUpdateOptions
            {
                BusinessProfile = new Stripe.BillingPortal.ConfigurationBusinessProfileOptions
                {
                    PrivacyPolicyUrl = "https://example.com/privacy",
                    TermsOfServiceUrl = "https://example.com/terms",
                },
            };
            var service = new Stripe.BillingPortal.ConfigurationService(
                this.StripeClient);
            service.Update("bpc_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestBillingPortalSessionServiceCreate()
        {
            var options = new Stripe.BillingPortal.SessionCreateOptions
            {
                Customer = "cus_xxxxxxxxxxxxx",
                ReturnUrl = "https://example.com/account",
            };
            var service = new Stripe.BillingPortal.SessionService(
                this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestCapabilityServiceList()
        {
            var service = new CapabilityService(this.StripeClient);
            StripeList<Capability> capabilities = service.List(
                "acct_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestCapabilityServiceRetrieve()
        {
            var service = new CapabilityService(this.StripeClient);
            service.Get("acct_xxxxxxxxxxxxx", "card_payments");
        }

        [Fact]
        public void TestCapabilityServiceUpdate()
        {
            var options = new CapabilityUpdateOptions { Requested = true };
            var service = new CapabilityService(this.StripeClient);
            service.Update("acct_xxxxxxxxxxxxx", "card_payments", options);
        }

        [Fact]
        public void TestCashBalanceServiceRetrieve()
        {
            var service = new CashBalanceService(this.StripeClient);
            service.Get("cus_123");
        }

        [Fact]
        public void TestCashBalanceServiceUpdate()
        {
            var options = new CashBalanceUpdateOptions
            {
                Settings = new CashBalanceSettingsOptions
                {
                    ReconciliationMode = "manual",
                },
            };
            var service = new CashBalanceService(this.StripeClient);
            service.Update("cus_123", options);
        }

        [Fact]
        public void TestChargeServiceCapture()
        {
            var service = new ChargeService(this.StripeClient);
            service.Capture("ch_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestChargeServiceCreate()
        {
            var options = new ChargeCreateOptions
            {
                Amount = 2000,
                Currency = "usd",
                Source = "tok_xxxx",
                Description = "My First Test Charge (created for API docs at https://www.stripe.com/docs/api)",
            };
            var service = new ChargeService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestChargeServiceList()
        {
            var options = new ChargeListOptions { Limit = 3 };
            var service = new ChargeService(this.StripeClient);
            StripeList<Charge> charges = service.List(options);
        }

        [Fact]
        public void TestChargeServiceRetrieve()
        {
            var service = new ChargeService(this.StripeClient);
            service.Get("ch_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestChargeServiceSearch()
        {
            var options = new ChargeSearchOptions
            {
                Query = "amount>999 AND metadata['order_id']:'6735'",
            };
            var service = new ChargeService(this.StripeClient);
            service.Search(options);
        }

        [Fact]
        public void TestChargeServiceUpdate()
        {
            var options = new ChargeUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new ChargeService(this.StripeClient);
            service.Update("ch_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestCheckoutSessionServiceCreate()
        {
            var options = new Stripe.Checkout.SessionCreateOptions
            {
                SuccessUrl = "https://example.com/success",
                CancelUrl = "https://example.com/cancel",
                Mode = "payment",
                ShippingOptions = new List<Stripe.Checkout.SessionShippingOptionOptions>
                {
                    new Stripe.Checkout.SessionShippingOptionOptions
                    {
                        ShippingRate = "shr_standard",
                    },
                    new Stripe.Checkout.SessionShippingOptionOptions
                    {
                        ShippingRateData = new Stripe.Checkout.SessionShippingOptionShippingRateDataOptions
                        {
                            DisplayName = "Standard",
                            DeliveryEstimate = new Stripe.Checkout.SessionShippingOptionShippingRateDataDeliveryEstimateOptions
                            {
                                Minimum = new Stripe.Checkout.SessionShippingOptionShippingRateDataDeliveryEstimateMinimumOptions
                                {
                                    Unit = "day",
                                    Value = 5,
                                },
                                Maximum = new Stripe.Checkout.SessionShippingOptionShippingRateDataDeliveryEstimateMaximumOptions
                                {
                                    Unit = "day",
                                    Value = 7,
                                },
                            },
                        },
                    },
                },
            };
            var service = new Stripe.Checkout.SessionService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestCheckoutSessionServiceCreate2()
        {
            var options = new Stripe.Checkout.SessionCreateOptions
            {
                SuccessUrl = "https://example.com/success",
                LineItems = new List<Stripe.Checkout.SessionLineItemOptions>
                {
                    new Stripe.Checkout.SessionLineItemOptions
                    {
                        Price = "price_xxxxxxxxxxxxx",
                        Quantity = 2,
                    },
                },
                Mode = "payment",
            };
            var service = new Stripe.Checkout.SessionService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestCheckoutSessionServiceExpire()
        {
            var service = new Stripe.Checkout.SessionService(this.StripeClient);
            service.Expire("sess_xyz");
        }

        [Fact]
        public void TestCheckoutSessionServiceExpire2()
        {
            var service = new Stripe.Checkout.SessionService(this.StripeClient);
            service.Expire("cs_test_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestCheckoutSessionServiceList()
        {
            var options = new Stripe.Checkout.SessionListOptions { Limit = 3 };
            var service = new Stripe.Checkout.SessionService(this.StripeClient);
            StripeList<Stripe.Checkout.Session> sessions = service.List(
                options);
        }

        [Fact]
        public void TestCheckoutSessionServiceListLineItems()
        {
            var service = new Stripe.Checkout.SessionService(this.StripeClient);
            service.ListLineItems("sess_xyz");
        }

        [Fact]
        public void TestCheckoutSessionServiceRetrieve()
        {
            var service = new Stripe.Checkout.SessionService(this.StripeClient);
            service.Get("cs_test_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestCountrySpecServiceList()
        {
            var options = new CountrySpecListOptions { Limit = 3 };
            var service = new CountrySpecService(this.StripeClient);
            StripeList<CountrySpec> countryspecs = service.List(options);
        }

        [Fact]
        public void TestCountrySpecServiceRetrieve()
        {
            var service = new CountrySpecService(this.StripeClient);
            service.Get("US");
        }

        [Fact]
        public void TestCouponServiceCreate()
        {
            var options = new CouponCreateOptions
            {
                PercentOff = 25.5m,
                Duration = "repeating",
                DurationInMonths = 3,
            };
            var service = new CouponService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestCouponServiceDelete()
        {
            var service = new CouponService(this.StripeClient);
            service.Delete("Z4OV52SU");
        }

        [Fact]
        public void TestCouponServiceList()
        {
            var options = new CouponListOptions { Limit = 3 };
            var service = new CouponService(this.StripeClient);
            StripeList<Coupon> coupons = service.List(options);
        }

        [Fact]
        public void TestCouponServiceRetrieve()
        {
            var service = new CouponService(this.StripeClient);
            service.Get("Z4OV52SU");
        }

        [Fact]
        public void TestCouponServiceUpdate()
        {
            var options = new CouponUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new CouponService(this.StripeClient);
            service.Update("Z4OV52SU", options);
        }

        [Fact]
        public void TestCreditNoteServiceCreate()
        {
            var options = new CreditNoteCreateOptions
            {
                Invoice = "in_xxxxxxxxxxxxx",
                Lines = new List<CreditNoteLineOptions>
                {
                    new CreditNoteLineOptions
                    {
                        Type = "invoice_line_item",
                        InvoiceLineItem = "il_xxxxxxxxxxxxx",
                        Quantity = 1,
                    },
                },
            };
            var service = new CreditNoteService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestCreditNoteServiceList()
        {
            var options = new CreditNoteListOptions { Limit = 3 };
            var service = new CreditNoteService(this.StripeClient);
            StripeList<CreditNote> creditnotes = service.List(options);
        }

        [Fact]
        public void TestCreditNoteServicePreview()
        {
            var options = new CreditNotePreviewOptions
            {
                Invoice = "in_xxxxxxxxxxxxx",
                Lines = new List<CreditNoteLineOptions>
                {
                    new CreditNoteLineOptions
                    {
                        Type = "invoice_line_item",
                        InvoiceLineItem = "il_xxxxxxxxxxxxx",
                        Quantity = 1,
                    },
                },
            };
            var service = new CreditNoteService(this.StripeClient);
            service.Preview(options);
        }

        [Fact]
        public void TestCreditNoteServiceVoidCreditNote()
        {
            var service = new CreditNoteService(this.StripeClient);
            service.VoidCreditNote("cn_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestCustomerBalanceTransactionServiceCreate()
        {
            var options = new CustomerBalanceTransactionCreateOptions
            {
                Amount = -500,
                Currency = "usd",
            };
            var service = new CustomerBalanceTransactionService(
                this.StripeClient);
            service.Create("cus_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestCustomerBalanceTransactionServiceList()
        {
            var options = new CustomerBalanceTransactionListOptions
            {
                Limit = 3,
            };
            var service = new CustomerBalanceTransactionService(
                this.StripeClient);
            StripeList<CustomerBalanceTransaction> customerbalancetransactions = service.List(
                "cus_xxxxxxxxxxxxx",
                options);
        }

        [Fact]
        public void TestCustomerBalanceTransactionServiceRetrieve()
        {
            var service = new CustomerBalanceTransactionService(
                this.StripeClient);
            service.Get("cus_xxxxxxxxxxxxx", "cbtxn_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestCustomerBalanceTransactionServiceUpdate()
        {
            var options = new CustomerBalanceTransactionUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new CustomerBalanceTransactionService(
                this.StripeClient);
            service.Update("cus_xxxxxxxxxxxxx", "cbtxn_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestCustomerServiceCreate()
        {
            var options = new CustomerCreateOptions
            {
                Description = "My First Test Customer (created for API docs at https://www.stripe.com/docs/api)",
            };
            var service = new CustomerService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestCustomerServiceCreateFundingInstructions()
        {
            var options = new CustomerCreateFundingInstructionsOptions
            {
                BankTransfer = new CustomerBankTransferOptions
                {
                    RequestedAddressTypes = new List<string> { "zengin" },
                    Type = "jp_bank_transfer",
                },
                Currency = "usd",
                FundingType = "bank_transfer",
            };
            var service = new CustomerService(this.StripeClient);
            service.CreateFundingInstructions("cus_123", options);
        }

        [Fact]
        public void TestCustomerServiceDelete()
        {
            var service = new CustomerService(this.StripeClient);
            service.Delete("cus_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestCustomerServiceFundCashBalance()
        {
            var options = new Stripe.TestHelpers.CustomerFundCashBalanceOptions
            {
                Amount = 30,
                Currency = "eur",
            };
            var service = new Stripe.TestHelpers.CustomerService(
                this.StripeClient);
            service.FundCashBalance("cus_123", options);
        }

        [Fact]
        public void TestCustomerServiceList()
        {
            var options = new CustomerListOptions { Limit = 3 };
            var service = new CustomerService(this.StripeClient);
            StripeList<Customer> customers = service.List(options);
        }

        [Fact]
        public void TestCustomerServiceList2()
        {
            var options = new CustomerListOptions { Limit = 3 };
            var service = new CustomerService(this.StripeClient);
            StripeList<Customer> customers = service.List(options);
        }

        [Fact]
        public void TestCustomerServiceListPaymentMethods()
        {
            var options = new CustomerListPaymentMethodsOptions
            {
                Type = "card",
            };
            var service = new CustomerService(this.StripeClient);
            service.ListPaymentMethods("cus_xyz", options);
        }

        [Fact]
        public void TestCustomerServiceListPaymentMethods2()
        {
            var options = new CustomerListPaymentMethodsOptions
            {
                Type = "card",
            };
            var service = new CustomerService(this.StripeClient);
            service.ListPaymentMethods("cus_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestCustomerServiceRetrieve()
        {
            var service = new CustomerService(this.StripeClient);
            service.Get("cus_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestCustomerServiceSearch()
        {
            var options = new CustomerSearchOptions
            {
                Query = "name:'fakename' AND metadata['foo']:'bar'",
            };
            var service = new CustomerService(this.StripeClient);
            service.Search(options);
        }

        [Fact]
        public void TestCustomerServiceSearch2()
        {
            var options = new CustomerSearchOptions
            {
                Query = "name:'fakename' AND metadata['foo']:'bar'",
            };
            var service = new CustomerService(this.StripeClient);
            service.Search(options);
        }

        [Fact]
        public void TestCustomerServiceUpdate()
        {
            var options = new CustomerUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new CustomerService(this.StripeClient);
            service.Update("cus_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestDisputeServiceClose()
        {
            var service = new DisputeService(this.StripeClient);
            service.Close("dp_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestDisputeServiceList()
        {
            var options = new DisputeListOptions { Limit = 3 };
            var service = new DisputeService(this.StripeClient);
            StripeList<Dispute> disputes = service.List(options);
        }

        [Fact]
        public void TestDisputeServiceRetrieve()
        {
            var service = new DisputeService(this.StripeClient);
            service.Get("dp_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestDisputeServiceUpdate()
        {
            var options = new DisputeUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new DisputeService(this.StripeClient);
            service.Update("dp_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestEventServiceList()
        {
            var options = new EventListOptions { Limit = 3 };
            var service = new EventService(this.StripeClient);
            StripeList<Event> events = service.List(options);
        }

        [Fact]
        public void TestEventServiceRetrieve()
        {
            var service = new EventService(this.StripeClient);
            service.Get("evt_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestFileLinkServiceCreate()
        {
            var options = new FileLinkCreateOptions
            {
                File = "file_xxxxxxxxxxxxx",
            };
            var service = new FileLinkService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestFileLinkServiceList()
        {
            var options = new FileLinkListOptions { Limit = 3 };
            var service = new FileLinkService(this.StripeClient);
            StripeList<FileLink> filelinks = service.List(options);
        }

        [Fact]
        public void TestFileLinkServiceRetrieve()
        {
            var service = new FileLinkService(this.StripeClient);
            service.Get("link_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestFileLinkServiceUpdate()
        {
            var options = new FileLinkUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new FileLinkService(this.StripeClient);
            service.Update("link_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestFileServiceList()
        {
            var options = new FileListOptions { Limit = 3 };
            var service = new FileService(this.StripeClient);
            StripeList<File> files = service.List(options);
        }

        [Fact]
        public void TestFileServiceRetrieve()
        {
            var service = new FileService(this.StripeClient);
            service.Get("file_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestFinancialConnectionsAccountServiceDisconnect()
        {
            var service = new Stripe.FinancialConnections.AccountService(
                this.StripeClient);
            service.Disconnect("fca_xyz");
        }

        [Fact]
        public void TestFinancialConnectionsAccountServiceDisconnect2()
        {
            var service = new Stripe.FinancialConnections.AccountService(
                this.StripeClient);
            service.Disconnect("fca_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestFinancialConnectionsAccountServiceList()
        {
            var service = new Stripe.FinancialConnections.AccountService(
                this.StripeClient);
            StripeList<Stripe.FinancialConnections.Account> accounts = service.List();
        }

        [Fact]
        public void TestFinancialConnectionsAccountServiceList2()
        {
            var options = new Stripe.FinancialConnections.AccountListOptions
            {
                AccountHolder = new Stripe.FinancialConnections.AccountAccountHolderOptions
                {
                    Customer = "cus_xxxxxxxxxxxxx",
                },
            };
            var service = new Stripe.FinancialConnections.AccountService(
                this.StripeClient);
            StripeList<Stripe.FinancialConnections.Account> accounts = service.List(
                options);
        }

        [Fact]
        public void TestFinancialConnectionsAccountServiceListOwners()
        {
            var options = new Stripe.FinancialConnections.AccountListOwnersOptions
            {
                Ownership = "fcaowns_xyz",
            };
            var service = new Stripe.FinancialConnections.AccountService(
                this.StripeClient);
            service.ListOwners("fca_xyz", options);
        }

        [Fact]
        public void TestFinancialConnectionsAccountServiceListOwners2()
        {
            var options = new Stripe.FinancialConnections.AccountListOwnersOptions
            {
                Limit = 3,
                Ownership = "fcaowns_xxxxxxxxxxxxx",
            };
            var service = new Stripe.FinancialConnections.AccountService(
                this.StripeClient);
            service.ListOwners("fca_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestFinancialConnectionsAccountServiceRefresh()
        {
            var options = new Stripe.FinancialConnections.AccountRefreshOptions
            {
                Features = new List<string> { "balance" },
            };
            var service = new Stripe.FinancialConnections.AccountService(
                this.StripeClient);
            service.Refresh("fca_xyz", options);
        }

        [Fact]
        public void TestFinancialConnectionsAccountServiceRetrieve()
        {
            var service = new Stripe.FinancialConnections.AccountService(
                this.StripeClient);
            service.Get("fca_xyz");
        }

        [Fact]
        public void TestFinancialConnectionsAccountServiceRetrieve2()
        {
            var service = new Stripe.FinancialConnections.AccountService(
                this.StripeClient);
            service.Get("fca_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestFinancialConnectionsSessionServiceCreate()
        {
            var options = new Stripe.FinancialConnections.SessionCreateOptions
            {
                AccountHolder = new Stripe.FinancialConnections.SessionAccountHolderOptions
                {
                    Type = "customer",
                    Customer = "cus_123",
                },
                Permissions = new List<string> { "balances" },
            };
            var service = new Stripe.FinancialConnections.SessionService(
                this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestFinancialConnectionsSessionServiceCreate2()
        {
            var options = new Stripe.FinancialConnections.SessionCreateOptions
            {
                AccountHolder = new Stripe.FinancialConnections.SessionAccountHolderOptions
                {
                    Type = "customer",
                    Customer = "cus_xxxxxxxxxxxxx",
                },
                Permissions = new List<string> { "payment_method", "balances" },
                Filters = new Stripe.FinancialConnections.SessionFiltersOptions
                {
                    Countries = new List<string> { "US" },
                },
            };
            var service = new Stripe.FinancialConnections.SessionService(
                this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestFinancialConnectionsSessionServiceRetrieve()
        {
            var service = new Stripe.FinancialConnections.SessionService(
                this.StripeClient);
            service.Get("fcsess_xyz");
        }

        [Fact]
        public void TestFinancialConnectionsSessionServiceRetrieve2()
        {
            var service = new Stripe.FinancialConnections.SessionService(
                this.StripeClient);
            service.Get("fcsess_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIdentityVerificationReportServiceList()
        {
            var options = new Stripe.Identity.VerificationReportListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Identity.VerificationReportService(
                this.StripeClient);
            StripeList<Stripe.Identity.VerificationReport> verificationreports = service.List(
                options);
        }

        [Fact]
        public void TestIdentityVerificationReportServiceRetrieve()
        {
            var service = new Stripe.Identity.VerificationReportService(
                this.StripeClient);
            service.Get("vr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIdentityVerificationSessionServiceCancel()
        {
            var service = new Stripe.Identity.VerificationSessionService(
                this.StripeClient);
            service.Cancel("vs_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIdentityVerificationSessionServiceCreate()
        {
            var options = new Stripe.Identity.VerificationSessionCreateOptions
            {
                Type = "document",
            };
            var service = new Stripe.Identity.VerificationSessionService(
                this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestIdentityVerificationSessionServiceList()
        {
            var options = new Stripe.Identity.VerificationSessionListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Identity.VerificationSessionService(
                this.StripeClient);
            StripeList<Stripe.Identity.VerificationSession> verificationsessions = service.List(
                options);
        }

        [Fact]
        public void TestIdentityVerificationSessionServiceRedact()
        {
            var service = new Stripe.Identity.VerificationSessionService(
                this.StripeClient);
            service.Redact("vs_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIdentityVerificationSessionServiceRetrieve()
        {
            var service = new Stripe.Identity.VerificationSessionService(
                this.StripeClient);
            service.Get("vs_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIdentityVerificationSessionServiceUpdate()
        {
            var options = new Stripe.Identity.VerificationSessionUpdateOptions
            {
                Type = "id_number",
            };
            var service = new Stripe.Identity.VerificationSessionService(
                this.StripeClient);
            service.Update("vs_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestInvoiceItemServiceCreate()
        {
            var options = new InvoiceItemCreateOptions
            {
                Customer = "cus_xxxxxxxxxxxxx",
                Price = "price_xxxxxxxxxxxxx",
            };
            var service = new InvoiceItemService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestInvoiceItemServiceDelete()
        {
            var service = new InvoiceItemService(this.StripeClient);
            service.Delete("ii_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestInvoiceItemServiceList()
        {
            var options = new InvoiceItemListOptions { Limit = 3 };
            var service = new InvoiceItemService(this.StripeClient);
            StripeList<InvoiceItem> invoiceitems = service.List(options);
        }

        [Fact]
        public void TestInvoiceItemServiceRetrieve()
        {
            var service = new InvoiceItemService(this.StripeClient);
            service.Get("ii_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestInvoiceItemServiceUpdate()
        {
            var options = new InvoiceItemUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new InvoiceItemService(this.StripeClient);
            service.Update("ii_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestInvoiceServiceCreate()
        {
            var options = new InvoiceCreateOptions
            {
                Customer = "cus_xxxxxxxxxxxxx",
            };
            var service = new InvoiceService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestInvoiceServiceDelete()
        {
            var service = new InvoiceService(this.StripeClient);
            service.Delete("in_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestInvoiceServiceFinalizeInvoice()
        {
            var service = new InvoiceService(this.StripeClient);
            service.FinalizeInvoice("in_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestInvoiceServiceList()
        {
            var options = new InvoiceListOptions { Limit = 3 };
            var service = new InvoiceService(this.StripeClient);
            StripeList<Invoice> invoices = service.List(options);
        }

        [Fact]
        public void TestInvoiceServiceMarkUncollectible()
        {
            var service = new InvoiceService(this.StripeClient);
            service.MarkUncollectible("in_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestInvoiceServicePay()
        {
            var service = new InvoiceService(this.StripeClient);
            service.Pay("in_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestInvoiceServiceRetrieve()
        {
            var service = new InvoiceService(this.StripeClient);
            service.Get("in_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestInvoiceServiceRetrieve2()
        {
            var options = new InvoiceGetOptions
            {
                Expand = new List<string> { "customer" },
            };
            var service = new InvoiceService(this.StripeClient);
            service.Get("in_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestInvoiceServiceSearch()
        {
            var options = new InvoiceSearchOptions
            {
                Query = "total>999 AND metadata['order_id']:'6735'",
            };
            var service = new InvoiceService(this.StripeClient);
            service.Search(options);
        }

        [Fact]
        public void TestInvoiceServiceSendInvoice()
        {
            var service = new InvoiceService(this.StripeClient);
            service.SendInvoice("in_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestInvoiceServiceUpcoming()
        {
            var options = new UpcomingInvoiceOptions
            {
                Customer = "cus_9utnxg47pWjV1e",
            };
            var service = new InvoiceService(this.StripeClient);
            service.Upcoming(options);
        }

        [Fact]
        public void TestInvoiceServiceUpdate()
        {
            var options = new InvoiceUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new InvoiceService(this.StripeClient);
            service.Update("in_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestInvoiceServiceVoidInvoice()
        {
            var service = new InvoiceService(this.StripeClient);
            service.VoidInvoice("in_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIssuingAuthorizationServiceApprove()
        {
            var service = new Stripe.Issuing.AuthorizationService(
                this.StripeClient);
            service.Approve("iauth_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIssuingAuthorizationServiceDecline()
        {
            var service = new Stripe.Issuing.AuthorizationService(
                this.StripeClient);
            service.Decline("iauth_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIssuingAuthorizationServiceList()
        {
            var options = new Stripe.Issuing.AuthorizationListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Issuing.AuthorizationService(
                this.StripeClient);
            StripeList<Stripe.Issuing.Authorization> authorizations = service.List(
                options);
        }

        [Fact]
        public void TestIssuingAuthorizationServiceRetrieve()
        {
            var service = new Stripe.Issuing.AuthorizationService(
                this.StripeClient);
            service.Get("iauth_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIssuingAuthorizationServiceUpdate()
        {
            var options = new Stripe.Issuing.AuthorizationUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new Stripe.Issuing.AuthorizationService(
                this.StripeClient);
            service.Update("iauth_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestIssuingCardholderServiceCreate()
        {
            var options = new Stripe.Issuing.CardholderCreateOptions
            {
                Type = "individual",
                Name = "Jenny Rosen",
                Email = "jenny.rosen@example.com",
                PhoneNumber = "+18888675309",
                Billing = new Stripe.Issuing.CardholderBillingOptions
                {
                    Address = new AddressOptions
                    {
                        Line1 = "1234 Main Street",
                        City = "San Francisco",
                        State = "CA",
                        Country = "US",
                        PostalCode = "94111",
                    },
                },
            };
            var service = new Stripe.Issuing.CardholderService(
                this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestIssuingCardholderServiceList()
        {
            var options = new Stripe.Issuing.CardholderListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Issuing.CardholderService(
                this.StripeClient);
            StripeList<Stripe.Issuing.Cardholder> cardholders = service.List(
                options);
        }

        [Fact]
        public void TestIssuingCardholderServiceRetrieve()
        {
            var service = new Stripe.Issuing.CardholderService(
                this.StripeClient);
            service.Get("ich_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIssuingCardholderServiceUpdate()
        {
            var options = new Stripe.Issuing.CardholderUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new Stripe.Issuing.CardholderService(
                this.StripeClient);
            service.Update("ich_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestIssuingCardServiceCreate()
        {
            var options = new Stripe.Issuing.CardCreateOptions
            {
                Cardholder = "ich_xxxxxxxxxxxxx",
                Currency = "usd",
                Type = "virtual",
            };
            var service = new Stripe.Issuing.CardService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestIssuingCardServiceDeliverCard()
        {
            var service = new Stripe.TestHelpers.Issuing.CardService(
                this.StripeClient);
            service.DeliverCard("card_123");
        }

        [Fact]
        public void TestIssuingCardServiceFailCard()
        {
            var service = new Stripe.TestHelpers.Issuing.CardService(
                this.StripeClient);
            service.FailCard("card_123");
        }

        [Fact]
        public void TestIssuingCardServiceList()
        {
            var options = new Stripe.Issuing.CardListOptions { Limit = 3 };
            var service = new Stripe.Issuing.CardService(this.StripeClient);
            StripeList<Stripe.Issuing.Card> cards = service.List(options);
        }

        [Fact]
        public void TestIssuingCardServiceRetrieve()
        {
            var service = new Stripe.Issuing.CardService(this.StripeClient);
            service.Get("ic_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIssuingCardServiceReturnCard()
        {
            var service = new Stripe.TestHelpers.Issuing.CardService(
                this.StripeClient);
            service.ReturnCard("card_123");
        }

        [Fact]
        public void TestIssuingCardServiceShipCard()
        {
            var service = new Stripe.TestHelpers.Issuing.CardService(
                this.StripeClient);
            service.ShipCard("card_123");
        }

        [Fact]
        public void TestIssuingCardServiceUpdate()
        {
            var options = new Stripe.Issuing.CardUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new Stripe.Issuing.CardService(this.StripeClient);
            service.Update("ic_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestIssuingDisputeServiceCreate()
        {
            var options = new Stripe.Issuing.DisputeCreateOptions
            {
                Transaction = "ipi_xxxxxxxxxxxxx",
                Evidence = new Stripe.Issuing.DisputeEvidenceOptions
                {
                    Reason = "fraudulent",
                    Fraudulent = new Stripe.Issuing.DisputeEvidenceFraudulentOptions
                    {
                        Explanation = "Purchase was unrecognized.",
                    },
                },
            };
            var service = new Stripe.Issuing.DisputeService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestIssuingDisputeServiceList()
        {
            var options = new Stripe.Issuing.DisputeListOptions { Limit = 3 };
            var service = new Stripe.Issuing.DisputeService(this.StripeClient);
            StripeList<Stripe.Issuing.Dispute> disputes = service.List(options);
        }

        [Fact]
        public void TestIssuingDisputeServiceRetrieve()
        {
            var service = new Stripe.Issuing.DisputeService(this.StripeClient);
            service.Get("idp_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIssuingDisputeServiceSubmit()
        {
            var service = new Stripe.Issuing.DisputeService(this.StripeClient);
            service.Submit("idp_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIssuingTransactionServiceList()
        {
            var options = new Stripe.Issuing.TransactionListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Issuing.TransactionService(
                this.StripeClient);
            StripeList<Stripe.Issuing.Transaction> transactions = service.List(
                options);
        }

        [Fact]
        public void TestIssuingTransactionServiceRetrieve()
        {
            var service = new Stripe.Issuing.TransactionService(
                this.StripeClient);
            service.Get("ipi_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIssuingTransactionServiceUpdate()
        {
            var options = new Stripe.Issuing.TransactionUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new Stripe.Issuing.TransactionService(
                this.StripeClient);
            service.Update("ipi_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestLoginLinkServiceCreate()
        {
            var service = new LoginLinkService(this.StripeClient);
            service.Create("acct_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestMandateServiceRetrieve()
        {
            var service = new MandateService(this.StripeClient);
            service.Get("mandate_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPaymentIntentServiceApplyCustomerBalance()
        {
            var service = new PaymentIntentService(this.StripeClient);
            service.ApplyCustomerBalance("pi_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPaymentIntentServiceCancel()
        {
            var service = new PaymentIntentService(this.StripeClient);
            service.Cancel("pi_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPaymentIntentServiceCapture()
        {
            var service = new PaymentIntentService(this.StripeClient);
            service.Capture("pi_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPaymentIntentServiceConfirm()
        {
            var options = new PaymentIntentConfirmOptions
            {
                PaymentMethod = "pm_card_visa",
            };
            var service = new PaymentIntentService(this.StripeClient);
            service.Confirm("pi_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestPaymentIntentServiceCreate()
        {
            var options = new PaymentIntentCreateOptions
            {
                Amount = 1099,
                Currency = "eur",
                AutomaticPaymentMethods = new PaymentIntentAutomaticPaymentMethodsOptions
                {
                    Enabled = true,
                },
            };
            var service = new PaymentIntentService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestPaymentIntentServiceCreate2()
        {
            var options = new PaymentIntentCreateOptions
            {
                Amount = 2000,
                Currency = "usd",
                AutomaticPaymentMethods = new PaymentIntentAutomaticPaymentMethodsOptions
                {
                    Enabled = true,
                },
            };
            var service = new PaymentIntentService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestPaymentIntentServiceIncrementAuthorization()
        {
            var options = new PaymentIntentIncrementAuthorizationOptions
            {
                Amount = 2099,
            };
            var service = new PaymentIntentService(this.StripeClient);
            service.IncrementAuthorization("pi_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestPaymentIntentServiceList()
        {
            var options = new PaymentIntentListOptions { Limit = 3 };
            var service = new PaymentIntentService(this.StripeClient);
            StripeList<PaymentIntent> paymentintents = service.List(options);
        }

        [Fact]
        public void TestPaymentIntentServiceRetrieve()
        {
            var service = new PaymentIntentService(this.StripeClient);
            service.Get("pi_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPaymentIntentServiceSearch()
        {
            var options = new PaymentIntentSearchOptions
            {
                Query = "status:'succeeded' AND metadata['order_id']:'6735'",
            };
            var service = new PaymentIntentService(this.StripeClient);
            service.Search(options);
        }

        [Fact]
        public void TestPaymentIntentServiceUpdate()
        {
            var options = new PaymentIntentUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new PaymentIntentService(this.StripeClient);
            service.Update("pi_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestPaymentIntentServiceVerifyMicrodeposits()
        {
            var service = new PaymentIntentService(this.StripeClient);
            service.VerifyMicrodeposits("pi_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPaymentIntentServiceVerifyMicrodeposits2()
        {
            var options = new PaymentIntentVerifyMicrodepositsOptions
            {
                Amounts = new List<long?> { 32, 45 },
            };
            var service = new PaymentIntentService(this.StripeClient);
            service.VerifyMicrodeposits("pi_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestPaymentLinkServiceCreate()
        {
            var options = new PaymentLinkCreateOptions
            {
                LineItems = new List<PaymentLinkLineItemOptions>
                {
                    new PaymentLinkLineItemOptions
                    {
                        Price = "price_xxxxxxxxxxxxx",
                        Quantity = 1,
                    },
                },
            };
            var service = new PaymentLinkService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestPaymentLinkServiceCreate2()
        {
            var options = new PaymentLinkCreateOptions
            {
                LineItems = new List<PaymentLinkLineItemOptions>
                {
                    new PaymentLinkLineItemOptions
                    {
                        Price = "price_xxxxxxxxxxxxx",
                        Quantity = 1,
                    },
                },
            };
            var service = new PaymentLinkService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestPaymentLinkServiceList()
        {
            var options = new PaymentLinkListOptions { Limit = 3 };
            var service = new PaymentLinkService(this.StripeClient);
            StripeList<PaymentLink> paymentlinks = service.List(options);
        }

        [Fact]
        public void TestPaymentLinkServiceListLineItems()
        {
            var service = new PaymentLinkService(this.StripeClient);
            service.ListLineItems("pl_xyz");
        }

        [Fact]
        public void TestPaymentLinkServiceRetrieve()
        {
            var service = new PaymentLinkService(this.StripeClient);
            service.Get("pl_xyz");
        }

        [Fact]
        public void TestPaymentLinkServiceRetrieve2()
        {
            var service = new PaymentLinkService(this.StripeClient);
            service.Get("plink_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPaymentLinkServiceUpdate()
        {
            var options = new PaymentLinkUpdateOptions { Active = false };
            var service = new PaymentLinkService(this.StripeClient);
            service.Update("plink_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestPaymentMethodServiceAttach()
        {
            var options = new PaymentMethodAttachOptions
            {
                Customer = "cus_xxxxxxxxxxxxx",
            };
            var service = new PaymentMethodService(this.StripeClient);
            service.Attach("pm_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestPaymentMethodServiceCreate()
        {
            var options = new PaymentMethodCreateOptions
            {
                Type = "card",
                Card = new PaymentMethodCardOptions
                {
                    Number = "4242424242424242",
                    ExpMonth = 8,
                    ExpYear = 2024,
                    Cvc = "314",
                },
            };
            var service = new PaymentMethodService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestPaymentMethodServiceDetach()
        {
            var service = new PaymentMethodService(this.StripeClient);
            service.Detach("pm_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPaymentMethodServiceList()
        {
            var options = new PaymentMethodListOptions
            {
                Customer = "cus_xxxxxxxxxxxxx",
                Type = "card",
            };
            var service = new PaymentMethodService(this.StripeClient);
            StripeList<PaymentMethod> paymentmethods = service.List(options);
        }

        [Fact]
        public void TestPaymentMethodServiceRetrieve()
        {
            var service = new PaymentMethodService(this.StripeClient);
            service.Get("pm_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPaymentMethodServiceUpdate()
        {
            var options = new PaymentMethodUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new PaymentMethodService(this.StripeClient);
            service.Update("pm_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestPayoutServiceCancel()
        {
            var service = new PayoutService(this.StripeClient);
            service.Cancel("po_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPayoutServiceCreate()
        {
            var options = new PayoutCreateOptions
            {
                Amount = 1100,
                Currency = "usd",
            };
            var service = new PayoutService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestPayoutServiceList()
        {
            var options = new PayoutListOptions { Limit = 3 };
            var service = new PayoutService(this.StripeClient);
            StripeList<Payout> payouts = service.List(options);
        }

        [Fact]
        public void TestPayoutServiceRetrieve()
        {
            var service = new PayoutService(this.StripeClient);
            service.Get("po_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPayoutServiceReverse()
        {
            var service = new PayoutService(this.StripeClient);
            service.Reverse("po_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPayoutServiceUpdate()
        {
            var options = new PayoutUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new PayoutService(this.StripeClient);
            service.Update("po_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestPersonServiceCreate()
        {
            var options = new PersonCreateOptions
            {
                FirstName = "Jane",
                LastName = "Diaz",
            };
            var service = new PersonService(this.StripeClient);
            service.Create("acct_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestPersonServiceDelete()
        {
            var service = new PersonService(this.StripeClient);
            service.Delete("acct_xxxxxxxxxxxxx", "person_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPersonServiceList()
        {
            var options = new PersonListOptions { Limit = 3 };
            var service = new PersonService(this.StripeClient);
            StripeList<Person> persons = service.List(
                "acct_xxxxxxxxxxxxx",
                options);
        }

        [Fact]
        public void TestPersonServiceRetrieve()
        {
            var service = new PersonService(this.StripeClient);
            service.Get("acct_xxxxxxxxxxxxx", "person_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPersonServiceUpdate()
        {
            var options = new PersonUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new PersonService(this.StripeClient);
            service.Update(
                "acct_xxxxxxxxxxxxx",
                "person_xxxxxxxxxxxxx",
                options);
        }

        [Fact]
        public void TestPlanServiceCreate()
        {
            var options = new PlanCreateOptions
            {
                Amount = 2000,
                Currency = "usd",
                Interval = "month",
                Product = "prod_xxxxxxxxxxxxx",
            };
            var service = new PlanService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestPlanServiceDelete()
        {
            var service = new PlanService(this.StripeClient);
            service.Delete("price_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPlanServiceList()
        {
            var options = new PlanListOptions { Limit = 3 };
            var service = new PlanService(this.StripeClient);
            StripeList<Plan> plans = service.List(options);
        }

        [Fact]
        public void TestPlanServiceRetrieve()
        {
            var service = new PlanService(this.StripeClient);
            service.Get("price_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPlanServiceUpdate()
        {
            var options = new PlanUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new PlanService(this.StripeClient);
            service.Update("price_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestPriceServiceCreate()
        {
            var options = new PriceCreateOptions
            {
                UnitAmount = 2000,
                Currency = "usd",
                CurrencyOptions = new Dictionary<string, PriceCurrencyOptionsOptions>
                {
                    {
                        "uah", new PriceCurrencyOptionsOptions
                        {
                            UnitAmount = 5000,
                        }
                    },
                    {
                        "eur", new PriceCurrencyOptionsOptions
                        {
                            UnitAmount = 1800,
                        }
                    },
                },
                Recurring = new PriceRecurringOptions { Interval = "month" },
                Product = "prod_xxxxxxxxxxxxx",
            };
            var service = new PriceService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestPriceServiceCreate2()
        {
            var options = new PriceCreateOptions
            {
                UnitAmount = 2000,
                Currency = "usd",
                Recurring = new PriceRecurringOptions { Interval = "month" },
                Product = "prod_xxxxxxxxxxxxx",
            };
            var service = new PriceService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestPriceServiceList()
        {
            var options = new PriceListOptions { Limit = 3 };
            var service = new PriceService(this.StripeClient);
            StripeList<Price> prices = service.List(options);
        }

        [Fact]
        public void TestPriceServiceRetrieve()
        {
            var service = new PriceService(this.StripeClient);
            service.Get("price_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPriceServiceSearch()
        {
            var options = new PriceSearchOptions
            {
                Query = "active:'true' AND metadata['order_id']:'6735'",
            };
            var service = new PriceService(this.StripeClient);
            service.Search(options);
        }

        [Fact]
        public void TestPriceServiceUpdate()
        {
            var options = new PriceUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new PriceService(this.StripeClient);
            service.Update("price_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestProductServiceCreate()
        {
            var options = new ProductCreateOptions { Name = "Gold Special" };
            var service = new ProductService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestProductServiceDelete()
        {
            var service = new ProductService(this.StripeClient);
            service.Delete("prod_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestProductServiceList()
        {
            var options = new ProductListOptions { Limit = 3 };
            var service = new ProductService(this.StripeClient);
            StripeList<Product> products = service.List(options);
        }

        [Fact]
        public void TestProductServiceRetrieve()
        {
            var service = new ProductService(this.StripeClient);
            service.Get("prod_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestProductServiceSearch()
        {
            var options = new ProductSearchOptions
            {
                Query = "active:'true' AND metadata['order_id']:'6735'",
            };
            var service = new ProductService(this.StripeClient);
            service.Search(options);
        }

        [Fact]
        public void TestProductServiceUpdate()
        {
            var options = new ProductUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new ProductService(this.StripeClient);
            service.Update("prod_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestPromotionCodeServiceCreate()
        {
            var options = new PromotionCodeCreateOptions
            {
                Coupon = "Z4OV52SU",
            };
            var service = new PromotionCodeService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestPromotionCodeServiceList()
        {
            var options = new PromotionCodeListOptions { Limit = 3 };
            var service = new PromotionCodeService(this.StripeClient);
            StripeList<PromotionCode> promotioncodes = service.List(options);
        }

        [Fact]
        public void TestPromotionCodeServiceRetrieve()
        {
            var service = new PromotionCodeService(this.StripeClient);
            service.Get("promo_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPromotionCodeServiceUpdate()
        {
            var options = new PromotionCodeUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new PromotionCodeService(this.StripeClient);
            service.Update("promo_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestQuoteServiceAccept()
        {
            var service = new QuoteService(this.StripeClient);
            service.Accept("qt_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestQuoteServiceCancel()
        {
            var service = new QuoteService(this.StripeClient);
            service.Cancel("qt_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestQuoteServiceCreate()
        {
            var options = new QuoteCreateOptions
            {
                Customer = "cus_xxxxxxxxxxxxx",
                LineItems = new List<QuoteLineItemOptions>
                {
                    new QuoteLineItemOptions
                    {
                        Price = "price_xxxxxxxxxxxxx",
                        Quantity = 2,
                    },
                },
            };
            var service = new QuoteService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestQuoteServiceFinalizeQuote()
        {
            var service = new QuoteService(this.StripeClient);
            service.FinalizeQuote("qt_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestQuoteServiceList()
        {
            var options = new QuoteListOptions { Limit = 3 };
            var service = new QuoteService(this.StripeClient);
            StripeList<Quote> quotes = service.List(options);
        }

        [Fact]
        public void TestQuoteServiceRetrieve()
        {
            var service = new QuoteService(this.StripeClient);
            service.Get("qt_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestQuoteServiceUpdate()
        {
            var options = new QuoteUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new QuoteService(this.StripeClient);
            service.Update("qt_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestRadarEarlyFraudWarningServiceList()
        {
            var options = new Stripe.Radar.EarlyFraudWarningListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Radar.EarlyFraudWarningService(
                this.StripeClient);
            StripeList<Stripe.Radar.EarlyFraudWarning> earlyfraudwarnings = service.List(
                options);
        }

        [Fact]
        public void TestRadarEarlyFraudWarningServiceRetrieve()
        {
            var service = new Stripe.Radar.EarlyFraudWarningService(
                this.StripeClient);
            service.Get("issfr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestRadarValueListItemServiceCreate()
        {
            var options = new Stripe.Radar.ValueListItemCreateOptions
            {
                ValueList = "rsl_xxxxxxxxxxxxx",
                Value = "1.2.3.4",
            };
            var service = new Stripe.Radar.ValueListItemService(
                this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestRadarValueListItemServiceDelete()
        {
            var service = new Stripe.Radar.ValueListItemService(
                this.StripeClient);
            service.Delete("rsli_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestRadarValueListItemServiceList()
        {
            var options = new Stripe.Radar.ValueListItemListOptions
            {
                Limit = 3,
                ValueList = "rsl_xxxxxxxxxxxxx",
            };
            var service = new Stripe.Radar.ValueListItemService(
                this.StripeClient);
            StripeList<Stripe.Radar.ValueListItem> valuelistitems = service.List(
                options);
        }

        [Fact]
        public void TestRadarValueListItemServiceRetrieve()
        {
            var service = new Stripe.Radar.ValueListItemService(
                this.StripeClient);
            service.Get("rsli_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestRadarValueListServiceCreate()
        {
            var options = new Stripe.Radar.ValueListCreateOptions
            {
                Alias = "custom_ip_xxxxxxxxxxxxx",
                Name = "Custom IP Blocklist",
                ItemType = "ip_address",
            };
            var service = new Stripe.Radar.ValueListService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestRadarValueListServiceDelete()
        {
            var service = new Stripe.Radar.ValueListService(this.StripeClient);
            service.Delete("rsl_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestRadarValueListServiceList()
        {
            var options = new Stripe.Radar.ValueListListOptions { Limit = 3 };
            var service = new Stripe.Radar.ValueListService(this.StripeClient);
            StripeList<Stripe.Radar.ValueList> valuelists = service.List(
                options);
        }

        [Fact]
        public void TestRadarValueListServiceRetrieve()
        {
            var service = new Stripe.Radar.ValueListService(this.StripeClient);
            service.Get("rsl_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestRadarValueListServiceUpdate()
        {
            var options = new Stripe.Radar.ValueListUpdateOptions
            {
                Name = "Updated IP Block List",
            };
            var service = new Stripe.Radar.ValueListService(this.StripeClient);
            service.Update("rsl_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestRefundServiceCancel()
        {
            var service = new RefundService(this.StripeClient);
            service.Cancel("re_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestRefundServiceCreate()
        {
            var options = new RefundCreateOptions
            {
                Charge = "ch_xxxxxxxxxxxxx",
            };
            var service = new RefundService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestRefundServiceExpire()
        {
            var service = new Stripe.TestHelpers.RefundService(
                this.StripeClient);
            service.Expire("re_123");
        }

        [Fact]
        public void TestRefundServiceList()
        {
            var options = new RefundListOptions { Limit = 3 };
            var service = new RefundService(this.StripeClient);
            StripeList<Refund> refunds = service.List(options);
        }

        [Fact]
        public void TestRefundServiceRetrieve()
        {
            var service = new RefundService(this.StripeClient);
            service.Get("re_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestRefundServiceUpdate()
        {
            var options = new RefundUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new RefundService(this.StripeClient);
            service.Update("re_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestReportingReportRunServiceCreate()
        {
            var options = new Stripe.Reporting.ReportRunCreateOptions
            {
                ReportType = "balance.summary.1",
                Parameters = new Stripe.Reporting.ReportRunParametersOptions
                {
                    IntervalStart = DateTimeOffset.FromUnixTimeSeconds(
                        1522540800)
                        .UtcDateTime,
                    IntervalEnd = DateTimeOffset.FromUnixTimeSeconds(1525132800)
                        .UtcDateTime,
                },
            };
            var service = new Stripe.Reporting.ReportRunService(
                this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestReportingReportRunServiceList()
        {
            var options = new Stripe.Reporting.ReportRunListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Reporting.ReportRunService(
                this.StripeClient);
            StripeList<Stripe.Reporting.ReportRun> reportruns = service.List(
                options);
        }

        [Fact]
        public void TestReportingReportRunServiceRetrieve()
        {
            var service = new Stripe.Reporting.ReportRunService(
                this.StripeClient);
            service.Get("frr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestReportingReportTypeServiceList()
        {
            var service = new Stripe.Reporting.ReportTypeService(
                this.StripeClient);
            StripeList<Stripe.Reporting.ReportType> reporttypes = service.List();
        }

        [Fact]
        public void TestReportingReportTypeServiceRetrieve()
        {
            var service = new Stripe.Reporting.ReportTypeService(
                this.StripeClient);
            service.Get("balance.summary.1");
        }

        [Fact]
        public void TestReviewServiceApprove()
        {
            var service = new ReviewService(this.StripeClient);
            service.Approve("prv_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestReviewServiceList()
        {
            var options = new ReviewListOptions { Limit = 3 };
            var service = new ReviewService(this.StripeClient);
            StripeList<Review> reviews = service.List(options);
        }

        [Fact]
        public void TestReviewServiceRetrieve()
        {
            var service = new ReviewService(this.StripeClient);
            service.Get("prv_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSetupAttemptServiceList()
        {
            var options = new SetupAttemptListOptions
            {
                Limit = 3,
                SetupIntent = "si_xyz",
            };
            var service = new SetupAttemptService(this.StripeClient);
            StripeList<SetupAttempt> setupattempts = service.List(options);
        }

        [Fact]
        public void TestSetupIntentServiceCancel()
        {
            var service = new SetupIntentService(this.StripeClient);
            service.Cancel("seti_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSetupIntentServiceConfirm()
        {
            var options = new SetupIntentConfirmOptions
            {
                PaymentMethod = "pm_card_visa",
            };
            var service = new SetupIntentService(this.StripeClient);
            service.Confirm("seti_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestSetupIntentServiceCreate()
        {
            var options = new SetupIntentCreateOptions
            {
                PaymentMethodTypes = new List<string> { "card" },
            };
            var service = new SetupIntentService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestSetupIntentServiceList()
        {
            var options = new SetupIntentListOptions { Limit = 3 };
            var service = new SetupIntentService(this.StripeClient);
            StripeList<SetupIntent> setupintents = service.List(options);
        }

        [Fact]
        public void TestSetupIntentServiceRetrieve()
        {
            var service = new SetupIntentService(this.StripeClient);
            service.Get("seti_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSetupIntentServiceUpdate()
        {
            var options = new SetupIntentUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "user_id", "3435453" },
                },
            };
            var service = new SetupIntentService(this.StripeClient);
            service.Update("seti_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestSetupIntentServiceVerifyMicrodeposits()
        {
            var service = new SetupIntentService(this.StripeClient);
            service.VerifyMicrodeposits("seti_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSetupIntentServiceVerifyMicrodeposits2()
        {
            var options = new SetupIntentVerifyMicrodepositsOptions
            {
                Amounts = new List<long?> { 32, 45 },
            };
            var service = new SetupIntentService(this.StripeClient);
            service.VerifyMicrodeposits("seti_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestShippingRateServiceCreate()
        {
            var options = new ShippingRateCreateOptions
            {
                DisplayName = "Sample Shipper",
                FixedAmount = new ShippingRateFixedAmountOptions
                {
                    Currency = "usd",
                    Amount = 400,
                },
                Type = "fixed_amount",
            };
            var service = new ShippingRateService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestShippingRateServiceCreate2()
        {
            var options = new ShippingRateCreateOptions
            {
                DisplayName = "Ground shipping",
                Type = "fixed_amount",
                FixedAmount = new ShippingRateFixedAmountOptions
                {
                    Amount = 500,
                    Currency = "usd",
                },
            };
            var service = new ShippingRateService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestShippingRateServiceList()
        {
            var service = new ShippingRateService(this.StripeClient);
            StripeList<ShippingRate> shippingrates = service.List();
        }

        [Fact]
        public void TestShippingRateServiceList2()
        {
            var options = new ShippingRateListOptions { Limit = 3 };
            var service = new ShippingRateService(this.StripeClient);
            StripeList<ShippingRate> shippingrates = service.List(options);
        }

        [Fact]
        public void TestShippingRateServiceRetrieve()
        {
            var service = new ShippingRateService(this.StripeClient);
            service.Get("shr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestShippingRateServiceUpdate()
        {
            var options = new ShippingRateUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new ShippingRateService(this.StripeClient);
            service.Update("shr_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestSigmaScheduledQueryRunServiceList()
        {
            var options = new Stripe.Sigma.ScheduledQueryRunListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Sigma.ScheduledQueryRunService(
                this.StripeClient);
            StripeList<Stripe.Sigma.ScheduledQueryRun> scheduledqueryruns = service.List(
                options);
        }

        [Fact]
        public void TestSigmaScheduledQueryRunServiceRetrieve()
        {
            var service = new Stripe.Sigma.ScheduledQueryRunService(
                this.StripeClient);
            service.Get("sqr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSourceServiceRetrieve()
        {
            var service = new SourceService(this.StripeClient);
            service.Get("src_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSourceServiceRetrieve2()
        {
            var service = new SourceService(this.StripeClient);
            service.Get("src_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSourceServiceUpdate()
        {
            var options = new SourceUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new SourceService(this.StripeClient);
            service.Update("src_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestSubscriptionItemServiceCreate()
        {
            var options = new SubscriptionItemCreateOptions
            {
                Subscription = "sub_xxxxxxxxxxxxx",
                Price = "price_xxxxxxxxxxxxx",
                Quantity = 2,
            };
            var service = new SubscriptionItemService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestSubscriptionItemServiceDelete()
        {
            var service = new SubscriptionItemService(this.StripeClient);
            service.Delete("si_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSubscriptionItemServiceList()
        {
            var options = new SubscriptionItemListOptions
            {
                Subscription = "sub_xxxxxxxxxxxxx",
            };
            var service = new SubscriptionItemService(this.StripeClient);
            StripeList<SubscriptionItem> subscriptionitems = service.List(
                options);
        }

        [Fact]
        public void TestSubscriptionItemServiceRetrieve()
        {
            var service = new SubscriptionItemService(this.StripeClient);
            service.Get("si_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSubscriptionItemServiceUpdate()
        {
            var options = new SubscriptionItemUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new SubscriptionItemService(this.StripeClient);
            service.Update("si_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestSubscriptionScheduleServiceCancel()
        {
            var service = new SubscriptionScheduleService(this.StripeClient);
            service.Cancel("sub_sched_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSubscriptionScheduleServiceList()
        {
            var options = new SubscriptionScheduleListOptions { Limit = 3 };
            var service = new SubscriptionScheduleService(this.StripeClient);
            StripeList<SubscriptionSchedule> subscriptionschedules = service.List(
                options);
        }

        [Fact]
        public void TestSubscriptionScheduleServiceRelease()
        {
            var service = new SubscriptionScheduleService(this.StripeClient);
            service.Release("sub_sched_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSubscriptionScheduleServiceRetrieve()
        {
            var service = new SubscriptionScheduleService(this.StripeClient);
            service.Get("sub_sched_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSubscriptionScheduleServiceUpdate()
        {
            var options = new SubscriptionScheduleUpdateOptions
            {
                EndBehavior = "release",
            };
            var service = new SubscriptionScheduleService(this.StripeClient);
            service.Update("sub_sched_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestSubscriptionServiceCancel()
        {
            var service = new SubscriptionService(this.StripeClient);
            service.Cancel("sub_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSubscriptionServiceCreate()
        {
            var options = new SubscriptionCreateOptions
            {
                Customer = "cus_xxxxxxxxxxxxx",
                Items = new List<SubscriptionItemOptions>
                {
                    new SubscriptionItemOptions
                    {
                        Price = "price_xxxxxxxxxxxxx",
                    },
                },
            };
            var service = new SubscriptionService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestSubscriptionServiceList()
        {
            var options = new SubscriptionListOptions { Limit = 3 };
            var service = new SubscriptionService(this.StripeClient);
            StripeList<Subscription> subscriptions = service.List(options);
        }

        [Fact]
        public void TestSubscriptionServiceRetrieve()
        {
            var service = new SubscriptionService(this.StripeClient);
            service.Get("sub_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSubscriptionServiceSearch()
        {
            var options = new SubscriptionSearchOptions
            {
                Query = "status:'active' AND metadata['order_id']:'6735'",
            };
            var service = new SubscriptionService(this.StripeClient);
            service.Search(options);
        }

        [Fact]
        public void TestSubscriptionServiceUpdate()
        {
            var options = new SubscriptionUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new SubscriptionService(this.StripeClient);
            service.Update("sub_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestTaxCodeServiceList()
        {
            var options = new TaxCodeListOptions { Limit = 3 };
            var service = new TaxCodeService(this.StripeClient);
            StripeList<TaxCode> taxcodes = service.List(options);
        }

        [Fact]
        public void TestTaxCodeServiceRetrieve()
        {
            var service = new TaxCodeService(this.StripeClient);
            service.Get("txcd_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTaxIdServiceCreate()
        {
            var options = new TaxIdCreateOptions
            {
                Type = "eu_vat",
                Value = "DE123456789",
            };
            var service = new TaxIdService(this.StripeClient);
            service.Create("cus_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestTaxIdServiceDelete()
        {
            var service = new TaxIdService(this.StripeClient);
            service.Delete("cus_xxxxxxxxxxxxx", "txi_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTaxIdServiceList()
        {
            var options = new TaxIdListOptions { Limit = 3 };
            var service = new TaxIdService(this.StripeClient);
            StripeList<TaxId> taxids = service.List(
                "cus_xxxxxxxxxxxxx",
                options);
        }

        [Fact]
        public void TestTaxIdServiceRetrieve()
        {
            var service = new TaxIdService(this.StripeClient);
            service.Get("cus_xxxxxxxxxxxxx", "txi_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTaxRateServiceCreate()
        {
            var options = new TaxRateCreateOptions
            {
                DisplayName = "VAT",
                Description = "VAT Germany",
                Jurisdiction = "DE",
                Percentage = 16m,
                Inclusive = false,
            };
            var service = new TaxRateService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestTaxRateServiceList()
        {
            var options = new TaxRateListOptions { Limit = 3 };
            var service = new TaxRateService(this.StripeClient);
            StripeList<TaxRate> taxrates = service.List(options);
        }

        [Fact]
        public void TestTaxRateServiceRetrieve()
        {
            var service = new TaxRateService(this.StripeClient);
            service.Get("txr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTaxRateServiceUpdate()
        {
            var options = new TaxRateUpdateOptions { Active = false };
            var service = new TaxRateService(this.StripeClient);
            service.Update("txr_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestTerminalConfigurationServiceCreate()
        {
            var options = new Stripe.Terminal.ConfigurationCreateOptions();
            var service = new Stripe.Terminal.ConfigurationService(
                this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestTerminalConfigurationServiceCreate2()
        {
            var options = new Stripe.Terminal.ConfigurationCreateOptions
            {
                BbposWiseposE = new Stripe.Terminal.ConfigurationBbposWiseposEOptions
                {
                    Splashscreen = "file_xxxxxxxxxxxxx",
                },
            };
            var service = new Stripe.Terminal.ConfigurationService(
                this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestTerminalConfigurationServiceDelete()
        {
            var service = new Stripe.Terminal.ConfigurationService(
                this.StripeClient);
            service.Delete("uc_123");
        }

        [Fact]
        public void TestTerminalConfigurationServiceDelete2()
        {
            var service = new Stripe.Terminal.ConfigurationService(
                this.StripeClient);
            service.Delete("tmc_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTerminalConfigurationServiceList()
        {
            var service = new Stripe.Terminal.ConfigurationService(
                this.StripeClient);
            StripeList<Stripe.Terminal.Configuration> configurations = service.List();
        }

        [Fact]
        public void TestTerminalConfigurationServiceList2()
        {
            var options = new Stripe.Terminal.ConfigurationListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Terminal.ConfigurationService(
                this.StripeClient);
            StripeList<Stripe.Terminal.Configuration> configurations = service.List(
                options);
        }

        [Fact]
        public void TestTerminalConfigurationServiceRetrieve()
        {
            var service = new Stripe.Terminal.ConfigurationService(
                this.StripeClient);
            service.Get("uc_123");
        }

        [Fact]
        public void TestTerminalConfigurationServiceRetrieve2()
        {
            var service = new Stripe.Terminal.ConfigurationService(
                this.StripeClient);
            service.Get("tmc_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTerminalConfigurationServiceUpdate()
        {
            var options = new Stripe.Terminal.ConfigurationUpdateOptions
            {
                Tipping = new Stripe.Terminal.ConfigurationTippingOptions
                {
                    Usd = new Stripe.Terminal.ConfigurationTippingUsdOptions
                    {
                        FixedAmounts = new List<long?> { 10 },
                    },
                },
            };
            var service = new Stripe.Terminal.ConfigurationService(
                this.StripeClient);
            service.Update("uc_123", options);
        }

        [Fact]
        public void TestTerminalConfigurationServiceUpdate2()
        {
            var options = new Stripe.Terminal.ConfigurationUpdateOptions
            {
                BbposWiseposE = new Stripe.Terminal.ConfigurationBbposWiseposEOptions
                {
                    Splashscreen = "file_xxxxxxxxxxxxx",
                },
            };
            var service = new Stripe.Terminal.ConfigurationService(
                this.StripeClient);
            service.Update("tmc_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestTerminalLocationServiceCreate()
        {
            var options = new Stripe.Terminal.LocationCreateOptions
            {
                DisplayName = "My First Store",
                Address = new AddressOptions
                {
                    Line1 = "1234 Main Street",
                    City = "San Francisco",
                    PostalCode = "94111",
                    State = "CA",
                    Country = "US",
                },
            };
            var service = new Stripe.Terminal.LocationService(
                this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestTerminalLocationServiceDelete()
        {
            var service = new Stripe.Terminal.LocationService(
                this.StripeClient);
            service.Delete("tml_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTerminalLocationServiceList()
        {
            var options = new Stripe.Terminal.LocationListOptions { Limit = 3 };
            var service = new Stripe.Terminal.LocationService(
                this.StripeClient);
            StripeList<Stripe.Terminal.Location> locations = service.List(
                options);
        }

        [Fact]
        public void TestTerminalLocationServiceRetrieve()
        {
            var service = new Stripe.Terminal.LocationService(
                this.StripeClient);
            service.Get("tml_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTerminalLocationServiceUpdate()
        {
            var options = new Stripe.Terminal.LocationUpdateOptions
            {
                DisplayName = "My First Store",
            };
            var service = new Stripe.Terminal.LocationService(
                this.StripeClient);
            service.Update("tml_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestTerminalReaderServiceCancelAction()
        {
            var service = new Stripe.Terminal.ReaderService(this.StripeClient);
            service.CancelAction("tmr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTerminalReaderServiceCreate()
        {
            var options = new Stripe.Terminal.ReaderCreateOptions
            {
                RegistrationCode = "puppies-plug-could",
                Label = "Blue Rabbit",
                Location = "tml_1234",
            };
            var service = new Stripe.Terminal.ReaderService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestTerminalReaderServiceDelete()
        {
            var service = new Stripe.Terminal.ReaderService(this.StripeClient);
            service.Delete("tmr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTerminalReaderServiceList()
        {
            var options = new Stripe.Terminal.ReaderListOptions { Limit = 3 };
            var service = new Stripe.Terminal.ReaderService(this.StripeClient);
            StripeList<Stripe.Terminal.Reader> readers = service.List(options);
        }

        [Fact]
        public void TestTerminalReaderServiceProcessPaymentIntent()
        {
            var options = new Stripe.Terminal.ReaderProcessPaymentIntentOptions
            {
                PaymentIntent = "pi_xxxxxxxxxxxxx",
            };
            var service = new Stripe.Terminal.ReaderService(this.StripeClient);
            service.ProcessPaymentIntent("tmr_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestTerminalReaderServiceProcessSetupIntent()
        {
            var options = new Stripe.Terminal.ReaderProcessSetupIntentOptions
            {
                SetupIntent = "seti_xxxxxxxxxxxxx",
                CustomerConsentCollected = true,
            };
            var service = new Stripe.Terminal.ReaderService(this.StripeClient);
            service.ProcessSetupIntent("tmr_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestTerminalReaderServiceRetrieve()
        {
            var service = new Stripe.Terminal.ReaderService(this.StripeClient);
            service.Get("tmr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTerminalReaderServiceUpdate()
        {
            var options = new Stripe.Terminal.ReaderUpdateOptions
            {
                Label = "Blue Rabbit",
            };
            var service = new Stripe.Terminal.ReaderService(this.StripeClient);
            service.Update("tmr_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestTestHelpersTestClockServiceAdvance()
        {
            var options = new Stripe.TestHelpers.TestClockAdvanceOptions
            {
                FrozenTime = DateTimeOffset.FromUnixTimeSeconds(142)
                    .UtcDateTime,
            };
            var service = new Stripe.TestHelpers.TestClockService(
                this.StripeClient);
            service.Advance("clock_xyz", options);
        }

        [Fact]
        public void TestTestHelpersTestClockServiceAdvance2()
        {
            var options = new Stripe.TestHelpers.TestClockAdvanceOptions
            {
                FrozenTime = DateTimeOffset.FromUnixTimeSeconds(1675552261)
                    .UtcDateTime,
            };
            var service = new Stripe.TestHelpers.TestClockService(
                this.StripeClient);
            service.Advance("clock_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestTestHelpersTestClockServiceCreate()
        {
            var options = new Stripe.TestHelpers.TestClockCreateOptions
            {
                FrozenTime = DateTimeOffset.FromUnixTimeSeconds(123)
                    .UtcDateTime,
                Name = "cogsworth",
            };
            var service = new Stripe.TestHelpers.TestClockService(
                this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestTestHelpersTestClockServiceCreate2()
        {
            var options = new Stripe.TestHelpers.TestClockCreateOptions
            {
                FrozenTime = DateTimeOffset.FromUnixTimeSeconds(1577836800)
                    .UtcDateTime,
            };
            var service = new Stripe.TestHelpers.TestClockService(
                this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestTestHelpersTestClockServiceDelete()
        {
            var service = new Stripe.TestHelpers.TestClockService(
                this.StripeClient);
            service.Delete("clock_xyz");
        }

        [Fact]
        public void TestTestHelpersTestClockServiceDelete2()
        {
            var service = new Stripe.TestHelpers.TestClockService(
                this.StripeClient);
            service.Delete("clock_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTestHelpersTestClockServiceList()
        {
            var service = new Stripe.TestHelpers.TestClockService(
                this.StripeClient);
            StripeList<Stripe.TestHelpers.TestClock> testclocks = service.List();
        }

        [Fact]
        public void TestTestHelpersTestClockServiceList2()
        {
            var options = new Stripe.TestHelpers.TestClockListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.TestHelpers.TestClockService(
                this.StripeClient);
            StripeList<Stripe.TestHelpers.TestClock> testclocks = service.List(
                options);
        }

        [Fact]
        public void TestTestHelpersTestClockServiceRetrieve()
        {
            var service = new Stripe.TestHelpers.TestClockService(
                this.StripeClient);
            service.Get("clock_xyz");
        }

        [Fact]
        public void TestTestHelpersTestClockServiceRetrieve2()
        {
            var service = new Stripe.TestHelpers.TestClockService(
                this.StripeClient);
            service.Get("clock_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTokenServiceRetrieve()
        {
            var service = new TokenService(this.StripeClient);
            service.Get("tok_xxxx");
        }

        [Fact]
        public void TestTopupServiceCancel()
        {
            var service = new TopupService(this.StripeClient);
            service.Cancel("tu_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTopupServiceCreate()
        {
            var options = new TopupCreateOptions
            {
                Amount = 2000,
                Currency = "usd",
                Description = "Top-up for Jenny Rosen",
                StatementDescriptor = "Top-up",
            };
            var service = new TopupService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestTopupServiceList()
        {
            var options = new TopupListOptions { Limit = 3 };
            var service = new TopupService(this.StripeClient);
            StripeList<Topup> topups = service.List(options);
        }

        [Fact]
        public void TestTopupServiceRetrieve()
        {
            var service = new TopupService(this.StripeClient);
            service.Get("tu_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTopupServiceUpdate()
        {
            var options = new TopupUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new TopupService(this.StripeClient);
            service.Update("tu_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestTransferReversalServiceCreate()
        {
            var options = new TransferReversalCreateOptions { Amount = 100 };
            var service = new TransferReversalService(this.StripeClient);
            service.Create("tr_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestTransferReversalServiceList()
        {
            var options = new TransferReversalListOptions { Limit = 3 };
            var service = new TransferReversalService(this.StripeClient);
            StripeList<TransferReversal> transferreversals = service.List(
                "tr_xxxxxxxxxxxxx",
                options);
        }

        [Fact]
        public void TestTransferReversalServiceRetrieve()
        {
            var service = new TransferReversalService(this.StripeClient);
            service.Get("tr_xxxxxxxxxxxxx", "trr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTransferReversalServiceUpdate()
        {
            var options = new TransferReversalUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new TransferReversalService(this.StripeClient);
            service.Update("tr_xxxxxxxxxxxxx", "trr_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestTransferServiceCreate()
        {
            var options = new TransferCreateOptions
            {
                Amount = 400,
                Currency = "usd",
                Destination = "acct_xxxxxxxxxxxxx",
                TransferGroup = "ORDER_95",
            };
            var service = new TransferService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestTransferServiceList()
        {
            var options = new TransferListOptions { Limit = 3 };
            var service = new TransferService(this.StripeClient);
            StripeList<Transfer> transfers = service.List(options);
        }

        [Fact]
        public void TestTransferServiceRetrieve()
        {
            var service = new TransferService(this.StripeClient);
            service.Get("tr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTransferServiceUpdate()
        {
            var options = new TransferUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new TransferService(this.StripeClient);
            service.Update("tr_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestTreasuryCreditReversalServiceCreate()
        {
            var options = new Stripe.Treasury.CreditReversalCreateOptions
            {
                ReceivedCredit = "rc_xxxxxxxxxxxxx",
            };
            var service = new Stripe.Treasury.CreditReversalService(
                this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestTreasuryCreditReversalServiceList()
        {
            var options = new Stripe.Treasury.CreditReversalListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.CreditReversalService(
                this.StripeClient);
            StripeList<Stripe.Treasury.CreditReversal> creditreversals = service.List(
                options);
        }

        [Fact]
        public void TestTreasuryCreditReversalServiceRetrieve()
        {
            var service = new Stripe.Treasury.CreditReversalService(
                this.StripeClient);
            service.Get("credrev_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTreasuryDebitReversalServiceCreate()
        {
            var options = new Stripe.Treasury.DebitReversalCreateOptions
            {
                ReceivedDebit = "rd_xxxxxxxxxxxxx",
            };
            var service = new Stripe.Treasury.DebitReversalService(
                this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestTreasuryDebitReversalServiceList()
        {
            var options = new Stripe.Treasury.DebitReversalListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.DebitReversalService(
                this.StripeClient);
            StripeList<Stripe.Treasury.DebitReversal> debitreversals = service.List(
                options);
        }

        [Fact]
        public void TestTreasuryDebitReversalServiceRetrieve()
        {
            var service = new Stripe.Treasury.DebitReversalService(
                this.StripeClient);
            service.Get("debrev_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTreasuryFinancialAccountServiceCreate()
        {
            var options = new Stripe.Treasury.FinancialAccountCreateOptions
            {
                SupportedCurrencies = new List<string> { "usd" },
                Features = new Stripe.Treasury.FinancialAccountFeaturesOptions(),
            };
            var service = new Stripe.Treasury.FinancialAccountService(
                this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestTreasuryFinancialAccountServiceList()
        {
            var options = new Stripe.Treasury.FinancialAccountListOptions
            {
                Limit = 3,
            };
            var service = new Stripe.Treasury.FinancialAccountService(
                this.StripeClient);
            StripeList<Stripe.Treasury.FinancialAccount> financialaccounts = service.List(
                options);
        }

        [Fact]
        public void TestTreasuryFinancialAccountServiceRetrieve()
        {
            var service = new Stripe.Treasury.FinancialAccountService(
                this.StripeClient);
            service.Get("fa_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTreasuryFinancialAccountServiceRetrieveFeatures()
        {
            var service = new Stripe.Treasury.FinancialAccountService(
                this.StripeClient);
            service.RetrieveFeatures("fa_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTreasuryFinancialAccountServiceUpdate()
        {
            var options = new Stripe.Treasury.FinancialAccountUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new Stripe.Treasury.FinancialAccountService(
                this.StripeClient);
            service.Update("fa_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestTreasuryInboundTransferServiceCancel()
        {
            var service = new Stripe.Treasury.InboundTransferService(
                this.StripeClient);
            service.Cancel("ibt_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTreasuryInboundTransferServiceCreate()
        {
            var options = new Stripe.Treasury.InboundTransferCreateOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Amount = 10000,
                Currency = "usd",
                OriginPaymentMethod = "pm_xxxxxxxxxxxxx",
                Description = "InboundTransfer from my bank account",
            };
            var service = new Stripe.Treasury.InboundTransferService(
                this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestTreasuryInboundTransferServiceFail()
        {
            var options = new Stripe.TestHelpers.Treasury.InboundTransferFailOptions
            {
                FailureDetails = new Stripe.TestHelpers.Treasury.InboundTransferFailureDetailsOptions
                {
                    Code = "account_closed",
                },
            };
            var service = new Stripe.TestHelpers.Treasury.InboundTransferService(
                this.StripeClient);
            service.Fail("ibt_123", options);
        }

        [Fact]
        public void TestTreasuryInboundTransferServiceList()
        {
            var options = new Stripe.Treasury.InboundTransferListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.InboundTransferService(
                this.StripeClient);
            StripeList<Stripe.Treasury.InboundTransfer> inboundtransfers = service.List(
                options);
        }

        [Fact]
        public void TestTreasuryInboundTransferServiceRetrieve()
        {
            var service = new Stripe.Treasury.InboundTransferService(
                this.StripeClient);
            service.Get("ibt_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTreasuryInboundTransferServiceReturnInboundTransfer()
        {
            var service = new Stripe.TestHelpers.Treasury.InboundTransferService(
                this.StripeClient);
            service.ReturnInboundTransfer("ibt_123");
        }

        [Fact]
        public void TestTreasuryInboundTransferServiceSucceed()
        {
            var service = new Stripe.TestHelpers.Treasury.InboundTransferService(
                this.StripeClient);
            service.Succeed("ibt_123");
        }

        [Fact]
        public void TestTreasuryOutboundPaymentServiceCancel()
        {
            var service = new Stripe.Treasury.OutboundPaymentService(
                this.StripeClient);
            service.Cancel("bot_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTreasuryOutboundPaymentServiceCreate()
        {
            var options = new Stripe.Treasury.OutboundPaymentCreateOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Amount = 10000,
                Currency = "usd",
                Customer = "cus_xxxxxxxxxxxxx",
                DestinationPaymentMethod = "pm_xxxxxxxxxxxxx",
                Description = "OutboundPayment to a 3rd party",
            };
            var service = new Stripe.Treasury.OutboundPaymentService(
                this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestTreasuryOutboundPaymentServiceList()
        {
            var options = new Stripe.Treasury.OutboundPaymentListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.OutboundPaymentService(
                this.StripeClient);
            StripeList<Stripe.Treasury.OutboundPayment> outboundpayments = service.List(
                options);
        }

        [Fact]
        public void TestTreasuryOutboundPaymentServiceRetrieve()
        {
            var service = new Stripe.Treasury.OutboundPaymentService(
                this.StripeClient);
            service.Get("bot_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTreasuryOutboundTransferServiceCancel()
        {
            var service = new Stripe.Treasury.OutboundTransferService(
                this.StripeClient);
            service.Cancel("obt_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTreasuryOutboundTransferServiceCreate()
        {
            var options = new Stripe.Treasury.OutboundTransferCreateOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                DestinationPaymentMethod = "pm_xxxxxxxxxxxxx",
                Amount = 500,
                Currency = "usd",
                Description = "OutboundTransfer to my external bank account",
            };
            var service = new Stripe.Treasury.OutboundTransferService(
                this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestTreasuryOutboundTransferServiceFail()
        {
            var service = new Stripe.TestHelpers.Treasury.OutboundTransferService(
                this.StripeClient);
            service.Fail("obt_123");
        }

        [Fact]
        public void TestTreasuryOutboundTransferServiceList()
        {
            var options = new Stripe.Treasury.OutboundTransferListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.OutboundTransferService(
                this.StripeClient);
            StripeList<Stripe.Treasury.OutboundTransfer> outboundtransfers = service.List(
                options);
        }

        [Fact]
        public void TestTreasuryOutboundTransferServicePost()
        {
            var service = new Stripe.TestHelpers.Treasury.OutboundTransferService(
                this.StripeClient);
            service.Post("obt_123");
        }

        [Fact]
        public void TestTreasuryOutboundTransferServiceRetrieve()
        {
            var service = new Stripe.Treasury.OutboundTransferService(
                this.StripeClient);
            service.Get("obt_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTreasuryOutboundTransferServiceReturnOutboundTransfer()
        {
            var options = new Stripe.TestHelpers.Treasury.OutboundTransferReturnOutboundTransferOptions
            {
                ReturnedDetails = new Stripe.TestHelpers.Treasury.OutboundTransferReturnedDetailsOptions
                {
                    Code = "account_closed",
                },
            };
            var service = new Stripe.TestHelpers.Treasury.OutboundTransferService(
                this.StripeClient);
            service.ReturnOutboundTransfer("obt_123", options);
        }

        [Fact]
        public void TestTreasuryReceivedCreditServiceCreate()
        {
            var options = new Stripe.TestHelpers.Treasury.ReceivedCreditCreateOptions
            {
                FinancialAccount = "fa_123",
                Network = "ach",
                Amount = 1234,
                Currency = "usd",
            };
            var service = new Stripe.TestHelpers.Treasury.ReceivedCreditService(
                this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestTreasuryReceivedCreditServiceList()
        {
            var options = new Stripe.Treasury.ReceivedCreditListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.ReceivedCreditService(
                this.StripeClient);
            StripeList<Stripe.Treasury.ReceivedCredit> receivedcredits = service.List(
                options);
        }

        [Fact]
        public void TestTreasuryReceivedCreditServiceRetrieve()
        {
            var service = new Stripe.Treasury.ReceivedCreditService(
                this.StripeClient);
            service.Get("rc_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTreasuryReceivedDebitServiceCreate()
        {
            var options = new Stripe.TestHelpers.Treasury.ReceivedDebitCreateOptions
            {
                FinancialAccount = "fa_123",
                Network = "ach",
                Amount = 1234,
                Currency = "usd",
            };
            var service = new Stripe.TestHelpers.Treasury.ReceivedDebitService(
                this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestTreasuryReceivedDebitServiceList()
        {
            var options = new Stripe.Treasury.ReceivedDebitListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.ReceivedDebitService(
                this.StripeClient);
            StripeList<Stripe.Treasury.ReceivedDebit> receiveddebits = service.List(
                options);
        }

        [Fact]
        public void TestTreasuryReceivedDebitServiceRetrieve()
        {
            var service = new Stripe.Treasury.ReceivedDebitService(
                this.StripeClient);
            service.Get("rd_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTreasuryTransactionEntryServiceList()
        {
            var options = new Stripe.Treasury.TransactionEntryListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.TransactionEntryService(
                this.StripeClient);
            StripeList<Stripe.Treasury.TransactionEntry> transactionentries = service.List(
                options);
        }

        [Fact]
        public void TestTreasuryTransactionEntryServiceRetrieve()
        {
            var service = new Stripe.Treasury.TransactionEntryService(
                this.StripeClient);
            service.Get("trxne_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTreasuryTransactionServiceList()
        {
            var options = new Stripe.Treasury.TransactionListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var service = new Stripe.Treasury.TransactionService(
                this.StripeClient);
            StripeList<Stripe.Treasury.Transaction> transactions = service.List(
                options);
        }

        [Fact]
        public void TestTreasuryTransactionServiceRetrieve()
        {
            var service = new Stripe.Treasury.TransactionService(
                this.StripeClient);
            service.Get("trxn_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestUsageRecordSummaryServiceList()
        {
            var options = new UsageRecordSummaryListOptions { Limit = 3 };
            var service = new UsageRecordSummaryService(this.StripeClient);
            StripeList<UsageRecordSummary> usagerecordsummaries = service.List(
                "si_xxxxxxxxxxxxx",
                options);
        }

        [Fact]
        public void TestWebhookEndpointServiceCreate()
        {
            var options = new WebhookEndpointCreateOptions
            {
                Url = "https://example.com/my/webhook/endpoint",
                EnabledEvents = new List<string>
                {
                    "charge.failed",
                    "charge.succeeded",
                },
            };
            var service = new WebhookEndpointService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestWebhookEndpointServiceDelete()
        {
            var service = new WebhookEndpointService(this.StripeClient);
            service.Delete("we_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestWebhookEndpointServiceList()
        {
            var options = new WebhookEndpointListOptions { Limit = 3 };
            var service = new WebhookEndpointService(this.StripeClient);
            StripeList<WebhookEndpoint> webhookendpoints = service.List(
                options);
        }

        [Fact]
        public void TestWebhookEndpointServiceRetrieve()
        {
            var service = new WebhookEndpointService(this.StripeClient);
            service.Get("we_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestWebhookEndpointServiceUpdate()
        {
            var options = new WebhookEndpointUpdateOptions
            {
                Url = "https://example.com/new_endpoint",
            };
            var service = new WebhookEndpointService(this.StripeClient);
            service.Update("we_xxxxxxxxxxxxx", options);
        }
    }
}
