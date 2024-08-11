using BlazorUITemplate.Data;
using BlazorUITemplate.Enums;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorUITemplate.Services;

public class EventService
{
	public event Action<MouseEventArgs> OnMouseUpGlobal;
 	
 	public delegate void OnDrag<T>(T model) where T : BaseModel;
 
 	public event OnDrag<BaseModel> OnDragOccured;

	public event Func<Task> OnClearAll;
	public event Action<ComponentType,Guid?> OnGetComponent;

	public event Func<bool> OnRemoveSelected;

	public void OnRemoveSelectedEvent ()
	{
		OnRemoveSelected.Invoke ();
	}

	public void OnDragEvent<T> (T model) where T:BaseModel
	{
		OnDragOccured?.Invoke (model);
	}
	public async Task OnClearAllEvent ()
	{
		try
		{
			if (OnClearAll != null)
			{
				await OnClearAll.Invoke ();
			}
		}
		catch (Exception exception)
		{
			Console.WriteLine (exception.Message);
		}
	}

	public void OnGetComponentEvent (ComponentType type, Guid? id)
	{
				OnGetComponent.Invoke (type,id);
	}

	public void OnMouseUpGlobalEvent (MouseEventArgs eventArgs)
	{
		OnMouseUpGlobal.Invoke (eventArgs);
	}
}