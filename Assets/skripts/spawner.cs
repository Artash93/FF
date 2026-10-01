using UnityEngine;

public class spawner : MonoBehaviour

{
    [SerializeField] private int speed;
    [SerializeField] private GameObject _spawn;

    [SerializeField] private Animation an;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
    
        
        
        if (Input.GetKeyDown(KeyCode.Space))

        {
            Instantiate(_spawn, transform.position, transform.rotation);
        }
        
    }
}

// anmator = GetcOMMO<Animation>();
