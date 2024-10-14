using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoadGameRank : MonoBehaviour
{
    public TextMeshProUGUI BestPlayerName;

    // Static variables to hold best score data
    private static int bestScore;
    private static string bestPlayer;

    private void Awake()
    {
        Init();
    }

    public void Init()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        Debug.Log("Entered Init");
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            bestPlayer = data.TheBestPlayer;
            bestScore = data.HighestScore;
            SetBestPlayer();
        }
    }

    [System.Serializable]
    class SaveData
    {
        public int HighestScore;
        public string TheBestPlayer;
    }

    private void SetBestPlayer()
    {
        if (bestPlayer == null && bestScore == 0)
        {
            BestPlayerName.text = "";
        }
        else
        {
            BestPlayerName.text = $"Best Score - {bestPlayer}: {bestScore}";
        }
    }

}
