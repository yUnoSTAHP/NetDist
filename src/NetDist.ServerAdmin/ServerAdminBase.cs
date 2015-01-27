﻿using NetDist.Core;
using System;

namespace NetDist.ServerAdmin
{
    public abstract class ServerAdminBase
    {
        public abstract ServerInfo GetStatistics();
        public abstract PackageInfo GetPackages();
        public abstract void AddPackage(PackageInfo packageInfo, byte[] packageZip);
        public abstract AddJobHandlerResult AddJobHandler(string jobScript);
        public abstract void RemoveJobHandler(Guid handlerId);
        public abstract void StartJobHandler(Guid handlerId);
        public abstract void StopJobHandler(Guid handlerId);
        public abstract void PauseJobHandler(Guid handlerId);
        public abstract void EnableJobHandler(Guid handlerId);
        public abstract void DisableJobHandler(Guid handlerId);
    }
}
