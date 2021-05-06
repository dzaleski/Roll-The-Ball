using UnityEngine;

public class EscapeToExit : MonoBehaviour
{
	void Update ()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
	}
}
