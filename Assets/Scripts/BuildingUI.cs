using UnityEngine;

public class BuildingUI : MonoBehaviour
{
    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectBasicBlock()
    {
        Debug.Log("Basic Block Selected");
        buildManager.SetBuildingToBuild(buildManager.basicBlockPrefab);
    }

    public void SelectStartBlock()
    {
        Debug.Log("Start Block Selected");
        buildManager.SetBuildingToBuild(buildManager.startBlockPrefab);
    }

    public void SelectStartBlockPyruvate()
    {
        Debug.Log("Start Block Selected");
        buildManager.SetBuildingToBuild(buildManager.startBlockPyruvatePrefab);
    }
    public void SelectStartBlockFADH2()
    {
        Debug.Log("Start Block Selected");
        buildManager.SetBuildingToBuild(buildManager.startBlockFADH2Prefab);
    }
    public void SelectStartBlockNADH()
    {
        Debug.Log("Start Block Selected");
        buildManager.SetBuildingToBuild(buildManager.startBlockNADHPrefab);
    }

    public void SelectEndBlock()
    {
        Debug.Log("End Block Selected");
        buildManager.SetBuildingToBuild(buildManager.endBlockPrefab);
    }
    public void SelectEndBlockNADH()
    {
        Debug.Log("End Block Selected");
        buildManager.SetBuildingToBuild(buildManager.endBlockNADHPrefab);
    }
    public void SelectEndBlockNADHL()
    {
        Debug.Log("End Block Selected");
        buildManager.SetBuildingToBuild(buildManager.endBlockNADHLPrefab);
    }
    public void SelectEndBlockNADHR()
    {
        Debug.Log("End Block Selected");
        buildManager.SetBuildingToBuild(buildManager.endBlockNADHRPrefab);
    }
    public void SelectEndBlockFADH2()
    {
        Debug.Log("End Block Selected");
        buildManager.SetBuildingToBuild(buildManager.endBlockFADH2Prefab);
    }
    public void SelectEndBlockOxygen()
    {
        Debug.Log("End Block Selected");
        buildManager.SetBuildingToBuild(buildManager.endBlockOxygenPrefab);
    }

    public void SelectDestroy()
    {
        Debug.Log("Destroy Selected");
        buildManager.DestroyBuildingMode();
    }

    //Glycolysis
    public void SelectHexokinase()
    {
        Debug.Log("Hexokinase Selected");
        buildManager.SetBuildingToBuild(buildManager.HexokinasePrefab);
    }

    public void SelectPhosphoglucose_Isomerase()
    {
        Debug.Log("Phosphoglucose Isomerase Selected");
        buildManager.SetBuildingToBuild(buildManager.Phosphoglucose_IsomerasePrefab);
    }

    public void SelectPhosphofructokinase()
    {
        Debug.Log("Phosphofructokinase Selected");
        buildManager.SetBuildingToBuild(buildManager.PhosphofructokinasePrefab);
    }

    public void SelectFructose_bisphosphate_Aldolase()
    {
        Debug.Log("Fructose 1,6-bisphosphate Aldolase Selected");
        buildManager.SetBuildingToBuild(buildManager.Fructose_bisphosphate_AldolasePrefab);
    }

    public void SelectTriose_Phosphate_Isomerase()
    {
        Debug.Log("Triose Phosphate Isomerase Selected");
        buildManager.SetBuildingToBuild(buildManager.Triose_Phosphate_IsomerasekPrefab);
    }

    public void SelectGlyceraldehyde_Phosphate_Dehydrogenase()
    {
        Debug.Log("Glyceraldehyde-3-Phosphate Dehydrogenase Selected");
        buildManager.SetBuildingToBuild(buildManager.Glyceraldehyde_Phosphate_DehydrogenasePrefab);
    }

    public void SelectPhosphoglycerate_Kinase()
    {
        Debug.Log("Phosphoglycerate Kinase Selected");
        buildManager.SetBuildingToBuild(buildManager.Phosphoglycerate_KinasePrefab);
    }

    public void SelectPhosphoglycerate_Mutase()
    {
        Debug.Log("Phosphoglycerate Mutase Selected");
        buildManager.SetBuildingToBuild(buildManager.Phosphoglycerate_MutasePrefab);
    }

    public void SelectEnolase()
    {
        Debug.Log("Enolase Selected");
        buildManager.SetBuildingToBuild(buildManager.EnolasePrefab);
    }

    public void SelectPyruvate_Kinase()
    {
        Debug.Log("Pyruvate Kinase Selected");
        buildManager.SetBuildingToBuild(buildManager.Pyruvate_KinasePrefab);
    }

    //Citric acid cycle

    public void SelectPyruvate_Dehydrogenase()
    {
        Debug.Log("Pyruvate_Dehydrogenase Selected");
        buildManager.SetBuildingToBuild(buildManager.Pyruvate_DehydrogenasePrefab);
    }
    public void SelectCitrate_Synthase()
    {
        Debug.Log("Citrate_Synthase Selected");
        buildManager.SetBuildingToBuild(buildManager.Citrate_SynthasePrefab);
    }
    public void SelectAconitase()
    {
        Debug.Log("Aconitase Selected");
        buildManager.SetBuildingToBuild(buildManager.AconitasePrefab);
    }
    public void SelectIsocitrate_Dehydrogenase()
    {
        Debug.Log("Isocitrate_Dehydrogenase Selected");
        buildManager.SetBuildingToBuild(buildManager.Isocitrate_DehydrogenasePrefab);
    }
    public void SelectOxoglutarate_Dehydrogenase_Complex()
    {
        Debug.Log("Oxoglutarate_Dehydrogenase_Complex Selected");
        buildManager.SetBuildingToBuild(buildManager.Oxoglutarate_Dehydrogenase_ComplexPrefab);
    }
    public void SelectSuccinyl_CoA_Synthase()
    {
        Debug.Log("Succinyl_CoA_Synthase Selected");
        buildManager.SetBuildingToBuild(buildManager.Succinyl_CoA_SynthasePrefab);
    }
    public void SelectSuccinate_Dehydrogenase()
    {
        Debug.Log("Succinate_Dehydrogenase Selected");
        buildManager.SetBuildingToBuild(buildManager.Succinate_DehydrogenasePrefab);
    }
    public void SelectFumarase()
    {
        Debug.Log("Fumarase Selected");
        buildManager.SetBuildingToBuild(buildManager.FumarasePrefab);
    }
    public void SelectMalate_Dehydrogenase()
    {
        Debug.Log("Malate_Dehydrogenase Selected");
        buildManager.SetBuildingToBuild(buildManager.Malate_DehydrogenasePrefab);
    }

    //Electron Transport
    public void SelectC1()
    {
        Debug.Log("C1 Selected");
        buildManager.SetBuildingToBuild(buildManager.C1Prefab);
    }
    public void SelectC2()
    {
        Debug.Log("C2 Selected");
        buildManager.SetBuildingToBuild(buildManager.C2Prefab);
    }
    public void SelectQ10()
    {
        Debug.Log("Q10 Selected");
        buildManager.SetBuildingToBuild(buildManager.Q10Prefab);
    }
    public void SelectBc1()
    {
        Debug.Log("Bc1 Selected");
        buildManager.SetBuildingToBuild(buildManager.bc1Prefab);
    }
    public void SelectC()
    {
        Debug.Log("C Selected");
        buildManager.SetBuildingToBuild(buildManager.CPrefab);
    }
    public void SelectC_Oxidase()
    {
        Debug.Log("C_Oxidase Selected");
        buildManager.SetBuildingToBuild(buildManager.C_OxidasePrefab);
    }
}
