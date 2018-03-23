function Form_onload()
{
    formularioValido = true;
    var AdesaoBoletoAtual = 0;
    Pais = { BRASIL: 10 }
    DDI = { Brasil: "55" }
    Cliente_Manutencao = 200000;
    var AdesaoBoletoSim = 1;
    var AdesaoBoletoNao = 2;

    Mensagem = {
        PAIS_ESTRANGEIRO_NAO_SELECIONADO: "Para endereço estrangeiro não é possível selecionar o país BRASIL.",
        MENSAGEM_CEP_FORA_FAIXA: "Cep fora da faixa 8 dígitos sequenciais! Ex: 31080140",
        MENSAGEM_CEP_NAO_PREENCHIDO: "Cep não preenchido! Para Endereço Nacional é obrigatório o preenchido do CEP!",
        CONSULTA_CEP_NAO_DISPONIVEL: "Consulta de CEP não está disponível. Favor preencher o endereço.",
        CEP_NAO_CADASTRADO: "CEP não cadastrado, preencha o endereço!"
    }

    // Códigos de filter lookup de cidades por estados
    CodigoFiltrerLookup = {
        CIDADES_SP: "10031003",
        CIDADES_RJ_SP: "10031004",
        CIDADES_MG: "10031005",
        CIDADES_BA_SE: "10031006",
        CIDADES_AL_PB_PE_RN: "10031007",
        CIDADES_AC_AM_AP_CE_MA_PA_PI_RR: "10031008",
        CIDADES_DF_GO_MS_MT_RO_TO: "10031009",
        CIDADES_PR_SC: "10031010",
        CIDADES_RS: "10031011"
    }

    try {

        function Load() {
            EstadoCivil =
                {
                    SOLTEIRO: 1,
                    CASADO: 2,
                    VIUVO: 3,
                    DIVORCIADO: 4,
                    SEPARADO: 5,
                    UNIAO_ESTAVEL: 6
                }

            CEP_LENGTH = 8;

            //Adiciona Script para ser usado no click do botão
            //var elm = document.createElement("script");
            //elm.src = "/_static/_grid/cmds/util.js";
            //document.appendChild(elm);

            crmForm.SalvaDiaMesNascimento = function() {
                if (Xrm.Page.getAttribute("new_datadenascimento").getValue() != null) {
                    var dataNascimento = Xrm.Page.getAttribute("new_datadenascimento").getValue();
                    Xrm.Page.getAttribute("new_dia_nascimento").setValue(dataNascimento.getDate());
                    Xrm.Page.getAttribute("new_mes_nascimento").setValue((dataNascimento.getMonth() + 1));
                    Xrm.Page.getAttribute("new_dia_nascimento").setSubmitMode("always");
                    Xrm.Page.getAttribute("new_mes_nascimento").setSubmitMode("always");
                }
            }

            //Esconde a opção "União Estável" do picklist "Estado Civil"
            Xrm.Page.getControl("new_estadocivil").removeOption(EstadoCivil.UNIAO_ESTAVEL);

            crmForm.EscondeCampo = function(nomeCampo, esconde) {
                Xrm.Page.getControl(nomeCampo).setVisible(esconde);
            }

            crmForm.DesabilitaHabilitaCampos = function(atributos, desabilita) {
                var tmp = atributos.split(";");
                for (index = 0; index < tmp.length; index++) {
                    Xrm.Page.getControl(tmp[index]).setDisabled(desabilita);
                }
            }

            //ocultando campo quantos filhos-//
            if (Xrm.Page.getAttribute("new_temfilhos").getValue() != null && Xrm.Page.getAttribute("new_temfilhos").getValue() == 1) {
                Xrm.Page.getControl("new_quantidadedefilhos").setVisible(true);
                Xrm.Page.getControl("new_quantidadedefilhos").setVisible(true);
            }
            else {
                Xrm.Page.getControl("new_quantidadedefilhos").setVisible(false);
                Xrm.Page.getControl("new_quantidadedefilhos").setVisible(false);
            }

            //ocultando guias//
            Xrm.Page.ui.tabs.get(2).setVisible(false);

            //ocultando campos inscrição municipal e estadual-//
            if (Xrm.Page.getAttribute("new_exinscricaomunicipal").getValue() == 0) {
                Xrm.Page.getControl("new_inscricaomunicipal").setVisible(false);
                Xrm.Page.getControl("new_inscricaomunicipal").setVisible(false);
            }

            if (Xrm.Page.getAttribute("new_exinscricaoestadual").getValue() == 0) {
                Xrm.Page.getControl("new_inscricaoestadual").setVisible(false);
                Xrm.Page.getControl("new_inscricaoestadual").setVisible(false);
            }

            //Condicao no Botao SIm/NAO para pessoa física ou pessoa jurídica
            if (Xrm.Page.getAttribute("new_tipodecliente").getValue() != null && Xrm.Page.getAttribute("new_tipodecliente").getValue() == 0) {
                Xrm.Page.ui.tabs.get(1).setVisible(true);
                Xrm.Page.ui.tabs.get(2).setVisible(false);

            }
            else {
                Xrm.Page.ui.tabs.get(1).setVisible(false);
                Xrm.Page.ui.tabs.get(2).setVisible(true);
            }


            //CONDIÇÃO DO BOTÃO SIM/NÃO PARA A GUIA POSUI IMOVEL--------------------------
            if (Xrm.Page.getAttribute("new_possuiimovel").getValue() != null && Xrm.Page.getAttribute("new_possuiimovel").getValue() == 1) {
                Xrm.Page.getControl("new_motivodacompra").setDisabled(false);
                Xrm.Page.getAttribute("new_motivodanaocompra").setValue(null);
                Xrm.Page.getControl("new_motivodanaocompra").setDisabled(true);
            }
            else {
                Xrm.Page.getControl("new_motivodanaocompra").setDisabled(false);
                Xrm.Page.getAttribute("new_motivodacompra").setValue(null);
                Xrm.Page.getControl("new_motivodacompra").setDisabled(true);
            }

            //Bit - sim - não - Ocultar nome do campo e campo do formulario CAMPO INVESTIMENTO--
            if (Xrm.Page.getAttribute("new_investimento").getValue() != null && Xrm.Page.getAttribute("new_investimento").getValue() == false) {
                Xrm.Page.getControl("new_bairroparainvestimento").setVisible(false);
                Xrm.Page.getControl("new_bairroparainvestimento").setVisible(false);
            }
            else {
                Xrm.Page.getControl("new_bairroparainvestimento").setVisible(true);
                Xrm.Page.getControl("new_bairroparainvestimento").setVisible(true);
            }

            //Chama evento onchange do campo Nacionalidade
            Xrm.Page.getAttribute("new_nacionalidade").fireOnChange();

            //ocultar campo de construtoras em pesquisa de midia-------------
            if (Xrm.Page.getAttribute("new_outraconstrutora").getValue() != null && Xrm.Page.getAttribute("new_outraconstrutora").getValue() == 0) {
                Xrm.Page.getControl("new_construtorasid").setVisible(false);
                Xrm.Page.getControl("new_construtorasid").setVisible(false);
            }
            else {
                Xrm.Page.getControl("new_construtorasid").setVisible(true);
                Xrm.Page.getControl("new_construtorasid").setVisible(true);
            }

            //ocultar campo de sites em pesquisa de midia-------------
            if (Xrm.Page.getAttribute("new_pesquisounainternet").getValue() != null && Xrm.Page.getAttribute("new_pesquisounainternet").getValue() == 0) {
                Xrm.Page.getControl("new_qualosite").setVisible(false);
                Xrm.Page.getControl("new_qualosite").setVisible(false);
            }
            else {
                Xrm.Page.getControl("new_qualosite").setVisible(true);
                Xrm.Page.getControl("new_qualosite").setVisible(true);
            }

            if (Xrm.Page.getAttribute("new_tipodecliente").getValue() != null && Xrm.Page.getAttribute("new_tipodecliente").getValue() == true)
                Xrm.Page.getAttribute("new_grupo_contas").setValue("ZPJU");
            else
                Xrm.Page.getAttribute("new_grupo_contas").setValue("ZPFI");

            //chamar script para ocultar o campo de uf do orgao de expedicao
            Xrm.Page.getAttribute("new_orgao_expedicao").fireOnChange();

            //Setar Real como default no campo de moeda
            if (Xrm.Page.getAttribute("transactioncurrencyid").getValue() == null) {
                var lookupData = new Array();
                var lookupItem = new Object();

                lookupItem.id = "{DA713EF1-8041-DD11-A6D4-001B7845B4A6}";
                lookupItem.entityType = "transactioncurrency";
                lookupItem.name = "Real";
                lookupData[0] = lookupItem;
                Xrm.Page.getAttribute("transactioncurrencyid").setValue(lookupData);                
            }

            InformacoesUsuario = function() {
                var objeto = this;
                this.Fullname = "";
                this.Id = "";
                this.Login = "";
                this.EquipeRelacionamentoNome = "";
                this.EquipeRelacionamentoValue = "";
                this.Equipes;

                ////Obter informações.
                //var cmd = new RemoteCommand("MrvService", "ObterInformacoesUsuario", "/MRVCustomizations/");
                //var result = cmd.Execute();
                //if (result.Success) {
                //    if (result.ReturnValue.Mrv.Error) {
                //        crmForm.DesabilitarFormularioErro(result.ReturnValue.Mrv.Error);
                //    } else if (result.ReturnValue.Mrv.ErrorSoap) {
                //        crmForm.DesabilitarFormularioErro(result.ReturnValue.Mrv.ErrorSoap);
                //    }
                //    else {
                //        this.Fullname = result.ReturnValue.Mrv.Fullname;
                //        this.Id = result.ReturnValue.Mrv.Id;
                //        this.Login = result.ReturnValue.Mrv.Login;
                //        this.EquipeRelacionamentoNome = result.ReturnValue.Mrv.EquipeRelacionamentoNome;
                //        this.EquipeRelacionamentoValue = result.ReturnValue.Mrv.EquipeRelacionamentoValue;

                //        if (result.ReturnValue.Mrv.Equipes) {
                //            this.Equipes = result.ReturnValue.Mrv.Equipes.split(';');
                //        }
                //    }
                //}
                //else {
                //    //Desabilitar todo o formulário.
                //    alert("Erro na consulta das informações do usuário.");
                //    //window.location.href = window.location.href;
                //}

                objeto.PertenceA = function(nomeEquipe) {
                    for (var i = 0; i < this.Equipes.length; i++) {
                        var temp = this.Equipes[i].split('*');
                        if (temp[0].toString().toUpperCase() == nomeEquipe.toString().toUpperCase()) {
                            return true;
                        }
                    }
                    return false;
                }
            }

            Informacoes = new InformacoesUsuario();

            //Usuário Adm
            crmForm.UsuarioAdministrador = function() {
                return Informacoes.PertenceA("Administradores");
            }

            //definir campo tipo de cliente como permutante, quando o usuário pertencer a equipe "Permuta Financeira"
            if (Informacoes.PertenceA("Permuta Financeira")) {
                Xrm.Page.getControl("new_permutante").setDisabled(false);
            }

            function BloquearCampos() {
                var objeto = this;
                objeto.Proposta = function(bloqueio) {
                    crmForm.DesabilitaHabilitaCampos("new_cpf;new_cnpj", bloqueio);
                }

                //ALTERAÇÂO - DEFS 506635
                objeto.PerfilContratoERecebimento = function(bloqueio) {
                    var atributos = "new_cnpj;new_inscricaomunicipal;new_exinscricaomunicipal;new_exinscricaoestadual;new_inscricaoestadual;name;new_cpf;new_registrogeraln;new_datadeexpedicao;new_orgao_expedicao;new_uf_orgao_expedicao;new_estadocivil";
                    crmForm.DesabilitaHabilitaCampos(atributos, bloqueio);
                }

                objeto.Contrato = function(bloqueio) {
                    var atributos = "name;address1_postalcode;new_tipologradouro;address1_line1;new_numero;new_complemento;new_bairro;new_cidadeid;new_estado;new_pais;new_tipodecliente;new_registrogeraln;new_datadeexpedicao;new_orgao_expedicao;new_uf_orgao_expedicao;new_nomedopai;new_nomedamae;new_nacionalidade;new_naturalidadeid;new_sexo;new_endereco_confere;new_endereco_nacional;new_cidadeestrangeira;new_estadoestrangeiro";
                    crmForm.DesabilitaHabilitaCampos(atributos, bloqueio);
                }

                // Campos desabilitados para clientes com oportunidades ganhas
                objeto.OportunidadeGanha = function(bloqueio) {
                    var atributos = "new_cpf;new_cnpj;name;address1_postalcode;new_tipologradouro;address1_line1;new_numero;new_complemento;new_bairro;new_cidadeid;new_estado;new_pais;new_tipodecliente;new_registrogeraln;new_datadeexpedicao;new_orgao_expedicao;new_uf_orgao_expedicao;new_nomedopai;new_nomedamae;new_nacionalidade;new_naturalidadeid;new_sexo;new_endereco_confere;new_endereco_nacional;new_cidadeestrangeira;new_estadoestrangeiro;new_estadocivil;new_datadenascimento";
                    crmForm.DesabilitaHabilitaCampos(atributos, bloqueio);
                }
            }

            var bloquear = new BloquearCampos();

            if (Xrm.Page.ui.getFormType() == TypeUpdate) { //formulario for UPDATE
                //Liberar campos de códigos de cliente
                if (crmForm.UsuarioAdministrador()) {
                    crmForm.DesabilitaHabilitaCampos("new_codsap6;new_codigoparceiroconjuge;new_codigoparceirorepvendas;new_codigoparceiroprocurador;new_codigoparceirofiador", false);
                }

                if (!crmForm.UsuarioAdministrador()) {
                    //Verificar oportunidade do cliente
                    //Se existe proposta ou contrato
                    //var cmd = new RemoteCommand("MrvService", "VerficarOportunidadesContratos", "/MrvCustomizations/");
                    //cmd.SetParameter("clienteId", Xrm.Page.data.entity.getId());
                    //var resultado = cmd.Execute();
                    //Linhas de teste
                    var resultado = new Object();
                    resultado.Sucess = false;
                    if (resultado.Success) {
                        if (resultado.ReturnValue.Mrv.Error) {
                            alert(resultado.ReturnValue.Mrv.Error);
                            bloquear.Proposta(true);
                            bloquear.Contrato(true);
                        } else if (resultado.ReturnValue.Mrv.ErrorSoap) {
                            alert(resultado.ReturnValue.Mrv.ErrorSoap);
                            bloquear.Proposta(true);
                            bloquear.Contrato(true);
                        }

                        //Se verdadeiro, bloquei campos do cliente relativos a proposta - Nome e CPF/CNPJ
                        if (resultado.ReturnValue.Mrv.BloquerProposta) {
                            bloquear.Proposta(true);
                        }
                        //Se verdadeiro, bloquei campos do cliente relativos a contrato 
                        if (resultado.ReturnValue.Mrv.BloquerContrato) {
                            bloquear.Contrato(true);
                        }

                        if (resultado.ReturnValue.Mrv.BloquearOportunidade) {
                            bloquear.OportunidadeGanha(true);
                        }

                        //DEFS 506635
                        if (Informacoes.PertenceA(Equipe.ALTERACAO_CLIENTE) && !resultado.ReturnValue.Mrv.BloquearOportunidade) {
                            bloquear.PerfilContratoERecebimento(false);
                        }

                        if (Informacoes.PertenceA(Equipe.ATUALIZACAO_CADASTRAL)) {
                            bloquear.OportunidadeGanha(false);
                        }

                        if (MRV.Forms.UsuarioEmEquipe(Equipe.AT_CLIENTE_SAP) && Xrm.Page.getAttribute("accountclassificationcode").getValue() == Cliente_Manutencao) {
                            Xrm.Page.getControl("new_cod_cliente_manutencao").setDisabled(false);
                        }
                        else {
                            Xrm.Page.getControl("new_cod_cliente_manutencao").setDisabled(true);
                        }

                    } else {
                        alert("Erro na consulta do método VerficarOportunidadesContratos");
                        formularioValido = false;
                    }
                }
            }

            crmForm.TratarRetornoRemoteCommand = function(resultado, nomeMetodo) {
                var retorno = false;
                if (resultado.Success) {
                    if (resultado.ReturnValue.Mrv.Error)
                        alert(resultado.ReturnValue.Mrv.Error);
                    else if (resultado.ReturnValue.Mrv.ErrorSoap)
                        alert(resultado.ReturnValue.Mrv.ErrorSoap);
                    else
                        retorno = true;
                } else {
                    alert("Erro na consulta do método '" + nomeMetodo + "'. Contate o suporte.");
                }
                return retorno;
            }

            crmForm.ExibirCamposEstrangeiro = function(visivel) {

                // Definine a visibilidade dos campos de informações estrangeiras
                crmForm.EscondeCampo("new_cidadeestrangeira", !visivel);
                crmForm.EscondeCampo("new_estadoestrangeiro", !visivel);
            }

            crmForm.TrataExibicaoCampoEnderecoConfere = function() {
                var temPerfilDeConfereEndereco = Informacoes.PertenceA("Confere Endereço");
                crmForm.EscondeCampo("new_endereco_confere", !temPerfilDeConfereEndereco);

                if (Xrm.Page.getAttribute("new_endereco_confere").getValue() == null)
                    Xrm.Page.getAttribute("new_endereco_confere").setValue(true);
                else {
                    if (temPerfilDeConfereEndereco)
                        crmForm.TrataEnderecoConfere();
                }
            }

            crmForm.TrataEnderecoConfere = function() {
                if (Xrm.Page.getAttribute("new_endereco_nacional").getValue()) {
                    var habilitaCampoEndereco = Xrm.Page.getAttribute("new_endereco_confere").getValue();
                    crmForm.DesabilitaHabilitaCampos("new_cidadeid;new_estado;new_pais", true);
                    crmForm.DesabilitaHabilitaCampos("new_complemento;new_numero", false);
                    crmForm.DesabilitaHabilitaCampos("address1_line1;new_tipologradouro;new_bairro", habilitaCampoEndereco);
                    crmForm.DesabilitaHabilitaCampos("new_endereco_confere", !habilitaCampoEndereco);

                    if (!habilitaCampoEndereco && (Xrm.Page.ui.getFormType() == TypeCreate || Xrm.Page.ui.getFormType() == TypeUpdate)) {
                        Xrm.Page.getAttribute("new_endereco_confere").setSubmitMode("always");
                    }

                    if (Xrm.Page.getAttribute("new_pais").getValue() == null) {
                        Xrm.Page.getAttribute("new_pais").setValue(Pais.BRASIL);
                    }

                    if (Xrm.Page.getAttribute("new_pais").getValue() != Pais.BRASIL) {
                        crmForm.TrataPais();
                    }
                }
            }

            crmForm.TrataPais = function() {
                var enderecoNacional = Xrm.Page.getAttribute("new_endereco_nacional").getValue();
                if (enderecoNacional && Xrm.Page.getAttribute("new_pais").getValue() == Pais.BRASIL) {
                    Xrm.Page.getControl("new_pais").setDisabled(true);
                }
                else if (!enderecoNacional && crmForm.all.new_pais.SelectedIndex > 0 && Xrm.Page.getAttribute("new_pais").getValue() == Pais.BRASIL) {
                    alert(Mensagem.PAIS_ESTRANGEIRO_NAO_SELECIONADO);
                    crmForm.all.new_pais.SelectedIndex = 0;
                }
                else {
                    Xrm.Page.getControl("new_pais").setDisabled(false);
                }
            }

            crmForm.TratarExibicaoEnderecoNacional = function() {
                if (Xrm.Page.getAttribute("new_endereco_nacional").getValue() == null) {
                    Xrm.Page.getAttribute("new_endereco_nacional").setValue(true);
                }
                var enderecoNacional = Xrm.Page.getAttribute("new_endereco_nacional").getValue();
                if (enderecoNacional) {
                    crmForm.ExibirCamposEstrangeiro(false);
                    Xrm.Page.getControl("new_endereco_confere").setVisible(false);

                    crmForm.TrataEnderecoConfere();

                    if (Xrm.Page.getAttribute("new_pais").getValue() != Pais.BRASIL) {
                        Xrm.Page.getAttribute("new_pais").setValue(Pais.BRASIL);
                        Xrm.Page.getControl("new_pais").setDisabled(true);
                    }
                    Xrm.Page.getAttribute("new_cidadeestrangeira").setValue(null);
                    Xrm.Page.getAttribute("new_estadoestrangeiro").setValue(null);
                }
                else {
                    Xrm.Page.getControl("new_endereco_confere").setVisible(true);
                    crmForm.all.new_estado.SelectedIndex = 0;
                    Xrm.Page.getControl("new_estado").setDisabled(true);
                    Xrm.Page.getControl("new_cidadeid").setDisabled(true);
                    Xrm.Page.getAttribute("new_cidadeid").setValue(null);
                    Xrm.Page.getAttribute("new_estado").setValue(null);
                    if (Xrm.Page.getAttribute("new_pais").getValue() == Pais.BRASIL) {
                        crmForm.all.new_pais.SelectedIndex = 0;
                    }
                    crmForm.ExibirCamposEstrangeiro(true);
                }
            }

            crmForm.TratarEnderecoNacional = function() {
                var enderecoNacional = Xrm.Page.getAttribute("new_endereco_nacional").getValue();
                if (enderecoNacional) {
                    crmForm.ExibirCamposEstrangeiro(false);
                    Xrm.Page.getControl("new_endereco_confere").setVisible(false);
                    if (Xrm.Page.getAttribute("new_pais").getValue() != Pais.BRASIL) {
                        Xrm.Page.getAttribute("new_pais").setValue(Pais.BRASIL);
                        Xrm.Page.getControl("new_pais").setDisabled(true);
                    }
                    Xrm.Page.getAttribute("new_cidadeestrangeira").setValue(null);
                    Xrm.Page.getAttribute("new_estadoestrangeiro").setValue(null);
                }
                else {
                    Xrm.Page.getControl("new_endereco_confere").setVisible(true);
                    Xrm.Page.getControl("new_estado").setDisabled(true);
                    Xrm.Page.getControl("new_cidadeid").setDisabled(true);
                    Xrm.Page.getAttribute("new_cidadeid").setValue(null);
                    crmForm.all.new_estado.SelectedIndex = 0;
                    Xrm.Page.getAttribute("new_estado").setValue(null);
                    if (Xrm.Page.getAttribute("new_pais").getValue() == Pais.BRASIL) {
                        crmForm.all.new_pais.SelectedIndex = 0;
                    }
                    Xrm.Page.getControl("new_pais").setDisabled(false);
                    crmForm.ExibirCamposEstrangeiro(true);
                }
            }

            crmForm.TrataExibicaoCampoEnderecoConfere();
            crmForm.TratarExibicaoEnderecoNacional();

            crmForm.BuscaDadosTelefone = function(tipo, campo) {
                var cidadeId = null;
                var enderecoNacional = Xrm.Page.getAttribute("new_endereco_nacional").getValue();

                if (enderecoNacional) {
                    if (Xrm.Page.getAttribute("new_cidadeid").getValue() == null) {
                        alert("Preencha o campo Cidade!");
                        event.srcElement.setValue("");
                        return false;
                    }

                    cidadeId = Xrm.Page.getAttribute("new_cidadeid").getValue()[0].id;
                }

                if (event.srcElement.getValue() != null && event.srcElement.getValue() == "..") {
                    if (campo == "telephone1" && Xrm.Page.getAttribute("new_cidadeid").getValue() != null && enderecoNacional) {
                        var cmdDadosCidade = new RemoteCommand("MrvService", "retornarEstadoEDDD", "/MRVCustomizations/");
                        cmdDadosCidade.SetParameter("cidadeId", cidadeId);
                        var oResultado = cmdDadosCidade.Execute();
                        var ddd = "";
                        if (oResultado.ReturnValue.Mrv.Error && oResultado.ReturnValue.Mrv.ErrorSoap) {
                            ddd = "";
                        }
                        else {
                            if (crmForm.TratarRetornoRemoteCommand(oResultado, "retornarEstadoEDDD")) {
                                if (typeof (oResultado.ReturnValue.Mrv.ddd) == "object") //object = retorno vazio, ou seja, não existe ddd para a cidade informada
                                    ddd = "";
                                else
                                    ddd = oResultado.ReturnValue.Mrv.ddd;
                            }
                        }

                        //Verifica se o país é brasil
                        //Obs: não foi implementado ddi para demais paises.
                        var ddi = (crmForm.all.new_pais.SelectedIndex == 10 ? 55 : "");

                        retorno = openStdDlg("/MrvWeb/Phone/Default.aspx?tipo=" + tipo + "&ddi=" + ddi + "&ddd=" + ddd, null, 250, 250);
                    }
                    else {
                        retorno = openStdDlg("/MrvWeb/Phone/Default.aspx?tipo=" + tipo, null, 250, 250);
                    }

                    if (typeof (retorno) != "undefined")
                        event.srcElement.setValue(retorno);
                    else
                        event.srcElement.setValue("");
                } else if (event.srcElement.getValue() != null && event.srcElement.getValue() != "..") {
                    alert("Digite apenas ..");
                    event.srcElement.setValue("");
                }
            }

            crmForm.ValidarEndereco = function() {

                var enderecoNacional = Xrm.Page.getAttribute("new_endereco_nacional").getValue();

                var resumido = Xrm.Page.getAttribute("address2_line1").getValue() != null ? Xrm.Page.getAttribute("address2_line1").getValue() : "";
                var endereco = Xrm.Page.getAttribute("address1_line1").getValue() != null ? Xrm.Page.getAttribute("address1_line1").getValue() : "";
                var numero = Xrm.Page.getAttribute("new_numero").getValue() != null ? Xrm.Page.getAttribute("new_numero").getValue() : "";
                var complemento = Xrm.Page.getAttribute("new_complemento").getValue() != null ? Xrm.Page.getAttribute("new_complemento").getValue() : "";
                var tipo_logradouro = Xrm.Page.getAttribute("new_tipologradouro").getValue() != null ? Xrm.Page.getAttribute("new_tipologradouro").getValue() : "";
                var bairro = Xrm.Page.getAttribute("new_bairro").getValue() != null ? Xrm.Page.getAttribute("new_bairro").getValue() : "";

                if (enderecoNacional) {

                    if (Xrm.Page.getAttribute("address1_postalcode").getValue() == null && (endereco != "" || numero != "" || complemento != "" || resumido != "" || tipo_logradouro != "" || bairro != "")) {
                        alert(Mensagem.MENSAGEM_CEP_NAO_PREENCHIDO);
                        return false;
                    }

                    if (Xrm.Page.getAttribute("address1_postalcode").getValue() != null) {
                        var cep = Xrm.Page.getAttribute("address1_postalcode").getValue().replace(/[^0-9]/g, "");

                        if (cep.length != CEP_LENGTH) {
                            alert(Mensagem.MENSAGEM_CEP_FORA_FAIXA);
                            return false;
                        }
                    }
                }

                return true;
            }

            crmForm.LimpaCampos = function() {
                Xrm.Page.getAttribute("new_bairro").setValue(null);
                Xrm.Page.getAttribute("new_complemento").setValue(null);
                Xrm.Page.getAttribute("address1_line1").setValue(null);
                Xrm.Page.getAttribute("new_tipologradouro").setValue(null);
                Xrm.Page.getAttribute("new_numero").setValue(null);
                Xrm.Page.getAttribute("address2_line1").setValue(null);
                crmForm.all.new_estado.SelectedIndex = 0;
                crmForm.all.new_pais.SelectedIndex = 0;
                Xrm.Page.getAttribute("new_estadoestrangeiro").setValue(null);
                Xrm.Page.getAttribute("new_cidadeestrangeira").setValue(null);
                Xrm.Page.getAttribute("new_cidadeid").setValue(null);
            }

            crmForm.ValidarCEP = function(campo) {
                crmForm.LimpaCampos();
                if (typeof (campo) != "undefined" && campo != null) {
                    if (campo.getValue() != null) {
                        // Valida se é um endereço nacional
                        if (Xrm.Page.getAttribute("new_endereco_nacional").getValue()) {
                            var sTmp = campo.getValue().replace(/[^0-9]/g, "");

                            if (sTmp.length != 8) {
                                campo.setValue(null);
                                alert(Mensagem.MENSAGEM_CEP_FORA_FAIXA);
                            }
                            else {
                                crmForm.ObterEndereco(campo.getValue());
                                campo.setValue(sTmp.substr(0, 2) + "." + sTmp.substr(2, 3) + "-" + sTmp.substr(5, 3));
                            }
                        }
                    }
                    else { crmForm.ObterEndereco(campo.getValue()); }
                }
            }

            // Define os filtros de cidade à partir do cep informado
            crmForm.DefinirFiltroCidade = function(cep) {
                // Recupera o primeiro digito do cep
                var primeiroDigitoCep = cep.substring(0, 1);
                var codigoLookup = "";
                switch (primeiroDigitoCep) {
                    case "0":
                    case "1":
                        codigoLookup = CodigoFiltrerLookup.CIDADES_SP;
                        break;
                    case "2":
                        codigoLookup = CodigoFiltrerLookup.CIDADES_RJ_SP;
                        break;
                    case "3":
                        codigoLookup = CodigoFiltrerLookup.CIDADES_MG;
                        break;
                    case "4":
                        codigoLookup = CodigoFiltrerLookup.CIDADES_BA_SE;
                        break;
                    case "5":
                        codigoLookup = CodigoFiltrerLookup.CIDADES_AL_PB_PE_RN;
                        break;
                    case "6":
                        codigoLookup = CodigoFiltrerLookup.CIDADES_AC_AM_AP_CE_MA_PA_PI_RR;
                        break;
                    case "7":
                        codigoLookup = CodigoFiltrerLookup.CIDADES_DF_GO_MS_MT_RO_TO;
                        break;
                    case "8":
                        codigoLookup = CodigoFiltrerLookup.CIDADES_PR_SC;
                        break;
                    case "9":
                        codigoLookup = CodigoFiltrerLookup.CIDADES_RS;
                        break;
                }

                var oParam = "objectTypeCode=" + codigoLookup + "&filterDefault=false&attributesearch=new_name";
                crmForm.FilterLookup(crmForm.all.new_cidadeid, 10031, "/MRVWeb/FilterLookup/FilterLookup.aspx", oParam);
            }

            crmForm.SetUF = function(nome, picklistField) {
                for (i = 0; i < picklistField.Options.length; i++) {
                    if (picklistField.Options[i].Text.toUpperCase() == nome.toUpperCase())
                        picklistField.SelectedIndex = i;
                }
            }

            crmForm.SetTipoLogradouro = function(nome, picklistField) {
                for (i = 0; i < picklistField.Options.length; i++) {
                    if (picklistField.Options[i].Text.toUpperCase() == nome.toUpperCase()) {
                        picklistField.SelectedIndex = i;
                        return;
                    }
                }
                picklistField.SelectedIndex = 41;
            }

            crmForm.ObterEndereco = function(cep) {

                if (cep != null) {
                    cep = cep.replace(".", "");
                    cep = cep.replace("-", "");

                    var cmd = new RemoteCommand("MrvService", "GetAddressByCep", "/MRVCustomizations/");
                    cmd.SetParameter("cep", cep);
                    var result = cmd.Execute();
                    if (result.Success) {

                        if (!result.ReturnValue.Mrv.IsNull && !result.ReturnValue.Mrv.Error) {
                            if (typeof (result.ReturnValue.Mrv.TIPORUA) != "object" && typeof (result.ReturnValue.Mrv.NOMERUA) != "object") {
                                Xrm.Page.getAttribute("address1_line1").setValue(result.ReturnValue.Mrv.TIPORUA + " " + result.ReturnValue.Mrv.NOMERUA);
                            }
                            else if (typeof (result.ReturnValue.Mrv.NOMERUA) != "object") {
                                Xrm.Page.getAttribute("address1_line1").setValue(result.ReturnValue.Mrv.NOMERUA);
                            }
                            else {
                                Xrm.Page.getAttribute("address1_line1").setValue(null);
                            }

                            if (Xrm.Page.getAttribute("address1_line1").getValue() == "" || Xrm.Page.getAttribute("address1_line1").getValue() == null)
                                Xrm.Page.getControl("address1_line1").setDisabled(false);
                            else
                                Xrm.Page.getControl("address1_line1").setDisabled(true);

                            if (typeof (result.ReturnValue.Mrv.TIPORUA) != "object") {
                                crmForm.SetTipoLogradouro(result.ReturnValue.Mrv.TIPORUA, crmForm.all.new_tipologradouro);
                                Xrm.Page.getControl("new_tipologradouro").setDisabled(true);
                            }
                            else {
                                Xrm.Page.getControl("new_tipologradouro").setDisabled(false);
                            }

                            if (typeof (result.ReturnValue.Mrv.COMPLEMENTO) != "object") {
                                if (result.ReturnValue.Mrv.COMPLEMENTO.length <= 10)
                                    Xrm.Page.getAttribute("new_complemento").setValue(result.ReturnValue.Mrv.COMPLEMENTO);
                            }

                            if (typeof (result.ReturnValue.Mrv.NOMERUAREDUZIDO) != "object") {
                                Xrm.Page.getAttribute("address2_line1").setValue(result.ReturnValue.Mrv.NOMERUAREDUZIDO);
                                Xrm.Page.getControl("address2_line1").setDisabled(true);
                            }

                            if (typeof (result.ReturnValue.Mrv.UF) != "object") {
                                crmForm.SetUF(result.ReturnValue.Mrv.UF, crmForm.all.new_estado);
                                crmForm.all.new_pais.SelectedIndex = 10;
                            }

                            if (typeof (result.ReturnValue.Mrv.BAIRRO) != "object") {
                                if (result.ReturnValue.Mrv.BAIRRO.length <= 15) {
                                    Xrm.Page.getAttribute("new_bairro").setValue(result.ReturnValue.Mrv.BAIRRO);
                                    Xrm.Page.getControl("new_bairro").setDisabled(true);
                                } else {
                                    Xrm.Page.getControl("new_bairro").setDisabled(false);
                                    Xrm.Page.getAttribute("new_bairro").setValue(result.ReturnValue.Mrv.BAIRRO.slice(0, 15));
                                }
                            }
                            else {
                                Xrm.Page.getControl("new_bairro").setDisabled(false);
                            }

                            if (typeof (result.ReturnValue.Mrv.CIDADE) != "object" && typeof (result.ReturnValue.Mrv.UF) != "object") {
                                var cmdCidade = new RemoteCommand("MrvService", "GetCityByNameUf", "/MRVCustomizations/");
                                cmdCidade.SetParameter("NameCidade", result.ReturnValue.Mrv.CIDADE);
                                cmdCidade.SetParameter("UF", result.ReturnValue.Mrv.UF);
                                var oResultado = cmdCidade.Execute();
                                if (oResultado.Success) {
                                    if (oResultado.ReturnValue.Mrv.Cidade != false) {
                                        var lookupData = new Array();
                                        var lookupItem = new Object();

                                        lookupItem.id = oResultado.ReturnValue.Mrv.Cidade;
                                        lookupItem.entityType = 'new_cidade';
                                        lookupItem.name = result.ReturnValue.Mrv.CIDADE;
                                        lookupData[0] = lookupItem;
                                        Xrm.Page.getAttribute("new_cidadeid").setValue(lookupData);
                                    }
                                }
                            }
                            crmForm.DesabilitaHabilitaCampos("new_estado;new_cidadeid;new_pais", true);
                            crmForm.ExibirCamposEstrangeiro(false);
                            Xrm.Page.getAttribute("new_estadoestrangeiro").setValue(null);
                            Xrm.Page.getAttribute("new_cidadeestrangeira").setValue(null);

                            var enderecoConfere = (Xrm.Page.getAttribute("address1_line1").getValue() != null && Xrm.Page.getAttribute("new_tipologradouro").getValue() != null &&
                                                    Xrm.Page.getAttribute("new_cidadeid").getValue() != null && Xrm.Page.getAttribute("new_bairro").getValue() != null);

                            Xrm.Page.getAttribute("new_endereco_confere").setValue(enderecoConfere);
                            crmForm.DesabilitaHabilitaCampos("new_endereco_confere", !enderecoConfere);

                            if (Xrm.Page.ui.getFormType() == TypeCreate || Xrm.Page.ui.getFormType() == TypeUpdate) {
                                Xrm.Page.getAttribute("new_endereco_confere").setSubmitMode("always");
                            }

                        }
                        else {
                            if (result.ReturnValue.Mrv.Error) {
                                alert(Mensagem.CONSULTA_CEP_NAO_DISPONIVEL);
                            }
                            else {
                                alert(Mensagem.CEP_NAO_CADASTRADO);
                                // Define os filtros de cidade, conforme o cep
                                crmForm.DefinirFiltroCidade(cep);
                            }

                            Xrm.Page.getAttribute("new_endereco_confere").setValue(false);
                            crmForm.DesabilitaHabilitaCampos("new_endereco_confere", true);

                            if (Xrm.Page.ui.getFormType() == TypeCreate || Xrm.Page.ui.getFormType() == TypeUpdate) {
                                Xrm.Page.getAttribute("new_endereco_confere").setSubmitMode("always");
                            }

                            crmForm.LimpaCampos();
                            crmForm.DesabilitaHabilitaCampos("new_cidadeid;address1_line1;new_bairro;new_tipologradouro", false);
                            crmForm.DesabilitaHabilitaCampos("new_estado;new_pais", true);
                            crmForm.ExibirCamposEstrangeiro(false);
                        }
                    }
                }
            }

            crmForm.ResumirEndereco = function() {
                if (Xrm.Page.getAttribute("address1_line1").getValue() != null && Xrm.Page.getAttribute("new_tipologradouro").getSelectedOption().text != "") {
                    var endereco = Xrm.Page.getAttribute("address1_line1").getValue().split(' ');
                    var enderecoresumido = "";
                    var ultimoEndereco = endereco.length - 1;

                    try {
                        var tipologradouro = Xrm.Page.getAttribute("new_tipologradouro").getSelectedOption().text.toLowerCase();
                        tipologradouro = crmForm.RemoverAcento(tipologradouro);
                        tipologradouro = TIPOLOGRADOURO[tipologradouro].code;
                    }
                    catch (err) {
                        tipologradouro = tipologradouro.substring(0, 1).toUpperCase();
                    }

                    enderecoresumido += tipologradouro + '. ';

                    for (var i = 0; i < endereco.length; i++) {
                        var item = endereco[i];
                        if (i == 0 || i == ultimoEndereco) {
                            enderecoresumido += item.substring(0, item.length);
                        }
                        else {
                            enderecoresumido += item.substring(0, 1) + '.';
                        }

                        if (i != ultimoEndereco)
                            enderecoresumido += " ";
                    }

                    Xrm.Page.getAttribute("address2_line1").setValue(enderecoresumido);
                }
            }

            crmForm.RemoverAcento = function(texto) {
                texto = texto.replace(new RegExp('[ÁÀÂÃ]', 'gi'), 'a');
                texto = texto.replace(new RegExp('[ÉÈÊ]', 'gi'), 'e');
                texto = texto.replace(new RegExp('[ÍÌÎ]', 'gi'), 'i');
                texto = texto.replace(new RegExp('[ÓÒÔÕ]', 'gi'), 'o');
                texto = texto.replace(new RegExp('[ÚÙÛ]', 'gi'), 'u');
                texto = texto.replace(new RegExp('[Ç]', 'gi'), 'c');
                return texto;
            }

            // Desabilita Campo Endereço Resumido
            Xrm.Page.getControl("address2_line1").setDisabled(true);

            //Boleto Ditital : Controles para liberação de alteração de adesao
            crmForm.AdesaoBoletoChange = function() {
                Xrm.Page.getAttribute("new_motivo_nao_adesao").setRequiredLevel("none");
                if (AdesaoBoletoAtual != null && Xrm.Page.getAttribute("new_adesao_boleto_digital").getValue()) {
                }
                if (Xrm.Page.getAttribute("new_adesao_boleto_digital").getValue() == AdesaoBoletoSim) {
                    var data = new Date();
                    Xrm.Page.getAttribute("new_data_adesao_boleto_digital").setValue(data);
                    Xrm.Page.getAttribute("new_data_adesao_boleto_digital").setSubmitMode("always");
                    Xrm.Page.getAttribute("new_origem_adesao").setValue('RELACIONAMENTO');
                    Xrm.Page.getAttribute("new_origem_adesao").setSubmitMode("always");
                    Xrm.Page.getAttribute("new_motivo_nao_adesao").setValue(null);
                    Xrm.Page.getAttribute("new_motivo_nao_adesao").setSubmitMode("always");
                    crmForm.DesabilitaHabilitaCampos("new_motivo_nao_adesao", true);
                    Xrm.Page.getAttribute("new_adesao_boleto_sincronizado").setValue(false);
                    Xrm.Page.getAttribute("new_adesao_boleto_sincronizado").setSubmitMode("always");
                }
                else {
                    //Consulta sap para verificar desadesao
                    var codigoCliente = Xrm.Page.getAttribute("new_codsap6").getValue();
                    if (AdesaoBoletoAtual == AdesaoBoletoSim && codigoCliente != null) {
                        try {
                            var cmd = new RemoteCommand("MrvService", "ConsultaAdesaoBoletoDigital", "/MrvCustomizations/");
                            cmd.SetParameter("codigoCliente", codigoCliente);
                            var resultado = cmd.Execute();
                            if (!resultado.ReturnValue.Mrv.Success) {
                                alert(resultado.ReturnValue.Mrv.Error);
                                Xrm.Page.getAttribute("new_adesao_boleto_digital").setValue(AdesaoBoletoAtual);
                                return;
                            }
                        }
                        catch (error) {
                            alert("Não foi possível realizar a verificação para desadesão. Por favor tente novamente.\n" + error.description);
                            Xrm.Page.getAttribute("new_adesao_boleto_digital").setValue(adesaoBoletoAtual);
                            return;
                        }
                    }
                    var data = new Date();
                    Xrm.Page.getAttribute("new_data_adesao_boleto_digital").setValue(data);
                    Xrm.Page.getAttribute("new_data_adesao_boleto_digital").setSubmitMode("always");
                    Xrm.Page.getAttribute("new_origem_adesao").setValue('RELACIONAMENTO');
                    Xrm.Page.getAttribute("new_origem_adesao").setSubmitMode("always");
                    crmForm.DesabilitaHabilitaCampos("new_motivo_nao_adesao", false);
                    Xrm.Page.getAttribute("new_motivo_nao_adesao").setRequiredLevel("required");
                    Xrm.Page.getAttribute("new_adesao_boleto_sincronizado").setValue(false);
                    Xrm.Page.getAttribute("new_adesao_boleto_sincronizado").setSubmitMode("always");
                }
            } //Fim AdesaoBoletoChange

            if (Xrm.Page.ui.getFormType() == TypeUpdate && (crmForm.UsuarioAdministrador() || Informacoes.PertenceA("REL_ADESAO_BOLETO"))) {
                AdesaoBoletoAtual = Xrm.Page.getAttribute("new_adesao_boleto_digital").getValue();
                crmForm.DesabilitaHabilitaCampos("new_adesao_boleto_digital;new_motivo_nao_adesao", false);
            }
            else
                crmForm.DesabilitaHabilitaCampos("new_adesao_boleto_digital;new_motivo_nao_adesao", true);
        }

        function loadScript() {
            var oHead = document.getElementsByTagName('head')[0];
            var oScript = document.createElement('script');
            oScript.type = "text/javascript";
            oScript.src = "/_static/Base.js";

            oScript.onreadystatechange = function() {
                if (this.readyState == 'complete' || this.readyState == 'loaded') {
                    Load();
                }
            }
            oHead.appendChild(oScript);
        }

        loadScript();

    } catch (error) {
        formularioValido = false;
        alert("Ocorreu um erro no formulário.\n" + error.description);
    }

}

