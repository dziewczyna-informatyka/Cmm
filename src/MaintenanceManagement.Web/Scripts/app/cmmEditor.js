(function () {
    'use strict';

    cmmApp.directive('cmmEditor', function () {
        return {
            link: function (scope, element, attrs) {

            },
            scope: {
                model: '=model',
                schema: '=schema'
            },
            templateUrl: '/Template/Editor'
        };
    });
}());