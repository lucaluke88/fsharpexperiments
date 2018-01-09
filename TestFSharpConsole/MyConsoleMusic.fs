module MyConsoleMusic

open System

// Play tune (frequency, milliseconds)
let play_freq(freq,time) = 
    Console.Beep(freq,time);

// Play tunes
let play_tune(tune_text,time) =
    match tune_text with
    | "do" -> Console.Beep(261,time);
    | "rebemolle" -> Console.Beep(277,time);
    | "re" -> Console.Beep(293,time) ;
    | "mibemolle" -> Console.Beep(311,time);
    | "mi" -> Console.Beep(329,time);
    | "fa" -> Console.Beep(349,time) ;
    | "solbemolle" -> Console.Beep(369,time);
    | "sol" -> Console.Beep(392,time);
    | "labemolle" -> Console.Beep(415,time) ;
    | "la" -> Console.Beep(440,time) ;
    | "pause" -> Console.Beep(38,time) ;
    | "sibemolle" -> Console.Beep(466,time) ;
    | "si" -> Console.Beep(493,time) ;
    | _ -> Console.Beep(1,1) ;

// Musical Section

let play_pause(time) =
    play_tune(@"pause",time);

let play_track1_ascending_notes_simple() = 
   play_tune(@"do",300);
   play_tune(@"re",300);
   play_tune(@"mi",300);
   play_tune(@"fa",300);
   play_tune(@"sol",300);
   play_tune(@"la",300);
   play_tune(@"si",300);

let play_track2_descending_notes_simple() = 
   play_tune(@"si",300);
   play_tune(@"la",300);
   play_tune(@"sol",300);
   play_tune(@"fa",300);
   play_tune(@"mi",300);
   play_tune(@"re",300);
   play_tune(@"do",300);
  
let play_track3_ascedescending_notes_simple() = 
    play_track1_ascending_notes_simple();
    play_track2_descending_notes_simple();

// http://www.music-for-music-teachers.com/jingle-bells-sheet-music.html
let play_track4_jingle_bells() =
    let base_duration = 300;
    play_tune(@"mi", base_duration);
    play_tune(@"mi", base_duration);
    play_tune(@"mi", base_duration * 2);
    play_tune(@"mi", base_duration);
    play_tune(@"mi", base_duration);
    play_tune(@"mi", base_duration * 2);
    play_tune(@"mi", base_duration);
    play_tune(@"sol", base_duration);
    play_tune(@"do", base_duration);
    play_tune(@"re", base_duration);
    play_tune(@"re", base_duration * 4);
    play_tune(@"fa", base_duration);
    play_tune(@"fa", base_duration);
    play_tune(@"fa", base_duration);
    play_tune(@"fa", base_duration);
    play_tune(@"fa", base_duration);
    play_tune(@"mi", base_duration);
    play_tune(@"mi", base_duration);
    play_tune(@"mi", base_duration);
    play_tune(@"mi", base_duration);
    play_tune(@"re", base_duration);
    play_tune(@"re", base_duration);
    play_tune(@"mi", base_duration);
    play_tune(@"re", base_duration * 2);
    play_tune(@"sol", base_duration * 2);
    play_tune(@"mi", base_duration);
    play_tune(@"mi", base_duration);
    play_tune(@"mi", base_duration * 2);
    play_tune(@"mi", base_duration);
    play_tune(@"mi", base_duration);
    play_tune(@"mi", base_duration * 2);
    play_tune(@"mi", base_duration);
    play_tune(@"sol", base_duration);
    play_tune(@"do", base_duration);
    play_tune(@"re", base_duration);
    play_tune(@"re", base_duration * 4);
    play_tune(@"fa", base_duration);
    play_tune(@"fa", base_duration);
    play_tune(@"fa", base_duration);
    play_tune(@"fa", base_duration);
    play_tune(@"fa", base_duration);
    play_tune(@"mi", base_duration);
    play_tune(@"mi", base_duration);
    play_tune(@"mi", base_duration);
    play_tune(@"sol", base_duration);
    play_tune(@"sol", base_duration);
    play_tune(@"fa", base_duration);
    play_tune(@"re", base_duration);
    play_tune(@"do", base_duration * 4);
