using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Vector3 positionOffset;

    public GameObject building;

    private Renderer rend;
    private Color startColor;

    BuildManager buildManager;

    void Start ()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        buildManager = BuildManager.instance;
    }

    private void OnMouseDown()
    {
        GameObject buildingToBuild = buildManager.GetBuildingToBuild();

        if (building != null)
        {
            Debug.Log("You clicked on a node this shoudln't happen");
            return;
        }

        if (buildManager.GetBuildingToBuild() == null)
            return;
        if (BuildManager.gameActive == true)
        {
            building = (GameObject)Instantiate(buildingToBuild, transform.position + positionOffset, transform.rotation);

        }
    }

    void OnMouseEnter ()
    {
        if (buildManager.GetBuildingToBuild() == null)
            return;
        if (BuildManager.gameActive == true)
        {
            rend.material.color = hoverColor;
        }
    }

    void OnMouseExit ()
    {
        rend.material.color = startColor;
    }
}
