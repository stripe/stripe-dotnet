namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class CustomerBankAccountTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/customers/cus_123/bank_accounts/ba_123");
            var bankAccount = Mapper<CustomerBankAccount>.MapFromJson(json);
            Assert.NotNull(bankAccount);
            Assert.IsType<CustomerBankAccount>(bankAccount);
            Assert.NotNull(bankAccount.Id);
            Assert.Equal("bank_account", bankAccount.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "customer",
            };

            string json = GetFixture("/v1/customers/cus_123/bank_accounts/ba_123", expansions);
            var bankAccount = Mapper<CustomerBankAccount>.MapFromJson(json);
            Assert.NotNull(bankAccount);
            Assert.IsType<CustomerBankAccount>(bankAccount);
            Assert.NotNull(bankAccount.Id);
            Assert.Equal("bank_account", bankAccount.Object);

            Assert.NotNull(bankAccount.Customer);
            Assert.Equal("customer", bankAccount.Customer.Object);
        }
    }
}
