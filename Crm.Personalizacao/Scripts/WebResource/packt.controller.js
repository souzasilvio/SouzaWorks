app.controller('packtController', function
    ($scope, packtCrmService) {
    $scope.dataLoading = true;
    packtCrmService.loadAttributesFromCurrentEntity().then(
        function (result)
        {
            if (result.status == 200)
            {
                $scope.attributes = result.data;
            }
            else
            {
                alert("Ocorreu um erro ao carregar atributos. " + result.status);
            }
        }).finally(function () {
            $scope.dataLoading = false;
        });
});