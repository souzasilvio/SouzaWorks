//Javascript to centralize all custom script to account entity
var pessoaFisica = true;
var VAR_FORM_VALIDO = false;
var ID_MENSAGEM = "AC001"
if (typeof (CRM) == "undefined")
{ CRM = {}; }
CRM.Account = {
    OnLoad: function (context) {
        try {
            VAR_FORM_VALIDO = true;
        }
        catch (error) {
            VAR_FORM_VALIDO = false;
            Xrm.Page.ui.setFormNotification(error.description, 'ERROR', ID_MENSAGEM);
        }
    },

    OnSave: function (context) {
        try {
            //prevent save if any error ocorried
            if (!VAR_FORM_VALIDO) {
                context.getEventArgs().preventDefault();
                return false;
            }
        }
        catch (error) {
            VAR_FORM_VALIDO = false;
            Xrm.Page.ui.setFormNotification(error.description, 'ERROR', ID_MENSAGEM);
        }
    },

    //OnChange envent to field TipoClient
    //Here we do especific logic according to a select option
    TipoClienteChange: function (context) {
        podeSalvarCliente = false;
        pessoaFisica = (Xrm.Page.getAttribute('urb_tipo_cliente').getText() == TIPO_PF || Xrm.Page.getAttribute('urb_tipo_cliente').getText() == "");
        if (pessoaFisica) {
            Xrm.Page.ui.tabs.get("tab_pessoa_fisica").setVisible(true);
            Xrm.Page.getControl("urb_cnpj").setVisible(false);
            Xrm.Page.getControl("urb_cpf").setVisible(true);
            Xrm.Page.getAttribute("urb_cnpj").setRequiredLevel("none");
            Xrm.Page.ui.tabs.get("tab_pessoa_jurica").setVisible(false);
        }
        else {
            Xrm.Page.getAttribute("telephone1").setRequiredLevel("none");
            Xrm.Page.getControl("urb_cnpj").setVisible(true);
            Xrm.Page.getControl("urb_cpf").setVisible(false);
            Xrm.Page.getAttribute("urb_cpf").setRequiredLevel("none");
            Xrm.Page.ui.tabs.get("tab_pessoa_fisica").setVisible(false);
            Xrm.Page.ui.tabs.get("tab_pessoa_jurica").setVisible(true);
            Xrm.Page.getAttribute("urb_cnpj").setRequiredLevel("required");
        }
    },

    CNPJChange: function (contexto) {
        
    },

    CPFChange: function (contexto) {
        
    }
}