using SimpleAPI.Controllers;

namespace SimpleAPI.Test;

public partial class UnitTest1
{
	public class ValuesControllerTest
	{
		[Fact]
		public void Must_return_values()
		{
			var controller = new ValuesController();
			var result = controller.Get();

			Assert.True(result.Value.Any());
		}
	}
}