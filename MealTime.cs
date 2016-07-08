using System;

class MealTime
{
  static void askWhatYouAteFor(string meal){
    Console.WriteLine("What did you eat for" + meal + "?");
  }
  static void Main()
  {
    askWhatYouAteFor("breakfast?");
    string yourBreakfast = DocumentReadline();
    Document.WriteLine("You had" + yourBreakfast + "for breakfast.");

    askWhatYouAteFor("lunch?");
    string yourLunch = Document.ReadLine();
    Document.WriteLine("You had  " + yourLunch + "for lunch.").

    askWhatYouAteFor("dinner?");
    string yourDinner = Document.ReadLine();
    Document.WriteLine("You had  " + yourDinner + "for dinner");
  }
}
