using BlazorUITemplate.Enums;

namespace BlazorUITemplate.Data;

public class BaseModel
{
	public Guid? Id { get; set; }
	
	public bool IsDraggable { get; set; }
}