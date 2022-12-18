using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TanookiStudio
{
    public class Resolution : MonoBehaviour
    {
        public static Vector2 ScreenPointToCanvas(Vector2 screenPosition)
        {
            var viewportPosition = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            return ViewportPointToCanvas(viewportPosition);
        }
        public static Vector2 ViewportPointToCanvas(Vector2 viewportPosition)
        {
            return viewportPosition * GetCanvasResolution();
        }
        public static Vector2 WorldPointToCanvas(Vector3 worldPosition, bool relativeToMiddle = false)
        {
            var viewportPosition = (Vector2)Camera.main.WorldToViewportPoint(worldPosition);
            var canvasPosition = ViewportPointToCanvas(viewportPosition);

            if (relativeToMiddle)
                canvasPosition -= Resolution.GetCanvasResolution() * 0.5f;

            return canvasPosition;
        }
        public static Vector2 GetCanvasResolution()
        {
            if (GameObject.FindGameObjectWithTag("MainCanvas") == null)
                throw new System.Exception("Did not find Canvas with `MainCanvas` tag. Please set this tag to the reference canvas");

            CanvasScaler scaler = GameObject.FindGameObjectWithTag("MainCanvas").GetComponent<CanvasScaler>();
            var proportion = (float)UnityEngine.Screen.width / UnityEngine.Screen.height;
            float x = scaler.referenceResolution.x;
            float y = x / proportion;

            return new Vector2(x, y);
        }
    }
}