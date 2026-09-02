using UnityEngine;

public class MoveObject : MonoBehaviour
{
    [SerializeField] float speed = 0.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Test Moving object on Console");
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 input = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
        //transform.Translate(input * speed * Time.deltaTime);
        transform.Translate(speed, 0f, 0f);
    }
}
