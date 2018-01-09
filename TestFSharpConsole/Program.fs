// Fun with F#
open MyConsoleMusic
open System

let main() =
   Console.Write("What's your name? ")
   let name = Console.ReadLine()
   Console.Write("Hello, {0}\n", name)
   Console.WriteLine(System.String.Format("Big Greetings from {0} and {1}. Enjoy our music!", "Planet Namek", "Your Absolute God"))
   //Console.WriteLine(System.String.Format("|{0:yyyy-MMM-dd}|", System.DateTime.Now))
   Console.WriteLine("Song n°1 : Ascending Simple Notes");
   MyConsoleMusic.play_track1_ascending_notes_simple();
   MyConsoleMusic.play_pause(1000);
   Console.WriteLine("Song n°2 : Descending Simple Notes");
   MyConsoleMusic.play_track2_descending_notes_simple();
   MyConsoleMusic.play_pause(1000);
   Console.WriteLine("Song n°3 : AsceDescending Simple Notes");
   MyConsoleMusic.play_track3_ascedescending_notes_simple();
   MyConsoleMusic.play_pause(1000);
   Console.WriteLine("Song n°4 : Jingle Bells");
   MyConsoleMusic.play_track4_jingle_bells();
   MyConsoleMusic.play_pause(1000);
main()