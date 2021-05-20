using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooltipSystem : MonoBehaviour
{
    private static TooltipSystem current;
    public Tooltip tooltip;
    public GameObject pauseMenuUI;
    public static bool tooltipActive;

    public void Awake()
    {
        current = this;
        tooltipActive = true;
    }

    public static void Show(string content, string header = "")
    {
        if (tooltipActive == true)
        {
            current.tooltip.SetText(content, header);
            current.tooltip.gameObject.SetActive(true);
        }
    }

    public static void Hide()
    {
        current.tooltip.gameObject.SetActive(false);
    }
}
