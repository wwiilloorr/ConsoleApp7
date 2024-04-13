using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
namespace ConsoleApp7
{
    class NotesManager
    {
        List<string> list = new List<string>();
        public void addnewNote()
        {
            Console.WriteLine("You just choosed Create new note");
            Console.WriteLine("Enter your note:  ");
            list.Add(Console.ReadLine());
            list.Add("--- ================================ ---");
        }
        public void showNotes()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("No notes avaible :(");
            }
            else
            {
                list.ForEach(item => Console.WriteLine(item));
            }
        }
        public void deleteallNotes()
        {
            list.Clear();
            Console.WriteLine("You just deleted all your notes!");
        }
        public void exitfromProgram()
        {
            Console.WriteLine("Bye Bye,Have a nice day");
            Environment.Exit(0);
        }
        

        public void showMenu()
            
        {
            int choose = 0;

           


            Console.Write("1 - Start; 2 - Leave: ");
            choose = Convert.ToInt32(Console.ReadLine());
            if (choose == 1)
            {
                mainWork();
            }
            else if (choose == 2)
            {
                exitfromProgram(); 
            }
            else
            {
                checkError();
            }
        }
        public void mainWork()
        {
           

            
                Console.Write("Do a new note - 1; Show all notes - 2;Delete all notes - 3;Leave - 4:   ");
                int choose = Convert.ToInt32(Console.ReadLine());

                if (choose == 1)
                {
                  addnewNote();
                }
                else if (choose == 2)
                {
                showNotes(); 
                }
                else if (choose == 3)
                {
                   deleteallNotes();
                }
                else if (choose == 4)
                {
                    Environment.Exit(0);
                }
                else
                {
                    checkError();
                }
            
        }
        public void checkError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error!");
            Console.ResetColor();
        }
    }

    class Note
    {
        





    }


    
    internal class Program
    {
        
       
        
       
        static void Main(string[] args)
        {
            NotesManager obj = new NotesManager();           
                obj.showMenu();                   
        }
    }
}
