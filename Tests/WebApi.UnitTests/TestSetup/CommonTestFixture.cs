using AutoMapper;
using DAL.Concrete;
using Microsoft.EntityFrameworkCore;
using System; 

namespace WebApi.UnitTests.TestSetup
{
    public class CommonTestFixture
    {
        public IMapper Mapper { get; set; }
        public CommonTestFixture()
        {
        }     
    }
}