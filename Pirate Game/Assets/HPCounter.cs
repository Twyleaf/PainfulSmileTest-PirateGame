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
        transform.rotation = originalRotation;
    }
}
