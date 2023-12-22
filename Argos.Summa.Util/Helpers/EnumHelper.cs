using System.ComponentModel;

namespace Argos.Summa.Util.Helpers
{
	public static class EnumHelper
	{
		public static string GetDescription(Enum value)
		{
			var fi = value.GetType().GetField(value.ToString());
			var attributes = (DescriptionAttribute[]?)fi?.GetCustomAttributes(typeof(DescriptionAttribute), false);

			if (attributes?.Length > 0)
				return attributes[0].Description;
			else
				return value.ToString();
		}
	}
}
