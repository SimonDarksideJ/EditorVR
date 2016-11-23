﻿using System;
using System.Collections.Generic;
using UnityEngine.VR.Tools;

namespace UnityEngine.VR.Menus
{
	/// <summary>
	/// The main menu that can be shown on device proxies
	/// </summary>
	public interface IMainMenu : IUsesMenuActions, ISelectTool
	{
		/// <summary>
		/// The menu tools that will populate the menu
		/// </summary>
		List<Type> menuTools { set; }

		/// <summary>
		/// The workspaces that are selectable from the menu
		/// </summary>
		List<Type> menuWorkspaces { set; }

		/// <summary>
		/// Controls whether the menu is visible or not
		/// </summary>
		bool visible { get; set; }

		/// <summary>
		/// You must implement and call this event when the visibility of the menu changes
		/// IMainMenu: main menu instance
		/// </summary>
		event Action<IMainMenu> menuVisibilityChanged;
	}
}