using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikesCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (CollideWithSphere(collision))
        {
            RestartLevel();
        }
    }

    private static bool CollideWithSphere(Collider collision)
    {
        return collision.CompareTag("Sphere");
    }

    private static void RestartLevel()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneIndex);
    }
}
