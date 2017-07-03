//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.7.99
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "ec030b16eb387dda")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.4")]

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Home</summary>
	[PublishedContentModel("home")]
	public partial class Home : PublishedContentModel, IContactInfo
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "home";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Home(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Address line 1: Please provide the first line of your address
		///</summary>
		[ImplementPropertyType("addressLine1")]
		public string AddressLine1
		{
			get { return Umbraco.Web.PublishedContentModels.ContactInfo.GetAddressLine1(this); }
		}

		///<summary>
		/// Address line 2: Please provide your second line of your address
		///</summary>
		[ImplementPropertyType("addressLine2")]
		public string AddressLine2
		{
			get { return Umbraco.Web.PublishedContentModels.ContactInfo.GetAddressLine2(this); }
		}

		///<summary>
		/// Closing Time: Please provide the day when you are not open
		///</summary>
		[ImplementPropertyType("closingTime")]
		public string ClosingTime
		{
			get { return Umbraco.Web.PublishedContentModels.ContactInfo.GetClosingTime(this); }
		}

		///<summary>
		/// Opening Times: Please provide your opening times
		///</summary>
		[ImplementPropertyType("openingTimes")]
		public string OpeningTimes
		{
			get { return Umbraco.Web.PublishedContentModels.ContactInfo.GetOpeningTimes(this); }
		}

		///<summary>
		/// Phone number: Please provide your phone number
		///</summary>
		[ImplementPropertyType("phoneNumber")]
		public string PhoneNumber
		{
			get { return Umbraco.Web.PublishedContentModels.ContactInfo.GetPhoneNumber(this); }
		}

		///<summary>
		/// Postcode: Please provide your Postcode
		///</summary>
		[ImplementPropertyType("postcode")]
		public string Postcode
		{
			get { return Umbraco.Web.PublishedContentModels.ContactInfo.GetPostcode(this); }
		}

		///<summary>
		/// Text for phone number: Please add some text to you phone number
		///</summary>
		[ImplementPropertyType("textForPhoneNumber")]
		public string TextForPhoneNumber
		{
			get { return Umbraco.Web.PublishedContentModels.ContactInfo.GetTextForPhoneNumber(this); }
		}
	}

	/// <summary>About us</summary>
	[PublishedContentModel("aboutUs")]
	public partial class AboutUs : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "aboutUs";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public AboutUs(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<AboutUs, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Contact us</summary>
	[PublishedContentModel("contactUs")]
	public partial class ContactUs : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "contactUs";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ContactUs(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ContactUs, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Service</summary>
	[PublishedContentModel("service")]
	public partial class Service : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "service";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Service(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Service, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	// Mixin content Type 1103 with alias "contactInfo"
	/// <summary>Contact info</summary>
	public partial interface IContactInfo : IPublishedContent
	{
		/// <summary>Address line 1</summary>
		string AddressLine1 { get; }

		/// <summary>Address line 2</summary>
		string AddressLine2 { get; }

		/// <summary>Closing Time</summary>
		string ClosingTime { get; }

		/// <summary>Opening Times</summary>
		string OpeningTimes { get; }

		/// <summary>Phone number</summary>
		string PhoneNumber { get; }

		/// <summary>Postcode</summary>
		string Postcode { get; }

		/// <summary>Text for phone number</summary>
		string TextForPhoneNumber { get; }
	}

	/// <summary>Contact info</summary>
	[PublishedContentModel("contactInfo")]
	public partial class ContactInfo : PublishedContentModel, IContactInfo
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "contactInfo";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ContactInfo(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ContactInfo, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Address line 1: Please provide the first line of your address
		///</summary>
		[ImplementPropertyType("addressLine1")]
		public string AddressLine1
		{
			get { return GetAddressLine1(this); }
		}

		/// <summary>Static getter for Address line 1</summary>
		public static string GetAddressLine1(IContactInfo that) { return that.GetPropertyValue<string>("addressLine1"); }

		///<summary>
		/// Address line 2: Please provide your second line of your address
		///</summary>
		[ImplementPropertyType("addressLine2")]
		public string AddressLine2
		{
			get { return GetAddressLine2(this); }
		}

		/// <summary>Static getter for Address line 2</summary>
		public static string GetAddressLine2(IContactInfo that) { return that.GetPropertyValue<string>("addressLine2"); }

		///<summary>
		/// Closing Time: Please provide the day when you are not open
		///</summary>
		[ImplementPropertyType("closingTime")]
		public string ClosingTime
		{
			get { return GetClosingTime(this); }
		}

		/// <summary>Static getter for Closing Time</summary>
		public static string GetClosingTime(IContactInfo that) { return that.GetPropertyValue<string>("closingTime"); }

		///<summary>
		/// Opening Times: Please provide your opening times
		///</summary>
		[ImplementPropertyType("openingTimes")]
		public string OpeningTimes
		{
			get { return GetOpeningTimes(this); }
		}

		/// <summary>Static getter for Opening Times</summary>
		public static string GetOpeningTimes(IContactInfo that) { return that.GetPropertyValue<string>("openingTimes"); }

		///<summary>
		/// Phone number: Please provide your phone number
		///</summary>
		[ImplementPropertyType("phoneNumber")]
		public string PhoneNumber
		{
			get { return GetPhoneNumber(this); }
		}

		/// <summary>Static getter for Phone number</summary>
		public static string GetPhoneNumber(IContactInfo that) { return that.GetPropertyValue<string>("phoneNumber"); }

		///<summary>
		/// Postcode: Please provide your Postcode
		///</summary>
		[ImplementPropertyType("postcode")]
		public string Postcode
		{
			get { return GetPostcode(this); }
		}

		/// <summary>Static getter for Postcode</summary>
		public static string GetPostcode(IContactInfo that) { return that.GetPropertyValue<string>("postcode"); }

		///<summary>
		/// Text for phone number: Please add some text to you phone number
		///</summary>
		[ImplementPropertyType("textForPhoneNumber")]
		public string TextForPhoneNumber
		{
			get { return GetTextForPhoneNumber(this); }
		}

		/// <summary>Static getter for Text for phone number</summary>
		public static string GetTextForPhoneNumber(IContactInfo that) { return that.GetPropertyValue<string>("textForPhoneNumber"); }
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public string UmbracoFile
		{
			get { return this.GetPropertyValue<string>("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}
