using UnityEngine;

public class trophyManager : MonoBehaviour
{
    public static trophyManager instance;
    public bool[] trophies; //array of trophy states
    public string[] trophyNames; //names of trophies

    void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
        
        trophies = new bool[2]; //2 trophies
        trophyNames = new string[] {"First throw", "Hit Target"};

    }

    public void UnlockTrophy(int index)
    {
        if (!trophies[index])
        {
            trophies[index] = true;
            Debug.Log($"Trophy Unlocked: {trophyNames[index]}");
            FindObjectOfType<TrophyNotification>().ShowNotification(trophyNames[index]);
        }
    }

    public bool IsTrophyUnlocked(int index)
    {
        return trophies[index];
    }

    private void LoadTrophies()
    {
        trophies = new bool[10]; //example 10 trophies
        for (int i = 0; i < trophies.Length; i++)
        {
            trophies[i] = PlayerPrefs.GetInt("Trophy" + i, 0) == 1;
        } 
    }
}
