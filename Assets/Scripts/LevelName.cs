using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelName : MonoBehaviour {

    public TextMesh textMesh;

	void Start ()
    {
        SetLevelText();
    }

    private void SetLevelText()
    {
        string levelname = SceneManager.GetActiveScene().name;
        textMesh.text = levelname;
    }
}
