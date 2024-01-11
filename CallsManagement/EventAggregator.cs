using System;

public sealed class EventAggregator
{
    static EventAggregator EA = new EventAggregator();

    public event EventHandler<EventArgs> RegistryDeleted;

    public static EventAggregator GetEventAggregator()
    {
        return EA;
    }

    public void RaiseEntityDeletedEvent(object sender, EventArgs e)
    {
        RegistryDeleted?.Invoke(sender, e);
    }
}