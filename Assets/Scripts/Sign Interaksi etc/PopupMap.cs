using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupMap : MonoBehaviour
{
    [SerializeField] public GameObject dialogImage;
    [SerializeField] public GameObject panel;
    [SerializeField] int letterPerSecond;
    public string dialog;
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
                
            }
            else
            {
                panel.SetActive(true);
                dialogImage.SetActive(true);
                

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
                
        }
    }
}
