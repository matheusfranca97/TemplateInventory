using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Market : MonoBehaviour
{
    [SerializeField] MarketController marketController;

    private void OnCollisionEnter2D(Collision2D other)
    {
        marketController.OpenMarket();
    }

}
