using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo : MonoBehaviour
{
    public int Item;
    public Text priceText;
    public Text quantityText;
    public GameObject ShopMenuManager;

    void Update()
    {
        priceText.text = "$" + ShopMenuManager.GetComponent<ShopMenuManager>().shopItems[2,
            Item].ToString();
        quantityText.text = ShopMenuManager.GetComponent<ShopMenuManager>().shopItems[3,
            Item].ToString();
    }
}
