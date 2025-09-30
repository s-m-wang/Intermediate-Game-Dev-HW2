using UnityEngine;

public class PinballSpinner : MonoBehaviour
{
    public Sprite spinLit;
    public Sprite spinUnlit;
    public SpriteRenderer render;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("ball"))
        {
            render.sprite = spinLit;
            Invoke("resetSprite",1.0f);
        }
    }

    void resetSprite() {
        render.sprite = spinUnlit;
    }
}
