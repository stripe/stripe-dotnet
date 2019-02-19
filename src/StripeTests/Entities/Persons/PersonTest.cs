namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class PersonTest : BaseStripeTest
    {
        public PersonTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/accounts/acct_123/persons/person_123");
            var person = JsonConvert.DeserializeObject<Person>(json);
            Assert.NotNull(person);
            Assert.IsType<Person>(person);
            Assert.NotNull(person.Id);
            Assert.Equal("person", person.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "verification.document.back",
              "verification.document.front",
            };

            string json = this.GetFixture("/v1/accounts/acct_123/persons/person_123", expansions);
            var person = JsonConvert.DeserializeObject<Person>(json);
            Assert.NotNull(person);
            Assert.IsType<Person>(person);
            Assert.NotNull(person.Id);
            Assert.Equal("person", person.Object);

            Assert.NotNull(person.Verification.Document.Back);
            Assert.Equal("file", person.Verification.Document.Back.Object);

            Assert.NotNull(person.Verification.Document.Front);
            Assert.Equal("file", person.Verification.Document.Front.Object);
        }
    }
}
