using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickItem : MonoBehaviour
{
    public GameObject item;
    public GameObject eqObject;
    public string itemTitle;
    public AudioSource sfx;
    bool playerIn; 

    void OnTriggerEnter(Collider other)
    {
        PlayerControler player = GameObject.Find("Player").GetComponent<PlayerControler>();
        if (other.CompareTag("Player"))
        {
            playerIn = true;
            player.staticNotificationDisplay.GetComponent<UnityEngine.UI.Text>().text = "Press f to pick up " + itemTitle;
            player.staticNotificationDisplay.SetActive(true);
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        PlayerControler player = GameObject.Find("Player").GetComponent<PlayerControler>();
        if (other.CompareTag("Player"))
        {
            playerIn = false;
            player.staticNotificationDisplay.SetActive(false);
        }
    }
    private void Update()
    {
        if (Input.GetButtonDown("Action")&&playerIn==true)
        {
            PlayerControler player = GameObject.Find("Player").GetComponent<PlayerControler>();
            sfx.Play();
            eqObject.SetActive(true);
            item.SetActive(false);
            player.staticNotificationDisplay.SetActive(false);
        }
    }
}
