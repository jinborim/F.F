using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class SelectPanel : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{

    private Color color_;
    public Image Panel_Img;
    public bool Panel_activated=false;

    public void OnPointerEnter(PointerEventData eventData)
    {
        
        Panel_activated = true;
        Panel_ColorChanger(true);
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        
        Panel_activated = false;
        Panel_ColorChanger(false);

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            if (Panel_activated == true)
            {
                SceneManager.LoadScene("WORDLE");
                
                //씬 연결해줄 부분..ㅎ
            }
            else
            {

            }
        }
    }

    public void Panel_ColorChanger(bool Panelactivated_)
    {
        if (Panel_activated == true)
        {
            color_ = new Color(1, 1, 1, 1);
            color_.a = 1;
            Panel_Img.color = color_;
        }
        else
        {
            color_ = new Color(1, 1, 1, 1);
            color_.a = 0.8f;
            Panel_Img.color = color_;
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        Panel_Img = transform.GetComponent<Image>();
        //Panel_Img.color = color_;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
