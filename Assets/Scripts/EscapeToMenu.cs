using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeToMenu : MonoBehaviour
{
	void Update ()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            LoadMenuScene();
        }

    }

    private void LoadMenuScene()
    {
        SceneManager.LoadScene(1);
    }
}
