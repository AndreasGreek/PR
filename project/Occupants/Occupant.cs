using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Hostel
{
    public class Occupant : Human, IOccupant
    {
        protected String m_passportID;
        protected String m_name;
        protected String m_surname;
        protected DateTime m_birthDay;
        protected Int32 m_age;
        protected String m_sex;
        protected String m_phone;
        protected String m_email;
        
        protected Boolean m_status;
        protected Int32 m_roomNumber;

        protected DateTime m_dateIn;
        protected DateTime m_dateLeave;
        protected TimeSpan m_duration;

        protected Double m_countedPayment;
        protected Double m_paidPayment;
        protected Double m_debt;

        protected Int32 m_numberInList;
        
        public Occupant() { }
        public Occupant(Human human, Boolean status, Int32 roomNumber, DateTime dateIn, DateTime dateLeave, Double countedPayment, Double paidPayment, Double debt)
        {
            m_passportID = human.PassportID;
            m_name = human.Name;
            m_surname = human.Surname;
            m_birthDay = human.BirthDay;
            m_age = human.Age;
            m_sex = human.Sex;
            m_phone = human.Phone;
            m_email = human.Email;

            m_status = status;
            m_roomNumber = roomNumber;

            m_dateIn = dateIn;
            m_dateLeave = dateLeave;

            m_countedPayment = countedPayment;
            m_paidPayment = paidPayment;
            m_debt = debt;     
        }
        ~Occupant() { }

        
        public Int32 RoomNumber
        {
            set { m_roomNumber = value; }
            get { return m_roomNumber; }
        }
        public DateTime DateIn
        {
            set { m_dateIn = value; }
            get { return m_dateIn.Date; }
        }
        public DateTime DateLeave
        {
            set { m_dateLeave = value; }
            get { return m_dateLeave.Date; }
        }
        public TimeSpan Duration
        {
            set
            {
                m_duration = value;
            }
            get
            {
                if (DateLeave == null)
                    m_duration = DateTime.Now - DateIn;
                else m_duration = DateLeave - DateIn;
                return m_duration;
            }
        }
        public Double CountedPayment
        {
            set { m_countedPayment = value; }
            get { return m_countedPayment; }
        }
        public Double PaidPayment
        {
            set { m_paidPayment = value; }
            get { return m_paidPayment; }
        }
        public Double Debt
        {
            set { m_debt = value; }
            get { return m_debt; }
        }
        public Boolean Status
        {
            set { m_status = value; }
            get { return m_status; }
        }
        public Int32 NumberInList 
        {
            set { m_numberInList = value; }
            get { return m_numberInList; }
        }


    //    public void InputOfCardsInformation()
    //    {   //Input of Card ID
    //        Regex regCardNum = new Regex(@"[\d]{4}-[\d]{4}-[\d]{4}-[\d]{4}$|^Ν$|^n$");
    //        String tmpCardNum = "0";//temp variable

    //        while (!regCardNum.Match(tmpCardNum).Success)
    //        {
    //            Console.WriteLine("Please, enter the Number of Card in format ####-####-####-####");
    //            tmpCardNum = (Console.ReadLine());
    //        }
    //        if (tmpCardNum != "N" & tmpCardNum != "n")
    //        {
    //            m_card.CardNumber = tmpCardNum;

    //            //Input of Card Opened
    //            Regex regCardOpened = new Regex(@"^((((0[1-9])|([1-2][0-9])|(3[0-1]))|([1-9]))\x2F(((0[1-9])|(1[0-2]))|([1-9]))\x2F(([0-9]{2})|(((19)|([2]([0]{1})))([0-9]{2}))))$ ");

    //            String tmpCardOpened = "0";//temp variable

    //            //while (!regCardOpened.Match(tmpCardOpened).Success)
    //            //{
    //            //    Console.WriteLine("Please, enter the client passport ID");
    //            //    tmpCardOpened = (Console.ReadLine());
    //            //}
    //            tmpCardOpened = DateTime.Now.ToShortDateString();

    //            m_card.Opened = Convert.ToDateTime(tmpCardOpened);
    //            m_card.OpenedBefore = m_card.Opened.AddYears(3);
    //        }
    //    }

    ////    public List<Client> Sort(List<Client> clietnts)
    ////{
    ////       enum StringParams{Name, Surname, BirthDay, Phone, Email, PassportID}
        
    ////    return 
    ////}

    //    void IOccupant.SortList() 
    //    {
    //        SortedList<OccupantsDB, Client> sortedClient = new SortedList<OccupantsDB>();

    //         foreach (Client customer in clients)
    //            {
    //                yield return customer;
    //            }

    //    }

    //    void IOccupant.SearchClient()
    //    {

    //    }
    }
}