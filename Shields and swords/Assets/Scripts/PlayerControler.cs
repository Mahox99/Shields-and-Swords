using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControler : MonoBehaviour
{
    [Header("Sword")]
    public GameObject playerSword;
    public GameObject swTitleDisplay;
    public Image swIconDisplay;
    
    [Header("Shield")]
    public GameObject playerShield;
    public GameObject shTitleDisplay;
    public Image shIconDisplay;

    [Header("Other")]
    public GameObject dynamicNotificationDisplay;
    public GameObject staticNotificationDisplay;
    [SerializeField] public Animator notificationAnim;

    public Sprite emptyIcon;

    public void SetSwordEmpty()
    {
        swTitleDisplay.GetComponent<UnityEngine.UI.Text>().text = "Empty";
        swIconDisplay.sprite = emptyIcon;
    }
    public void SetShieldEmpty()
    {
        shTitleDisplay.GetComponent<UnityEngine.UI.Text>().text = "Empty";
        shIconDisplay.sprite = emptyIcon;
    }

}
 

