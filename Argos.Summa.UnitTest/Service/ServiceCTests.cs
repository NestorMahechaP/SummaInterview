using Argos.Summa.Service.Interface;
using Argos.Summa.Service.Service;

namespace Argos.Summa.UnitTest.Service
{
	[TestClass]
	public class ServiceCTests
	{
		private readonly IAgent _service;

		public ServiceCTests()
		{
			_service = new AgentC();
		}

		[DataRow(new double[] { 5, 4 }, 4.5)]
		[DataRow(new double[] { 7, 10, 15 }, 10)]
		[TestMethod]
		public void GetMedia_Array_ReturnsSameNumber(double[] data, double result)
		{
			//Arrange
			var dataList = data.ToList();

			//Act
			var response = _service.GetMedia(dataList);

			//Assert
			Assert.AreEqual(result, response);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void GetMedia_EmptyArray_ReturnException()
		{
			//Arrange
			var dataList = new List<double>();

			//Act
			_service.GetMedia(dataList);

			//Assert
		}

		[DataRow(1, "#\n")]
		[DataRow(2, " ## \n####\n ## ")]
		[DataRow(0, "")]
		[TestMethod]
		public void GetStairCase_ValidSize_ReturnSameValue(int size, string expected)
		{
			//Arrange

			//Act
			var result = _service.GetStairCase(size);

			//Assert
			Assert.AreEqual(expected, result);
		}
	}
}
