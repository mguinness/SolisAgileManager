namespace SolisManager.Shared.Models;

public static class ModelExtensions
{
    public static string Description(this SlotAction action) => action switch
    {
        SlotAction.Charge => "Charge",
        SlotAction.Discharge => "Discharge",
        SlotAction.DoNothing => "No Action",
        SlotAction.ChargeIfLowBattery => "Boost",
        SlotAction.Hold => "Hold",
        _ => string.Empty
    };

    public static string GetActionColour(this SlotAction action) =>
        action switch
        {
            SlotAction.Charge => "royalblue",
            SlotAction.Discharge => "forestgreen",
            SlotAction.ChargeIfLowBattery => "darkorange",
            SlotAction.Hold => "orangered",
            _ => "rgba(200,200,200, 0.8)"
        };
    
    public static string GetActionLegendTooltip(this SlotAction action, SolisManagerConfig? config) =>
        action switch
        {
            SlotAction.Charge => "Battery will be charged",
            SlotAction.Discharge => "Battery will be discharged",
            SlotAction.ChargeIfLowBattery => $"Battery will be charged if the SOC is below the {config?.LowBatteryPercentage}% threshold",
            SlotAction.Hold => "Battery charge will be held",
            _ => "No action will be taken on the inverter"
        };


}