(function () {
    'use strict';

    cmmApp.directive('cmmGrid', ['apiClient', function (apiClient) {
        return {
            link: function (scope, element, attrs) {
                element.find("[data-rel='tooltip']").tooltip();
               
                apiClient.read(scope.resource).then(function (data) {
                    scope.dataSource = data;
                });

            },
            scope: {
                resource: '=resource',
                schema: '=schema'
            },
            restrict: 'E',
            templateUrl: '/Template/Grid'
        }
    }]);
}());