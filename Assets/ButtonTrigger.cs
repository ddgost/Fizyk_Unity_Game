using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    static public bool inPlace = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Balloon"))
        {
            inPlace = true;
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Balloon"))
        {
            inPlace = false;
        }
    }
}
