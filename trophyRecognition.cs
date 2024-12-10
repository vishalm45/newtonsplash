using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class trophyRecognition : MonoBehaviour
{
    private ARTrackedImageManager trackedImageManager;

    void Awake()
    {
        trackedImageManager = GetComponent<ARTrackedImageManager>();
    }

    void OnEnable()
    {
        trackedImageManager.trackedImagesChanged += OnTrackedImagesChanged;
    }

    void OnDisable()
    {
        trackedImageManager.trackedImagesChanged -= OnTrackedImagesChanged;
    }

    private void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs args)
    {
        foreach (ARTrackedImage trackedImage in args.added)
        {
            UnlockTrophy(trackedImage.referenceImage.name);
        }
    }

    private void UnlockTrophy(string imageName)
    {
        if (imageName == "arcade_machine")
        {
            trophyManager.instance.UnlockTrophy(0); //unlock trophy 0
            Debug.Log("trophy unlocked");
        }
    }
}
