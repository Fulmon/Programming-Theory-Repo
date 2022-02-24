using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    [SerializeField] InputField inputField;

    public string nameText;

    public static TitleManager instance;

    public void inputEnd()
    {
        if (inputField.text != "")
        {
            nameText = inputField.text;
            SceneManager.LoadScene(1);
        }
    }

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(instance);
    }
}
