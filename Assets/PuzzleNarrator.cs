using UnityEngine;

public class PuzzleNarrator : MonoBehaviour
{
    public AudioSource AudioSource;

    static public bool played;

    // Update is called once per frame
    void Update()
    {
        if (LightsButton.isLightOn && ButtonTrigger.inPlace)
        {
            if (!played)
            {
                AudioSource.Play();
                played = true;
            }
        }
    }
}