function Form_onsave(context)
{
    try {
        if (!formularioValido) {
            alert("Ocorreu um erro no formulário. Impossível salvar.");
            context.getEventArgs().preventDefault();
            return false;
        }
        crmForm.SalvaDiaMesNascimento();

        var endereco = "";
        var enderecoResumido = "";
        var complemento = "";
        var bairro = "";
    
        if (Xrm.Page.getAttribute("telephone1").getValue() == null && Xrm.Page.getAttribute("address1_telephone3").getValue() == null) {
            alert("O número de telefone residencial ou o telefone celular devem estar preenchidos para finalizar o cadastro do Cliente");
            context.getEventArgs().preventDefault();
            return false;
        }

        if(Xrm.Page.getAttribute("address1_line1").getValue() != null)
            endereco = Xrm.Page.getAttribute("address1_line1").getValue().toString();

        if(Xrm.Page.getAttribute("address2_line1").getValue() != null)
            enderecoResumido = Xrm.Page.getAttribute("address2_line1").getValue().toString();

        if(Xrm.Page.getAttribute("new_complemento").getValue() != null)
            complemento = Xrm.Page.getAttribute("new_complemento").getValue().toString();

        if(Xrm.Page.getAttribute("new_bairro").getValue() != null)
            bairro = Xrm.Page.getAttribute("new_bairro").getValue().toString();

        var nome = Xrm.Page.getAttribute("name").getValue().toString();
        if(endereco.indexOf(";") != -1 ||  nome.indexOf(";") != -1 || enderecoResumido.indexOf(";") != -1 ||  complemento.indexOf(";") != -1 || bairro.indexOf(";") != -1)
        {
            alert('Não é possível salvar com ";" nos campos do endereço ou no nome do cliente.');
            context.getEventArgs().preventDefault();
            return false;
        }
    
        if (!crmForm.ValidarEndereco()) {
            context.getEventArgs().preventDefault();
            return false;
        }

        var cidadeId = "";
        var ddd = "";
        if(Xrm.Page.getAttribute("new_endereco_nacional").getValue()){
            if (Xrm.Page.getAttribute("new_cidadeid").getValue() != null){
                cidadeId = Xrm.Page.getAttribute("new_cidadeid").getValue()[0].id;
            
                var cmdDadosCidade = new RemoteCommand("MrvService", "retornarEstadoEDDD", "/MRVCustomizations/");
                cmdDadosCidade.SetParameter("cidadeId", cidadeId);
                var oResultado = cmdDadosCidade.Execute();
                if (oResultado.ReturnValue.Mrv.Error && oResultado.ReturnValue.Mrv.ErrorSoap){
                    ddd = "";
                }
                else {
                    if (crmForm.TratarRetornoRemoteCommand(oResultado, "retornarEstadoEDDD")) {
                        if (typeof (oResultado.ReturnValue.Mrv.ddd) == "object"){ //object = retorno vazio, ou seja, não existe ddd para a cidade informada
                            ddd = "";
                        }
                        else{
                            ddd = oResultado.ReturnValue.Mrv.ddd;
                        }
                    }
                }
            }
        }

        var ddi = (crmForm.all.new_pais.SelectedIndex == Pais.BRASIL ? DDI.Brasil : "");

        var cpfCnpj = "";

        if(Xrm.Page.getAttribute("new_tipodecliente").getValue() == 0){ //CPF
            cpfCnpj = Xrm.Page.getAttribute("new_cpf == null ? '' : Xrm.Page.getAttribute("new_cpf").getValue()");
        }
        else {
            cpfCnpj = Xrm.Page.getAttribute("new_cnpj == null ? '' : Xrm.Page.getAttribute("new_cnpj").getValue()");
        }
    	
        //Valida telefones
        var cmdValidaTelefones = new RemoteCommand("SrvCliente", "ValidaCadastroCliente", "/MRVCustomizations/");

        if(Xrm.Page.getAttribute("new_tipodecliente").getValue() == 0) //CPF
        {
            if(Xrm.Page.getAttribute("new_cpf").getValue() != null){
                cmdValidaTelefones.SetParameter("cpfCnpj", Xrm.Page.getAttribute("new_cpf").getValue());
            }
            else{
                cmdValidaTelefones.SetParameter("cpfCnpj", '');
            }
        }
        else{
            if(Xrm.Page.getAttribute("new_cnpj").getValue() != null){
                cmdValidaTelefones.SetParameter("cpfCnpj", Xrm.Page.getAttribute("new_cnpj").getValue());
            }
            else {
                cmdValidaTelefones.SetParameter("cpfCnpj", '');
            }
        }

        if(Xrm.Page.getAttribute("name").getValue() != null){
            cmdValidaTelefones.SetParameter("nome", Xrm.Page.getAttribute("name").getValue());
        }
        else{
            cmdValidaTelefones.SetParameter("nome", '');
        }

        if(Xrm.Page.getAttribute("address1_postalcode").getValue() != null){
            cmdValidaTelefones.SetParameter("cep", Xrm.Page.getAttribute("address1_postalcode").getValue());
        }
        else{
            cmdValidaTelefones.SetParameter("cep", '');
        }

        cmdValidaTelefones.SetParameter("DDD", ddd.toString());
        cmdValidaTelefones.SetParameter("DDI", ddi.toString());

    
        if(Xrm.Page.getAttribute("telephone1").getValue() != null){
            cmdValidaTelefones.SetParameter("telefoneResidencial", Xrm.Page.getAttribute("telephone1").getValue());
        }
        else {
            cmdValidaTelefones.SetParameter("telefoneResidencial", '');
        }
        if(Xrm.Page.getAttribute("telephone2").getValue() != null){
            cmdValidaTelefones.SetParameter("telefoneComercial", Xrm.Page.getAttribute("telephone2").getValue());
        }
        else {
            cmdValidaTelefones.SetParameter("telefoneComercial", '');
        }

        if(Xrm.Page.getAttribute("address1_telephone3").getValue() != null){
            cmdValidaTelefones.SetParameter("celular", Xrm.Page.getAttribute("address1_telephone3").getValue());
        }
        else {
            cmdValidaTelefones.SetParameter("celular", '');
        }

        if(Xrm.Page.getAttribute("fax").getValue() != null){
            cmdValidaTelefones.SetParameter("faxCelular2", Xrm.Page.getAttribute("fax").getValue());
        }
        else{
            cmdValidaTelefones.SetParameter("faxCelular2", '');
        }

        if(Xrm.Page.getAttribute("new_outrotelefone").getValue() != null){
            cmdValidaTelefones.SetParameter("outroTelefone", Xrm.Page.getAttribute("new_outrotelefone").getValue());
        }
        else {
            cmdValidaTelefones.SetParameter("outroTelefone", '');
        }

        if(Xrm.Page.getAttribute("new_telefoneum").getValue() != null){
            cmdValidaTelefones.SetParameter("telefoneEnriquecimento1", Xrm.Page.getAttribute("new_telefoneum").getValue());
        }
        else {
            cmdValidaTelefones.SetParameter("telefoneEnriquecimento1", '');
        }

        if(Xrm.Page.getAttribute("new_telefonedois").getValue() != null){
            cmdValidaTelefones.SetParameter("telefoneEnriquecimento2", Xrm.Page.getAttribute("new_telefonedois").getValue());
        }
        else{
            cmdValidaTelefones.SetParameter("telefoneEnriquecimento2", '');
        }

        if(Xrm.Page.getAttribute("new_telefonetrs").getValue() !=null){
            cmdValidaTelefones.SetParameter("telefoneEnriquecimento3", Xrm.Page.getAttribute("new_telefonetrs").getValue());
        }
        else{
            cmdValidaTelefones.SetParameter("telefoneEnriquecimento3", '');
        }

        if(Xrm.Page.getAttribute("new_telefonequatro").getValue() != null){
            cmdValidaTelefones.SetParameter("telefoneEnriquecimento4", Xrm.Page.getAttribute("new_telefonequatro").getValue());
        }
        else{
            cmdValidaTelefones.SetParameter("telefoneEnriquecimento4", '');
        }

        if(Xrm.Page.getAttribute("new_telefonecinco").getValue() != null){
            cmdValidaTelefones.SetParameter("telefoneEnriquecimento5", Xrm.Page.getAttribute("new_telefonecinco").getValue());
        }
        else{
            cmdValidaTelefones.SetParameter("telefoneEnriquecimento5", '');
        }
    
        if(Xrm.Page.getAttribute("emailaddress1").getValue() != null){
            cmdValidaTelefones.SetParameter("email", Xrm.Page.getAttribute("emailaddress1").getValue());
        }
        else{
            cmdValidaTelefones.SetParameter("email", '');
        }
    
        cmdValidaTelefones.SetParameter("indicadorEnderecoNacional", Xrm.Page.getAttribute("new_endereco_nacional").getValue());
    			
        var oResult = cmdValidaTelefones.Execute();
                   
        if(!oResult.ReturnValue.Mrv.Sucesso){
            alert(oResult.ReturnValue.Mrv.Mensagem);
            context.getEventArgs().preventDefault();
            return false;
        }
    
        // Transformar caracteres em maiusculos------------------------------------//
        var elm = document.getElementsByTagName("input");
        for (i = 0; i < elm.length; i++) {
            if (elm[i].type == "text")
                if (elm[i].getValue() != null) {
                    try {
                        elm[i].setValue(elm[i].getValue().toUpperCase());
                    }
                    catch (e) { }
                }
        }
    
        //Habilitando o campo classificação
        if (Xrm.Page.data.entity.getIsDirty())
        {
            Xrm.Page.getControl("accountclassificationcode").setDisabled(false);
            Xrm.Page.getControl("new_cidadeid").setDisabled(false);
            Xrm.Page.getControl("address1_line1").setDisabled(false);
            Xrm.Page.getControl("address2_line1").setDisabled(false);
            Xrm.Page.getControl("new_tipologradouro").setDisabled(false);
            Xrm.Page.getControl("new_bairro").setDisabled(false);
            Xrm.Page.getControl("new_estado").setDisabled(false);
            Xrm.Page.getControl("new_pais").setDisabled(false);
            Xrm.Page.getControl("new_cidadeid").setDisabled(false);
        }

        if (!Xrm.Page.getAttribute("new_tipodecliente").getValue()) {
            var ret = new_cpf_onchange0();
            event.returnValue = ret;
            return false;
        }
        else {
            var ret = new_cnpj_onchange0();
            event.returnValue = ret;
            return false;
        }
    
        if(Xrm.Page.getAttribute("name").getValue() != null)
        {
            var nome = Xrm.Page.getAttribute("name").getValue();
            Xrm.Page.getAttribute("name").setValue(nome.replace("*", ""));
        } 	            
    } catch (error) {
        alert("Ocorreu um erro no formulário.\n" + error.description);
        context.getEventArgs().preventDefault();
        return false;
    }

}

