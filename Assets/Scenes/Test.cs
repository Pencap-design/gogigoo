
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    public float speed;
    public float control;
    public float rotation;
    public int jump;
    public Rigidbody rb;
    public GameObject WinUI;
    public GameObject LoseUi;

    public Roadgenerator rg;
 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    { 
        rb.AddForce(speed * Time.deltaTime * Vector3.forward);
       
        rotation = Input.GetAxis("Horizontal") * control * Time.deltaTime;
        transform.position += Vector3.right * rotation;

        if (transform.position.x <= 2)
        {
            transform.position = new Vector3(2,transform.position.y,transform.position.z);
        }
        if (transform.position.x >= 9)
        {
            transform.position = new Vector3(9, transform.position.y, transform.position.z);
        }        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "wall")
        {
            speed = 0;
            rotation = 0;
            control = 0;
            
               Invoke("Restart",3f);

            
            LoseUi.SetActive(true);
        }

       
    }

    private void OnTriggerEnter(Collider aa)
    {
        if(aa.tag == "road")
        {
            rg.addRoad();

        }
    }
    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

   
}
