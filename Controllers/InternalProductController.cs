namespace NswagMultipleDocuments;

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]/[action]")]
public class InternalProductController
{
    [HttpGet]
    public long Count() => 100;
}