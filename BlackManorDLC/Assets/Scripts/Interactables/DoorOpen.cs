using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{

    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject Actiontext;
    public GameObject TheDoor;

    public AudioSource CreakSound; 

    // Update is called once per frame
    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    private void OnMouseOver()
    {
        if (TheDistance <= 3)
        {
            ActionDisplay.SetActive(true);
            Actiontext.SetActive(true);

        }
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 3)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                Actiontext.SetActive(false);
                TheDoor.GetComponent<Animation>().Play("FirstDoorOpenAnim");
                CreakSound.Play();
            }
        }
    }
     void OnMouseExit()

    {
        ActionDisplay.SetActive(false);
        Actiontext.SetActive(false);
    }
}

