using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Model.Entityes
{
    /// <summary>
    /// Uma cidade
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("mrv_cidade")]
    public partial class mrv_cidade : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public mrv_cidade() : base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "mrv_cidade";

        //public const int EntityTypeCode = 1;

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

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mrv_cidadeid")]
        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                this.mrv_cidadeid = value;
            }
        }

        /// <summary>
		/// Identificador exclusivo da cidade.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mrv_cidadeid")]
        public System.Nullable<System.Guid> mrv_cidadeid
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("mrv_cidadeid");
            }
            set
            {
                this.OnPropertyChanging("mrv_cidadeid");
                this.SetAttributeValue("mrv_cidadeid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("mrv_cidadeid");
            }
        }

        /// <summary>
		/// Digite a cidade do endereço principal.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mrv_name")]
        public string mrv_name
        {
            get
            {
                return this.GetAttributeValue<string>("mrv_name");
            }
            set
            {
                this.OnPropertyChanging("mrv_name");
                this.SetAttributeValue("mrv_name", value);
                this.OnPropertyChanged("mrv_name");
            }
        }


        /// <summary>
        /// Escolha a lista de preços padrão associada à conta para garantir que os preços de produtos corretos para este cliente sejam aplicados em oportunidades de vendas, cotações e ordens.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mrv_estadoid")]
        public Microsoft.Xrm.Sdk.EntityReference mrv_estadoid
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("mrv_estadoid");
            }
            set
            {
                this.OnPropertyChanging("mrv_estadoid");
                this.SetAttributeValue("mrv_estadoid", value);
                this.OnPropertyChanged("mrv_estadoid");
            }
        }

    }


}
