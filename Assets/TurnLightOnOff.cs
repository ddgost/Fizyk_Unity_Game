using UnityEngine;

public class TurnLightOnOff : MonoBehaviour
{
    public string spotlightColour;
    private GameObject spotlight;

    void Start()
    {
        spotlight = GameObject.FindGameObjectWithTag(spotlightColour);
    }

    private void OnMouseDown()
    {
        var light = spotlight.GetComponent<Light>();
        light.enabled =!light.enabled;
    }
}
