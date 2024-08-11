using BlazorUITemplate.Data;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorUITemplate.Services;

public class EventService
{
	public event Action<MouseEventArgs> OnMouseUpGlobal;
 	
 	public delegate void OnDrag<T>(T model) where T : BaseModel;
 
 	public event OnDrag<BaseModel> OnDragOccured;

 	public delegate void OnGetComponent<T>(T model) where T : BaseModel;
 
 	public event OnGetComponent<BaseModel> OnGetComponentOccured;

	public event Func<Task> OnClearAll;

	public event Func<bool> OnRemoveSelected;

	public void OnRemoveSelectedEvent ()
	{
		OnRemoveSelected.Invoke ();
	}

	public void OnDragEvent<T> (T model) where T:BaseModel
	{
		OnDragOccured?.Invoke (model);
	}
	
	public void OnGetComponentEvent<T> (T model) where T:BaseModel
	{
		OnGetComponentOccured?.Invoke (model);
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
	
	public void OnMouseUpGlobalEvent (MouseEventArgs eventArgs)
	{
		OnMouseUpGlobal.Invoke (eventArgs);
	}
}