using Quintessential;

namespace HalvingMetallurgyCampaign;

public class HMC : QuintessentialMod, IDataMod {
    public static HMC Instance
    {
        get;
    }
    public override string ModId => "halving_metallurgy_campaign";

    public override void Load() {
        Instance.Log.Info("Good morning, Saverio.");
    }

    public override void LoadContent() {
        if (!PuzzleSelectScreen.HasDRM())
        {
            Instance.Log.Warn("[HMC] Unbought DLC: De Re Metallica.");
        }

    }
    public override void LoadCompatContent() { }
    public override void FinaliseContent() { }

    public override void PostLoad() { }
	public override void Unload() { }
}
