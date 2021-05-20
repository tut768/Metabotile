using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WinCondition01 : MonoBehaviour
{
    public GameObject winMenuUI;
    public GameObject topMenuUI;
    public GameObject buildingMenuUI;
    public RaycastHit2D hit;
    public Correctmessage correctmessage;
    public void DetectWin()
    {
        int counter = 0;
        hit = Physics2D.Raycast(new Vector3(0, 1f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("StartBlock"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(0, 0f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("Hexokinase"))
        {
            counter += 1;
        }
        hit = Physics2D.Raycast(new Vector3(0, -1f, -0.5f), Vector3.back);
        if (hit.transform.gameObject.tag == ("EndBlock"))
        {
            counter += 1;
        }
        if (counter == 3)
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
        string text = "You have " + counter + "/3 correct";
        correctmessage.SetText(text);
        correctmessage.gameObject.SetActive(true);

        yield return new WaitForSeconds(3f);

        correctmessage.gameObject.SetActive(false);
    }
}
