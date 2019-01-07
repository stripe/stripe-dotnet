namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class BankAccountTest : BaseStripeTest
    {
        public BankAccountTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void DeserializeForAccount()
        {
            string json = this.GetFixture("/v1/accounts/acct_123/external_accounts/ba_123");
            var bankAccount = JsonConvert.DeserializeObject<BankAccount>(json);
            Assert.NotNull(bankAccount);
            Assert.IsType<BankAccount>(bankAccount);
            Assert.NotNull(bankAccount.Id);
            Assert.Equal("bank_account", bankAccount.Object);
        }

        [Fact]
        public void DeserializeForCustomer()
        {
            string json = this.GetFixture("/v1/customers/cus_123/bank_accounts/ba_123");
            var bankAccount = JsonConvert.DeserializeObject<BankAccount>(json);
            Assert.NotNull(bankAccount);
            Assert.IsType<BankAccount>(bankAccount);
            Assert.NotNull(bankAccount.Id);
            Assert.Equal("bank_account", bankAccount.Object);
        }

        [Fact]
        public void DeserializeWithExpansionsForCustomer()
        {
            string[] expansions =
            {
              "customer",
            };

            string json = this.GetFixture("/v1/customers/cus_123/bank_accounts/ba_123", expansions);
            var bankAccount = JsonConvert.DeserializeObject<BankAccount>(json);
            Assert.NotNull(bankAccount);
            Assert.IsType<BankAccount>(bankAccount);
            Assert.NotNull(bankAccount.Id);
            Assert.Equal("bank_account", bankAccount.Object);

            Assert.NotNull(bankAccount.Customer);
            Assert.Equal("customer", bankAccount.Customer.Object);
        }
    }
}
