(function () {
    'use strict';

    cmmApp.directive('cmmGrid', ['apiClient', function (apiClient) {
        return {
            link: function (scope, element, attrs) {                               
                apiClient.read(scope.resource).then(function (data) {
                    scope.dataSource = data;

                    element.find("[data-rel='tooltip']").tooltip();
                });

                scope.onEditClick = function(entity) {

                };

                scope.onDeleteClick = function(entity) {
                    if (confirm('are you sure')) {
                        apiClient.delete(scope.resource, entity.id).then(function() {
                            scope.dataSource.splice(scope.dataSource.indexOf(entity), 1);
                        });
                    }
                };

                scope.onAddClick = function(entity) {

                };

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