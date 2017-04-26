using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace SwimLib
{
    public class SwimmersManager : IRegistrantsRepository
    {
        private ArrayList swimmers;
        //private readonly int number;
        private ClubsManager clubManager;

        public int Number
        {
            get
            {
                return swimmers.Count;
            }
        }

        public ClubsManager ClubManager
        {
            get
            {
                return clubManager;
            }

            set
            {
                clubManager = value;
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

        public SwimmersManager(ClubsManager clubManager)
        {
            this.clubManager = clubManager;
            clubManager.SwimmerManager = this;
            Swimmers = new ArrayList();
        }

        public void Add(Registrant aSwimmer)
        {
            if (aSwimmer.Name == "")
            {
                throw new Exception("Invalid swimmer name:");
            }
            else if (GetByRegNum((uint)aSwimmer.Number) != null)
            {
                throw new Exception("Swimmer with the registration number already exists:");
            }
            else
            {
                if (aSwimmer.Club != null)
                {
                    Club checker = clubManager.GetByRegNum((uint)aSwimmer.Club.Number);
                    if (checker == null)
                    {
                        clubManager.Add(aSwimmer.Club);
                    }
                }
                swimmers.Add(aSwimmer);
            }
        }

        public Registrant GetByRegNum(uint regNumber)
        {
            if (Swimmers.Count == 0)
            {
                return null;
            }
            foreach (Swimmer swimmer in Swimmers)
            {
                if (swimmer.Number == regNumber)
                    return swimmer;
            }
            return null;
        }

        public void Load(string filename, string delimiter)
        {
            FileStream inFile = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);
            string recordIn = reader.ReadLine();
            string[] fields;
            while (recordIn != null)
            {
                fields = recordIn.Split(new string[] { delimiter }, StringSplitOptions.None); //tables from Assignment 2 pdf called for a string delimiter and not a char delimiter
                Registrant newSwimmer;
                uint swimmerNumber;
                int clubNumber;
                long phoneNumber;
                DateTime birthdate;
                
                try
                {
                    swimmerNumber = Convert.ToUInt32(fields[0]);
                    birthdate = Convert.ToDateTime(fields[2]);
                    phoneNumber = Convert.ToInt64(fields[7]);
                    newSwimmer = new Swimmer(fields[1], birthdate, new Address(fields[3], fields[4], fields[5], fields[6]), phoneNumber, (int)swimmerNumber);
                    Add(newSwimmer);
                    clubNumber = Convert.ToInt32(fields[8]); //placement of this code is intentional. some swimmers may not have a club, which will trigger an exception here.
                    Club swimmerClub = clubManager.GetByRegNum((uint)clubNumber);
                    swimmerClub.AddSwimmer(newSwimmer);
                }
                catch (FormatException ex)
                {
                    if (ex.ToString().Contains("ToUInt32"))
                    {
                        Console.WriteLine("Invalid swimmer record. Invalid registration number:\n\t{0}", recordIn);
                    }
                    else if (ex.ToString().Contains("ToInt64"))
                    {
                        Console.WriteLine("Invalid swimmer record. Phone number wrong format:\n\t{0}", recordIn);
                    }
                    else if (ex.ToString().Contains("ToDateTime"))
                    {
                        Console.WriteLine("Invalid swimmer record. Birth date is invalid:\n\t{0}", recordIn);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid swimmer record. {0}\n\t{1}", ex.Message, recordIn);
                }
                finally
                {
                    recordIn = reader.ReadLine();
                }
            }
            reader.Close();
            inFile.Close();
        }

        public void Save(string filename, string delimiter)
        {
            FileStream outFile = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);
            foreach(Swimmer swimmer in Swimmers)
            {
                string line = swimmer.Number + delimiter + swimmer.Name + delimiter + swimmer.DateOfBirth + delimiter;
                line += swimmer.Address.StreetAddress + delimiter + swimmer.Address.Municipality + delimiter + swimmer.Address.Province + delimiter + swimmer.Address.ZipCode + delimiter;
                line += swimmer.PhoneNumber + delimiter;
                if(swimmer.Club != null)
                {
                    line += swimmer.Club.Number;
                }
                writer.WriteLine(line);
            }
            writer.Close();
            outFile.Close();
        }
    }
}
