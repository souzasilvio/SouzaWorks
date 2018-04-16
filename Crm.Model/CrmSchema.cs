using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

[assembly: Microsoft.Xrm.Sdk.Client.ProxyTypesAssemblyAttribute()]
namespace Crm.Model2
{

	[System.Runtime.Serialization.DataContractAttribute()]
	public enum AccountState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Ativa = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inativa = 1,
	}

	/// <summary>
	/// Um negócio que representa um cliente ou cliente potencial. A empresa que é cobrada em transações comerciais.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("account")]
	public partial class Account : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public Account() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "account";
		
		public const int EntityTypeCode = 1;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.AccountId = value;
			}
		}
		/// <summary>
		/// Escolha uma categoria para indicar se a conta de cliente é padrão ou preferencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountcategorycode")]
		public Microsoft.Xrm.Sdk.OptionSetValue AccountCategoryCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("accountcategorycode");
			}
			set
			{
				this.OnPropertyChanging("AccountCategoryCode");
				this.SetAttributeValue("accountcategorycode", value);
				this.OnPropertyChanged("AccountCategoryCode");
			}
		}
	
		public virtual Enums.AccountCategoryCode? AccountCategoryCodeEnum
		{
			get
			{
				return ((Enums.AccountCategoryCode?)(EntityOptionSetEnum.GetEnum(this, "accountcategorycode")));
			}
			set
			{
				AccountCategoryCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Lista suspensa para classificar uma conta.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountclassificationcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue AccountClassificationCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("accountclassificationcode");
			}
			set
			{
				this.OnPropertyChanging("AccountClassificationCode");
				this.SetAttributeValue("accountclassificationcode", value);
				this.OnPropertyChanged("AccountClassificationCode");
			}
		}
	
		public virtual Enums.AccountClassificationCode? AccountClassificationCodeEnum
		{
			get
			{
				return ((Enums.AccountClassificationCode?)(EntityOptionSetEnum.GetEnum(this, "accountclassificationcode")));
			}
			set
			{
				AccountClassificationCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Identificador exclusivo da conta.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountid")]
		public System.Nullable<System.Guid> AccountId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("accountid");
			}
			set
			{
				this.OnPropertyChanging("AccountId");
				this.SetAttributeValue("accountid", value);
						if (value.HasValue)
						{
							base.Id = value.Value;
						}
						else
						{
							base.Id = System.Guid.Empty;
						}
				this.OnPropertyChanged("AccountId");
			}
		}
	


		/// <summary>
		/// Digite um número de ID ou código para a conta para pesquisar e identificar rapidamente a conta em exibições do sistema.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountnumber")]
		public string AccountNumber
		{
			get
			{
				return this.GetAttributeValue<string>("accountnumber");
			}
			set
			{
				this.OnPropertyChanging("AccountNumber");
				this.SetAttributeValue("accountnumber", value);
				this.OnPropertyChanged("AccountNumber");
			}
		}
	


		/// <summary>
		/// Lista suspensa para selecionar classificações de conta.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountratingcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue AccountRatingCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("accountratingcode");
			}
			set
			{
				this.OnPropertyChanging("AccountRatingCode");
				this.SetAttributeValue("accountratingcode", value);
				this.OnPropertyChanged("AccountRatingCode");
			}
		}
	
		public virtual Enums.AccountRatingCode? AccountRatingCodeEnum
		{
			get
			{
				return ((Enums.AccountRatingCode?)(EntityOptionSetEnum.GetEnum(this, "accountratingcode")));
			}
			set
			{
				AccountRatingCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Identificador exclusivo do endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addressid")]
		public System.Nullable<System.Guid> Address1_AddressId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("address1_addressid");
			}
			set
			{
				this.OnPropertyChanging("Address1_AddressId");
				this.SetAttributeValue("address1_addressid", value);
				this.OnPropertyChanged("Address1_AddressId");
			}
		}
	


		/// <summary>
		/// Escolha o tipo do endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addresstypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address1_AddressTypeCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_addresstypecode");
			}
			set
			{
				this.OnPropertyChanging("Address1_AddressTypeCode");
				this.SetAttributeValue("address1_addresstypecode", value);
				this.OnPropertyChanged("Address1_AddressTypeCode");
			}
		}
	
		public virtual Enums.Address1_AddressTypeCode? Address1_AddressTypeCodeEnum
		{
			get
			{
				return ((Enums.Address1_AddressTypeCode?)(EntityOptionSetEnum.GetEnum(this, "address1_addresstypecode")));
			}
			set
			{
				Address1_AddressTypeCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Digite a cidade do endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_city")]
		public string Address1_City
		{
			get
			{
				return this.GetAttributeValue<string>("address1_city");
			}
			set
			{
				this.OnPropertyChanging("Address1_City");
				this.SetAttributeValue("address1_city", value);
				this.OnPropertyChanged("Address1_City");
			}
		}
	


		/// <summary>
		/// Mostra o endereço principal completo.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_composite")]
		public string Address1_Composite
		{
			get
			{
				return this.GetAttributeValue<string>("address1_composite");
			}
		}
	


		/// <summary>
		/// Digite o país ou região do endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_country")]
		public string Address1_Country
		{
			get
			{
				return this.GetAttributeValue<string>("address1_country");
			}
			set
			{
				this.OnPropertyChanging("Address1_Country");
				this.SetAttributeValue("address1_country", value);
				this.OnPropertyChanged("Address1_Country");
			}
		}
	


		/// <summary>
		/// Digite o município do endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_county")]
		public string Address1_County
		{
			get
			{
				return this.GetAttributeValue<string>("address1_county");
			}
			set
			{
				this.OnPropertyChanging("Address1_County");
				this.SetAttributeValue("address1_county", value);
				this.OnPropertyChanged("Address1_County");
			}
		}
	


		/// <summary>
		/// Digite o número do fax associado ao endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_fax")]
		public string Address1_Fax
		{
			get
			{
				return this.GetAttributeValue<string>("address1_fax");
			}
			set
			{
				this.OnPropertyChanging("Address1_Fax");
				this.SetAttributeValue("address1_fax", value);
				this.OnPropertyChanged("Address1_Fax");
			}
		}
	


		/// <summary>
		/// Escolha as condições de frete do endereço principal para garantir que as ordens de remessa sejam processadas corretamente.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_freighttermscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address1_FreightTermsCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_freighttermscode");
			}
			set
			{
				this.OnPropertyChanging("Address1_FreightTermsCode");
				this.SetAttributeValue("address1_freighttermscode", value);
				this.OnPropertyChanged("Address1_FreightTermsCode");
			}
		}
	
		public virtual Enums.Address1_FreightTermsCode? Address1_FreightTermsCodeEnum
		{
			get
			{
				return ((Enums.Address1_FreightTermsCode?)(EntityOptionSetEnum.GetEnum(this, "address1_freighttermscode")));
			}
			set
			{
				Address1_FreightTermsCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Digite o valor da latitude do endereço principal para uso no mapeamento e em outros aplicativos.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_latitude")]
		public System.Nullable<double> Address1_Latitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address1_latitude");
			}
			set
			{
				this.OnPropertyChanging("Address1_Latitude");
				this.SetAttributeValue("address1_latitude", value);
				this.OnPropertyChanged("Address1_Latitude");
			}
		}
	


		/// <summary>
		/// Primeira linha para inserir informações de endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line1")]
		public string Address1_Line1
		{
			get
			{
				return this.GetAttributeValue<string>("address1_line1");
			}
			set
			{
				this.OnPropertyChanging("Address1_Line1");
				this.SetAttributeValue("address1_line1", value);
				this.OnPropertyChanged("Address1_Line1");
			}
		}
	


		/// <summary>
		/// Digite a segunda linha do endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line2")]
		public string Address1_Line2
		{
			get
			{
				return this.GetAttributeValue<string>("address1_line2");
			}
			set
			{
				this.OnPropertyChanging("Address1_Line2");
				this.SetAttributeValue("address1_line2", value);
				this.OnPropertyChanged("Address1_Line2");
			}
		}
	


		/// <summary>
		/// Terceira linha para inserir informações de endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line3")]
		public string Address1_Line3
		{
			get
			{
				return this.GetAttributeValue<string>("address1_line3");
			}
			set
			{
				this.OnPropertyChanging("Address1_Line3");
				this.SetAttributeValue("address1_line3", value);
				this.OnPropertyChanged("Address1_Line3");
			}
		}
	


		/// <summary>
		/// Digite o valor da longitude do endereço principal para uso no mapeamento e em outros aplicativos.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_longitude")]
		public System.Nullable<double> Address1_Longitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address1_longitude");
			}
			set
			{
				this.OnPropertyChanging("Address1_Longitude");
				this.SetAttributeValue("address1_longitude", value);
				this.OnPropertyChanged("Address1_Longitude");
			}
		}
	


		/// <summary>
		/// Digite um nome descritivo para o endereço principal, como Matriz Corporativa.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_name")]
		public string Address1_Name
		{
			get
			{
				return this.GetAttributeValue<string>("address1_name");
			}
			set
			{
				this.OnPropertyChanging("Address1_Name");
				this.SetAttributeValue("address1_name", value);
				this.OnPropertyChanged("Address1_Name");
			}
		}
	


		/// <summary>
		/// CEP do endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postalcode")]
		public string Address1_PostalCode
		{
			get
			{
				return this.GetAttributeValue<string>("address1_postalcode");
			}
			set
			{
				this.OnPropertyChanging("Address1_PostalCode");
				this.SetAttributeValue("address1_postalcode", value);
				this.OnPropertyChanged("Address1_PostalCode");
			}
		}
	


		/// <summary>
		/// Digite o número da caixa postal do endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postofficebox")]
		public string Address1_PostOfficeBox
		{
			get
			{
				return this.GetAttributeValue<string>("address1_postofficebox");
			}
			set
			{
				this.OnPropertyChanging("Address1_PostOfficeBox");
				this.SetAttributeValue("address1_postofficebox", value);
				this.OnPropertyChanged("Address1_PostOfficeBox");
			}
		}
	


		/// <summary>
		/// Digite o nome do contato principal no endereço principal da conta.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_primarycontactname")]
		public string Address1_PrimaryContactName
		{
			get
			{
				return this.GetAttributeValue<string>("address1_primarycontactname");
			}
			set
			{
				this.OnPropertyChanging("Address1_PrimaryContactName");
				this.SetAttributeValue("address1_primarycontactname", value);
				this.OnPropertyChanged("Address1_PrimaryContactName");
			}
		}
	


		/// <summary>
		/// Escolha uma forma de transporte para entregas enviadas para este endereço.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_shippingmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address1_ShippingMethodCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_shippingmethodcode");
			}
			set
			{
				this.OnPropertyChanging("Address1_ShippingMethodCode");
				this.SetAttributeValue("address1_shippingmethodcode", value);
				this.OnPropertyChanged("Address1_ShippingMethodCode");
			}
		}
	
		public virtual Enums.Address1_ShippingMethodCode? Address1_ShippingMethodCodeEnum
		{
			get
			{
				return ((Enums.Address1_ShippingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "address1_shippingmethodcode")));
			}
			set
			{
				Address1_ShippingMethodCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Digite o estado ou província do endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_stateorprovince")]
		public string Address1_StateOrProvince
		{
			get
			{
				return this.GetAttributeValue<string>("address1_stateorprovince");
			}
			set
			{
				this.OnPropertyChanging("Address1_StateOrProvince");
				this.SetAttributeValue("address1_stateorprovince", value);
				this.OnPropertyChanged("Address1_StateOrProvince");
			}
		}
	


		/// <summary>
		/// Digite o número do telefone principal associado ao endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone1")]
		public string Address1_Telephone1
		{
			get
			{
				return this.GetAttributeValue<string>("address1_telephone1");
			}
			set
			{
				this.OnPropertyChanging("Address1_Telephone1");
				this.SetAttributeValue("address1_telephone1", value);
				this.OnPropertyChanged("Address1_Telephone1");
			}
		}
	


		/// <summary>
		/// Digite um segundo número de telefone associado ao endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone2")]
		public string Address1_Telephone2
		{
			get
			{
				return this.GetAttributeValue<string>("address1_telephone2");
			}
			set
			{
				this.OnPropertyChanging("Address1_Telephone2");
				this.SetAttributeValue("address1_telephone2", value);
				this.OnPropertyChanged("Address1_Telephone2");
			}
		}
	


		/// <summary>
		/// Digite um terceiro número de telefone associado ao endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone3")]
		public string Address1_Telephone3
		{
			get
			{
				return this.GetAttributeValue<string>("address1_telephone3");
			}
			set
			{
				this.OnPropertyChanging("Address1_Telephone3");
				this.SetAttributeValue("address1_telephone3", value);
				this.OnPropertyChanged("Address1_Telephone3");
			}
		}
	


		/// <summary>
		/// Digite a zona UPS do endereço principal para garantir que os encargos de remessa sejam calculados corretamente e as entregas sejam feitas imediatamente, quando enviado por UPS.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_upszone")]
		public string Address1_UPSZone
		{
			get
			{
				return this.GetAttributeValue<string>("address1_upszone");
			}
			set
			{
				this.OnPropertyChanging("Address1_UPSZone");
				this.SetAttributeValue("address1_upszone", value);
				this.OnPropertyChanged("Address1_UPSZone");
			}
		}
	


		/// <summary>
		/// Escolha o fuso horário ou a compensação UTC deste endereço para que outras pessoas possam fazer referência a ele ao contatar alguém nesse endereço.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_utcoffset")]
		public System.Nullable<int> Address1_UTCOffset
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("address1_utcoffset");
			}
			set
			{
				this.OnPropertyChanging("Address1_UTCOffset");
				this.SetAttributeValue("address1_utcoffset", value);
				this.OnPropertyChanged("Address1_UTCOffset");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo do endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addressid")]
		public System.Nullable<System.Guid> Address2_AddressId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("address2_addressid");
			}
			set
			{
				this.OnPropertyChanging("Address2_AddressId");
				this.SetAttributeValue("address2_addressid", value);
				this.OnPropertyChanged("Address2_AddressId");
			}
		}
	


		/// <summary>
		/// Escolha o tipo do endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addresstypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address2_AddressTypeCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_addresstypecode");
			}
			set
			{
				this.OnPropertyChanging("Address2_AddressTypeCode");
				this.SetAttributeValue("address2_addresstypecode", value);
				this.OnPropertyChanged("Address2_AddressTypeCode");
			}
		}
	
		public virtual Enums.Address2_AddressTypeCode? Address2_AddressTypeCodeEnum
		{
			get
			{
				return ((Enums.Address2_AddressTypeCode?)(EntityOptionSetEnum.GetEnum(this, "address2_addresstypecode")));
			}
			set
			{
				Address2_AddressTypeCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Digite a cidade do endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_city")]
		public string Address2_City
		{
			get
			{
				return this.GetAttributeValue<string>("address2_city");
			}
			set
			{
				this.OnPropertyChanging("Address2_City");
				this.SetAttributeValue("address2_city", value);
				this.OnPropertyChanged("Address2_City");
			}
		}
	


		/// <summary>
		/// Mostra o endereço secundário completo.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_composite")]
		public string Address2_Composite
		{
			get
			{
				return this.GetAttributeValue<string>("address2_composite");
			}
		}
	


		/// <summary>
		/// Digite o país ou região do endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_country")]
		public string Address2_Country
		{
			get
			{
				return this.GetAttributeValue<string>("address2_country");
			}
			set
			{
				this.OnPropertyChanging("Address2_Country");
				this.SetAttributeValue("address2_country", value);
				this.OnPropertyChanged("Address2_Country");
			}
		}
	


		/// <summary>
		/// Digite o município do endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_county")]
		public string Address2_County
		{
			get
			{
				return this.GetAttributeValue<string>("address2_county");
			}
			set
			{
				this.OnPropertyChanging("Address2_County");
				this.SetAttributeValue("address2_county", value);
				this.OnPropertyChanged("Address2_County");
			}
		}
	


		/// <summary>
		/// Digite o número do fax associado ao endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_fax")]
		public string Address2_Fax
		{
			get
			{
				return this.GetAttributeValue<string>("address2_fax");
			}
			set
			{
				this.OnPropertyChanging("Address2_Fax");
				this.SetAttributeValue("address2_fax", value);
				this.OnPropertyChanged("Address2_Fax");
			}
		}
	


		/// <summary>
		/// Escolha as condições de frete do endereço secundário para garantir que as ordens de remessa sejam processadas corretamente.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_freighttermscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address2_FreightTermsCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_freighttermscode");
			}
			set
			{
				this.OnPropertyChanging("Address2_FreightTermsCode");
				this.SetAttributeValue("address2_freighttermscode", value);
				this.OnPropertyChanged("Address2_FreightTermsCode");
			}
		}
	
		public virtual Enums.Address2_FreightTermsCode? Address2_FreightTermsCodeEnum
		{
			get
			{
				return ((Enums.Address2_FreightTermsCode?)(EntityOptionSetEnum.GetEnum(this, "address2_freighttermscode")));
			}
			set
			{
				Address2_FreightTermsCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Digite o valor da latitude do endereço secundário para uso no mapeamento e em outros aplicativos.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_latitude")]
		public System.Nullable<double> Address2_Latitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address2_latitude");
			}
			set
			{
				this.OnPropertyChanging("Address2_Latitude");
				this.SetAttributeValue("address2_latitude", value);
				this.OnPropertyChanged("Address2_Latitude");
			}
		}
	


		/// <summary>
		/// Digite a primeira linha do endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line1")]
		public string Address2_Line1
		{
			get
			{
				return this.GetAttributeValue<string>("address2_line1");
			}
			set
			{
				this.OnPropertyChanging("Address2_Line1");
				this.SetAttributeValue("address2_line1", value);
				this.OnPropertyChanged("Address2_Line1");
			}
		}
	


		/// <summary>
		/// Digite a segunda linha do endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line2")]
		public string Address2_Line2
		{
			get
			{
				return this.GetAttributeValue<string>("address2_line2");
			}
			set
			{
				this.OnPropertyChanging("Address2_Line2");
				this.SetAttributeValue("address2_line2", value);
				this.OnPropertyChanged("Address2_Line2");
			}
		}
	


		/// <summary>
		/// Digite a terceira linha do endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line3")]
		public string Address2_Line3
		{
			get
			{
				return this.GetAttributeValue<string>("address2_line3");
			}
			set
			{
				this.OnPropertyChanging("Address2_Line3");
				this.SetAttributeValue("address2_line3", value);
				this.OnPropertyChanged("Address2_Line3");
			}
		}
	


		/// <summary>
		/// Digite o valor da longitude do endereço secundário para uso no mapeamento e em outros aplicativos.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_longitude")]
		public System.Nullable<double> Address2_Longitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address2_longitude");
			}
			set
			{
				this.OnPropertyChanging("Address2_Longitude");
				this.SetAttributeValue("address2_longitude", value);
				this.OnPropertyChanged("Address2_Longitude");
			}
		}
	


		/// <summary>
		/// Digite um nome descritivo para o endereço secundário, como Matriz Corporativa.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_name")]
		public string Address2_Name
		{
			get
			{
				return this.GetAttributeValue<string>("address2_name");
			}
			set
			{
				this.OnPropertyChanging("Address2_Name");
				this.SetAttributeValue("address2_name", value);
				this.OnPropertyChanged("Address2_Name");
			}
		}
	


		/// <summary>
		/// Digite o CEP do endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postalcode")]
		public string Address2_PostalCode
		{
			get
			{
				return this.GetAttributeValue<string>("address2_postalcode");
			}
			set
			{
				this.OnPropertyChanging("Address2_PostalCode");
				this.SetAttributeValue("address2_postalcode", value);
				this.OnPropertyChanged("Address2_PostalCode");
			}
		}
	


		/// <summary>
		/// Digite o número da caixa postal do endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postofficebox")]
		public string Address2_PostOfficeBox
		{
			get
			{
				return this.GetAttributeValue<string>("address2_postofficebox");
			}
			set
			{
				this.OnPropertyChanging("Address2_PostOfficeBox");
				this.SetAttributeValue("address2_postofficebox", value);
				this.OnPropertyChanged("Address2_PostOfficeBox");
			}
		}
	


		/// <summary>
		/// Digite o nome do contato principal no endereço secundário da conta.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_primarycontactname")]
		public string Address2_PrimaryContactName
		{
			get
			{
				return this.GetAttributeValue<string>("address2_primarycontactname");
			}
			set
			{
				this.OnPropertyChanging("Address2_PrimaryContactName");
				this.SetAttributeValue("address2_primarycontactname", value);
				this.OnPropertyChanged("Address2_PrimaryContactName");
			}
		}
	


		/// <summary>
		/// Escolha uma forma de transporte para entregas enviadas para este endereço.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_shippingmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address2_ShippingMethodCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_shippingmethodcode");
			}
			set
			{
				this.OnPropertyChanging("Address2_ShippingMethodCode");
				this.SetAttributeValue("address2_shippingmethodcode", value);
				this.OnPropertyChanged("Address2_ShippingMethodCode");
			}
		}
	
		public virtual Enums.Address2_ShippingMethodCode? Address2_ShippingMethodCodeEnum
		{
			get
			{
				return ((Enums.Address2_ShippingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "address2_shippingmethodcode")));
			}
			set
			{
				Address2_ShippingMethodCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Digite o estado ou província do endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_stateorprovince")]
		public string Address2_StateOrProvince
		{
			get
			{
				return this.GetAttributeValue<string>("address2_stateorprovince");
			}
			set
			{
				this.OnPropertyChanging("Address2_StateOrProvince");
				this.SetAttributeValue("address2_stateorprovince", value);
				this.OnPropertyChanged("Address2_StateOrProvince");
			}
		}
	


		/// <summary>
		/// Digite o número do telefone principal associado ao endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone1")]
		public string Address2_Telephone1
		{
			get
			{
				return this.GetAttributeValue<string>("address2_telephone1");
			}
			set
			{
				this.OnPropertyChanging("Address2_Telephone1");
				this.SetAttributeValue("address2_telephone1", value);
				this.OnPropertyChanged("Address2_Telephone1");
			}
		}
	


		/// <summary>
		/// Digite um segundo número de telefone associado ao endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone2")]
		public string Address2_Telephone2
		{
			get
			{
				return this.GetAttributeValue<string>("address2_telephone2");
			}
			set
			{
				this.OnPropertyChanging("Address2_Telephone2");
				this.SetAttributeValue("address2_telephone2", value);
				this.OnPropertyChanged("Address2_Telephone2");
			}
		}
	


		/// <summary>
		/// Digite um terceiro número de telefone associado ao endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone3")]
		public string Address2_Telephone3
		{
			get
			{
				return this.GetAttributeValue<string>("address2_telephone3");
			}
			set
			{
				this.OnPropertyChanging("Address2_Telephone3");
				this.SetAttributeValue("address2_telephone3", value);
				this.OnPropertyChanged("Address2_Telephone3");
			}
		}
	


		/// <summary>
		/// Digite a zona UPS do endereço secundário para garantir que os encargos de remessa sejam calculados corretamente e as entregas sejam feitas imediatamente, quando enviado por UPS.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_upszone")]
		public string Address2_UPSZone
		{
			get
			{
				return this.GetAttributeValue<string>("address2_upszone");
			}
			set
			{
				this.OnPropertyChanging("Address2_UPSZone");
				this.SetAttributeValue("address2_upszone", value);
				this.OnPropertyChanged("Address2_UPSZone");
			}
		}
	


		/// <summary>
		/// Escolha o fuso horário ou a compensação UTC deste endereço para que outras pessoas possam fazer referência a ele ao contatar alguém nesse endereço.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_utcoffset")]
		public System.Nullable<int> Address2_UTCOffset
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("address2_utcoffset");
			}
			set
			{
				this.OnPropertyChanging("Address2_UTCOffset");
				this.SetAttributeValue("address2_utcoffset", value);
				this.OnPropertyChanged("Address2_UTCOffset");
			}
		}
	


		/// <summary>
		/// Somente para uso do sistema.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging30")]
		public Microsoft.Xrm.Sdk.Money Aging30
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging30");
			}
		}
	


		/// <summary>
		/// O equivalente em moeda base do campo de vencimento em 30 dias.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging30_base")]
		public Microsoft.Xrm.Sdk.Money Aging30_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging30_base");
			}
		}
	


		/// <summary>
		/// Somente para uso do sistema.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging60")]
		public Microsoft.Xrm.Sdk.Money Aging60
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging60");
			}
		}
	


		/// <summary>
		/// O equivalente em moeda base do campo de vencimento em 60 dias.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging60_base")]
		public Microsoft.Xrm.Sdk.Money Aging60_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging60_base");
			}
		}
	


		/// <summary>
		/// Somente para uso do sistema.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging90")]
		public Microsoft.Xrm.Sdk.Money Aging90
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging90");
			}
		}
	


		/// <summary>
		/// O equivalente em moeda base do campo de vencimento em 90 dias.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging90_base")]
		public Microsoft.Xrm.Sdk.Money Aging90_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging90_base");
			}
		}
	


		/// <summary>
		/// Escolha a designação legal ou outro tipo de empresa da conta para fins de contratos ou relatórios.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businesstypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue BusinessTypeCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("businesstypecode");
			}
			set
			{
				this.OnPropertyChanging("BusinessTypeCode");
				this.SetAttributeValue("businesstypecode", value);
				this.OnPropertyChanged("BusinessTypeCode");
			}
		}
	
		public virtual Enums.BusinessTypeCode? BusinessTypeCodeEnum
		{
			get
			{
				return ((Enums.BusinessTypeCode?)(EntityOptionSetEnum.GetEnum(this, "businesstypecode")));
			}
			set
			{
				BusinessTypeCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Mostra quem criou o registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
	


		/// <summary>
		/// Mostra o participante externo que criou o registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdbyexternalparty")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedByExternalParty
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdbyexternalparty");
			}
		}
	




		/// <summary>
		/// Mostra a data e a hora em que o registro foi criado. A data e a hora são exibidas no fuso horário escolhido nas opções do Microsoft Dynamics 365.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
	


		/// <summary>
		/// Mostra quem criou o registro em nome de outro usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
	



		/// <summary>
		/// Digite o limite de crédito da conta. Isso é uma referência útil para resolver problemas de faturamento e de contabilidade com o cliente.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("creditlimit")]
		public Microsoft.Xrm.Sdk.Money CreditLimit
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("creditlimit");
			}
			set
			{
				this.OnPropertyChanging("CreditLimit");
				this.SetAttributeValue("creditlimit", value);
				this.OnPropertyChanged("CreditLimit");
			}
		}
	


		/// <summary>
		/// Mostra o limite de crédito convertido na moeda base padrão do sistema para fins de relatórios.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("creditlimit_base")]
		public Microsoft.Xrm.Sdk.Money CreditLimit_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("creditlimit_base");
			}
		}
	


		/// <summary>
		/// Escolha se o crédito da conta está suspenso. Essa é uma referência útil ao resolver problemas de faturamento e de contabilidade com o cliente.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("creditonhold")]
		public System.Nullable<bool> CreditOnHold
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("creditonhold");
			}
			set
			{
				this.OnPropertyChanging("CreditOnHold");
				this.SetAttributeValue("creditonhold", value);
				this.OnPropertyChanged("CreditOnHold");
			}
		}
	
		public virtual Enums.CreditOnHold? CreditOnHoldEnum
		{
			get
			{
				return ((Enums.CreditOnHold?)(EntityOptionSetEnum.GetEnum(this, "creditonhold")));
			}
			set
			{
		       if (value.HasValue)
                    CreditOnHold = ((int)value == 1);
                else                   
                    CreditOnHold = null;
			}
		}


		/// <summary>
		/// Escolha a categoria ou o intervalo de tamanho da conta para fins de segmentação e relatórios.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customersizecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue CustomerSizeCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("customersizecode");
			}
			set
			{
				this.OnPropertyChanging("CustomerSizeCode");
				this.SetAttributeValue("customersizecode", value);
				this.OnPropertyChanged("CustomerSizeCode");
			}
		}
	
		public virtual Enums.CustomerSizeCode? CustomerSizeCodeEnum
		{
			get
			{
				return ((Enums.CustomerSizeCode?)(EntityOptionSetEnum.GetEnum(this, "customersizecode")));
			}
			set
			{
				CustomerSizeCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Escolha a categoria que melhor descreve o relacionamento entre a conta e sua organização.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customertypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue CustomerTypeCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("customertypecode");
			}
			set
			{
				this.OnPropertyChanging("CustomerTypeCode");
				this.SetAttributeValue("customertypecode", value);
				this.OnPropertyChanged("CustomerTypeCode");
			}
		}
	
		public virtual Enums.CustomerTypeCode? CustomerTypeCodeEnum
		{
			get
			{
				return ((Enums.CustomerTypeCode?)(EntityOptionSetEnum.GetEnum(this, "customertypecode")));
			}
			set
			{
				CustomerTypeCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Escolha a lista de preços padrão associada à conta para garantir que os preços de produtos corretos para este cliente sejam aplicados em oportunidades de vendas, cotações e ordens.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultpricelevelid")]
		public Microsoft.Xrm.Sdk.EntityReference DefaultPriceLevelId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("defaultpricelevelid");
			}
			set
			{
				this.OnPropertyChanging("DefaultPriceLevelId");
				this.SetAttributeValue("defaultpricelevelid", value);
				this.OnPropertyChanged("DefaultPriceLevelId");
			}
		}
	



		/// <summary>
		/// Digite informações adicionais para descrever a conta, como um extrato do site da empresa.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			set
			{
				this.OnPropertyChanging("Description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("Description");
			}
		}
	


		/// <summary>
		/// Escolha se a conta permite o envio de email em massa em campanhas. Se Não Permitir estiver escolhido, a conta poderá ser adicionada às listas de marketing, mas será excluída de email.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotbulkemail")]
		public System.Nullable<bool> DoNotBulkEMail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotbulkemail");
			}
			set
			{
				this.OnPropertyChanging("DoNotBulkEMail");
				this.SetAttributeValue("donotbulkemail", value);
				this.OnPropertyChanged("DoNotBulkEMail");
			}
		}
	
		public virtual Enums.DoNotBulkEMail? DoNotBulkEMailEnum
		{
			get
			{
				return ((Enums.DoNotBulkEMail?)(EntityOptionSetEnum.GetEnum(this, "donotbulkemail")));
			}
			set
			{
		       if (value.HasValue)
                    DoNotBulkEMail = ((int)value == 1);
                else                   
                    DoNotBulkEMail = null;
			}
		}


		/// <summary>
		/// Escolha se a conta permite o envio de correio em massa em campanhas de marketing ou rápidas. Se Não Permitir estiver escolhido, a conta poderá ser adicionada às listas de marketing, mas será excluída do correio.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotbulkpostalmail")]
		public System.Nullable<bool> DoNotBulkPostalMail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotbulkpostalmail");
			}
			set
			{
				this.OnPropertyChanging("DoNotBulkPostalMail");
				this.SetAttributeValue("donotbulkpostalmail", value);
				this.OnPropertyChanged("DoNotBulkPostalMail");
			}
		}
	
		public virtual Enums.DoNotBulkPostalMail? DoNotBulkPostalMailEnum
		{
			get
			{
				return ((Enums.DoNotBulkPostalMail?)(EntityOptionSetEnum.GetEnum(this, "donotbulkpostalmail")));
			}
			set
			{
		       if (value.HasValue)
                    DoNotBulkPostalMail = ((int)value == 1);
                else                   
                    DoNotBulkPostalMail = null;
			}
		}


		/// <summary>
		/// Escolha se a conta permite o envio de email direto do Microsoft Dynamics 365.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotemail")]
		public System.Nullable<bool> DoNotEMail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotemail");
			}
			set
			{
				this.OnPropertyChanging("DoNotEMail");
				this.SetAttributeValue("donotemail", value);
				this.OnPropertyChanged("DoNotEMail");
			}
		}
	
		public virtual Enums.DoNotEMail? DoNotEMailEnum
		{
			get
			{
				return ((Enums.DoNotEMail?)(EntityOptionSetEnum.GetEnum(this, "donotemail")));
			}
			set
			{
		       if (value.HasValue)
                    DoNotEMail = ((int)value == 1);
                else                   
                    DoNotEMail = null;
			}
		}


		/// <summary>
		/// Escolha se a conta permite fax. Se Não Permitir estiver escolhido, a conta será excluída das atividades de fax distribuídas em campanhas de marketing.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotfax")]
		public System.Nullable<bool> DoNotFax
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotfax");
			}
			set
			{
				this.OnPropertyChanging("DoNotFax");
				this.SetAttributeValue("donotfax", value);
				this.OnPropertyChanged("DoNotFax");
			}
		}
	
		public virtual Enums.DoNotFax? DoNotFaxEnum
		{
			get
			{
				return ((Enums.DoNotFax?)(EntityOptionSetEnum.GetEnum(this, "donotfax")));
			}
			set
			{
		       if (value.HasValue)
                    DoNotFax = ((int)value == 1);
                else                   
                    DoNotFax = null;
			}
		}


		/// <summary>
		/// Escolha se a conta permite telefonemas. Se Não Permitir estiver escolhido, a conta será excluída das atividades de telefonema distribuídas em campanhas de marketing.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotphone")]
		public System.Nullable<bool> DoNotPhone
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotphone");
			}
			set
			{
				this.OnPropertyChanging("DoNotPhone");
				this.SetAttributeValue("donotphone", value);
				this.OnPropertyChanged("DoNotPhone");
			}
		}
	
		public virtual Enums.DoNotPhone? DoNotPhoneEnum
		{
			get
			{
				return ((Enums.DoNotPhone?)(EntityOptionSetEnum.GetEnum(this, "donotphone")));
			}
			set
			{
		       if (value.HasValue)
                    DoNotPhone = ((int)value == 1);
                else                   
                    DoNotPhone = null;
			}
		}


		/// <summary>
		/// Escolha se a conta permite email direto. Se Não Permitir estiver escolhido, a conta será excluída das atividades de cartas distribuídas em campanhas de marketing.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotpostalmail")]
		public System.Nullable<bool> DoNotPostalMail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotpostalmail");
			}
			set
			{
				this.OnPropertyChanging("DoNotPostalMail");
				this.SetAttributeValue("donotpostalmail", value);
				this.OnPropertyChanged("DoNotPostalMail");
			}
		}
	
		public virtual Enums.DoNotPostalMail? DoNotPostalMailEnum
		{
			get
			{
				return ((Enums.DoNotPostalMail?)(EntityOptionSetEnum.GetEnum(this, "donotpostalmail")));
			}
			set
			{
		       if (value.HasValue)
                    DoNotPostalMail = ((int)value == 1);
                else                   
                    DoNotPostalMail = null;
			}
		}


		/// <summary>
		/// Escolha se a conta aceita materiais de marketing, como brochuras ou catálogos.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotsendmm")]
		public System.Nullable<bool> DoNotSendMM
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotsendmm");
			}
			set
			{
				this.OnPropertyChanging("DoNotSendMM");
				this.SetAttributeValue("donotsendmm", value);
				this.OnPropertyChanged("DoNotSendMM");
			}
		}
	
		public virtual Enums.DoNotSendMM? DoNotSendMMEnum
		{
			get
			{
				return ((Enums.DoNotSendMM?)(EntityOptionSetEnum.GetEnum(this, "donotsendmm")));
			}
			set
			{
		       if (value.HasValue)
                    DoNotSendMM = ((int)value == 1);
                else                   
                    DoNotSendMM = null;
			}
		}


		/// <summary>
		/// Primeiro endereço de email da conta.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress1")]
		public string EMailAddress1
		{
			get
			{
				return this.GetAttributeValue<string>("emailaddress1");
			}
			set
			{
				this.OnPropertyChanging("EMailAddress1");
				this.SetAttributeValue("emailaddress1", value);
				this.OnPropertyChanged("EMailAddress1");
			}
		}
	


		/// <summary>
		/// Digite o endereço de email secundário da conta.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress2")]
		public string EMailAddress2
		{
			get
			{
				return this.GetAttributeValue<string>("emailaddress2");
			}
			set
			{
				this.OnPropertyChanging("EMailAddress2");
				this.SetAttributeValue("emailaddress2", value);
				this.OnPropertyChanged("EMailAddress2");
			}
		}
	


		/// <summary>
		/// Digite o endereço de email alternativo da conta.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress3")]
		public string EMailAddress3
		{
			get
			{
				return this.GetAttributeValue<string>("emailaddress3");
			}
			set
			{
				this.OnPropertyChanging("EMailAddress3");
				this.SetAttributeValue("emailaddress3", value);
				this.OnPropertyChanged("EMailAddress3");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage")]
		public byte[] EntityImage
		{
			get
			{
				return this.GetAttributeValue<byte[]>("entityimage");
			}
			set
			{
				this.OnPropertyChanging("EntityImage");
				this.SetAttributeValue("entityimage", value);
				this.OnPropertyChanged("EntityImage");
			}
		}
	


		/// <summary>
		///  
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_timestamp")]
		public System.Nullable<long> EntityImage_Timestamp
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("entityimage_timestamp");
			}
		}
	


		/// <summary>
		///  
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_url")]
		public string EntityImage_URL
		{
			get
			{
				return this.GetAttributeValue<string>("entityimage_url");
			}
		}
	


		/// <summary>
		/// Somente para uso interno.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimageid")]
		public System.Nullable<System.Guid> EntityImageId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("entityimageid");
			}
		}
	


		/// <summary>
		/// Mostra a taxa de conversão da moeda do registro. A taxa de conversão é usada para converter todos os campos de money do registro, da moeda local para a moeda padrão do sistema.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
		public System.Nullable<decimal> ExchangeRate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
			}
		}
	


		/// <summary>
		/// Digite o número do fax da conta.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fax")]
		public string Fax
		{
			get
			{
				return this.GetAttributeValue<string>("fax");
			}
			set
			{
				this.OnPropertyChanging("Fax");
				this.SetAttributeValue("fax", value);
				this.OnPropertyChanged("Fax");
			}
		}
	


		/// <summary>
		/// Informações que especificam se será permitido acompanhar atividades de email, como aberturas, exibições de anexo e cliques em links nos emails enviados à conta.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("followemail")]
		public System.Nullable<bool> FollowEmail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("followemail");
			}
			set
			{
				this.OnPropertyChanging("FollowEmail");
				this.SetAttributeValue("followemail", value);
				this.OnPropertyChanged("FollowEmail");
			}
		}
	
		public virtual Enums.FollowEmail? FollowEmailEnum
		{
			get
			{
				return ((Enums.FollowEmail?)(EntityOptionSetEnum.GetEnum(this, "followemail")));
			}
			set
			{
		       if (value.HasValue)
                    FollowEmail = ((int)value == 1);
                else                   
                    FollowEmail = null;
			}
		}


		/// <summary>
		/// Digite a URL do site de FTP da conta para permitir que os usuários acessem dados e compartilhem documentos.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ftpsiteurl")]
		public string FtpSiteURL
		{
			get
			{
				return this.GetAttributeValue<string>("ftpsiteurl");
			}
			set
			{
				this.OnPropertyChanging("FtpSiteURL");
				this.SetAttributeValue("ftpsiteurl", value);
				this.OnPropertyChanged("FtpSiteURL");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo da importação de dados ou migração de dados que criou este registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
	


		/// <summary>
		/// O tipo de setor ao qual a conta está associada.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("industrycode")]
		public Microsoft.Xrm.Sdk.OptionSetValue IndustryCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("industrycode");
			}
			set
			{
				this.OnPropertyChanging("IndustryCode");
				this.SetAttributeValue("industrycode", value);
				this.OnPropertyChanged("IndustryCode");
			}
		}
	
		public virtual Enums.IndustryCode? IndustryCodeEnum
		{
			get
			{
				return ((Enums.IndustryCode?)(EntityOptionSetEnum.GetEnum(this, "industrycode")));
			}
			set
			{
				IndustryCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isprivate")]
		public System.Nullable<bool> IsPrivate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isprivate");
			}
		}
	
		public virtual Enums.IsPrivate? IsPrivateEnum
		{
			get
			{
				return ((Enums.IsPrivate?)(EntityOptionSetEnum.GetEnum(this, "isprivate")));
			}
		}


		/// <summary>
		/// Contém o carimbo de data e hora da última suspensão.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastonholdtime")]
		public System.Nullable<System.DateTime> LastOnHoldTime
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastonholdtime");
			}
			set
			{
				this.OnPropertyChanging("LastOnHoldTime");
				this.SetAttributeValue("lastonholdtime", value);
				this.OnPropertyChanged("LastOnHoldTime");
			}
		}
	


		/// <summary>
		/// Mostra a data em que a conta foi incluída pela última vez em uma campanha de marketing ou campanha rápida.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastusedincampaign")]
		public System.Nullable<System.DateTime> LastUsedInCampaign
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastusedincampaign");
			}
			set
			{
				this.OnPropertyChanging("LastUsedInCampaign");
				this.SetAttributeValue("lastusedincampaign", value);
				this.OnPropertyChanged("LastUsedInCampaign");
			}
		}
	


		/// <summary>
		/// Digite a capitalização de mercado da conta para identificar o capital próprio da empresa, usado como um indicador em análises de desempenho financeiro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("marketcap")]
		public Microsoft.Xrm.Sdk.Money MarketCap
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("marketcap");
			}
			set
			{
				this.OnPropertyChanging("MarketCap");
				this.SetAttributeValue("marketcap", value);
				this.OnPropertyChanged("MarketCap");
			}
		}
	


		/// <summary>
		/// Mostra a capitalização de mercado convertida na moeda base padrão do sistema.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("marketcap_base")]
		public Microsoft.Xrm.Sdk.Money MarketCap_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("marketcap_base");
			}
		}
	


		/// <summary>
		/// Se for somente para marketing
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("marketingonly")]
		public System.Nullable<bool> MarketingOnly
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("marketingonly");
			}
			set
			{
				this.OnPropertyChanging("MarketingOnly");
				this.SetAttributeValue("marketingonly", value);
				this.OnPropertyChanged("MarketingOnly");
			}
		}
	
		public virtual Enums.MarketingOnly? MarketingOnlyEnum
		{
			get
			{
				return ((Enums.MarketingOnly?)(EntityOptionSetEnum.GetEnum(this, "marketingonly")));
			}
			set
			{
		       if (value.HasValue)
                    MarketingOnly = ((int)value == 1);
                else                   
                    MarketingOnly = null;
			}
		}


		/// <summary>
		/// Mostra a conta mestra com a qual a conta foi mesclada.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("masterid")]
		public Microsoft.Xrm.Sdk.EntityReference MasterId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("masterid");
			}
		}
	



		/// <summary>
		/// Mostra se a conta foi mesclada com outra conta.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("merged")]
		public System.Nullable<bool> Merged
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("merged");
			}
		}
	
		public virtual Enums.Merged? MergedEnum
		{
			get
			{
				return ((Enums.Merged?)(EntityOptionSetEnum.GetEnum(this, "merged")));
			}
		}


		/// <summary>
		/// Mostra quem atualizou o registro pela última vez.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
	


		/// <summary>
		/// Mostra o participante externo que modificou o registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedbyexternalparty")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedByExternalParty
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedbyexternalparty");
			}
		}
	




		/// <summary>
		/// Mostra a data e a hora em que o registro foi atualizado pela última vez. A data e a hora são exibidas no fuso horário escolhido nas opções do Microsoft Dynamics 365.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
	


		/// <summary>
		/// Mostra quem criou o registro em nome de outro usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
	



		/// <summary>
		/// Referência a outra conta a ser usada para cobrança (só deve ser usada quando a conta de cobrança é diferente)
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_billingaccount")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_BillingAccount
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_billingaccount");
			}
			set
			{
				this.OnPropertyChanging("msdyn_BillingAccount");
				this.SetAttributeValue("msdyn_billingaccount", value);
				this.OnPropertyChanged("msdyn_BillingAccount");
			}
		}
	



		/// <summary>
		/// ID da Conta Externa em outros sistemas.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_externalaccountid")]
		public string msdyn_externalaccountid
		{
			get
			{
				return this.GetAttributeValue<string>("msdyn_externalaccountid");
			}
			set
			{
				this.OnPropertyChanging("msdyn_externalaccountid");
				this.SetAttributeValue("msdyn_externalaccountid", value);
				this.OnPropertyChanged("msdyn_externalaccountid");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_preferredresource")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_PreferredResource
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_preferredresource");
			}
			set
			{
				this.OnPropertyChanging("msdyn_PreferredResource");
				this.SetAttributeValue("msdyn_preferredresource", value);
				this.OnPropertyChanged("msdyn_PreferredResource");
			}
		}
	



		/// <summary>
		/// Código do Imposto Padrão
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_salestaxcode")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_SalesTaxCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_salestaxcode");
			}
			set
			{
				this.OnPropertyChanging("msdyn_SalesTaxCode");
				this.SetAttributeValue("msdyn_salestaxcode", value);
				this.OnPropertyChanged("msdyn_SalesTaxCode");
			}
		}
	



		/// <summary>
		/// A Região de Serviço à qual pertence esta conta. Ela é usada para otimizar o agendamento e o roteamento
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_serviceterritory")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_ServiceTerritory
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_serviceterritory");
			}
			set
			{
				this.OnPropertyChanging("msdyn_ServiceTerritory");
				this.SetAttributeValue("msdyn_serviceterritory", value);
				this.OnPropertyChanged("msdyn_ServiceTerritory");
			}
		}
	



		/// <summary>
		/// Selecione se a conta tem isenção de imposto.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_taxexempt")]
		public System.Nullable<bool> msdyn_TaxExempt
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("msdyn_taxexempt");
			}
			set
			{
				this.OnPropertyChanging("msdyn_TaxExempt");
				this.SetAttributeValue("msdyn_taxexempt", value);
				this.OnPropertyChanged("msdyn_TaxExempt");
			}
		}
	
		public virtual Enums.msdyn_TaxExempt? msdyn_TaxExemptEnum
		{
			get
			{
				return ((Enums.msdyn_TaxExempt?)(EntityOptionSetEnum.GetEnum(this, "msdyn_taxexempt")));
			}
			set
			{
		       if (value.HasValue)
                    msdyn_TaxExempt = ((int)value == 1);
                else                   
                    msdyn_TaxExempt = null;
			}
		}


		/// <summary>
		/// Mostra o número de isenção de imposto governamental.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_taxexemptnumber")]
		public string msdyn_TaxExemptNumber
		{
			get
			{
				return this.GetAttributeValue<string>("msdyn_taxexemptnumber");
			}
			set
			{
				this.OnPropertyChanging("msdyn_TaxExemptNumber");
				this.SetAttributeValue("msdyn_taxexemptnumber", value);
				this.OnPropertyChanged("msdyn_TaxExemptNumber");
			}
		}
	


		/// <summary>
		/// Inserir a cobrança de viagem para incluir em ordens de serviço. Este valor será multiplicado pelo tipo de cobrança de viagem.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_travelcharge")]
		public Microsoft.Xrm.Sdk.Money msdyn_TravelCharge
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("msdyn_travelcharge");
			}
			set
			{
				this.OnPropertyChanging("msdyn_TravelCharge");
				this.SetAttributeValue("msdyn_travelcharge", value);
				this.OnPropertyChanged("msdyn_TravelCharge");
			}
		}
	


		/// <summary>
		/// Valor Cobrança de Viagem na moeda base.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_travelcharge_base")]
		public Microsoft.Xrm.Sdk.Money msdyn_travelcharge_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("msdyn_travelcharge_base");
			}
		}
	


		/// <summary>
		/// Especificar como a viagem é cobrada para esta conta.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_travelchargetype")]
		public Microsoft.Xrm.Sdk.OptionSetValue msdyn_TravelChargeType
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("msdyn_travelchargetype");
			}
			set
			{
				this.OnPropertyChanging("msdyn_TravelChargeType");
				this.SetAttributeValue("msdyn_travelchargetype", value);
				this.OnPropertyChanged("msdyn_TravelChargeType");
			}
		}
	
		public virtual Enums.msdyn_TravelChargeType? msdyn_TravelChargeTypeEnum
		{
			get
			{
				return ((Enums.msdyn_TravelChargeType?)(EntityOptionSetEnum.GetEnum(this, "msdyn_travelchargetype")));
			}
			set
			{
				msdyn_TravelChargeType = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Mostra as instruções padrão a serem exibidas nas novas ordens de serviço.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_workorderinstructions")]
		public string msdyn_WorkOrderInstructions
		{
			get
			{
				return this.GetAttributeValue<string>("msdyn_workorderinstructions");
			}
			set
			{
				this.OnPropertyChanging("msdyn_WorkOrderInstructions");
				this.SetAttributeValue("msdyn_workorderinstructions", value);
				this.OnPropertyChanged("msdyn_WorkOrderInstructions");
			}
		}
	


		/// <summary>
		/// Nome da conta.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			set
			{
				this.OnPropertyChanging("Name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("Name");
			}
		}
	


		/// <summary>
		/// Digite o número de funcionários que trabalham na conta para uso em segmentação de marketing e análise demográfica.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("numberofemployees")]
		public System.Nullable<int> NumberOfEmployees
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("numberofemployees");
			}
			set
			{
				this.OnPropertyChanging("NumberOfEmployees");
				this.SetAttributeValue("numberofemployees", value);
				this.OnPropertyChanged("NumberOfEmployees");
			}
		}
	


		/// <summary>
		/// Mostra o tempo, em minutos, em que o registro ficou suspenso.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("onholdtime")]
		public System.Nullable<int> OnHoldTime
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("onholdtime");
			}
		}
	


		/// <summary>
		/// Número de oportunidades em aberto em relação a uma conta e suas contas secundárias.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opendeals")]
		public System.Nullable<int> OpenDeals
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("opendeals");
			}
		}
	


		/// <summary>
		/// Hora da última atualização do campo cumulativo Negociações em Aberto.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opendeals_date")]
		public System.Nullable<System.DateTime> OpenDeals_Date
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("opendeals_date");
			}
		}
	


		/// <summary>
		/// Estado do campo cumulativo Negociações em Aberto.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opendeals_state")]
		public System.Nullable<int> OpenDeals_State
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("opendeals_state");
			}
		}
	


		/// <summary>
		/// Soma da receita em aberto em relação a uma conta e suas contas secundárias.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("openrevenue")]
		public Microsoft.Xrm.Sdk.Money OpenRevenue
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("openrevenue");
			}
		}
	


		/// <summary>
		/// Valor do Receita em Aberto em moeda base.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("openrevenue_base")]
		public Microsoft.Xrm.Sdk.Money OpenRevenue_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("openrevenue_base");
			}
		}
	


		/// <summary>
		/// Hora da última atualização do campo cumulativo Receita em Aberto.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("openrevenue_date")]
		public System.Nullable<System.DateTime> OpenRevenue_Date
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("openrevenue_date");
			}
		}
	


		/// <summary>
		/// Estado do campo cumulativo Receita em Aberto.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("openrevenue_state")]
		public System.Nullable<int> OpenRevenue_State
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("openrevenue_state");
			}
		}
	


		/// <summary>
		/// Mostra o cliente potencial do qual a conta foi criada, se a conta tiver sido criada por meio da conversão de um cliente potencial no Microsoft Dynamics 365. Isso é usado para relacionar a conta aos dados no cliente potencial de origem para uso em relatórios e análises.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("originatingleadid")]
		public Microsoft.Xrm.Sdk.EntityReference OriginatingLeadId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("originatingleadid");
			}
			set
			{
				this.OnPropertyChanging("OriginatingLeadId");
				this.SetAttributeValue("originatingleadid", value);
				this.OnPropertyChanged("OriginatingLeadId");
			}
		}
	



		/// <summary>
		/// Data e hora da migração do registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
	


		/// <summary>
		/// Insira o usuário ou a equipe atribuída para gerenciar o registro. Esse campo é atualizado toda vez que o registro é atribuído a outro usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			set
			{
				this.OnPropertyChanging("OwnerId");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
	


		/// <summary>
		/// Escolha a estrutura da propriedade da conta, como pública ou privada.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownershipcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue OwnershipCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("ownershipcode");
			}
			set
			{
				this.OnPropertyChanging("OwnershipCode");
				this.SetAttributeValue("ownershipcode", value);
				this.OnPropertyChanged("OwnershipCode");
			}
		}
	
		public virtual Enums.OwnershipCode? OwnershipCodeEnum
		{
			get
			{
				return ((Enums.OwnershipCode?)(EntityOptionSetEnum.GetEnum(this, "ownershipcode")));
			}
			set
			{
				OwnershipCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Mostra a unidade de negócios à qual o proprietário do registro pertence.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
		}
	



		/// <summary>
		/// Identificador exclusivo da equipe que possui a conta.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
		}
	



		/// <summary>
		/// Identificador exclusivo do usuário que é proprietário da conta.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
		}
	



		/// <summary>
		/// Escolha a conta primária associada a esta conta para mostrar negócios primários e secundários em relatórios e análises.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentaccountid")]
		public Microsoft.Xrm.Sdk.EntityReference ParentAccountId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentaccountid");
			}
			set
			{
				this.OnPropertyChanging("ParentAccountId");
				this.SetAttributeValue("parentaccountid", value);
				this.OnPropertyChanged("ParentAccountId");
			}
		}
	



		/// <summary>
		/// Somente para uso do sistema. Dados de fluxo de trabalho herdados do Microsoft Dynamics CRM 3.0.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("participatesinworkflow")]
		public System.Nullable<bool> ParticipatesInWorkflow
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("participatesinworkflow");
			}
			set
			{
				this.OnPropertyChanging("ParticipatesInWorkflow");
				this.SetAttributeValue("participatesinworkflow", value);
				this.OnPropertyChanged("ParticipatesInWorkflow");
			}
		}
	
		public virtual Enums.ParticipatesInWorkflow? ParticipatesInWorkflowEnum
		{
			get
			{
				return ((Enums.ParticipatesInWorkflow?)(EntityOptionSetEnum.GetEnum(this, "participatesinworkflow")));
			}
			set
			{
		       if (value.HasValue)
                    ParticipatesInWorkflow = ((int)value == 1);
                else                   
                    ParticipatesInWorkflow = null;
			}
		}


		/// <summary>
		/// Escolha as condições de pagamento para indicar quando o cliente precisa pagar o valor total.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("paymenttermscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PaymentTermsCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("paymenttermscode");
			}
			set
			{
				this.OnPropertyChanging("PaymentTermsCode");
				this.SetAttributeValue("paymenttermscode", value);
				this.OnPropertyChanged("PaymentTermsCode");
			}
		}
	
		public virtual Enums.PaymentTermsCode? PaymentTermsCodeEnum
		{
			get
			{
				return ((Enums.PaymentTermsCode?)(EntityOptionSetEnum.GetEnum(this, "paymenttermscode")));
			}
			set
			{
				PaymentTermsCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Escolha o dia preferencial da semana para compromissos de serviço.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredappointmentdaycode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PreferredAppointmentDayCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredappointmentdaycode");
			}
			set
			{
				this.OnPropertyChanging("PreferredAppointmentDayCode");
				this.SetAttributeValue("preferredappointmentdaycode", value);
				this.OnPropertyChanged("PreferredAppointmentDayCode");
			}
		}
	
		public virtual Enums.PreferredAppointmentDayCode? PreferredAppointmentDayCodeEnum
		{
			get
			{
				return ((Enums.PreferredAppointmentDayCode?)(EntityOptionSetEnum.GetEnum(this, "preferredappointmentdaycode")));
			}
			set
			{
				PreferredAppointmentDayCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Escolha a hora preferencial do dia para compromissos de serviço.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredappointmenttimecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PreferredAppointmentTimeCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredappointmenttimecode");
			}
			set
			{
				this.OnPropertyChanging("PreferredAppointmentTimeCode");
				this.SetAttributeValue("preferredappointmenttimecode", value);
				this.OnPropertyChanged("PreferredAppointmentTimeCode");
			}
		}
	
		public virtual Enums.PreferredAppointmentTimeCode? PreferredAppointmentTimeCodeEnum
		{
			get
			{
				return ((Enums.PreferredAppointmentTimeCode?)(EntityOptionSetEnum.GetEnum(this, "preferredappointmenttimecode")));
			}
			set
			{
				PreferredAppointmentTimeCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Forma de contato preferencial da conta.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredcontactmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PreferredContactMethodCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredcontactmethodcode");
			}
			set
			{
				this.OnPropertyChanging("PreferredContactMethodCode");
				this.SetAttributeValue("preferredcontactmethodcode", value);
				this.OnPropertyChanged("PreferredContactMethodCode");
			}
		}
	
		public virtual Enums.PreferredContactMethodCode? PreferredContactMethodCodeEnum
		{
			get
			{
				return ((Enums.PreferredContactMethodCode?)(EntityOptionSetEnum.GetEnum(this, "preferredcontactmethodcode")));
			}
			set
			{
				PreferredContactMethodCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Escolha a instalação ou o equipamento de serviço preferencial da conta para garantir que os serviços sejam agendados corretamente para o cliente.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredequipmentid")]
		public Microsoft.Xrm.Sdk.EntityReference PreferredEquipmentId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("preferredequipmentid");
			}
			set
			{
				this.OnPropertyChanging("PreferredEquipmentId");
				this.SetAttributeValue("preferredequipmentid", value);
				this.OnPropertyChanged("PreferredEquipmentId");
			}
		}
	



		/// <summary>
		/// Escolha o serviço preferencial da conta para referência ao agendar atividades de serviço.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredserviceid")]
		public Microsoft.Xrm.Sdk.EntityReference PreferredServiceId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("preferredserviceid");
			}
			set
			{
				this.OnPropertyChanging("PreferredServiceId");
				this.SetAttributeValue("preferredserviceid", value);
				this.OnPropertyChanged("PreferredServiceId");
			}
		}
	



		/// <summary>
		/// Escolha o representante de serviço preferencial para referência ao agendar atividades de serviço para a conta.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredsystemuserid")]
		public Microsoft.Xrm.Sdk.EntityReference PreferredSystemUserId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("preferredsystemuserid");
			}
			set
			{
				this.OnPropertyChanging("PreferredSystemUserId");
				this.SetAttributeValue("preferredsystemuserid", value);
				this.OnPropertyChanged("PreferredSystemUserId");
			}
		}
	



		/// <summary>
		/// Escolha o contato principal da conta para fornecer acesso rápido aos detalhes do contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primarycontactid")]
		public Microsoft.Xrm.Sdk.EntityReference PrimaryContactId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("primarycontactid");
			}
			set
			{
				this.OnPropertyChanging("PrimaryContactId");
				this.SetAttributeValue("primarycontactid", value);
				this.OnPropertyChanged("PrimaryContactId");
			}
		}
	



		/// <summary>
		/// ID Principal do Satori da Conta
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primarysatoriid")]
		public string PrimarySatoriId
		{
			get
			{
				return this.GetAttributeValue<string>("primarysatoriid");
			}
			set
			{
				this.OnPropertyChanging("PrimarySatoriId");
				this.SetAttributeValue("primarysatoriid", value);
				this.OnPropertyChanged("PrimarySatoriId");
			}
		}
	


		/// <summary>
		/// ID Principal do Twitter da Conta
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primarytwitterid")]
		public string PrimaryTwitterId
		{
			get
			{
				return this.GetAttributeValue<string>("primarytwitterid");
			}
			set
			{
				this.OnPropertyChanging("PrimaryTwitterId");
				this.SetAttributeValue("primarytwitterid", value);
				this.OnPropertyChanged("PrimaryTwitterId");
			}
		}
	


		/// <summary>
		/// Mostra a ID do processo.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
		public System.Nullable<System.Guid> ProcessId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("processid");
			}
			set
			{
				this.OnPropertyChanging("ProcessId");
				this.SetAttributeValue("processid", value);
				this.OnPropertyChanged("ProcessId");
			}
		}
	


		/// <summary>
		/// Digite a receita anual da conta, usada como um indicador na análise do desempenho financeiro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("revenue")]
		public Microsoft.Xrm.Sdk.Money Revenue
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("revenue");
			}
			set
			{
				this.OnPropertyChanging("Revenue");
				this.SetAttributeValue("revenue", value);
				this.OnPropertyChanged("Revenue");
			}
		}
	


		/// <summary>
		/// Mostra a receita anual convertida na moeda base padrão do sistema. Os cálculos usam a taxa de conversão especificada na área Moedas.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("revenue_base")]
		public Microsoft.Xrm.Sdk.Money Revenue_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("revenue_base");
			}
		}
	


		/// <summary>
		/// Digite o número de ações da conta disponíveis ao público. Esse número é usado como um indicador em análises de desempenho financeiro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sharesoutstanding")]
		public System.Nullable<int> SharesOutstanding
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("sharesoutstanding");
			}
			set
			{
				this.OnPropertyChanging("SharesOutstanding");
				this.SetAttributeValue("sharesoutstanding", value);
				this.OnPropertyChanged("SharesOutstanding");
			}
		}
	


		/// <summary>
		/// Escolha uma forma de transporte para as entregas enviadas para o endereço da conta para designar a transportadora preferencial ou outra opção de entrega.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shippingmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue ShippingMethodCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("shippingmethodcode");
			}
			set
			{
				this.OnPropertyChanging("ShippingMethodCode");
				this.SetAttributeValue("shippingmethodcode", value);
				this.OnPropertyChanged("ShippingMethodCode");
			}
		}
	
		public virtual Enums.ShippingMethodCode? ShippingMethodCodeEnum
		{
			get
			{
				return ((Enums.ShippingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "shippingmethodcode")));
			}
			set
			{
				ShippingMethodCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Digite o CNAE (Código Nacional de Atividade Econômica) que indica o setor principal de negócios da conta, para uso em segmentação de marketing e análise demográfica.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sic")]
		public string SIC
		{
			get
			{
				return this.GetAttributeValue<string>("sic");
			}
			set
			{
				this.OnPropertyChanging("SIC");
				this.SetAttributeValue("sic", value);
				this.OnPropertyChanged("SIC");
			}
		}
	


		/// <summary>
		/// Escolha o contrato de nível de serviço (SLA) que deseja aplicar ao registro de Conta.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slaid")]
		public Microsoft.Xrm.Sdk.EntityReference SLAId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("slaid");
			}
			set
			{
				this.OnPropertyChanging("SLAId");
				this.SetAttributeValue("slaid", value);
				this.OnPropertyChanged("SLAId");
			}
		}
	



		/// <summary>
		/// Último SLA que foi aplicado a essa ocorrência. Esse campo destina-se a uso interno somente.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slainvokedid")]
		public Microsoft.Xrm.Sdk.EntityReference SLAInvokedId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("slainvokedid");
			}
		}
	



		/// <summary>
		/// Mostra a ID do estágio.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
		public System.Nullable<System.Guid> StageId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("stageid");
			}
			set
			{
				this.OnPropertyChanging("StageId");
				this.SetAttributeValue("stageid", value);
				this.OnPropertyChanged("StageId");
			}
		}
	


		/// <summary>
		/// Mostra se a conta está ativa ou inativa. Contas inativas são somente leitura e não podem ser editadas a não ser que sejam reativadas.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<AccountState> StateCode
		{
				get
				{
					Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
					if ((optionSet != null))
					{
						return ((AccountState)(System.Enum.ToObject(typeof(AccountState), optionSet.Value)));
					}
					else
					{
						return null;
					}
				}
					set
					{
						this.OnPropertyChanging("StateCode");
						if ((value == null))
						{
							this.SetAttributeValue("statecode", null);
						}
						else
						{
							this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
						}
						this.OnPropertyChanged("StateCode");
					}
		}
	


		/// <summary>
		/// Escolha o status da conta.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			set
			{
				this.OnPropertyChanging("StatusCode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("StatusCode");
			}
		}
	


		/// <summary>
		/// Digite a bolsa de valores na qual a conta está listada para acompanhar o desempenho financeiro e ações da empresa.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stockexchange")]
		public string StockExchange
		{
			get
			{
				return this.GetAttributeValue<string>("stockexchange");
			}
			set
			{
				this.OnPropertyChanging("StockExchange");
				this.SetAttributeValue("stockexchange", value);
				this.OnPropertyChanged("StockExchange");
			}
		}
	


		/// <summary>
		/// Primeiro número de telefone da conta.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone1")]
		public string Telephone1
		{
			get
			{
				return this.GetAttributeValue<string>("telephone1");
			}
			set
			{
				this.OnPropertyChanging("Telephone1");
				this.SetAttributeValue("telephone1", value);
				this.OnPropertyChanged("Telephone1");
			}
		}
	


		/// <summary>
		/// Digite um segundo número de telefone desta conta.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone2")]
		public string Telephone2
		{
			get
			{
				return this.GetAttributeValue<string>("telephone2");
			}
			set
			{
				this.OnPropertyChanging("Telephone2");
				this.SetAttributeValue("telephone2", value);
				this.OnPropertyChanged("Telephone2");
			}
		}
	


		/// <summary>
		/// Digite um terceiro número de telefone desta conta.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone3")]
		public string Telephone3
		{
			get
			{
				return this.GetAttributeValue<string>("telephone3");
			}
			set
			{
				this.OnPropertyChanging("Telephone3");
				this.SetAttributeValue("telephone3", value);
				this.OnPropertyChanged("Telephone3");
			}
		}
	


		/// <summary>
		/// Escolha a região ou território da conta para uso em segmentação de marketing e análise demográfica.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("territorycode")]
		public Microsoft.Xrm.Sdk.OptionSetValue TerritoryCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("territorycode");
			}
			set
			{
				this.OnPropertyChanging("TerritoryCode");
				this.SetAttributeValue("territorycode", value);
				this.OnPropertyChanged("TerritoryCode");
			}
		}
	
		public virtual Enums.TerritoryCode? TerritoryCodeEnum
		{
			get
			{
				return ((Enums.TerritoryCode?)(EntityOptionSetEnum.GetEnum(this, "territorycode")));
			}
			set
			{
				TerritoryCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Escolha a região ou território de vendas da conta para garantir que a conta seja atribuída ao representante correto e para uso em segmentação e análise.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("territoryid")]
		public Microsoft.Xrm.Sdk.EntityReference TerritoryId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("territoryid");
			}
			set
			{
				this.OnPropertyChanging("TerritoryId");
				this.SetAttributeValue("territoryid", value);
				this.OnPropertyChanged("TerritoryId");
			}
		}
	



		/// <summary>
		/// Digite o símbolo da bolsa de valores da conta para acompanhar o desempenho financeiro da empresa. Você pode clicar no código inserido neste campo para acessar as informações comerciais mais recentes no MSN Dinheiro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("tickersymbol")]
		public string TickerSymbol
		{
			get
			{
				return this.GetAttributeValue<string>("tickersymbol");
			}
			set
			{
				this.OnPropertyChanging("TickerSymbol");
				this.SetAttributeValue("tickersymbol", value);
				this.OnPropertyChanged("TickerSymbol");
			}
		}
	


		/// <summary>
		/// Tempo total gasto por mim com emails (leitura e redação) e reuniões em relação ao registro da conta.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timespentbymeonemailandmeetings")]
		public string TimeSpentByMeOnEmailAndMeetings
		{
			get
			{
				return this.GetAttributeValue<string>("timespentbymeonemailandmeetings");
			}
		}
	


		/// <summary>
		/// Apenas para uso interno.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
	


		/// <summary>
		/// Escolha a moeda local do registro para garantir que os orçamentos sejam relatados na moeda correta.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
			}
			set
			{
				this.OnPropertyChanging("TransactionCurrencyId");
				this.SetAttributeValue("transactioncurrencyid", value);
				this.OnPropertyChanged("TransactionCurrencyId");
			}
		}
	



		/// <summary>
		/// Apenas para uso interno.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traversedpath")]
		public string TraversedPath
		{
			get
			{
				return this.GetAttributeValue<string>("traversedpath");
			}
			set
			{
				this.OnPropertyChanging("TraversedPath");
				this.SetAttributeValue("traversedpath", value);
				this.OnPropertyChanged("TraversedPath");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_agencia_bancaria")]
		public string urb_agencia_bancaria
		{
			get
			{
				return this.GetAttributeValue<string>("urb_agencia_bancaria");
			}
			set
			{
				this.OnPropertyChanging("urb_agencia_bancaria");
				this.SetAttributeValue("urb_agencia_bancaria", value);
				this.OnPropertyChanged("urb_agencia_bancaria");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_bairro_interesse")]
		public string urb_bairro_interesse
		{
			get
			{
				return this.GetAttributeValue<string>("urb_bairro_interesse");
			}
			set
			{
				this.OnPropertyChanging("urb_bairro_interesse");
				this.SetAttributeValue("urb_bairro_interesse", value);
				this.OnPropertyChanged("urb_bairro_interesse");
			}
		}
	


		/// <summary>
		/// Banco da conta do cliente
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_bancoid")]
		public Microsoft.Xrm.Sdk.EntityReference urb_BancoId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("urb_bancoid");
			}
			set
			{
				this.OnPropertyChanging("urb_BancoId");
				this.SetAttributeValue("urb_bancoid", value);
				this.OnPropertyChanged("urb_BancoId");
			}
		}
	



		/// <summary>
		/// Identificador único para Cidade associado a Cliente.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_cidade_enderecoid")]
		public Microsoft.Xrm.Sdk.EntityReference urb_Cidade_enderecoId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("urb_cidade_enderecoid");
			}
			set
			{
				this.OnPropertyChanging("urb_Cidade_enderecoId");
				this.SetAttributeValue("urb_cidade_enderecoid", value);
				this.OnPropertyChanged("urb_Cidade_enderecoId");
			}
		}
	



		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_cidade_estrangeiro")]
		public string urb_Cidade_estrangeiro
		{
			get
			{
				return this.GetAttributeValue<string>("urb_cidade_estrangeiro");
			}
			set
			{
				this.OnPropertyChanging("urb_Cidade_estrangeiro");
				this.SetAttributeValue("urb_cidade_estrangeiro", value);
				this.OnPropertyChanged("urb_Cidade_estrangeiro");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_cidade_interesse")]
		public Microsoft.Xrm.Sdk.OptionSetValue urb_cidade_interesse
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("urb_cidade_interesse");
			}
			set
			{
				this.OnPropertyChanging("urb_cidade_interesse");
				this.SetAttributeValue("urb_cidade_interesse", value);
				this.OnPropertyChanged("urb_cidade_interesse");
			}
		}
	
		public virtual Enums.urb_cidade_interesse? urb_cidade_interesseEnum
		{
			get
			{
				return ((Enums.urb_cidade_interesse?)(EntityOptionSetEnum.GetEnum(this, "urb_cidade_interesse")));
			}
			set
			{
				urb_cidade_interesse = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_classe_risco")]
		public Microsoft.Xrm.Sdk.OptionSetValue urb_classe_risco
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("urb_classe_risco");
			}
			set
			{
				this.OnPropertyChanging("urb_classe_risco");
				this.SetAttributeValue("urb_classe_risco", value);
				this.OnPropertyChanged("urb_classe_risco");
			}
		}
	
		public virtual Enums.urb_classe_risco? urb_classe_riscoEnum
		{
			get
			{
				return ((Enums.urb_classe_risco?)(EntityOptionSetEnum.GetEnum(this, "urb_classe_risco")));
			}
			set
			{
				urb_classe_risco = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_cliente_possui_outro_imovel")]
		public System.Nullable<bool> urb_cliente_possui_outro_imovel
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("urb_cliente_possui_outro_imovel");
			}
			set
			{
				this.OnPropertyChanging("urb_cliente_possui_outro_imovel");
				this.SetAttributeValue("urb_cliente_possui_outro_imovel", value);
				this.OnPropertyChanged("urb_cliente_possui_outro_imovel");
			}
		}
	
		public virtual Enums.urb_cliente_possui_outro_imovel? urb_cliente_possui_outro_imovelEnum
		{
			get
			{
				return ((Enums.urb_cliente_possui_outro_imovel?)(EntityOptionSetEnum.GetEnum(this, "urb_cliente_possui_outro_imovel")));
			}
			set
			{
		       if (value.HasValue)
                    urb_cliente_possui_outro_imovel = ((int)value == 1);
                else                   
                    urb_cliente_possui_outro_imovel = null;
			}
		}


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_cnpj")]
		public string urb_CNPJ
		{
			get
			{
				return this.GetAttributeValue<string>("urb_cnpj");
			}
			set
			{
				this.OnPropertyChanging("urb_CNPJ");
				this.SetAttributeValue("urb_cnpj", value);
				this.OnPropertyChanged("urb_CNPJ");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_codigo_parceiro_conjuge")]
		public string urb_codigo_parceiro_conjuge
		{
			get
			{
				return this.GetAttributeValue<string>("urb_codigo_parceiro_conjuge");
			}
			set
			{
				this.OnPropertyChanging("urb_codigo_parceiro_conjuge");
				this.SetAttributeValue("urb_codigo_parceiro_conjuge", value);
				this.OnPropertyChanged("urb_codigo_parceiro_conjuge");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_codigo_parceiro_fiador")]
		public string urb_codigo_parceiro_fiador
		{
			get
			{
				return this.GetAttributeValue<string>("urb_codigo_parceiro_fiador");
			}
			set
			{
				this.OnPropertyChanging("urb_codigo_parceiro_fiador");
				this.SetAttributeValue("urb_codigo_parceiro_fiador", value);
				this.OnPropertyChanged("urb_codigo_parceiro_fiador");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_codigo_parceiro_procurador")]
		public string urb_codigo_parceiro_procurador
		{
			get
			{
				return this.GetAttributeValue<string>("urb_codigo_parceiro_procurador");
			}
			set
			{
				this.OnPropertyChanging("urb_codigo_parceiro_procurador");
				this.SetAttributeValue("urb_codigo_parceiro_procurador", value);
				this.OnPropertyChanged("urb_codigo_parceiro_procurador");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_codigo_parceiro_repr_vendas")]
		public string urb_codigo_parceiro_repr_vendas
		{
			get
			{
				return this.GetAttributeValue<string>("urb_codigo_parceiro_repr_vendas");
			}
			set
			{
				this.OnPropertyChanging("urb_codigo_parceiro_repr_vendas");
				this.SetAttributeValue("urb_codigo_parceiro_repr_vendas", value);
				this.OnPropertyChanged("urb_codigo_parceiro_repr_vendas");
			}
		}
	


		/// <summary>
		/// Código Grupo YCPF/YCPJ
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_codigo_sap")]
		public string urb_codigo_sap
		{
			get
			{
				return this.GetAttributeValue<string>("urb_codigo_sap");
			}
			set
			{
				this.OnPropertyChanging("urb_codigo_sap");
				this.SetAttributeValue("urb_codigo_sap", value);
				this.OnPropertyChanged("urb_codigo_sap");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_conta_bancaria")]
		public string urb_conta_bancaria
		{
			get
			{
				return this.GetAttributeValue<string>("urb_conta_bancaria");
			}
			set
			{
				this.OnPropertyChanging("urb_conta_bancaria");
				this.SetAttributeValue("urb_conta_bancaria", value);
				this.OnPropertyChanged("urb_conta_bancaria");
			}
		}
	


		/// <summary>
		/// Identificador único para Corretor associado a Cliente.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_corretorid")]
		public Microsoft.Xrm.Sdk.EntityReference urb_CorretorId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("urb_corretorid");
			}
			set
			{
				this.OnPropertyChanging("urb_CorretorId");
				this.SetAttributeValue("urb_corretorid", value);
				this.OnPropertyChanged("urb_CorretorId");
			}
		}
	



		/// <summary>
		/// Informe o CPF. Se o cliente existir na MRV os seus dados serão carregados.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_cpf")]
		public string urb_CPF
		{
			get
			{
				return this.GetAttributeValue<string>("urb_cpf");
			}
			set
			{
				this.OnPropertyChanging("urb_CPF");
				this.SetAttributeValue("urb_cpf", value);
				this.OnPropertyChanged("urb_CPF");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_data_expedicao_identidade")]
		public System.Nullable<System.DateTime> urb_data_expedicao_identidade
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("urb_data_expedicao_identidade");
			}
			set
			{
				this.OnPropertyChanging("urb_data_expedicao_identidade");
				this.SetAttributeValue("urb_data_expedicao_identidade", value);
				this.OnPropertyChanged("urb_data_expedicao_identidade");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_data_nascimento")]
		public System.Nullable<System.DateTime> urb_Data_Nascimento
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("urb_data_nascimento");
			}
			set
			{
				this.OnPropertyChanging("urb_Data_Nascimento");
				this.SetAttributeValue("urb_data_nascimento", value);
				this.OnPropertyChanged("urb_Data_Nascimento");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_empresa_trabalho")]
		public string urb_Empresa_trabalho
		{
			get
			{
				return this.GetAttributeValue<string>("urb_empresa_trabalho");
			}
			set
			{
				this.OnPropertyChanging("urb_Empresa_trabalho");
				this.SetAttributeValue("urb_empresa_trabalho", value);
				this.OnPropertyChanged("urb_Empresa_trabalho");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_endereco_nacional")]
		public System.Nullable<bool> urb_Endereco_Nacional
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("urb_endereco_nacional");
			}
			set
			{
				this.OnPropertyChanging("urb_Endereco_Nacional");
				this.SetAttributeValue("urb_endereco_nacional", value);
				this.OnPropertyChanged("urb_Endereco_Nacional");
			}
		}
	
		public virtual Enums.urb_Endereco_Nacional? urb_Endereco_NacionalEnum
		{
			get
			{
				return ((Enums.urb_Endereco_Nacional?)(EntityOptionSetEnum.GetEnum(this, "urb_endereco_nacional")));
			}
			set
			{
		       if (value.HasValue)
                    urb_Endereco_Nacional = ((int)value == 1);
                else                   
                    urb_Endereco_Nacional = null;
			}
		}


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_estado_civil")]
		public Microsoft.Xrm.Sdk.OptionSetValue urb_estado_civil
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("urb_estado_civil");
			}
			set
			{
				this.OnPropertyChanging("urb_estado_civil");
				this.SetAttributeValue("urb_estado_civil", value);
				this.OnPropertyChanged("urb_estado_civil");
			}
		}
	
		public virtual Enums.urb_estado_civil? urb_estado_civilEnum
		{
			get
			{
				return ((Enums.urb_estado_civil?)(EntityOptionSetEnum.GetEnum(this, "urb_estado_civil")));
			}
			set
			{
				urb_estado_civil = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Identificador único para Estado associado a Cliente.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_estado_enderecoid")]
		public Microsoft.Xrm.Sdk.EntityReference urb_Estado_EnderecoId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("urb_estado_enderecoid");
			}
			set
			{
				this.OnPropertyChanging("urb_Estado_EnderecoId");
				this.SetAttributeValue("urb_estado_enderecoid", value);
				this.OnPropertyChanged("urb_Estado_EnderecoId");
			}
		}
	



		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_estado_estrangeiro")]
		public string urb_estado_estrangeiro
		{
			get
			{
				return this.GetAttributeValue<string>("urb_estado_estrangeiro");
			}
			set
			{
				this.OnPropertyChanging("urb_estado_estrangeiro");
				this.SetAttributeValue("urb_estado_estrangeiro", value);
				this.OnPropertyChanged("urb_estado_estrangeiro");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_finalidade_aquisicao_lote")]
		public Microsoft.Xrm.Sdk.OptionSetValue urb_finalidade_aquisicao_lote
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("urb_finalidade_aquisicao_lote");
			}
			set
			{
				this.OnPropertyChanging("urb_finalidade_aquisicao_lote");
				this.SetAttributeValue("urb_finalidade_aquisicao_lote", value);
				this.OnPropertyChanged("urb_finalidade_aquisicao_lote");
			}
		}
	
		public virtual Enums.urb_finalidade_aquisicao_lote? urb_finalidade_aquisicao_loteEnum
		{
			get
			{
				return ((Enums.urb_finalidade_aquisicao_lote?)(EntityOptionSetEnum.GetEnum(this, "urb_finalidade_aquisicao_lote")));
			}
			set
			{
				urb_finalidade_aquisicao_lote = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_grau_instrucao")]
		public Microsoft.Xrm.Sdk.OptionSetValue urb_grau_instrucao
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("urb_grau_instrucao");
			}
			set
			{
				this.OnPropertyChanging("urb_grau_instrucao");
				this.SetAttributeValue("urb_grau_instrucao", value);
				this.OnPropertyChanged("urb_grau_instrucao");
			}
		}
	
		public virtual Enums.urb_grau_instrucao? urb_grau_instrucaoEnum
		{
			get
			{
				return ((Enums.urb_grau_instrucao?)(EntityOptionSetEnum.GetEnum(this, "urb_grau_instrucao")));
			}
			set
			{
				urb_grau_instrucao = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Identificador único para Grupo Cliente associado a Cliente.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_grupoclientesid")]
		public Microsoft.Xrm.Sdk.EntityReference urb_GrupoClientesId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("urb_grupoclientesid");
			}
			set
			{
				this.OnPropertyChanging("urb_GrupoClientesId");
				this.SetAttributeValue("urb_grupoclientesid", value);
				this.OnPropertyChanged("urb_GrupoClientesId");
			}
		}
	



		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_importado_mrv")]
		public System.Nullable<bool> urb_importado_mrv
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("urb_importado_mrv");
			}
			set
			{
				this.OnPropertyChanging("urb_importado_mrv");
				this.SetAttributeValue("urb_importado_mrv", value);
				this.OnPropertyChanged("urb_importado_mrv");
			}
		}
	
		public virtual Enums.urb_importado_mrv? urb_importado_mrvEnum
		{
			get
			{
				return ((Enums.urb_importado_mrv?)(EntityOptionSetEnum.GetEnum(this, "urb_importado_mrv")));
			}
			set
			{
		       if (value.HasValue)
                    urb_importado_mrv = ((int)value == 1);
                else                   
                    urb_importado_mrv = null;
			}
		}


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_interesse_finan_lote_contrucao")]
		public System.Nullable<bool> urb_interesse_finan_lote_contrucao
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("urb_interesse_finan_lote_contrucao");
			}
			set
			{
				this.OnPropertyChanging("urb_interesse_finan_lote_contrucao");
				this.SetAttributeValue("urb_interesse_finan_lote_contrucao", value);
				this.OnPropertyChanged("urb_interesse_finan_lote_contrucao");
			}
		}
	
		public virtual Enums.urb_interesse_finan_lote_contrucao? urb_interesse_finan_lote_contrucaoEnum
		{
			get
			{
				return ((Enums.urb_interesse_finan_lote_contrucao?)(EntityOptionSetEnum.GetEnum(this, "urb_interesse_finan_lote_contrucao")));
			}
			set
			{
		       if (value.HasValue)
                    urb_interesse_finan_lote_contrucao = ((int)value == 1);
                else                   
                    urb_interesse_finan_lote_contrucao = null;
			}
		}


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_logradouro_resumido")]
		public string urb_Logradouro_Resumido
		{
			get
			{
				return this.GetAttributeValue<string>("urb_logradouro_resumido");
			}
			set
			{
				this.OnPropertyChanging("urb_Logradouro_Resumido");
				this.SetAttributeValue("urb_logradouro_resumido", value);
				this.OnPropertyChanged("urb_Logradouro_Resumido");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_midia")]
		public Microsoft.Xrm.Sdk.OptionSetValue urb_midia
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("urb_midia");
			}
			set
			{
				this.OnPropertyChanging("urb_midia");
				this.SetAttributeValue("urb_midia", value);
				this.OnPropertyChanged("urb_midia");
			}
		}
	
		public virtual Enums.urb_midia? urb_midiaEnum
		{
			get
			{
				return ((Enums.urb_midia?)(EntityOptionSetEnum.GetEnum(this, "urb_midia")));
			}
			set
			{
				urb_midia = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_nacionalidade")]
		public Microsoft.Xrm.Sdk.OptionSetValue urb_nacionalidade
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("urb_nacionalidade");
			}
			set
			{
				this.OnPropertyChanging("urb_nacionalidade");
				this.SetAttributeValue("urb_nacionalidade", value);
				this.OnPropertyChanged("urb_nacionalidade");
			}
		}
	
		public virtual Enums.urb_nacionalidade? urb_nacionalidadeEnum
		{
			get
			{
				return ((Enums.urb_nacionalidade?)(EntityOptionSetEnum.GetEnum(this, "urb_nacionalidade")));
			}
			set
			{
				urb_nacionalidade = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Identificador único para Cidade associado a Cliente.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_naturalidadeid")]
		public Microsoft.Xrm.Sdk.EntityReference urb_NaturalidadeId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("urb_naturalidadeid");
			}
			set
			{
				this.OnPropertyChanging("urb_NaturalidadeId");
				this.SetAttributeValue("urb_naturalidadeid", value);
				this.OnPropertyChanged("urb_NaturalidadeId");
			}
		}
	



		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_nome_mae")]
		public string urb_Nome_mae
		{
			get
			{
				return this.GetAttributeValue<string>("urb_nome_mae");
			}
			set
			{
				this.OnPropertyChanging("urb_Nome_mae");
				this.SetAttributeValue("urb_nome_mae", value);
				this.OnPropertyChanged("urb_Nome_mae");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_nome_pai")]
		public string urb_nome_pai
		{
			get
			{
				return this.GetAttributeValue<string>("urb_nome_pai");
			}
			set
			{
				this.OnPropertyChanging("urb_nome_pai");
				this.SetAttributeValue("urb_nome_pai", value);
				this.OnPropertyChanged("urb_nome_pai");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_nome_referencia")]
		public string urb_nome_referencia
		{
			get
			{
				return this.GetAttributeValue<string>("urb_nome_referencia");
			}
			set
			{
				this.OnPropertyChanging("urb_nome_referencia");
				this.SetAttributeValue("urb_nome_referencia", value);
				this.OnPropertyChanged("urb_nome_referencia");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_num_filhos")]
		public System.Nullable<int> urb_num_filhos
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("urb_num_filhos");
			}
			set
			{
				this.OnPropertyChanging("urb_num_filhos");
				this.SetAttributeValue("urb_num_filhos", value);
				this.OnPropertyChanged("urb_num_filhos");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_numero")]
		public System.Nullable<int> urb_Numero
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("urb_numero");
			}
			set
			{
				this.OnPropertyChanging("urb_Numero");
				this.SetAttributeValue("urb_numero", value);
				this.OnPropertyChanged("urb_Numero");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_numero_identidade")]
		public string urb_numero_identidade
		{
			get
			{
				return this.GetAttributeValue<string>("urb_numero_identidade");
			}
			set
			{
				this.OnPropertyChanging("urb_numero_identidade");
				this.SetAttributeValue("urb_numero_identidade", value);
				this.OnPropertyChanged("urb_numero_identidade");
			}
		}
	


		/// <summary>
		/// Identificador único para Ocupação associado a Cliente.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_ocupaoid")]
		public Microsoft.Xrm.Sdk.EntityReference urb_OcupaoId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("urb_ocupaoid");
			}
			set
			{
				this.OnPropertyChanging("urb_OcupaoId");
				this.SetAttributeValue("urb_ocupaoid", value);
				this.OnPropertyChanged("urb_OcupaoId");
			}
		}
	



		/// <summary>
		/// Identificador único para Orgão Expedição associado a Cliente.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_orgao_expedicaoid")]
		public Microsoft.Xrm.Sdk.EntityReference urb_orgao_expedicaoid
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("urb_orgao_expedicaoid");
			}
			set
			{
				this.OnPropertyChanging("urb_orgao_expedicaoid");
				this.SetAttributeValue("urb_orgao_expedicaoid", value);
				this.OnPropertyChanged("urb_orgao_expedicaoid");
			}
		}
	



		/// <summary>
		/// Identificador único para País associado a Cliente.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_paisid")]
		public Microsoft.Xrm.Sdk.EntityReference urb_PaisId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("urb_paisid");
			}
			set
			{
				this.OnPropertyChanging("urb_PaisId");
				this.SetAttributeValue("urb_paisid", value);
				this.OnPropertyChanged("urb_PaisId");
			}
		}
	



		/// <summary>
		/// Indica se o cliente é parceiro construtor. Relatório específico será exibido na impressão de contrato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_parceiro_construtor")]
		public System.Nullable<bool> urb_parceiro_construtor
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("urb_parceiro_construtor");
			}
			set
			{
				this.OnPropertyChanging("urb_parceiro_construtor");
				this.SetAttributeValue("urb_parceiro_construtor", value);
				this.OnPropertyChanged("urb_parceiro_construtor");
			}
		}
	
		public virtual Enums.urb_parceiro_construtor? urb_parceiro_construtorEnum
		{
			get
			{
				return ((Enums.urb_parceiro_construtor?)(EntityOptionSetEnum.GetEnum(this, "urb_parceiro_construtor")));
			}
			set
			{
		       if (value.HasValue)
                    urb_parceiro_construtor = ((int)value == 1);
                else                   
                    urb_parceiro_construtor = null;
			}
		}


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_principal_atrativo_compra_lote")]
		public Microsoft.Xrm.Sdk.OptionSetValue urb_principal_atrativo_compra_lote
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("urb_principal_atrativo_compra_lote");
			}
			set
			{
				this.OnPropertyChanging("urb_principal_atrativo_compra_lote");
				this.SetAttributeValue("urb_principal_atrativo_compra_lote", value);
				this.OnPropertyChanged("urb_principal_atrativo_compra_lote");
			}
		}
	
		public virtual Enums.urb_principal_atrativo_compra_lote? urb_principal_atrativo_compra_loteEnum
		{
			get
			{
				return ((Enums.urb_principal_atrativo_compra_lote?)(EntityOptionSetEnum.GetEnum(this, "urb_principal_atrativo_compra_lote")));
			}
			set
			{
				urb_principal_atrativo_compra_lote = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_renda_pessoal")]
		public Microsoft.Xrm.Sdk.Money urb_renda_pessoal
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("urb_renda_pessoal");
			}
			set
			{
				this.OnPropertyChanging("urb_renda_pessoal");
				this.SetAttributeValue("urb_renda_pessoal", value);
				this.OnPropertyChanged("urb_renda_pessoal");
			}
		}
	


		/// <summary>
		/// Valor do Renda Pessoal em moeda base.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_renda_pessoal_base")]
		public Microsoft.Xrm.Sdk.Money urb_renda_pessoal_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("urb_renda_pessoal_base");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_score")]
		public System.Nullable<int> urb_score
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("urb_score");
			}
			set
			{
				this.OnPropertyChanging("urb_score");
				this.SetAttributeValue("urb_score", value);
				this.OnPropertyChanged("urb_score");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_sexo")]
		public Microsoft.Xrm.Sdk.OptionSetValue urb_Sexo
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("urb_sexo");
			}
			set
			{
				this.OnPropertyChanging("urb_Sexo");
				this.SetAttributeValue("urb_sexo", value);
				this.OnPropertyChanged("urb_Sexo");
			}
		}
	
		public virtual Enums.urb_Sexo? urb_SexoEnum
		{
			get
			{
				return ((Enums.urb_Sexo?)(EntityOptionSetEnum.GetEnum(this, "urb_sexo")));
			}
			set
			{
				urb_Sexo = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_taxa_inadimplencia")]
		public System.Nullable<decimal> urb_taxa_inadimplencia
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("urb_taxa_inadimplencia");
			}
			set
			{
				this.OnPropertyChanging("urb_taxa_inadimplencia");
				this.SetAttributeValue("urb_taxa_inadimplencia", value);
				this.OnPropertyChanged("urb_taxa_inadimplencia");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_telefone_enriquecimento_1")]
		public string urb_telefone_enriquecimento_1
		{
			get
			{
				return this.GetAttributeValue<string>("urb_telefone_enriquecimento_1");
			}
			set
			{
				this.OnPropertyChanging("urb_telefone_enriquecimento_1");
				this.SetAttributeValue("urb_telefone_enriquecimento_1", value);
				this.OnPropertyChanged("urb_telefone_enriquecimento_1");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_telefone_enriquecimento_2")]
		public string urb_telefone_enriquecimento_2
		{
			get
			{
				return this.GetAttributeValue<string>("urb_telefone_enriquecimento_2");
			}
			set
			{
				this.OnPropertyChanging("urb_telefone_enriquecimento_2");
				this.SetAttributeValue("urb_telefone_enriquecimento_2", value);
				this.OnPropertyChanged("urb_telefone_enriquecimento_2");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_telefone_enriquecimento_3")]
		public string urb_telefone_enriquecimento_3
		{
			get
			{
				return this.GetAttributeValue<string>("urb_telefone_enriquecimento_3");
			}
			set
			{
				this.OnPropertyChanging("urb_telefone_enriquecimento_3");
				this.SetAttributeValue("urb_telefone_enriquecimento_3", value);
				this.OnPropertyChanged("urb_telefone_enriquecimento_3");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_telefone_enriquecimento_4")]
		public string urb_telefone_enriquecimento_4
		{
			get
			{
				return this.GetAttributeValue<string>("urb_telefone_enriquecimento_4");
			}
			set
			{
				this.OnPropertyChanging("urb_telefone_enriquecimento_4");
				this.SetAttributeValue("urb_telefone_enriquecimento_4", value);
				this.OnPropertyChanged("urb_telefone_enriquecimento_4");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_telefone_enriquecimento_5")]
		public string urb_telefone_enriquecimento_5
		{
			get
			{
				return this.GetAttributeValue<string>("urb_telefone_enriquecimento_5");
			}
			set
			{
				this.OnPropertyChanging("urb_telefone_enriquecimento_5");
				this.SetAttributeValue("urb_telefone_enriquecimento_5", value);
				this.OnPropertyChanged("urb_telefone_enriquecimento_5");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_telefone_referencia")]
		public string urb_telefone_referencia
		{
			get
			{
				return this.GetAttributeValue<string>("urb_telefone_referencia");
			}
			set
			{
				this.OnPropertyChanging("urb_telefone_referencia");
				this.SetAttributeValue("urb_telefone_referencia", value);
				this.OnPropertyChanged("urb_telefone_referencia");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_tipo_cliente")]
		public Microsoft.Xrm.Sdk.OptionSetValue urb_tipo_cliente
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("urb_tipo_cliente");
			}
			set
			{
				this.OnPropertyChanging("urb_tipo_cliente");
				this.SetAttributeValue("urb_tipo_cliente", value);
				this.OnPropertyChanged("urb_tipo_cliente");
			}
		}
	
		public virtual Enums.urb_tipo_cliente? urb_tipo_clienteEnum
		{
			get
			{
				return ((Enums.urb_tipo_cliente?)(EntityOptionSetEnum.GetEnum(this, "urb_tipo_cliente")));
			}
			set
			{
				urb_tipo_cliente = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_tipo_conta")]
		public Microsoft.Xrm.Sdk.OptionSetValue urb_tipo_conta
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("urb_tipo_conta");
			}
			set
			{
				this.OnPropertyChanging("urb_tipo_conta");
				this.SetAttributeValue("urb_tipo_conta", value);
				this.OnPropertyChanged("urb_tipo_conta");
			}
		}
	
		public virtual Enums.urb_tipo_conta? urb_tipo_contaEnum
		{
			get
			{
				return ((Enums.urb_tipo_conta?)(EntityOptionSetEnum.GetEnum(this, "urb_tipo_conta")));
			}
			set
			{
				urb_tipo_conta = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_tipo_logradouro")]
		public Microsoft.Xrm.Sdk.OptionSetValue urb_Tipo_Logradouro
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("urb_tipo_logradouro");
			}
			set
			{
				this.OnPropertyChanging("urb_Tipo_Logradouro");
				this.SetAttributeValue("urb_tipo_logradouro", value);
				this.OnPropertyChanged("urb_Tipo_Logradouro");
			}
		}
	
		public virtual Enums.urb_Tipo_Logradouro? urb_Tipo_LogradouroEnum
		{
			get
			{
				return ((Enums.urb_Tipo_Logradouro?)(EntityOptionSetEnum.GetEnum(this, "urb_tipo_logradouro")));
			}
			set
			{
				urb_Tipo_Logradouro = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_tipo_renda_cliente")]
		public Microsoft.Xrm.Sdk.OptionSetValue urb_tipo_renda_cliente
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("urb_tipo_renda_cliente");
			}
			set
			{
				this.OnPropertyChanging("urb_tipo_renda_cliente");
				this.SetAttributeValue("urb_tipo_renda_cliente", value);
				this.OnPropertyChanged("urb_tipo_renda_cliente");
			}
		}
	
		public virtual Enums.urb_tipo_renda_cliente? urb_tipo_renda_clienteEnum
		{
			get
			{
				return ((Enums.urb_tipo_renda_cliente?)(EntityOptionSetEnum.GetEnum(this, "urb_tipo_renda_cliente")));
			}
			set
			{
				urb_tipo_renda_cliente = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Identificador único para Estado associado a Cliente.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_uf_expedicaoid")]
		public Microsoft.Xrm.Sdk.EntityReference urb_uf_expedicaoid
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("urb_uf_expedicaoid");
			}
			set
			{
				this.OnPropertyChanging("urb_uf_expedicaoid");
				this.SetAttributeValue("urb_uf_expedicaoid", value);
				this.OnPropertyChanged("urb_uf_expedicaoid");
			}
		}
	



		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_vinculo_referencia")]
		public Microsoft.Xrm.Sdk.OptionSetValue urb_vinculo_referencia
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("urb_vinculo_referencia");
			}
			set
			{
				this.OnPropertyChanging("urb_vinculo_referencia");
				this.SetAttributeValue("urb_vinculo_referencia", value);
				this.OnPropertyChanged("urb_vinculo_referencia");
			}
		}
	
		public virtual Enums.urb_vinculo_referencia? urb_vinculo_referenciaEnum
		{
			get
			{
				return ((Enums.urb_vinculo_referencia?)(EntityOptionSetEnum.GetEnum(this, "urb_vinculo_referencia")));
			}
			set
			{
				urb_vinculo_referencia = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Código de fuso horário em uso quando o registro foi criado.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
	


		/// <summary>
		/// Número de versão da conta.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
	


		/// <summary>
		/// Digite a URL do site da conta para obter detalhes sobre o perfil da empresa.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("websiteurl")]
		public string WebSiteURL
		{
			get
			{
				return this.GetAttributeValue<string>("websiteurl");
			}
			set
			{
				this.OnPropertyChanging("WebSiteURL");
				this.SetAttributeValue("websiteurl", value);
				this.OnPropertyChanged("WebSiteURL");
			}
		}
	


		/// <summary>
		/// Digite a ortografia fonética do nome da empresa, se especificado em japonês, para garantir que o nome seja pronunciado corretamente em telefonemas e outras comunicações.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yominame")]
		public string YomiName
		{
			get
			{
				return this.GetAttributeValue<string>("yominame");
			}
			set
			{
				this.OnPropertyChanging("YomiName");
				this.SetAttributeValue("yominame", value);
				this.OnPropertyChanged("YomiName");
			}
		}
	


		
		/// <summary>
		/// 1:N lead_customer_accounts
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_customer_accounts")]
		public System.Collections.Generic.IEnumerable<Lead> lead_customer_accounts
		{
			get
			{
				return this.GetRelatedEntities<Lead>("lead_customer_accounts", null);
			}
			set
			{
				this.OnPropertyChanging("lead_customer_accounts");
				this.SetRelatedEntities<Lead>("lead_customer_accounts", null, value);
				this.OnPropertyChanged("lead_customer_accounts");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lead_customer_accounts(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lead_customer_accounts");
		}

		
		/// <summary>
		/// 1:N opportunity_customer_accounts
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_customer_accounts")]
		public System.Collections.Generic.IEnumerable<Opportunity> opportunity_customer_accounts
		{
			get
			{
				return this.GetRelatedEntities<Opportunity>("opportunity_customer_accounts", null);
			}
			set
			{
				this.OnPropertyChanging("opportunity_customer_accounts");
				this.SetRelatedEntities<Opportunity>("opportunity_customer_accounts", null, value);
				this.OnPropertyChanged("opportunity_customer_accounts");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_opportunity_customer_accounts(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "opportunity_customer_accounts");
		}

		
		/// <summary>
		/// 1:N account_master_account
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_master_account", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<Account> Referencedaccount_master_account
		{
			get
			{
				return this.GetRelatedEntities<Account>("account_master_account", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referencedaccount_master_account");
				this.SetRelatedEntities<Account>("account_master_account", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedaccount_master_account");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_account_master_account(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "account_master_account");
		}

		
		/// <summary>
		/// 1:N msdyn_account_account_BillingAccount
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_account_account_BillingAccount", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<Account> Referencedmsdyn_account_account_BillingAccount
		{
			get
			{
				return this.GetRelatedEntities<Account>("msdyn_account_account_BillingAccount", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referencedmsdyn_account_account_BillingAccount");
				this.SetRelatedEntities<Account>("msdyn_account_account_BillingAccount", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedmsdyn_account_account_BillingAccount");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_msdyn_account_account_BillingAccount(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "msdyn_account_account_BillingAccount");
		}

		
		/// <summary>
		/// 1:N account_parent_account
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<Account> Referencedaccount_parent_account
		{
			get
			{
				return this.GetRelatedEntities<Account>("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referencedaccount_parent_account");
				this.SetRelatedEntities<Account>("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedaccount_parent_account");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_account_parent_account(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "account_parent_account");
		}

		
		/// <summary>
		/// 1:N lead_parent_account
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_parent_account")]
		public System.Collections.Generic.IEnumerable<Lead> lead_parent_account
		{
			get
			{
				return this.GetRelatedEntities<Lead>("lead_parent_account", null);
			}
			set
			{
				this.OnPropertyChanging("lead_parent_account");
				this.SetRelatedEntities<Lead>("lead_parent_account", null, value);
				this.OnPropertyChanged("lead_parent_account");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lead_parent_account(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lead_parent_account");
		}

		
		/// <summary>
		/// 1:N opportunity_parent_account
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_parent_account")]
		public System.Collections.Generic.IEnumerable<Opportunity> opportunity_parent_account
		{
			get
			{
				return this.GetRelatedEntities<Opportunity>("opportunity_parent_account", null);
			}
			set
			{
				this.OnPropertyChanging("opportunity_parent_account");
				this.SetRelatedEntities<Opportunity>("opportunity_parent_account", null, value);
				this.OnPropertyChanged("opportunity_parent_account");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_opportunity_parent_account(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "opportunity_parent_account");
		}

		
		/// <summary>
		/// 1:N contact_customer_accounts
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_customer_accounts")]
		public System.Collections.Generic.IEnumerable<Contact> contact_customer_accounts
		{
			get
			{
				return this.GetRelatedEntities<Contact>("contact_customer_accounts", null);
			}
			set
			{
				this.OnPropertyChanging("contact_customer_accounts");
				this.SetRelatedEntities<Contact>("contact_customer_accounts", null, value);
				this.OnPropertyChanged("contact_customer_accounts");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_contact_customer_accounts(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "contact_customer_accounts");
		}

		
		/// <summary>
		/// 1:N account_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_activity_parties")]
		public System.Collections.Generic.IEnumerable<ActivityParty> account_activity_parties
		{
			get
			{
				return this.GetRelatedEntities<ActivityParty>("account_activity_parties", null);
			}
			set
			{
				this.OnPropertyChanging("account_activity_parties");
				this.SetRelatedEntities<ActivityParty>("account_activity_parties", null, value);
				this.OnPropertyChanged("account_activity_parties");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_account_activity_parties(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "account_activity_parties");
		}

		
		/// <summary>
		/// N:1 lk_accountbase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_createdby")]
		public SystemUser lk_accountbase_createdby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_accountbase_createdby", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_accountbase_createdby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_accountbase_createdby");
		}

		
		/// <summary>
		/// N:1 lk_accountbase_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_createdonbehalfby")]
		public SystemUser lk_accountbase_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_accountbase_createdonbehalfby", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_accountbase_createdonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_accountbase_createdonbehalfby");
		}

		
		/// <summary>
		/// N:1 account_master_account
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("masterid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_master_account", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public Account Referencingaccount_master_account
		{
			get
			{
				return this.GetRelatedEntity<Account>("account_master_account", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_account_master_account(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "account_master_account");
		}

		
		/// <summary>
		/// N:1 lk_accountbase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_modifiedby")]
		public SystemUser lk_accountbase_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_accountbase_modifiedby", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_accountbase_modifiedby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_accountbase_modifiedby");
		}

		
		/// <summary>
		/// N:1 lk_accountbase_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_modifiedonbehalfby")]
		public SystemUser lk_accountbase_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_accountbase_modifiedonbehalfby", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_accountbase_modifiedonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_accountbase_modifiedonbehalfby");
		}

		
		/// <summary>
		/// N:1 msdyn_account_account_BillingAccount
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_billingaccount")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_account_account_BillingAccount", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public Account Referencingmsdyn_account_account_BillingAccount
		{
			get
			{
				return this.GetRelatedEntity<Account>("msdyn_account_account_BillingAccount", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
			set
			{
				this.OnPropertyChanging("Referencingmsdyn_account_account_BillingAccount");
				this.SetRelatedEntity<Account>("msdyn_account_account_BillingAccount", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
				this.OnPropertyChanged("Referencingmsdyn_account_account_BillingAccount");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_msdyn_account_account_BillingAccount(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "msdyn_account_account_BillingAccount");
		}

		
		/// <summary>
		/// N:1 account_originating_lead
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("originatingleadid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_originating_lead")]
		public Lead account_originating_lead
		{
			get
			{
				return this.GetRelatedEntity<Lead>("account_originating_lead", null);
			}
			set
			{
				this.OnPropertyChanging("account_originating_lead");
				this.SetRelatedEntity<Lead>("account_originating_lead", null, value);
				this.OnPropertyChanged("account_originating_lead");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_account_originating_lead(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "account_originating_lead");
		}

		
		/// <summary>
		/// N:1 business_unit_accounts
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_accounts")]
		public BusinessUnit business_unit_accounts
		{
			get
			{
				return this.GetRelatedEntity<BusinessUnit>("business_unit_accounts", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_business_unit_accounts(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "business_unit_accounts");
		}

		
		/// <summary>
		/// N:1 team_accounts
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_accounts")]
		public Team team_accounts
		{
			get
			{
				return this.GetRelatedEntity<Team>("team_accounts", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_team_accounts(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "team_accounts");
		}

		
		/// <summary>
		/// N:1 user_accounts
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_accounts")]
		public SystemUser user_accounts
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("user_accounts", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_user_accounts(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "user_accounts");
		}

		
		/// <summary>
		/// N:1 account_parent_account
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentaccountid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public Account Referencingaccount_parent_account
		{
			get
			{
				return this.GetRelatedEntity<Account>("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
			set
			{
				this.OnPropertyChanging("Referencingaccount_parent_account");
				this.SetRelatedEntity<Account>("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
				this.OnPropertyChanged("Referencingaccount_parent_account");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_account_parent_account(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "account_parent_account");
		}

		
		/// <summary>
		/// N:1 system_user_accounts
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredsystemuserid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_accounts")]
		public SystemUser system_user_accounts
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("system_user_accounts", null);
			}
			set
			{
				this.OnPropertyChanging("system_user_accounts");
				this.SetRelatedEntity<SystemUser>("system_user_accounts", null, value);
				this.OnPropertyChanged("system_user_accounts");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_system_user_accounts(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "system_user_accounts");
		}

		
		/// <summary>
		/// N:1 account_primary_contact
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primarycontactid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_primary_contact")]
		public Contact account_primary_contact
		{
			get
			{
				return this.GetRelatedEntity<Contact>("account_primary_contact", null);
			}
			set
			{
				this.OnPropertyChanging("account_primary_contact");
				this.SetRelatedEntity<Contact>("account_primary_contact", null, value);
				this.OnPropertyChanged("account_primary_contact");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_account_primary_contact(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "account_primary_contact");
		}

		
		/// <summary>
		/// N:1 transactioncurrency_account
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_account")]
		public TransactionCurrency transactioncurrency_account
		{
			get
			{
				return this.GetRelatedEntity<TransactionCurrency>("transactioncurrency_account", null);
			}
			set
			{
				this.OnPropertyChanging("transactioncurrency_account");
				this.SetRelatedEntity<TransactionCurrency>("transactioncurrency_account", null, value);
				this.OnPropertyChanged("transactioncurrency_account");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_transactioncurrency_account(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "transactioncurrency_account");
		}

		
		/// <summary>
		/// N:N accountleads_association
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("accountleads_association")]
		public System.Collections.Generic.IEnumerable<Lead> accountleads_association
		{
			get
			{
				return this.GetRelatedEntities<Lead>("accountleads_association", null);
			}
			set
			{
				this.OnPropertyChanging("accountleads_association");
				this.SetRelatedEntities<Lead>("accountleads_association", null, value);
				this.OnPropertyChanged("accountleads_association");
			}
		}
		/// <summary>
		/// Loads this N:N relationship into the object 
		/// </summary>
        public void Load_accountleads_association(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "accountleads_association");
		}




		public class Enums 
		{
			[DataContractAttribute]
			public enum AccountCategoryCode 
			{
				[EnumMemberAttribute]
				ClientePreferencial = 1,
				[EnumMemberAttribute]
				Padrao = 2,
			}		
			[DataContractAttribute]
			public enum AccountClassificationCode 
			{
				[EnumMemberAttribute]
				Prospect = 1,
				[EnumMemberAttribute]
				Cliente = 169070000,
			}		
			[DataContractAttribute]
			public enum AccountRatingCode 
			{
				[EnumMemberAttribute]
				Prospect = 1,
				[EnumMemberAttribute]
				Cliente = 169070000,
			}		
			[DataContractAttribute]
			public enum Address1_AddressTypeCode 
			{
				[EnumMemberAttribute]
				Fatura = 1,
				[EnumMemberAttribute]
				Remessa = 2,
				[EnumMemberAttribute]
				Primario = 3,
				[EnumMemberAttribute]
				Outro = 4,
			}		
			[DataContractAttribute]
			public enum Address1_FreightTermsCode 
			{
				[EnumMemberAttribute]
				FOB = 1,
				[EnumMemberAttribute]
				FreteGratuito = 2,
			}		
			[DataContractAttribute]
			public enum Address1_ShippingMethodCode 
			{
				[EnumMemberAttribute]
				DHL = 2,
				[EnumMemberAttribute]
				FedEx = 3,
				[EnumMemberAttribute]
				UPS = 4,
				[EnumMemberAttribute]
				CorreioComum = 5,
				[EnumMemberAttribute]
				ClienteRetiranoLocal = 7,
				[EnumMemberAttribute]
				Transportadora = 17,
				[EnumMemberAttribute]
				SEDEX = 23,
			}		
			[DataContractAttribute]
			public enum Address2_AddressTypeCode 
			{
				[EnumMemberAttribute]
				ValorPadrao = 1,
			}		
			[DataContractAttribute]
			public enum Address2_FreightTermsCode 
			{
				[EnumMemberAttribute]
				ValorPadrao = 1,
			}		
			[DataContractAttribute]
			public enum Address2_ShippingMethodCode 
			{
				[EnumMemberAttribute]
				ValorPadrao = 1,
			}		
			[DataContractAttribute]
			public enum BusinessTypeCode 
			{
				[EnumMemberAttribute]
				ValorPadrao = 1,
			}		
			[DataContractAttribute]
			public enum CreditOnHold 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum CustomerSizeCode 
			{
				[EnumMemberAttribute]
				ValorPadrao = 1,
			}		
			[DataContractAttribute]
			public enum CustomerTypeCode 
			{
				[EnumMemberAttribute]
				Concorrente = 1,
				[EnumMemberAttribute]
				Consultor = 2,
				[EnumMemberAttribute]
				Cliente = 3,
				[EnumMemberAttribute]
				Investidor = 4,
				[EnumMemberAttribute]
				Parceiro = 5,
				[EnumMemberAttribute]
				Influenciador = 6,
				[EnumMemberAttribute]
				Imprensa = 7,
				[EnumMemberAttribute]
				ClientePotencial = 8,
				[EnumMemberAttribute]
				Revendedor = 9,
				[EnumMemberAttribute]
				Fornecedor = 10,
				[EnumMemberAttribute]
				Fornecedordeservicos = 11,
				[EnumMemberAttribute]
				Outro = 12,
			}		
			[DataContractAttribute]
			public enum DoNotBulkEMail 
			{
				[EnumMemberAttribute]
				NaoPermitir = 1,
				[EnumMemberAttribute]
				Permitir = 0,
			}		
			[DataContractAttribute]
			public enum DoNotBulkPostalMail 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum DoNotEMail 
			{
				[EnumMemberAttribute]
				NaoPermitir = 1,
				[EnumMemberAttribute]
				Permitir = 0,
			}		
			[DataContractAttribute]
			public enum DoNotFax 
			{
				[EnumMemberAttribute]
				NaoPermitir = 1,
				[EnumMemberAttribute]
				Permitir = 0,
			}		
			[DataContractAttribute]
			public enum DoNotPhone 
			{
				[EnumMemberAttribute]
				NaoPermitir = 1,
				[EnumMemberAttribute]
				Permitir = 0,
			}		
			[DataContractAttribute]
			public enum DoNotPostalMail 
			{
				[EnumMemberAttribute]
				NaoPermitir = 1,
				[EnumMemberAttribute]
				Permitir = 0,
			}		
			[DataContractAttribute]
			public enum DoNotSendMM 
			{
				[EnumMemberAttribute]
				NaoEnviar = 1,
				[EnumMemberAttribute]
				Enviar = 0,
			}		
			[DataContractAttribute]
			public enum FollowEmail 
			{
				[EnumMemberAttribute]
				Permitir = 1,
				[EnumMemberAttribute]
				NaoPermitir = 0,
			}		
			[DataContractAttribute]
			public enum IndustryCode 
			{
				[EnumMemberAttribute]
				VeiculosePecas = 122,
				[EnumMemberAttribute]
				Seguros = 20,
				[EnumMemberAttribute]
				ComercioAtacadista = 33,
				[EnumMemberAttribute]
				Eletroeletronico = 48,
				[EnumMemberAttribute]
				Agricultura = 49,
				[EnumMemberAttribute]
				Mineracao = 50,
				[EnumMemberAttribute]
				Educacao = 67,
				[EnumMemberAttribute]
				ComercioVarejista = 72,
				[EnumMemberAttribute]
				TecnologiadaInformacao = 74,
				[EnumMemberAttribute]
				ServicosMedicos = 78,
				[EnumMemberAttribute]
				Alimentos = 79,
				[EnumMemberAttribute]
				Bancos = 81,
				[EnumMemberAttribute]
				Metalurgia = 89,
				[EnumMemberAttribute]
				IndustriaAutomobilistica = 91,
				[EnumMemberAttribute]
				TransporteseLogistica = 92,
				[EnumMemberAttribute]
				TextilCouroeVestuario = 93,
				[EnumMemberAttribute]
				Siderurgia = 94,
				[EnumMemberAttribute]
				EnergiaEletrica = 102,
				[EnumMemberAttribute]
				AguaeSaneamento = 110,
				[EnumMemberAttribute]
				BebidaseFumo = 111,
				[EnumMemberAttribute]
				ComercioExterior = 112,
				[EnumMemberAttribute]
				ConstrucaoCivil = 113,
				[EnumMemberAttribute]
				Farmaceutica = 114,
				[EnumMemberAttribute]
				Holdings = 115,
				[EnumMemberAttribute]
				MaterialdeConstrucaoeDecoracao = 116,
				[EnumMemberAttribute]
				Mecanica = 117,
				[EnumMemberAttribute]
				PapeleCelulose = 118,
				[EnumMemberAttribute]
				PlasticoseBorracha = 119,
				[EnumMemberAttribute]
				QuimicaePetroquimica = 120,
				[EnumMemberAttribute]
				ServicosEspecializados = 121,
				[EnumMemberAttribute]
				Telecomunicacoes = 135,
			}		
			[DataContractAttribute]
			public enum IsPrivate 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum MarketingOnly 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum Merged 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum msdyn_TaxExempt 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum msdyn_TravelChargeType 
			{
				[EnumMemberAttribute]
				PorHora = 690970000,
				[EnumMemberAttribute]
				Quilometragem = 690970001,
				[EnumMemberAttribute]
				Corrigido = 690970002,
				[EnumMemberAttribute]
				Nenhum = 690970003,
			}		
			[DataContractAttribute]
			public enum OwnershipCode 
			{
				[EnumMemberAttribute]
				Publica = 1,
				[EnumMemberAttribute]
				Particular = 2,
				[EnumMemberAttribute]
				CapitalMisto = 12,
			}		
			[DataContractAttribute]
			public enum ParticipatesInWorkflow 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum PaymentTermsCode 
			{
				[EnumMemberAttribute]
				Vencimentoem30dias = 1,
				[EnumMemberAttribute]
				Vencimentoem45dias = 3,
				[EnumMemberAttribute]
				Vencimentoem60dias = 4,
				[EnumMemberAttribute]
				AVista = 10,
			}		
			[DataContractAttribute]
			public enum PreferredAppointmentDayCode 
			{
				[EnumMemberAttribute]
				Domingo = 0,
				[EnumMemberAttribute]
				Segundafeira = 1,
				[EnumMemberAttribute]
				Tercafeira = 2,
				[EnumMemberAttribute]
				Quartafeira = 3,
				[EnumMemberAttribute]
				Quintafeira = 4,
				[EnumMemberAttribute]
				Sextafeira = 5,
				[EnumMemberAttribute]
				Sabado = 6,
			}		
			[DataContractAttribute]
			public enum PreferredAppointmentTimeCode 
			{
				[EnumMemberAttribute]
				Manha = 1,
				[EnumMemberAttribute]
				Tarde = 2,
				[EnumMemberAttribute]
				Noite = 3,
			}		
			[DataContractAttribute]
			public enum PreferredContactMethodCode 
			{
				[EnumMemberAttribute]
				Qualqueruma = 1,
				[EnumMemberAttribute]
				Email = 2,
				[EnumMemberAttribute]
				Telefone = 3,
				[EnumMemberAttribute]
				Fax = 4,
				[EnumMemberAttribute]
				Correio = 5,
			}		
			[DataContractAttribute]
			public enum ShippingMethodCode 
			{
				[EnumMemberAttribute]
				ValorPadrao = 1,
			}		
			[DataContractAttribute]
			public enum StateCode 
			{
				[EnumMemberAttribute]
				Ativa = 0,
				[EnumMemberAttribute]
				Inativa = 1,
			}		
			[DataContractAttribute]
			public enum StatusCode 
			{
				[EnumMemberAttribute]
				Ativa = 1,
				[EnumMemberAttribute]
				Inativa = 2,
			}		
			[DataContractAttribute]
			public enum TerritoryCode 
			{
				[EnumMemberAttribute]
				ValorPadrao = 1,
			}		
			[DataContractAttribute]
			public enum urb_cidade_interesse 
			{
				[EnumMemberAttribute]
				Araraquara = 169070000,
				[EnumMemberAttribute]
				AlvaresMachado = 169070007,
				[EnumMemberAttribute]
				CamposdosGoytacazes = 169070001,
				[EnumMemberAttribute]
				FeiradeSantana = 169070004,
				[EnumMemberAttribute]
				Natal = 169070002,
				[EnumMemberAttribute]
				RibeiraoPreto = 169070005,
				[EnumMemberAttribute]
				SaoCarlos = 169070006,
				[EnumMemberAttribute]
				Outros = 169070003,
			}		
			[DataContractAttribute]
			public enum urb_classe_risco 
			{
				[EnumMemberAttribute]
				A = 169070000,
				[EnumMemberAttribute]
				B = 169070001,
				[EnumMemberAttribute]
				C = 169070002,
				[EnumMemberAttribute]
				D = 169070003,
				[EnumMemberAttribute]
				E = 169070004,
				[EnumMemberAttribute]
				F = 169070005,
			}		
			[DataContractAttribute]
			public enum urb_cliente_possui_outro_imovel 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum urb_Endereco_Nacional 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum urb_estado_civil 
			{
				[EnumMemberAttribute]
				Solteiroa = 169070000,
				[EnumMemberAttribute]
				Casadoa = 169070001,
				[EnumMemberAttribute]
				Viuvoa = 169070002,
				[EnumMemberAttribute]
				Divorciadoa = 169070003,
				[EnumMemberAttribute]
				Separadoa = 169070004,
			}		
			[DataContractAttribute]
			public enum urb_finalidade_aquisicao_lote 
			{
				[EnumMemberAttribute]
				Moradia = 169070000,
				[EnumMemberAttribute]
				Investimento = 169070001,
				[EnumMemberAttribute]
				Outros = 169070002,
			}		
			[DataContractAttribute]
			public enum urb_grau_instrucao 
			{
				[EnumMemberAttribute]
				Analfabeto = 169070000,
				[EnumMemberAttribute]
				Ensinofundamentalincompleto = 169070001,
				[EnumMemberAttribute]
				Ensinofundamentalcompleto = 169070002,
				[EnumMemberAttribute]
				Ensinomedioincompleto = 169070009,
				[EnumMemberAttribute]
				Ensinomediocompleto = 169070003,
				[EnumMemberAttribute]
				Superiorincompleto = 169070004,
				[EnumMemberAttribute]
				Superiorcompleto = 169070005,
				[EnumMemberAttribute]
				Especializacao = 169070006,
				[EnumMemberAttribute]
				Mestrado = 169070007,
				[EnumMemberAttribute]
				Doutorado = 169070008,
			}		
			[DataContractAttribute]
			public enum urb_importado_mrv 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum urb_interesse_finan_lote_contrucao 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum urb_midia 
			{
				[EnumMemberAttribute]
				Folheto = 169070004,
				[EnumMemberAttribute]
				TV = 169070015,
				[EnumMemberAttribute]
				Radio = 169070012,
				[EnumMemberAttribute]
				Jornal = 169070007,
				[EnumMemberAttribute]
				Revista = 169070016,
				[EnumMemberAttribute]
				Outdoor = 169070013,
				[EnumMemberAttribute]
				BackBus = 169070001,
				[EnumMemberAttribute]
				Faixa = 169070003,
				[EnumMemberAttribute]
				Internet = 169070006,
				[EnumMemberAttribute]
				SMS = 169070009,
				[EnumMemberAttribute]
				WhatsApp = 169070010,
				[EnumMemberAttribute]
				Indicacao = 169070005,
				[EnumMemberAttribute]
				Telemarketing = 169070014,
				[EnumMemberAttribute]
				AtivoCorretor = 169070020,
				[EnumMemberAttribute]
				Pirata = 169070018,
				[EnumMemberAttribute]
				PlantaodeVendas = 169070011,
				[EnumMemberAttribute]
				EMail = 169070002,
				[EnumMemberAttribute]
				Chat = 169070000,
			}		
			[DataContractAttribute]
			public enum urb_nacionalidade 
			{
				[EnumMemberAttribute]
				Brasileiroa = 169070000,
				[EnumMemberAttribute]
				Estrangeiroa = 169070001,
			}		
			[DataContractAttribute]
			public enum urb_parceiro_construtor 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum urb_principal_atrativo_compra_lote 
			{
				[EnumMemberAttribute]
				Areadelazerpracasareaverde = 169070001,
				[EnumMemberAttribute]
				Localizacaodoterreno = 169070000,
				[EnumMemberAttribute]
				Metragemdolote = 169070004,
				[EnumMemberAttribute]
				Precocondicoesdepagamento = 169070002,
				[EnumMemberAttribute]
				SolidezdamarcaUrbamaisMRV = 169070003,
			}		
			[DataContractAttribute]
			public enum urb_Sexo 
			{
				[EnumMemberAttribute]
				Masculino = 169070000,
				[EnumMemberAttribute]
				Feminino = 169070001,
			}		
			[DataContractAttribute]
			public enum urb_tipo_cliente 
			{
				[EnumMemberAttribute]
				PFisica = 169070000,
				[EnumMemberAttribute]
				PJuridica = 169070001,
			}		
			[DataContractAttribute]
			public enum urb_tipo_conta 
			{
				[EnumMemberAttribute]
				Corrente = 169070000,
				[EnumMemberAttribute]
				Poupanca = 169070001,
			}		
			[DataContractAttribute]
			public enum urb_Tipo_Logradouro 
			{
				[EnumMemberAttribute]
				AEROPORTO = 169070000,
				[EnumMemberAttribute]
				ALAMEDA = 169070001,
				[EnumMemberAttribute]
				AREA = 169070002,
				[EnumMemberAttribute]
				AVENIDA = 169070003,
				[EnumMemberAttribute]
				CAMPO = 169070004,
				[EnumMemberAttribute]
				CAMINHO = 169070028,
				[EnumMemberAttribute]
				CHACARA = 169070005,
				[EnumMemberAttribute]
				COLONIA = 169070006,
				[EnumMemberAttribute]
				CONDOMINIO = 169070007,
				[EnumMemberAttribute]
				CONJUNTO = 169070008,
				[EnumMemberAttribute]
				DISTRITO = 169070009,
				[EnumMemberAttribute]
				EXPLANADA = 169070010,
				[EnumMemberAttribute]
				ESTACAO = 169070011,
				[EnumMemberAttribute]
				ESTRADA = 169070012,
				[EnumMemberAttribute]
				FAVELA = 169070013,
				[EnumMemberAttribute]
				FAZENDA = 169070014,
				[EnumMemberAttribute]
				FEIRA = 169070015,
				[EnumMemberAttribute]
				JARDIM = 169070016,
				[EnumMemberAttribute]
				LADEIRA = 169070017,
				[EnumMemberAttribute]
				LAGO = 169070018,
				[EnumMemberAttribute]
				LAGOA = 169070019,
				[EnumMemberAttribute]
				LOTEAMENTO = 169070020,
				[EnumMemberAttribute]
				MORRO = 169070021,
				[EnumMemberAttribute]
				NUCLEO = 169070022,
				[EnumMemberAttribute]
				PARQUE = 169070023,
				[EnumMemberAttribute]
				PASSARELA = 169070024,
				[EnumMemberAttribute]
				PATIO = 169070025,
				[EnumMemberAttribute]
				PATIO_2 = 169070026,
				[EnumMemberAttribute]
				PRACA = 169070027,
				[EnumMemberAttribute]
				RESIDENCIAL = 169070029,
				[EnumMemberAttribute]
				RODOVIA = 169070030,
				[EnumMemberAttribute]
				RUA = 169070031,
				[EnumMemberAttribute]
				SITIO = 169070032,
				[EnumMemberAttribute]
				TRAVESSA = 169070033,
				[EnumMemberAttribute]
				VIADUTO = 169070034,
				[EnumMemberAttribute]
				VILA = 169070036,
				[EnumMemberAttribute]
				BECO = 169070037,
				[EnumMemberAttribute]
				NAOCADASTRADO = 169070038,
				[EnumMemberAttribute]
				Item = 169070035,
			}		
			[DataContractAttribute]
			public enum urb_tipo_renda_cliente 
			{
				[EnumMemberAttribute]
				RendaComprovada = 169070000,
				[EnumMemberAttribute]
				Rendanaocomprovada = 169070001,
				[EnumMemberAttribute]
				Naopossuirenda = 169070002,
			}		
			[DataContractAttribute]
			public enum urb_vinculo_referencia 
			{
				[EnumMemberAttribute]
				Pai = 169070000,
				[EnumMemberAttribute]
				Mae = 169070001,
				[EnumMemberAttribute]
				Tioa = 169070002,
				[EnumMemberAttribute]
				Avoo = 169070003,
				[EnumMemberAttribute]
				Filhoa = 169070004,
				[EnumMemberAttribute]
				Irmaoa = 169070005,
				[EnumMemberAttribute]
				Amigo = 169070006,
				[EnumMemberAttribute]
				Funcionario = 169070007,
				[EnumMemberAttribute]
				Outros = 169070008,
			}		
	}


		public class OneToMany
		{
			public const string lead_customer_accounts = "lead_customer_accounts";
			public const string opportunity_customer_accounts = "opportunity_customer_accounts";
			public const string account_master_account = "account_master_account";
			public const string msdyn_account_account_BillingAccount = "msdyn_account_account_BillingAccount";
			public const string account_parent_account = "account_parent_account";
			public const string lead_parent_account = "lead_parent_account";
			public const string opportunity_parent_account = "opportunity_parent_account";
			public const string contact_customer_accounts = "contact_customer_accounts";
			public const string account_activity_parties = "account_activity_parties";
}
		public class ManyToMany
		{
			public const string accountleads_association = "accountleads_association";
}

		public class Fields
		{
			public const string SchemaName = "account";
			
			public const string AccountCategoryCode = "accountcategorycode";
			public const string AccountClassificationCode = "accountclassificationcode";
			public const string AccountId = "accountid";
			public const string AccountNumber = "accountnumber";
			public const string AccountRatingCode = "accountratingcode";
			public const string Address1_AddressId = "address1_addressid";
			public const string Address1_AddressTypeCode = "address1_addresstypecode";
			public const string Address1_City = "address1_city";
			public const string Address1_Composite = "address1_composite";
			public const string Address1_Country = "address1_country";
			public const string Address1_County = "address1_county";
			public const string Address1_Fax = "address1_fax";
			public const string Address1_FreightTermsCode = "address1_freighttermscode";
			public const string Address1_Latitude = "address1_latitude";
			public const string Address1_Line1 = "address1_line1";
			public const string Address1_Line2 = "address1_line2";
			public const string Address1_Line3 = "address1_line3";
			public const string Address1_Longitude = "address1_longitude";
			public const string Address1_Name = "address1_name";
			public const string Address1_PostalCode = "address1_postalcode";
			public const string Address1_PostOfficeBox = "address1_postofficebox";
			public const string Address1_PrimaryContactName = "address1_primarycontactname";
			public const string Address1_ShippingMethodCode = "address1_shippingmethodcode";
			public const string Address1_StateOrProvince = "address1_stateorprovince";
			public const string Address1_Telephone1 = "address1_telephone1";
			public const string Address1_Telephone2 = "address1_telephone2";
			public const string Address1_Telephone3 = "address1_telephone3";
			public const string Address1_UPSZone = "address1_upszone";
			public const string Address1_UTCOffset = "address1_utcoffset";
			public const string Address2_AddressId = "address2_addressid";
			public const string Address2_AddressTypeCode = "address2_addresstypecode";
			public const string Address2_City = "address2_city";
			public const string Address2_Composite = "address2_composite";
			public const string Address2_Country = "address2_country";
			public const string Address2_County = "address2_county";
			public const string Address2_Fax = "address2_fax";
			public const string Address2_FreightTermsCode = "address2_freighttermscode";
			public const string Address2_Latitude = "address2_latitude";
			public const string Address2_Line1 = "address2_line1";
			public const string Address2_Line2 = "address2_line2";
			public const string Address2_Line3 = "address2_line3";
			public const string Address2_Longitude = "address2_longitude";
			public const string Address2_Name = "address2_name";
			public const string Address2_PostalCode = "address2_postalcode";
			public const string Address2_PostOfficeBox = "address2_postofficebox";
			public const string Address2_PrimaryContactName = "address2_primarycontactname";
			public const string Address2_ShippingMethodCode = "address2_shippingmethodcode";
			public const string Address2_StateOrProvince = "address2_stateorprovince";
			public const string Address2_Telephone1 = "address2_telephone1";
			public const string Address2_Telephone2 = "address2_telephone2";
			public const string Address2_Telephone3 = "address2_telephone3";
			public const string Address2_UPSZone = "address2_upszone";
			public const string Address2_UTCOffset = "address2_utcoffset";
			public const string Aging30 = "aging30";
			public const string Aging30_Base = "aging30_base";
			public const string Aging60 = "aging60";
			public const string Aging60_Base = "aging60_base";
			public const string Aging90 = "aging90";
			public const string Aging90_Base = "aging90_base";
			public const string BusinessTypeCode = "businesstypecode";
			public const string CreatedBy = "createdby";
			public const string CreatedByExternalParty = "createdbyexternalparty";
			public const string CreatedByExternalPartyName = "createdbyexternalpartyName";
			public const string CreatedByName = "createdbyName";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CreatedOnBehalfByName = "createdonbehalfbyName";
			public const string CreditLimit = "creditlimit";
			public const string CreditLimit_Base = "creditlimit_base";
			public const string CreditOnHold = "creditonhold";
			public const string CustomerSizeCode = "customersizecode";
			public const string CustomerTypeCode = "customertypecode";
			public const string DefaultPriceLevelId = "defaultpricelevelid";
			public const string DefaultPriceLevelIdName = "defaultpricelevelidName";
			public const string Description = "description";
			public const string DoNotBulkEMail = "donotbulkemail";
			public const string DoNotBulkPostalMail = "donotbulkpostalmail";
			public const string DoNotEMail = "donotemail";
			public const string DoNotFax = "donotfax";
			public const string DoNotPhone = "donotphone";
			public const string DoNotPostalMail = "donotpostalmail";
			public const string DoNotSendMM = "donotsendmm";
			public const string EMailAddress1 = "emailaddress1";
			public const string EMailAddress2 = "emailaddress2";
			public const string EMailAddress3 = "emailaddress3";
			public const string EntityImage = "entityimage";
			public const string EntityImage_Timestamp = "entityimage_timestamp";
			public const string EntityImage_URL = "entityimage_url";
			public const string EntityImageId = "entityimageid";
			public const string ExchangeRate = "exchangerate";
			public const string Fax = "fax";
			public const string FollowEmail = "followemail";
			public const string FtpSiteURL = "ftpsiteurl";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string IndustryCode = "industrycode";
			public const string IsPrivate = "isprivate";
			public const string LastOnHoldTime = "lastonholdtime";
			public const string LastUsedInCampaign = "lastusedincampaign";
			public const string MarketCap = "marketcap";
			public const string MarketCap_Base = "marketcap_base";
			public const string MarketingOnly = "marketingonly";
			public const string MasterId = "masterid";
			public const string MasterIdName = "masteridName";
			public const string Merged = "merged";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedByExternalParty = "modifiedbyexternalparty";
			public const string ModifiedByExternalPartyName = "modifiedbyexternalpartyName";
			public const string ModifiedByName = "modifiedbyName";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string ModifiedOnBehalfByName = "modifiedonbehalfbyName";
			public const string msdyn_BillingAccount = "msdyn_billingaccount";
			public const string msdyn_BillingAccountName = "msdyn_billingaccountName";
			public const string msdyn_externalaccountid = "msdyn_externalaccountid";
			public const string msdyn_PreferredResource = "msdyn_preferredresource";
			public const string msdyn_PreferredResourceName = "msdyn_preferredresourceName";
			public const string msdyn_SalesTaxCode = "msdyn_salestaxcode";
			public const string msdyn_SalesTaxCodeName = "msdyn_salestaxcodeName";
			public const string msdyn_ServiceTerritory = "msdyn_serviceterritory";
			public const string msdyn_ServiceTerritoryName = "msdyn_serviceterritoryName";
			public const string msdyn_TaxExempt = "msdyn_taxexempt";
			public const string msdyn_TaxExemptNumber = "msdyn_taxexemptnumber";
			public const string msdyn_TravelCharge = "msdyn_travelcharge";
			public const string msdyn_travelcharge_Base = "msdyn_travelcharge_base";
			public const string msdyn_TravelChargeType = "msdyn_travelchargetype";
			public const string msdyn_WorkOrderInstructions = "msdyn_workorderinstructions";
			public const string Name = "name";
			public const string NumberOfEmployees = "numberofemployees";
			public const string OnHoldTime = "onholdtime";
			public const string OpenDeals = "opendeals";
			public const string OpenDeals_Date = "opendeals_date";
			public const string OpenDeals_State = "opendeals_state";
			public const string OpenRevenue = "openrevenue";
			public const string OpenRevenue_Base = "openrevenue_base";
			public const string OpenRevenue_Date = "openrevenue_date";
			public const string OpenRevenue_State = "openrevenue_state";
			public const string OriginatingLeadId = "originatingleadid";
			public const string OriginatingLeadIdName = "originatingleadidName";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string OwnerId = "ownerid";
			public const string OwnershipCode = "ownershipcode";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningBusinessUnitName = "owningbusinessunitName";
			public const string OwningTeam = "owningteam";
			public const string OwningTeamName = "owningteamName";
			public const string OwningUser = "owninguser";
			public const string OwningUserName = "owninguserName";
			public const string ParentAccountId = "parentaccountid";
			public const string ParentAccountIdName = "parentaccountidName";
			public const string ParticipatesInWorkflow = "participatesinworkflow";
			public const string PaymentTermsCode = "paymenttermscode";
			public const string PreferredAppointmentDayCode = "preferredappointmentdaycode";
			public const string PreferredAppointmentTimeCode = "preferredappointmenttimecode";
			public const string PreferredContactMethodCode = "preferredcontactmethodcode";
			public const string PreferredEquipmentId = "preferredequipmentid";
			public const string PreferredEquipmentIdName = "preferredequipmentidName";
			public const string PreferredServiceId = "preferredserviceid";
			public const string PreferredServiceIdName = "preferredserviceidName";
			public const string PreferredSystemUserId = "preferredsystemuserid";
			public const string PreferredSystemUserIdName = "preferredsystemuseridName";
			public const string PrimaryContactId = "primarycontactid";
			public const string PrimaryContactIdName = "primarycontactidName";
			public const string PrimarySatoriId = "primarysatoriid";
			public const string PrimaryTwitterId = "primarytwitterid";
			public const string ProcessId = "processid";
			public const string Revenue = "revenue";
			public const string Revenue_Base = "revenue_base";
			public const string SharesOutstanding = "sharesoutstanding";
			public const string ShippingMethodCode = "shippingmethodcode";
			public const string SIC = "sic";
			public const string SLAId = "slaid";
			public const string SLAIdName = "slaidName";
			public const string SLAInvokedId = "slainvokedid";
			public const string SLAInvokedIdName = "slainvokedidName";
			public const string StageId = "stageid";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string StockExchange = "stockexchange";
			public const string Telephone1 = "telephone1";
			public const string Telephone2 = "telephone2";
			public const string Telephone3 = "telephone3";
			public const string TerritoryCode = "territorycode";
			public const string TerritoryId = "territoryid";
			public const string TerritoryIdName = "territoryidName";
			public const string TickerSymbol = "tickersymbol";
			public const string TimeSpentByMeOnEmailAndMeetings = "timespentbymeonemailandmeetings";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string TransactionCurrencyIdName = "transactioncurrencyidName";
			public const string TraversedPath = "traversedpath";
			public const string urb_agencia_bancaria = "urb_agencia_bancaria";
			public const string urb_bairro_interesse = "urb_bairro_interesse";
			public const string urb_BancoId = "urb_bancoid";
			public const string urb_BancoIdName = "urb_bancoidName";
			public const string urb_Cidade_enderecoId = "urb_cidade_enderecoid";
			public const string urb_Cidade_enderecoIdName = "urb_cidade_enderecoidName";
			public const string urb_Cidade_estrangeiro = "urb_cidade_estrangeiro";
			public const string urb_cidade_interesse = "urb_cidade_interesse";
			public const string urb_classe_risco = "urb_classe_risco";
			public const string urb_cliente_possui_outro_imovel = "urb_cliente_possui_outro_imovel";
			public const string urb_CNPJ = "urb_cnpj";
			public const string urb_codigo_parceiro_conjuge = "urb_codigo_parceiro_conjuge";
			public const string urb_codigo_parceiro_fiador = "urb_codigo_parceiro_fiador";
			public const string urb_codigo_parceiro_procurador = "urb_codigo_parceiro_procurador";
			public const string urb_codigo_parceiro_repr_vendas = "urb_codigo_parceiro_repr_vendas";
			public const string urb_codigo_sap = "urb_codigo_sap";
			public const string urb_conta_bancaria = "urb_conta_bancaria";
			public const string urb_CorretorId = "urb_corretorid";
			public const string urb_CorretorIdName = "urb_corretoridName";
			public const string urb_CPF = "urb_cpf";
			public const string urb_data_expedicao_identidade = "urb_data_expedicao_identidade";
			public const string urb_Data_Nascimento = "urb_data_nascimento";
			public const string urb_Empresa_trabalho = "urb_empresa_trabalho";
			public const string urb_Endereco_Nacional = "urb_endereco_nacional";
			public const string urb_estado_civil = "urb_estado_civil";
			public const string urb_Estado_EnderecoId = "urb_estado_enderecoid";
			public const string urb_Estado_EnderecoIdName = "urb_estado_enderecoidName";
			public const string urb_estado_estrangeiro = "urb_estado_estrangeiro";
			public const string urb_finalidade_aquisicao_lote = "urb_finalidade_aquisicao_lote";
			public const string urb_grau_instrucao = "urb_grau_instrucao";
			public const string urb_GrupoClientesId = "urb_grupoclientesid";
			public const string urb_GrupoClientesIdName = "urb_grupoclientesidName";
			public const string urb_importado_mrv = "urb_importado_mrv";
			public const string urb_interesse_finan_lote_contrucao = "urb_interesse_finan_lote_contrucao";
			public const string urb_Logradouro_Resumido = "urb_logradouro_resumido";
			public const string urb_midia = "urb_midia";
			public const string urb_nacionalidade = "urb_nacionalidade";
			public const string urb_NaturalidadeId = "urb_naturalidadeid";
			public const string urb_NaturalidadeIdName = "urb_naturalidadeidName";
			public const string urb_Nome_mae = "urb_nome_mae";
			public const string urb_nome_pai = "urb_nome_pai";
			public const string urb_nome_referencia = "urb_nome_referencia";
			public const string urb_num_filhos = "urb_num_filhos";
			public const string urb_Numero = "urb_numero";
			public const string urb_numero_identidade = "urb_numero_identidade";
			public const string urb_OcupaoId = "urb_ocupaoid";
			public const string urb_OcupaoIdName = "urb_ocupaoidName";
			public const string urb_orgao_expedicaoid = "urb_orgao_expedicaoid";
			public const string urb_orgao_expedicaoidName = "urb_orgao_expedicaoidName";
			public const string urb_PaisId = "urb_paisid";
			public const string urb_PaisIdName = "urb_paisidName";
			public const string urb_parceiro_construtor = "urb_parceiro_construtor";
			public const string urb_principal_atrativo_compra_lote = "urb_principal_atrativo_compra_lote";
			public const string urb_renda_pessoal = "urb_renda_pessoal";
			public const string urb_renda_pessoal_Base = "urb_renda_pessoal_base";
			public const string urb_score = "urb_score";
			public const string urb_Sexo = "urb_sexo";
			public const string urb_taxa_inadimplencia = "urb_taxa_inadimplencia";
			public const string urb_telefone_enriquecimento_1 = "urb_telefone_enriquecimento_1";
			public const string urb_telefone_enriquecimento_2 = "urb_telefone_enriquecimento_2";
			public const string urb_telefone_enriquecimento_3 = "urb_telefone_enriquecimento_3";
			public const string urb_telefone_enriquecimento_4 = "urb_telefone_enriquecimento_4";
			public const string urb_telefone_enriquecimento_5 = "urb_telefone_enriquecimento_5";
			public const string urb_telefone_referencia = "urb_telefone_referencia";
			public const string urb_tipo_cliente = "urb_tipo_cliente";
			public const string urb_tipo_conta = "urb_tipo_conta";
			public const string urb_Tipo_Logradouro = "urb_tipo_logradouro";
			public const string urb_tipo_renda_cliente = "urb_tipo_renda_cliente";
			public const string urb_uf_expedicaoid = "urb_uf_expedicaoid";
			public const string urb_uf_expedicaoidName = "urb_uf_expedicaoidName";
			public const string urb_vinculo_referencia = "urb_vinculo_referencia";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
			public const string WebSiteURL = "websiteurl";
			public const string YomiName = "yominame";
		}
	}

	/// <summary>
	/// Pessoa ou grupo associado a uma atividade. Uma atividade pode ter vários participantes.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("activityparty")]
	public partial class ActivityParty : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public ActivityParty() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "activityparty";
		
		public const int EntityTypeCode = 135;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activitypartyid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.ActivityPartyId = value;
			}
		}
		/// <summary>
		/// Identificador exclusivo de uma atividade associada ao participante da atividade. (Um "participante" é qualquer pessoa associada a uma atividade.)
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
		public Microsoft.Xrm.Sdk.EntityReference ActivityId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("activityid");
			}
			set
			{
				this.OnPropertyChanging("ActivityId");
				this.SetAttributeValue("activityid", value);
				this.OnPropertyChanged("ActivityId");
			}
		}
	



		/// <summary>
		/// Identificador exclusivo do participante da atividade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activitypartyid")]
		public System.Nullable<System.Guid> ActivityPartyId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("activitypartyid");
			}
			set
			{
				this.OnPropertyChanging("ActivityPartyId");
				this.SetAttributeValue("activitypartyid", value);
						if (value.HasValue)
						{
							base.Id = value.Value;
						}
						else
						{
							base.Id = System.Guid.Empty;
						}
				this.OnPropertyChanged("ActivityPartyId");
			}
		}
	


		/// <summary>
		/// Endereço de email para o qual um email é entregue e que está associado a uma entidade de destino.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addressused")]
		public string AddressUsed
		{
			get
			{
				return this.GetAttributeValue<string>("addressused");
			}
			set
			{
				this.OnPropertyChanging("AddressUsed");
				this.SetAttributeValue("addressused", value);
				this.OnPropertyChanged("AddressUsed");
			}
		}
	


		/// <summary>
		/// Número da coluna de endereço de email do participante associado.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addressusedemailcolumnnumber")]
		public System.Nullable<int> AddressUsedEmailColumnNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("addressusedemailcolumnnumber");
			}
		}
	


		/// <summary>
		/// Informações que especificam se é permitido enviar e-mail aos participantes da atividade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotemail")]
		public System.Nullable<bool> DoNotEmail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotemail");
			}
		}
	
		public virtual Enums.DoNotEmail? DoNotEmailEnum
		{
			get
			{
				return ((Enums.DoNotEmail?)(EntityOptionSetEnum.GetEnum(this, "donotemail")));
			}
		}


		/// <summary>
		/// Informações que especificam se é permitido enviar faxes aos participantes da atividade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotfax")]
		public System.Nullable<bool> DoNotFax
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotfax");
			}
		}
	
		public virtual Enums.DoNotFax? DoNotFaxEnum
		{
			get
			{
				return ((Enums.DoNotFax?)(EntityOptionSetEnum.GetEnum(this, "donotfax")));
			}
		}


		/// <summary>
		/// Informação que especifica se é permitido telefonar ao cliente potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotphone")]
		public System.Nullable<bool> DoNotPhone
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotphone");
			}
		}
	
		public virtual Enums.DoNotPhone? DoNotPhoneEnum
		{
			get
			{
				return ((Enums.DoNotPhone?)(EntityOptionSetEnum.GetEnum(this, "donotphone")));
			}
		}


		/// <summary>
		/// Informação que especifica se é permitido enviar correio comum ao cliente potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotpostalmail")]
		public System.Nullable<bool> DoNotPostalMail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotpostalmail");
			}
		}
	
		public virtual Enums.DoNotPostalMail? DoNotPostalMailEnum
		{
			get
			{
				return ((Enums.DoNotPostalMail?)(EntityOptionSetEnum.GetEnum(this, "donotpostalmail")));
			}
		}


		/// <summary>
		/// Esforço feito pelo recurso em uma atividade de compromisso de serviço.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("effort")]
		public System.Nullable<double> Effort
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("effort");
			}
			set
			{
				this.OnPropertyChanging("Effort");
				this.SetAttributeValue("effort", value);
				this.OnPropertyChanged("Effort");
			}
		}
	


		/// <summary>
		/// Apenas para uso interno.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangeentryid")]
		public string ExchangeEntryId
		{
			get
			{
				return this.GetAttributeValue<string>("exchangeentryid");
			}
			set
			{
				this.OnPropertyChanging("ExchangeEntryId");
				this.SetAttributeValue("exchangeentryid", value);
				this.OnPropertyChanged("ExchangeEntryId");
			}
		}
	


		/// <summary>
		/// Tipo de instância de uma série recorrente.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("instancetypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue InstanceTypeCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("instancetypecode");
			}
		}
	
		public virtual Enums.InstanceTypeCode? InstanceTypeCodeEnum
		{
			get
			{
				return ((Enums.InstanceTypeCode?)(EntityOptionSetEnum.GetEnum(this, "instancetypecode")));
			}
		}


		/// <summary>
		/// Informações sobre se o registro de entidade subjacente é excluído.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ispartydeleted")]
		public System.Nullable<bool> IsPartyDeleted
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("ispartydeleted");
			}
		}
	
		public virtual Enums.IsPartyDeleted? IsPartyDeletedEnum
		{
			get
			{
				return ((Enums.IsPartyDeleted?)(EntityOptionSetEnum.GetEnum(this, "ispartydeleted")));
			}
		}


		/// <summary>
		/// Identificador exclusivo do usuário ou da equipe que possui o activity_party.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public System.Nullable<System.Guid> OwningBusinessUnit
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("owningbusinessunit");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public System.Nullable<System.Guid> OwningUser
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("owninguser");
			}
		}
	


		/// <summary>
		/// Função da pessoa na atividade, como por exemplo, remetente, para, cc, cco, obrigatória, opcional, organizador, referente ou proprietário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("participationtypemask")]
		public Microsoft.Xrm.Sdk.OptionSetValue ParticipationTypeMask
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("participationtypemask");
			}
			set
			{
				this.OnPropertyChanging("ParticipationTypeMask");
				this.SetAttributeValue("participationtypemask", value);
				this.OnPropertyChanged("ParticipationTypeMask");
			}
		}
	
		public virtual Enums.ParticipationTypeMask? ParticipationTypeMaskEnum
		{
			get
			{
				return ((Enums.ParticipationTypeMask?)(EntityOptionSetEnum.GetEnum(this, "participationtypemask")));
			}
			set
			{
				ParticipationTypeMask = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Identificador exclusivo do participante associado à atividade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
		public Microsoft.Xrm.Sdk.EntityReference PartyId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("partyid");
			}
			set
			{
				this.OnPropertyChanging("PartyId");
				this.SetAttributeValue("partyid", value);
				this.OnPropertyChanged("PartyId");
			}
		}
	




		/// <summary>
		/// Identificador exclusivo da especificação de recurso para o participante da atividade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resourcespecid")]
		public Microsoft.Xrm.Sdk.EntityReference ResourceSpecId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("resourcespecid");
			}
			set
			{
				this.OnPropertyChanging("ResourceSpecId");
				this.SetAttributeValue("resourcespecid", value);
				this.OnPropertyChanged("ResourceSpecId");
			}
		}
	



		/// <summary>
		/// Hora de término agendada da atividade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduledend")]
		public System.Nullable<System.DateTime> ScheduledEnd
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduledend");
			}
		}
	


		/// <summary>
		/// Hora de início agendada da atividade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduledstart")]
		public System.Nullable<System.DateTime> ScheduledStart
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduledstart");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
	


		
		/// <summary>
		/// N:1 account_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_activity_parties")]
		public Account account_activity_parties
		{
			get
			{
				return this.GetRelatedEntity<Account>("account_activity_parties", null);
			}
			set
			{
				this.OnPropertyChanging("account_activity_parties");
				this.SetRelatedEntity<Account>("account_activity_parties", null, value);
				this.OnPropertyChanged("account_activity_parties");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_account_activity_parties(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "account_activity_parties");
		}

		
		/// <summary>
		/// N:1 contact_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_activity_parties")]
		public Contact contact_activity_parties
		{
			get
			{
				return this.GetRelatedEntity<Contact>("contact_activity_parties", null);
			}
			set
			{
				this.OnPropertyChanging("contact_activity_parties");
				this.SetRelatedEntity<Contact>("contact_activity_parties", null, value);
				this.OnPropertyChanged("contact_activity_parties");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_contact_activity_parties(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "contact_activity_parties");
		}

		
		/// <summary>
		/// N:1 system_user_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_activity_parties")]
		public SystemUser system_user_activity_parties
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("system_user_activity_parties", null);
			}
			set
			{
				this.OnPropertyChanging("system_user_activity_parties");
				this.SetRelatedEntity<SystemUser>("system_user_activity_parties", null, value);
				this.OnPropertyChanged("system_user_activity_parties");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_system_user_activity_parties(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "system_user_activity_parties");
		}

		
		/// <summary>
		/// N:1 lead_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_activity_parties")]
		public Lead lead_activity_parties
		{
			get
			{
				return this.GetRelatedEntity<Lead>("lead_activity_parties", null);
			}
			set
			{
				this.OnPropertyChanging("lead_activity_parties");
				this.SetRelatedEntity<Lead>("lead_activity_parties", null, value);
				this.OnPropertyChanged("lead_activity_parties");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lead_activity_parties(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lead_activity_parties");
		}

		
		/// <summary>
		/// N:1 opportunity_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_activity_parties")]
		public Opportunity opportunity_activity_parties
		{
			get
			{
				return this.GetRelatedEntity<Opportunity>("opportunity_activity_parties", null);
			}
			set
			{
				this.OnPropertyChanging("opportunity_activity_parties");
				this.SetRelatedEntity<Opportunity>("opportunity_activity_parties", null, value);
				this.OnPropertyChanged("opportunity_activity_parties");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_opportunity_activity_parties(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "opportunity_activity_parties");
		}



		public class Enums 
		{
			[DataContractAttribute]
			public enum DoNotEmail 
			{
				[EnumMemberAttribute]
				NaoPermitir = 1,
				[EnumMemberAttribute]
				Permitir = 0,
			}		
			[DataContractAttribute]
			public enum DoNotFax 
			{
				[EnumMemberAttribute]
				NaoPermitir = 1,
				[EnumMemberAttribute]
				Permitir = 0,
			}		
			[DataContractAttribute]
			public enum DoNotPhone 
			{
				[EnumMemberAttribute]
				NaoPermitir = 1,
				[EnumMemberAttribute]
				Permitir = 0,
			}		
			[DataContractAttribute]
			public enum DoNotPostalMail 
			{
				[EnumMemberAttribute]
				NaoPermitir = 1,
				[EnumMemberAttribute]
				Permitir = 0,
			}		
			[DataContractAttribute]
			public enum InstanceTypeCode 
			{
				[EnumMemberAttribute]
				NaoRecorrente = 0,
				[EnumMemberAttribute]
				MestreRecorrente = 1,
				[EnumMemberAttribute]
				InstanciaRecorrente = 2,
				[EnumMemberAttribute]
				ExcecaoRecorrente = 3,
				[EnumMemberAttribute]
				ExcecaoFuturaRecorrente = 4,
			}		
			[DataContractAttribute]
			public enum IsPartyDeleted 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum ParticipationTypeMask 
			{
				[EnumMemberAttribute]
				Remetente = 1,
				[EnumMemberAttribute]
				DestinatarioPara = 2,
				[EnumMemberAttribute]
				DestinatarioCC = 3,
				[EnumMemberAttribute]
				DestinatarioCCO = 4,
				[EnumMemberAttribute]
				Participanteobrigatorio = 5,
				[EnumMemberAttribute]
				Participanteopcional = 6,
				[EnumMemberAttribute]
				Organizador = 7,
				[EnumMemberAttribute]
				Referentea = 8,
				[EnumMemberAttribute]
				Proprietario = 9,
				[EnumMemberAttribute]
				Recurso = 10,
				[EnumMemberAttribute]
				Cliente = 11,
			}		
	}


		public class OneToMany
		{
}
		public class ManyToMany
		{
}

		public class Fields
		{
			public const string SchemaName = "activityparty";
			
			public const string ActivityId = "activityid";
			public const string ActivityIdName = "activityidName";
			public const string ActivityPartyId = "activitypartyid";
			public const string AddressUsed = "addressused";
			public const string AddressUsedEmailColumnNumber = "addressusedemailcolumnnumber";
			public const string DoNotEmail = "donotemail";
			public const string DoNotFax = "donotfax";
			public const string DoNotPhone = "donotphone";
			public const string DoNotPostalMail = "donotpostalmail";
			public const string Effort = "effort";
			public const string ExchangeEntryId = "exchangeentryid";
			public const string InstanceTypeCode = "instancetypecode";
			public const string IsPartyDeleted = "ispartydeleted";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningUser = "owninguser";
			public const string ParticipationTypeMask = "participationtypemask";
			public const string PartyId = "partyid";
			public const string PartyIdName = "partyidName";
			public const string PartyIdType = "partyidType";
			public const string ResourceSpecId = "resourcespecid";
			public const string ResourceSpecIdName = "resourcespecidName";
			public const string ScheduledEnd = "scheduledend";
			public const string ScheduledStart = "scheduledstart";
			public const string VersionNumber = "versionnumber";
		}
	}

	/// <summary>
	/// Negócio, divisão ou departamento no banco de dados do Microsoft Dynamics CRM.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("businessunit")]
	public partial class BusinessUnit : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public BusinessUnit() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "businessunit";
		
		public const int EntityTypeCode = 10;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.BusinessUnitId = value;
			}
		}
		/// <summary>
		/// Identificador exclusivo do endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addressid")]
		public System.Nullable<System.Guid> Address1_AddressId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("address1_addressid");
			}
			set
			{
				this.OnPropertyChanging("Address1_AddressId");
				this.SetAttributeValue("address1_addressid", value);
				this.OnPropertyChanged("Address1_AddressId");
			}
		}
	


		/// <summary>
		/// Tipo do endereço 1, como por exemplo, endereço para cobrança, endereço para entrega ou endereço primário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addresstypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address1_AddressTypeCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_addresstypecode");
			}
			set
			{
				this.OnPropertyChanging("Address1_AddressTypeCode");
				this.SetAttributeValue("address1_addresstypecode", value);
				this.OnPropertyChanged("Address1_AddressTypeCode");
			}
		}
	
		public virtual Enums.Address1_AddressTypeCode? Address1_AddressTypeCodeEnum
		{
			get
			{
				return ((Enums.Address1_AddressTypeCode?)(EntityOptionSetEnum.GetEnum(this, "address1_addresstypecode")));
			}
			set
			{
				Address1_AddressTypeCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Nome da cidade do endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_city")]
		public string Address1_City
		{
			get
			{
				return this.GetAttributeValue<string>("address1_city");
			}
			set
			{
				this.OnPropertyChanging("Address1_City");
				this.SetAttributeValue("address1_city", value);
				this.OnPropertyChanged("Address1_City");
			}
		}
	


		/// <summary>
		/// País/região do endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_country")]
		public string Address1_Country
		{
			get
			{
				return this.GetAttributeValue<string>("address1_country");
			}
			set
			{
				this.OnPropertyChanging("Address1_Country");
				this.SetAttributeValue("address1_country", value);
				this.OnPropertyChanged("Address1_Country");
			}
		}
	


		/// <summary>
		/// Nome do município do endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_county")]
		public string Address1_County
		{
			get
			{
				return this.GetAttributeValue<string>("address1_county");
			}
			set
			{
				this.OnPropertyChanging("Address1_County");
				this.SetAttributeValue("address1_county", value);
				this.OnPropertyChanged("Address1_County");
			}
		}
	


		/// <summary>
		/// Número de fax do endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_fax")]
		public string Address1_Fax
		{
			get
			{
				return this.GetAttributeValue<string>("address1_fax");
			}
			set
			{
				this.OnPropertyChanging("Address1_Fax");
				this.SetAttributeValue("address1_fax", value);
				this.OnPropertyChanged("Address1_Fax");
			}
		}
	


		/// <summary>
		/// Latitude do endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_latitude")]
		public System.Nullable<double> Address1_Latitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address1_latitude");
			}
			set
			{
				this.OnPropertyChanging("Address1_Latitude");
				this.SetAttributeValue("address1_latitude", value);
				this.OnPropertyChanged("Address1_Latitude");
			}
		}
	


		/// <summary>
		/// Primeira linha para inserir informações de endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line1")]
		public string Address1_Line1
		{
			get
			{
				return this.GetAttributeValue<string>("address1_line1");
			}
			set
			{
				this.OnPropertyChanging("Address1_Line1");
				this.SetAttributeValue("address1_line1", value);
				this.OnPropertyChanged("Address1_Line1");
			}
		}
	


		/// <summary>
		/// Segunda linha para inserir informações de endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line2")]
		public string Address1_Line2
		{
			get
			{
				return this.GetAttributeValue<string>("address1_line2");
			}
			set
			{
				this.OnPropertyChanging("Address1_Line2");
				this.SetAttributeValue("address1_line2", value);
				this.OnPropertyChanged("Address1_Line2");
			}
		}
	


		/// <summary>
		/// Terceira linha para inserir informações de endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line3")]
		public string Address1_Line3
		{
			get
			{
				return this.GetAttributeValue<string>("address1_line3");
			}
			set
			{
				this.OnPropertyChanging("Address1_Line3");
				this.SetAttributeValue("address1_line3", value);
				this.OnPropertyChanged("Address1_Line3");
			}
		}
	


		/// <summary>
		/// Longitude do endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_longitude")]
		public System.Nullable<double> Address1_Longitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address1_longitude");
			}
			set
			{
				this.OnPropertyChanging("Address1_Longitude");
				this.SetAttributeValue("address1_longitude", value);
				this.OnPropertyChanged("Address1_Longitude");
			}
		}
	


		/// <summary>
		/// Nome a ser inserido para endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_name")]
		public string Address1_Name
		{
			get
			{
				return this.GetAttributeValue<string>("address1_name");
			}
			set
			{
				this.OnPropertyChanging("Address1_Name");
				this.SetAttributeValue("address1_name", value);
				this.OnPropertyChanged("Address1_Name");
			}
		}
	


		/// <summary>
		/// CEP do endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postalcode")]
		public string Address1_PostalCode
		{
			get
			{
				return this.GetAttributeValue<string>("address1_postalcode");
			}
			set
			{
				this.OnPropertyChanging("Address1_PostalCode");
				this.SetAttributeValue("address1_postalcode", value);
				this.OnPropertyChanged("Address1_PostalCode");
			}
		}
	


		/// <summary>
		/// Número da caixa postal do endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postofficebox")]
		public string Address1_PostOfficeBox
		{
			get
			{
				return this.GetAttributeValue<string>("address1_postofficebox");
			}
			set
			{
				this.OnPropertyChanging("Address1_PostOfficeBox");
				this.SetAttributeValue("address1_postofficebox", value);
				this.OnPropertyChanged("Address1_PostOfficeBox");
			}
		}
	


		/// <summary>
		/// Método de entrega para endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_shippingmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address1_ShippingMethodCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_shippingmethodcode");
			}
			set
			{
				this.OnPropertyChanging("Address1_ShippingMethodCode");
				this.SetAttributeValue("address1_shippingmethodcode", value);
				this.OnPropertyChanged("Address1_ShippingMethodCode");
			}
		}
	
		public virtual Enums.Address1_ShippingMethodCode? Address1_ShippingMethodCodeEnum
		{
			get
			{
				return ((Enums.Address1_ShippingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "address1_shippingmethodcode")));
			}
			set
			{
				Address1_ShippingMethodCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Estado do endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_stateorprovince")]
		public string Address1_StateOrProvince
		{
			get
			{
				return this.GetAttributeValue<string>("address1_stateorprovince");
			}
			set
			{
				this.OnPropertyChanging("Address1_StateOrProvince");
				this.SetAttributeValue("address1_stateorprovince", value);
				this.OnPropertyChanged("Address1_StateOrProvince");
			}
		}
	


		/// <summary>
		/// Primeiro número de telefone associado ao endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone1")]
		public string Address1_Telephone1
		{
			get
			{
				return this.GetAttributeValue<string>("address1_telephone1");
			}
			set
			{
				this.OnPropertyChanging("Address1_Telephone1");
				this.SetAttributeValue("address1_telephone1", value);
				this.OnPropertyChanged("Address1_Telephone1");
			}
		}
	


		/// <summary>
		/// Segundo número de telefone associado ao endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone2")]
		public string Address1_Telephone2
		{
			get
			{
				return this.GetAttributeValue<string>("address1_telephone2");
			}
			set
			{
				this.OnPropertyChanging("Address1_Telephone2");
				this.SetAttributeValue("address1_telephone2", value);
				this.OnPropertyChanged("Address1_Telephone2");
			}
		}
	


		/// <summary>
		/// Terceiro número de telefone associado ao endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone3")]
		public string Address1_Telephone3
		{
			get
			{
				return this.GetAttributeValue<string>("address1_telephone3");
			}
			set
			{
				this.OnPropertyChanging("Address1_Telephone3");
				this.SetAttributeValue("address1_telephone3", value);
				this.OnPropertyChanged("Address1_Telephone3");
			}
		}
	


		/// <summary>
		/// Zona UPS do endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_upszone")]
		public string Address1_UPSZone
		{
			get
			{
				return this.GetAttributeValue<string>("address1_upszone");
			}
			set
			{
				this.OnPropertyChanging("Address1_UPSZone");
				this.SetAttributeValue("address1_upszone", value);
				this.OnPropertyChanged("Address1_UPSZone");
			}
		}
	


		/// <summary>
		/// Diferença UTC do endereço 1. Essa é a diferença entre a hora local e a Hora Universal Coordenada oficial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_utcoffset")]
		public System.Nullable<int> Address1_UTCOffset
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("address1_utcoffset");
			}
			set
			{
				this.OnPropertyChanging("Address1_UTCOffset");
				this.SetAttributeValue("address1_utcoffset", value);
				this.OnPropertyChanged("Address1_UTCOffset");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo do endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addressid")]
		public System.Nullable<System.Guid> Address2_AddressId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("address2_addressid");
			}
			set
			{
				this.OnPropertyChanging("Address2_AddressId");
				this.SetAttributeValue("address2_addressid", value);
				this.OnPropertyChanged("Address2_AddressId");
			}
		}
	


		/// <summary>
		/// Tipo do endereço 2, como por exemplo, endereço para cobrança, endereço para entrega ou endereço primário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addresstypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address2_AddressTypeCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_addresstypecode");
			}
			set
			{
				this.OnPropertyChanging("Address2_AddressTypeCode");
				this.SetAttributeValue("address2_addresstypecode", value);
				this.OnPropertyChanged("Address2_AddressTypeCode");
			}
		}
	
		public virtual Enums.Address2_AddressTypeCode? Address2_AddressTypeCodeEnum
		{
			get
			{
				return ((Enums.Address2_AddressTypeCode?)(EntityOptionSetEnum.GetEnum(this, "address2_addresstypecode")));
			}
			set
			{
				Address2_AddressTypeCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Nome da cidade do endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_city")]
		public string Address2_City
		{
			get
			{
				return this.GetAttributeValue<string>("address2_city");
			}
			set
			{
				this.OnPropertyChanging("Address2_City");
				this.SetAttributeValue("address2_city", value);
				this.OnPropertyChanged("Address2_City");
			}
		}
	


		/// <summary>
		/// País/região do endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_country")]
		public string Address2_Country
		{
			get
			{
				return this.GetAttributeValue<string>("address2_country");
			}
			set
			{
				this.OnPropertyChanging("Address2_Country");
				this.SetAttributeValue("address2_country", value);
				this.OnPropertyChanged("Address2_Country");
			}
		}
	


		/// <summary>
		/// Nome do município do endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_county")]
		public string Address2_County
		{
			get
			{
				return this.GetAttributeValue<string>("address2_county");
			}
			set
			{
				this.OnPropertyChanging("Address2_County");
				this.SetAttributeValue("address2_county", value);
				this.OnPropertyChanged("Address2_County");
			}
		}
	


		/// <summary>
		/// Número de fax do endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_fax")]
		public string Address2_Fax
		{
			get
			{
				return this.GetAttributeValue<string>("address2_fax");
			}
			set
			{
				this.OnPropertyChanging("Address2_Fax");
				this.SetAttributeValue("address2_fax", value);
				this.OnPropertyChanged("Address2_Fax");
			}
		}
	


		/// <summary>
		/// Latitude do endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_latitude")]
		public System.Nullable<double> Address2_Latitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address2_latitude");
			}
			set
			{
				this.OnPropertyChanging("Address2_Latitude");
				this.SetAttributeValue("address2_latitude", value);
				this.OnPropertyChanged("Address2_Latitude");
			}
		}
	


		/// <summary>
		/// Primeira linha para inserir informações de endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line1")]
		public string Address2_Line1
		{
			get
			{
				return this.GetAttributeValue<string>("address2_line1");
			}
			set
			{
				this.OnPropertyChanging("Address2_Line1");
				this.SetAttributeValue("address2_line1", value);
				this.OnPropertyChanged("Address2_Line1");
			}
		}
	


		/// <summary>
		/// Segunda linha para inserir informações de endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line2")]
		public string Address2_Line2
		{
			get
			{
				return this.GetAttributeValue<string>("address2_line2");
			}
			set
			{
				this.OnPropertyChanging("Address2_Line2");
				this.SetAttributeValue("address2_line2", value);
				this.OnPropertyChanged("Address2_Line2");
			}
		}
	


		/// <summary>
		/// Terceira linha para inserir informações de endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line3")]
		public string Address2_Line3
		{
			get
			{
				return this.GetAttributeValue<string>("address2_line3");
			}
			set
			{
				this.OnPropertyChanging("Address2_Line3");
				this.SetAttributeValue("address2_line3", value);
				this.OnPropertyChanged("Address2_Line3");
			}
		}
	


		/// <summary>
		/// Longitude do endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_longitude")]
		public System.Nullable<double> Address2_Longitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address2_longitude");
			}
			set
			{
				this.OnPropertyChanging("Address2_Longitude");
				this.SetAttributeValue("address2_longitude", value);
				this.OnPropertyChanged("Address2_Longitude");
			}
		}
	


		/// <summary>
		/// Nome a ser inserido para endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_name")]
		public string Address2_Name
		{
			get
			{
				return this.GetAttributeValue<string>("address2_name");
			}
			set
			{
				this.OnPropertyChanging("Address2_Name");
				this.SetAttributeValue("address2_name", value);
				this.OnPropertyChanged("Address2_Name");
			}
		}
	


		/// <summary>
		/// CEP do endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postalcode")]
		public string Address2_PostalCode
		{
			get
			{
				return this.GetAttributeValue<string>("address2_postalcode");
			}
			set
			{
				this.OnPropertyChanging("Address2_PostalCode");
				this.SetAttributeValue("address2_postalcode", value);
				this.OnPropertyChanged("Address2_PostalCode");
			}
		}
	


		/// <summary>
		/// Número da caixa postal do endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postofficebox")]
		public string Address2_PostOfficeBox
		{
			get
			{
				return this.GetAttributeValue<string>("address2_postofficebox");
			}
			set
			{
				this.OnPropertyChanging("Address2_PostOfficeBox");
				this.SetAttributeValue("address2_postofficebox", value);
				this.OnPropertyChanged("Address2_PostOfficeBox");
			}
		}
	


		/// <summary>
		/// Método de entrega para endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_shippingmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address2_ShippingMethodCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_shippingmethodcode");
			}
			set
			{
				this.OnPropertyChanging("Address2_ShippingMethodCode");
				this.SetAttributeValue("address2_shippingmethodcode", value);
				this.OnPropertyChanged("Address2_ShippingMethodCode");
			}
		}
	
		public virtual Enums.Address2_ShippingMethodCode? Address2_ShippingMethodCodeEnum
		{
			get
			{
				return ((Enums.Address2_ShippingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "address2_shippingmethodcode")));
			}
			set
			{
				Address2_ShippingMethodCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Estado do endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_stateorprovince")]
		public string Address2_StateOrProvince
		{
			get
			{
				return this.GetAttributeValue<string>("address2_stateorprovince");
			}
			set
			{
				this.OnPropertyChanging("Address2_StateOrProvince");
				this.SetAttributeValue("address2_stateorprovince", value);
				this.OnPropertyChanged("Address2_StateOrProvince");
			}
		}
	


		/// <summary>
		/// Primeiro número de telefone associado ao endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone1")]
		public string Address2_Telephone1
		{
			get
			{
				return this.GetAttributeValue<string>("address2_telephone1");
			}
			set
			{
				this.OnPropertyChanging("Address2_Telephone1");
				this.SetAttributeValue("address2_telephone1", value);
				this.OnPropertyChanged("Address2_Telephone1");
			}
		}
	


		/// <summary>
		/// Segundo número de telefone associado ao endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone2")]
		public string Address2_Telephone2
		{
			get
			{
				return this.GetAttributeValue<string>("address2_telephone2");
			}
			set
			{
				this.OnPropertyChanging("Address2_Telephone2");
				this.SetAttributeValue("address2_telephone2", value);
				this.OnPropertyChanged("Address2_Telephone2");
			}
		}
	


		/// <summary>
		/// Terceiro número de telefone associado ao endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone3")]
		public string Address2_Telephone3
		{
			get
			{
				return this.GetAttributeValue<string>("address2_telephone3");
			}
			set
			{
				this.OnPropertyChanging("Address2_Telephone3");
				this.SetAttributeValue("address2_telephone3", value);
				this.OnPropertyChanged("Address2_Telephone3");
			}
		}
	


		/// <summary>
		/// Zona UPS do endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_upszone")]
		public string Address2_UPSZone
		{
			get
			{
				return this.GetAttributeValue<string>("address2_upszone");
			}
			set
			{
				this.OnPropertyChanging("Address2_UPSZone");
				this.SetAttributeValue("address2_upszone", value);
				this.OnPropertyChanged("Address2_UPSZone");
			}
		}
	


		/// <summary>
		/// Diferença UTC do endereço 2. Essa é a diferença entre a hora local e a Hora Universal Coordenada oficial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_utcoffset")]
		public System.Nullable<int> Address2_UTCOffset
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("address2_utcoffset");
			}
			set
			{
				this.OnPropertyChanging("Address2_UTCOffset");
				this.SetAttributeValue("address2_utcoffset", value);
				this.OnPropertyChanged("Address2_UTCOffset");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo da unidade de negócios.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
		public System.Nullable<System.Guid> BusinessUnitId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("businessunitid");
			}
			set
			{
				this.OnPropertyChanging("BusinessUnitId");
				this.SetAttributeValue("businessunitid", value);
						if (value.HasValue)
						{
							base.Id = value.Value;
						}
						else
						{
							base.Id = System.Guid.Empty;
						}
				this.OnPropertyChanged("BusinessUnitId");
			}
		}
	


		/// <summary>
		/// Calendário fiscal associado à unidade de negócios.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("calendarid")]
		public Microsoft.Xrm.Sdk.EntityReference CalendarId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("calendarid");
			}
			set
			{
				this.OnPropertyChanging("CalendarId");
				this.SetAttributeValue("calendarid", value);
				this.OnPropertyChanged("CalendarId");
			}
		}
	



		/// <summary>
		/// Nome do centro de custos da unidade de negócios.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("costcenter")]
		public string CostCenter
		{
			get
			{
				return this.GetAttributeValue<string>("costcenter");
			}
			set
			{
				this.OnPropertyChanging("CostCenter");
				this.SetAttributeValue("costcenter", value);
				this.OnPropertyChanged("CostCenter");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo do usuário que criou a unidade de negócios.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
	



		/// <summary>
		/// Data e hora em que a unidade de negócios foi criada.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo do usuário delegado que criou a businessunit.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
	



		/// <summary>
		/// Limite de crédito da unidade de negócios.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("creditlimit")]
		public System.Nullable<double> CreditLimit
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("creditlimit");
			}
			set
			{
				this.OnPropertyChanging("CreditLimit");
				this.SetAttributeValue("creditlimit", value);
				this.OnPropertyChanged("CreditLimit");
			}
		}
	


		/// <summary>
		/// Descrição da unidade de negócios.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			set
			{
				this.OnPropertyChanging("Description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("Description");
			}
		}
	


		/// <summary>
		/// Razão para desabilitar a unidade de negócios.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("disabledreason")]
		public string DisabledReason
		{
			get
			{
				return this.GetAttributeValue<string>("disabledreason");
			}
		}
	


		/// <summary>
		/// Nome da divisão à qual a unidade de negócios pertence.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("divisionname")]
		public string DivisionName
		{
			get
			{
				return this.GetAttributeValue<string>("divisionname");
			}
			set
			{
				this.OnPropertyChanging("DivisionName");
				this.SetAttributeValue("divisionname", value);
				this.OnPropertyChanged("DivisionName");
			}
		}
	


		/// <summary>
		/// Endereço de email da unidade de negócios.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress")]
		public string EMailAddress
		{
			get
			{
				return this.GetAttributeValue<string>("emailaddress");
			}
			set
			{
				this.OnPropertyChanging("EMailAddress");
				this.SetAttributeValue("emailaddress", value);
				this.OnPropertyChanged("EMailAddress");
			}
		}
	


		/// <summary>
		/// Taxa de câmbio da moeda associada à businessunit em relação à moeda base.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
		public System.Nullable<decimal> ExchangeRate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
			}
		}
	


		/// <summary>
		/// Nome alternativo com o qual a unidade de negócios pode ser arquivada.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fileasname")]
		public string FileAsName
		{
			get
			{
				return this.GetAttributeValue<string>("fileasname");
			}
			set
			{
				this.OnPropertyChanging("FileAsName");
				this.SetAttributeValue("fileasname", value);
				this.OnPropertyChanged("FileAsName");
			}
		}
	


		/// <summary>
		/// URL do site FTP da unidade de negócios.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ftpsiteurl")]
		public string FtpSiteUrl
		{
			get
			{
				return this.GetAttributeValue<string>("ftpsiteurl");
			}
			set
			{
				this.OnPropertyChanging("FtpSiteUrl");
				this.SetAttributeValue("ftpsiteurl", value);
				this.OnPropertyChanged("FtpSiteUrl");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo da importação de dados ou migração de dados que criou este registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
	


		/// <summary>
		/// Máscara de herança da unidade de negócios.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("inheritancemask")]
		public System.Nullable<int> InheritanceMask
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("inheritancemask");
			}
			set
			{
				this.OnPropertyChanging("InheritanceMask");
				this.SetAttributeValue("inheritancemask", value);
				this.OnPropertyChanged("InheritanceMask");
			}
		}
	


		/// <summary>
		/// Informação que especifica se a unidade de negócios está habilitada ou desabilitada.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdisabled")]
		public System.Nullable<bool> IsDisabled
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isdisabled");
			}
			set
			{
				this.OnPropertyChanging("IsDisabled");
				this.SetAttributeValue("isdisabled", value);
				this.OnPropertyChanged("IsDisabled");
			}
		}
	
		public virtual Enums.IsDisabled? IsDisabledEnum
		{
			get
			{
				return ((Enums.IsDisabled?)(EntityOptionSetEnum.GetEnum(this, "isdisabled")));
			}
			set
			{
		       if (value.HasValue)
                    IsDisabled = ((int)value == 1);
                else                   
                    IsDisabled = null;
			}
		}


		/// <summary>
		/// Identificador exclusivo do usuário que modificou a unidade de negócios por último.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
	



		/// <summary>
		/// Data e hora da última modificação da unidade de negócios.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo do usuário delegado que fez a última modificação na businessunit.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
	



		/// <summary>
		/// Identificador exclusivo do Depósito associado à Unidade de Negócios.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_warehouse")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_Warehouse
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_warehouse");
			}
			set
			{
				this.OnPropertyChanging("msdyn_Warehouse");
				this.SetAttributeValue("msdyn_warehouse", value);
				this.OnPropertyChanged("msdyn_Warehouse");
			}
		}
	



		/// <summary>
		/// Nome da unidade de negócios.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			set
			{
				this.OnPropertyChanging("Name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("Name");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo da organização associada à unidade de negócios.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
	



		/// <summary>
		/// Data e hora da migração do registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo da divisão primária.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentbusinessunitid")]
		public Microsoft.Xrm.Sdk.EntityReference ParentBusinessUnitId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentbusinessunitid");
			}
			set
			{
				this.OnPropertyChanging("ParentBusinessUnitId");
				this.SetAttributeValue("parentbusinessunitid", value);
				this.OnPropertyChanged("ParentBusinessUnitId");
			}
		}
	



		/// <summary>
		/// Imagem ou diagrama da unidade de negócios.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("picture")]
		public string Picture
		{
			get
			{
				return this.GetAttributeValue<string>("picture");
			}
			set
			{
				this.OnPropertyChanging("Picture");
				this.SetAttributeValue("picture", value);
				this.OnPropertyChanged("Picture");
			}
		}
	


		/// <summary>
		/// Bolsa de valores na qual o negócio está listado.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stockexchange")]
		public string StockExchange
		{
			get
			{
				return this.GetAttributeValue<string>("stockexchange");
			}
			set
			{
				this.OnPropertyChanging("StockExchange");
				this.SetAttributeValue("stockexchange", value);
				this.OnPropertyChanged("StockExchange");
			}
		}
	


		/// <summary>
		/// Símbolo da unidade de negócios na bolsa de valores.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("tickersymbol")]
		public string TickerSymbol
		{
			get
			{
				return this.GetAttributeValue<string>("tickersymbol");
			}
			set
			{
				this.OnPropertyChanging("TickerSymbol");
				this.SetAttributeValue("tickersymbol", value);
				this.OnPropertyChanged("TickerSymbol");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo da moeda associada à businessunit.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
			}
			set
			{
				this.OnPropertyChanging("TransactionCurrencyId");
				this.SetAttributeValue("transactioncurrencyid", value);
				this.OnPropertyChanged("TransactionCurrencyId");
			}
		}
	



		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_email_secundario")]
		public string urb_email_secundario
		{
			get
			{
				return this.GetAttributeValue<string>("urb_email_secundario");
			}
			set
			{
				this.OnPropertyChanging("urb_email_secundario");
				this.SetAttributeValue("urb_email_secundario", value);
				this.OnPropertyChanged("urb_email_secundario");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_email_terceiro_contato")]
		public string urb_email_terceiro_contato
		{
			get
			{
				return this.GetAttributeValue<string>("urb_email_terceiro_contato");
			}
			set
			{
				this.OnPropertyChanging("urb_email_terceiro_contato");
				this.SetAttributeValue("urb_email_terceiro_contato", value);
				this.OnPropertyChanged("urb_email_terceiro_contato");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_percentual_comissao")]
		public System.Nullable<decimal> urb_percentual_comissao
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("urb_percentual_comissao");
			}
			set
			{
				this.OnPropertyChanging("urb_percentual_comissao");
				this.SetAttributeValue("urb_percentual_comissao", value);
				this.OnPropertyChanged("urb_percentual_comissao");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("usergroupid")]
		public System.Nullable<System.Guid> UserGroupId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("usergroupid");
			}
		}
	


		/// <summary>
		/// Diferença UTC para a unidade de negócios. Essa é a diferença entre a hora local e a Hora Universal Coordenada oficial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcoffset")]
		public System.Nullable<int> UTCOffset
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcoffset");
			}
			set
			{
				this.OnPropertyChanging("UTCOffset");
				this.SetAttributeValue("utcoffset", value);
				this.OnPropertyChanged("UTCOffset");
			}
		}
	


		/// <summary>
		/// Número de versão da divisão.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
	


		/// <summary>
		/// URL do site da unidade de negócios.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("websiteurl")]
		public string WebSiteUrl
		{
			get
			{
				return this.GetAttributeValue<string>("websiteurl");
			}
			set
			{
				this.OnPropertyChanging("WebSiteUrl");
				this.SetAttributeValue("websiteurl", value);
				this.OnPropertyChanged("WebSiteUrl");
			}
		}
	


		/// <summary>
		/// Informação que especifica se as regras de fluxo de trabalho ou de processo de vendas foram suspensas.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workflowsuspended")]
		public System.Nullable<bool> WorkflowSuspended
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("workflowsuspended");
			}
			set
			{
				this.OnPropertyChanging("WorkflowSuspended");
				this.SetAttributeValue("workflowsuspended", value);
				this.OnPropertyChanged("WorkflowSuspended");
			}
		}
	
		public virtual Enums.WorkflowSuspended? WorkflowSuspendedEnum
		{
			get
			{
				return ((Enums.WorkflowSuspended?)(EntityOptionSetEnum.GetEnum(this, "workflowsuspended")));
			}
			set
			{
		       if (value.HasValue)
                    WorkflowSuspended = ((int)value == 1);
                else                   
                    WorkflowSuspended = null;
			}
		}


		
		/// <summary>
		/// 1:N business_unit_teams
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_teams")]
		public System.Collections.Generic.IEnumerable<Team> business_unit_teams
		{
			get
			{
				return this.GetRelatedEntities<Team>("business_unit_teams", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_teams");
				this.SetRelatedEntities<Team>("business_unit_teams", null, value);
				this.OnPropertyChanged("business_unit_teams");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_business_unit_teams(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "business_unit_teams");
		}

		
		/// <summary>
		/// 1:N business_unit_system_users
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_system_users")]
		public System.Collections.Generic.IEnumerable<SystemUser> business_unit_system_users
		{
			get
			{
				return this.GetRelatedEntities<SystemUser>("business_unit_system_users", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_system_users");
				this.SetRelatedEntities<SystemUser>("business_unit_system_users", null, value);
				this.OnPropertyChanged("business_unit_system_users");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_business_unit_system_users(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "business_unit_system_users");
		}

		
		/// <summary>
		/// 1:N business_unit_contacts
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_contacts")]
		public System.Collections.Generic.IEnumerable<Contact> business_unit_contacts
		{
			get
			{
				return this.GetRelatedEntities<Contact>("business_unit_contacts", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_contacts");
				this.SetRelatedEntities<Contact>("business_unit_contacts", null, value);
				this.OnPropertyChanged("business_unit_contacts");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_business_unit_contacts(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "business_unit_contacts");
		}

		
		/// <summary>
		/// 1:N business_unit_accounts
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_accounts")]
		public System.Collections.Generic.IEnumerable<Account> business_unit_accounts
		{
			get
			{
				return this.GetRelatedEntities<Account>("business_unit_accounts", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_accounts");
				this.SetRelatedEntities<Account>("business_unit_accounts", null, value);
				this.OnPropertyChanged("business_unit_accounts");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_business_unit_accounts(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "business_unit_accounts");
		}

		
		/// <summary>
		/// 1:N business_unit_leads
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_leads")]
		public System.Collections.Generic.IEnumerable<Lead> business_unit_leads
		{
			get
			{
				return this.GetRelatedEntities<Lead>("business_unit_leads", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_leads");
				this.SetRelatedEntities<Lead>("business_unit_leads", null, value);
				this.OnPropertyChanged("business_unit_leads");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_business_unit_leads(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "business_unit_leads");
		}

		
		/// <summary>
		/// 1:N business_unit_opportunities
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_opportunities")]
		public System.Collections.Generic.IEnumerable<Opportunity> business_unit_opportunities
		{
			get
			{
				return this.GetRelatedEntities<Opportunity>("business_unit_opportunities", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_opportunities");
				this.SetRelatedEntities<Opportunity>("business_unit_opportunities", null, value);
				this.OnPropertyChanged("business_unit_opportunities");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_business_unit_opportunities(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "business_unit_opportunities");
		}

		
		/// <summary>
		/// 1:N business_unit_parent_business_unit
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_parent_business_unit", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<BusinessUnit> Referencedbusiness_unit_parent_business_unit
		{
			get
			{
				return this.GetRelatedEntities<BusinessUnit>("business_unit_parent_business_unit", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referencedbusiness_unit_parent_business_unit");
				this.SetRelatedEntities<BusinessUnit>("business_unit_parent_business_unit", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedbusiness_unit_parent_business_unit");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_business_unit_parent_business_unit(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "business_unit_parent_business_unit");
		}

		
		/// <summary>
		/// N:1 lk_businessunitbase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunitbase_createdby")]
		public SystemUser lk_businessunitbase_createdby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_businessunitbase_createdby", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_businessunitbase_createdby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_businessunitbase_createdby");
		}

		
		/// <summary>
		/// N:1 lk_businessunit_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunit_createdonbehalfby")]
		public SystemUser lk_businessunit_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_businessunit_createdonbehalfby", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_businessunit_createdonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_businessunit_createdonbehalfby");
		}

		
		/// <summary>
		/// N:1 lk_businessunitbase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunitbase_modifiedby")]
		public SystemUser lk_businessunitbase_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_businessunitbase_modifiedby", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_businessunitbase_modifiedby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_businessunitbase_modifiedby");
		}

		
		/// <summary>
		/// N:1 lk_businessunit_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunit_modifiedonbehalfby")]
		public SystemUser lk_businessunit_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_businessunit_modifiedonbehalfby", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_businessunit_modifiedonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_businessunit_modifiedonbehalfby");
		}

		
		/// <summary>
		/// N:1 business_unit_parent_business_unit
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentbusinessunitid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_parent_business_unit", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public BusinessUnit Referencingbusiness_unit_parent_business_unit
		{
			get
			{
				return this.GetRelatedEntity<BusinessUnit>("business_unit_parent_business_unit", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
			set
			{
				this.OnPropertyChanging("Referencingbusiness_unit_parent_business_unit");
				this.SetRelatedEntity<BusinessUnit>("business_unit_parent_business_unit", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
				this.OnPropertyChanged("Referencingbusiness_unit_parent_business_unit");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_business_unit_parent_business_unit(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "business_unit_parent_business_unit");
		}

		
		/// <summary>
		/// N:1 TransactionCurrency_BusinessUnit
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_BusinessUnit")]
		public TransactionCurrency TransactionCurrency_BusinessUnit
		{
			get
			{
				return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_BusinessUnit", null);
			}
			set
			{
				this.OnPropertyChanging("TransactionCurrency_BusinessUnit");
				this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_BusinessUnit", null, value);
				this.OnPropertyChanged("TransactionCurrency_BusinessUnit");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_TransactionCurrency_BusinessUnit(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "TransactionCurrency_BusinessUnit");
		}



		public class Enums 
		{
			[DataContractAttribute]
			public enum Address1_AddressTypeCode 
			{
				[EnumMemberAttribute]
				ValorPadrao = 1,
			}		
			[DataContractAttribute]
			public enum Address1_ShippingMethodCode 
			{
				[EnumMemberAttribute]
				ValorPadrao = 1,
			}		
			[DataContractAttribute]
			public enum Address2_AddressTypeCode 
			{
				[EnumMemberAttribute]
				ValorPadrao = 1,
			}		
			[DataContractAttribute]
			public enum Address2_ShippingMethodCode 
			{
				[EnumMemberAttribute]
				ValorPadrao = 1,
			}		
			[DataContractAttribute]
			public enum IsDisabled 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum WorkflowSuspended 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
	}


		public class OneToMany
		{
			public const string business_unit_teams = "business_unit_teams";
			public const string business_unit_system_users = "business_unit_system_users";
			public const string business_unit_contacts = "business_unit_contacts";
			public const string business_unit_accounts = "business_unit_accounts";
			public const string business_unit_leads = "business_unit_leads";
			public const string business_unit_opportunities = "business_unit_opportunities";
			public const string business_unit_parent_business_unit = "business_unit_parent_business_unit";
}
		public class ManyToMany
		{
}

		public class Fields
		{
			public const string SchemaName = "businessunit";
			
			public const string Address1_AddressId = "address1_addressid";
			public const string Address1_AddressTypeCode = "address1_addresstypecode";
			public const string Address1_City = "address1_city";
			public const string Address1_Country = "address1_country";
			public const string Address1_County = "address1_county";
			public const string Address1_Fax = "address1_fax";
			public const string Address1_Latitude = "address1_latitude";
			public const string Address1_Line1 = "address1_line1";
			public const string Address1_Line2 = "address1_line2";
			public const string Address1_Line3 = "address1_line3";
			public const string Address1_Longitude = "address1_longitude";
			public const string Address1_Name = "address1_name";
			public const string Address1_PostalCode = "address1_postalcode";
			public const string Address1_PostOfficeBox = "address1_postofficebox";
			public const string Address1_ShippingMethodCode = "address1_shippingmethodcode";
			public const string Address1_StateOrProvince = "address1_stateorprovince";
			public const string Address1_Telephone1 = "address1_telephone1";
			public const string Address1_Telephone2 = "address1_telephone2";
			public const string Address1_Telephone3 = "address1_telephone3";
			public const string Address1_UPSZone = "address1_upszone";
			public const string Address1_UTCOffset = "address1_utcoffset";
			public const string Address2_AddressId = "address2_addressid";
			public const string Address2_AddressTypeCode = "address2_addresstypecode";
			public const string Address2_City = "address2_city";
			public const string Address2_Country = "address2_country";
			public const string Address2_County = "address2_county";
			public const string Address2_Fax = "address2_fax";
			public const string Address2_Latitude = "address2_latitude";
			public const string Address2_Line1 = "address2_line1";
			public const string Address2_Line2 = "address2_line2";
			public const string Address2_Line3 = "address2_line3";
			public const string Address2_Longitude = "address2_longitude";
			public const string Address2_Name = "address2_name";
			public const string Address2_PostalCode = "address2_postalcode";
			public const string Address2_PostOfficeBox = "address2_postofficebox";
			public const string Address2_ShippingMethodCode = "address2_shippingmethodcode";
			public const string Address2_StateOrProvince = "address2_stateorprovince";
			public const string Address2_Telephone1 = "address2_telephone1";
			public const string Address2_Telephone2 = "address2_telephone2";
			public const string Address2_Telephone3 = "address2_telephone3";
			public const string Address2_UPSZone = "address2_upszone";
			public const string Address2_UTCOffset = "address2_utcoffset";
			public const string BusinessUnitId = "businessunitid";
			public const string CalendarId = "calendarid";
			public const string CalendarIdName = "calendaridName";
			public const string CostCenter = "costcenter";
			public const string CreatedBy = "createdby";
			public const string CreatedByName = "createdbyName";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CreatedOnBehalfByName = "createdonbehalfbyName";
			public const string CreditLimit = "creditlimit";
			public const string Description = "description";
			public const string DisabledReason = "disabledreason";
			public const string DivisionName = "divisionname";
			public const string EMailAddress = "emailaddress";
			public const string ExchangeRate = "exchangerate";
			public const string FileAsName = "fileasname";
			public const string FtpSiteUrl = "ftpsiteurl";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string InheritanceMask = "inheritancemask";
			public const string IsDisabled = "isdisabled";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedByName = "modifiedbyName";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string ModifiedOnBehalfByName = "modifiedonbehalfbyName";
			public const string msdyn_Warehouse = "msdyn_warehouse";
			public const string msdyn_WarehouseName = "msdyn_warehouseName";
			public const string Name = "name";
			public const string OrganizationId = "organizationid";
			public const string OrganizationIdName = "organizationidName";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string ParentBusinessUnitId = "parentbusinessunitid";
			public const string ParentBusinessUnitIdName = "parentbusinessunitidName";
			public const string Picture = "picture";
			public const string StockExchange = "stockexchange";
			public const string TickerSymbol = "tickersymbol";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string TransactionCurrencyIdName = "transactioncurrencyidName";
			public const string urb_email_secundario = "urb_email_secundario";
			public const string urb_email_terceiro_contato = "urb_email_terceiro_contato";
			public const string urb_percentual_comissao = "urb_percentual_comissao";
			public const string UserGroupId = "usergroupid";
			public const string UTCOffset = "utcoffset";
			public const string VersionNumber = "versionnumber";
			public const string WebSiteUrl = "websiteurl";
			public const string WorkflowSuspended = "workflowsuspended";
		}
	}

	[System.Runtime.Serialization.DataContractAttribute()]
	public enum ContactState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Ativa = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inativa = 1,
	}

	/// <summary>
	/// Pessoa com a qual uma unidade de negócios tem um relacionamento, como cliente, fornecedor e colega.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("contact")]
	public partial class Contact : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public Contact() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "contact";
		
		public const int EntityTypeCode = 2;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contactid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.ContactId = value;
			}
		}
		/// <summary>
		/// Identificador exclusivo da conta à qual o contato está associado.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountid")]
		public Microsoft.Xrm.Sdk.EntityReference AccountId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("accountid");
			}
		}
	



		/// <summary>
		/// Escolha a função do contato dentro da empresa ou o processo de vendas, como o tomador de decisão, o funcionário ou o influenciador.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountrolecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue AccountRoleCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("accountrolecode");
			}
			set
			{
				this.OnPropertyChanging("AccountRoleCode");
				this.SetAttributeValue("accountrolecode", value);
				this.OnPropertyChanged("AccountRoleCode");
			}
		}
	
		public virtual Enums.AccountRoleCode? AccountRoleCodeEnum
		{
			get
			{
				return ((Enums.AccountRoleCode?)(EntityOptionSetEnum.GetEnum(this, "accountrolecode")));
			}
			set
			{
				AccountRoleCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Identificador exclusivo do endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addressid")]
		public System.Nullable<System.Guid> Address1_AddressId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("address1_addressid");
			}
			set
			{
				this.OnPropertyChanging("Address1_AddressId");
				this.SetAttributeValue("address1_addressid", value);
				this.OnPropertyChanged("Address1_AddressId");
			}
		}
	


		/// <summary>
		/// Tipo do endereço 1, como por exemplo, endereço para cobrança, endereço para entrega ou endereço primário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addresstypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address1_AddressTypeCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_addresstypecode");
			}
			set
			{
				this.OnPropertyChanging("Address1_AddressTypeCode");
				this.SetAttributeValue("address1_addresstypecode", value);
				this.OnPropertyChanged("Address1_AddressTypeCode");
			}
		}
	
		public virtual Enums.Address1_AddressTypeCode? Address1_AddressTypeCodeEnum
		{
			get
			{
				return ((Enums.Address1_AddressTypeCode?)(EntityOptionSetEnum.GetEnum(this, "address1_addresstypecode")));
			}
			set
			{
				Address1_AddressTypeCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Digite a cidade do endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_city")]
		public string Address1_City
		{
			get
			{
				return this.GetAttributeValue<string>("address1_city");
			}
			set
			{
				this.OnPropertyChanging("Address1_City");
				this.SetAttributeValue("address1_city", value);
				this.OnPropertyChanged("Address1_City");
			}
		}
	


		/// <summary>
		/// Mostra o endereço principal completo.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_composite")]
		public string Address1_Composite
		{
			get
			{
				return this.GetAttributeValue<string>("address1_composite");
			}
		}
	


		/// <summary>
		/// Digite o país ou região do endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_country")]
		public string Address1_Country
		{
			get
			{
				return this.GetAttributeValue<string>("address1_country");
			}
			set
			{
				this.OnPropertyChanging("Address1_Country");
				this.SetAttributeValue("address1_country", value);
				this.OnPropertyChanged("Address1_Country");
			}
		}
	


		/// <summary>
		/// Digite o município do endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_county")]
		public string Address1_County
		{
			get
			{
				return this.GetAttributeValue<string>("address1_county");
			}
			set
			{
				this.OnPropertyChanging("Address1_County");
				this.SetAttributeValue("address1_county", value);
				this.OnPropertyChanged("Address1_County");
			}
		}
	


		/// <summary>
		/// Digite o número do fax associado ao endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_fax")]
		public string Address1_Fax
		{
			get
			{
				return this.GetAttributeValue<string>("address1_fax");
			}
			set
			{
				this.OnPropertyChanging("Address1_Fax");
				this.SetAttributeValue("address1_fax", value);
				this.OnPropertyChanged("Address1_Fax");
			}
		}
	


		/// <summary>
		/// Escolha as condições de frete do endereço principal para garantir que as ordens de remessa sejam processadas corretamente.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_freighttermscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address1_FreightTermsCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_freighttermscode");
			}
			set
			{
				this.OnPropertyChanging("Address1_FreightTermsCode");
				this.SetAttributeValue("address1_freighttermscode", value);
				this.OnPropertyChanged("Address1_FreightTermsCode");
			}
		}
	
		public virtual Enums.Address1_FreightTermsCode? Address1_FreightTermsCodeEnum
		{
			get
			{
				return ((Enums.Address1_FreightTermsCode?)(EntityOptionSetEnum.GetEnum(this, "address1_freighttermscode")));
			}
			set
			{
				Address1_FreightTermsCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Digite o valor da latitude do endereço principal para uso no mapeamento e em outros aplicativos.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_latitude")]
		public System.Nullable<double> Address1_Latitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address1_latitude");
			}
			set
			{
				this.OnPropertyChanging("Address1_Latitude");
				this.SetAttributeValue("address1_latitude", value);
				this.OnPropertyChanged("Address1_Latitude");
			}
		}
	


		/// <summary>
		/// Digite a primeira linha do endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line1")]
		public string Address1_Line1
		{
			get
			{
				return this.GetAttributeValue<string>("address1_line1");
			}
			set
			{
				this.OnPropertyChanging("Address1_Line1");
				this.SetAttributeValue("address1_line1", value);
				this.OnPropertyChanged("Address1_Line1");
			}
		}
	


		/// <summary>
		/// Digite a segunda linha do endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line2")]
		public string Address1_Line2
		{
			get
			{
				return this.GetAttributeValue<string>("address1_line2");
			}
			set
			{
				this.OnPropertyChanging("Address1_Line2");
				this.SetAttributeValue("address1_line2", value);
				this.OnPropertyChanged("Address1_Line2");
			}
		}
	


		/// <summary>
		/// Digite a terceira linha do endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line3")]
		public string Address1_Line3
		{
			get
			{
				return this.GetAttributeValue<string>("address1_line3");
			}
			set
			{
				this.OnPropertyChanging("Address1_Line3");
				this.SetAttributeValue("address1_line3", value);
				this.OnPropertyChanged("Address1_Line3");
			}
		}
	


		/// <summary>
		/// Digite o valor da longitude do endereço principal para uso no mapeamento e em outros aplicativos.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_longitude")]
		public System.Nullable<double> Address1_Longitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address1_longitude");
			}
			set
			{
				this.OnPropertyChanging("Address1_Longitude");
				this.SetAttributeValue("address1_longitude", value);
				this.OnPropertyChanged("Address1_Longitude");
			}
		}
	


		/// <summary>
		/// Digite um nome descritivo para o endereço principal, como Matriz Corporativa.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_name")]
		public string Address1_Name
		{
			get
			{
				return this.GetAttributeValue<string>("address1_name");
			}
			set
			{
				this.OnPropertyChanging("Address1_Name");
				this.SetAttributeValue("address1_name", value);
				this.OnPropertyChanged("Address1_Name");
			}
		}
	


		/// <summary>
		/// Digite o CEP do endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postalcode")]
		public string Address1_PostalCode
		{
			get
			{
				return this.GetAttributeValue<string>("address1_postalcode");
			}
			set
			{
				this.OnPropertyChanging("Address1_PostalCode");
				this.SetAttributeValue("address1_postalcode", value);
				this.OnPropertyChanged("Address1_PostalCode");
			}
		}
	


		/// <summary>
		/// Digite o número da caixa postal do endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postofficebox")]
		public string Address1_PostOfficeBox
		{
			get
			{
				return this.GetAttributeValue<string>("address1_postofficebox");
			}
			set
			{
				this.OnPropertyChanging("Address1_PostOfficeBox");
				this.SetAttributeValue("address1_postofficebox", value);
				this.OnPropertyChanged("Address1_PostOfficeBox");
			}
		}
	


		/// <summary>
		/// Digite o nome do contato principal no endereço principal da conta.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_primarycontactname")]
		public string Address1_PrimaryContactName
		{
			get
			{
				return this.GetAttributeValue<string>("address1_primarycontactname");
			}
			set
			{
				this.OnPropertyChanging("Address1_PrimaryContactName");
				this.SetAttributeValue("address1_primarycontactname", value);
				this.OnPropertyChanged("Address1_PrimaryContactName");
			}
		}
	


		/// <summary>
		/// Escolha uma forma de transporte para entregas enviadas para este endereço.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_shippingmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address1_ShippingMethodCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_shippingmethodcode");
			}
			set
			{
				this.OnPropertyChanging("Address1_ShippingMethodCode");
				this.SetAttributeValue("address1_shippingmethodcode", value);
				this.OnPropertyChanged("Address1_ShippingMethodCode");
			}
		}
	
		public virtual Enums.Address1_ShippingMethodCode? Address1_ShippingMethodCodeEnum
		{
			get
			{
				return ((Enums.Address1_ShippingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "address1_shippingmethodcode")));
			}
			set
			{
				Address1_ShippingMethodCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Digite o estado ou província do endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_stateorprovince")]
		public string Address1_StateOrProvince
		{
			get
			{
				return this.GetAttributeValue<string>("address1_stateorprovince");
			}
			set
			{
				this.OnPropertyChanging("Address1_StateOrProvince");
				this.SetAttributeValue("address1_stateorprovince", value);
				this.OnPropertyChanged("Address1_StateOrProvince");
			}
		}
	


		/// <summary>
		/// Digite o número do telefone principal associado ao endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone1")]
		public string Address1_Telephone1
		{
			get
			{
				return this.GetAttributeValue<string>("address1_telephone1");
			}
			set
			{
				this.OnPropertyChanging("Address1_Telephone1");
				this.SetAttributeValue("address1_telephone1", value);
				this.OnPropertyChanged("Address1_Telephone1");
			}
		}
	


		/// <summary>
		/// Digite um segundo número de telefone associado ao endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone2")]
		public string Address1_Telephone2
		{
			get
			{
				return this.GetAttributeValue<string>("address1_telephone2");
			}
			set
			{
				this.OnPropertyChanging("Address1_Telephone2");
				this.SetAttributeValue("address1_telephone2", value);
				this.OnPropertyChanged("Address1_Telephone2");
			}
		}
	


		/// <summary>
		/// Digite um terceiro número de telefone associado ao endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone3")]
		public string Address1_Telephone3
		{
			get
			{
				return this.GetAttributeValue<string>("address1_telephone3");
			}
			set
			{
				this.OnPropertyChanging("Address1_Telephone3");
				this.SetAttributeValue("address1_telephone3", value);
				this.OnPropertyChanged("Address1_Telephone3");
			}
		}
	


		/// <summary>
		/// Digite a zona UPS do endereço principal para garantir que os encargos de remessa sejam calculados corretamente e as entregas sejam feitas imediatamente, quando enviado por UPS.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_upszone")]
		public string Address1_UPSZone
		{
			get
			{
				return this.GetAttributeValue<string>("address1_upszone");
			}
			set
			{
				this.OnPropertyChanging("Address1_UPSZone");
				this.SetAttributeValue("address1_upszone", value);
				this.OnPropertyChanged("Address1_UPSZone");
			}
		}
	


		/// <summary>
		/// Escolha o fuso horário ou a compensação UTC deste endereço para que outras pessoas possam fazer referência a ele ao contatar alguém nesse endereço.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_utcoffset")]
		public System.Nullable<int> Address1_UTCOffset
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("address1_utcoffset");
			}
			set
			{
				this.OnPropertyChanging("Address1_UTCOffset");
				this.SetAttributeValue("address1_utcoffset", value);
				this.OnPropertyChanged("Address1_UTCOffset");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo do endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addressid")]
		public System.Nullable<System.Guid> Address2_AddressId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("address2_addressid");
			}
			set
			{
				this.OnPropertyChanging("Address2_AddressId");
				this.SetAttributeValue("address2_addressid", value);
				this.OnPropertyChanged("Address2_AddressId");
			}
		}
	


		/// <summary>
		/// Escolha o tipo do endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addresstypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address2_AddressTypeCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_addresstypecode");
			}
			set
			{
				this.OnPropertyChanging("Address2_AddressTypeCode");
				this.SetAttributeValue("address2_addresstypecode", value);
				this.OnPropertyChanged("Address2_AddressTypeCode");
			}
		}
	
		public virtual Enums.Address2_AddressTypeCode? Address2_AddressTypeCodeEnum
		{
			get
			{
				return ((Enums.Address2_AddressTypeCode?)(EntityOptionSetEnum.GetEnum(this, "address2_addresstypecode")));
			}
			set
			{
				Address2_AddressTypeCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Digite a cidade do endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_city")]
		public string Address2_City
		{
			get
			{
				return this.GetAttributeValue<string>("address2_city");
			}
			set
			{
				this.OnPropertyChanging("Address2_City");
				this.SetAttributeValue("address2_city", value);
				this.OnPropertyChanged("Address2_City");
			}
		}
	


		/// <summary>
		/// Mostra o endereço secundário completo.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_composite")]
		public string Address2_Composite
		{
			get
			{
				return this.GetAttributeValue<string>("address2_composite");
			}
		}
	


		/// <summary>
		/// Digite o país ou região do endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_country")]
		public string Address2_Country
		{
			get
			{
				return this.GetAttributeValue<string>("address2_country");
			}
			set
			{
				this.OnPropertyChanging("Address2_Country");
				this.SetAttributeValue("address2_country", value);
				this.OnPropertyChanged("Address2_Country");
			}
		}
	


		/// <summary>
		/// Digite o município do endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_county")]
		public string Address2_County
		{
			get
			{
				return this.GetAttributeValue<string>("address2_county");
			}
			set
			{
				this.OnPropertyChanging("Address2_County");
				this.SetAttributeValue("address2_county", value);
				this.OnPropertyChanged("Address2_County");
			}
		}
	


		/// <summary>
		/// Digite o número do fax associado ao endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_fax")]
		public string Address2_Fax
		{
			get
			{
				return this.GetAttributeValue<string>("address2_fax");
			}
			set
			{
				this.OnPropertyChanging("Address2_Fax");
				this.SetAttributeValue("address2_fax", value);
				this.OnPropertyChanged("Address2_Fax");
			}
		}
	


		/// <summary>
		/// Escolha as condições de frete do endereço secundário para garantir que as ordens de remessa sejam processadas corretamente.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_freighttermscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address2_FreightTermsCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_freighttermscode");
			}
			set
			{
				this.OnPropertyChanging("Address2_FreightTermsCode");
				this.SetAttributeValue("address2_freighttermscode", value);
				this.OnPropertyChanged("Address2_FreightTermsCode");
			}
		}
	
		public virtual Enums.Address2_FreightTermsCode? Address2_FreightTermsCodeEnum
		{
			get
			{
				return ((Enums.Address2_FreightTermsCode?)(EntityOptionSetEnum.GetEnum(this, "address2_freighttermscode")));
			}
			set
			{
				Address2_FreightTermsCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Digite o valor da latitude do endereço secundário para uso no mapeamento e em outros aplicativos.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_latitude")]
		public System.Nullable<double> Address2_Latitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address2_latitude");
			}
			set
			{
				this.OnPropertyChanging("Address2_Latitude");
				this.SetAttributeValue("address2_latitude", value);
				this.OnPropertyChanged("Address2_Latitude");
			}
		}
	


		/// <summary>
		/// Digite a primeira linha do endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line1")]
		public string Address2_Line1
		{
			get
			{
				return this.GetAttributeValue<string>("address2_line1");
			}
			set
			{
				this.OnPropertyChanging("Address2_Line1");
				this.SetAttributeValue("address2_line1", value);
				this.OnPropertyChanged("Address2_Line1");
			}
		}
	


		/// <summary>
		/// Digite a segunda linha do endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line2")]
		public string Address2_Line2
		{
			get
			{
				return this.GetAttributeValue<string>("address2_line2");
			}
			set
			{
				this.OnPropertyChanging("Address2_Line2");
				this.SetAttributeValue("address2_line2", value);
				this.OnPropertyChanged("Address2_Line2");
			}
		}
	


		/// <summary>
		/// Digite a terceira linha do endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line3")]
		public string Address2_Line3
		{
			get
			{
				return this.GetAttributeValue<string>("address2_line3");
			}
			set
			{
				this.OnPropertyChanging("Address2_Line3");
				this.SetAttributeValue("address2_line3", value);
				this.OnPropertyChanged("Address2_Line3");
			}
		}
	


		/// <summary>
		/// Digite o valor da longitude do endereço secundário para uso no mapeamento e em outros aplicativos.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_longitude")]
		public System.Nullable<double> Address2_Longitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address2_longitude");
			}
			set
			{
				this.OnPropertyChanging("Address2_Longitude");
				this.SetAttributeValue("address2_longitude", value);
				this.OnPropertyChanged("Address2_Longitude");
			}
		}
	


		/// <summary>
		/// Digite um nome descritivo para o endereço secundário, como Matriz Corporativa.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_name")]
		public string Address2_Name
		{
			get
			{
				return this.GetAttributeValue<string>("address2_name");
			}
			set
			{
				this.OnPropertyChanging("Address2_Name");
				this.SetAttributeValue("address2_name", value);
				this.OnPropertyChanged("Address2_Name");
			}
		}
	


		/// <summary>
		/// Digite o CEP do endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postalcode")]
		public string Address2_PostalCode
		{
			get
			{
				return this.GetAttributeValue<string>("address2_postalcode");
			}
			set
			{
				this.OnPropertyChanging("Address2_PostalCode");
				this.SetAttributeValue("address2_postalcode", value);
				this.OnPropertyChanged("Address2_PostalCode");
			}
		}
	


		/// <summary>
		/// Digite o número da caixa postal do endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postofficebox")]
		public string Address2_PostOfficeBox
		{
			get
			{
				return this.GetAttributeValue<string>("address2_postofficebox");
			}
			set
			{
				this.OnPropertyChanging("Address2_PostOfficeBox");
				this.SetAttributeValue("address2_postofficebox", value);
				this.OnPropertyChanged("Address2_PostOfficeBox");
			}
		}
	


		/// <summary>
		/// Digite o nome do contato principal no endereço secundário da conta.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_primarycontactname")]
		public string Address2_PrimaryContactName
		{
			get
			{
				return this.GetAttributeValue<string>("address2_primarycontactname");
			}
			set
			{
				this.OnPropertyChanging("Address2_PrimaryContactName");
				this.SetAttributeValue("address2_primarycontactname", value);
				this.OnPropertyChanged("Address2_PrimaryContactName");
			}
		}
	


		/// <summary>
		/// Escolha uma forma de transporte para entregas enviadas para este endereço.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_shippingmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address2_ShippingMethodCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_shippingmethodcode");
			}
			set
			{
				this.OnPropertyChanging("Address2_ShippingMethodCode");
				this.SetAttributeValue("address2_shippingmethodcode", value);
				this.OnPropertyChanged("Address2_ShippingMethodCode");
			}
		}
	
		public virtual Enums.Address2_ShippingMethodCode? Address2_ShippingMethodCodeEnum
		{
			get
			{
				return ((Enums.Address2_ShippingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "address2_shippingmethodcode")));
			}
			set
			{
				Address2_ShippingMethodCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Digite o estado ou província do endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_stateorprovince")]
		public string Address2_StateOrProvince
		{
			get
			{
				return this.GetAttributeValue<string>("address2_stateorprovince");
			}
			set
			{
				this.OnPropertyChanging("Address2_StateOrProvince");
				this.SetAttributeValue("address2_stateorprovince", value);
				this.OnPropertyChanged("Address2_StateOrProvince");
			}
		}
	


		/// <summary>
		/// Digite o número do telefone principal associado ao endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone1")]
		public string Address2_Telephone1
		{
			get
			{
				return this.GetAttributeValue<string>("address2_telephone1");
			}
			set
			{
				this.OnPropertyChanging("Address2_Telephone1");
				this.SetAttributeValue("address2_telephone1", value);
				this.OnPropertyChanged("Address2_Telephone1");
			}
		}
	


		/// <summary>
		/// Digite um segundo número de telefone associado ao endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone2")]
		public string Address2_Telephone2
		{
			get
			{
				return this.GetAttributeValue<string>("address2_telephone2");
			}
			set
			{
				this.OnPropertyChanging("Address2_Telephone2");
				this.SetAttributeValue("address2_telephone2", value);
				this.OnPropertyChanged("Address2_Telephone2");
			}
		}
	


		/// <summary>
		/// Digite um terceiro número de telefone associado ao endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone3")]
		public string Address2_Telephone3
		{
			get
			{
				return this.GetAttributeValue<string>("address2_telephone3");
			}
			set
			{
				this.OnPropertyChanging("Address2_Telephone3");
				this.SetAttributeValue("address2_telephone3", value);
				this.OnPropertyChanged("Address2_Telephone3");
			}
		}
	


		/// <summary>
		/// Digite a zona UPS do endereço secundário para garantir que os encargos de remessa sejam calculados corretamente e as entregas sejam feitas imediatamente, quando enviado por UPS.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_upszone")]
		public string Address2_UPSZone
		{
			get
			{
				return this.GetAttributeValue<string>("address2_upszone");
			}
			set
			{
				this.OnPropertyChanging("Address2_UPSZone");
				this.SetAttributeValue("address2_upszone", value);
				this.OnPropertyChanged("Address2_UPSZone");
			}
		}
	


		/// <summary>
		/// Escolha o fuso horário ou a compensação UTC deste endereço para que outras pessoas possam fazer referência a ele ao contatar alguém nesse endereço.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_utcoffset")]
		public System.Nullable<int> Address2_UTCOffset
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("address2_utcoffset");
			}
			set
			{
				this.OnPropertyChanging("Address2_UTCOffset");
				this.SetAttributeValue("address2_utcoffset", value);
				this.OnPropertyChanged("Address2_UTCOffset");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo do endereço 3.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_addressid")]
		public System.Nullable<System.Guid> Address3_AddressId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("address3_addressid");
			}
			set
			{
				this.OnPropertyChanging("Address3_AddressId");
				this.SetAttributeValue("address3_addressid", value);
				this.OnPropertyChanged("Address3_AddressId");
			}
		}
	


		/// <summary>
		/// Selecione o terceiro tipo de endereço.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_addresstypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address3_AddressTypeCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address3_addresstypecode");
			}
			set
			{
				this.OnPropertyChanging("Address3_AddressTypeCode");
				this.SetAttributeValue("address3_addresstypecode", value);
				this.OnPropertyChanged("Address3_AddressTypeCode");
			}
		}
	
		public virtual Enums.Address3_AddressTypeCode? Address3_AddressTypeCodeEnum
		{
			get
			{
				return ((Enums.Address3_AddressTypeCode?)(EntityOptionSetEnum.GetEnum(this, "address3_addresstypecode")));
			}
			set
			{
				Address3_AddressTypeCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Digite a cidade do 3º endereço.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_city")]
		public string Address3_City
		{
			get
			{
				return this.GetAttributeValue<string>("address3_city");
			}
			set
			{
				this.OnPropertyChanging("Address3_City");
				this.SetAttributeValue("address3_city", value);
				this.OnPropertyChanged("Address3_City");
			}
		}
	


		/// <summary>
		/// Mostra o terceiro endereço completo.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_composite")]
		public string Address3_Composite
		{
			get
			{
				return this.GetAttributeValue<string>("address3_composite");
			}
		}
	


		/// <summary>
		/// o país ou região do 3º endereço.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_country")]
		public string Address3_Country
		{
			get
			{
				return this.GetAttributeValue<string>("address3_country");
			}
			set
			{
				this.OnPropertyChanging("Address3_Country");
				this.SetAttributeValue("address3_country", value);
				this.OnPropertyChanged("Address3_Country");
			}
		}
	


		/// <summary>
		/// Digite o município do terceiro endereço.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_county")]
		public string Address3_County
		{
			get
			{
				return this.GetAttributeValue<string>("address3_county");
			}
			set
			{
				this.OnPropertyChanging("Address3_County");
				this.SetAttributeValue("address3_county", value);
				this.OnPropertyChanged("Address3_County");
			}
		}
	


		/// <summary>
		/// Digite o número do fax associado ao terceiro endereço.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_fax")]
		public string Address3_Fax
		{
			get
			{
				return this.GetAttributeValue<string>("address3_fax");
			}
			set
			{
				this.OnPropertyChanging("Address3_Fax");
				this.SetAttributeValue("address3_fax", value);
				this.OnPropertyChanged("Address3_Fax");
			}
		}
	


		/// <summary>
		/// Escolha as condições de frete do terceiro endereço para garantir que as ordens de remessa sejam processadas corretamente.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_freighttermscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address3_FreightTermsCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address3_freighttermscode");
			}
			set
			{
				this.OnPropertyChanging("Address3_FreightTermsCode");
				this.SetAttributeValue("address3_freighttermscode", value);
				this.OnPropertyChanged("Address3_FreightTermsCode");
			}
		}
	
		public virtual Enums.Address3_FreightTermsCode? Address3_FreightTermsCodeEnum
		{
			get
			{
				return ((Enums.Address3_FreightTermsCode?)(EntityOptionSetEnum.GetEnum(this, "address3_freighttermscode")));
			}
			set
			{
				Address3_FreightTermsCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Digite o valor da latitude do terceiro endereço para uso no mapeamento e em outros aplicativos.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_latitude")]
		public System.Nullable<double> Address3_Latitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address3_latitude");
			}
			set
			{
				this.OnPropertyChanging("Address3_Latitude");
				this.SetAttributeValue("address3_latitude", value);
				this.OnPropertyChanged("Address3_Latitude");
			}
		}
	


		/// <summary>
		/// a primeira linha do 3º endereço.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_line1")]
		public string Address3_Line1
		{
			get
			{
				return this.GetAttributeValue<string>("address3_line1");
			}
			set
			{
				this.OnPropertyChanging("Address3_Line1");
				this.SetAttributeValue("address3_line1", value);
				this.OnPropertyChanged("Address3_Line1");
			}
		}
	


		/// <summary>
		/// a segunda linha do 3º endereço.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_line2")]
		public string Address3_Line2
		{
			get
			{
				return this.GetAttributeValue<string>("address3_line2");
			}
			set
			{
				this.OnPropertyChanging("Address3_Line2");
				this.SetAttributeValue("address3_line2", value);
				this.OnPropertyChanged("Address3_Line2");
			}
		}
	


		/// <summary>
		/// a terceira linha do 3º endereço.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_line3")]
		public string Address3_Line3
		{
			get
			{
				return this.GetAttributeValue<string>("address3_line3");
			}
			set
			{
				this.OnPropertyChanging("Address3_Line3");
				this.SetAttributeValue("address3_line3", value);
				this.OnPropertyChanged("Address3_Line3");
			}
		}
	


		/// <summary>
		/// Digite o valor da longitude do terceiro endereço para uso no mapeamento e em outros aplicativos.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_longitude")]
		public System.Nullable<double> Address3_Longitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address3_longitude");
			}
			set
			{
				this.OnPropertyChanging("Address3_Longitude");
				this.SetAttributeValue("address3_longitude", value);
				this.OnPropertyChanged("Address3_Longitude");
			}
		}
	


		/// <summary>
		/// Digite um nome descritivo para o terceiro endereço, como Matriz Corporativa.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_name")]
		public string Address3_Name
		{
			get
			{
				return this.GetAttributeValue<string>("address3_name");
			}
			set
			{
				this.OnPropertyChanging("Address3_Name");
				this.SetAttributeValue("address3_name", value);
				this.OnPropertyChanged("Address3_Name");
			}
		}
	


		/// <summary>
		/// o CEP do 3º endereço.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_postalcode")]
		public string Address3_PostalCode
		{
			get
			{
				return this.GetAttributeValue<string>("address3_postalcode");
			}
			set
			{
				this.OnPropertyChanging("Address3_PostalCode");
				this.SetAttributeValue("address3_postalcode", value);
				this.OnPropertyChanged("Address3_PostalCode");
			}
		}
	


		/// <summary>
		/// o número da caixa postal do 3º endereço.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_postofficebox")]
		public string Address3_PostOfficeBox
		{
			get
			{
				return this.GetAttributeValue<string>("address3_postofficebox");
			}
			set
			{
				this.OnPropertyChanging("Address3_PostOfficeBox");
				this.SetAttributeValue("address3_postofficebox", value);
				this.OnPropertyChanged("Address3_PostOfficeBox");
			}
		}
	


		/// <summary>
		/// Digite o nome do contato principal no terceiro endereço da conta.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_primarycontactname")]
		public string Address3_PrimaryContactName
		{
			get
			{
				return this.GetAttributeValue<string>("address3_primarycontactname");
			}
			set
			{
				this.OnPropertyChanging("Address3_PrimaryContactName");
				this.SetAttributeValue("address3_primarycontactname", value);
				this.OnPropertyChanged("Address3_PrimaryContactName");
			}
		}
	


		/// <summary>
		/// Escolha uma forma de transporte para entregas enviadas para este endereço.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_shippingmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address3_ShippingMethodCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address3_shippingmethodcode");
			}
			set
			{
				this.OnPropertyChanging("Address3_ShippingMethodCode");
				this.SetAttributeValue("address3_shippingmethodcode", value);
				this.OnPropertyChanged("Address3_ShippingMethodCode");
			}
		}
	
		public virtual Enums.Address3_ShippingMethodCode? Address3_ShippingMethodCodeEnum
		{
			get
			{
				return ((Enums.Address3_ShippingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "address3_shippingmethodcode")));
			}
			set
			{
				Address3_ShippingMethodCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// o estado ou província do terceiro endereço.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_stateorprovince")]
		public string Address3_StateOrProvince
		{
			get
			{
				return this.GetAttributeValue<string>("address3_stateorprovince");
			}
			set
			{
				this.OnPropertyChanging("Address3_StateOrProvince");
				this.SetAttributeValue("address3_stateorprovince", value);
				this.OnPropertyChanged("Address3_StateOrProvince");
			}
		}
	


		/// <summary>
		/// Digite o número do telefone principal associado ao terceiro endereço.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_telephone1")]
		public string Address3_Telephone1
		{
			get
			{
				return this.GetAttributeValue<string>("address3_telephone1");
			}
			set
			{
				this.OnPropertyChanging("Address3_Telephone1");
				this.SetAttributeValue("address3_telephone1", value);
				this.OnPropertyChanged("Address3_Telephone1");
			}
		}
	


		/// <summary>
		/// Digite um segundo número de telefone associado ao terceiro endereço.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_telephone2")]
		public string Address3_Telephone2
		{
			get
			{
				return this.GetAttributeValue<string>("address3_telephone2");
			}
			set
			{
				this.OnPropertyChanging("Address3_Telephone2");
				this.SetAttributeValue("address3_telephone2", value);
				this.OnPropertyChanged("Address3_Telephone2");
			}
		}
	


		/// <summary>
		/// Digite um terceiro número de telefone associado ao endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_telephone3")]
		public string Address3_Telephone3
		{
			get
			{
				return this.GetAttributeValue<string>("address3_telephone3");
			}
			set
			{
				this.OnPropertyChanging("Address3_Telephone3");
				this.SetAttributeValue("address3_telephone3", value);
				this.OnPropertyChanged("Address3_Telephone3");
			}
		}
	


		/// <summary>
		/// Digite a zona UPS do terceiro endereço para garantir que os encargos de remessa sejam calculados corretamente e as entregas sejam feitas imediatamente, quando enviado por UPS.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_upszone")]
		public string Address3_UPSZone
		{
			get
			{
				return this.GetAttributeValue<string>("address3_upszone");
			}
			set
			{
				this.OnPropertyChanging("Address3_UPSZone");
				this.SetAttributeValue("address3_upszone", value);
				this.OnPropertyChanged("Address3_UPSZone");
			}
		}
	


		/// <summary>
		/// Escolha o fuso horário ou a compensação UTC deste endereço para que outras pessoas possam fazer referência a ele ao contatar alguém nesse endereço.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_utcoffset")]
		public System.Nullable<int> Address3_UTCOffset
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("address3_utcoffset");
			}
			set
			{
				this.OnPropertyChanging("Address3_UTCOffset");
				this.SetAttributeValue("address3_utcoffset", value);
				this.OnPropertyChanged("Address3_UTCOffset");
			}
		}
	


		/// <summary>
		/// Somente para uso do sistema.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging30")]
		public Microsoft.Xrm.Sdk.Money Aging30
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging30");
			}
		}
	


		/// <summary>
		/// Mostra o campo Vencimento em 30 dias convertido na moeda base padrão do sistema. Os cálculos usam a taxa de conversão especificada na área Moedas.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging30_base")]
		public Microsoft.Xrm.Sdk.Money Aging30_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging30_base");
			}
		}
	


		/// <summary>
		/// Somente para uso do sistema.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging60")]
		public Microsoft.Xrm.Sdk.Money Aging60
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging60");
			}
		}
	


		/// <summary>
		/// Mostra o campo Vencimento em 60 dias convertido na moeda base padrão do sistema. Os cálculos usam a taxa de conversão especificada na área Moedas.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging60_base")]
		public Microsoft.Xrm.Sdk.Money Aging60_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging60_base");
			}
		}
	


		/// <summary>
		/// Somente para uso do sistema.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging90")]
		public Microsoft.Xrm.Sdk.Money Aging90
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging90");
			}
		}
	


		/// <summary>
		/// Mostra o campo Vencimento em 90 dias convertido na moeda base padrão do sistema. Os cálculos usam a taxa de conversão especificada na área Moedas.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging90_base")]
		public Microsoft.Xrm.Sdk.Money Aging90_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging90_base");
			}
		}
	


		/// <summary>
		/// Insira a data do aniversário de casamento ou de serviço do contato para uso em programas de presentes para clientes ou outras comunicações.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("anniversary")]
		public System.Nullable<System.DateTime> Anniversary
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("anniversary");
			}
			set
			{
				this.OnPropertyChanging("Anniversary");
				this.SetAttributeValue("anniversary", value);
				this.OnPropertyChanged("Anniversary");
			}
		}
	


		/// <summary>
		/// Digite a receita anual do contato para uso na criação de perfil e na análise financeira.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("annualincome")]
		public Microsoft.Xrm.Sdk.Money AnnualIncome
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("annualincome");
			}
			set
			{
				this.OnPropertyChanging("AnnualIncome");
				this.SetAttributeValue("annualincome", value);
				this.OnPropertyChanged("AnnualIncome");
			}
		}
	


		/// <summary>
		/// Mostra o campo Receita Anual convertida na moeda base padrão do sistema. Os cálculos usam a taxa de conversão especificada na área Moedas.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("annualincome_base")]
		public Microsoft.Xrm.Sdk.Money AnnualIncome_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("annualincome_base");
			}
		}
	


		/// <summary>
		/// Digite o nome do assistente do contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("assistantname")]
		public string AssistantName
		{
			get
			{
				return this.GetAttributeValue<string>("assistantname");
			}
			set
			{
				this.OnPropertyChanging("AssistantName");
				this.SetAttributeValue("assistantname", value);
				this.OnPropertyChanged("AssistantName");
			}
		}
	


		/// <summary>
		/// Digite o número do telefone do assistente do contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("assistantphone")]
		public string AssistantPhone
		{
			get
			{
				return this.GetAttributeValue<string>("assistantphone");
			}
			set
			{
				this.OnPropertyChanging("AssistantPhone");
				this.SetAttributeValue("assistantphone", value);
				this.OnPropertyChanged("AssistantPhone");
			}
		}
	


		/// <summary>
		/// Insira a data do aniversário do contato para uso em programas de presentes para clientes ou outras comunicações.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("birthdate")]
		public System.Nullable<System.DateTime> BirthDate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("birthdate");
			}
			set
			{
				this.OnPropertyChanging("BirthDate");
				this.SetAttributeValue("birthdate", value);
				this.OnPropertyChanged("BirthDate");
			}
		}
	


		/// <summary>
		/// Digite um segundo número do telefone comercial deste contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("business2")]
		public string Business2
		{
			get
			{
				return this.GetAttributeValue<string>("business2");
			}
			set
			{
				this.OnPropertyChanging("Business2");
				this.SetAttributeValue("business2", value);
				this.OnPropertyChanged("Business2");
			}
		}
	


		/// <summary>
		/// Digite um segundo número do telefone para retorno de chamada deste contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("callback")]
		public string Callback
		{
			get
			{
				return this.GetAttributeValue<string>("callback");
			}
			set
			{
				this.OnPropertyChanging("Callback");
				this.SetAttributeValue("callback", value);
				this.OnPropertyChanged("Callback");
			}
		}
	


		/// <summary>
		/// Digite os nomes dos filhos do contato para referência em comunicações e programas de clientes.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("childrensnames")]
		public string ChildrensNames
		{
			get
			{
				return this.GetAttributeValue<string>("childrensnames");
			}
			set
			{
				this.OnPropertyChanging("ChildrensNames");
				this.SetAttributeValue("childrensnames", value);
				this.OnPropertyChanged("ChildrensNames");
			}
		}
	


		/// <summary>
		/// Digite o telefone da empresa do contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("company")]
		public string Company
		{
			get
			{
				return this.GetAttributeValue<string>("company");
			}
			set
			{
				this.OnPropertyChanging("Company");
				this.SetAttributeValue("company", value);
				this.OnPropertyChanged("Company");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo do contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contactid")]
		public System.Nullable<System.Guid> ContactId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("contactid");
			}
			set
			{
				this.OnPropertyChanging("ContactId");
				this.SetAttributeValue("contactid", value);
						if (value.HasValue)
						{
							base.Id = value.Value;
						}
						else
						{
							base.Id = System.Guid.Empty;
						}
				this.OnPropertyChanged("ContactId");
			}
		}
	


		/// <summary>
		/// Mostra quem criou o registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
	


		/// <summary>
		/// Mostra o participante externo que criou o registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdbyexternalparty")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedByExternalParty
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdbyexternalparty");
			}
		}
	




		/// <summary>
		/// Mostra a data e a hora em que o registro foi criado. A data e a hora são exibidas no fuso horário escolhido nas opções do Microsoft Dynamics 365.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
	


		/// <summary>
		/// Mostra quem criou o registro em nome de outro usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
	



		/// <summary>
		/// Digite o limite de crédito do contato para referência ao resolver problemas de faturamento e de contabilidade com o cliente.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("creditlimit")]
		public Microsoft.Xrm.Sdk.Money CreditLimit
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("creditlimit");
			}
			set
			{
				this.OnPropertyChanging("CreditLimit");
				this.SetAttributeValue("creditlimit", value);
				this.OnPropertyChanged("CreditLimit");
			}
		}
	


		/// <summary>
		/// Mostra o campo Limite de Crédito convertido na moeda base padrão do sistema para fins de relatórios. Os cálculos usam a taxa de conversão especificada na área Moedas.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("creditlimit_base")]
		public Microsoft.Xrm.Sdk.Money CreditLimit_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("creditlimit_base");
			}
		}
	


		/// <summary>
		/// Escolha se o contato está em suspensão de crédito, para referência ao resolver problemas de faturamento e de contabilidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("creditonhold")]
		public System.Nullable<bool> CreditOnHold
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("creditonhold");
			}
			set
			{
				this.OnPropertyChanging("CreditOnHold");
				this.SetAttributeValue("creditonhold", value);
				this.OnPropertyChanged("CreditOnHold");
			}
		}
	
		public virtual Enums.CreditOnHold? CreditOnHoldEnum
		{
			get
			{
				return ((Enums.CreditOnHold?)(EntityOptionSetEnum.GetEnum(this, "creditonhold")));
			}
			set
			{
		       if (value.HasValue)
                    CreditOnHold = ((int)value == 1);
                else                   
                    CreditOnHold = null;
			}
		}


		/// <summary>
		/// Escolha o tamanho da empresa do contato para fins de segmentação e relatórios.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customersizecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue CustomerSizeCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("customersizecode");
			}
			set
			{
				this.OnPropertyChanging("CustomerSizeCode");
				this.SetAttributeValue("customersizecode", value);
				this.OnPropertyChanged("CustomerSizeCode");
			}
		}
	
		public virtual Enums.CustomerSizeCode? CustomerSizeCodeEnum
		{
			get
			{
				return ((Enums.CustomerSizeCode?)(EntityOptionSetEnum.GetEnum(this, "customersizecode")));
			}
			set
			{
				CustomerSizeCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Escolha a categoria que melhor descreve o relacionamento entre o contato e sua organização.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customertypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue CustomerTypeCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("customertypecode");
			}
			set
			{
				this.OnPropertyChanging("CustomerTypeCode");
				this.SetAttributeValue("customertypecode", value);
				this.OnPropertyChanged("CustomerTypeCode");
			}
		}
	
		public virtual Enums.CustomerTypeCode? CustomerTypeCodeEnum
		{
			get
			{
				return ((Enums.CustomerTypeCode?)(EntityOptionSetEnum.GetEnum(this, "customertypecode")));
			}
			set
			{
				CustomerTypeCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Escolha a lista de preços padrão associada ao contato para ter certeza de que os preços de produtos corretos para este cliente sejam aplicados em oportunidades de vendas, cotações e ordens.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultpricelevelid")]
		public Microsoft.Xrm.Sdk.EntityReference DefaultPriceLevelId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("defaultpricelevelid");
			}
			set
			{
				this.OnPropertyChanging("DefaultPriceLevelId");
				this.SetAttributeValue("defaultpricelevelid", value);
				this.OnPropertyChanged("DefaultPriceLevelId");
			}
		}
	



		/// <summary>
		/// Digite o departamento ou a unidade de negócios onde o contato trabalha na empresa ou negócio primário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("department")]
		public string Department
		{
			get
			{
				return this.GetAttributeValue<string>("department");
			}
			set
			{
				this.OnPropertyChanging("Department");
				this.SetAttributeValue("department", value);
				this.OnPropertyChanged("Department");
			}
		}
	


		/// <summary>
		/// Digite informações adicionais para descrever o contato, como um extrato do site da empresa.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			set
			{
				this.OnPropertyChanging("Description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("Description");
			}
		}
	


		/// <summary>
		/// Escolha se o contato aceita envio de email em massa em campanhas de marketing ou rápidas. Se Não Permitir estiver escolhido, o contato poderá ser adicionado às listas de marketing, mas será excluído do email.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotbulkemail")]
		public System.Nullable<bool> DoNotBulkEMail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotbulkemail");
			}
			set
			{
				this.OnPropertyChanging("DoNotBulkEMail");
				this.SetAttributeValue("donotbulkemail", value);
				this.OnPropertyChanged("DoNotBulkEMail");
			}
		}
	
		public virtual Enums.DoNotBulkEMail? DoNotBulkEMailEnum
		{
			get
			{
				return ((Enums.DoNotBulkEMail?)(EntityOptionSetEnum.GetEnum(this, "donotbulkemail")));
			}
			set
			{
		       if (value.HasValue)
                    DoNotBulkEMail = ((int)value == 1);
                else                   
                    DoNotBulkEMail = null;
			}
		}


		/// <summary>
		/// Escolha se o contato aceita envio de correio em massa em campanhas de marketing ou rápidas. Se Não Permitir estiver escolhido, o contato poderá ser adicionado às listas de marketing, mas será excluído de cartas.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotbulkpostalmail")]
		public System.Nullable<bool> DoNotBulkPostalMail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotbulkpostalmail");
			}
			set
			{
				this.OnPropertyChanging("DoNotBulkPostalMail");
				this.SetAttributeValue("donotbulkpostalmail", value);
				this.OnPropertyChanged("DoNotBulkPostalMail");
			}
		}
	
		public virtual Enums.DoNotBulkPostalMail? DoNotBulkPostalMailEnum
		{
			get
			{
				return ((Enums.DoNotBulkPostalMail?)(EntityOptionSetEnum.GetEnum(this, "donotbulkpostalmail")));
			}
			set
			{
		       if (value.HasValue)
                    DoNotBulkPostalMail = ((int)value == 1);
                else                   
                    DoNotBulkPostalMail = null;
			}
		}


		/// <summary>
		/// Escolha se o contato permite o envio de email direto do Microsoft Dynamics 365. Se Não Permitir estiver escolhido, o Microsoft Dynamics 365 não enviará o email.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotemail")]
		public System.Nullable<bool> DoNotEMail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotemail");
			}
			set
			{
				this.OnPropertyChanging("DoNotEMail");
				this.SetAttributeValue("donotemail", value);
				this.OnPropertyChanged("DoNotEMail");
			}
		}
	
		public virtual Enums.DoNotEMail? DoNotEMailEnum
		{
			get
			{
				return ((Enums.DoNotEMail?)(EntityOptionSetEnum.GetEnum(this, "donotemail")));
			}
			set
			{
		       if (value.HasValue)
                    DoNotEMail = ((int)value == 1);
                else                   
                    DoNotEMail = null;
			}
		}


		/// <summary>
		/// Escolha se o contato permite fax. Se Não Permitir estiver escolhido, o contato será excluído de todas as atividades de fax distribuídas em campanhas de marketing.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotfax")]
		public System.Nullable<bool> DoNotFax
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotfax");
			}
			set
			{
				this.OnPropertyChanging("DoNotFax");
				this.SetAttributeValue("donotfax", value);
				this.OnPropertyChanged("DoNotFax");
			}
		}
	
		public virtual Enums.DoNotFax? DoNotFaxEnum
		{
			get
			{
				return ((Enums.DoNotFax?)(EntityOptionSetEnum.GetEnum(this, "donotfax")));
			}
			set
			{
		       if (value.HasValue)
                    DoNotFax = ((int)value == 1);
                else                   
                    DoNotFax = null;
			}
		}


		/// <summary>
		/// Escolha se o contato aceita telefonemas. Se Não Permitir estiver escolhido, o contato será excluído de todas as atividades de telefonemas distribuídas em campanhas de marketing.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotphone")]
		public System.Nullable<bool> DoNotPhone
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotphone");
			}
			set
			{
				this.OnPropertyChanging("DoNotPhone");
				this.SetAttributeValue("donotphone", value);
				this.OnPropertyChanged("DoNotPhone");
			}
		}
	
		public virtual Enums.DoNotPhone? DoNotPhoneEnum
		{
			get
			{
				return ((Enums.DoNotPhone?)(EntityOptionSetEnum.GetEnum(this, "donotphone")));
			}
			set
			{
		       if (value.HasValue)
                    DoNotPhone = ((int)value == 1);
                else                   
                    DoNotPhone = null;
			}
		}


		/// <summary>
		/// Escolha se o contato permite email direto. Se Não Permitir estiver escolhido, o contato será excluído das atividades de cartas distribuídas em campanhas de marketing.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotpostalmail")]
		public System.Nullable<bool> DoNotPostalMail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotpostalmail");
			}
			set
			{
				this.OnPropertyChanging("DoNotPostalMail");
				this.SetAttributeValue("donotpostalmail", value);
				this.OnPropertyChanged("DoNotPostalMail");
			}
		}
	
		public virtual Enums.DoNotPostalMail? DoNotPostalMailEnum
		{
			get
			{
				return ((Enums.DoNotPostalMail?)(EntityOptionSetEnum.GetEnum(this, "donotpostalmail")));
			}
			set
			{
		       if (value.HasValue)
                    DoNotPostalMail = ((int)value == 1);
                else                   
                    DoNotPostalMail = null;
			}
		}


		/// <summary>
		/// Escolha se o contato aceita materiais de marketing, como brochuras ou catálogos. Os contatos que recusarem podem ser excluídos das iniciativas de marketing.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotsendmm")]
		public System.Nullable<bool> DoNotSendMM
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotsendmm");
			}
			set
			{
				this.OnPropertyChanging("DoNotSendMM");
				this.SetAttributeValue("donotsendmm", value);
				this.OnPropertyChanged("DoNotSendMM");
			}
		}
	
		public virtual Enums.DoNotSendMM? DoNotSendMMEnum
		{
			get
			{
				return ((Enums.DoNotSendMM?)(EntityOptionSetEnum.GetEnum(this, "donotsendmm")));
			}
			set
			{
		       if (value.HasValue)
                    DoNotSendMM = ((int)value == 1);
                else                   
                    DoNotSendMM = null;
			}
		}


		/// <summary>
		/// Escolha o mais alto nível de formação acadêmica do contato para uso em segmentação de marketing e análise.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("educationcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue EducationCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("educationcode");
			}
			set
			{
				this.OnPropertyChanging("EducationCode");
				this.SetAttributeValue("educationcode", value);
				this.OnPropertyChanged("EducationCode");
			}
		}
	
		public virtual Enums.EducationCode? EducationCodeEnum
		{
			get
			{
				return ((Enums.EducationCode?)(EntityOptionSetEnum.GetEnum(this, "educationcode")));
			}
			set
			{
				EducationCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Digite o endereço de email principal do contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress1")]
		public string EMailAddress1
		{
			get
			{
				return this.GetAttributeValue<string>("emailaddress1");
			}
			set
			{
				this.OnPropertyChanging("EMailAddress1");
				this.SetAttributeValue("emailaddress1", value);
				this.OnPropertyChanged("EMailAddress1");
			}
		}
	


		/// <summary>
		/// Digite o endereço de email secundário do contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress2")]
		public string EMailAddress2
		{
			get
			{
				return this.GetAttributeValue<string>("emailaddress2");
			}
			set
			{
				this.OnPropertyChanging("EMailAddress2");
				this.SetAttributeValue("emailaddress2", value);
				this.OnPropertyChanged("EMailAddress2");
			}
		}
	


		/// <summary>
		/// Digite o endereço de email alternativo do contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress3")]
		public string EMailAddress3
		{
			get
			{
				return this.GetAttributeValue<string>("emailaddress3");
			}
			set
			{
				this.OnPropertyChanging("EMailAddress3");
				this.SetAttributeValue("emailaddress3", value);
				this.OnPropertyChanged("EMailAddress3");
			}
		}
	


		/// <summary>
		/// Digite a ID ou o número de funcionário do contato para referência em ordens, ocorrências de serviços ou outras comunicações com a organização do contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("employeeid")]
		public string EmployeeId
		{
			get
			{
				return this.GetAttributeValue<string>("employeeid");
			}
			set
			{
				this.OnPropertyChanging("EmployeeId");
				this.SetAttributeValue("employeeid", value);
				this.OnPropertyChanged("EmployeeId");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage")]
		public byte[] EntityImage
		{
			get
			{
				return this.GetAttributeValue<byte[]>("entityimage");
			}
			set
			{
				this.OnPropertyChanging("EntityImage");
				this.SetAttributeValue("entityimage", value);
				this.OnPropertyChanged("EntityImage");
			}
		}
	


		/// <summary>
		///  
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_timestamp")]
		public System.Nullable<long> EntityImage_Timestamp
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("entityimage_timestamp");
			}
		}
	


		/// <summary>
		///  
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_url")]
		public string EntityImage_URL
		{
			get
			{
				return this.GetAttributeValue<string>("entityimage_url");
			}
		}
	


		/// <summary>
		/// Somente para uso interno.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimageid")]
		public System.Nullable<System.Guid> EntityImageId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("entityimageid");
			}
		}
	


		/// <summary>
		/// Mostra a taxa de conversão da moeda do registro. A taxa de conversão é usada para converter todos os campos de money do registro, da moeda local para a moeda padrão do sistema.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
		public System.Nullable<decimal> ExchangeRate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
			}
		}
	


		/// <summary>
		/// Identificador de um usuário externo.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("externaluseridentifier")]
		public string ExternalUserIdentifier
		{
			get
			{
				return this.GetAttributeValue<string>("externaluseridentifier");
			}
			set
			{
				this.OnPropertyChanging("ExternalUserIdentifier");
				this.SetAttributeValue("externaluseridentifier", value);
				this.OnPropertyChanged("ExternalUserIdentifier");
			}
		}
	


		/// <summary>
		/// Estado civil do contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("familystatuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue FamilyStatusCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("familystatuscode");
			}
			set
			{
				this.OnPropertyChanging("FamilyStatusCode");
				this.SetAttributeValue("familystatuscode", value);
				this.OnPropertyChanged("FamilyStatusCode");
			}
		}
	
		public virtual Enums.FamilyStatusCode? FamilyStatusCodeEnum
		{
			get
			{
				return ((Enums.FamilyStatusCode?)(EntityOptionSetEnum.GetEnum(this, "familystatuscode")));
			}
			set
			{
				FamilyStatusCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Digite o número do fax do contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fax")]
		public string Fax
		{
			get
			{
				return this.GetAttributeValue<string>("fax");
			}
			set
			{
				this.OnPropertyChanging("Fax");
				this.SetAttributeValue("fax", value);
				this.OnPropertyChanged("Fax");
			}
		}
	


		/// <summary>
		/// Digite o nome do contato para garantir que o contato seja tratado corretamente em chamadas de vendas, emails e campanhas de marketing.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("firstname")]
		public string FirstName
		{
			get
			{
				return this.GetAttributeValue<string>("firstname");
			}
			set
			{
				this.OnPropertyChanging("FirstName");
				this.SetAttributeValue("firstname", value);
				this.OnPropertyChanged("FirstName");
			}
		}
	


		/// <summary>
		/// Informações que especificam se será permitido acompanhar atividades de email, como aberturas, exibições de anexo e cliques em links nos emails enviados ao contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("followemail")]
		public System.Nullable<bool> FollowEmail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("followemail");
			}
			set
			{
				this.OnPropertyChanging("FollowEmail");
				this.SetAttributeValue("followemail", value);
				this.OnPropertyChanged("FollowEmail");
			}
		}
	
		public virtual Enums.FollowEmail? FollowEmailEnum
		{
			get
			{
				return ((Enums.FollowEmail?)(EntityOptionSetEnum.GetEnum(this, "followemail")));
			}
			set
			{
		       if (value.HasValue)
                    FollowEmail = ((int)value == 1);
                else                   
                    FollowEmail = null;
			}
		}


		/// <summary>
		/// Digite a URL do site de FTP do contato para permitir que os usuários acessem dados e compartilhem documentos.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ftpsiteurl")]
		public string FtpSiteUrl
		{
			get
			{
				return this.GetAttributeValue<string>("ftpsiteurl");
			}
			set
			{
				this.OnPropertyChanging("FtpSiteUrl");
				this.SetAttributeValue("ftpsiteurl", value);
				this.OnPropertyChanged("FtpSiteUrl");
			}
		}
	


		/// <summary>
		/// Combina e mostra o nome e o sobrenome do contato, para que o nome completo possa ser mostrado em exibições e relatórios.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fullname")]
		public string FullName
		{
			get
			{
				return this.GetAttributeValue<string>("fullname");
			}
		}
	


		/// <summary>
		/// Escolha o sexo do contato para garantir que o contato seja tratado corretamente em chamadas de vendas, emails e campanhas de marketing.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("gendercode")]
		public Microsoft.Xrm.Sdk.OptionSetValue GenderCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("gendercode");
			}
			set
			{
				this.OnPropertyChanging("GenderCode");
				this.SetAttributeValue("gendercode", value);
				this.OnPropertyChanged("GenderCode");
			}
		}
	
		public virtual Enums.GenderCode? GenderCodeEnum
		{
			get
			{
				return ((Enums.GenderCode?)(EntityOptionSetEnum.GetEnum(this, "gendercode")));
			}
			set
			{
				GenderCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Digite o número do passaporte ou de outra ID do governo do contato para uso em documentos ou relatórios.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("governmentid")]
		public string GovernmentId
		{
			get
			{
				return this.GetAttributeValue<string>("governmentid");
			}
			set
			{
				this.OnPropertyChanging("GovernmentId");
				this.SetAttributeValue("governmentid", value);
				this.OnPropertyChanged("GovernmentId");
			}
		}
	


		/// <summary>
		/// Escolha se o contato tem filhos para referência em telefonemas de acompanhamento e outras comunicações.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("haschildrencode")]
		public Microsoft.Xrm.Sdk.OptionSetValue HasChildrenCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("haschildrencode");
			}
			set
			{
				this.OnPropertyChanging("HasChildrenCode");
				this.SetAttributeValue("haschildrencode", value);
				this.OnPropertyChanged("HasChildrenCode");
			}
		}
	
		public virtual Enums.HasChildrenCode? HasChildrenCodeEnum
		{
			get
			{
				return ((Enums.HasChildrenCode?)(EntityOptionSetEnum.GetEnum(this, "haschildrencode")));
			}
			set
			{
				HasChildrenCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Digite um segundo número do telefone residencial deste contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("home2")]
		public string Home2
		{
			get
			{
				return this.GetAttributeValue<string>("home2");
			}
			set
			{
				this.OnPropertyChanging("Home2");
				this.SetAttributeValue("home2", value);
				this.OnPropertyChanged("Home2");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo da importação de dados ou migração de dados que criou este registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
	


		/// <summary>
		/// Informações sobre se o contato foi criado automaticamente durante a promoção de um email ou um compromisso.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isautocreate")]
		public System.Nullable<bool> IsAutoCreate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isautocreate");
			}
		}
	
		public virtual Enums.IsAutoCreate? IsAutoCreateEnum
		{
			get
			{
				return ((Enums.IsAutoCreate?)(EntityOptionSetEnum.GetEnum(this, "isautocreate")));
			}
		}


		/// <summary>
		/// Escolha se o contato existe em um sistema contábil ou outro sistema separado, como o Microsoft Dynamics GP ou outro banco de dados de ERP, para uso em processos de integração.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isbackofficecustomer")]
		public System.Nullable<bool> IsBackofficeCustomer
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isbackofficecustomer");
			}
			set
			{
				this.OnPropertyChanging("IsBackofficeCustomer");
				this.SetAttributeValue("isbackofficecustomer", value);
				this.OnPropertyChanged("IsBackofficeCustomer");
			}
		}
	
		public virtual Enums.IsBackofficeCustomer? IsBackofficeCustomerEnum
		{
			get
			{
				return ((Enums.IsBackofficeCustomer?)(EntityOptionSetEnum.GetEnum(this, "isbackofficecustomer")));
			}
			set
			{
		       if (value.HasValue)
                    IsBackofficeCustomer = ((int)value == 1);
                else                   
                    IsBackofficeCustomer = null;
			}
		}


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isprivate")]
		public System.Nullable<bool> IsPrivate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isprivate");
			}
		}
	
		public virtual Enums.IsPrivate? IsPrivateEnum
		{
			get
			{
				return ((Enums.IsPrivate?)(EntityOptionSetEnum.GetEnum(this, "isprivate")));
			}
		}


		/// <summary>
		/// Digite o cargo do contato para garantir que o contato seja tratado corretamente em chamadas de vendas, emails e campanhas de marketing.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("jobtitle")]
		public string JobTitle
		{
			get
			{
				return this.GetAttributeValue<string>("jobtitle");
			}
			set
			{
				this.OnPropertyChanging("JobTitle");
				this.SetAttributeValue("jobtitle", value);
				this.OnPropertyChanged("JobTitle");
			}
		}
	


		/// <summary>
		/// Digite o sobrenome do contato para garantir que o contato seja tratado corretamente em chamadas de vendas, emails e campanhas de marketing.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastname")]
		public string LastName
		{
			get
			{
				return this.GetAttributeValue<string>("lastname");
			}
			set
			{
				this.OnPropertyChanging("LastName");
				this.SetAttributeValue("lastname", value);
				this.OnPropertyChanged("LastName");
			}
		}
	


		/// <summary>
		/// Contém o carimbo de data e hora da última suspensão.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastonholdtime")]
		public System.Nullable<System.DateTime> LastOnHoldTime
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastonholdtime");
			}
			set
			{
				this.OnPropertyChanging("LastOnHoldTime");
				this.SetAttributeValue("lastonholdtime", value);
				this.OnPropertyChanged("LastOnHoldTime");
			}
		}
	


		/// <summary>
		/// Mostra a data em que o contato foi incluído pela última vez em uma campanha de marketing ou campanha rápida.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastusedincampaign")]
		public System.Nullable<System.DateTime> LastUsedInCampaign
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastusedincampaign");
			}
			set
			{
				this.OnPropertyChanging("LastUsedInCampaign");
				this.SetAttributeValue("lastusedincampaign", value);
				this.OnPropertyChanged("LastUsedInCampaign");
			}
		}
	


		/// <summary>
		/// Escolha a origem de marketing principal que direcionou o contato para sua organização.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("leadsourcecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue LeadSourceCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("leadsourcecode");
			}
			set
			{
				this.OnPropertyChanging("LeadSourceCode");
				this.SetAttributeValue("leadsourcecode", value);
				this.OnPropertyChanged("LeadSourceCode");
			}
		}
	
		public virtual Enums.LeadSourceCode? LeadSourceCodeEnum
		{
			get
			{
				return ((Enums.LeadSourceCode?)(EntityOptionSetEnum.GetEnum(this, "leadsourcecode")));
			}
			set
			{
				LeadSourceCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Digite o nome do gerente do contato para uso em problemas de escalonamento ou outras comunicações de acompanhamento com o contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("managername")]
		public string ManagerName
		{
			get
			{
				return this.GetAttributeValue<string>("managername");
			}
			set
			{
				this.OnPropertyChanging("ManagerName");
				this.SetAttributeValue("managername", value);
				this.OnPropertyChanged("ManagerName");
			}
		}
	


		/// <summary>
		/// Digite o número do telefone do gerente do contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("managerphone")]
		public string ManagerPhone
		{
			get
			{
				return this.GetAttributeValue<string>("managerphone");
			}
			set
			{
				this.OnPropertyChanging("ManagerPhone");
				this.SetAttributeValue("managerphone", value);
				this.OnPropertyChanged("ManagerPhone");
			}
		}
	


		/// <summary>
		/// Se for somente para marketing
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("marketingonly")]
		public System.Nullable<bool> MarketingOnly
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("marketingonly");
			}
			set
			{
				this.OnPropertyChanging("MarketingOnly");
				this.SetAttributeValue("marketingonly", value);
				this.OnPropertyChanged("MarketingOnly");
			}
		}
	
		public virtual Enums.MarketingOnly? MarketingOnlyEnum
		{
			get
			{
				return ((Enums.MarketingOnly?)(EntityOptionSetEnum.GetEnum(this, "marketingonly")));
			}
			set
			{
		       if (value.HasValue)
                    MarketingOnly = ((int)value == 1);
                else                   
                    MarketingOnly = null;
			}
		}


		/// <summary>
		/// Identificador exclusivo do contato mestre para mesclagem.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("masterid")]
		public Microsoft.Xrm.Sdk.EntityReference MasterId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("masterid");
			}
		}
	



		/// <summary>
		/// Mostra se a conta foi mesclada com um contato mestre.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("merged")]
		public System.Nullable<bool> Merged
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("merged");
			}
		}
	
		public virtual Enums.Merged? MergedEnum
		{
			get
			{
				return ((Enums.Merged?)(EntityOptionSetEnum.GetEnum(this, "merged")));
			}
		}


		/// <summary>
		/// Digite a inicial ou o nome do meio do contato para garantir que o contato seja tratado corretamente.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("middlename")]
		public string MiddleName
		{
			get
			{
				return this.GetAttributeValue<string>("middlename");
			}
			set
			{
				this.OnPropertyChanging("MiddleName");
				this.SetAttributeValue("middlename", value);
				this.OnPropertyChanged("MiddleName");
			}
		}
	


		/// <summary>
		/// Digite o número do celular do contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mobilephone")]
		public string MobilePhone
		{
			get
			{
				return this.GetAttributeValue<string>("mobilephone");
			}
			set
			{
				this.OnPropertyChanging("MobilePhone");
				this.SetAttributeValue("mobilephone", value);
				this.OnPropertyChanged("MobilePhone");
			}
		}
	


		/// <summary>
		/// Mostra quem atualizou o registro pela última vez.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
	


		/// <summary>
		/// Mostra o participante externo que modificou o registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedbyexternalparty")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedByExternalParty
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedbyexternalparty");
			}
		}
	




		/// <summary>
		/// Mostra a data e a hora em que o registro foi atualizado pela última vez. A data e a hora são exibidas no fuso horário escolhido nas opções do Microsoft Dynamics 365.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
	


		/// <summary>
		/// Mostra quem atualizou o registro pela última vez em nome de outro usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
	



		/// <summary>
		/// Digite o apelido do contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("nickname")]
		public string NickName
		{
			get
			{
				return this.GetAttributeValue<string>("nickname");
			}
			set
			{
				this.OnPropertyChanging("NickName");
				this.SetAttributeValue("nickname", value);
				this.OnPropertyChanged("NickName");
			}
		}
	


		/// <summary>
		/// Digite o número de filhos do contato para referência em telefonemas de acompanhamento e outras comunicações.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("numberofchildren")]
		public System.Nullable<int> NumberOfChildren
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("numberofchildren");
			}
			set
			{
				this.OnPropertyChanging("NumberOfChildren");
				this.SetAttributeValue("numberofchildren", value);
				this.OnPropertyChanged("NumberOfChildren");
			}
		}
	


		/// <summary>
		/// Mostra o tempo, em minutos, em que o registro ficou suspenso.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("onholdtime")]
		public System.Nullable<int> OnHoldTime
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("onholdtime");
			}
		}
	


		/// <summary>
		/// Mostra o lead a partir do qual o contato foi criado se o contato tiver sido criado por meio da conversão de um lead no Microsoft Dynamics 365. Isso é usado para relacionar o contato aos dados no lead original para uso em relatórios e análises.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("originatingleadid")]
		public Microsoft.Xrm.Sdk.EntityReference OriginatingLeadId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("originatingleadid");
			}
			set
			{
				this.OnPropertyChanging("OriginatingLeadId");
				this.SetAttributeValue("originatingleadid", value);
				this.OnPropertyChanged("OriginatingLeadId");
			}
		}
	



		/// <summary>
		/// Data e hora da migração do registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
	


		/// <summary>
		/// Insira o usuário ou a equipe atribuída para gerenciar o registro. Esse campo é atualizado toda vez que o registro é atribuído a outro usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			set
			{
				this.OnPropertyChanging("OwnerId");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo da unidade de negócios que é proprietária do contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
		}
	



		/// <summary>
		/// Identificador exclusivo da equipe que possui o contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
		}
	



		/// <summary>
		/// Identificador exclusivo do usuário que possui o contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
		}
	



		/// <summary>
		/// Digite o número do pager do contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pager")]
		public string Pager
		{
			get
			{
				return this.GetAttributeValue<string>("pager");
			}
			set
			{
				this.OnPropertyChanging("Pager");
				this.SetAttributeValue("pager", value);
				this.OnPropertyChanged("Pager");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo do contato primário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcontactid")]
		public Microsoft.Xrm.Sdk.EntityReference ParentContactId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentcontactid");
			}
		}
	



		/// <summary>
		/// Escolha a conta primária ou o contato principal do contato para fornecer um link rápido para detalhes adicionais, como informações financeiras, atividades e oportunidades.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcustomerid")]
		public Microsoft.Xrm.Sdk.EntityReference ParentCustomerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentcustomerid");
			}
			set
			{
				this.OnPropertyChanging("ParentCustomerId");
				this.SetAttributeValue("parentcustomerid", value);
				this.OnPropertyChanged("ParentCustomerId");
			}
		}
	




		/// <summary>
		/// Mostra se o contato participa de regras de fluxo de trabalho.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("participatesinworkflow")]
		public System.Nullable<bool> ParticipatesInWorkflow
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("participatesinworkflow");
			}
			set
			{
				this.OnPropertyChanging("ParticipatesInWorkflow");
				this.SetAttributeValue("participatesinworkflow", value);
				this.OnPropertyChanged("ParticipatesInWorkflow");
			}
		}
	
		public virtual Enums.ParticipatesInWorkflow? ParticipatesInWorkflowEnum
		{
			get
			{
				return ((Enums.ParticipatesInWorkflow?)(EntityOptionSetEnum.GetEnum(this, "participatesinworkflow")));
			}
			set
			{
		       if (value.HasValue)
                    ParticipatesInWorkflow = ((int)value == 1);
                else                   
                    ParticipatesInWorkflow = null;
			}
		}


		/// <summary>
		/// Escolha as condições de pagamento para indicar quando o cliente precisa pagar o valor total.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("paymenttermscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PaymentTermsCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("paymenttermscode");
			}
			set
			{
				this.OnPropertyChanging("PaymentTermsCode");
				this.SetAttributeValue("paymenttermscode", value);
				this.OnPropertyChanged("PaymentTermsCode");
			}
		}
	
		public virtual Enums.PaymentTermsCode? PaymentTermsCodeEnum
		{
			get
			{
				return ((Enums.PaymentTermsCode?)(EntityOptionSetEnum.GetEnum(this, "paymenttermscode")));
			}
			set
			{
				PaymentTermsCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Escolha o dia preferencial da semana para compromissos de serviço.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredappointmentdaycode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PreferredAppointmentDayCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredappointmentdaycode");
			}
			set
			{
				this.OnPropertyChanging("PreferredAppointmentDayCode");
				this.SetAttributeValue("preferredappointmentdaycode", value);
				this.OnPropertyChanged("PreferredAppointmentDayCode");
			}
		}
	
		public virtual Enums.PreferredAppointmentDayCode? PreferredAppointmentDayCodeEnum
		{
			get
			{
				return ((Enums.PreferredAppointmentDayCode?)(EntityOptionSetEnum.GetEnum(this, "preferredappointmentdaycode")));
			}
			set
			{
				PreferredAppointmentDayCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Escolha a hora preferencial do dia para compromissos de serviço.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredappointmenttimecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PreferredAppointmentTimeCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredappointmenttimecode");
			}
			set
			{
				this.OnPropertyChanging("PreferredAppointmentTimeCode");
				this.SetAttributeValue("preferredappointmenttimecode", value);
				this.OnPropertyChanged("PreferredAppointmentTimeCode");
			}
		}
	
		public virtual Enums.PreferredAppointmentTimeCode? PreferredAppointmentTimeCodeEnum
		{
			get
			{
				return ((Enums.PreferredAppointmentTimeCode?)(EntityOptionSetEnum.GetEnum(this, "preferredappointmenttimecode")));
			}
			set
			{
				PreferredAppointmentTimeCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Escolha o método preferencial de contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredcontactmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PreferredContactMethodCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredcontactmethodcode");
			}
			set
			{
				this.OnPropertyChanging("PreferredContactMethodCode");
				this.SetAttributeValue("preferredcontactmethodcode", value);
				this.OnPropertyChanged("PreferredContactMethodCode");
			}
		}
	
		public virtual Enums.PreferredContactMethodCode? PreferredContactMethodCodeEnum
		{
			get
			{
				return ((Enums.PreferredContactMethodCode?)(EntityOptionSetEnum.GetEnum(this, "preferredcontactmethodcode")));
			}
			set
			{
				PreferredContactMethodCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Escolha a instalação ou o equipamento de serviço preferencial do contato para garantir que os serviços sejam agendados corretamente para o cliente.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredequipmentid")]
		public Microsoft.Xrm.Sdk.EntityReference PreferredEquipmentId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("preferredequipmentid");
			}
			set
			{
				this.OnPropertyChanging("PreferredEquipmentId");
				this.SetAttributeValue("preferredequipmentid", value);
				this.OnPropertyChanged("PreferredEquipmentId");
			}
		}
	



		/// <summary>
		/// Escolha o serviço preferencial do contato para garantir que os serviços sejam agendados corretamente para o cliente.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredserviceid")]
		public Microsoft.Xrm.Sdk.EntityReference PreferredServiceId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("preferredserviceid");
			}
			set
			{
				this.OnPropertyChanging("PreferredServiceId");
				this.SetAttributeValue("preferredserviceid", value);
				this.OnPropertyChanged("PreferredServiceId");
			}
		}
	



		/// <summary>
		/// Escolha o representante de serviço de atendimento ao consumidor preferencial do cliente para referência ao agendar atividades de serviço para o contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredsystemuserid")]
		public Microsoft.Xrm.Sdk.EntityReference PreferredSystemUserId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("preferredsystemuserid");
			}
			set
			{
				this.OnPropertyChanging("PreferredSystemUserId");
				this.SetAttributeValue("preferredsystemuserid", value);
				this.OnPropertyChanged("PreferredSystemUserId");
			}
		}
	



		/// <summary>
		/// Mostra a ID do processo.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
		public System.Nullable<System.Guid> ProcessId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("processid");
			}
			set
			{
				this.OnPropertyChanging("ProcessId");
				this.SetAttributeValue("processid", value);
				this.OnPropertyChanged("ProcessId");
			}
		}
	


		/// <summary>
		/// Digite a saudação do contato para garantir que o contato seja tratado corretamente em chamadas de vendas, mensagens de email e campanhas de marketing.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salutation")]
		public string Salutation
		{
			get
			{
				return this.GetAttributeValue<string>("salutation");
			}
			set
			{
				this.OnPropertyChanging("Salutation");
				this.SetAttributeValue("salutation", value);
				this.OnPropertyChanged("Salutation");
			}
		}
	


		/// <summary>
		/// Escolha uma forma de transporte para entregas enviadas para este endereço.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shippingmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue ShippingMethodCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("shippingmethodcode");
			}
			set
			{
				this.OnPropertyChanging("ShippingMethodCode");
				this.SetAttributeValue("shippingmethodcode", value);
				this.OnPropertyChanged("ShippingMethodCode");
			}
		}
	
		public virtual Enums.ShippingMethodCode? ShippingMethodCodeEnum
		{
			get
			{
				return ((Enums.ShippingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "shippingmethodcode")));
			}
			set
			{
				ShippingMethodCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Escolha o contrato de nível de serviço (SLA) que deseja aplicar ao registro do Contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slaid")]
		public Microsoft.Xrm.Sdk.EntityReference SLAId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("slaid");
			}
			set
			{
				this.OnPropertyChanging("SLAId");
				this.SetAttributeValue("slaid", value);
				this.OnPropertyChanged("SLAId");
			}
		}
	



		/// <summary>
		/// Último SLA que foi aplicado a essa ocorrência. Esse campo destina-se a uso interno somente.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slainvokedid")]
		public Microsoft.Xrm.Sdk.EntityReference SLAInvokedId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("slainvokedid");
			}
		}
	



		/// <summary>
		/// Digite o nome do cônjuge ou parceiro do contato para referência durante chamadas, eventos ou outras comunicações com o contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("spousesname")]
		public string SpousesName
		{
			get
			{
				return this.GetAttributeValue<string>("spousesname");
			}
			set
			{
				this.OnPropertyChanging("SpousesName");
				this.SetAttributeValue("spousesname", value);
				this.OnPropertyChanged("SpousesName");
			}
		}
	


		/// <summary>
		/// Mostra a ID do estágio.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
		public System.Nullable<System.Guid> StageId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("stageid");
			}
			set
			{
				this.OnPropertyChanging("StageId");
				this.SetAttributeValue("stageid", value);
				this.OnPropertyChanged("StageId");
			}
		}
	


		/// <summary>
		/// Mostra se o contato está ativo ou inativo. Contatos inativos são somente leitura e não podem ser editados a não ser que sejam reativados.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<ContactState> StateCode
		{
				get
				{
					Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
					if ((optionSet != null))
					{
						return ((ContactState)(System.Enum.ToObject(typeof(ContactState), optionSet.Value)));
					}
					else
					{
						return null;
					}
				}
					set
					{
						this.OnPropertyChanging("StateCode");
						if ((value == null))
						{
							this.SetAttributeValue("statecode", null);
						}
						else
						{
							this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
						}
						this.OnPropertyChanged("StateCode");
					}
		}
	


		/// <summary>
		/// Escolha o status do contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			set
			{
				this.OnPropertyChanging("StatusCode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("StatusCode");
			}
		}
	


		/// <summary>
		/// Apenas para uso interno.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subscriptionid")]
		public System.Nullable<System.Guid> SubscriptionId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("subscriptionid");
			}
			set
			{
				this.OnPropertyChanging("SubscriptionId");
				this.SetAttributeValue("subscriptionid", value);
				this.OnPropertyChanged("SubscriptionId");
			}
		}
	


		/// <summary>
		/// Digite o sufixo usado no nome do contato, como Jr. ou Sr. para garantir que o contato seja tratado corretamente em chamadas de vendas, emails e campanhas de marketing.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("suffix")]
		public string Suffix
		{
			get
			{
				return this.GetAttributeValue<string>("suffix");
			}
			set
			{
				this.OnPropertyChanging("Suffix");
				this.SetAttributeValue("suffix", value);
				this.OnPropertyChanged("Suffix");
			}
		}
	


		/// <summary>
		/// Digite o número do telefone principal deste contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone1")]
		public string Telephone1
		{
			get
			{
				return this.GetAttributeValue<string>("telephone1");
			}
			set
			{
				this.OnPropertyChanging("Telephone1");
				this.SetAttributeValue("telephone1", value);
				this.OnPropertyChanged("Telephone1");
			}
		}
	


		/// <summary>
		/// Digite um segundo número do telefone deste contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone2")]
		public string Telephone2
		{
			get
			{
				return this.GetAttributeValue<string>("telephone2");
			}
			set
			{
				this.OnPropertyChanging("Telephone2");
				this.SetAttributeValue("telephone2", value);
				this.OnPropertyChanged("Telephone2");
			}
		}
	


		/// <summary>
		/// Digite um terceiro número de telefone deste contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone3")]
		public string Telephone3
		{
			get
			{
				return this.GetAttributeValue<string>("telephone3");
			}
			set
			{
				this.OnPropertyChanging("Telephone3");
				this.SetAttributeValue("telephone3", value);
				this.OnPropertyChanged("Telephone3");
			}
		}
	


		/// <summary>
		/// Escolha a região ou território do contato para uso em segmentação de marketing e análise demográfica.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("territorycode")]
		public Microsoft.Xrm.Sdk.OptionSetValue TerritoryCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("territorycode");
			}
			set
			{
				this.OnPropertyChanging("TerritoryCode");
				this.SetAttributeValue("territorycode", value);
				this.OnPropertyChanged("TerritoryCode");
			}
		}
	
		public virtual Enums.TerritoryCode? TerritoryCodeEnum
		{
			get
			{
				return ((Enums.TerritoryCode?)(EntityOptionSetEnum.GetEnum(this, "territorycode")));
			}
			set
			{
				TerritoryCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Tempo total gasto por mim com emails (leitura e redação) e reuniões em relação ao registro do contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timespentbymeonemailandmeetings")]
		public string TimeSpentByMeOnEmailAndMeetings
		{
			get
			{
				return this.GetAttributeValue<string>("timespentbymeonemailandmeetings");
			}
		}
	


		/// <summary>
		/// Apenas para uso interno.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
	


		/// <summary>
		/// Escolha a moeda local do registro para garantir que os orçamentos sejam relatados na moeda correta.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
			}
			set
			{
				this.OnPropertyChanging("TransactionCurrencyId");
				this.SetAttributeValue("transactioncurrencyid", value);
				this.OnPropertyChanged("TransactionCurrencyId");
			}
		}
	



		/// <summary>
		/// Apenas para uso interno.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traversedpath")]
		public string TraversedPath
		{
			get
			{
				return this.GetAttributeValue<string>("traversedpath");
			}
			set
			{
				this.OnPropertyChanging("TraversedPath");
				this.SetAttributeValue("traversedpath", value);
				this.OnPropertyChanged("TraversedPath");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_complemento")]
		public string urb_complemento
		{
			get
			{
				return this.GetAttributeValue<string>("urb_complemento");
			}
			set
			{
				this.OnPropertyChanging("urb_complemento");
				this.SetAttributeValue("urb_complemento", value);
				this.OnPropertyChanged("urb_complemento");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_empresa")]
		public string urb_empresa
		{
			get
			{
				return this.GetAttributeValue<string>("urb_empresa");
			}
			set
			{
				this.OnPropertyChanging("urb_empresa");
				this.SetAttributeValue("urb_empresa", value);
				this.OnPropertyChanged("urb_empresa");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_tipodecontato")]
		public Microsoft.Xrm.Sdk.OptionSetValue urb_tipodecontato
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("urb_tipodecontato");
			}
			set
			{
				this.OnPropertyChanging("urb_tipodecontato");
				this.SetAttributeValue("urb_tipodecontato", value);
				this.OnPropertyChanged("urb_tipodecontato");
			}
		}
	
		public virtual Enums.urb_tipodecontato? urb_tipodecontatoEnum
		{
			get
			{
				return ((Enums.urb_tipodecontato?)(EntityOptionSetEnum.GetEnum(this, "urb_tipodecontato")));
			}
			set
			{
				urb_tipodecontato = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Código de fuso horário em uso quando o registro foi criado.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
	


		/// <summary>
		/// Número de versão do contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
	


		/// <summary>
		/// Digite a URL do site ou blog profissional ou pessoal do contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("websiteurl")]
		public string WebSiteUrl
		{
			get
			{
				return this.GetAttributeValue<string>("websiteurl");
			}
			set
			{
				this.OnPropertyChanging("WebSiteUrl");
				this.SetAttributeValue("websiteurl", value);
				this.OnPropertyChanged("WebSiteUrl");
			}
		}
	


		/// <summary>
		/// Digite a ortografia fonética do nome do contato, se o nome for especificado em japonês, para garantir que o nome seja pronunciado corretamente em telefonemas com o contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomifirstname")]
		public string YomiFirstName
		{
			get
			{
				return this.GetAttributeValue<string>("yomifirstname");
			}
			set
			{
				this.OnPropertyChanging("YomiFirstName");
				this.SetAttributeValue("yomifirstname", value);
				this.OnPropertyChanged("YomiFirstName");
			}
		}
	


		/// <summary>
		/// Mostra o nome e o sobrenome Yomi combinados do contato para que o nome fonético completo possa ser mostrado em exibições e relatórios.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomifullname")]
		public string YomiFullName
		{
			get
			{
				return this.GetAttributeValue<string>("yomifullname");
			}
		}
	


		/// <summary>
		/// Digite a ortografia fonética do sobrenome do contato, se o nome for especificado em japonês, para garantir que o nome seja pronunciado corretamente em telefonemas com o contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomilastname")]
		public string YomiLastName
		{
			get
			{
				return this.GetAttributeValue<string>("yomilastname");
			}
			set
			{
				this.OnPropertyChanging("YomiLastName");
				this.SetAttributeValue("yomilastname", value);
				this.OnPropertyChanged("YomiLastName");
			}
		}
	


		/// <summary>
		/// Digite a ortografia fonética do nome do meio do contato, se o nome for especificado em japonês, para garantir que o nome seja pronunciado corretamente em telefonemas com o contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomimiddlename")]
		public string YomiMiddleName
		{
			get
			{
				return this.GetAttributeValue<string>("yomimiddlename");
			}
			set
			{
				this.OnPropertyChanging("YomiMiddleName");
				this.SetAttributeValue("yomimiddlename", value);
				this.OnPropertyChanged("YomiMiddleName");
			}
		}
	


		
		/// <summary>
		/// 1:N lead_customer_contacts
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_customer_contacts")]
		public System.Collections.Generic.IEnumerable<Lead> lead_customer_contacts
		{
			get
			{
				return this.GetRelatedEntities<Lead>("lead_customer_contacts", null);
			}
			set
			{
				this.OnPropertyChanging("lead_customer_contacts");
				this.SetRelatedEntities<Lead>("lead_customer_contacts", null, value);
				this.OnPropertyChanged("lead_customer_contacts");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lead_customer_contacts(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lead_customer_contacts");
		}

		
		/// <summary>
		/// 1:N opportunity_customer_contacts
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_customer_contacts")]
		public System.Collections.Generic.IEnumerable<Opportunity> opportunity_customer_contacts
		{
			get
			{
				return this.GetRelatedEntities<Opportunity>("opportunity_customer_contacts", null);
			}
			set
			{
				this.OnPropertyChanging("opportunity_customer_contacts");
				this.SetRelatedEntities<Opportunity>("opportunity_customer_contacts", null, value);
				this.OnPropertyChanged("opportunity_customer_contacts");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_opportunity_customer_contacts(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "opportunity_customer_contacts");
		}

		
		/// <summary>
		/// 1:N contact_master_contact
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_master_contact", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<Contact> Referencedcontact_master_contact
		{
			get
			{
				return this.GetRelatedEntities<Contact>("contact_master_contact", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referencedcontact_master_contact");
				this.SetRelatedEntities<Contact>("contact_master_contact", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedcontact_master_contact");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_contact_master_contact(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "contact_master_contact");
		}

		
		/// <summary>
		/// 1:N lead_parent_contact
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_parent_contact")]
		public System.Collections.Generic.IEnumerable<Lead> lead_parent_contact
		{
			get
			{
				return this.GetRelatedEntities<Lead>("lead_parent_contact", null);
			}
			set
			{
				this.OnPropertyChanging("lead_parent_contact");
				this.SetRelatedEntities<Lead>("lead_parent_contact", null, value);
				this.OnPropertyChanged("lead_parent_contact");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lead_parent_contact(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lead_parent_contact");
		}

		
		/// <summary>
		/// 1:N opportunity_parent_contact
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_parent_contact")]
		public System.Collections.Generic.IEnumerable<Opportunity> opportunity_parent_contact
		{
			get
			{
				return this.GetRelatedEntities<Opportunity>("opportunity_parent_contact", null);
			}
			set
			{
				this.OnPropertyChanging("opportunity_parent_contact");
				this.SetRelatedEntities<Opportunity>("opportunity_parent_contact", null, value);
				this.OnPropertyChanged("opportunity_parent_contact");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_opportunity_parent_contact(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "opportunity_parent_contact");
		}

		
		/// <summary>
		/// 1:N contact_customer_contacts
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_customer_contacts", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<Contact> Referencedcontact_customer_contacts
		{
			get
			{
				return this.GetRelatedEntities<Contact>("contact_customer_contacts", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referencedcontact_customer_contacts");
				this.SetRelatedEntities<Contact>("contact_customer_contacts", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedcontact_customer_contacts");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_contact_customer_contacts(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "contact_customer_contacts");
		}

		
		/// <summary>
		/// 1:N contact_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_activity_parties")]
		public System.Collections.Generic.IEnumerable<ActivityParty> contact_activity_parties
		{
			get
			{
				return this.GetRelatedEntities<ActivityParty>("contact_activity_parties", null);
			}
			set
			{
				this.OnPropertyChanging("contact_activity_parties");
				this.SetRelatedEntities<ActivityParty>("contact_activity_parties", null, value);
				this.OnPropertyChanged("contact_activity_parties");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_contact_activity_parties(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "contact_activity_parties");
		}

		
		/// <summary>
		/// 1:N account_primary_contact
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_primary_contact")]
		public System.Collections.Generic.IEnumerable<Account> account_primary_contact
		{
			get
			{
				return this.GetRelatedEntities<Account>("account_primary_contact", null);
			}
			set
			{
				this.OnPropertyChanging("account_primary_contact");
				this.SetRelatedEntities<Account>("account_primary_contact", null, value);
				this.OnPropertyChanged("account_primary_contact");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_account_primary_contact(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "account_primary_contact");
		}

		
		/// <summary>
		/// N:1 lk_contactbase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contactbase_createdby")]
		public SystemUser lk_contactbase_createdby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_contactbase_createdby", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_contactbase_createdby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_contactbase_createdby");
		}

		
		/// <summary>
		/// N:1 lk_contact_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contact_createdonbehalfby")]
		public SystemUser lk_contact_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_contact_createdonbehalfby", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_contact_createdonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_contact_createdonbehalfby");
		}

		
		/// <summary>
		/// N:1 contact_master_contact
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("masterid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_master_contact", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public Contact Referencingcontact_master_contact
		{
			get
			{
				return this.GetRelatedEntity<Contact>("contact_master_contact", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_contact_master_contact(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "contact_master_contact");
		}

		
		/// <summary>
		/// N:1 lk_contactbase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contactbase_modifiedby")]
		public SystemUser lk_contactbase_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_contactbase_modifiedby", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_contactbase_modifiedby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_contactbase_modifiedby");
		}

		
		/// <summary>
		/// N:1 lk_contact_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contact_modifiedonbehalfby")]
		public SystemUser lk_contact_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_contact_modifiedonbehalfby", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_contact_modifiedonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_contact_modifiedonbehalfby");
		}

		
		/// <summary>
		/// N:1 contact_originating_lead
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("originatingleadid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_originating_lead")]
		public Lead contact_originating_lead
		{
			get
			{
				return this.GetRelatedEntity<Lead>("contact_originating_lead", null);
			}
			set
			{
				this.OnPropertyChanging("contact_originating_lead");
				this.SetRelatedEntity<Lead>("contact_originating_lead", null, value);
				this.OnPropertyChanged("contact_originating_lead");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_contact_originating_lead(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "contact_originating_lead");
		}

		
		/// <summary>
		/// N:1 business_unit_contacts
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_contacts")]
		public BusinessUnit business_unit_contacts
		{
			get
			{
				return this.GetRelatedEntity<BusinessUnit>("business_unit_contacts", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_business_unit_contacts(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "business_unit_contacts");
		}

		
		/// <summary>
		/// N:1 team_contacts
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_contacts")]
		public Team team_contacts
		{
			get
			{
				return this.GetRelatedEntity<Team>("team_contacts", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_team_contacts(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "team_contacts");
		}

		
		/// <summary>
		/// N:1 contact_owning_user
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_owning_user")]
		public SystemUser contact_owning_user
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("contact_owning_user", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_contact_owning_user(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "contact_owning_user");
		}

		
		/// <summary>
		/// N:1 contact_customer_accounts
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcustomerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_customer_accounts")]
		public Account contact_customer_accounts
		{
			get
			{
				return this.GetRelatedEntity<Account>("contact_customer_accounts", null);
			}
			set
			{
				this.OnPropertyChanging("contact_customer_accounts");
				this.SetRelatedEntity<Account>("contact_customer_accounts", null, value);
				this.OnPropertyChanged("contact_customer_accounts");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_contact_customer_accounts(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "contact_customer_accounts");
		}

		
		/// <summary>
		/// N:1 contact_customer_contacts
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcustomerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_customer_contacts", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public Contact Referencingcontact_customer_contacts
		{
			get
			{
				return this.GetRelatedEntity<Contact>("contact_customer_contacts", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
			set
			{
				this.OnPropertyChanging("Referencingcontact_customer_contacts");
				this.SetRelatedEntity<Contact>("contact_customer_contacts", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
				this.OnPropertyChanged("Referencingcontact_customer_contacts");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_contact_customer_contacts(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "contact_customer_contacts");
		}

		
		/// <summary>
		/// N:1 system_user_contacts
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredsystemuserid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_contacts")]
		public SystemUser system_user_contacts
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("system_user_contacts", null);
			}
			set
			{
				this.OnPropertyChanging("system_user_contacts");
				this.SetRelatedEntity<SystemUser>("system_user_contacts", null, value);
				this.OnPropertyChanged("system_user_contacts");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_system_user_contacts(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "system_user_contacts");
		}

		
		/// <summary>
		/// N:1 transactioncurrency_contact
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_contact")]
		public TransactionCurrency transactioncurrency_contact
		{
			get
			{
				return this.GetRelatedEntity<TransactionCurrency>("transactioncurrency_contact", null);
			}
			set
			{
				this.OnPropertyChanging("transactioncurrency_contact");
				this.SetRelatedEntity<TransactionCurrency>("transactioncurrency_contact", null, value);
				this.OnPropertyChanged("transactioncurrency_contact");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_transactioncurrency_contact(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "transactioncurrency_contact");
		}

		
		/// <summary>
		/// N:N contactleads_association
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contactleads_association")]
		public System.Collections.Generic.IEnumerable<Lead> contactleads_association
		{
			get
			{
				return this.GetRelatedEntities<Lead>("contactleads_association", null);
			}
			set
			{
				this.OnPropertyChanging("contactleads_association");
				this.SetRelatedEntities<Lead>("contactleads_association", null, value);
				this.OnPropertyChanged("contactleads_association");
			}
		}
		/// <summary>
		/// Loads this N:N relationship into the object 
		/// </summary>
        public void Load_contactleads_association(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "contactleads_association");
		}




		public class Enums 
		{
			[DataContractAttribute]
			public enum AccountRoleCode 
			{
				[EnumMemberAttribute]
				TomadordeDecisao = 1,
				[EnumMemberAttribute]
				Funcionario = 2,
				[EnumMemberAttribute]
				Influenciador = 3,
			}		
			[DataContractAttribute]
			public enum Address1_AddressTypeCode 
			{
				[EnumMemberAttribute]
				Fatura = 1,
				[EnumMemberAttribute]
				Remessa = 2,
				[EnumMemberAttribute]
				Primario = 3,
				[EnumMemberAttribute]
				Outro = 4,
				[EnumMemberAttribute]
				Principal = 169070000,
			}		
			[DataContractAttribute]
			public enum Address1_FreightTermsCode 
			{
				[EnumMemberAttribute]
				FOB = 1,
				[EnumMemberAttribute]
				FreteGratuito = 2,
			}		
			[DataContractAttribute]
			public enum Address1_ShippingMethodCode 
			{
				[EnumMemberAttribute]
				DHL = 2,
				[EnumMemberAttribute]
				FedEx = 3,
				[EnumMemberAttribute]
				UPS = 4,
				[EnumMemberAttribute]
				CorreioComum = 5,
				[EnumMemberAttribute]
				ClienteRetiranoLocal = 7,
				[EnumMemberAttribute]
				Transportadora = 17,
				[EnumMemberAttribute]
				SEDEX = 23,
			}		
			[DataContractAttribute]
			public enum Address2_AddressTypeCode 
			{
				[EnumMemberAttribute]
				ValorPadrao = 1,
			}		
			[DataContractAttribute]
			public enum Address2_FreightTermsCode 
			{
				[EnumMemberAttribute]
				ValorPadrao = 1,
			}		
			[DataContractAttribute]
			public enum Address2_ShippingMethodCode 
			{
				[EnumMemberAttribute]
				ValorPadrao = 1,
			}		
			[DataContractAttribute]
			public enum Address3_AddressTypeCode 
			{
				[EnumMemberAttribute]
				ValorPadrao = 1,
			}		
			[DataContractAttribute]
			public enum Address3_FreightTermsCode 
			{
				[EnumMemberAttribute]
				ValorPadrao = 1,
			}		
			[DataContractAttribute]
			public enum Address3_ShippingMethodCode 
			{
				[EnumMemberAttribute]
				ValorPadrao = 1,
			}		
			[DataContractAttribute]
			public enum CreditOnHold 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum CustomerSizeCode 
			{
				[EnumMemberAttribute]
				ValorPadrao = 1,
			}		
			[DataContractAttribute]
			public enum CustomerTypeCode 
			{
				[EnumMemberAttribute]
				ValorPadrao = 1,
			}		
			[DataContractAttribute]
			public enum DoNotBulkEMail 
			{
				[EnumMemberAttribute]
				NaoPermitir = 1,
				[EnumMemberAttribute]
				Permitir = 0,
			}		
			[DataContractAttribute]
			public enum DoNotBulkPostalMail 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum DoNotEMail 
			{
				[EnumMemberAttribute]
				NaoPermitir = 1,
				[EnumMemberAttribute]
				Permitir = 0,
			}		
			[DataContractAttribute]
			public enum DoNotFax 
			{
				[EnumMemberAttribute]
				NaoPermitir = 1,
				[EnumMemberAttribute]
				Permitir = 0,
			}		
			[DataContractAttribute]
			public enum DoNotPhone 
			{
				[EnumMemberAttribute]
				NaoPermitir = 1,
				[EnumMemberAttribute]
				Permitir = 0,
			}		
			[DataContractAttribute]
			public enum DoNotPostalMail 
			{
				[EnumMemberAttribute]
				NaoPermitir = 1,
				[EnumMemberAttribute]
				Permitir = 0,
			}		
			[DataContractAttribute]
			public enum DoNotSendMM 
			{
				[EnumMemberAttribute]
				NaoEnviar = 1,
				[EnumMemberAttribute]
				Enviar = 0,
			}		
			[DataContractAttribute]
			public enum EducationCode 
			{
				[EnumMemberAttribute]
				ValorPadrao = 1,
			}		
			[DataContractAttribute]
			public enum FamilyStatusCode 
			{
				[EnumMemberAttribute]
				Solteiro = 1,
				[EnumMemberAttribute]
				Casadoa = 2,
				[EnumMemberAttribute]
				Divorciadoa = 3,
				[EnumMemberAttribute]
				Viuvoa = 4,
				[EnumMemberAttribute]
				Casado = 169070000,
			}		
			[DataContractAttribute]
			public enum FollowEmail 
			{
				[EnumMemberAttribute]
				Permitir = 1,
				[EnumMemberAttribute]
				NaoPermitir = 0,
			}		
			[DataContractAttribute]
			public enum GenderCode 
			{
				[EnumMemberAttribute]
				Masculino = 1,
				[EnumMemberAttribute]
				Feminino = 2,
			}		
			[DataContractAttribute]
			public enum HasChildrenCode 
			{
				[EnumMemberAttribute]
				ValorPadrao = 1,
			}		
			[DataContractAttribute]
			public enum IsAutoCreate 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum IsBackofficeCustomer 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum IsPrivate 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum LeadSourceCode 
			{
				[EnumMemberAttribute]
				ValorPadrao = 1,
			}		
			[DataContractAttribute]
			public enum MarketingOnly 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum Merged 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum ParticipatesInWorkflow 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum PaymentTermsCode 
			{
				[EnumMemberAttribute]
				Vencimentoem30dias = 1,
				[EnumMemberAttribute]
				Vencimentoem45dias = 3,
				[EnumMemberAttribute]
				Vencimentoem60dias = 4,
				[EnumMemberAttribute]
				AVista = 10,
			}		
			[DataContractAttribute]
			public enum PreferredAppointmentDayCode 
			{
				[EnumMemberAttribute]
				Domingo = 0,
				[EnumMemberAttribute]
				Segundafeira = 1,
				[EnumMemberAttribute]
				Tercafeira = 2,
				[EnumMemberAttribute]
				Quartafeira = 3,
				[EnumMemberAttribute]
				Quintafeira = 4,
				[EnumMemberAttribute]
				Sextafeira = 5,
				[EnumMemberAttribute]
				Sabado = 6,
			}		
			[DataContractAttribute]
			public enum PreferredAppointmentTimeCode 
			{
				[EnumMemberAttribute]
				Manha = 1,
				[EnumMemberAttribute]
				Tarde = 2,
				[EnumMemberAttribute]
				Noite = 3,
			}		
			[DataContractAttribute]
			public enum PreferredContactMethodCode 
			{
				[EnumMemberAttribute]
				Qualqueruma = 1,
				[EnumMemberAttribute]
				Email = 2,
				[EnumMemberAttribute]
				Telefone = 3,
				[EnumMemberAttribute]
				Fax = 4,
				[EnumMemberAttribute]
				Correio = 5,
			}		
			[DataContractAttribute]
			public enum ShippingMethodCode 
			{
				[EnumMemberAttribute]
				ValorPadrao = 1,
			}		
			[DataContractAttribute]
			public enum StateCode 
			{
				[EnumMemberAttribute]
				Ativa = 0,
				[EnumMemberAttribute]
				Inativa = 1,
			}		
			[DataContractAttribute]
			public enum StatusCode 
			{
				[EnumMemberAttribute]
				Ativa = 1,
				[EnumMemberAttribute]
				Inativa = 2,
			}		
			[DataContractAttribute]
			public enum TerritoryCode 
			{
				[EnumMemberAttribute]
				ValorPadrao = 1,
			}		
			[DataContractAttribute]
			public enum urb_tipodecontato 
			{
				[EnumMemberAttribute]
				Interno = 169070001,
				[EnumMemberAttribute]
				Externo = 169070000,
				[EnumMemberAttribute]
				Departamento = 169070002,
			}		
	}


		public class OneToMany
		{
			public const string lead_customer_contacts = "lead_customer_contacts";
			public const string opportunity_customer_contacts = "opportunity_customer_contacts";
			public const string contact_master_contact = "contact_master_contact";
			public const string lead_parent_contact = "lead_parent_contact";
			public const string opportunity_parent_contact = "opportunity_parent_contact";
			public const string contact_customer_contacts = "contact_customer_contacts";
			public const string contact_activity_parties = "contact_activity_parties";
			public const string account_primary_contact = "account_primary_contact";
}
		public class ManyToMany
		{
			public const string contactleads_association = "contactleads_association";
}

		public class Fields
		{
			public const string SchemaName = "contact";
			
			public const string AccountId = "accountid";
			public const string AccountIdName = "accountidName";
			public const string AccountRoleCode = "accountrolecode";
			public const string Address1_AddressId = "address1_addressid";
			public const string Address1_AddressTypeCode = "address1_addresstypecode";
			public const string Address1_City = "address1_city";
			public const string Address1_Composite = "address1_composite";
			public const string Address1_Country = "address1_country";
			public const string Address1_County = "address1_county";
			public const string Address1_Fax = "address1_fax";
			public const string Address1_FreightTermsCode = "address1_freighttermscode";
			public const string Address1_Latitude = "address1_latitude";
			public const string Address1_Line1 = "address1_line1";
			public const string Address1_Line2 = "address1_line2";
			public const string Address1_Line3 = "address1_line3";
			public const string Address1_Longitude = "address1_longitude";
			public const string Address1_Name = "address1_name";
			public const string Address1_PostalCode = "address1_postalcode";
			public const string Address1_PostOfficeBox = "address1_postofficebox";
			public const string Address1_PrimaryContactName = "address1_primarycontactname";
			public const string Address1_ShippingMethodCode = "address1_shippingmethodcode";
			public const string Address1_StateOrProvince = "address1_stateorprovince";
			public const string Address1_Telephone1 = "address1_telephone1";
			public const string Address1_Telephone2 = "address1_telephone2";
			public const string Address1_Telephone3 = "address1_telephone3";
			public const string Address1_UPSZone = "address1_upszone";
			public const string Address1_UTCOffset = "address1_utcoffset";
			public const string Address2_AddressId = "address2_addressid";
			public const string Address2_AddressTypeCode = "address2_addresstypecode";
			public const string Address2_City = "address2_city";
			public const string Address2_Composite = "address2_composite";
			public const string Address2_Country = "address2_country";
			public const string Address2_County = "address2_county";
			public const string Address2_Fax = "address2_fax";
			public const string Address2_FreightTermsCode = "address2_freighttermscode";
			public const string Address2_Latitude = "address2_latitude";
			public const string Address2_Line1 = "address2_line1";
			public const string Address2_Line2 = "address2_line2";
			public const string Address2_Line3 = "address2_line3";
			public const string Address2_Longitude = "address2_longitude";
			public const string Address2_Name = "address2_name";
			public const string Address2_PostalCode = "address2_postalcode";
			public const string Address2_PostOfficeBox = "address2_postofficebox";
			public const string Address2_PrimaryContactName = "address2_primarycontactname";
			public const string Address2_ShippingMethodCode = "address2_shippingmethodcode";
			public const string Address2_StateOrProvince = "address2_stateorprovince";
			public const string Address2_Telephone1 = "address2_telephone1";
			public const string Address2_Telephone2 = "address2_telephone2";
			public const string Address2_Telephone3 = "address2_telephone3";
			public const string Address2_UPSZone = "address2_upszone";
			public const string Address2_UTCOffset = "address2_utcoffset";
			public const string Address3_AddressId = "address3_addressid";
			public const string Address3_AddressTypeCode = "address3_addresstypecode";
			public const string Address3_City = "address3_city";
			public const string Address3_Composite = "address3_composite";
			public const string Address3_Country = "address3_country";
			public const string Address3_County = "address3_county";
			public const string Address3_Fax = "address3_fax";
			public const string Address3_FreightTermsCode = "address3_freighttermscode";
			public const string Address3_Latitude = "address3_latitude";
			public const string Address3_Line1 = "address3_line1";
			public const string Address3_Line2 = "address3_line2";
			public const string Address3_Line3 = "address3_line3";
			public const string Address3_Longitude = "address3_longitude";
			public const string Address3_Name = "address3_name";
			public const string Address3_PostalCode = "address3_postalcode";
			public const string Address3_PostOfficeBox = "address3_postofficebox";
			public const string Address3_PrimaryContactName = "address3_primarycontactname";
			public const string Address3_ShippingMethodCode = "address3_shippingmethodcode";
			public const string Address3_StateOrProvince = "address3_stateorprovince";
			public const string Address3_Telephone1 = "address3_telephone1";
			public const string Address3_Telephone2 = "address3_telephone2";
			public const string Address3_Telephone3 = "address3_telephone3";
			public const string Address3_UPSZone = "address3_upszone";
			public const string Address3_UTCOffset = "address3_utcoffset";
			public const string Aging30 = "aging30";
			public const string Aging30_Base = "aging30_base";
			public const string Aging60 = "aging60";
			public const string Aging60_Base = "aging60_base";
			public const string Aging90 = "aging90";
			public const string Aging90_Base = "aging90_base";
			public const string Anniversary = "anniversary";
			public const string AnnualIncome = "annualincome";
			public const string AnnualIncome_Base = "annualincome_base";
			public const string AssistantName = "assistantname";
			public const string AssistantPhone = "assistantphone";
			public const string BirthDate = "birthdate";
			public const string Business2 = "business2";
			public const string Callback = "callback";
			public const string ChildrensNames = "childrensnames";
			public const string Company = "company";
			public const string ContactId = "contactid";
			public const string CreatedBy = "createdby";
			public const string CreatedByExternalParty = "createdbyexternalparty";
			public const string CreatedByExternalPartyName = "createdbyexternalpartyName";
			public const string CreatedByName = "createdbyName";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CreatedOnBehalfByName = "createdonbehalfbyName";
			public const string CreditLimit = "creditlimit";
			public const string CreditLimit_Base = "creditlimit_base";
			public const string CreditOnHold = "creditonhold";
			public const string CustomerSizeCode = "customersizecode";
			public const string CustomerTypeCode = "customertypecode";
			public const string DefaultPriceLevelId = "defaultpricelevelid";
			public const string DefaultPriceLevelIdName = "defaultpricelevelidName";
			public const string Department = "department";
			public const string Description = "description";
			public const string DoNotBulkEMail = "donotbulkemail";
			public const string DoNotBulkPostalMail = "donotbulkpostalmail";
			public const string DoNotEMail = "donotemail";
			public const string DoNotFax = "donotfax";
			public const string DoNotPhone = "donotphone";
			public const string DoNotPostalMail = "donotpostalmail";
			public const string DoNotSendMM = "donotsendmm";
			public const string EducationCode = "educationcode";
			public const string EMailAddress1 = "emailaddress1";
			public const string EMailAddress2 = "emailaddress2";
			public const string EMailAddress3 = "emailaddress3";
			public const string EmployeeId = "employeeid";
			public const string EntityImage = "entityimage";
			public const string EntityImage_Timestamp = "entityimage_timestamp";
			public const string EntityImage_URL = "entityimage_url";
			public const string EntityImageId = "entityimageid";
			public const string ExchangeRate = "exchangerate";
			public const string ExternalUserIdentifier = "externaluseridentifier";
			public const string FamilyStatusCode = "familystatuscode";
			public const string Fax = "fax";
			public const string FirstName = "firstname";
			public const string FollowEmail = "followemail";
			public const string FtpSiteUrl = "ftpsiteurl";
			public const string FullName = "fullname";
			public const string GenderCode = "gendercode";
			public const string GovernmentId = "governmentid";
			public const string HasChildrenCode = "haschildrencode";
			public const string Home2 = "home2";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string IsAutoCreate = "isautocreate";
			public const string IsBackofficeCustomer = "isbackofficecustomer";
			public const string IsPrivate = "isprivate";
			public const string JobTitle = "jobtitle";
			public const string LastName = "lastname";
			public const string LastOnHoldTime = "lastonholdtime";
			public const string LastUsedInCampaign = "lastusedincampaign";
			public const string LeadSourceCode = "leadsourcecode";
			public const string ManagerName = "managername";
			public const string ManagerPhone = "managerphone";
			public const string MarketingOnly = "marketingonly";
			public const string MasterId = "masterid";
			public const string MasterIdName = "masteridName";
			public const string Merged = "merged";
			public const string MiddleName = "middlename";
			public const string MobilePhone = "mobilephone";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedByExternalParty = "modifiedbyexternalparty";
			public const string ModifiedByExternalPartyName = "modifiedbyexternalpartyName";
			public const string ModifiedByName = "modifiedbyName";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string ModifiedOnBehalfByName = "modifiedonbehalfbyName";
			public const string NickName = "nickname";
			public const string NumberOfChildren = "numberofchildren";
			public const string OnHoldTime = "onholdtime";
			public const string OriginatingLeadId = "originatingleadid";
			public const string OriginatingLeadIdName = "originatingleadidName";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningBusinessUnitName = "owningbusinessunitName";
			public const string OwningTeam = "owningteam";
			public const string OwningTeamName = "owningteamName";
			public const string OwningUser = "owninguser";
			public const string OwningUserName = "owninguserName";
			public const string Pager = "pager";
			public const string ParentContactId = "parentcontactid";
			public const string ParentContactIdName = "parentcontactidName";
			public const string ParentCustomerId = "parentcustomerid";
			public const string ParentCustomerIdName = "parentcustomeridName";
			public const string ParentCustomerIdType = "parentcustomeridType";
			public const string ParticipatesInWorkflow = "participatesinworkflow";
			public const string PaymentTermsCode = "paymenttermscode";
			public const string PreferredAppointmentDayCode = "preferredappointmentdaycode";
			public const string PreferredAppointmentTimeCode = "preferredappointmenttimecode";
			public const string PreferredContactMethodCode = "preferredcontactmethodcode";
			public const string PreferredEquipmentId = "preferredequipmentid";
			public const string PreferredEquipmentIdName = "preferredequipmentidName";
			public const string PreferredServiceId = "preferredserviceid";
			public const string PreferredServiceIdName = "preferredserviceidName";
			public const string PreferredSystemUserId = "preferredsystemuserid";
			public const string PreferredSystemUserIdName = "preferredsystemuseridName";
			public const string ProcessId = "processid";
			public const string Salutation = "salutation";
			public const string ShippingMethodCode = "shippingmethodcode";
			public const string SLAId = "slaid";
			public const string SLAIdName = "slaidName";
			public const string SLAInvokedId = "slainvokedid";
			public const string SLAInvokedIdName = "slainvokedidName";
			public const string SpousesName = "spousesname";
			public const string StageId = "stageid";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string SubscriptionId = "subscriptionid";
			public const string Suffix = "suffix";
			public const string Telephone1 = "telephone1";
			public const string Telephone2 = "telephone2";
			public const string Telephone3 = "telephone3";
			public const string TerritoryCode = "territorycode";
			public const string TimeSpentByMeOnEmailAndMeetings = "timespentbymeonemailandmeetings";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string TransactionCurrencyIdName = "transactioncurrencyidName";
			public const string TraversedPath = "traversedpath";
			public const string urb_complemento = "urb_complemento";
			public const string urb_empresa = "urb_empresa";
			public const string urb_tipodecontato = "urb_tipodecontato";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
			public const string WebSiteUrl = "websiteurl";
			public const string YomiFirstName = "yomifirstname";
			public const string YomiFullName = "yomifullname";
			public const string YomiLastName = "yomilastname";
			public const string YomiMiddleName = "yomimiddlename";
		}
	}

	[System.Runtime.Serialization.DataContractAttribute()]
	public enum LeadState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		EmAberto = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Qualificado = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Desqualificado = 2,
	}

	/// <summary>
	/// Colaborador potencial ou oportunidade de vendas potencial. Clientes potenciais serão convertidos em contas, contatos ou oportunidades quando qualificados. Caso contrário, serão excluídos ou arquivados.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("lead")]
	public partial class Lead : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public Lead() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "lead";
		
		public const int EntityTypeCode = 4;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("leadid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.LeadId = value;
			}
		}
		/// <summary>
		/// Identificador exclusivo da conta à qual o cliente potencial está associado.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountid")]
		public Microsoft.Xrm.Sdk.EntityReference AccountId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("accountid");
			}
		}
	



		/// <summary>
		/// Identificador exclusivo do endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addressid")]
		public System.Nullable<System.Guid> Address1_AddressId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("address1_addressid");
			}
			set
			{
				this.OnPropertyChanging("Address1_AddressId");
				this.SetAttributeValue("address1_addressid", value);
				this.OnPropertyChanged("Address1_AddressId");
			}
		}
	


		/// <summary>
		/// Escolha o tipo do endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addresstypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address1_AddressTypeCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_addresstypecode");
			}
			set
			{
				this.OnPropertyChanging("Address1_AddressTypeCode");
				this.SetAttributeValue("address1_addresstypecode", value);
				this.OnPropertyChanged("Address1_AddressTypeCode");
			}
		}
	
		public virtual Enums.Address1_AddressTypeCode? Address1_AddressTypeCodeEnum
		{
			get
			{
				return ((Enums.Address1_AddressTypeCode?)(EntityOptionSetEnum.GetEnum(this, "address1_addresstypecode")));
			}
			set
			{
				Address1_AddressTypeCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Digite a cidade do endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_city")]
		public string Address1_City
		{
			get
			{
				return this.GetAttributeValue<string>("address1_city");
			}
			set
			{
				this.OnPropertyChanging("Address1_City");
				this.SetAttributeValue("address1_city", value);
				this.OnPropertyChanged("Address1_City");
			}
		}
	


		/// <summary>
		/// Mostra o endereço principal completo.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_composite")]
		public string Address1_Composite
		{
			get
			{
				return this.GetAttributeValue<string>("address1_composite");
			}
		}
	


		/// <summary>
		/// Digite o país ou região do endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_country")]
		public string Address1_Country
		{
			get
			{
				return this.GetAttributeValue<string>("address1_country");
			}
			set
			{
				this.OnPropertyChanging("Address1_Country");
				this.SetAttributeValue("address1_country", value);
				this.OnPropertyChanged("Address1_Country");
			}
		}
	


		/// <summary>
		/// Digite o município do endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_county")]
		public string Address1_County
		{
			get
			{
				return this.GetAttributeValue<string>("address1_county");
			}
			set
			{
				this.OnPropertyChanging("Address1_County");
				this.SetAttributeValue("address1_county", value);
				this.OnPropertyChanged("Address1_County");
			}
		}
	


		/// <summary>
		/// Digite o número do fax associado ao endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_fax")]
		public string Address1_Fax
		{
			get
			{
				return this.GetAttributeValue<string>("address1_fax");
			}
			set
			{
				this.OnPropertyChanging("Address1_Fax");
				this.SetAttributeValue("address1_fax", value);
				this.OnPropertyChanged("Address1_Fax");
			}
		}
	


		/// <summary>
		/// Digite o valor da latitude do endereço principal para uso no mapeamento e em outros aplicativos.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_latitude")]
		public System.Nullable<double> Address1_Latitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address1_latitude");
			}
			set
			{
				this.OnPropertyChanging("Address1_Latitude");
				this.SetAttributeValue("address1_latitude", value);
				this.OnPropertyChanged("Address1_Latitude");
			}
		}
	


		/// <summary>
		/// Digite a primeira linha do endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line1")]
		public string Address1_Line1
		{
			get
			{
				return this.GetAttributeValue<string>("address1_line1");
			}
			set
			{
				this.OnPropertyChanging("Address1_Line1");
				this.SetAttributeValue("address1_line1", value);
				this.OnPropertyChanged("Address1_Line1");
			}
		}
	


		/// <summary>
		/// Digite a segunda linha do endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line2")]
		public string Address1_Line2
		{
			get
			{
				return this.GetAttributeValue<string>("address1_line2");
			}
			set
			{
				this.OnPropertyChanging("Address1_Line2");
				this.SetAttributeValue("address1_line2", value);
				this.OnPropertyChanged("Address1_Line2");
			}
		}
	


		/// <summary>
		/// Digite a terceira linha do endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line3")]
		public string Address1_Line3
		{
			get
			{
				return this.GetAttributeValue<string>("address1_line3");
			}
			set
			{
				this.OnPropertyChanging("Address1_Line3");
				this.SetAttributeValue("address1_line3", value);
				this.OnPropertyChanged("Address1_Line3");
			}
		}
	


		/// <summary>
		/// Digite o valor da longitude do endereço principal para uso no mapeamento e em outros aplicativos.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_longitude")]
		public System.Nullable<double> Address1_Longitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address1_longitude");
			}
			set
			{
				this.OnPropertyChanging("Address1_Longitude");
				this.SetAttributeValue("address1_longitude", value);
				this.OnPropertyChanged("Address1_Longitude");
			}
		}
	


		/// <summary>
		/// Digite um nome descritivo para o endereço principal, como Matriz Corporativa.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_name")]
		public string Address1_Name
		{
			get
			{
				return this.GetAttributeValue<string>("address1_name");
			}
			set
			{
				this.OnPropertyChanging("Address1_Name");
				this.SetAttributeValue("address1_name", value);
				this.OnPropertyChanged("Address1_Name");
			}
		}
	


		/// <summary>
		/// Digite o CEP do endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postalcode")]
		public string Address1_PostalCode
		{
			get
			{
				return this.GetAttributeValue<string>("address1_postalcode");
			}
			set
			{
				this.OnPropertyChanging("Address1_PostalCode");
				this.SetAttributeValue("address1_postalcode", value);
				this.OnPropertyChanged("Address1_PostalCode");
			}
		}
	


		/// <summary>
		/// Digite o número da caixa postal do endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postofficebox")]
		public string Address1_PostOfficeBox
		{
			get
			{
				return this.GetAttributeValue<string>("address1_postofficebox");
			}
			set
			{
				this.OnPropertyChanging("Address1_PostOfficeBox");
				this.SetAttributeValue("address1_postofficebox", value);
				this.OnPropertyChanged("Address1_PostOfficeBox");
			}
		}
	


		/// <summary>
		/// Escolha uma forma de transporte para entregas enviadas para este endereço.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_shippingmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address1_ShippingMethodCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_shippingmethodcode");
			}
			set
			{
				this.OnPropertyChanging("Address1_ShippingMethodCode");
				this.SetAttributeValue("address1_shippingmethodcode", value);
				this.OnPropertyChanged("Address1_ShippingMethodCode");
			}
		}
	
		public virtual Enums.Address1_ShippingMethodCode? Address1_ShippingMethodCodeEnum
		{
			get
			{
				return ((Enums.Address1_ShippingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "address1_shippingmethodcode")));
			}
			set
			{
				Address1_ShippingMethodCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Digite o estado ou província do endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_stateorprovince")]
		public string Address1_StateOrProvince
		{
			get
			{
				return this.GetAttributeValue<string>("address1_stateorprovince");
			}
			set
			{
				this.OnPropertyChanging("Address1_StateOrProvince");
				this.SetAttributeValue("address1_stateorprovince", value);
				this.OnPropertyChanged("Address1_StateOrProvince");
			}
		}
	


		/// <summary>
		/// Digite o número do telefone principal associado ao endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone1")]
		public string Address1_Telephone1
		{
			get
			{
				return this.GetAttributeValue<string>("address1_telephone1");
			}
			set
			{
				this.OnPropertyChanging("Address1_Telephone1");
				this.SetAttributeValue("address1_telephone1", value);
				this.OnPropertyChanged("Address1_Telephone1");
			}
		}
	


		/// <summary>
		/// Digite um segundo número de telefone associado ao endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone2")]
		public string Address1_Telephone2
		{
			get
			{
				return this.GetAttributeValue<string>("address1_telephone2");
			}
			set
			{
				this.OnPropertyChanging("Address1_Telephone2");
				this.SetAttributeValue("address1_telephone2", value);
				this.OnPropertyChanged("Address1_Telephone2");
			}
		}
	


		/// <summary>
		/// Digite um terceiro número de telefone associado ao endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone3")]
		public string Address1_Telephone3
		{
			get
			{
				return this.GetAttributeValue<string>("address1_telephone3");
			}
			set
			{
				this.OnPropertyChanging("Address1_Telephone3");
				this.SetAttributeValue("address1_telephone3", value);
				this.OnPropertyChanged("Address1_Telephone3");
			}
		}
	


		/// <summary>
		/// Digite a zona UPS do endereço principal para garantir que os encargos de remessa sejam calculados corretamente e as entregas sejam feitas imediatamente, quando enviado por UPS.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_upszone")]
		public string Address1_UPSZone
		{
			get
			{
				return this.GetAttributeValue<string>("address1_upszone");
			}
			set
			{
				this.OnPropertyChanging("Address1_UPSZone");
				this.SetAttributeValue("address1_upszone", value);
				this.OnPropertyChanged("Address1_UPSZone");
			}
		}
	


		/// <summary>
		/// Escolha o fuso horário ou a compensação UTC deste endereço para que outras pessoas possam fazer referência a ele ao contatar alguém nesse endereço.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_utcoffset")]
		public System.Nullable<int> Address1_UTCOffset
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("address1_utcoffset");
			}
			set
			{
				this.OnPropertyChanging("Address1_UTCOffset");
				this.SetAttributeValue("address1_utcoffset", value);
				this.OnPropertyChanged("Address1_UTCOffset");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo do endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addressid")]
		public System.Nullable<System.Guid> Address2_AddressId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("address2_addressid");
			}
			set
			{
				this.OnPropertyChanging("Address2_AddressId");
				this.SetAttributeValue("address2_addressid", value);
				this.OnPropertyChanged("Address2_AddressId");
			}
		}
	


		/// <summary>
		/// Escolha o tipo do endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addresstypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address2_AddressTypeCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_addresstypecode");
			}
			set
			{
				this.OnPropertyChanging("Address2_AddressTypeCode");
				this.SetAttributeValue("address2_addresstypecode", value);
				this.OnPropertyChanged("Address2_AddressTypeCode");
			}
		}
	
		public virtual Enums.Address2_AddressTypeCode? Address2_AddressTypeCodeEnum
		{
			get
			{
				return ((Enums.Address2_AddressTypeCode?)(EntityOptionSetEnum.GetEnum(this, "address2_addresstypecode")));
			}
			set
			{
				Address2_AddressTypeCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Digite a cidade do endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_city")]
		public string Address2_City
		{
			get
			{
				return this.GetAttributeValue<string>("address2_city");
			}
			set
			{
				this.OnPropertyChanging("Address2_City");
				this.SetAttributeValue("address2_city", value);
				this.OnPropertyChanged("Address2_City");
			}
		}
	


		/// <summary>
		/// Mostra o endereço secundário completo.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_composite")]
		public string Address2_Composite
		{
			get
			{
				return this.GetAttributeValue<string>("address2_composite");
			}
		}
	


		/// <summary>
		/// Digite o país ou região do endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_country")]
		public string Address2_Country
		{
			get
			{
				return this.GetAttributeValue<string>("address2_country");
			}
			set
			{
				this.OnPropertyChanging("Address2_Country");
				this.SetAttributeValue("address2_country", value);
				this.OnPropertyChanged("Address2_Country");
			}
		}
	


		/// <summary>
		/// Digite o município do endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_county")]
		public string Address2_County
		{
			get
			{
				return this.GetAttributeValue<string>("address2_county");
			}
			set
			{
				this.OnPropertyChanging("Address2_County");
				this.SetAttributeValue("address2_county", value);
				this.OnPropertyChanged("Address2_County");
			}
		}
	


		/// <summary>
		/// Digite o número do fax associado ao endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_fax")]
		public string Address2_Fax
		{
			get
			{
				return this.GetAttributeValue<string>("address2_fax");
			}
			set
			{
				this.OnPropertyChanging("Address2_Fax");
				this.SetAttributeValue("address2_fax", value);
				this.OnPropertyChanged("Address2_Fax");
			}
		}
	


		/// <summary>
		/// Digite o valor da latitude do endereço secundário para uso no mapeamento e em outros aplicativos.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_latitude")]
		public System.Nullable<double> Address2_Latitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address2_latitude");
			}
			set
			{
				this.OnPropertyChanging("Address2_Latitude");
				this.SetAttributeValue("address2_latitude", value);
				this.OnPropertyChanged("Address2_Latitude");
			}
		}
	


		/// <summary>
		/// Digite a primeira linha do endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line1")]
		public string Address2_Line1
		{
			get
			{
				return this.GetAttributeValue<string>("address2_line1");
			}
			set
			{
				this.OnPropertyChanging("Address2_Line1");
				this.SetAttributeValue("address2_line1", value);
				this.OnPropertyChanged("Address2_Line1");
			}
		}
	


		/// <summary>
		/// Digite a segunda linha do endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line2")]
		public string Address2_Line2
		{
			get
			{
				return this.GetAttributeValue<string>("address2_line2");
			}
			set
			{
				this.OnPropertyChanging("Address2_Line2");
				this.SetAttributeValue("address2_line2", value);
				this.OnPropertyChanged("Address2_Line2");
			}
		}
	


		/// <summary>
		/// Digite a terceira linha do endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line3")]
		public string Address2_Line3
		{
			get
			{
				return this.GetAttributeValue<string>("address2_line3");
			}
			set
			{
				this.OnPropertyChanging("Address2_Line3");
				this.SetAttributeValue("address2_line3", value);
				this.OnPropertyChanged("Address2_Line3");
			}
		}
	


		/// <summary>
		/// Digite o valor da longitude do endereço secundário para uso no mapeamento e em outros aplicativos.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_longitude")]
		public System.Nullable<double> Address2_Longitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address2_longitude");
			}
			set
			{
				this.OnPropertyChanging("Address2_Longitude");
				this.SetAttributeValue("address2_longitude", value);
				this.OnPropertyChanged("Address2_Longitude");
			}
		}
	


		/// <summary>
		/// Digite um nome descritivo para o endereço secundário, como Matriz Corporativa.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_name")]
		public string Address2_Name
		{
			get
			{
				return this.GetAttributeValue<string>("address2_name");
			}
			set
			{
				this.OnPropertyChanging("Address2_Name");
				this.SetAttributeValue("address2_name", value);
				this.OnPropertyChanged("Address2_Name");
			}
		}
	


		/// <summary>
		/// Digite o CEP do endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postalcode")]
		public string Address2_PostalCode
		{
			get
			{
				return this.GetAttributeValue<string>("address2_postalcode");
			}
			set
			{
				this.OnPropertyChanging("Address2_PostalCode");
				this.SetAttributeValue("address2_postalcode", value);
				this.OnPropertyChanged("Address2_PostalCode");
			}
		}
	


		/// <summary>
		/// Digite o número da caixa postal do endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postofficebox")]
		public string Address2_PostOfficeBox
		{
			get
			{
				return this.GetAttributeValue<string>("address2_postofficebox");
			}
			set
			{
				this.OnPropertyChanging("Address2_PostOfficeBox");
				this.SetAttributeValue("address2_postofficebox", value);
				this.OnPropertyChanged("Address2_PostOfficeBox");
			}
		}
	


		/// <summary>
		/// Escolha uma forma de transporte para entregas enviadas para este endereço.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_shippingmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address2_ShippingMethodCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_shippingmethodcode");
			}
			set
			{
				this.OnPropertyChanging("Address2_ShippingMethodCode");
				this.SetAttributeValue("address2_shippingmethodcode", value);
				this.OnPropertyChanged("Address2_ShippingMethodCode");
			}
		}
	
		public virtual Enums.Address2_ShippingMethodCode? Address2_ShippingMethodCodeEnum
		{
			get
			{
				return ((Enums.Address2_ShippingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "address2_shippingmethodcode")));
			}
			set
			{
				Address2_ShippingMethodCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Digite o estado ou província do endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_stateorprovince")]
		public string Address2_StateOrProvince
		{
			get
			{
				return this.GetAttributeValue<string>("address2_stateorprovince");
			}
			set
			{
				this.OnPropertyChanging("Address2_StateOrProvince");
				this.SetAttributeValue("address2_stateorprovince", value);
				this.OnPropertyChanged("Address2_StateOrProvince");
			}
		}
	


		/// <summary>
		/// Digite o número do telefone principal associado ao endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone1")]
		public string Address2_Telephone1
		{
			get
			{
				return this.GetAttributeValue<string>("address2_telephone1");
			}
			set
			{
				this.OnPropertyChanging("Address2_Telephone1");
				this.SetAttributeValue("address2_telephone1", value);
				this.OnPropertyChanged("Address2_Telephone1");
			}
		}
	


		/// <summary>
		/// Digite um segundo número de telefone associado ao endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone2")]
		public string Address2_Telephone2
		{
			get
			{
				return this.GetAttributeValue<string>("address2_telephone2");
			}
			set
			{
				this.OnPropertyChanging("Address2_Telephone2");
				this.SetAttributeValue("address2_telephone2", value);
				this.OnPropertyChanged("Address2_Telephone2");
			}
		}
	


		/// <summary>
		/// Digite um terceiro número de telefone associado ao endereço secundário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone3")]
		public string Address2_Telephone3
		{
			get
			{
				return this.GetAttributeValue<string>("address2_telephone3");
			}
			set
			{
				this.OnPropertyChanging("Address2_Telephone3");
				this.SetAttributeValue("address2_telephone3", value);
				this.OnPropertyChanged("Address2_Telephone3");
			}
		}
	


		/// <summary>
		/// Digite a zona UPS do endereço secundário para garantir que os encargos de remessa sejam calculados corretamente e as entregas sejam feitas imediatamente, quando enviado por UPS.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_upszone")]
		public string Address2_UPSZone
		{
			get
			{
				return this.GetAttributeValue<string>("address2_upszone");
			}
			set
			{
				this.OnPropertyChanging("Address2_UPSZone");
				this.SetAttributeValue("address2_upszone", value);
				this.OnPropertyChanged("Address2_UPSZone");
			}
		}
	


		/// <summary>
		/// Escolha o fuso horário ou a compensação UTC deste endereço para que outras pessoas possam fazer referência a ele ao contatar alguém nesse endereço.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_utcoffset")]
		public System.Nullable<int> Address2_UTCOffset
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("address2_utcoffset");
			}
			set
			{
				this.OnPropertyChanging("Address2_UTCOffset");
				this.SetAttributeValue("address2_utcoffset", value);
				this.OnPropertyChanged("Address2_UTCOffset");
			}
		}
	


		/// <summary>
		/// Informações sobre o valor do orçamento da empresa ou organização do cliente potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("budgetamount")]
		public Microsoft.Xrm.Sdk.Money BudgetAmount
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("budgetamount");
			}
			set
			{
				this.OnPropertyChanging("BudgetAmount");
				this.SetAttributeValue("budgetamount", value);
				this.OnPropertyChanged("BudgetAmount");
			}
		}
	


		/// <summary>
		/// Valor do Valor do Orçamento em moeda base.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("budgetamount_base")]
		public Microsoft.Xrm.Sdk.Money BudgetAmount_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("budgetamount_base");
			}
		}
	


		/// <summary>
		/// Informações sobre o status do orçamento da empresa ou organização do cliente potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("budgetstatus")]
		public Microsoft.Xrm.Sdk.OptionSetValue BudgetStatus
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("budgetstatus");
			}
			set
			{
				this.OnPropertyChanging("BudgetStatus");
				this.SetAttributeValue("budgetstatus", value);
				this.OnPropertyChanged("BudgetStatus");
			}
		}
	
		public virtual Enums.BudgetStatus? BudgetStatusEnum
		{
			get
			{
				return ((Enums.BudgetStatus?)(EntityOptionSetEnum.GetEnum(this, "budgetstatus")));
			}
			set
			{
				BudgetStatus = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Escolha a campanha da qual o cliente potencial foi gerado para rastrear a efetividade das campanhas de marketing e identificar as comunicações recebidas pelo cliente potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("campaignid")]
		public Microsoft.Xrm.Sdk.EntityReference CampaignId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("campaignid");
			}
			set
			{
				this.OnPropertyChanging("CampaignId");
				this.SetAttributeValue("campaignid", value);
				this.OnPropertyChanged("CampaignId");
			}
		}
	



		/// <summary>
		/// Digite o nome da empresa associada ao cliente potencial. Esse se torna o nome da conta quando o cliente potencial é qualificado e convertido em uma conta de cliente.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("companyname")]
		public string CompanyName
		{
			get
			{
				return this.GetAttributeValue<string>("companyname");
			}
			set
			{
				this.OnPropertyChanging("CompanyName");
				this.SetAttributeValue("companyname", value);
				this.OnPropertyChanged("CompanyName");
			}
		}
	


		/// <summary>
		/// Escolha se o cliente potencial confirmou o interesse em suas ofertas. Isso ajuda a determinar a qualidade do cliente potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("confirminterest")]
		public System.Nullable<bool> ConfirmInterest
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("confirminterest");
			}
			set
			{
				this.OnPropertyChanging("ConfirmInterest");
				this.SetAttributeValue("confirminterest", value);
				this.OnPropertyChanged("ConfirmInterest");
			}
		}
	
		public virtual Enums.ConfirmInterest? ConfirmInterestEnum
		{
			get
			{
				return ((Enums.ConfirmInterest?)(EntityOptionSetEnum.GetEnum(this, "confirminterest")));
			}
			set
			{
		       if (value.HasValue)
                    ConfirmInterest = ((int)value == 1);
                else                   
                    ConfirmInterest = null;
			}
		}


		/// <summary>
		/// Identificador exclusivo do contato ao qual o cliente potencial está associado.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contactid")]
		public Microsoft.Xrm.Sdk.EntityReference ContactId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("contactid");
			}
		}
	



		/// <summary>
		/// Mostra quem criou o registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
	



		/// <summary>
		/// Data e hora de criação do registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
	


		/// <summary>
		/// Mostra quem criou o registro em nome de outro usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
	



		/// <summary>
		/// Selecione a conta ou o contato do cliente para fornecer um link rápido para detalhes adicionais do cliente, como informações sobre a conta, atividades e oportunidades.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
		public Microsoft.Xrm.Sdk.EntityReference CustomerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("customerid");
			}
			set
			{
				this.OnPropertyChanging("CustomerId");
				this.SetAttributeValue("customerid", value);
				this.OnPropertyChanged("CustomerId");
			}
		}
	




		/// <summary>
		/// Escolha se suas observações incluem informações sobre quem faz as decisões de compra na empresa do cliente potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("decisionmaker")]
		public System.Nullable<bool> DecisionMaker
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("decisionmaker");
			}
			set
			{
				this.OnPropertyChanging("DecisionMaker");
				this.SetAttributeValue("decisionmaker", value);
				this.OnPropertyChanged("DecisionMaker");
			}
		}
	
		public virtual Enums.DecisionMaker? DecisionMakerEnum
		{
			get
			{
				return ((Enums.DecisionMaker?)(EntityOptionSetEnum.GetEnum(this, "decisionmaker")));
			}
			set
			{
		       if (value.HasValue)
                    DecisionMaker = ((int)value == 1);
                else                   
                    DecisionMaker = null;
			}
		}


		/// <summary>
		/// Digite informações adicionais para descrever o cliente potencial, como um extrato do site da empresa.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			set
			{
				this.OnPropertyChanging("Description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("Description");
			}
		}
	


		/// <summary>
		/// Escolha se o cliente potencial aceita envio de email em massa em campanhas de marketing ou rápidas. Se Não Permitir estiver escolhido, o cliente potencial poderá ser adicionado às listas de marketing, mas será excluído do email.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotbulkemail")]
		public System.Nullable<bool> DoNotBulkEMail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotbulkemail");
			}
			set
			{
				this.OnPropertyChanging("DoNotBulkEMail");
				this.SetAttributeValue("donotbulkemail", value);
				this.OnPropertyChanged("DoNotBulkEMail");
			}
		}
	
		public virtual Enums.DoNotBulkEMail? DoNotBulkEMailEnum
		{
			get
			{
				return ((Enums.DoNotBulkEMail?)(EntityOptionSetEnum.GetEnum(this, "donotbulkemail")));
			}
			set
			{
		       if (value.HasValue)
                    DoNotBulkEMail = ((int)value == 1);
                else                   
                    DoNotBulkEMail = null;
			}
		}


		/// <summary>
		/// Escolha se o lead permite o envio de email direto do Microsoft Dynamics 365.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotemail")]
		public System.Nullable<bool> DoNotEMail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotemail");
			}
			set
			{
				this.OnPropertyChanging("DoNotEMail");
				this.SetAttributeValue("donotemail", value);
				this.OnPropertyChanged("DoNotEMail");
			}
		}
	
		public virtual Enums.DoNotEMail? DoNotEMailEnum
		{
			get
			{
				return ((Enums.DoNotEMail?)(EntityOptionSetEnum.GetEnum(this, "donotemail")));
			}
			set
			{
		       if (value.HasValue)
                    DoNotEMail = ((int)value == 1);
                else                   
                    DoNotEMail = null;
			}
		}


		/// <summary>
		/// Escolha se o cliente potencial permite fax.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotfax")]
		public System.Nullable<bool> DoNotFax
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotfax");
			}
			set
			{
				this.OnPropertyChanging("DoNotFax");
				this.SetAttributeValue("donotfax", value);
				this.OnPropertyChanged("DoNotFax");
			}
		}
	
		public virtual Enums.DoNotFax? DoNotFaxEnum
		{
			get
			{
				return ((Enums.DoNotFax?)(EntityOptionSetEnum.GetEnum(this, "donotfax")));
			}
			set
			{
		       if (value.HasValue)
                    DoNotFax = ((int)value == 1);
                else                   
                    DoNotFax = null;
			}
		}


		/// <summary>
		/// Escolha se o cliente potencial permite telefonemas.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotphone")]
		public System.Nullable<bool> DoNotPhone
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotphone");
			}
			set
			{
				this.OnPropertyChanging("DoNotPhone");
				this.SetAttributeValue("donotphone", value);
				this.OnPropertyChanged("DoNotPhone");
			}
		}
	
		public virtual Enums.DoNotPhone? DoNotPhoneEnum
		{
			get
			{
				return ((Enums.DoNotPhone?)(EntityOptionSetEnum.GetEnum(this, "donotphone")));
			}
			set
			{
		       if (value.HasValue)
                    DoNotPhone = ((int)value == 1);
                else                   
                    DoNotPhone = null;
			}
		}


		/// <summary>
		/// Escolha se o cliente potencial permite email direto.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotpostalmail")]
		public System.Nullable<bool> DoNotPostalMail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotpostalmail");
			}
			set
			{
				this.OnPropertyChanging("DoNotPostalMail");
				this.SetAttributeValue("donotpostalmail", value);
				this.OnPropertyChanged("DoNotPostalMail");
			}
		}
	
		public virtual Enums.DoNotPostalMail? DoNotPostalMailEnum
		{
			get
			{
				return ((Enums.DoNotPostalMail?)(EntityOptionSetEnum.GetEnum(this, "donotpostalmail")));
			}
			set
			{
		       if (value.HasValue)
                    DoNotPostalMail = ((int)value == 1);
                else                   
                    DoNotPostalMail = null;
			}
		}


		/// <summary>
		/// Escolha se o cliente potencial aceita materiais de marketing, como brochuras ou catálogos. Os clientes potenciais que recusarem podem ser excluídos das iniciativas de marketing.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotsendmm")]
		public System.Nullable<bool> DoNotSendMM
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotsendmm");
			}
			set
			{
				this.OnPropertyChanging("DoNotSendMM");
				this.SetAttributeValue("donotsendmm", value);
				this.OnPropertyChanged("DoNotSendMM");
			}
		}
	
		public virtual Enums.DoNotSendMM? DoNotSendMMEnum
		{
			get
			{
				return ((Enums.DoNotSendMM?)(EntityOptionSetEnum.GetEnum(this, "donotsendmm")));
			}
			set
			{
		       if (value.HasValue)
                    DoNotSendMM = ((int)value == 1);
                else                   
                    DoNotSendMM = null;
			}
		}


		/// <summary>
		/// Digite o endereço de email principal do cliente potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress1")]
		public string EMailAddress1
		{
			get
			{
				return this.GetAttributeValue<string>("emailaddress1");
			}
			set
			{
				this.OnPropertyChanging("EMailAddress1");
				this.SetAttributeValue("emailaddress1", value);
				this.OnPropertyChanged("EMailAddress1");
			}
		}
	


		/// <summary>
		/// Digite o endereço de email secundário do cliente potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress2")]
		public string EMailAddress2
		{
			get
			{
				return this.GetAttributeValue<string>("emailaddress2");
			}
			set
			{
				this.OnPropertyChanging("EMailAddress2");
				this.SetAttributeValue("emailaddress2", value);
				this.OnPropertyChanged("EMailAddress2");
			}
		}
	


		/// <summary>
		/// Digite o terceiro endereço de email do cliente potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress3")]
		public string EMailAddress3
		{
			get
			{
				return this.GetAttributeValue<string>("emailaddress3");
			}
			set
			{
				this.OnPropertyChanging("EMailAddress3");
				this.SetAttributeValue("emailaddress3", value);
				this.OnPropertyChanged("EMailAddress3");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage")]
		public byte[] EntityImage
		{
			get
			{
				return this.GetAttributeValue<byte[]>("entityimage");
			}
			set
			{
				this.OnPropertyChanging("EntityImage");
				this.SetAttributeValue("entityimage", value);
				this.OnPropertyChanged("EntityImage");
			}
		}
	


		/// <summary>
		///  
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_timestamp")]
		public System.Nullable<long> EntityImage_Timestamp
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("entityimage_timestamp");
			}
		}
	


		/// <summary>
		///  
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_url")]
		public string EntityImage_URL
		{
			get
			{
				return this.GetAttributeValue<string>("entityimage_url");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimageid")]
		public System.Nullable<System.Guid> EntityImageId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("entityimageid");
			}
		}
	


		/// <summary>
		/// Digite o valor da receita estimada que este cliente potencial gerará para auxiliar na previsão e no planejamento de vendas.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("estimatedamount")]
		public Microsoft.Xrm.Sdk.Money EstimatedAmount
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("estimatedamount");
			}
			set
			{
				this.OnPropertyChanging("EstimatedAmount");
				this.SetAttributeValue("estimatedamount", value);
				this.OnPropertyChanged("EstimatedAmount");
			}
		}
	


		/// <summary>
		/// Valor do Valor Est. em moeda base.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("estimatedamount_base")]
		public Microsoft.Xrm.Sdk.Money EstimatedAmount_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("estimatedamount_base");
			}
		}
	


		/// <summary>
		/// Insira a data de fechamento do cliente potencial, para que a equipe de vendas possa agendar reuniões de acompanhamento em tempo hábil para mover o colaborador potencial para o próximo estágio da venda.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("estimatedclosedate")]
		public System.Nullable<System.DateTime> EstimatedCloseDate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("estimatedclosedate");
			}
			set
			{
				this.OnPropertyChanging("EstimatedCloseDate");
				this.SetAttributeValue("estimatedclosedate", value);
				this.OnPropertyChanged("EstimatedCloseDate");
			}
		}
	


		/// <summary>
		/// Digite um valor numérico para o valor estimado do cliente potencial, como a quantidade de um produto, se nenhum valor de receita puder ser especificado no campo Valor Est. Isso pode ser usado para previsão e planejamento de vendas.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("estimatedvalue")]
		public System.Nullable<double> EstimatedValue
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("estimatedvalue");
			}
			set
			{
				this.OnPropertyChanging("EstimatedValue");
				this.SetAttributeValue("estimatedvalue", value);
				this.OnPropertyChanged("EstimatedValue");
			}
		}
	


		/// <summary>
		/// Escolha se o ajuste entre as necessidades do cliente potencial e suas ofertas foi avaliado.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("evaluatefit")]
		public System.Nullable<bool> EvaluateFit
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("evaluatefit");
			}
			set
			{
				this.OnPropertyChanging("EvaluateFit");
				this.SetAttributeValue("evaluatefit", value);
				this.OnPropertyChanged("EvaluateFit");
			}
		}
	
		public virtual Enums.EvaluateFit? EvaluateFitEnum
		{
			get
			{
				return ((Enums.EvaluateFit?)(EntityOptionSetEnum.GetEnum(this, "evaluatefit")));
			}
			set
			{
		       if (value.HasValue)
                    EvaluateFit = ((int)value == 1);
                else                   
                    EvaluateFit = null;
			}
		}


		/// <summary>
		/// Mostra a taxa de conversão da moeda do registro. A taxa de câmbio é usada para converter todos os campos monetários do registro da moeda local na moeda padrão do sistema.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
		public System.Nullable<decimal> ExchangeRate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
			}
		}
	


		/// <summary>
		/// Digite o número do fax do contato principal do cliente potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fax")]
		public string Fax
		{
			get
			{
				return this.GetAttributeValue<string>("fax");
			}
			set
			{
				this.OnPropertyChanging("Fax");
				this.SetAttributeValue("fax", value);
				this.OnPropertyChanged("Fax");
			}
		}
	


		/// <summary>
		/// Digite o nome do contato principal do cliente potencial para garantir que o colaborador potencial seja tratado corretamente em chamadas de vendas, emails e campanhas de marketing.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("firstname")]
		public string FirstName
		{
			get
			{
				return this.GetAttributeValue<string>("firstname");
			}
			set
			{
				this.OnPropertyChanging("FirstName");
				this.SetAttributeValue("firstname", value);
				this.OnPropertyChanged("FirstName");
			}
		}
	


		/// <summary>
		/// Informações que especificam se será permitido acompanhar atividades de email, como aberturas, exibições de anexo e cliques em links nos emails enviados ao lead.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("followemail")]
		public System.Nullable<bool> FollowEmail
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("followemail");
			}
			set
			{
				this.OnPropertyChanging("FollowEmail");
				this.SetAttributeValue("followemail", value);
				this.OnPropertyChanged("FollowEmail");
			}
		}
	
		public virtual Enums.FollowEmail? FollowEmailEnum
		{
			get
			{
				return ((Enums.FollowEmail?)(EntityOptionSetEnum.GetEnum(this, "followemail")));
			}
			set
			{
		       if (value.HasValue)
                    FollowEmail = ((int)value == 1);
                else                   
                    FollowEmail = null;
			}
		}


		/// <summary>
		/// Combina e mostra o nome e os sobrenomes do cliente potencial para que o nome completo possa ser mostrado em exibições e relatórios.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fullname")]
		public string FullName
		{
			get
			{
				return this.GetAttributeValue<string>("fullname");
			}
		}
	


		/// <summary>
		/// Número de sequência da importação que criou este registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
	


		/// <summary>
		/// Escolha o setor principal no qual o negócio do cliente potencial está focalizado, para uso em segmentação de marketing e análise demográfica.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("industrycode")]
		public Microsoft.Xrm.Sdk.OptionSetValue IndustryCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("industrycode");
			}
			set
			{
				this.OnPropertyChanging("IndustryCode");
				this.SetAttributeValue("industrycode", value);
				this.OnPropertyChanged("IndustryCode");
			}
		}
	
		public virtual Enums.IndustryCode? IndustryCodeEnum
		{
			get
			{
				return ((Enums.IndustryCode?)(EntityOptionSetEnum.GetEnum(this, "industrycode")));
			}
			set
			{
				IndustryCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Escolha se alguém da equipe de vendas entrou em contato com este cliente potencial anteriormente.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("initialcommunication")]
		public Microsoft.Xrm.Sdk.OptionSetValue InitialCommunication
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("initialcommunication");
			}
			set
			{
				this.OnPropertyChanging("InitialCommunication");
				this.SetAttributeValue("initialcommunication", value);
				this.OnPropertyChanged("InitialCommunication");
			}
		}
	
		public virtual Enums.InitialCommunication? InitialCommunicationEnum
		{
			get
			{
				return ((Enums.InitialCommunication?)(EntityOptionSetEnum.GetEnum(this, "initialcommunication")));
			}
			set
			{
				InitialCommunication = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Informações sobre se o contato foi criado automaticamente durante a promoção de um email ou um compromisso.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isautocreate")]
		public System.Nullable<bool> IsAutoCreate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isautocreate");
			}
		}
	
		public virtual Enums.IsAutoCreate? IsAutoCreateEnum
		{
			get
			{
				return ((Enums.IsAutoCreate?)(EntityOptionSetEnum.GetEnum(this, "isautocreate")));
			}
		}


		/// <summary>
		/// Indica se o cliente potencial é particular ou se está visível para toda a organização.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isprivate")]
		public System.Nullable<bool> IsPrivate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isprivate");
			}
		}
	
		public virtual Enums.IsPrivate? IsPrivateEnum
		{
			get
			{
				return ((Enums.IsPrivate?)(EntityOptionSetEnum.GetEnum(this, "isprivate")));
			}
		}


		/// <summary>
		/// Digite o cargo do contato principal deste cliente potencial para garantir que o colaborador potencial seja tratado corretamente em chamadas de vendas, emails e campanhas de marketing.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("jobtitle")]
		public string JobTitle
		{
			get
			{
				return this.GetAttributeValue<string>("jobtitle");
			}
			set
			{
				this.OnPropertyChanging("JobTitle");
				this.SetAttributeValue("jobtitle", value);
				this.OnPropertyChanged("JobTitle");
			}
		}
	


		/// <summary>
		/// Digite o sobrenome do contato principal do cliente potencial para garantir que o colaborador potencial seja tratado corretamente em chamadas de vendas, emails e campanhas de marketing.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastname")]
		public string LastName
		{
			get
			{
				return this.GetAttributeValue<string>("lastname");
			}
			set
			{
				this.OnPropertyChanging("LastName");
				this.SetAttributeValue("lastname", value);
				this.OnPropertyChanged("LastName");
			}
		}
	


		/// <summary>
		/// Contém o carimbo de data e hora do último tempo de suspensão.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastonholdtime")]
		public System.Nullable<System.DateTime> LastOnHoldTime
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastonholdtime");
			}
			set
			{
				this.OnPropertyChanging("LastOnHoldTime");
				this.SetAttributeValue("lastonholdtime", value);
				this.OnPropertyChanged("LastOnHoldTime");
			}
		}
	


		/// <summary>
		/// Mostra a data em que o cliente potencial foi incluído pela última vez em uma campanha de marketing ou campanha rápida.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastusedincampaign")]
		public System.Nullable<System.DateTime> LastUsedInCampaign
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastusedincampaign");
			}
			set
			{
				this.OnPropertyChanging("LastUsedInCampaign");
				this.SetAttributeValue("lastusedincampaign", value);
				this.OnPropertyChanged("LastUsedInCampaign");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo do cliente potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("leadid")]
		public System.Nullable<System.Guid> LeadId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("leadid");
			}
			set
			{
				this.OnPropertyChanging("LeadId");
				this.SetAttributeValue("leadid", value);
						if (value.HasValue)
						{
							base.Id = value.Value;
						}
						else
						{
							base.Id = System.Guid.Empty;
						}
				this.OnPropertyChanged("LeadId");
			}
		}
	


		/// <summary>
		/// Escolha um valor de classificação para indicar a possibilidade de o cliente potencial se tornar um cliente.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("leadqualitycode")]
		public Microsoft.Xrm.Sdk.OptionSetValue LeadQualityCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("leadqualitycode");
			}
			set
			{
				this.OnPropertyChanging("LeadQualityCode");
				this.SetAttributeValue("leadqualitycode", value);
				this.OnPropertyChanged("LeadQualityCode");
			}
		}
	
		public virtual Enums.LeadQualityCode? LeadQualityCodeEnum
		{
			get
			{
				return ((Enums.LeadQualityCode?)(EntityOptionSetEnum.GetEnum(this, "leadqualitycode")));
			}
			set
			{
				LeadQualityCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Escolha a origem de marketing principal que motivou o cliente potencial a entrar em contato com você.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("leadsourcecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue LeadSourceCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("leadsourcecode");
			}
			set
			{
				this.OnPropertyChanging("LeadSourceCode");
				this.SetAttributeValue("leadsourcecode", value);
				this.OnPropertyChanged("LeadSourceCode");
			}
		}
	
		public virtual Enums.LeadSourceCode? LeadSourceCodeEnum
		{
			get
			{
				return ((Enums.LeadSourceCode?)(EntityOptionSetEnum.GetEnum(this, "leadsourcecode")));
			}
			set
			{
				LeadSourceCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// O identificador exclusivo do cliente potencial mestre para mesclagem.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("masterid")]
		public Microsoft.Xrm.Sdk.EntityReference MasterId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("masterid");
			}
		}
	



		/// <summary>
		/// Informa se o cliente potencial foi mesclado com outro cliente potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("merged")]
		public System.Nullable<bool> Merged
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("merged");
			}
		}
	
		public virtual Enums.Merged? MergedEnum
		{
			get
			{
				return ((Enums.Merged?)(EntityOptionSetEnum.GetEnum(this, "merged")));
			}
		}


		/// <summary>
		/// Digite a inicial ou o nome do meio do contato principal do cliente potencial para garantir que o colaborador potencial seja tratado corretamente em chamadas de vendas, emails e campanhas de marketing.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("middlename")]
		public string MiddleName
		{
			get
			{
				return this.GetAttributeValue<string>("middlename");
			}
			set
			{
				this.OnPropertyChanging("MiddleName");
				this.SetAttributeValue("middlename", value);
				this.OnPropertyChanged("MiddleName");
			}
		}
	


		/// <summary>
		/// Digite o número do celular do contato principal do cliente potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mobilephone")]
		public string MobilePhone
		{
			get
			{
				return this.GetAttributeValue<string>("mobilephone");
			}
			set
			{
				this.OnPropertyChanging("MobilePhone");
				this.SetAttributeValue("mobilephone", value);
				this.OnPropertyChanged("MobilePhone");
			}
		}
	


		/// <summary>
		/// Mostra quem atualizou o registro pela última vez.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
	



		/// <summary>
		/// Data e hora de modificação do registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
	


		/// <summary>
		/// Mostra quem atualizou o registro pela última vez em nome de outro usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
	



		/// <summary>
		/// Indica se a Oportunidade criada ao qualificar este Cliente Potencial é para uma venda baseada em item ou em Serviço
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_ordertype")]
		public Microsoft.Xrm.Sdk.OptionSetValue msdyn_ordertype
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("msdyn_ordertype");
			}
			set
			{
				this.OnPropertyChanging("msdyn_ordertype");
				this.SetAttributeValue("msdyn_ordertype", value);
				this.OnPropertyChanged("msdyn_ordertype");
			}
		}
	
		public virtual Enums.msdyn_ordertype? msdyn_ordertypeEnum
		{
			get
			{
				return ((Enums.msdyn_ordertype?)(EntityOptionSetEnum.GetEnum(this, "msdyn_ordertype")));
			}
			set
			{
				msdyn_ordertype = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Escolha o grau de necessidade da empresa do cliente potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("need")]
		public Microsoft.Xrm.Sdk.OptionSetValue Need
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("need");
			}
			set
			{
				this.OnPropertyChanging("Need");
				this.SetAttributeValue("need", value);
				this.OnPropertyChanged("Need");
			}
		}
	
		public virtual Enums.Need? NeedEnum
		{
			get
			{
				return ((Enums.Need?)(EntityOptionSetEnum.GetEnum(this, "need")));
			}
			set
			{
				Need = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Digite o número de funcionários que trabalham na empresa associada ao cliente potencial, para uso em segmentação de marketing e análise demográfica.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("numberofemployees")]
		public System.Nullable<int> NumberOfEmployees
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("numberofemployees");
			}
			set
			{
				this.OnPropertyChanging("NumberOfEmployees");
				this.SetAttributeValue("numberofemployees", value);
				this.OnPropertyChanged("NumberOfEmployees");
			}
		}
	


		/// <summary>
		/// Mostra o tempo, em minutos, em que o registro esteve em suspensão.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("onholdtime")]
		public System.Nullable<int> OnHoldTime
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("onholdtime");
			}
		}
	


		/// <summary>
		/// Este atributo é usado para Processos Empresariais de Serviços de Exemplo.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("originatingcaseid")]
		public Microsoft.Xrm.Sdk.EntityReference OriginatingCaseId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("originatingcaseid");
			}
			set
			{
				this.OnPropertyChanging("OriginatingCaseId");
				this.SetAttributeValue("originatingcaseid", value);
				this.OnPropertyChanged("OriginatingCaseId");
			}
		}
	



		/// <summary>
		/// Data e hora da migração do registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
	


		/// <summary>
		/// ID do Proprietário
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			set
			{
				this.OnPropertyChanging("OwnerId");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo da unidade de negócios proprietária do registro
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
		}
	



		/// <summary>
		/// Identificador exclusivo da equipe que possui o registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
		}
	



		/// <summary>
		/// Identificador exclusivo do usuário proprietário do registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
		}
	



		/// <summary>
		/// Digite o número do pager do contato principal do cliente potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pager")]
		public string Pager
		{
			get
			{
				return this.GetAttributeValue<string>("pager");
			}
			set
			{
				this.OnPropertyChanging("Pager");
				this.SetAttributeValue("pager", value);
				this.OnPropertyChanged("Pager");
			}
		}
	


		/// <summary>
		/// Escolha uma conta à qual conectar este cliente potencial para que o relacionamento seja visível em relatórios e análises.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentaccountid")]
		public Microsoft.Xrm.Sdk.EntityReference ParentAccountId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentaccountid");
			}
			set
			{
				this.OnPropertyChanging("ParentAccountId");
				this.SetAttributeValue("parentaccountid", value);
				this.OnPropertyChanged("ParentAccountId");
			}
		}
	



		/// <summary>
		/// Escolha um contato ao qual conectar este cliente potencial, para que o relacionamento seja visível em relatórios e análises.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcontactid")]
		public Microsoft.Xrm.Sdk.EntityReference ParentContactId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentcontactid");
			}
			set
			{
				this.OnPropertyChanging("ParentContactId");
				this.SetAttributeValue("parentcontactid", value);
				this.OnPropertyChanged("ParentContactId");
			}
		}
	



		/// <summary>
		/// Mostra se o cliente potencial participa de regras de fluxo de trabalho.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("participatesinworkflow")]
		public System.Nullable<bool> ParticipatesInWorkflow
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("participatesinworkflow");
			}
			set
			{
				this.OnPropertyChanging("ParticipatesInWorkflow");
				this.SetAttributeValue("participatesinworkflow", value);
				this.OnPropertyChanged("ParticipatesInWorkflow");
			}
		}
	
		public virtual Enums.ParticipatesInWorkflow? ParticipatesInWorkflowEnum
		{
			get
			{
				return ((Enums.ParticipatesInWorkflow?)(EntityOptionSetEnum.GetEnum(this, "participatesinworkflow")));
			}
			set
			{
		       if (value.HasValue)
                    ParticipatesInWorkflow = ((int)value == 1);
                else                   
                    ParticipatesInWorkflow = null;
			}
		}


		/// <summary>
		/// Escolha o método preferencial de contato.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredcontactmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PreferredContactMethodCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredcontactmethodcode");
			}
			set
			{
				this.OnPropertyChanging("PreferredContactMethodCode");
				this.SetAttributeValue("preferredcontactmethodcode", value);
				this.OnPropertyChanged("PreferredContactMethodCode");
			}
		}
	
		public virtual Enums.PreferredContactMethodCode? PreferredContactMethodCodeEnum
		{
			get
			{
				return ((Enums.PreferredContactMethodCode?)(EntityOptionSetEnum.GetEnum(this, "preferredcontactmethodcode")));
			}
			set
			{
				PreferredContactMethodCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Escolha a prioridade de forma que os clientes preferenciais ou os problemas críticos sejam tratados rapidamente.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("prioritycode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PriorityCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("prioritycode");
			}
			set
			{
				this.OnPropertyChanging("PriorityCode");
				this.SetAttributeValue("prioritycode", value);
				this.OnPropertyChanged("PriorityCode");
			}
		}
	
		public virtual Enums.PriorityCode? PriorityCodeEnum
		{
			get
			{
				return ((Enums.PriorityCode?)(EntityOptionSetEnum.GetEnum(this, "prioritycode")));
			}
			set
			{
				PriorityCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Contém a id do processo associado à entidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
		public System.Nullable<System.Guid> ProcessId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("processid");
			}
			set
			{
				this.OnPropertyChanging("ProcessId");
				this.SetAttributeValue("processid", value);
				this.OnPropertyChanged("ProcessId");
			}
		}
	


		/// <summary>
		/// Escolha se um indivíduo ou comitê será envolvido no processo de compra do cliente potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("purchaseprocess")]
		public Microsoft.Xrm.Sdk.OptionSetValue PurchaseProcess
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("purchaseprocess");
			}
			set
			{
				this.OnPropertyChanging("PurchaseProcess");
				this.SetAttributeValue("purchaseprocess", value);
				this.OnPropertyChanged("PurchaseProcess");
			}
		}
	
		public virtual Enums.PurchaseProcess? PurchaseProcessEnum
		{
			get
			{
				return ((Enums.PurchaseProcess?)(EntityOptionSetEnum.GetEnum(this, "purchaseprocess")));
			}
			set
			{
				PurchaseProcess = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Escolha a quantidade de tempo provável que o cliente potencial levará para fazer uma compra, para que a equipe de vendas esteja ciente.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("purchasetimeframe")]
		public Microsoft.Xrm.Sdk.OptionSetValue PurchaseTimeFrame
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("purchasetimeframe");
			}
			set
			{
				this.OnPropertyChanging("PurchaseTimeFrame");
				this.SetAttributeValue("purchasetimeframe", value);
				this.OnPropertyChanged("PurchaseTimeFrame");
			}
		}
	
		public virtual Enums.PurchaseTimeFrame? PurchaseTimeFrameEnum
		{
			get
			{
				return ((Enums.PurchaseTimeFrame?)(EntityOptionSetEnum.GetEnum(this, "purchasetimeframe")));
			}
			set
			{
				PurchaseTimeFrame = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Digite comentários sobre a qualificação ou a pontuação do cliente potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("qualificationcomments")]
		public string QualificationComments
		{
			get
			{
				return this.GetAttributeValue<string>("qualificationcomments");
			}
			set
			{
				this.OnPropertyChanging("QualificationComments");
				this.SetAttributeValue("qualificationcomments", value);
				this.OnPropertyChanged("QualificationComments");
			}
		}
	


		/// <summary>
		/// Escolha a oportunidade na qual o cliente potencial foi qualificado e convertido.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("qualifyingopportunityid")]
		public Microsoft.Xrm.Sdk.EntityReference QualifyingOpportunityId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("qualifyingopportunityid");
			}
			set
			{
				this.OnPropertyChanging("QualifyingOpportunityId");
				this.SetAttributeValue("qualifyingopportunityid", value);
				this.OnPropertyChanged("QualifyingOpportunityId");
			}
		}
	



		/// <summary>
		/// Resposta de Campanha Relacionada.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("relatedobjectid")]
		public Microsoft.Xrm.Sdk.EntityReference RelatedObjectId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("relatedobjectid");
			}
			set
			{
				this.OnPropertyChanging("RelatedObjectId");
				this.SetAttributeValue("relatedobjectid", value);
				this.OnPropertyChanged("RelatedObjectId");
			}
		}
	



		/// <summary>
		/// Digite a receita anual da empresa associada ao cliente potencial para fornecer um entendimento do negócio do colaborador potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("revenue")]
		public Microsoft.Xrm.Sdk.Money Revenue
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("revenue");
			}
			set
			{
				this.OnPropertyChanging("Revenue");
				this.SetAttributeValue("revenue", value);
				this.OnPropertyChanged("Revenue");
			}
		}
	


		/// <summary>
		/// Valor do Receita Anual em moeda base.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("revenue_base")]
		public Microsoft.Xrm.Sdk.Money Revenue_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("revenue_base");
			}
		}
	


		/// <summary>
		/// Escolha o estágio de vendas deste cliente potencial para ajudar a equipe de vendas em seus esforços de converter este cliente potencial em uma oportunidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesstage")]
		public Microsoft.Xrm.Sdk.OptionSetValue SalesStage
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("salesstage");
			}
			set
			{
				this.OnPropertyChanging("SalesStage");
				this.SetAttributeValue("salesstage", value);
				this.OnPropertyChanged("SalesStage");
			}
		}
	
		public virtual Enums.SalesStage? SalesStageEnum
		{
			get
			{
				return ((Enums.SalesStage?)(EntityOptionSetEnum.GetEnum(this, "salesstage")));
			}
			set
			{
				SalesStage = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Escolha o estágio do processo de vendas deste cliente potencial para ajudar a determinar a probabilidade de conversão do cliente potencial em uma oportunidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesstagecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue SalesStageCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("salesstagecode");
			}
			set
			{
				this.OnPropertyChanging("SalesStageCode");
				this.SetAttributeValue("salesstagecode", value);
				this.OnPropertyChanged("SalesStageCode");
			}
		}
	
		public virtual Enums.SalesStageCode? SalesStageCodeEnum
		{
			get
			{
				return ((Enums.SalesStageCode?)(EntityOptionSetEnum.GetEnum(this, "salesstagecode")));
			}
			set
			{
				SalesStageCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Digite a saudação do contato principal deste cliente potencial para garantir que o colaborador potencial seja tratado corretamente em chamadas de vendas, mensagens de email e campanhas de marketing.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salutation")]
		public string Salutation
		{
			get
			{
				return this.GetAttributeValue<string>("salutation");
			}
			set
			{
				this.OnPropertyChanging("Salutation");
				this.SetAttributeValue("salutation", value);
				this.OnPropertyChanged("Salutation");
			}
		}
	


		/// <summary>
		/// Digite a data e a hora da reunião de acompanhamento de prospecção com o cliente potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("schedulefollowup_prospect")]
		public System.Nullable<System.DateTime> ScheduleFollowUp_Prospect
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("schedulefollowup_prospect");
			}
			set
			{
				this.OnPropertyChanging("ScheduleFollowUp_Prospect");
				this.SetAttributeValue("schedulefollowup_prospect", value);
				this.OnPropertyChanged("ScheduleFollowUp_Prospect");
			}
		}
	


		/// <summary>
		/// Digite a data e a hora da reunião de acompanhamento de qualificação com o cliente potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("schedulefollowup_qualify")]
		public System.Nullable<System.DateTime> ScheduleFollowUp_Qualify
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("schedulefollowup_qualify");
			}
			set
			{
				this.OnPropertyChanging("ScheduleFollowUp_Qualify");
				this.SetAttributeValue("schedulefollowup_qualify", value);
				this.OnPropertyChanged("ScheduleFollowUp_Qualify");
			}
		}
	


		/// <summary>
		/// Digite o CNAE (Código Nacional de Atividade Econômica) que indica o setor principal do negócio do cliente potencial, para uso em segmentação de marketing e análise demográfica.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sic")]
		public string SIC
		{
			get
			{
				return this.GetAttributeValue<string>("sic");
			}
			set
			{
				this.OnPropertyChanging("SIC");
				this.SetAttributeValue("sic", value);
				this.OnPropertyChanged("SIC");
			}
		}
	


		/// <summary>
		/// Escolha o SLA (contrato de nível de serviço) que você quer aplicar ao registro do Cliente Potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slaid")]
		public Microsoft.Xrm.Sdk.EntityReference SLAId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("slaid");
			}
			set
			{
				this.OnPropertyChanging("SLAId");
				this.SetAttributeValue("slaid", value);
				this.OnPropertyChanged("SLAId");
			}
		}
	



		/// <summary>
		/// O último SLA aplicado a esta ocorrência. Este campo é somente para uso interno.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slainvokedid")]
		public Microsoft.Xrm.Sdk.EntityReference SLAInvokedId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("slainvokedid");
			}
		}
	



		/// <summary>
		/// Contém a id do estágio onde a entidade está localizada.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
		public System.Nullable<System.Guid> StageId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("stageid");
			}
			set
			{
				this.OnPropertyChanging("StageId");
				this.SetAttributeValue("stageid", value);
				this.OnPropertyChanged("StageId");
			}
		}
	


		/// <summary>
		/// Mostra se o cliente potencial está em aberto, qualificado ou desqualificado. Clientes potenciais qualificados e desqualificados são somente leitura e não podem ser editados a não ser que sejam reativados.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<LeadState> StateCode
		{
				get
				{
					Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
					if ((optionSet != null))
					{
						return ((LeadState)(System.Enum.ToObject(typeof(LeadState), optionSet.Value)));
					}
					else
					{
						return null;
					}
				}
					set
					{
						this.OnPropertyChanging("StateCode");
						if ((value == null))
						{
							this.SetAttributeValue("statecode", null);
						}
						else
						{
							this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
						}
						this.OnPropertyChanged("StateCode");
					}
		}
	


		/// <summary>
		/// Escolha o status do cliente potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			set
			{
				this.OnPropertyChanging("StatusCode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("StatusCode");
			}
		}
	


		/// <summary>
		/// Digite o assunto ou o nome descritivo, como a ordem esperada, o nome da empresa ou a lista de origem de marketing, para identificar o cliente potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subject")]
		public string Subject
		{
			get
			{
				return this.GetAttributeValue<string>("subject");
			}
			set
			{
				this.OnPropertyChanging("Subject");
				this.SetAttributeValue("subject", value);
				this.OnPropertyChanged("Subject");
			}
		}
	


		/// <summary>
		/// Digite o número do telefone comercial do contato principal do cliente potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone1")]
		public string Telephone1
		{
			get
			{
				return this.GetAttributeValue<string>("telephone1");
			}
			set
			{
				this.OnPropertyChanging("Telephone1");
				this.SetAttributeValue("telephone1", value);
				this.OnPropertyChanged("Telephone1");
			}
		}
	


		/// <summary>
		/// Digite o número do telefone residencial do contato principal do cliente potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone2")]
		public string Telephone2
		{
			get
			{
				return this.GetAttributeValue<string>("telephone2");
			}
			set
			{
				this.OnPropertyChanging("Telephone2");
				this.SetAttributeValue("telephone2", value);
				this.OnPropertyChanged("Telephone2");
			}
		}
	


		/// <summary>
		/// Digite um número de telefone alternativo do contato principal do cliente potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone3")]
		public string Telephone3
		{
			get
			{
				return this.GetAttributeValue<string>("telephone3");
			}
			set
			{
				this.OnPropertyChanging("Telephone3");
				this.SetAttributeValue("telephone3", value);
				this.OnPropertyChanged("Telephone3");
			}
		}
	


		/// <summary>
		/// Tempo total gasto por mim com emails (leitura e redação) e reuniões em relação ao registro do lead.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timespentbymeonemailandmeetings")]
		public string TimeSpentByMeOnEmailAndMeetings
		{
			get
			{
				return this.GetAttributeValue<string>("timespentbymeonemailandmeetings");
			}
		}
	


		/// <summary>
		/// Apenas para uso interno.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
	


		/// <summary>
		/// Escolha a moeda local do registro para garantir que os orçamentos sejam relatados na moeda correta.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
			}
			set
			{
				this.OnPropertyChanging("TransactionCurrencyId");
				this.SetAttributeValue("transactioncurrencyid", value);
				this.OnPropertyChanged("TransactionCurrencyId");
			}
		}
	



		/// <summary>
		/// Uma lista separada por vírgula de valores de cadeia de caracteres representando os identificadores exclusivos dos estágios de uma instância do fluxo do processo empresarial na ordem em que ocorrem.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traversedpath")]
		public string TraversedPath
		{
			get
			{
				return this.GetAttributeValue<string>("traversedpath");
			}
			set
			{
				this.OnPropertyChanging("TraversedPath");
				this.SetAttributeValue("traversedpath", value);
				this.OnPropertyChanged("TraversedPath");
			}
		}
	


		/// <summary>
		/// Código de fuso horário em uso quando o registro foi criado.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
	


		/// <summary>
		/// Número da Versão
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
	


		/// <summary>
		/// Digite a URL do site da empresa associada a este cliente potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("websiteurl")]
		public string WebSiteUrl
		{
			get
			{
				return this.GetAttributeValue<string>("websiteurl");
			}
			set
			{
				this.OnPropertyChanging("WebSiteUrl");
				this.SetAttributeValue("websiteurl", value);
				this.OnPropertyChanged("WebSiteUrl");
			}
		}
	


		/// <summary>
		/// Digite a ortografia fonética do nome da empresa do cliente potencial, se o nome for especificado em japonês, para garantir que o nome seja pronunciado corretamente em telefonemas com o colaborador potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomicompanyname")]
		public string YomiCompanyName
		{
			get
			{
				return this.GetAttributeValue<string>("yomicompanyname");
			}
			set
			{
				this.OnPropertyChanging("YomiCompanyName");
				this.SetAttributeValue("yomicompanyname", value);
				this.OnPropertyChanged("YomiCompanyName");
			}
		}
	


		/// <summary>
		/// Digite a ortografia fonética do nome do cliente potencial, se o nome for especificado em japonês, para garantir que o nome seja pronunciado corretamente em telefonemas com o colaborador potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomifirstname")]
		public string YomiFirstName
		{
			get
			{
				return this.GetAttributeValue<string>("yomifirstname");
			}
			set
			{
				this.OnPropertyChanging("YomiFirstName");
				this.SetAttributeValue("yomifirstname", value);
				this.OnPropertyChanged("YomiFirstName");
			}
		}
	


		/// <summary>
		/// Combina e mostra o nome e os sobrenomes Yomi do cliente potencial para que o nome fonético completo possa ser mostrado em exibições e relatórios.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomifullname")]
		public string YomiFullName
		{
			get
			{
				return this.GetAttributeValue<string>("yomifullname");
			}
		}
	


		/// <summary>
		/// Digite a ortografia fonética do sobrenome do cliente potencial, se o nome for especificado em japonês, para garantir que o nome seja pronunciado corretamente em telefonemas com o colaborador potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomilastname")]
		public string YomiLastName
		{
			get
			{
				return this.GetAttributeValue<string>("yomilastname");
			}
			set
			{
				this.OnPropertyChanging("YomiLastName");
				this.SetAttributeValue("yomilastname", value);
				this.OnPropertyChanged("YomiLastName");
			}
		}
	


		/// <summary>
		/// Digite a ortografia fonética do nome do meio do cliente potencial, se o nome for especificado em japonês, para garantir que o nome seja pronunciado corretamente em telefonemas com o colaborador potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomimiddlename")]
		public string YomiMiddleName
		{
			get
			{
				return this.GetAttributeValue<string>("yomimiddlename");
			}
			set
			{
				this.OnPropertyChanging("YomiMiddleName");
				this.SetAttributeValue("yomimiddlename", value);
				this.OnPropertyChanged("YomiMiddleName");
			}
		}
	


		
		/// <summary>
		/// 1:N lead_master_lead
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_master_lead", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<Lead> Referencedlead_master_lead
		{
			get
			{
				return this.GetRelatedEntities<Lead>("lead_master_lead", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referencedlead_master_lead");
				this.SetRelatedEntities<Lead>("lead_master_lead", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedlead_master_lead");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lead_master_lead(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lead_master_lead");
		}

		
		/// <summary>
		/// 1:N account_originating_lead
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_originating_lead")]
		public System.Collections.Generic.IEnumerable<Account> account_originating_lead
		{
			get
			{
				return this.GetRelatedEntities<Account>("account_originating_lead", null);
			}
			set
			{
				this.OnPropertyChanging("account_originating_lead");
				this.SetRelatedEntities<Account>("account_originating_lead", null, value);
				this.OnPropertyChanged("account_originating_lead");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_account_originating_lead(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "account_originating_lead");
		}

		
		/// <summary>
		/// 1:N contact_originating_lead
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_originating_lead")]
		public System.Collections.Generic.IEnumerable<Contact> contact_originating_lead
		{
			get
			{
				return this.GetRelatedEntities<Contact>("contact_originating_lead", null);
			}
			set
			{
				this.OnPropertyChanging("contact_originating_lead");
				this.SetRelatedEntities<Contact>("contact_originating_lead", null, value);
				this.OnPropertyChanged("contact_originating_lead");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_contact_originating_lead(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "contact_originating_lead");
		}

		
		/// <summary>
		/// 1:N opportunity_originating_lead
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_originating_lead")]
		public System.Collections.Generic.IEnumerable<Opportunity> opportunity_originating_lead
		{
			get
			{
				return this.GetRelatedEntities<Opportunity>("opportunity_originating_lead", null);
			}
			set
			{
				this.OnPropertyChanging("opportunity_originating_lead");
				this.SetRelatedEntities<Opportunity>("opportunity_originating_lead", null, value);
				this.OnPropertyChanged("opportunity_originating_lead");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_opportunity_originating_lead(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "opportunity_originating_lead");
		}

		
		/// <summary>
		/// 1:N lead_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_activity_parties")]
		public System.Collections.Generic.IEnumerable<ActivityParty> lead_activity_parties
		{
			get
			{
				return this.GetRelatedEntities<ActivityParty>("lead_activity_parties", null);
			}
			set
			{
				this.OnPropertyChanging("lead_activity_parties");
				this.SetRelatedEntities<ActivityParty>("lead_activity_parties", null, value);
				this.OnPropertyChanged("lead_activity_parties");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lead_activity_parties(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lead_activity_parties");
		}

		
		/// <summary>
		/// N:1 lk_leadbase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_leadbase_createdby")]
		public SystemUser lk_leadbase_createdby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_leadbase_createdby", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_leadbase_createdby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_leadbase_createdby");
		}

		
		/// <summary>
		/// N:1 lk_lead_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lead_createdonbehalfby")]
		public SystemUser lk_lead_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_lead_createdonbehalfby", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_lead_createdonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_lead_createdonbehalfby");
		}

		
		/// <summary>
		/// N:1 lead_customer_accounts
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_customer_accounts")]
		public Account lead_customer_accounts
		{
			get
			{
				return this.GetRelatedEntity<Account>("lead_customer_accounts", null);
			}
			set
			{
				this.OnPropertyChanging("lead_customer_accounts");
				this.SetRelatedEntity<Account>("lead_customer_accounts", null, value);
				this.OnPropertyChanged("lead_customer_accounts");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lead_customer_accounts(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lead_customer_accounts");
		}

		
		/// <summary>
		/// N:1 lead_customer_contacts
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_customer_contacts")]
		public Contact lead_customer_contacts
		{
			get
			{
				return this.GetRelatedEntity<Contact>("lead_customer_contacts", null);
			}
			set
			{
				this.OnPropertyChanging("lead_customer_contacts");
				this.SetRelatedEntity<Contact>("lead_customer_contacts", null, value);
				this.OnPropertyChanged("lead_customer_contacts");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lead_customer_contacts(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lead_customer_contacts");
		}

		
		/// <summary>
		/// N:1 lead_master_lead
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("masterid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_master_lead", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public Lead Referencinglead_master_lead
		{
			get
			{
				return this.GetRelatedEntity<Lead>("lead_master_lead", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lead_master_lead(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lead_master_lead");
		}

		
		/// <summary>
		/// N:1 lk_leadbase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_leadbase_modifiedby")]
		public SystemUser lk_leadbase_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_leadbase_modifiedby", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_leadbase_modifiedby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_leadbase_modifiedby");
		}

		
		/// <summary>
		/// N:1 lk_lead_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lead_modifiedonbehalfby")]
		public SystemUser lk_lead_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_lead_modifiedonbehalfby", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_lead_modifiedonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_lead_modifiedonbehalfby");
		}

		
		/// <summary>
		/// N:1 business_unit_leads
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_leads")]
		public BusinessUnit business_unit_leads
		{
			get
			{
				return this.GetRelatedEntity<BusinessUnit>("business_unit_leads", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_business_unit_leads(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "business_unit_leads");
		}

		
		/// <summary>
		/// N:1 lead_owning_team
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_owning_team")]
		public Team lead_owning_team
		{
			get
			{
				return this.GetRelatedEntity<Team>("lead_owning_team", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lead_owning_team(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lead_owning_team");
		}

		
		/// <summary>
		/// N:1 lead_owning_user
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_owning_user")]
		public SystemUser lead_owning_user
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lead_owning_user", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lead_owning_user(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lead_owning_user");
		}

		
		/// <summary>
		/// N:1 lead_parent_account
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentaccountid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_parent_account")]
		public Account lead_parent_account
		{
			get
			{
				return this.GetRelatedEntity<Account>("lead_parent_account", null);
			}
			set
			{
				this.OnPropertyChanging("lead_parent_account");
				this.SetRelatedEntity<Account>("lead_parent_account", null, value);
				this.OnPropertyChanged("lead_parent_account");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lead_parent_account(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lead_parent_account");
		}

		
		/// <summary>
		/// N:1 lead_parent_contact
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcontactid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_parent_contact")]
		public Contact lead_parent_contact
		{
			get
			{
				return this.GetRelatedEntity<Contact>("lead_parent_contact", null);
			}
			set
			{
				this.OnPropertyChanging("lead_parent_contact");
				this.SetRelatedEntity<Contact>("lead_parent_contact", null, value);
				this.OnPropertyChanged("lead_parent_contact");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lead_parent_contact(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lead_parent_contact");
		}

		
		/// <summary>
		/// N:1 lead_qualifying_opportunity
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("qualifyingopportunityid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_qualifying_opportunity")]
		public Opportunity lead_qualifying_opportunity
		{
			get
			{
				return this.GetRelatedEntity<Opportunity>("lead_qualifying_opportunity", null);
			}
			set
			{
				this.OnPropertyChanging("lead_qualifying_opportunity");
				this.SetRelatedEntity<Opportunity>("lead_qualifying_opportunity", null, value);
				this.OnPropertyChanged("lead_qualifying_opportunity");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lead_qualifying_opportunity(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lead_qualifying_opportunity");
		}

		
		/// <summary>
		/// N:1 transactioncurrency_lead
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_lead")]
		public TransactionCurrency transactioncurrency_lead
		{
			get
			{
				return this.GetRelatedEntity<TransactionCurrency>("transactioncurrency_lead", null);
			}
			set
			{
				this.OnPropertyChanging("transactioncurrency_lead");
				this.SetRelatedEntity<TransactionCurrency>("transactioncurrency_lead", null, value);
				this.OnPropertyChanged("transactioncurrency_lead");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_transactioncurrency_lead(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "transactioncurrency_lead");
		}

		
		/// <summary>
		/// N:N accountleads_association
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("accountleads_association")]
		public System.Collections.Generic.IEnumerable<Account> accountleads_association
		{
			get
			{
				return this.GetRelatedEntities<Account>("accountleads_association", null);
			}
			set
			{
				this.OnPropertyChanging("accountleads_association");
				this.SetRelatedEntities<Account>("accountleads_association", null, value);
				this.OnPropertyChanged("accountleads_association");
			}
		}
		/// <summary>
		/// Loads this N:N relationship into the object 
		/// </summary>
        public void Load_accountleads_association(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "accountleads_association");
		}


		
		/// <summary>
		/// N:N contactleads_association
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contactleads_association")]
		public System.Collections.Generic.IEnumerable<Contact> contactleads_association
		{
			get
			{
				return this.GetRelatedEntities<Contact>("contactleads_association", null);
			}
			set
			{
				this.OnPropertyChanging("contactleads_association");
				this.SetRelatedEntities<Contact>("contactleads_association", null, value);
				this.OnPropertyChanged("contactleads_association");
			}
		}
		/// <summary>
		/// Loads this N:N relationship into the object 
		/// </summary>
        public void Load_contactleads_association(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "contactleads_association");
		}




		public class Enums 
		{
			[DataContractAttribute]
			public enum Address1_AddressTypeCode 
			{
				[EnumMemberAttribute]
				ValorPadrao = 1,
			}		
			[DataContractAttribute]
			public enum Address1_ShippingMethodCode 
			{
				[EnumMemberAttribute]
				ValorPadrao = 1,
			}		
			[DataContractAttribute]
			public enum Address2_AddressTypeCode 
			{
				[EnumMemberAttribute]
				ValorPadrao = 1,
			}		
			[DataContractAttribute]
			public enum Address2_ShippingMethodCode 
			{
				[EnumMemberAttribute]
				ValorPadrao = 1,
			}		
			[DataContractAttribute]
			public enum BudgetStatus 
			{
				[EnumMemberAttribute]
				NenhumOrcamentoComprometido = 0,
				[EnumMemberAttribute]
				PossivelComprar = 1,
				[EnumMemberAttribute]
				PodeComprar = 2,
				[EnumMemberAttribute]
				Comprara = 3,
			}		
			[DataContractAttribute]
			public enum ConfirmInterest 
			{
				[EnumMemberAttribute]
				Nao = 1,
				[EnumMemberAttribute]
				Sim = 0,
			}		
			[DataContractAttribute]
			public enum DecisionMaker 
			{
				[EnumMemberAttribute]
				concluido = 1,
				[EnumMemberAttribute]
				marcarcomoconcluido = 0,
			}		
			[DataContractAttribute]
			public enum DoNotBulkEMail 
			{
				[EnumMemberAttribute]
				NaoPermitir = 1,
				[EnumMemberAttribute]
				Permitir = 0,
			}		
			[DataContractAttribute]
			public enum DoNotEMail 
			{
				[EnumMemberAttribute]
				NaoPermitir = 1,
				[EnumMemberAttribute]
				Permitir = 0,
			}		
			[DataContractAttribute]
			public enum DoNotFax 
			{
				[EnumMemberAttribute]
				NaoPermitir = 1,
				[EnumMemberAttribute]
				Permitir = 0,
			}		
			[DataContractAttribute]
			public enum DoNotPhone 
			{
				[EnumMemberAttribute]
				NaoPermitir = 1,
				[EnumMemberAttribute]
				Permitir = 0,
			}		
			[DataContractAttribute]
			public enum DoNotPostalMail 
			{
				[EnumMemberAttribute]
				NaoPermitir = 1,
				[EnumMemberAttribute]
				Permitir = 0,
			}		
			[DataContractAttribute]
			public enum DoNotSendMM 
			{
				[EnumMemberAttribute]
				NaoEnviar = 1,
				[EnumMemberAttribute]
				Enviar = 0,
			}		
			[DataContractAttribute]
			public enum EvaluateFit 
			{
				[EnumMemberAttribute]
				Nao = 1,
				[EnumMemberAttribute]
				Sim = 0,
			}		
			[DataContractAttribute]
			public enum FollowEmail 
			{
				[EnumMemberAttribute]
				Permitir = 1,
				[EnumMemberAttribute]
				NaoPermitir = 0,
			}		
			[DataContractAttribute]
			public enum IndustryCode 
			{
				[EnumMemberAttribute]
				Seguros = 20,
				[EnumMemberAttribute]
				ComercioAtacadista = 33,
				[EnumMemberAttribute]
				Eletroeletronico = 48,
				[EnumMemberAttribute]
				Agricultura = 49,
				[EnumMemberAttribute]
				Mineracao = 50,
				[EnumMemberAttribute]
				Educacao = 67,
				[EnumMemberAttribute]
				comerciovarejista = 72,
				[EnumMemberAttribute]
				TecnologiadaInformacao = 74,
				[EnumMemberAttribute]
				ServicosMedicos = 78,
				[EnumMemberAttribute]
				Alimentos = 79,
				[EnumMemberAttribute]
				Bancos = 81,
				[EnumMemberAttribute]
				Metalurgia = 89,
				[EnumMemberAttribute]
				IndustriaAutomobilistica = 91,
				[EnumMemberAttribute]
				TransporteseLogistica = 92,
				[EnumMemberAttribute]
				TextilCouroeVestuario = 93,
				[EnumMemberAttribute]
				Siderurgia = 94,
				[EnumMemberAttribute]
				EnergiaEletrica = 102,
				[EnumMemberAttribute]
				AguaeSaneamento = 110,
				[EnumMemberAttribute]
				BebidaseFumo = 111,
				[EnumMemberAttribute]
				ComercioExterior = 112,
				[EnumMemberAttribute]
				ConstrucaoCivil = 113,
				[EnumMemberAttribute]
				Farmaceutica = 114,
				[EnumMemberAttribute]
				Holdings = 115,
				[EnumMemberAttribute]
				MaterialdeConstrucaoeDecoracao = 116,
				[EnumMemberAttribute]
				Mecanica = 117,
				[EnumMemberAttribute]
				PapeleCelulose = 118,
				[EnumMemberAttribute]
				PlasticoseBorracha = 119,
				[EnumMemberAttribute]
				QuimicaePetroquimica = 120,
				[EnumMemberAttribute]
				ServicosEspecializados = 121,
				[EnumMemberAttribute]
				VeiculosePecas = 122,
				[EnumMemberAttribute]
				Telecomunicacoes = 135,
			}		
			[DataContractAttribute]
			public enum InitialCommunication 
			{
				[EnumMemberAttribute]
				Contatado = 0,
				[EnumMemberAttribute]
				NaoContatado = 1,
			}		
			[DataContractAttribute]
			public enum IsAutoCreate 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum IsPrivate 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum LeadQualityCode 
			{
				[EnumMemberAttribute]
				MuitoInteressado = 1,
				[EnumMemberAttribute]
				Interessado = 2,
				[EnumMemberAttribute]
				Seminteresse = 3,
			}		
			[DataContractAttribute]
			public enum LeadSourceCode 
			{
				[EnumMemberAttribute]
				Anuncio = 1,
				[EnumMemberAttribute]
				IndicacaodeFuncionario = 2,
				[EnumMemberAttribute]
				IndicacaoExterna = 3,
				[EnumMemberAttribute]
				Parceiro = 4,
				[EnumMemberAttribute]
				RelacoesPublicas = 5,
				[EnumMemberAttribute]
				Seminario = 6,
				[EnumMemberAttribute]
				FeiradeNegocios = 7,
				[EnumMemberAttribute]
				Web = 8,
				[EnumMemberAttribute]
				BocaaBoca = 9,
				[EnumMemberAttribute]
				Outro = 10,
			}		
			[DataContractAttribute]
			public enum Merged 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum msdyn_ordertype 
			{
				[EnumMemberAttribute]
				Baseadoemtrabalho = 192350001,
				[EnumMemberAttribute]
				Baseadoemitem = 192350000,
				[EnumMemberAttribute]
				BaseadoemManutencaodeServico = 690970002,
			}		
			[DataContractAttribute]
			public enum Need 
			{
				[EnumMemberAttribute]
				Eobrigatorioter = 0,
				[EnumMemberAttribute]
				Deveter = 1,
				[EnumMemberAttribute]
				Ebomter = 2,
				[EnumMemberAttribute]
				Semnecessidades = 3,
			}		
			[DataContractAttribute]
			public enum ParticipatesInWorkflow 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum PreferredContactMethodCode 
			{
				[EnumMemberAttribute]
				Qualqueruma = 1,
				[EnumMemberAttribute]
				Email = 2,
				[EnumMemberAttribute]
				Telefone = 3,
				[EnumMemberAttribute]
				Fax = 4,
				[EnumMemberAttribute]
				Correio = 5,
			}		
			[DataContractAttribute]
			public enum PriorityCode 
			{
				[EnumMemberAttribute]
				ValorPadrao = 1,
			}		
			[DataContractAttribute]
			public enum PurchaseProcess 
			{
				[EnumMemberAttribute]
				Individual = 0,
				[EnumMemberAttribute]
				Comissao = 1,
				[EnumMemberAttribute]
				Desconhecido = 2,
			}		
			[DataContractAttribute]
			public enum PurchaseTimeFrame 
			{
				[EnumMemberAttribute]
				Imediato = 0,
				[EnumMemberAttribute]
				EsteTrimestre = 1,
				[EnumMemberAttribute]
				ProximoTrimestre = 2,
				[EnumMemberAttribute]
				EsteAno = 3,
				[EnumMemberAttribute]
				Desconhecido = 4,
			}		
			[DataContractAttribute]
			public enum SalesStage 
			{
				[EnumMemberAttribute]
				Qualificar = 0,
			}		
			[DataContractAttribute]
			public enum SalesStageCode 
			{
				[EnumMemberAttribute]
				ValorPadrao = 1,
			}		
			[DataContractAttribute]
			public enum StateCode 
			{
				[EnumMemberAttribute]
				EmAberto = 0,
				[EnumMemberAttribute]
				Qualificado = 1,
				[EnumMemberAttribute]
				Desqualificado = 2,
			}		
			[DataContractAttribute]
			public enum StatusCode 
			{
				[EnumMemberAttribute]
				Novo = 1,
				[EnumMemberAttribute]
				Contatado = 2,
				[EnumMemberAttribute]
				Qualificado = 3,
				[EnumMemberAttribute]
				Perdido = 4,
				[EnumMemberAttribute]
				NaoEPossivelContatar = 5,
				[EnumMemberAttribute]
				NaoEstaMaisInteressado = 6,
				[EnumMemberAttribute]
				Cancelado = 7,
			}		
	}


		public class OneToMany
		{
			public const string lead_master_lead = "lead_master_lead";
			public const string account_originating_lead = "account_originating_lead";
			public const string contact_originating_lead = "contact_originating_lead";
			public const string opportunity_originating_lead = "opportunity_originating_lead";
			public const string lead_activity_parties = "lead_activity_parties";
}
		public class ManyToMany
		{
			public const string accountleads_association = "accountleads_association";
			public const string contactleads_association = "contactleads_association";
}

		public class Fields
		{
			public const string SchemaName = "lead";
			
			public const string AccountId = "accountid";
			public const string AccountIdName = "accountidName";
			public const string Address1_AddressId = "address1_addressid";
			public const string Address1_AddressTypeCode = "address1_addresstypecode";
			public const string Address1_City = "address1_city";
			public const string Address1_Composite = "address1_composite";
			public const string Address1_Country = "address1_country";
			public const string Address1_County = "address1_county";
			public const string Address1_Fax = "address1_fax";
			public const string Address1_Latitude = "address1_latitude";
			public const string Address1_Line1 = "address1_line1";
			public const string Address1_Line2 = "address1_line2";
			public const string Address1_Line3 = "address1_line3";
			public const string Address1_Longitude = "address1_longitude";
			public const string Address1_Name = "address1_name";
			public const string Address1_PostalCode = "address1_postalcode";
			public const string Address1_PostOfficeBox = "address1_postofficebox";
			public const string Address1_ShippingMethodCode = "address1_shippingmethodcode";
			public const string Address1_StateOrProvince = "address1_stateorprovince";
			public const string Address1_Telephone1 = "address1_telephone1";
			public const string Address1_Telephone2 = "address1_telephone2";
			public const string Address1_Telephone3 = "address1_telephone3";
			public const string Address1_UPSZone = "address1_upszone";
			public const string Address1_UTCOffset = "address1_utcoffset";
			public const string Address2_AddressId = "address2_addressid";
			public const string Address2_AddressTypeCode = "address2_addresstypecode";
			public const string Address2_City = "address2_city";
			public const string Address2_Composite = "address2_composite";
			public const string Address2_Country = "address2_country";
			public const string Address2_County = "address2_county";
			public const string Address2_Fax = "address2_fax";
			public const string Address2_Latitude = "address2_latitude";
			public const string Address2_Line1 = "address2_line1";
			public const string Address2_Line2 = "address2_line2";
			public const string Address2_Line3 = "address2_line3";
			public const string Address2_Longitude = "address2_longitude";
			public const string Address2_Name = "address2_name";
			public const string Address2_PostalCode = "address2_postalcode";
			public const string Address2_PostOfficeBox = "address2_postofficebox";
			public const string Address2_ShippingMethodCode = "address2_shippingmethodcode";
			public const string Address2_StateOrProvince = "address2_stateorprovince";
			public const string Address2_Telephone1 = "address2_telephone1";
			public const string Address2_Telephone2 = "address2_telephone2";
			public const string Address2_Telephone3 = "address2_telephone3";
			public const string Address2_UPSZone = "address2_upszone";
			public const string Address2_UTCOffset = "address2_utcoffset";
			public const string BudgetAmount = "budgetamount";
			public const string BudgetAmount_Base = "budgetamount_base";
			public const string BudgetStatus = "budgetstatus";
			public const string CampaignId = "campaignid";
			public const string CampaignIdName = "campaignidName";
			public const string CompanyName = "companyname";
			public const string ConfirmInterest = "confirminterest";
			public const string ContactId = "contactid";
			public const string ContactIdName = "contactidName";
			public const string CreatedBy = "createdby";
			public const string CreatedByName = "createdbyName";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CreatedOnBehalfByName = "createdonbehalfbyName";
			public const string CustomerId = "customerid";
			public const string CustomerIdName = "customeridName";
			public const string CustomerIdType = "customeridType";
			public const string DecisionMaker = "decisionmaker";
			public const string Description = "description";
			public const string DoNotBulkEMail = "donotbulkemail";
			public const string DoNotEMail = "donotemail";
			public const string DoNotFax = "donotfax";
			public const string DoNotPhone = "donotphone";
			public const string DoNotPostalMail = "donotpostalmail";
			public const string DoNotSendMM = "donotsendmm";
			public const string EMailAddress1 = "emailaddress1";
			public const string EMailAddress2 = "emailaddress2";
			public const string EMailAddress3 = "emailaddress3";
			public const string EntityImage = "entityimage";
			public const string EntityImage_Timestamp = "entityimage_timestamp";
			public const string EntityImage_URL = "entityimage_url";
			public const string EntityImageId = "entityimageid";
			public const string EstimatedAmount = "estimatedamount";
			public const string EstimatedAmount_Base = "estimatedamount_base";
			public const string EstimatedCloseDate = "estimatedclosedate";
			public const string EstimatedValue = "estimatedvalue";
			public const string EvaluateFit = "evaluatefit";
			public const string ExchangeRate = "exchangerate";
			public const string Fax = "fax";
			public const string FirstName = "firstname";
			public const string FollowEmail = "followemail";
			public const string FullName = "fullname";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string IndustryCode = "industrycode";
			public const string InitialCommunication = "initialcommunication";
			public const string IsAutoCreate = "isautocreate";
			public const string IsPrivate = "isprivate";
			public const string JobTitle = "jobtitle";
			public const string LastName = "lastname";
			public const string LastOnHoldTime = "lastonholdtime";
			public const string LastUsedInCampaign = "lastusedincampaign";
			public const string LeadId = "leadid";
			public const string LeadQualityCode = "leadqualitycode";
			public const string LeadSourceCode = "leadsourcecode";
			public const string MasterId = "masterid";
			public const string MasterIdName = "masteridName";
			public const string Merged = "merged";
			public const string MiddleName = "middlename";
			public const string MobilePhone = "mobilephone";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedByName = "modifiedbyName";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string ModifiedOnBehalfByName = "modifiedonbehalfbyName";
			public const string msdyn_ordertype = "msdyn_ordertype";
			public const string Need = "need";
			public const string NumberOfEmployees = "numberofemployees";
			public const string OnHoldTime = "onholdtime";
			public const string OriginatingCaseId = "originatingcaseid";
			public const string OriginatingCaseIdName = "originatingcaseidName";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningBusinessUnitName = "owningbusinessunitName";
			public const string OwningTeam = "owningteam";
			public const string OwningTeamName = "owningteamName";
			public const string OwningUser = "owninguser";
			public const string OwningUserName = "owninguserName";
			public const string Pager = "pager";
			public const string ParentAccountId = "parentaccountid";
			public const string ParentAccountIdName = "parentaccountidName";
			public const string ParentContactId = "parentcontactid";
			public const string ParentContactIdName = "parentcontactidName";
			public const string ParticipatesInWorkflow = "participatesinworkflow";
			public const string PreferredContactMethodCode = "preferredcontactmethodcode";
			public const string PriorityCode = "prioritycode";
			public const string ProcessId = "processid";
			public const string PurchaseProcess = "purchaseprocess";
			public const string PurchaseTimeFrame = "purchasetimeframe";
			public const string QualificationComments = "qualificationcomments";
			public const string QualifyingOpportunityId = "qualifyingopportunityid";
			public const string QualifyingOpportunityIdName = "qualifyingopportunityidName";
			public const string RelatedObjectId = "relatedobjectid";
			public const string RelatedObjectIdName = "relatedobjectidName";
			public const string Revenue = "revenue";
			public const string Revenue_Base = "revenue_base";
			public const string SalesStage = "salesstage";
			public const string SalesStageCode = "salesstagecode";
			public const string Salutation = "salutation";
			public const string ScheduleFollowUp_Prospect = "schedulefollowup_prospect";
			public const string ScheduleFollowUp_Qualify = "schedulefollowup_qualify";
			public const string SIC = "sic";
			public const string SLAId = "slaid";
			public const string SLAIdName = "slaidName";
			public const string SLAInvokedId = "slainvokedid";
			public const string SLAInvokedIdName = "slainvokedidName";
			public const string StageId = "stageid";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string Subject = "subject";
			public const string Telephone1 = "telephone1";
			public const string Telephone2 = "telephone2";
			public const string Telephone3 = "telephone3";
			public const string TimeSpentByMeOnEmailAndMeetings = "timespentbymeonemailandmeetings";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string TransactionCurrencyIdName = "transactioncurrencyidName";
			public const string TraversedPath = "traversedpath";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
			public const string WebSiteUrl = "websiteurl";
			public const string YomiCompanyName = "yomicompanyname";
			public const string YomiFirstName = "yomifirstname";
			public const string YomiFullName = "yomifullname";
			public const string YomiLastName = "yomilastname";
			public const string YomiMiddleName = "yomimiddlename";
		}
	}

	[System.Runtime.Serialization.DataContractAttribute()]
	public enum OpportunityState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Aberta = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Ganha = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Perdida = 2,
	}

	/// <summary>
	/// Evento gerador de receita potencial, ou venda para uma conta, que precisa ser controlado por meio de um processo de vendas para conclusão.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("opportunity")]
	public partial class Opportunity : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public Opportunity() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "opportunity";
		
		public const int EntityTypeCode = 3;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunityid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.OpportunityId = value;
			}
		}
		/// <summary>
		/// Identificador exclusivo da conta à qual a oportunidade está associada.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountid")]
		public Microsoft.Xrm.Sdk.EntityReference AccountId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("accountid");
			}
		}
	



		/// <summary>
		/// Mostra a data e a hora em que a oportunidade foi fechada ou cancelada.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualclosedate")]
		public System.Nullable<System.DateTime> ActualCloseDate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("actualclosedate");
			}
			set
			{
				this.OnPropertyChanging("ActualCloseDate");
				this.SetAttributeValue("actualclosedate", value);
				this.OnPropertyChanged("ActualCloseDate");
			}
		}
	


		/// <summary>
		/// Digite o valor real da receita da oportunidade para relatórios e análises de vendas estimadas versus reais. O campo é padronizado para o valor de Receita Estimada quando uma oportunidade é ganha.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualvalue")]
		public Microsoft.Xrm.Sdk.Money ActualValue
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("actualvalue");
			}
			set
			{
				this.OnPropertyChanging("ActualValue");
				this.SetAttributeValue("actualvalue", value);
				this.OnPropertyChanged("ActualValue");
			}
		}
	


		/// <summary>
		/// Valor do Receita Real em moeda base.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualvalue_base")]
		public Microsoft.Xrm.Sdk.Money ActualValue_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("actualvalue_base");
			}
		}
	


		/// <summary>
		/// Digite um valor entre 0 e 1.000.000.000.000 para indicar o orçamento disponível do cliente potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("budgetamount")]
		public Microsoft.Xrm.Sdk.Money BudgetAmount
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("budgetamount");
			}
			set
			{
				this.OnPropertyChanging("BudgetAmount");
				this.SetAttributeValue("budgetamount", value);
				this.OnPropertyChanged("BudgetAmount");
			}
		}
	


		/// <summary>
		/// Valor do Valor do Orçamento em moeda base.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("budgetamount_base")]
		public Microsoft.Xrm.Sdk.Money BudgetAmount_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("budgetamount_base");
			}
		}
	


		/// <summary>
		/// Escolha o status provável do orçamento da empresa do cliente potencial. Isso pode ajudar a determinar a classificação do cliente potencial ou sua abordagem de vendas.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("budgetstatus")]
		public Microsoft.Xrm.Sdk.OptionSetValue BudgetStatus
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("budgetstatus");
			}
			set
			{
				this.OnPropertyChanging("BudgetStatus");
				this.SetAttributeValue("budgetstatus", value);
				this.OnPropertyChanged("BudgetStatus");
			}
		}
	
		public virtual Enums.BudgetStatus? BudgetStatusEnum
		{
			get
			{
				return ((Enums.BudgetStatus?)(EntityOptionSetEnum.GetEnum(this, "budgetstatus")));
			}
			set
			{
				BudgetStatus = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Mostra a campanha na qual a oportunidade foi criada. A ID é usada para acompanhar o sucesso da campanha.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("campaignid")]
		public Microsoft.Xrm.Sdk.EntityReference CampaignId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("campaignid");
			}
			set
			{
				this.OnPropertyChanging("CampaignId");
				this.SetAttributeValue("campaignid", value);
				this.OnPropertyChanged("CampaignId");
			}
		}
	



		/// <summary>
		/// Escolha se os comentários da proposta foram capturados para a oportunidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("captureproposalfeedback")]
		public System.Nullable<bool> CaptureProposalFeedback
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("captureproposalfeedback");
			}
			set
			{
				this.OnPropertyChanging("CaptureProposalFeedback");
				this.SetAttributeValue("captureproposalfeedback", value);
				this.OnPropertyChanged("CaptureProposalFeedback");
			}
		}
	
		public virtual Enums.CaptureProposalFeedback? CaptureProposalFeedbackEnum
		{
			get
			{
				return ((Enums.CaptureProposalFeedback?)(EntityOptionSetEnum.GetEnum(this, "captureproposalfeedback")));
			}
			set
			{
		       if (value.HasValue)
                    CaptureProposalFeedback = ((int)value == 1);
                else                   
                    CaptureProposalFeedback = null;
			}
		}


		/// <summary>
		/// Digite um número de 0 a 100 que represente a probabilidade de fechar o oportunidade. Isso pode ajudar a equipe de vendas em seus esforços para converter a oportunidade em uma venda.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("closeprobability")]
		public System.Nullable<int> CloseProbability
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("closeprobability");
			}
			set
			{
				this.OnPropertyChanging("CloseProbability");
				this.SetAttributeValue("closeprobability", value);
				this.OnPropertyChanged("CloseProbability");
			}
		}
	


		/// <summary>
		/// Escolha se uma proposta final foi concluída para a oportunidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("completefinalproposal")]
		public System.Nullable<bool> CompleteFinalProposal
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("completefinalproposal");
			}
			set
			{
				this.OnPropertyChanging("CompleteFinalProposal");
				this.SetAttributeValue("completefinalproposal", value);
				this.OnPropertyChanged("CompleteFinalProposal");
			}
		}
	
		public virtual Enums.CompleteFinalProposal? CompleteFinalProposalEnum
		{
			get
			{
				return ((Enums.CompleteFinalProposal?)(EntityOptionSetEnum.GetEnum(this, "completefinalproposal")));
			}
			set
			{
		       if (value.HasValue)
                    CompleteFinalProposal = ((int)value == 1);
                else                   
                    CompleteFinalProposal = null;
			}
		}


		/// <summary>
		/// Escolha se uma revisão interna foi concluída para esta oportunidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("completeinternalreview")]
		public System.Nullable<bool> CompleteInternalReview
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("completeinternalreview");
			}
			set
			{
				this.OnPropertyChanging("CompleteInternalReview");
				this.SetAttributeValue("completeinternalreview", value);
				this.OnPropertyChanged("CompleteInternalReview");
			}
		}
	
		public virtual Enums.CompleteInternalReview? CompleteInternalReviewEnum
		{
			get
			{
				return ((Enums.CompleteInternalReview?)(EntityOptionSetEnum.GetEnum(this, "completeinternalreview")));
			}
			set
			{
		       if (value.HasValue)
                    CompleteInternalReview = ((int)value == 1);
                else                   
                    CompleteInternalReview = null;
			}
		}


		/// <summary>
		/// Escolha se o cliente potencial confirmou o interesse em suas ofertas. Isso ajuda a determinar a qualidade e a probabilidade do cliente potencial se tornar uma oportunidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("confirminterest")]
		public System.Nullable<bool> ConfirmInterest
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("confirminterest");
			}
			set
			{
				this.OnPropertyChanging("ConfirmInterest");
				this.SetAttributeValue("confirminterest", value);
				this.OnPropertyChanged("ConfirmInterest");
			}
		}
	
		public virtual Enums.ConfirmInterest? ConfirmInterestEnum
		{
			get
			{
				return ((Enums.ConfirmInterest?)(EntityOptionSetEnum.GetEnum(this, "confirminterest")));
			}
			set
			{
		       if (value.HasValue)
                    ConfirmInterest = ((int)value == 1);
                else                   
                    ConfirmInterest = null;
			}
		}


		/// <summary>
		/// Identificador exclusivo do contato associado à oportunidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contactid")]
		public Microsoft.Xrm.Sdk.EntityReference ContactId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("contactid");
			}
		}
	



		/// <summary>
		/// Mostra quem criou o registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
	



		/// <summary>
		/// Data e hora de criação do registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
	


		/// <summary>
		/// Mostra quem criou o registro em nome de outro usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
	



		/// <summary>
		/// Digite observações sobre a empresa ou organização associada à oportunidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currentsituation")]
		public string CurrentSituation
		{
			get
			{
				return this.GetAttributeValue<string>("currentsituation");
			}
			set
			{
				this.OnPropertyChanging("CurrentSituation");
				this.SetAttributeValue("currentsituation", value);
				this.OnPropertyChanged("CurrentSituation");
			}
		}
	


		/// <summary>
		/// Selecione a conta ou o contato do cliente para fornecer um link rápido para detalhes adicionais do cliente, como endereço, número do telefone, atividades e ordens.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
		public Microsoft.Xrm.Sdk.EntityReference CustomerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("customerid");
			}
			set
			{
				this.OnPropertyChanging("CustomerId");
				this.SetAttributeValue("customerid", value);
				this.OnPropertyChanged("CustomerId");
			}
		}
	




		/// <summary>
		/// Digite algumas observações sobre as necessidades do cliente para ajudar a equipe de vendas a identificar produtos e serviços que possam atender às suas necessidades.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerneed")]
		public string CustomerNeed
		{
			get
			{
				return this.GetAttributeValue<string>("customerneed");
			}
			set
			{
				this.OnPropertyChanging("CustomerNeed");
				this.SetAttributeValue("customerneed", value);
				this.OnPropertyChanged("CustomerNeed");
			}
		}
	


		/// <summary>
		/// Digite observações sobre os problemas encontrados do cliente para ajudar a equipe de vendas a identificar produtos e serviços que possam resolver esses problemas.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerpainpoints")]
		public string CustomerPainPoints
		{
			get
			{
				return this.GetAttributeValue<string>("customerpainpoints");
			}
			set
			{
				this.OnPropertyChanging("CustomerPainPoints");
				this.SetAttributeValue("customerpainpoints", value);
				this.OnPropertyChanged("CustomerPainPoints");
			}
		}
	


		/// <summary>
		/// Escolha se suas observações incluem informações sobre quem faz as decisões de compra na empresa do cliente potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("decisionmaker")]
		public System.Nullable<bool> DecisionMaker
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("decisionmaker");
			}
			set
			{
				this.OnPropertyChanging("DecisionMaker");
				this.SetAttributeValue("decisionmaker", value);
				this.OnPropertyChanged("DecisionMaker");
			}
		}
	
		public virtual Enums.DecisionMaker? DecisionMakerEnum
		{
			get
			{
				return ((Enums.DecisionMaker?)(EntityOptionSetEnum.GetEnum(this, "decisionmaker")));
			}
			set
			{
		       if (value.HasValue)
                    DecisionMaker = ((int)value == 1);
                else                   
                    DecisionMaker = null;
			}
		}


		/// <summary>
		/// Digite informações adicionais para descrever a oportunidade, como possíveis produtos para venda ou compras anteriores do cliente.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			set
			{
				this.OnPropertyChanging("Description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("Description");
			}
		}
	


		/// <summary>
		/// Escolha se uma proposta foi desenvolvida para a oportunidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("developproposal")]
		public System.Nullable<bool> DevelopProposal
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("developproposal");
			}
			set
			{
				this.OnPropertyChanging("DevelopProposal");
				this.SetAttributeValue("developproposal", value);
				this.OnPropertyChanged("DevelopProposal");
			}
		}
	
		public virtual Enums.DevelopProposal? DevelopProposalEnum
		{
			get
			{
				return ((Enums.DevelopProposal?)(EntityOptionSetEnum.GetEnum(this, "developproposal")));
			}
			set
			{
		       if (value.HasValue)
                    DevelopProposal = ((int)value == 1);
                else                   
                    DevelopProposal = null;
			}
		}


		/// <summary>
		/// Digite o valor do desconto da oportunidade se o cliente estiver qualificado para economias especiais.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("discountamount")]
		public Microsoft.Xrm.Sdk.Money DiscountAmount
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("discountamount");
			}
			set
			{
				this.OnPropertyChanging("DiscountAmount");
				this.SetAttributeValue("discountamount", value);
				this.OnPropertyChanged("DiscountAmount");
			}
		}
	


		/// <summary>
		/// Valor do Valor do Desconto da Oportunidade em moeda base.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("discountamount_base")]
		public Microsoft.Xrm.Sdk.Money DiscountAmount_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("discountamount_base");
			}
		}
	


		/// <summary>
		/// Digite a taxa de desconto que deve ser aplicada ao campo Total de Produtos para incluir economias adicionais para o cliente na oportunidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("discountpercentage")]
		public System.Nullable<decimal> DiscountPercentage
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("discountpercentage");
			}
			set
			{
				this.OnPropertyChanging("DiscountPercentage");
				this.SetAttributeValue("discountpercentage", value);
				this.OnPropertyChanged("DiscountPercentage");
			}
		}
	


		/// <summary>
		/// O principal endereço de email da entidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress")]
		public string EmailAddress
		{
			get
			{
				return this.GetAttributeValue<string>("emailaddress");
			}
			set
			{
				this.OnPropertyChanging("EmailAddress");
				this.SetAttributeValue("emailaddress", value);
				this.OnPropertyChanged("EmailAddress");
			}
		}
	


		/// <summary>
		/// Insira a data de fechamento esperada da oportunidade para ajudar a fazer previsões de receita precisas.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("estimatedclosedate")]
		public System.Nullable<System.DateTime> EstimatedCloseDate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("estimatedclosedate");
			}
			set
			{
				this.OnPropertyChanging("EstimatedCloseDate");
				this.SetAttributeValue("estimatedclosedate", value);
				this.OnPropertyChanged("EstimatedCloseDate");
			}
		}
	


		/// <summary>
		/// Digite o valor estimado da receita para indicar a venda potencial ou o valor da oportunidade para previsão da receita. Esse campo pode ser populado pelo sistema ou ser editado com base na seleção do campo Receita.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("estimatedvalue")]
		public Microsoft.Xrm.Sdk.Money EstimatedValue
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("estimatedvalue");
			}
			set
			{
				this.OnPropertyChanging("EstimatedValue");
				this.SetAttributeValue("estimatedvalue", value);
				this.OnPropertyChanged("EstimatedValue");
			}
		}
	


		/// <summary>
		/// Valor do Receita Estimada em moeda base.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("estimatedvalue_base")]
		public Microsoft.Xrm.Sdk.Money EstimatedValue_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("estimatedvalue_base");
			}
		}
	


		/// <summary>
		/// Escolha se o ajuste entre as necessidades do cliente potencial e suas ofertas foi avaliado.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("evaluatefit")]
		public System.Nullable<bool> EvaluateFit
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("evaluatefit");
			}
			set
			{
				this.OnPropertyChanging("EvaluateFit");
				this.SetAttributeValue("evaluatefit", value);
				this.OnPropertyChanged("EvaluateFit");
			}
		}
	
		public virtual Enums.EvaluateFit? EvaluateFitEnum
		{
			get
			{
				return ((Enums.EvaluateFit?)(EntityOptionSetEnum.GetEnum(this, "evaluatefit")));
			}
			set
			{
		       if (value.HasValue)
                    EvaluateFit = ((int)value == 1);
                else                   
                    EvaluateFit = null;
			}
		}


		/// <summary>
		/// Mostra a taxa de conversão da moeda do registro. A taxa de câmbio é usada para converter todos os campos monetários do registro da moeda local na moeda padrão do sistema.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
		public System.Nullable<decimal> ExchangeRate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
			}
		}
	


		/// <summary>
		/// Escolha se a equipe de vendas registrou observações detalhadas nas propostas e as respostas das contas.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filedebrief")]
		public System.Nullable<bool> FileDebrief
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("filedebrief");
			}
			set
			{
				this.OnPropertyChanging("FileDebrief");
				this.SetAttributeValue("filedebrief", value);
				this.OnPropertyChanged("FileDebrief");
			}
		}
	
		public virtual Enums.FileDebrief? FileDebriefEnum
		{
			get
			{
				return ((Enums.FileDebrief?)(EntityOptionSetEnum.GetEnum(this, "filedebrief")));
			}
			set
			{
		       if (value.HasValue)
                    FileDebrief = ((int)value == 1);
                else                   
                    FileDebrief = null;
			}
		}


		/// <summary>
		/// Insira a data e a hora em que a decisão final da oportunidade foi tomada.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("finaldecisiondate")]
		public System.Nullable<System.DateTime> FinalDecisionDate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("finaldecisiondate");
			}
			set
			{
				this.OnPropertyChanging("FinalDecisionDate");
				this.SetAttributeValue("finaldecisiondate", value);
				this.OnPropertyChanged("FinalDecisionDate");
			}
		}
	


		/// <summary>
		/// Digite o custo do frete ou da remessa dos produtos incluídos na oportunidade para uso no cálculo do campo Valor Total.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("freightamount")]
		public Microsoft.Xrm.Sdk.Money FreightAmount
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("freightamount");
			}
			set
			{
				this.OnPropertyChanging("FreightAmount");
				this.SetAttributeValue("freightamount", value);
				this.OnPropertyChanged("FreightAmount");
			}
		}
	


		/// <summary>
		/// Valor do Valor do Frete em moeda base.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("freightamount_base")]
		public Microsoft.Xrm.Sdk.Money FreightAmount_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("freightamount_base");
			}
		}
	


		/// <summary>
		/// Escolha se as informações sobre os concorrentes estão incluídas.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("identifycompetitors")]
		public System.Nullable<bool> IdentifyCompetitors
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("identifycompetitors");
			}
			set
			{
				this.OnPropertyChanging("IdentifyCompetitors");
				this.SetAttributeValue("identifycompetitors", value);
				this.OnPropertyChanged("IdentifyCompetitors");
			}
		}
	
		public virtual Enums.IdentifyCompetitors? IdentifyCompetitorsEnum
		{
			get
			{
				return ((Enums.IdentifyCompetitors?)(EntityOptionSetEnum.GetEnum(this, "identifycompetitors")));
			}
			set
			{
		       if (value.HasValue)
                    IdentifyCompetitors = ((int)value == 1);
                else                   
                    IdentifyCompetitors = null;
			}
		}


		/// <summary>
		/// Escolha se os contatos do cliente para esta oportunidade foram identificados.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("identifycustomercontacts")]
		public System.Nullable<bool> IdentifyCustomerContacts
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("identifycustomercontacts");
			}
			set
			{
				this.OnPropertyChanging("IdentifyCustomerContacts");
				this.SetAttributeValue("identifycustomercontacts", value);
				this.OnPropertyChanged("IdentifyCustomerContacts");
			}
		}
	
		public virtual Enums.IdentifyCustomerContacts? IdentifyCustomerContactsEnum
		{
			get
			{
				return ((Enums.IdentifyCustomerContacts?)(EntityOptionSetEnum.GetEnum(this, "identifycustomercontacts")));
			}
			set
			{
		       if (value.HasValue)
                    IdentifyCustomerContacts = ((int)value == 1);
                else                   
                    IdentifyCustomerContacts = null;
			}
		}


		/// <summary>
		/// Escolha se você registrou quem perseguirá a oportunidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("identifypursuitteam")]
		public System.Nullable<bool> IdentifyPursuitTeam
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("identifypursuitteam");
			}
			set
			{
				this.OnPropertyChanging("IdentifyPursuitTeam");
				this.SetAttributeValue("identifypursuitteam", value);
				this.OnPropertyChanged("IdentifyPursuitTeam");
			}
		}
	
		public virtual Enums.IdentifyPursuitTeam? IdentifyPursuitTeamEnum
		{
			get
			{
				return ((Enums.IdentifyPursuitTeam?)(EntityOptionSetEnum.GetEnum(this, "identifypursuitteam")));
			}
			set
			{
		       if (value.HasValue)
                    IdentifyPursuitTeam = ((int)value == 1);
                else                   
                    IdentifyPursuitTeam = null;
			}
		}


		/// <summary>
		/// Número de sequência da importação que criou este registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
	


		/// <summary>
		/// Escolha se alguém da equipe de vendas entrou em contato com este cliente potencial anteriormente.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("initialcommunication")]
		public Microsoft.Xrm.Sdk.OptionSetValue InitialCommunication
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("initialcommunication");
			}
			set
			{
				this.OnPropertyChanging("InitialCommunication");
				this.SetAttributeValue("initialcommunication", value);
				this.OnPropertyChanged("InitialCommunication");
			}
		}
	
		public virtual Enums.InitialCommunication? InitialCommunicationEnum
		{
			get
			{
				return ((Enums.InitialCommunication?)(EntityOptionSetEnum.GetEnum(this, "initialcommunication")));
			}
			set
			{
				InitialCommunication = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Indica se a oportunidade é particular ou se está visível para toda a organização.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isprivate")]
		public System.Nullable<bool> IsPrivate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isprivate");
			}
		}
	
		public virtual Enums.IsPrivate? IsPrivateEnum
		{
			get
			{
				return ((Enums.IsPrivate?)(EntityOptionSetEnum.GetEnum(this, "isprivate")));
			}
		}


		/// <summary>
		/// Escolha se a receita estimada da oportunidade é calculada automaticamente com base nos produtos inseridos ou inseridos manualmente por um usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isrevenuesystemcalculated")]
		public System.Nullable<bool> IsRevenueSystemCalculated
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isrevenuesystemcalculated");
			}
			set
			{
				this.OnPropertyChanging("IsRevenueSystemCalculated");
				this.SetAttributeValue("isrevenuesystemcalculated", value);
				this.OnPropertyChanged("IsRevenueSystemCalculated");
			}
		}
	
		public virtual Enums.IsRevenueSystemCalculated? IsRevenueSystemCalculatedEnum
		{
			get
			{
				return ((Enums.IsRevenueSystemCalculated?)(EntityOptionSetEnum.GetEnum(this, "isrevenuesystemcalculated")));
			}
			set
			{
		       if (value.HasValue)
                    IsRevenueSystemCalculated = ((int)value == 1);
                else                   
                    IsRevenueSystemCalculated = null;
			}
		}


		/// <summary>
		/// Contém o carimbo de data e hora da última suspensão.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastonholdtime")]
		public System.Nullable<System.DateTime> LastOnHoldTime
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastonholdtime");
			}
			set
			{
				this.OnPropertyChanging("LastOnHoldTime");
				this.SetAttributeValue("lastonholdtime", value);
				this.OnPropertyChanged("LastOnHoldTime");
			}
		}
	


		/// <summary>
		/// Mostra quem atualizou o registro pela última vez.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
	



		/// <summary>
		/// Data e hora de modificação do registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
	


		/// <summary>
		/// Mostra quem atualizou o registro pela última vez em nome de outro usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
	



		/// <summary>
		/// O gerente de conta responsável pela oportunidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_accountmanagerid")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_AccountManagerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_accountmanagerid");
			}
			set
			{
				this.OnPropertyChanging("msdyn_AccountManagerId");
				this.SetAttributeValue("msdyn_accountmanagerid", value);
				this.OnPropertyChanged("msdyn_AccountManagerId");
			}
		}
	



		/// <summary>
		/// A unidade organizacional responsável pela oportunidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_contractorganizationalunitid")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_ContractOrganizationalUnitId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_contractorganizationalunitid");
			}
			set
			{
				this.OnPropertyChanging("msdyn_ContractOrganizationalUnitId");
				this.SetAttributeValue("msdyn_contractorganizationalunitid", value);
				this.OnPropertyChanged("msdyn_ContractOrganizationalUnitId");
			}
		}
	



		/// <summary>
		/// Somente para uso interno.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_ordertype")]
		public Microsoft.Xrm.Sdk.OptionSetValue msdyn_OrderType
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("msdyn_ordertype");
			}
			set
			{
				this.OnPropertyChanging("msdyn_OrderType");
				this.SetAttributeValue("msdyn_ordertype", value);
				this.OnPropertyChanged("msdyn_OrderType");
			}
		}
	
		public virtual Enums.msdyn_OrderType? msdyn_OrderTypeEnum
		{
			get
			{
				return ((Enums.msdyn_OrderType?)(EntityOptionSetEnum.GetEnum(this, "msdyn_ordertype")));
			}
			set
			{
				msdyn_OrderType = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Identificador exclusivo do Tipo de Ordem de Serviço associado à Oportunidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_workordertype")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_WorkOrderType
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_workordertype");
			}
			set
			{
				this.OnPropertyChanging("msdyn_WorkOrderType");
				this.SetAttributeValue("msdyn_workordertype", value);
				this.OnPropertyChanged("msdyn_WorkOrderType");
			}
		}
	



		/// <summary>
		/// Digite o assunto ou o nome descritivo, como a ordem esperada ou o nome da empresa, da oportunidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			set
			{
				this.OnPropertyChanging("Name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("Name");
			}
		}
	


		/// <summary>
		/// Escolha o grau de necessidade da empresa do cliente potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("need")]
		public Microsoft.Xrm.Sdk.OptionSetValue Need
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("need");
			}
			set
			{
				this.OnPropertyChanging("Need");
				this.SetAttributeValue("need", value);
				this.OnPropertyChanged("Need");
			}
		}
	
		public virtual Enums.Need? NeedEnum
		{
			get
			{
				return ((Enums.Need?)(EntityOptionSetEnum.GetEnum(this, "need")));
			}
			set
			{
				Need = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Mostra a duração, em minutos, em que a oportunidade ficou suspensa.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("onholdtime")]
		public System.Nullable<int> OnHoldTime
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("onholdtime");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo da oportunidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunityid")]
		public System.Nullable<System.Guid> OpportunityId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("opportunityid");
			}
			set
			{
				this.OnPropertyChanging("OpportunityId");
				this.SetAttributeValue("opportunityid", value);
						if (value.HasValue)
						{
							base.Id = value.Value;
						}
						else
						{
							base.Id = System.Guid.Empty;
						}
				this.OnPropertyChanged("OpportunityId");
			}
		}
	


		/// <summary>
		/// Escolha o valor esperado ou a prioridade da oportunidade com base na receita, no status do cliente ou na probabilidade de fechamento.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunityratingcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue OpportunityRatingCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("opportunityratingcode");
			}
			set
			{
				this.OnPropertyChanging("OpportunityRatingCode");
				this.SetAttributeValue("opportunityratingcode", value);
				this.OnPropertyChanged("OpportunityRatingCode");
			}
		}
	
		public virtual Enums.OpportunityRatingCode? OpportunityRatingCodeEnum
		{
			get
			{
				return ((Enums.OpportunityRatingCode?)(EntityOptionSetEnum.GetEnum(this, "opportunityratingcode")));
			}
			set
			{
				OpportunityRatingCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Escolha o cliente potencial do qual a oportunidade foi criada para relatórios e análises. O campo é somente leitura depois que a oportunidade é criada e é padronizado para o cliente potencial correto quando uma oportunidade é criada a partir de um cliente potencial convertido.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("originatingleadid")]
		public Microsoft.Xrm.Sdk.EntityReference OriginatingLeadId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("originatingleadid");
			}
			set
			{
				this.OnPropertyChanging("OriginatingLeadId");
				this.SetAttributeValue("originatingleadid", value);
				this.OnPropertyChanged("OriginatingLeadId");
			}
		}
	



		/// <summary>
		/// Data e hora da migração do registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
	


		/// <summary>
		/// ID do Proprietário
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			set
			{
				this.OnPropertyChanging("OwnerId");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo da unidade de negócios proprietária do registro
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
		}
	



		/// <summary>
		/// Identificador exclusivo da equipe que possui o registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
		}
	



		/// <summary>
		/// Identificador exclusivo do usuário proprietário do registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
		}
	



		/// <summary>
		/// Escolha uma conta à qual conectar esta oportunidade, para que o relacionamento seja visível em relatórios e análises e para fornecer um link rápido para detalhes adicionais, como informações financeiras e atividades.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentaccountid")]
		public Microsoft.Xrm.Sdk.EntityReference ParentAccountId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentaccountid");
			}
			set
			{
				this.OnPropertyChanging("ParentAccountId");
				this.SetAttributeValue("parentaccountid", value);
				this.OnPropertyChanged("ParentAccountId");
			}
		}
	



		/// <summary>
		/// Escolha um contato ao qual conectar esta oportunidade, para que o relacionamento seja visível em relatórios e análises.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcontactid")]
		public Microsoft.Xrm.Sdk.EntityReference ParentContactId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentcontactid");
			}
			set
			{
				this.OnPropertyChanging("ParentContactId");
				this.SetAttributeValue("parentcontactid", value);
				this.OnPropertyChanged("ParentContactId");
			}
		}
	



		/// <summary>
		/// Informação que especifica se a oportunidade faz parte de regras de fluxo de trabalho.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("participatesinworkflow")]
		public System.Nullable<bool> ParticipatesInWorkflow
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("participatesinworkflow");
			}
			set
			{
				this.OnPropertyChanging("ParticipatesInWorkflow");
				this.SetAttributeValue("participatesinworkflow", value);
				this.OnPropertyChanged("ParticipatesInWorkflow");
			}
		}
	
		public virtual Enums.ParticipatesInWorkflow? ParticipatesInWorkflowEnum
		{
			get
			{
				return ((Enums.ParticipatesInWorkflow?)(EntityOptionSetEnum.GetEnum(this, "participatesinworkflow")));
			}
			set
			{
		       if (value.HasValue)
                    ParticipatesInWorkflow = ((int)value == 1);
                else                   
                    ParticipatesInWorkflow = null;
			}
		}


		/// <summary>
		/// Escolha se a proposta final foi apresentada à conta.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("presentfinalproposal")]
		public System.Nullable<bool> PresentFinalProposal
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("presentfinalproposal");
			}
			set
			{
				this.OnPropertyChanging("PresentFinalProposal");
				this.SetAttributeValue("presentfinalproposal", value);
				this.OnPropertyChanged("PresentFinalProposal");
			}
		}
	
		public virtual Enums.PresentFinalProposal? PresentFinalProposalEnum
		{
			get
			{
				return ((Enums.PresentFinalProposal?)(EntityOptionSetEnum.GetEnum(this, "presentfinalproposal")));
			}
			set
			{
		       if (value.HasValue)
                    PresentFinalProposal = ((int)value == 1);
                else                   
                    PresentFinalProposal = null;
			}
		}


		/// <summary>
		/// Escolha se uma proposta da oportunidade foi apresentada à conta.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("presentproposal")]
		public System.Nullable<bool> PresentProposal
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("presentproposal");
			}
			set
			{
				this.OnPropertyChanging("PresentProposal");
				this.SetAttributeValue("presentproposal", value);
				this.OnPropertyChanged("PresentProposal");
			}
		}
	
		public virtual Enums.PresentProposal? PresentProposalEnum
		{
			get
			{
				return ((Enums.PresentProposal?)(EntityOptionSetEnum.GetEnum(this, "presentproposal")));
			}
			set
			{
		       if (value.HasValue)
                    PresentProposal = ((int)value == 1);
                else                   
                    PresentProposal = null;
			}
		}


		/// <summary>
		/// Escolha a lista de preços associada a este registro para garantir que os produtos associados à campanha sejam oferecidos nos preços corretos.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricelevelid")]
		public Microsoft.Xrm.Sdk.EntityReference PriceLevelId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("pricelevelid");
			}
			set
			{
				this.OnPropertyChanging("PriceLevelId");
				this.SetAttributeValue("pricelevelid", value);
				this.OnPropertyChanged("PriceLevelId");
			}
		}
	



		/// <summary>
		/// Erro de precificação da oportunidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricingerrorcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PricingErrorCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("pricingerrorcode");
			}
			set
			{
				this.OnPropertyChanging("PricingErrorCode");
				this.SetAttributeValue("pricingerrorcode", value);
				this.OnPropertyChanged("PricingErrorCode");
			}
		}
	
		public virtual Enums.PricingErrorCode? PricingErrorCodeEnum
		{
			get
			{
				return ((Enums.PricingErrorCode?)(EntityOptionSetEnum.GetEnum(this, "pricingerrorcode")));
			}
			set
			{
				PricingErrorCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Escolha a prioridade de forma que os clientes preferenciais ou os problemas críticos sejam tratados rapidamente.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("prioritycode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PriorityCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("prioritycode");
			}
			set
			{
				this.OnPropertyChanging("PriorityCode");
				this.SetAttributeValue("prioritycode", value);
				this.OnPropertyChanged("PriorityCode");
			}
		}
	
		public virtual Enums.PriorityCode? PriorityCodeEnum
		{
			get
			{
				return ((Enums.PriorityCode?)(EntityOptionSetEnum.GetEnum(this, "prioritycode")));
			}
			set
			{
				PriorityCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Contém a id do processo associado à entidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
		public System.Nullable<System.Guid> ProcessId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("processid");
			}
			set
			{
				this.OnPropertyChanging("ProcessId");
				this.SetAttributeValue("processid", value);
				this.OnPropertyChanged("ProcessId");
			}
		}
	


		/// <summary>
		/// Digite observações sobre a solução proposta para a oportunidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("proposedsolution")]
		public string ProposedSolution
		{
			get
			{
				return this.GetAttributeValue<string>("proposedsolution");
			}
			set
			{
				this.OnPropertyChanging("ProposedSolution");
				this.SetAttributeValue("proposedsolution", value);
				this.OnPropertyChanged("ProposedSolution");
			}
		}
	


		/// <summary>
		/// Escolha se um indivíduo ou comitê será envolvido no processo de compra do cliente potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("purchaseprocess")]
		public Microsoft.Xrm.Sdk.OptionSetValue PurchaseProcess
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("purchaseprocess");
			}
			set
			{
				this.OnPropertyChanging("PurchaseProcess");
				this.SetAttributeValue("purchaseprocess", value);
				this.OnPropertyChanged("PurchaseProcess");
			}
		}
	
		public virtual Enums.PurchaseProcess? PurchaseProcessEnum
		{
			get
			{
				return ((Enums.PurchaseProcess?)(EntityOptionSetEnum.GetEnum(this, "purchaseprocess")));
			}
			set
			{
				PurchaseProcess = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Escolha a quantidade de tempo provável que o cliente potencial levará para fazer a compra.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("purchasetimeframe")]
		public Microsoft.Xrm.Sdk.OptionSetValue PurchaseTimeframe
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("purchasetimeframe");
			}
			set
			{
				this.OnPropertyChanging("PurchaseTimeframe");
				this.SetAttributeValue("purchasetimeframe", value);
				this.OnPropertyChanged("PurchaseTimeframe");
			}
		}
	
		public virtual Enums.PurchaseTimeframe? PurchaseTimeframeEnum
		{
			get
			{
				return ((Enums.PurchaseTimeframe?)(EntityOptionSetEnum.GetEnum(this, "purchasetimeframe")));
			}
			set
			{
				PurchaseTimeframe = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Escolha se a decisão de perseguir a oportunidade foi feita.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pursuitdecision")]
		public System.Nullable<bool> PursuitDecision
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("pursuitdecision");
			}
			set
			{
				this.OnPropertyChanging("PursuitDecision");
				this.SetAttributeValue("pursuitdecision", value);
				this.OnPropertyChanged("PursuitDecision");
			}
		}
	
		public virtual Enums.PursuitDecision? PursuitDecisionEnum
		{
			get
			{
				return ((Enums.PursuitDecision?)(EntityOptionSetEnum.GetEnum(this, "pursuitdecision")));
			}
			set
			{
		       if (value.HasValue)
                    PursuitDecision = ((int)value == 1);
                else                   
                    PursuitDecision = null;
			}
		}


		/// <summary>
		/// Digite comentários sobre a qualificação ou a pontuação do cliente potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("qualificationcomments")]
		public string QualificationComments
		{
			get
			{
				return this.GetAttributeValue<string>("qualificationcomments");
			}
			set
			{
				this.OnPropertyChanging("QualificationComments");
				this.SetAttributeValue("qualificationcomments", value);
				this.OnPropertyChanged("QualificationComments");
			}
		}
	


		/// <summary>
		/// Digite comentários sobre as cotações associadas à oportunidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quotecomments")]
		public string QuoteComments
		{
			get
			{
				return this.GetAttributeValue<string>("quotecomments");
			}
			set
			{
				this.OnPropertyChanging("QuoteComments");
				this.SetAttributeValue("quotecomments", value);
				this.OnPropertyChanged("QuoteComments");
			}
		}
	


		/// <summary>
		/// Escolha se os comentários da proposta foram capturados e resolvidos para a oportunidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resolvefeedback")]
		public System.Nullable<bool> ResolveFeedback
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("resolvefeedback");
			}
			set
			{
				this.OnPropertyChanging("ResolveFeedback");
				this.SetAttributeValue("resolvefeedback", value);
				this.OnPropertyChanged("ResolveFeedback");
			}
		}
	
		public virtual Enums.ResolveFeedback? ResolveFeedbackEnum
		{
			get
			{
				return ((Enums.ResolveFeedback?)(EntityOptionSetEnum.GetEnum(this, "resolvefeedback")));
			}
			set
			{
		       if (value.HasValue)
                    ResolveFeedback = ((int)value == 1);
                else                   
                    ResolveFeedback = null;
			}
		}


		/// <summary>
		/// Escolha o estágio de vendas desta oportunidade para ajudar a equipe de vendas em seus esforços de ganhar essa oportunidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesstage")]
		public Microsoft.Xrm.Sdk.OptionSetValue SalesStage
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("salesstage");
			}
			set
			{
				this.OnPropertyChanging("SalesStage");
				this.SetAttributeValue("salesstage", value);
				this.OnPropertyChanged("SalesStage");
			}
		}
	
		public virtual Enums.SalesStage? SalesStageEnum
		{
			get
			{
				return ((Enums.SalesStage?)(EntityOptionSetEnum.GetEnum(this, "salesstage")));
			}
			set
			{
				SalesStage = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Escolha o estágio do processo de vendas da oportunidade para indicar a probabilidade de fechamento da oportunidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesstagecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue SalesStageCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("salesstagecode");
			}
			set
			{
				this.OnPropertyChanging("SalesStageCode");
				this.SetAttributeValue("salesstagecode", value);
				this.OnPropertyChanged("SalesStageCode");
			}
		}
	
		public virtual Enums.SalesStageCode? SalesStageCodeEnum
		{
			get
			{
				return ((Enums.SalesStageCode?)(EntityOptionSetEnum.GetEnum(this, "salesstagecode")));
			}
			set
			{
				SalesStageCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Digite a data e a hora da reunião de acompanhamento de prospecção com o cliente potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("schedulefollowup_prospect")]
		public System.Nullable<System.DateTime> ScheduleFollowup_Prospect
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("schedulefollowup_prospect");
			}
			set
			{
				this.OnPropertyChanging("ScheduleFollowup_Prospect");
				this.SetAttributeValue("schedulefollowup_prospect", value);
				this.OnPropertyChanged("ScheduleFollowup_Prospect");
			}
		}
	


		/// <summary>
		/// Digite a data e a hora da reunião de acompanhamento de qualificação com o cliente potencial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("schedulefollowup_qualify")]
		public System.Nullable<System.DateTime> ScheduleFollowup_Qualify
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("schedulefollowup_qualify");
			}
			set
			{
				this.OnPropertyChanging("ScheduleFollowup_Qualify");
				this.SetAttributeValue("schedulefollowup_qualify", value);
				this.OnPropertyChanged("ScheduleFollowup_Qualify");
			}
		}
	


		/// <summary>
		/// Digite a data e a hora da reunião da proposta da oportunidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduleproposalmeeting")]
		public System.Nullable<System.DateTime> ScheduleProposalMeeting
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduleproposalmeeting");
			}
			set
			{
				this.OnPropertyChanging("ScheduleProposalMeeting");
				this.SetAttributeValue("scheduleproposalmeeting", value);
				this.OnPropertyChanged("ScheduleProposalMeeting");
			}
		}
	


		/// <summary>
		/// Escolha se uma nota de agradecimento foi enviada à conta por considerar a proposta.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sendthankyounote")]
		public System.Nullable<bool> SendThankYouNote
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("sendthankyounote");
			}
			set
			{
				this.OnPropertyChanging("SendThankYouNote");
				this.SetAttributeValue("sendthankyounote", value);
				this.OnPropertyChanged("SendThankYouNote");
			}
		}
	
		public virtual Enums.SendThankYouNote? SendThankYouNoteEnum
		{
			get
			{
				return ((Enums.SendThankYouNote?)(EntityOptionSetEnum.GetEnum(this, "sendthankyounote")));
			}
			set
			{
		       if (value.HasValue)
                    SendThankYouNote = ((int)value == 1);
                else                   
                    SendThankYouNote = null;
			}
		}


		/// <summary>
		/// Escolha o contrato de nível de serviço (SLA) que você deseja aplicar ao registro de oportunidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slaid")]
		public Microsoft.Xrm.Sdk.EntityReference SLAId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("slaid");
			}
			set
			{
				this.OnPropertyChanging("SLAId");
				this.SetAttributeValue("slaid", value);
				this.OnPropertyChanged("SLAId");
			}
		}
	



		/// <summary>
		/// O último SLA aplicado a esta oportunidade. Este campo é somente para uso interno.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slainvokedid")]
		public Microsoft.Xrm.Sdk.EntityReference SLAInvokedId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("slainvokedid");
			}
		}
	



		/// <summary>
		/// Contém a id do estágio onde a entidade está localizada.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
		public System.Nullable<System.Guid> StageId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("stageid");
			}
			set
			{
				this.OnPropertyChanging("StageId");
				this.SetAttributeValue("stageid", value);
				this.OnPropertyChanged("StageId");
			}
		}
	


		/// <summary>
		/// Status da oportunidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<OpportunityState> StateCode
		{
				get
				{
					Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
					if ((optionSet != null))
					{
						return ((OpportunityState)(System.Enum.ToObject(typeof(OpportunityState), optionSet.Value)));
					}
					else
					{
						return null;
					}
				}
					set
					{
						this.OnPropertyChanging("StateCode");
						if ((value == null))
						{
							this.SetAttributeValue("statecode", null);
						}
						else
						{
							this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
						}
						this.OnPropertyChanged("StateCode");
					}
		}
	


		/// <summary>
		/// Razão para o status da oportunidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			set
			{
				this.OnPropertyChanging("StatusCode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("StatusCode");
			}
		}
	


		/// <summary>
		/// Mostra a ID da etapa do fluxo de trabalho.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stepid")]
		public System.Nullable<System.Guid> StepId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("stepid");
			}
			set
			{
				this.OnPropertyChanging("StepId");
				this.SetAttributeValue("stepid", value);
				this.OnPropertyChanged("StepId");
			}
		}
	


		/// <summary>
		/// Mostra a fase atual no pipeline de vendas para a oportunidade. Ela é atualizada por um fluxo de trabalho.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stepname")]
		public string StepName
		{
			get
			{
				return this.GetAttributeValue<string>("stepname");
			}
			set
			{
				this.OnPropertyChanging("StepName");
				this.SetAttributeValue("stepname", value);
				this.OnPropertyChanged("StepName");
			}
		}
	


		/// <summary>
		/// Escolha quando é provável que a oportunidade seja fechada.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timeline")]
		public Microsoft.Xrm.Sdk.OptionSetValue TimeLine
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("timeline");
			}
			set
			{
				this.OnPropertyChanging("TimeLine");
				this.SetAttributeValue("timeline", value);
				this.OnPropertyChanged("TimeLine");
			}
		}
	
		public virtual Enums.TimeLine? TimeLineEnum
		{
			get
			{
				return ((Enums.TimeLine?)(EntityOptionSetEnum.GetEnum(this, "timeline")));
			}
			set
			{
				TimeLine = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Tempo total gasto por mim com emails (leitura e redação) e reuniões em relação ao registro da oportunidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timespentbymeonemailandmeetings")]
		public string TimeSpentByMeOnEmailAndMeetings
		{
			get
			{
				return this.GetAttributeValue<string>("timespentbymeonemailandmeetings");
			}
		}
	


		/// <summary>
		/// Apenas para uso interno.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
	


		/// <summary>
		/// Mostra o valor total devido, calculado como a soma dos produtos, descontos, frete e impostos da oportunidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totalamount")]
		public Microsoft.Xrm.Sdk.Money TotalAmount
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totalamount");
			}
			set
			{
				this.OnPropertyChanging("TotalAmount");
				this.SetAttributeValue("totalamount", value);
				this.OnPropertyChanged("TotalAmount");
			}
		}
	


		/// <summary>
		/// Valor do Valor Total em moeda base.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totalamount_base")]
		public Microsoft.Xrm.Sdk.Money TotalAmount_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totalamount_base");
			}
		}
	


		/// <summary>
		/// Mostra o valor total do produto da oportunidade, menos qualquer desconto. Esse valor é adicionado aos valores de frete e de imposto no cálculo do valor total da oportunidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totalamountlessfreight")]
		public Microsoft.Xrm.Sdk.Money TotalAmountLessFreight
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totalamountlessfreight");
			}
			set
			{
				this.OnPropertyChanging("TotalAmountLessFreight");
				this.SetAttributeValue("totalamountlessfreight", value);
				this.OnPropertyChanged("TotalAmountLessFreight");
			}
		}
	


		/// <summary>
		/// Valor do Valor Total sem Frete em moeda base.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totalamountlessfreight_base")]
		public Microsoft.Xrm.Sdk.Money TotalAmountLessFreight_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totalamountlessfreight_base");
			}
		}
	


		/// <summary>
		/// Mostra o valor total do desconto, com base no preço com desconto e na taxa inserida na oportunidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totaldiscountamount")]
		public Microsoft.Xrm.Sdk.Money TotalDiscountAmount
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totaldiscountamount");
			}
			set
			{
				this.OnPropertyChanging("TotalDiscountAmount");
				this.SetAttributeValue("totaldiscountamount", value);
				this.OnPropertyChanged("TotalDiscountAmount");
			}
		}
	


		/// <summary>
		/// Valor do Valor Total do Desconto em moeda base.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totaldiscountamount_base")]
		public Microsoft.Xrm.Sdk.Money TotalDiscountAmount_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totaldiscountamount_base");
			}
		}
	


		/// <summary>
		/// Mostra a soma de todos os produtos existentes e fora do catálogo incluídos na oportunidade, com base na lista de preços e nas quantidades especificadas.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totallineitemamount")]
		public Microsoft.Xrm.Sdk.Money TotalLineItemAmount
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totallineitemamount");
			}
			set
			{
				this.OnPropertyChanging("TotalLineItemAmount");
				this.SetAttributeValue("totallineitemamount", value);
				this.OnPropertyChanged("TotalLineItemAmount");
			}
		}
	


		/// <summary>
		/// Valor do Valor Total Detalhado em moeda base.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totallineitemamount_base")]
		public Microsoft.Xrm.Sdk.Money TotalLineItemAmount_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totallineitemamount_base");
			}
		}
	


		/// <summary>
		/// Mostra o total dos valores de Desconto Manual especificados em todos os produtos incluídos na oportunidade. Esse valor é refletido no campo Valor Total Detalhado na oportunidade e é adicionado a qualquer valor de desconto ou imposto especificado na oportunidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totallineitemdiscountamount")]
		public Microsoft.Xrm.Sdk.Money TotalLineItemDiscountAmount
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totallineitemdiscountamount");
			}
			set
			{
				this.OnPropertyChanging("TotalLineItemDiscountAmount");
				this.SetAttributeValue("totallineitemdiscountamount", value);
				this.OnPropertyChanged("TotalLineItemDiscountAmount");
			}
		}
	


		/// <summary>
		/// Valor do Valor Total do Desconto do Item de Linha em moeda base.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totallineitemdiscountamount_base")]
		public Microsoft.Xrm.Sdk.Money TotalLineItemDiscountAmount_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totallineitemdiscountamount_base");
			}
		}
	


		/// <summary>
		/// Mostra o total dos valores de Imposto especificados em todos os produtos incluídos na oportunidade, incluídos no cálculo do campo Valor Total da oportunidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totaltax")]
		public Microsoft.Xrm.Sdk.Money TotalTax
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totaltax");
			}
			set
			{
				this.OnPropertyChanging("TotalTax");
				this.SetAttributeValue("totaltax", value);
				this.OnPropertyChanged("TotalTax");
			}
		}
	


		/// <summary>
		/// Valor do Total de Impostos em moeda base.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totaltax_base")]
		public Microsoft.Xrm.Sdk.Money TotalTax_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totaltax_base");
			}
		}
	


		/// <summary>
		/// Escolha a moeda local do registro para garantir que os orçamentos sejam relatados na moeda correta.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
			}
			set
			{
				this.OnPropertyChanging("TransactionCurrencyId");
				this.SetAttributeValue("transactioncurrencyid", value);
				this.OnPropertyChanged("TransactionCurrencyId");
			}
		}
	



		/// <summary>
		/// Uma lista separada por vírgula de valores de cadeia de caracteres representando os identificadores exclusivos dos estágios de uma instância do fluxo do processo empresarial na ordem em que ocorrem.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traversedpath")]
		public string TraversedPath
		{
			get
			{
				return this.GetAttributeValue<string>("traversedpath");
			}
			set
			{
				this.OnPropertyChanging("TraversedPath");
				this.SetAttributeValue("traversedpath", value);
				this.OnPropertyChanged("TraversedPath");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_aditivo_taxa_administracao")]
		public string urb_aditivo_taxa_administracao
		{
			get
			{
				return this.GetAttributeValue<string>("urb_aditivo_taxa_administracao");
			}
			set
			{
				this.OnPropertyChanging("urb_aditivo_taxa_administracao");
				this.SetAttributeValue("urb_aditivo_taxa_administracao", value);
				this.OnPropertyChanged("urb_aditivo_taxa_administracao");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_codigo_deposito_identificado")]
		public string urb_codigo_deposito_identificado
		{
			get
			{
				return this.GetAttributeValue<string>("urb_codigo_deposito_identificado");
			}
			set
			{
				this.OnPropertyChanging("urb_codigo_deposito_identificado");
				this.SetAttributeValue("urb_codigo_deposito_identificado", value);
				this.OnPropertyChanged("urb_codigo_deposito_identificado");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_codigo_pagador")]
		public string urb_codigo_pagador
		{
			get
			{
				return this.GetAttributeValue<string>("urb_codigo_pagador");
			}
			set
			{
				this.OnPropertyChanging("urb_codigo_pagador");
				this.SetAttributeValue("urb_codigo_pagador", value);
				this.OnPropertyChanged("urb_codigo_pagador");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_codigo_seguro_mip")]
		public string urb_codigo_seguro_mip
		{
			get
			{
				return this.GetAttributeValue<string>("urb_codigo_seguro_mip");
			}
			set
			{
				this.OnPropertyChanging("urb_codigo_seguro_mip");
				this.SetAttributeValue("urb_codigo_seguro_mip", value);
				this.OnPropertyChanged("urb_codigo_seguro_mip");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_contrato_sap")]
		public string urb_contrato_sap
		{
			get
			{
				return this.GetAttributeValue<string>("urb_contrato_sap");
			}
			set
			{
				this.OnPropertyChanging("urb_contrato_sap");
				this.SetAttributeValue("urb_contrato_sap", value);
				this.OnPropertyChanged("urb_contrato_sap");
			}
		}
	


		/// <summary>
		/// Identificador único para Corretor associado a Oportunidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_corretor_oportunidadeid")]
		public Microsoft.Xrm.Sdk.EntityReference urb_corretor_oportunidadeid
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("urb_corretor_oportunidadeid");
			}
			set
			{
				this.OnPropertyChanging("urb_corretor_oportunidadeid");
				this.SetAttributeValue("urb_corretor_oportunidadeid", value);
				this.OnPropertyChanged("urb_corretor_oportunidadeid");
			}
		}
	



		/// <summary>
		/// Identificador único para Empreendimento associado a Oportunidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_empreendimentoid")]
		public Microsoft.Xrm.Sdk.EntityReference urb_EmpreendimentoId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("urb_empreendimentoid");
			}
			set
			{
				this.OnPropertyChanging("urb_EmpreendimentoId");
				this.SetAttributeValue("urb_empreendimentoid", value);
				this.OnPropertyChanged("urb_EmpreendimentoId");
			}
		}
	



		/// <summary>
		/// Gerente da Oportunidade
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_gerenteid")]
		public Microsoft.Xrm.Sdk.EntityReference urb_gerenteid
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("urb_gerenteid");
			}
			set
			{
				this.OnPropertyChanging("urb_gerenteid");
				this.SetAttributeValue("urb_gerenteid", value);
				this.OnPropertyChanged("urb_gerenteid");
			}
		}
	



		/// <summary>
		/// Identificador único para Plano de Financiamento associado a Oportunidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_plano_financiamentoid")]
		public Microsoft.Xrm.Sdk.EntityReference urb_plano_financiamentoid
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("urb_plano_financiamentoid");
			}
			set
			{
				this.OnPropertyChanging("urb_plano_financiamentoid");
				this.SetAttributeValue("urb_plano_financiamentoid", value);
				this.OnPropertyChanged("urb_plano_financiamentoid");
			}
		}
	



		/// <summary>
		/// Produto de oportunidade venda de serviço
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_produto_servicoid")]
		public Microsoft.Xrm.Sdk.EntityReference urb_produto_servicoid
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("urb_produto_servicoid");
			}
			set
			{
				this.OnPropertyChanging("urb_produto_servicoid");
				this.SetAttributeValue("urb_produto_servicoid", value);
				this.OnPropertyChanged("urb_produto_servicoid");
			}
		}
	



		/// <summary>
		/// Identificador único para Produto associado a Oportunidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_produtoid")]
		public Microsoft.Xrm.Sdk.EntityReference urb_ProdutoId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("urb_produtoid");
			}
			set
			{
				this.OnPropertyChanging("urb_ProdutoId");
				this.SetAttributeValue("urb_produtoid", value);
				this.OnPropertyChanged("urb_ProdutoId");
			}
		}
	



		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_quantidade_queda")]
		public System.Nullable<int> urb_Quantidade_Queda
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("urb_quantidade_queda");
			}
			set
			{
				this.OnPropertyChanging("urb_Quantidade_Queda");
				this.SetAttributeValue("urb_quantidade_queda", value);
				this.OnPropertyChanged("urb_Quantidade_Queda");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_tipo_oportunidade")]
		public Microsoft.Xrm.Sdk.OptionSetValue urb_tipo_oportunidade
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("urb_tipo_oportunidade");
			}
			set
			{
				this.OnPropertyChanging("urb_tipo_oportunidade");
				this.SetAttributeValue("urb_tipo_oportunidade", value);
				this.OnPropertyChanged("urb_tipo_oportunidade");
			}
		}
	
		public virtual Enums.urb_tipo_oportunidade? urb_tipo_oportunidadeEnum
		{
			get
			{
				return ((Enums.urb_tipo_oportunidade?)(EntityOptionSetEnum.GetEnum(this, "urb_tipo_oportunidade")));
			}
			set
			{
				urb_tipo_oportunidade = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_tipo_venda")]
		public Microsoft.Xrm.Sdk.OptionSetValue urb_tipo_venda
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("urb_tipo_venda");
			}
			set
			{
				this.OnPropertyChanging("urb_tipo_venda");
				this.SetAttributeValue("urb_tipo_venda", value);
				this.OnPropertyChanged("urb_tipo_venda");
			}
		}
	
		public virtual Enums.urb_tipo_venda? urb_tipo_vendaEnum
		{
			get
			{
				return ((Enums.urb_tipo_venda?)(EntityOptionSetEnum.GetEnum(this, "urb_tipo_venda")));
			}
			set
			{
				urb_tipo_venda = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_valor_proposta")]
		public Microsoft.Xrm.Sdk.Money urb_valor_proposta
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("urb_valor_proposta");
			}
			set
			{
				this.OnPropertyChanging("urb_valor_proposta");
				this.SetAttributeValue("urb_valor_proposta", value);
				this.OnPropertyChanged("urb_valor_proposta");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_valor_proposta_acessoria")]
		public Microsoft.Xrm.Sdk.Money urb_valor_proposta_acessoria
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("urb_valor_proposta_acessoria");
			}
			set
			{
				this.OnPropertyChanging("urb_valor_proposta_acessoria");
				this.SetAttributeValue("urb_valor_proposta_acessoria", value);
				this.OnPropertyChanged("urb_valor_proposta_acessoria");
			}
		}
	


		/// <summary>
		/// Valor do Valor Proposta com Acessoria em moeda base.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_valor_proposta_acessoria_base")]
		public Microsoft.Xrm.Sdk.Money urb_valor_proposta_acessoria_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("urb_valor_proposta_acessoria_base");
			}
		}
	


		/// <summary>
		/// Valor do Valor Proposta em moeda base.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_valor_proposta_base")]
		public Microsoft.Xrm.Sdk.Money urb_valor_proposta_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("urb_valor_proposta_base");
			}
		}
	


		/// <summary>
		/// Código de fuso horário em uso quando o registro foi criado.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
	


		/// <summary>
		/// Número da Versão
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
	


		
		/// <summary>
		/// 1:N opportunity_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_activity_parties")]
		public System.Collections.Generic.IEnumerable<ActivityParty> opportunity_activity_parties
		{
			get
			{
				return this.GetRelatedEntities<ActivityParty>("opportunity_activity_parties", null);
			}
			set
			{
				this.OnPropertyChanging("opportunity_activity_parties");
				this.SetRelatedEntities<ActivityParty>("opportunity_activity_parties", null, value);
				this.OnPropertyChanged("opportunity_activity_parties");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_opportunity_activity_parties(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "opportunity_activity_parties");
		}

		
		/// <summary>
		/// 1:N lead_qualifying_opportunity
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_qualifying_opportunity")]
		public System.Collections.Generic.IEnumerable<Lead> lead_qualifying_opportunity
		{
			get
			{
				return this.GetRelatedEntities<Lead>("lead_qualifying_opportunity", null);
			}
			set
			{
				this.OnPropertyChanging("lead_qualifying_opportunity");
				this.SetRelatedEntities<Lead>("lead_qualifying_opportunity", null, value);
				this.OnPropertyChanged("lead_qualifying_opportunity");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lead_qualifying_opportunity(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lead_qualifying_opportunity");
		}

		
		/// <summary>
		/// 1:N opportunity_Teams
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_Teams")]
		public System.Collections.Generic.IEnumerable<Team> opportunity_Teams
		{
			get
			{
				return this.GetRelatedEntities<Team>("opportunity_Teams", null);
			}
			set
			{
				this.OnPropertyChanging("opportunity_Teams");
				this.SetRelatedEntities<Team>("opportunity_Teams", null, value);
				this.OnPropertyChanged("opportunity_Teams");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_opportunity_Teams(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "opportunity_Teams");
		}

		
		/// <summary>
		/// N:1 lk_opportunitybase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunitybase_createdby")]
		public SystemUser lk_opportunitybase_createdby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_opportunitybase_createdby", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_opportunitybase_createdby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_opportunitybase_createdby");
		}

		
		/// <summary>
		/// N:1 lk_opportunity_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunity_createdonbehalfby")]
		public SystemUser lk_opportunity_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_opportunity_createdonbehalfby", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_opportunity_createdonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_opportunity_createdonbehalfby");
		}

		
		/// <summary>
		/// N:1 opportunity_customer_accounts
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_customer_accounts")]
		public Account opportunity_customer_accounts
		{
			get
			{
				return this.GetRelatedEntity<Account>("opportunity_customer_accounts", null);
			}
			set
			{
				this.OnPropertyChanging("opportunity_customer_accounts");
				this.SetRelatedEntity<Account>("opportunity_customer_accounts", null, value);
				this.OnPropertyChanged("opportunity_customer_accounts");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_opportunity_customer_accounts(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "opportunity_customer_accounts");
		}

		
		/// <summary>
		/// N:1 opportunity_customer_contacts
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_customer_contacts")]
		public Contact opportunity_customer_contacts
		{
			get
			{
				return this.GetRelatedEntity<Contact>("opportunity_customer_contacts", null);
			}
			set
			{
				this.OnPropertyChanging("opportunity_customer_contacts");
				this.SetRelatedEntity<Contact>("opportunity_customer_contacts", null, value);
				this.OnPropertyChanged("opportunity_customer_contacts");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_opportunity_customer_contacts(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "opportunity_customer_contacts");
		}

		
		/// <summary>
		/// N:1 lk_opportunitybase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunitybase_modifiedby")]
		public SystemUser lk_opportunitybase_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_opportunitybase_modifiedby", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_opportunitybase_modifiedby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_opportunitybase_modifiedby");
		}

		
		/// <summary>
		/// N:1 lk_opportunity_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunity_modifiedonbehalfby")]
		public SystemUser lk_opportunity_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_opportunity_modifiedonbehalfby", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_opportunity_modifiedonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_opportunity_modifiedonbehalfby");
		}

		
		/// <summary>
		/// N:1 msdyn_accountmanager_opportunity
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_accountmanagerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_accountmanager_opportunity")]
		public SystemUser msdyn_accountmanager_opportunity
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("msdyn_accountmanager_opportunity", null);
			}
			set
			{
				this.OnPropertyChanging("msdyn_accountmanager_opportunity");
				this.SetRelatedEntity<SystemUser>("msdyn_accountmanager_opportunity", null, value);
				this.OnPropertyChanged("msdyn_accountmanager_opportunity");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_msdyn_accountmanager_opportunity(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "msdyn_accountmanager_opportunity");
		}

		
		/// <summary>
		/// N:1 opportunity_originating_lead
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("originatingleadid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_originating_lead")]
		public Lead opportunity_originating_lead
		{
			get
			{
				return this.GetRelatedEntity<Lead>("opportunity_originating_lead", null);
			}
			set
			{
				this.OnPropertyChanging("opportunity_originating_lead");
				this.SetRelatedEntity<Lead>("opportunity_originating_lead", null, value);
				this.OnPropertyChanged("opportunity_originating_lead");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_opportunity_originating_lead(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "opportunity_originating_lead");
		}

		
		/// <summary>
		/// N:1 business_unit_opportunities
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_opportunities")]
		public BusinessUnit business_unit_opportunities
		{
			get
			{
				return this.GetRelatedEntity<BusinessUnit>("business_unit_opportunities", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_business_unit_opportunities(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "business_unit_opportunities");
		}

		
		/// <summary>
		/// N:1 team_opportunities
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_opportunities")]
		public Team team_opportunities
		{
			get
			{
				return this.GetRelatedEntity<Team>("team_opportunities", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_team_opportunities(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "team_opportunities");
		}

		
		/// <summary>
		/// N:1 opportunity_owning_user
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_owning_user")]
		public SystemUser opportunity_owning_user
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("opportunity_owning_user", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_opportunity_owning_user(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "opportunity_owning_user");
		}

		
		/// <summary>
		/// N:1 opportunity_parent_account
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentaccountid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_parent_account")]
		public Account opportunity_parent_account
		{
			get
			{
				return this.GetRelatedEntity<Account>("opportunity_parent_account", null);
			}
			set
			{
				this.OnPropertyChanging("opportunity_parent_account");
				this.SetRelatedEntity<Account>("opportunity_parent_account", null, value);
				this.OnPropertyChanged("opportunity_parent_account");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_opportunity_parent_account(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "opportunity_parent_account");
		}

		
		/// <summary>
		/// N:1 opportunity_parent_contact
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcontactid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_parent_contact")]
		public Contact opportunity_parent_contact
		{
			get
			{
				return this.GetRelatedEntity<Contact>("opportunity_parent_contact", null);
			}
			set
			{
				this.OnPropertyChanging("opportunity_parent_contact");
				this.SetRelatedEntity<Contact>("opportunity_parent_contact", null, value);
				this.OnPropertyChanged("opportunity_parent_contact");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_opportunity_parent_contact(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "opportunity_parent_contact");
		}

		
		/// <summary>
		/// N:1 transactioncurrency_opportunity
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_opportunity")]
		public TransactionCurrency transactioncurrency_opportunity
		{
			get
			{
				return this.GetRelatedEntity<TransactionCurrency>("transactioncurrency_opportunity", null);
			}
			set
			{
				this.OnPropertyChanging("transactioncurrency_opportunity");
				this.SetRelatedEntity<TransactionCurrency>("transactioncurrency_opportunity", null, value);
				this.OnPropertyChanged("transactioncurrency_opportunity");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_transactioncurrency_opportunity(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "transactioncurrency_opportunity");
		}

		
		/// <summary>
		/// N:1 urb_systemuser_opportunity
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_gerenteid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("urb_systemuser_opportunity")]
		public SystemUser urb_systemuser_opportunity
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("urb_systemuser_opportunity", null);
			}
			set
			{
				this.OnPropertyChanging("urb_systemuser_opportunity");
				this.SetRelatedEntity<SystemUser>("urb_systemuser_opportunity", null, value);
				this.OnPropertyChanged("urb_systemuser_opportunity");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_urb_systemuser_opportunity(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "urb_systemuser_opportunity");
		}



		public class Enums 
		{
			[DataContractAttribute]
			public enum BudgetStatus 
			{
				[EnumMemberAttribute]
				NenhumOrcamentoComprometido = 0,
				[EnumMemberAttribute]
				PossivelComprar = 1,
				[EnumMemberAttribute]
				PodeComprar = 2,
				[EnumMemberAttribute]
				Comprara = 3,
			}		
			[DataContractAttribute]
			public enum CaptureProposalFeedback 
			{
				[EnumMemberAttribute]
				Nao = 1,
				[EnumMemberAttribute]
				Sim = 0,
			}		
			[DataContractAttribute]
			public enum CompleteFinalProposal 
			{
				[EnumMemberAttribute]
				concluido = 1,
				[EnumMemberAttribute]
				marcarcomoconcluida = 0,
			}		
			[DataContractAttribute]
			public enum CompleteInternalReview 
			{
				[EnumMemberAttribute]
				concluido = 1,
				[EnumMemberAttribute]
				marcarcomoconcluida = 0,
			}		
			[DataContractAttribute]
			public enum ConfirmInterest 
			{
				[EnumMemberAttribute]
				Nao = 1,
				[EnumMemberAttribute]
				Sim = 0,
			}		
			[DataContractAttribute]
			public enum DecisionMaker 
			{
				[EnumMemberAttribute]
				concluido = 1,
				[EnumMemberAttribute]
				marcarcomoconcluido = 0,
			}		
			[DataContractAttribute]
			public enum DevelopProposal 
			{
				[EnumMemberAttribute]
				concluido = 1,
				[EnumMemberAttribute]
				marcarcomoconcluido = 0,
			}		
			[DataContractAttribute]
			public enum EvaluateFit 
			{
				[EnumMemberAttribute]
				Nao = 1,
				[EnumMemberAttribute]
				Sim = 0,
			}		
			[DataContractAttribute]
			public enum FileDebrief 
			{
				[EnumMemberAttribute]
				concluido = 1,
				[EnumMemberAttribute]
				marcarcomoconcluido = 0,
			}		
			[DataContractAttribute]
			public enum IdentifyCompetitors 
			{
				[EnumMemberAttribute]
				concluido = 1,
				[EnumMemberAttribute]
				marcarcomoconcluido = 0,
			}		
			[DataContractAttribute]
			public enum IdentifyCustomerContacts 
			{
				[EnumMemberAttribute]
				concluido = 1,
				[EnumMemberAttribute]
				marcarcomoconcluido = 0,
			}		
			[DataContractAttribute]
			public enum IdentifyPursuitTeam 
			{
				[EnumMemberAttribute]
				concluido = 1,
				[EnumMemberAttribute]
				marcarcomoconcluido = 0,
			}		
			[DataContractAttribute]
			public enum InitialCommunication 
			{
				[EnumMemberAttribute]
				Contatado = 0,
				[EnumMemberAttribute]
				NaoContatado = 1,
			}		
			[DataContractAttribute]
			public enum IsPrivate 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum IsRevenueSystemCalculated 
			{
				[EnumMemberAttribute]
				CalculadapeloSistema = 1,
				[EnumMemberAttribute]
				FornecidapeloUsuario = 0,
			}		
			[DataContractAttribute]
			public enum msdyn_OrderType 
			{
				[EnumMemberAttribute]
				Baseadoemtrabalho = 192350001,
				[EnumMemberAttribute]
				Baseadoemitem = 192350000,
				[EnumMemberAttribute]
				BaseadoemManutencaodeServico = 690970002,
			}		
			[DataContractAttribute]
			public enum Need 
			{
				[EnumMemberAttribute]
				Eobrigatorioter = 0,
				[EnumMemberAttribute]
				Deveter = 1,
				[EnumMemberAttribute]
				Ebomter = 2,
				[EnumMemberAttribute]
				Semnecessidades = 3,
			}		
			[DataContractAttribute]
			public enum OpportunityRatingCode 
			{
				[EnumMemberAttribute]
				MuitoInteressado = 1,
				[EnumMemberAttribute]
				Interessado = 2,
				[EnumMemberAttribute]
				Seminteresse = 3,
			}		
			[DataContractAttribute]
			public enum ParticipatesInWorkflow 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum PresentFinalProposal 
			{
				[EnumMemberAttribute]
				concluido = 1,
				[EnumMemberAttribute]
				marcarcomoconcluido = 0,
			}		
			[DataContractAttribute]
			public enum PresentProposal 
			{
				[EnumMemberAttribute]
				concluido = 1,
				[EnumMemberAttribute]
				marcarcomoconcluido = 0,
			}		
			[DataContractAttribute]
			public enum PricingErrorCode 
			{
				[EnumMemberAttribute]
				Nenhum = 0,
				[EnumMemberAttribute]
				ErrodeDetalhe = 1,
				[EnumMemberAttribute]
				FaltaoNiveldePreco = 2,
				[EnumMemberAttribute]
				NiveldePrecoInativo = 3,
				[EnumMemberAttribute]
				FaltaaQuantidade = 4,
				[EnumMemberAttribute]
				FaltaoPrecoUnitario = 5,
				[EnumMemberAttribute]
				FaltaoProduto = 6,
				[EnumMemberAttribute]
				ProdutoInvalido = 7,
				[EnumMemberAttribute]
				FaltaoCodigodePrecificacao = 8,
				[EnumMemberAttribute]
				CodigodePrecificacaoInvalido = 9,
				[EnumMemberAttribute]
				FaltaaUM = 10,
				[EnumMemberAttribute]
				ProdutoNaoEstanoNiveldePreco = 11,
				[EnumMemberAttribute]
				FaltaoValordoNiveldePreco = 12,
				[EnumMemberAttribute]
				FaltaaPorcentagemdoNiveldePreco = 13,
				[EnumMemberAttribute]
				FaltaoPreco = 14,
				[EnumMemberAttribute]
				FaltaoCustoAtual = 15,
				[EnumMemberAttribute]
				FaltaoCustoPadrao = 16,
				[EnumMemberAttribute]
				ValorInvalidodeNiveldePreco = 17,
				[EnumMemberAttribute]
				PorcentagemInvalidadeNiveldePreco = 18,
				[EnumMemberAttribute]
				PrecoInvalido = 19,
				[EnumMemberAttribute]
				CustoAtualInvalido = 20,
				[EnumMemberAttribute]
				CustoPadraoInvalido = 21,
				[EnumMemberAttribute]
				PoliticadeArredondamentoInvalida = 22,
				[EnumMemberAttribute]
				OpcaodeArredondamentoInvalida = 23,
				[EnumMemberAttribute]
				ValorInvalidodeArredondamento = 24,
				[EnumMemberAttribute]
				ErrodeCalculodePreco = 25,
				[EnumMemberAttribute]
				TipoInvalidodeDesconto = 26,
				[EnumMemberAttribute]
				EstadoInvalidodoTipodeDesconto = 27,
				[EnumMemberAttribute]
				DescontoInvalido = 28,
				[EnumMemberAttribute]
				QuantidadeInvalida = 29,
				[EnumMemberAttribute]
				PrecisaoInvalidadePrecificacao = 30,
				[EnumMemberAttribute]
				FaltaaUMPadraodoProduto = 31,
				[EnumMemberAttribute]
				FaltaaProgramacaodeUMdeProduto = 32,
				[EnumMemberAttribute]
				TipodeDescontoInativo = 33,
				[EnumMemberAttribute]
				MoedaInvalidadeNiveldePreco = 34,
				[EnumMemberAttribute]
				AtributodePrecoForadeIntervalo = 35,
				[EnumMemberAttribute]
				EstourodoAtributodeMoedaBase = 36,
				[EnumMemberAttribute]
				EstouroNegativodoAtributodeMoedaBase = 37,
			}		
			[DataContractAttribute]
			public enum PriorityCode 
			{
				[EnumMemberAttribute]
				ValorPadrao = 1,
			}		
			[DataContractAttribute]
			public enum PurchaseProcess 
			{
				[EnumMemberAttribute]
				Individual = 0,
				[EnumMemberAttribute]
				Comissao = 1,
				[EnumMemberAttribute]
				Desconhecido = 2,
			}		
			[DataContractAttribute]
			public enum PurchaseTimeframe 
			{
				[EnumMemberAttribute]
				Imediato = 0,
				[EnumMemberAttribute]
				EsteTrimestre = 1,
				[EnumMemberAttribute]
				ProximoTrimestre = 2,
				[EnumMemberAttribute]
				EsteAno = 3,
				[EnumMemberAttribute]
				Desconhecido = 4,
			}		
			[DataContractAttribute]
			public enum PursuitDecision 
			{
				[EnumMemberAttribute]
				Nao = 1,
				[EnumMemberAttribute]
				Sim = 0,
			}		
			[DataContractAttribute]
			public enum ResolveFeedback 
			{
				[EnumMemberAttribute]
				Nao = 1,
				[EnumMemberAttribute]
				Sim = 0,
			}		
			[DataContractAttribute]
			public enum SalesStage 
			{
				[EnumMemberAttribute]
				Qualificar = 0,
				[EnumMemberAttribute]
				Desenvolver = 1,
				[EnumMemberAttribute]
				Propor = 2,
				[EnumMemberAttribute]
				Fechar = 3,
			}		
			[DataContractAttribute]
			public enum SalesStageCode 
			{
				[EnumMemberAttribute]
				ValorPadrao = 1,
			}		
			[DataContractAttribute]
			public enum SendThankYouNote 
			{
				[EnumMemberAttribute]
				concluido = 1,
				[EnumMemberAttribute]
				marcarcomoconcluido = 0,
			}		
			[DataContractAttribute]
			public enum StateCode 
			{
				[EnumMemberAttribute]
				Aberta = 0,
				[EnumMemberAttribute]
				Ganha = 1,
				[EnumMemberAttribute]
				Perdida = 2,
			}		
			[DataContractAttribute]
			public enum StatusCode 
			{
				[EnumMemberAttribute]
				EmAndamento = 1,
				[EnumMemberAttribute]
				Suspenso = 2,
				[EnumMemberAttribute]
				QuedaemAndamento = 169070000,
				[EnumMemberAttribute]
				Ganha = 3,
				[EnumMemberAttribute]
				Cancelada = 4,
				[EnumMemberAttribute]
				Esgotada = 5,
				[EnumMemberAttribute]
				Distrato = 169070001,
			}		
			[DataContractAttribute]
			public enum TimeLine 
			{
				[EnumMemberAttribute]
				Imediato = 0,
				[EnumMemberAttribute]
				EsteTrimestre = 1,
				[EnumMemberAttribute]
				ProximoTrimestre = 2,
				[EnumMemberAttribute]
				EsteAno = 3,
				[EnumMemberAttribute]
				Desconhecido = 4,
			}		
			[DataContractAttribute]
			public enum urb_tipo_oportunidade 
			{
				[EnumMemberAttribute]
				VendadeLote = 169070000,
				[EnumMemberAttribute]
				VendadeServico = 169070001,
			}		
			[DataContractAttribute]
			public enum urb_tipo_venda 
			{
				[EnumMemberAttribute]
				VendaEfetiva = 169070000,
				[EnumMemberAttribute]
				RenegociacaodeContrato = 169070001,
				[EnumMemberAttribute]
				RenegociacaoFinanciamentoBancario = 169070002,
				[EnumMemberAttribute]
				CessaodeDireitos = 169070003,
			}		
	}


		public class OneToMany
		{
			public const string opportunity_activity_parties = "opportunity_activity_parties";
			public const string lead_qualifying_opportunity = "lead_qualifying_opportunity";
			public const string opportunity_Teams = "opportunity_Teams";
}
		public class ManyToMany
		{
}

		public class Fields
		{
			public const string SchemaName = "opportunity";
			
			public const string AccountId = "accountid";
			public const string AccountIdName = "accountidName";
			public const string ActualCloseDate = "actualclosedate";
			public const string ActualValue = "actualvalue";
			public const string ActualValue_Base = "actualvalue_base";
			public const string BudgetAmount = "budgetamount";
			public const string BudgetAmount_Base = "budgetamount_base";
			public const string BudgetStatus = "budgetstatus";
			public const string CampaignId = "campaignid";
			public const string CampaignIdName = "campaignidName";
			public const string CaptureProposalFeedback = "captureproposalfeedback";
			public const string CloseProbability = "closeprobability";
			public const string CompleteFinalProposal = "completefinalproposal";
			public const string CompleteInternalReview = "completeinternalreview";
			public const string ConfirmInterest = "confirminterest";
			public const string ContactId = "contactid";
			public const string ContactIdName = "contactidName";
			public const string CreatedBy = "createdby";
			public const string CreatedByName = "createdbyName";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CreatedOnBehalfByName = "createdonbehalfbyName";
			public const string CurrentSituation = "currentsituation";
			public const string CustomerId = "customerid";
			public const string CustomerIdName = "customeridName";
			public const string CustomerIdType = "customeridType";
			public const string CustomerNeed = "customerneed";
			public const string CustomerPainPoints = "customerpainpoints";
			public const string DecisionMaker = "decisionmaker";
			public const string Description = "description";
			public const string DevelopProposal = "developproposal";
			public const string DiscountAmount = "discountamount";
			public const string DiscountAmount_Base = "discountamount_base";
			public const string DiscountPercentage = "discountpercentage";
			public const string EmailAddress = "emailaddress";
			public const string EstimatedCloseDate = "estimatedclosedate";
			public const string EstimatedValue = "estimatedvalue";
			public const string EstimatedValue_Base = "estimatedvalue_base";
			public const string EvaluateFit = "evaluatefit";
			public const string ExchangeRate = "exchangerate";
			public const string FileDebrief = "filedebrief";
			public const string FinalDecisionDate = "finaldecisiondate";
			public const string FreightAmount = "freightamount";
			public const string FreightAmount_Base = "freightamount_base";
			public const string IdentifyCompetitors = "identifycompetitors";
			public const string IdentifyCustomerContacts = "identifycustomercontacts";
			public const string IdentifyPursuitTeam = "identifypursuitteam";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string InitialCommunication = "initialcommunication";
			public const string IsPrivate = "isprivate";
			public const string IsRevenueSystemCalculated = "isrevenuesystemcalculated";
			public const string LastOnHoldTime = "lastonholdtime";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedByName = "modifiedbyName";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string ModifiedOnBehalfByName = "modifiedonbehalfbyName";
			public const string msdyn_AccountManagerId = "msdyn_accountmanagerid";
			public const string msdyn_AccountManagerIdName = "msdyn_accountmanageridName";
			public const string msdyn_ContractOrganizationalUnitId = "msdyn_contractorganizationalunitid";
			public const string msdyn_ContractOrganizationalUnitIdName = "msdyn_contractorganizationalunitidName";
			public const string msdyn_OrderType = "msdyn_ordertype";
			public const string msdyn_WorkOrderType = "msdyn_workordertype";
			public const string msdyn_WorkOrderTypeName = "msdyn_workordertypeName";
			public const string Name = "name";
			public const string Need = "need";
			public const string OnHoldTime = "onholdtime";
			public const string OpportunityId = "opportunityid";
			public const string OpportunityRatingCode = "opportunityratingcode";
			public const string OriginatingLeadId = "originatingleadid";
			public const string OriginatingLeadIdName = "originatingleadidName";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningBusinessUnitName = "owningbusinessunitName";
			public const string OwningTeam = "owningteam";
			public const string OwningTeamName = "owningteamName";
			public const string OwningUser = "owninguser";
			public const string OwningUserName = "owninguserName";
			public const string ParentAccountId = "parentaccountid";
			public const string ParentAccountIdName = "parentaccountidName";
			public const string ParentContactId = "parentcontactid";
			public const string ParentContactIdName = "parentcontactidName";
			public const string ParticipatesInWorkflow = "participatesinworkflow";
			public const string PresentFinalProposal = "presentfinalproposal";
			public const string PresentProposal = "presentproposal";
			public const string PriceLevelId = "pricelevelid";
			public const string PriceLevelIdName = "pricelevelidName";
			public const string PricingErrorCode = "pricingerrorcode";
			public const string PriorityCode = "prioritycode";
			public const string ProcessId = "processid";
			public const string ProposedSolution = "proposedsolution";
			public const string PurchaseProcess = "purchaseprocess";
			public const string PurchaseTimeframe = "purchasetimeframe";
			public const string PursuitDecision = "pursuitdecision";
			public const string QualificationComments = "qualificationcomments";
			public const string QuoteComments = "quotecomments";
			public const string ResolveFeedback = "resolvefeedback";
			public const string SalesStage = "salesstage";
			public const string SalesStageCode = "salesstagecode";
			public const string ScheduleFollowup_Prospect = "schedulefollowup_prospect";
			public const string ScheduleFollowup_Qualify = "schedulefollowup_qualify";
			public const string ScheduleProposalMeeting = "scheduleproposalmeeting";
			public const string SendThankYouNote = "sendthankyounote";
			public const string SLAId = "slaid";
			public const string SLAIdName = "slaidName";
			public const string SLAInvokedId = "slainvokedid";
			public const string SLAInvokedIdName = "slainvokedidName";
			public const string StageId = "stageid";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string StepId = "stepid";
			public const string StepName = "stepname";
			public const string TimeLine = "timeline";
			public const string TimeSpentByMeOnEmailAndMeetings = "timespentbymeonemailandmeetings";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string TotalAmount = "totalamount";
			public const string TotalAmount_Base = "totalamount_base";
			public const string TotalAmountLessFreight = "totalamountlessfreight";
			public const string TotalAmountLessFreight_Base = "totalamountlessfreight_base";
			public const string TotalDiscountAmount = "totaldiscountamount";
			public const string TotalDiscountAmount_Base = "totaldiscountamount_base";
			public const string TotalLineItemAmount = "totallineitemamount";
			public const string TotalLineItemAmount_Base = "totallineitemamount_base";
			public const string TotalLineItemDiscountAmount = "totallineitemdiscountamount";
			public const string TotalLineItemDiscountAmount_Base = "totallineitemdiscountamount_base";
			public const string TotalTax = "totaltax";
			public const string TotalTax_Base = "totaltax_base";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string TransactionCurrencyIdName = "transactioncurrencyidName";
			public const string TraversedPath = "traversedpath";
			public const string urb_aditivo_taxa_administracao = "urb_aditivo_taxa_administracao";
			public const string urb_codigo_deposito_identificado = "urb_codigo_deposito_identificado";
			public const string urb_codigo_pagador = "urb_codigo_pagador";
			public const string urb_codigo_seguro_mip = "urb_codigo_seguro_mip";
			public const string urb_contrato_sap = "urb_contrato_sap";
			public const string urb_corretor_oportunidadeid = "urb_corretor_oportunidadeid";
			public const string urb_corretor_oportunidadeidName = "urb_corretor_oportunidadeidName";
			public const string urb_EmpreendimentoId = "urb_empreendimentoid";
			public const string urb_EmpreendimentoIdName = "urb_empreendimentoidName";
			public const string urb_gerenteid = "urb_gerenteid";
			public const string urb_gerenteidName = "urb_gerenteidName";
			public const string urb_plano_financiamentoid = "urb_plano_financiamentoid";
			public const string urb_plano_financiamentoidName = "urb_plano_financiamentoidName";
			public const string urb_produto_servicoid = "urb_produto_servicoid";
			public const string urb_produto_servicoidName = "urb_produto_servicoidName";
			public const string urb_ProdutoId = "urb_produtoid";
			public const string urb_ProdutoIdName = "urb_produtoidName";
			public const string urb_Quantidade_Queda = "urb_quantidade_queda";
			public const string urb_tipo_oportunidade = "urb_tipo_oportunidade";
			public const string urb_tipo_venda = "urb_tipo_venda";
			public const string urb_valor_proposta = "urb_valor_proposta";
			public const string urb_valor_proposta_acessoria = "urb_valor_proposta_acessoria";
			public const string urb_valor_proposta_acessoria_Base = "urb_valor_proposta_acessoria_base";
			public const string urb_valor_proposta_Base = "urb_valor_proposta_base";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
		}
	}

	/// <summary>
	/// Pessoa com acesso ao sistema Microsoft CRM e proprietária de objetos no banco de dados do Microsoft CRM.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("systemuser")]
	public partial class SystemUser : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public SystemUser() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "systemuser";
		
		public const int EntityTypeCode = 8;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.SystemUserId = value;
			}
		}
		/// <summary>
		/// Tipo de usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accessmode")]
		public Microsoft.Xrm.Sdk.OptionSetValue AccessMode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("accessmode");
			}
			set
			{
				this.OnPropertyChanging("AccessMode");
				this.SetAttributeValue("accessmode", value);
				this.OnPropertyChanged("AccessMode");
			}
		}
	
		public virtual Enums.AccessMode? AccessModeEnum
		{
			get
			{
				return ((Enums.AccessMode?)(EntityOptionSetEnum.GetEnum(this, "accessmode")));
			}
			set
			{
				AccessMode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// GUID de objeto do Active Directory para o usuário do sistema.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activedirectoryguid")]
		public System.Nullable<System.Guid> ActiveDirectoryGuid
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("activedirectoryguid");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo do endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addressid")]
		public System.Nullable<System.Guid> Address1_AddressId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("address1_addressid");
			}
			set
			{
				this.OnPropertyChanging("Address1_AddressId");
				this.SetAttributeValue("address1_addressid", value);
				this.OnPropertyChanged("Address1_AddressId");
			}
		}
	


		/// <summary>
		/// Tipo do endereço 1, como por exemplo, endereço para cobrança, endereço para entrega ou endereço primário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addresstypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address1_AddressTypeCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_addresstypecode");
			}
			set
			{
				this.OnPropertyChanging("Address1_AddressTypeCode");
				this.SetAttributeValue("address1_addresstypecode", value);
				this.OnPropertyChanged("Address1_AddressTypeCode");
			}
		}
	
		public virtual Enums.Address1_AddressTypeCode? Address1_AddressTypeCodeEnum
		{
			get
			{
				return ((Enums.Address1_AddressTypeCode?)(EntityOptionSetEnum.GetEnum(this, "address1_addresstypecode")));
			}
			set
			{
				Address1_AddressTypeCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Nome da cidade do endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_city")]
		public string Address1_City
		{
			get
			{
				return this.GetAttributeValue<string>("address1_city");
			}
			set
			{
				this.OnPropertyChanging("Address1_City");
				this.SetAttributeValue("address1_city", value);
				this.OnPropertyChanged("Address1_City");
			}
		}
	


		/// <summary>
		/// Mostra o endereço principal completo.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_composite")]
		public string Address1_Composite
		{
			get
			{
				return this.GetAttributeValue<string>("address1_composite");
			}
		}
	


		/// <summary>
		/// Nome do país/região em endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_country")]
		public string Address1_Country
		{
			get
			{
				return this.GetAttributeValue<string>("address1_country");
			}
			set
			{
				this.OnPropertyChanging("Address1_Country");
				this.SetAttributeValue("address1_country", value);
				this.OnPropertyChanged("Address1_Country");
			}
		}
	


		/// <summary>
		/// Nome do município do endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_county")]
		public string Address1_County
		{
			get
			{
				return this.GetAttributeValue<string>("address1_county");
			}
			set
			{
				this.OnPropertyChanging("Address1_County");
				this.SetAttributeValue("address1_county", value);
				this.OnPropertyChanged("Address1_County");
			}
		}
	


		/// <summary>
		/// Número de fax do endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_fax")]
		public string Address1_Fax
		{
			get
			{
				return this.GetAttributeValue<string>("address1_fax");
			}
			set
			{
				this.OnPropertyChanging("Address1_Fax");
				this.SetAttributeValue("address1_fax", value);
				this.OnPropertyChanged("Address1_Fax");
			}
		}
	


		/// <summary>
		/// Latitude do endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_latitude")]
		public System.Nullable<double> Address1_Latitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address1_latitude");
			}
			set
			{
				this.OnPropertyChanging("Address1_Latitude");
				this.SetAttributeValue("address1_latitude", value);
				this.OnPropertyChanged("Address1_Latitude");
			}
		}
	


		/// <summary>
		/// Primeira linha para inserir informações de endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line1")]
		public string Address1_Line1
		{
			get
			{
				return this.GetAttributeValue<string>("address1_line1");
			}
			set
			{
				this.OnPropertyChanging("Address1_Line1");
				this.SetAttributeValue("address1_line1", value);
				this.OnPropertyChanged("Address1_Line1");
			}
		}
	


		/// <summary>
		/// Segunda linha para inserir informações de endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line2")]
		public string Address1_Line2
		{
			get
			{
				return this.GetAttributeValue<string>("address1_line2");
			}
			set
			{
				this.OnPropertyChanging("Address1_Line2");
				this.SetAttributeValue("address1_line2", value);
				this.OnPropertyChanged("Address1_Line2");
			}
		}
	


		/// <summary>
		/// Terceira linha para inserir informações de endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line3")]
		public string Address1_Line3
		{
			get
			{
				return this.GetAttributeValue<string>("address1_line3");
			}
			set
			{
				this.OnPropertyChanging("Address1_Line3");
				this.SetAttributeValue("address1_line3", value);
				this.OnPropertyChanged("Address1_Line3");
			}
		}
	


		/// <summary>
		/// Longitude do endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_longitude")]
		public System.Nullable<double> Address1_Longitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address1_longitude");
			}
			set
			{
				this.OnPropertyChanging("Address1_Longitude");
				this.SetAttributeValue("address1_longitude", value);
				this.OnPropertyChanged("Address1_Longitude");
			}
		}
	


		/// <summary>
		/// Nome a ser inserido para endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_name")]
		public string Address1_Name
		{
			get
			{
				return this.GetAttributeValue<string>("address1_name");
			}
			set
			{
				this.OnPropertyChanging("Address1_Name");
				this.SetAttributeValue("address1_name", value);
				this.OnPropertyChanged("Address1_Name");
			}
		}
	


		/// <summary>
		/// CEP do endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postalcode")]
		public string Address1_PostalCode
		{
			get
			{
				return this.GetAttributeValue<string>("address1_postalcode");
			}
			set
			{
				this.OnPropertyChanging("Address1_PostalCode");
				this.SetAttributeValue("address1_postalcode", value);
				this.OnPropertyChanged("Address1_PostalCode");
			}
		}
	


		/// <summary>
		/// Número da caixa postal do endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postofficebox")]
		public string Address1_PostOfficeBox
		{
			get
			{
				return this.GetAttributeValue<string>("address1_postofficebox");
			}
			set
			{
				this.OnPropertyChanging("Address1_PostOfficeBox");
				this.SetAttributeValue("address1_postofficebox", value);
				this.OnPropertyChanged("Address1_PostOfficeBox");
			}
		}
	


		/// <summary>
		/// Método de entrega para endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_shippingmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address1_ShippingMethodCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_shippingmethodcode");
			}
			set
			{
				this.OnPropertyChanging("Address1_ShippingMethodCode");
				this.SetAttributeValue("address1_shippingmethodcode", value);
				this.OnPropertyChanged("Address1_ShippingMethodCode");
			}
		}
	
		public virtual Enums.Address1_ShippingMethodCode? Address1_ShippingMethodCodeEnum
		{
			get
			{
				return ((Enums.Address1_ShippingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "address1_shippingmethodcode")));
			}
			set
			{
				Address1_ShippingMethodCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Estado do endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_stateorprovince")]
		public string Address1_StateOrProvince
		{
			get
			{
				return this.GetAttributeValue<string>("address1_stateorprovince");
			}
			set
			{
				this.OnPropertyChanging("Address1_StateOrProvince");
				this.SetAttributeValue("address1_stateorprovince", value);
				this.OnPropertyChanged("Address1_StateOrProvince");
			}
		}
	


		/// <summary>
		/// Primeiro número de telefone associado ao endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone1")]
		public string Address1_Telephone1
		{
			get
			{
				return this.GetAttributeValue<string>("address1_telephone1");
			}
			set
			{
				this.OnPropertyChanging("Address1_Telephone1");
				this.SetAttributeValue("address1_telephone1", value);
				this.OnPropertyChanged("Address1_Telephone1");
			}
		}
	


		/// <summary>
		/// Segundo número de telefone associado ao endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone2")]
		public string Address1_Telephone2
		{
			get
			{
				return this.GetAttributeValue<string>("address1_telephone2");
			}
			set
			{
				this.OnPropertyChanging("Address1_Telephone2");
				this.SetAttributeValue("address1_telephone2", value);
				this.OnPropertyChanged("Address1_Telephone2");
			}
		}
	


		/// <summary>
		/// Terceiro número de telefone associado ao endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone3")]
		public string Address1_Telephone3
		{
			get
			{
				return this.GetAttributeValue<string>("address1_telephone3");
			}
			set
			{
				this.OnPropertyChanging("Address1_Telephone3");
				this.SetAttributeValue("address1_telephone3", value);
				this.OnPropertyChanged("Address1_Telephone3");
			}
		}
	


		/// <summary>
		/// Zona UPS do endereço 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_upszone")]
		public string Address1_UPSZone
		{
			get
			{
				return this.GetAttributeValue<string>("address1_upszone");
			}
			set
			{
				this.OnPropertyChanging("Address1_UPSZone");
				this.SetAttributeValue("address1_upszone", value);
				this.OnPropertyChanged("Address1_UPSZone");
			}
		}
	


		/// <summary>
		/// Diferença UTC do endereço 1. Essa é a diferença entre a hora local e a Hora Universal Coordenada oficial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_utcoffset")]
		public System.Nullable<int> Address1_UTCOffset
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("address1_utcoffset");
			}
			set
			{
				this.OnPropertyChanging("Address1_UTCOffset");
				this.SetAttributeValue("address1_utcoffset", value);
				this.OnPropertyChanged("Address1_UTCOffset");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo do endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addressid")]
		public System.Nullable<System.Guid> Address2_AddressId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("address2_addressid");
			}
			set
			{
				this.OnPropertyChanging("Address2_AddressId");
				this.SetAttributeValue("address2_addressid", value);
				this.OnPropertyChanged("Address2_AddressId");
			}
		}
	


		/// <summary>
		/// Tipo do endereço 2, como por exemplo, endereço para cobrança, endereço para entrega ou endereço primário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addresstypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address2_AddressTypeCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_addresstypecode");
			}
			set
			{
				this.OnPropertyChanging("Address2_AddressTypeCode");
				this.SetAttributeValue("address2_addresstypecode", value);
				this.OnPropertyChanged("Address2_AddressTypeCode");
			}
		}
	
		public virtual Enums.Address2_AddressTypeCode? Address2_AddressTypeCodeEnum
		{
			get
			{
				return ((Enums.Address2_AddressTypeCode?)(EntityOptionSetEnum.GetEnum(this, "address2_addresstypecode")));
			}
			set
			{
				Address2_AddressTypeCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Nome da cidade do endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_city")]
		public string Address2_City
		{
			get
			{
				return this.GetAttributeValue<string>("address2_city");
			}
			set
			{
				this.OnPropertyChanging("Address2_City");
				this.SetAttributeValue("address2_city", value);
				this.OnPropertyChanged("Address2_City");
			}
		}
	


		/// <summary>
		/// Mostra o endereço secundário completo.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_composite")]
		public string Address2_Composite
		{
			get
			{
				return this.GetAttributeValue<string>("address2_composite");
			}
		}
	


		/// <summary>
		/// Nome do país/região em endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_country")]
		public string Address2_Country
		{
			get
			{
				return this.GetAttributeValue<string>("address2_country");
			}
			set
			{
				this.OnPropertyChanging("Address2_Country");
				this.SetAttributeValue("address2_country", value);
				this.OnPropertyChanged("Address2_Country");
			}
		}
	


		/// <summary>
		/// Nome do município do endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_county")]
		public string Address2_County
		{
			get
			{
				return this.GetAttributeValue<string>("address2_county");
			}
			set
			{
				this.OnPropertyChanging("Address2_County");
				this.SetAttributeValue("address2_county", value);
				this.OnPropertyChanged("Address2_County");
			}
		}
	


		/// <summary>
		/// Número de fax do endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_fax")]
		public string Address2_Fax
		{
			get
			{
				return this.GetAttributeValue<string>("address2_fax");
			}
			set
			{
				this.OnPropertyChanging("Address2_Fax");
				this.SetAttributeValue("address2_fax", value);
				this.OnPropertyChanged("Address2_Fax");
			}
		}
	


		/// <summary>
		/// Latitude do endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_latitude")]
		public System.Nullable<double> Address2_Latitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address2_latitude");
			}
			set
			{
				this.OnPropertyChanging("Address2_Latitude");
				this.SetAttributeValue("address2_latitude", value);
				this.OnPropertyChanged("Address2_Latitude");
			}
		}
	


		/// <summary>
		/// Primeira linha para inserir informações de endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line1")]
		public string Address2_Line1
		{
			get
			{
				return this.GetAttributeValue<string>("address2_line1");
			}
			set
			{
				this.OnPropertyChanging("Address2_Line1");
				this.SetAttributeValue("address2_line1", value);
				this.OnPropertyChanged("Address2_Line1");
			}
		}
	


		/// <summary>
		/// Segunda linha para inserir informações de endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line2")]
		public string Address2_Line2
		{
			get
			{
				return this.GetAttributeValue<string>("address2_line2");
			}
			set
			{
				this.OnPropertyChanging("Address2_Line2");
				this.SetAttributeValue("address2_line2", value);
				this.OnPropertyChanged("Address2_Line2");
			}
		}
	


		/// <summary>
		/// Terceira linha para inserir informações de endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line3")]
		public string Address2_Line3
		{
			get
			{
				return this.GetAttributeValue<string>("address2_line3");
			}
			set
			{
				this.OnPropertyChanging("Address2_Line3");
				this.SetAttributeValue("address2_line3", value);
				this.OnPropertyChanged("Address2_Line3");
			}
		}
	


		/// <summary>
		/// Longitude do endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_longitude")]
		public System.Nullable<double> Address2_Longitude
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("address2_longitude");
			}
			set
			{
				this.OnPropertyChanging("Address2_Longitude");
				this.SetAttributeValue("address2_longitude", value);
				this.OnPropertyChanged("Address2_Longitude");
			}
		}
	


		/// <summary>
		/// Nome a ser inserido para endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_name")]
		public string Address2_Name
		{
			get
			{
				return this.GetAttributeValue<string>("address2_name");
			}
			set
			{
				this.OnPropertyChanging("Address2_Name");
				this.SetAttributeValue("address2_name", value);
				this.OnPropertyChanged("Address2_Name");
			}
		}
	


		/// <summary>
		/// CEP do endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postalcode")]
		public string Address2_PostalCode
		{
			get
			{
				return this.GetAttributeValue<string>("address2_postalcode");
			}
			set
			{
				this.OnPropertyChanging("Address2_PostalCode");
				this.SetAttributeValue("address2_postalcode", value);
				this.OnPropertyChanged("Address2_PostalCode");
			}
		}
	


		/// <summary>
		/// Número da caixa postal do endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postofficebox")]
		public string Address2_PostOfficeBox
		{
			get
			{
				return this.GetAttributeValue<string>("address2_postofficebox");
			}
			set
			{
				this.OnPropertyChanging("Address2_PostOfficeBox");
				this.SetAttributeValue("address2_postofficebox", value);
				this.OnPropertyChanged("Address2_PostOfficeBox");
			}
		}
	


		/// <summary>
		/// Método de entrega para endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_shippingmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Address2_ShippingMethodCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_shippingmethodcode");
			}
			set
			{
				this.OnPropertyChanging("Address2_ShippingMethodCode");
				this.SetAttributeValue("address2_shippingmethodcode", value);
				this.OnPropertyChanged("Address2_ShippingMethodCode");
			}
		}
	
		public virtual Enums.Address2_ShippingMethodCode? Address2_ShippingMethodCodeEnum
		{
			get
			{
				return ((Enums.Address2_ShippingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "address2_shippingmethodcode")));
			}
			set
			{
				Address2_ShippingMethodCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Estado do endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_stateorprovince")]
		public string Address2_StateOrProvince
		{
			get
			{
				return this.GetAttributeValue<string>("address2_stateorprovince");
			}
			set
			{
				this.OnPropertyChanging("Address2_StateOrProvince");
				this.SetAttributeValue("address2_stateorprovince", value);
				this.OnPropertyChanged("Address2_StateOrProvince");
			}
		}
	


		/// <summary>
		/// Primeiro número de telefone associado ao endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone1")]
		public string Address2_Telephone1
		{
			get
			{
				return this.GetAttributeValue<string>("address2_telephone1");
			}
			set
			{
				this.OnPropertyChanging("Address2_Telephone1");
				this.SetAttributeValue("address2_telephone1", value);
				this.OnPropertyChanged("Address2_Telephone1");
			}
		}
	


		/// <summary>
		/// Segundo número de telefone associado ao endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone2")]
		public string Address2_Telephone2
		{
			get
			{
				return this.GetAttributeValue<string>("address2_telephone2");
			}
			set
			{
				this.OnPropertyChanging("Address2_Telephone2");
				this.SetAttributeValue("address2_telephone2", value);
				this.OnPropertyChanged("Address2_Telephone2");
			}
		}
	


		/// <summary>
		/// Terceiro número de telefone associado ao endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone3")]
		public string Address2_Telephone3
		{
			get
			{
				return this.GetAttributeValue<string>("address2_telephone3");
			}
			set
			{
				this.OnPropertyChanging("Address2_Telephone3");
				this.SetAttributeValue("address2_telephone3", value);
				this.OnPropertyChanged("Address2_Telephone3");
			}
		}
	


		/// <summary>
		/// Zona UPS do endereço 2.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_upszone")]
		public string Address2_UPSZone
		{
			get
			{
				return this.GetAttributeValue<string>("address2_upszone");
			}
			set
			{
				this.OnPropertyChanging("Address2_UPSZone");
				this.SetAttributeValue("address2_upszone", value);
				this.OnPropertyChanged("Address2_UPSZone");
			}
		}
	


		/// <summary>
		/// Diferença UTC do endereço 2. Essa é a diferença entre a hora local e a Hora Universal Coordenada oficial.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_utcoffset")]
		public System.Nullable<int> Address2_UTCOffset
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("address2_utcoffset");
			}
			set
			{
				this.OnPropertyChanging("Address2_UTCOffset");
				this.SetAttributeValue("address2_utcoffset", value);
				this.OnPropertyChanged("Address2_UTCOffset");
			}
		}
	


		/// <summary>
		/// O identificador do aplicativo. É usado para acessar dados em outro aplicativo.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("applicationid")]
		public System.Nullable<System.Guid> ApplicationId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("applicationid");
			}
			set
			{
				this.OnPropertyChanging("ApplicationId");
				this.SetAttributeValue("applicationid", value);
				this.OnPropertyChanged("ApplicationId");
			}
		}
	


		/// <summary>
		/// O URI usado como identificador lógico exclusivo do aplicativo externo. Pode ser usado para validar o aplicativo.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("applicationiduri")]
		public string ApplicationIdUri
		{
			get
			{
				return this.GetAttributeValue<string>("applicationiduri");
			}
		}
	


		/// <summary>
		/// É a ID do objeto do diretório de aplicativos.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("azureactivedirectoryobjectid")]
		public System.Nullable<System.Guid> AzureActiveDirectoryObjectId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("azureactivedirectoryobjectid");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo da unidade de negócios à qual o usuário está associado.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
		public Microsoft.Xrm.Sdk.EntityReference BusinessUnitId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("businessunitid");
			}
			set
			{
				this.OnPropertyChanging("BusinessUnitId");
				this.SetAttributeValue("businessunitid", value);
				this.OnPropertyChanged("BusinessUnitId");
			}
		}
	



		/// <summary>
		/// Calendário fiscal associado ao usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("calendarid")]
		public Microsoft.Xrm.Sdk.EntityReference CalendarId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("calendarid");
			}
			set
			{
				this.OnPropertyChanging("CalendarId");
				this.SetAttributeValue("calendarid", value);
				this.OnPropertyChanged("CalendarId");
			}
		}
	



		/// <summary>
		/// Tipo de licença do usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("caltype")]
		public Microsoft.Xrm.Sdk.OptionSetValue CALType
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("caltype");
			}
			set
			{
				this.OnPropertyChanging("CALType");
				this.SetAttributeValue("caltype", value);
				this.OnPropertyChanged("CALType");
			}
		}
	
		public virtual Enums.CALType? CALTypeEnum
		{
			get
			{
				return ((Enums.CALType?)(EntityOptionSetEnum.GetEnum(this, "caltype")));
			}
			set
			{
				CALType = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Identificador exclusivo do usuário que criou o  usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
	



		/// <summary>
		/// Data e hora em que o usuário foi criado.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo do usuário delegado que criou o systemuser.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
	



		/// <summary>
		/// Indica se os filtros padrão do Outlook foram populados.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultfilterspopulated")]
		public System.Nullable<bool> DefaultFiltersPopulated
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("defaultfilterspopulated");
			}
		}
	
		public virtual Enums.DefaultFiltersPopulated? DefaultFiltersPopulatedEnum
		{
			get
			{
				return ((Enums.DefaultFiltersPopulated?)(EntityOptionSetEnum.GetEnum(this, "defaultfilterspopulated")));
			}
		}


		/// <summary>
		/// Escolha a caixa de correio associada a este usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultmailbox")]
		public Microsoft.Xrm.Sdk.EntityReference DefaultMailbox
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("defaultmailbox");
			}
		}
	



		/// <summary>
		/// Digite um nome de pasta padrão para o local do OneDrive For Business do usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultodbfoldername")]
		public string DefaultOdbFolderName
		{
			get
			{
				return this.GetAttributeValue<string>("defaultodbfoldername");
			}
		}
	


		/// <summary>
		/// Razão para desabilitar o usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("disabledreason")]
		public string DisabledReason
		{
			get
			{
				return this.GetAttributeValue<string>("disabledreason");
			}
		}
	


		/// <summary>
		/// Indicação se o usuário deve ser mostrado em exibições de serviço.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("displayinserviceviews")]
		public System.Nullable<bool> DisplayInServiceViews
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("displayinserviceviews");
			}
			set
			{
				this.OnPropertyChanging("DisplayInServiceViews");
				this.SetAttributeValue("displayinserviceviews", value);
				this.OnPropertyChanged("DisplayInServiceViews");
			}
		}
	
		public virtual Enums.DisplayInServiceViews? DisplayInServiceViewsEnum
		{
			get
			{
				return ((Enums.DisplayInServiceViews?)(EntityOptionSetEnum.GetEnum(this, "displayinserviceviews")));
			}
			set
			{
		       if (value.HasValue)
                    DisplayInServiceViews = ((int)value == 1);
                else                   
                    DisplayInServiceViews = null;
			}
		}


		/// <summary>
		/// Domínio do Active Directory do qual o usuário é membro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("domainname")]
		public string DomainName
		{
			get
			{
				return this.GetAttributeValue<string>("domainname");
			}
			set
			{
				this.OnPropertyChanging("DomainName");
				this.SetAttributeValue("domainname", value);
				this.OnPropertyChanged("DomainName");
			}
		}
	


		/// <summary>
		/// Mostra o status do endereço de email principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailrouteraccessapproval")]
		public Microsoft.Xrm.Sdk.OptionSetValue EmailRouterAccessApproval
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("emailrouteraccessapproval");
			}
			set
			{
				this.OnPropertyChanging("EmailRouterAccessApproval");
				this.SetAttributeValue("emailrouteraccessapproval", value);
				this.OnPropertyChanged("EmailRouterAccessApproval");
			}
		}
	
		public virtual Enums.EmailRouterAccessApproval? EmailRouterAccessApprovalEnum
		{
			get
			{
				return ((Enums.EmailRouterAccessApproval?)(EntityOptionSetEnum.GetEnum(this, "emailrouteraccessapproval")));
			}
			set
			{
				EmailRouterAccessApproval = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Identificador de funcionário para o usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("employeeid")]
		public string EmployeeId
		{
			get
			{
				return this.GetAttributeValue<string>("employeeid");
			}
			set
			{
				this.OnPropertyChanging("EmployeeId");
				this.SetAttributeValue("employeeid", value);
				this.OnPropertyChanged("EmployeeId");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage")]
		public byte[] EntityImage
		{
			get
			{
				return this.GetAttributeValue<byte[]>("entityimage");
			}
			set
			{
				this.OnPropertyChanging("EntityImage");
				this.SetAttributeValue("entityimage", value);
				this.OnPropertyChanged("EntityImage");
			}
		}
	


		/// <summary>
		///  
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_timestamp")]
		public System.Nullable<long> EntityImage_Timestamp
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("entityimage_timestamp");
			}
		}
	


		/// <summary>
		///  
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_url")]
		public string EntityImage_URL
		{
			get
			{
				return this.GetAttributeValue<string>("entityimage_url");
			}
		}
	


		/// <summary>
		/// Somente para uso interno.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimageid")]
		public System.Nullable<System.Guid> EntityImageId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("entityimageid");
			}
		}
	


		/// <summary>
		/// Taxa de câmbio da moeda associada ao systemuser com relação à moeda base.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
		public System.Nullable<decimal> ExchangeRate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
			}
		}
	


		/// <summary>
		/// Nome do usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("firstname")]
		public string FirstName
		{
			get
			{
				return this.GetAttributeValue<string>("firstname");
			}
			set
			{
				this.OnPropertyChanging("FirstName");
				this.SetAttributeValue("firstname", value);
				this.OnPropertyChanged("FirstName");
			}
		}
	


		/// <summary>
		/// Nome completo do usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fullname")]
		public string FullName
		{
			get
			{
				return this.GetAttributeValue<string>("fullname");
			}
		}
	


		/// <summary>
		/// Identificador de governo para o usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("governmentid")]
		public string GovernmentId
		{
			get
			{
				return this.GetAttributeValue<string>("governmentid");
			}
			set
			{
				this.OnPropertyChanging("GovernmentId");
				this.SetAttributeValue("governmentid", value);
				this.OnPropertyChanged("GovernmentId");
			}
		}
	


		/// <summary>
		/// Número do telefone residencial do usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("homephone")]
		public string HomePhone
		{
			get
			{
				return this.GetAttributeValue<string>("homephone");
			}
			set
			{
				this.OnPropertyChanging("HomePhone");
				this.SetAttributeValue("homephone", value);
				this.OnPropertyChanged("HomePhone");
			}
		}
	


		/// <summary>
		/// Somente para uso interno.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("identityid")]
		public System.Nullable<int> IdentityId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("identityid");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo da importação de dados ou migração de dados que criou este registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
	


		/// <summary>
		/// Método de entrega de emails de entrada do usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("incomingemaildeliverymethod")]
		public Microsoft.Xrm.Sdk.OptionSetValue IncomingEmailDeliveryMethod
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("incomingemaildeliverymethod");
			}
			set
			{
				this.OnPropertyChanging("IncomingEmailDeliveryMethod");
				this.SetAttributeValue("incomingemaildeliverymethod", value);
				this.OnPropertyChanged("IncomingEmailDeliveryMethod");
			}
		}
	
		public virtual Enums.IncomingEmailDeliveryMethod? IncomingEmailDeliveryMethodEnum
		{
			get
			{
				return ((Enums.IncomingEmailDeliveryMethod?)(EntityOptionSetEnum.GetEnum(this, "incomingemaildeliverymethod")));
			}
			set
			{
				IncomingEmailDeliveryMethod = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Endereço de email interno do usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("internalemailaddress")]
		public string InternalEMailAddress
		{
			get
			{
				return this.GetAttributeValue<string>("internalemailaddress");
			}
			set
			{
				this.OnPropertyChanging("InternalEMailAddress");
				this.SetAttributeValue("internalemailaddress", value);
				this.OnPropertyChanged("InternalEMailAddress");
			}
		}
	


		/// <summary>
		/// Status do convite do usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("invitestatuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue InviteStatusCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("invitestatuscode");
			}
			set
			{
				this.OnPropertyChanging("InviteStatusCode");
				this.SetAttributeValue("invitestatuscode", value);
				this.OnPropertyChanged("InviteStatusCode");
			}
		}
	
		public virtual Enums.InviteStatusCode? InviteStatusCodeEnum
		{
			get
			{
				return ((Enums.InviteStatusCode?)(EntityOptionSetEnum.GetEnum(this, "invitestatuscode")));
			}
			set
			{
				InviteStatusCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Informações que indicam se o usuário é um usuário do Active Directory.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isactivedirectoryuser")]
		public System.Nullable<bool> IsActiveDirectoryUser
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isactivedirectoryuser");
			}
		}
	
		public virtual Enums.IsActiveDirectoryUser? IsActiveDirectoryUserEnum
		{
			get
			{
				return ((Enums.IsActiveDirectoryUser?)(EntityOptionSetEnum.GetEnum(this, "isactivedirectoryuser")));
			}
		}


		/// <summary>
		/// Especifica se  usuário está habilitado.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdisabled")]
		public System.Nullable<bool> IsDisabled
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isdisabled");
			}
			set
			{
				this.OnPropertyChanging("IsDisabled");
				this.SetAttributeValue("isdisabled", value);
				this.OnPropertyChanged("IsDisabled");
			}
		}
	
		public virtual Enums.IsDisabled? IsDisabledEnum
		{
			get
			{
				return ((Enums.IsDisabled?)(EntityOptionSetEnum.GetEnum(this, "isdisabled")));
			}
			set
			{
		       if (value.HasValue)
                    IsDisabled = ((int)value == 1);
                else                   
                    IsDisabled = null;
			}
		}


		/// <summary>
		/// Mostra o status da aprovação do endereço de email pelo administrador do O365.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isemailaddressapprovedbyo365admin")]
		public System.Nullable<bool> IsEmailAddressApprovedByO365Admin
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isemailaddressapprovedbyo365admin");
			}
		}
	
		public virtual Enums.IsEmailAddressApprovedByO365Admin? IsEmailAddressApprovedByO365AdminEnum
		{
			get
			{
				return ((Enums.IsEmailAddressApprovedByO365Admin?)(EntityOptionSetEnum.GetEnum(this, "isemailaddressapprovedbyo365admin")));
			}
		}


		/// <summary>
		/// Verifique se o usuário é um usuário de integração.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isintegrationuser")]
		public System.Nullable<bool> IsIntegrationUser
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isintegrationuser");
			}
			set
			{
				this.OnPropertyChanging("IsIntegrationUser");
				this.SetAttributeValue("isintegrationuser", value);
				this.OnPropertyChanged("IsIntegrationUser");
			}
		}
	
		public virtual Enums.IsIntegrationUser? IsIntegrationUserEnum
		{
			get
			{
				return ((Enums.IsIntegrationUser?)(EntityOptionSetEnum.GetEnum(this, "isintegrationuser")));
			}
			set
			{
		       if (value.HasValue)
                    IsIntegrationUser = ((int)value == 1);
                else                   
                    IsIntegrationUser = null;
			}
		}


		/// <summary>
		/// Informações se o usuário é licenciado ou não.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("islicensed")]
		public System.Nullable<bool> IsLicensed
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("islicensed");
			}
			set
			{
				this.OnPropertyChanging("IsLicensed");
				this.SetAttributeValue("islicensed", value);
				this.OnPropertyChanged("IsLicensed");
			}
		}
	
		public virtual Enums.IsLicensed? IsLicensedEnum
		{
			get
			{
				return ((Enums.IsLicensed?)(EntityOptionSetEnum.GetEnum(this, "islicensed")));
			}
			set
			{
		       if (value.HasValue)
                    IsLicensed = ((int)value == 1);
                else                   
                    IsLicensed = null;
			}
		}


		/// <summary>
		/// Informação que especifica se o usuário está sincronizado ou não com o diretório.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("issyncwithdirectory")]
		public System.Nullable<bool> IsSyncWithDirectory
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("issyncwithdirectory");
			}
			set
			{
				this.OnPropertyChanging("IsSyncWithDirectory");
				this.SetAttributeValue("issyncwithdirectory", value);
				this.OnPropertyChanged("IsSyncWithDirectory");
			}
		}
	
		public virtual Enums.IsSyncWithDirectory? IsSyncWithDirectoryEnum
		{
			get
			{
				return ((Enums.IsSyncWithDirectory?)(EntityOptionSetEnum.GetEnum(this, "issyncwithdirectory")));
			}
			set
			{
		       if (value.HasValue)
                    IsSyncWithDirectory = ((int)value == 1);
                else                   
                    IsSyncWithDirectory = null;
			}
		}


		/// <summary>
		/// Cargo do usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("jobtitle")]
		public string JobTitle
		{
			get
			{
				return this.GetAttributeValue<string>("jobtitle");
			}
			set
			{
				this.OnPropertyChanging("JobTitle");
				this.SetAttributeValue("jobtitle", value);
				this.OnPropertyChanged("JobTitle");
			}
		}
	


		/// <summary>
		/// Sobrenome do usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastname")]
		public string LastName
		{
			get
			{
				return this.GetAttributeValue<string>("lastname");
			}
			set
			{
				this.OnPropertyChanging("LastName");
				this.SetAttributeValue("lastname", value);
				this.OnPropertyChanged("LastName");
			}
		}
	


		/// <summary>
		/// Carimbo de data/hora da última atualização do usuário
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("latestupdatetime")]
		public System.Nullable<System.DateTime> LatestUpdateTime
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("latestupdatetime");
			}
		}
	


		/// <summary>
		/// Segundo nome do usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("middlename")]
		public string MiddleName
		{
			get
			{
				return this.GetAttributeValue<string>("middlename");
			}
			set
			{
				this.OnPropertyChanging("MiddleName");
				this.SetAttributeValue("middlename", value);
				this.OnPropertyChanged("MiddleName");
			}
		}
	


		/// <summary>
		/// Endereço de email de alerta do celular do usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mobilealertemail")]
		public string MobileAlertEMail
		{
			get
			{
				return this.GetAttributeValue<string>("mobilealertemail");
			}
			set
			{
				this.OnPropertyChanging("MobileAlertEMail");
				this.SetAttributeValue("mobilealertemail", value);
				this.OnPropertyChanged("MobileAlertEMail");
			}
		}
	


		/// <summary>
		/// Itens contidos em um SystemUser específico.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mobileofflineprofileid")]
		public Microsoft.Xrm.Sdk.EntityReference MobileOfflineProfileId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("mobileofflineprofileid");
			}
			set
			{
				this.OnPropertyChanging("MobileOfflineProfileId");
				this.SetAttributeValue("mobileofflineprofileid", value);
				this.OnPropertyChanged("MobileOfflineProfileId");
			}
		}
	



		/// <summary>
		/// Número do celular do usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mobilephone")]
		public string MobilePhone
		{
			get
			{
				return this.GetAttributeValue<string>("mobilephone");
			}
			set
			{
				this.OnPropertyChanging("MobilePhone");
				this.SetAttributeValue("mobilephone", value);
				this.OnPropertyChanged("MobilePhone");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo do usuário que modificou o usuário por último.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
	



		/// <summary>
		/// Data e hora da última modificação do usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo do usuário delegado que modificou o systemuser pela última vez.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
	



		/// <summary>
		/// Apelido do usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("nickname")]
		public string NickName
		{
			get
			{
				return this.GetAttributeValue<string>("nickname");
			}
			set
			{
				this.OnPropertyChanging("NickName");
				this.SetAttributeValue("nickname", value);
				this.OnPropertyChanged("NickName");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo da organização associada ao usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public System.Nullable<System.Guid> OrganizationId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("organizationid");
			}
		}
	


		/// <summary>
		/// Método de entrega de emails de saída do usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("outgoingemaildeliverymethod")]
		public Microsoft.Xrm.Sdk.OptionSetValue OutgoingEmailDeliveryMethod
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("outgoingemaildeliverymethod");
			}
			set
			{
				this.OnPropertyChanging("OutgoingEmailDeliveryMethod");
				this.SetAttributeValue("outgoingemaildeliverymethod", value);
				this.OnPropertyChanged("OutgoingEmailDeliveryMethod");
			}
		}
	
		public virtual Enums.OutgoingEmailDeliveryMethod? OutgoingEmailDeliveryMethodEnum
		{
			get
			{
				return ((Enums.OutgoingEmailDeliveryMethod?)(EntityOptionSetEnum.GetEnum(this, "outgoingemaildeliverymethod")));
			}
			set
			{
				OutgoingEmailDeliveryMethod = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Data e hora da migração do registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo do gerente do usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentsystemuserid")]
		public Microsoft.Xrm.Sdk.EntityReference ParentSystemUserId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentsystemuserid");
			}
			set
			{
				this.OnPropertyChanging("ParentSystemUserId");
				this.SetAttributeValue("parentsystemuserid", value);
				this.OnPropertyChanged("ParentSystemUserId");
			}
		}
	



		/// <summary>
		/// Apenas para uso interno.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("passporthi")]
		public System.Nullable<int> PassportHi
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("passporthi");
			}
			set
			{
				this.OnPropertyChanging("PassportHi");
				this.SetAttributeValue("passporthi", value);
				this.OnPropertyChanged("PassportHi");
			}
		}
	


		/// <summary>
		/// Apenas para uso interno.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("passportlo")]
		public System.Nullable<int> PassportLo
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("passportlo");
			}
			set
			{
				this.OnPropertyChanging("PassportLo");
				this.SetAttributeValue("passportlo", value);
				this.OnPropertyChanged("PassportLo");
			}
		}
	


		/// <summary>
		/// Endereço de email pessoal do usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("personalemailaddress")]
		public string PersonalEMailAddress
		{
			get
			{
				return this.GetAttributeValue<string>("personalemailaddress");
			}
			set
			{
				this.OnPropertyChanging("PersonalEMailAddress");
				this.SetAttributeValue("personalemailaddress", value);
				this.OnPropertyChanged("PersonalEMailAddress");
			}
		}
	


		/// <summary>
		/// URL do site em que a foto do usuário está localizada.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("photourl")]
		public string PhotoUrl
		{
			get
			{
				return this.GetAttributeValue<string>("photourl");
			}
			set
			{
				this.OnPropertyChanging("PhotoUrl");
				this.SetAttributeValue("photourl", value);
				this.OnPropertyChanged("PhotoUrl");
			}
		}
	


		/// <summary>
		/// Posição do usuário no modelo de segurança hierárquica.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("positionid")]
		public Microsoft.Xrm.Sdk.EntityReference PositionId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("positionid");
			}
			set
			{
				this.OnPropertyChanging("PositionId");
				this.SetAttributeValue("positionid", value);
				this.OnPropertyChanged("PositionId");
			}
		}
	



		/// <summary>
		/// Endereço preferencial do usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredaddresscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PreferredAddressCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredaddresscode");
			}
			set
			{
				this.OnPropertyChanging("PreferredAddressCode");
				this.SetAttributeValue("preferredaddresscode", value);
				this.OnPropertyChanged("PreferredAddressCode");
			}
		}
	
		public virtual Enums.PreferredAddressCode? PreferredAddressCodeEnum
		{
			get
			{
				return ((Enums.PreferredAddressCode?)(EntityOptionSetEnum.GetEnum(this, "preferredaddresscode")));
			}
			set
			{
				PreferredAddressCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Endereço de email preferencial do usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredemailcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PreferredEmailCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredemailcode");
			}
			set
			{
				this.OnPropertyChanging("PreferredEmailCode");
				this.SetAttributeValue("preferredemailcode", value);
				this.OnPropertyChanged("PreferredEmailCode");
			}
		}
	
		public virtual Enums.PreferredEmailCode? PreferredEmailCodeEnum
		{
			get
			{
				return ((Enums.PreferredEmailCode?)(EntityOptionSetEnum.GetEnum(this, "preferredemailcode")));
			}
			set
			{
				PreferredEmailCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Número de telefone preferencial do usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredphonecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PreferredPhoneCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredphonecode");
			}
			set
			{
				this.OnPropertyChanging("PreferredPhoneCode");
				this.SetAttributeValue("preferredphonecode", value);
				this.OnPropertyChanged("PreferredPhoneCode");
			}
		}
	
		public virtual Enums.PreferredPhoneCode? PreferredPhoneCodeEnum
		{
			get
			{
				return ((Enums.PreferredPhoneCode?)(EntityOptionSetEnum.GetEnum(this, "preferredphonecode")));
			}
			set
			{
				PreferredPhoneCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Mostra a ID do processo.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
		public System.Nullable<System.Guid> ProcessId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("processid");
			}
			set
			{
				this.OnPropertyChanging("ProcessId");
				this.SetAttributeValue("processid", value);
				this.OnPropertyChanged("ProcessId");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo da fila padrão do usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queueid")]
		public Microsoft.Xrm.Sdk.EntityReference QueueId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("queueid");
			}
			set
			{
				this.OnPropertyChanging("QueueId");
				this.SetAttributeValue("queueid", value);
				this.OnPropertyChanged("QueueId");
			}
		}
	



		/// <summary>
		/// Saudação para correspondências com o usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salutation")]
		public string Salutation
		{
			get
			{
				return this.GetAttributeValue<string>("salutation");
			}
			set
			{
				this.OnPropertyChanging("Salutation");
				this.SetAttributeValue("salutation", value);
				this.OnPropertyChanged("Salutation");
			}
		}
	


		/// <summary>
		/// Verificar se o usuário é um usuário de instalação.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("setupuser")]
		public System.Nullable<bool> SetupUser
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("setupuser");
			}
			set
			{
				this.OnPropertyChanging("SetupUser");
				this.SetAttributeValue("setupuser", value);
				this.OnPropertyChanged("SetupUser");
			}
		}
	
		public virtual Enums.SetupUser? SetupUserEnum
		{
			get
			{
				return ((Enums.SetupUser?)(EntityOptionSetEnum.GetEnum(this, "setupuser")));
			}
			set
			{
		       if (value.HasValue)
                    SetupUser = ((int)value == 1);
                else                   
                    SetupUser = null;
			}
		}


		/// <summary>
		/// Endereço de Email de Trabalho do SharePoint
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sharepointemailaddress")]
		public string SharePointEmailAddress
		{
			get
			{
				return this.GetAttributeValue<string>("sharepointemailaddress");
			}
			set
			{
				this.OnPropertyChanging("SharePointEmailAddress");
				this.SetAttributeValue("sharepointemailaddress", value);
				this.OnPropertyChanged("SharePointEmailAddress");
			}
		}
	


		/// <summary>
		/// Local do usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("siteid")]
		public Microsoft.Xrm.Sdk.EntityReference SiteId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("siteid");
			}
			set
			{
				this.OnPropertyChanging("SiteId");
				this.SetAttributeValue("siteid", value);
				this.OnPropertyChanged("SiteId");
			}
		}
	



		/// <summary>
		/// Conjunto de qualificações do usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("skills")]
		public string Skills
		{
			get
			{
				return this.GetAttributeValue<string>("skills");
			}
			set
			{
				this.OnPropertyChanging("Skills");
				this.SetAttributeValue("skills", value);
				this.OnPropertyChanged("Skills");
			}
		}
	


		/// <summary>
		/// Mostra a ID do estágio.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
		public System.Nullable<System.Guid> StageId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("stageid");
			}
			set
			{
				this.OnPropertyChanging("StageId");
				this.SetAttributeValue("stageid", value);
				this.OnPropertyChanged("StageId");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo do usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserid")]
		public System.Nullable<System.Guid> SystemUserId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("systemuserid");
			}
			set
			{
				this.OnPropertyChanging("SystemUserId");
				this.SetAttributeValue("systemuserid", value);
						if (value.HasValue)
						{
							base.Id = value.Value;
						}
						else
						{
							base.Id = System.Guid.Empty;
						}
				this.OnPropertyChanged("SystemUserId");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo da região à qual o usuário está atribuído.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("territoryid")]
		public Microsoft.Xrm.Sdk.EntityReference TerritoryId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("territoryid");
			}
			set
			{
				this.OnPropertyChanging("TerritoryId");
				this.SetAttributeValue("territoryid", value);
				this.OnPropertyChanged("TerritoryId");
			}
		}
	



		/// <summary>
		/// Apenas para uso interno.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
	


		/// <summary>
		/// Título do usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("title")]
		public string Title
		{
			get
			{
				return this.GetAttributeValue<string>("title");
			}
			set
			{
				this.OnPropertyChanging("Title");
				this.SetAttributeValue("title", value);
				this.OnPropertyChanged("Title");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo da moeda associada ao systemuser.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
			}
			set
			{
				this.OnPropertyChanging("TransactionCurrencyId");
				this.SetAttributeValue("transactioncurrencyid", value);
				this.OnPropertyChanged("TransactionCurrencyId");
			}
		}
	



		/// <summary>
		/// Apenas para uso interno.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traversedpath")]
		public string TraversedPath
		{
			get
			{
				return this.GetAttributeValue<string>("traversedpath");
			}
			set
			{
				this.OnPropertyChanging("TraversedPath");
				this.SetAttributeValue("traversedpath", value);
				this.OnPropertyChanged("TraversedPath");
			}
		}
	


		/// <summary>
		/// Identificador único para Loja associado a Usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_lojaid")]
		public Microsoft.Xrm.Sdk.EntityReference urb_LojaId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("urb_lojaid");
			}
			set
			{
				this.OnPropertyChanging("urb_LojaId");
				this.SetAttributeValue("urb_lojaid", value);
				this.OnPropertyChanged("urb_LojaId");
			}
		}
	



		/// <summary>
		/// Indica se usuário recebe e-mail com pendências de oportunidades
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_notifica_pendencia_oportunidade")]
		public System.Nullable<bool> urb_notifica_pendencia_oportunidade
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("urb_notifica_pendencia_oportunidade");
			}
			set
			{
				this.OnPropertyChanging("urb_notifica_pendencia_oportunidade");
				this.SetAttributeValue("urb_notifica_pendencia_oportunidade", value);
				this.OnPropertyChanged("urb_notifica_pendencia_oportunidade");
			}
		}
	
		public virtual Enums.urb_notifica_pendencia_oportunidade? urb_notifica_pendencia_oportunidadeEnum
		{
			get
			{
				return ((Enums.urb_notifica_pendencia_oportunidade?)(EntityOptionSetEnum.GetEnum(this, "urb_notifica_pendencia_oportunidade")));
			}
			set
			{
		       if (value.HasValue)
                    urb_notifica_pendencia_oportunidade = ((int)value == 1);
                else                   
                    urb_notifica_pendencia_oportunidade = null;
			}
		}


		/// <summary>
		/// Registro de observações de atendimento
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_observacoes")]
		public string urb_observacoes
		{
			get
			{
				return this.GetAttributeValue<string>("urb_observacoes");
			}
			set
			{
				this.OnPropertyChanging("urb_observacoes");
				this.SetAttributeValue("urb_observacoes", value);
				this.OnPropertyChanged("urb_observacoes");
			}
		}
	


		/// <summary>
		/// Mostra o tipo de licença de usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userlicensetype")]
		public System.Nullable<int> UserLicenseType
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("userlicensetype");
			}
			set
			{
				this.OnPropertyChanging("UserLicenseType");
				this.SetAttributeValue("userlicensetype", value);
				this.OnPropertyChanged("UserLicenseType");
			}
		}
	


		/// <summary>
		///  Informações Identificáveis do PUID do Usuário
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userpuid")]
		public string UserPuid
		{
			get
			{
				return this.GetAttributeValue<string>("userpuid");
			}
		}
	


		/// <summary>
		/// Código de fuso horário em uso quando o registro foi criado.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
	


		/// <summary>
		/// Número da versão do usuário.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
	


		/// <summary>
		/// Windows Live ID
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("windowsliveid")]
		public string WindowsLiveID
		{
			get
			{
				return this.GetAttributeValue<string>("windowsliveid");
			}
			set
			{
				this.OnPropertyChanging("WindowsLiveID");
				this.SetAttributeValue("windowsliveid", value);
				this.OnPropertyChanged("WindowsLiveID");
			}
		}
	


		/// <summary>
		/// Endereço de email de logon no Yammer do usuário
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yammeremailaddress")]
		public string YammerEmailAddress
		{
			get
			{
				return this.GetAttributeValue<string>("yammeremailaddress");
			}
			set
			{
				this.OnPropertyChanging("YammerEmailAddress");
				this.SetAttributeValue("yammeremailaddress", value);
				this.OnPropertyChanged("YammerEmailAddress");
			}
		}
	


		/// <summary>
		/// ID do Usuário do Yammer
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yammeruserid")]
		public string YammerUserId
		{
			get
			{
				return this.GetAttributeValue<string>("yammeruserid");
			}
			set
			{
				this.OnPropertyChanging("YammerUserId");
				this.SetAttributeValue("yammeruserid", value);
				this.OnPropertyChanged("YammerUserId");
			}
		}
	


		/// <summary>
		/// Pronúncia do nome do usuário, escrito em caracteres fonéticos hiragana ou katakana.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomifirstname")]
		public string YomiFirstName
		{
			get
			{
				return this.GetAttributeValue<string>("yomifirstname");
			}
			set
			{
				this.OnPropertyChanging("YomiFirstName");
				this.SetAttributeValue("yomifirstname", value);
				this.OnPropertyChanged("YomiFirstName");
			}
		}
	


		/// <summary>
		/// Pronúncia do nome completo do usuário, escrito em caracteres fonéticos hiragana ou katakana.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomifullname")]
		public string YomiFullName
		{
			get
			{
				return this.GetAttributeValue<string>("yomifullname");
			}
		}
	


		/// <summary>
		/// Pronúncia do sobrenome do usuário, escrito em caracteres fonéticos hiragana ou katakana.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomilastname")]
		public string YomiLastName
		{
			get
			{
				return this.GetAttributeValue<string>("yomilastname");
			}
			set
			{
				this.OnPropertyChanging("YomiLastName");
				this.SetAttributeValue("yomilastname", value);
				this.OnPropertyChanged("YomiLastName");
			}
		}
	


		/// <summary>
		/// Pronúncia do segundo nome do usuário, escrito em caracteres fonéticos hiragana ou katakana.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomimiddlename")]
		public string YomiMiddleName
		{
			get
			{
				return this.GetAttributeValue<string>("yomimiddlename");
			}
			set
			{
				this.OnPropertyChanging("YomiMiddleName");
				this.SetAttributeValue("yomimiddlename", value);
				this.OnPropertyChanged("YomiMiddleName");
			}
		}
	


		
		/// <summary>
		/// 1:N lk_teambase_administratorid
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_teambase_administratorid")]
		public System.Collections.Generic.IEnumerable<Team> lk_teambase_administratorid
		{
			get
			{
				return this.GetRelatedEntities<Team>("lk_teambase_administratorid", null);
			}
			set
			{
				this.OnPropertyChanging("lk_teambase_administratorid");
				this.SetRelatedEntities<Team>("lk_teambase_administratorid", null, value);
				this.OnPropertyChanged("lk_teambase_administratorid");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_teambase_administratorid(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_teambase_administratorid");
		}

		
		/// <summary>
		/// 1:N lk_teambase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_teambase_createdby")]
		public System.Collections.Generic.IEnumerable<Team> lk_teambase_createdby
		{
			get
			{
				return this.GetRelatedEntities<Team>("lk_teambase_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_teambase_createdby");
				this.SetRelatedEntities<Team>("lk_teambase_createdby", null, value);
				this.OnPropertyChanged("lk_teambase_createdby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_teambase_createdby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_teambase_createdby");
		}

		
		/// <summary>
		/// 1:N lk_contactbase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contactbase_createdby")]
		public System.Collections.Generic.IEnumerable<Contact> lk_contactbase_createdby
		{
			get
			{
				return this.GetRelatedEntities<Contact>("lk_contactbase_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_contactbase_createdby");
				this.SetRelatedEntities<Contact>("lk_contactbase_createdby", null, value);
				this.OnPropertyChanged("lk_contactbase_createdby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_contactbase_createdby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_contactbase_createdby");
		}

		
		/// <summary>
		/// 1:N lk_accountbase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_createdby")]
		public System.Collections.Generic.IEnumerable<Account> lk_accountbase_createdby
		{
			get
			{
				return this.GetRelatedEntities<Account>("lk_accountbase_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_accountbase_createdby");
				this.SetRelatedEntities<Account>("lk_accountbase_createdby", null, value);
				this.OnPropertyChanged("lk_accountbase_createdby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_accountbase_createdby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_accountbase_createdby");
		}

		
		/// <summary>
		/// 1:N lk_transactioncurrencybase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transactioncurrencybase_createdby")]
		public System.Collections.Generic.IEnumerable<TransactionCurrency> lk_transactioncurrencybase_createdby
		{
			get
			{
				return this.GetRelatedEntities<TransactionCurrency>("lk_transactioncurrencybase_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_transactioncurrencybase_createdby");
				this.SetRelatedEntities<TransactionCurrency>("lk_transactioncurrencybase_createdby", null, value);
				this.OnPropertyChanged("lk_transactioncurrencybase_createdby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_transactioncurrencybase_createdby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_transactioncurrencybase_createdby");
		}

		
		/// <summary>
		/// 1:N lk_systemuserbase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuserbase_createdby", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<SystemUser> Referencedlk_systemuserbase_createdby
		{
			get
			{
				return this.GetRelatedEntities<SystemUser>("lk_systemuserbase_createdby", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referencedlk_systemuserbase_createdby");
				this.SetRelatedEntities<SystemUser>("lk_systemuserbase_createdby", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedlk_systemuserbase_createdby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_systemuserbase_createdby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_systemuserbase_createdby");
		}

		
		/// <summary>
		/// 1:N lk_businessunitbase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunitbase_createdby")]
		public System.Collections.Generic.IEnumerable<BusinessUnit> lk_businessunitbase_createdby
		{
			get
			{
				return this.GetRelatedEntities<BusinessUnit>("lk_businessunitbase_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_businessunitbase_createdby");
				this.SetRelatedEntities<BusinessUnit>("lk_businessunitbase_createdby", null, value);
				this.OnPropertyChanged("lk_businessunitbase_createdby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_businessunitbase_createdby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_businessunitbase_createdby");
		}

		
		/// <summary>
		/// 1:N lk_leadbase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_leadbase_createdby")]
		public System.Collections.Generic.IEnumerable<Lead> lk_leadbase_createdby
		{
			get
			{
				return this.GetRelatedEntities<Lead>("lk_leadbase_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_leadbase_createdby");
				this.SetRelatedEntities<Lead>("lk_leadbase_createdby", null, value);
				this.OnPropertyChanged("lk_leadbase_createdby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_leadbase_createdby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_leadbase_createdby");
		}

		
		/// <summary>
		/// 1:N lk_uombase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uombase_createdby")]
		public System.Collections.Generic.IEnumerable<UoM> lk_uombase_createdby
		{
			get
			{
				return this.GetRelatedEntities<UoM>("lk_uombase_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_uombase_createdby");
				this.SetRelatedEntities<UoM>("lk_uombase_createdby", null, value);
				this.OnPropertyChanged("lk_uombase_createdby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_uombase_createdby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_uombase_createdby");
		}

		
		/// <summary>
		/// 1:N lk_uomschedulebase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uomschedulebase_createdby")]
		public System.Collections.Generic.IEnumerable<UoMSchedule> lk_uomschedulebase_createdby
		{
			get
			{
				return this.GetRelatedEntities<UoMSchedule>("lk_uomschedulebase_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_uomschedulebase_createdby");
				this.SetRelatedEntities<UoMSchedule>("lk_uomschedulebase_createdby", null, value);
				this.OnPropertyChanged("lk_uomschedulebase_createdby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_uomschedulebase_createdby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_uomschedulebase_createdby");
		}

		
		/// <summary>
		/// 1:N lk_opportunitybase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunitybase_createdby")]
		public System.Collections.Generic.IEnumerable<Opportunity> lk_opportunitybase_createdby
		{
			get
			{
				return this.GetRelatedEntities<Opportunity>("lk_opportunitybase_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_opportunitybase_createdby");
				this.SetRelatedEntities<Opportunity>("lk_opportunitybase_createdby", null, value);
				this.OnPropertyChanged("lk_opportunitybase_createdby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_opportunitybase_createdby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_opportunitybase_createdby");
		}

		
		/// <summary>
		/// 1:N lk_businessunit_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunit_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<BusinessUnit> lk_businessunit_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<BusinessUnit>("lk_businessunit_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_businessunit_createdonbehalfby");
				this.SetRelatedEntities<BusinessUnit>("lk_businessunit_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_businessunit_createdonbehalfby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_businessunit_createdonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_businessunit_createdonbehalfby");
		}

		
		/// <summary>
		/// 1:N lk_team_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_team_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<Team> lk_team_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<Team>("lk_team_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_team_createdonbehalfby");
				this.SetRelatedEntities<Team>("lk_team_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_team_createdonbehalfby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_team_createdonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_team_createdonbehalfby");
		}

		
		/// <summary>
		/// 1:N lk_systemuser_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuser_createdonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<SystemUser> Referencedlk_systemuser_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<SystemUser>("lk_systemuser_createdonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referencedlk_systemuser_createdonbehalfby");
				this.SetRelatedEntities<SystemUser>("lk_systemuser_createdonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedlk_systemuser_createdonbehalfby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_systemuser_createdonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_systemuser_createdonbehalfby");
		}

		
		/// <summary>
		/// 1:N lk_contact_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contact_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<Contact> lk_contact_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<Contact>("lk_contact_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_contact_createdonbehalfby");
				this.SetRelatedEntities<Contact>("lk_contact_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_contact_createdonbehalfby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_contact_createdonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_contact_createdonbehalfby");
		}

		
		/// <summary>
		/// 1:N lk_transactioncurrency_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transactioncurrency_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<TransactionCurrency> lk_transactioncurrency_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TransactionCurrency>("lk_transactioncurrency_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_transactioncurrency_createdonbehalfby");
				this.SetRelatedEntities<TransactionCurrency>("lk_transactioncurrency_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_transactioncurrency_createdonbehalfby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_transactioncurrency_createdonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_transactioncurrency_createdonbehalfby");
		}

		
		/// <summary>
		/// 1:N lk_accountbase_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<Account> lk_accountbase_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<Account>("lk_accountbase_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_accountbase_createdonbehalfby");
				this.SetRelatedEntities<Account>("lk_accountbase_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_accountbase_createdonbehalfby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_accountbase_createdonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_accountbase_createdonbehalfby");
		}

		
		/// <summary>
		/// 1:N lk_lead_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lead_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<Lead> lk_lead_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<Lead>("lk_lead_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_lead_createdonbehalfby");
				this.SetRelatedEntities<Lead>("lk_lead_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_lead_createdonbehalfby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_lead_createdonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_lead_createdonbehalfby");
		}

		
		/// <summary>
		/// 1:N lk_uom_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uom_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<UoM> lk_uom_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<UoM>("lk_uom_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_uom_createdonbehalfby");
				this.SetRelatedEntities<UoM>("lk_uom_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_uom_createdonbehalfby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_uom_createdonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_uom_createdonbehalfby");
		}

		
		/// <summary>
		/// 1:N lk_uomschedule_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uomschedule_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<UoMSchedule> lk_uomschedule_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<UoMSchedule>("lk_uomschedule_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_uomschedule_createdonbehalfby");
				this.SetRelatedEntities<UoMSchedule>("lk_uomschedule_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_uomschedule_createdonbehalfby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_uomschedule_createdonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_uomschedule_createdonbehalfby");
		}

		
		/// <summary>
		/// 1:N lk_opportunity_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunity_createdonbehalfby")]
		public System.Collections.Generic.IEnumerable<Opportunity> lk_opportunity_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<Opportunity>("lk_opportunity_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_opportunity_createdonbehalfby");
				this.SetRelatedEntities<Opportunity>("lk_opportunity_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_opportunity_createdonbehalfby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_opportunity_createdonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_opportunity_createdonbehalfby");
		}

		
		/// <summary>
		/// 1:N lk_teambase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_teambase_modifiedby")]
		public System.Collections.Generic.IEnumerable<Team> lk_teambase_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<Team>("lk_teambase_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_teambase_modifiedby");
				this.SetRelatedEntities<Team>("lk_teambase_modifiedby", null, value);
				this.OnPropertyChanged("lk_teambase_modifiedby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_teambase_modifiedby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_teambase_modifiedby");
		}

		
		/// <summary>
		/// 1:N lk_transactioncurrencybase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transactioncurrencybase_modifiedby")]
		public System.Collections.Generic.IEnumerable<TransactionCurrency> lk_transactioncurrencybase_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<TransactionCurrency>("lk_transactioncurrencybase_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_transactioncurrencybase_modifiedby");
				this.SetRelatedEntities<TransactionCurrency>("lk_transactioncurrencybase_modifiedby", null, value);
				this.OnPropertyChanged("lk_transactioncurrencybase_modifiedby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_transactioncurrencybase_modifiedby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_transactioncurrencybase_modifiedby");
		}

		
		/// <summary>
		/// 1:N lk_systemuserbase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuserbase_modifiedby", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<SystemUser> Referencedlk_systemuserbase_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<SystemUser>("lk_systemuserbase_modifiedby", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referencedlk_systemuserbase_modifiedby");
				this.SetRelatedEntities<SystemUser>("lk_systemuserbase_modifiedby", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedlk_systemuserbase_modifiedby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_systemuserbase_modifiedby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_systemuserbase_modifiedby");
		}

		
		/// <summary>
		/// 1:N lk_accountbase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_modifiedby")]
		public System.Collections.Generic.IEnumerable<Account> lk_accountbase_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<Account>("lk_accountbase_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_accountbase_modifiedby");
				this.SetRelatedEntities<Account>("lk_accountbase_modifiedby", null, value);
				this.OnPropertyChanged("lk_accountbase_modifiedby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_accountbase_modifiedby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_accountbase_modifiedby");
		}

		
		/// <summary>
		/// 1:N lk_businessunitbase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunitbase_modifiedby")]
		public System.Collections.Generic.IEnumerable<BusinessUnit> lk_businessunitbase_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<BusinessUnit>("lk_businessunitbase_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_businessunitbase_modifiedby");
				this.SetRelatedEntities<BusinessUnit>("lk_businessunitbase_modifiedby", null, value);
				this.OnPropertyChanged("lk_businessunitbase_modifiedby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_businessunitbase_modifiedby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_businessunitbase_modifiedby");
		}

		
		/// <summary>
		/// 1:N lk_contactbase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contactbase_modifiedby")]
		public System.Collections.Generic.IEnumerable<Contact> lk_contactbase_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<Contact>("lk_contactbase_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_contactbase_modifiedby");
				this.SetRelatedEntities<Contact>("lk_contactbase_modifiedby", null, value);
				this.OnPropertyChanged("lk_contactbase_modifiedby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_contactbase_modifiedby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_contactbase_modifiedby");
		}

		
		/// <summary>
		/// 1:N lk_leadbase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_leadbase_modifiedby")]
		public System.Collections.Generic.IEnumerable<Lead> lk_leadbase_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<Lead>("lk_leadbase_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_leadbase_modifiedby");
				this.SetRelatedEntities<Lead>("lk_leadbase_modifiedby", null, value);
				this.OnPropertyChanged("lk_leadbase_modifiedby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_leadbase_modifiedby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_leadbase_modifiedby");
		}

		
		/// <summary>
		/// 1:N lk_uombase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uombase_modifiedby")]
		public System.Collections.Generic.IEnumerable<UoM> lk_uombase_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<UoM>("lk_uombase_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_uombase_modifiedby");
				this.SetRelatedEntities<UoM>("lk_uombase_modifiedby", null, value);
				this.OnPropertyChanged("lk_uombase_modifiedby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_uombase_modifiedby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_uombase_modifiedby");
		}

		
		/// <summary>
		/// 1:N lk_uomschedulebase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uomschedulebase_modifiedby")]
		public System.Collections.Generic.IEnumerable<UoMSchedule> lk_uomschedulebase_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<UoMSchedule>("lk_uomschedulebase_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_uomschedulebase_modifiedby");
				this.SetRelatedEntities<UoMSchedule>("lk_uomschedulebase_modifiedby", null, value);
				this.OnPropertyChanged("lk_uomschedulebase_modifiedby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_uomschedulebase_modifiedby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_uomschedulebase_modifiedby");
		}

		
		/// <summary>
		/// 1:N lk_opportunitybase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunitybase_modifiedby")]
		public System.Collections.Generic.IEnumerable<Opportunity> lk_opportunitybase_modifiedby
		{
			get
			{
				return this.GetRelatedEntities<Opportunity>("lk_opportunitybase_modifiedby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_opportunitybase_modifiedby");
				this.SetRelatedEntities<Opportunity>("lk_opportunitybase_modifiedby", null, value);
				this.OnPropertyChanged("lk_opportunitybase_modifiedby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_opportunitybase_modifiedby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_opportunitybase_modifiedby");
		}

		
		/// <summary>
		/// 1:N lk_transactioncurrency_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transactioncurrency_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<TransactionCurrency> lk_transactioncurrency_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<TransactionCurrency>("lk_transactioncurrency_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_transactioncurrency_modifiedonbehalfby");
				this.SetRelatedEntities<TransactionCurrency>("lk_transactioncurrency_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_transactioncurrency_modifiedonbehalfby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_transactioncurrency_modifiedonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_transactioncurrency_modifiedonbehalfby");
		}

		
		/// <summary>
		/// 1:N lk_businessunit_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunit_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<BusinessUnit> lk_businessunit_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<BusinessUnit>("lk_businessunit_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_businessunit_modifiedonbehalfby");
				this.SetRelatedEntities<BusinessUnit>("lk_businessunit_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_businessunit_modifiedonbehalfby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_businessunit_modifiedonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_businessunit_modifiedonbehalfby");
		}

		
		/// <summary>
		/// 1:N lk_team_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_team_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<Team> lk_team_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<Team>("lk_team_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_team_modifiedonbehalfby");
				this.SetRelatedEntities<Team>("lk_team_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_team_modifiedonbehalfby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_team_modifiedonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_team_modifiedonbehalfby");
		}

		
		/// <summary>
		/// 1:N lk_accountbase_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<Account> lk_accountbase_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<Account>("lk_accountbase_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_accountbase_modifiedonbehalfby");
				this.SetRelatedEntities<Account>("lk_accountbase_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_accountbase_modifiedonbehalfby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_accountbase_modifiedonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_accountbase_modifiedonbehalfby");
		}

		
		/// <summary>
		/// 1:N lk_contact_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contact_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<Contact> lk_contact_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<Contact>("lk_contact_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_contact_modifiedonbehalfby");
				this.SetRelatedEntities<Contact>("lk_contact_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_contact_modifiedonbehalfby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_contact_modifiedonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_contact_modifiedonbehalfby");
		}

		
		/// <summary>
		/// 1:N lk_systemuser_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuser_modifiedonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<SystemUser> Referencedlk_systemuser_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<SystemUser>("lk_systemuser_modifiedonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referencedlk_systemuser_modifiedonbehalfby");
				this.SetRelatedEntities<SystemUser>("lk_systemuser_modifiedonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedlk_systemuser_modifiedonbehalfby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_systemuser_modifiedonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_systemuser_modifiedonbehalfby");
		}

		
		/// <summary>
		/// 1:N lk_lead_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lead_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<Lead> lk_lead_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<Lead>("lk_lead_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_lead_modifiedonbehalfby");
				this.SetRelatedEntities<Lead>("lk_lead_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_lead_modifiedonbehalfby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_lead_modifiedonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_lead_modifiedonbehalfby");
		}

		
		/// <summary>
		/// 1:N lk_uom_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uom_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<UoM> lk_uom_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<UoM>("lk_uom_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_uom_modifiedonbehalfby");
				this.SetRelatedEntities<UoM>("lk_uom_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_uom_modifiedonbehalfby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_uom_modifiedonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_uom_modifiedonbehalfby");
		}

		
		/// <summary>
		/// 1:N lk_uomschedule_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uomschedule_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<UoMSchedule> lk_uomschedule_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<UoMSchedule>("lk_uomschedule_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_uomschedule_modifiedonbehalfby");
				this.SetRelatedEntities<UoMSchedule>("lk_uomschedule_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_uomschedule_modifiedonbehalfby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_uomschedule_modifiedonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_uomschedule_modifiedonbehalfby");
		}

		
		/// <summary>
		/// 1:N lk_opportunity_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunity_modifiedonbehalfby")]
		public System.Collections.Generic.IEnumerable<Opportunity> lk_opportunity_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntities<Opportunity>("lk_opportunity_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_opportunity_modifiedonbehalfby");
				this.SetRelatedEntities<Opportunity>("lk_opportunity_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_opportunity_modifiedonbehalfby");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lk_opportunity_modifiedonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_opportunity_modifiedonbehalfby");
		}

		
		/// <summary>
		/// 1:N msdyn_accountmanager_opportunity
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_accountmanager_opportunity")]
		public System.Collections.Generic.IEnumerable<Opportunity> msdyn_accountmanager_opportunity
		{
			get
			{
				return this.GetRelatedEntities<Opportunity>("msdyn_accountmanager_opportunity", null);
			}
			set
			{
				this.OnPropertyChanging("msdyn_accountmanager_opportunity");
				this.SetRelatedEntities<Opportunity>("msdyn_accountmanager_opportunity", null, value);
				this.OnPropertyChanged("msdyn_accountmanager_opportunity");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_msdyn_accountmanager_opportunity(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "msdyn_accountmanager_opportunity");
		}

		
		/// <summary>
		/// 1:N user_accounts
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_accounts")]
		public System.Collections.Generic.IEnumerable<Account> user_accounts
		{
			get
			{
				return this.GetRelatedEntities<Account>("user_accounts", null);
			}
			set
			{
				this.OnPropertyChanging("user_accounts");
				this.SetRelatedEntities<Account>("user_accounts", null, value);
				this.OnPropertyChanged("user_accounts");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_user_accounts(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "user_accounts");
		}

		
		/// <summary>
		/// 1:N contact_owning_user
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_owning_user")]
		public System.Collections.Generic.IEnumerable<Contact> contact_owning_user
		{
			get
			{
				return this.GetRelatedEntities<Contact>("contact_owning_user", null);
			}
			set
			{
				this.OnPropertyChanging("contact_owning_user");
				this.SetRelatedEntities<Contact>("contact_owning_user", null, value);
				this.OnPropertyChanged("contact_owning_user");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_contact_owning_user(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "contact_owning_user");
		}

		
		/// <summary>
		/// 1:N lead_owning_user
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_owning_user")]
		public System.Collections.Generic.IEnumerable<Lead> lead_owning_user
		{
			get
			{
				return this.GetRelatedEntities<Lead>("lead_owning_user", null);
			}
			set
			{
				this.OnPropertyChanging("lead_owning_user");
				this.SetRelatedEntities<Lead>("lead_owning_user", null, value);
				this.OnPropertyChanged("lead_owning_user");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lead_owning_user(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lead_owning_user");
		}

		
		/// <summary>
		/// 1:N opportunity_owning_user
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_owning_user")]
		public System.Collections.Generic.IEnumerable<Opportunity> opportunity_owning_user
		{
			get
			{
				return this.GetRelatedEntities<Opportunity>("opportunity_owning_user", null);
			}
			set
			{
				this.OnPropertyChanging("opportunity_owning_user");
				this.SetRelatedEntities<Opportunity>("opportunity_owning_user", null, value);
				this.OnPropertyChanged("opportunity_owning_user");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_opportunity_owning_user(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "opportunity_owning_user");
		}

		
		/// <summary>
		/// 1:N user_parent_user
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<SystemUser> Referenceduser_parent_user
		{
			get
			{
				return this.GetRelatedEntities<SystemUser>("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referenceduser_parent_user");
				this.SetRelatedEntities<SystemUser>("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referenceduser_parent_user");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_user_parent_user(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "user_parent_user");
		}

		
		/// <summary>
		/// 1:N system_user_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_activity_parties")]
		public System.Collections.Generic.IEnumerable<ActivityParty> system_user_activity_parties
		{
			get
			{
				return this.GetRelatedEntities<ActivityParty>("system_user_activity_parties", null);
			}
			set
			{
				this.OnPropertyChanging("system_user_activity_parties");
				this.SetRelatedEntities<ActivityParty>("system_user_activity_parties", null, value);
				this.OnPropertyChanged("system_user_activity_parties");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_system_user_activity_parties(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "system_user_activity_parties");
		}

		
		/// <summary>
		/// 1:N system_user_contacts
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_contacts")]
		public System.Collections.Generic.IEnumerable<Contact> system_user_contacts
		{
			get
			{
				return this.GetRelatedEntities<Contact>("system_user_contacts", null);
			}
			set
			{
				this.OnPropertyChanging("system_user_contacts");
				this.SetRelatedEntities<Contact>("system_user_contacts", null, value);
				this.OnPropertyChanged("system_user_contacts");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_system_user_contacts(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "system_user_contacts");
		}

		
		/// <summary>
		/// 1:N system_user_accounts
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_accounts")]
		public System.Collections.Generic.IEnumerable<Account> system_user_accounts
		{
			get
			{
				return this.GetRelatedEntities<Account>("system_user_accounts", null);
			}
			set
			{
				this.OnPropertyChanging("system_user_accounts");
				this.SetRelatedEntities<Account>("system_user_accounts", null, value);
				this.OnPropertyChanged("system_user_accounts");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_system_user_accounts(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "system_user_accounts");
		}

		
		/// <summary>
		/// 1:N urb_systemuser_opportunity
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("urb_systemuser_opportunity")]
		public System.Collections.Generic.IEnumerable<Opportunity> urb_systemuser_opportunity
		{
			get
			{
				return this.GetRelatedEntities<Opportunity>("urb_systemuser_opportunity", null);
			}
			set
			{
				this.OnPropertyChanging("urb_systemuser_opportunity");
				this.SetRelatedEntities<Opportunity>("urb_systemuser_opportunity", null, value);
				this.OnPropertyChanged("urb_systemuser_opportunity");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_urb_systemuser_opportunity(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "urb_systemuser_opportunity");
		}

		
		/// <summary>
		/// N:1 business_unit_system_users
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_system_users")]
		public BusinessUnit business_unit_system_users
		{
			get
			{
				return this.GetRelatedEntity<BusinessUnit>("business_unit_system_users", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_system_users");
				this.SetRelatedEntity<BusinessUnit>("business_unit_system_users", null, value);
				this.OnPropertyChanged("business_unit_system_users");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_business_unit_system_users(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "business_unit_system_users");
		}

		
		/// <summary>
		/// N:1 lk_systemuserbase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuserbase_createdby", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public SystemUser Referencinglk_systemuserbase_createdby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_systemuserbase_createdby", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_systemuserbase_createdby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_systemuserbase_createdby");
		}

		
		/// <summary>
		/// N:1 lk_systemuser_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuser_createdonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public SystemUser Referencinglk_systemuser_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_systemuser_createdonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_systemuser_createdonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_systemuser_createdonbehalfby");
		}

		
		/// <summary>
		/// N:1 lk_systemuserbase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuserbase_modifiedby", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public SystemUser Referencinglk_systemuserbase_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_systemuserbase_modifiedby", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_systemuserbase_modifiedby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_systemuserbase_modifiedby");
		}

		
		/// <summary>
		/// N:1 lk_systemuser_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuser_modifiedonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public SystemUser Referencinglk_systemuser_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_systemuser_modifiedonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_systemuser_modifiedonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_systemuser_modifiedonbehalfby");
		}

		
		/// <summary>
		/// N:1 user_parent_user
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentsystemuserid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public SystemUser Referencinguser_parent_user
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
			set
			{
				this.OnPropertyChanging("Referencinguser_parent_user");
				this.SetRelatedEntity<SystemUser>("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
				this.OnPropertyChanged("Referencinguser_parent_user");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_user_parent_user(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "user_parent_user");
		}

		
		/// <summary>
		/// N:1 TransactionCurrency_SystemUser
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_SystemUser")]
		public TransactionCurrency TransactionCurrency_SystemUser
		{
			get
			{
				return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_SystemUser", null);
			}
			set
			{
				this.OnPropertyChanging("TransactionCurrency_SystemUser");
				this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_SystemUser", null, value);
				this.OnPropertyChanged("TransactionCurrency_SystemUser");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_TransactionCurrency_SystemUser(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "TransactionCurrency_SystemUser");
		}

		
		/// <summary>
		/// N:N teammembership_association
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("teammembership_association")]
		public System.Collections.Generic.IEnumerable<Team> teammembership_association
		{
			get
			{
				return this.GetRelatedEntities<Team>("teammembership_association", null);
			}
			set
			{
				this.OnPropertyChanging("teammembership_association");
				this.SetRelatedEntities<Team>("teammembership_association", null, value);
				this.OnPropertyChanged("teammembership_association");
			}
		}
		/// <summary>
		/// Loads this N:N relationship into the object 
		/// </summary>
        public void Load_teammembership_association(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "teammembership_association");
		}




		public class Enums 
		{
			[DataContractAttribute]
			public enum AccessMode 
			{
				[EnumMemberAttribute]
				LeituraGravacao = 0,
				[EnumMemberAttribute]
				Administrativo = 1,
				[EnumMemberAttribute]
				Leitura = 2,
				[EnumMemberAttribute]
				SuporteaoUsuario = 3,
				[EnumMemberAttribute]
				NaoInterativo = 4,
				[EnumMemberAttribute]
				AdministradorDelegado = 5,
			}		
			[DataContractAttribute]
			public enum Address1_AddressTypeCode 
			{
				[EnumMemberAttribute]
				ValorPadrao = 1,
			}		
			[DataContractAttribute]
			public enum Address1_ShippingMethodCode 
			{
				[EnumMemberAttribute]
				ValorPadrao = 1,
			}		
			[DataContractAttribute]
			public enum Address2_AddressTypeCode 
			{
				[EnumMemberAttribute]
				ValorPadrao = 1,
			}		
			[DataContractAttribute]
			public enum Address2_ShippingMethodCode 
			{
				[EnumMemberAttribute]
				ValorPadrao = 1,
			}		
			[DataContractAttribute]
			public enum CALType 
			{
				[EnumMemberAttribute]
				Profissional = 0,
				[EnumMemberAttribute]
				Administrativo = 1,
				[EnumMemberAttribute]
				Basico = 2,
				[EnumMemberAttribute]
				ProfissionaldeDispositivo = 3,
				[EnumMemberAttribute]
				DispositivoBasico = 4,
				[EnumMemberAttribute]
				Essencial = 5,
				[EnumMemberAttribute]
				DispositivoEssencial = 6,
				[EnumMemberAttribute]
				Empresa = 7,
				[EnumMemberAttribute]
				EmpresadeDispositivos = 8,
				[EnumMemberAttribute]
				Vendas = 9,
				[EnumMemberAttribute]
				Servico = 10,
				[EnumMemberAttribute]
				FieldService = 11,
				[EnumMemberAttribute]
				ProjectService = 12,
			}		
			[DataContractAttribute]
			public enum DefaultFiltersPopulated 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum DisplayInServiceViews 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum EmailRouterAccessApproval 
			{
				[EnumMemberAttribute]
				Vazio = 0,
				[EnumMemberAttribute]
				Aprovado = 1,
				[EnumMemberAttribute]
				AprovacaoPendente = 2,
				[EnumMemberAttribute]
				Rejeitado = 3,
			}		
			[DataContractAttribute]
			public enum IncomingEmailDeliveryMethod 
			{
				[EnumMemberAttribute]
				Nenhum = 0,
				[EnumMemberAttribute]
				MicrosoftDynamicsCRMparaOutlook = 1,
				[EnumMemberAttribute]
				EmailRouter = 2,
				[EnumMemberAttribute]
				CaixadeCorreioparaEncaminhamento = 3,
			}		
			[DataContractAttribute]
			public enum InviteStatusCode 
			{
				[EnumMemberAttribute]
				ConvitenaoEnviado = 0,
				[EnumMemberAttribute]
				Convidado = 1,
				[EnumMemberAttribute]
				ConviteQuaseVencido = 2,
				[EnumMemberAttribute]
				ConviteVencido = 3,
				[EnumMemberAttribute]
				ConviteAceito = 4,
				[EnumMemberAttribute]
				ConviteRecusado = 5,
				[EnumMemberAttribute]
				ConviteRevogado = 6,
			}		
			[DataContractAttribute]
			public enum IsActiveDirectoryUser 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum IsDisabled 
			{
				[EnumMemberAttribute]
				Desabilitado = 1,
				[EnumMemberAttribute]
				Habilitado = 0,
			}		
			[DataContractAttribute]
			public enum IsEmailAddressApprovedByO365Admin 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum IsIntegrationUser 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum IsLicensed 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum IsSyncWithDirectory 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum OutgoingEmailDeliveryMethod 
			{
				[EnumMemberAttribute]
				Nenhum = 0,
				[EnumMemberAttribute]
				MicrosoftDynamicsCRMparaOutlook = 1,
				[EnumMemberAttribute]
				EmailRouter = 2,
			}		
			[DataContractAttribute]
			public enum PreferredAddressCode 
			{
				[EnumMemberAttribute]
				EnderecoparaCorrespondencia = 1,
				[EnumMemberAttribute]
				OutroEndereco = 2,
			}		
			[DataContractAttribute]
			public enum PreferredEmailCode 
			{
				[EnumMemberAttribute]
				ValorPadrao = 1,
			}		
			[DataContractAttribute]
			public enum PreferredPhoneCode 
			{
				[EnumMemberAttribute]
				TelefonePrincipal = 1,
				[EnumMemberAttribute]
				OutroTelefone = 2,
				[EnumMemberAttribute]
				TelefoneResidencial = 3,
				[EnumMemberAttribute]
				TelefoneCelular = 4,
			}		
			[DataContractAttribute]
			public enum SetupUser 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum urb_notifica_pendencia_oportunidade 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
	}


		public class OneToMany
		{
			public const string lk_teambase_administratorid = "lk_teambase_administratorid";
			public const string lk_teambase_createdby = "lk_teambase_createdby";
			public const string lk_contactbase_createdby = "lk_contactbase_createdby";
			public const string lk_accountbase_createdby = "lk_accountbase_createdby";
			public const string lk_transactioncurrencybase_createdby = "lk_transactioncurrencybase_createdby";
			public const string lk_systemuserbase_createdby = "lk_systemuserbase_createdby";
			public const string lk_businessunitbase_createdby = "lk_businessunitbase_createdby";
			public const string lk_leadbase_createdby = "lk_leadbase_createdby";
			public const string lk_uombase_createdby = "lk_uombase_createdby";
			public const string lk_uomschedulebase_createdby = "lk_uomschedulebase_createdby";
			public const string lk_opportunitybase_createdby = "lk_opportunitybase_createdby";
			public const string lk_businessunit_createdonbehalfby = "lk_businessunit_createdonbehalfby";
			public const string lk_team_createdonbehalfby = "lk_team_createdonbehalfby";
			public const string lk_systemuser_createdonbehalfby = "lk_systemuser_createdonbehalfby";
			public const string lk_contact_createdonbehalfby = "lk_contact_createdonbehalfby";
			public const string lk_transactioncurrency_createdonbehalfby = "lk_transactioncurrency_createdonbehalfby";
			public const string lk_accountbase_createdonbehalfby = "lk_accountbase_createdonbehalfby";
			public const string lk_lead_createdonbehalfby = "lk_lead_createdonbehalfby";
			public const string lk_uom_createdonbehalfby = "lk_uom_createdonbehalfby";
			public const string lk_uomschedule_createdonbehalfby = "lk_uomschedule_createdonbehalfby";
			public const string lk_opportunity_createdonbehalfby = "lk_opportunity_createdonbehalfby";
			public const string lk_teambase_modifiedby = "lk_teambase_modifiedby";
			public const string lk_transactioncurrencybase_modifiedby = "lk_transactioncurrencybase_modifiedby";
			public const string lk_systemuserbase_modifiedby = "lk_systemuserbase_modifiedby";
			public const string lk_accountbase_modifiedby = "lk_accountbase_modifiedby";
			public const string lk_businessunitbase_modifiedby = "lk_businessunitbase_modifiedby";
			public const string lk_contactbase_modifiedby = "lk_contactbase_modifiedby";
			public const string lk_leadbase_modifiedby = "lk_leadbase_modifiedby";
			public const string lk_uombase_modifiedby = "lk_uombase_modifiedby";
			public const string lk_uomschedulebase_modifiedby = "lk_uomschedulebase_modifiedby";
			public const string lk_opportunitybase_modifiedby = "lk_opportunitybase_modifiedby";
			public const string lk_transactioncurrency_modifiedonbehalfby = "lk_transactioncurrency_modifiedonbehalfby";
			public const string lk_businessunit_modifiedonbehalfby = "lk_businessunit_modifiedonbehalfby";
			public const string lk_team_modifiedonbehalfby = "lk_team_modifiedonbehalfby";
			public const string lk_accountbase_modifiedonbehalfby = "lk_accountbase_modifiedonbehalfby";
			public const string lk_contact_modifiedonbehalfby = "lk_contact_modifiedonbehalfby";
			public const string lk_systemuser_modifiedonbehalfby = "lk_systemuser_modifiedonbehalfby";
			public const string lk_lead_modifiedonbehalfby = "lk_lead_modifiedonbehalfby";
			public const string lk_uom_modifiedonbehalfby = "lk_uom_modifiedonbehalfby";
			public const string lk_uomschedule_modifiedonbehalfby = "lk_uomschedule_modifiedonbehalfby";
			public const string lk_opportunity_modifiedonbehalfby = "lk_opportunity_modifiedonbehalfby";
			public const string msdyn_accountmanager_opportunity = "msdyn_accountmanager_opportunity";
			public const string user_accounts = "user_accounts";
			public const string contact_owning_user = "contact_owning_user";
			public const string lead_owning_user = "lead_owning_user";
			public const string opportunity_owning_user = "opportunity_owning_user";
			public const string user_parent_user = "user_parent_user";
			public const string system_user_activity_parties = "system_user_activity_parties";
			public const string system_user_contacts = "system_user_contacts";
			public const string system_user_accounts = "system_user_accounts";
			public const string urb_systemuser_opportunity = "urb_systemuser_opportunity";
}
		public class ManyToMany
		{
			public const string teammembership_association = "teammembership_association";
}

		public class Fields
		{
			public const string SchemaName = "systemuser";
			
			public const string AccessMode = "accessmode";
			public const string ActiveDirectoryGuid = "activedirectoryguid";
			public const string Address1_AddressId = "address1_addressid";
			public const string Address1_AddressTypeCode = "address1_addresstypecode";
			public const string Address1_City = "address1_city";
			public const string Address1_Composite = "address1_composite";
			public const string Address1_Country = "address1_country";
			public const string Address1_County = "address1_county";
			public const string Address1_Fax = "address1_fax";
			public const string Address1_Latitude = "address1_latitude";
			public const string Address1_Line1 = "address1_line1";
			public const string Address1_Line2 = "address1_line2";
			public const string Address1_Line3 = "address1_line3";
			public const string Address1_Longitude = "address1_longitude";
			public const string Address1_Name = "address1_name";
			public const string Address1_PostalCode = "address1_postalcode";
			public const string Address1_PostOfficeBox = "address1_postofficebox";
			public const string Address1_ShippingMethodCode = "address1_shippingmethodcode";
			public const string Address1_StateOrProvince = "address1_stateorprovince";
			public const string Address1_Telephone1 = "address1_telephone1";
			public const string Address1_Telephone2 = "address1_telephone2";
			public const string Address1_Telephone3 = "address1_telephone3";
			public const string Address1_UPSZone = "address1_upszone";
			public const string Address1_UTCOffset = "address1_utcoffset";
			public const string Address2_AddressId = "address2_addressid";
			public const string Address2_AddressTypeCode = "address2_addresstypecode";
			public const string Address2_City = "address2_city";
			public const string Address2_Composite = "address2_composite";
			public const string Address2_Country = "address2_country";
			public const string Address2_County = "address2_county";
			public const string Address2_Fax = "address2_fax";
			public const string Address2_Latitude = "address2_latitude";
			public const string Address2_Line1 = "address2_line1";
			public const string Address2_Line2 = "address2_line2";
			public const string Address2_Line3 = "address2_line3";
			public const string Address2_Longitude = "address2_longitude";
			public const string Address2_Name = "address2_name";
			public const string Address2_PostalCode = "address2_postalcode";
			public const string Address2_PostOfficeBox = "address2_postofficebox";
			public const string Address2_ShippingMethodCode = "address2_shippingmethodcode";
			public const string Address2_StateOrProvince = "address2_stateorprovince";
			public const string Address2_Telephone1 = "address2_telephone1";
			public const string Address2_Telephone2 = "address2_telephone2";
			public const string Address2_Telephone3 = "address2_telephone3";
			public const string Address2_UPSZone = "address2_upszone";
			public const string Address2_UTCOffset = "address2_utcoffset";
			public const string ApplicationId = "applicationid";
			public const string ApplicationIdUri = "applicationiduri";
			public const string AzureActiveDirectoryObjectId = "azureactivedirectoryobjectid";
			public const string BusinessUnitId = "businessunitid";
			public const string BusinessUnitIdName = "businessunitidName";
			public const string CalendarId = "calendarid";
			public const string CalendarIdName = "calendaridName";
			public const string CALType = "caltype";
			public const string CreatedBy = "createdby";
			public const string CreatedByName = "createdbyName";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CreatedOnBehalfByName = "createdonbehalfbyName";
			public const string DefaultFiltersPopulated = "defaultfilterspopulated";
			public const string DefaultMailbox = "defaultmailbox";
			public const string DefaultMailboxName = "defaultmailboxName";
			public const string DefaultOdbFolderName = "defaultodbfoldername";
			public const string DisabledReason = "disabledreason";
			public const string DisplayInServiceViews = "displayinserviceviews";
			public const string DomainName = "domainname";
			public const string EmailRouterAccessApproval = "emailrouteraccessapproval";
			public const string EmployeeId = "employeeid";
			public const string EntityImage = "entityimage";
			public const string EntityImage_Timestamp = "entityimage_timestamp";
			public const string EntityImage_URL = "entityimage_url";
			public const string EntityImageId = "entityimageid";
			public const string ExchangeRate = "exchangerate";
			public const string FirstName = "firstname";
			public const string FullName = "fullname";
			public const string GovernmentId = "governmentid";
			public const string HomePhone = "homephone";
			public const string IdentityId = "identityid";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string IncomingEmailDeliveryMethod = "incomingemaildeliverymethod";
			public const string InternalEMailAddress = "internalemailaddress";
			public const string InviteStatusCode = "invitestatuscode";
			public const string IsActiveDirectoryUser = "isactivedirectoryuser";
			public const string IsDisabled = "isdisabled";
			public const string IsEmailAddressApprovedByO365Admin = "isemailaddressapprovedbyo365admin";
			public const string IsIntegrationUser = "isintegrationuser";
			public const string IsLicensed = "islicensed";
			public const string IsSyncWithDirectory = "issyncwithdirectory";
			public const string JobTitle = "jobtitle";
			public const string LastName = "lastname";
			public const string LatestUpdateTime = "latestupdatetime";
			public const string MiddleName = "middlename";
			public const string MobileAlertEMail = "mobilealertemail";
			public const string MobileOfflineProfileId = "mobileofflineprofileid";
			public const string MobileOfflineProfileIdName = "mobileofflineprofileidName";
			public const string MobilePhone = "mobilephone";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedByName = "modifiedbyName";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string ModifiedOnBehalfByName = "modifiedonbehalfbyName";
			public const string NickName = "nickname";
			public const string OrganizationId = "organizationid";
			public const string OutgoingEmailDeliveryMethod = "outgoingemaildeliverymethod";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string ParentSystemUserId = "parentsystemuserid";
			public const string ParentSystemUserIdName = "parentsystemuseridName";
			public const string PassportHi = "passporthi";
			public const string PassportLo = "passportlo";
			public const string PersonalEMailAddress = "personalemailaddress";
			public const string PhotoUrl = "photourl";
			public const string PositionId = "positionid";
			public const string PositionIdName = "positionidName";
			public const string PreferredAddressCode = "preferredaddresscode";
			public const string PreferredEmailCode = "preferredemailcode";
			public const string PreferredPhoneCode = "preferredphonecode";
			public const string ProcessId = "processid";
			public const string QueueId = "queueid";
			public const string QueueIdName = "queueidName";
			public const string Salutation = "salutation";
			public const string SetupUser = "setupuser";
			public const string SharePointEmailAddress = "sharepointemailaddress";
			public const string SiteId = "siteid";
			public const string SiteIdName = "siteidName";
			public const string Skills = "skills";
			public const string StageId = "stageid";
			public const string SystemUserId = "systemuserid";
			public const string TerritoryId = "territoryid";
			public const string TerritoryIdName = "territoryidName";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string Title = "title";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string TransactionCurrencyIdName = "transactioncurrencyidName";
			public const string TraversedPath = "traversedpath";
			public const string urb_LojaId = "urb_lojaid";
			public const string urb_LojaIdName = "urb_lojaidName";
			public const string urb_notifica_pendencia_oportunidade = "urb_notifica_pendencia_oportunidade";
			public const string urb_observacoes = "urb_observacoes";
			public const string UserLicenseType = "userlicensetype";
			public const string UserPuid = "userpuid";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
			public const string WindowsLiveID = "windowsliveid";
			public const string YammerEmailAddress = "yammeremailaddress";
			public const string YammerUserId = "yammeruserid";
			public const string YomiFirstName = "yomifirstname";
			public const string YomiFullName = "yomifullname";
			public const string YomiLastName = "yomilastname";
			public const string YomiMiddleName = "yomimiddlename";
		}
	}

	/// <summary>
	/// Grupo de usuários do sistema que colaboram rotineiramente. Equipes podem ser utilizadas para simplificar o compartilhamento de registros e fornecer aos membros da equipe um acesso comum aos dados da organização, quando esses membros de equipe pertencerem a diferentes Divisões.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("team")]
	public partial class Team : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public Team() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "team";
		
		public const int EntityTypeCode = 9;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.TeamId = value;
			}
		}
		/// <summary>
		/// Identificador exclusivo do usuário principal responsável pela equipe.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("administratorid")]
		public Microsoft.Xrm.Sdk.EntityReference AdministratorId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("administratorid");
			}
			set
			{
				this.OnPropertyChanging("AdministratorId");
				this.SetAttributeValue("administratorid", value);
				this.OnPropertyChanged("AdministratorId");
			}
		}
	



		/// <summary>
		/// Identificador exclusivo da unidade de negócios à qual a equipe está associada.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
		public Microsoft.Xrm.Sdk.EntityReference BusinessUnitId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("businessunitid");
			}
			set
			{
				this.OnPropertyChanging("BusinessUnitId");
				this.SetAttributeValue("businessunitid", value);
				this.OnPropertyChanged("BusinessUnitId");
			}
		}
	



		/// <summary>
		/// Identificador exclusivo do usuário que criou a equipe.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
	



		/// <summary>
		/// Data e hora em que a equipe foi criada.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo do usuário delegado que criou a equipe.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
	



		/// <summary>
		/// Descrição da equipe.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			set
			{
				this.OnPropertyChanging("Description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("Description");
			}
		}
	


		/// <summary>
		/// Endereço de email da equipe.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress")]
		public string EMailAddress
		{
			get
			{
				return this.GetAttributeValue<string>("emailaddress");
			}
			set
			{
				this.OnPropertyChanging("EMailAddress");
				this.SetAttributeValue("emailaddress", value);
				this.OnPropertyChanged("EMailAddress");
			}
		}
	


		/// <summary>
		/// Taxa de câmbio da moeda associada à equipe com relação à moeda base.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
		public System.Nullable<decimal> ExchangeRate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo da importação de dados ou migração de dados que criou este registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
	


		/// <summary>
		/// Informação que especifica se a equipe é uma equipe de unidade empresarial padrão.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdefault")]
		public System.Nullable<bool> IsDefault
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isdefault");
			}
		}
	
		public virtual Enums.IsDefault? IsDefaultEnum
		{
			get
			{
				return ((Enums.IsDefault?)(EntityOptionSetEnum.GetEnum(this, "isdefault")));
			}
		}


		/// <summary>
		/// Identificador exclusivo do usuário que modificou a equipe por último.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
	



		/// <summary>
		/// Data e hora da última modificação da equipe.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo do usuário delegado que modificou a equipe pela última vez.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
	



		/// <summary>
		/// Nome da equipe.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			set
			{
				this.OnPropertyChanging("Name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("Name");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo da organização associada à equipe.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public System.Nullable<System.Guid> OrganizationId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("organizationid");
			}
		}
	


		/// <summary>
		/// Data e hora da migração do registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
	


		/// <summary>
		/// Mostra a ID do processo.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
		public System.Nullable<System.Guid> ProcessId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("processid");
			}
			set
			{
				this.OnPropertyChanging("ProcessId");
				this.SetAttributeValue("processid", value);
				this.OnPropertyChanged("ProcessId");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo da fila padrão da equipe.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queueid")]
		public Microsoft.Xrm.Sdk.EntityReference QueueId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("queueid");
			}
			set
			{
				this.OnPropertyChanging("QueueId");
				this.SetAttributeValue("queueid", value);
				this.OnPropertyChanged("QueueId");
			}
		}
	



		/// <summary>
		/// Escolha o registro ao qual a equipe está relacionada.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		public Microsoft.Xrm.Sdk.EntityReference RegardingObjectId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("regardingobjectid");
			}
			set
			{
				this.OnPropertyChanging("RegardingObjectId");
				this.SetAttributeValue("regardingobjectid", value);
				this.OnPropertyChanged("RegardingObjectId");
			}
		}
	




		/// <summary>
		/// Mostra a ID do estágio.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
		public System.Nullable<System.Guid> StageId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("stageid");
			}
			set
			{
				this.OnPropertyChanging("StageId");
				this.SetAttributeValue("stageid", value);
				this.OnPropertyChanged("StageId");
			}
		}
	


		/// <summary>
		/// Escolha se a equipe será gerenciada pelo sistema.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemmanaged")]
		public System.Nullable<bool> SystemManaged
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("systemmanaged");
			}
		}
	
		public virtual Enums.SystemManaged? SystemManagedEnum
		{
			get
			{
				return ((Enums.SystemManaged?)(EntityOptionSetEnum.GetEnum(this, "systemmanaged")));
			}
		}


		/// <summary>
		/// Identificador exclusivo da equipe.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamid")]
		public System.Nullable<System.Guid> TeamId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("teamid");
			}
			set
			{
				this.OnPropertyChanging("TeamId");
				this.SetAttributeValue("teamid", value);
						if (value.HasValue)
						{
							base.Id = value.Value;
						}
						else
						{
							base.Id = System.Guid.Empty;
						}
				this.OnPropertyChanged("TeamId");
			}
		}
	


		/// <summary>
		/// Mostra o modelo de equipe associado à equipe.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamtemplateid")]
		public Microsoft.Xrm.Sdk.EntityReference TeamTemplateId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("teamtemplateid");
			}
			set
			{
				this.OnPropertyChanging("TeamTemplateId");
				this.SetAttributeValue("teamtemplateid", value);
				this.OnPropertyChanged("TeamTemplateId");
			}
		}
	



		/// <summary>
		/// Escolha o tipo de equipe.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamtype")]
		public Microsoft.Xrm.Sdk.OptionSetValue TeamType
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("teamtype");
			}
			set
			{
				this.OnPropertyChanging("TeamType");
				this.SetAttributeValue("teamtype", value);
				this.OnPropertyChanged("TeamType");
			}
		}
	
		public virtual Enums.TeamType? TeamTypeEnum
		{
			get
			{
				return ((Enums.TeamType?)(EntityOptionSetEnum.GetEnum(this, "teamtype")));
			}
			set
			{
				TeamType = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}


		/// <summary>
		/// Identificador exclusivo da moeda associada à equipe.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
			}
			set
			{
				this.OnPropertyChanging("TransactionCurrencyId");
				this.SetAttributeValue("transactioncurrencyid", value);
				this.OnPropertyChanged("TransactionCurrencyId");
			}
		}
	



		/// <summary>
		/// Apenas para uso interno.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traversedpath")]
		public string TraversedPath
		{
			get
			{
				return this.GetAttributeValue<string>("traversedpath");
			}
			set
			{
				this.OnPropertyChanging("TraversedPath");
				this.SetAttributeValue("traversedpath", value);
				this.OnPropertyChanged("TraversedPath");
			}
		}
	


		/// <summary>
		/// Indica que a equipe permite criação de ocorrências e tarefas com todos os assuntos não sendo necessário associar assuntos especificos
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("urb_permite_todos_assuntos")]
		public System.Nullable<bool> urb_permite_todos_assuntos
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("urb_permite_todos_assuntos");
			}
			set
			{
				this.OnPropertyChanging("urb_permite_todos_assuntos");
				this.SetAttributeValue("urb_permite_todos_assuntos", value);
				this.OnPropertyChanged("urb_permite_todos_assuntos");
			}
		}
	
		public virtual Enums.urb_permite_todos_assuntos? urb_permite_todos_assuntosEnum
		{
			get
			{
				return ((Enums.urb_permite_todos_assuntos?)(EntityOptionSetEnum.GetEnum(this, "urb_permite_todos_assuntos")));
			}
			set
			{
		       if (value.HasValue)
                    urb_permite_todos_assuntos = ((int)value == 1);
                else                   
                    urb_permite_todos_assuntos = null;
			}
		}


		/// <summary>
		/// Número da versão da equipe.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
	


		/// <summary>
		/// Pronúncia do nome completo da equipe, escrito em caracteres fonéticos hiragana ou katakana.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yominame")]
		public string YomiName
		{
			get
			{
				return this.GetAttributeValue<string>("yominame");
			}
			set
			{
				this.OnPropertyChanging("YomiName");
				this.SetAttributeValue("yominame", value);
				this.OnPropertyChanged("YomiName");
			}
		}
	


		
		/// <summary>
		/// 1:N team_contacts
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_contacts")]
		public System.Collections.Generic.IEnumerable<Contact> team_contacts
		{
			get
			{
				return this.GetRelatedEntities<Contact>("team_contacts", null);
			}
			set
			{
				this.OnPropertyChanging("team_contacts");
				this.SetRelatedEntities<Contact>("team_contacts", null, value);
				this.OnPropertyChanged("team_contacts");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_team_contacts(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "team_contacts");
		}

		
		/// <summary>
		/// 1:N team_accounts
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_accounts")]
		public System.Collections.Generic.IEnumerable<Account> team_accounts
		{
			get
			{
				return this.GetRelatedEntities<Account>("team_accounts", null);
			}
			set
			{
				this.OnPropertyChanging("team_accounts");
				this.SetRelatedEntities<Account>("team_accounts", null, value);
				this.OnPropertyChanged("team_accounts");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_team_accounts(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "team_accounts");
		}

		
		/// <summary>
		/// 1:N lead_owning_team
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_owning_team")]
		public System.Collections.Generic.IEnumerable<Lead> lead_owning_team
		{
			get
			{
				return this.GetRelatedEntities<Lead>("lead_owning_team", null);
			}
			set
			{
				this.OnPropertyChanging("lead_owning_team");
				this.SetRelatedEntities<Lead>("lead_owning_team", null, value);
				this.OnPropertyChanged("lead_owning_team");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_lead_owning_team(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lead_owning_team");
		}

		
		/// <summary>
		/// 1:N team_opportunities
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_opportunities")]
		public System.Collections.Generic.IEnumerable<Opportunity> team_opportunities
		{
			get
			{
				return this.GetRelatedEntities<Opportunity>("team_opportunities", null);
			}
			set
			{
				this.OnPropertyChanging("team_opportunities");
				this.SetRelatedEntities<Opportunity>("team_opportunities", null, value);
				this.OnPropertyChanged("team_opportunities");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_team_opportunities(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "team_opportunities");
		}

		
		/// <summary>
		/// N:1 lk_teambase_administratorid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("administratorid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_teambase_administratorid")]
		public SystemUser lk_teambase_administratorid
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_teambase_administratorid", null);
			}
			set
			{
				this.OnPropertyChanging("lk_teambase_administratorid");
				this.SetRelatedEntity<SystemUser>("lk_teambase_administratorid", null, value);
				this.OnPropertyChanged("lk_teambase_administratorid");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_teambase_administratorid(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_teambase_administratorid");
		}

		
		/// <summary>
		/// N:1 business_unit_teams
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_teams")]
		public BusinessUnit business_unit_teams
		{
			get
			{
				return this.GetRelatedEntity<BusinessUnit>("business_unit_teams", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_teams");
				this.SetRelatedEntity<BusinessUnit>("business_unit_teams", null, value);
				this.OnPropertyChanged("business_unit_teams");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_business_unit_teams(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "business_unit_teams");
		}

		
		/// <summary>
		/// N:1 lk_teambase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_teambase_createdby")]
		public SystemUser lk_teambase_createdby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_teambase_createdby", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_teambase_createdby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_teambase_createdby");
		}

		
		/// <summary>
		/// N:1 lk_team_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_team_createdonbehalfby")]
		public SystemUser lk_team_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_team_createdonbehalfby", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_team_createdonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_team_createdonbehalfby");
		}

		
		/// <summary>
		/// N:1 lk_teambase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_teambase_modifiedby")]
		public SystemUser lk_teambase_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_teambase_modifiedby", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_teambase_modifiedby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_teambase_modifiedby");
		}

		
		/// <summary>
		/// N:1 lk_team_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_team_modifiedonbehalfby")]
		public SystemUser lk_team_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_team_modifiedonbehalfby", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_team_modifiedonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_team_modifiedonbehalfby");
		}

		
		/// <summary>
		/// N:1 opportunity_Teams
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_Teams")]
		public Opportunity opportunity_Teams
		{
			get
			{
				return this.GetRelatedEntity<Opportunity>("opportunity_Teams", null);
			}
			set
			{
				this.OnPropertyChanging("opportunity_Teams");
				this.SetRelatedEntity<Opportunity>("opportunity_Teams", null, value);
				this.OnPropertyChanged("opportunity_Teams");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_opportunity_Teams(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "opportunity_Teams");
		}

		
		/// <summary>
		/// N:1 TransactionCurrency_Team
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_Team")]
		public TransactionCurrency TransactionCurrency_Team
		{
			get
			{
				return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_Team", null);
			}
			set
			{
				this.OnPropertyChanging("TransactionCurrency_Team");
				this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_Team", null, value);
				this.OnPropertyChanged("TransactionCurrency_Team");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_TransactionCurrency_Team(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "TransactionCurrency_Team");
		}

		
		/// <summary>
		/// N:N teammembership_association
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("teammembership_association")]
		public System.Collections.Generic.IEnumerable<SystemUser> teammembership_association
		{
			get
			{
				return this.GetRelatedEntities<SystemUser>("teammembership_association", null);
			}
			set
			{
				this.OnPropertyChanging("teammembership_association");
				this.SetRelatedEntities<SystemUser>("teammembership_association", null, value);
				this.OnPropertyChanged("teammembership_association");
			}
		}
		/// <summary>
		/// Loads this N:N relationship into the object 
		/// </summary>
        public void Load_teammembership_association(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "teammembership_association");
		}




		public class Enums 
		{
			[DataContractAttribute]
			public enum IsDefault 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum SystemManaged 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
			[DataContractAttribute]
			public enum TeamType 
			{
				[EnumMemberAttribute]
				Proprietario = 0,
				[EnumMemberAttribute]
				Acesso = 1,
			}		
			[DataContractAttribute]
			public enum urb_permite_todos_assuntos 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
	}


		public class OneToMany
		{
			public const string team_contacts = "team_contacts";
			public const string team_accounts = "team_accounts";
			public const string lead_owning_team = "lead_owning_team";
			public const string team_opportunities = "team_opportunities";
}
		public class ManyToMany
		{
			public const string teammembership_association = "teammembership_association";
}

		public class Fields
		{
			public const string SchemaName = "team";
			
			public const string AdministratorId = "administratorid";
			public const string AdministratorIdName = "administratoridName";
			public const string BusinessUnitId = "businessunitid";
			public const string BusinessUnitIdName = "businessunitidName";
			public const string CreatedBy = "createdby";
			public const string CreatedByName = "createdbyName";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CreatedOnBehalfByName = "createdonbehalfbyName";
			public const string Description = "description";
			public const string EMailAddress = "emailaddress";
			public const string ExchangeRate = "exchangerate";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string IsDefault = "isdefault";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedByName = "modifiedbyName";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string ModifiedOnBehalfByName = "modifiedonbehalfbyName";
			public const string Name = "name";
			public const string OrganizationId = "organizationid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string ProcessId = "processid";
			public const string QueueId = "queueid";
			public const string QueueIdName = "queueidName";
			public const string RegardingObjectId = "regardingobjectid";
			public const string RegardingObjectIdName = "regardingobjectidName";
			public const string RegardingObjectIdType = "regardingobjectidType";
			public const string StageId = "stageid";
			public const string SystemManaged = "systemmanaged";
			public const string TeamId = "teamid";
			public const string TeamTemplateId = "teamtemplateid";
			public const string TeamTemplateIdName = "teamtemplateidName";
			public const string TeamType = "teamtype";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string TransactionCurrencyIdName = "transactioncurrencyidName";
			public const string TraversedPath = "traversedpath";
			public const string urb_permite_todos_assuntos = "urb_permite_todos_assuntos";
			public const string VersionNumber = "versionnumber";
			public const string YomiName = "yominame";
		}
	}

	/// <summary>
	/// 
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("teammembership")]
	public partial class TeamMembership : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public TeamMembership() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "teammembership";
		
		public const int EntityTypeCode = 23;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teammembershipid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.TeamMembershipId = value;
			}
		}
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserid")]
		public System.Nullable<System.Guid> SystemUserId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("systemuserid");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamid")]
		public System.Nullable<System.Guid> TeamId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("teamid");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo de participação na equipe.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teammembershipid")]
		public System.Nullable<System.Guid> TeamMembershipId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("teammembershipid");
			}
			set
			{
				this.OnPropertyChanging("TeamMembershipId");
				this.SetAttributeValue("teammembershipid", value);
						if (value.HasValue)
						{
							base.Id = value.Value;
						}
						else
						{
							base.Id = System.Guid.Empty;
						}
				this.OnPropertyChanged("TeamMembershipId");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
	


		
		/// <summary>
		/// N:N teammembership_association
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("teammembership_association")]
		public System.Collections.Generic.IEnumerable<Team> teammembership_association
		{
			get
			{
				return this.GetRelatedEntities<Team>("teammembership_association", null);
			}
			set
			{
				this.OnPropertyChanging("teammembership_association");
				this.SetRelatedEntities<Team>("teammembership_association", null, value);
				this.OnPropertyChanged("teammembership_association");
			}
		}
		/// <summary>
		/// Loads this N:N relationship into the object 
		/// </summary>
        public void Load_teammembership_association(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "teammembership_association");
		}




		public class Enums 
		{
	}


		public class OneToMany
		{
}
		public class ManyToMany
		{
			public const string teammembership_association = "teammembership_association";
}

		public class Fields
		{
			public const string SchemaName = "teammembership";
			
			public const string SystemUserId = "systemuserid";
			public const string TeamId = "teamid";
			public const string TeamMembershipId = "teammembershipid";
			public const string VersionNumber = "versionnumber";
		}
	}

	[System.Runtime.Serialization.DataContractAttribute()]
	public enum TransactionCurrencyState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Ativa = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inativa = 1,
	}

	/// <summary>
	/// Moeda na qual uma transação financeira é realizada.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("transactioncurrency")]
	public partial class TransactionCurrency : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public TransactionCurrency() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "transactioncurrency";
		
		public const int EntityTypeCode = 9105;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.TransactionCurrencyId = value;
			}
		}
		/// <summary>
		/// Identificador exclusivo do usuário que criou a moeda da transação.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
	



		/// <summary>
		/// Data e hora em que a moeda da transação foi criada.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo do usuário delegado que criou o transactioncurrency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
	



		/// <summary>
		/// Nome da moeda da transação.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currencyname")]
		public string CurrencyName
		{
			get
			{
				return this.GetAttributeValue<string>("currencyname");
			}
			set
			{
				this.OnPropertyChanging("CurrencyName");
				this.SetAttributeValue("currencyname", value);
				this.OnPropertyChanged("CurrencyName");
			}
		}
	


		/// <summary>
		/// Número de casas decimais que podem ser usadas para a moeda.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currencyprecision")]
		public System.Nullable<int> CurrencyPrecision
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("currencyprecision");
			}
			set
			{
				this.OnPropertyChanging("CurrencyPrecision");
				this.SetAttributeValue("currencyprecision", value);
				this.OnPropertyChanged("CurrencyPrecision");
			}
		}
	


		/// <summary>
		/// Símbolo da moeda da transação.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currencysymbol")]
		public string CurrencySymbol
		{
			get
			{
				return this.GetAttributeValue<string>("currencysymbol");
			}
			set
			{
				this.OnPropertyChanging("CurrencySymbol");
				this.SetAttributeValue("currencysymbol", value);
				this.OnPropertyChanged("CurrencySymbol");
			}
		}
	


		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage")]
		public byte[] EntityImage
		{
			get
			{
				return this.GetAttributeValue<byte[]>("entityimage");
			}
			set
			{
				this.OnPropertyChanging("EntityImage");
				this.SetAttributeValue("entityimage", value);
				this.OnPropertyChanged("EntityImage");
			}
		}
	


		/// <summary>
		///  
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_timestamp")]
		public System.Nullable<long> EntityImage_Timestamp
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("entityimage_timestamp");
			}
		}
	


		/// <summary>
		///  
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_url")]
		public string EntityImage_URL
		{
			get
			{
				return this.GetAttributeValue<string>("entityimage_url");
			}
		}
	


		/// <summary>
		/// Somente para uso interno.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimageid")]
		public System.Nullable<System.Guid> EntityImageId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("entityimageid");
			}
		}
	


		/// <summary>
		/// Taxa de câmbio entre a moeda da transação e a moeda base.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
		public System.Nullable<decimal> ExchangeRate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
			}
			set
			{
				this.OnPropertyChanging("ExchangeRate");
				this.SetAttributeValue("exchangerate", value);
				this.OnPropertyChanged("ExchangeRate");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo da importação de dados ou migração de dados que criou este registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
	


		/// <summary>
		/// Código de moeda ISO da moeda da transação.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isocurrencycode")]
		public string ISOCurrencyCode
		{
			get
			{
				return this.GetAttributeValue<string>("isocurrencycode");
			}
			set
			{
				this.OnPropertyChanging("ISOCurrencyCode");
				this.SetAttributeValue("isocurrencycode", value);
				this.OnPropertyChanged("ISOCurrencyCode");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo do usuário que modificou a moeda da transação por último.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
	



		/// <summary>
		/// Data e hora em que a moeda da transação foi modificada por último.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo do usuário delegado que modificou o transactioncurrency pela última vez.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
	



		/// <summary>
		/// Identificador exclusivo da organização associada à moeda da transação.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
	



		/// <summary>
		/// Data e hora da migração do registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
	


		/// <summary>
		/// Status da moeda da transação.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<TransactionCurrencyState> StateCode
		{
				get
				{
					Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
					if ((optionSet != null))
					{
						return ((TransactionCurrencyState)(System.Enum.ToObject(typeof(TransactionCurrencyState), optionSet.Value)));
					}
					else
					{
						return null;
					}
				}
					set
					{
						this.OnPropertyChanging("StateCode");
						if ((value == null))
						{
							this.SetAttributeValue("statecode", null);
						}
						else
						{
							this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
						}
						this.OnPropertyChanged("StateCode");
					}
		}
	


		/// <summary>
		/// Razão do status da moeda da transação.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			set
			{
				this.OnPropertyChanging("StatusCode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("StatusCode");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo da moeda da transação.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public System.Nullable<System.Guid> TransactionCurrencyId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("transactioncurrencyid");
			}
			set
			{
				this.OnPropertyChanging("TransactionCurrencyId");
				this.SetAttributeValue("transactioncurrencyid", value);
						if (value.HasValue)
						{
							base.Id = value.Value;
						}
						else
						{
							base.Id = System.Guid.Empty;
						}
				this.OnPropertyChanged("TransactionCurrencyId");
			}
		}
	


		/// <summary>
		/// Apenas para uso interno.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uniquedscid")]
		public System.Nullable<System.Guid> UniqueDscId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("uniquedscid");
			}
		}
	


		/// <summary>
		/// Número da versão da moeda de transação.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
	


		
		/// <summary>
		/// 1:N TransactionCurrency_SystemUser
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_SystemUser")]
		public System.Collections.Generic.IEnumerable<SystemUser> TransactionCurrency_SystemUser
		{
			get
			{
				return this.GetRelatedEntities<SystemUser>("TransactionCurrency_SystemUser", null);
			}
			set
			{
				this.OnPropertyChanging("TransactionCurrency_SystemUser");
				this.SetRelatedEntities<SystemUser>("TransactionCurrency_SystemUser", null, value);
				this.OnPropertyChanged("TransactionCurrency_SystemUser");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_TransactionCurrency_SystemUser(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "TransactionCurrency_SystemUser");
		}

		
		/// <summary>
		/// 1:N TransactionCurrency_Team
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_Team")]
		public System.Collections.Generic.IEnumerable<Team> TransactionCurrency_Team
		{
			get
			{
				return this.GetRelatedEntities<Team>("TransactionCurrency_Team", null);
			}
			set
			{
				this.OnPropertyChanging("TransactionCurrency_Team");
				this.SetRelatedEntities<Team>("TransactionCurrency_Team", null, value);
				this.OnPropertyChanged("TransactionCurrency_Team");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_TransactionCurrency_Team(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "TransactionCurrency_Team");
		}

		
		/// <summary>
		/// 1:N TransactionCurrency_BusinessUnit
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_BusinessUnit")]
		public System.Collections.Generic.IEnumerable<BusinessUnit> TransactionCurrency_BusinessUnit
		{
			get
			{
				return this.GetRelatedEntities<BusinessUnit>("TransactionCurrency_BusinessUnit", null);
			}
			set
			{
				this.OnPropertyChanging("TransactionCurrency_BusinessUnit");
				this.SetRelatedEntities<BusinessUnit>("TransactionCurrency_BusinessUnit", null, value);
				this.OnPropertyChanged("TransactionCurrency_BusinessUnit");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_TransactionCurrency_BusinessUnit(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "TransactionCurrency_BusinessUnit");
		}

		
		/// <summary>
		/// 1:N transactioncurrency_contact
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_contact")]
		public System.Collections.Generic.IEnumerable<Contact> transactioncurrency_contact
		{
			get
			{
				return this.GetRelatedEntities<Contact>("transactioncurrency_contact", null);
			}
			set
			{
				this.OnPropertyChanging("transactioncurrency_contact");
				this.SetRelatedEntities<Contact>("transactioncurrency_contact", null, value);
				this.OnPropertyChanged("transactioncurrency_contact");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_transactioncurrency_contact(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "transactioncurrency_contact");
		}

		
		/// <summary>
		/// 1:N transactioncurrency_account
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_account")]
		public System.Collections.Generic.IEnumerable<Account> transactioncurrency_account
		{
			get
			{
				return this.GetRelatedEntities<Account>("transactioncurrency_account", null);
			}
			set
			{
				this.OnPropertyChanging("transactioncurrency_account");
				this.SetRelatedEntities<Account>("transactioncurrency_account", null, value);
				this.OnPropertyChanged("transactioncurrency_account");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_transactioncurrency_account(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "transactioncurrency_account");
		}

		
		/// <summary>
		/// 1:N transactioncurrency_lead
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_lead")]
		public System.Collections.Generic.IEnumerable<Lead> transactioncurrency_lead
		{
			get
			{
				return this.GetRelatedEntities<Lead>("transactioncurrency_lead", null);
			}
			set
			{
				this.OnPropertyChanging("transactioncurrency_lead");
				this.SetRelatedEntities<Lead>("transactioncurrency_lead", null, value);
				this.OnPropertyChanged("transactioncurrency_lead");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_transactioncurrency_lead(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "transactioncurrency_lead");
		}

		
		/// <summary>
		/// 1:N transactioncurrency_opportunity
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_opportunity")]
		public System.Collections.Generic.IEnumerable<Opportunity> transactioncurrency_opportunity
		{
			get
			{
				return this.GetRelatedEntities<Opportunity>("transactioncurrency_opportunity", null);
			}
			set
			{
				this.OnPropertyChanging("transactioncurrency_opportunity");
				this.SetRelatedEntities<Opportunity>("transactioncurrency_opportunity", null, value);
				this.OnPropertyChanged("transactioncurrency_opportunity");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_transactioncurrency_opportunity(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "transactioncurrency_opportunity");
		}

		
		/// <summary>
		/// N:1 lk_transactioncurrencybase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transactioncurrencybase_createdby")]
		public SystemUser lk_transactioncurrencybase_createdby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_transactioncurrencybase_createdby", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_transactioncurrencybase_createdby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_transactioncurrencybase_createdby");
		}

		
		/// <summary>
		/// N:1 lk_transactioncurrency_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transactioncurrency_createdonbehalfby")]
		public SystemUser lk_transactioncurrency_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_transactioncurrency_createdonbehalfby", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_transactioncurrency_createdonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_transactioncurrency_createdonbehalfby");
		}

		
		/// <summary>
		/// N:1 lk_transactioncurrencybase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transactioncurrencybase_modifiedby")]
		public SystemUser lk_transactioncurrencybase_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_transactioncurrencybase_modifiedby", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_transactioncurrencybase_modifiedby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_transactioncurrencybase_modifiedby");
		}

		
		/// <summary>
		/// N:1 lk_transactioncurrency_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transactioncurrency_modifiedonbehalfby")]
		public SystemUser lk_transactioncurrency_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_transactioncurrency_modifiedonbehalfby", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_transactioncurrency_modifiedonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_transactioncurrency_modifiedonbehalfby");
		}



		public class Enums 
		{
			[DataContractAttribute]
			public enum StateCode 
			{
				[EnumMemberAttribute]
				Ativa = 0,
				[EnumMemberAttribute]
				Inativa = 1,
			}		
			[DataContractAttribute]
			public enum StatusCode 
			{
				[EnumMemberAttribute]
				Ativa = 1,
				[EnumMemberAttribute]
				Inativa = 2,
			}		
	}


		public class OneToMany
		{
			public const string TransactionCurrency_SystemUser = "TransactionCurrency_SystemUser";
			public const string TransactionCurrency_Team = "TransactionCurrency_Team";
			public const string TransactionCurrency_BusinessUnit = "TransactionCurrency_BusinessUnit";
			public const string transactioncurrency_contact = "transactioncurrency_contact";
			public const string transactioncurrency_account = "transactioncurrency_account";
			public const string transactioncurrency_lead = "transactioncurrency_lead";
			public const string transactioncurrency_opportunity = "transactioncurrency_opportunity";
}
		public class ManyToMany
		{
}

		public class Fields
		{
			public const string SchemaName = "transactioncurrency";
			
			public const string CreatedBy = "createdby";
			public const string CreatedByName = "createdbyName";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CreatedOnBehalfByName = "createdonbehalfbyName";
			public const string CurrencyName = "currencyname";
			public const string CurrencyPrecision = "currencyprecision";
			public const string CurrencySymbol = "currencysymbol";
			public const string EntityImage = "entityimage";
			public const string EntityImage_Timestamp = "entityimage_timestamp";
			public const string EntityImage_URL = "entityimage_url";
			public const string EntityImageId = "entityimageid";
			public const string ExchangeRate = "exchangerate";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string ISOCurrencyCode = "isocurrencycode";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedByName = "modifiedbyName";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string ModifiedOnBehalfByName = "modifiedonbehalfbyName";
			public const string OrganizationId = "organizationid";
			public const string OrganizationIdName = "organizationidName";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string UniqueDscId = "uniquedscid";
			public const string VersionNumber = "versionnumber";
		}
	}

	/// <summary>
	/// Unidade de medida.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("uom")]
	public partial class UoM : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public UoM() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "uom";
		
		public const int EntityTypeCode = 1055;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.UoMId = value;
			}
		}
		/// <summary>
		/// Escolha a unidade base ou principal na qual a unidade é baseada.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baseuom")]
		public Microsoft.Xrm.Sdk.EntityReference BaseUoM
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("baseuom");
			}
			set
			{
				this.OnPropertyChanging("BaseUoM");
				this.SetAttributeValue("baseuom", value);
				this.OnPropertyChanged("BaseUoM");
			}
		}
	



		/// <summary>
		/// Identificador exclusivo do usuário que criou a unidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
	


		/// <summary>
		/// Mostra o participante externo que criou o registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdbyexternalparty")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedByExternalParty
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdbyexternalparty");
			}
		}
	




		/// <summary>
		/// Data e hora em que a unidade foi criada.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo do usuário delegado que criou o uom.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
	



		/// <summary>
		/// Número de sequência da importação que criou este registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
	


		/// <summary>
		/// Informa se a unidade é a unidade base do grupo de unidades associado.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isschedulebaseuom")]
		public System.Nullable<bool> IsScheduleBaseUoM
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isschedulebaseuom");
			}
		}
	
		public virtual Enums.IsScheduleBaseUoM? IsScheduleBaseUoMEnum
		{
			get
			{
				return ((Enums.IsScheduleBaseUoM?)(EntityOptionSetEnum.GetEnum(this, "isschedulebaseuom")));
			}
		}


		/// <summary>
		/// O identificador exclusivo do usuário que modificou a unidade pela última vez.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
	


		/// <summary>
		/// Mostra o participante externo que modificou o registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedbyexternalparty")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedByExternalParty
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedbyexternalparty");
			}
		}
	




		/// <summary>
		/// Data e hora da última modificação da unidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo do usuário delegado que modificou o uom pela última vez.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
	



		/// <summary>
		/// Digite um título ou nome descritivo para a unidade de medida.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			set
			{
				this.OnPropertyChanging("Name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("Name");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo da organização associada à unidade de medida.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public System.Nullable<System.Guid> OrganizationId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("organizationid");
			}
		}
	


		/// <summary>
		/// Data e hora da migração do registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
	


		/// <summary>
		/// Quantidade de unidades do produto.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quantity")]
		public System.Nullable<decimal> Quantity
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("quantity");
			}
			set
			{
				this.OnPropertyChanging("Quantity");
				this.SetAttributeValue("quantity", value);
				this.OnPropertyChanged("Quantity");
			}
		}
	


		/// <summary>
		/// Apenas para uso interno.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo da unidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomid")]
		public System.Nullable<System.Guid> UoMId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("uomid");
			}
			set
			{
				this.OnPropertyChanging("UoMId");
				this.SetAttributeValue("uomid", value);
						if (value.HasValue)
						{
							base.Id = value.Value;
						}
						else
						{
							base.Id = System.Guid.Empty;
						}
				this.OnPropertyChanged("UoMId");
			}
		}
	


		/// <summary>
		/// Escolha a ID do grupo de unidades ao qual a unidade está associada.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomscheduleid")]
		public Microsoft.Xrm.Sdk.EntityReference UoMScheduleId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("uomscheduleid");
			}
			set
			{
				this.OnPropertyChanging("UoMScheduleId");
				this.SetAttributeValue("uomscheduleid", value);
				this.OnPropertyChanged("UoMScheduleId");
			}
		}
	



		/// <summary>
		/// Código de fuso horário em uso quando o registro foi criado.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
	


		/// <summary>
		/// Número da Versão
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
	


		
		/// <summary>
		/// 1:N unit_of_measurement_base_unit
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measurement_base_unit", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<UoM> Referencedunit_of_measurement_base_unit
		{
			get
			{
				return this.GetRelatedEntities<UoM>("unit_of_measurement_base_unit", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referencedunit_of_measurement_base_unit");
				this.SetRelatedEntities<UoM>("unit_of_measurement_base_unit", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedunit_of_measurement_base_unit");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_unit_of_measurement_base_unit(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "unit_of_measurement_base_unit");
		}

		
		/// <summary>
		/// N:1 unit_of_measurement_base_unit
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baseuom")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measurement_base_unit", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public UoM Referencingunit_of_measurement_base_unit
		{
			get
			{
				return this.GetRelatedEntity<UoM>("unit_of_measurement_base_unit", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
			set
			{
				this.OnPropertyChanging("Referencingunit_of_measurement_base_unit");
				this.SetRelatedEntity<UoM>("unit_of_measurement_base_unit", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
				this.OnPropertyChanged("Referencingunit_of_measurement_base_unit");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_unit_of_measurement_base_unit(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "unit_of_measurement_base_unit");
		}

		
		/// <summary>
		/// N:1 lk_uombase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uombase_createdby")]
		public SystemUser lk_uombase_createdby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_uombase_createdby", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_uombase_createdby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_uombase_createdby");
		}

		
		/// <summary>
		/// N:1 lk_uom_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uom_createdonbehalfby")]
		public SystemUser lk_uom_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_uom_createdonbehalfby", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_uom_createdonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_uom_createdonbehalfby");
		}

		
		/// <summary>
		/// N:1 lk_uombase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uombase_modifiedby")]
		public SystemUser lk_uombase_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_uombase_modifiedby", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_uombase_modifiedby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_uombase_modifiedby");
		}

		
		/// <summary>
		/// N:1 lk_uom_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uom_modifiedonbehalfby")]
		public SystemUser lk_uom_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_uom_modifiedonbehalfby", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_uom_modifiedonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_uom_modifiedonbehalfby");
		}

		
		/// <summary>
		/// N:1 unit_of_measure_schedule_conversions
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomscheduleid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measure_schedule_conversions")]
		public UoMSchedule unit_of_measure_schedule_conversions
		{
			get
			{
				return this.GetRelatedEntity<UoMSchedule>("unit_of_measure_schedule_conversions", null);
			}
			set
			{
				this.OnPropertyChanging("unit_of_measure_schedule_conversions");
				this.SetRelatedEntity<UoMSchedule>("unit_of_measure_schedule_conversions", null, value);
				this.OnPropertyChanged("unit_of_measure_schedule_conversions");
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_unit_of_measure_schedule_conversions(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "unit_of_measure_schedule_conversions");
		}



		public class Enums 
		{
			[DataContractAttribute]
			public enum IsScheduleBaseUoM 
			{
				[EnumMemberAttribute]
				Sim = 1,
				[EnumMemberAttribute]
				Nao = 0,
			}		
	}


		public class OneToMany
		{
			public const string unit_of_measurement_base_unit = "unit_of_measurement_base_unit";
}
		public class ManyToMany
		{
}

		public class Fields
		{
			public const string SchemaName = "uom";
			
			public const string BaseUoM = "baseuom";
			public const string BaseUoMName = "baseuomName";
			public const string CreatedBy = "createdby";
			public const string CreatedByExternalParty = "createdbyexternalparty";
			public const string CreatedByExternalPartyName = "createdbyexternalpartyName";
			public const string CreatedByName = "createdbyName";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CreatedOnBehalfByName = "createdonbehalfbyName";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string IsScheduleBaseUoM = "isschedulebaseuom";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedByExternalParty = "modifiedbyexternalparty";
			public const string ModifiedByExternalPartyName = "modifiedbyexternalpartyName";
			public const string ModifiedByName = "modifiedbyName";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string ModifiedOnBehalfByName = "modifiedonbehalfbyName";
			public const string Name = "name";
			public const string OrganizationId = "organizationid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string Quantity = "quantity";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string UoMId = "uomid";
			public const string UoMScheduleId = "uomscheduleid";
			public const string UoMScheduleIdName = "uomscheduleidName";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
		}
	}

	[System.Runtime.Serialization.DataContractAttribute()]
	public enum UoMScheduleState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Ativo = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inativo = 1,
	}

	/// <summary>
	/// Agrupamento de unidades.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("uomschedule")]
	public partial class UoMSchedule : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public UoMSchedule() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "uomschedule";
		
		public const int EntityTypeCode = 1056;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomscheduleid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.UoMScheduleId = value;
			}
		}
		/// <summary>
		/// Nome da unidade base.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baseuomname")]
		public string BaseUoMName
		{
			get
			{
				return this.GetAttributeValue<string>("baseuomname");
			}
			set
			{
				this.OnPropertyChanging("BaseUoMName");
				this.SetAttributeValue("baseuomname", value);
				this.OnPropertyChanged("BaseUoMName");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo do usuário que criou o grupo de unidades.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
	


		/// <summary>
		/// Mostra o participante externo que criou o registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdbyexternalparty")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedByExternalParty
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdbyexternalparty");
			}
		}
	




		/// <summary>
		/// Data e hora em que o grupo de unidades foi criado.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo do usuário delegado que criou o uomschedule.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
	



		/// <summary>
		/// Descrição do grupo de unidades.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			set
			{
				this.OnPropertyChanging("Description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("Description");
			}
		}
	


		/// <summary>
		/// Número de sequência da importação que criou este registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
	


		/// <summary>
		/// O identificador exclusivo do usuário que modificou o grupo de unidades pela última vez.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
	


		/// <summary>
		/// Mostra o participante externo que modificou o registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedbyexternalparty")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedByExternalParty
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedbyexternalparty");
			}
		}
	




		/// <summary>
		/// Data e hora da última modificação do grupo de unidades.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo do usuário delegado que modificou o uomschedule pela última vez.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
	



		/// <summary>
		/// Nome do grupo de unidades.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			set
			{
				this.OnPropertyChanging("Name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("Name");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo da organização
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
	



		/// <summary>
		/// Data e hora da migração do registro.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
	


		/// <summary>
		/// Status do Grupo de Unidades.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<UoMScheduleState> StateCode
		{
				get
				{
					Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
					if ((optionSet != null))
					{
						return ((UoMScheduleState)(System.Enum.ToObject(typeof(UoMScheduleState), optionSet.Value)));
					}
					else
					{
						return null;
					}
				}
					set
					{
						this.OnPropertyChanging("StateCode");
						if ((value == null))
						{
							this.SetAttributeValue("statecode", null);
						}
						else
						{
							this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
						}
						this.OnPropertyChanged("StateCode");
					}
		}
	


		/// <summary>
		/// Motivo do status do Grupo de Unidades.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			set
			{
				this.OnPropertyChanging("StatusCode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("StatusCode");
			}
		}
	


		/// <summary>
		/// Apenas para uso interno.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
	


		/// <summary>
		/// Identificador exclusivo do grupo de unidades.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomscheduleid")]
		public System.Nullable<System.Guid> UoMScheduleId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("uomscheduleid");
			}
			set
			{
				this.OnPropertyChanging("UoMScheduleId");
				this.SetAttributeValue("uomscheduleid", value);
						if (value.HasValue)
						{
							base.Id = value.Value;
						}
						else
						{
							base.Id = System.Guid.Empty;
						}
				this.OnPropertyChanged("UoMScheduleId");
			}
		}
	


		/// <summary>
		/// Código de fuso horário em uso quando o registro foi criado.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
	


		/// <summary>
		/// Número da Versão
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
	


		
		/// <summary>
		/// 1:N unit_of_measure_schedule_conversions
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measure_schedule_conversions")]
		public System.Collections.Generic.IEnumerable<UoM> unit_of_measure_schedule_conversions
		{
			get
			{
				return this.GetRelatedEntities<UoM>("unit_of_measure_schedule_conversions", null);
			}
			set
			{
				this.OnPropertyChanging("unit_of_measure_schedule_conversions");
				this.SetRelatedEntities<UoM>("unit_of_measure_schedule_conversions", null, value);
				this.OnPropertyChanged("unit_of_measure_schedule_conversions");
			}
		}
        /// <summary>
		/// Loads this 1:N relationship into the object 
		/// </summary>
        public void Load_unit_of_measure_schedule_conversions(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "unit_of_measure_schedule_conversions");
		}

		
		/// <summary>
		/// N:1 lk_uomschedulebase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uomschedulebase_createdby")]
		public SystemUser lk_uomschedulebase_createdby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_uomschedulebase_createdby", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_uomschedulebase_createdby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_uomschedulebase_createdby");
		}

		
		/// <summary>
		/// N:1 lk_uomschedule_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uomschedule_createdonbehalfby")]
		public SystemUser lk_uomschedule_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_uomschedule_createdonbehalfby", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_uomschedule_createdonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_uomschedule_createdonbehalfby");
		}

		
		/// <summary>
		/// N:1 lk_uomschedulebase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uomschedulebase_modifiedby")]
		public SystemUser lk_uomschedulebase_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_uomschedulebase_modifiedby", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_uomschedulebase_modifiedby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_uomschedulebase_modifiedby");
		}

		
		/// <summary>
		/// N:1 lk_uomschedule_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uomschedule_modifiedonbehalfby")]
		public SystemUser lk_uomschedule_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<SystemUser>("lk_uomschedule_modifiedonbehalfby", null);
			}
		}

		/// <summary>
		/// Loads the lookup record into the object 
		/// </summary>
        public void LoadLookup_lk_uomschedule_modifiedonbehalfby(XrmServiceContext ctx)
		{
			ctx.LoadProperty(this, "lk_uomschedule_modifiedonbehalfby");
		}



		public class Enums 
		{
			[DataContractAttribute]
			public enum StateCode 
			{
				[EnumMemberAttribute]
				Ativo = 0,
				[EnumMemberAttribute]
				Inativo = 1,
			}		
			[DataContractAttribute]
			public enum StatusCode 
			{
				[EnumMemberAttribute]
				Ativo = 1,
				[EnumMemberAttribute]
				Inativo = 2,
			}		
	}


		public class OneToMany
		{
			public const string unit_of_measure_schedule_conversions = "unit_of_measure_schedule_conversions";
}
		public class ManyToMany
		{
}

		public class Fields
		{
			public const string SchemaName = "uomschedule";
			
			public const string BaseUoMName = "baseuomname";
			public const string CreatedBy = "createdby";
			public const string CreatedByExternalParty = "createdbyexternalparty";
			public const string CreatedByExternalPartyName = "createdbyexternalpartyName";
			public const string CreatedByName = "createdbyName";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CreatedOnBehalfByName = "createdonbehalfbyName";
			public const string Description = "description";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedByExternalParty = "modifiedbyexternalparty";
			public const string ModifiedByExternalPartyName = "modifiedbyexternalpartyName";
			public const string ModifiedByName = "modifiedbyName";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string ModifiedOnBehalfByName = "modifiedonbehalfbyName";
			public const string Name = "name";
			public const string OrganizationId = "organizationid";
			public const string OrganizationIdName = "organizationidName";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string UoMScheduleId = "uomscheduleid";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
		}
	}

	/// <summary>
	/// Represents a source of entities bound to a CRM service. It tracks and manages changes made to the retrieved entities.
	/// </summary>
	public partial class XrmServiceContext : Microsoft.Xrm.Sdk.Client.OrganizationServiceContext
	{
		/// <summary>
		/// Constructor.
		/// </summary>
		public XrmServiceContext(Microsoft.Xrm.Sdk.IOrganizationService service) : 
				base(service)
		{
		}

		/// <summary>
		/// Gets a binding to the set of all <see cref="Account"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Account> AccountSet
		{
			get
			{
				return this.CreateQuery<Account>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="ActivityParty"/> entities.
		/// </summary>
		public System.Linq.IQueryable<ActivityParty> ActivityPartySet
		{
			get
			{
				return this.CreateQuery<ActivityParty>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="BusinessUnit"/> entities.
		/// </summary>
		public System.Linq.IQueryable<BusinessUnit> BusinessUnitSet
		{
			get
			{
				return this.CreateQuery<BusinessUnit>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="Contact"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Contact> ContactSet
		{
			get
			{
				return this.CreateQuery<Contact>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="Lead"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Lead> LeadSet
		{
			get
			{
				return this.CreateQuery<Lead>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="Opportunity"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Opportunity> OpportunitySet
		{
			get
			{
				return this.CreateQuery<Opportunity>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="SystemUser"/> entities.
		/// </summary>
		public System.Linq.IQueryable<SystemUser> SystemUserSet
		{
			get
			{
				return this.CreateQuery<SystemUser>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="Team"/> entities.
		/// </summary>
		public System.Linq.IQueryable<Team> TeamSet
		{
			get
			{
				return this.CreateQuery<Team>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="TeamMembership"/> entities.
		/// </summary>
		public System.Linq.IQueryable<TeamMembership> TeamMembershipSet
		{
			get
			{
				return this.CreateQuery<TeamMembership>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="TransactionCurrency"/> entities.
		/// </summary>
		public System.Linq.IQueryable<TransactionCurrency> TransactionCurrencySet
		{
			get
			{
				return this.CreateQuery<TransactionCurrency>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="UoM"/> entities.
		/// </summary>
		public System.Linq.IQueryable<UoM> UoMSet
		{
			get
			{
				return this.CreateQuery<UoM>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="UoMSchedule"/> entities.
		/// </summary>
		public System.Linq.IQueryable<UoMSchedule> UoMScheduleSet
		{
			get
			{
				return this.CreateQuery<UoMSchedule>();
			}
		}
	}
	 internal sealed class EntityOptionSetEnum
    {

        public static System.Nullable<int> GetEnum(Microsoft.Xrm.Sdk.Entity entity, string attributeLogicalName)
        {
            if (entity.Attributes.ContainsKey(attributeLogicalName))
            {
                Microsoft.Xrm.Sdk.OptionSetValue value = entity.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>(attributeLogicalName);
                if (value != null)
                {
                    return value.Value;
                }
            }
            return null;
        }
    }
}
