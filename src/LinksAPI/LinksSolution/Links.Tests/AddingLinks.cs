
using Alba;

namespace Links.Tests;
public class AddingLinks
{
    [Fact]
    public async Task AddingALinkReturnA200()
    {

        // this is low rent better way tmrw
        //var client = new HttpClient();
        //client.BaseAddress = new Uri("http://localhost:1337");

        //var response = await client.PostAsJsonAsync("/links", new { });

        //Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        // this will start up (host) my API for me in this test
        var host = await AlbaHost.For<Program>();

        // given I post this data to this API then this should happen
        await host.Scenario(api =>
        {
            api.Post.Json(new { }).ToUrl("/links");
            api.StatusCodeShouldBeOk();


        });




    }
}
