using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WinCondition03 : MonoBehaviour
{
    public GameObject winMenuUI;
    public GameObject topMenuUI;
    public GameObject buildingMenuUI;
    public RaycastHit2D hit;
    public Correctmessage correctmessage;
    public void DetectWin()
    {
        //main column
        int counter = 0;
        hit = Physics2D.Raycast(new Vector3(0, 5f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("StartBlock"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(0, 4f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("Hexokinase"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(0, 3f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("Phosphoglucose Isomerase"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(0, 2f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("Phosphofructokinase"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(0, 1f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("Fructose 1,6-bisphosphate Aldolase"))
        {
            counter += 1;
        }
        //Dihydroxy column
        hit = Physics2D.Raycast(new Vector3(-1, 1f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("Triose Phosphate Isomerase"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(-1, 0f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("Glyceraldehyde-3-Phosphate Dehydrogenase"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(-1, -1f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("Phosphoglycerate Kinase"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(-1, -2f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("Phosphoglycerate Mutase"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(-1, -3f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("Enolase"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(-1, -4f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("Pyruvate Kinase"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(-1, -5f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("EndBlock"))
        {
            counter += 1;
        }

        //Glyceraldehyde column
        hit = Physics2D.Raycast(new Vector3(1, 1f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("Glyceraldehyde-3-Phosphate Dehydrogenase"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(1, 0f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("Phosphoglycerate Kinase"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(1, -1f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("Phosphoglycerate Mutase"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(1, -2f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("Enolase"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(1, -3f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("Pyruvate Kinase"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(1, -4f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("EndBlock"))
        {
            counter += 1;
        }

        //check if correct
        if (counter == 18)
        {
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
        string text = "You have " + counter + "/18 correct";
        correctmessage.SetText(text);
        correctmessage.gameObject.SetActive(true);

        yield return new WaitForSeconds(3f);

        correctmessage.gameObject.SetActive(false);
    }
}
