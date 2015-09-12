using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Hostel
{
    public class CreateOccupants
    {
        //int counter=0;
        List<Occupant> m_occupantsDB;

        public CreateOccupants(){}

        public CreateOccupants(List<Occupant> occupantsDB) 
        {
            m_occupantsDB = occupantsDB;
        }

        ~CreateOccupants() { }



        //public void DoYouWantToAddNewClient()
        //{
            
        //    string tmp = "0"; //temp variable
        //    try
        //    {
        //        Regex YesNo = new Regex(@"^y$|^n$");//regular expression for numeric control;

        //        while (!YesNo.Match(tmp).Success)
        //        {
        //            Console.WriteLine("WOULD YOU LIKE TO ADD THE NEW CLIENT TO THE GROUP (Y|N)");
        //            tmp = (Console.ReadLine()).ToLower();

        //            //int count = 0;
        //            while (tmp == "y")
        //            {
        //                counter += 1;
        //                InputOfInformation();
        //                //DoYouWantToAddNewClient();
                        
        //                Console.WriteLine("WOULD YOU LIKE TO ADD THE NEW CLIENT TO THE GROUP (Y|N)");
        //                tmp = (Console.ReadLine()).ToLower();
        //            }
        //            if (tmp == "n")
        //            {
        //                //recording of the information about students to the file

        //                Files fl = new Files();
        //                String filePath = @"D:\\Files\\Clients.txt";
        //                fl.RecordToFile(m_clientsDB, filePath);

        //                //Reading of the information from file
        //                Files file2 = new Files();

        //                IEnumerable<Client> customers = new List<Client>();
        //                customers = file2.ReadFromFile(filePath);

        //                Console.WriteLine("\n|{0, 10}|{1,10}|{2,10}|{3,4}|{4,14}|{5,14}|{6,10}|", "PassportID", "Name", "Surname", "BirthDay", "Age", "Phone", "Email", "CardNumber", "Card IsValidBefore");

        //                foreach (Client customer in customers)
        //                {
        //                    Console.WriteLine("\n|{0,10:F2}|{1,10:D7}|{2,10}|{3,10}|{4,4:d}|{5,14:D}|{6,14:F2}|{7,15:F2}|{8,10:F2}|", customer.PassportID, customer.Name, customer.Surname, customer.BirthDay.ToShortDateString(), customer.Age, customer.Phone, customer.Email, customer.Card.CardNumber, customer.Card.OpenedBefore);
        //                }
        //            }
        //        }
        //        Show();
        //    }
        //    catch (RegexMatchTimeoutException)
        //    {
        //        Console.WriteLine("Please push correct button");
        //    }
        //}


        //public void InputOfInformation()
        //{
        //    //Input of the name;
        //    Regex regName = new Regex(@"^[A-Za-z]*$");
        //    string tmpName = "0";//temp variable
        //    //Console.WriteLine("Please, enter the name of the client");

        //    while (!regName.Match(tmpName).Success)
        //    {
        //        Console.WriteLine("Please, enter the name of the client using only letters");
        //        tmpName = (Console.ReadLine());
        //    }

        //    String name = tmpName;

        //    //Input of the surname;
        //    Regex regSurname = new Regex(@"^[A-Za-z]*$");
        //    String tmpSurname = "0";//temp variable
        //    Console.WriteLine("Please, enter the surname of the client using only letters");
        //    tmpSurname = (Console.ReadLine());

        //    while (!regSurname.Match(tmpSurname).Success)
        //    {
        //        Console.WriteLine("Please, enter the surname of the client using only letters");
        //        tmpSurname = (Console.ReadLine());
        //    }
        //    String surname = tmpSurname;

        //    //Input the birthDay
        //    Regex regDate = new Regex(@"^((((0[1-9])|([1-2][0-9])|(3[0-1]))|([1-9]))\x2F(((0[1-9])|(1[0-2]))|([1-9]))\x2F(([0-9]{2})|(((19)|([2]([0]{1})))([0-9]{2}))))$");
        //    String tmpDate = "0";
        //    String Bdate="";
        //    //Console.WriteLine("Please, enter the birthday of the client in format dd/MM/yyyy");
        //    //tmpDate = (Console.ReadLine());
        //    while (!regDate.Match(tmpDate).Success)
        //    {
        //        Console.WriteLine("Please, enter the birthday of the cluent in format dd/MM/yyyy");
        //        tmpDate = (Console.ReadLine());
        //    }
        //    //Bdate = Convert.ToDateTime(tmpDate).ToString("dd/MM/yyyy");
        //    DateTime birthDay = Convert.ToDateTime(tmpDate, CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat);

        //    //Input of the phone
        //    //Console.WriteLine("Please, enter the  client phone in the next consequence (0##)-###-##-##");
        //    Regex regPhone = new Regex(@"^\(?0\d{2}\)?-?\d{3}-?\d{2}-?\d{2}$");
        //    String tmpPhone = "0";//temp variable

        //    while (!regPhone.Match(tmpPhone).Success)
        //    {
        //        Console.WriteLine("Please, enter the  client phone in the next consequence (0##)###-##-##");
        //        tmpPhone = (Console.ReadLine());
        //    }
        //    String phone = tmpPhone;

        //    //INPUT THE PassportID
        //    Regex regPassport = new Regex(@"[A-Za-z]{2}\d{6}");
        //    String tmpPassport = "@";//temp variable
        //    while (!regPassport.Match(tmpPassport).Success)
        //    {
        //        Console.WriteLine("Please, enter the client passport ID");
        //        tmpPassport = (Console.ReadLine());
        //    }
        //    String passportID = tmpPassport;

        //    //INPUT THE E-MAIL
        //    Regex regEMail = new Regex(@"[\w-.]@[\w-.]+\.[a-zA-Z]{2,4}$");
        //    String tmpEMail = "0";//temp variable

        //    while (!regEMail.Match(tmpEMail).Success)
        //    {
        //        Console.WriteLine("Please, enter the correct client e-Mail");
        //        tmpEMail = (Console.ReadLine());
        //    }
        //    String email = tmpEMail;



        //    m_clientsDB.Add(new Client(name, surname, birthDay, phone, email, passportID));

        //    m_clientsDB[m_clientsDB.Count - 1].InputOfCardsInformation();
        //}
        //public void Sort()
        //{
        //    Files file = new Files();
        //    String filePath = @"Clients.txt";

        //    IEnumerable<Client> list = new List<Client>();
        //    list = file.ReadFromFile(filePath);

        //    Int16 caseSwitch;
        //    IEnumerable<Client> result = new List<Client>();
        //    Regex regName = new Regex(@"^[0-6]$");
        //    string tmpName = "0";//temp variable

        //    while (!regName.Match(tmpName).Success)
        //    {
        //        Console.WriteLine("Make choise how to sort the list of clients\n (0 - by Passport ID; 1- by Name, 2= by Surname, 3 - by BirthDay, 4 - by Age,\n 5 - by Phone, 6 - by E-mail)");
        //        tmpName = Console.ReadLine();
        //    }
        //    caseSwitch = Convert.ToInt16(tmpName);

        //    switch (caseSwitch)
        //    {
        //        case 0:
        //            Console.WriteLine("\n\n\nSORTED LIST BY PassportID");
        //            result = list.OrderBy(x => x.PassportID).ThenBy(x => x.PassportID);
        //            break;
        //        case 1:
        //            Console.WriteLine("\n\n\nSORTED LIST BY Name");
        //            result = list.OrderBy(x => x.Name).ThenBy(x => x.Name);
        //            break;
        //        case 2:
        //            Console.WriteLine("\n\n\nSORTED LIST BY Surname");
        //            result = list.OrderBy(x => x.Surname).ThenBy(x => x.Surname);
        //            break;
        //        case 3:
        //            Console.WriteLine("\n\n\nSORTED LIST BY BirthDay");
        //            result = list.OrderBy(x => x.BirthDay).ThenBy(x => x.BirthDay);
        //            break;
        //        case 4:
        //            Console.WriteLine("\n\n\nSORTED LIST BY Age");
        //            result = list.OrderBy(x => x.Age).ThenBy(x => x.Age);
        //            break;
        //        case 5:
        //            Console.WriteLine("\n\n\nSORTED LIST BY Phone");
        //            result = list.OrderBy(x => x.Phone).ThenBy(x => x.Phone);
        //            break;
        //        case 6:
        //            Console.WriteLine("\n\n\nSORTED LIST BY E-mail");
        //            result = list.OrderBy(x => x.Email).ThenBy(x => x.Email);
        //            break;
        //    }
        //    Console.WriteLine("\n|{0, 10}|{1,7}|{2,10}|{3,10}|{4,3}|{5,14}|{6,16}|", "PassportID", "Name", "Surname", "BirthDay", "Age", "Phone", "Email");

        //    foreach (Client customer in result)
        //    {
        //        Console.WriteLine("\n+----------+-------+----------+----------+---+--------------+-----------------+");
        //        Console.WriteLine("\n|{0,10:F2}|{1,7:D7}|{2,10}|{3,10}|{4,3:d}|{5,14:D}|{6,14:F2}", customer.PassportID, customer.Name, customer.Surname, customer.BirthDay.ToShortDateString(), customer.Age, customer.Phone, customer.Email);
        //    }
        //}
        //public void Show()
        //{
        //    //Formattable output
        //    if(counter>0) Console.WriteLine("\n|{0, 10}|{1,10}|{2,10}|{3,4}|{4,14}|{5,14}|{6,10}|", "Name", "Surname", "BirthDay", "Age", "Phone", "Email", "PassportID", "CardNumber", "Card IsValidBefore");
            
        //    foreach (Client client in m_clientsDB)
        //    {
        //        Console.WriteLine("\n|{0,10:D7}|{1,10}|{2,10}|{3,4:d}|{4,14:D}|{5,14:F2}|{6,10:F2}|", client.Name, client.Surname, client.BirthDay.ToShortDateString(), client.Age, client.Phone, client.Email, client.PassportID, client.Card.CardNumber, client.Card.OpenedBefore);
        //    }
        //}
    }
}
