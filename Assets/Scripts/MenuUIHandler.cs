using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] private TMP_InputField nameInput;

    void Start()
    {
        MainManager.Instance.playerName = nameInput.text;
    }
    
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    void Update()
    {
        
    }

}
