using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Rigidbody sphereRb;
    public CameraController cameraController;
    public Light lightPrefab;

    public GameObject leveNamePrefab;
    public GameObject overBasePrefab;

	void Start ()
    {
        Rigidbody sphere = Instantiate(sphereRb);
        sphere.transform.position = transform.position + Vector3.up * 0.5f;

        CameraController camera = Instantiate(cameraController);
        camera.sphereRigidbody = sphere;

        SpawnLight(0.6f, Color.white);

        Instantiate(leveNamePrefab);
        Instantiate(overBasePrefab);

    }

    private void SpawnLight(float intensity, Color color)
    {
        Light light = Instantiate(lightPrefab);
        light.intensity = intensity;
        light.color = color;
        RenderSettings.ambientMode = UnityEngine.Rendering.AmbientMode.Flat;
        RenderSettings.ambientLight = color * intensity;
    }

}
