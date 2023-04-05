using Microsoft.AspNetCore.Mvc;

namespace HttpDogsApi.Controllers
{
	public class DogsController : Controller
	{
		public IActionResult Index(int code)
		{
			string baseString = $"https://localhost:7257/httpdog/{code}.jpg";
			return View((object)baseString);
		}
	}
}
