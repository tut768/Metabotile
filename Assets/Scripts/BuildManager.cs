using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;
    public static bool gameActive;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one build manager exits");
            return;
        }
        instance = this;
        gameActive = true;
    }

    public GameObject basicBlockPrefab;
    public GameObject startBlockPrefab;
    public GameObject endBlockPrefab;

    public GameObject startBlockPyruvatePrefab;
    public GameObject endBlockNADHLPrefab;
    public GameObject endBlockNADHRPrefab;
    public GameObject endBlockNADHPrefab;
    public GameObject endBlockFADH2Prefab;

    public GameObject endBlockOxygenPrefab;
    public GameObject startBlockNADHPrefab;
    public GameObject startBlockFADH2Prefab;

    //Glycolysis
    public GameObject HexokinasePrefab;
    public GameObject Phosphoglucose_IsomerasePrefab;
    public GameObject PhosphofructokinasePrefab;
    public GameObject Fructose_bisphosphate_AldolasePrefab;
    public GameObject Triose_Phosphate_IsomerasekPrefab;
    public GameObject Glyceraldehyde_Phosphate_DehydrogenasePrefab;
    public GameObject Phosphoglycerate_KinasePrefab;
    public GameObject Phosphoglycerate_MutasePrefab;
    public GameObject EnolasePrefab;
    public GameObject Pyruvate_KinasePrefab;

    //Cytric Acid Cycle

    public GameObject Pyruvate_DehydrogenasePrefab;
    public GameObject Citrate_SynthasePrefab;
    public GameObject AconitasePrefab;
    public GameObject Isocitrate_DehydrogenasePrefab;
    public GameObject Oxoglutarate_Dehydrogenase_ComplexPrefab;
    public GameObject Succinyl_CoA_SynthasePrefab;
    public GameObject Succinate_DehydrogenasePrefab;
    public GameObject FumarasePrefab;
    public GameObject Malate_DehydrogenasePrefab;

    //Electron Transport
    public GameObject C1Prefab;
    public GameObject C2Prefab;
    public GameObject Q10Prefab;
    public GameObject bc1Prefab;
    public GameObject C_OxidasePrefab;
    public GameObject CPrefab;

    private GameObject buildingToBuild;

    public GameObject GetBuildingToBuild()
    {
        return buildingToBuild;
    }

    public void SetBuildingToBuild(GameObject building)
    {
        buildingToBuild = building;
    }

    public void DestroyBuildingMode()
    {
        buildingToBuild = null;
    }
}
