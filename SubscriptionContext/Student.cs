using System.Security.Cryptography.X509Certificates;
using Balta.ContentContext;
using Balta.NotificationContext;

namespace Balta.SubscriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public User? User { get; set; }
        public IList<Subscription>? Subscriptions { get; set; }
        public void CreateSubscription(Subscription sub)
        {
            if (IsPremium)
            {
                AddNotification(new Notification("Premium", "O aluno já tem uma assinatura ativa"));
                return;
            }
            Subscriptions.Add(sub);
        }
        public bool IsPremium => Subscriptions.Any(x => !x.IsActive);
    }
}