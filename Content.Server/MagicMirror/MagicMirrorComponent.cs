using Content.Shared.Humanoid;
using Robust.Shared.Audio;

namespace Content.Server.MagicMirror;

/// <summary>
/// Allows humanoids to change their appearance mid-round.
/// </summary>
[RegisterComponent]
public sealed partial class MagicMirrorComponent : Component
{
    /// <summary>
    /// Magic mirror target, used for validating UI messages.
    /// </summary>
    [DataField]
    public EntityUid? Target;

    /// <summary>
    /// doafter time required to add a new slot
    /// </summary>
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public TimeSpan AddSlotTime = TimeSpan.FromSeconds(5);

    /// <summary>
    /// doafter time required to remove a existing slot
    /// </summary>
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public TimeSpan RemoveSlotTime = TimeSpan.FromSeconds(2);

    /// <summary>
    /// doafter time required to change slot
    /// </summary>
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public TimeSpan SelectSlotTime = TimeSpan.FromSeconds(3);

    /// <summary>
    /// doafter time required to recolor slot
    /// </summary>
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public TimeSpan ChangeSlotTime = TimeSpan.FromSeconds(1);

    /// <summary>
    /// Sound emitted when slots are changed
    /// </summary>
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public SoundSpecifier ChangeHairSound = new SoundPathSpecifier("/Audio/Items/scissors.ogg");
}
