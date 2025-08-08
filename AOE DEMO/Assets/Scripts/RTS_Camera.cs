using UnityEngine;

public class RTS_Camera : MonoBehaviour
{
    public float moveSpeed = 10f; // Speed of camera movement
    public float zoomSpeed = 50f; // Speed of camera zoom
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        transform.position += move * moveSpeed * Time.deltaTime;
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            scroll *= 10f; // Increase zoom speed when holding left shift
        }
        Debug.Log("Scroll: " + scroll);
        transform.position += transform.forward * scroll * zoomSpeed * Time.deltaTime;
    }
}
