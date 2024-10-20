using UnityEngine;

public class SoundController : MonoBehaviour
{
    private AudioSource audioSource;
    private bool isPlaying = true;

    void Start()
    {
        // Get the AudioSource component attached to the GameObject
        audioSource = GetComponent<AudioSource>();

        // Play the audio at the start (if desired)
        audioSource.Play();
    }

    void Update()
    {
        // Check if the 'm' key is pressed
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (isPlaying)
            {
                // If currently playing, pause the audio
                audioSource.Pause();
                isPlaying = false;
            }
            else
            {
                // If currently paused, resume the audio
                audioSource.UnPause();
                isPlaying = true;
            }
        }
    }
}
