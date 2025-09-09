using Microsoft.AspNetCore.Mvc;

namespace Links.Api.Links;


// Whenever a POST comes in for "/links" create an instance of this class
public class LinksController : ControllerBase
{
    // Shortcut for errors - Click on error hit ctrl+.(period)

    // "Flag a marker on this method that the Api will read and know this is where POSTs to "/links" should be directed
    [HttpPost("/links")]
    public async Task<ActionResult> AddALink(
        [FromBody] CreateLinkRequest request)
    {

        var response = new CreateLinkResponse
        {
            Id = Guid.NewGuid(),
            Href = request.Href,
            Description = request.Description,
            AddedBy = "Arra@aol.com",
            Created = DateTimeOffset.Now,
        };

        return Ok(response); // = return new OkObjectResult("good"); but with ControllerBase makes it simple as you can see
    }
}

// DTO - Data Transfer Object
public record CreateLinkRequest
{
    public string Href { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}


public record CreateLinkResponse
{
    // uuid
    public Guid Id { get; set; } = Guid.Empty;
    public string Href { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string AddedBy { get; set; } = string.Empty;
    public DateTimeOffset Created { get; set; }
}
