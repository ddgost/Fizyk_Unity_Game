using UnityEngine;

public class Narrator : MonoBehaviour
{
    public AudioSource AudioSource;

    public bool played;

    private void OnTriggerEnter(Collider other)
    {
        if (!played)
        {
            AudioSource.Play();
            played = true;
        }
    }
}
