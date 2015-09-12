using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel
{
    public class Human:IHuman
    {
        private String m_passportID;
        private String m_name;
        private String m_surname;
        private DateTime m_birthDay;
        private Int32 m_age;
        private String m_sex;
        private String m_phone;
        private String m_email;

        public String PassportID
        {
            set { m_passportID = value; }
            get { return m_passportID; }
        }
        public string Name
        {
            set { m_name = value; }
            get { return m_name; }
        }
        public string Surname
        {
            set { m_surname = value; }
            get { return m_surname; }
        }

        public DateTime BirthDay
        {
            set { m_birthDay = value; }
            get { return m_birthDay.Date; }
        }
        public Int32 Age
        {
            set
            {
                m_age = value;
            }
            get
            {
                DateTime thisDay = DateTime.Today;
                m_age = thisDay.Year - m_birthDay.Year;
                if (thisDay < m_birthDay.AddYears(m_age)) m_age--;
                return m_age;
            }
        }
        
        public String Phone
        {
            set { m_phone = value; }
            get { return m_phone; }
        }
        public String Email
        {
            set { m_email = value; }
            get { return m_email; }
        }
        public String Sex
        {
            set { m_sex = value; }
            get { return m_sex; }
        }
    }
}
