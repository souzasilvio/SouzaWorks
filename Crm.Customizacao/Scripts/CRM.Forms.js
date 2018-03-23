var msgForm = "msgForm";
var FORM_TYPE_CREATE = 1;
var FORM_TYPE_UPDATE = 2;
var FORM_TYPE_READ_ONLY = 3;
var FORM_TYPE_DISABLED = 4;
var FORM_TYPE_BULK_EDIT = 6;

var CRM = CRM || {};
CRM.Forms = CRM.Forms || {};
CRM.Forms = {
    //Adiciona mensagem com tipo ERROR, WARNING ou INFO
    AdicionaNotificacao: function (mensagem, tipo, id) { Xrm.Page.ui.clearFormNotification(id);Xrm.Page.ui.setFormNotification(mensagem, tipo, id);},
    //Limpa notificação criada com um id
    LimpaNotificacao: function (id) { Xrm.Page.ui.clearFormNotification(id); },
    //Obter texto selecionado de campo option list
    ObterTexto: function (nomeAtributo) { Xrm.Page.getAttribute(nomeAtributo).getText(); },
    //Obter nome do usuário atual
    ObterUsuarioNome: function () { return Xrm.Page.context.getUserName(); },
    //obter id do usuário 'sem chaves'
    ObterUsuarioId: function () { return Xrm.Page.context.getUserId().replace("}", "").replace("{", ""); },
    //Exibe uma mensagem de confirmação com funcoes de callback para respostas
    ExibeConfirmacao: function (mensagem, funcaoSim, funcaoNao) { Xrm.Utility.confirmDialog(mensagem, funcaoSim, funcaoNao); },
    //Seta o valor em campo lookup tem o id e nome do registro obtido em um consulta
    AlteraLookup: function (nomeAtributo, nomeEntidade, Id, Nome) {
        var lookupReference = [];
        lookupReference[0] = {};
        lookupReference[0].id = Id;
        lookupReference[0].entityType = nomeEntidade;
        lookupReference[0].name = Name;
        Xrm.Page.getAttribute(nomeAtributo).setValue(lookupReference);
    },    
    /*Verifica se usuario atual está na equipe informada*/
    UsuarioEmEquipe: function (equipe) {
        var consulta = "teams?$select=teamid,name&$filter=name eq '" + equipe + "'";
        var registroRetornado = CRM.WebAPI.ObterSincrono(consulta);
        if (registroRetornado == null) {
            CRM.Forms.AdicionaNotificacao("Equipe informada não existe!", 'ERROR', msgForm);
            return false;
        }
        var idEquipe = registroRetornado.teamid;
        var idUsuario = CRM.Forms.ObterUsuarioId();
        filtro = "teammemberships?$select=systemuserid,teamid&$filter=systemuserid eq " + idUsuario + " and teamid eq " + idEquipe ;
        registroRetornado = CRM.WebAPI.ObterSincrono(filtro);
        return registroRetornado == null ? false : true;
    },
    /*Coloca em maiusculo os campos string e memo. ignora campos da lista.*/
    SetFormUpperCase: function (camposIgnore) {
        var controls = Xrm.Page.ui.controls.get();
        var tmpIgnore = camposIgnore == null ? new Array() : camposIgnore.split(";");
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
    /*Formatação de campo Telefone*/
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
                //case 13:rever
                //    campo.setValue("+" + sTmp.substr(0, 2) + " (" + sTmp.substr(2, 2) + ") " + sTmp.substr(4, 5) + "-" + sTmp.substr(7, 4));
                    break;
                default:
                    alert("Telefone inválido. Digite o ddd e telefone com 8 ou 9 dígitos. Ex:(11) 8765-4321 ou (011) 98765-4321.");
                    campo.setValue(null);
                    break;
            }
        }
    },
    /*Formatação de campo cep*/
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
    /*Formatação de campo CPF*/
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
    //Obter o valor texto de um lookup
    ObterTextoLoockup: function (atributo) {
        var lookupObject = Xrm.Page.getAttribute(atributo);
        var valor = null;
        if (lookupObject != null) {
            var lookUpObjectValue = lookupObject.getValue();
            if (lookUpObjectValue != null)
                valor = lookUpObjectValue[0].name.toUpperCase();
        }
        return valor;
    },
    //Obtem o id de um campo lookup    
    ObterIDLoockup: function (atributo) {
        var lookupObject = Xrm.Page.getAttribute(atributo);
        var valor = null;
        if (lookupObject != null) {
            var lookUpObjectValue = lookupObject.getValue();
            if (lookUpObjectValue != null)
                valor = lookUpObjectValue[0].id;
        }
        return valor;
    },
    //Altera um campo e define o submite mode para salvar mesmo se desabilitado.
    AlteraCampo: function (campo, valor) {
        Xrm.Page.getAttribute(campo).setValue(valor);
        Xrm.Page.getAttribute(campo).setSubmitMode("always");
    },
    //limpa um campo lookup
    LimpaLoockup: function (atributo) {
        var lookupObject = Xrm.Page.getAttribute(atributo);
        if (lookupObject != null)
            lookupObject.setValue(null);
    },
    //Habilita/Desabilita uma seção
    BloquearSecao: function (nomeSecao, status) {
        var ctrlName = Xrm.Page.ui.controls.get();
        for (var i in ctrlName) {
            var ctrl = ctrlName[i];
            var ctrlSection = ctrl.getParent().getName();
            if (ctrlSection == nomeSecao)
                ctrl.setDisabled(status);
        }
    },
    //Habilita/Desabilita uma guia
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
    //Obtem data no formato dd/mm/yyyy de campo data
    ObtemDataString: function (campo) {
        var dateFieldValue = Xrm.Page.getAttribute(campo).getValue();
        var year = dateFieldValue.getFullYear() + "";
        var month = (dateFieldValue.getMonth() + 1) + "";
        var day = dateFieldValue.getDate() + "";
        return day + "/" + month + "/" + year;
    },
    //Retorna true se entity tem alteração. uma mensagem é exibida se houver.
    AlteracaoPendente: function () {
        var isDirty = Xrm.Page.data.entity.getIsDirty();
        if (isDirty) {
            CRM.Forms.AdicionaNotificacao('Salve o registro antes de realizar esta operação', 'WARNING', msgForm);
            return true;
        }
        else
            return false;
    },
    //Altera o valor selecionado em optionset dado um valor texto
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
    //Retorna se controle tem atributos. Controles especiais como iframe, grid e subgrid nao tem
    ControleTemAtributos: function (control) {
        var controlType = control.getControlType();
        return controlType != "iframe" && controlType != "webresource" && controlType != "subgrid";
    },
    //Desabilita um formulário
    DesabilitaFormulario: function (onOff) {
        Xrm.Page.ui.controls.forEach(function (control, index) {
            if (CRM.Forms.ControleTemAtributos(control)) {
                control.setDisabled(onOff);
            }
        });
    },
    //Habilita/Desabilita uma lista de campos separadas por ponto-virgula
    DesabilitarCampos: function (campos, bloqueio) {
        var tmp = campos.toString().split(";");

        for (var i = 0; i < tmp.length; i++) {
            var controle = Xrm.Page.getControl(tmp[i]);
            if (controle != null)
                controle.setDisabled(bloqueio);
        }
    },
    //Recebe um controle do tipo section e limpa todos os seus atributos
    LimpaSecao: function (secao) {
        secao.controls.forEach(function (control, controlIndex) {
            control.getAttribute().setValue(null);
            control.getAttribute().setRequiredLevel("none");
            control.getAttribute().setSubmitMode("always");
        });
    },
    //Retorna true se form em modo create ou update
    FormEditavel: function () {
        return Xrm.Page.ui.getFormType() == FORM_TYPE_CREATE || Xrm.Page.ui.getFormType() == FORM_TYPE_UPDATE;
    },
    //Exibe/Oculta uma seção dado o nome da tab que contem a secao e o nome da seção
    ExibeSecao: function (tabName, secaoName, visivel) {
        var tabCtrl = Xrm.Page.ui.tabs.get(tabName);
        if (tabCtrl && tabCtrl.sections.get(secaoName))
            tabCtrl.sections.get(secaoName).setVisible(visivel);
    },
    //Obtem o assunto pai de um dado id assunto
    ObterAssuntoPai: function (idAssunto) {
        var consulta = "subjects(" + idAssunto + ")?$select=title&$expand=parentsubject($select=subjectid,title)";
        var assunto = CRM.WebAPI.ObterSincrono(consulta);
        if (assunto != null && assunto.parentsubject != null) {
            var assuntoPai = new Object();
            assuntoPai.subjectid = assunto.parentsubject.subjectid;
            assuntoPai.title = assunto.parentsubject.title;
            return assuntoPai;
        }
        else {
            return null;
        }
    },
    //Retorna o nível de um assunto dentro da arvore de assuntos
    ObterNivelAssunto: function (idAssunto) {
        nivel = 1;
        while (true) {
            var assunto = CRM.Forms.ObterAssuntoPai(idAssunto);
            if (assunto != null) {
                idAssunto = assunto.subjectid;
                nivel++;
            }
            else
                break;
        }
        return nivel;
    },

    ObterNomeHierarquia: function (idAssunto, nomeAssunto) {
        var hierarquia = nomeAssunto;
        while (true) {
            var lkPai = CRM.Forms.ObterAssuntoPai(idAssunto);
            if (lkPai != null ) {
                hierarquia = lkPai.title + " / " + hierarquia;
                idAssunto = lkPai.subjectid;
            }
            else
                break;
        }
        return hierarquia;
    }
}