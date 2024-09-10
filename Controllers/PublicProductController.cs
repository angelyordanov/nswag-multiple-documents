namespace NswagMultipleDocuments;

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]/[action]")]
public class PublicProductController
{
    [HttpGet]
    public long Count() => 50;
}
