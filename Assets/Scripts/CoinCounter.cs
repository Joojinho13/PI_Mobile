using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    public static CoinCounter instance;
    public TMP_Text coinText;
    public int CurrentCoins = 0;

    // Start is called before the first frame update
    
    void Awake()
    {
        instance = this;

    }
    
    void Start()
    {
        coinText.text = "COINS " + CurrentCoins.ToString();
    }

    public void IncraseCoins(int v)
    {
        CurrentCoins += v;
        coinText.text = "COINS " + CurrentCoins.ToString();
    }
}
