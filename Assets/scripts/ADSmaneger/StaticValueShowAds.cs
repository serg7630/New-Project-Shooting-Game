using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class StaticValueShowAds : MonoBehaviour
{
    static public StaticValueShowAds S;
    static public bool ShowAds=true;
    static public int ValForAds;
    //public GameObject PanelRevu;

    [Header("количесвто монет")]
    string CoinsPlayer = "Coins";
    [SerializeField] int _coins;
    [SerializeField] int secondForAhowADS = 120;
    void Start()
    {
        Debug.LogError(ShowAds+"   реклама");
        if (S==null) S = this;
        _coins= PlayerPrefs.GetInt(CoinsPlayer);
        Debug.LogError("startScriptADS");
        //startMyAdsCoroutine();
        //StartShowADS();
        //DontDestroyOnLoad(this.gameObject);
    }
   static public void StartShowADS()
    {
        ShowAds = true;
        Debug.LogError(ShowAds);
    }
    public void TestInvoce()
    {
        Invoke("StartShowADS", secondForAhowADS);
    }
   static public void ReturnYimeForADS()
    {
        StaticValueShowAds.S.TestInvoce();
    }

    public IEnumerator StartShowADS(int second)
    {
        Debug.LogError(ShowAds);
        yield return new WaitForSeconds(second);
        ShowAds = true;
        startMyAdsCoroutine();
        Debug.LogError(ShowAds);
    }

    public void startMyAdsCoroutine()
    {
        ShowAds = false;
        StartCoroutine(StartShowADS(secondForAhowADS));
    }
    public int Coins
    {
        get { return _coins; }
        set { _coins = value; }
    }
   public void PlusShowAdsVal()
    {
        ValForAds++;
    }
   public void loadScenLevels()
    {
        SceneManager.LoadScene("LevelsMenu");
    }
    //public void ShowReveu()
    //{
    //    PanelRevu.SetActive(true);
    //}
    //public void HideReveu()
    //{
    //    PanelRevu.SetActive(false);
    //}
    void Update()
    {
        
    }
   public void setCoin(int coins)
    {
        PlayerPrefs.SetInt(CoinsPlayer, coins);
        //Debug.LogError(coins+ " playerPrefer");
    }
    public int getCoin()
    {
       return Coins=PlayerPrefs.GetInt(CoinsPlayer);

    }
    public void resetCoins()
    {
        PlayerPrefs.SetInt(CoinsPlayer, 1);
        getCoin();
        //Debug.LogError(1 + "     playerPrefer");
    }

}

