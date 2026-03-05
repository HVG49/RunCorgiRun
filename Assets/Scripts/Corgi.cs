using System;
using UnityEngine;


public class Corgi : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private SpriteRenderer corgiSpriteRenderer;
    public void Awake()
    {
        corgiSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Move(Vector2 direction)
    {
        FaceCorrectDirection(direction);
        Vector2 movementAmount = 5f * direction * Time.deltaTime;
        print(movementAmount);
        corgiSpriteRenderer.transform.Translate(movementAmount.x, movementAmount.y, 0);
    }

    private void FaceCorrectDirection(Vector2 direction)
    {
        if (direction.x > 0)
        {
            corgiSpriteRenderer.flipX = false;
        }
        else if (direction.x < 0)
        {
            corgiSpriteRenderer.flipX = true;
        }
    }
}
