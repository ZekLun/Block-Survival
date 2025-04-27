using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using TMPro;
using UnityEngine;

public class UIScript : MonoBehaviour
{
    static public float Coins = 0f;
    public TextMeshProUGUI CoinText;

    private void Start()
    {

    }

    private void Update()
    {
        CoinText.text = Coins.ToString();
    }

}
