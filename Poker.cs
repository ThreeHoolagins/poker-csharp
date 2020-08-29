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
      Console.WriteLine("\nPick An option: ");
      Console.WriteLine("1. How to play 2. Play 3. Test");

      string option = Console.ReadLine();

      if (option.Equals("1")) {
        howTo();
      }
      else if (option.Equals("2")) {
        startMatch();
      }
      else if (option.Equals("3")) {
        testCards();
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
    // testCards();
  }

  static void testCards() {
    Deck cardDeck = new Deck(10);
    cardDeck.printDeck();
  }
}

class Card {
  string suit;
  string card;

  public Card(string inputSuit, string inputCard){
    suit = inputSuit;
    card = inputCard;
  }

  public void printCard(){
    string print = card+" of "+suit;
    Console.WriteLine(print);
  }
}

class Deck {
  static string[] suits = {"Hearts", "Diamonds", "Spades", "Clubs"};
  static string[] cards = {"Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"};
  Card[] currentDeck;
  bool[,] hasCard = new bool[4,13];

  public Deck(int numberOfCards = 52, bool hasJokers = false) {
    // this methoud makes a deck but only with enough cards to play the game to save game space
    // Defult Paramaters make a standard set of cards

    //Initalize bool array to make sure we are safe on duplicates
    //Developer's Note: Tried to do this with foreach loops and gave up
    for (int i = 0; i < 4; i++) {
      for (int j = 0; j < 13; j++) {
        hasCard[i,j] = false;
      }
    }
    currentDeck = new Card[numberOfCards];

    // Pick up random cards
    Random rng = new Random();
    for (int i = 0; i < numberOfCards; i++) {
      int randSuit = rng.Next(0,4);
      int randCard = rng.Next(0,13);

      // Confirm that we don't have duplicates, loop until we don't again
      while(hasCard[randSuit,randCard]) {
        randSuit = rng.Next(0,4);
        randCard = rng.Next(0,13);
      }

      currentDeck[i] = new Card(suits[randSuit], cards[randCard]);
      hasCard[randSuit,randCard] = false;
    }
  }

  public void printDeck() {
    foreach (Card card in currentDeck) {
      card.printCard();
    }
  }
}
