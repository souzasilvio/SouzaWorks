var msgForm = "msgForm";
var FORM_TYPE_CREATE = 1;
var FORM_TYPE_UPDATE = 2;
var FORM_TYPE_READ_ONLY = 3;
var FORM_TYPE_DISABLED = 4;
var FORM_TYPE_BULK_EDIT = 6;
//Use this url to point to the local where you host the project Crm.WebExtension with your custom api operations
var URL_CUSTOM_API = 'https://localhost:44357/api/';

var CRM = CRM || {};
CRM.Forms = CRM.Forms || {};
CRM.Forms = {

    //Add form message of type ERROR, WARNING ou INFO
    AddFormNotification: function (mensagem, tipo, id) { Xrm.Page.ui.clearFormNotification(id);Xrm.Page.ui.setFormNotification(mensagem, tipo, id);},

    //Limpa notificação criada com um id
    ClearFormNotification: function (id) { Xrm.Page.ui.clearFormNotification(id); },

    //Get Select text from option list Attribute
    GetAttributeText: function (nomeAtributo) { return Xrm.Page.getAttribute(nomeAtributo).getText(); },

    //Get current user name
    GetUserName: function () { return Xrm.Utility.getGlobalContext().userSettings.userName; },

    //Get user id read to be use in web api
    GetUserId: function () { return Xrm.Utility.getGlobalContext().userSettings.userId.replace("}", "").replace("{", ""); },

    //Show a confirm dialog with call back functions to Yes and No answer
    ShowConfirmDialog: function (mensagem, funcaoSim, funcaoNao) { Xrm.Utility.confirmDialog(mensagem, funcaoSim, funcaoNao); },

    //Set a form loockup field 
    SetFormLookup: function (fieldName, entityName, IdValue, nameValue) {
        var lookupReference = [];
        lookupReference[0] = {};
        lookupReference[0].id = IdValue;
        lookupReference[0].entityType = entityName;
        lookupReference[0].name = nameValue;
        Xrm.Page.getAttribute(fieldName).setValue(lookupReference);
    }, 


    //ASync Retrieve a crm record using lasted Xrm.WebApi. View Test.js do know how to use
    RetrieveRecord: function (entityName, id, query, sucessCallBack) {
        parent.Xrm.WebApi.retrieveRecord(entityName, id, query).then(sucessCallBack,
            function (error) {
                Xrm.Utility.alertDialog(error.message);
            }
        );
    },

    //Retrieve a list of record. View Test.js do know how to use
    RetrieveMultiple: function (entityName, query, sucessCallBack) {
        parent.Xrm.WebApi.retrieveMultipleRecords(entityName, query).then(sucessCallBack,
            function (error) {
                Xrm.Utility.alertDialog(error.message);
            });
    },

    //Async Check if user is in a team to do some especific task on form
    UserInTeam: function (teamName, callback) {
        parent.Xrm.WebApi.retrieveMultipleRecords("team", "?$select=name&$filter=name eq '" + teamName + "'").then(
            function success(result) {
                if (result.entities.length > 0) {
                    var idEquipe = result.entities[0].teamid;
                    var id = CRM.Forms.GetUserId();
                    var filtro = "$select=systemuserid,teamid&$filter=systemuserid eq " + id + " and teamid eq " + idEquipe;
                    parent.Xrm.WebApi.retrieveMultipleRecords("teammembership", filtro).then(callback,
                        function (error) {
                            Xrm.Utility.alertDialog(error.message);
                        });
                }
                else {
                    Xrm.Utility.alertDialog('Equipe ' + teamName + ' foi não cadastrada. Solicite o cadastro.');
                }
            },
            function (error) {
                Xrm.Utility.alertDialog(error.message);
            }
        );
    },

    //Check if user is member of a list of coma separeted teams
    UserInAnyTeam: function (teamlist, callback) {
        var lista = teamlist.split(";");
        var filtro = "$select=name&$filter=";
        for (var i = 0; i < lista.length; i++) {
            if (i > 0) {
                filtro += " or ";
            }
            filtro += "name eq '" + lista[i] + "'";
        }
        parent.Xrm.WebApi.retrieveMultipleRecords("team", filtro).then(
            function success(result) {
                if (result.entities.length > 0) {
                    var id = MRV.Forms.GetUserId();
                    filtro = "$select=systemuserid,teamid&$filter=systemuserid eq " + id + " and ";
                    for (var i = 0; i < result.entities.length; i++) {
                        if (i > 0) {
                            filtro += " or ";
                        }
                        filtro += "teamid eq " + result.entities[i].teamid;
                    }
                    parent.Xrm.WebApi.retrieveMultipleRecords("teammembership", filtro).then(callback,
                        function (error) {
                            Xrm.Utility.alertDialog(error.message);
                        });
                }
                else {
                    Xrm.Utility.alertDialog('Equipes ' + teamlist + ' não cadastradas. Solicite o cadastro.');
                }
            },
            function (error) {
                Xrm.Utility.alertDialog(error.message);
            }
        );
    },
    
    /*Set forms fields content to uppercase. Doe not to aply to option list fields.*/
    SetFormUpperCase: function (fieldsToIgnore) {
        var controls = Xrm.Page.ui.controls.get();
        var tmpIgnore = camposIgnore == null ? new Array() : fieldsToIgnore.split(";");
        for (var i in controls) {
            try {
                var ignorar = false;
                var atributo = controls[i].getAttribute();
                for (var i = 0; i < tmpIgnore.length; i++) {
                    if (atributo != null && tmpIgnore[i].toUpperCase() == atributo.getName().toUpperCase()) {
                        ignorar = true;
                        break;
                    }
                }

                if (ignorar == false && atributo != null && atributo.getIsDirty()) {
                    var tipo = atributo.getAttributeType();
                    switch (tipo) {
                        case 'string':
                        case 'memo':
                            atributo.setValue(atributo.getValue().toUpperCase());
                    }
                }
            }
            catch (error) {
            }
        }
    },

    /*Phone number format. (Brazil format) */
    FormataTelefone: function (context, ddi, ddd) {
        //+55 (31) 3889-1212
        //+55 (31) 99152-5803
        var campo = context.getEventSource();
        if (campo != null && campo.getValue() != null) {
            var sTmp = campo.getValue().replace(/[^0-9]/g, "");
            switch (sTmp.length) {
                case 8:
                    campo.setValue("+" + ddi + " (" + ddd + ") " + sTmp.substr(0, 4) + "-" + sTmp.substr(5, 4));
                case 10:
                    campo.setValue("(" + sTmp.substr(0, 2) + ") " + sTmp.substr(2, 4) + "-" + sTmp.substr(6, 4));
                    break;
                case 11:
                    campo.setValue("(" + sTmp.substr(0, 2) + ") " + sTmp.substr(2, 5) + "-" + sTmp.substr(7, 4));
                    break;
                default:
                    alert("Telefone inválido. Digite o ddd e telefone com 8 ou 9 dígitos. Ex:(11) 8765-4321 ou (011) 98765-4321.");
                    campo.setValue(null);
                    break;
            }
        }
    },

    /*Forma Zip Code. Brasil Format*/
    FormataCEP: function (context) {
        var campo = context.getEventSource();
        if (campo != null && campo.getValue() != null) {
            var sTmp = campo.getValue().replace(/[^0-9]/g, "");
            if (sTmp.length != 8) {
                campo.setValue(null);
                alert("Cep fora da faixa 8 dígitos sequenciais! Ex: 31080140");
            }
            else {
                campo.setValue(sTmp.substr(0, 2) + "." + sTmp.substr(2, 3) + "-" + sTmp.substr(5, 3));
            }
        }
    },

    /*Format CPF number of Brazil (like US Social)*/
    FormataCPF: function (context) {
        var campo = context.getEventSource();
        if (campo != null && campo.getValue() != null) {
            var sTmp = campo.getValue().replace(/[^0-9]/g, "");
            if (sTmp.length != 8) {
                campo.setValue(null);
                alert("CPF fora da faixa 8 dígitos sequenciais! Ex: 845.854.789-89");
            }
            else {
                campo.setValue(sTmp.substr(0, 2) + "." + sTmp.substr(2, 3) + "-" + sTmp.substr(5, 3));
            }
        }
    },

    //Get lookup text value
    GetLoockupText: function (atributo) {
        var lookupObject = Xrm.Page.getAttribute(atributo);
        var valor = null;
        if (lookupObject != null) {
            var lookUpObjectValue = lookupObject.getValue();
            if (lookUpObjectValue != null)
                valor = lookUpObjectValue[0].name.toUpperCase();
        }
        return valor;
    },

    //Get the id from lookup field
    GetLookupId: function (atributo) {
        var lookupObject = Xrm.Page.getAttribute(atributo);
        var valor = null;
        if (lookupObject != null) {
            var lookUpObjectValue = lookupObject.getValue();
            if (lookUpObjectValue != null)
                valor = lookUpObjectValue[0].id;
        }
        return valor;
    },

    //Set a field value and put in submit mode.
    AlteraCampo: function (campo, valor) {
        Xrm.Page.getAttribute(campo).setValue(valor);
        Xrm.Page.getAttribute(campo).setSubmitMode("always");
    },

    //Clear lookup field content
    ClearLoockup: function (atributo) {
        var lookupObject = Xrm.Page.getAttribute(atributo);
        if (lookupObject != null)
            lookupObject.setValue(null);
    },

    //Enable/Disable a section
    BloquearSecao: function (nomeSecao, status) {
        var ctrlName = Xrm.Page.ui.controls.get();
        for (var i in ctrlName) {
            var ctrl = ctrlName[i];
            var ctrlSection = ctrl.getParent().getName();
            if (ctrlSection == nomeSecao)
                ctrl.setDisabled(status);
        }
    },

    //Enable/Disable a tab
    BloquearTab: function (nomeTab, status) {
        var tab = Xrm.Page.ui.tabs.get(nomeTab);
        if (tab == null) alert("Atenção: A Guia " + nomeTab + " não existe no formulário.");
        else {
            var tabsections = tab.sections.get();
            for (var i in tabsections) {
                var secname = tabsections[i].getName();
                CRM.Forms.BloquearSecao(secname, status);
            }
        }
    },
    
    //Show a mesage if form is dirty. Used to prevent some service call before save
    IsFormDirty: function () {
        var isDirty = Xrm.Page.data.entity.getIsDirty();
        if (isDirty) {
            CRM.Forms.AdicionaNotificacao('Salve o registro antes de realizar esta operação', 'WARNING', msgForm);
            return true;
        }
        else
            return false;
    },

    //Set a option value using a text to mach
    SetaListaPorValor: function (optionsetAttribute, optionText) {
        if (optionText == null) return;
        var options = Xrm.Page.getAttribute(optionsetAttribute).getOptions();
        for (i = 0; i < options.length; i++) {
            if (options[i].text.toUpperCase() == optionText.toUpperCase()) {
                Xrm.Page.getAttribute(optionsetAttribute).setValue(options[i].value);
                Xrm.Page.getAttribute(optionsetAttribute).setSubmitMode("always");
            }
        }
    },
    
    //Disable a form
    DesabilitaFormulario: function (onOff) {
        Xrm.Page.ui.controls.forEach(function (control, index) {
            if (CRM.Forms.ControleTemAtributos(control)) {
                control.setDisabled(onOff);
            }
        });
    },

    //Enable/Disable a list of fields. Use comma to inform field list
    DesabilitarCampos: function (campos, bloqueio) {
        var tmp = campos.toString().split(";");

        for (var i = 0; i < tmp.length; i++) {
            var controle = Xrm.Page.getControl(tmp[i]);
            if (controle != null)
                controle.setDisabled(bloqueio);
        }
    },

    //Clear a entity section
    LimpaSecao: function (secao) {
        secao.controls.forEach(function (control, controlIndex) {
            control.getAttribute().setValue(null);
            control.getAttribute().setRequiredLevel("none");
            control.getAttribute().setSubmitMode("always");
        });
    },

    //Check if a form is in edit mode
    FormEditavel: function () {
        return Xrm.Page.ui.getFormType() == FORM_TYPE_CREATE || Xrm.Page.ui.getFormType() == FORM_TYPE_UPDATE;
    },

    //Show/Hide a section using a section name and container tab
    ExibeSecao: function (tabName, secaoName, visivel) {
        var tabCtrl = Xrm.Page.ui.tabs.get(tabName);
        if (tabCtrl && tabCtrl.sections.get(secaoName))
            tabCtrl.sections.get(secaoName).setVisible(visivel);
    },


    //Make a call to web api in Sincronous mode. Use this with caution and only if async is not possible. 
    QueryApiSinc: function (query) {
        var clientURL = Xrm.Utility.getGlobalContext().getClientUrl();
        var req = new XMLHttpRequest();
        req.open("GET", encodeURI(clientURL + "/api/data/v9.0/" + query), false);
        req.setRequestHeader("Accept", "application/json");
        req.setRequestHeader("Content-Type", "application/json; charset=utf-8");
        req.setRequestHeader("OData-MaxVersion", "4.0");
        req.setRequestHeader("OData-Version", "4.0");
        req.send(null);
        if (req.status === 200) {
            return JSON.parse(req.response);
        }
    },

    CallCustomAPIAsinc: function (url, method, sucessCallback) {
        var req = new XMLHttpRequest();
        req.open("GET", url + method, true);
        req.setRequestHeader("OData-MaxVersion", "4.0");
        req.setRequestHeader("OData-Version", "4.0");
        req.setRequestHeader("Accept", "application/json");
        req.setRequestHeader("Content-Type", "application/json; charset=utf-8");
        req.setRequestHeader("Access-Control-Allow-Origin", "*");
        
        req.onreadystatechange = sucessCallback;
        req.send();
    }

}