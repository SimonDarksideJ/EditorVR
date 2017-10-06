﻿#if UNITY_EDITOR && UNITY_EDITORVR
using UnityEditor.Experimental.EditorVR.Modules;

namespace UnityEditor.Experimental.EditorVR.Core
{
	partial class EditorVR
	{
		class HighlightModuleConnector : Nested, IInterfaceConnector, ILateBindInterfaceMethods<HighlightModule>
		{
			public void LateBindInterfaceMethods(HighlightModule provider)
			{
				ISetHighlightMethods.setHighlight = provider.SetHighlight;
			}

			public void ConnectInterface(object @object, object userData = null)
			{
				var customHighlight = @object as ICustomHighlight;
				if (customHighlight != null)
					evr.GetModule<HighlightModule>().customHighlight += customHighlight.OnHighlight;
			}

			public void DisconnectInterface(object @object, object userData = null)
			{
				var customHighlight = @object as ICustomHighlight;
				if (customHighlight != null)
					evr.GetModule<HighlightModule>().customHighlight -= customHighlight.OnHighlight;
			}
		}
	}
}
#endif
