using Microsoft.AspNetCore.Mvc;

namespace Links.Api.Links;


// Whenever a POST comes in for "/links" create an instance of this class
public class LinksController : ControllerBase
{
    // Shortcut for errors - Click on error hit ctrl+.(period)

    // "Flag a marker on this method that the Api will read and know this is where POSTs to "/links" should be directed
    [HttpPost("/links")]
    public async Task<ActionResult> AddALink()
    {
        return this.Ok(); // = return new OkObjectResult("good"); but with ControllerBase makes it simple as you can see
    }
}
