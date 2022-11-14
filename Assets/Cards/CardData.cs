using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardData : MonoBehaviour
{
    // Start is called before the first frame update
    public static List<Card> cardList =new List<Card> ();

    void Awake() {
        cardList.Add(new Card(0, "Dino", 0, 0, "Hola",Resources.Load<Sprite>("Ilusor"), "None"));
        cardList.Add(new Card(1, "Cninja", 0, 0, "None",Resources.Load<Sprite>("Ilusor"), "Red"));
        cardList.Add(new Card(2, "Illusor", 2, 0, "Es un ilusor",Resources.Load<Sprite>("Ilusor"), "Blue"));
        cardList.Add(new Card(3, "timeK", 0, 0, "None",Resources.Load<Sprite>("Ilusor"),"Yellow"));
        cardList.Add(new Card(4, "Hunter", 0, 0, "None",Resources.Load<Sprite>("Ilusor"),"Purple"));
        cardList.Add(new Card(5, "Mecha", 0, 0, "None",Resources.Load<Sprite>("Ilusor"),"Purple"));

    }
}
