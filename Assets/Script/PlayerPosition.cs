using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{   
    [SerializeField]private float landscapeGap = 500;
    [SerializeField]private float portraitGap = 200;

    void Start()
    {
        // Set the object's position initially
        AdjustObjectPosition();
    }

    // Update is called once per frame
    void Update()
    {
        // Adjust the object's position when the screen orientation changes
        AdjustObjectPosition();
    }

    void AdjustObjectPosition()
    {

        float screenHeight = Camera.main.orthographicSize * 2.0f;
        float screenWidth = screenHeight * Screen.width / Screen.height;

        // Check the current screen orientation
        if ( Screen.orientation == ScreenOrientation.LandscapeLeft || Screen.orientation == ScreenOrientation.LandscapeRight)
        {
            // Landscape mode
            Vector3 newPos = Camera.main.ScreenToWorldPoint(new Vector3(landscapeGap, Screen.height / 2, Camera.main.nearClipPlane));
            transform.position = new Vector3(newPos.x, transform.position.y, transform.position.z);
        }
        else if (Screen.orientation == ScreenOrientation.Portrait || Screen.orientation == ScreenOrientation.PortraitUpsideDown)
        {
            // Portrait mode
            Vector3 newPos = Camera.main.ScreenToWorldPoint(new Vector3(portraitGap, Screen.width / 2, Camera.main.nearClipPlane));
            transform.position = new Vector3(newPos.x, transform.position.y, transform.position.z);
        }
    }
}
