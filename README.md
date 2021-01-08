# BlackjackCS

    /Problem
        - Make a game of Black Jack.

        - The game should be played with a standard deck of playing cards (52).

        - The house should be dealt two cards, hidden from the player until the house reveals its hand.

        - The player should be dealt two cards, visible to the player.

        - The player should have a chance to hit (i.e. be dealt another card) until they decide to stop or they bust (i.e. their total is over 21). At which point they lose regardless of the dealer's hand.

        - When the player stands, the house reveals its hand and hits (i.e. draw cards) until they have 17 or more.

        - If dealer goes over 21 the dealer loses.

        - The player should have two choices: "Hit" and "Stand."

        - Consider Aces to be worth 11, never 1.

        - The app should display the winner. For this mode, the winner is who is closer to a blackjack (21) without going over.

       - Ties go to the DEALER

       - There should be an option to play again. This should start a new game with a new full deck of 52 shuffled cards and new empty hands for the dealer and the player.

    /Examples
     - If player starts with a 2 of Spades and a 9 of Hearts and then hit once to get a 8 of Hearts before staying. Then the dealer revealed the 7 of Clubs and Jack of Diamonds, the player wins and it asks to play again.
     - If a player gets 21 and the house gets 21 is it a tie? No, tie goes to the dealer.
     - If the player gets 18 and the dealer gets 16 what happens? The dealer has to hit again.
     - If the player gets 19 and the dealer gets 21 what happens? Dealer wins.
     - If player gets 15 and stays and the dealer gets 15 what happens? The dealer has to hit and may win or bust.
     - If the player is dealt 21 and the dealer gets 19 what happens? The player wins.

    /Data Structure
      - Card Class : with 2 properties FACE and SUITE and one Property, VALUE that will be assigned what the card is worth.
      - Deck Class :For the deck of cards I will have 2 Methods 1. To draw a card and 2. To Shuffle/Reset
      - Player Class:  to hold the hand (list of cards) Make a method in the player class to calculate the hands value.
      - Game Class:  That handles the rules and handles the player/dealer input. Methods for bust, win etc..?
      - Handle the Play Again? In a Loop as part of main method



    /Algorithm
      -
      - Create a deck of 52 cards. Face cards are worth 10 and Aces are worth 11 - never 1. Others cards are worth their value.
      - Shuffle the cards
      - Object of the game is to get 21 or as close to 21 without going over 21 or you bust and lose.
      - The dealer deals 2 cards to themselves. Keeps hidden.
      - Dealer deals 2 cards to player, visible to player.
      - Player chooses to hit or stand until they bust (as many times as they like).
      - When the player stands, the dealer reveals his cards and hits until they have 17 or more or busts.
      - If the dealer or player goes over 21 they lose.
      - Tie goes to the dealer.
      - The app should display the winner
      - Option to play again, if yes, repeat the process from the beginning.
      - Reset the game. New full deck and empty hands for dealer and player.
      -
      -
      -
      -

    Code

---
