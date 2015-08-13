﻿using System;
using System.Linq;
using AutoMapper;
using Brewgr.Web.Core.Model;
using Brewgr.Web.Models;
using ctorx.Core.Mapping;

namespace Brewgr.Web.Mappers
{
	public class UserMapper : IMappingDefinition
	{
		public void DefineMappings()
		{
			Mapper.CreateMap<User, UserSettingsViewModel>()
				.ForMember(x => x.RecipeCommentNotifications, y => y.MapFrom(z => z.UserNotificationTypes.Any(zz => zz.NotificationTypeId == (int)NotificationType.RecipeComment)))
				.ForMember(x => x.BrewSessionCommentNotifications, y => y.MapFrom(z => z.UserNotificationTypes.Any(zz => zz.NotificationTypeId == (int)NotificationType.BrewSessionComment)))
				.ForMember(x => x.BrewerFollowNotifications, y => y.MapFrom(z => z.UserNotificationTypes.Any(zz => zz.NotificationTypeId == (int)NotificationType.BrewerFollowed)))
				.ForMember(x => x.SiteFeatureNotifications, y => y.MapFrom(z => z.UserNotificationTypes.Any(zz => zz.NotificationTypeId == (int)NotificationType.SiteFeatures)))
				.ForMember(x => x.SiteOutageNotifications, y => y.MapFrom(z => z.UserNotificationTypes.Any(zz => zz.NotificationTypeId == (int)NotificationType.SiteOutages)));

			Mapper.CreateMap<UserSettingsViewModel, User>()
			      .ForMember(x => x.DateCreated, y => y.Ignore())
			      .ForMember(x => x.UserId, y => y.Ignore())
			      .ForMember(x => x.HasCustomUsername, y => y.Ignore());

			Mapper.CreateMap<User, UserSummary>()
				.ForMember(x => x.Username, y => y.MapFrom(z => z.CalculatedUsername))
				.ForMember(x => x.IsAdmin, y => y.MapFrom(z => z.UserAdmin != null && z.UserAdmin.IsActive))
				.ForMember(x => x.IsPartner, y => y.MapFrom(z => z.UserPartnerAdmins != null ? z.UserPartnerAdmins.Any(zz => zz.IsActive) : false));
		}
	}
}