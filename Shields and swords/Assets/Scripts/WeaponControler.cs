using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponControler : MonoBehaviour
{
    [SerializeField] private Animator itemAnim;

    void Update()
    {
            if (Input.GetMouseButtonDown(0))
            {
                itemAnim.SetTrigger("Attack");
                Debug.Log("click LPM");
            }
            if (Input.GetMouseButtonDown(1))
            {
                itemAnim.SetTrigger("Block");
                Debug.Log("click down LPM");
            }
            if (Input.GetMouseButtonUp(1))
            {
                itemAnim.SetTrigger("Discharge");
                Debug.Log("click up LPM");
            }  
    }
}
