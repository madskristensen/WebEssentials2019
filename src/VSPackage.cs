using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace WebEssentials
{
    [Guid("7222ad82-a34e-4c8e-ae3b-0a2714d5ffd8")]
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [InstalledProductRegistration(Vsix.Name, Vsix.Description, Vsix.Version)]
    public sealed class WebEssentialsPackage : AsyncPackage
    {
    }
}
