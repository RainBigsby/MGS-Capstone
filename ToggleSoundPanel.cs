using UnityEngine;

public class ToggleSoundPanel : MonoBehaviour
{
    // Reference to the Sound Panel GameObject
    public GameObject soundPanel;

    // Function to toggle the Sound Panel on/off
    public void TogglePanel()
    {
        // Check if the Sound Panel is active
        if (soundPanel.activeSelf)
        {
            // If active, deactivate the Sound Panel
            soundPanel.SetActive(false);
        }
        else
        {
            // If inactive, activate the Sound Panel
            soundPanel.SetActive(true);
        }
    }
}
