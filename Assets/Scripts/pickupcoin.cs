using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pickupcoin : MonoBehaviour
{
    void Start()
    {
        //SetCountText();
    }
    // For now just destroy the coin if the player runs into
    // it. Could play a sound, add to a score or more here later!
    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.gameObject.CompareTag("Player"))
    //    {
    //        if (this.gameObject.tag == "coinSprite1")
    //        {
    //            //count+=1;
    //            //Destroy(this.gameObject);
    //            //SetCountText();
    //            Debug.Log("Coin was picked up");
    //        }
            
    //    }
    //}

    //public Text countText;
    //public Text winText;
    //public int count = 0;

    //void SetCountText()
    //{
    //    countText.text = "Twój wynik: " + count.ToString();
    //    if (count >= 9)
    //    {
    //        winText.text = "Wygrałeś!!!";
    //    }
    //}
}
