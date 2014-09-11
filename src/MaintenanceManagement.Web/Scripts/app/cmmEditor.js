(function () {
    'use strict';

    cmmApp.directive('cmmEditor', function () {
        return {
            link: function (scope, element, attrs) {
                console.log(scope.schema);
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