namespace StripeTests
{
    using Stripe;
    using Stripe.Infrastructure.FormEncoding;
    using Xunit;

    public class AccountCreateOptionsTest : BaseStripeTest
    {
        [Fact]
        public void Serialize()
        {
            var options = new AccountCreateOptions
            {
                Individual = new PersonCreateOptions
                {
                    FirstName = "first name",
                    LastName = "last name",
                },
            };

            Assert.Equal(
                "individual[first_name]=first+name&individual[last_name]=last+name",
                FormEncoder.CreateQueryString(options));
        }
    }
}
