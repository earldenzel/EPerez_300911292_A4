using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SwimLib
{
    public class Swimmer : Registrant
    {
        private ArrayList bestTimes = new ArrayList();
        private Coach coach;

        public Swimmer(): base()
        {

        }
        
        public Swimmer(string name, DateTime dateOfBirth, Address address, long phoneNumber, int number): base(name, dateOfBirth, address, phoneNumber, number)
        {

        }


        public Swimmer(string name, DateTime dateOfBirth, Address address, long phoneNumber) :base(name, dateOfBirth, address, phoneNumber)
        {

        }

        public ArrayList BestTimes
        {
            get
            {
                return bestTimes;
            }

            set
            {
                bestTimes = value;
            }
        }

        public Coach Coach
        {
            get
            {
                return coach;
            }

            set
            {
                if (value.Club != Club)
                {
                    throw new Exception("Coach is not assigned to the club");
                }
                coach = value;
            }
        }

        public override string ToString()
        {
            string info;
            if (Coach == null)
                info = "\nCoach: not assigned";
            else
                info = string.Format("Coach: {0}", Coach.Name);

            return base.ToString() + info;
        }

        public void AddAsBestTime(PoolType poolType, EventDistance eventDistance, Stroke stroke, TimeSpan time)
        {
            TimeSpan bestTime = GetBestTime(poolType, stroke, eventDistance);
            if (bestTime == new TimeSpan(1, 0, 0))
            {
                BestTimes.Add(new BestTime(poolType, eventDistance, stroke, time));
            }
            else if (time < bestTime)
            {
                int i = BestTimes.IndexOf(new BestTime(poolType, eventDistance, stroke, bestTime));
                BestTime best = new BestTime(poolType, eventDistance, stroke, time);
                bestTimes[i] = best;
            }
        }

        public TimeSpan GetBestTime(PoolType poolType, Stroke stroke, EventDistance eventDistance)
        {
            foreach (BestTime best in BestTimes)
            {
                if (best.PoolType == poolType && best.EventDistance == eventDistance && best.Stroke == stroke)
                {
                    return best.RecordTime;
                }
            }
            return new TimeSpan(1,0,0);
        }
    }
}
