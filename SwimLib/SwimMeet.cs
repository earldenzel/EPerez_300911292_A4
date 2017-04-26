using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SwimLib
{
    public enum PoolType
    {
        SCM, SCY, LCM
    }

    public class SwimMeet
    {
        private DateTime startDate;
        private DateTime endDate;
        private string name;
        private PoolType poolType;
        private int lanes;
        private readonly ArrayList events;

        public SwimMeet():this("",new DateTime(), new DateTime(), PoolType.SCM, 8)
        {

        }

        public SwimMeet(string name, DateTime startDate, DateTime endDate, PoolType poolType, int lanes)
        {
            this.startDate = startDate;
            this.endDate = endDate;
            this.name = name;
            this.poolType = poolType;
            this.lanes = lanes;
            events = new ArrayList();
        }

        public override string ToString()
        {
            string info = string.Format("Swim Meet name: {0}\nFrom-to: {1} to {2}\nPool Type: {3}\nNo. of Lanes: {4}\nEvents:", name, startDate.ToString("MMMM dd, yyyy"), endDate.ToString("MMMM dd, yyyy"), poolType, lanes);
            foreach (Event aEvent in Events)
            {
                if (aEvent != null)
                {
                    info += aEvent.ToString() + "\n";
                }
            }
            return info;
        }

        public DateTime StartDate
        {
            set
            {
                startDate = value;
            }
            get
            {
                return startDate;
            }
        }

        public DateTime EndDate
        {
            set
            {
                endDate = value;
            }
            get
            {
                return endDate;
            }
        }

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public PoolType PoolType
        {
            set
            {
                poolType = value;
            }
            get
            {
                return poolType;
            }
        }

        public int Lanes
        {
            get
            {
                return lanes;
            }

            set
            {
                lanes = value;
            }
        }

        public ArrayList Events
        {
            get
            {
                return events;
            }
        }

        public void AddEvent(Event aEvent)
        {
            aEvent.SwimMeet = this;
            events.Add(aEvent);
        }

        public void Seed()
        {
            foreach(Event aEvent in Events)
            {
                aEvent.Seed();
            }
        }
    }
}
