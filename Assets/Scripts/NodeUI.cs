using UnityEngine.UI;
using JetBrains.Annotations;
using UnityEngine;

public class NodeUI : MonoBehaviour
{
   public GameObject Ui;
   private Node target;
   public Text upgradeCost;
   public Button upgradeButton;
   
   public void SetTarget(Node _target)
   {
      target = _target;
      transform.position = target.GetBuildPosition();
   
      if (!target.isUpgraded)
      {
         upgradeCost.text = "K" + target.turretBlueprint.upgradeCost;

         upgradeButton.interactable = true;
      }
      else
      {
         upgradeCost.text = "UPGRADED";
         upgradeButton.interactable = false;

      }
      
      
      Ui.SetActive(true);
   }

   public void Hide()
   {
      Ui.SetActive(false);
   }

   public void Upgrade()
   {
      target.UpgradeTurret();
      BuildManager.instance.DeselectNode();
   }
   
   
}
