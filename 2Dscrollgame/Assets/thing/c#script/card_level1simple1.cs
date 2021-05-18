using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class card_level1simple1 : MonoBehaviour
{       
    public int ID
    { get{  return id;}}
    private int id;

    private Sprite frontImg;
    private Sprite backImg;
    

    private Image showImg;
    public Button cardBtn;

    public void InitCard(int Id, Sprite FrontImg,Sprite BackImg)
    {
        this.id = Id;
        this.frontImg = FrontImg;
        this.backImg = BackImg;

        showImg = GetComponent<Image>();
        showImg.sprite = this.backImg;

        cardBtn = GetComponent<Button>();
    }

    public void SetFanPai()
    {
        showImg.sprite = frontImg;
        cardBtn.interactable = false;
    }


    public void SetRecover()
    {
        showImg.sprite = backImg;
        cardBtn.interactable = true;
    }




}