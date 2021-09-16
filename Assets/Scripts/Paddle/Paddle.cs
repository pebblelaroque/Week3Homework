using UnityEngine;

public class Paddle : MonoBehaviour
{
    private float speed = 5.0f;

    [SerializeField]
    private GameObject ballPrefab = null;

    
    

    private void Start()
    {
        
    }

    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
           
            if(GameObject.Find("Ball(Clone)") == null)
            {
                Vector3 spawnPoint = new Vector3(GetComponent<Paddle>().transform.position.x, -3.6f, 0.0f);
                Instantiate(ballPrefab, spawnPoint, Quaternion.identity);
                
            }
           
        }

       
        
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Paddle>().transform.Translate(Vector3.left * Time.deltaTime * speed, Space.World);
        }

        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Paddle>().transform.Translate(Vector3.right * Time.deltaTime * speed, Space.World);
        }

        var xPos = Mathf.Clamp(transform.position.x, -5.5f, 6.0f);
        GetComponent<Paddle>().transform.position = new Vector3(xPos, transform.position.y, transform.position.z);

        

    }
    //TODO
    // Move paddle left and right using keyboard keys, mapping is up to you **DONE**
    // Paddle should be able to launch the ball upon space bar being pressed **DONE**
    // A launched ball will then bounce around, changing its direction upon any collision **DONE**
}
