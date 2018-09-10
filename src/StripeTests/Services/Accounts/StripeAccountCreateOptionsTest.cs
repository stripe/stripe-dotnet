namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Stripe.Infrastructure;
    using Xunit;

    public class StripeAccountCreateOptionsTest : BaseStripeTest
    {
        private StripeAccountService service;

        public StripeAccountCreateOptionsTest()
        {
            this.service = new StripeAccountService();
        }

        [Fact]
        public void SerializeAdditionalOwnersProperly()
        {
            var options = new StripeAccountCreateOptions
            {
                LegalEntity = new StripeAccountLegalEntityOptions
                {
                    AdditionalOwners = new List<StripeAccountAdditionalOwner>
                    {
                        new StripeAccountAdditionalOwner
                        {
                            FirstName = "John",
                            LastName = "Doe",
                            BirthDay = 1,
                            BirthMonth = 1,
                            BirthYear = 1980,
                            VerificationDocument = "file_123",
                            VerificationDocumentBack = "file_234",
                        },
                        new StripeAccountAdditionalOwner
                        {
                            FirstName = "Jenny",
                            LastName = "Rosen",
                            State = "CA",
                            CityOrTown = "City",
                            Line1 = "Line1",
                            Line2 = "Line2",
                            PostalCode = "90210",
                            Country = "US",
                        }
                    },
                },
            };

            var url = this.service.ApplyAllParameters(options, string.Empty, false);
            Assert.Equal(
                "?legal_entity[additional_owners][0][dob][day]=1" +
                "&legal_entity[additional_owners][0][dob][month]=1" +
                "&legal_entity[additional_owners][0][dob][year]=1980" +
                "&legal_entity[additional_owners][0][first_name]=John" +
                "&legal_entity[additional_owners][0][last_name]=Doe" +
                "&legal_entity[additional_owners][0][verification][document]=file_123" +
                "&legal_entity[additional_owners][0][verification][document_back]=file_234" +
                "&legal_entity[additional_owners][1][address][city]=City" +
                "&legal_entity[additional_owners][1][address][country]=US" +
                "&legal_entity[additional_owners][1][address][line1]=Line1" +
                "&legal_entity[additional_owners][1][address][line2]=Line2" +
                "&legal_entity[additional_owners][1][address][postal_code]=90210" +
                "&legal_entity[additional_owners][1][address][state]=CA" +
                "&legal_entity[additional_owners][1][first_name]=Jenny" +
                "&legal_entity[additional_owners][1][last_name]=Rosen",
                url);
        }

        [Fact]
        public void SerializeEmptyAdditionalOwnersProperly()
        {
            var options = new StripeAccountCreateOptions
            {
                LegalEntity = new StripeAccountLegalEntityOptions
                {
                    AdditionalOwners = new List<StripeAccountAdditionalOwner>()
                },
            };

            var url = this.service.ApplyAllParameters(options, string.Empty, false);
            Assert.Equal("?legal_entity[additional_owners]=", url);
        }
    }
}
