using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelController : MonoBehaviour
{
    private float rotateSpeed = 10f;
    private float scaleSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ModelRotate();
        ModelScale();
    }
    private void ModelRotate()
    {
        if (Input.GetMouseButton(0))
        {
            float x = -Input.GetAxis("Mouse X");
            float y = -Input.GetAxis("Mouse Y");
            Vector2 offset = new Vector2(y, x);
            transform.eulerAngles += (Vector3)offset * rotateSpeed;
        }
    }

    private void ModelScale()
    {
        float scrolValue = Input.GetAxis("Mouse ScrollWheel");
        float aimScale=scrolValue * scaleSpeed+transform.localScale.x;
        aimScale = Mathf.Clamp(aimScale, 1, 5);
        transform.localScale = new Vector3(aimScale, aimScale, aimScale);
    }
}
