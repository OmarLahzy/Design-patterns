using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace StratgyPattern
{
    /*Context Class to take client request*/
    class Context 
    {
        /*Create a refrence of type strantgy since all class will Inherit from*/
        private Stratgy _transportstratgy;


        /*Set the current object or stratgy choosen by client*/
        public Context(Stratgy transportstratgy) 
        {
            this._transportstratgy = transportstratgy;
        }

        /*Excute the Transportaion stratgy of that object*/
        public void TransportationStratgy()
        {
            _transportstratgy.TransportationStratgy();
        }
    }


    /*An abstract class that all the stratgy will Inherit from */
    abstract class Stratgy 
    {
        public String transport_Strat;
        public abstract void TransportationStratgy();
    }


    class Bus : Stratgy
    { 
        public Bus()
        {
            this.transport_Strat = "Bus";

        }
        public override void TransportationStratgy()
        {
            Console.WriteLine("---The Clinet choose The {0}----", this.transport_Strat);
        }
    }

    class Taxi : Stratgy
    {
        public Taxi()
        {
            this.transport_Strat = "Taxi";

        }
        public override void TransportationStratgy()
        {
            Console.WriteLine("---The Clinet choose The {0}----", this.transport_Strat);
        }
    }

    class Car : Stratgy
    {
        public Car()
        {
            this.transport_Strat = "Car";

        }
        public override void TransportationStratgy()
        {
            Console.WriteLine("---The Clinet choose The {0}----",this.transport_Strat);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            Context cx1 = new Context(c);
            cx1.TransportationStratgy();

            Taxi t = new Taxi();
            Context cx2 = new Context(t);
            cx2.TransportationStratgy();

            Bus b = new Bus();
            Context cx3 = new Context(b);
            cx3.TransportationStratgy();
        }
    }
}
