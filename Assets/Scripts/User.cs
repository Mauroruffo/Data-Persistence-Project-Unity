using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class User : MonoBehaviour
{
    public string userName;
    public int highScore;
    public TextMeshProUGUI highScoreUser;
    public int scoreStart;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Init()
    {
        scoreStart = 0;
    }

}
