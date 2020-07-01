namespace StripeTests
{
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class PersonServiceTest : BaseStripeTest
    {
        private const string AccountId = "acct_123";
        private const string PersonId = "person_123";

        private readonly PersonService service;
        private readonly PersonCreateOptions createOptions;
        private readonly PersonUpdateOptions updateOptions;
        private readonly PersonListOptions listOptions;

        public PersonServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new PersonService(this.StripeClient);

            this.createOptions = new PersonCreateOptions
            {
                FirstName = "John",
                Relationship = new PersonRelationshipOptions
                {
                    Owner = true,
                    PercentOwnership = 30.5m,
                    Representative = true,
                },
                Verification = new PersonVerificationOptions
                {
                    AdditionalDocument = new PersonVerificationDocumentOptions
                    {
                        Back = "file_abc",
                        Front = "file_def",
                    },
                    Document = new PersonVerificationDocumentOptions
                    {
                        Back = "file_123",
                        Front = "file_345",
                    },
                },
            };

            this.updateOptions = new PersonUpdateOptions
            {
                FirstName = "John",
                Relationship = new PersonRelationshipOptions
                {
                    Owner = true,
                    PercentOwnership = 30.5m,
                    Representative = true,
                },
            };

            this.listOptions = new PersonListOptions
            {
                Limit = 1,
                Relationship = new PersonRelationshipListOptions
                {
                    Director = true,
                },
            };
        }

        [Fact]
        public void Create()
        {
            var person = this.service.Create(AccountId, this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/accounts/acct_123/persons");
            Assert.NotNull(person);
            Assert.Equal("person", person.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var person = await this.service.CreateAsync(AccountId, this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/accounts/acct_123/persons");
            Assert.NotNull(person);
            Assert.Equal("person", person.Object);
        }

        [Fact]
        public void Delete()
        {
            var person = this.service.Delete(AccountId, PersonId);
            this.AssertRequest(HttpMethod.Delete, "/v1/accounts/acct_123/persons/person_123");
            Assert.NotNull(person);
            Assert.Equal("person", person.Object);
        }

        [Fact]
        public async Task DeleteAsync()
        {
            var person = await this.service.DeleteAsync(AccountId, PersonId);
            this.AssertRequest(HttpMethod.Delete, "/v1/accounts/acct_123/persons/person_123");
            Assert.NotNull(person);
            Assert.Equal("person", person.Object);
        }

        [Fact]
        public void Get()
        {
            var person = this.service.Get(AccountId, PersonId);
            this.AssertRequest(HttpMethod.Get, "/v1/accounts/acct_123/persons/person_123");
            Assert.NotNull(person);
            Assert.Equal("person", person.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var person = await this.service.GetAsync(AccountId, PersonId);
            this.AssertRequest(HttpMethod.Get, "/v1/accounts/acct_123/persons/person_123");
            Assert.NotNull(person);
            Assert.Equal("person", person.Object);
        }

        [Fact]
        public void List()
        {
            var persons = this.service.List(AccountId, this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/accounts/acct_123/persons");
            Assert.NotNull(persons);
            Assert.Equal("list", persons.Object);
            Assert.Single(persons.Data);
            Assert.Equal("person", persons.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var persons = await this.service.ListAsync(AccountId, this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/accounts/acct_123/persons");
            Assert.NotNull(persons);
            Assert.Equal("list", persons.Object);
            Assert.Single(persons.Data);
            Assert.Equal("person", persons.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var person = this.service.ListAutoPaging(AccountId, this.listOptions).First();
            Assert.NotNull(person);
            Assert.Equal("person", person.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var person = await this.service.ListAutoPagingAsync(AccountId, this.listOptions).FirstAsync();
            Assert.NotNull(person);
            Assert.Equal("person", person.Object);
        }

        [Fact]
        public void Update()
        {
            var person = this.service.Update(AccountId, PersonId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/accounts/acct_123/persons/person_123");
            Assert.NotNull(person);
            Assert.Equal("person", person.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var person = await this.service.UpdateAsync(AccountId, PersonId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/accounts/acct_123/persons/person_123");
            Assert.NotNull(person);
            Assert.Equal("person", person.Object);
        }
    }
}
