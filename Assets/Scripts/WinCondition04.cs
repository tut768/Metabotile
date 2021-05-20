using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WinCondition04 : MonoBehaviour
{
    public GameObject winMenuUI;
    public GameObject topMenuUI;
    public GameObject buildingMenuUI;
    public RaycastHit2D hit;
    public Correctmessage correctmessage;
    public void DetectWin()
    {
        int counter = 0;
        hit = Physics2D.Raycast(new Vector3(0, 3f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("StartBlock"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(0, 2f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("Pyruvate Dehydrogenase"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(0, 1f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("Citrate Synthase"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(1, 1f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("Aconitase"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(1, 0f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("Isocitrate Dehydrogenase"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(1, -1f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("Oxoglutarate Dehydrogenase"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(0, -1f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("Succinyl Synthase"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(-1, -1f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("Succinate Dehydrogenase"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(-1, 0f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("Fumarase"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(-1, 1f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("Malate Dehydrogenase"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(2, 0f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("EndBlockNADHL"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(1, -2f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("EndBlockNADH"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(-1, -2f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("EndBlockFADH2"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(-2, 1f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("EndBlockNADHR"))
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
