﻿#if UNITY_EDITOR && UNITY_EDITORVR
using UnityEditor.Experimental.EditorVR.Modules;

namespace UnityEditor.Experimental.EditorVR.Core
{
	partial class EditorVR
	{
		class WorkspaceModuleConnector : Nested, ILateBindInterfaceMethods<WorkspaceModule>, IInterfaceConnector
		{
			public void LateBindInterfaceMethods(WorkspaceModule provider)
			{
				ICreateWorkspaceMethods.createWorkspace = provider.CreateWorkspace;
				IResetWorkspacesMethods.resetWorkspaceRotations = provider.ResetWorkspaceRotations;
			}

			public void ConnectInterface(object @object, object userData = null)
			{
				var workspaceModule = evr.GetModule<WorkspaceModule>();

				var allWorkspaces = @object as IAllWorkspaces;
				if (allWorkspaces != null)
					allWorkspaces.allWorkspaces = workspaceModule.workspaces;
			}

			public void DisconnectInterface(object @object, object userData = null)
			{
			}
		}
	}
}
#endif
