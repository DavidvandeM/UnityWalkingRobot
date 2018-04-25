using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Timer : MonoBehaviour
{

    public Text timerText;
    private float startTime;
    private string minutes;
    private string seconds;
    private Vector3 startPosition;
    private float distance;
    public int trialnum = 0;
    //private float endTime;
    private bool started = false;
    //private bool finished = false;

    // Use this for initialization
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Q) && Input.GetKey(KeyCode.UpArrow))
        {
            started = true;
            startTime = Time.time;
            startPosition = transform.position;
            

        }
        //if (finished)
        //    return;
        if (started == true)
            {
            float t = Time.time - startTime;
            
            

            minutes = ((int)t / 60).ToString();
            seconds = (t % 60).ToString("f2");

            timerText.text = minutes + ":" + seconds;
        }

        // if 
        if (started == true && !Input.GetKey(KeyCode.UpArrow))
        {
            started = false;
            trialnum += 1;
            float distance = Vector3.Distance(transform.position, startPosition);

            string trial = "trial " + trialnum.ToString() + " = "; 
            string recordtime = minutes + ":" + seconds;


            Debug.Log("distance" + distance);
            Debug.Log(transform.position.x.ToString());
            Debug.Log(trial + recordtime + " " + distance.ToString());
        }
    }

    //void Update ()
    //{
    // Finish = true;
    //timerText.color = Color.yellow;
    //endTime= Time.time - startTime
    //}
}
