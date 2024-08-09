namespace BlazorUITemplate.Services;

public class ColorGenerator
{
	private static readonly Random _random = new Random();

	public static string GenerateRandomColor()
	{
		var r = _random.Next(0, 256);
		var g = _random.Next(0, 256);
		var b = _random.Next(0, 256);
		return $"rgb({r},{g},{b})";
	}
}