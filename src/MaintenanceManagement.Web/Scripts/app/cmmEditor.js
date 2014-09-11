(function () {
    'use strict';

    cmmApp.directive('cmmEditor', function () {
        return {
            link: function (scope, element, attrs) {               
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