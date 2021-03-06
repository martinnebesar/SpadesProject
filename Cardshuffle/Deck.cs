﻿using System;

public class Deck
{
    private Card[] deck;
    private int currentCard;
    private const int NUMBER_OF_CARDS = 52;
    private Random ranNum;

    public Deck()
    {
        string[] faces = { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };
        string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades" };
        deck = new Card[NUMBER_OF_CARDS];
        currentCard = 0;
        ranNum = new Random();
        for (int count = 0; count < deck.Length; count++)
            deck[count] = new Card(faces[count % 13], suits[count / 13]);
    }
    public void Shuffle()
    {
        currentCard = 0;
        for (int first = 0; first<deck.Length; first++)
        {
            int second = ranNum.Next(NUMBER_OF_CARDS);
    Card temp = deck[first];
    deck[first] = deck[second];
            deck[second] = temp;
        }
        }

    public Card DealCard()
    {
        if (currentCard < deck.Length)
            return deck[currentCard++];
        else
            return null;
    }
}