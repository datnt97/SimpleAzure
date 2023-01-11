using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers;

[Route("api/[controller]")]
public class ValuesController : ControllerBase
{
	[HttpGet]
	public ActionResult<IEnumerable<string>> Get()
	{
		return new List<string>();
		//{ "value 1", "value 2" };
	}

	[HttpGet("{id}")]
	public ActionResult<string> Get(int id)
	{
		return "Simple string";
	}

	[HttpPost]
	public ActionResult<IEnumerable<string>> Post([FromBody] string value)
	{
		List<string> values = new List<string>();
		//{
		//	"value 1",
		//	"value 2",
		//	value
		//};

		return values;
	}
}