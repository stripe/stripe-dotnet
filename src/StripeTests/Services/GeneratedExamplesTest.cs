// File generated from our OpenAPI spec
namespace StripeTests
{
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
                Description = "My First Test Charge (created for API docs)",
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
                PercentOff = 25,
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
            service.Delete("co_xxxxxxxxxxxxx");
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
            service.Get("25_5OFF");
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
            service.Update("co_xxxxxxxxxxxxx", options);
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
        public void TestCreditNoteServicePreview2()
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
        public void TestCreditNoteServiceRetrieve()
        {
            var service = new CreditNoteService(this.StripeClient);
            service.Get("cn_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestCreditNoteServiceUpdate()
        {
            var options = new CreditNoteUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new CreditNoteService(this.StripeClient);
            service.Update("cn_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestCreditNoteServiceVoidCreditNote()
        {
            var service = new CreditNoteService(this.StripeClient);
            service.VoidCreditNote("cn_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestCustomerServiceCreate()
        {
            var options = new CustomerCreateOptions
            {
                Description = "My First Test Customer (created for API docs)",
            };
            var service = new CustomerService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestCustomerServiceDelete()
        {
            var service = new CustomerService(this.StripeClient);
            service.Delete("cus_xxxxxxxxxxxxx");
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
        public void TestCustomerServiceRetrieve()
        {
            var service = new CustomerService(this.StripeClient);
            service.Get("cus_xxxxxxxxxxxxx");
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
        public void TestInvoiceServiceSendInvoice()
        {
            var service = new InvoiceService(this.StripeClient);
            service.SendInvoice("in_xxxxxxxxxxxxx");
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
        public void TestMandateServiceRetrieve()
        {
            var service = new MandateService(this.StripeClient);
            service.Get("mandate_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestOrderServiceCreate()
        {
            var options = new OrderCreateOptions
            {
                Currency = "usd",
                Email = "jenny.rosen@example.com",
                Items = new List<OrderItemOptions>
                {
                    new OrderItemOptions
                    {
                        Type = "sku",
                        Parent = "sku_xxxxxxxxxxxxx",
                    },
                },
                Shipping = new ShippingOptions
                {
                    Name = "Jenny Rosen",
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
            var service = new OrderService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestOrderServiceList()
        {
            var options = new OrderListOptions { Limit = 3 };
            var service = new OrderService(this.StripeClient);
            StripeList<Order> orders = service.List(options);
        }

        [Fact]
        public void TestOrderServicePay()
        {
            var options = new OrderPayOptions { Source = "tok_xxxx" };
            var service = new OrderService(this.StripeClient);
            service.Pay("or_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestOrderServiceRetrieve()
        {
            var service = new OrderService(this.StripeClient);
            service.Get("or_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestOrderServiceUpdate()
        {
            var options = new OrderUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new OrderService(this.StripeClient);
            service.Update("or_xxxxxxxxxxxxx", options);
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
                Amount = 2000,
                Currency = "usd",
                PaymentMethodTypes = new List<string> { "card" },
            };
            var service = new PaymentIntentService(this.StripeClient);
            service.Create(options);
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
                    ExpMonth = 5,
                    ExpYear = 2022,
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
            var options = new PromotionCodeCreateOptions { Coupon = "25_5OFF" };
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
                SetupIntent = "seti_xxxxxxxxxxxxx",
                Limit = 3,
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
        public void TestSkuServiceCreate()
        {
            var options = new SkuCreateOptions
            {
                Attributes = new Dictionary<string, string>
                {
                    { "size", "Medium" },
                    { "gender", "Unisex" },
                },
                Price = 1500,
                Currency = "usd",
                Inventory = new SkuInventoryOptions
                {
                    Type = "finite",
                    Quantity = 500,
                },
                Product = "prod_xxxxxxxxxxxxx",
            };
            var service = new SkuService(this.StripeClient);
            service.Create(options);
        }

        [Fact]
        public void TestSkuServiceDelete()
        {
            var service = new SkuService(this.StripeClient);
            service.Delete("sku_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSkuServiceList()
        {
            var options = new SkuListOptions { Limit = 3 };
            var service = new SkuService(this.StripeClient);
            StripeList<Sku> skus = service.List(options);
        }

        [Fact]
        public void TestSkuServiceRetrieve()
        {
            var service = new SkuService(this.StripeClient);
            service.Get("sku_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSkuServiceUpdate()
        {
            var options = new SkuUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var service = new SkuService(this.StripeClient);
            service.Update("sku_xxxxxxxxxxxxx", options);
        }

        [Fact]
        public void TestSourceServiceRetrieve()
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
        public void TestTaxRateServiceCreate()
        {
            var options = new TaxRateCreateOptions
            {
                DisplayName = "VAT",
                Description = "VAT Germany",
                Jurisdiction = "DE",
                Percentage = 16,
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
