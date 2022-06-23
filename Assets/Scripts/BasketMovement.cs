using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketMovement : MonoBehaviour
{
    Vector3 basketScale;
    public float speed = 10f;
    float basketScaleX;

    public float xBound = 2.23f;
    // Start is called before the first frame update
    void Start()
    {
        basketScale = transform.localScale;
        basketScaleX = basketScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0, 0);
        if(Input.GetAxis("Horizontal") < 0)
        {
            basketScale.x = -basketScaleX;
        }
        if(Input.GetAxis("Horizontal") > 0)
        {
            basketScale.x = basketScaleX;
        }
        transform.localScale = basketScale;

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -xBound, xBound), transform.position.y);
    }
}
