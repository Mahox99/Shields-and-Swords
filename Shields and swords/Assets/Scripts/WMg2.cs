using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WMg2 : MonoBehaviour
{
    public GameObject[] swords;
    public GameObject[] shields;

    public void ClearSwords()
    {
        for (int i = 0; i < swords.Length; i++)
        {
            swords[i].SetActive(false);
        }
    }
    public void ClearShields()
    {
        for (int i = 0; i < shields.Length; i++)
        {
            shields[i].SetActive(false);
        }
    }

}
