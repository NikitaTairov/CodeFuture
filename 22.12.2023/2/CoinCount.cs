using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCount : MonoBehaviour
{
    public Text coinText;
    public static int coin = 0;

    // Update is called once per frame
    void Update()
    {
        coinText.text = "$" + coin;
    }
}
