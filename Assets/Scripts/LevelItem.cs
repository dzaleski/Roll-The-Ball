using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelItem : MonoBehaviour
{
    public GameObject okey;
	public string levelName;
    public TextMesh textMest;

	void Awake()
    {
        textMest.text = levelName;

        if (PlayerPrefs.GetInt(levelName + "end",0) == 0)
        {
            Destroy(okey);
        }
	}
    private void OnMouseDown()
    {
        LoadLevel();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Sphere"))
        {
            if (Input.GetKey(KeyCode.W))
            {
                LoadLevel();
            }
        }
    }
    private void LoadLevel()
    {
        if (levelName == "Level1")
        {
            SceneManager.LoadScene(2);
        }
        else if (PlayerPrefs.GetInt("Level1end", 0) == 1)
        {
            SceneManager.LoadScene(3);
        }
    }
}
