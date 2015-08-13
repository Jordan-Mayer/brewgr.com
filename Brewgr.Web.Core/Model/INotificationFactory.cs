﻿using System;

namespace Brewgr.Web.Core.Model
{
	public interface INotificationFactory
	{
		/// <summary>
		/// Makes a Notification
		/// </summary>
		INotification Make(NotificationType notificationType);
	}
}