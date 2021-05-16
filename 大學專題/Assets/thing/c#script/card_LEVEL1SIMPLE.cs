using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class card_LEVEL1SIMPLE : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool  DO_NOT = false;

    [SerializeField]
    private int _state;
    [SerializeField]
    private int _cardValue;
    [SerializeField]
    private bool _initialized = false;

    private Sprite _cardBack;
    private Sprite _cardFace;

    private GameObject _manager;

    void Start()
    {
        _state = 1;
        _manager = GameObject.FindGameObjectWithTag("Manager");
    }

    public void setupGraphics()
    {
        _cardBack = _manager.GetComponent<CardGameManager>().getCardBack();
        _cardFace = _manager.GetComponent<CardGameManager>().getCardFace(_cardValue);

        FilpCard();
    }

    public void FilpCard()
    {
        
        if(_state == 0 && !DO_NOT)
            GetComponent<Image>().sprite = _cardBack;
        else if(_state == 1 && !DO_NOT) 
            GetComponent<Image>().sprite = _cardFace;
    }

    public int state 
    {
        get {return _state;}
        set {_state = value;}
    }

    public int cardValue
    {
        get {return _cardValue;}
        set {_cardValue = value;}
    }

    public bool initialized
    {
        get {return _initialized;}
        set {_initialized = value;}
    }

    public void falseCheck()
    {
        StartCoroutine(pause());
    }

    IEnumerator pause()
    {
        yield return new WaitForSeconds(1);
        if(_state == 0)     
            GetComponent<Image>().sprite = _cardBack;
        else if(_state == 1)
            GetComponent<Image>().sprite = _cardFace;
    }
}
