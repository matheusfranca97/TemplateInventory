using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{

    public static Coin instance;
    [SerializeField] Text coinsText;
    int ammountOfCoins = 0;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public int GetCoins()
    {
        return ammountOfCoins;
    }

    public void AddCoins(int ammount)
    {
        ammountOfCoins += ammount;
        UpdateCoinsText();
    }

    public void RemoveCoins(int ammount)
    {
        ammountOfCoins -= ammount;
        UpdateCoinsText();
    }

    public void UpdateCoinsText()
    {
        coinsText.text = "MY COINS: " + ammountOfCoins.ToString();
    }

}
