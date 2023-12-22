using Argos.Summa.Service.Interface;
using Argos.Summa.Service.Service;

namespace Argos.Summa.UnitTest.Service
{
	[TestClass]
	public class ServiceATests
	{
		private readonly IAgent _service;

        public ServiceATests()
        {
            _service = new AgentA();
        }

        [DataRow(new double[] {3, 4, 2 }, 3)]
		[DataRow(new double[] {1, 1, 1 }, 1)]
		[DataRow(new double[] {5.5, 4.5 }, 5)]
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
		public void GetMedia_EmptyArray_ReturnNan()
		{
			//Arrange
			var dataList = new List<double>();
			var expected = double.NaN;

			//Act
			var response = _service.GetMedia(dataList);

			//Assert
			Assert.AreEqual(expected, response);
		}

		[DataRow(1, "#\n")]
		[DataRow(2, " #\n##\n")]
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
