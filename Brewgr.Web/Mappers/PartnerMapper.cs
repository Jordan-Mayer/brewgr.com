﻿using AutoMapper;
using Brewgr.Web.Core.Model;
using Brewgr.Web.Models;
using ctorx.Core.Mapping;

namespace Brewgr.Web.Mappers
{
	public class PartnerMapper : IMappingDefinition
	{
		/// <summary>
		/// Defines Mappings
		/// </summary>
		public void DefineMappings()
		{
			Mapper.CreateMap<Partner, PartnerSettingsViewModel>();
			Mapper.CreateMap<PartnerSettingsViewModel, Partner>();
			Mapper.CreateMap<PartnerSendToShopSettings, PartnerSendToShopSettings>();

			Mapper.CreateMap<SendToShopOrder, SendToShopOrderViewModel>()
				.ForMember(x => x.Partner, y => y.Ignore())
				.ForMember(x => x.PartnerIngredients, y => y.Ignore())
				.ForMember(x => x.PartnerSettings, y => y.Ignore())
				.ForMember(x => x.Recipe, y => y.Ignore());

			Mapper.CreateMap<SendToShopOrderViewModel, SendToShopOrder>();
		}
	}
}