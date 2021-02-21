using UnityEngine;

public class MBuzzer : MonoBehaviour
{
    public AudioSource AudioSource;
    public AudioClip chime;

    private bool isRedEnabled;
    private bool isGreenEnabled;
    private bool isBlueEnabled;
    private bool playAudio;
    static public bool isSolved;

    private GameObject red;
    private GameObject green;
    private GameObject blue;

    void Start()
    {
        red = GameObject.FindGameObjectWithTag("RedSpotlight");
        green = GameObject.FindGameObjectWithTag("GreenSpotlight");
        blue = GameObject.FindGameObjectWithTag("BlueSpotlight");

    }

    void Update()
    {
        isBlueEnabled = blue.GetComponent<Light>().isActiveAndEnabled;
        isGreenEnabled = green.GetComponent<Light>().isActiveAndEnabled;
        isRedEnabled = red.GetComponent<Light>().isActiveAndEnabled;

        if (isBlueEnabled && !isGreenEnabled && isRedEnabled)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
            
            isSolved = true;
            
            if (!playAudio)
            {
                AudioSource.PlayOneShot(chime);
                playAudio = true;
            }

        }
    }
}
