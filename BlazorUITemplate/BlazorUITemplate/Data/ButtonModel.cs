using BlazorUITemplate.Enums;

namespace BlazorUITemplate.Data;

public class ButtonModel:BaseModel
{
	public string? Name { get; set; }
	public ButtonColor ButtonColor { get; set; }
	public string ButtonClass { get; set; }
}