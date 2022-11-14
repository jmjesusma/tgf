using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCards : MonoBehaviour
{

    public GameObject Card1;
    public GameObject Card2;
    public GameObject PlayerArea;
    public GameObject EnemyArea;

    List<GameObject>cards=new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        cards.Add(Card1);
        cards.Add(Card2);    
        /*   string agtname;
            Dictionary<string, Agent> agents;
            int lim; //limit 
            for(int i = 1; i<= lim; i++) 
            { 
                agtname = "agent_" + i.ToString(); //You can use int class method instead of System.Convert
                agents.Add(agtname, new Agent());
            }*/
    }

    public void OnClick()
    {
        for(int i = 0; i < 5; i++) {
        GameObject playerCard= Instantiate(cards[Random.Range(0, cards.Count)], new Vector3(0,0,0),Quaternion.identity);
        playerCard.transform.SetParent(PlayerArea.transform, false);

        GameObject enemyCard= Instantiate(cards[Random.Range(0, cards.Count)], new Vector3(0 , 0 , 0), Quaternion.identity);
        enemyCard.transform.SetParent(EnemyArea.transform, false);
        
        }
  }


}
