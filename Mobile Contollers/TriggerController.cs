using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class TriggerController : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    public Image triggerBG;
    public Image trigger;

    private Vector2 rotateVector; // полученные координаты триггера  

    private void Awake()
    {
        triggerBG = GetComponent<Image>();
        trigger = transform.GetChild(0).GetComponent<Image>();
    }

    public void OnPointerDown(PointerEventData ped)
    {
        OnDrag(ped);
    }

    public void OnPointerUp(PointerEventData ped)
    {
        rotateVector = Vector2.zero;

        trigger.rectTransform.anchoredPosition = Vector2.zero; // возврат триггера в центр
    }

    public void OnDrag(PointerEventData ped)
    {
        Trigger(ped);
    }

    // Метод контроллера тригера
    private void Trigger(PointerEventData ped)
    {
        Vector2 pos;       

        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(triggerBG.rectTransform, ped.position, ped.pressEventCamera, out pos))
        {
            pos.x = (pos.x / triggerBG.rectTransform.sizeDelta.x); // получение координат позиции касания на триггер
            pos.y = (pos.y / triggerBG.rectTransform.sizeDelta.y); // получение координат позиции касания на триггер

            rotateVector = new Vector2(pos.x * 2f - 1, pos.y * 2f - 1); // установка точных координаты из касания      

            rotateVector = (rotateVector.magnitude > 1.0f) ? rotateVector.normalized : rotateVector;    

            trigger.rectTransform.anchoredPosition = new Vector2(rotateVector.x * (triggerBG.rectTransform.sizeDelta.x / 5f), rotateVector.y * (triggerBG.rectTransform.sizeDelta.y / 5f));

        }
    }
    
    // Метод возврата горизонтальной оси
    public float Horizontal()
    {
        if (rotateVector.x != 0) return rotateVector.x;
        else return Input.GetAxis("Horizontal");
    }

    // Метод возврата вертикальной оси
    public float Vertical()
    {
        if (rotateVector.y != 0) return rotateVector.y;
        else return Input.GetAxis("Vertical");
    }

}
