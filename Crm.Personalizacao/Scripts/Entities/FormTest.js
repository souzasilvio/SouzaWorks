//Script to entity FormTest. After add this webresource configure dependence to script CRM.Forms.js
var CRM = CRM || {};
CRM.FormTest = {
   
    OnLoad: function (context)
    {

        CRM.FormTest.CreateTestData();
            
    },

    CreateTestData: function ()
    {
        //Create Contact. Check if record exists first
        parent.Xrm.WebApi.retrieveMultipleRecords("contact", "?$select=firstname&$top=1&$filter=firstname eq 'John' and lastname eq 'Doe'").then(
            function success(result) {
                if (result.entities.length === 0) {
                    //Create a record if not exist
                    var contato = { 'firstname': 'John', 'lastname': 'Doe' };
                    parent.Xrm.WebApi.createRecord("contact", contato).then(null, null);
                }
            },
            null);
    },

    OnSave: function (context) {
        try {
           
        }
        catch (error) {
            alert(error.description);
        }
    },

    
    functionsOnChange: function ()
    {
        //get the text of selected option control
        var fName = CRM.Forms.GetAttributeText('crmarch_functions');
        switch (fName) {
            case 'AddFormNotification':
                CRM.Forms.AddFormNotification('This function show a notification on your form.', 'INFO', 'MSG01');
                break;
            case 'ClearFormNotification':
                CRM.Forms.ClearFormNotification('MSG01');
                Xrm.Utility.alertDialog('Mesage was cleared.')
                break;

            case 'GetUserName':
                var name = CRM.Forms.GetUserName();
                Xrm.Utility.alertDialog('User Name:' + name);
                break;
            case 'GetUserId':
                var valor = CRM.Forms.GetUserId();
                Xrm.Utility.alertDialog('User Id:' + valor);
                break;
            case 'ShowConfirmDialog':
                CRM.Forms.ShowConfirmDialog('Confirm something?',
                    function () { Xrm.Utility.alertDialog('Yes selected!') },
                    function () { Xrm.Utility.alertDialog('No selected!') }
                );
                break;

            case 'RetrieveRecord':
                //Here I use lastest CRM client api to check if a John Doe contact exists.
                CRM.Forms.RetrieveMultiple('contact', "?$select=firstname,lastname&$filter=firstname eq 'John' and lastname eq 'Doe'",
                    function (result) {
                        if (result.entities.length > 0) {
                            var id = result.entities[0].contactid;
                            Xrm.Utility.alertDialog('Contact Retrieved: ' + id);
                        }                
                    }
                );

                break;

            case 'RetrieveMultiple':
                //Create more contact with firstname equal John if youu wish
                CRM.Forms.RetrieveMultiple('contact', "?$select=firstname,lastname&$filter=firstname eq 'John'", this.ProcessResult);
                break;

            case 'UserInTeam':
                //You should create Admin Team First. 
                CRM.Forms.UserInTeam('Admin',
                    function (result) {
                        if (result.entities.length > 0) {
                            Xrm.Utility.alertDialog('User Belong to Team Admin. Do Something in form here.');
                        }
                        else {
                            Xrm.Utility.alertDialog('User Not Belong to Admin team. Add user to team and test again.');
                        }
                    }
                );
                break;

            case 'QueryApiSinc':
                this.QueryApiSinc();
                break;

            case 'UserInAnyTeam':
                this.UserInAnyTeam();
                break;
            case 'CallCustomAPIAsinc':
                this.CallCustomAPIAsinc();
                break;
            
        }
    },

    ProcessResult: function (result) {
        if (result.entities.length > 0) {
            Xrm.Utility.alertDialog('Records Retrieved: ' + result.entities.length);
        }
    },

    QueryApiSinc: function () {
        //Get a record in sincmode and wait result to do something.
        var query = "contacts?$select=firstname,lastname&$filter=firstname eq 'John' and lastname eq 'Doe'";
        var dados = CRM.Forms.QueryApiSinc(query);
        if (dados != null && dados.value.length > 0) {
            Xrm.Utility.alertDialog('Contact Retrieved in SincMode : ' + dados.value[0].firstname + ' ' + dados.value[0].lastname);
        }
    },

    UserInAnyTeam: function () {
        //If Records returned user belong to one or more teams
        CRM.Forms.UserInAnyTeam('Admin;Team2', this.ProcessResult);
    },

    CallCustomAPIAsinc: function () {
        var action = "sales/getaddress/30570350";
        CRM.Forms.CallCustomAPIAsinc(URL_CUSTOM_API, action, CRM.FormTest.GetAddressComplete);
    },

    GetAddressComplete: function ()
    {
        if (this.readyState === 4) {
            if (this.status === 200) {
                var result = JSON.parse(this.response);
                Xrm.Utility.alertDialog('Address Returned:' +
                    result.Logradouro + ", " + result.Bairro + ", " + result.Cidade + ", " + result.Estado);
            } else {
                Xrm.Utility.alertDialog(this.statusText);
            }
        }
    }

}