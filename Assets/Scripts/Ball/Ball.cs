using UnityEngine;

public class Ball : MonoBehaviour
{


    [SerializeField]
    private Rigidbody2D rigidBody = null;

    [SerializeField]
    private float speed = 50.0f;

    private Vector3 currentDirection = Vector3.zero;

    private bool hasStarted = false;
    private void Awake()
    {
        
        currentDirection = new Vector3(Random(), Random(), 0);
        if(currentDirection.y > 0)
        {
            currentDirection.y *= -1;
        }

    }

    private void Start()
    {
        hasStarted = false;
        
    }

    void Update()
    {
       
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            hasStarted = true;
            
        }
        if(hasStarted == true)
        {
            
            var newDelta = currentDirection * Time.deltaTime * speed;
            GetComponent<Rigidbody2D>().MovePosition(transform.position + newDelta);

        }
        if (hasStarted == false)
        {

           
            GetComponent<Rigidbody2D>().transform.position = new Vector3(GameObject.Find("Paddle").transform.position.x, -3.6f, 0.0f);
        }




    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        currentDirection = Vector2.Reflect(currentDirection, collision.contacts[0].normal);

        if (collision.gameObject.CompareTag("Piece"))
        {
            
            Destroy(collision.gameObject);
        }
    }

    private int Random()
    {
        return UnityEngine.Random.Range(0, 2) == 0 ? -1 : 1;
    }

    //TODO: Add code to move ball along with code to delete pieces upon colliding with one **DONE**
    //Ball should only move once its been launched **DONE**
}