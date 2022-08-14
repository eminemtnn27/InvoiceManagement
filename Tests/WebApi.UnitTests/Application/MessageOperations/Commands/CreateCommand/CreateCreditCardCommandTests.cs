using AutoMapper;
using DAL.Concrete;
using FluentAssertions;
using System;
using System.Linq;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.Application.CreditCardOperations.Commands.CreateCommand
{
    public class CreateCreditCardCommandTests : IClassFixture<CommonTestFixture>
    { 
        private readonly IMapper _mapper;
        public CreateCreditCardCommandTests(CommonTestFixture testFixture) 
        {  
            _mapper = testFixture.Mapper;
        } 
        [Fact]
        public void WhenAlreadyExistCreditCardTitleIsGiven_InvalidOperationException_ShouldBeRetrn()
        {
            
        }

         
    }

}