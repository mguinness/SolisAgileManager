using SolisManager.Shared.Models;

namespace SolisManager.Shared;

public interface IInverterService
{
    public SolisManagerState InverterState { get; }
    public Task RefreshInverterState();
    public Task<List<HistoryEntry>> GetHistory();
    public Task<SolisManagerConfig> GetConfig();
    public Task SaveConfig(SolisManagerConfig config);

    public Task CancelSlotAction(OctopusPriceSlot slot);
    public Task TestCharge();
    public Task ChargeBattery();
    public Task DischargeBattery();
    public Task DumpAndChargeBattery();
    public Task ClearOverrides();
    public Task AdvanceSimulation();
    public Task ResetSimulation();
    public Task<NewVersionResponse?> GetVersionInfo();
}

public interface IInverterRefreshService
{
    public Task RefreshBatteryState();
    public Task RefreshSolcastData();
    public Task RefreshAgileRates();
}