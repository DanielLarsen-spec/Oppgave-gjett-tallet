using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave_gjett_tallet
{
    internal class GjettTallet
    {
       
       


        public void Run(int randomNumber)
        {
            
            Console.WriteLine("Gjett tallet! Du skal gjette tallet 1-100");
            Console.WriteLine("skriv inn ett tall:");
            _theNumber(randomNumber);
           
        }
        void _theNumber(int randomNumber)
        {
             int userinput = Convert.ToInt32(Console.ReadLine());
            


            if (userinput == randomNumber)
            {
                Console.WriteLine("Correct");
                _continueChoice();  
            }
            else if (userinput > randomNumber)
            {
                Console.WriteLine("Your input is too high!");

            }
            else if (userinput < randomNumber)
            {
                Console.WriteLine("Your input is too low");

            }
        }
        void _continueChoice()
        {
           var menyChoice = Console.ReadLine();
            switch(menyChoice)
            {
                case "1":
                    Console.WriteLine("new round");
                    Console.ReadLine();
                    break;

                case "2":
                    Console.WriteLine("Ending game...");
                    return;
                    break ;

               
                    
            }

        }

       
    }
}

