using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SwimLib
{
    public class Coach : Registrant
    {
        private string credentials;
        private ArrayList swimmers = new ArrayList();

        public Coach(string name, DateTime dateOfBirth, Address address, long phoneNumber): base(name, dateOfBirth,address,phoneNumber)
        {
        }

        public string Credentials
        {
            get
            {
                return credentials;
            }

            set
            {
                credentials = value;
            }
        }

        public ArrayList Swimmers
        {
            get
            {
                return swimmers;
            }

            set
            {
                swimmers = value;
            }
        }
        
        public void AddSwimmer(Swimmer swimmer)
        {
            if (Club == null)
            {
                throw new Exception("Coach is not assigned to a club");
            }
            else if (Club != swimmer.Club)
            {
                throw new Exception("Coach and swimmer are not in the same club");
            }
            else
            {
                Swimmers.Add(swimmer);
                swimmer.Coach = this;
                //string message = "";
                //foreach (Swimmer aswimmer in swimmers)
                //{
                //    message += aswimmer.GetSwimmerName();
                //}

                //throw new Exception(message);
            }
        }

        public override string ToString()
        {
            string info = string.Format("\nCredentials: {0}\nSwimmers:", Credentials);
            foreach (Swimmer swimmer in Swimmers)
            {
                info += swimmer.GetSwimmerName();
            }            
            return base.ToString() + info;
        }
    }
}
