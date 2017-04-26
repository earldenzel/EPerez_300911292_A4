using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SwimLib
{
    public enum Stroke
    {
        Butterfly, Backstroke, Breaststroke, Freestyle, Individual_Medley
    }
    public enum EventDistance
    {
        _50 = 50, _100 = 100, _200 = 200, _400 = 400, _800 = 800, _1500 = 1500
    }
    public class Event
    {
        private EventDistance distance;
        private Stroke stroke;
        private ArrayList registrants;
        private SwimMeet swimMeet;
        private ArrayList swims;

        public string Name
        {
            get
            {
                return distance + " " + stroke;
            }
        }

        public Event():this(EventDistance._1500,Stroke.Individual_Medley)
        {

        }

        public Event(EventDistance distance, Stroke stroke)
        {
            this.distance = distance;
            this.stroke = stroke;
            Registrants = new ArrayList();
            Swims = new ArrayList();
        }

        public override string ToString()
        {
            string info = string.Format("\n\t{0} {1}\n\tSwimmers:",distance,stroke);
            if (Swims.Count == 0)
            {
                foreach (Swimmer swimmer in registrants)
                {
                    info += swimmer.GetSwimmerName();
                    info += "\n\t\tNot seeded/No swim";
                }
            }
            else
            {
                foreach (Swim swim in swims)
                {
                    info += swim.Registrant.GetSwimmerName();
                    info += string.Format("\tH{0}L{1}\tTime: {2}", swim.Heat, swim.Lane, swim.GetInfo());                    
                }
            }
            return info;
        }

        public EventDistance Distance
        {
            set
            {
                distance = value;
            }
            get
            {
                return distance;
            }
        }

        public Stroke Stroke
        {
            set
            {
                stroke = value;
            }
            get
            {
                return stroke;
            }
        }

        public SwimMeet SwimMeet
        {
            get
            {
                return swimMeet;
            }

            set
            {
                swimMeet = value;
            }
        }

        public ArrayList Registrants
        {
            get
            {
                return registrants;
            }

            set
            {
                registrants = value;
            }
        }

        public ArrayList Swims
        {
            get
            {
                return swims;
            }

            set
            {
                swims = value;
            }
        }

        public void AddSwimmer(Registrant aSwimmer)
        {
            if (Registrants.Contains(aSwimmer))
            {
                throw new Exception(string.Format("Swimmer {0},{1} is already entered", aSwimmer.Name, aSwimmer.Number));
            }
            Registrants.Add(aSwimmer);
        }

        public void Seed()
        {
            for (int i = 0; i < Registrants.Count; i++)
            {
                Swim newSwim = new Swim(1 + i / SwimMeet.Lanes, 1 + i % SwimMeet.Lanes);
                newSwim.Registrant = Registrants[i] as Swimmer;
                newSwim.SwimEvent = this;
                Swims.Add(newSwim);
            }
        }

        public void EnterSwimmersTime(Registrant registrant, string swimTime)
        {
            Swimmer swimmer = registrant as Swimmer;
            if (Registrants.Contains(registrant))
            {
                int locator = Registrants.IndexOf(registrant);
                Swim correspondingSwim = Swims[locator] as Swim;
                correspondingSwim.SwimTime = swimTime;
                swimmer.AddAsBestTime(swimMeet.PoolType, Distance, Stroke, TimeSpan.Parse("00:" + swimTime));
                return;
            }
            throw new Exception("Swimmer has not entered event");
        }
    }
}
