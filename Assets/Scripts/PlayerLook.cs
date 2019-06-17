using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{

    [SerializeField] private float minX = -60f;
    [SerializeField] private float maxX = 60f;
    // [SerializeField] private float minY = -360f;
    // [SerializeField] private float maxY = 360f;

    [SerializeField] private float sensitivityX = 5f;
    [SerializeField] private float sensitivityY = 5f;

    float rotationX = 0f;
    float rotationY = 0f;

    public Camera cam;
    // Start is called before the first frame update
    void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        rotationY += Input.GetAxis("Mouse X") * sensitivityY;
        rotationX += Input.GetAxis("Mouse Y") * sensitivityX;

        rotationX = Mathf.Clamp(rotationX, minX, maxX);

        transform.localEulerAngles = new Vector3(0, rotationY, 0);
        cam.transform.localEulerAngles = new Vector3(-rotationX, 0, 0);
    }
}
