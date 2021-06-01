using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CardGameManager : MonoBehaviour {

    public Text text;
    
    public GameObject Bu;
    
    public static int x=0,f=0;
    private const int winCardCouples = 6;
    public int curCardCouples = 0;
    private bool canPlayerClick = true;

    public Sprite BackSprite;
 
    public Sprite[] FrontSprites;

    public GameObject CardPre;
    public Transform CardsView;
    private List<GameObject> CardObjs;
    private List<card_level1simple1> FaceCards;


    public GameObject textDisplay;
    public int secondsleft = 30;

    public bool takingAway;
   
    void Start () {
        Bu.SetActive(false);
        CardPre.SetActive(true);
        textDisplay.GetComponent<Text>().text = "0:" + secondsleft;
        CardObjs = new List<GameObject>();
        FaceCards = new List<card_level1simple1>();

        
        for (int i = 0; i < 6; i++)
        {
            Sprite FrontSprite = FrontSprites[i];
            for (int j = 0; j < 2; j++)
            {
                
                GameObject go = (GameObject)Instantiate(CardPre);
                
                card_level1simple1 card = go.GetComponent<card_level1simple1>();
                card.InitCard(i, FrontSprite, BackSprite);
                card.cardBtn.onClick.AddListener(() => CardOnClick(card));

                CardObjs.Add(go);
            }
        }

        while (CardObjs.Count > 0)
        {
            
            int ran = Random.Range(0, CardObjs.Count);
            GameObject go = CardObjs[ran];
            
            go.transform.SetParent(CardsView);
            
           
            go.transform.localPosition = Vector3.zero;
            go.transform.localScale = Vector3.one;
            
            CardObjs.RemoveAt(ran);
        }
    }


    void Update()
    {
        if(takingAway == false && secondsleft > 0)
        {
            if(curCardCouples < 6)
                StartCoroutine(TimeTake());
        }
        if(x == 0 && secondsleft == 0)
        {
            text.text = "please restart game. (PRESS PAUSE AND MENU)";
            CardPre.SetActive(false);
        }
        if(secondsleft == 0 && curCardCouples < 6)
        {
            CardPre.SetActive(false);
            text.text = "you lose! can't to next level please restart";
            Bu.SetActive(true);
        }
    }

    private void CardOnClick(card_level1simple1 card)
    {
        if (canPlayerClick)
        {
            
            card.SetFanPai();
            
            FaceCards.Add(card);
           
            if (FaceCards.Count == 2)
            {
                canPlayerClick = false;
                StartCoroutine(JugdeTwoCards());
            }
        }
    }

    IEnumerator JugdeTwoCards()
    {
        x=1;
        x++;
        
        card_level1simple1 card1 = FaceCards[0];
        card_level1simple1 card2 = FaceCards[1];

        if (card1.ID == card2.ID)
        {
            text.text = "good";
            
            yield return new WaitForSeconds(0.5f);
            curCardCouples++;
            if (curCardCouples == winCardCouples && secondsleft > 0)
            {
               
                text.text = "you win! go to next level(wait 5 seconds)";
                 yield return new WaitForSeconds(5f);
                 SceneManager.LoadScene("UILevel");
                 f = 1;             
            }
        }
        else
        {
            text.text = "fail...";
            yield return new WaitForSeconds(1f);
            card1.SetRecover();
            card2.SetRecover();
        }

        if(secondsleft == 0 && curCardCouples < 6)
        {
            CardPre.SetActive(false);
            text.text = "you lose! can't to next level please restart(wait 3 seconds)";
             yield return new WaitForSeconds(3f);
             SceneManager.LoadScene("game-level1SIMPLE");
        }
        FaceCards = new List<card_level1simple1>();
        canPlayerClick = true;
    }


    IEnumerator TimeTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsleft -= 1;
        textDisplay.GetComponent<Text>().text = "0:" + secondsleft;
        takingAway = false;
    }

    public void clickBack()
    {
        SceneManager.LoadScene("game-level1simple");
    }
}