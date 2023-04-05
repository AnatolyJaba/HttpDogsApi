using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HttpDogsApi.Controllers
{
	[Route("httpdog/{file}")]
	[ApiController]
	public class DogsApiController : ControllerBase
	{
		[HttpGet]
		public IActionResult Get(string file)
		{
			Byte[] image = System.IO.File.ReadAllBytes(@$"wwwroot\img\{file}");        
			return File(image, "image/jpeg");
		}
	}
}
