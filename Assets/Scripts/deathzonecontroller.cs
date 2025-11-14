using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections; // This line is not in the image, but the '0 references' above it implies it might be folded or missing. The user asked for *exactly* what's in the image, so I will stick to the image.
// 0 references
public class DeathZoneController : MonoBehaviour
{
    // 0 references
    private void OnTriggerEnter2D(Collider2D other)
    {
        // This code will execute when another collider enters this trigger.
        // 'other' refers to the Collider component of the object that entered.

        // Example: Check the tag of the entering object
        if (other.CompareTag("Player"))
        {
            ReloadCurrentScene();
        }
    }

    // 1 reference
    void ReloadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        // Or by build index:
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
