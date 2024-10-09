using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    // The duration for a complete day in seconds
    [SerializeField]
    private float dayDuration = 60f; // Default: 60 seconds for a full day

    // Update is called once per frame
    void Update()
    {
        // Calculate the rotation angle based on the time passed
        float rotationSpeed = 360f / dayDuration * Time.deltaTime;
        transform.Rotate(rotationSpeed, 0f, 0f);
    }
}
