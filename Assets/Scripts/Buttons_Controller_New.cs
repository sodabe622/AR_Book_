using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons_Controller_New : MonoBehaviour
{
    private GameObject picture_button, picture_1, picture_2, picture_3, picture_close_button, short_details_button, more_details_button, short_details_text, more_details_text;

    // Start is called before the first frame update
    void Start()
    {
        picture_button = GameObject.Find("ImageTargetBackCover/Canvas/Picture Button");
        picture_1 = GameObject.Find("ImageTargetBackCover/Picture_1");
        picture_2 = GameObject.Find("ImageTargetBackCover/Picture_2");
        picture_3 = GameObject.Find("ImageTargetBackCover/Picture_3");
        picture_close_button = GameObject.Find("ImageTargetBackCover/Canvas/Picture Close Button");
        short_details_button = GameObject.Find("ImageTargetBackCover/Canvas/Short Details Button");
        more_details_button = GameObject.Find("ImageTargetBackCover/Canvas/More Button");
        short_details_text = GameObject.Find("ImageTargetBackCover/Canvas/Short Details Text");
        more_details_text = GameObject.Find("ImageTargetBackCover/Canvas/More Details Text");

        picture_1.SetActive(false);
        picture_2.SetActive(false);
        picture_3.SetActive(false);
        short_details_text.SetActive(false);
        more_details_text.SetActive(false);
        picture_close_button.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Picture_Button_Pressed()
    {
        picture_button.SetActive(false);
        short_details_button.SetActive(false);
        more_details_button.SetActive(false);
        picture_1.SetActive(true);
        picture_2.SetActive(true);
        picture_3.SetActive(true);
        picture_close_button.SetActive(true);
    }

    public void Picture_Close_Button_Pressed()
    {
        picture_1.SetActive(false);
        picture_2.SetActive(false);
        picture_3.SetActive(false);
        picture_close_button.SetActive(false);
        short_details_text.SetActive(false);
        more_details_text.SetActive(false);
        picture_button.SetActive(true);
        short_details_button.SetActive(true);
        more_details_button.SetActive(true);
    }

    public void Short_Details_Button_Pressed()
    {
        picture_button.SetActive(false);
        short_details_button.SetActive(false);
        more_details_button.SetActive(false);
        short_details_text.SetActive(true);
        picture_close_button.SetActive(true);
    }

    public void More_Details_Button_Pressed()
    {
        picture_button.SetActive(false);
        short_details_button.SetActive(false);
        more_details_button.SetActive(false);
        more_details_text.SetActive(true);
       picture_close_button.SetActive(true);
    }
}
