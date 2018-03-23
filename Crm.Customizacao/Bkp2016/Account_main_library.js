function Form_onload() {
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
            var elm = document.createElement("script");
            elm.src = "/_static/_grid/cmds/util.js";
            document.appendChild(elm);

            crmForm.SalvaDiaMesNascimento = function () {
                if (crmForm.all.new_datadenascimento.DataValue != null) {
                    var dataNascimento = crmForm.all.new_datadenascimento.DataValue;
                    crmForm.all.new_dia_nascimento.DataValue = dataNascimento.getDate();
                    crmForm.all.new_mes_nascimento.DataValue = (dataNascimento.getMonth() + 1);
                    crmForm.all.new_dia_nascimento.ForceSubmit = true;
                    crmForm.all.new_mes_nascimento.ForceSubmit = true;
                }
            }

            //Esconde a opção "União Estável" do picklist "Estado Civil"
            crmForm.all.new_estadocivil.remove(EstadoCivil.UNIAO_ESTAVEL);

            crmForm.EscondeCampo = function (nomeCampo, esconde) {
                var tipo = "";
                if (esconde)
                    tipo = "none";

                var atributo_c = eval("crmForm.all." + nomeCampo + "_c");
                var atributo_d = eval("crmForm.all." + nomeCampo + "_d");
                atributo_c.style.display = tipo;
                atributo_d.style.display = tipo;
            }

            crmForm.DesabilitaHabilitaCampos = function (atributos, desabilita) {
                var tmp = atributos.split(";");
                for (index = 0; index < tmp.length; index++) {
                    var object = eval("crmForm.all." + tmp[index])
                    object.Disabled = desabilita;
                }
            }

            //Ocultando links
            if (document.getElementById("navQuotes"))
                document.getElementById("navQuotes").style.display = "none";

            if (document.getElementById("navContracts"))
                document.getElementById("navContracts").style.display = "none";

            //ocultando campo quantos filhos---------------------------------------------------------//
            if (crmForm.all.new_temfilhos.DataValue != null && crmForm.all.new_temfilhos.DataValue == 1) {
                crmForm.all.new_quantidadedefilhos_c.style.visibility = "visible";
                crmForm.all.new_quantidadedefilhos_d.style.visibility = "visible";
            }
            else {
                crmForm.all.new_quantidadedefilhos_c.style.visibility = "hidden";
                crmForm.all.new_quantidadedefilhos_d.style.visibility = "hidden";
            }


            //ocultando guias---------------------------------------------------------------------------//
            crmForm.all.tab2Tab.style.display = "none";

            //ocultando campos inscrição municipal e estadual-------------------------------------//
            if (crmForm.all.new_exinscricaomunicipal.DataValue == 0) {
                crmForm.all.new_inscricaomunicipal_c.style.visibility = "hidden";
                crmForm.all.new_inscricaomunicipal_d.style.visibility = "hidden";
            }

            if (crmForm.all.new_exinscricaoestadual.DataValue == 0) {
                crmForm.all.new_inscricaoestadual_c.style.visibility = "hidden";
                crmForm.all.new_inscricaoestadual_d.style.visibility = "hidden";
            }

            //Condicao no Botao SIm/NAO para pessoa física ou pessoa jurídica
            if (crmForm.all.new_tipodecliente.DataValue != null && crmForm.all.new_tipodecliente.DataValue == 0) {
                crmForm.all.tab1Tab.style.display = "inline";
                crmForm.all.tab2Tab.style.display = "none";

            }
            else {
                crmForm.all.tab1Tab.style.display = "none";
                crmForm.all.tab2Tab.style.display = "inline";
            }


            //CONDIÇÃO DO BOTÃO SIM/NÃO PARA A GUIA POSUI IMOVEL--------------------------
            if (crmForm.all.new_possuiimovel.DataValue != null && crmForm.all.new_possuiimovel.DataValue == 1) {
                crmForm.all.new_motivodacompra.Disabled = false;
                crmForm.all.new_motivodanaocompra.DataValue = null;
                crmForm.all.new_motivodanaocompra.Disabled = true;
            }
            else {
                crmForm.all.new_motivodanaocompra.Disabled = false;
                crmForm.all.new_motivodacompra.DataValue = null;
                crmForm.all.new_motivodacompra.Disabled = true;
            }

            //Bit - sim - não - Ocultar nome do campo e campo do formulario CAMPO INVESTIMENTO--
            if (crmForm.all.new_investimento.DataValue != null && crmForm.all.new_investimento.DataValue == false) {
                crmForm.all.new_bairroparainvestimento_c.style.visibility = 'hidden';
                crmForm.all.new_bairroparainvestimento_d.style.visibility = 'hidden';
            }
            else {
                crmForm.all.new_bairroparainvestimento_c.style.visibility = 'visible';
                crmForm.all.new_bairroparainvestimento_d.style.visibility = 'visible';
            }

            //Chama evento onchange do campo Nacionalidade
            crmForm.all.new_nacionalidade.FireOnChange();

            //ocultar campo de construtoras em pesquisa de midia-------------
            if (crmForm.all.new_outraconstrutora.DataValue != null && crmForm.all.new_outraconstrutora.DataValue == 0) {
                crmForm.all.new_construtorasid_c.style.visibility = 'hidden';
                crmForm.all.new_construtorasid_d.style.visibility = 'hidden';
            }
            else {
                crmForm.all.new_construtorasid_c.style.visibility = 'visible';
                crmForm.all.new_construtorasid_d.style.visibility = 'visible';
            }

            //ocultar campo de sites em pesquisa de midia-------------
            if (crmForm.all.new_pesquisounainternet.DataValue != null && crmForm.all.new_pesquisounainternet.DataValue == 0) {
                crmForm.all.new_qualosite_c.style.visibility = 'hidden';
                crmForm.all.new_qualosite_d.style.visibility = 'hidden';
            }
            else {
                crmForm.all.new_qualosite_c.style.visibility = 'visible';
                crmForm.all.new_qualosite_d.style.visibility = 'visible';
            }

            if (crmForm.all.new_tipodecliente.DataValue != null && crmForm.all.new_tipodecliente.DataValue == true)
                crmForm.all.new_grupo_contas.DataValue = "ZPJU";
            else
                crmForm.all.new_grupo_contas.DataValue = "ZPFI";

            //chamar script para ocultar o campo de uf do orgao de expedicao
            new_orgao_expedicao_onchange0();

            crmForm.SetaMoeda = function (valor) {
                var todosInputs = document.getElementsByTagName("input");
                for (var i = 0; i < todosInputs.length; i++) {
                    if (todosInputs[i].title == "Moeda") {
                        todosInputs[i].value = valor;
                    }
                }
            }

            //Setar Real como default no campo de moeda
            if (crmForm.all.transactioncurrencyid.DataValue == null) {
                var lookupData = new Array();
                var lookupItem = new Object();

                lookupItem.id = "{DA713EF1-8041-DD11-A6D4-001B7845B4A6}";
                lookupItem.typename = "transactioncurrency";
                lookupItem.name = "Real";
                lookupData[0] = lookupItem;
                crmForm.all.transactioncurrencyid.DataValue = lookupData;
                crmForm.SetaMoeda("R$");
            }

            InformacoesUsuario = function () {
                var objeto = this;
                this.Fullname = "";
                this.Id = "";
                this.Login = "";
                this.EquipeRelacionamentoNome = "";
                this.EquipeRelacionamentoValue = "";
                this.Equipes;

                //Obter informações.
                var cmd = new RemoteCommand("MrvService", "ObterInformacoesUsuario", "/MRVCustomizations/");
                var result = cmd.Execute();
                if (result.Success) {
                    if (result.ReturnValue.Mrv.Error) {
                        crmForm.DesabilitarFormularioErro(result.ReturnValue.Mrv.Error);
                    } else if (result.ReturnValue.Mrv.ErrorSoap) {
                        crmForm.DesabilitarFormularioErro(result.ReturnValue.Mrv.ErrorSoap);
                    }
                    else {
                        this.Fullname = result.ReturnValue.Mrv.Fullname;
                        this.Id = result.ReturnValue.Mrv.Id;
                        this.Login = result.ReturnValue.Mrv.Login;
                        this.EquipeRelacionamentoNome = result.ReturnValue.Mrv.EquipeRelacionamentoNome;
                        this.EquipeRelacionamentoValue = result.ReturnValue.Mrv.EquipeRelacionamentoValue;

                        if (result.ReturnValue.Mrv.Equipes) {
                            this.Equipes = result.ReturnValue.Mrv.Equipes.split(';');
                        }
                    }
                }
                else {
                    //Desabilitar todo o formulário.
                    alert("Erro na consulta das informações do usuário.");
                    window.location.href = window.location.href;
                }

                objeto.PertenceA = function (nomeEquipe) {
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
            crmForm.UsuarioAdministrador = function () {
                return Informacoes.PertenceA("Administradores");
            }

            //definir campo tipo de cliente como permutante, quando o usuário pertencer a equipe "Permuta Financeira"
            if (Informacoes.PertenceA("Permuta Financeira")) {
                crmForm.all.new_permutante.Disabled = false;
            }

            function BloquearCampos() {
                var objeto = this;
                objeto.Proposta = function (bloqueio) {
                    crmForm.DesabilitaHabilitaCampos("new_cpf;new_cnpj", bloqueio);
                }

                //ALTERAÇÂO - DEFS 506635
                objeto.PerfilContratoERecebimento = function (bloqueio) {
                    var atributos = "new_cnpj;new_inscricaomunicipal;new_exinscricaomunicipal;new_exinscricaoestadual;new_inscricaoestadual;name;new_cpf;new_registrogeraln;new_datadeexpedicao;new_orgao_expedicao;new_uf_orgao_expedicao;new_estadocivil";
                    crmForm.DesabilitaHabilitaCampos(atributos, bloqueio);
                }

                objeto.Contrato = function (bloqueio) {
                    var atributos = "name;address1_postalcode;new_tipologradouro;address1_line1;new_numero;new_complemento;new_bairro;new_cidadeid;new_estado;new_pais;new_tipodecliente;new_registrogeraln;new_datadeexpedicao;new_orgao_expedicao;new_uf_orgao_expedicao;new_nomedopai;new_nomedamae;new_nacionalidade;new_naturalidadeid;new_sexo;new_endereco_confere;new_endereco_nacional;new_cidadeestrangeira;new_estadoestrangeiro";
                    crmForm.DesabilitaHabilitaCampos(atributos, bloqueio);
                }

                // Campos desabilitados para clientes com oportunidades ganhas
                objeto.OportunidadeGanha = function (bloqueio) {
                    var atributos = "new_cpf;new_cnpj;name;address1_postalcode;new_tipologradouro;address1_line1;new_numero;new_complemento;new_bairro;new_cidadeid;new_estado;new_pais;new_tipodecliente;new_registrogeraln;new_datadeexpedicao;new_orgao_expedicao;new_uf_orgao_expedicao;new_nomedopai;new_nomedamae;new_nacionalidade;new_naturalidadeid;new_sexo;new_endereco_confere;new_endereco_nacional;new_cidadeestrangeira;new_estadoestrangeiro;new_estadocivil;new_datadenascimento";
                    crmForm.DesabilitaHabilitaCampos(atributos, bloqueio);
                }
            }

            var bloquear = new BloquearCampos();

            if (crmForm.FormType == TypeUpdate) { //formulario for UPDATE
                //Liberar campos de códigos de cliente
                if (crmForm.UsuarioAdministrador()) {
                    crmForm.DesabilitaHabilitaCampos("new_codsap6;new_codigoparceiroconjuge;new_codigoparceirorepvendas;new_codigoparceiroprocurador;new_codigoparceirofiador", false);
                }

                if (!crmForm.UsuarioAdministrador()) {
                    //Verificar oportunidade do cliente
                    //Se existe proposta ou contrato
                    var cmd = new RemoteCommand("MrvService", "VerficarOportunidadesContratos", "/MrvCustomizations/");
                    cmd.SetParameter("clienteId", crmForm.ObjectId);
                    var resultado = cmd.Execute();
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

                        if (crmForm.UsuarioPertenceEquipe(Equipe.AT_CLIENTE_SAP) && crmForm.all.accountclassificationcode.DataValue == Cliente_Manutencao) {
                            crmForm.all.new_cod_cliente_manutencao.Disabled = false;
                        }
                        else {
                            crmForm.all.new_cod_cliente_manutencao.Disabled = true;
                        }

                    } else {
                        alert("Erro na consulta do método VerficarOportunidadesContratos");
                        formularioValido = false;
                    }
                }
            }

            crmForm.TratarRetornoRemoteCommand = function (resultado, nomeMetodo) {
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

            crmForm.ExibirCamposEstrangeiro = function (visivel) {

                // Definine a visibilidade dos campos de informações estrangeiras
                crmForm.EscondeCampo("new_cidadeestrangeira", !visivel);
                crmForm.EscondeCampo("new_estadoestrangeiro", !visivel);
            }

            crmForm.TrataExibicaoCampoEnderecoConfere = function () {
                var temPerfilDeConfereEndereco = Informacoes.PertenceA("Confere Endereço");
                crmForm.EscondeCampo("new_endereco_confere", !temPerfilDeConfereEndereco);

                if (crmForm.all.new_endereco_confere.DataValue == null)
                    crmForm.all.new_endereco_confere.DataValue = true;
                else {
                    if (temPerfilDeConfereEndereco)
                        crmForm.TrataEnderecoConfere();
                }
            }

            crmForm.TrataEnderecoConfere = function () {
                if (crmForm.all.new_endereco_nacional.DataValue) {
                    var habilitaCampoEndereco = crmForm.all.new_endereco_confere.DataValue;
                    crmForm.DesabilitaHabilitaCampos("new_cidadeid;new_estado;new_pais", true);
                    crmForm.DesabilitaHabilitaCampos("new_complemento;new_numero", false);
                    crmForm.DesabilitaHabilitaCampos("address1_line1;new_tipologradouro;new_bairro", habilitaCampoEndereco);
                    crmForm.DesabilitaHabilitaCampos("new_endereco_confere", !habilitaCampoEndereco);

                    if (!habilitaCampoEndereco && (crmForm.FormType == TypeCreate || crmForm.FormType == TypeUpdate)) {
                        crmForm.all.new_endereco_confere.ForceSubmit = true;
                    }

                    if (crmForm.all.new_pais.DataValue == null) {
                        crmForm.all.new_pais.DataValue = Pais.BRASIL;
                    }

                    if (crmForm.all.new_pais.DataValue != Pais.BRASIL) {
                        crmForm.TrataPais();
                    }
                }
            }

            crmForm.TrataPais = function () {
                var enderecoNacional = crmForm.all.new_endereco_nacional.DataValue;
                if (enderecoNacional && crmForm.all.new_pais.DataValue == Pais.BRASIL) {
                    crmForm.all.new_pais.Disabled = true;
                }
                else if (!enderecoNacional && crmForm.all.new_pais.SelectedIndex > 0 && crmForm.all.new_pais.DataValue == Pais.BRASIL) {
                    alert(Mensagem.PAIS_ESTRANGEIRO_NAO_SELECIONADO);
                    crmForm.all.new_pais.SelectedIndex = 0;
                }
                else {
                    crmForm.all.new_pais.Disabled = false;
                }
            }

            crmForm.TratarExibicaoEnderecoNacional = function () {
                if (crmForm.all.new_endereco_nacional.DataValue == null) {
                    crmForm.all.new_endereco_nacional.DataValue = true;
                }
                var enderecoNacional = crmForm.all.new_endereco_nacional.DataValue;
                if (enderecoNacional) {
                    crmForm.ExibirCamposEstrangeiro(false);
                    crmForm.EscondeCampo("new_endereco_confere", false);

                    crmForm.TrataEnderecoConfere();

                    if (crmForm.all.new_pais.DataValue != Pais.BRASIL) {
                        crmForm.all.new_pais.DataValue = Pais.BRASIL;
                        crmForm.all.new_pais.Disabled = true;
                    }
                    crmForm.all.new_cidadeestrangeira.DataValue = null;
                    crmForm.all.new_estadoestrangeiro.DataValue = null;
                }
                else {
                    crmForm.EscondeCampo("new_endereco_confere", true);
                    crmForm.all.new_estado.SelectedIndex = 0;
                    crmForm.all.new_estado.Disabled = true;
                    crmForm.all.new_cidadeid.Disabled = true;
                    crmForm.all.new_cidadeid.DataValue = null;
                    crmForm.all.new_estado.DataValue = null;
                    if (crmForm.all.new_pais.DataValue == Pais.BRASIL) {
                        crmForm.all.new_pais.SelectedIndex = 0;
                    }
                    crmForm.ExibirCamposEstrangeiro(true);
                }
            }

            crmForm.TratarEnderecoNacional = function () {
                var enderecoNacional = crmForm.all.new_endereco_nacional.DataValue;
                if (enderecoNacional) {
                    crmForm.ExibirCamposEstrangeiro(false);
                    crmForm.EscondeCampo("new_endereco_confere", false);
                    if (crmForm.all.new_pais.DataValue != Pais.BRASIL) {
                        crmForm.all.new_pais.DataValue = Pais.BRASIL;
                        crmForm.all.new_pais.Disabled = true;
                    }
                    crmForm.all.new_cidadeestrangeira.DataValue = null;
                    crmForm.all.new_estadoestrangeiro.DataValue = null;
                }
                else {
                    crmForm.EscondeCampo("new_endereco_confere", true);
                    crmForm.all.new_estado.Disabled = true;
                    crmForm.all.new_cidadeid.Disabled = true;
                    crmForm.all.new_cidadeid.DataValue = null;
                    crmForm.all.new_estado.SelectedIndex = 0;
                    crmForm.all.new_estado.DataValue = null;
                    if (crmForm.all.new_pais.DataValue == Pais.BRASIL) {
                        crmForm.all.new_pais.SelectedIndex = 0;
                    }
                    crmForm.all.new_pais.Disabled = false;
                    crmForm.ExibirCamposEstrangeiro(true);
                }
            }

            crmForm.TrataExibicaoCampoEnderecoConfere();
            crmForm.TratarExibicaoEnderecoNacional();

            crmForm.BuscaDadosTelefone = function (tipo, campo) {
                var cidadeId = null;
                var enderecoNacional = crmForm.all.new_endereco_nacional.DataValue;

                if (enderecoNacional) {
                    if (crmForm.all.new_cidadeid.DataValue == null) {
                        alert("Preencha o campo Cidade!");
                        event.srcElement.DataValue = "";
                        return false;
                    }

                    cidadeId = crmForm.all.new_cidadeid.DataValue[0].id;
                }

                if (event.srcElement.DataValue != null && event.srcElement.DataValue == "..") {
                    if (campo == "telephone1" && crmForm.all.new_cidadeid.DataValue != null && enderecoNacional) {
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
                        event.srcElement.DataValue = retorno;
                    else
                        event.srcElement.DataValue = "";
                } else if (event.srcElement.DataValue != null && event.srcElement.DataValue != "..") {
                    alert("Digite apenas ..");
                    event.srcElement.DataValue = "";
                }
            }

            crmForm.ValidarEndereco = function () {

                var enderecoNacional = crmForm.all.new_endereco_nacional.DataValue;

                var resumido = crmForm.all.address2_line1.DataValue != null ? crmForm.all.address2_line1.DataValue : "";
                var endereco = crmForm.all.address1_line1.DataValue != null ? crmForm.all.address1_line1.DataValue : "";
                var numero = crmForm.all.new_numero.DataValue != null ? crmForm.all.new_numero.DataValue : "";
                var complemento = crmForm.all.new_complemento.DataValue != null ? crmForm.all.new_complemento.DataValue : "";
                var tipo_logradouro = crmForm.all.new_tipologradouro.DataValue != null ? crmForm.all.new_tipologradouro.DataValue : "";
                var bairro = crmForm.all.new_bairro.DataValue != null ? crmForm.all.new_bairro.DataValue : "";

                if (enderecoNacional) {

                    if (crmForm.all.address1_postalcode.DataValue == null && (endereco != "" || numero != "" || complemento != "" || resumido != "" || tipo_logradouro != "" || bairro != "")) {
                        alert(Mensagem.MENSAGEM_CEP_NAO_PREENCHIDO);
                        return false;
                    }

                    if (crmForm.all.address1_postalcode.DataValue != null) {
                        var cep = crmForm.all.address1_postalcode.DataValue.replace(/[^0-9]/g, "");

                        if (cep.length != CEP_LENGTH) {
                            alert(Mensagem.MENSAGEM_CEP_FORA_FAIXA);
                            return false;
                        }
                    }
                }

                return true;
            }

            crmForm.LimpaCampos = function () {
                crmForm.all.new_bairro.DataValue = null;
                crmForm.all.new_complemento.DataValue = null;
                crmForm.all.address1_line1.DataValue = null;
                crmForm.all.new_tipologradouro.DataValue = null;
                crmForm.all.new_numero.DataValue = null;
                crmForm.all.address2_line1.DataValue = null;
                crmForm.all.new_estado.SelectedIndex = 0;
                crmForm.all.new_pais.SelectedIndex = 0;
                crmForm.all.new_estadoestrangeiro.DataValue = null;
                crmForm.all.new_cidadeestrangeira.DataValue = null;
                crmForm.all.new_cidadeid.DataValue = null;
            }

            crmForm.ValidarCEP = function (campo) {
                crmForm.LimpaCampos();
                if (typeof (campo) != "undefined" && campo != null) {
                    if (campo.DataValue != null) {
                        // Valida se é um endereço nacional
                        if (crmForm.all.new_endereco_nacional.DataValue) {
                            var sTmp = campo.DataValue.replace(/[^0-9]/g, "");

                            if (sTmp.length != 8) {
                                campo.DataValue = null;
                                alert(Mensagem.MENSAGEM_CEP_FORA_FAIXA);
                            }
                            else {
                                crmForm.ObterEndereco(campo.DataValue);
                                campo.DataValue = sTmp.substr(0, 2) + "." + sTmp.substr(2, 3) + "-" + sTmp.substr(5, 3);
                            }
                        }
                    }
                    else { crmForm.ObterEndereco(campo.DataValue); }
                }
            }

            // Define os filtros de cidade à partir do cep informado
            crmForm.DefinirFiltroCidade = function (cep) {
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

            crmForm.SetUF = function (nome, picklistField) {
                for (i = 0; i < picklistField.Options.length; i++) {
                    if (picklistField.Options[i].Text.toUpperCase() == nome.toUpperCase())
                        picklistField.SelectedIndex = i;
                }
            }

            crmForm.SetTipoLogradouro = function (nome, picklistField) {
                for (i = 0; i < picklistField.Options.length; i++) {
                    if (picklistField.Options[i].Text.toUpperCase() == nome.toUpperCase()) {
                        picklistField.SelectedIndex = i;
                        return;
                    }
                }
                picklistField.SelectedIndex = 41;
            }

            crmForm.ObterEndereco = function (cep) {

                if (cep != null) {
                    cep = cep.replace(".", "");
                    cep = cep.replace("-", "");

                    var cmd = new RemoteCommand("MrvService", "GetAddressByCep", "/MRVCustomizations/");
                    cmd.SetParameter("cep", cep);
                    var result = cmd.Execute();
                    if (result.Success) {

                        if (!result.ReturnValue.Mrv.IsNull && !result.ReturnValue.Mrv.Error) {
                            if (typeof (result.ReturnValue.Mrv.TIPORUA) != "object" && typeof (result.ReturnValue.Mrv.NOMERUA) != "object") {
                                crmForm.all.address1_line1.DataValue = result.ReturnValue.Mrv.TIPORUA + " " + result.ReturnValue.Mrv.NOMERUA;
                            }
                            else if (typeof (result.ReturnValue.Mrv.NOMERUA) != "object") {
                                crmForm.all.address1_line1.DataValue = result.ReturnValue.Mrv.NOMERUA;
                            }
                            else {
                                crmForm.all.address1_line1.DataValue = null;
                            }

                            if (crmForm.all.address1_line1.DataValue == "" || crmForm.all.address1_line1.DataValue == null)
                                crmForm.all.address1_line1.Disabled = false;
                            else
                                crmForm.all.address1_line1.Disabled = true;

                            if (typeof (result.ReturnValue.Mrv.TIPORUA) != "object") {
                                crmForm.SetTipoLogradouro(result.ReturnValue.Mrv.TIPORUA, crmForm.all.new_tipologradouro);
                                crmForm.all.new_tipologradouro.Disabled = true;
                            }
                            else {
                                crmForm.all.new_tipologradouro.Disabled = false;
                            }

                            if (typeof (result.ReturnValue.Mrv.COMPLEMENTO) != "object") {
                                if (result.ReturnValue.Mrv.COMPLEMENTO.length <= 10)
                                    crmForm.all.new_complemento.DataValue = result.ReturnValue.Mrv.COMPLEMENTO;
                            }

                            if (typeof (result.ReturnValue.Mrv.NOMERUAREDUZIDO) != "object") {
                                crmForm.all.address2_line1.DataValue = result.ReturnValue.Mrv.NOMERUAREDUZIDO;
                                crmForm.all.address2_line1.Disabled = true;
                            }

                            if (typeof (result.ReturnValue.Mrv.UF) != "object") {
                                crmForm.SetUF(result.ReturnValue.Mrv.UF, crmForm.all.new_estado);
                                crmForm.all.new_pais.SelectedIndex = 10;
                            }

                            if (typeof (result.ReturnValue.Mrv.BAIRRO) != "object") {
                                if (result.ReturnValue.Mrv.BAIRRO.length <= 15) {
                                    crmForm.all.new_bairro.DataValue = result.ReturnValue.Mrv.BAIRRO;
                                    crmForm.all.new_bairro.Disabled = true;
                                } else {
                                    crmForm.all.new_bairro.Disabled = false;
                                    crmForm.all.new_bairro.DataValue = result.ReturnValue.Mrv.BAIRRO.slice(0, 15);
                                }
                            }
                            else {
                                crmForm.all.new_bairro.Disabled = false;
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
                                        lookupItem.typename = 'new_cidade';
                                        lookupItem.name = result.ReturnValue.Mrv.CIDADE;
                                        lookupData[0] = lookupItem;
                                        crmForm.all.new_cidadeid.DataValue = lookupData;
                                    }
                                }
                            }
                            crmForm.DesabilitaHabilitaCampos("new_estado;new_cidadeid;new_pais", true);
                            crmForm.ExibirCamposEstrangeiro(false);
                            crmForm.all.new_estadoestrangeiro.DataValue = null;
                            crmForm.all.new_cidadeestrangeira.DataValue = null;

                            var enderecoConfere = (crmForm.all.address1_line1.DataValue != null && crmForm.all.new_tipologradouro.DataValue != null &&
                                                    crmForm.all.new_cidadeid.DataValue != null && crmForm.all.new_bairro.DataValue != null);

                            crmForm.all.new_endereco_confere.DataValue = enderecoConfere;
                            crmForm.DesabilitaHabilitaCampos("new_endereco_confere", !enderecoConfere);

                            if (crmForm.FormType == TypeCreate || crmForm.FormType == TypeUpdate) {
                                crmForm.all.new_endereco_confere.ForceSubmit = true;
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

                            crmForm.all.new_endereco_confere.DataValue = false;
                            crmForm.DesabilitaHabilitaCampos("new_endereco_confere", true);

                            if (crmForm.FormType == TypeCreate || crmForm.FormType == TypeUpdate) {
                                crmForm.all.new_endereco_confere.ForceSubmit = true;
                            }

                            crmForm.LimpaCampos();
                            crmForm.DesabilitaHabilitaCampos("new_cidadeid;address1_line1;new_bairro;new_tipologradouro", false);
                            crmForm.DesabilitaHabilitaCampos("new_estado;new_pais", true);
                            crmForm.ExibirCamposEstrangeiro(false);
                        }
                    }
                }
            }

            crmForm.ResumirEndereco = function () {
                if (crmForm.all.address1_line1.DataValue != null && crmForm.all.new_tipologradouro.SelectedText != "") {
                    var endereco = crmForm.all.address1_line1.DataValue.split(' ');
                    var enderecoresumido = "";
                    var ultimoEndereco = endereco.length - 1;

                    try {
                        var tipologradouro = crmForm.all.new_tipologradouro.SelectedText.toLowerCase();
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

                    crmForm.all.address2_line1.DataValue = enderecoresumido;
                }
            }

            crmForm.RemoverAcento = function (texto) {
                texto = texto.replace(new RegExp('[ÁÀÂÃ]', 'gi'), 'a');
                texto = texto.replace(new RegExp('[ÉÈÊ]', 'gi'), 'e');
                texto = texto.replace(new RegExp('[ÍÌÎ]', 'gi'), 'i');
                texto = texto.replace(new RegExp('[ÓÒÔÕ]', 'gi'), 'o');
                texto = texto.replace(new RegExp('[ÚÙÛ]', 'gi'), 'u');
                texto = texto.replace(new RegExp('[Ç]', 'gi'), 'c');
                return texto;
            }

            // Desabilita Campo Endereço Resumido
            crmForm.all.address2_line1.Disabled = true;

            //Boleto Ditital : Controles para liberação de alteração de adesao
            crmForm.AdesaoBoletoChange = function () {
                crmForm.SetFieldReqLevel("new_motivo_nao_adesao", false);
                if (AdesaoBoletoAtual != null && crmForm.all.new_adesao_boleto_digital.DataValue) {
                }
                if (crmForm.all.new_adesao_boleto_digital.DataValue == AdesaoBoletoSim) {
                    var data = new Date();
                    crmForm.all.new_data_adesao_boleto_digital.DataValue = data;
                    crmForm.all.new_data_adesao_boleto_digital.ForceSubmit = true;
                    crmForm.all.new_origem_adesao.DataValue = 'RELACIONAMENTO';
                    crmForm.all.new_origem_adesao.ForceSubmit = true;
                    crmForm.all.new_motivo_nao_adesao.DataValue = null;
                    crmForm.all.new_motivo_nao_adesao.ForceSubmit = true;
                    crmForm.DesabilitaHabilitaCampos("new_motivo_nao_adesao", true);
                    crmForm.all.new_adesao_boleto_sincronizado.DataValue = false;
                    crmForm.all.new_adesao_boleto_sincronizado.ForceSubmit = true;
                }
                else {
                    //Consulta sap para verificar desadesao
                    var codigoCliente = crmForm.all.new_codsap6.DataValue;
                    if (AdesaoBoletoAtual == AdesaoBoletoSim && codigoCliente != null) {
                        try {
                            var cmd = new RemoteCommand("MrvService", "ConsultaAdesaoBoletoDigital", "/MrvCustomizations/");
                            cmd.SetParameter("codigoCliente", codigoCliente);
                            var resultado = cmd.Execute();
                            if (!resultado.ReturnValue.Mrv.Success) {
                                alert(resultado.ReturnValue.Mrv.Error);
                                crmForm.all.new_adesao_boleto_digital.DataValue = AdesaoBoletoAtual;
                                return;
                            }
                        }
                        catch (error) {
                            alert("Não foi possível realizar a verificação para desadesão. Por favor tente novamente.\n" + error.description);
                            crmForm.all.new_adesao_boleto_digital.DataValue = adesaoBoletoAtual;
                            return;
                        }
                    }
                    var data = new Date();
                    crmForm.all.new_data_adesao_boleto_digital.DataValue = data;
                    crmForm.all.new_data_adesao_boleto_digital.ForceSubmit = true;
                    crmForm.all.new_origem_adesao.DataValue = 'RELACIONAMENTO';
                    crmForm.all.new_origem_adesao.ForceSubmit = true;
                    crmForm.DesabilitaHabilitaCampos("new_motivo_nao_adesao", false);
                    crmForm.SetFieldReqLevel("new_motivo_nao_adesao", true);
                    crmForm.all.new_adesao_boleto_sincronizado.DataValue = false;
                    crmForm.all.new_adesao_boleto_sincronizado.ForceSubmit = true;
                }
            } //Fim AdesaoBoletoChange

            if (crmForm.FormType == TypeUpdate && (crmForm.UsuarioAdministrador() || Informacoes.PertenceA("REL_ADESAO_BOLETO"))) {
                AdesaoBoletoAtual = crmForm.all.new_adesao_boleto_digital.DataValue;
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

            oScript.onreadystatechange = function () {
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

function Form_onsave() {
    try {
        if (!formularioValido) {
            alert("Ocorreu um erro no formulário. Impossível salvar.");
            event.returnValue = false;
            return false;
        }
        crmForm.SalvaDiaMesNascimento();

        var endereco = "";
        var enderecoResumido = "";
        var complemento = "";
        var bairro = "";

        if (crmForm.all.telephone1.DataValue == null && crmForm.all.address1_telephone3.DataValue == null) {
            alert("O número de telefone residencial ou o telefone celular devem estar preenchidos para finalizar o cadastro do Cliente");
            event.returnValue = false;
            return false;
        }

        if (crmForm.all.address1_line1.DataValue != null)
            endereco = crmForm.all.address1_line1.DataValue.toString();

        if (crmForm.all.address2_line1.DataValue != null)
            enderecoResumido = crmForm.all.address2_line1.DataValue.toString();

        if (crmForm.all.new_complemento.DataValue != null)
            complemento = crmForm.all.new_complemento.DataValue.toString();

        if (crmForm.all.new_bairro.DataValue != null)
            bairro = crmForm.all.new_bairro.DataValue.toString();

        var nome = crmForm.all.name.DataValue.toString();
        if (endereco.indexOf(";") != -1 || nome.indexOf(";") != -1 || enderecoResumido.indexOf(";") != -1 || complemento.indexOf(";") != -1 || bairro.indexOf(";") != -1) {
            alert('Não é possível salvar com ";" nos campos do endereço ou no nome do cliente.');
            event.returnValue = false;
            return false;
        }

        if (!crmForm.ValidarEndereco()) {
            event.returnValue = false;
            return false;
        }

        var cidadeId = "";
        var ddd = "";
        if (crmForm.all.new_endereco_nacional.DataValue) {
            if (crmForm.all.new_cidadeid.DataValue != null) {
                cidadeId = crmForm.all.new_cidadeid.DataValue[0].id;

                var cmdDadosCidade = new RemoteCommand("MrvService", "retornarEstadoEDDD", "/MRVCustomizations/");
                cmdDadosCidade.SetParameter("cidadeId", cidadeId);
                var oResultado = cmdDadosCidade.Execute();
                if (oResultado.ReturnValue.Mrv.Error && oResultado.ReturnValue.Mrv.ErrorSoap) {
                    ddd = "";
                }
                else {
                    if (crmForm.TratarRetornoRemoteCommand(oResultado, "retornarEstadoEDDD")) {
                        if (typeof (oResultado.ReturnValue.Mrv.ddd) == "object") { //object = retorno vazio, ou seja, não existe ddd para a cidade informada
                            ddd = "";
                        }
                        else {
                            ddd = oResultado.ReturnValue.Mrv.ddd;
                        }
                    }
                }
            }
        }

        var ddi = (crmForm.all.new_pais.SelectedIndex == Pais.BRASIL ? DDI.Brasil : "");

        var cpfCnpj = "";

        if (crmForm.all.new_tipodecliente.DataValue == 0) { //CPF
            cpfCnpj = crmForm.all.new_cpf == null ? '' : crmForm.all.new_cpf.DataValue;
        }
        else {
            cpfCnpj = crmForm.all.new_cnpj == null ? '' : crmForm.all.new_cnpj.DataValue;
        }

        //Valida telefones
        var cmdValidaTelefones = new RemoteCommand("SrvCliente", "ValidaCadastroCliente", "/MRVCustomizations/");

        if (crmForm.all.new_tipodecliente.DataValue == 0) //CPF
        {
            if (crmForm.all.new_cpf.DataValue != null) {
                cmdValidaTelefones.SetParameter("cpfCnpj", crmForm.all.new_cpf.DataValue);
            }
            else {
                cmdValidaTelefones.SetParameter("cpfCnpj", '');
            }
        }
        else {
            if (crmForm.all.new_cnpj.DataValue != null) {
                cmdValidaTelefones.SetParameter("cpfCnpj", crmForm.all.new_cnpj.DataValue);
            }
            else {
                cmdValidaTelefones.SetParameter("cpfCnpj", '');
            }
        }

        if (crmForm.all.name.DataValue != null) {
            cmdValidaTelefones.SetParameter("nome", crmForm.all.name.DataValue);
        }
        else {
            cmdValidaTelefones.SetParameter("nome", '');
        }

        if (crmForm.all.address1_postalcode.DataValue != null) {
            cmdValidaTelefones.SetParameter("cep", crmForm.all.address1_postalcode.DataValue);
        }
        else {
            cmdValidaTelefones.SetParameter("cep", '');
        }

        cmdValidaTelefones.SetParameter("DDD", ddd.toString());
        cmdValidaTelefones.SetParameter("DDI", ddi.toString());


        if (crmForm.all.telephone1.DataValue != null) {
            cmdValidaTelefones.SetParameter("telefoneResidencial", crmForm.all.telephone1.DataValue);
        }
        else {
            cmdValidaTelefones.SetParameter("telefoneResidencial", '');
        }
        if (crmForm.all.telephone2.DataValue != null) {
            cmdValidaTelefones.SetParameter("telefoneComercial", crmForm.all.telephone2.DataValue);
        }
        else {
            cmdValidaTelefones.SetParameter("telefoneComercial", '');
        }

        if (crmForm.all.address1_telephone3.DataValue != null) {
            cmdValidaTelefones.SetParameter("celular", crmForm.all.address1_telephone3.DataValue);
        }
        else {
            cmdValidaTelefones.SetParameter("celular", '');
        }

        if (crmForm.all.fax.DataValue != null) {
            cmdValidaTelefones.SetParameter("faxCelular2", crmForm.all.fax.DataValue);
        }
        else {
            cmdValidaTelefones.SetParameter("faxCelular2", '');
        }

        if (crmForm.all.new_outrotelefone.DataValue != null) {
            cmdValidaTelefones.SetParameter("outroTelefone", crmForm.all.new_outrotelefone.DataValue);
        }
        else {
            cmdValidaTelefones.SetParameter("outroTelefone", '');
        }

        if (crmForm.all.new_telefoneum.DataValue != null) {
            cmdValidaTelefones.SetParameter("telefoneEnriquecimento1", crmForm.all.new_telefoneum.DataValue);
        }
        else {
            cmdValidaTelefones.SetParameter("telefoneEnriquecimento1", '');
        }

        if (crmForm.all.new_telefonedois.DataValue != null) {
            cmdValidaTelefones.SetParameter("telefoneEnriquecimento2", crmForm.all.new_telefonedois.DataValue);
        }
        else {
            cmdValidaTelefones.SetParameter("telefoneEnriquecimento2", '');
        }

        if (crmForm.all.new_telefonetrs.DataValue != null) {
            cmdValidaTelefones.SetParameter("telefoneEnriquecimento3", crmForm.all.new_telefonetrs.DataValue);
        }
        else {
            cmdValidaTelefones.SetParameter("telefoneEnriquecimento3", '');
        }

        if (crmForm.all.new_telefonequatro.DataValue != null) {
            cmdValidaTelefones.SetParameter("telefoneEnriquecimento4", crmForm.all.new_telefonequatro.DataValue);
        }
        else {
            cmdValidaTelefones.SetParameter("telefoneEnriquecimento4", '');
        }

        if (crmForm.all.new_telefonecinco.DataValue != null) {
            cmdValidaTelefones.SetParameter("telefoneEnriquecimento5", crmForm.all.new_telefonecinco.DataValue);
        }
        else {
            cmdValidaTelefones.SetParameter("telefoneEnriquecimento5", '');
        }

        if (crmForm.all.emailaddress1.DataValue != null) {
            cmdValidaTelefones.SetParameter("email", crmForm.all.emailaddress1.DataValue);
        }
        else {
            cmdValidaTelefones.SetParameter("email", '');
        }

        cmdValidaTelefones.SetParameter("indicadorEnderecoNacional", crmForm.all.new_endereco_nacional.DataValue);

        var oResult = cmdValidaTelefones.Execute();

        if (!oResult.ReturnValue.Mrv.Sucesso) {
            alert(oResult.ReturnValue.Mrv.Mensagem);
            event.returnValue = false;
            return false;
        }

        // Transformar caracteres em maiusculos------------------------------------//
        var elm = document.getElementsByTagName("input");
        for (i = 0; i < elm.length; i++) {
            if (elm[i].type == "text")
                if (elm[i].DataValue != null) {
                    try {
                        elm[i].DataValue = elm[i].DataValue.toUpperCase();
                    }
                    catch (e) { }
                }
        }

        //Habilitando o campo classificação
        if (crmForm.IsDirty) {
            crmForm.all.accountclassificationcode.Disabled = false;
            crmForm.all.new_cidadeid.Disabled = false;
            crmForm.all.address1_line1.Disabled = false;
            crmForm.all.address2_line1.Disabled = false;
            crmForm.all.new_tipologradouro.Disabled = false;
            crmForm.all.new_bairro.Disabled = false;
            crmForm.all.new_estado.Disabled = false;
            crmForm.all.new_pais.Disabled = false;
            crmForm.all.new_cidadeid.Disabled = false;
        }

        if (!crmForm.all.new_tipodecliente.DataValue) {
            var ret = new_cpf_onchange0();
            event.returnValue = ret;
            return false;
        }
        else {
            var ret = new_cnpj_onchange0();
            event.returnValue = ret;
            return false;
        }

        if (crmForm.all.name.DataValue != null) {
            var nome = crmForm.all.name.DataValue;
            crmForm.all.name.DataValue = nome.replace("*", "");
        }
    } catch (error) {
        alert("Ocorreu um erro no formulário.\n" + error.description);
        event.returnValue = false;
        return false;
    }

}

function accountclassificationcode_onchange() {
    if (crmForm.all.accountclassificationcode.DataValue == 2 && crmForm.all.new_tipodecliente.DataValue == 0) {
        crmForm.SetFieldReqLevel("address1_postalcode", true);

        //pessoa fisica-----------------------------------------
        crmForm.SetFieldReqLevel("new_naturalidade", true);
        crmForm.SetFieldReqLevel("new_nacionalidade", true);
        crmForm.SetFieldReqLevel("new_profissao", true);
        crmForm.SetFieldReqLevel("new_sexo", true);
        crmForm.SetFieldReqLevel("new_estadocivil", true);
        crmForm.SetFieldReqLevel("new_cpf", true);
        crmForm.SetFieldReqLevel("new_registrogeraln", true);
        crmForm.SetFieldReqLevel("new_datadeexpedicao", true);
        crmForm.SetFieldReqLevel("new_orgaodeexpedicao", true);
        crmForm.SetFieldReqLevel("new_nomedamae", true);
        crmForm.SetFieldReqLevel("new_datadenascimento", true);

        crmForm.SetFieldReqLevel("primarycontactid", false);
        crmForm.SetFieldReqLevel("industrycode", false);
        crmForm.SetFieldReqLevel("ownershipcode", false);
        crmForm.SetFieldReqLevel("new_cnpj", false);
    }

    if (crmForm.all.accountclassificationcode.DataValue == 2 && crmForm.all.new_tipodecliente.DataValue == 1) {
        crmForm.SetFieldReqLevel("address1_postalcode", true);

        //pessoa juridica---------------------------------------
        crmForm.SetFieldReqLevel("primarycontactid", true);
        crmForm.SetFieldReqLevel("industrycode", true);
        crmForm.SetFieldReqLevel("ownershipcode", true);
        crmForm.SetFieldReqLevel("new_cnpj", true);

        crmForm.SetFieldReqLevel("new_naturalidade", false);
        crmForm.SetFieldReqLevel("new_nacionalidade", false);
        crmForm.SetFieldReqLevel("new_profissao", false);
        crmForm.SetFieldReqLevel("new_sexo", false);
        crmForm.SetFieldReqLevel("new_estadocivil", false);
        crmForm.SetFieldReqLevel("new_cpf", false);
        crmForm.SetFieldReqLevel("new_registrogeraln", false);
        crmForm.SetFieldReqLevel("new_datadeexpedicao", false);
        crmForm.SetFieldReqLevel("new_orgaodeexpedicao", false);
        crmForm.SetFieldReqLevel("new_nomedamae", false);
        crmForm.SetFieldReqLevel("new_datadenascimento", false);
    }

    // Se o tipo de cliente for prospect e cliente PJ-------------------------------------//   
    if (crmForm.all.accountclassificationcode.DataValue == 1 && crmForm.all.new_tipodecliente.DataValue == 1) {
        crmForm.all.tab1Tab.style.display = "none";
        crmForm.all.tab2Tab.style.display = "inline";

        crmForm.SetFieldReqLevel("address1_postalcode", false);

        crmForm.SetFieldReqLevel("primarycontactid", false);
        crmForm.SetFieldReqLevel("industrycode", false);
        crmForm.SetFieldReqLevel("ownershipcode", false);
        crmForm.SetFieldReqLevel("new_cnpj", false);

        crmForm.SetFieldReqLevel("new_naturalidade", false);
        crmForm.SetFieldReqLevel("new_nacionalidade", false);
        crmForm.SetFieldReqLevel("new_profissao", false);
        crmForm.SetFieldReqLevel("new_sexo", false);
        crmForm.SetFieldReqLevel("new_estadocivil", false);
        crmForm.SetFieldReqLevel("new_cpf", false);
        crmForm.SetFieldReqLevel("new_registrogeraln", false);
        crmForm.SetFieldReqLevel("new_datadeexpedicao", false);
        crmForm.SetFieldReqLevel("new_orgaodeexpedicao", false);
        crmForm.SetFieldReqLevel("new_nomedamae", false);
        crmForm.SetFieldReqLevel("new_datadenascimento", false);
    }

    // Se o tipo de cliente for prospect e cliente PF----------------------------------//   
    if (crmForm.all.accountclassificationcode.DataValue == 1 && crmForm.all.new_tipodecliente.DataValue == 0) {
        crmForm.all.tab1Tab.style.display = "inline";
        crmForm.all.tab2Tab.style.display = "none";

        crmForm.SetFieldReqLevel("address1_postalcode", false);

        crmForm.SetFieldReqLevel("primarycontactid", false);
        crmForm.SetFieldReqLevel("industrycode", false);
        crmForm.SetFieldReqLevel("ownershipcode", false);
        crmForm.SetFieldReqLevel("new_cnpj", false);

        crmForm.SetFieldReqLevel("new_naturalidade", false);
        crmForm.SetFieldReqLevel("new_nacionalidade", false);
        crmForm.SetFieldReqLevel("new_profissao", false);
        crmForm.SetFieldReqLevel("new_sexo", false);
        crmForm.SetFieldReqLevel("new_estadocivil", false);
        crmForm.SetFieldReqLevel("new_cpf", false);
        crmForm.SetFieldReqLevel("new_registrogeraln", false);
        crmForm.SetFieldReqLevel("new_datadeexpedicao", false);
        crmForm.SetFieldReqLevel("new_orgaodeexpedicao", false);
        crmForm.SetFieldReqLevel("new_nomedamae", false);
        crmForm.SetFieldReqLevel("new_datadenascimento", false);
    }

}

function name_onchange() {


}

function new_tipodecliente_onchange() {
    //Condicao no Botao SIm/NAO para pessoa física ou pessoa jurídica

    // Se o tipo de cliente for cliente e o tipo de cliente for PF----------------------------------------------------------//   
    if (crmForm.all.accountclassificationcode.DataValue == 2 && crmForm.all.new_tipodecliente.DataValue == 0) {
        crmForm.all.tab1Tab.style.display = "inline";
        crmForm.all.tab2Tab.style.display = "none";

        crmForm.SetFieldReqLevel("address1_postalcode", true);

        //pessoa fisica-----------------------------------------
        crmForm.SetFieldReqLevel("new_naturalidade", true);
        crmForm.SetFieldReqLevel("new_nacionalidade", true);
        crmForm.SetFieldReqLevel("new_profissao", true);
        crmForm.SetFieldReqLevel("new_sexo", true);
        crmForm.SetFieldReqLevel("new_estadocivil", true);
        crmForm.SetFieldReqLevel("new_cpf", true);
        crmForm.SetFieldReqLevel("new_registrogeraln", true);
        crmForm.SetFieldReqLevel("new_datadeexpedicao", true);
        crmForm.SetFieldReqLevel("new_orgaodeexpedicao", true);
        crmForm.SetFieldReqLevel("new_nomedamae", true);
        crmForm.SetFieldReqLevel("new_datadenascimento", true);

        crmForm.SetFieldReqLevel("primarycontactid", false);
        crmForm.SetFieldReqLevel("industrycode", false);
        crmForm.SetFieldReqLevel("ownershipcode", false);
        crmForm.SetFieldReqLevel("new_cnpj", false);

        crmForm.all.new_grupo_contas.DataValue = "ZPFI";
    }

    // Se o tipo de cliente for cliente e o tipo de cliente for PJ----------------------------------------------------------//   
    if (crmForm.all.accountclassificationcode.DataValue == 2 && crmForm.all.new_tipodecliente.DataValue == 1) {
        crmForm.all.tab1Tab.style.display = "none";
        crmForm.all.tab2Tab.style.display = "inline";

        crmForm.SetFieldReqLevel("address1_postalcode", true);

        //pessoa juridica---------------------------------------
        crmForm.SetFieldReqLevel("primarycontactid", true);
        crmForm.SetFieldReqLevel("industrycode", true);
        crmForm.SetFieldReqLevel("ownershipcode", true);
        crmForm.SetFieldReqLevel("new_cnpj", true);

        crmForm.SetFieldReqLevel("new_naturalidade", false);
        crmForm.SetFieldReqLevel("new_nacionalidade", false);
        crmForm.SetFieldReqLevel("new_profissao", false);
        crmForm.SetFieldReqLevel("new_sexo", false);
        crmForm.SetFieldReqLevel("new_estadocivil", false);
        crmForm.SetFieldReqLevel("new_cpf", false);
        crmForm.SetFieldReqLevel("new_registrogeraln", false);
        crmForm.SetFieldReqLevel("new_datadeexpedicao", false);
        crmForm.SetFieldReqLevel("new_orgaodeexpedicao", false);
        crmForm.SetFieldReqLevel("new_nomedamae", false);
        crmForm.SetFieldReqLevel("new_datadenascimento", false);
        crmForm.all.new_grupo_contas.DataValue = "ZPJU";
    }

    // Se o tipo de cliente for prospect e cliente PJ-------------------------------------//   
    if (crmForm.all.accountclassificationcode.DataValue == 1 && crmForm.all.new_tipodecliente.DataValue == 1) {
        crmForm.all.tab1Tab.style.display = "none";
        crmForm.all.tab2Tab.style.display = "inline";

        crmForm.SetFieldReqLevel("address1_postalcode", false);

        crmForm.SetFieldReqLevel("primarycontactid", false);
        crmForm.SetFieldReqLevel("industrycode", false);
        crmForm.SetFieldReqLevel("ownershipcode", false);
        crmForm.SetFieldReqLevel("new_cnpj", false);

        crmForm.SetFieldReqLevel("new_naturalidade", false);
        crmForm.SetFieldReqLevel("new_nacionalidade", false);
        crmForm.SetFieldReqLevel("new_profissao", false);
        crmForm.SetFieldReqLevel("new_sexo", false);
        crmForm.SetFieldReqLevel("new_estadocivil", false);
        crmForm.SetFieldReqLevel("new_cpf", false);
        crmForm.SetFieldReqLevel("new_registrogeraln", false);
        crmForm.SetFieldReqLevel("new_datadeexpedicao", false);
        crmForm.SetFieldReqLevel("new_orgaodeexpedicao", false);
        crmForm.SetFieldReqLevel("new_nomedamae", false);
        crmForm.SetFieldReqLevel("new_datadenascimento", false);
        crmForm.all.new_grupo_contas.DataValue = "ZPJU";
    }

    // Se o tipo de cliente for prospect e cliente PF----------------------------------//   
    if (crmForm.all.accountclassificationcode.DataValue == 1 && crmForm.all.new_tipodecliente.DataValue == 0) {
        crmForm.all.tab1Tab.style.display = "inline";
        crmForm.all.tab2Tab.style.display = "none";

        crmForm.SetFieldReqLevel("address1_postalcode", false);

        crmForm.SetFieldReqLevel("primarycontactid", false);
        crmForm.SetFieldReqLevel("industrycode", false);
        crmForm.SetFieldReqLevel("ownershipcode", false);
        crmForm.SetFieldReqLevel("new_cnpj", false);

        crmForm.SetFieldReqLevel("new_naturalidade", false);
        crmForm.SetFieldReqLevel("new_nacionalidade", false);
        crmForm.SetFieldReqLevel("new_profissao", false);
        crmForm.SetFieldReqLevel("new_sexo", false);
        crmForm.SetFieldReqLevel("new_estadocivil", false);
        crmForm.SetFieldReqLevel("new_cpf", false);
        crmForm.SetFieldReqLevel("new_registrogeraln", false);
        crmForm.SetFieldReqLevel("new_datadeexpedicao", false);
        crmForm.SetFieldReqLevel("new_orgaodeexpedicao", false);
        crmForm.SetFieldReqLevel("new_nomedamae", false);
        crmForm.SetFieldReqLevel("new_datadenascimento", false);
        crmForm.all.new_grupo_contas.DataValue = "ZPFI";
    }

}

function emailaddress1_onchange() {


}

function new_endereco_nacional_onchange() {
    crmForm.TratarEnderecoNacional();

    // Limpa os campos de endereço
    crmForm.all.address1_postalcode.DataValue = null;
    crmForm.all.address1_line1.DataValue = null;
    crmForm.all.new_complemento.DataValue = null;
    crmForm.all.address2_line1.DataValue = null;
    crmForm.all.new_tipologradouro.SelectedIndex = 0;
    crmForm.all.new_bairro.DataValue = null;
    crmForm.all.new_numero.DataValue = null;

}

function address1_postalcode_onchange() {
    var campo = event.srcElement;
    crmForm.ValidarCEP(campo);

}

function new_endereco_confere_onchange() {
    crmForm.TrataEnderecoConfere();

}

function address1_line1_onchange() {
    crmForm.ResumirEndereco();

}

function new_tipologradouro_onchange() {
    crmForm.ResumirEndereco();

}

function new_cidadeid_onchange() {
    crmForm.all.telephone1.value = "";

    if (crmForm.all.new_cidadeid.DataValue == null)
        crmForm.all.new_estado.Disabled = false;

    var valorlookupcidade = new Array();
    valorlookupcidade = crmForm.all.new_cidadeid.DataValue;

    if (valorlookupcidade != null) {
        var cmdDadosCidade = new RemoteCommand("MrvService", "retornarEstadoEDDD", "/MRVCustomizations/");
        cmdDadosCidade.SetParameter("cidadeId", valorlookupcidade[0].id);
        var oResultado = cmdDadosCidade.Execute();
        if (oResultado.Success) {
            // Atribui o BRASIL como item selecionado no campo Pais
            crmForm.all.new_pais.DataValue = Pais.BRASIL;
            crmForm.all.new_pais.Disabled = true;

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
            crmForm.all.new_estado.Disabled = true;
        }
    }

}

function new_estado_onchange() {


}

function new_pais_onchange() {
    crmForm.TrataPais();

}

function telephone1_onchange() {
    crmForm.BuscaDadosTelefone("2", "telephone1");

}

function address1_telephone3_onchange() {
    crmForm.BuscaDadosTelefone("1", "address1_telephone3");

}

function telephone2_onchange() {
    crmForm.BuscaDadosTelefone("2", "telephone2");

}

function fax_onchange() {
    crmForm.BuscaDadosTelefone("3", "fax");

}

function new_outrotelefone_onchange() {
    crmForm.BuscaDadosTelefone("4", "new_outroTelefone");

}

function new_telefoneum_onchange() {
    if (event.srcElement.DataValue != null && event.srcElement.DataValue == "..") {
        retorno = openStdDlg("/MrvWeb/Phone/Default.aspx?tipo=4", null, 250, 250);
        if (typeof (retorno) != "undefined") {
            event.srcElement.DataValue = retorno;
        }
        else
            event.srcElement.DataValue = "";
    }
    else if (event.srcElement.DataValue != null && event.srcElement.DataValue != "..") {
        alert("Digite apenas ..");
        event.srcElement.DataValue = "";
        event.srcElement.SetFocus();
    }

}

function new_telefonedois_onchange() {
    if (event.srcElement.DataValue != null && event.srcElement.DataValue == "..") {
        retorno = openStdDlg("/MrvWeb/Phone/Default.aspx?tipo=4", null, 250, 250);
        if (typeof (retorno) != "undefined") {
            event.srcElement.DataValue = retorno;
        }
        else
            event.srcElement.DataValue = "";
    }
    else if (event.srcElement.DataValue != null && event.srcElement.DataValue != "..") {
        alert("Digite apenas ..");
        event.srcElement.DataValue = "";
        event.srcElement.SetFocus();
    }

}

function new_telefonetrs_onchange() {
    if (event.srcElement.DataValue != null && event.srcElement.DataValue == "..") {
        retorno = openStdDlg("/MrvWeb/Phone/Default.aspx?tipo=4", null, 250, 250);
        if (typeof (retorno) != "undefined") {
            event.srcElement.DataValue = retorno;
        }
        else
            event.srcElement.DataValue = "";
    }
    else if (event.srcElement.DataValue != null && event.srcElement.DataValue != "..") {
        alert("Digite apenas ..");
        event.srcElement.DataValue = "";
        event.srcElement.SetFocus();
    }

}

function new_telefonequatro_onchange() {
    if (event.srcElement.DataValue != null && event.srcElement.DataValue == "..") {
        retorno = openStdDlg("/MrvWeb/Phone/Default.aspx?tipo=4", null, 250, 250);
        if (typeof (retorno) != "undefined") {
            event.srcElement.DataValue = retorno;
        }
        else
            event.srcElement.DataValue = "";
    }
    else if (event.srcElement.DataValue != null && event.srcElement.DataValue != "..") {
        alert("Digite apenas ..");
        event.srcElement.DataValue = "";
        event.srcElement.SetFocus();
    }

}

function new_telefonecinco_onchange() {
    if (event.srcElement.DataValue != null && event.srcElement.DataValue == "..") {
        retorno = openStdDlg("/MrvWeb/Phone/Default.aspx?tipo=4", null, 250, 250);
        if (typeof (retorno) != "undefined") {
            event.srcElement.DataValue = retorno;
        }
        else
            event.srcElement.DataValue = "";
    }
    else if (event.srcElement.DataValue != null && event.srcElement.DataValue != "..") {
        alert("Digite apenas ..");
        event.srcElement.DataValue = "";
        event.srcElement.SetFocus();
    }

}

function new_investimento_onchange() {
    //Bit - sim - não - Ocultar nome do campo e campo do formulario

    if (crmForm.all.new_investimento.DataValue == false) {
        crmForm.all.new_bairroparainvestimento_c.style.visibility = 'hidden';
        crmForm.all.new_bairroparainvestimento_d.style.visibility = 'hidden';
    }
    else {
        crmForm.all.new_bairroparainvestimento_c.style.visibility = 'visible';
        crmForm.all.new_bairroparainvestimento_d.style.visibility = 'visible';
    }

}

function new_adesao_boleto_digital_onchange() {
    crmForm.AdesaoBoletoChange();

}

function new_orgao_expedicao_onchange() {
    if (crmForm.all.new_orgao_expedicao.DataValue == null) {
        crmForm.SetFieldReqLevel("new_uf_orgao_expedicao", false);
        crmForm.all.new_uf_orgao_expedicao.DataValue = null;
    }
    else {
        crmForm.SetFieldReqLevel("new_uf_orgao_expedicao", true);
    }

}

function new_cpf_onchange() {
    var erro = '';

    function AddMascara(cpf) {
        if (typeof (cpf) != "undefined" && cpf != null) {
            var sTmp = cpf.replace(/[^0-9]/g, "");

            if (sTmp.length == 11) {
                crmForm.all.new_cpf.DataValue = sTmp.substr(0, 3) + "." + sTmp.substr(3, 3) + "." + sTmp.substr(6, 3) + "-" + sTmp.substr(9, 2);
                cpf = '';
                return true;
            }
            else {
                crmForm.all.new_cpf.DataValue = null;
                alert("Campo fora da faixa de dígitos sequenciais!");
                crmForm.all.new_cpf.SetFocus();
                return false;
            }
        }
    }

    function RemoteCPF(cpf, changeCPF) {
        var oCmd = new RemoteCommand("MrvService", "ValidCnpjOrCpf", "/MRVCustomizations/");

        oCmd.SetParameter("pNumber", cpf.toString());

        if (changeCPF)
            oCmd.SetParameter("pType", "1");
        else
            oCmd.SetParameter("pType", "0");

        var oResult = oCmd.Execute();

        if (oResult.Success) {
            if (!oResult.ReturnValue.Mrv.Valid) {
                alert(oResult.ReturnValue.Mrv.Mensagem);
                return oResult.ReturnValue.Mrv.Valid;
            }
        }
        else {
            alert("Erro. Contate o administrador.");
            return false;
        }
    }

    if (crmForm.all.new_cpf.DataValue != null || crmForm.all.new_cnpj.DataValue != null) {
        var Number = (!crmForm.all.new_tipodecliente.DataValue) ? crmForm.all.new_cpf.DataValue : crmForm.all.new_cnpj.DataValue;

        if (AddMascara(crmForm.all.new_cpf.DataValue)) {
            return RemoteCPF(crmForm.all.new_cpf.DataValue, crmForm.all.new_cpf.IsDirty);
        }
    }

}

function new_nacionalidade_onchange() {
    if (crmForm.all.new_nacionalidade.DataValue == null || crmForm.all.new_nacionalidade.DataValue == 2) {
        crmForm.all.new_naturalidadeid.DataValue = null;
        crmForm.all.new_naturalidadeid.Disabled = true;
        if (crmForm.FormType == TypeCreate || crmForm.FormType == TypeUpdate) {
            crmForm.all.new_naturalidadeid.ForceSubmit = true;
        }
    }
    else {
        crmForm.all.new_naturalidadeid.Disabled = false;
    }

}

function new_sexo_onchange() {


}

function new_temfilhos_onchange() {
    if (crmForm.all.new_temfilhos.DataValue == 1) {
        crmForm.all.new_quantidadedefilhos_c.style.visibility = "visible";
        crmForm.all.new_quantidadedefilhos_d.style.visibility = "visible";
    }
    else {
        crmForm.all.new_quantidadedefilhos.DataValue = null;
        crmForm.all.new_quantidadedefilhos_c.style.visibility = "hidden";
        crmForm.all.new_quantidadedefilhos_d.style.visibility = "hidden";
    }

}

function transactioncurrencyid_onchange() {
    if (crmForm.all.transactioncurrencyid.DataValue == null)
        crmForm.SetaMoeda("");

}

function new_renda_pessoal_onchange() {
    //cálculo para saber a faxia salarial 
    var SalBase = 415;
    var VlrSal = crmForm.all.new_renda_pessoal.DataValue;
    var VlrMedio = parseInt(VlrSal / SalBase);

    if (VlrMedio < 30) {
        switch (VlrMedio) {
            case 0:
            case 1:
            case 2:
                crmForm.all.new_faixasalarial.DataValue = 1;
                break;

            case 3:
            case 4:
            case 5:
                crmForm.all.new_faixasalarial.DataValue = 2;
                break;

            case 6:
            case 7:
            case 8:
                crmForm.all.new_faixasalarial.DataValue = 3;
                break;

            case 9:
            case 10:
            case 11:
                crmForm.all.new_faixasalarial.DataValue = 4;
                break;

            case 12:
            case 13:
            case 14:
                crmForm.all.new_faixasalarial.DataValue = 5;
                break;

            case 15:
            case 16:
            case 17:
            case 18:
            case 19:
                crmForm.all.new_faixasalarial.DataValue = 6;
                break;

            case 20:
            case 21:
            case 22:
            case 23:
            case 24:
                crmForm.all.new_faixasalarial.DataValue = 7;
                break;

            case 25:
            case 26:
            case 27:
            case 28:
            case 29:
                crmForm.all.new_faixasalarial.DataValue = 8;
                break;

            default:
                crmForm.all.new_faixasalarial.DataValue = 0;
                break;
        }
    }
    else
        crmForm.all.new_faixasalarial.DataValue = 9;

}

function new_cnpj_onchange() {
    var erro = '';
    function AddMascara(cnpj) {
        if (typeof (cnpj) != "undefined" && cnpj != null) {
            var sTmp = crmForm.all.new_cnpj.DataValue.replace(/[^0-9]/g, "");

            if (sTmp.length != 14) {
                //crmForm.all.new_cnpj.DataValue = '';
                alert("Campo fora da faixa de dígitos sequenciais!");
            }
            else {
                if (sTmp.length == 14) {
                    crmForm.all.new_cnpj.DataValue = sTmp.substr(0, 2) + "." + sTmp.substr(2, 3) + "." + sTmp.substr(5, 3) + "/" + sTmp.substr(8, 4) + "-" + sTmp.substr(12, 2);
                }
            }
        }
    }

    //Válida se o CPF existe
    function RemoteCPF(cpf, changeCPF) {
        var oCmd = new RemoteCommand("MrvService", "ValidCnpjOrCpf", "/MRVCustomizations/");
        oCmd.SetParameter("pNumber", cpf.toString());
        if (changeCPF)
            oCmd.SetParameter("pType", "1");
        else
            oCmd.SetParameter("pType", "0");

        var oResult = oCmd.Execute();
        if (oResult.Success) {
            if (oResult.ReturnValue.Mrv.Valid) {
                if (oResult.ReturnValue.Mrv.Exist.toString() == "true") {
                    if (oResult.ReturnValue.Mrv.Type.toString() == "Cliente") {
                        alert("Atenção\n" + oResult.ReturnValue.Mrv.Nome.toString() + " já está cadastrado com este CNPJ como um Cliente " + oResult.ReturnValue.Mrv.Status.toString());
                    }
                    else
                        alert("Atenção\n" + oResult.ReturnValue.Mrv.Nome.toString() + " já está cadastrado com este CNPJ como um Cliente Potencial");


                    return false;
                }
                else
                    return true;
            }
            else {
                alert(oResult.ReturnValue.Mrv.Mensagem);
                return false;
            }
        }
        else {
            alert("Erro. Contate o administrador.");
            return false;
        }
    }

    if (crmForm.all.new_cpf.DataValue != null || crmForm.all.new_cnpj.DataValue != null) {
        var _isChangeCPF = crmForm.all.new_cnpj.IsDirty;
        var Number = '';
        if (!crmForm.all.new_tipodecliente.DataValue)
            Number = crmForm.all.new_cpf.DataValue;
        else
            Number = crmForm.all.new_cnpj.DataValue;

        AddMascara(crmForm.all.new_cnpj.DataValue);
        var ret = RemoteCPF(crmForm.all.new_cnpj.DataValue, _isChangeCPF);
        return ret;
    }

}

function new_exinscricaomunicipal_onchange() {
    //condição do botão sim/não para a inscrição municipal
    if (crmForm.all.new_exinscricaomunicipal.DataValue == 1) {
        crmForm.all.new_inscricaomunicipal_c.style.visibility = "visible";
        crmForm.all.new_inscricaomunicipal_d.style.visibility = "visible";
        crmForm.all.new_inscricaomunicipal.setAttribute("req", 2);
        crmForm.all.new_inscricaomunicipal_c.className = "req";
    }
    else {
        crmForm.all.new_inscricaomunicipal.DataValue = null;
        crmForm.all.new_inscricaomunicipal.setAttribute("req", 0);
        crmForm.all.new_inscricaomunicipal_c.className = "n";
        crmForm.all.new_inscricaomunicipal_c.style.visibility = "hidden";
        crmForm.all.new_inscricaomunicipal_d.style.visibility = "hidden";
    }

}

function new_exinscricaoestadual_onchange() {
    //condição do botão sim/não para a inscrição estadual
    if (crmForm.all.new_exinscricaoestadual.DataValue == 1) {
        crmForm.all.new_inscricaoestadual_c.style.visibility = "visible";
        crmForm.all.new_inscricaoestadual_d.style.visibility = "visible";
        crmForm.all.new_inscricaoestadual.setAttribute("req", 2);
        crmForm.all.new_inscricaoestadual_c.className = "req";
    }
    else {
        crmForm.all.new_inscricaoestadual.DataValue = null;
        crmForm.all.new_inscricaoestadual.setAttribute("req", 0);
        crmForm.all.new_inscricaoestadual_c.className = "n";
        crmForm.all.new_inscricaoestadual_c.style.visibility = "hidden";
        crmForm.all.new_inscricaoestadual_d.style.visibility = "hidden";
    }

}

function revenue_onchange() {
    //cálculo para saber a faxia salarial 
    var SalBase = 415;
    var VlrSal = (crmForm.all.revenue.DataValue != null) ? crmForm.all.revenue.DataValue : "0";
    var VlrMedio = parseInt((VlrSal / 12) / SalBase);

    if (VlrMedio < 30) {
        switch (VlrMedio) {
            case 0:
            case 1:
            case 2:
                crmForm.all.new_faixasalarial.DataValue = 1;
                break;

            case 3:
            case 4:
            case 5:
                crmForm.all.new_faixasalarial.DataValue = 2;
                break;

            case 6:
            case 7:
            case 8:
                crmForm.all.new_faixasalarial.DataValue = 3;
                break;

            case 9:
            case 10:
            case 11:
                crmForm.all.new_faixasalarial.DataValue = 4;
                break;

            case 12:
            case 13:
            case 14:
                crmForm.all.new_faixasalarial.DataValue = 5;
                break;

            case 15:
            case 16:
            case 17:
            case 18:
            case 19:
                crmForm.all.new_faixasalarial.DataValue = 6;
                break;

            case 20:
            case 21:
            case 22:
            case 23:
            case 24:
                crmForm.all.new_faixasalarial.DataValue = 7;
                break;

            case 25:
            case 26:
            case 27:
            case 28:
            case 29:
                crmForm.all.new_faixasalarial.DataValue = 8;
                break;

            default:
                crmForm.all.new_faixasalarial.DataValue = 0;
                break;
        }
    }
    else
        crmForm.all.new_faixasalarial.DataValue = 9;

}

function new_cidade_midia_id_onchange() {
    crmForm.all.new_midiaid.FireOnChange();

}

function new_midiaid_onchange() {
    function FilterLookup(attribute, url, param) {
        if (param != null)
            url += '?' + param;

        oImg = eval('attribute' + '.parentNode.childNodes[0]');
        oImg.onclick = function () {
            retorno = openStdDlg(url, null, 600, 450);
            if (typeof (retorno) != "undefined") {
                strValues = retorno.split('*|*');
                var lookupData = new Array();
                lookupItem = new Object();
                lookupItem.id = "{" + strValues[1] + "}";
                lookupItem.type = parseInt(strValues[2]);
                lookupItem.name = strValues[0];
                lookupData[0] = lookupItem;
                attribute.DataValue = lookupData;
                attribute.FireOnChange();
            }
        };
    }

    var IdCidade = "";
    var filterDefault = "false";
    if (crmForm.all.new_cidade_midia_id.DataValue != null) {
        IdCidade = crmForm.all.new_cidade_midia_id.DataValue[0].id;
        filterDefault = "true";
    }
    else {
        IdCidade = "";
        filterDefault = "false";
    }

    if (IdCidade != "")
        IdCidade = IdCidade.substr(1, IdCidade.length - 2);

    var oParam = "objectTypeCode=10083&filterDefault=" + filterDefault + "&attributesearch=new_name&new_cidadeid=" + IdCidade;

    FilterLookup(crmForm.all.new_midiaid, "/MRVWeb/FilterLookup/FilterLookup.aspx", oParam);

}

function new_possuiimovel_onchange() {
    if (crmForm.all.new_possuiimovel.DataValue == 1) {
        crmForm.all.new_motivodacompra.Disabled = false;
        crmForm.all.new_motivodanaocompra.DataValue = null;
        crmForm.all.new_motivodanaocompra.Disabled = true;
    }
    else {
        crmForm.all.new_motivodanaocompra.Disabled = false;
        crmForm.all.new_motivodacompra.DataValue = null;
        crmForm.all.new_motivodacompra.Disabled = true;
    }

}

function new_outraconstrutora_onchange() {
    if (crmForm.all.new_outraconstrutora.DataValue == 0) {
        crmForm.all.new_construtorasid_c.style.visibility = 'hidden';
        crmForm.all.new_construtorasid_d.style.visibility = 'hidden';
    }
    else {
        crmForm.all.new_construtorasid_c.style.visibility = 'visible';
        crmForm.all.new_construtorasid_d.style.visibility = 'visible';
    }

}

function new_pesquisounainternet_onchange() {
    if (crmForm.all.new_pesquisounainternet.DataValue == 0) {
        crmForm.all.new_qualosite_c.style.visibility = 'hidden';
        crmForm.all.new_qualosite_d.style.visibility = 'hidden';
    }
    else {
        crmForm.all.new_qualosite_c.style.visibility = 'visible';
        crmForm.all.new_qualosite_d.style.visibility = 'visible';
    }

}

