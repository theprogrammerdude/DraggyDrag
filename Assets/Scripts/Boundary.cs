using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{
    private Vector2 screenBoundary;
    private float objectHeight;
    private float objectWidth;

    private void Start()
    {

        screenBoundary = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
        objectWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
    }

    void Update()
    {

        Vector3 currentPos = transform.position;

        currentPos.x = Mathf.Clamp(currentPos.x, -screenBoundary.x + objectWidth, screenBoundary.x - objectWidth);
        currentPos.y = Mathf.Clamp(currentPos.y, -screenBoundary.y + objectHeight, screenBoundary.y - objectHeight);

        transform.position = currentPos;
    }
}
