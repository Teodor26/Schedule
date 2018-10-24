using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Logic
{
    public class Schedule
    {
        private string login;
        private string password;        
        public string student;

        public int NumberGroups = 560;
        public int[] newGroup = new int[6];


        public string[] firstGroup = new string[20];       
        public string[] secondGroup = new string[15];       
        public string[] thirdGroup = new string[15];
        public string[] fourthGroup = new string[5];
        public string[] fifthGroup = new string[5];
        public string[] nullGroup = new string[5];       


        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (value == "admin")
                    password = value;
               
            }
        }

        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                if (value == "admin")
                    login = value;
                
            }
        }       

        public bool SystemIn()
        {

            if (Login == "admin" || Password=="admin")
                return false;
            else
                return true;

        }

        public void MadeGroup()
        {
            for (int i = 0; i <= 5; i++)
            {
                newGroup[i] = NumberGroups++;                
            }
        }

        public void ShowGroup()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(newGroup[i]); ;
            }            
        }

        public void GetInGroup(int chossenGroup)
        {

            if (chossenGroup == newGroup[0])
            {
                for (int i = 0; i < nullGroup.Length; i++)
                {
                    if (nullGroup[i] == null)
                    {
                        nullGroup[i] = student;
                        break;
                    }
                    else
                        continue;
                }
                Console.Clear();
                Console.WriteLine($"The list of {newGroup[0]}");
                for (int j = 0; j < nullGroup.Length; j++)
                {
                    if (nullGroup[j] != null)
                    {
                                               
                        Console.WriteLine($"{j+1}.{nullGroup[j]}");                        
                    }
                    else
                        break;

                }
            }

           else if (chossenGroup == newGroup[1])
            {
                for (int i = 0; i < firstGroup.Length; i++)
                {
                    if (firstGroup[i] == null)
                    {
                        firstGroup[i] = student;
                        break;
                    }
                    else
                        continue;
                }
                Console.Clear();
                Console.WriteLine($"The list of {newGroup[1]}");
                for (int j = 0; j < firstGroup.Length; j++)
                {
                    if (firstGroup[j] != null)
                    {
                        Console.WriteLine($"{j + 1}.{firstGroup[j]}");

                    }
                    else
                        break;
                }
            }
            else if(chossenGroup == newGroup[2])
            {
                for (int i = 0; i < secondGroup.Length; i++)
                {
                    if (secondGroup[i] == null)
                    {
                        secondGroup[i] = student;
                        break;
                    }
                    else
                        continue;
                }
                Console.Clear();
                Console.WriteLine($"The list of {newGroup[2]}");
                for (int j = 0; j < secondGroup.Length; j++)
                {
                    if (secondGroup[j] != null)
                    {
                        Console.WriteLine($"{j + 1}.{secondGroup[j]}");

                    }
                    else
                        break;
                }
            }

            
            else if (chossenGroup == newGroup[3])
            {
                for (int i = 0; i < thirdGroup.Length; i++)
                {
                    if (thirdGroup[i] == null)
                    {
                        thirdGroup[i] = student;
                        break;
                    }
                    else
                        continue;
                }
                Console.Clear();
                Console.WriteLine($"The list of {newGroup[3]}");
                for (int j = 0; j < thirdGroup.Length; j++)
                {
                    if (thirdGroup[j] != null)
                    {
                        Console.WriteLine($"{j + 1}.{thirdGroup[j]}");

                    }
                    else
                        break;
                }
            }

            else if (chossenGroup == newGroup[4])
            {
                for (int i = 0; i < fourthGroup.Length; i++)
                {
                    if (fourthGroup[i] == null)
                    {
                        fourthGroup[i] = student;
                        break;
                    }
                    else
                        continue;
                }
                Console.Clear();
                Console.WriteLine($"The list of {newGroup[4]}");
                for (int j = 0; j < fourthGroup.Length; j++)
                {
                    if (fourthGroup[j] != null)
                    {
                        Console.WriteLine($"{j + 1}.{fourthGroup[j]}");

                    }
                }
            }

            else if (chossenGroup == newGroup[5])
            {
                for (int i = 0; i < fifthGroup.Length; i++)
                {
                    if (fifthGroup[i] == null)
                    {
                        fifthGroup[i] = student;
                        break;
                    }
                    else
                        continue;
                }

                Console.Clear();
                Console.WriteLine($"The list of {newGroup[5]}");
                for (int j = 0; j < fifthGroup.Length; j++)
                {
                    if (fifthGroup[j] != null)
                    {
                        Console.WriteLine($"{j + 1}.{fifthGroup[j]}");
                      
                    }
                    else
                        break;
                }
            }
           
        }



    }





    }

