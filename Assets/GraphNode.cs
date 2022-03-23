using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI.BoundsControl;
using Microsoft.MixedReality.Toolkit.UI;

public class GraphNode : MonoBehaviour
{
    [SerializeField] GameObject interactionMenu;

    // BoundsControl bControl;
    // Start is called before the first frame update
    void Start()
    {
        // BoundsControl bControl = gameObject.GetComponentInChildren<BoundsControl>();
        // bControl.enabled = false;

        // GameObject intMenu = Instantiate(interactionMenu, new Vector3(0, 0.6f, -0.05f), Quaternion.identity);
    
        // MonoBehaviour cpo = gameObject.GetComponent<MonoBehaviour>();
        // intMenu.GetComponent<AppBar>().Target = cpo;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HandleAppBarVisibility(bool selected)
    {
        BoundsControl bControl = gameObject.GetComponentInChildren<BoundsControl>();
        
        if (selected)
        {
            interactionMenu.SetActive(true);
            
            bControl.enabled = true;

        } else {
            interactionMenu.SetActive(false);
        }
    }
}
