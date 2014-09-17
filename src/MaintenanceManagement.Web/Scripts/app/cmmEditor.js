(function () {
    'use strict';

    cmmApp.directive('cmmEditor', function () {
        return {
            link: function (scope, element, attrs) {
                scope.getFieldType = function(e) {
                    if (!e.dataType) {
                        return { type: 'text' };
                    }

                    if (typeof e.dataType == 'string') {
                        return { type: e.dataType };
                    }

                    return { type: 'dropdown', resource: e.dataType.resource };
                };

                scope.isEditable = function(s) {
                    return s.isEditable == undefined || s.isEditable == true;
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