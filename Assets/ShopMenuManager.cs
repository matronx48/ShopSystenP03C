using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopMenuManager : MonoBehaviour
{
    public int[,] shopItems = new int[5, 5];
    public float bank;
    public Text bankText;


    void Start()
    {
        bankText.text = "Bank: " + bank.ToString();

        //SHOP ID'S
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;

        //ITEM PRICE
        shopItems[2, 1] = 200;
        shopItems[2, 2] = 200;
        shopItems[2, 3] = 300;
        shopItems[2, 4] = 400;

        //ITEM QUANTITY
        shopItems[3, 1] = 0;
        shopItems[3, 2] = 0;
        shopItems[3, 3] = 0;
        shopItems[3, 4] = 0;
    }

    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag
            ("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if(bank >= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().Item])
        {
            bank -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().Item];
            shopItems[3, ButtonRef.GetComponent<ButtonInfo>().Item]++;
            bankText.text = "Bank: " + bank.ToString();
            ButtonRef.GetComponent<ButtonInfo>().quantityText.text =
                shopItems[3, ButtonRef.GetComponent<ButtonInfo>().Item].ToString();
        }
    }
}
