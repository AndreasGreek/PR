using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace Hostel
{
    //Class  for work with files
    class Files
    {
        //method for work recording of information to file;
        public void RecordToFile(List<Occupant> list, String filePath)
        {
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }

            FileStream fs = new FileStream(filePath, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            try
            {
                foreach (Occupant occupant in list)
                {
                    sw.WriteLine(occupant.PassportID);
                    sw.WriteLine(occupant.Name);
                    sw.WriteLine(occupant.Surname);
                    sw.WriteLine("{0,10:dd/MM/yyyy}", occupant.BirthDay);
                    sw.WriteLine(occupant.Age);
                    sw.WriteLine(occupant.Phone);
                    sw.WriteLine(occupant.Email);
                }
            }
            catch (IOException exc)
            {
                Console.WriteLine(exc.Message);
            }
            sw.Close();
            fs.Close();
        }

        public IEnumerable<Occupant> ReadFromFile(String filePath)
        {
            if (File.Exists(filePath))
            {
                //string line;
                //String info = "";
                //FileStream fs = new FileStream(filePath, FileMode.Open);
                StreamReader sr = new StreamReader(filePath);

                List<Occupant> occupants = new List<Occupant>();
                try
                {
                String[] ReadableFile = File.ReadAllLines(filePath, Encoding.Default);
                int ClientQuantity = ReadableFile.Length / 10;
                for (int i = 0; i < ClientQuantity; i++)
                {
                    Occupant occupant = new Occupant();
                    
                    for (int caseSwitch = 0; caseSwitch < 10; caseSwitch++)
                    {
                        switch (caseSwitch)
                        {
                            case 0:
                                occupant.PassportID = ReadableFile[(i * 10 + caseSwitch)];
                                //client.PassportID = sr.ReadLine();
                                break;
                            case 1:
                                occupant.Name = ReadableFile[i * 10 + caseSwitch];
                                //client.Name = sr.ReadLine();
                                break;
                            case 2:
                                occupant.Surname = ReadableFile[i * 10 + caseSwitch];
                                //client.Surname = sr.ReadLine();
                                break;
                            case 3:
                                String BDate = ReadableFile[i * 10 + caseSwitch];
                                //String BDate = sr.ReadLine();
                                BDate = Convert.ToDateTime(BDate, CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat).ToString("dd/MM/yyyy");
                                occupant.BirthDay = Convert.ToDateTime(BDate, CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat);
                                break;
                            case 4:
                                occupant.Age = Convert.ToInt32(ReadableFile[i * 10 + caseSwitch]);
                                //client.Age = Convert.ToInt32(sr.ReadLine());
                                break;
                            case 5:
                                occupant.Phone = ReadableFile[i * 10 + caseSwitch];
                                //client.Phone = sr.ReadLine();
                                break;
                            case 6:
                                occupant.Email = ReadableFile[i * 10 + caseSwitch];
                                //client.Email = sr.ReadLine();
                                break;
                            case 7:
                                //client.CardNumber = ReadableFile[i * 10 + caseSwitch];
                                //client.CardNumber = sr.ReadLine();
                                break;
                            case 8:
                                //client.Opened = Convert.ToDateTime(Convert.ToDateTime(ReadableFile[i * 10 + caseSwitch]).ToShortTimeString());
                                //client.Opened = Convert.ToDateTime(sr.ReadLine());
                                break;
                            case 9:
                                //client.OpenedBefore = Convert.ToDateTime(Convert.ToDateTime(ReadableFile[i * 10 + caseSwitch]).ToShortTimeString());
                                //client.OpenedBefore = Convert.ToDateTime(sr.ReadLine());
                                break;
                        }
                    }
                    occupants.Add(occupant);
                }

                
                    //int counter = 0;
                    //Console.WriteLine("\n|{0, 12}|{1,12}|{2,12}|{3,12}|{4,14}|{5,12}|{6,12}|{6,12}|{6,10}|", "Name", "Surname", "BirthDay", "Age", "Phone", "Email", "PassportID", "CardNumber", "CardOpened", "Card IsValidBefore");
                    
                    
                    //while ((line = sr.ReadLine()) != null)
                    //{   
                    //    info = info + " | " + line;
                    //    counter++;
                    //    if (counter % 10 == 0) { Console.WriteLine("\n{0,12}|", info); info = ""; }
                    //}
                }

                catch (IOException exc)
                {
                    Console.WriteLine(exc.Message);
                }

                foreach (Occupant occupant in occupants)
                {
                    yield return occupant;
                }
                sr.Close();
            }
            else
            {
                Console.WriteLine("\nImpossible to open the file");
            }
        }
    }
}
