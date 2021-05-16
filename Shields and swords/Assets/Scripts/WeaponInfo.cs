using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponInfo : MonoBehaviour
{
    public int id;
    public bool isSword = false;
    public bool isShield = false;

    public string title;
    public GameObject titleDisplay;
    public GameObject infoDisplay;
    public string addInfo = "";
    public int damagePoints;
    public int defensePoints;

    public GameObject PlayerSword;
    public GameObject PlayerShield;

    //[SerializeField] private Animator myAnimation;

    public GameObject[] Swords;
    public GameObject[] Shields;

    void Start()
    {
        titleDisplay.GetComponent<UnityEngine.UI.Text>().text = title;
        if(isSword == true)
        {
            infoDisplay.GetComponent<UnityEngine.UI.Text>().text = "Dam. =" + damagePoints + " " + addInfo;
        }
        if (isShield == true)
        {
            infoDisplay.GetComponent<UnityEngine.UI.Text>().text = "Def. =" + defensePoints + " " + addInfo;
        }
        
        //TimeDisplay.GetComponent<UnityEngine.UI.Text>().text = "Time: " + time;
    }
    void Update()
    {
        
    }

    public void Equip()
    {
        if (isSword == true)
        {
            ClearSwords();
            PlayerSword = Swords[id];
            PlayerSword.SetActive(true);
            //myAnimation.SetBool("Attack", true);
        }

        if (isShield == true)
        {
            ClearShields();
            PlayerShield = Shields[id];
            PlayerShield.SetActive(true);
            //myAnimation.SetBool("Defense", true);
        }
    }
    public void TakeOff()
    {
        if (isSword == true)
        {
            Swords[id].SetActive(false);
        }
        if (isShield == true)
        {
            Shields[id].SetActive(false);
        }
    }

    public void ClearSwords()
    {
        for (int i = 0; i < Swords.Length; i++)
        {
            Swords[i].SetActive(false);
        }
    }
    public void ClearShields()
    {
        for (int i = 0; i < Shields.Length; i++)
        {
            Shields[i].SetActive(false);
        }
    }
    
}
