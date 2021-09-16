using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    private void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Destroy(collision.gameObject);
            
        }
      
        
        //TODO: Implement functionality to reset the game somehow. **DONE**
        // Resetting the game includes destroying the out of bounds ball and creating a new one ready to be launched from the paddle **DONE**
    }
}
