using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPCounter : MonoBehaviour
{
    public TextMesh text;
    public Ship ship;
    Quaternion originalRotation;
    // Start is called before the first frame update
    void Start()
    {
        originalRotation = transform.rotation;

    }

    // Update is called once per frame
    void Update()
    {
        text.text = ship.health.ToString();
    }

    public void ResetPosition(Transform playerTransform)
    {
        transform.rotation = originalRotation;
        transform.position = playerTransform.position;
        Vector3 temp = new Vector3(0, 0.7f, 0);
        transform.position += temp;
    }
}
