using System.Security.Cryptography.X509Certificates;



namespace PooBasics
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			
			Player player = new Player(10, "Zidane");
			Assert.AreEqual("Zidane", player.Name);
			Assert.AreEqual(-1, player.Number);
			// Impossible de changer l'ID
			// player.Id = 23;


		}
	}
}