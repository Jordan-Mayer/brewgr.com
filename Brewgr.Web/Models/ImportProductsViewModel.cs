﻿using System;
using System.Linq;
using System.Web;

namespace Brewgr.Web.Models
{
	public class ImportProductsViewModel
	{
		/// <summary>
		/// Gets or sets the ProductFeedFile
		/// </summary>
		public HttpPostedFileBase ProductFeedFile { get; set; }
	}
}