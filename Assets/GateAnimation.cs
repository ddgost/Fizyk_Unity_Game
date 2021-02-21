using UnityEngine;

public class GateAnimation : MonoBehaviour
{
    private Animator anim;
    public AudioSource AudioSource;

    public string animName;
    private bool playAudio;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (LightsButton.isLightOn && ButtonTrigger.inPlace)
        {
            anim.enabled = true;
            if (!playAudio)
            {
                AudioSource.Play();
                playAudio = true;
            }
        }
        else
        {
            anim.enabled = false;
        }
    }
}
