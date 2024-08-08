using BlazorUITemplate.Enums;

namespace BlazorUITemplate.Data;

public class ButtonModel
{
	public Guid? Id { get; set; }
	public string? Name { get; set; }
	public ComponentType ComponentType { get; set; }
	public bool IsDraggable { get; set; }
}