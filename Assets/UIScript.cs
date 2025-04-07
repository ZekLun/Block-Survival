using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    static public float Coins = 0f;
    public Text CoinText;

    private void Update()
    {
        CoinText.text = Coins.ToString();
    }

}
