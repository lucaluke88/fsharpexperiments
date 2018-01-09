// Fun with F#
open System
let main() =
   Console.Write("What's your name? ")
   let name = Console.ReadLine()
   Console.Write("Hello, {0}\n", name)
   Console.WriteLine(System.String.Format("Big Greetings from {0} and {1}", "Planet Namek", "Your Absolute God"))
   Console.WriteLine(System.String.Format("|{0:yyyy-MMM-dd}|", System.DateTime.Now))
   
   // Musical Section
   Console.Beep(3000,100);
   Console.Beep(2500,100);
   Console.Beep(3000,100);
   Console.Beep(2000,500);
   Console.Beep(3000,100);
   Console.Beep(2500,100);
   Console.Beep(3000,100);
   Console.Beep(2000,2000);
main()