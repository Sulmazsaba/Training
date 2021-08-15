using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Observer
{
  public  class Subject
  {

      public List<ISubscriber> Subscribers = new List<ISubscriber>();


        public void AddSubscriber(ISubscriber subscriber)
        {
            Subscribers.Add(subscriber);
        }

        public void RemoveSubscriber(ISubscriber subscriber)
        {
            Subscribers.Remove(subscriber);
        }

        
        public void Notify()
        {
            foreach (var subscriber in Subscribers)
            {
                subscriber.Update();
            }
        }
    }
}
