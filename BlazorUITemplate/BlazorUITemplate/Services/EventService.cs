namespace BlazorUITemplate.Services;

public class EventService
{
	public event Func<Task> OnClearAllClick;
	public event Func<Task> OnRemoveSelectedClick;

	public async Task OnRaiseClearAllEvent ()
	{
		if (OnClearAllClick != null)
		{
			await OnClearAllClick.Invoke ();
		}
	}
	public async Task OnRaiseRemoveSelectedEvent ()
	{
		if (OnRemoveSelectedClick != null)
		{
			await OnRemoveSelectedClick.Invoke ();
		}
	}
}