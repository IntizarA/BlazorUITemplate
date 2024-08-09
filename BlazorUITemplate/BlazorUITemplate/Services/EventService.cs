using Microsoft.AspNetCore.Components.Web;

namespace BlazorUITemplate.Services;

public class EventService
{
	public event Func<Task> OnClearAllClick;
	public event Func<Task> OnRemoveSelectedClick;

	public event Action<MouseEventArgs> OnMouseUp;

	public async Task OnRaiseClearAllEvent ()
	{
		try
		{
			if (OnClearAllClick != null)
			{
				await OnClearAllClick.Invoke ();
			}
		}
		catch (Exception exception)
		{
			Console.WriteLine (exception.Message);
		}
	}

	public async Task OnRaiseRemoveSelectedEvent ()
	{
		try
		{
			if (OnRemoveSelectedClick != null)
			{
				await OnRemoveSelectedClick.Invoke ();
			}
		}
		catch (Exception exception)
		{
			Console.WriteLine (exception.Message);
		}
	}

	public void OnMouseUpEvent (MouseEventArgs eventArgs)
	{
		OnMouseUp.Invoke (eventArgs);
	}
}