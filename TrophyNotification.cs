using TMPro;
using UnityEngine;

public class TrophyNotification : MonoBehaviour
{
    public TextMeshProUGUI notificationText;
    public GameObject notificationPanel;

    void Start()
    {
        //ensure notification panel is hidden at start
        notificationPanel.SetActive(false);
        Debug.Log("notification panel hidden at start");
    }

    public void ShowNotification(string message)
    {
        notificationText.text = $"Trophy Unlocked: {message}";
        Debug.Log("trophy unlocked");
        notificationPanel.SetActive(true);
        Invoke(nameof(HideNotification), 3f); //hide after 3 seconds
        Debug.Log("hidden notification");
    }

    void HideNotification()
    {
        notificationPanel.SetActive(false);
        Debug.Log("hide notification panel");
    }
}
