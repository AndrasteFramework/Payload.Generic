using Andraste.Payload.VFS;
using EasyHook;

namespace Andraste.Payload.Generic
{
    public class GenericEntryPoint : EntryPoint
    {
        public GenericEntryPoint(RemoteHooking.IContext context) : base(context)
        {
        }

        public override string FrameworkName => "Andraste Generic";
        public override string Version => "0.1.1";
        protected override void PreWakeup()
        {
            Container.RegisterManager(new BasicFileRedirectingManager());
        }

        protected override void PostWakeup()
        {
        }

        protected override void ApplicationReady()
        {
        }
    }
}