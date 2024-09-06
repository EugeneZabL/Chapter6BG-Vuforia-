using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public GameObject ButtonPlay, ButtonPause;

    [SerializeField]
    GameObject _planeFinder;

    [SerializeField]
    Animator _anim;


    void Update()
    {
        TapReyCast();
    }

    void TapReyCast()
    {
        // Проверяем, было ли нажатие на экран
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            // Создаем луч из позиции нажатия
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            // Проверяем, попадает ли луч в объект с Collider
            if (Physics.Raycast(ray, out hit))
            {
                ButtonsController button = hit.collider.GetComponent<ButtonsController>();
                // Если объект был нажат, вызываем соответствующий метод
                if (button != null)
                {
                    button.SendMessage("OnAction");
                }
            }
        }
    }

    public void ChangeAnimation(bool state)
    {
        if (state)
            _anim.Play("Dance");
        else
            _anim.Play("Idle");
    }
}

