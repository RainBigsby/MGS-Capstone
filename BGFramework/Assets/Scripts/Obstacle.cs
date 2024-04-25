using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]

public class Obstacle : MonoBehaviour
{
    public bool isCapsule;
    public bool isTriangle;
    public bool isSquare;
    public bool isCircle;
    public Sprite capsule, triangle, square, circle;
    private Sprite usedSprite;

    // This component will change its shape once it is brought into the editor.
    // To see the accurate shape in the editor, click the desired shape option in 
    // the prefab inspector before bringing it into the scene.

    void Awake()
    {
        changeShape();
    }

    public void changeShape()
    {
        // check for changing shape to capsule
        if (isCapsule == true)
        {
            GetComponent<SpriteRenderer>().sprite = capsule;
            usedSprite = capsule;
        }

        // check for changing shape to triangle
        if (isTriangle == true)
        {
            GetComponent<SpriteRenderer>().sprite = triangle;
            usedSprite = triangle;
        }

        // check for changing shape to square
        if (isSquare == true)
        {
            GetComponent<SpriteRenderer>().sprite = square;
            usedSprite = square;
        }

        // check for changing shape to circle
        if (isCircle == true)
        {
            GetComponent<SpriteRenderer>().sprite = circle;
            usedSprite = circle;
        }

        changeCollider(usedSprite);

    }

    public void changeCollider(Sprite collision)
    {
        // adjust hitbox depending on shape
        this.GetComponent<BoxCollider2D>().size = 
            GetComponent<SpriteRenderer>().sprite.bounds.size;
    }
}
