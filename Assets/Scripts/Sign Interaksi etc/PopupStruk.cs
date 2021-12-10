using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupStruk : MonoBehaviour
{
    [SerializeField] public GameObject dialogImage;
    [SerializeField] public GameObject panel;
    [SerializeField] public GameObject dialogImagi;
    public bool PlayerInRange;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && PlayerInRange)
        {
            if (panel.activeInHierarchy)
            {
                panel.SetActive(false);
                dialogImage.SetActive(false);
                dialogImagi.SetActive(false);
                
            }
            else
            {
                panel.SetActive(true);
                dialogImage.SetActive(true);
                dialogImagi.SetActive(true);
                

            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerInRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerInRange = false;
            panel.SetActive(false);
            dialogImage.SetActive(false);
            dialogImagi.SetActive(false);
                
        }
    }
}
