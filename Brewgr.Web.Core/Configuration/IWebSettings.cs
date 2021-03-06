using System;
using System.Collections.Generic;

namespace Brewgr.Web.Core.Configuration
{
	public interface IWebSettings
	{
        /// <summary>
        /// Get the runnning env
        /// </summary>
        string Environment { get; }

	    bool IsProduction();

		/// <summary>
		/// Gets the RootPathSecure
		/// </summary>
		string RootPathSecure { get; }

		/// <summary>
		/// Gets the secure static root path
		/// </summary>
		string StaticRootPathSecure { get; }

		/// <summary>
		/// Gets a value specifying whether or not https is disabled
		/// </summary>
		bool DisableHttps { get; }

		/// <summary>
		/// Gets the MediaPhysicalRoot
		/// </summary>
		string MediaPhysicalRoot { get; }

		/// <summary>
		/// Gets the MediaUrlRoot
		/// </summary>
		string MediaUrlRoot { get; }

		/// <summary>
		/// Gets the MediaUrlRoot Secure
		/// </summary>
		string MediaUrlRootSecure { get; }

        string ShopEmail { get; }

        /// <summary>
        /// Gets or sets the SenderName
        /// </summary>
        string SenderDisplayName { get; }

		/// <summary>
		/// Gets or sets the SenderAddress
		/// </summary>
		string SenderAddress { get; }

		/// <summary>
		/// Gets the contact form Email Address
		/// </summary>
		IList<string> ContactFormEmailAddress { get; }

		/// <summary>
		/// Gets the default number of Recipes per page
		/// </summary>
		int DefaultRecipesPerPage { get; }

		/// <summary>
		/// Gets the default image root
		/// </summary>
		string DefaultRecipeImageRoot { get; }

        string FB_ApplicationSecret { get; }
        string FB_ApplicationKey { get; }


    }
}