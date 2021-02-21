using UnityEngine;

public class FinalPlatform : MonoBehaviour
{
    private GameObject platform;
    public AudioSource audioSource;
    private bool playAudio;
    void Awake()
    {
        platform = GameObject.FindGameObjectWithTag("FinalPlatform");
    }
    void Update()
    {
        if (!BBuzzer.isSolved && !YBuzzer.isSolved && !MBuzzer.isSolved && !Wbuzzer.isSolved)
        {
            platform.SetActive(false);
        }
        else if (BBuzzer.isSolved && YBuzzer.isSolved && MBuzzer.isSolved && Wbuzzer.isSolved)
        {
            platform.SetActive(true);
            if (!playAudio)
            {
                audioSource.Play();
                playAudio = true;
            }
        }
    }
}