function accountclassificationcode_onchange()
{
    if(Xrm.Page.getAttribute("accountclassificationcode").getValue() == 2 && Xrm.Page.getAttribute("new_tipodecliente").getValue() == 0 )
    {
        Xrm.Page.getAttribute("address1_postalcode").setRequiredLevel("required");
  
        //pessoa fisica-----------------------------------------
        Xrm.Page.getAttribute("new_naturalidade").setRequiredLevel("required");
        Xrm.Page.getAttribute("new_nacionalidade").setRequiredLevel("required");
        Xrm.Page.getAttribute("new_profissao").setRequiredLevel("required");
        Xrm.Page.getAttribute("new_sexo").setRequiredLevel("required");
        Xrm.Page.getAttribute("new_estadocivil").setRequiredLevel("required");
        Xrm.Page.getAttribute("new_cpf").setRequiredLevel("required");
        Xrm.Page.getAttribute("new_registrogeraln").setRequiredLevel("required");
        Xrm.Page.getAttribute("new_datadeexpedicao").setRequiredLevel("required");
        Xrm.Page.getAttribute("new_orgaodeexpedicao").setRequiredLevel("required");
        Xrm.Page.getAttribute("new_nomedamae").setRequiredLevel("required");
        Xrm.Page.getAttribute("new_datadenascimento").setRequiredLevel("required");

        Xrm.Page.getAttribute("primarycontactid").setRequiredLevel("none");
        Xrm.Page.getAttribute("industrycode").setRequiredLevel("none");
        Xrm.Page.getAttribute("ownershipcode").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_cnpj").setRequiredLevel("none");
    }

    if(Xrm.Page.getAttribute("accountclassificationcode").getValue() == 2 && Xrm.Page.getAttribute("new_tipodecliente").getValue() == 1)
    {
        Xrm.Page.getAttribute("address1_postalcode").setRequiredLevel("required");

        //pessoa juridica---------------------------------------
        Xrm.Page.getAttribute("primarycontactid").setRequiredLevel("required");
        Xrm.Page.getAttribute("industrycode").setRequiredLevel("required");
        Xrm.Page.getAttribute("ownershipcode").setRequiredLevel("required");
        Xrm.Page.getAttribute("new_cnpj").setRequiredLevel("required");

        Xrm.Page.getAttribute("new_naturalidade").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_nacionalidade").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_profissao").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_sexo").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_estadocivil").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_cpf").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_registrogeraln").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_datadeexpedicao").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_orgaodeexpedicao").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_nomedamae").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_datadenascimento").setRequiredLevel("none");
    }
   
    // Se o tipo de cliente for prospect e cliente PJ-------------------------------------//   
    if(Xrm.Page.getAttribute("accountclassificationcode").getValue() == 1 && Xrm.Page.getAttribute("new_tipodecliente").getValue() == 1)  
    {
        Xrm.Page.ui.tabs.get(1).setVisible(false);
        crmForm.all.tab2Tab.style.display = "inline";

        Xrm.Page.getAttribute("address1_postalcode").setRequiredLevel("none");

        Xrm.Page.getAttribute("primarycontactid").setRequiredLevel("none");
        Xrm.Page.getAttribute("industrycode").setRequiredLevel("none");
        Xrm.Page.getAttribute("ownershipcode").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_cnpj").setRequiredLevel("none");

        Xrm.Page.getAttribute("new_naturalidade").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_nacionalidade").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_profissao").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_sexo").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_estadocivil").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_cpf").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_registrogeraln").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_datadeexpedicao").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_orgaodeexpedicao").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_nomedamae").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_datadenascimento").setRequiredLevel("none");
    }

    // Se o tipo de cliente for prospect e cliente PF----------------------------------//   
    if(Xrm.Page.getAttribute("accountclassificationcode").getValue() == 1 && Xrm.Page.getAttribute("new_tipodecliente").getValue() == 0)  
    {
        crmForm.all.tab1Tab.style.display = "inline";
        Xrm.Page.ui.tabs.get(2).setVisible(false);

        Xrm.Page.getAttribute("address1_postalcode").setRequiredLevel("none");

        Xrm.Page.getAttribute("primarycontactid").setRequiredLevel("none");
        Xrm.Page.getAttribute("industrycode").setRequiredLevel("none");
        Xrm.Page.getAttribute("ownershipcode").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_cnpj").setRequiredLevel("none");

        Xrm.Page.getAttribute("new_naturalidade").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_nacionalidade").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_profissao").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_sexo").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_estadocivil").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_cpf").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_registrogeraln").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_datadeexpedicao").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_orgaodeexpedicao").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_nomedamae").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_datadenascimento").setRequiredLevel("none");
    }

}

