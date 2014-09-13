(function () {
    'use strict';

    cmmApp.directive('cmmDropDown', ['apiClient', function (apiClient) {
        return {
            link: function (scope, element, attrs) {
                var select = $(element).find('select');

                apiClient.get(scope.resource).then(function(data) {
                    scope.dataSource = data;
                });
                
                scope.$watch('model', function() {
                    if (scope.model) {
                        select.val(scope.model.id);
                    }
                });

                select.on('change', function(e) {
                    for (var i in scope.dataSource) {
                        if (scope.dataSource[i].id == select.val()) {
                            scope.model = scope.dataSource[i];
                        }
                    }
                });
            },
            restrict: 'E',
            scope: {
                resource: '=',
                model: '='
            },
            templateUrl: '/Template/DropDown'
        };
    }]);
}());