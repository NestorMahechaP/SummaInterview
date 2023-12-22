using System.ComponentModel;

namespace Argos.Summa.Util.Enums
{
	public enum EResult
	{
		[Description("Invalid body request")]
		InvalidBodyRequest,
		[Description("Invalid member with 0 value")]
		InvalidZeroMember,
		[Description("Server Error")]
		ServerError,
		[Description("Success")]
		Success
	}
}
