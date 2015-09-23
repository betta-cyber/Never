using UnityEngine;
using System.Collections;

public class PlayerControl1 : MonoBehaviour
{
    static int status;
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
        status = 0;
        trigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        scankey();
        if (Input.GetKeyDown(KeyCode.J) && status < 3)
        {
            if (status == 0)
            {
                TimeMiki.gameObject.SetActive(true);
                TimeMiki.position = transform.position;
                pos1 = transform.position;
                status = 2;
                return;
            }
            if (status == 1)
            {
                TimeMiki.gameObject.SetActive(true);
                TimeMiki.position = transform.position;
                pos1 = transform.position;
                status = 3;
            }
            if (status == 2)
            {
                Debug.Log("111");
                TimeMiki1.gameObject.SetActive(true);
                TimeMiki1.position = transform.position;
                pos2 = transform.position;
                status = 3;
            }
            if (status == 3)
            {
                return;
            }
            Debug.Log(status);
        }

        if (Input.GetKeyDown(KeyCode.J) && enter)
        {
            TimeMiki.gameObject.SetActive(false);
            enter = false;
            status = 1;
        }
        if (Input.GetKeyDown(KeyCode.J) && enter1)
        {
            TimeMiki1.gameObject.SetActive(false);
            enter1 = false;
            status = 2;
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
            enter = true;
        }
        if (col.tag == "TimeMiki1")
        {
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