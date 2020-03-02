using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Consumer.UnitTest
{
	[TestClass]
	public class ProgramTest
	{
		[TestMethod]
		[DeploymentItem("Deployables")]
		public void ConnectorTest()
		{
			Program.Connect();
		}
	}
}