function name_onchange()
{


}

function new_tipodecliente_onchange()

{
    //Condicao no Botao SIm/NAO para pessoa física ou pessoa jurídica

    // Se o tipo de cliente for cliente e o tipo de cliente for PF----------------------------------------------------------//   
    if(Xrm.Page.getAttribute("accountclassificationcode").getValue() == 2 && Xrm.Page.getAttribute("new_tipodecliente").getValue() == 0 )
    {
        crmForm.all.tab1Tab.style.display = "inline";
        Xrm.Page.ui.tabs.get(2).setVisible(false);
  
        Xrm.Page.getAttribute("address1_postalcode").setRequiredLevel("required");
  
        //pessoa fisica-----------------------------------------
        Xrm.Page.getAttribute("new_naturalidade").setRequiredLevel("required");
        Xrm.Page.getAttribute("new_nacionalidade").setRequiredLevel("required");
        Xrm.Page.getAttribute("new_profissao").setRequiredLevel("required");
        Xrm.Page.getAttribute("new_sexo").setRequiredLevel("required");
        Xrm.Page.getAttribute("new_estadocivil").setRequiredLevel("required");
        Xrm.Page.getAttribute("new_cpf").setRequiredLevel("required");
        Xrm.Page.getAttribute("new_registrogeraln").setRequiredLevel("required");
        Xrm.Page.getAttribute("new_datadeexpedicao").setRequiredLevel("required");
        Xrm.Page.getAttribute("new_orgaodeexpedicao").setRequiredLevel("required");
        Xrm.Page.getAttribute("new_nomedamae").setRequiredLevel("required");
        Xrm.Page.getAttribute("new_datadenascimento").setRequiredLevel("required");

        Xrm.Page.getAttribute("primarycontactid").setRequiredLevel("none");
        Xrm.Page.getAttribute("industrycode").setRequiredLevel("none");
        Xrm.Page.getAttribute("ownershipcode").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_cnpj").setRequiredLevel("none");

        Xrm.Page.getAttribute("new_grupo_contas").setValue("ZPFI");
    }

    // Se o tipo de cliente for cliente e o tipo de cliente for PJ----------------------------------------------------------//   
    if(Xrm.Page.getAttribute("accountclassificationcode").getValue() == 2 && Xrm.Page.getAttribute("new_tipodecliente").getValue() == 1)
    {
        Xrm.Page.ui.tabs.get(1).setVisible(false);
        crmForm.all.tab2Tab.style.display = "inline";

        Xrm.Page.getAttribute("address1_postalcode").setRequiredLevel("required");

        //pessoa juridica---------------------------------------
        Xrm.Page.getAttribute("primarycontactid").setRequiredLevel("required");
        Xrm.Page.getAttribute("industrycode").setRequiredLevel("required");
        Xrm.Page.getAttribute("ownershipcode").setRequiredLevel("required");
        Xrm.Page.getAttribute("new_cnpj").setRequiredLevel("required");

        Xrm.Page.getAttribute("new_naturalidade").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_nacionalidade").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_profissao").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_sexo").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_estadocivil").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_cpf").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_registrogeraln").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_datadeexpedicao").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_orgaodeexpedicao").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_nomedamae").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_datadenascimento").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_grupo_contas").setValue("ZPJU");
    }

    // Se o tipo de cliente for prospect e cliente PJ-------------------------------------//   
    if(Xrm.Page.getAttribute("accountclassificationcode").getValue() == 1 && Xrm.Page.getAttribute("new_tipodecliente").getValue() == 1)  
    {
        Xrm.Page.ui.tabs.get(1).setVisible(false);
        crmForm.all.tab2Tab.style.display = "inline";

        Xrm.Page.getAttribute("address1_postalcode").setRequiredLevel("none");

        Xrm.Page.getAttribute("primarycontactid").setRequiredLevel("none");
        Xrm.Page.getAttribute("industrycode").setRequiredLevel("none");
        Xrm.Page.getAttribute("ownershipcode").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_cnpj").setRequiredLevel("none");

        Xrm.Page.getAttribute("new_naturalidade").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_nacionalidade").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_profissao").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_sexo").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_estadocivil").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_cpf").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_registrogeraln").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_datadeexpedicao").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_orgaodeexpedicao").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_nomedamae").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_datadenascimento").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_grupo_contas").setValue("ZPJU");
    }

    // Se o tipo de cliente for prospect e cliente PF----------------------------------//   
    if(Xrm.Page.getAttribute("accountclassificationcode").getValue() == 1 && Xrm.Page.getAttribute("new_tipodecliente").getValue() == 0)  
    {
        crmForm.all.tab1Tab.style.display = "inline";
        Xrm.Page.ui.tabs.get(2).setVisible(false);

        Xrm.Page.getAttribute("address1_postalcode").setRequiredLevel("none");

        Xrm.Page.getAttribute("primarycontactid").setRequiredLevel("none");
        Xrm.Page.getAttribute("industrycode").setRequiredLevel("none");
        Xrm.Page.getAttribute("ownershipcode").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_cnpj").setRequiredLevel("none");

        Xrm.Page.getAttribute("new_naturalidade").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_nacionalidade").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_profissao").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_sexo").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_estadocivil").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_cpf").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_registrogeraln").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_datadeexpedicao").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_orgaodeexpedicao").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_nomedamae").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_datadenascimento").setRequiredLevel("none");
        Xrm.Page.getAttribute("new_grupo_contas").setValue("ZPFI");
    }

}

