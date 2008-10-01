using System;
using OpenMetaverse;

namespace Simian
{
    public interface IInventoryProvider
    {
        UUID CreateItem(Agent agent, string name, string description, InventoryType invType, AssetType type,
            UUID assetID, UUID parentID, PermissionMask ownerMask, PermissionMask nextOwnerMask, UUID ownerID,
            UUID creatorID, UUID transactionID, uint callbackID);
        bool CreateFolder(Agent agent, UUID folderID, string name, AssetType preferredType, UUID parentID,
            UUID ownerID);
        bool CreateRootFolder(Agent agent, UUID folderID, string name, UUID ownerID);
    }
}
