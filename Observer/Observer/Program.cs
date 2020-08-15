using System;
using System.Collections.Generic;
using System.Threading;

namespace Observer
{

    class subject
    {
        private List<observer> _observers = new List<observer>();
        public int State;
        public void Register(observer obs)
        {
            _observers.Add(obs);
        }

        public void unRegister(observer obs)
        {
            _observers.Remove(obs);
        }

        public void notify()
        {
            Console.WriteLine("------------Notifing Observers----------\n");
            
            foreach(observer obs in _observers)
            {
                this.State = new Random().Next(0, 50);
                obs.update(this);
            }

        }
    }

    abstract class observer
    {
        public abstract void update(subject sub);
    }

    class observerA : observer
    {
        public override void update(subject sub)
        {
            Console.WriteLine("Notified with state number {0} to observer -> A", sub.State);
        }
    }

    class observerB : observer
    {
        public override void update(subject sub)
        {
            Console.WriteLine("Notified with state number {0} to observer -> B", sub.State);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            subject sub = new subject();

            observerA obsa = new observerA();
            observerB obsb = new observerB();

            sub.Register(obsa);
            sub.Register(obsb);

            sub.notify();

            sub.unRegister(obsa);

            sub.notify();
        }
    }
}
