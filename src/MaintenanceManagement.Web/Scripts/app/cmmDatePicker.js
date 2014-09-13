(function () {
    'use strict';

    cmmApp.directive('cmmDatePicker', function () {
        return {
            link: function (scope, element, attrs) {
                $(element)
                    .datepicker({ format: 'dd/mm/yyyy' })
                    .on('changeDate', function () {
                        $(element).datepicker('hide');
                    });
            },
            restrict: 'A'
        };
    });
}());