using HarmonyLib;
using TaleWorlds.CampaignSystem.SandBox.GameComponents;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace ProfitableWorkshops
    {
    public class ProfitableWorkshopsSubModule : MBSubModuleBase
        {
        protected override void OnSubModuleLoad()
            {
            base.OnSubModuleLoad();
            new Harmony("hsngrms.profitable.workshops.mod").PatchAll();
            }
        protected override void OnBeforeInitialModuleScreenSetAsRoot()
            {
            base.OnBeforeInitialModuleScreenSetAsRoot();
            InformationManager.DisplayMessage(new InformationMessage("Profitable Workshops mod enabled"));
            }
        }

    [HarmonyPatch(typeof(DefaultWorkshopModel), "GetBuyingCostForPlayer")]
    internal class WorkshopCostModification
        {
        public static void Postfix(ref int __result)
            {
            try
                {
                __result = 1;
                }
            catch (System.Exception)
                {
                InformationManager.DisplayMessage(new InformationMessage(" Oops... Something went terribly wrong because of WorkshopCostModification ! "));
                }
            }
        }

    [HarmonyPatch(typeof(DefaultWorkshopModel), "GetDailyExpense")]
    internal class WorkshopDailyExpenseModification
        {
        public static void Postfix(ref int __result)
            {
            try
                {
                __result = 1;
                }
            catch (System.Exception)
                {
                InformationManager.DisplayMessage(new InformationMessage(" Oops... Something went terribly wrong because of WorkshopDailyExpenseModification ! "));
                }
            }
        }

    [HarmonyPatch(typeof(DefaultWorkshopModel), "GetConvertProductionCost")]
    internal class WorkshopConvertProductionCostModification
        {
        public static void Postfix(ref int __result)
            {
            try
                {
                __result = 1;
                }
            catch (System.Exception)
                {
                InformationManager.DisplayMessage(new InformationMessage(" Oops... Something went terribly wrong because of WorkshopConvertProductionCostModification ! "));
                }
            }
        }

    [HarmonyPatch(typeof(DefaultWorkshopModel), "GetSellingCost")]
    internal class WorkshopSellPriceModification
        {
        public static void Postfix(ref int __result)
            {
            try
                {
                __result = 1;
                }
            catch (System.Exception)
                {
                InformationManager.DisplayMessage(new InformationMessage(" Oops... Something went terribly wrong because of WorkshopSellPriceModification ! "));
                }
            }
        }

    [HarmonyPatch(typeof(DefaultWorkshopModel), "GetMaxWorkshopCountForPlayer")]
    internal class WorkshopCountModification
        {
        public static void Postfix(ref int __result)
            {
            try
                {
                __result = 9999;
                }
            catch (System.Exception)
                {
                InformationManager.DisplayMessage(new InformationMessage(" Oops... Something went terribly wrong because of WorkshopCountModification ! "));
                }
            }
        }

    }