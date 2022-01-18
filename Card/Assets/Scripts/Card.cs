using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    // card sprites
    [SerializeField]
    Sprite faceUpSprite;
    [SerializeField]
    Sprite faceDownSprite;
    [SerializeField]
    string rank;
    [SerializeField]
    string suit;
    [SerializeField]
    bool faceUp;

    SpriteRenderer spriteRenderer;

    public string Rank { get { return rank; } }
    public string Suit { get { return suit; } }
    public bool FaceUp { get { return faceUp; } }





    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        SetSprite();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FlipOver()
    {
        faceUp = !faceUp;
        SetSprite();
    }

    void SetSprite()
    {
        if(faceUp)
        {
            spriteRenderer.sprite = faceUpSprite;
        }
        else
        {
            spriteRenderer.sprite = faceDownSprite;
        }
    }
}
