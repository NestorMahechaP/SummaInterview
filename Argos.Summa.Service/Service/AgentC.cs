using Argos.Summa.Service.Interface;
namespace Argos.Summa.Service.Service
{
	public class AgentC : IAgent
	{
		public double GetMedia(List<double> data)
		{
			data.Sort();
			var size = data.Count;
			var middle = size / 2;
			return size % 2 != 0 ? data[middle] : (data[middle] + data[middle - 1]) / 2;
		}
		public string GetStairCase(int size)
		{
			var endLine = "\n";
			var symbols = new Dictionary<int, string>()
			{
				{ 0, "#"},
				{ 1, " "}
			};
			var result = string.Empty;
			var middle = string.Empty;
			var indexBeforeMiddle = size - 2;
			for (int row = 0; row < size; row++)
			{
				var temp = string.Empty;
				var middleSecSymbolSize = size - 1 - row;
				for (int col = 0; col < middleSecSymbolSize; col++)
				{
					temp += symbols[1];
				}
				result += temp;
				var prinSymbolSyze = size + (row * 2);
				for (int col = 0; col < prinSymbolSyze; col++)
				{
					result += symbols[0];
				}
				result += temp;
				if (row == indexBeforeMiddle)
				{
					var tempArray = result.ToCharArray();
					Array.Reverse(tempArray);
					middle = new string (tempArray);
				}
				result += endLine;
			}
			return result + middle;
		}
	}
}
