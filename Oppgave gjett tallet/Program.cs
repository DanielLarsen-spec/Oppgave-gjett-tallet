using Oppgave_gjett_tallet;

var oppgave = new GjettTallet();
Random rand = new Random();
int randomNumber = rand.Next(0, 100);

while (true)
{
oppgave.Run(randomNumber);
   
}
    
   




