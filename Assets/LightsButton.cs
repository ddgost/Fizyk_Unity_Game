using UnityEngine;

public class LightsButton : MonoBehaviour
{
    private GameObject[] balloonLights;
    static public bool isLightOn;

    void Start()
    {
        balloonLights = GameObject.FindGameObjectsWithTag("BalloonLight");
    }

    private void OnMouseDown()
    {
        foreach (GameObject balloonLight in balloonLights)
        {
            var light = balloonLight.GetComponent<Light>();
            light.enabled = !light.enabled;
        }
        isLightOn = true;      
    }

}
