using Argos.Summa.Service.Interface;

namespace Argos.Summa.Service.Service
{
	public class AgentA : IAgent
	{
		public double GetMedia(List<double> data)
		{
			return data.Sum(x => x) / data.Count;
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
			for (int row = 1; row <= size; row++)
			{
				for (int col = 0; col < size - row; col++)
				{
					result += symbols[1];
				}
				for (int col = 0; col < row; col++)
				{
					result += symbols[0];
				}
				result += endLine;
			}
			return result;
		}
	}
}
