using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Links.Tests;
public class AddingLinks
{
    [Fact]
    public async Task AddingALinkReturnA200()
    {

        // this is low rent better way tmrw
        var client = new HttpClient();
        client.BaseAddress = new Uri("http://localhost:1337");

        var response = await client.PostAsJsonAsync("/links", new { });

        Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
    }
}
