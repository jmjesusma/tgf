using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]

public class Card
{
    public int id;
    public string cardName;
    public int cost;
    public int power;
    public string cardDescription;

    public string color;
    public Sprite thisImage;

    public Card()
    {


    }
    public Card(int Id, string CardName, int Cost, int Power, string CardDescription, Sprite ThisImage, string Color)
    {
        id=Id;
        cardName=CardName;
        cost=Cost;
        power=Power;
        cardDescription=CardDescription;

        thisImage=ThisImage;

        color = Color;

    }
}
