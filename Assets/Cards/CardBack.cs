using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardBack : MonoBehaviour
{
    public GameObject cardBack;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void UpdateCard (bool updown)
    {
        cardBack.SetActive(updown);
    }
    // Update is called once per frame
   /* void Update()
    {
        if(ThisCard.staticCardBack==true) 
        {
            cardBack.SetActive(true);
        }else
        {
            cardBack.SetActive(false);
        }
    }*/
}