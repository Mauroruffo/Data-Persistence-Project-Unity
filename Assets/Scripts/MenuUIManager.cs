using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MenuUIManager : MonoBehaviour
{
    public User highScoreUser;
    public User user;
    public TMP_InputField userNameInput;
    public Button start;
    public Button exit;
    public TextMeshProUGUI highScoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        //MainSceneManager.Instance.user.userName = userNameInput.text;
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void SetPlayerName()
    {
        DataHandler.Instance.PlayerName = userNameInput.text;
    }

}