function emailaddress1_onchange()

{


}

function new_endereco_nacional_onchange()

{
    crmForm.TratarEnderecoNacional();

    // Limpa os campos de endereço
    Xrm.Page.getAttribute("address1_postalcode").setValue(null);
    Xrm.Page.getAttribute("address1_line1").setValue(null);
    Xrm.Page.getAttribute("new_complemento").setValue(null);
    Xrm.Page.getAttribute("address2_line1").setValue(null);
    crmForm.all.new_tipologradouro.SelectedIndex = 0;
    Xrm.Page.getAttribute("new_bairro").setValue(null);
    Xrm.Page.getAttribute("new_numero").setValue(null);

}

function address1_postalcode_onchange()

{
    var campo = ExecutionObj.getEventSource();
    crmForm.ValidarCEP(campo);

}

function new_endereco_confere_onchange()

{
    crmForm.TrataEnderecoConfere();

}

function address1_line1_onchange()

{
    crmForm.ResumirEndereco();

}

function new_tipologradouro_onchange()

{
    crmForm.ResumirEndereco();

}

function new_cidadeid_onchange()

{
    crmForm.all.telephone1.value = "";

    if (Xrm.Page.getAttribute("new_cidadeid").getValue() == null)
        Xrm.Page.getControl("new_estado").setDisabled(false);

    var valorlookupcidade = new Array();
    valorlookupcidade = Xrm.Page.getAttribute("new_cidadeid").getValue();

    if (valorlookupcidade != null) {
        var cmdDadosCidade = new RemoteCommand("MrvService", "retornarEstadoEDDD", "/MRVCustomizations/");
        cmdDadosCidade.SetParameter("cidadeId", valorlookupcidade[0].id);
        var oResultado = cmdDadosCidade.Execute();
        if (oResultado.Success) {
            // Atribui o BRASIL como item selecionado no campo Pais
            Xrm.Page.getAttribute("new_pais").setValue(Pais.BRASIL);
            Xrm.Page.getControl("new_pais").setDisabled(true);

            switch (oResultado.ReturnValue.Mrv.estado) {
                case "AC":
                    crmForm.all.new_estado.SelectedIndex = EstadoPicklist.AC;
                    break;
                case "AL":
                    crmForm.all.new_estado.SelectedIndex = EstadoPicklist.AL;
                    break;
                case "AM":
                    crmForm.all.new_estado.SelectedIndex = EstadoPicklist.AM;
                    break;
                case "AP":
                    crmForm.all.new_estado.SelectedIndex = EstadoPicklist.AP;
                    break;
                case "BA":
                    crmForm.all.new_estado.SelectedIndex = EstadoPicklist.BA;
                    break;
                case "CE":
                    crmForm.all.new_estado.SelectedIndex = EstadoPicklist.CE;
                    break;
                case "DF":
                    crmForm.all.new_estado.SelectedIndex = EstadoPicklist.DF;
                    break;
                case "ES":
                    crmForm.all.new_estado.SelectedIndex = EstadoPicklist.ES;
                    break;
                case "GO":
                    crmForm.all.new_estado.SelectedIndex = EstadoPicklist.GO;
                    break;
                case "MA":
                    crmForm.all.new_estado.SelectedIndex = EstadoPicklist.MA;
                    break;
                case "MG":
                    crmForm.all.new_estado.SelectedIndex = EstadoPicklist.MG;
                    break;
                case "MS":
                    crmForm.all.new_estado.SelectedIndex = EstadoPicklist.MS;
                    break;
                case "MT":
                    crmForm.all.new_estado.SelectedIndex = EstadoPicklist.MT;
                    break;
                case "PA":
                    crmForm.all.new_estado.SelectedIndex = EstadoPicklist.PA;
                    break;
                case "PB":
                    crmForm.all.new_estado.SelectedIndex = EstadoPicklist.PB;
                    break;
                case "PE":
                    crmForm.all.new_estado.SelectedIndex = EstadoPicklist.PE;
                    break;
                case "PI":
                    crmForm.all.new_estado.SelectedIndex = EstadoPicklist.PI;
                    break;
                case "PR":
                    crmForm.all.new_estado.SelectedIndex = EstadoPicklist.PR;
                    break;
                case "RJ":
                    crmForm.all.new_estado.SelectedIndex = EstadoPicklist.RJ;
                    break;
                case "RN":
                    crmForm.all.new_estado.SelectedIndex = EstadoPicklist.RN;
                    break;
                case "RO":
                    crmForm.all.new_estado.SelectedIndex = EstadoPicklist.RO;
                    break;
                case "RR":
                    crmForm.all.new_estado.SelectedIndex = EstadoPicklist.RR;
                    break;
                case "RS":
                    crmForm.all.new_estado.SelectedIndex = EstadoPicklist.RS;
                    break;
                case "SC":
                    crmForm.all.new_estado.SelectedIndex = EstadoPicklist.SC;
                    break;
                case "SE":
                    crmForm.all.new_estado.SelectedIndex = EstadoPicklist.SE;
                    break;
                case "SP":
                    crmForm.all.new_estado.SelectedIndex = EstadoPicklist.SP;
                    break;
                case "TO":
                    crmForm.all.new_estado.SelectedIndex = EstadoPicklist.TO;
                    break;
                default:
                    crmForm.all.new_estado.SelectedIndex = 0;
                    break;        
            }
            Xrm.Page.getControl("new_estado").setDisabled(true);
        }
    }

}

