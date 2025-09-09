
using Alba;
using Links.Api.Links;

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
        // "Desliming"
        var linkToAdd = new CreateLinkRequest
        {
            Href = "htpps://microsoft.com",
            Description = "yo microsoft"
        };
        var postResponse = await host.Scenario(api =>
        {
            api.Post.Json(linkToAdd).ToUrl("/links");
            api.StatusCodeShouldBe(201); // Created
        });

        var postBody = postResponse.ReadAsJson<CreateLinkResponse>();

        Assert.NotNull(postBody);
        Assert.Equal(linkToAdd.Href, postBody.Href);
        Assert.Equal(linkToAdd.Description, postBody.Description);
        Assert.Equal("Arra@aol.com", postBody.AddedBy); //slime
        //Assert.Equal(DateTimeOffset.Now, postBody.Created, TimeSpan.FromMilliseconds(500)); //kinda slimey
        Assert.NotEqual(Guid.Empty, postBody.Id); //super slimey

        var locationHeader = postResponse.Context.Response.Headers.Location.ToString();
        Assert.NotNull(locationHeader);
        var getResponse = await host.Scenario(api =>
        {
            api.Get.Url(locationHeader);
            api.StatusCodeShouldBeOk(); 

        });

        var getBody = getResponse.ReadAsJson<CreateLinkResponse>();
        Assert.NotNull(getBody);

        Assert.Equal(postBody, getBody);




    }
}
