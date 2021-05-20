using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WinCondition05 : MonoBehaviour
{
    public GameObject winMenuUI;
    public GameObject topMenuUI;
    public GameObject buildingMenuUI;
    public RaycastHit2D hit;
    public Correctmessage correctmessage;
    public void DetectWin()
    {
        int counter = 0;
        hit = Physics2D.Raycast(new Vector3(-1, 3f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("StartblockFADH2"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(-1, 2f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("C2"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(-1, 1f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("Q10"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(-1, 0f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("C3"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(-1, -1f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("C"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(-1, -2f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("C4"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(-1, -3f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("EndBlockoxygen"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(1, 3f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("StartblockNADH"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(1, 2f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("C1"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(1, 1f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("Q10"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(1, 0f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("C3"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(1, -1f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("C"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(1, -2f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("C4"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(1, -3f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("EndBlockoxygen"))
        {
            counter += 1;
        }

        //check if correct
        if (counter == 14)
        {
            Debug.Log("testing answer");
            winMenuUI.SetActive(true);
            topMenuUI.SetActive(false);
            buildingMenuUI.SetActive(false);
            TooltipSystem.tooltipActive = false;
            TooltipSystem.Hide();
        }
        else
        {
            StartCoroutine(Displaymessage(counter));
        }
    }

    IEnumerator Displaymessage(int counter)
    {
        string text = "You have " + counter + "/14 correct";
        Debug.Log("Setting message");
        correctmessage.SetText(text);
        correctmessage.gameObject.SetActive(true);

        yield return new WaitForSeconds(3f);

        correctmessage.gameObject.SetActive(false);
    }
}