function new_estado_onchange()

{


}

function new_pais_onchange()

{
    crmForm.TrataPais();

}

function telephone1_onchange()

{
    crmForm.BuscaDadosTelefone("2","telephone1");

}

function address1_telephone3_onchange()

{
    crmForm.BuscaDadosTelefone("1","address1_telephone3");

}

function telephone2_onchange()

{
    crmForm.BuscaDadosTelefone("2","telephone2");

}

function fax_onchange()

{
    crmForm.BuscaDadosTelefone("3","fax");

}

function new_outrotelefone_onchange()

{
    crmForm.BuscaDadosTelefone("4","new_outroTelefone");

}

function new_telefoneum_onchange()

{
    if(event.srcElement.getValue() != null && event.srcElement.getValue() == ".." )
    {
        retorno= openStdDlg("/MrvWeb/Phone/Default.aspx?tipo=4", null, 250, 250);
        if(typeof(retorno) != "undefined")
        {
            event.srcElement.setValue(retorno);
        }   
        else
            event.srcElement.setValue("");        
    }
    else if(event.srcElement.getValue() != null && event.srcElement.getValue() != ".." )
    {
        alert("Digite apenas ..");
        event.srcElement.setValue("");
        event.srcElement.SetFocus();
    }

}

function new_telefonedois_onchange()

