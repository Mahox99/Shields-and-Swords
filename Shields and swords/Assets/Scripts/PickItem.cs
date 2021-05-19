using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickItem : MonoBehaviour
{
    public GameObject item;
    public GameObject eqObject;
    public string itemTitle;
    public AudioSource sfx;
    bool PlayerIn;
    

    void OnTriggerEnter(Collider other)
    {
        PlayerControler player = GameObject.Find("Player").GetComponent<PlayerControler>();
        if (other.CompareTag("Player"))
        {
            PlayerIn = true;
            Debug.Log("Jestem w srodku!");
            player.staticNotificationDisplay.GetComponent<UnityEngine.UI.Text>().text = "Press f to pick up " + itemTitle;
            player.staticNotificationDisplay.SetActive(true);
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        PlayerControler player = GameObject.Find("Player").GetComponent<PlayerControler>();
        if (other.CompareTag("Player"))
        {
            Debug.Log("Jestem na zewnatrz!");
            PlayerIn = false;
            player.staticNotificationDisplay.SetActive(false);
        }
    }
    private void Update()
    {
        if (Input.GetButtonDown("Action")&&PlayerIn==true)
        {
            PlayerControler player = GameObject.Find("Player").GetComponent<PlayerControler>();
            sfx.Play();
            eqObject.SetActive(true);
            item.SetActive(false);
            player.staticNotificationDisplay.SetActive(false);
        }
    }
}
