using UnityEngine;

public class Latch : MonoBehaviour
{
    private BoxCollider2D myCollider;

    [SerializeField]
    GameObject otherObject;

    private CircleCollider2D otherCollider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myCollider = GetComponent<BoxCollider2D>(); 
        otherCollider = otherObject.GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //if ()
    }

    void OnTriggerExit2D(Collider2D otherCollider) {
        myCollider.isTrigger = false;
        Debug.Log("triggered");
    }
}
