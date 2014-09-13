(function () {
    'use strict';

    cmmApp.directive('cmmEditor', function () {
        return {
            link: function (scope, element, attrs) {
                scope.getFieldType = function(e) {
                    if (!e.dataType) {
                        return 'text';
                    }

                    if (typeof e.dataType == 'string') {
                        return e.dataType;
                    }

                    scope.resource = e.resource;
                    return 'dropDown';
                };
            },
            scope: {
                model: '=',
                schema: '='
            },
            restrict: 'E',
            templateUrl: '/Template/Editor'
        };
    });
}());