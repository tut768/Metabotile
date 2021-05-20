using UnityEngine;

public class Buildings : MonoBehaviour
{
    BuildManager buildManager;

    private GameObject building;
    public GameObject buildingtype;


    private void Start()
    {
        buildManager = BuildManager.instance;
        SetBuilding(buildingtype);
    }

    private void OnMouseDown()
    {
        GameObject buildingToBuild = buildManager.GetBuildingToBuild();

        if (buildingToBuild == null)
        {
            Debug.Log("Destroying");
            Destroy(building);
            TooltipSystem.Hide();
        }
        else
        {
            Debug.Log("Cant build there!");
            return;
        }
    }

    public void SetBuilding(GameObject buildingtype)
    {
        building = buildingtype;
    }
    
}
