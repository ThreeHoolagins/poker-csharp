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
      Console.WriteLine("1. How to play 2. Play");

      string option = Console.ReadLine();

      if (option.Equals("1")) {
        howTo();
      }
      else if (option.Equals("2")) {
        startMatch();
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

  static void startMatch(){

  }
}

class Card {
  string suit;
  string card;

  new Card(string inputSuit, string inputCard){
    suit = inputSuit;
    card = inputCard;
  }

  void printCard(){
    string print = $"{card} of {suit}";
    Console.WriteLine(print);
  }
}

class Deck {
  static string[] suits = {"Hearts", "Diamonds", "Spades", "Clubs"};
  static string[] cards = {"Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"};
  Card[] currentDeck;
  bool[][] hasCard = new bool[4][13];

  new Deck(int numberOfCards = 52, bool hasJokers = false) {
    // this methoud makes a deck but only with enough cards to play the game to save game space
    // Defult Paramaters make a standard set of cards

    //Initalize bool array to make sure we are safe on duplicates
    foreach (card in hasCard) {
      card = false;
    }
    currentDeck = new Card[numberOfCards];

    // Pick up random cards
    var rng = new Random();
    for (int i = 0; i < numberOfCards; i++) {
      int randSuit = rng.next(0,4);
      int randCard = rng.next(0,13);

      // Confirm that we don't have duplicates, loop until we don't again
      while(hasCard[randSuit][randCard]) {
        int randSuit = rng.next(0,4);
        int randCard = rng.next(0,13);
      }

      currentDeck[i] = new Card(suits[randSuit], cards[randCard]);
      hasCard[randSuit][randCard] = false;
    }
  }

  void printDeck() {
    foreach (card in currentDeck) {
      card.PrintCard;
    }
  }
}
