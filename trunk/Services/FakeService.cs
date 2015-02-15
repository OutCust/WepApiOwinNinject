using WepApiOwinNinject.Interfaces;

namespace WepApiOwinNinject.Services
{
	public class FakeService : IFakeService
	{
		public bool GetAnswer(string question)
		{
			return question.Contains("Is");
		}
	}
}