{
    if(event.srcElement.getValue() != null && event.srcElement.getValue() == ".." )
    {
        retorno= openStdDlg("/MrvWeb/Phone/Default.aspx?tipo=4", null, 250, 250);
        if(typeof(retorno) != "undefined")
        {
            event.srcElement.setValue(retorno);
        }   
        else
            event.srcElement.setValue("");        
    }
    else if(event.srcElement.getValue() != null && event.srcElement.getValue() != ".." )
    {
        alert("Digite apenas ..");
        event.srcElement.setValue("");
        event.srcElement.SetFocus();
    }

}

function new_telefonetrs_onchange()

{
    if(event.srcElement.getValue() != null && event.srcElement.getValue() == ".." )
    {
        retorno= openStdDlg("/MrvWeb/Phone/Default.aspx?tipo=4", null, 250, 250);
        if(typeof(retorno) != "undefined")
        {
            event.srcElement.setValue(retorno);
        }   
        else
            event.srcElement.setValue("");        
    }
    else if(event.srcElement.getValue() != null && event.srcElement.getValue() != ".." )
    {
        alert("Digite apenas ..");
        event.srcElement.setValue("");
        event.srcElement.SetFocus();
    }

}

function new_telefonequatro_onchange()

{
    if(event.srcElement.getValue() != null && event.srcElement.getValue() == ".." )
    {
        retorno= openStdDlg("/MrvWeb/Phone/Default.aspx?tipo=4", null, 250, 250);
        if(typeof(retorno) != "undefined")
        {
            event.srcElement.setValue(retorno);
        }   
        else
            event.srcElement.setValue("");        
    }
    else if(event.srcElement.getValue() != null && event.srcElement.getValue() != ".." )
    {
        alert("Digite apenas ..");
        event.srcElement.setValue("");
        event.srcElement.SetFocus();
    }

}

function new_telefonecinco_onchange()

{
    if(event.srcElement.getValue() != null && event.srcElement.getValue() == ".." )
    {
        retorno= openStdDlg("/MrvWeb/Phone/Default.aspx?tipo=4", null, 250, 250);
        if(typeof(retorno) != "undefined")
        {
            event.srcElement.setValue(retorno);
        }   
        else
            event.srcElement.setValue("");        
    }
    else if(event.srcElement.getValue() != null && event.srcElement.getValue() != ".." )
    {
        alert("Digite apenas ..");
        event.srcElement.setValue("");
        event.srcElement.SetFocus();
    }

}

function new_investimento_onchange()

{
    //Bit - sim - não - Ocultar nome do campo e campo do formulario

    if (Xrm.Page.getAttribute("new_investimento").getValue() == false)
    {
        Xrm.Page.getControl("new_bairroparainvestimento").setVisible(false);
        Xrm.Page.getControl("new_bairroparainvestimento").setVisible(false);       
    }
    else
    {
        Xrm.Page.getControl("new_bairroparainvestimento").setVisible(true);
        Xrm.Page.getControl("new_bairroparainvestimento").setVisible(true);
    }

}

function new_adesao_boleto_digital_onchange()

{
    crmForm.AdesaoBoletoChange();

}

function new_orgao_expedicao_onchange()
{
    if(Xrm.Page.getAttribute("new_orgao_expedicao").getValue() == null)
    {
        crmForm.SetFieldReqLevel("new_uf_orgao_expedicao",false);
        Xrm.Page.getAttribute("new_uf_orgao_expedicao").setValue(null);
    }
    else
    {
        crmForm.SetFieldReqLevel("new_uf_orgao_expedicao",true);
    }
}

function new_cpf_onchange()

{
    var erro = '';

    function AddMascara(cpf)
    {
        if (typeof(cpf) != "undefined" && cpf != null) 
        { 
            var sTmp = cpf.replace(/[^0-9]/g, ""); 
        
            if (sTmp.length == 11)
            {
                Xrm.Page.getAttribute("new_cpf").setValue( sTmp.substr(0,3) + "." + sTmp.substr(3,3) + "." + sTmp.substr(6,3) + "-" + sTmp.substr(9,2)); 
                cpf = '';
                return true;
            }
            else
            {
                Xrm.Page.getAttribute("new_cpf").setValue(null);
                alert("Campo fora da faixa de dígitos sequenciais!");
                Xrm.Page.getControl("new_cpf").setFocus(true);
                return false;
            }
        }
    }

    function RemoteCPF(cpf, changeCPF)
    {
        var oCmd = new RemoteCommand("MrvService", "ValidCnpjOrCpf", "/MRVCustomizations/");
   
        oCmd.SetParameter("pNumber", cpf.toString());
   
        if(changeCPF)
            oCmd.SetParameter("pType","1");
        else
            oCmd.SetParameter("pType","0");

        var oResult = oCmd.Execute();
   
        if(oResult.Success)
        {
            if(!oResult.ReturnValue.Mrv.Valid)
            {
                alert(oResult.ReturnValue.Mrv.Mensagem);
                return oResult.ReturnValue.Mrv.Valid;
            }
        }
        else
        {
            alert("Erro. Contate o administrador.");
            return false;
        }
    }

    if(Xrm.Page.getAttribute("new_cpf").getValue() != null || Xrm.Page.getAttribute("new_cnpj").getValue() != null)
    {
        var Number = (!Xrm.Page.getAttribute("new_tipodecliente").getValue()) ? Xrm.Page.getAttribute("new_cpf").getValue() : Xrm.Page.getAttribute("new_cnpj").getValue();

        if (AddMascara(Xrm.Page.getAttribute("new_cpf").getValue()))
        {
            return RemoteCPF(Xrm.Page.getAttribute("new_cpf").getValue(), crmForm.all.new_cpf.IsDirty);   
        }
    }

}

function new_nacionalidade_onchange()

{
    if (Xrm.Page.getAttribute("new_nacionalidade").getValue() == null || Xrm.Page.getAttribute("new_nacionalidade").getValue() == 2) {
        Xrm.Page.getAttribute("new_naturalidadeid").setValue(null);
        Xrm.Page.getControl("new_naturalidadeid").setDisabled(true);
        if (Xrm.Page.ui.getFormType() == TypeCreate || Xrm.Page.ui.getFormType() == TypeUpdate) {
            Xrm.Page.getAttribute("new_naturalidadeid").setSubmitMode("always");
        }
    }
    else {
        Xrm.Page.getControl("new_naturalidadeid").setDisabled(false);
    }

}

function new_sexo_onchange()

{


}

function new_temfilhos_onchange()

{
    if(Xrm.Page.getAttribute("new_temfilhos").getValue() == 1)
    {
        crmForm.all.new_quantidadedefilhos_c.style.visibility ="visible";
        Xrm.Page.getControl("new_quantidadedefilhos").setVisible(true);
    }
    else{
        Xrm.Page.getAttribute("new_quantidadedefilhos").setValue(null);
        Xrm.Page.getControl("new_quantidadedefilhos").setVisible(false);
        Xrm.Page.getControl("new_quantidadedefilhos").setVisible(false);
    }

}

function new_renda_pessoal_onchange()

