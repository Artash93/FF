using UnityEngine;

public class Player : MonoBehaviour
{
    
    public int speed;

    [SerializeField] private Animator animator;

    [SerializeField] private Transform _target;

    [SerializeField] private CharacterController _controller;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        Vector3 direction = _target.position - transform.position;
      
        if (direction.magnitude > 0.1f)
        {
            transform.position += speed * Time.deltaTime * direction.normalized;
            transform.forward = direction;
        }

        // if (Input.GetKey(KeyCode.W))
        //
        // {
        //     transform.position+=(Vector3.forward * speed * Time.deltaTime);
        // }
        //
        // if (Input.GetKey(KeyCode.S))
        //     
        // {
        //     transform.Translate(Vector3.back * speed * Time.deltaTime);
        // } 
        //
        // if (Input.GetKey(KeyCode.D))
        //
        // {
        //     transform.Translate(Vector3.right* speed * Time.deltaTime);
        // }
        //
        // if (Input.GetKey(KeyCode.A))
        //
        // {
        //     transform.Translate(Vector3.left* speed * Time.deltaTime);
        // }
    }
}
