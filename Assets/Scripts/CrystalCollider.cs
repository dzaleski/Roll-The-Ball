using UnityEngine;
using UnityEngine.SceneManagement;

public class CrystalCollider : MonoBehaviour
{
   
    public GameObject particles;
    public GameObject crystaleffect;

    private void OnTriggerEnter(Collider other)
    {
        if (CollideWithSphere(other))
        { 
            CollectCrystal();
        }
        if (LeaveCrystals() == 1)
        {
            EndLevel();
        }
    }

    private static bool CollideWithSphere(Collider other)
    {
        return other.CompareTag("Sphere");
    }

    private void CollectCrystal()
    {
        Instantiate(particles, transform.position, Quaternion.identity);
        Instantiate(crystaleffect);
        Destroy(gameObject, 0.2f);
    }
    private int LeaveCrystals()
    {
        CrystalCollider[] crystals = Component.FindObjectsOfType<CrystalCollider>();
        return crystals.Length;
    }
    private void EndLevel()
    {
        string levelName = SceneManager.GetActiveScene().name;
        Instantiate(crystaleffect);
        PlayerPrefs.SetInt(levelName + "end", 1);
        SceneManager.LoadScene("menu");
    }
}
