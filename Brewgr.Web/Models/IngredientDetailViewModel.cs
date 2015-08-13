﻿using System;
using System.Collections.Generic;
using Brewgr.Web.Core.Model;

namespace Brewgr.Web.Models
{
	public class IngredientDetailViewModel<TIngredientType> : PageableViewModel where TIngredientType : IIngredient
	{
		/// <summary>
		/// Gets or sets the Ingredient
		/// </summary>
		public TIngredientType Ingredient { get; set; }

		/// <summary>
		/// Gets or sets the Affiliate Product
		/// </summary>
		public AffiliateProduct AffiliateProduct { get; set; }

		/// <summary>
		/// Gets or sets the Recipes
		/// </summary>
		public IList<RecipeSummary> Recipes { get; set; }
	}
}