
using UnityEngine;
//using UnityEngine.ParticleSystem;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float moveeSpeed = 5f;
    [SerializeField] float rotateSpeed = 120f;
    [SerializeField] ParticleSystem TestParticle;
    bool iskey = false;
    SpriteRenderer carRender;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        carRender = GetComponent<SpriteRenderer>();
    }
    // Rotation
        
    // Update is called once per frame
    void Update()
    {
        //Rotation
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0f, 0f, rotateSpeed * Time.deltaTime);

        }
        if(Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0f, 0f, -rotateSpeed * Time.deltaTime);

        }
        float x = Input.GetAxis("Horizontal"); // This to  - 1 or +1 for the x
        float y = Input.GetAxis("Vertical");
        Vector3 Move = new Vector3(x, y, 0f);
        //transform.Rotate(0f, 0.4f,0f);
        transform.Translate(Move * moveeSpeed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        Debug.Log("Collision happened " + collision.gameObject.name);
        if (collision.collider.CompareTag("TEST"))
        {
            Debug.Log("Hitting Obstacle");
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Trigger happened");
        Debug.Log(iskey);
        if (other.CompareTag("TEST"))
        {
            iskey = true;
            Debug.Log("You trigger with an object" + other.gameObject.name);
            Debug.Log(iskey);
            carRender.color = Color.yellow;
            //TestParticle.transform.position = transform.position;  // <-- move it to the car

            TestParticle.Play();
            //Destroy(other.gameObject);

        }

        
            
    }
        
        
            
    }

    


