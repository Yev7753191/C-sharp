﻿namespace Ex_6_1;
class Program
{
    static void Main(string[] args)
    {
        List<int> ages = new();

        Console.WriteLine("# Help to fill the ages of a programing course students. #");
        Console.WriteLine("- If there's a student whose age you're not sure about just take your best guess");
        Console.WriteLine("- when you're done just type ' exit '");
        do{
            int i=1;
            string? inpt;

            Console.Write("Age for student nrº{0}: ",i);
            try{
                inpt = Console.ReadLine();
                ages.Add(int.Parse(inpt)); 
                i++;
            }
            catch (ArgumentNullException){
                Console.WriteLine("Ups... You have seem to forgot to insert a value...");
            }
            catch(FormatException){
                if(inpt.ToLower() == "exit" || inpt.ToLower() == "end")
                    break;
                Console.WriteLine("You seem chatty, have you finished yet?");
            }
            catch(Exception){
                Console.WriteLine("What happened?\nHuh....\nTry again.");
            }
        }while(true);
        Console.WriteLine("\nLets see what you have done for today.\n");
        for(int i=0; i<ages.Count; i++){
            Console.WriteLine($"Strudent nº{i+1} is {ages[i]} years old.");
        }
        Console.WriteLine("\nThat's great work\nLets just order them by their age, so we can group them better later.\n###");
        ages.Sort();
        Console.WriteLine("Okay. So now:");
        for(int i=0; i<ages.Count; i++){
            Console.WriteLine($"The student with age {ages[i]} is logged as student nº{i+1}");
        }
        Console.WriteLine("Perfect, that's much more organized.");
        Console.WriteLine("\n\nThank you for your help! Bye, bye.");
    }
}
