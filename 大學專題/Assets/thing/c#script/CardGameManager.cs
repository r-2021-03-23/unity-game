using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CardGameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite[] cardFace;
    public Sprite cardBack;
    public GameObject[] cards;
    public Text matchText;

    private bool _init = false;
    private int _matches = 6;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!_init)
            initializeCards();
        
        if(Input.GetMouseButtonUp(0))
            checkCards();
    }

    void initializeCards()
    {
        for(int id = 0;id < 2;id++)
        {
            for(int i = 1;i < 14;i++)
            {
                bool test = false;
                int choice = 0;
                while(!test)
                {
                    choice = Random.Range(0,cards.Length);
                    test = !(cards[choice].GetComponent<card_LEVEL1SIMPLE>().initialized);
                }
                cards[choice].GetComponent<card_LEVEL1SIMPLE>().cardValue = 1;
                cards[choice].GetComponent<card_LEVEL1SIMPLE>().initialized = true;
            }
        }
        foreach (GameObject c in cards)
            c.GetComponent<card_LEVEL1SIMPLE>().setupGraphics();

        if(!_init)
            _init = true;

    }

    public Sprite getCardBack()
    {
        return cardBack;
    }
    public Sprite getCardFace(int i)
    {
        return cardFace[i-1];
    }

    void checkCards()
    {
        List<int> c = new List<int> ();

        for(int i = 0;i<cards.Length;i++)
        {
            if(cards[i].GetComponent<card_LEVEL1SIMPLE>().state == 1)
                c.Add(i);
        }
        if(c.Count == 2)
            cardComparison(c);
    }

    void cardComparison(List<int> c)
    {
        card_LEVEL1SIMPLE.DO_NOT = true;
        int x = 0;
        if(cards[c[0]].GetComponent<card_LEVEL1SIMPLE>().cardValue == cards[c[1]].GetComponent<card_LEVEL1SIMPLE>().cardValue)
        {
            x = 2;
            _matches--;
            matchText.text = "Number of Matches:" +  _matches;
            if(_matches == 0)
                SceneManager.LoadScene("game-level1SIMPLE");
        }
        for(int i = 0;i<c.Count;i++)
        {
            cards[c[i]].GetComponent<card_LEVEL1SIMPLE>().state = x;
            cards[c[i]].GetComponent<card_LEVEL1SIMPLE>().falseCheck();
        }
    }
}
