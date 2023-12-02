// See https://aka.ms/new-console-template for more information

String line;
int game = 1;
char last_char;
int myInt;
bool isNumerical;
int totalrounds = 0;
string lastvalue;
string round;

try
{
    //Pass the file path and file name to the StreamReader constructor
    StreamReader sr = new StreamReader("./input.txt");
    //Read the first line of text
    line = sr.ReadLine();
    //Continue to read until you reach end of file
    while (line != null)
    {
        //write the line to console window
        Console.WriteLine(line);
        //Read the next line
        line = sr.ReadLine();

        string teil1 = line.Substring(0, line.IndexOf(':'));
        last_char = teil1[teil1.Length - 1];

        string allrounds = line.Substring(last_char, line.Length - 1);
        foreach (char c in allrounds)
        {
            if(c == ';')
            {
                
                totalrounds++;
            }
        }

        for(int i = 0; i < totalrounds; i++)
        {
            
        }


        string teil2 = line.Substring(last_char, line.IndexOf(','));
        isNumerical = int.TryParse(teil2, out myInt);

        

        game++;
    }
    //close the file
    sr.Close();
    Console.ReadLine();
}
catch(Exception e)
{
    Console.WriteLine("Exception: " + e.Message);
}
finally
{
    Console.WriteLine("Executing finally block.");
}

//string game = "BlauesAuto - Rotes Auto";
//string teil = text.Substring(0, text.IndexOf('-'));

