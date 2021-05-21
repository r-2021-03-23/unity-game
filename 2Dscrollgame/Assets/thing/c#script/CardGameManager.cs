using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CardGameManager : MonoBehaviour {

    public Text text;

    
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
    // Use this for initialization
    void Start () {
        textDisplay.GetComponent<Text>().text = "0:" + secondsleft;
        CardObjs = new List<GameObject>();
        FaceCards = new List<card_level1simple1>();

        //将12张卡牌制作完成后添加到CardObjs数组
        for (int i = 0; i < 6; i++)
        {
            Sprite FrontSprite = FrontSprites[i];
            for (int j = 0; j < 2; j++)
            {
                //实例化对象
                GameObject go = (GameObject)Instantiate(CardPre);
                //获取Card组件进行初始化，点击事件由游戏管理器统一处理
                //所以卡牌的点击事件的监听在管理器指定
                card_level1simple1 card = go.GetComponent<card_level1simple1>();
                card.InitCard(i, FrontSprite, BackSprite);
                card.cardBtn.onClick.AddListener(() => CardOnClick(card));

                CardObjs.Add(go);
            }
        }

        while (CardObjs.Count > 0)
        {
            //取随机数，左闭右开区间
            int ran = Random.Range(0, CardObjs.Count);
            GameObject go = CardObjs[ran];
            //将对象指定给Panel作为子物体，这样就会被我们的组件自动布局
            go.transform.SetParent(CardsView);
            //local就表示相对于父物体的相对坐标系，此处做校正处理
            //有兴趣的同学可以把下面两句代码注释掉看看效果
            go.transform.localPosition = Vector3.zero;
            go.transform.localScale = Vector3.one;
            //从CardObjs列表中移除该索引指向对象，列表对象数量减少1个
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
        if(x > 0 && secondsleft == 0)
        {
            text.text = "please restart game. (PRESS PAUSE AND MENU)";
        }
        
    }

    private void CardOnClick(card_level1simple1 card)
    {
        if (canPlayerClick)
        {
            //先判断是否可以点击，可点击则直接翻牌
            card.SetFanPai();
            //添加到比对数组中
            FaceCards.Add(card);
            //如果有两张牌了，则不可再点击，进入协同程序
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
        //获取到两张卡牌对象
        card_level1simple1 card1 = FaceCards[0];
        card_level1simple1 card2 = FaceCards[1];
        //对ID进行比对
        if (card1.ID == card2.ID)
        {
            text.text = "good";
            //此时会在此处等待0.8秒后再执行下一条语句
            //协程不影响主程序的进行，这里可以做个小实验
            //将下面的0.8改成8秒，在Update中打印Time.time会发现不会有停顿的时候
            yield return new WaitForSeconds(0.5f);
            curCardCouples++;
            if (curCardCouples == winCardCouples && secondsleft > 0)
            {
                //此处可以弹出游戏成功等字样的UI，同学们可以自由设定
                text.text = "you win! go to next level";
                 yield return new WaitForSeconds(5f);
                 SceneManager.LoadScene("UILevel");
                 f = 1;             
            }
        }
        else
        {
            text.text = "fail...";
            //配对失败等待的时间要更长，因为要让玩家记忆更深刻
            yield return new WaitForSeconds(1f);
            card1.SetRecover();
            card2.SetRecover();
        }

        if(secondsleft == 0 && curCardCouples < 6)
        {
            text.text = "you lose! can't to next level please restart";
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
}