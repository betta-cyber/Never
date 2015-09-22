using UnityEngine;
using System.Collections;

public class PlayerControl1 : MonoBehaviour
{
    static int count;
    private bool enter = false;
    private bool enter1 = false;
    private Vector3 pos1;
    private Vector3 pos2;
    public static bool trigger;

    public Transform TimeMiki;
    public Transform TimeMiki1;
    // Use this for initialization
    void Start()
    {
        count = 0;
        trigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        scankey();
        if (Input.GetKeyDown(KeyCode.J) && count < 2)
        {
            if (count == 0)
            {
                TimeMiki.gameObject.SetActive(true);
                //GameObject t0 = Instantiate(TimeMiki, transform.position, transform.rotation) as GameObject;
                TimeMiki.position = transform.position;
                pos1 = transform.position;
            }
            if (count == 1)
            {
                TimeMiki1.gameObject.SetActive(true);
                //GameObject t0 = Instantiate(TimeMiki, transform.position, transform.rotation) as GameObject;
                TimeMiki1.position = transform.position;
                pos2 = transform.position;
            }
            count++;
            Debug.Log(count);
        }

        if (Input.GetKeyDown(KeyCode.J) && enter)
        {
            TimeMiki.gameObject.SetActive(false);
            count--;
            Debug.Log("xx");
        }
        if (Input.GetKeyDown(KeyCode.J) && enter1)
        {
            TimeMiki1.gameObject.SetActive(false);
            Debug.Log("vv");
        }

        if (Input.GetKeyDown(KeyCode.K) && enter)
        {
            transform.position = pos2;
            enter = false;
        }
        if (Input.GetKeyDown(KeyCode.K) && enter1)
        {
            transform.position = pos1;
            enter1 = false;
        }
    }

    void scankey()
    {
        if (Input.GetKey(KeyCode.A) | Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-5 * Time.deltaTime, 0, 0, Space.World);
            Vector3 theScale = transform.localScale;
            theScale.x = -1;
            transform.localScale = theScale;
        }
        if (Input.GetKey(KeyCode.D) | Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(5 * Time.deltaTime, 0, 0, Space.World);
            Vector3 theScale = transform.localScale;
            theScale.x = 1;
            transform.localScale = theScale;
        }
        if (Input.GetKey(KeyCode.W) | Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 5 * Time.deltaTime, 0, Space.World);
        }
        if (Input.GetKey(KeyCode.S) | Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -5 * Time.deltaTime, 0, Space.World);
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "TimeMiki")
        {
            Debug.Log("11");
            enter = true;
        }
        if (col.tag == "TimeMiki1")
        {
            Debug.Log("22");
            enter1 = true;
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "TimeMiki")
        {
            enter = false;
        }
        if (col.tag == "TimeMiki1")
        {
            enter1 = false;
        }
    }
}