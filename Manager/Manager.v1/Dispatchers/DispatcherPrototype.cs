using Manager.v1.dispatchers;
using Manager.v1.Dispatchers;
using Manager.v1.Manager;
using Manager.v1.Store;
using System.Collections.Generic;

namespace designPatterns.exercises.n3_manager.v1.dispatchers
{
    public class DispatcherPrototype
	{

		private IDictionary<FrameType, Dispatcher> dispatcherMap;

		public DispatcherPrototype(IStore store, Server server)
		{
			dispatcherMap = new Dictionary<FrameType, Dispatcher>
			{
				[FrameType.ADD] = new AddDispatcher(store, server),
				[FrameType.REMOVE] = new RemoveDispatcher(store, server),
				[FrameType.EXIST] = new ExistDispatcher(store, server),
				[FrameType.LIST] = new ListDispatcher(store, server)
			};
		}

		public virtual void dispatch(FrameType frameType)
		{
			dispatcherMap[frameType].Clone().Dispatch();
		}

	}

}