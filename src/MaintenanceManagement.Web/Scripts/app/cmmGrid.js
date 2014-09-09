(function () {
    'use strict';

    cmmApp.directive('cmmGrid', function () {
        return {
            link: function (scope, element, attrs) {
                element.find("[data-rel='tooltip']").tooltip();
            },
            restrict: 'E',
            templateUrl: '/Template/Grid'
        }
    });
}());