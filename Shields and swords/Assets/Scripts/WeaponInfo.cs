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

    public bool isSword = false;
    public bool isShield = false;
         
    [Header("Displays")]
    public GameObject titleDisplay;
    public GameObject aboutDisplay;
    //public GameObject notificationDisplay;


    [Header("Images")]
    public Sprite icon;
    public Image EqIcon;

    [Header("Animations")]
    [SerializeField] private Animator itemAnim;


    void Start()
    {
        titleDisplay.GetComponent<UnityEngine.UI.Text>().text = title;
        if (isSword == true)
        {
            EqIcon.sprite = icon;
            aboutDisplay.GetComponent<UnityEngine.UI.Text>().text = "Damage: " + damagePoints + "\n" + addInfo;
            Debug.Log("zdefiniowano miecz " + id);
        }
        if (isShield == true)
        {
            EqIcon.sprite =  icon;
            aboutDisplay.GetComponent<UnityEngine.UI.Text>().text = "Defense: " + defensePoints + "\n" + addInfo;
            Debug.Log("zdefiniowano tarcze " + id);
        }  
    }

    public void Equip()
    {
        WMg2 item = GameObject.Find("WeaponMenager").GetComponent<WMg2>();
        PlayerControler player = GameObject.Find("Player").GetComponent<PlayerControler>();
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
        player.notificationDisplay.GetComponent<UnityEngine.UI.Text>().text = title + " was allready equipped";
        player.notificationAnim.SetTrigger("Show");
    }
    public void TakeOff()
    {
        WMg2 item = GameObject.Find("WeaponMenager").GetComponent<WMg2>();
        PlayerControler player = GameObject.Find("Player").GetComponent<PlayerControler>();
        player.notificationDisplay.GetComponent<UnityEngine.UI.Text>().text = title + " was allready taken off";
        player.notificationAnim.SetTrigger("Show");
        if (isSword == true)
        {
            player.SetSwordEmpty();  
            player.playerSword.SetActive(false);
            
        }
        if (isShield == true)
        {
            player.SetShieldEmpty();
            player.playerShield.SetActive(false);
        }     
    }
}
