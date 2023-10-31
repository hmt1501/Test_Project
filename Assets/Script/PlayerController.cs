using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public GameObject start;
    public GameObject end;
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;
  // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, a.transform.position, speed);
        transform.position = Vector3.MoveTowards(transform.position, b.transform.position, speed);
        transform.position = Vector3.MoveTowards(transform.position, c.transform.position, speed);
        transform.position = Vector3.MoveTowards(transform.position, d.transform.position, speed);
        transform.position = Vector3.MoveTowards(transform.position, end.transform.position, speed);
        //if (Input.GetKey("w"))
        //{
        //    transform.Translate(Vector3.up * Time.deltaTime * speed);
        //}
        //if (Input.GetKey("a"))
        //{
        //    transform.Translate(Vector3.left * Time.deltaTime * speed);
        //}
        //if (Input.GetKey("d"))
        //{
        //    transform.Translate(Vector3.right * Time.deltaTime * speed) ;
        //}
        //if (Input.GetKey("s"))
        //{
        //    transform.Translate(Vector3.down * Time.deltaTime * speed) ;
        //}
        //if (transform.position == new Vector3(0, 4, 0))
        //{
        //    transform.position = new Vector3(0,-2,0);
        //}
        //if (absNumber(gameObject.transform.position.x, end.transform.position.x) <1f && absNumber(gameObject.transform.position.y, end.transform.position.y) < 1f)
        //{
        //    //gan vi tri
        //    gameObject.transform.position = start.transform.position;
        //}

        //float horizontalMovement = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        //float verticalMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        // Sử dụng phương thức Translate để di chuyển nhân vật
        //transform.Translate(new Vector3(horizontalMovement, verticalMovement, 0));
 

       

     
    }
    private float absNumber(float x, float y)
    {
        if (x- y > 0)
        {
            return x - y;
        }
        return y - x;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "End")
        {
            gameObject.transform.position = start.transform.position;

        }
    }
    
}
