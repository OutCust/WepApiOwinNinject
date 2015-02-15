using System.Web.Http;
using System.Web.Script.Serialization;
using WepApiOwinNinject.Interfaces;

namespace WepApiOwinNinject.Controllers
{
	[RoutePrefix("api/home")]
	public class HomeController : ApiController
	{
		private readonly IFakeService _fakeService;

		public HomeController(IFakeService fakeService)
		{
			_fakeService = fakeService;
		}

		[Route("")]
		public IHttpActionResult Index(string question)
		{
			var jsonSerialiser = new JavaScriptSerializer();
			if (_fakeService.GetAnswer(question))
				return Ok();

			return BadRequest(jsonSerialiser.Serialize("This is not a question."));
		}
	}
}