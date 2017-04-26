using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SwimLib
{
    
    public class Club
    {
        private int number;
        private string name;
        private Address address;
        private long phoneNumber;
        private ArrayList registrants; //collective list of both swimmers and coaches

        public Club():this("",new Address(), 0, 0)
        {

        }

        public Club(string name, Address address, long phoneNumber) : this(name, address, phoneNumber, RegNumber.AssignRegNumber().Number)
        {

        }


        public Club(string name, Address address, long phoneNumber, int number)
        {
            this.number = number;
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
            Registrants = new ArrayList();
        }

        public override string ToString()
        {
            string info = string.Format("Name: {0}\nAddress:\n\t{1}\n\t{2}\n\t{3}\n\t{4}\nPhone: {5}\nReg number: {6}\nSwimmers:", name, address.StreetAddress, address.Municipality, address.Province, address.ZipCode, phoneNumber, number);
            string coachInfo = "";
            foreach (Registrant registrant in Registrants)
            {
                Swimmer swimmer = registrant as Swimmer;
                if (swimmer != null)
                    info += registrant.GetSwimmerName();
                else
                    coachInfo += registrant.GetSwimmerName();
            }
            if (coachInfo != "")
                info += string.Format("\nCoaches: {0}", coachInfo);

            return info;
        }

        public string Name
        {
            set
            {
                name = value;
                if (Number == 0)
                {
                    Number = RegNumber.AssignRegNumber().Number; //club number 1 from harness
                }
            }
            get
            {
                return name;
            }
        }

        public Address Address
        {
            set
            {
                address = value;
            }
            get
            {
                return address;
            }
        }

        public long PhoneNumber
        {
            set
            {
                phoneNumber = value;
            }
            get
            {
                return phoneNumber;
            }
        }

        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
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

        public void AddSwimmer(Registrant aRegistrant)
        {
            aRegistrant.Club = this;
        }

        public void AddCoach(Coach coach)
        {
            coach.Club = this;
        }
    }
}
