using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteAnimator : MonoBehaviour
{
    [SerializeField] Sprite[] frameArray;
    [SerializeField] float framerate;
    private int currentFrame;
    private float timer;
    private Image ImgObject;

    private void Awake()
    {
        ImgObject = gameObject.GetComponent<Image>();
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= framerate)
        {
            timer -= framerate;
            currentFrame = (currentFrame + 1) % frameArray.Length;
            ImgObject.sprite = frameArray[currentFrame];
        }
    }
}
