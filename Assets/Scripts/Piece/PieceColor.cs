using UnityEngine;

public class PieceColor : MonoBehaviour
{
 
    [SerializeField]
    public int colorInt = 0;
    [SerializeField]
    public Sprite[] brickColor;
    public SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    private void Awake()
    {
        
        colorInt = UnityEngine.Random.Range(0, 6);
        ChooseColor();
    }

    private void ChooseColor()
    {
        

        spriteRenderer.sprite = brickColor[colorInt];

    }
    //TODO
    // set spriteRenderer.sprite to a random sprite that is present above **

    //spriteRenderer.sprite = ???;
}
