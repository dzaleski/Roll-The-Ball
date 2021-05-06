using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    IEnumerator Start()
    {
        yield return new WaitForSeconds(2f);
        LoadMenuScene();
    }

    private static void LoadMenuScene()
    {
        SceneManager.LoadScene(1);
    }
}
