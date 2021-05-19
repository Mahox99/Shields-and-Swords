using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUiControler : MonoBehaviour
{
    public GameObject eqPanel;
    bool isEqPanelOpen = false;
    [SerializeField] private Animator eqAnim;


    void Start()
    {
        isEqPanelOpen = false;
    }

    void Update()
    {
        if ((Input.GetButtonDown("Eq")) && (isEqPanelOpen == false))
        {
            MouseLook mouse = GameObject.Find("Camera").GetComponent<MouseLook>();
            Cursor.lockState = CursorLockMode.None;
            mouse.sensitivity = 8f;
            eqPanel.SetActive(true);
            eqAnim.SetTrigger("Open");
            isEqPanelOpen = true;
            Debug.Log("otwieram eq");
        }
        else if ((Input.GetButtonDown("Eq")) && (isEqPanelOpen == true))
        {
            MouseLook mouse = GameObject.Find("Camera").GetComponent<MouseLook>();
            Cursor.lockState = CursorLockMode.Locked;
            mouse.sensitivity = 100f;
            eqAnim.SetTrigger("Close");
            eqPanel.SetActive(false);
            isEqPanelOpen = false;
            Debug.Log("zamykam eq");
        }
    }
}
