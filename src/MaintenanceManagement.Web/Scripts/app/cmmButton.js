(function () {
    'use strict';

    cmmApp.directive('cmmButton', [function () {
        return {
            link: function (scope, element, attrs) {
                console.log(scope.icon);

                element.ready(function () {
                    $(element).find("button").attr('title', scope.tooltip).tooltip();
                });
            },
            scope: {
                icon: '@',
                text: '@',
                tooltip: '@',
                extraClass: '@extraClass'
            },
            restrict: 'E',
            template: '<button title="" data-toggle="tooltip" data-placement="top" class="btn btn-default {{extraClass}}"><i class="fa fa-{{icon}}" /> {{text}}</button>'
        }
    }]);
}());