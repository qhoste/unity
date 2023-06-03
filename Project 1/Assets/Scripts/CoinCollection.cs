using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCollection : MonoBehaviour
{
    private int Coin = 0;
    public TextMeshProUGUI coinText;
    public GameObject complete;
    public void gameOver () 
    {
        complete.SetActive(true);
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.transform.tag == "Coin") 
        {
            Coin++;
            coinText.text = "Coin: " + Coin.ToString();
            Debug.Log(Coin);
            Destroy(other.gameObject);
        }
    }
    void Start () 
    {
        complete.SetActive(false);
    }
    void Update () 
    {
        if(Coin >= 18) 
        {
            complete.SetActive(true);
            gameObject.GetComponent<TankMovement>().enabled = false;
        }
    }
}
