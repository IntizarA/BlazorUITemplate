using BlazorUITemplate.Enums;

namespace BlazorUITemplate.Data;

public class BaseModel
{
	public Guid? Id { get; set; }
	
	public bool IsDraggable { get; set; }
	
	public string Width { get; set; } = "150px";
	public string Height { get; set; } = "40px";
}