{
    //cálculo para saber a faxia salarial 
    var SalBase = 415;
    var VlrSal = Xrm.Page.getAttribute("new_renda_pessoal").getValue();
    var VlrMedio = parseInt(VlrSal/SalBase);

    if(VlrMedio < 30)
    {
        switch(VlrMedio)
        {
            case 0:
            case 1:
            case 2:
                Xrm.Page.getAttribute("new_faixasalarial").setValue(1);  
                break;

            case 3:
            case 4:
            case 5:
                Xrm.Page.getAttribute("new_faixasalarial").setValue(2);  
                break; 
  
            case 6:
            case 7:
            case 8:
                Xrm.Page.getAttribute("new_faixasalarial").setValue(3);  
                break;

            case 9:
            case 10:
            case 11:
                Xrm.Page.getAttribute("new_faixasalarial").setValue(4);  
                break;

            case 12:
            case 13:
            case 14:
                Xrm.Page.getAttribute("new_faixasalarial").setValue(5);  
                break;

            case 15:
            case 16:
            case 17:
            case 18:
            case 19:
                Xrm.Page.getAttribute("new_faixasalarial").setValue(6);  
                break;

            case 20:
            case 21:
            case 22:
            case 23:
            case 24:
                Xrm.Page.getAttribute("new_faixasalarial").setValue(7);  
                break;

            case 25:
            case 26:
            case 27:
            case 28:
            case 29:
                Xrm.Page.getAttribute("new_faixasalarial").setValue(8);  
                break;

            default:
                Xrm.Page.getAttribute("new_faixasalarial").setValue(0);
                break;
        }
    }
    else
        Xrm.Page.getAttribute("new_faixasalarial").setValue(9);

}

function new_cnpj_onchange()

{
    var erro = '';
    function AddMascara(cnpj)
    {
        if (typeof(cnpj) != "undefined" && cnpj != null) 
        { 
            var sTmp = Xrm.Page.getAttribute("new_cnpj").getValue().replace(/[^0-9]/g, ""); 
 
            if ( sTmp.length != 14)
            {
                //Xrm.Page.getAttribute("new_cnpj").setValue('');
                alert("Campo fora da faixa de dígitos sequenciais!");	
            }
            else
            {
                if(sTmp.length == 14) 
                {
                    Xrm.Page.getAttribute("new_cnpj").setValue( sTmp.substr(0, 2) + "." + sTmp.substr(2, 3) + "." + sTmp.substr(5, 3) + "/" + sTmp.substr(8, 4) + "-" + sTmp.substr(12, 2)); 
                }
            }
        }
    }

    //Válida se o CPF existe
    function RemoteCPF(cpf, changeCPF)
    {
        var oCmd = new RemoteCommand("MrvService", "ValidCnpjOrCpf", "/MRVCustomizations/");
        oCmd.SetParameter("pNumber", cpf.toString());
        if(changeCPF)
            oCmd.SetParameter("pType","1");
        else
            oCmd.SetParameter("pType","0");

        var oResult = oCmd.Execute();
        if(oResult.Success)
        {
            if(oResult.ReturnValue.Mrv.Valid)
            {
                if(oResult.ReturnValue.Mrv.Exist.toString() == "true")
                {
                    if(oResult.ReturnValue.Mrv.Type.toString() == "Cliente")
                    {
                        alert("Atenção\n"+ oResult.ReturnValue.Mrv.Nome.toString() + " já está cadastrado com este CNPJ como um Cliente " + oResult.ReturnValue.Mrv.Status.toString()); 
                    }
                    else
                        alert("Atenção\n"+ oResult.ReturnValue.Mrv.Nome.toString() + " já está cadastrado com este CNPJ como um Cliente Potencial"); 

 
                    return false;
                }
                else
                    return true;
            }
            else
            {
                alert(oResult.ReturnValue.Mrv.Mensagem);
                return false;
            }
        }
        else
        {
            alert("Erro. Contate o administrador.");
            return false;
        }
    }

    if(Xrm.Page.getAttribute("new_cpf").getValue()!=null || Xrm.Page.getAttribute("new_cnpj").getValue()!=null)
    {
        var _isChangeCPF = Xrm.Page.getAttribute("new_cnpj.IsDirty");
        var Number = '';
        if(!Xrm.Page.getAttribute("new_tipodecliente").getValue())
            Number = Xrm.Page.getAttribute("new_cpf").getValue();
        else
            Number = Xrm.Page.getAttribute("new_cnpj").getValue();

        AddMascara(Xrm.Page.getAttribute("new_cnpj").getValue());
        var ret = RemoteCPF(Xrm.Page.getAttribute("new_cnpj").getValue(), _isChangeCPF);
        return ret;
    }

}

function new_exinscricaomunicipal_onchange()

{
    //condição do botão sim/não para a inscrição municipal
    if (Xrm.Page.getAttribute("new_exinscricaomunicipal").getValue() == 1)
    {
        Xrm.Page.getControl("new_inscricaomunicipal").setVisible(true);
        Xrm.Page.getControl("new_inscricaomunicipal").setVisible(true);
        crmForm.all.new_inscricaomunicipal.setAttribute("req", 2);
        Xrm.Page.getAttribute('new_inscricaomunicipal').setRequiredLevel('required');
    }
    else
    {
        Xrm.Page.getAttribute("new_inscricaomunicipal").getValue()=null;
        crmForm.all.new_inscricaomunicipal.setAttribute("req", 0);
        Xrm.Page.getAttribute('new_inscricaomunicipal').setRequiredLevel('none');
        Xrm.Page.getControl("new_inscricaomunicipal").setVisible(false);
        Xrm.Page.getControl("new_inscricaomunicipal").setVisible(false);
    }

}

function new_exinscricaoestadual_onchange()

{
    //condição do botão sim/não para a inscrição estadual
    if (Xrm.Page.getAttribute("new_exinscricaoestadual").getValue() == 1)
    {
        Xrm.Page.getControl("new_inscricaoestadual").setVisible(true);
        Xrm.Page.getControl("new_inscricaoestadual").setVisible(true);
        crmForm.all.new_inscricaoestadual.setAttribute("req", 2);
        Xrm.Page.getAttribute('new_inscricaoestadual').setRequiredLevel('required');
    }
    else
    {
        Xrm.Page.getAttribute("new_inscricaoestadual").getValue()=null;
        crmForm.all.new_inscricaoestadual.setAttribute("req", 0);
        Xrm.Page.getAttribute('new_inscricaoestadual').setRequiredLevel('none');
        Xrm.Page.getControl("new_inscricaoestadual").setVisible(false);
        Xrm.Page.getControl("new_inscricaoestadual").setVisible(false);
    }

}

function revenue_onchange()

{
    //cálculo para saber a faxia salarial 
    var SalBase = 415;
    var VlrSal = (Xrm.Page.getAttribute("revenue").getValue() != null) ? Xrm.Page.getAttribute("revenue").getValue(): "0";
    var VlrMedio = parseInt((VlrSal/12)/SalBase);

    if(VlrMedio < 30)
    {
        switch(VlrMedio)
        {
            case 0:
            case 1:
            case 2:
                Xrm.Page.getAttribute("new_faixasalarial").setValue(1);  
                break;

            case 3:
            case 4:
            case 5:
                Xrm.Page.getAttribute("new_faixasalarial").setValue(2);  
                break; 
  
            case 6:
            case 7:
            case 8:
                Xrm.Page.getAttribute("new_faixasalarial").setValue(3);  
                break;

            case 9:
            case 10:
            case 11:
                Xrm.Page.getAttribute("new_faixasalarial").setValue(4);  
                break;

            case 12:
            case 13:
            case 14:
                Xrm.Page.getAttribute("new_faixasalarial").setValue(5);  
                break;

            case 15:
            case 16:
            case 17:
            case 18:
            case 19:
                Xrm.Page.getAttribute("new_faixasalarial").setValue(6);  
                break;

            case 20:
            case 21:
            case 22:
            case 23:
            case 24:
                Xrm.Page.getAttribute("new_faixasalarial").setValue(7);  
                break;

            case 25:
            case 26:
            case 27:
            case 28:
            case 29:
                Xrm.Page.getAttribute("new_faixasalarial").setValue(8);  
                break;

            default:
                Xrm.Page.getAttribute("new_faixasalarial").setValue(0);
                break;
        }
    }
    else
        Xrm.Page.getAttribute("new_faixasalarial").setValue(9);

}

function new_cidade_midia_id_onchange()

{
    Xrm.Page.getAttribute("new_midiaid").fireOnChange();

}

function new_midiaid_onchange()

{
    function FilterLookup(attribute, url, param)
    {
        if(param!=null)
            url += '?'+param;
 
        oImg = eval('attribute'+'.parentNode.childNodes[0]');
        oImg.onclick=function()
        { 
            retorno= openStdDlg(url, null, 600, 450); 
            if(typeof(retorno) != "undefined")
            {
                strValues = retorno.split('*|*');
                var lookupData = new Array();
                lookupItem = new Object();
                lookupItem.id = "{" + strValues[1] + "}";
                lookupItem.type = parseInt(strValues[2]);
                lookupItem.name = strValues[0];
                lookupData[0] = lookupItem;
                attribute.setValue(lookupData);
                attribute.fireOnChange();
            }
        };
    }

    var IdCidade="";
    var filterDefault = "false";
    if(Xrm.Page.getAttribute("new_cidade_midia_id").getValue() != null)
    {
        IdCidade = Xrm.Page.getAttribute("new_cidade_midia_id").getValue()[0].id;
        filterDefault = "true";
    }
    else
    {
        IdCidade = "";
        filterDefault = "false";
    }

    if(IdCidade != "")
        IdCidade = IdCidade.substr(1, IdCidade.length-2);

    var oParam = "objectTypeCode=10083&filterDefault="+filterDefault+"&attributesearch=new_name&new_cidadeid=" + IdCidade;

    FilterLookup(crmForm.all.new_midiaid,"/MRVWeb/FilterLookup/FilterLookup.aspx", oParam);

}

function new_possuiimovel_onchange()
{
    if(Xrm.Page.getAttribute("new_possuiimovel").getValue() == 1)
    {
        Xrm.Page.getControl("new_motivodacompra").getDisabled()=false;
        Xrm.Page.getAttribute("new_motivodanaocompra").getValue() =null;
        Xrm.Page.getControl("new_motivodanaocompra").getDisabled()=true;
    }
    else
    {
        Xrm.Page.getControl("new_motivodanaocompra").getDisabled()=false;
        Xrm.Page.getAttribute("new_motivodacompra").getValue() =null;
        Xrm.Page.getControl("new_motivodacompra").getDisabled()=true;
    }
}

function new_outraconstrutora_onchange()
{
    if(Xrm.Page.getAttribute("new_outraconstrutora").getValue() == 0 )
    {
        Xrm.Page.getControl("new_construtorasid").setVisible(false);
        Xrm.Page.getControl("new_construtorasid").setVisible(false);
    }
    else
    {
        Xrm.Page.getControl("new_construtorasid").setVisible(true);
        Xrm.Page.getControl("new_construtorasid").setVisible(true);
    }
}

function new_pesquisounainternet_onchange()
{
    if(Xrm.Page.getAttribute("new_pesquisounainternet").getValue() == 0 )
    {
        Xrm.Page.getControl("new_qualosite").setVisible(false);
        Xrm.Page.getControl("new_qualosite").setVisible(false);
    }
    else
    {
        Xrm.Page.getControl("new_qualosite").setVisible(true);
        Xrm.Page.getControl("new_qualosite").setVisible(true);
    }
}