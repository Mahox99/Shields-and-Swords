using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponInfo : MonoBehaviour
{
    [Header("Main info")]
    public int id;
    public string title;
    public int damagePoints;
    public int defensePoints;
    public string addInfo = "";
    public AudioSource sound;

    public bool isSword = false;
    public bool isShield = false;
         
    [Header("Displays")]
    public GameObject titleDisplay;
    public GameObject aboutDisplay;

    [Header("Images")]
    public Sprite icon;
    public Image eqIcon;

    [Header("Animations")]
    [SerializeField] private Animator itemAnim;

    void Start()
    {
        titleDisplay.GetComponent<UnityEngine.UI.Text>().text = title;
        if (isSword == true)
        {
            eqIcon.sprite = icon;
            aboutDisplay.GetComponent<UnityEngine.UI.Text>().text = "Damage: " + damagePoints + "\n" + addInfo;
        }
        if (isShield == true)
        {
            eqIcon.sprite =  icon;
            aboutDisplay.GetComponent<UnityEngine.UI.Text>().text = "Defense: " + defensePoints + "\n" + addInfo;
        }  
    }
    public void Equip()
    {
        WeaponMenager item = GameObject.Find("WeaponMenager").GetComponent<WeaponMenager>();
        PlayerControler player = GameObject.Find("Player").GetComponent<PlayerControler>();
        sound.Play();
        if (isSword == true)
        {       
            item.ClearSwords();
            player.playerSword = item.swords[id];
            player.playerSword.SetActive(true);
            player.swIconDisplay.sprite = icon;
            player.swTitleDisplay.GetComponent<UnityEngine.UI.Text>().text = title;
        }

        if (isShield == true)
        {
            item.ClearShields();
            player.playerShield = item.shields[id];
            player.playerShield.SetActive(true);
            player.shIconDisplay.sprite = icon;
            player.shTitleDisplay.GetComponent<UnityEngine.UI.Text>().text = title;
        }
        itemAnim.SetTrigger("Presentation");
        player.dynamicNotificationDisplay.GetComponent<UnityEngine.UI.Text>().text = title + " was allready equipped";
        player.notificationAnim.SetTrigger("Show");
    }
    public void TakeOff()
    {
        WeaponMenager item = GameObject.Find("WeaponMenager").GetComponent<WeaponMenager>();
        PlayerControler player = GameObject.Find("Player").GetComponent<PlayerControler>();
        if (isSword == true)
        {
            if(player.playerSword == item.swords[id])
            {
                player.SetSwordEmpty();
                player.playerSword.SetActive(false);
                player.dynamicNotificationDisplay.GetComponent<UnityEngine.UI.Text>().text = title + " was allready taken off";
                player.notificationAnim.SetTrigger("Show");
            }      
        }
        if (isShield == true)
        {
            if (player.playerShield == item.shields[id])
            {
                player.SetShieldEmpty();
                player.playerShield.SetActive(false);
                player.dynamicNotificationDisplay.GetComponent<UnityEngine.UI.Text>().text = title + " was allready taken off";
                player.notificationAnim.SetTrigger("Show");
            }
        }     
    }
}
