using System;

class Poker {

  static string userName;
  static void Main() {
    Menu();
  }

  static void PrintName() {
    // This methoud takes the name from the user, and prints it back to them
    Console.WriteLine("Hi! Welcome to the poker table, what is your name?");

    string userName = Console.ReadLine();
    if (userName.Equals("stop")) {
      Environment.Exit(0);
    }

    Console.WriteLine("Welcome " + userName);
  }
  static void Menu() {
    // This methoud is the basic commandline menu for our poker game
    Console.WriteLine("Hi! Welcome to the poker table, what is your name?");

    userName = Console.ReadLine();

    Console.WriteLine("Welcome " + userName);

    bool continueLoop = true;
    while (continueLoop) {
      Console.WriteLine("Pick An option: ");
      Console.WriteLine("1. How to play 2. Next");

      string option = Console.ReadLine();

      if (option.Equals("1")) {
        howTo();
      }
      else if (option.Equals("2")) {
        Console.WriteLine("Nah");
      }
      else if (option.Equals("q")) {
        continueLoop = false;
      }
      else {
        Console.WriteLine(option + " Is not a proper input");
      }
    }

  }

  static void howTo(){
    Console.WriteLine("it's poker dummi");
  }
}
