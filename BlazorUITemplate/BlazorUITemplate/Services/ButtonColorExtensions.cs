using BlazorUITemplate.Enums;

namespace BlazorUITemplate.Services;

public static class ButtonColorExtensions
{
	public static string ToCssClass(this ButtonColor color)
	{
		return color switch
		{
			ButtonColor.Yellow => "btn btn-warning",
			ButtonColor.Red => "btn btn-danger",
			ButtonColor.Blue => "btn btn-primary",
			_ => "btn btn-default",
		};
	}
}