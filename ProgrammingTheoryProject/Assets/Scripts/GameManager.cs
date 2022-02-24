using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text nameText;

    private void Awake()
    {
        if (TitleManager.instance != null)
        {
            nameText.text = "Name : " + TitleManager.instance.nameText;
        }
        else
        {
            nameText.text = "Name : " + "Debug";
        }
        
    }
}
