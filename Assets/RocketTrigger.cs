using UnityEngine;
using UnityEngine.SceneManagement;

public class RocketTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("EndCard");
        }
    }

}
