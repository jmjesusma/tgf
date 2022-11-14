using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ThisCard : MonoBehaviour
{   
    public List<Card> thisCard= new List<Card>();
    public int thisId;

    public int id;
    public string cardName;
    public int cost;
    public int power;
    public string cardDescription;

    public Text nameText;
    public Text costText;
    public Text powerText;
    public Text descriptionText;

    public Sprite thisSprite;
    public Image thisImage;

    public Image frame;

    public bool cardBack;
    //public static bool staticCardBack;
    CardBack CardBackScript;
    // Start is called before the first frame update
    void Start()
    {   CardBackScript = GetComponent<CardBack>();
       thisCard[0]=CardData.cardList[thisId]; 
    }

    // Update is called once per frame
    void Update()
    {
        id = thisCard[0].id;
        cardName=thisCard[0].cardName;
        cost = thisCard[0].cost;
        power=thisCard[0].power;
        cardDescription= thisCard[0].cardDescription;  
        
        thisSprite=thisCard[0].thisImage;
    
    nameText.text=""+cardName;
    costText.text=""+cost;
    powerText.text=""+power;
    descriptionText.text=""+cardDescription;
    thisImage.sprite=thisSprite;

    
   // staticCardBack=cardBack;
   CardBackScript.UpdateCard(cardBack); 
    }
}
