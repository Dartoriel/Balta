namespace Balta.NotificationContext 
{
  public abstract class Notifiable
  {
    public List<Notification> Notifications { get; set; }

    public void Add(Notification notification)
    {
      Notification.Add(notification);
    }

    public void AddRange(IEnumerable<Notification> notifications)
    {
      Notification.AddRange(notifications);
    }

    public bool IsValid => Notifications.Any();
  }
}