using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    static public float Coins = 0f;

    private void OnGUI()
    {
        GUI.Label(new Rect(80, 20, 10, 10), Coins.ToString());
    }
}
