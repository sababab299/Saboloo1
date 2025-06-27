using System.Collections;
using UnityEngine;
[RequireComponent(typeof(Camera))]

public class Aspect : MonoBehaviour
{
    // Desired aspect ratio (width / height)
    private readonly float targetAspect = 9f / 16f;

    void Start()
    {
        SetAspect();
        //StartCoroutine(SetAspectCoroutine());
    }

    IEnumerator SetAspectCoroutine()
    {
        yield return new WaitForEndOfFrame();
        SetAspect();
    }

    void SetAspect()
    {
        float windowAspect = (float)Screen.width / (float)Screen.height;
        float scaleHeight = windowAspect / targetAspect;

        Camera cam = GetComponent<Camera>();

        if (scaleHeight < 1.0f)
        {
            // Add letterbox
            Rect rect = new Rect(0.0f, (1.0f - scaleHeight) / 2.0f, 1.0f, scaleHeight);
            cam.rect = rect;
        }
        else
        {
            // Add pillarbox
            float scaleWidth = 1.0f / scaleHeight;
            Rect rect = new Rect((1.0f - scaleWidth) / 2.0f, 0.0f, scaleWidth, 1.0f);
            cam.rect = rect;
        }
    }
}