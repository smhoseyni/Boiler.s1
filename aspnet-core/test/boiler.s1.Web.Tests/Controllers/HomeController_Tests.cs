using System.Threading.Tasks;
using boiler.s1.Models.TokenAuth;
using boiler.s1.Web.Controllers;
using Shouldly;
using Xunit;

namespace boiler.s1.Web.Tests.Controllers
{
    public class HomeController_Tests: s1WebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}