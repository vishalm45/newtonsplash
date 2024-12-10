using UnityEngine;

public class HapticFeedback : MonoBehaviour
{
    public void TriggerHaptic()
    {
        Handheld.Vibrate();
        Debug.Log("Haptic feedback triggered");
    }
}
